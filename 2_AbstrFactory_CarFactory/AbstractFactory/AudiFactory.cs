using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AudiFactory: CarFactory
    {
        AudiFactory() { }
        static Lazy<AudiFactory> myAudiFactory = new Lazy<AudiFactory>(() => new AudiFactory());
        public static AudiFactory MyAudiFactory { get { return myAudiFactory.Value; } }

        public override AbstractCar CreateCar() { return new AudiCar("Ауди"); }
        public override AbstractEngine CreateEngine() { return new AudiEngine(); }
        public override AbstractBody CreateBody() { return new AudiBody(); }
    }
}
