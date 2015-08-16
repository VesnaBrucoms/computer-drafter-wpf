using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class SsdModel : PartModel, IMultiPartModel, INotifyPropertyChanged
    {
        private int number;
        private string capacity;
        private string read;
        private string write;
        private string selConnection;

        #region Properties
        private SsdModel GetInstance
        {
            get { return this; }
        }

        public int PartNumber
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged("PartNumber");
                OnPropertyChanged("PartNumberString");
            }
        }

        public string PartNumberString
        {
            get { return "Drive " + number; }
        }

        public string Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string Read
        {
            get { return read; }
            set { read = value; }
        }

        public string Write
        {
            get { return write; }
            set { write = value; }
        }

        public List<string> GetConnections
        {
            get { return DriveData.GetConnections; }
        }

        public string SelectedConnection
        {
            get { return selConnection; }
            set { selConnection = value; }
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
