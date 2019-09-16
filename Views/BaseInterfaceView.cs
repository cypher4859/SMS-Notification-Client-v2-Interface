using SMS_Notification_Client_v2_Interface.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Notification_Client_v2_Interface
{
    public partial class BaseInterface : Form
    {
        public BaseInterface()
        {
            InitializeComponent();
        }

        

        private void MenuNotifyNowOption_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SmsPrepareToNotify>().Count() == 0) {
                SmsPrepareToNotify prepareToNotifyForm = new SmsPrepareToNotify();
                prepareToNotifyForm.MdiParent = this;
                prepareToNotifyForm.Show();
                SetParent(prepareToNotifyForm.Handle, this.BaseViewParentArea.Handle);
            } else if(Application.OpenForms.OfType<SmsPrepareToNotify>().Count() == 1) {
                Application.OpenForms.OfType<SmsPrepareToNotify>().First().Close();
            }
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void BaseParentMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BaseLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
