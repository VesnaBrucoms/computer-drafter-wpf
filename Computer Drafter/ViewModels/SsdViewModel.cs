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

        public SsdViewModel(MainWindowViewModel parent)
        {
            parent.DraftOpened += new MainWindowViewModel.NewDraftEventHandler(newComputerDraftUpdateProperties);

            ssdModels = parent.GetComputer.GetSsds;
        }

        private void newComputerDraftUpdateProperties()
        {
            //
        }

        #region Commands
        private void AddSsd(object parameter)
        {
            ssdModels.Add(new SsdModel());
            ssdModels[ssdModels.Count - 1].PartNumber = ssdModels.Count;
        }

        private bool CanAddSsd()
        {
            return true;
        }

        private void RemoveSsd(object parameter)
        {
            SsdModel model = (SsdModel)parameter;
            ssdModels.Remove(model);

            int count = 0;
            foreach (SsdModel module in ssdModels)
            {
                if (module.PartNumber - 1 != count)
                    module.PartNumber = count + 1;

                count++;
            }
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
