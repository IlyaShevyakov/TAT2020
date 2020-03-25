using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    abstract public class VehicleBase
    {
        private Chassis _chassis;
        private Transmission _transmission;
        private Engine _engine;

        public VehicleBase(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        public Engine Engine
        {
            set
            {
                _engine = value ;
            }

            get
            {
                return _engine;
            }
        }

        public Chassis Chassis
        {
            set
            {
                _chassis = value ;
            }

            get
            {
                return _chassis;
            }
        }

        public Transmission Transmission
        {
            set
            {
                _transmission = value ;
            }

            get
            {
                return _transmission;
            }
        }

        virtual public string GetInfo()
        {
            return $"{_engine.GetInfo()}\n" + $"{_chassis.GetInfo()}\n" + $"{_transmission.GetInfo()}\n";
        }
    }
}
