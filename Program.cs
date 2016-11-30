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

            int Attack_Bonus = 1;
            int Speech_Bonus = 1;
            int Sneak_Bonus = 0;
            int Armour_Bouns = 0;
            int Casting_Bouns = 0;


            int Teammates = 1;

            int foe_hp_current;
            int foe_hp_full;
            int foe_attack;
            int char_attack = 1;

            //string:
            string Char_Name = "";
            string Current_Command;
            string Char_Status = "";
            string Char_Class;

            string foe_name;
            string char_weapon = "fists";

            //Random
            Random Diceroll = new Random();
            //array:
            string[,] Inventory = new string[10,20];
            string[,] Spellbook = new string[10, 20];


            
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
                            Spellbook[0, 0] = "Flame";
                            Spellbook[1, 0] = "5";
                            Spellbook[1, 0] = "DAMAGE";
                            Spellbook[0, 0] = "Thunderbolt";
                            Spellbook[1, 1] = "7";
                            Spellbook[1, 0] = "DAMAGE";
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
                            Spellbook[0, 0] = "Lesser Healing";
                            Spellbook[1, 0] = "10";
                            Spellbook[1, 0] = "DAMAGE";
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
                if(Char_HP_Current <= 0)
                {
                    Game_Over = 1;
                }
            

            //draw GUI:
            //draw stats:
            Console.Clear();
            /*Console.SetCursorPosition(0, 0);
            Console.WriteLine(" ________________");
            */Console.SetCursorPosition(7, 1);
            Console.WriteLine("Name: {0}", Char_Name);
            Console.SetCursorPosition(37, 1);
            Console.WriteLine("HP: {0}/{1}", Char_HP_Current, Char_HP_Full);
            Console.SetCursorPosition(67,1);
            Console.WriteLine("EXP: {0}/{1}", Char_EXP_Current, Char_EXP_Full);
            Console.SetCursorPosition(97,1);
            Console.WriteLine("Level: {0}", Char_Level_Current);
            /*Console.WriteLine("_____________________");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("/");
            Console.SetCursorPosition(118, 1);
            Console.WriteLine("/");
           *//*draw game screen:
            for(int a = 3; a <= 27; a++)
            {
                Console.SetCursorPosition(0, a);
                Console.Write("|");
                Console.SetCursorPosition(119, a);
                Console.Write("|");
            }
            Console.SetCursorPosition(0,28);
            Console.WriteLine("________________");
            */



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







                //Intro Mission:
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("You awaken in a darkened dungon cellar. Feeling around, you do not notice any particular items on your person.");
                Console.WriteLine("Your fists bloody from the fight you put up, and your ribs broken and bruised, from when they took you down.");
                Console.WriteLine("It appears they did not enjoy the rebelion as much as you did, and you are sure to end up paying the price.");
                Console.WriteLine("The need to find your way out inceases when you hear the footsteps in the distance, might be the rescue, or maybe a prison warden");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 3);
                Console.WriteLine("WAIT (Hope for a savior)");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 2);
                Console.WriteLine("RUN (Escape potential warden)");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 2);
                Current_Command = Console.ReadLine().ToUpper();
                if(Current_Command == "RUN")
                {

                }if(Current_Command == "Wait")
                {
                    int Dicerolled = Diceroll.Next(1, 3);
                    if(Dicerolled == 1)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(3, 5);
                        Console.WriteLine("The footsteps have come to a full stop, and a almost inaudible sound is mand from the right corner of the room");
                        Console.SetCursorPosition(3, 6);
                        Console.WriteLine("Psssst!");
                        Console.SetCursorPosition(3, 7);
                        Console.WriteLine("You pick up a the lit candle on a barrel next to you, and hold it forward to try lighting up this dark dungeon. But as if the light was swallowed by the darknes, it goes nowhere.");
                        Console.SetCursorPosition(3, 8);
                        Console.WriteLine("The voice is again heard.");
                        Console.SetCursorPosition(3, 9);
                        Console.WriteLine("I see you in there..!");
                         Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 - 3);
                        Console.WriteLine("WAIT (Hope for the best)");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 - 2);
                        Console.WriteLine("RUN (Escape potential danger)");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 - 2);
                        Current_Command = Console.ReadLine().ToUpper();
                        if(Current_Command == "Wait")
                        {
                            Console.Clear();
                            Teammates++;
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("The footsteps come towards you, and as if no time has passed, a shadow figure is against the bars of your cellar");
                            Console.SetCursorPosition(3, 6);
                            Console.WriteLine("You hold the candle in towards the shadow of a person, and a female face is seen");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("Female: do not make a noice, I am here to help you escape. But I think I was followed down here.");
                            Console.SetCursorPosition(3, 8);
                            Console.WriteLine("Pulling out a homemade mechinical device, the woman pulls a trigger and the lock on your cellar door comes right off.");
                            Console.SetCursorPosition(3, 9);
                            Console.WriteLine("Female: Follow me now, or I will leave you");
                            Console.SetCursorPosition(3, 10);
                            Console.WriteLine("You follow along, and the both of you start running, although the darkness seemed to swallow your light, outside the cellar it is as bright as day.");
                            Console.SetCursorPosition(3, 11);
                            Console.WriteLine("Barging through a wooden plank door, the two of you fall to the floor and breath out, sure that something was following you, looking back yield no results.");
                            Console.SetCursorPosition(3, 12);
                            Console.WriteLine("Looking ahead, a shadow figure is standing right in front of you, and stares into the very soul of you both.");
                            Console.SetCursorPosition(3, 13);
                            Console.WriteLine("A scream is heard inside your head, and you feel as if your brain is about to explode out of your eyes.");
                            
                            
                            Console.SetCursorPosition(2, 27);
                            Console.Write("[Enter] To enter Combat");
                            Console.Read();
                            Console.Clear();

                            //Foe:
                            foe_name = "Shadow";
                            foe_hp_full = 40;
                            foe_hp_current = 40;
                            foe_attack = 5;
                            Current_Command = "COMBAT";

                            //combat:
                            do
                            {
                            Console.SetCursorPosition(7, 1);
                            Console.WriteLine("Player Name: {0}", Char_Name);
                            Console.SetCursorPosition(37, 1);
                            Console.WriteLine("HP: {0}/{1}", Char_HP_Current, Char_HP_Full);
                            Console.SetCursorPosition(67,1);
                            Console.WriteLine("EXP: {0}/{1}", Char_EXP_Current, Char_EXP_Full);
                            Console.SetCursorPosition(97,1);
                            Console.WriteLine("Level: {0}", Char_Level_Current);

                            Console.SetCursorPosition(7, 3);
                            Console.WriteLine("Enemy Name: {0}", foe_name);
                            Console.SetCursorPosition(37, 3);
                            Console.WriteLine("HP: {0}/{1}", foe_hp_current, foe_hp_full);

                            Console.SetCursorPosition(67,1);
                            Console.SetCursorPosition(10, 10);
                            Console.Write("[1] To Attack");
                            Console.SetCursorPosition(40, 10);
                            Console.Write("[2] To Cast Magick");
                            Console.SetCursorPosition(10, 11);
                            Console.Write("[3] To Consume HP Potion");
                            Console.SetCursorPosition(40, 11);
                            Console.Write("[4] To Attempt Fleeing");
                            Current_Command = Console.ReadLine();
                            if(Current_Command == "1")
                            {
                                Dicerolled = Diceroll.Next(0, char_attack + Attack_Bonus+1);
                                if(Dicerolled >= 1)
                                {
                                    Console.SetCursorPosition(3, 15);
                                    Console.WriteLine("You hit the {0} and delt {1} damage.", foe_name, Dicerolled);
                                    foe_hp_current = foe_hp_current - Dicerolled;
                                }
                                else
                                {
                                    Console.SetCursorPosition(3, 15);
                                    Console.WriteLine("You missed");
                                }
                            }
                            if(Current_Command == "2")
                            {
                                Dicerolled = Diceroll.Next(1, 3);
                                Console.WriteLine("Choose a spell from your Spellbook");
                                for(int y = 0; y<= 100; y++;)
                                {
                                    for(int x = 0;)
                                }
                            }
                            if(Current_Command == "3")
                            {
                                Dicerolled = Diceroll.Next(1, 3);
                            }
                            if(Current_Command == "4")
                            {
                                Dicerolled = Diceroll.Next(1, 3);
                            }


                            } while (foe_hp_current > 0 || Char_HP_Current >= 0);
                        }
                    }
                    if(Dicerolled == 2)
                    {
                        
                    }
                }if(Current_Command == "RUN")
                {

                }






                //command options default:
                Console.SetCursorPosition(0, 29);
                Current_Command = Console.ReadLine().ToUpper();
                if (Current_Command == "INVENTORY" || Current_Command == "INV")
                {
                    Console.Clear();
                     //draw stats:
               /*Console.SetCursorPosition(0, 0);
                Console.WriteLine(" ________________");
                */Console.SetCursorPosition(7, 1);
                Console.WriteLine("Name: {0}", Char_Name);
                Console.SetCursorPosition(37, 1);
                Console.WriteLine("HP: {0}/{1}", Char_HP_Current, Char_HP_Full);
                Console.SetCursorPosition(67,1);
                Console.WriteLine("EXP: {0}/{1}", Char_EXP_Current, Char_EXP_Full);
                Console.SetCursorPosition(97,1);
                Console.WriteLine("Level: {0}", Char_Level_Current);
                /*Console.WriteLine("_____________________");
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("/");
                Console.SetCursorPosition(118, 1);
                Console.WriteLine("/");*/
                /*draw game screen:
                for(int a = 3; a <= 27; a++)
                {
                    Console.SetCursorPosition(0, a);
                    Console.Write("|");
                    Console.SetCursorPosition(119, a);
                    Console.Write("|");
                }
                Console.SetCursorPosition(0,28);
                Console.WriteLine("________________");
                */

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
                         if(Char_HP_Current < Char_EXP_Full*0.60)
                         {
                             Char_Status = "You have felt better..";
                         }
                         if(Char_HP_Current < Char_EXP_Full*0.50)
                         {
                             Char_Status = "You feel pretty bad, but able to go on..";
                         }
                          if(Char_HP_Current < Char_EXP_Full*0.10)
                         {
                             Char_Status = "You are bleeding from the torso, and your battle scars are massive.";
                         }
                         Console.Clear();
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