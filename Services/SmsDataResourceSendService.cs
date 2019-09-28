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
        //Create the list that will hold models
        IList<SmsNotificationDataResource> ListOfDataPackages { get; set; }


        //Initialize the model and 
        //inject the model
        public SmsDataResourceSendService(SelectionRange DateSelection) {
            ListOfDataPackages = new List<SmsNotificationDataResource>();
            

            // Make and use the DB Connector
            // It will send the same DateSelection regardless.
            string dbEnvironment = "alta";
            BaseDatabaseConnector connector = new BaseDatabaseConnector();

            if (dbEnvironment == "alta") {
                connector = new AltaPointDatabaseConnector(DateSelection);
            }
            else if (dbEnvironment == "total") {
               connector = new TotalMdDatabaseConnector(DateSelection);
            }
            else if (dbEnvironment == "Some other bullshit") {

            }
             

            //Iterate over a collection of dictionaries and send to the transformer.
            foreach (Dictionary<string, dynamic> PatientAppointment in connector.CollectionOfAppointments)
            {
                SmsNotificationDataResource DataPackage = new SmsNotificationDataResource();
                SmsNotificationModelTransformer transformer = new SmsNotificationModelTransformer(PatientAppointment);
                DataPackage = transformer.InjectData();
                ListOfDataPackages.Add(DataPackage);            // Add to the total list of packages
            }

        }

        //Serialize the model
        public string SerializeToJson(IList<SmsNotificationDataResource> obj) {
            return JsonConvert.SerializeObject(obj);
        }

        //Send the model
        public async Task SendToServerAsync() {
            //Make HTTP Request
            using (var client = new HttpClient())
            {
                string PreparedDataPayload = this.SerializeToJson(this.ListOfDataPackages);
                var response = await client.PostAsync(
                    "SomeURL",
                    new StringContent(PreparedDataPayload, Encoding.UTF8, "application/json"));
            }
        }
    }
}
