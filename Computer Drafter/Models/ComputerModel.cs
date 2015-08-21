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
        private List<RamModel> rams;
        private List<GpuModel> gpus;
        private List<SsdModel> ssds;
        private List<HddModel> hdds;
        private List<DiscDriveModel> discDrives;
        private PsuModel psu;
        private CaseModel caseModel;
        private OsModel os;

        #region Properties
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
        #endregion
    }
}
