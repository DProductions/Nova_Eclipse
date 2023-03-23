/**
* 29 Mar 2023
* CSC 153
* Daniel Parks
* Nova Eclipse
* 
* SPRINT 3 completed. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading.Tasks;






namespace Nova_Eclipse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isSelected = false;
            while (!isSelected)
            {
                Console.WriteLine("- - - - - Menu - - - - -\n" +
                                  "Please make a selection\n" +
                                  "   1. Display Rooms\n" +
                                  "   2. Display Weapons\n" +
                                  "   3. Display Potion\n" +
                                  "   4. Display Treasure\n" +
                                  "   5. Display Items\n" +
                                  "   6. Exit-\n" +
                                  "- - - - - - - - - - - -");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine(
                             "\n" +
                             "                                     Back Door                   \n" +
                             "________________________________________     __________________\n" +
                             "|   My      |   Spare   |             |                        |\n" +
                             "| Bedroom   |   Room    |   Study     |         Living Room    |\n" +
                             "|_________  |_________  |   __________|                        |\n" +
                             "| BTHRM1 |           Hallway                                   |\n" +
                             "|_____________________ ________    __                          |\n" +
                             "                      |             |                          |\n" +
                             "                      |                           ______       |\n" +
                             "                      |   Kitchen       Dining    |       |    |\n" +
                             "                      |             |    Room     | BTHRM2|    |\n" +
                             "                      |_____________|_____________|_______|    |\n" +
                             "                                                       Front Door\n" +
                             "\n");

                        // read text file for rooms
                        string[] rooms = File.ReadAllLines(@"..\..\..\..\Nova_Eclipse\Nova_Eclipse\Variables\rooms.txt");
                        Console.WriteLine("\n");
                        Console.WriteLine($"Room 1: {rooms[0]}");
                        Console.WriteLine($"Room 2: {rooms[1]}");
                        Console.WriteLine($"Room 3: {rooms[2]}");
                        Console.WriteLine($"Room 4: {rooms[3]}");
                        Console.WriteLine($"Room 5: {rooms[4]}");
                        Console.WriteLine($"Room 6: {rooms[5]}");
                        Console.WriteLine($"Room 7: {rooms[6]}");
                        Console.WriteLine($"Room 8: {rooms[7]}");
                        Console.WriteLine($"Room 9: {rooms[8]}");


                        break;

                    case "2":
                        // read text file for weapons
                        string[] weapons = File.ReadAllLines(@"..\..\..\..\Nova_Eclipse\Nova_Eclipse\Variables\weapons.txt");
                        Console.WriteLine("\n");
                        Console.WriteLine($"Weapon 1: {weapons[0]}");
                        Console.WriteLine($"Weapon 2: {weapons[1]}");
                        Console.WriteLine($"Weapon 3: {weapons[2]}");
                        Console.WriteLine($"Weapon 4: {weapons[3]}");

                        break;

                    case "3":
                        // read text file for potions
                        string[] potions = File.ReadAllLines(@"..\..\..\..\Nova_Eclipse\Nova_Eclipse\Variables\potions.txt");
                        Console.WriteLine("\n");
                        Console.WriteLine($"Potion 1: {potions[0]}");
                        Console.WriteLine($"Potion 2: {potions[1]}");

                        break;

                    case "4":
                        // read text file for treasure
                        string[] treasure = File.ReadAllLines(@"..\..\..\..\Nova_Eclipse\Nova_Eclipse\Variables\treasure.txt");
                        Console.WriteLine("\n");
                        Console.WriteLine($"Treasure 1: {treasure[0]}");
                        Console.WriteLine($"Treasure 2: {treasure[1]}");
                        Console.WriteLine($"Treasure 3: {treasure[2]}");
                        Console.WriteLine($"Treasure 4: {treasure[3]}");

                        break;

                    case "5":
                        // read text file for items
                        string[] items = File.ReadAllLines(@"..\..\..\..\Nova_Eclipse\Nova_Eclipse\Variables\items.txt");
                        Console.WriteLine("\n");
                        Console.WriteLine($"Item 1: {items[0]}");
                        Console.WriteLine($"Item 2: {items[1]}");
                        Console.WriteLine($"Item 3: {items[2]}");
                        Console.WriteLine($"Item 4: {items[3]}");

                        break;

                    case "6":
                        isSelected = true;
                        break;

                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        break;
                }
            }
        }
    }
}