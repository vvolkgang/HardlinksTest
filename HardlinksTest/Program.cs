using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardlinksTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hardlinks Name Test";
            //string name = System.AppDomain.CurrentDomain.FriendlyName;
            string fname = System.IO.Path.GetFileNameWithoutExtension(System.AppDomain.CurrentDomain.FriendlyName);
            string pname = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            string mmname = System.IO.Path.GetFileNameWithoutExtension(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            
            PrintStatus("OK", ConsoleColor.DarkGreen);
            Console.WriteLine("Main Model File Name>\t" + mmname);
            PrintStatus("OK", ConsoleColor.DarkGreen);
            Console.WriteLine("Friendly Name>\t\t" + fname);
            PrintStatus("FAIL", ConsoleColor.DarkRed); 
            Console.WriteLine("Process Name>\t\t" + pname);

            Console.WriteLine();
            PrintStatus("CODE", ConsoleColor.DarkCyan);
            Console.WriteLine("\n");
            Console.WriteLine("System.IO.Path.GetFileNameWithoutExtension(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);\n");
            Console.WriteLine("System.IO.Path.GetFileNameWithoutExtension(System.AppDomain.CurrentDomain.FriendlyName);\n");
            Console.WriteLine("System.Diagnostics.Process.GetCurrentProcess().ProcessName;\n");
            
            Console.ReadLine();

        }

        private static void PrintStatus(string status, ConsoleColor color)
        {
            ConsoleColor d = Console.ForegroundColor;
            Console.Write("[");
            Console.ForegroundColor = color;
            Console.Write(status);
            Console.ForegroundColor = d;
            Console.Write("] ");
        }

    }
}
