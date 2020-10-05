using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Progression val = new ArithmeticProgression(1, 8, 2);
            val.TemplateMethod();

            val = new GeometricProgression(1, 6, 3);
            val.TemplateMethod();
        }
    }
}

//позволяет разбить какую-то функцию на подфункции и реализовать ее функционал поочередным выполнением каждой подфункции
//удобство: общие подфункции можно описать в абстрактном классе
