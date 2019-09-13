using Newtonsoft.Json;
using SMS_Notification_Client_v2_Interface.Models;
using SMS_Notification_Client_v2_Interface.DatabaseConnectorModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Notification_Client_v2_Interface.Services
{
    class SmsDataResourceSendService : BaseService
    {
        //Create the model
        public SmsNotificationDataResource DataPackage = new SmsNotificationDataResource();

        //Initialize the model
        public SmsDataResourceSendService() {
            
        }

        public void InitializeModel(string chart, string patient_phone_number, string patient_name, string date_created, 
            string doctor_name, string message_body, string doctor_office, string doctor_office_number, string acct, string token, 
            string secret_name, string delivery_status, string scheduled_time, IDictionary<string, string> appointment) {

            this.DataPackage.acct = acct;
            this.DataPackage.chart = chart;
            this.DataPackage.patient_number = patient_phone_number;
            this.DataPackage.name = patient_name;
            this.DataPackage.date_created = date_created;
            this.DataPackage.appointment = appointment;
            this.DataPackage.doctor = doctor_name;
            this.DataPackage.message = message_body;
            this.DataPackage.doctor_office = doctor_office;
            this.DataPackage.doctor_number = doctor_office_number;
            this.DataPackage.token = token;
            this.DataPackage.secret_name = secret_name;
            this.DataPackage.delivery_status = delivery_status;
            this.DataPackage.scheduled_time = scheduled_time;
        }

        //Serialize
        public string SerializeToJson() {
            string SerializedDataPackage = JsonConvert.SerializeObject(this.DataPackage);
            return SerializedDataPackage;
        }

        //Send
        public async Task SendToServerAsync() {
            string PreparedDataPayload = this.SerializeToJson();

            //Make HTTP Request
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                    "SomeURL",
                    new StringContent(PreparedDataPayload, Encoding.UTF8, "application/json"));
            }
        }
    }
}
