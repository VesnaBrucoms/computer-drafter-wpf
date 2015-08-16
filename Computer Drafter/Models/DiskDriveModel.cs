using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class DiscDriveModel : PartModel, IMultiPartModel, INotifyPropertyChanged
    {
        private int number;
        private List<string> types;
        private string selType;

        #region Properties
        public DiscDriveModel GetInstance
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
            get { return "Disk drive " + number; }
        }

        public List<string> GetTypes
        {
            get { return types; }
        }

        public string SelectedType
        {
            get { return selType; }
            set { selType = value; }
        }
        #endregion

        public DiscDriveModel()
        {
            types = new List<string>();
            types.Add("CD-ROM");
            types.Add("CD-R");
            types.Add("CD-RW");
            types.Add("DVD-ROM");
            types.Add("DVD-R");
            types.Add("DVD-RW");
            types.Add("BD-ROM");
            types.Add("BD-R");
            types.Add("BD-RE");
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
