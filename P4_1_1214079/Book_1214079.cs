using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214079
{
    internal class Book_1214079 : Product
    {
        protected string pageCount; // menghitung halaman buku//

        public Book_1214079(string Type, string title, string pagecount) : base(Type,title) // 3 paramenter //
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }
    }
}
