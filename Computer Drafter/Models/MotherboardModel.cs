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
        private List<string> memFreqs;
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
            get { return memFreqs; }
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

            memFreqs = new List<string>();
            memFreqs.Add("266");
            memFreqs.Add("333");
            memFreqs.Add("400");
            memFreqs.Add("533");
            memFreqs.Add("667");
            memFreqs.Add("800");
            memFreqs.Add("1600");
            memFreqs.Add("1800+");
            memFreqs.Add("2133");
            memFreqs.Add("2400");
            memFreqs.Add("2666+");
            memFreqs.Add("2800+");
            memFreqs.Add("3000+");
            memFreqs.Add("3200+");
        }
    }
}
