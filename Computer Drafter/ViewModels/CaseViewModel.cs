using Computer_Drafter.Models;
using Computer_Drafter.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.ViewModels
{
    class CaseViewModel : INotifyPropertyChanged
    {
        private CaseModel caseModel;

        #region ModelProperties
        public string CaseName
        {
            get { return caseModel.Name; }
            set
            {
                caseModel.Name = value;
                OnPropertyChanged("CaseName");
            }
        }

        public decimal CasePrice
        {
            get { return caseModel.Price; }
            set
            {
                caseModel.Price = value;
                OnPropertyChanged("CasePrice");
            }
        }

        public List<string> GetCaseFormsList
        {
            get { return caseModel.GetForms; }
        }

        public string SetCaseForm
        {
            get { return caseModel.SelectedForm; }
            set
            {
                caseModel.SelectedForm = value;
                OnPropertyChanged("SetCaseForm");
            }
        }

        public List<string> GetCaseBayNumbersList
        {
            get { return caseModel.GetBayNumbers; }
        }

        public string SetCaseFiveBays
        {
            get { return caseModel.SelectedFiveBays; }
            set
            {
                caseModel.SelectedFiveBays = value;
                OnPropertyChanged("SetCaseFiveBays");
            }
        }

        public string SetCaseThreeBays
        {
            get { return caseModel.SelectedThreeBays; }
            set
            {
                caseModel.SelectedThreeBays = value;
                OnPropertyChanged("SetCaseThreeBays");
            }
        }

        public string SetCaseTwoBays
        {
            get { return caseModel.SelectedTwoBays; }
            set
            {
                caseModel.SelectedTwoBays = value;
                OnPropertyChanged("SetCaseTwoBays");
            }
        }

        public bool CaseAcceptsItx
        {
            get { return caseModel.AcceptsItx; }
            set
            {
                caseModel.AcceptsItx = value;
                OnPropertyChanged("CaseAcceptsItx");
            }
        }

        public bool CaseAcceptsMatx
        {
            get { return caseModel.AcceptsMatx; }
            set
            {
                caseModel.AcceptsMatx = value;
                OnPropertyChanged("CaseAcceptsMatx");
            }
        }

        public bool CaseAcceptsAtx
        {
            get { return caseModel.AcceptsAtx; }
            set
            {
                caseModel.AcceptsAtx = value;
                OnPropertyChanged("CaseAcceptsAtx");
            }
        }

        public bool CaseAcceptsEatx
        {
            get { return caseModel.AcceptsEatx; }
            set
            {
                caseModel.AcceptsEatx = value;
                OnPropertyChanged("CaseAcceptsEatx");
            }
        }

        public bool CaseHasUsbThree
        {
            get { return caseModel.HasUsbThree; }
            set
            {
                caseModel.HasUsbThree = value;
                OnPropertyChanged("CaseHasUsbThree");
            }
        }

        public bool CaseHasPsu
        {
            get { return caseModel.HasPsu; }
            set
            {
                caseModel.HasPsu = value;
                OnPropertyChanged("CaseHasPsu");
            }
        }

        public bool CaseHasWindow
        {
            get { return caseModel.HasWindow; }
            set
            {
                caseModel.HasWindow = value;
                OnPropertyChanged("CaseHasWindow");
            }
        }

        public bool CaseIsToolless
        {
            get { return caseModel.IsToolless; }
            set
            {
                caseModel.IsToolless = value;
                OnPropertyChanged("CaseIsToolless");
            }
        }
        #endregion

        #region CommandProperties
        #endregion

        public CaseViewModel(MainWindowViewModel parent)
        {
            parent.DraftOpened += new MainWindowViewModel.NewDraftEventHandler(newComputerDraftUpdateProperties);

            caseModel = parent.GetComputer.GetCase;
        }

        private void newComputerDraftUpdateProperties()
        {
            //
        }

        #region Commands
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
