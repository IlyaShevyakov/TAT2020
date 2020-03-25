using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    public class Engine
    {
        float _power;
        float _engineVolume;
        string _type;
        string _serialNumber;

        public Engine(float power, float engineVolume, string type, string serialNumber)
        {
            Power = power;
            EngineVolume = engineVolume;
            Type = type;
            SerialNumber = serialNumber;
        }
         
        public float Power
        {
            get
            {
                return _power;
            }
            set
            {
                CheckValue(value);
                _power = value;
            }
        }
        public float EngineVolume
        {
            get
            {
                return _engineVolume;
            }
            set
            {
                CheckValue(value);
                _engineVolume = value;
            }  
        }
        public string  Type
        {
            get
            {
                return _type;
            }
            set
            {
                LettersCheck(value);
                _type =value ;
            }
        }
        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
            set
            {
                LettersCheck(value);
                _serialNumber= value;
            }
        }
        public void CheckValue(float value)
        {
            if (value < 1)
            {
                throw new ArgumentException("Invalid number of transfers");
            }
        }
        public void LettersCheck(string value)
        {
            if (value == String.Empty || value == null)
            {
                throw new ArgumentException();
            }
        }
        public string GetInfo()
        {
            return $"ENGINE \n" +
                $"Power: {_power} horsepower \n" +
                $"Engine Volume: {_engineVolume} centimeters cubic \n" +
                $"Type: {_type} \n" +
                $"Serial number: {_serialNumber} \n";
        }
    }
}
