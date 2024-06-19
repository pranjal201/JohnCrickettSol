using ccwc.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ccwc
{
    public class StartPoint
    {
        public static void Main(string[] args)
        {
            //string option = "-l";
            //string filepath = @"C:\PersonalStuff\DotNet\ccwc\input.txt";

            string option = args[1];
            string filepath = args[2];
            if (args.Length == 3)
                //if (true)
            {
                WordCount wc = new WordCount();
                switch(option)
                {
                    case "-m":
                        int bytes = wc.CountBytes(filepath);
                        Console.WriteLine($"{bytes,8} {filepath}");
                        
                        break;
                    case "-l":
                        int lines = wc.CountLines(filepath);
                        Console.WriteLine($"{lines,8} {filepath}");
                        break;
                    case "-w":
                        int words = wc.CountWords(filepath);
                        Console.WriteLine($"{words,8} {filepath}");
                        break;
                    default: Console.WriteLine("Enter a valid attribute");
                        break;
                }
            }
            else{
                Console.WriteLine("Please Enter correct Argument");
            }
        }
    }
}
