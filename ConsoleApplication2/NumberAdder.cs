using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class NumberAdder
    {
        public double Width { get; set;  }
        public double Height { get; set;  }
        public NumberAdder(double width, double height)
        {
            this.Width = width;
            this.Height = height; 
        }

        public NumberAdder()
        {

        }
        public static NumberAdder operator+(NumberAdder first , NumberAdder second)
        {
            NumberAdder res = new NumberAdder(); 
            res.Width = first.Width + second.Width;
            res.Height = first.Height + second.Height; 
            return res; 
        }

        public static NumberAdder operator-(NumberAdder first, NumberAdder second)
        {
            double w = first.Width - second.Width;
            double h = first.Height - second.Height; 
            NumberAdder res = new NumberAdder(w, h);
            return res; 
        }

        public static NumberAdder operator*(NumberAdder first, NumberAdder second)
        {
            double h = first.Height * second.Height;
            double w = first.Width * second.Width;
            return new NumberAdder(w, h); 
        }

        public static NumberAdder operator/(NumberAdder first, NumberAdder second)
        {
            double w = first.Width / second.Width;
            double h = first.Height / second.Height;
            return new NumberAdder(w, h); 
        }


        public String ToString()
        {
            return String.Format("[{0}, {1}]", Width, Height); 
        }
    }
}
