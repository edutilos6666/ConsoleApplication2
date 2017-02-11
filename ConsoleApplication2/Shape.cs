using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Shape
    {
        public abstract double Area();
        public abstract String TypeOfShape(); 
    }

    class Rectangle: Shape 
    {
        public Double Width { get; set;  }
        public Double Height { get; set;  }

        public Rectangle(double width , double height)
        {
            this.Width = width;
            this.Height = height; 
        }

        public override double Area()
        {
            return this.Width * this.Height; 
        }

        public override string TypeOfShape()
        {
            return "Rectangle"; 
        }
    }

    class Triangle: Shape 
    {
        public Double X { get; set;  }
        public Double Y { get; set;  }
        public Double Z { get; set;  }
        
        public Triangle(double x , double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z; 
        }

        public override double Area()
        {
            double res;
            double s = (this.X + this.Y + this.Z) / 2;
            res = Math.Sqrt(s * (s - X) * (s - Y) * (s - Z));
            return res; 
        }

        public override string TypeOfShape()
        {
            return "Triangle"; 
        }
    }

    class Circle : Shape
    {

        public Double R { get; set; }
        public Circle(double r)
        {
            this.R = r; 
        }

        public override double Area()
        {
            return Math.Pow(this.R, 2) * Math.PI; 
        }

        public override string TypeOfShape()
        {
            return "Circle"; 
        }
    }
}
