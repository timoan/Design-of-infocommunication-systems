using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Adapter
{
    class Kost: IGame
    {
        Random r;
        public Kost()
        {
            r = new Random();
        }
        public int Brosok()
        {
            // Случайное число от 1 до 6.
            int res = r.Next(6) + 1;
            return res;
        }
    }
}
