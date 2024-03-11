using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class SedanFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Sedan();
        }
    }

}
