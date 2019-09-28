using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS_Notification_Client_v2_Interface.DatabaseConnectorModule;
using SMS_Notification_Client_v2_Interface.Models;


namespace SMS_Notification_Client_v2_Interface.Transformers
{
    class SmsNotificationModelTransformer : BaseTransformer
    {
        public SmsNotificationDataResource mod = new SmsNotificationDataResource();

        public SmsNotificationModelTransformer(Dictionary<string, dynamic> AppointmentData) {
            

            //This will need to inject one at a time the database info into the model. 
            //One model for every patient. Thus, we should have a collection of serialized models.
            //Perhaps move the database part before the transformer. So it would loop over the collection from
            //the database and for each element it will pass it to the transformer. 
            //Everything else stays the same
            
            //inject DB info into the model
            mod.chart = AppointmentData["chart"];
            mod.appointment = new Dictionary<string,string>() {
                { "time", AppointmentData["patient_appointment_time"] },
                { "date", AppointmentData["patient_appointment_date"] },
                { "status", "" },       // This should be empty
                { "timezone", "" }      // Get this from config!
            };
            mod.doctor = AppointmentData["doctor_name"];
            mod.name = AppointmentData["patient_name"];
            mod.patient_number = AppointmentData["patient_number"];

        }

        public SmsNotificationDataResource InjectData() {
            return InjectConfigDataIntoModelResource(mod);
        }

        public SmsNotificationDataResource InjectConfigDataIntoModelResource(SmsNotificationDataResource model) {
            //Inject Config Data into the model
            model.acct = "";
            model.doctor_number = "";
            model.doctor_office = "";
            model.message = "";
            model.secret_name = "";

            return model;
        }
    }
}
