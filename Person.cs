using System;

namespace PassTask13
{   
    /// <summary>
    /// This is an abstract Person Class which contains 2 fields
    /// </summary>
    public abstract class Person{
        private string _name;
        private int _pin;

        /// <summary>
        /// This is a pass-by-value constructor which will receive parameters: name, pin
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pin"></param>
        public Person(string name, int pin){
            _name = name;
            _pin = pin;
        }

        /// <summary>
        /// This is a property for the _name field which allows me to set and get the _name value of a person
        /// </summary>
        /// <value></value>
        public string Name{
            get{ return _name; }
            set{ _name = value; }
        }

        /// <summary>
        /// This is a property for the _pin field which allows me to set and get the _pin value of a person
        /// </summary>
        /// <value></value>
        public int Pin{
            get{ return _pin; }
            set{ _pin = value; }
        }
        
        /// <summary>
        /// This is an abstract method which accepts a string as a parameter
        /// </summary>
        /// <param name="name"></param>
        public abstract void DisplayMessage(string name);
    }
    
}