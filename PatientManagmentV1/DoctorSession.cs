using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagmentV1
{
    public static class DoctorSession
    {
        public static int DoctorId { get; set; }
        public static string? DoctorName { get; set; }
        public static string? Role { get; set; }

        // Method to clear the session data
        public static void ClearSession()
        {
            DoctorId = 0;
            DoctorName = null;
            Role = null;
        }
    }
}