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
            testVariables();
            testUserInput(); 
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
