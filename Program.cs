using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ints:
            int Char_HP_Current = 20;
            int Char_HP_Full = 100;

            int Char_EXP_Current = 10;
            int Char_EXP_Full = 100;
            int Char_Level_Current = 1;

            //string:
            string Char_Name = "Class inc.";
            Console.WriteLine("");
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Name: {0}", Char_Name);
            Console.SetCursorPosition(35, 1);
            Console.WriteLine("HP: {0}/{1}", Char_HP_Current, Char_HP_Full);
            Console.SetCursorPosition(60,1);
            Console.WriteLine("EXP: {0}/{1}, Char_EXP_Current, Char_EXP_Full");
            Console.ReadLine();
        }
    }
}
