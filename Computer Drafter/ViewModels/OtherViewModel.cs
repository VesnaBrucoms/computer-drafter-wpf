using Computer_Drafter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.ViewModels
{
    class OtherViewModel : INotifyPropertyChanged
    {
        private OsModel osModel;

        #region ModelProperties
        public string OsName
        {
            get { return osModel.Name; }
            set
            {
                osModel.Name = value;
                OnPropertyChanged("OsName");
            }
        }

        public decimal OsPrice
        {
            get { return osModel.Price; }
            set
            {
                osModel.Price = value;
                OnPropertyChanged("OsPrice");
            }
        }
        #endregion

        public OtherViewModel(MainWindowViewModel parent)
        {
            parent.DraftOpened += new MainWindowViewModel.NewDraftEventHandler(newComputerDraftUpdateProperties);

            osModel = parent.GetComputer.GetOs;
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
