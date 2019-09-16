using SMS_Notification_Client_v2_Interface.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Notification_Client_v2_Interface
{
    public partial class SmsPrepareToNotify : Form
    {
        public SmsPrepareToNotify()
        {
            InitializeComponent();
        }

        private void CreateSendServiceAndSend()
        {
            //Check that a data is selected
            DateTime DateStart = SmsDatePicker.SelectionStart;
            DateTime DateEnd = SmsDatePicker.SelectionEnd;
            SelectionRange DateRange = SmsDatePicker.SelectionRange;

            //Create Service, it will:
            // 1. Create Model
            // 2. Initialize/Inject
            // 3. Serialize
            SmsDataResourceSendService service = new SmsDataResourceSendService(DateRange);
            SmsPrepareToNotifyProgressBar.Increment(30);

            _ = service.SendToServerAsync();
            SmsPrepareToNotifyProgressBar.Increment(70);
        }

        private void SmsPrepareToNotifySubmit_Click(object sender, EventArgs e)
        {
            CreateSendServiceAndSend();
        }


        private void CloseThisForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
