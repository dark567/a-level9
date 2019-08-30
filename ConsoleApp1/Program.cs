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

                        foreach (Car spw in CarLogic.GetCar)
                        {
                            Console.WriteLine($" {spw.Id} \t {spw.Type} \t {spw.Color} \t {spw.Price} ");
                        }
                        ShowMenuInConsole();

                        break;
                    case 2: //Show ALL

                        try
                        {
                            addNewCar();
                            Console.WriteLine("\t Item added successfully.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\tError. Something went wrong!)", e.Message);
                        }

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
            CarLogic.AddCar(new Car("Vaz", "Red", 0));
            CarLogic.AddCar(new Car("Vaz", "Green", 0));
            CarLogic.AddCar(new Car("Vaz", "Black", 0));
        }

        private static void addNewCar()
        {
            try
            {
                string Type, Color;
                decimal Price;

                Console.Write("\t Write Type Car:");
                Type = Console.ReadLine();

                Console.Write("\t Write Collor Car:");
                Color = Console.ReadLine();

                bool pr = false;
                do
                {
                    Console.Write("\t Write Price Car:");
                    pr = decimal.TryParse(Console.ReadLine(), out Price);
                    if (Price <= 0) pr = false;

                } while (!pr);


                CarLogic.AddCar(new Car(Type, Color, Price));

                Console.WriteLine("\tSuccessfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("\tError. Something went wrong!)", e.Message);
            }

        }
    }
}
