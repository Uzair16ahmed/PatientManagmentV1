using PatientManagmentV1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PatientManagmentV1
{
    public static class DatabaseConnection
    {
        private static readonly string connectionString = @"Data Source=DESKTOP-N615JQS\SQLEXPRESS01;Initial Catalog=Patient_ManagementV1;Integrated Security=True;Trust Server Certificate=True";

        //private static readonly string connectionString = @"Data Source=DESKTOP-N615JQS\SQLEXPRESS01;Initial Catalog=Patient_ManagementV1;User Id=Clinic_User;password=asdf1234";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

}

