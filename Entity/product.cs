using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStock.Entity
{
    class product
    {
        private string name;
        private int amount;
        private float price;

        public product() { }
        public product(String productName)
        {
            name = productName;
        }
        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public override string ToString()
        {
            return "" + Name;
        }



    }
}
