using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public static class CarLogic
    {


        public static Car[] GetCar
        {
            get
            {
                return Car._ModelCar.ToArray();
            }
        }

        public static void AddCar(Car _modelCar)
        {
            Car._ModelCar.Add(_modelCar);
        }


    }
}
