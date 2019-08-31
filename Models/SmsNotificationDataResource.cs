using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Notification_Client_v2_Interface.Models
{


    class SmsNotificationDataResource : BaseSmsResource
    {
        public SmsNotificationDataResource()
        {
            this.date_created = date_created;   //this should be filled in with current date at this point
            this.doctor_number = doctor_number; // This should be grabbed from a config file of some sort
            this.acct = acct;                   // This should be filled in by some sort of config file, perhaps hashed
            this.token = null;                  // This should never NOT be null
            this.secret_name = secret_name;     // This should be filled in from config file
        }



        /// <summary>
        /// The chart number of the patient that will be contacted
        /// </summary>
        public string chart { get; set; }


        /// <summary>
        /// The patient's phone number that will be used to establish contact
        /// </summary>
        public string patient_number { get; set; }


        /// <summary>
        /// The name of the patient that will be included in the message
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// The date that the message request is created
        /// </summary>
        public string date_created { get; set; }

        /// <summary>
        /// This dictionary will hold the date, time, status, and timezone data
        /// of the patient's appointment
        /// </summary>
        public IDictionary<string, string> appointment { get; set; }


        /// <summary>
        /// The name of the doctor that the patient will be seeing
        /// </summary>
        public string doctor { get; set; }


        /// <summary>
        /// The message that will be sent to the patient
        /// </summary>
        public string message { get; set; }


        /// <summary>
        /// The name of the doctor's office that the patient is scheduled to arrive at
        /// </summary>
        public string doctor_office { get; set; }

        /// <summary>
        /// The phone number designated for use by the client.
        /// </summary>
        public string doctor_number { get; set; }


        /// <summary>
        /// The account SID that will be used to identify the Twilio account to use for messaging
        /// </summary>
        public string acct { get; set; }


        /// <summary>
        /// (PlaceHolder) The secret token that will eventually be plugged in on the server side
        /// </summary>
        public string token { get; set; }


        /// <summary>
        /// The secret name which will be used to tie the account SID and token together in Vault
        /// </summary>
        public string secret_name { get; set; }


        /// <summary>
        /// (PlaceHolder) The delivery status of the message that has been sent
        /// </summary>
        public string delivery_status { get; set; }


        /// <summary>
        /// The scheduled time that messages should be delivered to the patient
        /// </summary>
        public string scheduled_time { get; set; }
    }
}
