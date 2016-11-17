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

            int Char_Move_Left_Right = 10;
            int Char_Move_Up_Down = 10;

            int Game_Over = 0;
            //string:
            string Char_Name = "Class inc.";
            do 
            {
            //draw GUI:
                //draw stats:
                Console.SetCursorPosition(0, 0);
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
                Console.SetCursorPosition(0,28);

                ConsoleKeyInfo KeyInfo;
                KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                    for(int a = 0; a <= 2; a++)
                    {
                        for(int b = 0; b <= 2; b++)
                        {
                            Console.SetCursorPosition(b, a);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("X");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");
                        }
                    }
                    Char_Move_Left_Right++;
                    Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                    Console.Write("X");

                        break;
                }
            } while(Game_Over == 0);










            Console.ReadLine();
    }
    }
}