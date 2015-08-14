using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    class PsuModel : PartModel
    {
        private List<string> types;
        private string selTypes;
        private List<string> forms;
        private string selForms;
        private string wattage;

        #region Properties
        public List<string> GetTypes
        {
            get { return types; }
        }

        public string SelectedType
        {
            get { return selTypes; }
            set { selTypes = value; }
        }

        public List<string> GetForms
        {
            get { return forms; }
        }

        public string SelectedForm
        {
            get { return selForms; }
            set { selForms = value; }
        }

        public string Wattage
        {
            get { return wattage; }
            set { wattage = value; }
        }
        #endregion

        public PsuModel()
        {
            types = new List<string>();
            types.Add("Non-modular");
            types.Add("Hybrid modular");
            types.Add("Full modular");

            forms = new List<string>();
            forms.Add("Mini-ITX");
            forms.Add("Micro-ATX");
            forms.Add("ATX");
        }
    }
}
