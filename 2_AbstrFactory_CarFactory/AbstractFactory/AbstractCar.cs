using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractCar
    {
        public string Name { get; set; }
        public abstract int MaxSpeed (AbstractEngine engine);
        public abstract string CarBody (AbstractBody body);
    }
}
