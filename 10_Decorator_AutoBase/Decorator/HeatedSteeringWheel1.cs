using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HeatedSteeringWheel : DecoratorOptions
    {
        public HeatedSteeringWheel(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Подогрев руля";
            Description = p.Description + ". " + this.Title + ". Новейшая система подогрева руля для эксплуатации в холодном климате";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 50.00;
        }
    }
}
