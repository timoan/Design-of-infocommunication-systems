using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Adapter
{
    class Monet
    {
        Random r;
        public Monet()
        {
            r = new Random();
        }
        public int BrosokM()
        {
            //Случаное число 1 или 2.
            int res = r.Next(2) + 1;
            return res;
        }
    }
}
