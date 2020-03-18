using System;
using System.Collections.Generic;


namespace DEV_1._2
{
   public  class NumberConverter
    {
        private int _number;
        private int _systemNumber;
        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="systemNumber"></param>
        public NumberConverter( int number, int  systemNumber)
        {
            Number = number;
            SystemNumber = systemNumber;
        }
        /// <summary>
        /// check the type of   number
        /// </summary>
        /// <param name="value"></param>
        public void CheckNumber(int value)
        {
            if (value < 0)
            {
                throw new ArgumentNullException();
            }
           
        }
        /// <summary>
        /// Number accepts and returns values
        /// </summary>
        public int Number
        {
           
            set
            {
                CheckNumber(value);
                _number = value;
            }
            get
            {
                return _number;
            }
        }
        /// <summary>
        /// checks the order of the number system
        /// </summary>
        /// <param name="value"></param>
        public void CheckSystemNumber(int value)
        {
            if (value <2)
            {
                throw new ArgumentException();
            }
            if (value >20)
            {
                throw new Exception();
            }

        }
        /// <summary>
        /// System accepts and returns values
        /// </summary>
        public int SystemNumber
        {
            set
            {
                CheckSystemNumber(value);
                _systemNumber = value;
            }
            get
            {
                return _systemNumber;
            }
        }
        /// <summary>
        /// translates a number from one number system to another
        /// </summary>
        /// <returns></returns>
        public string TransferToNewSystem()
        {
            int remains = 0;
            List<string> TheOldNumber = new List<string>();

            while (Number > 0)
            {
                remains = Number % SystemNumber;
                Number = Number / SystemNumber;
                CheckRemains(remains, TheOldNumber);
            }

            return CorrectNumber(TheOldNumber);
        }
        /// <summary>
        /// returns the List as a string in reverse order
        /// </summary>
        /// <param name="TheOldNumber"></param>
        /// <returns></returns>
        public static string CorrectNumber(List<string> TheOldNumber)
        {
            List<string> Numbers = new List<string>();

            for (int i = TheOldNumber.Count - 1; i >= 0; i--)
            {
                Numbers.Add(TheOldNumber[i]);
            }

            return string.Join(String.Empty, Numbers);
        }
        /// <summary>
        /// checks the remainder of the division
        /// </summary>
        /// <param name="remains"></param>
        /// <param name="TheOldNumber"></param>
        /// <returns></returns>
        public List<string> CheckRemains(int remains, List<string> TheOldNumber)
        {
            if (remains > 9)
            {
                TheOldNumber.Add(DivisorGreaterThanNine(remains.ToString()));
                return TheOldNumber;
            }

            else
            {
                TheOldNumber.Add(remains.ToString());
                return TheOldNumber;
            }
        }
        /// <summary>
        /// returns the letter to the corresponding remainder
        /// </summary>
        /// <param name="remains"></param>
        /// <returns></returns>
        public static  string DivisorGreaterThanNine(string remains)
        {
            switch (remains)
            {
                case "10":
                return "A";
                case "11":
                return "B";
                case "12":
                return "C";
                case "13":
                return "D";
                case "14":
                return "E";
                case "15":
                return "F";
                case "16":
                return "G";
                case "17":
                return "H";
                case "18":
                return "I";
                case "19":
                return "J";
            }

            return String.Empty;
        }
    }
}
