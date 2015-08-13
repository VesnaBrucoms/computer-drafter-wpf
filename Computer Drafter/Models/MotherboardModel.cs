using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class MotherboardModel : PartModel
    {
        private List<string> amdChipsets;
        private List<string> intelChipsets;
        private string selChipset;
        private List<string> memCaps;
        private string selMemCap;
        private List<string> memTypes;
        private string selMemType;
        private string selMemFreq;

        #region Properties
        public List<string> AmdChipsets
        {
            get { return amdChipsets; }
        }

        public List<string> IntelChipsets
        {
            get { return intelChipsets; }
        }

        public string SelectedChipset
        {
            get { return selChipset; }
            set { selChipset = value; }
        }

        public List<string> MemoryCapacities
        {
            get { return memCaps; }
        }

        public string SelectedMemoryCapacity
        {
            get { return selMemCap; }
            set { selMemCap = value; }
        }

        public List<string> MemoryTypes
        {
            get { return memTypes; }
        }

        public string SelectedMemoryType
        {
            get { return selMemType; }
            set { selMemType = value; }
        }

        public List<string> MemoryFrequencies
        {
            get { return FrequencyData.GetFrequencies; }
        }

        public string SelectedMemoryFreq
        {
            get { return selMemFreq; }
            set { selMemFreq = value; }
        }
        #endregion

        public MotherboardModel()
        {
            amdChipsets = new List<string>();
            amdChipsets.Add("740");
            amdChipsets.Add("760");
            amdChipsets.Add("760G");
            amdChipsets.Add("770");
            amdChipsets.Add("870");
            amdChipsets.Add("880");
            amdChipsets.Add("880G");
            amdChipsets.Add("890");
            amdChipsets.Add("970");
            amdChipsets.Add("990X");
            amdChipsets.Add("990FX");
            amdChipsets.Add("G34 Opteron");

            intelChipsets = new List<string>();
            intelChipsets.Add("B85");
            intelChipsets.Add("H81");
            intelChipsets.Add("H87");
            intelChipsets.Add("H97");
            intelChipsets.Add("Q85");
            intelChipsets.Add("Q87");
            intelChipsets.Add("Z77");
            intelChipsets.Add("Z87");
            intelChipsets.Add("Z97");
            intelChipsets.Add("X79");
            intelChipsets.Add("X99");
            intelChipsets.Add("Xeon");

            memCaps = new List<string>();
            memCaps.Add("16GB");
            memCaps.Add("32GB");
            memCaps.Add("64GB");
            memCaps.Add("128GB");
            memCaps.Add("256GB");
            memCaps.Add("512GB");
            memCaps.Add("768GB");
            memCaps.Add("1024GB");
            memCaps.Add("1.5TB");

            memTypes = new List<string>();
            memTypes.Add("DDR");
            memTypes.Add("DDR2");
            memTypes.Add("DDR3");
            memTypes.Add("DDR4");
        }
    }
}
