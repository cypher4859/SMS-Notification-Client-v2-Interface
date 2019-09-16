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
using System.Windows.Forms;

namespace SMS_Notification_Client_v2_Interface.Services
{
    class SmsDataResourceSendService : BaseService
    {
        //Create the model
        IList<SmsNotificationDataResource> ListOfDataPackages { get; set; }


        //Initialize the model and 
        //inject the model
        public SmsDataResourceSendService(SelectionRange DateSelection) {
            ListOfDataPackages = new List<SmsNotificationDataResource>();
            SmsNotificationDataResource DataPackage = new SmsNotificationDataResource();

            //Make and use the DB Connector
            AltaPointDatabaseConnector connector = new AltaPointDatabaseConnector(DateSelection);

            //Iterate over a collection of dictionaries and send to the transformer.
            foreach (Dictionary<string, string> PatientAppointment in connector.CollectionOfAppointments)
            {
                SmsNotificationModelTransformer transformer = new SmsNotificationModelTransformer(PatientAppointment);
                DataPackage = transformer.InjectData();
                ListOfDataPackages.Add(DataPackage);
            }

        }

        //Serialize the model
        public string SerializeToJson(IList<SmsNotificationDataResource> obj) {
            string SerializedDataPackage = JsonConvert.SerializeObject(obj);
            return SerializedDataPackage;
        }

        //Send the model
        public async Task SendToServerAsync() {
            string PreparedDataPayload = this.SerializeToJson(this.ListOfDataPackages);

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
