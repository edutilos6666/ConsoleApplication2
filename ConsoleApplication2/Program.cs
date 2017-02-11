using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections; 

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
            //Count1s(); 
            //FrequencyThe(); 
            //SwapNumbersXOR(); 
            // PrintDiamond(); 
            //PrintPrimes(); 
            // IsPositive(); 
            // MagnitudeOfInt(); 
            // ListStatistics(); 
            // NumberTriangle(); 
            //FindPerson();
            // TestLinq(); 
            // TestNumberAdder(); 
            //TestBookStruct(); 
            //TestShape(); 
            // TestSimpleInterface(); 
            TestDelegateExample(); 
        }



        private static void TestDelegateExample()
        {
            MathDelegate md1, md2, md3, md4;
            md1 = new MathDelegate(SimpleMath.Add);
            md2 = new MathDelegate(SimpleMath.Subtract);
            md3 = new MathDelegate(SimpleMath.Multiply);
            md4 = new MathDelegate(SimpleMath.Divide);

            Random rand = new Random();
            int n1 = rand.Next(1, 100),
                n2 = rand.Next(1, 100);

            int add = md1(n1, n2);
            int sub = md2(n1, n2);
            int mult = md3(n1, n2);
            int div = md4(n1, n2);

            String format = "add = {0}{1}subtract = {2}{1}multiply = {3}{1}divide = {4}";
            String nl = "\r\n";
            Console.WriteLine("n1 = {0} , n2 = {1}", n1, n2); 
            String msg = String.Format(format, add, nl, sub, mult, div);
            Console.WriteLine(msg);
        }



        private static void TestSimpleInterface()
        {
            CustomFile f1, f2, f3;

            Random rand = new Random();
            f1 = new CustomFile("foo.txt", "root", rand.Next(), true, false, false);
            f2 = new CustomFile("bar.txt", "root", rand.Next(), false, true, false);
            f3 = new CustomFile("bim.exe", "bin", rand.Next(), false, false, true);
            f1.PrettyPrint();
            f2.PrettyPrint();
            f3.PrettyPrint();
            f1.AllOnce();
            f2.AllOnce();
            f3.AllOnce(); 
        }

        private static void TestShape()
        {
            Shape s1, s2, s3;
            s1 = new Rectangle(10, 20);
            s2 = new Triangle(10, 20, 20);
            s3 = new Circle(20);

            Console.WriteLine("{0} -> {1}", s1.TypeOfShape(), s1.Area());
            Console.WriteLine("{0} -> {1}", s2.TypeOfShape(), s2.Area());
            Console.WriteLine("{0} -> {1}", s3.TypeOfShape(), s3.Area()); 

        }


        private static void TestBookStruct()
        {
            Book b1, b2;
            DateTime bd1 = new DateTime(1991, 10, 10);
            DateTime bd2 = new DateTime(1994, 11, 11);
            b1 = new Book("foo", 10, bd1);
            b2 = new Book("bar", 20, bd2);

            Console.WriteLine("Printing books: ");
            Console.WriteLine("{0}", b1.ToString());
            Console.WriteLine("{0}", b2.ToString());

            Book sum = b1 + b2;
            Console.WriteLine("sum of books = {0}", sum.ToString()); 
        }
      


        private static void TestNumberAdder()
        {
            double w1 = 10, h1 = 5;
            double w2 = 30, h2 = 15;
            NumberAdder adder1, adder2;
            adder1 = new NumberAdder(w1, h1);
            adder2 = new NumberAdder(w2, h2);
            NumberAdder _add = adder1 + adder2;
            NumberAdder _sub = adder1 - adder2;
            NumberAdder _mult = adder1 * adder2;
            NumberAdder _div = adder1 / adder2;
            Console.WriteLine("sum = {0}", _add.ToString());
            Console.WriteLine("sub = {0}", _sub.ToString());
            Console.WriteLine("mult = {0}", _mult.ToString());
            Console.WriteLine("div = {0}", _div.ToString()); 
        }

        private static void TestLinq()
        {
            LinqExample ex = new LinqExample();
            ex.Example2(); 
        }

        private static void FindPerson()
        {
            List<Hashtable> people = new List<Hashtable>();

            String fileName = "people.txt"; 
            StreamReader reader = File.OpenText(fileName);
            String line = reader.ReadLine();
            String nameEl = "", ageEl = "", wageEl = ""; 
            while (line != null)
            {
                //Console.WriteLine(line);
                String[] sep1 = Regex.Split(line, ",");
                nameEl = sep1[0];
                ageEl = sep1[1];
                wageEl = sep1[2];
                Hashtable temp = new Hashtable();
                String[] sep2 = Regex.Split(nameEl, "="); 
                temp[sep2[0]] = sep2[1];
                sep2 = Regex.Split(ageEl, "=");
                temp[sep2[0]] = sep2[1];
                sep2 = Regex.Split(wageEl, "=");
                temp[sep2[0]] = sep2[1];
                people.Add(temp); 
                line = reader.ReadLine(); 
            }
            reader.Close(); 

            /*
            foreach(var person in people)
            {
                Console.WriteLine("{0}, {1}, {2}", person["name"], person["age"], person["wage"]); 
            }
            */

            for(;;)
            {
                Console.WriteLine("enter person name for search(end):  ");
                String input = Console.ReadLine();
                if (input.Equals("end", StringComparison.CurrentCultureIgnoreCase)) break;
                int flag = 0; 
                foreach(var person in people)
                {
                    //Console.WriteLine(person["name"]); 
                    if(person["name"].Equals(input))
                    {
                        Console.WriteLine("{0}, {1}, {2}", person["name"], person["age"], person["wage"]);
                        flag = 1; 
                        break; 
                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine("no entry found with this name");
                }

            }
        }
        private static void NumberTriangle()
        {
            int rows;
            Console.WriteLine("enter # of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            List<List<int>> mainList = new List<List<int>>();
            List<int> list0 = new List<int>();
            list0.Add(1);
            List<int> list1 = new List<int>();
            list1.Add(1); list1.Add(1);
            mainList.Add(list0);
            mainList.Add(list1); 
            for(int i=2; i <= rows; ++i)
            {
                List<int> lastList = mainList.ElementAt(i - 1);
                List<int> newList = new List<int>();
                newList.Add(1); 
                for(int j=0; j< lastList.Count -1; ++j)
                {
                    int el0 = lastList.ElementAt(j);
                    int el1 = lastList.ElementAt(j + 1);
                    newList.Add(el0 + el1); 
                }
                newList.Add(1); 
                mainList.Add(newList); 
            }


            /*
            foreach (var l in mainList)
            {
                foreach(var el in l)
                {
                    Console.Write("{0} ", el); 
                }
                Console.WriteLine(); 
            }

    */ 

              for(int i = 0; i<= rows; ++i)
            {
                int numberSpaces = rows - i + 1;
                for (int j = 0; j < numberSpaces; ++j)
                    Console.Write(" ");
                var l = mainList.ElementAt(i); 
                foreach(var el in l)
                {
                    Console.Write("{0} ", el); 
                }
                Console.WriteLine(); 
            }
        }


        private static void ListStatistics()
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            int c = 10; 
            while(c>0)
            {
                list.Add(rand.Next(1, 100));
                --c; 
            }

            int min = list.ElementAt(0);
            int max = list.ElementAt(0);
            int sum = 0;
            double avg = 0; 
            foreach(var el in list)
            {
                if (el < min) min = el; 
            }

            foreach(var el in list)
            {
                if (el > max) max = el; 
            }

            foreach(var el in list)
            {
                sum += el; 
            }
            avg = (double)sum / list.Count;

            Console.WriteLine("<<list>>");
            foreach (var el in list) Console.Write("{0} ; ", el);
            Console.WriteLine(); 
            Console.WriteLine("min = {0}, max = {1}, sum = {2} , avg = {3}", min, max, sum, avg); 
        }

        private static void MagnitudeOfInt()
        {
            int n;
            Console.WriteLine("your number: ");
            n = Convert.ToInt32(Console.ReadLine());
            int temp = n; 
            int i = 0; 
            while (temp > 0 )
            {
                ++i;
                temp /= 10; 
            }
            Console.WriteLine("Magnitude of {0} = {1}", n, i); 
        }

        private static void IsPositive()
        {
            int n;
            Console.WriteLine("your number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
                Console.WriteLine("{0} is positive", n);
            else
                Console.WriteLine("{0} is negative", n);
        }
        private static void PrintPrimes()
        {
            Console.WriteLine("13 = {0}", IsPrime(13));
            Console.WriteLine("127 = {0}", IsPrime(127));
            Console.WriteLine("125 = {0}", IsPrime(125));


            int upperBound = 100; 
            for(int i=2; i<= 100; ++i)
            {
                if (IsPrime(i)) Console.Write("{0} ; ", i); 
            }
            Console.WriteLine(); 
        }
        private static bool IsPrime(int number)
        {
            int square = (int)Math.Sqrt(number);
            //Console.WriteLine("Square = {0}", square); 
            for(int i=2; i<= square; ++i)
            {
                if (number % i == 0) return false; 
            }
            return true ; 
        }

        private static void PrintDiamond()
        {
            int rows;
            Console.WriteLine("Enter # of rows: ");
            rows = Convert.ToInt32(Console.ReadLine()); 
            for(int i=0; i< rows; ++i)
            {
                int totalRow = 2 * i + 1;
                int totalSpace = (2 * rows - totalRow) / 2;
                for (int j = 0; j < totalSpace; ++j)
                    Console.Write(" ");
                for (int j = 0; j < totalRow; ++j)
                    Console.Write("*");
                Console.WriteLine(); 
            }

            for(int i= rows -2; i >= 0; --i)
            {
                int totalRow = 2 * i + 1;
                int totalSpace = (2 * rows - totalRow) / 2;
                for (int j = 0; j < totalSpace; ++j)
                    Console.Write(" ");
                for (int j = 0; j < totalRow; ++j)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        private static void SwapNumbersXOR()
        {
            int n1, n2;
            Console.WriteLine("first integer: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second integer: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            int temp = n1 ^ n2;
            n1 = temp ^ n1;
            n2 = temp ^ n2;
            Console.WriteLine("n1 = {0}, n2 = {1}", n1, n2); 
        }
        private static void FrequencyThe()
        {
            String sentence1 = "foo the bar the the the";
            String sentence2 = "bim the the bim";

           
            String [] arr1 =  Regex.Split(sentence1, @"\s+");
            int counter1 = 0, counter2 = 0; 
            foreach(String str in arr1)
            {
                if (str.Equals("the", StringComparison.CurrentCultureIgnoreCase))
                    counter1++; 
            }

            String[] arr2 = Regex.Split(sentence2, @"\s+"); 
            foreach(String str in arr2)
            {
                if (str.Equals("the", StringComparison.CurrentCultureIgnoreCase))
                    ++counter2; 
            }


            Console.WriteLine("Counter1 = {0}, Counter2 = {1}", counter1, counter2); 
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
