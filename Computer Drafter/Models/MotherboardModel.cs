using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class MotherboardModel : PartModel
    {
        private string chipset;
        private string memCap;
        private string memType;
        private string memFreq;

        public string Chipset
        {
            get { return chipset; }
            set { chipset = value; }
        }

        public string MemoryCapacity
        {
            get { return memCap; }
            set { memCap = value; }
        }

        public string MemoryType
        {
            get { return memType; }
            set { memType = value; }
        }

        public string MemoryFrequancy
        {
            get { return memFreq; }
            set { memFreq = value; }
        }
    }
}
