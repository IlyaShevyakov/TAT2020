using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
   public class Car : VehicleBase
    {
        private int _numberOfDoors;
        private string  _name;

        public Car(string name, int numberOfDoors, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            Name = name;
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
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                CheckName(value);
                _name = value;
            }
        }
        public void CheckValue(int value)
        {
            if (value < 1)
            {
                throw new ArgumentException("Invalid number of transfers");
            }
        }
        void CheckName(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (LetterCheck(value[i]) == false)
                {
                    throw new Exception("Must be letters of the latin alphabet or numbers");
                }
            }
        }
        bool LetterCheck(char symbol)
        {
            return (((int)symbol >= (char)65) && ((int)symbol <= (char)90)) ||
                (((int)symbol >= (char)97) && ((int)symbol <= (char)122)) ||
                symbol == ' ' || ((int)symbol >= (char)48) && ((int)symbol <= (char)57);
        }
        public override string GetInfo()
        {
            string carInfo = base.GetInfo();
            return (carInfo + $"\nNumber of doors: {NumberOfDoors}"+ $"\nName : {Name}");
        }
    }
}
