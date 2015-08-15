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
    class RamViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<RamModel> ramModules;

        #region Properties
        public ObservableCollection<RamModel> GetRamModules
        {
            get { return ramModules; }
        }
        #endregion

        #region CommandProperties
        public ICommand AddModuleCommand
        {
            get { return new DelegateCommand(AddModule, CanAddModule); }
        }

        public ICommand RemoveModuleCommand
        {
            get { return new DelegateCommand(RemoveModule, CanRemoveModule); }
        }
        #endregion

        public RamViewModel()
        {
            ramModules = new ObservableCollection<RamModel>();
        }

        #region Commands
        private void AddModule(object parameter)
        {
            ramModules.Add(new RamModel());
            ramModules[ramModules.Count - 1].PartNumber = ramModules.Count;
        }

        private bool CanAddModule()
        {
            return true;
        }

        private void RemoveModule(object parameter)
        {
            int moduleNumber = (int)parameter;
            //Console.WriteLine("YAY!" + moduleNumber);
            ramModules.RemoveAt(moduleNumber - 1);

            int count = 0;
            foreach (RamModel module in ramModules)
            {
                if (module.PartNumber - 1 != count)
                    module.PartNumber = count + 1;

                count++;
            }
        }

        private bool CanRemoveModule()
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
