using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInnerJoinDemo
{
    class Sales
    {
        public int Sid { get; set; }
        public DateTime SDate { get; set; }
        public decimal Price { get; set; }
        public string Bname { get; set; }

        public Sales(int s_id, DateTime date, decimal price, string bname)
        {
            this.Sid = s_id;
            this.SDate = date;
            this.Price = price;
            this.Bname = bname;
        }
    }
}
