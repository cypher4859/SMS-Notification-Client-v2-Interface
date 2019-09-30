using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Notification_Client_v2_Interface.DatabaseConnectorModule
{
    class TotalMdDatabaseConnector : BaseDatabaseConnector
    {

        public TotalMdDatabaseConnector()
        {

        }
        //Old Code

        //if (database_environ == "altapoint")
        //    {
        //        connectionString = "Dsn=altapoint;Uid=admin;Pwd=admin;";
        //        db_sqlgrab = "select appointment.patient, appointment.date, appointment.time_str, patient.phone_cell, patient.email, patient.firstname, patient.lastname, patient.provider from appointment inner join patient on appointment.patient=patient.code where appointment.DATE between \'" + begin2_date + "\' and \'" + end2_date + "\'";
        //    }
        //    else if (database_environ == "totalmd") {
        //        connectionString = "Dsn=totalmd;Uid=Admin;Pwd=DBAdmin;";
        //        db_sqlgrab = "select appointment.\"chart number\", appointment.date, appointment.time, patient.mobile, patient.\"e-mail\", patient.\"first name\", patient.\"last name\", appointment.id, provider.\"last name\" from appointment inner join patient on appointment.\"chart number\"=patient.\"chart number\" inner join provider on provider.code=appointment.provider where appointment.DATE BETWEEN \'" + begin2_date + "\' and \'" + end2_date + "\'";
        //    }


        //using (OdbcConnection connection = new OdbcConnection(connectionString)) { }
    }
}
