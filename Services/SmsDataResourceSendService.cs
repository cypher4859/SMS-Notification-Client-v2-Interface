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
        
        //Initialize the model and 
        //inject the model
        public SmsDataResourceSendService(SelectionRange DateSelection, bool IsScheduled) {
            ListOfDataPackages = new List<SmsNotificationDataResource>();
            connector.DateSelection = DateSelection;

            BaseTransformer transformer;


            //Iterate over a collection of dictionaries and send to the transformer.
            foreach (Dictionary<string, dynamic> PatientAppointment in connector.CollectionOfAppointments)
            {
                SmsNotificationDataResource DataPackage = new SmsNotificationDataResource();
                if (IsScheduled) {
                    //This needs fixed and tweaked to accomodate the scheduled part
                    transformer = new SmsNotificationModelTransformer(PatientAppointment);
                    DataPackage = (SmsNotificationDataResource)transformer.InjectData;
                }
                else {
                    transformer = new SmsNotificationModelTransformer(PatientAppointment);
                    DataPackage = (SmsNotificationDataResource)transformer.InjectData;
                }

                
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
