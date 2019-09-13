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
        public SmsNotificationModelTransformer(SmsNotificationDataResource model) {
            //Make and use the DB Connector
            AltaPointDatabaseConnector connector = new AltaPointDatabaseConnector();

            //inject DB info into the model
            model.chart = connector.chart;
            model.appointment = connector.patient_appointment;
            model.doctor = connector.doctor_name;
            model.name = connector.patient_name;
            model.patient_number = connector.patient_number;

            //Inject Config Data into the model

            //return the transformed model
        }

        public SmsNotificationDataResource InjectConfigDataIntoModelResource(SmsNotificationDataResource obj) {


            return obj;
        }
    }
}
