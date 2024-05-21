using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*this is a comment*/
            int rakin = 190; //integer variable
            /*MULTI-LINE COMMENT
       
             ** Variables
            integer - int - 4 bytes
            floating point number - float -4 bytes
            character - char = ''; - 2 bytes
            boolean - bool isGreat = true/false 1bit
            string inp = "harry" 
            */


            Console.Write("Hello World");
            Console.WriteLine("Hello Rakin");
            Console.WriteLine("Hello World" + rakin);
            Console.ReadLine();

            //new input
            string inp = Console.ReadLine(); // Readline()
            Console.WriteLine(inp);
        }
    }
}
