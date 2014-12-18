using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Arbiter
    {
        /// <summary>
        /// Encapsulated fields in class Arbiter
        /// </summary>
        private string _firstName;
        private string _lastName;
        private string _season;



        /// <summary>
        /// Properties for fisrt name and last name of one arbiter
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("You have to enter valid name!");
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("You have to enter valid last name!");
                }
                _lastName = value;
            }
        }
        /// <summary>
        /// Propertie Season that gets and sets values for a season in which one arbiter is registrated
        /// </summary>
        public string Season
        {
            get
            {
                return _season;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("You have to enter valid value for one Season!");
                }
                _season = value;
            }
        }


        /// <summary>
        /// Class default constructor
        /// </summary>
        public Arbiter()
        {
            isVerified(0);
        }
        /// <summary>
        /// Method that checks if Arbiter is verified to judge one competition
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool isVerified(int a)
        {
            if (a == 1)
            {
                return true;
            } 
            else if( a==0)
            {
                return false;
            }
            else
            {
                throw new Exception("Not valid input!");
            }
        }
        /// <summary>
        /// Method that takes name and grade, and returns a string as representation of competitor and his grade
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grade"></param>
        /// <returns></returns>
        public string addGrade(string name, int grade)
        {
            if (grade<11 && grade >-1)
            {
                string strGrade= grade.ToString();
                return strGrade+name;
            }
            else
            {
                throw new Exception("Grade is not in the valid interval!");
            }
        }

    }
}
