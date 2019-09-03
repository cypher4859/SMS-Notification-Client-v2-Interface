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
    public partial class SmsPrepareToSendRequest : Form
    {
        public SmsPrepareToSendRequest()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Get Data
            string chart = "some chart";
            string patient_phone_number = "3046664209";
            string patient_name = "some dumbass";
            string date_created = "current data";
            string doctor_name = "dr. asswipe";
            string message_body = "HEEELPPPP";
            string doctor_office = "Dr. Asswipes Rectal Service";
            string doctor_office_number = "3048=D4202";
            string acct = "";
            string token = "";
            string secret_name = "";
            string delivery_status = "";
            string scheduled_time = "";
            IDictionary<string, string> appointment = new Dictionary<string, string>
            {
                { "date", "some date" },
                { "time", "4:20" },
                { "status", "ConfirmedBitches!" },
                { "timezone", "EastCoastBitches" }
            };



            //Create Service and initialize model
            SmsDataResourceSendService service = new SmsDataResourceSendService();
            service.InitializeModel(
                chart,
                patient_phone_number,
                patient_name,
                date_created,
                doctor_name,
                message_body,
                doctor_office,
                doctor_office_number,
                acct,
                token,
                secret_name,
                delivery_status,
                scheduled_time,
                appointment
            );

            _ = service.SendToServerAsync();
        }
    }
}
