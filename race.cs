/*
 //Race Creation:
            do {
                Console.Clear();
                Console.WriteLine ("Please choose a race as below:");
                Console.WriteLine ("Human");
                Console.WriteLine ("Dwarf");
                Console.WriteLine ("Elf");
                Console.WriteLine ("Orc");
                Console.WriteLine ("Your Choice:");
                Player_Race = Console.ReadLine ().ToUpper ();
                if (Player_Race == "HUMAN")
                {
                    Console.WriteLine("This race has the following bonuses:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 1 Point");
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
                }
                    if (Player_Race == "DWARF")
                    {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 2 Point");
                    Console.WriteLine("Ranged Weapons. 1 Point");
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
                    if (Player_Race == "ELF")
                    {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 0 Point");
                    Console.WriteLine("Two Handed Weapons. 1 Point");
                    Console.WriteLine("Ranged Weapons. 2 Point");
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
                    }
                    if (Player_Race == "ORC")
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
            } while(correct == 0);
            correct = 0;
            */