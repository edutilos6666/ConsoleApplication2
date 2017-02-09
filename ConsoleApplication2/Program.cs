using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // testVariables();
            //  testUserInput();

            //   TestPerson();
            TestComplexNumber(); 
        }



        private static void TestComplexNumber()
        {
            ComplexNumber c1 = new ComplexNumber(10, 20);
            Console.WriteLine(c1.ToString());

            ComplexNumber c2 = new ComplexNumber(20, 30);

            ComplexNumber cAdd = c1.Add(c2);
            ComplexNumber cSubtract = c1.Subtract(c2);
            ComplexNumber cMultiply = c1.Multiply(c2);
            ComplexNumber cDivide = c1.Divide(c2);
            Console.WriteLine("cAdd = {0}", cAdd.ToString());
            Console.WriteLine("cSubtract = {0}", cSubtract.ToString());
            Console.WriteLine("cMultiply = {0}", cMultiply.ToString());
            Console.WriteLine("cDivide = {0}", cDivide.ToString()); 
        }

        private static void TestPerson()
        {
            Person p1, p2;
            p1 = new Person("foo", 10, 100.0);
            p2 = new Person("bar", 20, 200.0);
            p1.PrintPrrops();
            p2.PrintPrrops();
        }

      

        private static void testUserInput()
        {
            int age;
            double wage;
            string name;
            bool active;
            Console.WriteLine("insert age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert wage: ");
            wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insert name: ");
            name = Console.ReadLine();
            Console.WriteLine("insert active: "); 
            active = Convert.ToBoolean(Console.ReadLine());

            string format = "age = {0}{1}wage = {2}{1}name = {3}{1}active = {4}";
            const string nl = "\r\n";
            Console.WriteLine(format, age, nl, wage,  name, active); 
        }

        private static void testVariables()
        {
            int n1;
            long n5; 
            double n2;
            float n3;
            bool n4;
            string n6;
            n1 = 10;
            n2 = 20;
            n3 = 30;
            n4 = false ;
            n5 = 50;
            n6 = "hello world";
            object[] arr = { n1, n2, n3, n4, n5, n6 };
            object[] names = { "int", "double", "float", "bool", "long", "string" }; 
            Console.WriteLine("<<printing all variables>>"); 
            for(int i=0; i< arr.Length; ++i)
            {
                Console.WriteLine("{0} => {1}", names[i], arr[i]); 
            }
        }

    }
}
