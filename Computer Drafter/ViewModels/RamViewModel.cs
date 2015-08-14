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
        #endregion

        public RamViewModel()
        {
            ramModules = new ObservableCollection<RamModel>();
        }

        private void AddModule(object parameter)
        {
            ramModules.Add(new RamModel());
        }

        private bool CanAddModule()
        {
            return true;
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
