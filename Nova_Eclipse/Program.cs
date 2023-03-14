/**
* 25 Feb 2023
* CSC 153
* Daniel Parks
* Nova Eclipse
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nova_Eclipse
{
    internal class Program
    {

            // 2nd edit - 2nd push 13 March 2023
            String myBDRMRoom, mybath1Room, myspareRM1Room, myStudyRoom, myHallwayRoom, myKitchenRoom, myDiningRMRoom, myLivingRMRoom, myBath2Room;
            String knifeWeapon, pistolWeapon, punchWeapon, kickWeapon;
            String healPotion, revivePotion;
            String oneTreasure, fiveTreasure, tenTreasure, twentyTreasure;
            String flashlightItem, ropeItem, batteriesItem, watchItem;



            



        static string menueOption(int answer)
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

                answer = Console.ReadLine();
                string answer
                    switch (answer, answer)
                    {
                    case 1:
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
                            "\n" +
                            "\n" +
                            " 1. My Bedroom " +
                            " 2. Bathroom 1 " +
                            " 3. Spare Room " +
                            " 4. Study " +
                            " 5. Hallway " +
                            " 6. Kitchen " +
                            " 7. Dining Room " +
                            " 8. Living Room " +
                            " 9. Bathroom 2 "
                            );
                        break;

                    case 2:
                        Console.WriteLine("____ Weapons____\n" +
                        "   1 - Pistol\n" +
                        "   2 - Knife\n" +
                        "   3 - Punch\n" +
                        "   4 - Kick\n");
                        break;

                    case 3:
                         Console.WriteLine("____Potions____\n" +
                        "   1 - Heal\n" +
                        "   2 - Revive\n");
                        break;

                    case 4:
                        Console.WriteLine("____Treasure____\n" +
                        "   1 - $1.00\n" +
                        "   2 - $5.00\n" +
                        "   3 _ $10.00\n" +
                        "   4 - $20.00\n");
                        break;  
           
                    case 5:
                        Console.WriteLine("____Items____\n" +
                        "   1 - Flashlight\n" +
                        "   2 - Rope\n" +
                        "   3 _ Batteries\n" +
                        "   4 - Watch\n");
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Entry. Please make a selection. "
                        break;
                    }
                
                }
            
        }
    }
}