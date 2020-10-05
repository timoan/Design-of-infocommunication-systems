using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        private AbstractCar abstractCar;
        private AbstractEngine abstractEngine;
        private AbstractBody abstractBody;

        public Client(CarFactory car_factory)
        {
            abstractCar = car_factory.CreateCar();
            abstractEngine = car_factory.CreateEngine();
            abstractBody = car_factory.CreateBody();
        }

        public int RunMaxSpeed() { return abstractCar.MaxSpeed(abstractEngine); }
        public override string ToString() { return abstractCar.ToString(); }
        public string NameCarBody() { return abstractCar.CarBody(abstractBody); }
    }
}
