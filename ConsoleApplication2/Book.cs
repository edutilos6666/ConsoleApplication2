using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    struct  Book
    {
        public String Title { get; set; }
        public double Price { get; set; }
        public DateTime Bd { get; set; }

        public Book(String title , double price , DateTime bd)
        {
            this.Title = title;
            this.Price = price;
            this.Bd = bd; 
        }

       public String ToString()
        {
            return String.Format("{0}, {1}, {2}", this.Title, this.Price, this.Bd); 
        }


        public bool CompareTo(Book other)
        {
            if (this.Price > other.Price) return true;
            return false; 
        }


        public static Book operator+(Book first , Book second)
        {
            Book res = new Book();
            res.Title = first.Title + " " + second.Title;
            res.Price = first.Price + second.Price;
            DateTime bd1 = first.Bd;
            DateTime bd2 = second.Bd;
            TimeSpan diff = bd2.Subtract(bd1);
            res.Bd = bd1.Add(diff);  //bd2   
            return res; 
        }
    }
}
