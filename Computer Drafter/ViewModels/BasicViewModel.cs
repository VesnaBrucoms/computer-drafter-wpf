using Computer_Drafter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.ViewModels
{
    class BasicViewModel : INotifyPropertyChanged
    {
        private CpuModel cpu;
        private MotherboardModel motherboard;

        #region ModelProperties
        public string CpuName
        {
            get { return cpu.Name; }
            set
            {
                cpu.Name = value;
                OnPropertyChanged("CpuName");
            }
        }

        public decimal CpuPrice
        {
            get { return cpu.Price; }
            set
            {
                cpu.Price = value;
                OnPropertyChanged("CpuPrice");
            }
        }

        public List<string> GetCpuBrandList
        {
            get { return cpu.Brand; }
        }

        public string SetCpuBrand
        {
            get { return cpu.SelectedBrand; }
            set
            {
                cpu.SelectedBrand = value;
                OnPropertyChanged("SetCpuBrand");
                OnPropertyChanged("GetCpuSocketList");
                OnPropertyChanged("GetMotherboardChipsetList");
            }
        }

        public List<string> GetCpuCoresList
        {
            get { return cpu.Cores; }
        }

        public string SetCpuCores
        {
            get { return cpu.SelectedCores; }
            set
            {
                cpu.SelectedCores = value;
                OnPropertyChanged("SetCpuCores");
            }
        }

        public string CpuClock
        {
            get { return cpu.Clock; }
            set
            {
                cpu.Clock = value;
                OnPropertyChanged("CpuClock");
            }
        }

        public List<string> GetCpuSocketList
        {
            get
            {
                if (cpu.SelectedBrand == "AMD")
                    return cpu.AmdSockets;
                else if (cpu.SelectedBrand == "Intel")
                    return cpu.IntelSockets;
                else
                    return new List<string>();
            }
        }

        public string SetCpuSocket
        {
            get { return cpu.Sockets; }
            set
            {
                cpu.Sockets = value;
                OnPropertyChanged("SetCpuSocket");
            }
        }

        public string MotherboardName
        {
            get { return motherboard.Name; }
            set
            {
                motherboard.Name = value;
                OnPropertyChanged("MotherboardName");
            }
        }

        public decimal MotherboardPrice
        {
            get { return motherboard.Price; }
            set
            {
                motherboard.Price = value;
                OnPropertyChanged("MotherboardPrice");
            }
        }

        public List<string> GetMotherboardChipsetList
        {
            get
            {
                if (cpu.SelectedBrand == "AMD")
                    return motherboard.AmdChipsets;
                else if (cpu.SelectedBrand == "Intel")
                    return motherboard.IntelChipsets;
                else
                    return new List<string>();
            }
        }

        public string SetMotherboardChipset
        {
            get { return motherboard.SelectedChipset; }
            set
            {
                motherboard.SelectedChipset = value;
                OnPropertyChanged("SetMotherboardChipset");
            }
        }

        public List<string> GetMotherboardMemCapList
        {
            get { return motherboard.MemoryCapacities; }
        }

        public string SetMotherboardMemCap
        {
            get { return motherboard.SelectedMemoryCapacity; }
            set
            {
                motherboard.SelectedMemoryCapacity = value;
                OnPropertyChanged("SetMotherboardMemCap");
            }
        }

        public List<string> GetMotherboardMemTypeList
        {
            get { return motherboard.MemoryTypes; }
        }

        public string SetMotherboardMemType
        {
            get { return motherboard.SelectedMemoryType; }
            set
            {
                motherboard.SelectedMemoryType = value;
                OnPropertyChanged("SetMotherboardMemType");
            }
        }

        public List<string> GetMotherboardMemFreqList
        {
            get { return motherboard.MemoryFrequencies; }
        }

        public string SetMotherboardMemFreq
        {
            get { return motherboard.SelectedMemoryFreq; }
            set
            {
                motherboard.SelectedMemoryFreq = value;
                OnPropertyChanged("SetMotherboardMemFreq");
            }
        }
        #endregion

        #region CommandProperties
        #endregion

        public BasicViewModel(MainWindowViewModel parent)
        {
            parent.DraftOpened += new MainWindowViewModel.NewDraftEventHandler(newComputerDraftUpdateProperties);

            cpu = parent.GetComputer.GetCpu;
            motherboard = parent.GetComputer.GetMotherboard;
        }

        private void newComputerDraftUpdateProperties()
        {
            //
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
