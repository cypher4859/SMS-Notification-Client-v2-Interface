using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Notification_Client_v2_Interface.Models
{

    // SAMPLE DATA

//    [{
//	"chart": "someChart",
//	"patient_number": "3044446329",
//	"name": "testting",
//	"date_created": "",
//	"appointment": {
//		"date": "2019-08-20",
//		"time": "1:06pm",
//		"status": "Unconfirmed",
//		"timezone": ""

//    },
//	"doctor": "Dr. Strange",
//	"message": "Test new system",
//	"doctor_office": "The Office",
//	"doctor_number": "3047605956",
//	"acct": "AC471e900502c9d036fa8cc7e6a50682e9",
//	"token": "",
//	"secret_name": "childerstaylor",
//	"delivery_status": "",
//	"scheduled_time": {
//		"date": "2019-08-20",
//		"time": "1:06pm",
//		"timezone": "US/Eastern"
//	}
//}]

    class SmsNotificationDataResource : BaseSmsResource
    {
        public SmsNotificationDataResource()
        {
        }



        /// <summary>
        /// (retrieve from DB) The chart number of the patient that will be contacted
        /// </summary>
        public string chart { get; set; }


        /// <summary>
        /// (retrieve from DB) The patient's phone number that will be used to establish contact
        /// </summary>
        public string patient_number { get; set; }


        /// <summary>
        /// (retrieve from DB) The name of the patient that will be included in the message
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// (Generated) The date that the message request is created
        /// </summary>
        public string date_created { get; set; }

        /// <summary>
        /// (retrieve from DB) This dictionary will hold the date, time, status, and timezone data
        /// of the patient's appointment
        /// </summary>
        public Dictionary<string, string> appointment { get; set; }


        /// <summary>
        /// (retrieve from DB) The name of the doctor that the patient will be seeing
        /// </summary>
        public string doctor { get; set; }


        /// <summary>
        /// (Generated, mostly)The message that will be sent to the patient
        /// </summary>
        public string message { get; set; }


        /// <summary>
        /// (retrieve from config) The name of the doctor's office that the patient is scheduled to arrive at
        /// </summary>
        public string doctor_office { get; set; }

        /// <summary>
        /// (retrieve from config) The phone number designated for use by the client.
        /// </summary>
        public string doctor_number { get; set; }


        /// <summary>
        /// (retrieve from config) The account SID that will be used to identify the Twilio account to use for messaging
        /// </summary>
        public string acct { get; set; }


        /// <summary>
        /// (PlaceHolder) The secret token that will eventually be plugged in on the server side
        /// </summary>
        public string token { get; set; }


        /// <summary>
        /// (retrieve from config) The secret name which will be used to tie the account SID and token together in Vault
        /// </summary>
        public string secret_name { get; set; }


        /// <summary>
        /// (PlaceHolder) The delivery status of the message that has been sent
        /// </summary>
        public string delivery_status { get; set; }


        /// <summary>
        /// (Generate where applicable)The scheduled time that messages should be delivered to the patient
        /// </summary>
        public string scheduled_time { get; set; }
    }
}
