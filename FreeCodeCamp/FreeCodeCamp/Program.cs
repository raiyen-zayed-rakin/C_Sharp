using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var age = 23;

            //var bigNumber = 900000L;

            //var negative = -566;

            //var precision = 5.00001F;

            //var money = 14.99M;

            //var year = "2024";
            //Console.Write(year);

            //var name = "rakin";
            //var number = "01779309553";
            //var age = 23;

            //Console.WriteLine(name);
            //Console.WriteLine(age);

            //int num1 = 10;
            //int num2 = 2;

            //int rem = num1 % num2; 

            //Console.WriteLine(rem);

            // double value = 1000D / 12.340;

            //Console.WriteLine(value);
            //Console.WriteLine(string.Format("{0:0}", value));
            //Console.WriteLine(string.Format("{0:0.#}", value));
            //Console.WriteLine(string.Format("{0:0.00}", value));

            //double money = -10D / 3D; 
            //Console.WriteLine(money);
            //Console.WriteLine(string.Format("-$10 / $3 = ${0:0.00}", money));
            //Console.WriteLine(money.ToString());


            //TRYPARSE
            //bool success = true;

            //while (success)
            //{

            //    Console.Write("Enter a number : ");
            //    string numInput = Console.ReadLine();

            //    if (int.TryParse(numInput, out int num))
            //    {
            //        success = false;
            //        Console.WriteLine(num);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed");
            //    }

            //}

            ////TIMES TABLE
            //Console.Write("Enter a number for table : ");
            ////int num = Convert.ToInt32(Console.ReadLine());
            //string numInput = Console.ReadLine();
            //int num = Convert.ToInt32(numInput);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(string.Format("{0} x {1} = {2}",i, num, i * num));
            //}


            //FIZZ BUZZ GAME

            //Console.Write("Enter Number : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    if(i%3 == 0 && i%5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i%3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i%5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //string name = "Rakin";
            //string nickName = "TomarPapa";
            //////String interpolation
            ////Console.WriteLine($"Your name is {name} and nick name is {nickName}");

            ////string concatanation;
            //string test = string.Concat("Your name is ", name, " and your age is ", nickName);
            //Console.WriteLine(test);

            //string[] names = new string[] {"aba", "test", "test1"};

            //Console.WriteLine(string.Concat(names));

            //string message = "C# is aright";

            //Console.WriteLine(message[0]);
            //Console.WriteLine(message.Substring(0,1));

            //Console.Write("Enter a text : ");
            //string message = Console.ReadLine();

            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.Write(message[i]);
            //}

            //for (int i = message.Length-1; i >= 0 ; i--)
            //{
            //    Console.Write(message[i]);
            //}


            //if (name != "") {
            //    Console.WriteLine("0");
            //}
            //if (!name.Equals(""))
            //{
            //    Console.WriteLine("1");
            //}
            //if (!string.IsNullOrEmpty(name))
            //{
            //    Console.WriteLine("3");
            //}

            //Console.Write("Enter your password : ");
            //string p1 = Console.ReadLine();
            //Console.Write("Enter your password again : ");
            //string p2 = Console.ReadLine();

            //if (!p1.Equals(string.Empty))
            //{
            //    if (p2.Equals(string.Empty))
            //    {
            //        if (p1 == p2)
            //        {
            //            Console.WriteLine("Matched");
            //        }
            //        else if (p1 != p2)
            //        {
            //            Console.WriteLine("Not Matched");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter the confirmation password.");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Please enter the password.");
            //}
            Console.ReadLine();
        }
    }
}
