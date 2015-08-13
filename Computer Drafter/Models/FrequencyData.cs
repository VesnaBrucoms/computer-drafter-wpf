using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    internal static class FrequencyData
    {
        private static List<string> frequencies;

        public static List<string> GetFrequencies
        {
            get
            {
                frequencies = new List<string>();
                frequencies.Add("266");
                frequencies.Add("333");
                frequencies.Add("400");
                frequencies.Add("533");
                frequencies.Add("667");
                frequencies.Add("800");
                frequencies.Add("1600");
                frequencies.Add("1800+");
                frequencies.Add("2133");
                frequencies.Add("2400");
                frequencies.Add("2666+");
                frequencies.Add("2800+");
                frequencies.Add("3000+");
                frequencies.Add("3200+");

                return frequencies;
            }
        }
    }
}
