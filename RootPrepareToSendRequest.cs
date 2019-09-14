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
    public partial class RootPrepareToSendRequest : Form
    {
        public RootPrepareToSendRequest()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Create Service, it will:
            // 1. Create Model
            // 2. Initialize/Inject
            // 3. Serialize
            SmsDataResourceSendService service = new SmsDataResourceSendService();
            _ = service.SendToServerAsync();
        }
    }
}
