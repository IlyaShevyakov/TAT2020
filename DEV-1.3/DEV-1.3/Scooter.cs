using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    class Scooter : VehicleBase
    {
        private double _maximumSpeed;
        public Scooter(int maximumSpeed, Engine engine, Chassis chassis, Transmission transmission): base(engine, chassis, transmission)
        {
            MaximumSpeed = _maximumSpeed;
        }

        public double MaximumSpeed
        {
            set
            {
                CheckValue(value);
             _maximumSpeed = value;
            }

            get
            {
                return _maximumSpeed;
            }
        }
        public void CheckValue(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid number of transfers");
            }
        }
        public override string GetInfo()
        {
            string scooterInfo = base.GetInfo();
            return (scooterInfo + $"\nMaximum speed: {MaximumSpeed}");
        }
    }
}
