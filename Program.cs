using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInnerJoinDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Books> bookList = new List<Books>()
            {
                new Books(1,"Wings of Fire" , "Dr. A P J Abdul Kalam"),
                new Books(2, "Harry Potter" , "J.K. Rowling"),
                new Books(3, "Animal Farm" , "George Orwell"),
                new Books(4, "Mein Kampf" , "Adolf Hitler"),
                new Books(5, "Alice in WonderLand", "Lewis Caroll")
            };

            List<Sales> salesList = new List<Sales>()
            {
                new Sales(101 , new DateTime(2020,01,20) , 1600 ,  "Wings of Fire"),
                new Sales(102, new DateTime(2021,02,10) , 1000 , "Animal Farm"),
                new Sales(103, new DateTime(2020 , 12,11) , 1300 , "Alice in WonderLand")
            };

            var joinQuery = from book in bookList 
                            from sale in salesList 
                            where book.Bname == sale.Bname select new { book , sale};

            foreach(var item in joinQuery)
            {
                Console.WriteLine("Sales ID : " + item.sale.Sid + 
                                    " \nBook Name : "+ item.book.Bname +
                                        "\nAuthor  : " + item.book.Author +
                                            "\nPrice : " +item.sale.Price +"\n");
            }

            Console.ReadKey();
         }
    }
}
