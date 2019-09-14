using Newtonsoft.Json;
using SMS_Notification_Client_v2_Interface.Models;
using SMS_Notification_Client_v2_Interface.DatabaseConnectorModule;
using SMS_Notification_Client_v2_Interface.Transformers;
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

        //Initialize the model and inject the model
        public SmsDataResourceSendService() {
            SmsNotificationModelTransformer transformer = new SmsNotificationModelTransformer();
            DataPackage = transformer.InjectData();
        }

        //Serialize the model
        public string SerializeToJson() {
            string SerializedDataPackage = JsonConvert.SerializeObject(this.DataPackage);
            return SerializedDataPackage;
        }

        //Send the model
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
