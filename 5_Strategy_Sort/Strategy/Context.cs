using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Context
    {
        StrategySort strategy;
        int[] array;

        public Context(StrategySort strategy, int[] array)
        {
            this.strategy = strategy;
            this.array = array;
        }

        public void Sort() { strategy.Sort(array); }

        public void PrintArray()
        {
            Console.WriteLine(strategy.ToString());
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}
