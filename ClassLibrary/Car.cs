using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Car
    {
        

        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        private int discount = 0;

        public static List<Car> _ModelCar;


        static Car()
        {
            _ModelCar = new List<Car>();
        }

        public Car(string Type = "n/a", string Color = "n/a", decimal Price = 0)
        {
            this.Id = Guid.NewGuid();
            this.Type = Type;
            this.Color = Color;
            this.Price = Price;

        }

        public int Discount
        {
            get
            {
                if (Price > 10000)
                {
                    return discount + 25;

                }
                return discount;
            }
            set
            {
                if (value <= 100)
                {
                    discount = value;
                }
                else
                {
                    Console.WriteLine("wrong discount size you are fraud");
                    discount = 0;
                }
            }
        }

    }
}
