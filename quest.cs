/*
//Quest giving system:
                Quest_Reward_EXP = 20;
                Quest_Reward_Gold = 50;
                Player_Quest_Goal = 3;
                Player_Quest_Enemy = "Rats";
                /*
                do {
                    correct = 0;
                    Console.Clear();
                    if (Player_Quest != " ")
                    {
                        Console.WriteLine ("You have to finish your current quest. in order to get a new one.");
                        correct = 1;
                    }
                    if (Player_Quest == " ")
                    {
                        Console.WriteLine ("I would gladly pay you to kill the 3 rats thats annoying me, out on my fields.");
                        Console.WriteLine ("Reward: {0} Gold, and {1} EXP", Quest_Reward_Gold, Quest_Reward_EXP);
                        Console.WriteLine ("Accept Yes/No:");
                        Input = Console.ReadLine ().ToUpper ();
                        if (Input == "NO")
                        {
                            correct = 1;
                            Quest_Accepted = "NO";
                        }
                        if (Input == "YES")
                        {
                            Console.WriteLine("The quest has been accepted.");
                            Player_Quest = "The farmer would gladly pay you 50 and give you 20 EXP, to rid his fields of the 3 rats";
                            correct = 1;
                            Quest_Accepted = "YES";
                        }
                    }
                } while(correct == 0);
                Console.ReadLine ();


                //Menu Quest Writeout
                do {
                    correct = 0;
                    Console.Clear();
                    Console.WriteLine ("Enter Quest, to see your current quest");
                    Console.WriteLine ("Enter Inventory, to see your Inventory content");
                    Console.WriteLine ("Enter Status, to see in detail how your character is doing");
                    Console.WriteLine ("Enter Exit, to quit the Menu");
                    Input = Console.ReadLine ().ToUpper ();
                    if (Input == "QUEST" && Player_Quest != " ") {
                        do {
                            Console.Clear();
                            Console.WriteLine (Player_Quest);
                            Console.WriteLine ("Progress: {0}/{1} {2}", Player_Quest_Progress, Player_Quest_Goal, Player_Quest_Enemy);
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine ().ToUpper ();
                            if (Input == "BACK") {
                                correct = 1;
                            }
                            if (Input != "BACK") {
                            }
                        } while(correct == 0);
                    }
                    if (Input == "QUEST" && Player_Quest == " ") {
                        do {
                            Console.Clear ();
                            Console.WriteLine ("You do not have any active quests at the moment");
                            Console.WriteLine ("< back");
                            Input = Console.ReadLine ().ToUpper ();
                            if (Input == "BACK") {
                                correct = 1;
                            }
                            if (Input != "BACK") {
                            }
                        } while(correct == 0);
                    }
                    if (Input == "INVENTORY" || Input == "INV") {
                        do{
                        Console.Clear();
                        Console.WriteLine("Your Inventory Contains:");
                        for (Arraycount = 0; Arraycount < 20; Arraycount++)
                        {
                            int inventory_possition = Arraycount +1;
                            Console.SetCursorPosition (0, inventory_possition);
                            Console.WriteLine("{0}", Inventory[Arraycount]);
                        }
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine().ToUpper();
                        if(Input == "BACK")
                        {correct = 1;}
                        if(Input != "BACK")
                        {correct = 0;}
                    }while(correct == 0);
                    }
                    if (Input == "STATUS" || Input == "STAT") {
                        do{
                            Console.Clear();
                            Console.WriteLine ("Your character is:");
                            Console.WriteLine ("A {0} {1} {2}", Player_Gender, Player_Race, Player_Class);
                            Console.WriteLine("One Handed Weapon Skill Points: {0}", Player_One_Handed);
                            Console.WriteLine("Two Handed Weapon Skill Points: {0}", Player_Two_Handed);
                            Console.WriteLine("Ranged Weapon Skill Points: {0}", Player_Ranged_Weapon);
                            Console.WriteLine("Magical Attack Skill Points: {0}", Player_Magic);
                            Console.WriteLine("{0} Health Points, {1} Mana Points, {2} Experience Points",Player_Health_Points, Player_Mana_Points, Player_EXP);
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine ().ToUpper();
                            if(Input == "BACK")
                            {correct = 1;}
                            if(Input != "BACK")
                            {correct = 0;}
                        }while(correct == 0);
                    }
                    if(Input == "EXIT")
                    {correct = 2;}
                    else {
                    }
                } while(correct != 2);

                */