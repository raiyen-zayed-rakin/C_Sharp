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


            Console.Write("Enter a number : ");
            string numInput = Console.ReadLine();
            int num = Convert.ToInt32(numInput);

            Console.WriteLine(num);
            //here
            int.TryParse(numInput, out num);

            Console.ReadLine();
        }
    }
}
