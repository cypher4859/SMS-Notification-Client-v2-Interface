using SMS_Notification_Client_v2_Interface.DatabaseConnectorModule;
using SMS_Notification_Client_v2_Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SMS_Notification_Client_v2_Interface.Services
{
    class BaseService
    {
        public BaseService() {
            // Make and use the DB Connector
            // It will send the same DateSelection regardless.
            string dbEnvironment = "alta";

            if (dbEnvironment == "alta")
            {
                connector = new AltaPointDatabaseConnector();
            }
            else if (dbEnvironment == "total")
            {
                connector = new TotalMdDatabaseConnector();
            }
            else if (dbEnvironment == "Some other bullshit")
            {

            }
        }

        public BaseDatabaseConnector connector { get; set; }

        //Create the list that will hold models
        public IList<SmsNotificationDataResource> ListOfDataPackages { get; set; }
    }
}
