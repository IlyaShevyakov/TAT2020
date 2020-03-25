using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    public class Bus : VehicleBase
    {
        private int _numberOfDoors;

        public Bus(int numberOfDoors , Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            NumberOfDoors = numberOfDoors;
        }
        public int NumberOfDoors
        {
            set
            {
                CheckValue(value);
                 _numberOfDoors = value;
            }

            get
            {
                return _numberOfDoors;
            }
        }
        public void CheckValue(int value)
        {
            if (value < 1)
            {
                throw new ArgumentException("Invalid number of transfers");
            }
        }
        public override string GetInfo()
        {
            string busInfo = base.GetInfo();
            return (busInfo + $"\nNumber of doors : {NumberOfDoors}");
        }
    }
}
