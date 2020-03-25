using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    public class Chassis
    {
        float _numberOfWheels;
        float _permissibleLoad;
        string _serialNumber;

        public Chassis (float numberOfWheels, float permissbleLoad, string serialNumber)
        {
            NumberOfWheels = numberOfWheels;
            PermissbleLoad = permissbleLoad;
            SerialNumber = serialNumber;
        }
        public float NumberOfWheels
        {
            set
            {
                CheckWheels(value);
                _numberOfWheels = value;
            }
            get
            {
                return _numberOfWheels;
            }
            
        }
        public float PermissbleLoad
        {
            set
            {
                _permissibleLoad = value;
            }
            get
            {
                return _permissibleLoad;
            }
            
        }
        public string SerialNumber
        {
            set
            {
                LettersCheck(value);
                _serialNumber = value;
            }

            get
            {
                return _serialNumber;
            }
           
        }
        public void  LettersCheck(string value)
        {
            if (value == String.Empty || value == null)
            {
                throw new ArgumentException();
            }
        }
        void CheckWheels(float value)
        {
            if (value < 0)
            {
                throw new Exception("Invalid number of wheels");
            }
        }

        public string GetInfo()
        {
            return $"CHASSIS \n" + $"Number of wheels: {_numberOfWheels} \n" + $"Serial number: {_serialNumber}\n" + $"Permissible load: {_permissibleLoad} kilogram \n";
        }
    }
}
