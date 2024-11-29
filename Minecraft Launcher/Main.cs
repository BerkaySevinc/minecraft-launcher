using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Version;



// email validation

namespace Beko_S_Mc_Launcher
{
    public partial class Main : Form
    {

        #region Form

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
        );

        public Main()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        #endregion
        #region Form Dragging

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        #endregion
        #region Main Buttons

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion


        CMLauncher launcher;
        private void Main_Load(object sender, EventArgs e)
        {
            lblProgress.Text = "";

            launcher = new CMLauncher(new MinecraftPath());

            MVersionCollection versions = launcher.GetAllVersions();
            comboVersions.Items.AddRange(versions.Select(v => v.Name).ToArray());  
        }


        private void cbxPremium_CheckedChanged(object sender)
        {
            panelPremium.Visible = cbxPremium.Checked;
            panelOffline.Visible = !cbxPremium.Checked;
        }



        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (comboVersions.Text == "") return;

            MSession session;

            if (cbxPremium.Checked)
            {
                if (tbxEmail.Text == "") return;
                if (tbxPassword.Text == "") return;

                string email = tbxEmail.Text.Trim();
                string password = tbxPassword.Text.Trim();

                MLoginResponse result = new MLogin().Authenticate(email, password);

                if (!result.IsSuccess)
                {
                    MessageBox.Show(result.Result.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                session = result.Session;
            }
            else
            {
                if (tbxUsername.Text == "") return;
                string username = tbxUsername.Text.Trim();

                session = MSession.GetOfflineSession(username);
            }
            // Create Session


            Thread thread = new Thread(() => Launch(session, comboVersions.Text));
            thread.IsBackground = true;
            thread.Start();
            // Launch In New Thread
        }

        private void Launch(MSession session, string Version)
        {
            launcher.FileChanged += (e) =>
            {
                lblProgress.Text = "Loading " + e.FileKind + "...";

                if (e.TotalFileCount == 0) return;
                int percentage = Convert.ToInt32(e.ProgressedFileCount / Convert.ToDouble(e.TotalFileCount) * 100);
                if (percentage > progressBarLaunch.Value) progressBarLaunch.Value = percentage;
            };

            MLaunchOption launchOptions = new MLaunchOption
            {
                MaximumRamMb = 1024,
                Session = session
            };

            Process process = launcher.CreateProcess(Version, launchOptions);

            process.Start();
            Application.Exit();
        }

    }
}
