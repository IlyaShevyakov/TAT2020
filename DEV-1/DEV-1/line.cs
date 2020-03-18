using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    public  class NumberOfDifferentSymbols 
    {
       
        private string _line;
        /// <summary>
        /// constructor
        /// </summary>
        public NumberOfDifferentSymbols (string Line)
        {
           line = Line;
        }
        /// <summary>
        /// Method that set and return field values
        /// </summary>
        public string line
        {
            get
            {
                return _line;
            }
            set
            {
                checkValue(value);
                this._line = value ;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsLineEmpty()
        {
            if (line == "")
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Throw exception if value of string is null
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string  checkValue(string value)
        {
            if (value == null)
            {
                throw new ArgumentException();
            }
            return value;
        }
        /// <summary>
        /// Method counts number of non repeating symbols in line
        /// </summary>
        /// <returns></returns>
        public int NumberNonRepeatingCharacter()
        {
            if (line == "")
                {
                    return 0;
                }
            int count = 0;
            int max = 0;
            char buffer = '\0';
            buffer = line[0];
            
            for (int i = 1; i < line.Length; ++i)
            {
                
                if (line[i] != buffer)
                {
                    count++;
                    buffer = line[i];
                }
                else
                {
                    if (max < count)
                    {
                        max = count;
                    }
                    count = 1;
                    buffer = line[i];
                }
            }
            if (count > max)
            {
                max = count;

                return max;
            }
            else
            {
                return 0;
            }
        }
        
    }
}
