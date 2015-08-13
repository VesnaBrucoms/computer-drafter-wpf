using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class CpuModel : PartModel
    {
        private List<string> brand;
        private string selBrand;
        private List<string> cores;
        private string selCores;
        private string clock;
        private List<string> amdSockets;
        private List<string> intelSockets;
        private string selSocket;

        #region Properties
        public List<string> Brand
        {
            get { return brand; }
        }

        public string SelectedBrand
        {
            get { return selBrand; }
            set { selBrand = value; }
        }

        public List<string> Cores
        {
            get { return cores; }
        }

        public string SelectedCores
        {
            get { return selCores; }
            set { selCores = value; }
        }

        public string Clock
        {
            get { return clock; }
            set { clock = value; }
        }

        public List<string> AmdSockets
        {
            get { return amdSockets; }
        }

        public List<string> IntelSockets
        {
            get { return intelSockets; }
        }

        public string Sockets
        {
            get { return selSocket; }
            set { selSocket = value; }
        }
        #endregion

        public CpuModel()
        {
            brand = new List<string>();
            brand.Add("AMD");
            brand.Add("Intel");

            cores = new List<string>();
            cores.Add("1");
            cores.Add("2");
            cores.Add("3");
            cores.Add("4");
            cores.Add("6");
            cores.Add("8");
            cores.Add("12");
            cores.Add("16");

            amdSockets = new List<string>();
            amdSockets.Add("940");
            amdSockets.Add("AM1");
            amdSockets.Add("AM1+");
            amdSockets.Add("AM2");
            amdSockets.Add("AM2+");
            amdSockets.Add("AM3");
            amdSockets.Add("AM3+");
            amdSockets.Add("F");
            amdSockets.Add("FM1");
            amdSockets.Add("FM2");
            amdSockets.Add("G34");

            intelSockets = new List<string>();
            intelSockets.Add("LGA 478");
            intelSockets.Add("LGA 479");
            intelSockets.Add("LGA 771");
            intelSockets.Add("LGA 775");
            intelSockets.Add("LGA 988");
            intelSockets.Add("LGA 1150");
            intelSockets.Add("LGA 1151");
            intelSockets.Add("LGA 1155");
            intelSockets.Add("LGA 1156");
            intelSockets.Add("LGA 1356");
            intelSockets.Add("LGA 1366");
            intelSockets.Add("LGA 2011");
            intelSockets.Add("P");
        }
    }
}
