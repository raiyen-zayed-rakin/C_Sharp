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


            //int a = (int)3.4;
            int x = 3;
            double y = x;
            int z = 'y';
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
