using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Person
    {
        private String name;
        private int age;
        private double wage; 

        public Person(String name, int age, double wage)
        {
            this.name = name;
            this.age = age;
            this.wage = wage; 
        }

        public Person()
        {
            this.name = "";
            this.age = 0;
            this.wage = 0.0; 
        }

        public void PrintPrrops()
        {
            Console.WriteLine("name = {0}", name);
            Console.WriteLine("age = {0}", age);
            Console.WriteLine("wage = {0}", wage); 
        }
    }
}
