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

            int Char_Mouse_Left_Right = 10;
            int Char_Mouse_Up_Down = 10;


            //string:
            string Char_Name = "Class inc.";

            //draw GUI:
                //draw stats:
            Console.WriteLine("");
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Name: {0}", Char_Name);
            Console.SetCursorPosition(35, 1);
            Console.WriteLine("HP: {0}/{1}", Char_HP_Current, Char_HP_Full);
            Console.SetCursorPosition(60,1);
            Console.WriteLine("EXP: {0}/{1}", Char_EXP_Current, Char_EXP_Full);
            Console.WriteLine("_____________________");
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("/");
                //draw game screen:
                for(int a = 3; a <= 27; a++)
                {
                    Console.SetCursorPosition(0,a);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(119, a);
                    Console.Write("|");
                }
                Console.WriteLine("________________");
                ConsoleKeyInfo KeyInfo;
                KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                    Char_Move_Left_Right++;
                    Console.SetCursorPosition(Char_Mouse_Left_Right, Char_Move_Up_Down);
                    Console.WriteLine("X");
                        break;
                }










            Console.ReadLine();
        }
    }
}
