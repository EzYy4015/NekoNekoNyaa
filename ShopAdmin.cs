using System;

namespace PassTask13
{
    /// <summary>
    /// This is an ShopAdmin class which inherits the fields from Person class (ShopAdmin is a kind of Person)
    /// </summary>
    public class ShopAdmin:Person
    {
        /// <summary>
        /// This is a pass-by-value constructor which will receive parameters: 
        /// name, pin
        /// while base(name, pin) will be going into the Person class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pin"></param>
        /// <returns></returns>
        public ShopAdmin(string name, int pin):base(name, pin)
        {

        }

        /// <summary>
        /// This is an override method which accepts a string as a parameter and is used to display a message
        /// </summary>
        /// <param name="name"></param>
        public override void DisplayMessage(string name)
        {
            Console.WriteLine("\nWelcome back " + name);
        }
    }
}