using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stationary_Shop
{
    public class Product
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        string product;

        public string Product1
        {
            get { return product; }
            set { product = value; }
        }
        string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        string taxtype;

        public string Taxtype
        {
            get { return taxtype; }
            set { taxtype = value; }
        }
        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public override string ToString()
        {
            return string.Format(" Id : {0} \n Product : {1} \n Category : {2}  \n Price : {3} \n TaxType : {4} \n Status : {5} ", this.id, this.product, this.category, this.price, this.taxtype, this.status);
        }

        public Product(int Id, string product, string category, float price, string taxtype, string status)
        {
            this.id = Id;
            this.product = product;
            this.category = category;
            this.price = price;
            this.taxtype = taxtype;
            this.status = status;
        }

        public Product()
        {
 
        }

    }
}
