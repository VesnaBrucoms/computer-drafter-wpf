using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class GpuModel : PartModel, IMultiPartModel
    {
        private int number;
        private string cores;
        private string clock;
        private string memory;
        private string memBit;
        private string memClock;

        #region Properties
        public GpuModel GetInstance
        {
            get { return this; }
        }

        public int PartNumber
        {
            get { return number; }
            set { number = value; }
        }

        public string PartNumberString
        {
            get { return "GPU " + number; }
        }

        public string Cores
        {
            get { return cores; }
            set { cores = value; }
        }

        public string Clock
        {
            get { return clock; }
            set { clock = value; }
        }

        public string Memory
        {
            get { return memory; }
            set { memory = value; }
        }

        public string MemoryBitRate
        {
            get { return memBit; }
            set { memBit = value; }
        }

        public string MemoryClock
        {
            get { return memClock; }
            set { memClock = value; }
        }
        #endregion

        public GpuModel()
        {
        }
    }
}
