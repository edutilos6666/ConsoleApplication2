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
            //TestComplexNumber(); 
            //EvenOrOdd(); 
            //SwapNumbers(); 
            // SumOfDigits(); 
            //ReverseNumber(); 
            // BinaryTriangle(); 
            //TestNumberSystemConverter(); 
            Count1s(); 
        }


        private static void Count1s()
        {
            int n;
            Console.WriteLine("insert integer: ");
            n = Convert.ToInt32(Console.ReadLine());
            String str = n.ToString();
            int i = 0; 
            foreach(var ch in str)
            {
                if (ch == '1') ++i; 
            }

            Console.WriteLine("number of 1s in {0} = {1}", n, i); 
        }

        private static void TestNumberSystemConverter()
        {
            String input = "123456";
            String output = NumberSystemConverter.DecimalToBinary(input);
            Console.WriteLine("dec: {0} =>  bin: {1}", input, output);
            String input2 = output;
            output = NumberSystemConverter.BinaryToDecimal(input2);
            Console.WriteLine("bin: {0} => dec: {1}", input2, output); 
           // input = "123456";
            output = NumberSystemConverter.DecimalToOctal(input); 
            Console.WriteLine("dec: {0} => octal: {1} ", input, output);
            input2 = output;
            output = NumberSystemConverter.OctalToDecimal(input2);
            Console.WriteLine("octal: {0} => dec: {1}", input2, output); 

            output = NumberSystemConverter.DecimalToHex(input);
            Console.WriteLine("dec: {0} => hex: {1}", input, output);
            input2 = output;
            output = NumberSystemConverter.HexToDecimal(input2);
            Console.WriteLine("hex: {0} => dec: {1}", input2, output);

            //binary to hex 
            input = "123456";
            input = NumberSystemConverter.DecimalToBinary(input);
            output = NumberSystemConverter.BinaryToHex(input);
            Console.WriteLine("bin: {0} => hex: {1}", input, output);
            //hex to binary 
            input = output;
            output = NumberSystemConverter.HexToBinary(input);
            Console.WriteLine("hex: {0} => bin: {1}", input, output); 
        }

        private static void BinaryTriangle()
        {
            int rows = 0;
            Console.WriteLine("Enter rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            builder.Append('1');
            Console.WriteLine(builder.ToString());
            for (int i=1; i< rows; ++i)
            {
                char[] arr = builder.ToString().ToCharArray(); 
                if(arr[arr.Length-1] == '0')
                {
                    builder.Append('1'); 
                } else
                {
                    builder.Append('0'); 
                }
                Console.WriteLine(builder.ToString());
            }
        }


        private static void ReverseNumber()
        {
            int n;
            Console.WriteLine("Insert your integer number: ");
            n = Convert.ToInt32(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            int rest = 0; 
            while(n > 0 )
            {
                rest = n % 10;
                n /= 10;
                builder.Append(rest); 
                
            }

            Console.WriteLine("Reversed Number = {0}", builder.ToString());


            double n2;
            Console.WriteLine("Insert your double number: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("n2 = {0}", n2.ToString()); 
            IEnumerable<char> str = n2.ToString().Reverse();
            StringBuilder builder2 = new StringBuilder();
            foreach (var ch in str)
                builder2.Append(ch); 
            Console.WriteLine("Reversed n2 = {0}", builder2.ToString()); 
        }
        private static void SumOfDigits()
        {
            int n;
            Console.WriteLine("Insert your integer number: ");
            n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int rest = 0; 
            while(n > 0 )
            {
                rest = n % 10;
                sum += rest;
                n = n / 10; 
            }

            Console.WriteLine("Sum of digits = {0}", sum); 
        }

        private static void SwapNumbers()
        {
            double n1 , n2;
            Console.WriteLine("first number: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("second number: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Before swap: n1 = {0}, n2 = {1}", n1, n2);
            double temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("After swap: n1 = {0}, n2 = {1}", n1, n2); 
        }

        private static void EvenOrOdd()
        {
            double number;
            Console.WriteLine("Enter your number: ");
            number = Convert.ToDouble(Console.ReadLine());
            int rest = Convert.ToInt32(number % 2);
            if (rest == 0) Console.WriteLine("Number is even.");
            else if (rest == 1) Console.WriteLine("Number is odd."); 
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
