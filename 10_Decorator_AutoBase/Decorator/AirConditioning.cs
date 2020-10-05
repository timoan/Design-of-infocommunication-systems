using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AirConditioning : DecoratorOptions
    {
        public AirConditioning(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Кондиционер";
            Description = p.Description + ". " + this.Title + ". Ощути прохладу даже в самое жаркое лето.";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 10.00;
        }
    }
}
