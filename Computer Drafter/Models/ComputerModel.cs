using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class ComputerModel
    {
        private CpuModel cpu;
        private MotherboardModel motherboard;

        public CpuModel Cpu
        {
            get { return cpu; }
            set { cpu = value; }
        }

        public MotherboardModel Motherboard
        {
            get { return motherboard; }
            set { motherboard = value; }
        }
    }
}
