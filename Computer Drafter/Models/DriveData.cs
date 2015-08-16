using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    internal static class DriveData
    {
        private static List<string> connections;

        public static List<string> GetConnections
        {
            get
            {
                connections = new List<string>();
                connections.Add("IDE");
                connections.Add("SATA I - 1.5Gb/s");
                connections.Add("SATA II - 3Gb/s");
                connections.Add("SATA III - 6Gb/s");

                return connections;
            }
        }
    }
}
