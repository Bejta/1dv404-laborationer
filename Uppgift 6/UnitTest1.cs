using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace TestOnTest
{
    /// <summary>
    /// Check_UC4 method shows that it adds arbiter for a season that is already created
    /// </summary>
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void Check_UC4()
        {
            string firstName = "John";
            string lastName = "Locke";
            
            Arbiter arbiter = new Arbiter();

            string name = "Championship";
            string year = "2014";
            Season currentSeason = new Season();

            currentSeason.Name=name;
            currentSeason.Year=year;

            arbiter.FirstName = firstName;
            arbiter.LastName = lastName;

            try
            {
                arbiter.Season=currentSeason.Year;
            }
            catch
            {
                return;
            }
        }

        [TestMethod]
        public void Check_UC4AlternativeFlow()
        {
            string firstName = "John";
            string lastName = "Locke";

            Arbiter arbiter = new Arbiter();

            string name = "Championship";
            string year = "2014";
            Season currentSeason = new Season();

            currentSeason.Name = name;
            currentSeason.Year = year;

            arbiter.FirstName = firstName;
            arbiter.LastName = lastName;

            string incorrectInput = "2040";

            if (currentSeason.Year == incorrectInput)
            {
                arbiter.Season = incorrectInput;
            }
            else
            {
                return ;
            }

        }

    }

     [TestClass]
    public class UnitTest1
    {

       /// <summary>
       /// Testfall 1, test if instance of class is created with valid values
       /// ...and then checks if values returns from class getters
       /// </summary>
        [TestMethod]
        public void CheckConstructor()
        {
            // arrange
            string firstName = "John";
            string lastName = "Locke";
            string season = "2014";
            Arbiter arbiter = new Arbiter();

            //act
            try
            {
                arbiter.FirstName = firstName;
            }
            catch
            {
                return;
            }
            try
            {
                arbiter.Season = season;
            }
            catch
            {
                return;
            }

            try
            {
                arbiter.LastName = lastName;
            }
            catch
            {
                return;
            }
            
            string scenario1 = arbiter.FirstName;
            string scenario2 = arbiter.LastName;
            string scenario3 = arbiter.Season;
        }
        
        /// <summary>
        /// Testfall 2, First name is empty string
        /// </summary>
        [TestMethod]
        public void CheckFieldFirstName()
        {
            // arrange
            string firstName = "";
            string lastName = "Locke";
            string season = "2014";
            Arbiter arbiter = new Arbiter();

            //act
            try
            {
                arbiter.FirstName = firstName;
            }
            catch
            {
                return;
            }
            try
            {
                arbiter.Season = season;
            }
            catch
            {
                return;
            }

            try
            {
                arbiter.LastName = lastName;
            }
            catch
            {
                return;
            }
            
            string scenario1 = arbiter.FirstName;
            string scenario2 = arbiter.LastName;
            string scenario3 = arbiter.Season;

        }

        /// <summary>
        /// Testfall 3, Last name is empty string
        /// </summary>
        [TestMethod]
        public void CheckFieldLastName()
        {
            // arrange
            string firstName = "John";
            string lastName = "";
            string season = "2014";
            Arbiter arbiter = new Arbiter();

            //act
            try
            {
                arbiter.FirstName = firstName;
            }
            catch
            {
                return;
            }
            try
            {
                arbiter.Season = season;
            }
            catch
            {
                return;
            }

            try
            {
                arbiter.LastName = lastName;
            }
            catch
            {
                return;
            }
            
            string scenario1 = arbiter.FirstName;
            string scenario2 = arbiter.LastName;
            string scenario3 = arbiter.Season;

        }

        /// <summary>
        /// Testfall 4, Season is an empty string
        /// </summary>
        [TestMethod]
        public void CheckFieldSeason()
        {
            // arrange
            string firstName = "John";
            string lastName = "Locke";
            string season = "";
            Arbiter arbiter = new Arbiter();

            //act
            try
            {
                arbiter.FirstName = firstName;
            }
            catch
            {
                return;
            }
            try
            {
                arbiter.Season = season;
            }
            catch
            {
                return;
            }

            try
            {
                arbiter.LastName = lastName;
            }
            catch
            {
                return;
            }
            
            string scenario1 = arbiter.FirstName;
            string scenario2 = arbiter.LastName;
            string scenario3 = arbiter.Season;

        }

        /// <summary>
        /// Testfall for Class Season, tests constructor, setters and getters
        /// </summary>
        [TestMethod]
        public void CheckConstructorSeason()
        {
            // arrange
            string name = "Championship";
            string year = "2014";
            
            Season season = new Season();

            //act
            try
            {
                season.Name = name;
            }
            catch
            {
                return;
            }
            try
            {
                season.Year = year;
            }
            catch
            {
                return;
            }
            

            string scenario1 = season.Name;
            string scenario2 = season.Year;
            
        }

        /// <summary>
        /// Testfall with empty string as value for year (oterwise the same as previous)
        /// </summary>
        [TestMethod]
        public void CheckFieldYear()
        {
            // arrange
            string name = "Championship";
            string year = "";

            Season season = new Season();

            //act
            try
            {
                season.Name = name;
            }
            catch
            {
                return;
            }
            try
            {
                season.Year = year;
            }
            catch
            {
                return;
            }


            string scenario1 = season.Name;
            string scenario2 = season.Year;

        }

        /// <summary>
        /// Testfall with empty string as value for Name.
        /// This (and previous) scenarios test alternative flow.
        /// </summary>
        [TestMethod]
        public void CheckFieldName()
        {
            // arrange
            string name = "";
            string year = "2014";

            Season season = new Season();

            //act
            try
            {
                season.Name = name;
            }
            catch
            {
                return;
            }
            try
            {
                season.Year = year;
            }
            catch
            {
                return;
            }

            string scenario1 = season.Name;
            string scenario2 = season.Year;

        }
    }
}
