using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    public  class Line
    {
       
        private string _line;
        /// <summary>
        /// constructor
        /// </summary>
        public Line (string Word)
        {
           word = Word;
        }
        /// <summary>
        /// Method that set and return field values
        /// </summary>
        public string word
        {
            get
            {
                return _line;
            }
            set
            {
                this._line = value ;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsLineEmpty()
        {
            if (word == "")
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
        public int NonRepeatingSymbols()
        {
            int count = 0;
            int max = 0;
            char buffer = '\0';
            buffer = word[0];
            for (int i = 1; i < word.Length; ++i)
            {
                if (word[i] != buffer)
                {
                    count++;
                }
                else
                {
                    if (max < count)
                    {
                        max = count;
                    }
                    count = 1;
                    buffer = word[0];
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
