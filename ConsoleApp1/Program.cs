using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool MQuit = false;

            int ChoiceNomMenu = 0;

            AddCarList();
            ShowMenuInConsole();
            while (!MQuit)
            {

                if (!Int32.TryParse(Console.ReadLine(), out ChoiceNomMenu) || !(ChoiceNomMenu >= 1 && ChoiceNomMenu <= 3))
                {
                    Console.WriteLine("\t Invalid input. Try again:");

                    ShowMenuInConsole();
                    continue;
                }

                switch (ChoiceNomMenu)
                {
                    case 1: //Show ALL

                        foreach (Car spw in Car.GetCar)
                        {
                            Console.WriteLine($" {spw.Id} \t {spw.Type} \t {spw.Color} \t {spw.Price} ");
                        }
                        ShowMenuInConsole();

                        break;
                    case 2: //Show ALL



                        ShowMenuInConsole();

                        break;
                    case 3: //Show ALL

                        Console.WriteLine("\t Quitting...");
                        MQuit = true;
                        break;
                    default:
                        break;
                }
            }
        }

        static void ShowMenuInConsole()
        {
            Console.WriteLine("\n Please choose one of the options:");
            Console.WriteLine("\t [1] Show ALL Cars");
            Console.WriteLine("\t [2] Enter New CAr");
            Console.WriteLine("\t [3] Exit the program");
        }

        static void AddCarList()
        {
            CarLogic.AddCar("Vaz", "Red", 0);
            CarLogic.AddCar("Vaz", "Red", 0);
            CarLogic.AddCar("Vaz", "Red", 0);
        }
    }
}
