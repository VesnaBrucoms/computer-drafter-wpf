using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class RamModel : PartModel
    {
        private List<string> capacities;
        private string selCapacity;
        private string selFrequency;
        private string casLatency;

        #region Properties
        public List<string> Capacities
        {
            get { return capacities; }
        }

        public string SelectedCapacity
        {
            get { return selCapacity; }
            set { selCapacity = value; }
        }

        public List<string> Frequencies
        {
            get { return FrequencyData.GetFrequencies; }
        }

        public string SelectedFrequency
        {
            get { return selFrequency; }
            set { selFrequency = value; }
        }

        public string CasLatency
        {
            get { return casLatency; }
            set { casLatency = value; }
        }
        #endregion

        public RamModel()
        {
            name = "test";
            capacities = new List<string>();
            capacities.Add("512MB");
            capacities.Add("1GB");
            capacities.Add("2GB");
            capacities.Add("4GB");
            capacities.Add("8GB");
            capacities.Add("16GB");
        }
    }
}
