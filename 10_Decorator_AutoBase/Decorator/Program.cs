using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Renault reno = new Renault("Рено", "Renault LOGAN Active", 499.0);
            Print(reno);
            AutoBase myreno = new MediaNAV(reno, "Навигация");
            Print(myreno);
            AutoBase newmyReno = new SystemSecurity(new MediaNAV(reno, "Навигация"), "Безопасность");
            Print(newmyReno);

            BMW bmw = new BMW("БМВ", "BMW i8 Roadster", 1000.0);
            Print(bmw);
            AutoBase mybmw = new HeatedSteeringWheel(bmw, "Подогрев руля");
            Print(mybmw);
            AutoBase newmybmw = new AirConditioning(new HeatedSteeringWheel(bmw, "Руль теплый"), "Кондиционер");
            Print(newmybmw);
        }
        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }
    }
}

/*Фасад — это простой интерфейс для работы со сложной подсистемой, 
 * содержащей множество классов.Фасад может иметь урезанный интерфейс, 
 * не имеющий 100% функциональности, которой можно достичь, используя сложную подсистему напрямую. 
 * Но он предоставляет именно те возможности, которые нужны клиенту, и скрывает все остальные.
 */

//Позволяет избежать перегрузке классов наследованием.
