using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DecoratorOptions : AutoBase
    {
        public AutoBase AutoProperty { protected get; set; }
        public string Title { get; set; }
        public DecoratorOptions(AutoBase au, string tit)
        {
            AutoProperty = au;
            Title = tit;
        }
        public override double GetCost() { return 2.0; }
    }
}
