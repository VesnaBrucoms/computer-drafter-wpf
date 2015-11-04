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
        public CpuModel GetCpu
        {
            get { return cpu; }
        }

        public MotherboardModel GetMotherboard
        {
            get { return motherboard; }
        }

        public List<RamModel> GetRams
        {
            get { return rams; }
        }

        public List<GpuModel> GetGpus
        {
            get { return gpus; }
        }

        public List<SsdModel> GetSsds
        {
            get { return ssds; }
        }

        public List<HddModel> GetHdds
        {
            get { return hdds; }
        }

        public List<DiscDriveModel> GetDiscDrives
        {
            get { return discDrives; }
        }

        public PsuModel GetPsu
        {
            get { return psu; }
        }

        public CaseModel GetCase
        {
            get { return caseModel; }
        }

        public OsModel GetOs
        {
            get { return os; }
        }
        #endregion

        public ComputerModel()
        {
            cpu = new CpuModel();
            motherboard = new MotherboardModel();
            rams = new List<RamModel>();
            gpus = new List<GpuModel>();
            ssds = new List<SsdModel>();
            hdds = new List<HddModel>();
            discDrives = new List<DiscDriveModel>();
            psu = new PsuModel();
            caseModel = new CaseModel();
            os = new OsModel();
        }
    }
}
