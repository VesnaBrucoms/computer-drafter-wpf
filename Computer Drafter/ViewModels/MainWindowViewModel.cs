using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.ViewModels
{
    class MainWindowViewModel
    {
        private string windowTitle;
        private string loadedDraft;

        public string GetWindowTitle
        {
            get { return loadedDraft + " - " + windowTitle; }
        }

        public MainWindowViewModel()
        {
            windowTitle = "Computer Drafter";
            loadedDraft = "test";
            OnPropertyChanged("GetWindowTitle");
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
