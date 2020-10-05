﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BMW : AutoBase
    {
        public BMW(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }
        public override double GetCost()
        {
            return CostBase * 2;
        }
    }
}
