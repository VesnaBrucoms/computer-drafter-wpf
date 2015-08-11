using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class CpuModel : PartModel
    {
        private string brand;
        private string cores;
        private string clock;
        private string socket;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
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

        public string Sockets
        {
            get { return socket; }
            set { socket = value; }
        }
    }
}
