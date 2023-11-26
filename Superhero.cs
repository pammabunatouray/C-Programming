using System;

namespace Program4
{
    public class SuperHero
    {   //Declared variables
        string _superName;
        string _birthPlace;
        string _firstPower;
        int _yearOfbirth;
        string _secondPower;
        char _firstChar;
        bool _earthStatus;
        //5 Parameter constructor that will accept the heroes information 
        public SuperHero(string superheroName, string birthCity, string firstSuperpower, int birthYear, string secondSuperpower)
        {
            SuperheroName = superheroName;
            BirthCity = birthCity;
            FirstSuperpower=firstSuperpower;
            BirthYear=birthYear;
            SecondSuperpower=secondSuperpower;
            
            IsOnPlanetEarth();
        }

       // String and int properties with a get and set 
        public string SuperheroName { get { return _superName; } set{ _superName = value; } }
        public string BirthCity { get { return _birthPlace; } set { _birthPlace = value; } }
        public string FirstSuperpower { get { return _firstPower; } set { _firstPower = value; } }
        public int BirthYear { get { return _yearOfbirth; } set { _yearOfbirth = value; } }
        public string SecondSuperpower { get { return _secondPower; } set { _secondPower = value; } }

        public char FirstChar { get { return SuperheroName[0]; } }
        

        //Method to determine if the hero is on earth or not
        public void OnPlanetEarth() 
        {
            _earthStatus = true; //This will reflect that the hero is on earth
        }
        
        public void OffPlanetEarth() 
        {
            _earthStatus = false;//This will reflect that the hero is not on earth
        }
        public bool IsOnPlanetEarth() 
        {
           return _earthStatus; //The hero is on earth  
        }
        //Method that will format the string into this method 
        public override string ToString() 
        
        {
            string result = "";
            result +="Super Hero Name:" + SuperheroName + Environment.NewLine;
            result +="Birth City:" + BirthCity + Environment.NewLine;
            result +="First Superpower: " + FirstSuperpower + Environment.NewLine;
            result +="Birth Year:" + BirthYear + Environment.NewLine;
            result +="Second Superpower:"+ SecondSuperpower + Environment.NewLine;
            result += "Earth Status:" + IsOnPlanetEarth() + Environment.NewLine;
            result += "Initial:"+FirstChar + Environment.NewLine;
            return result;

        }

    }
}
