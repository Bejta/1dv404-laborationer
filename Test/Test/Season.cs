using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Season
    {
        /// <summary>
        /// Encapsulated fields
        /// </summary>
        private string _name;
        private string _year;

        /// <summary>
        /// Properties for name of season and year
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Value is not valid!");
                }
                _name = value;
            }
        }

        public string Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Value is not valid!");
                }
                _year = value;
            }
        }
        /// <summary>
        /// Default constructor for class Season
        /// </summary>
        public Season()
        {
            //empty...
        }

        /// <summary>
        /// Method that takes two parameters and returns formated paremer for one arbiter
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public string addArbiter(string firstName, string lastName)
        {
            string arbiter;
            arbiter=String.Format("{0}"+" "+"{1}", firstName,lastName);
            return arbiter;
        }
    }
}
