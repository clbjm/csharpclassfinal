/*
//Class Creation:
            do {
                Console.Clear();
                Console.WriteLine("Please choose a class as below:");
                Console.WriteLine ("Warrior");
                Console.WriteLine ("Hunter");
                Console.WriteLine ("Mage");
                Console.WriteLine ("Thief");
                Console.WriteLine ("Your Choice:");
                Player_Class = Console.ReadLine ().ToUpper ();
                if (Player_Class == "WARRIOR")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 2 Point");
                    Console.WriteLine("Two Handed Weapons. 2 Point");
                    Console.WriteLine("Ranged Weapons. 0 Point");
                    Console.WriteLine("Magical Attacks. 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if(Input == "YES")
                    {
                        correct = 1;
                    }
                    if(Input == "NO")
                    {
                        correct = 0;
                    }
                }
                    if (Player_Class == "HUNTER")
                 {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 0 Point");
                    Console.WriteLine("Ranged Weapons. 2 Point");
                    Console.WriteLine("Magical Attacks. 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if(Input == "YES")
                    {
                        correct = 1;
                    }
                    if(Input == "NO")
                    {
                        correct = 0;
                    }
                 }
                    if (Player_Class == "MAGE")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 0 Point");
                    Console.WriteLine("Ranged Weapons. 1 Point");
                    Console.WriteLine("Magical Attacks. 2 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if(Input == "YES")
                    {
                        correct = 1;
                    }
                    if(Input == "NO")
                    {
                        correct = 0;
                    }
                }
                    if (Player_Class == "THIEF")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 2 Point");
                    Console.WriteLine("Two Handed Weapons. 0 Point");
                    Console.WriteLine("Ranged Weapons. 1 Point");
                    Console.WriteLine("Magical Attacks. 1 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if(Input == "YES")
                    {
                        correct = 1;
                    }
                    if(Input == "NO")
                    {
                        correct = 0;
                    }
                    correct = 1;
                }
                else{}
            } while(correct == 0);
            correct = 0;
*/