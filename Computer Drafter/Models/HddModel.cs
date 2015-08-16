using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class HddModel : PartModel, IMultiPartModel, INotifyPropertyChanged
    {
        private int number;
        private string capacity;
        private List<string> rpms;
        private string selRpm;
        private List<string> cache;
        private string selCache;
        private string selConnection;

        #region Properties
        public HddModel GetInstance
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

        public List<string> GetRpms
        {
            get { return rpms; }
        }

        public string SelectedRpm
        {
            get { return selRpm; }
            set { selRpm = value; }
        }

        public List<string> GetCache
        {
            get { return cache; }
        }

        public string SelectedCache
        {
            get { return selCache; }
            set { selCache = value; }
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

        public HddModel()
        {
            rpms = new List<string>();
            rpms.Add("5400");
            rpms.Add("5900");
            rpms.Add("7200");
            rpms.Add("10000");
            rpms.Add("IntelliPower");

            cache = new List<string>();
            cache.Add("8MB");
            cache.Add("16MB");
            cache.Add("32MB");
            cache.Add("64MB");
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
