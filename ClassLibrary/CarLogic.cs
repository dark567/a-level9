using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class CarLogic
    {
        public static void AddCar(string Type, string Color, decimal Price)
        {
            Car car = new Car(Type, Color, Price);
        }


      



    }
}
