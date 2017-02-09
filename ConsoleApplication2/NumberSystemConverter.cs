using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class NumberSystemConverter
    {
        public static String DecimalToBinary(String input)
        {
            int n = Convert.ToInt32(input);
            StringBuilder builder = new StringBuilder();
            int rest = 0;
            while (n > 0)
            {
                rest = n % 2;
                builder.Append(rest);
                n /= 2;
            }
            ReverseBuilder(builder);
            return builder.ToString();
        }

        private static void ReverseBuilder(StringBuilder builder)
        {
            IEnumerable<char> res = builder.ToString().Reverse<char>();
            builder.Clear();
            foreach (char ch in res)
                builder.Append(ch);
        }


        public static String DecimalToOctal(String input)
        {
            StringBuilder builder = new StringBuilder();
            int n = Convert.ToInt32(input);
            int rest = 0; 
            while(n > 0 )
            {
                rest = n % 8;
                builder.Append(rest);
                n /= 8; 
            }

            ReverseBuilder(builder); 
            return builder.ToString(); 
        }

       

        public static String DecimalToHex(String input)
        {
            StringBuilder builder = new StringBuilder();
            int n = Convert.ToInt32(input);
            int rest = 0; 
            while(n > 0 )
            {
                rest = n % 16;
                builder.Append(RestToChar(rest));
                n /= 16; 
            }
            ReverseBuilder(builder); 
            return builder.ToString(); 
        }

        private static char RestToChar(int rest)
        {
            char res = ' '; 

            switch(rest)
            {
                case 0:  res = '0'; break; 
                case 1: res = '1'; break;
                case 2: res = '2'; break;
                case 3: res = '3'; break;
                case 4: res = '4'; break;
                case 5: res = '5'; break;
                case 6: res = '6'; break;
                case 7: res = '7'; break;
                case 8: res = '8'; break;
                case 9: res = '9'; break; 
                case 10:
                    res = 'A';
                    break;
                case 11:
                    res = 'B';
                    break;
                case 12:
                    res = 'C';
                    break;
                case 13:
                    res = 'D';
                    break;
                case 14:
                    res = 'E';
                    break;
                case 15:
                    res = 'F';
                    break; 
            }

            return res; 
        }

        public static String BinaryToDecimal(String input)
        {
            IEnumerable<char> arr = input.Reverse<char>();
            int i = 0;
            //StringBuilder builder = new StringBuilder();
            double sum = 0; 
            foreach(var ch in arr)
            {
                if (ch == '0')
                {
                    ++i;
                    continue;
                }
                sum += Math.Pow(2, i);
                ++i; 
            }
            return sum.ToString(); 
        }

        public static String OctalToDecimal(String input)
        {
            IEnumerable<char> arr = input.Reverse<char>();
            double sum = 0;
            int i = 0; 
            foreach(var ch in arr)
            {
                //Console.WriteLine((int)ch-48); 
                // int n = (int)ch - 48;
                int n = CharToInt(ch); 
                sum += n*Math.Pow(8, i); 
                ++i; 
            }
            return sum.ToString(); 
        }

        private static int CharToInt(char ch)
        {
            int n = (int)ch - 48;
            if (n >= 0 && n <= 9) return n; 
            else
            {
                switch(ch)
                {
                    case 'A': return 10;
                    case 'B': return 11;
                    case 'C': return 12;
                    case 'D': return 13;
                    case 'E': return 14;
                    case 'F': return 15; 
                }
            }
            return -1; 
        }

        public static String HexToDecimal(String input)
        {
            double sum = 0;
            int i = 0;
            IEnumerable<char> arr = input.Reverse<char>(); 
            foreach(char ch in arr)
            {
                int n = CharToInt(ch);
                sum += n * Math.Pow(16, i);
                ++i; 
            }
            return sum.ToString(); 
        }

  

        public static String BinaryToHex(String input)
        {
            while (input.Length % 4 != 0)
                input = input.Insert(0, "0");
            IEnumerable<char> arr = input.Reverse<char>();
            StringBuilder builder = new StringBuilder();
            builder.Clear();
            StringBuilder res = new StringBuilder(); 
            for(int i=0; i< arr.Count<char>(); ++i)
            {
                char ch0 = arr.ElementAt<char>(i);
                ++i;
                char ch1 = arr.ElementAt<char>(i);
                ++i;
                char ch2 = arr.ElementAt<char>(i);
                ++i;
                char ch3 = arr.ElementAt<char>(i);
                //if(ch3 != '0')
                builder.Append(ch3);
                //if (ch2 != '0')  
                builder.Append(ch2);
                //if (ch3 != '0') 
                builder.Append(ch1);
                builder.Append(ch0);
                Console.WriteLine(builder.ToString()); 
                res.Append(_BinaryToHex(builder.ToString()));
                builder.Clear(); 
            }
            ReverseBuilder(res); 
            return res.ToString();
        }

        private static String _BinaryToHex(String str)
        {
            String output = "";
            List<String> list = new List<string>();
            String[] arr = {"0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101",
            "1110", "1111"};
            list.AddRange(arr);
            int index = list.IndexOf(str);
            output += RestToChar(index);
            return output;
        }


        public static String HexToBinary(String input)
        {
            StringBuilder builder = new StringBuilder();
            String[] arr = {"0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101",
            "1110", "1111"};

            foreach (var ch in input)
            {
                int index = CharToInt(ch);
                builder.Append(arr[index]); 
            }
            return builder.ToString(); 
        }
    }
}
