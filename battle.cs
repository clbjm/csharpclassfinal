/*
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
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_One_Weapon_Damage);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0,11);
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
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Two_Weapon_Damage);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0,11);
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
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Ranged_Weapon);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0,11);
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
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Magic);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0,11);
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
*/
