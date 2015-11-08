using Computer_Drafter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.ViewModels
{
    class PsuViewModel : INotifyPropertyChanged
    {
        private PsuModel psuModel;

        #region ModelProperties
        public string PsuName
        {
            get { return psuModel.Name; }
            set
            {
                psuModel.Name = value;
                OnPropertyChanged("PsuName");
            }
        }

        public decimal PsuPrice
        {
            get { return psuModel.Price; }
            set
            {
                psuModel.Price = value;
                OnPropertyChanged("PsuPrice");
            }
        }

        public List<string> GetPsuTypesList
        {
            get { return psuModel.GetTypes; }
        }

        public string SetPsuType
        {
            get { return psuModel.SelectedType; }
            set
            {
                psuModel.SelectedType = value;
                OnPropertyChanged("SetPsuType");
            }
        }

        public List<string> GetPsuFormsList
        {
            get { return psuModel.GetForms; }
        }

        public string SetPsuForm
        {
            get { return psuModel.SelectedForm; }
            set
            {
                psuModel.SelectedForm = value;
                OnPropertyChanged("SetPsuForm");
            }
        }

        public string PsuWattage
        {
            get { return psuModel.Wattage; }
            set
            {
                psuModel.Wattage = value;
                OnPropertyChanged("PsuWattage");
            }
        }
        #endregion

        #region CommandProperties
        #endregion

        public PsuViewModel(MainWindowViewModel parent)
        {
            parent.DraftOpened += new MainWindowViewModel.NewDraftEventHandler(newComputerDraftUpdateProperties);

            psuModel = parent.GetComputer.GetPsu;
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
