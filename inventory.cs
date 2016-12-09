 /*
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
*/