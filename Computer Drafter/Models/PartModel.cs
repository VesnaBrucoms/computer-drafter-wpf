using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    /// <summary>
    /// The basic data shared by all computer part classes.
    /// </summary>
    abstract class PartModel
    {
        protected string name;
        protected decimal price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
