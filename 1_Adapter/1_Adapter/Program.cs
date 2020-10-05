using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Kost kubik = new Kost();
            Gamer g1 = new Gamer("Иван");
            Console.WriteLine("Выпало очков {0} для игрока {1}", g1.SeansGame(kubik), g1.ToString());

            Monet mon = new Monet();
            IGame bmon = new AdapterGame(mon);
            Console.WriteLine("Монета показала \"{0}\" для игрока {1}", g1.SeansGame(bmon), g1.ToString());
        }
    }
}