using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class ComputerModel
    {
        private CpuModel cpu;
        private MotherboardModel motherboard;
        private ObservableCollection<RamModel> rams;
        private ObservableCollection<GpuModel> gpus;
        private ObservableCollection<SsdModel> ssds;
        private ObservableCollection<HddModel> hdds;
        private ObservableCollection<DiscDriveModel> discDrives;
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

        public ObservableCollection<RamModel> GetRams
        {
            get { return rams; }
        }

        public ObservableCollection<GpuModel> GetGpus
        {
            get { return gpus; }
        }

        public ObservableCollection<SsdModel> GetSsds
        {
            get { return ssds; }
        }

        public ObservableCollection<HddModel> GetHdds
        {
            get { return hdds; }
        }

        public ObservableCollection<DiscDriveModel> GetDiscDrives
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
            rams = new ObservableCollection<RamModel>();
            gpus = new ObservableCollection<GpuModel>();
            ssds = new ObservableCollection<SsdModel>();
            hdds = new ObservableCollection<HddModel>();
            discDrives = new ObservableCollection<DiscDriveModel>();
            psu = new PsuModel();
            caseModel = new CaseModel();
            os = new OsModel();
        }
    }
}
