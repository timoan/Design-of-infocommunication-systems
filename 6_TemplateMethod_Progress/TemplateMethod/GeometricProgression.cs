using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class GeometricProgression: Progression
    {
        public GeometricProgression(int f, int l, int h) : base(f, l, h) { }
        public override void Progress()
        {
            int fF = First;
            do
            {
                progList.Add(fF);
                fF = fF * H;
            }
            while (fF < Last);
        }
    }
}
