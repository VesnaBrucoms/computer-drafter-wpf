using Computer_Drafter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.ViewModels
{
    class MainWindowViewModel
    {
        public delegate void NewDraftEventHandler();
        public event NewDraftEventHandler DraftOpened;

        private ComputerModel computer;
        private BasicViewModel basicViewModel;
        private RamViewModel ramViewModel;
        private GpuViewModel gpuViewModel;
        private SsdViewModel ssdViewModel;
        private HddViewModel hddViewModel;
        private DiscDriveViewModel discViewModel;
        private PsuViewModel psuViewModel;
        private CaseViewModel caseViewModel;
        private OtherViewModel otherViewModel;

        private string windowTitle;
        private string loadedDraft;

        #region ModelProperties
        public ComputerModel GetComputer
        {
            get { return computer; }
        }
        #endregion

        #region ViewModelProperties
        public BasicViewModel GetBasicViewModel
        {
            get { return basicViewModel; }
        }

        public RamViewModel GetRamViewModel
        {
            get { return ramViewModel; }
        }

        public GpuViewModel GetGpuViewModel
        {
            get { return gpuViewModel; }
        }

        public SsdViewModel GetSsdViewModel
        {
            get { return ssdViewModel; }
        }

        public HddViewModel GetHddViewModel
        {
            get { return hddViewModel; }
        }

        public DiscDriveViewModel GetDiscViewModel
        {
            get { return discViewModel; }
        }

        public PsuViewModel GetPsuViewModel
        {
            get { return psuViewModel; }
        }

        public CaseViewModel GetCaseViewModel
        {
            get { return caseViewModel; }
        }

        public OtherViewModel GetOtherViewModel
        {
            get { return otherViewModel; }
        }
        #endregion

        public string GetWindowTitle
        {
            get { return loadedDraft + " - " + windowTitle; }
        }

        public MainWindowViewModel()
        {
            computer = new ComputerModel();

            basicViewModel = new BasicViewModel(this);
            ramViewModel = new RamViewModel();
            gpuViewModel = new GpuViewModel();
            ssdViewModel = new SsdViewModel();
            hddViewModel = new HddViewModel();
            discViewModel = new DiscDriveViewModel();
            psuViewModel = new PsuViewModel();
            caseViewModel = new CaseViewModel();
            otherViewModel = new OtherViewModel();

            windowTitle = "Computer Drafter";
            loadedDraft = "test";
            OnPropertyChanged("GetWindowTitle");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                Console.WriteLine(propertyName);
            }
        }
    }
}
