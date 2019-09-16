namespace SMS_Notification_Client_v2_Interface
{
    partial class SmsPrepareToNotify
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SmsDatePicker = new System.Windows.Forms.MonthCalendar();
            this.SmsPrepareToNotifySubmit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SmsPrepareToNotifyProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.SmsPrepareToNotifySubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "01-01-1999";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 224);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "01-01-1999";
            // 
            // SmsDatePicker
            // 
            this.SmsDatePicker.Location = new System.Drawing.Point(174, 158);
            this.SmsDatePicker.Name = "SmsDatePicker";
            this.SmsDatePicker.TabIndex = 2;
            // 
            // SmsPrepareToNotifySubmit
            // 
            this.SmsPrepareToNotifySubmit.Image = global::SMS_Notification_Client_v2_Interface.Properties.Resources.baseline_send_black_48dp;
            this.SmsPrepareToNotifySubmit.Location = new System.Drawing.Point(354, 332);
            this.SmsPrepareToNotifySubmit.Name = "SmsPrepareToNotifySubmit";
            this.SmsPrepareToNotifySubmit.Size = new System.Drawing.Size(100, 50);
            this.SmsPrepareToNotifySubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SmsPrepareToNotifySubmit.TabIndex = 3;
            this.SmsPrepareToNotifySubmit.TabStop = false;
            this.SmsPrepareToNotifySubmit.Click += new System.EventHandler(this.SmsPrepareToNotifySubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMS_Notification_Client_v2_Interface.Properties.Resources.baseline_close_black_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(427, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.CloseThisForm);
            // 
            // SmsPrepareToNotifyProgressBar
            // 
            this.SmsPrepareToNotifyProgressBar.BackColor = System.Drawing.Color.White;
            this.SmsPrepareToNotifyProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.SmsPrepareToNotifyProgressBar.Location = new System.Drawing.Point(63, 395);
            this.SmsPrepareToNotifyProgressBar.Name = "SmsPrepareToNotifyProgressBar";
            this.SmsPrepareToNotifyProgressBar.Size = new System.Drawing.Size(352, 23);
            this.SmsPrepareToNotifyProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SmsPrepareToNotifyProgressBar.TabIndex = 5;
            // 
            // SmsPrepareToNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 480);
            this.Controls.Add(this.SmsPrepareToNotifyProgressBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SmsPrepareToNotifySubmit);
            this.Controls.Add(this.SmsDatePicker);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SmsPrepareToNotify";
            this.Text = "SmsPrepareToNotify";
            ((System.ComponentModel.ISupportInitialize)(this.SmsPrepareToNotifySubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MonthCalendar SmsDatePicker;
        private System.Windows.Forms.PictureBox SmsPrepareToNotifySubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar SmsPrepareToNotifyProgressBar;
    }
}