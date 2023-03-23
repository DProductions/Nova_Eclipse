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
using System.IO;
using System.Threading.Tasks;






namespace Nova_Eclipse
    {
        internal class Program
        {
            // 2nd edit - 2nd push 13 March 2023
            string myRoom1, myRoom2, myRoom3, myRoom4, myRoom5, myRoom6, myRoom7; myRoom8, myRoom9
            string myBackyard, myFrontDoor;
            string myWeapons1, myWeapons2, myWeapons3, myWeapons4;
            string myPotions1, myPotions2;
            string treasure1, treasure2, treasure3, treasure4;   
            string myItems1, myItems2, myitems3, myitems4;

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
                    string end;
                int answer = Convert.ToInt32(Console.ReadLine());

                    switch ( answer)
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
                                "\n"  );
                            try {      
                                string line;
                               
                                StreamReader sr = new StreamReader(@"..\..\..\..\Nova_Eclipse\Nova_Eclipse\Variables\rooms.txt");
                                line = sr.ReadLine();
                            
                                while (line!= null) {  
                                    Console.WriteLine(line);
                                    line =  sr.ReadLine();
                                }

                                }
                        
                            finally
                                {
                                  var wait = Task.Run(async delegate
                                     {
                                      await Task.Delay(TimeSpan.FromSeconds(2));
                                      return;
                                      });
                                  wait.Wait();
                                  Console.WriteLine("\nPlease make next selection\n");
                                }
                               

                            break;

                        case 2:
                            Console.WriteLine("____ Weapons____\n" );
                            try {      
                                string line;
                               
                                StreamReader sr = new StreamReader(@"..\..\..\..\Nova_Eclipse\Nova_Eclipse\Variables\weapons.txt");
                                line = sr.ReadLine();
                            
                                while (line!= null) {  
                                    Console.WriteLine(line);
                                    line =  sr.ReadLine();
                                }
                                sr.Close();
                                
                                }
                            finally
                                {  
                                  var wait = Task.Run(async delegate
                                     {
                                      await Task.Delay(TimeSpan.FromSeconds(2));
                                      return;
                                      });
                                  wait.Wait();
                                Console.WriteLine("\nPlease make next selection\n");
                                }
                            break;

                        case 3:
                            Console.WriteLine("____Potions____\n" );
                            try {      
                                string line;
                               
                                StreamReader sr = new StreamReader(@"..\..\..\..\Nova_Eclipse\Nova_Eclipse\Variables\potions.txt");
                                line = sr.ReadLine();
                            
                                while (line!= null) {  
                                    Console.WriteLine(line);
                                    line =  sr.ReadLine();
                                }
                                sr.Close();
                                
                                }
                            finally
                                {
                                  var wait = Task.Run(async delegate
                                     {
                                      await Task.Delay(TimeSpan.FromSeconds(2));
                                      return;
                                      });
                                  wait.Wait();
                                Console.WriteLine("\nPlease make next selection\n");
                                }
                            break;

                        case 4:
                            Console.WriteLine("____Treasure____\n" );
                            try {      
                                string line;
                               
                                StreamReader sr = new StreamReader(@"..\..\..\..\Nova_Eclipse\Nova_Eclipse\Variables\treasure.txt");
                                line = sr.ReadLine();
                            
                                while (line!= null) {  
                                    Console.WriteLine(line);
                                    line =  sr.ReadLine();
                                }
                                sr.Close();
                                
                                }
                            finally
                                {
                                  var wait = Task.Run(async delegate
                                     {
                                      await Task.Delay(TimeSpan.FromSeconds(2));
                                      return;
                                      });
                                  wait.Wait();
                                Console.WriteLine("\nPlease make next selection\n");
                                }
                            break;

                        case 5:
                            Console.WriteLine("____Items____\n" );
                            try {      
                                string line;
                               
                                StreamReader sr = new StreamReader(@"..\..\..\..\Nova_Eclipse\Nova_Eclipse\Variables\items.txt");
                                line = sr.ReadLine();
                            
                                while (line!= null) {  
                                    Console.WriteLine(line);
                                    line =  sr.ReadLine();
                                }
                                sr.Close();
                                
                                }
                            finally
                                {
                                  var wait = Task.Run(async delegate
                                     {
                                      await Task.Delay(TimeSpan.FromSeconds(2));
                                      return;
                                      });
                                  wait.Wait();
                                Console.WriteLine("\nPlease make next selection\n");
                                }
                            break;

                        case 6:
                            isSelected = true;
                            end = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("\n***Invalid Entry. Please make a selection.***\n ");

                            break;
                    }

                }
            }
        }
    }
