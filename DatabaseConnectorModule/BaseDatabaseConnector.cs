using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Notification_Client_v2_Interface.DatabaseConnectorModule
{
    class BaseDatabaseConnector
    {
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

        public BaseDatabaseConnector() {
            chart = "";
            patient_appointment = new Dictionary<string, string>
            {
                { "date", "some date" },
                { "time", "4:20" },
                { "status", "ConfirmedBitches!" },
                { "timezone", "EastCoastBitches" }
            };

            doctor_name = "";
            patient_name = "";
            patient_number = "";
        }

        /// <summary>
        /// The chart number of selected patient
        /// </summary>
        public string chart { get; set; }

        /// <summary>
        /// The appointment information of the patient
        /// </summary>
        public IDictionary<string,string> patient_appointment { get; set; }

        /// <summary>
        /// The name of the doctor that the patient will eventually see
        /// </summary>
        public string doctor_name { get; set; }

        /// <summary>
        /// The name of the selected patient
        /// </summary>
        public string patient_name { get; set; }

        /// <summary>
        /// The phone number of the selected patient
        /// </summary>
        public string patient_number { get; set; }
    }
}
