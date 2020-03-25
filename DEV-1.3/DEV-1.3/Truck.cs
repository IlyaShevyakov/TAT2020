using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    class Truck : VehicleBase
    {
        private double _maximumLoad;
        public Truck(double maximumLoad, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            MaximumLoad = maximumLoad;
        }
        public double MaximumLoad
        {
            set
            {
                CheckValue(value);
                _maximumLoad = value;
            }

            get
            {
                return _maximumLoad;
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
            string truckInfo = base.GetInfo();
            return (truckInfo + $"\nMaximun load: {MaximumLoad}");
        }
    }
}
