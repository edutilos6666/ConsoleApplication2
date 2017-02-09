using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    
    /*
     *  a + i*x 
     * 
     */
    class ComplexNumber
    {
        private double re, im; 

        public ComplexNumber(double re, double im)
        {
            this.re = re;
            this.im = im; 
        }

        private ComplexNumber()
        {
            this.re = 0;
            this.im = 0; 
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            ComplexNumber res = new ComplexNumber();
            res.re = this.re + other.re;
            res.im = this.im + other.im; 
            return res ; 
        }

        public ComplexNumber Subtract(ComplexNumber other)
        {
            ComplexNumber res = new ComplexNumber();
            res.re = this.re - other.re;
            res.im = this.im - other.im; 
            return res ; 
        }

        public ComplexNumber Multiply(ComplexNumber other)
        {
            ComplexNumber res = new ComplexNumber();
            res.re = this.re * other.re - this.im * other.im;
            res.im = this.re * other.im + this.im * other.re;
            return res ; 
        }

        public ComplexNumber Divide(ComplexNumber other)
        {
            ComplexNumber temp1 = new ComplexNumber(other.re, -other.im);
            ComplexNumber temp2 = this.Multiply(temp1);
            double q = Math.Pow(other.re, 2) + Math.Pow(other.im, 2);
            temp2.re = temp2.re / q;
            temp2.im = temp2.im / q;              
            return temp2; 
        }


        public ComplexNumber Add(double re, double im)
        {
            return this.Add(new ComplexNumber(re, im)); 
        }

        public ComplexNumber Subtract(double re, double im)
        {
            return this.Subtract(new ComplexNumber(re, im)); 
        }

        public ComplexNumber Multiply(double re, double im)
        {
            return this.Multiply(new ComplexNumber(re, im)); 
        }
        public ComplexNumber Divide(double re, double im)
        {
            return this.Divide(new ComplexNumber(re, im)); 
        }

        public String ToString()
        {
            return String.Format("{0} + {1}*i", re, im); 
        }
    }
}
