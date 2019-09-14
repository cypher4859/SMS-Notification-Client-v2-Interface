using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS_Notification_Client_v2_Interface.DatabaseConnectorModule;
using SMS_Notification_Client_v2_Interface.Models;

namespace SMS_Notification_Client_v2_Interface.Transformers
{
    class SmsNotificationModelTransformer : BaseTransformer
    {
        SmsNotificationDataResource mod;

        public SmsNotificationModelTransformer() {
            //Make and use the DB Connector
            AltaPointDatabaseConnector connector = new AltaPointDatabaseConnector();

            //inject DB info into the model
            mod.chart = connector.chart;
            mod.appointment = connector.patient_appointment;
            mod.doctor = connector.doctor_name;
            mod.name = connector.patient_name;
            mod.patient_number = connector.patient_number;

        }

        public SmsNotificationDataResource InjectData() {
            SmsNotificationDataResource hydrated_obj = InjectConfigDataIntoModelResource(mod);
            return mod;
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
