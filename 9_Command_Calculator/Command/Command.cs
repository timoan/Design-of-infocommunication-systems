using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    abstract class Command
    {
        protected ArithmeticUnit unit;
        protected double operand;
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
