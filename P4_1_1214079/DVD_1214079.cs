using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214079
{
    internal class DVD_1214079 : Product
    {
        protected string duration;

        public DVD_1214079(string title, string duration) // method constructor dengan 2 parameter
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this.duration = duration;

            Console.WriteLine("Ini dari Class DVD!!");
        }

        public string Duration
        {
            get { return this.duration; }
            set { duration = value; }
        }
    }
}
