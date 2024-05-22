using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            /*this is a comment*/
            //int rakin = 190; //integer variable
            /*MULTI-LINE COMMENT
       
             ** Variables
            integer - int - 4 bytes
            floating point number - float -4 bytes
            character - char = ''; - 2 bytes
            boolean - bool isGreat = true/false 1bit
            string inp = "harry" -> 2 byte per character
            */


            //Console.Write("Hello World");
            //Console.WriteLine("Hello Rakin");
            //Console.WriteLine("Hello World" + rakin);
            //Console.ReadLine();

            ////new input
            //string inp = Console.ReadLine(); // Readline()
            //Console.WriteLine(inp);


            //Datatypes Examples

            //int a = 34;
            //float b = 34.4F;
            //double c = 43.2D;
            //bool isGreat = true;
            //char d = 'r';
            //string e = "rakin is hehe";
            //Console.WriteLine(e);
            //Console.WriteLine(d);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(a + b + c);
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //typecasting 

            //2 types -
            //1.Implicit
            //char to int to long to float to double
            //2.Explicit

            //type vName = value;

            //int a = (int)3.4;
            //int x = 3;
            //double y = x;
            //int z = 'y';
            //float f = Convert.ToInt32(3.45);
            //string sx = "random string";

            //Console.WriteLine(f);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine("Enter your name : ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello "+name);

            //Opertors in C#
            /*
             1. Arithmetic operators;
             2. Assignment Operators;
             3. Comparison Operators;

             */
            //int a = 1, b = 2;
            //Console.WriteLine("the value of a + b is : " + (a + b));

            //Logical Operator

            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(true || false);

            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            //Comparison Operator;

            //Console.WriteLine(34 > 4);
            //Console.WriteLine(34 > 5566);
            //Console.WriteLine(34 < 41);

            //int a =  Math.Min(34, 345);
            //Console.WriteLine(a);


            //string hello = "hello world, fuck you";
            //string b = "heke";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello + "teb");
            //Console.WriteLine(string.Concat(hello, b));

            //string name  = Console.ReadLine();
            //string candies = Console.ReadLine();

            ////*** String interpolation
            //Console.WriteLine($"your name is {name}. you have {candies}");

            //string hello = "hello world, fuck you";
            //Console.WriteLine(hello[3]);

            Player rakin = new Player();
            Console.WriteLine(rakin.getHealth());
            
            rakin.setHealth(60);
            Console.WriteLine(rakin.getHealth());


            Console.ReadLine();
        }
    }
}
