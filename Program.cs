using System;


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
            int Error = 0;

            int Attack_Bonus = 0;
            int Speech_Bonus = 0;
            int Sneak_Bonus = 0;
            int Armour_Bouns = 0;
            int Casting_Bouns = 0;

            //string:
            string Char_Name = "";
            string Current_Command;
            string Char_Status = "";
            string Char_Class;


            //array:
            string[,] Inventory = new string[10,20];


            
            //Character Creation:
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.WindowHeight / 2 - 3);
            Console.Write("What is your name? ");
            Char_Name = Console.ReadLine();
            do {
                    Console.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 3);
                    Console.Write("Choose a Class: ");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 1);
                    Console.Write("Outlaw");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                    Console.Write("Caster");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 1);
                    Console.Write("Guardian");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 2);
                    Console.Write("Paladin");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 3);
                    Char_Class = Console.ReadLine().ToUpper();
                    if(Char_Class != "OUTLAW" || Char_Class != "CASTER" || Char_Class != "GUARDIAN" || Char_Class != "PALADIN" || Char_Class != "CLAUS")
                    {
                        Error = 0;
                        if(Char_Class == "OUTLAW")
                        {
                            Attack_Bonus =+ 4;
                            Speech_Bonus =+ 7;
                            Sneak_Bonus =+ 10;
                            Armour_Bouns =+ 3;
                            Casting_Bouns =+ 1;
                        }if(Char_Class == "Caster")
                        {
                            Attack_Bonus =+ 5;
                            Speech_Bonus =+ 5;
                            Sneak_Bonus =+ 3;
                            Armour_Bouns =+ 2;
                            Casting_Bouns =+ 10;
                        }if(Char_Class == "Guardian")
                        {
                            Attack_Bonus =+ 9;
                            Speech_Bonus =+ 3;
                            Sneak_Bonus =+ 2;
                            Armour_Bouns =+ 10;
                            Casting_Bouns =+ 1;
                        }if(Char_Class == "Paladin")
                        {
                            Attack_Bonus =+ 6;
                            Speech_Bonus =+ 6;
                            Sneak_Bonus =+ 2;
                            Armour_Bouns =+ 5;
                            Casting_Bouns =+ 6;
                        }if(Char_Class == "Claus")
                        {
                            Attack_Bonus =+ 5;
                            Speech_Bonus =+ 10;
                            Sneak_Bonus =+ 2;
                            Armour_Bouns =+ 7;
                            Casting_Bouns =+ 1;
                        }
                    }
                    else
                    {
                        Error = 1;
                    }
                } while (Error == 1);
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
            

            //draw GUI:
            //draw stats:
            Console.Clear();
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
                Console.Write("|");
                Console.SetCursorPosition(119, a);
                Console.Write("|");
            }
            Console.SetCursorPosition(0,28);
            Console.WriteLine("________________");

            /*
            //player controls
            ConsoleKeyInfo KeyInfo;
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
                    Console.Write("|");
                    Console.SetCursorPosition(119, a);
                    Console.Write("|");
                }
                Console.SetCursorPosition(0,28);
                Console.WriteLine("________________");


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
                    Resting_Time = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 3);
                    Console.Write("Resting:");
                    Resting_Time = (Resting_Time * 3) * 1000;
                    System.Threading.Thread.Sleep(Resting_Time);
                    Console.Clear();

                    Char_HP_Current = Char_HP_Current + ((Resting_Time / 1000)/3)*15;
                    }if(Current_Command == "STATUS" || Current_Command == "HOW AM I DOING")
                    {
                        if(Char_Class =="CLAUS")
                         {
                             Char_Status = "Claus!..";
                         }
                         Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 3);
                         Console.Write("{0}",Char_Status);
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



                        //Intro Mission:
                        Console.SetCursorPosition(3,5);
                        Console.WriteLine("You awaken in a darkened dungon cellar. Feeling around, you do not notice any particular items on your person");


                        

                } while(Game_Over == 0);


            Console.ReadLine();
        }
    }
}