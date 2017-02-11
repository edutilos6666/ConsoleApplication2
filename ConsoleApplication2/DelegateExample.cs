using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SimpleMath 
    {
        public static int Add(int n1 , int n2)
        {
            return n1 + n2; 
        }

        public static int Subtract(int n1 , int n2)
        {
            return n1 - n2; 
        }

        public static int Multiply(int n1 , int n2)
        {
            return n1 * n2; 
        }

        public static int Divide(int n1, int n2)
        {
            return n1 / n2; 
        }
    }


    delegate int MathDelegate(int number1 , int number2);

   
}
