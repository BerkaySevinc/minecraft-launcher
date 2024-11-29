
namespace Beko_S_Mc_Launcher
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.panelPremium = new System.Windows.Forms.Panel();
            this.tbxEmail = new Client.Beko_TextBox();
            this.tbxPassword = new Client.Beko_TextBox();
            this.panelOffline = new System.Windows.Forms.Panel();
            this.tbxUsername = new Client.Beko_TextBox();
            this.progressBarLaunch = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.cbxPremium = new Client.Beko_CheckBox_Tick();
            this.comboVersions = new Client.iTalk_ComboBox();
            this.btnLaunch = new Client.Beko_Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panelPremium.SuspendLayout();
            this.panelOffline.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(862, 17);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 76;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.Location = new System.Drawing.Point(824, -12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 44);
            this.btnMinimize.TabIndex = 77;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelPremium
            // 
            this.panelPremium.Controls.Add(this.tbxEmail);
            this.panelPremium.Controls.Add(this.tbxPassword);
            this.panelPremium.Location = new System.Drawing.Point(215, 113);
            this.panelPremium.Name = "panelPremium";
            this.panelPremium.Size = new System.Drawing.Size(458, 130);
            this.panelPremium.TabIndex = 85;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbxEmail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbxEmail.ForeColor = System.Drawing.Color.DimGray;
            this.tbxEmail.Image = null;
            this.tbxEmail.Location = new System.Drawing.Point(16, 14);
            this.tbxEmail.MaxLength = 32767;
            this.tbxEmail.Multiline = false;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = false;
            this.tbxEmail.Size = new System.Drawing.Size(423, 41);
            this.tbxEmail.TabIndex = 80;
            this.tbxEmail.Text = "Email";
            this.tbxEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxEmail.UseSystemPasswordChar = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbxPassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPassword.Image = null;
            this.tbxPassword.Location = new System.Drawing.Point(16, 76);
            this.tbxPassword.MaxLength = 32767;
            this.tbxPassword.Multiline = false;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.ReadOnly = false;
            this.tbxPassword.Size = new System.Drawing.Size(423, 41);
            this.tbxPassword.TabIndex = 79;
            this.tbxPassword.Text = "Password";
            this.tbxPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPassword.UseSystemPasswordChar = false;
            // 
            // panelOffline
            // 
            this.panelOffline.Controls.Add(this.tbxUsername);
            this.panelOffline.Location = new System.Drawing.Point(215, 113);
            this.panelOffline.Name = "panelOffline";
            this.panelOffline.Size = new System.Drawing.Size(458, 130);
            this.panelOffline.TabIndex = 86;
            this.panelOffline.Visible = false;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbxUsername.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.tbxUsername.Image = null;
            this.tbxUsername.Location = new System.Drawing.Point(16, 55);
            this.tbxUsername.MaxLength = 32767;
            this.tbxUsername.Multiline = false;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.ReadOnly = false;
            this.tbxUsername.Size = new System.Drawing.Size(423, 41);
            this.tbxUsername.TabIndex = 80;
            this.tbxUsername.Text = "Username";
            this.tbxUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxUsername.UseSystemPasswordChar = false;
            // 
            // progressBarLaunch
            // 
            this.progressBarLaunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.progressBarLaunch.Location = new System.Drawing.Point(27, 541);
            this.progressBarLaunch.Name = "progressBarLaunch";
            this.progressBarLaunch.Size = new System.Drawing.Size(850, 23);
            this.progressBarLaunch.TabIndex = 87;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProgress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProgress.Location = new System.Drawing.Point(68, 517);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(68, 20);
            this.lblProgress.TabIndex = 88;
            this.lblProgress.Text = "Progress";
            // 
            // cbxPremium
            // 
            this.cbxPremium.BackColor = System.Drawing.Color.Transparent;
            this.cbxPremium.Checked = true;
            this.cbxPremium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxPremium.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPremium.Location = new System.Drawing.Point(266, 246);
            this.cbxPremium.Name = "cbxPremium";
            this.cbxPremium.Size = new System.Drawing.Size(127, 25);
            this.cbxPremium.TabIndex = 84;
            this.cbxPremium.Text = "  Premium";
            this.cbxPremium.CheckedChanged += new Client.Beko_CheckBox_Tick.CheckedChangedEventHandler(this.cbxPremium_CheckedChanged);
            // 
            // comboVersions
            // 
            this.comboVersions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.comboVersions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboVersions.DropDownHeight = 184;
            this.comboVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVersions.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboVersions.ForeColor = System.Drawing.Color.Black;
            this.comboVersions.FormattingEnabled = true;
            this.comboVersions.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.comboVersions.IntegralHeight = false;
            this.comboVersions.ItemHeight = 23;
            this.comboVersions.Location = new System.Drawing.Point(341, 350);
            this.comboVersions.Name = "comboVersions";
            this.comboVersions.Size = new System.Drawing.Size(204, 29);
            this.comboVersions.StartIndex = 0;
            this.comboVersions.TabIndex = 83;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Transparent;
            this.btnLaunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaunch.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLaunch.Image = null;
            this.btnLaunch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaunch.Location = new System.Drawing.Point(320, 392);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(247, 66);
            this.btnLaunch.TabIndex = 81;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(905, 583);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBarLaunch);
            this.Controls.Add(this.panelOffline);
            this.Controls.Add(this.cbxPremium);
            this.Controls.Add(this.comboVersions);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panelPremium);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beko-S Mc Launcher";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panelPremium.ResumeLayout(false);
            this.panelOffline.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label btnMinimize;
        private Client.Beko_TextBox tbxPassword;
        private Client.Beko_TextBox tbxEmail;
        private Client.Beko_Button btnLaunch;
        private Client.iTalk_ComboBox comboVersions;
        private Client.Beko_CheckBox_Tick cbxPremium;
        private System.Windows.Forms.Panel panelPremium;
        private System.Windows.Forms.Panel panelOffline;
        private Client.Beko_TextBox tbxUsername;
        private System.Windows.Forms.ProgressBar progressBarLaunch;
        private System.Windows.Forms.Label lblProgress;
    }
}

