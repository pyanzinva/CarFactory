using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class SUVFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new SUV();
        }
    }

}
