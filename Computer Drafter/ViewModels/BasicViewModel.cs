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

        public string MotherboardChipset
        {
            get { return motherboard.Chipset; }
            set
            {
                motherboard.Chipset = value;
                OnPropertyChanged("MotherboardChipset");
            }
        }

        public string MotherboardMemCap
        {
            get { return motherboard.MemoryCapacity; }
            set
            {
                motherboard.MemoryCapacity = value;
                OnPropertyChanged("MotherboardMemCap");
            }
        }

        public string MotherboardMemType
        {
            get { return motherboard.MemoryType; }
            set
            {
                motherboard.MemoryType = value;
                OnPropertyChanged("MotherboardMemType");
            }
        }

        public string MotherboardMemFreq
        {
            get { return motherboard.MemoryFrequancy; }
            set
            {
                motherboard.MemoryFrequancy = value;
                OnPropertyChanged("MotherboardMemFreq");
            }
        }
        #endregion

        #region CommandProperties
        #endregion

        public BasicViewModel()
        {
            cpu = new CpuModel();
            motherboard = new MotherboardModel();
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
