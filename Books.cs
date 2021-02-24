using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInnerJoinDemo
{
    class Books
    {
        public int Bid { get; set; }
        public string Bname { get; set; }
        public string Author { get; set; }

        public Books(int bid , string bname , string author)
        {
            this.Bid = bid;
            this.Bname = bname;
            this.Author = author;
        }
    }
}
