namespace SMS_Notification_Client_v2_Interface
{
    partial class BaseInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BaseParentMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuNotifyNowOption = new System.Windows.Forms.PictureBox();
            this.MenuNotifyScheduleOption = new System.Windows.Forms.PictureBox();
            this.MenuMonitorOption = new System.Windows.Forms.PictureBox();
            this.MenuSettingsOption = new System.Windows.Forms.PictureBox();
            this.MenuDashboardOption = new System.Windows.Forms.PictureBox();
            this.BaseViewParentArea = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BaseLogo = new System.Windows.Forms.PictureBox();
            this.BaseParentMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuNotifyNowOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuNotifyScheduleOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuMonitorOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSettingsOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDashboardOption)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseParentMenu
            // 
            this.BaseParentMenu.BackColor = System.Drawing.Color.White;
            this.BaseParentMenu.Controls.Add(this.MenuNotifyNowOption);
            this.BaseParentMenu.Controls.Add(this.MenuNotifyScheduleOption);
            this.BaseParentMenu.Controls.Add(this.MenuMonitorOption);
            this.BaseParentMenu.Controls.Add(this.MenuSettingsOption);
            this.BaseParentMenu.Controls.Add(this.MenuDashboardOption);
            this.BaseParentMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BaseParentMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BaseParentMenu.Location = new System.Drawing.Point(0, 0);
            this.BaseParentMenu.Name = "BaseParentMenu";
            this.BaseParentMenu.Size = new System.Drawing.Size(218, 460);
            this.BaseParentMenu.TabIndex = 1;
            this.BaseParentMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.BaseParentMenu_Paint);
            // 
            // MenuNotifyNowOption
            // 
            this.MenuNotifyNowOption.Image = global::SMS_Notification_Client_v2_Interface.Properties.Resources.baseline_textsms_black_48dp;
            this.MenuNotifyNowOption.Location = new System.Drawing.Point(3, 3);
            this.MenuNotifyNowOption.Name = "MenuNotifyNowOption";
            this.MenuNotifyNowOption.Size = new System.Drawing.Size(78, 64);
            this.MenuNotifyNowOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuNotifyNowOption.TabIndex = 0;
            this.MenuNotifyNowOption.TabStop = false;
            this.MenuNotifyNowOption.Click += new System.EventHandler(this.MenuNotifyNowOption_Click);
            // 
            // MenuNotifyScheduleOption
            // 
            this.MenuNotifyScheduleOption.Image = global::SMS_Notification_Client_v2_Interface.Properties.Resources.baseline_alarm_black_48dp;
            this.MenuNotifyScheduleOption.Location = new System.Drawing.Point(3, 73);
            this.MenuNotifyScheduleOption.Name = "MenuNotifyScheduleOption";
            this.MenuNotifyScheduleOption.Size = new System.Drawing.Size(78, 58);
            this.MenuNotifyScheduleOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuNotifyScheduleOption.TabIndex = 1;
            this.MenuNotifyScheduleOption.TabStop = false;
            // 
            // MenuMonitorOption
            // 
            this.MenuMonitorOption.Image = global::SMS_Notification_Client_v2_Interface.Properties.Resources.baseline_speaker_notes_black_48dp;
            this.MenuMonitorOption.Location = new System.Drawing.Point(3, 137);
            this.MenuMonitorOption.Name = "MenuMonitorOption";
            this.MenuMonitorOption.Size = new System.Drawing.Size(78, 58);
            this.MenuMonitorOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuMonitorOption.TabIndex = 2;
            this.MenuMonitorOption.TabStop = false;
            // 
            // MenuSettingsOption
            // 
            this.MenuSettingsOption.Image = global::SMS_Notification_Client_v2_Interface.Properties.Resources.baseline_settings_applications_black_48dp;
            this.MenuSettingsOption.Location = new System.Drawing.Point(3, 201);
            this.MenuSettingsOption.Name = "MenuSettingsOption";
            this.MenuSettingsOption.Size = new System.Drawing.Size(78, 58);
            this.MenuSettingsOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuSettingsOption.TabIndex = 3;
            this.MenuSettingsOption.TabStop = false;
            // 
            // MenuDashboardOption
            // 
            this.MenuDashboardOption.Image = global::SMS_Notification_Client_v2_Interface.Properties.Resources.baseline_dashboard_black_48dp;
            this.MenuDashboardOption.Location = new System.Drawing.Point(3, 265);
            this.MenuDashboardOption.Name = "MenuDashboardOption";
            this.MenuDashboardOption.Size = new System.Drawing.Size(78, 58);
            this.MenuDashboardOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuDashboardOption.TabIndex = 4;
            this.MenuDashboardOption.TabStop = false;
            // 
            // BaseViewParentArea
            // 
            this.BaseViewParentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseViewParentArea.Location = new System.Drawing.Point(218, 0);
            this.BaseViewParentArea.Name = "BaseViewParentArea";
            this.BaseViewParentArea.Size = new System.Drawing.Size(548, 460);
            this.BaseViewParentArea.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BaseLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(218, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 92);
            this.panel1.TabIndex = 5;
            // 
            // BaseLogo
            // 
            this.BaseLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BaseLogo.Location = new System.Drawing.Point(383, 0);
            this.BaseLogo.Name = "BaseLogo";
            this.BaseLogo.Size = new System.Drawing.Size(165, 92);
            this.BaseLogo.TabIndex = 3;
            this.BaseLogo.TabStop = false;
            this.BaseLogo.Click += new System.EventHandler(this.BaseLogo_Click);
            // 
            // BaseInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BaseViewParentArea);
            this.Controls.Add(this.BaseParentMenu);
            this.IsMdiContainer = true;
            this.Name = "BaseInterface";
            this.Text = "Form1";
            this.BaseParentMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuNotifyNowOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuNotifyScheduleOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuMonitorOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSettingsOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDashboardOption)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel BaseParentMenu;
        private System.Windows.Forms.PictureBox MenuNotifyNowOption;
        private System.Windows.Forms.PictureBox MenuNotifyScheduleOption;
        private System.Windows.Forms.PictureBox MenuMonitorOption;
        private System.Windows.Forms.PictureBox MenuSettingsOption;
        private System.Windows.Forms.Panel BaseViewParentArea;
        private System.Windows.Forms.PictureBox BaseLogo;
        private System.Windows.Forms.PictureBox MenuDashboardOption;
        private System.Windows.Forms.Panel panel1;
    }
}

