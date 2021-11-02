using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Text_based_RPG_Map
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2D Text-based RPG Map");
            Console.WriteLine("By: Brianna Chisholm");
            Console.ReadKey(true);
            Console.WriteLine();
            DisplayMapLegend();
            Console.ReadKey(true);
            Console.WriteLine();
            DisplayMap();
            Console.ReadKey(true);
            Console.WriteLine();
            DisplayMap(2);
            Console.ReadKey(true);
            Console.WriteLine();
            DisplayMap(3);
            Console.ReadKey(true);
        }

        static void DisplayMap()
        {
            string[,] Map = new string[,]
            {
             {"^","^","^","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"^","^","'","'","'","'","*","*","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","~","~","~","'","'","'"},
             {"^","^","'","'","'","*","*","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","~","~","~","'","'","'","'","'"},
             {"^","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"'","'","'","'","~","~","~","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"'","'","'","'","~","~","~","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"'","'","'","~","~","~","~","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","^","^","'","'","'","'","'","'"},
             {"'","'","'","'","'","~","~","~","'","'","'","'","'","'","'","'","'","'","'","'","'","^","^","^","^","'","'","'","'","'"},
             {"'","'","'","'","'","~","~","~","~","'","'","'","'","'","'","'","'","'","'","'","'","'","'","^","^","^","^","'","'","'"},
             {"'","'","'","'","'","'","'","~","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
            };

            Console.WriteLine();

            for (int y = 0; y <= 11; y++) // starts at 0 to 11
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("║");
                for (int x = 0; x <= 29; x++)
                {
                    if (Map[y, x] == "^") { Console.ForegroundColor = ConsoleColor.White;}
                    else if (Map[y, x] == "*") { Console.ForegroundColor = ConsoleColor.Green;}
                    else if (Map[y, x] == "'") { Console.ForegroundColor = ConsoleColor.Yellow;}
                    else if (Map[y, x] == "~") { Console.ForegroundColor = ConsoleColor.Blue;}
                    else { Console.ForegroundColor = ConsoleColor.Gray;}
                    Console.Write(Map[y, x]);
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("║"); 

            }
        }

        static void DisplayMap(int scale)
        {
            string[,] Map = new string[,]
            {
             {"^","^","^","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"^","^","'","'","'","'","*","*","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","~","~","~","'","'","'"},
             {"^","^","'","'","'","*","*","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","~","~","~","'","'","'","'","'"},
             {"^","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"'","'","'","'","~","~","~","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"'","'","'","'","~","~","~","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"'","'","'","~","~","~","~","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","^","^","'","'","'","'","'","'"},
             {"'","'","'","'","'","~","~","~","'","'","'","'","'","'","'","'","'","'","'","'","'","^","^","^","^","'","'","'","'","'"},
             {"'","'","'","'","'","~","~","~","~","'","'","'","'","'","'","'","'","'","'","'","'","'","'","^","^","^","^","'","'","'"},
             {"'","'","'","'","'","'","'","~","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
             {"'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
            };

            for (int y = 0; y <= Map.GetLength(0) - 1; y++)
            {
                for (int s = scale; s >= 1; s--)
                {
                    Console.Write("║"); 

                    for (int x = 0; x <= Map.GetLength(1) - 1; x++)
                    {
                        for (int z = scale; z >= 1; z--)
                        {
                            
                            if (Map[y, x] == "^") { Console.ForegroundColor = ConsoleColor.White;}
                            else if (Map[y, x] == "*") { Console.ForegroundColor = ConsoleColor.Green;}
                            else if (Map[y, x] == "'") { Console.ForegroundColor = ConsoleColor.Yellow;}
                            else if (Map[y, x] == "~") { Console.ForegroundColor = ConsoleColor.Blue;}
                            else { Console.ForegroundColor = ConsoleColor.Gray;}
                            Console.Write(Map[y, x]);
                        }
                    }
                    Console.WriteLine("║");
                }
            }

        }
        static void DisplayMapLegend()
        {
            string[,] legend = new string[1, 6]
            {
              { "Map Legend" ,"///////////" , "^ = Mountain" , "' = Grass" , "~ = Water" , "* = Trees"}
            };
            for (int x = 0; x <= 0; x++)
            {

                for (int y = 0; y <= 5; y++)
                {
                    if (legend[x, y] == "^ = Mountain") { Console.ForegroundColor = ConsoleColor.White;}
                    else if (legend[x, y] == "' = Grass") { Console.ForegroundColor = ConsoleColor.Yellow;}
                    else if (legend[x, y] == "~ = Water") { Console.ForegroundColor = ConsoleColor.Blue;}
                    else if (legend[x, y] == "* = Trees") { Console.ForegroundColor = ConsoleColor.Green;}
                    else { Console.ForegroundColor = ConsoleColor.Gray;}
                    Console.WriteLine(legend[x, y]);
                }
            }
        }
    }
}
