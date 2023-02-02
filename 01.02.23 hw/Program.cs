using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02._23_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            {
                Console.WriteLine("Task 1\nEnter number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
            #endregion
            #region task 2
            {
                Console.WriteLine("Task 2\nEnter number");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter percent val");
                int percent = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Result is {num / 100 * percent}");
            }
            #endregion
            #region task 3
            {
                Console.WriteLine("Task 3\n Enter 4 numbers");
                int num1 = Convert.ToInt32(Console.ReadLine()), num2 = Convert.ToInt32(Console.ReadLine()), num3 = Convert.ToInt32(Console.ReadLine()), num4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Result is {num1 * 1000 + num2 * 100 + num3 * 10 + num4}");
            }
            #endregion
            #region task 4
            {
                Console.WriteLine("Task 4\nEnter 6-signed number");
                int num = Convert.ToInt32(Console.ReadLine());
                string strNum = num.ToString();
                if (strNum.Length > 6 || strNum.Length < 6)
                {
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Enter two digit numbers");
                int char1 = Convert.ToInt32(Console.ReadLine()), char2 = Convert.ToInt32(Console.ReadLine()), temp1 = 0, temp2 = 0;
                int num6 = num % 10, num5 = ((num - num6) / 10) % 10, num4 = ((num - num6 - num5) / 100) % 10, num3 = ((num - num6 - num5 - num4) / 1000) % 10, num2 = ((num - num6 - num5 - num4 - num3) / 10000) % 10, num1 = ((num - num6 - num5 - num4 - num3 - num2) / 100000) % 10;
                switch (char1)
                {
                    case 1:
                        temp1 = num1;
                        break;
                    case 2:
                        temp1 = num2;
                        break;
                    case 3:
                        temp1 = num3;
                        break;
                    case 4:
                        temp1 = num4;
                        break;
                    case 5:
                        temp1 = num5;
                        break;
                    case 6:
                        temp1 = num6;
                        break;
                }
                switch (char2)
                {
                    case 1:
                        temp2 = num1;
                        num1 = temp1;
                        break;
                    case 2:
                        temp2 = num2;
                        num2 = temp1;
                        break;
                    case 3:
                        temp2 = num3;
                        num3 = temp1;
                        break;
                    case 4:
                        temp2 = num4;
                        num4 = temp1;
                        break;
                    case 5:
                        temp2 = num5;
                        num5 = temp1;
                        break;
                    case 6:
                        temp2 = num6;
                        num6 = temp1;
                        break;
                }
                switch (char1)
                {
                    case 1:
                        num1 = temp2;
                        break;
                    case 2:
                        num2 = temp2;
                        break;
                    case 3:
                        num3 = temp2;
                        break;
                    case 4:
                        num4 = temp2;
                        break;
                    case 5:
                        num5 = temp2;
                        break;
                    case 6:
                        num6 = temp2;
                        break;
                }
                Console.WriteLine($"{num1}{num2}{num3}{num4}{num5}{num6}");
            }
            #endregion
            #region 5
            {
                Console.WriteLine("Enter date\"dd/mm/yyyy\"");
                string strDate = Console.ReadLine();
                DateTime date = DateTime.Parse(strDate);
                if (date.Month == 1 || date.Month == 2 || date.Month == 12)
                {
                    Console.Write("Winter ");
                }
                else if (date.Month == 3 || date.Month == 4 || date.Month == 5)
                {
                    Console.Write("Spring ");
                }
                else if (date.Month == 6 || date.Month == 7 || date.Month == 8)
                {
                    Console.Write("Summer ");
                }
                else
                {
                    Console.Write("Autumn ");
                }
                Console.WriteLine(date.DayOfWeek);
            }
            #endregion
            #region 6
            {
                Console.WriteLine("C/F?");
                string mode = Console.ReadLine();
                Console.WriteLine("Enter temperature");
                int t = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Covert to\tC/F?(press a key)");
                string _mode = Console.ReadLine();
                if (mode == _mode) Console.WriteLine(t);
                else if (_mode == "C") Console.WriteLine((t - 32) / 1.8);
                else if (_mode == "F") Console.WriteLine(t * 1.8 + 32);
                else Console.WriteLine("Error");
            }
            #endregion
            #region 7
            {
                Console.WriteLine("Enter borders");
                int bord1 = Convert.ToInt32(Console.ReadLine()), bord2 = Convert.ToInt32(Console.ReadLine());
                if (bord1 > bord2)
                {
                    int temp = bord1;
                    bord1 = bord2;
                    bord2 = temp;
                }
                int gain = bord1 % 2 == 0 ? 2 : 1;
                for (int i = bord1+gain; i < bord2; i++)
                {
                    Console.Write($"{i}\t");
                }
            }
            #endregion
            Console.ReadKey();
        }
    }
}
