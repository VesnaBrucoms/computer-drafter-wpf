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
    class SsdViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<SsdModel> ssdModels;

        #region ModelProperties
        public ObservableCollection<SsdModel> GetSsdModels
        {
            get { return ssdModels; }
        }
        #endregion

        #region CommandProperties
        public ICommand AddSsdCommand
        {
            get { return new DelegateCommand(AddSsd, CanAddSsd); }
        }

        public ICommand RemoveSsdCommand
        {
            get { return new DelegateCommand(RemoveSsd, CanRemoveSsd); }
        }
        #endregion

        #region Commands
        private void AddSsd(object parameter)
        {
            //
        }

        private bool CanAddSsd()
        {
            return true;
        }

        private void RemoveSsd(object parameter)
        {
            //
        }

        private bool CanRemoveSsd()
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
