using System;
using System.Collections.Generic;
using System.Text;

namespace No_Such_Element_Exception_Handle
{
    public static class Messages //Static class can only have static methods.

    {
        public static void Greenmsg(String green)

        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(green);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Redmsg(String red)

        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(red);
            Console.ForegroundColor = ConsoleColor.White;
        }




    }
}
