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
            int Enemy_Maximum_Damage;
            int Player_Inventory_Money = 0;
            int Player_Inventory_Experience = 0;
            int Quest_Reward_EXP;
            int Quest_Reward_Gold;
            int Player_Quest_Progress = 0;
            int Player_Quest_Goal;
            int Player_EXP = 0;
            int Player_Checked_For_Item = 0;
            //strings:
            string Player_Gender;
            string Player_Race;
            string Player_Class;
            string[] Inventory = new string[20];
            string Input;
            string Enemy_Name;
            string Player_Quest = " ";
            string Quest_Accepted;
            string Player_Quest_Enemy;
            //Caracter Creation:
            do {
                Console.Clear();
                Console.WriteLine ("Please choose a gender as below:");
                Console.WriteLine ("Male / Female");
                Player_Gender = Console.ReadLine ().ToUpper();
                if (Player_Gender == "MALE")
                {
                    correct =1;
                }
                if (Player_Gender == "FEMALE") 
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
                else if (Player_Race != "HUMAN" || Player_Race != "DWARF" || Player_Race != "ELF" || Player_Race != "ORC")
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

            //Bonuses:
            //Race Bonus:
            if (Player_Race == "HUMAN")
            {
                Player_One_Handed++;
                Player_Two_Handed++;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }
            if (Player_Race == "DWARF")
            {
                Player_One_Handed++;
                Player_Two_Handed = Player_Two_Handed + 2;
                Player_Ranged_Weapon++;
            }
            if (Player_Race == "ELF")
            {
                Player_One_Handed++;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
                Player_Magic++;
            }
            if (Player_Race == "ORC")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Two_Handed = Player_Two_Handed + 2;
            }
            
            //Class Bonus:
            if (Player_Class == "WARRIOR")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Two_Handed = Player_Two_Handed + 2;
            }
            if (Player_Class == "HUNTER")
            {
                Player_One_Handed++;
                Player_Two_Handed++;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
            }
            if (Player_Class == "MAGE")
            {
                Player_One_Handed++;
                Player_Ranged_Weapon++;
                Player_Magic = Player_Magic + 2;   
            }
            if (Player_Class == "THIEF")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }


            //Player description, Writeout
            Console.Clear();
            Console.WriteLine("Your Full Character Description, is:");
            Console.WriteLine("A {0} {1} {2}",Player_Gender, Player_Race, Player_Class);
            Console.WriteLine("One Handed Weapon Skill Points: {0}", Player_One_Handed);
            Console.WriteLine("Two Handed Weapon Skill Points: {0}", Player_Two_Handed);
            Console.WriteLine("Ranged Weapon Skill Points: {0}", Player_Two_Handed);
            Console.WriteLine("Magical Attack Skill Points: {0}", Player_Magic);
            Console.ReadLine();

            Inventory[0] = "a"; Inventory[1] = "b" ; Inventory[2] = "snails";

            Console.Clear();
            Console.WriteLine ("Inventory Test: type inventory below");
            Input = Console.ReadLine ().ToUpper ();
            //Inventory System:
            if (Input == "INVENTORY" || Input == "INV")
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

            //Enemy Declair System:
            Enemy_Name = "Rat";
            Enemy_Health_Points = 12;
            Enemy_Maximum_Damage = 2;


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
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = random.Next(0,11);
                    if(Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_One_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage",Player_One_Handed);
                    }
                    else{}
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                if(Player_Attack_Type == 2)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = random.Next(0, Player_Two_Weapon_Damage);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = random.Next(0,11);
                    if(Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Two_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage",Player_Two_Handed);
                    }
                    else{}
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                if(Player_Attack_Type == 3)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = random.Next(0, Player_Ranged_Weapon);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = random.Next(0,11);
                    if(Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Ranged_Weapon;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage",Player_Ranged_Weapon);
                    }
                    else{}
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                if(Player_Attack_Type == 4)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = random.Next(0, Player_Magic);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = random.Next(0,11);
                    if(Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Magic;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage",Player_Magic);
                    }
                    else{}
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                else{}
                if(Enemy_Health_Points > 0)
                {
                    Random Enemy_Damage_Roll = new Random();
                    int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Enemy_Maximum_Damage);
                    Console.WriteLine("The {0} Strikes back, and deal {1} Points of Damage",Enemy_Name, Random_Enemy_Damage_Roll);
                    Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;
                    Console.ReadLine();
                }
                else{}
            }while(Player_Health_Points > 0 && Enemy_Health_Points > 0);
            Console.Clear();
            if (Enemy_Health_Points < 0)
            {
                Enemy_Health_Points = 0;
            }
            if (Enemy_Health_Points < 0)
            {
                Enemy_Health_Points = 0;
            }
            Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points",Player_Health_Points, Player_Mana_Points);
                Console.WriteLine("The {0}s Health is at {1} Points",Enemy_Name, Enemy_Health_Points);
                Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
                Console.WriteLine("1. One Handed Attack");
                Console.WriteLine("2. Two Handed Attack");
                Console.WriteLine("3. Ranged Weapon Attack");
                Console.WriteLine("4. Magical Attack");
                if (Enemy_Health_Points > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("... You lost the battle");
                    Console.ReadLine();
                }
                if (Enemy_Health_Points > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("... You won the battle");
                    Console.ReadLine();
                }

                //Quest giving system:
                Quest_Reward_EXP = 20;
                Quest_Reward_Gold = 50;
                Player_Quest_Goal = 3;
                Player_Quest_Enemy = "Rats";

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
                        Console.WriteLine ("I would gladly pay you to kill the 3 rats thats annoying me, out on my field");
                        Console.WriteLine ("Reward: {0} Gold, and {1} EXP", Quest_Reward_Gold, Quest_Reward_Gold);
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
                        Console.WriteLine("Your Inventory contains:");
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
                    if (Input == "STATUS" || Input == "STATS") {
                        do{
                            Console.Clear();
                            Console.WriteLine ("Your character is:");
                            Console.WriteLine ("A {0} {1} {2}", Player_Gender, Player_Class, Player_Class);
                            Console.WriteLine("One Handed Weapon Skill Points: {0}", Player_One_Handed);
                            Console.WriteLine("Two Handed Weapon Skill Points: {0}", Player_Two_Handed);
                            Console.WriteLine("Ranged Weapon Skill Points: {0}", Player_Two_Handed);
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


                //Tutorial quest, introduction:
                Console.Clear ();
                Console.WriteLine ("You have just woken up in what seems like a dungon lock up, with brick walls all around you, with little to no light in some areas. you can skimtout of the bars in front of you.");
                Console.WriteLine("______________________________________________________");
                Console.WriteLine ("'Look' around, to see if anything might help you excape.");
                Console.WriteLine ("'Bars' to shake the bars that is locking you in.")
                Console.WriteLine ("'Barrel' in the corner seems to be leaking something.");
                Console.WriteLine ("'Menu' to check your person at this time");
                Input = Console.ReadLine ().ToUpper ();
                if (Input == "LOOK") {
                    if(Player_Checked_For_Item == 0){
                        do{
                            Console.WriteLine("It's just a dirty old cell, in what seems to be a basement..");
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if(Input == "BACK")
                            {correct = 1;}
                            if(Input != "BACK")
                            {correct = 0;}
                        }while(correct == 0);
                    }if(Player_Checked_For_Item == 1)
                    {
                        Console.WriteLine("You notice something, you swar it wasn't there before. An old rusty, metal cup. You pick it up, and put it in your inventory");
                        Inventory{0} = "Old Metal Cup";
                    }
                }
                    }
                }





            Console.ReadLine ();
        }
    }
}