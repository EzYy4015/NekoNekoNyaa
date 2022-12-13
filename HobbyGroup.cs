using System;
using System.Collections.Generic;

namespace PassTask13
{
    /// <summary>
    /// This is a HobbyGroup Class which contains 5 fields
    /// </summary>
    public class HobbyGroup
    {
        private string _groupName;
        private int _subscriptionFees;
        private List<GroupMember> _members;
        private List<string> _hobbyNews;
        private List<string> _hobbyEvents;
        private List<string> _comments;
        
        /// <summary>
        /// This is a pass-by-value constructor which will receive parameters: groupName, subscriptionFees
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="subscriptionFees"></param>
        public HobbyGroup(string groupName, int subscriptionFees){
            _members = new List<GroupMember>();
            _hobbyNews = new List<string>();
            _hobbyEvents = new List<string>();
            _comments = new List<string>();
            _groupName = groupName;
            _subscriptionFees = subscriptionFees;
        }

        /// <summary>
        /// This is a property for the _groupname field which allows me to set and get the _groupname value of a Hobby group
        /// </summary>
        /// <value></value>
        public string GroupName{
            get{ return _groupName; }
            set{ _groupName = value; }
        }

        /// <summary>
        /// This is a property for the _subscriptionFees field which allows me to set and get the _subscriptionFees value of a Hobby group
        /// </summary>
        /// <value></value>
        public int SubscriptionFees{
            get{ return _subscriptionFees; }
            set{ _subscriptionFees = value; }
        }

        /// <summary>
        /// This is a property for the List string of HobbyNews which allows me to get the list of HobbyNews in a Hobby group
        /// </summary>
        /// <value></value>
        public List<string> HobbyNews{
            get{ return _hobbyNews; }
        }

        /// <summary>
        /// This is a property for the List string of HobbyEvents which allows me to get the list of HobbyEvents in a Hobby group
        /// </summary>
        /// <value></value>
        public List<string> HobbyEvents{
            get{ return _hobbyEvents; }
        }

        /// <summary>
        /// This is a property for the List of Members which allows me to get the list of Members registered
        /// </summary>
        /// <value></value>
        public List<GroupMember> Members{
            get{ return _members; }
        }

        /// <summary>
        /// This is a property for the List of Comments which allows me to get the list of Comments in a Hobby group
        /// </summary>
        /// <value></value>
        public List<string> Allcomments{
            get{ return _comments; }
        }

        /// <summary>
        /// This is a method that accepts the object created from Person class as a parameter, which allows me to add new person objects into the List(_members)
        /// </summary>
        /// <param name="member"></param>
        public void AddMember(GroupMember member){
            _members.Add(member); 
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: nname, ngroup, nmonth
        /// Which is used to overwrite the original values of particular fields stored inside the List _members
        /// </summary>
        /// <param name="nname"></param>
        /// <param name="ngroup"></param>
        /// <param name="nmonth"></param>
        public void EditMember(string nname, string ngroup, string nmonth){
        
            foreach(GroupMember g in _members){
                if(g.Name == nname){
                    g.Group = ngroup;
                    g.Month = nmonth;
                    Console.WriteLine("Changes are made Successfully...");
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: nname
        /// Which is used to change the value of the Status field of a specific object in the List _members
        /// </summary>
        /// <param name="nname"></param>
        /// <returns></returns>
        public List<GroupMember> UpdateStatus(string nname){
            List<GroupMember> _results = new List<GroupMember>();
            foreach(GroupMember g in _members){
                if(g.Name == nname){
                    if(g.Status == MemberStatus.Activated){
                        g.Status = MemberStatus.Deactivated;
                    }else{
                        g.Status = MemberStatus.Activated;
                    }
                    _results.Add(g);
                    Console.WriteLine("Changes are made Successfully...");
                }
            }
            return _results;
        }
        
        /// <summary>
        /// This is a pass-by-value method which accepts parameters: nname
        /// Which is used to change the value of the PayMethod field of a specific object in the List _members
        /// </summary>
        /// <param name="nname"></param>
        /// <returns></returns>
        public List<GroupMember> UpdateMembership(string nname){
            List<GroupMember> _results = new List<GroupMember>();
            foreach(GroupMember g in _members){
                if(g.Name == nname){
                    if(g.PayMethod == PayMethods.Annually){
                        g.PayMethod = PayMethods.Monthly;
                    }else{
                        g.PayMethod = PayMethods.Annually;
                    }
                    _results.Add(g);
                    Console.WriteLine("Changes are made Successfully...");
                }
            }
            return _results;
        }
        
    }
}