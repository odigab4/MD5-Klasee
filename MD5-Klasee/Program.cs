using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD5_Klasee
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "vaards";
            string guess = "";

            while (guess != secretWord)
            {
                Console.WriteLine("Mini: ");
                guess = Console.ReadLine();
            }
            Console.WriteLine("Tu atmineeji!");

            Console.ReadLine();

        }
    }
}
