using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;
        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }
        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }
        public double Add(double operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }
        public double Subtraction(double operand)
        {
            return Run(new Subtraction(arithmeticUnit, operand));
        }
        public double Multiply(double operand)
        {
            return Run(new Multiply(arithmeticUnit, operand));
        }
        public double Divide(double operand)
        {
            return Run(new Divide(arithmeticUnit, operand));
        }
    }
}
