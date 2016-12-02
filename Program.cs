using System;

namespace Text_based_adventure_game
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            //Ints:
            int correct = 0;
            int Player_One_Handed = 0;
            int Player_Two_Handed = 0;
            int Player_Ranged_Weapon = 0;
            int Player_Magic = 0;
            int Arraycount = 0;
            int Player_Attack_Type = 0;
            int Player_One_Weapon_Damage = 2;
            int Player_Two_Weapon_Damage = 2;
            int Player_Ranged_Weapon_Damage = 2;
            int Player_Magical_Damage = 2;
            int Player_Health_Points = 20;
            int Player_Mana_Points = 12;
            int Enemy_Health_Points;



            //strings:
            string Gender;
            string Race;
            string Class;
            string[] Inventory = new string[20];
            string Input;
            string Enemy_Name;

            //Caracter Creation:
            do {
                Console.Clear();
                Console.WriteLine ("Please choose a gender as below:");
                Console.WriteLine ("Male / Female");
                Gender = Console.ReadLine ().ToUpper();
                if (Gender == "MALE")
                {
                    correct =1;
                }
                if (Gender == "FEMALE") 
                {
                    correct =1;
                }
                else {}
            }while(correct == 0);
            correct = 0;


            //Race Creation:
            do {
                Console.Clear();
                Console.WriteLine ("Please choose a race as below:");
                Console.WriteLine ("Human");
                Console.WriteLine ("Dwarf");
                Console.WriteLine ("Elf");
                Console.WriteLine ("Orc");
                Console.WriteLine ("Your Choice:");
                Race = Console.ReadLine ().ToUpper ();
                if (Race == "HUMAN")
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
                    if (Race == "DWARF")
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
                    if (Race == "ELF")
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
                    if (Race == "ORC")
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
                else if (Race != "HUMAN" || Race != "DWARF" || Race != "ELF" || Race != "ORC")
                {
                    correct = 0;
                } 
            } while(correct == 0);
            correct = 0;





            //Class Creation:
            do {
                Console.Clear();
                Console.WriteLine("Please choose a class as below:");
                Console.WriteLine ("Warrior");
                Console.WriteLine ("Hunter");
                Console.WriteLine ("Mage");
                Console.WriteLine ("Thief");
                Console.WriteLine ("Your Choice:");
                Class = Console.ReadLine ().ToUpper ();
                if (Class == "WARRIOR")
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
                    if (Class == "HUNTER")
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
                    if (Class == "MAGE")
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
                    if (Class == "THIEF")
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

            //Bonuses:
            //Race Bonus:
            if (Race == "HUMAN")
            {
                Player_One_Handed++;
                Player_Two_Handed++;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }
            if (Race == "DWARF")
            {
                Player_One_Handed++;
                Player_Two_Handed = Player_Two_Handed + 2;
                Player_Ranged_Weapon++;
            }
            if (Race == "ELF")
            {
                Player_One_Handed++;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
                Player_Magic++;
            }
            if (Race == "ORC")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Two_Handed = Player_Two_Handed + 2;
            }
            
            //Class Bonus:
            if (Class == "WARRIOR")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Two_Handed = Player_Two_Handed + 2;
            }
            if (Class == "HUNTER")
            {
                Player_One_Handed++;
                Player_Two_Handed++;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
            }
            if (Class == "MAGE")
            {
                Player_One_Handed++;
                Player_Ranged_Weapon++;
                Player_Magic = Player_Magic + 2;   
            }
            if (Class == "THIEF")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }


            Inventory[0] = "a"; Inventory[1] = "b" ; Inventory[2] = "snails";

            Console.Clear();
            Console.WriteLine ("Inventory Test: type inventory below");
            Input = Console.ReadLine ().ToUpper ();
            //Inventory System:
            if (Input == "INVENTORY")
            {
                Console.Clear();
                Console.WriteLine("Your Inventory contains:");
                for (Arraycount = 0; Arraycount < 20; Arraycount++)
                {
                    int inventory_possition = Arraycount +1;
                    Console.SetCursorPosition (0, inventory_possition);
                    Console.WriteLine("{0}", Inventory[Arraycount]);
                }
            }
            else
            {

            }




            //random integer between 0 and 100 (100 not included):




            Random random = new Random();
            int randomNumber = random.Next(0, 100);




            //Enemy Declair System:
            Enemy_Name "Rat";
            Enemy_Health_Points = 12;



            //Combat System:
            do {
                correct = 0;
                Console.Clear();
                Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points",Player_Health_Points, Player_Mana_Points);
                Console.WriteLine("The {0}s Health is at {1} Points",Enemy_Name, Enemy_Health_Points);
                Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
                Console.WriteLine("1. One Handed Attack");
                Console.WriteLine("2. Two Handed Attack");
                Console.WriteLine("3. Ranged Weapon Attack");
                Console.WriteLine("4. Magical Attack");
                Player_Attack_Type = Convert.ToInt32(Console.ReadLine());
                if(Player_Attack_Type == 1)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = random.Next(0, Player_One_Weapon_Damage);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = random.Next(0,11);
                    if(Skill_Point_Outcome > 6)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_One_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage",Player_One_Handed);
                        Console.WriteLine("{0}",Player_One_Handed);
                    }
                    else{}
                }
                if(Player_Attack_Type == 2)
                {
                    
                }
                if(Player_Attack_Type == 3)
                {
                    
                }
                if(Player_Attack_Type == 4)
                {
                    
                }
                else{}
                Console.ReadLine();
            } while(correct == 0);
















            Console.ReadLine();
        }
    }
}