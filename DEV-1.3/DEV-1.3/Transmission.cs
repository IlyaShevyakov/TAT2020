using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
   public  class Transmission
    {
        string _type;
        string _maker;
        int _numberOfGears;

        public Transmission( string type, string maker, int numberOfGrears)
        {
            Type = type;
            Maker = maker;
            NumberOfGrears = numberOfGrears;
        }
        public int NumberOfGrears
        {
            get
            {
                return _numberOfGears;
            }

            set
            {
                CheckValue(value);
                _numberOfGears = value;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                if (value == String.Empty || value == null)
                {
                    throw new ArgumentException();
                }
                _type = value;
            }
        }
        public string Maker
        {
            get
            {
                return _maker;
            }

            set
            {
                if (value == String.Empty || value == null)
                {
                    throw new ArgumentException();
                }
                _maker = value;
            }

        }
        public void CheckValue(int value)
        {
            if (value < 1)
            {
                throw new ArgumentException("Invalid number of transfers");
            }
        }
        public string GetInfo()
        {
            return $"TRANSMISSION \n" + $"Type: {_type}  drive \n" + $"Number of gears: {_numberOfGears} \n" + $"Maker: {_maker} \n";
        }
    }
}
