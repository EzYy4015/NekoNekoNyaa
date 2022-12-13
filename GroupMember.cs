using System;
using System.Collections.Generic;

namespace PassTask13
{
    /// <summary>
    /// This is a GroupMember class which contains 5 fields, besides, it also inherits the fields from Person class (GroupMember is a kind of Person)
    /// </summary>
    public class GroupMember:Person
    {
        private string _month;
        private string _group; 
        private MemberStatus _status;
        private PayMethods _payMethod;
        //private List<string> _comments;

        /// <summary>
        /// This is a pass-by-value constructor which will receive parameters:
        /// name, pin, group, month
        /// while base(name, pin) will be going into the Person class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pin"></param>
        /// <param name="group"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public GroupMember(string name, int pin, string group, string month):base(name, pin){
            _month = month;
            _group = group;
            _status = MemberStatus.Activated;
            _payMethod = PayMethods.Monthly;
            //_comments = new List<string>();
            
        }

        /// <summary>
        /// This is a property of the List string of Comments which allows me to get the List of Comments
        /// </summary>
        /// <value></value>
        //public List<string> Comments{
            //get{ return _comments; }
        //}

        /// <summary>
        /// This is a property for the _month field which allows me to set and get the _month value of a group member
        /// </summary>
        /// <value></value>
        public string Month{
            get{ return _month; }
            set{ _month = value; }
        }

        /// <summary>
        /// This is a property for the _groups field which allows me to set and get the _groups value of a group member
        /// </summary>
        /// <value></value>
        public string Group{
            get{ return _group; }
            set{ _group = value; }
        }

        /// <summary>
        /// This is a property for the _status field which allows me to set and get the _status value of a group member
        /// </summary>
        /// <value></value>
        public MemberStatus Status{
            get{ return _status; }
            set{ _status = value; }
        }

        /// <summary>
        /// This is a property for the _payMethod field which allows me to set and get the _payMethod value of a group member
        /// </summary>
        /// <value></value>
        public PayMethods PayMethod{
            get{ return _payMethod; }
            set{ _payMethod = value; }
        }   
        
        /// <summary>
        /// This is a method which allows the toggle between values of the PayMethod
        /// </summary>
        public void ChangePayingMethod(){
            if(PayMethod == PayMethods.Annually){
                PayMethod = PayMethods.Monthly;
            }else{
                PayMethod = PayMethods.Annually;
            }
                Console.WriteLine("Changes are made Successfully...");
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: newpasscode
        /// Which is used to change the value of the Pin
        /// </summary>
        /// <param name="newpasscode"></param>
        public void ChangePasscode(int newpasscode){

            Pin = newpasscode;
            Console.WriteLine("\nChanges are made Successfully...");
            Console.WriteLine("\nRemember to Login again to confirm Passcode changes...TQ :>");
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