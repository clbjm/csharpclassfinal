using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ints:
            int Char_HP_Current = 20;
            int Char_HP_Full = 100;
            int Char_EXP_Current = 110;
            double Char_EXP_Full = 100;
            int Char_Level_Current = 1;
            int Char_Move_Left_Right = 10;
            int Char_Move_Up_Down = 10;
            int Game_Over = 0;
            int Resting_Time;

            //string:
            string Char_Name = "";
            string Current_Command;
            string Char_Status = "";


            //array:
            string[,] Inventory = new string[10,20];

            do 
            {
                //count EXP:
                if(Char_EXP_Current >= Char_EXP_Full)
                {
                    Char_EXP_Current = Convert.ToInt32(Char_EXP_Current - Char_EXP_Full);
                    Char_Level_Current++;
                    Char_EXP_Full = Char_EXP_Full * 1.20;
                }
                if(Char_HP_Current > Char_HP_Full)
                {
                    Char_HP_Current = Char_HP_Full;
                }
            //Character Creation:
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.WindowHeight / 2 - 3);
            Console.Write("What is your name? ");
            Char_Name = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 3);
            Console.Write("Choose a Class: ");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 1);
            Console.WriteLine("Outlaw");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
            Console.WriteLine("Caster");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 1);
            Console.WriteLine("Guardian");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 2);
            Console.Write("");

            //draw GUI:
            //draw stats:
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(" ________________");
            Console.SetCursorPosition(7, 1);
            Console.WriteLine("Name: {0}", Char_Name);
            Console.SetCursorPosition(37, 1);
            Console.WriteLine("HP: {0}/{1}", Char_HP_Current, Char_HP_Full);
            Console.SetCursorPosition(67,1);
            Console.WriteLine("EXP: {0}/{1}", Char_EXP_Current, Char_EXP_Full);
            Console.SetCursorPosition(97,1);
            Console.WriteLine("Level: {0}", Char_Level_Current);
            Console.WriteLine("_____________________");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("/");
            Console.SetCursorPosition(118, 1);
            Console.WriteLine("/");
            //draw game screen:
            for(int a = 3; a <= 27; a++)
            {
                Console.SetCursorPosition(0, a);
                Console.WriteLine("|");
                Console.SetCursorPosition(119, a);
                Console.Write("|");
            }
            Console.SetCursorPosition(0,28);
            Console.WriteLine("________________");

            //player controls
           /* ConsoleKeyInfo KeyInfo;
            KeyInfo = Console.ReadKey(true);
            switch (KeyInfo.Key)
            {
                case ConsoleKey.RightArrow:
                    if (Char_Move_Left_Right < 118)
                    {
                        Char_Move_Left_Right++;
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                        Console.Write("X");
                        Console.SetCursorPosition(Char_Move_Left_Right - 1, Char_Move_Up_Down);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("X");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                        else { }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Char_Move_Left_Right > 1)
                        {
                            Char_Move_Left_Right--;
                            Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                            Console.Write("X");
                            Console.SetCursorPosition(Char_Move_Left_Right +1, Char_Move_Up_Down);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("X");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else { }
                        break;
                case ConsoleKey.UpArrow:
                    if(Char_Move_Up_Down > 3)
                {
                    Char_Move_Up_Down--;
                    Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                    Console.Write("X");
                    Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down+1);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("X");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                        else { }
                        break;
                    case ConsoleKey.DownArrow:
                    if(Char_Move_Up_Down < 27)
                    {
                        Char_Move_Up_Down++;
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                        Console.Write("X");
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down - 1);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("X");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                        else{ }
                        break;
                    case ConsoleKey.Spacebar:
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down);
                        Console.Write("X");
                        System.Threading.Thread.Sleep(30);
                        Console.SetCursorPosition(Char_Move_Left_Right + 1, Char_Move_Up_Down);
                        Console.Write("-");
                        System.Threading.Thread.Sleep(30);
                        Console.SetCursorPosition(Char_Move_Left_Right, Char_Move_Up_Down-1);
                        Console.Write("|");
                        System.Threading.Thread.Sleep(30);
                        Console.SetCursorPosition(Char_Move_Left_Right -1, Char_Move_Up_Down);
                        Console.Write("--");
                        break;
                }
*/
                for(int a = 0; a <= 19; a++)
                {
                    for (int b = 0; b <= 9; b++)
                    {
                        Inventory[b, a] = "asd";
                    }
                }

                //command options default:
                Current_Command = Console.ReadLine().ToUpper();
                if (Current_Command == "INVENTORY" || Current_Command == "INV")
                {
                    Console.Clear();
                     //draw stats:
                Console.SetCursorPosition(0, 0);
            Console.WriteLine(" ________________");
            Console.SetCursorPosition(7, 1);
            Console.WriteLine("Name: {0}", Char_Name);
            Console.SetCursorPosition(37, 1);
            Console.WriteLine("HP: {0}/{1}", Char_HP_Current, Char_HP_Full);
            Console.SetCursorPosition(67,1);
            Console.WriteLine("EXP: {0}/{1}", Char_EXP_Current, Char_EXP_Full);
            Console.SetCursorPosition(97,1);
            Console.WriteLine("Level: {0}", Char_Level_Current);
            Console.WriteLine("_____________________");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("/");
            Console.SetCursorPosition(118, 1);
            Console.WriteLine("/");
                //draw game screen:
                for(int a = 3; a <= 27; a++)
                {
                    Console.SetCursorPosition(0, a);
                    Console.WriteLine("|");
                    Console.SetCursorPosition(119, a);
                    Console.Write("|");
                }
                Console.WriteLine("________________");
                Console.SetCursorPosition(0,28);

                    for (int a = 0; a <= 19; a++)
                    {
                        for (int b = 0; b <= 9; b++)
                        {
                            if (b <= 9)
                            {
                                Console.SetCursorPosition(b * 7 + 3, 5 + a);
                                Console.Write("{0}", Inventory[b, a]);
                            }
                            else { }

                                }
                            }
                            
                        Console.SetCursorPosition(2, 27);
                        Console.Write("< Back");
                        Console.SetCursorPosition(0, 29);
                        Current_Command = Console.ReadLine().ToUpper();
                        if (Current_Command == "BACK" || Current_Command == "<")
                        {
                            Console.Clear();
                        }
                        else { }
            }if(Current_Command == "SLEEP" || Current_Command == "NAP" || Current_Command == "REST")
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2-5, Console.WindowHeight / 2-3);
                Console.Write("For how long?");
                Resting_Time= Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 3);
                Console.Write("Resting");
                Resting_Time = (Resting_Time * 3) * 1000;
                System.Threading.Thread.Sleep(Resting_Time);
                Console.Clear();

               Char_HP_Current = Char_HP_Current + ((Resting_Time / 1000)/3)*15;
            }if(Current_Command == "STATUS" || Current_Command == "HOW AM I DOING" || Current_Command == "")
            {
                Console.SetCursorPosition(2, 27);
                Console.Write("< Back");
                Console.SetCursorPosition(0, 29);
                Current_Command = Console.ReadLine().ToUpper();
                if (Current_Command == "BACK" || Current_Command == "<")
                {
                    Console.Clear();
                }
                else { }
            }

            } while(Game_Over == 0);


            Console.ReadLine();
    }
    }
}
