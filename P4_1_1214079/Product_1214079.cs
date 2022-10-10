using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214079
{
    public class Product // best claasss
    {
        //protected string myType = "Book";
        private string myType;
        private string myTitle;

        public Product()
        {

        }

        public Product(string myType, string myTitle) // method constructor// parameter //
        {
            this.myType = myType;
            this.myTitle = myTitle;
           
        }

        public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }
            public string MyTitle
            {
            get
            {
                return myTitle;
            }
            set
            {
               myTitle = value;
            }
        }
    }
}
