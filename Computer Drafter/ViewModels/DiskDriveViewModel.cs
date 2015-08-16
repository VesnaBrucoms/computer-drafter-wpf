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
    class DiscDriveViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<DiscDriveModel> discDrives;

        #region ModelProperties
        public ObservableCollection<DiscDriveModel> GetDiscDrives
        {
            get { return discDrives; }
        }
        #endregion

        #region CommandProperties
        public ICommand AddDiscDriveCommand
        {
            get { return new DelegateCommand(AddDiscDrive, CanAddDiscDrive); }
        }

        public ICommand RemoveDiscDriveCommand
        {
            get { return new DelegateCommand(RemoveDiscDrive, CanRemoveDiscDrive); }
        }
        #endregion

        public DiscDriveViewModel()
        {
            discDrives = new ObservableCollection<DiscDriveModel>();
        }

        #region Commands
        private void AddDiscDrive(object parameter)
        {
            discDrives.Add(new DiscDriveModel());
            discDrives[discDrives.Count - 1].PartNumber = discDrives.Count;
        }

        private bool CanAddDiscDrive()
        {
            return true;
        }

        private void RemoveDiscDrive(object parameter)
        {
            DiscDriveModel model = (DiscDriveModel)parameter;
            discDrives.Remove(model);

            int count = 0;
            foreach (DiscDriveModel drive in discDrives)
            {
                if (drive.PartNumber - 1 != count)
                    drive.PartNumber = count + 1;

                count++;
            }
        }

        private bool CanRemoveDiscDrive()
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
