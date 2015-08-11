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

        public string CpuBrand
        {
            get { return cpu.Brand; }
            set
            {
                cpu.Brand = value;
                OnPropertyChanged("CpuBrand");
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
