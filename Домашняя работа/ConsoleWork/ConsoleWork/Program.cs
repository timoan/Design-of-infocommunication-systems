using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Уникальный идентификатор пользователя, получаемый при считывании карты.
            string id = "1";
            //Адаптер для работы с ситемой учета времени
            AdapterHandler handler = new AdapterHandler();

            //Вывод результата работы пользователю
            if (handler.fixGo(id))
            {
                Console.WriteLine("GREEEEEEN");
            }
            else
            {
                Console.WriteLine("REEEEEEEEEED");
            }

            //Вывод результата работы пользователю
            if (handler.fixGo("12"))
            {
                Console.WriteLine("GREEEEEEN");
            }
            else
            {
                Console.WriteLine("REEEEEEEEEED");
            }

            //Вывод результата работы пользователю
            if (handler.fixGo(id))
            {
                Console.WriteLine("GREEEEEEN");
            }
            else
            {
                Console.WriteLine("REEEEEEEEEED");
            }

        }
    }
    
}
