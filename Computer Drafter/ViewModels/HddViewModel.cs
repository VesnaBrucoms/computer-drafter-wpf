using Computer_Drafter.Models;
using Computer_Drafter.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Computer_Drafter.ViewModels
{
    class HddViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<HddModel> hddModels;

        #region ModelProperties
        public ObservableCollection<HddModel> GetHddModels
        {
            get { return hddModels; }
        }
        #endregion

        #region CommandProperties
        public ICommand AddHddCommand
        {
            get { return new DelegateCommand(AddHdd, CanAddHdd); }
        }

        public ICommand RemoveHddCommand
        {
            get { return new DelegateCommand(RemoveHdd, CanRemoveHdd); }
        }
        #endregion

        public HddViewModel()
        {
            hddModels = new ObservableCollection<HddModel>();
        }

        #region Commands
        private void AddHdd(object parameter)
        {
            hddModels.Add(new HddModel());
            hddModels[hddModels.Count - 1].PartNumber = hddModels.Count;
        }

        private bool CanAddHdd()
        {
            return true;
        }

        private void RemoveHdd(object parameter)
        {
            HddModel model = (HddModel)parameter;
            hddModels.Remove(model);

            int count = 0;
            foreach (HddModel module in hddModels)
            {
                if (module.PartNumber - 1 != count)
                    module.PartNumber = count + 1;

                count++;
            }
        }

        private bool CanRemoveHdd()
        {
            return true;
        }
        #endregion

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
