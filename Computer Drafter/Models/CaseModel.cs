using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class CaseModel : PartModel
    {
        private List<string> forms;
        private string selForm;
        private List<string> bayNumbers;
        private string selFiveBays;
        private string selThreeBays;
        private string selTwoBays;
        private bool acceptsItx;
        private bool acceptsMatx;
        private bool acceptsAtx;
        private bool acceptsEatx;
        private bool hasUsbThree;
        private bool hasPsu;
        private bool hasWindow;
        private bool isToolless;

        #region Properties
        public List<string> GetForms
        {
            get { return forms; }
        }

        public string SelectedForm
        {
            get { return selForm; }
            set { selForm = value; }
        }

        public List<string> GetBayNumbers
        {
            get { return bayNumbers; }
        }

        public string SelectedFiveBays
        {
            get { return selFiveBays; }
            set { selFiveBays = value; }
        }

        public string SelectedThreeBays
        {
            get { return selThreeBays; }
            set { selThreeBays = value; }
        }

        public string SelectedTwoBays
        {
            get { return selTwoBays; }
            set { selTwoBays = value; }
        }

        public bool AcceptsItx
        {
            get { return acceptsItx; }
            set { acceptsItx = value; }
        }

        public bool AcceptsMatx
        {
            get { return acceptsMatx; }
            set { acceptsMatx = value; }
        }

        public bool AcceptsAtx
        {
            get { return acceptsAtx; }
            set { acceptsAtx = value; }
        }

        public bool AcceptsEatx
        {
            get { return acceptsEatx; }
            set { acceptsEatx = value; }
        }

        public bool HasUsbThree
        {
            get { return hasUsbThree; }
            set { hasUsbThree = value; }
        }

        public bool HasPsu
        {
            get { return hasPsu; }
            set { hasPsu = value; }
        }

        public bool HasWindow
        {
            get { return hasWindow; }
            set { hasWindow = value; }
        }

        public bool IsToolless
        {
            get { return isToolless; }
            set { isToolless = value; }
        }
        #endregion

        public CaseModel()
        {
            forms = new List<string>();
            forms.Add("Mini-ITX");
            forms.Add("Micro-ATX");
            forms.Add("ATX");
            forms.Add("E-ATX");

            bayNumbers = new List<string>();
            bayNumbers.Add("1");
            bayNumbers.Add("2");
            bayNumbers.Add("3");
            bayNumbers.Add("4");
            bayNumbers.Add("5");
            bayNumbers.Add("6");
            bayNumbers.Add("7");
            bayNumbers.Add("8");
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
