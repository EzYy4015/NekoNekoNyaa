using System;
using System.Collections.Generic;

namespace PassTask13
{   
    /// <summary>
    /// This is a NekoNekoNyaa class which contains 3 fields
    /// </summary>
    public class NekoNekoNyaa
    {   
        private List<GroupMember> _allmembers;
        private List<HobbyGroup> _groups;
        private List<string> _generalNews;

        /// <summary>
        /// This is a constructor of NekoNekoNyaa Class
        /// </summary>
        public NekoNekoNyaa()
        {
            _allmembers = new List<GroupMember>();
            _groups = new List<HobbyGroup>();
            _generalNews = new List<string>();
            
        }

        /// <summary>
        /// This is a property for the List of Allmembers which allows me to get the list of Allmembers registered
        /// </summary>
        /// <value></value>
        public List<GroupMember> Allmembers{
            get{ return _allmembers; }
        }

        /// <summary>
        /// This is a property for the List of Groups which allows me to get the list of Groups registered
        /// </summary>
        /// <value></value>
        public List<HobbyGroup> Groups{
            get{ return _groups; }
        }  

        /// <summary>
        /// This is a property of the List string of GeneralNews which allows me to get the List of GeneralNews
        /// </summary>
        /// <value></value>
        public List<string> GeneralNews{
            get{ return _generalNews; }
        }  

        /// <summary>
        /// This is a property for me to get the number of items inside the _groups List
        /// </summary>
        /// <value></value>
        public int GroupCount{
            get{ return _groups.Count; }
        }  

        /// <summary>
        /// This is an indexer property for the List of HobbyGroup which allows me to access an object by using an index
        /// </summary>
        /// <value></value>
        public HobbyGroup this[int i]{
            get{ return _groups[i]; }
        }    

        /// <summary>
        /// This is a method that accepts the object created from GroupMember class as a parameter, which allows me to add new GroupMember objects into the List(_allmembers)
        /// </summary>
        /// <param name="allmember"></param>
        public void AddAllMembers(GroupMember allmember){
            _allmembers.Add(allmember);
            foreach(HobbyGroup g in Groups){
                if(g.GroupName == allmember.Group){
                    g.AddMember(allmember);
                }
            }
        }
        
        /// <summary>
        /// This is a method that accepts the object created from HobbyGroup class as a parameter, which allows me to add new hobbygroup objects into the List(_groups)
        /// </summary>
        /// <param name="group"></param>
        public void AddGroup(HobbyGroup group){
            _groups.Add(group);
        }

        /// <summary>
        /// This is a method that accepts the object created from HobbyGroup class as a parameter, which allows me to remove a hobbygroup object from the List(_groups)
        /// </summary>
        /// <param name="group"></param>
        public void DeleteGroup(HobbyGroup group){
            _groups.Remove(group);
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: nname, nfees
        /// Which is used to overwrite the original values of particular fields stored inside the List _groups
        /// </summary>
        /// <param name="nname"></param>
        /// <param name="nfees"></param>
        public void EditGroup(string nname, int nfees){
            
            foreach(HobbyGroup g in Groups){
                if(g.GroupName == nname){
                    g.SubscriptionFees = nfees;
                    
                    Console.WriteLine("Changes are made Successfully...");
                }
            }
            
        }

        /// <summary>
        /// This is method to display the Name and Subcription Fees of all the HobbyGroup objects stored inside the List(_groups)
        /// </summary>
        public void  DisplayGroup(){
        int count1 = 0; 
            foreach(HobbyGroup g in Groups){

                count1 ++;
                Console.WriteLine("\n" + count1 + "." + g.GroupName );
                Console.WriteLine("Fees: " + g.SubscriptionFees );

            }           
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: nname
        /// Which is used to show all the values of fields inside a specific GroupMember object
        /// </summary>
        /// <param name="nname"></param>
        /// <returns></returns>
        public List<GroupMember> ViewMember(string nname){
            List<GroupMember> _results = new List<GroupMember>();
            
                foreach(GroupMember g in Allmembers){
                    if(g.Name == nname){
                    Console.WriteLine("\nMember's Name: " + g.Name);
                    Console.WriteLine("Member's Group: " + g.Group);
                    Console.WriteLine("Member's Status: " + g.Status);
                    Console.WriteLine("Member's subscription Month: " + g.Month);
                    _results.Add(g);
                    }
                }
            return _results;
        }

        /// <summary>
        /// This is a method which displays the List _allmembers according to each Hobby group insde the List _groups
        /// Display the name of members
        /// </summary>
        public void ViewMembers(){
        
            foreach(HobbyGroup g in Groups){
                Console.WriteLine("\nGroup Name: " + g.GroupName);
                foreach(GroupMember p in Allmembers){
                    if(g.GroupName == p.Group){
                        Console.WriteLine("-> " + p.Name);
                    }
                }
            }
        }

        /// <summary>
        /// This is a method which displays the List _allmembers according to each Hobby group insde the List _groups
        /// isplays the name and status of members
        /// </summary>
        public void ViewMembers2(){
        
            foreach(HobbyGroup g in Groups){
                Console.WriteLine("\nGroup Name: " + g.GroupName);
                foreach(GroupMember p in Allmembers){
                    if(g.GroupName == p.Group){
                        Console.WriteLine("-> " + p.Name);
                        Console.WriteLine("-  Status: " + p.Status);
                    }
                }
            }
        }

        /// <summary>
        /// This is a method which displays the List _allmembers according to each Hobby group insde the List _groups
        /// Display the name and subscription method of members
        /// </summary>
        public void ViewMembers3(){
        
            foreach(HobbyGroup g in Groups){
                Console.WriteLine("\nGroup Name: " + g.GroupName);
                foreach(GroupMember p in Allmembers){
                    if(g.GroupName == p.Group){
                        Console.WriteLine("-> " + p.Name);
                        Console.WriteLine("   Subscription Method: " + p.PayMethod);
                    }
                }
            }
        }

        /// <summary>
        /// This is a method which is used to display the members in List _allmembers, according to their subscription month
        /// </summary>
        public void ShowMonthlyMem(){
            for (int num2=0; num2<12; num2++){
                var num3 = (Months)num2;
                string returnMonth = num3.ToString();

                Console.WriteLine( "\n* " + returnMonth + " List: ");
                foreach(GroupMember g in Allmembers){
                    if(g.Month == returnMonth){
                        Console.WriteLine("  Members: " + g.Name); 
                    }      
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: gnews
        /// Which is used to add string objects inside the List _generalNews
        /// </summary>
        /// <param name="gnews"></param>
        public void AddGenNews(string gnews){

            string[] generalInput = { gnews };
            List<string> allgeneralNews = new List<string>(generalInput);
            _generalNews.AddRange(allgeneralNews);

        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: place, edits
        /// Which is used to replace a new string object at a specific place inside the List _generalNews
        /// </summary>
        /// <param name="place"></param>
        /// <param name="edits"></param>
        public void EditGenNews(int place, string edits){

            _generalNews.RemoveRange(place, 1);
            string[] replace = { edits };
            _generalNews.InsertRange(place, replace);

        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: place2
        /// Which is used to delete a string object at a specific place inside the List _generalNews
        /// </summary>
        /// <param name="place2"></param>
        public void DeleteGenNews(int place2){

            _generalNews.RemoveRange(place2, 1); 
            
        }

        /// <summary>
        /// This is a method which displays all the string objects inside the List _generalNews
        /// </summary>
        public void PrintAllGeneralNews(){
            int count = 0;
            foreach( string s in GeneralNews){
                count ++ ;
                Console.WriteLine(count + ". " + s);
            }
        }

        /// <summary>
        /// This is a method which displays all the string objects of the List _hobbyNews inside each HobbyGroup object in List _groups
        /// </summary>
        public void PrintAllGroupNews(){
            
            int i = 0;
            foreach(HobbyGroup g in _groups){
                i++;
                Console.WriteLine("\n" + i + ". HobbyGroup Name: " + g.GroupName);
                Console.WriteLine("--Group News--");
                int o = 0;
                foreach(var h in g.HobbyNews){
                    o++;
                    Console.WriteLine(o + ". " + h);
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: groupname
        /// Which is used to display the string objects in the List _hobbyNews of a specific HobbyGroup object inside the List _groups
        /// </summary>
        /// <param name="groupname"></param>
        public void PrintSingleGroupNews(string groupname){
            
            foreach(HobbyGroup g in _groups){
                if ( g.GroupName == groupname){
                    Console.WriteLine("Group to Edit: " + g.GroupName);
                    int o = 0;
                    foreach(var h in g.HobbyNews){
                        o++;
                        Console.WriteLine(o + ". " + h);
                    }
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: groupname
        /// Which is used to display the string objects in the List _hobbyNews of a specific HobbyGroup object inside the List _groups
        /// </summary>
        /// <param name="groupname"></param>
        public void PrintMemberGroupNews(string groupname){

            foreach(HobbyGroup g in _groups){
                if ( g.GroupName == groupname){
                    int o = 0;
                    foreach(var h in g.HobbyNews){
                        o++;
                        Console.WriteLine(o + ". " + h);
                    }
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: groupname, groupnews
        /// Which is used to add string objects inside the List _hobbyNews of a specific group in List _groups
        /// </summary>
        /// <param name="groupname"></param>
        /// <param name="groupnews"></param>
        public void AddGroupNews(string groupname, string groupnews){
        
            foreach(HobbyGroup g in _groups){
                if( g.GroupName == groupname){

                    string[] eventsInput = { groupnews };
                    List<string> allGroupNews = new List<string>(eventsInput);
                    g.HobbyNews.AddRange(allGroupNews);
                
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: groupname, place3, edits
        /// Which is used to replace a new string object at a specific place inside the List _hobbyNews of a specific group in List _groups
        /// </summary>
        /// <param name="groupname"></param>
        /// <param name="place3"></param>
        /// <param name="edits"></param>
        
        public void EditGroupNews(string groupname, int place3, string edits){
            foreach(HobbyGroup g in _groups){
                if( g.GroupName == groupname ){
                    g.HobbyNews.RemoveRange(place3, 1);
                    string[] replace = { edits };
                    g.HobbyNews.InsertRange(place3, replace);
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: groupname, place4
        /// Which is used to delete a string object at a specific place inside the List _hobbyNews of a specific group in List _groups
        /// </summary>
        /// <param name="groupname"></param>
        /// <param name="place4"></param>
        public void DeleteGroupNews(string groupname, int place4){
            foreach(HobbyGroup g in _groups){
                if( g.GroupName == groupname ){
                    g.HobbyNews.RemoveRange(place4, 1);
                }
            } 
        }

        /// <summary>
        /// This is method which displays all the string objects of the List _hobbyEvents inside each HobbyGroup object in List _groups
        /// </summary>
        public void PrintAllGroupEvents(){
            
            int i = 0;
            foreach(HobbyGroup g in _groups){
                i++;
                Console.WriteLine("\n" + i + ". HobbyGroup Name: " + g.GroupName);
                Console.WriteLine("--Group Events--");
                int o = 0;
                foreach(var h in g.HobbyEvents){
                    o++;
                    Console.WriteLine(o + ". " + h);
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: groupname
        /// Which is used to display the string objects in the List _hobbyEvents of a specific HobbyGroup object inside the List _groups
        /// </summary>
        /// <param name="groupname"></param>
        public void PrintSingleGroupEvent(string groupname){
            
            foreach(HobbyGroup g in _groups){
                if ( g.GroupName == groupname){
                    Console.WriteLine("\nHobby Group: " + g.GroupName);
                    int o = 0;
                    foreach(var h in g.HobbyEvents){
                        o++;
                        Console.WriteLine(o + ". " + h);
                    }
                }
            }
        }  

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: groupname, groupevents
        /// Which is used to add string objects inside the List _hobbyEvents of a specific group in List _groups
        /// </summary>
        /// <param name="groupname"></param>
        /// <param name="groupevents"></param>
        public void AddGroupEvents(string groupname, string groupevents){
            
            foreach(HobbyGroup g in _groups){
                if( g.GroupName == groupname){

                    string[] EventsInput = { groupevents };
                    List<string> allGroupEvents = new List<string>(EventsInput);
                    g.HobbyEvents.AddRange(allGroupEvents);
                    
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: groupname, place3, edits
        /// Which is used to replace a new string object at a specific place inside the List _hobbyEvents of a specific group in List _groups
        /// </summary>
        /// <param name="groupname"></param>
        /// <param name="place3"></param>
        /// <param name="edits"></param>
        public void EditGroupEvents(string groupname, int place3, string edits){
            foreach(HobbyGroup g in _groups){
                if( g.GroupName == groupname ){
                    g.HobbyEvents.RemoveRange(place3, 1);
                    string[] replace = { edits };
                    g.HobbyEvents.InsertRange(place3, replace);
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: groupname, place4
        /// Which is used to delete a string object at a specific place inside the List _hobbyEvents of a specific group in List _groups
        /// </summary>
        /// <param name="groupname"></param>
        /// <param name="place4"></param>
        public void DeleteGroupEvents(string groupname, int place4){
            foreach(HobbyGroup g in _groups){
                if( g.GroupName == groupname ){
                    g.HobbyEvents.RemoveRange(place4, 1);
                }
            } 
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: groupname, returnmonth
        /// Which is used to display the List _hobbyevents according to months, of a specific group in List _groups
        /// </summary>
        /// <param name="groupname"></param>
        /// <param name="returnMonth"></param>
        public void FindEventDate(string groupname, string returnMonth){
            
            foreach(HobbyGroup g in _groups){
                if ( g.GroupName == groupname){
                    int o = 0;
                    foreach(var h in g.HobbyEvents){
                        if(h.Contains(returnMonth)){
                            o++;
                            Console.WriteLine(o + ". " + h); 
                            Console.WriteLine("\n");
                        }
                    } 
                }
            }     
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: memname, month, groupname and groupcomment
        /// Which is used to add a string object into the Allcomments list inside a specific hobby group
        /// </summary>
        /// <param name="memname"></param>
        /// <param name="month"></param>
        /// <param name="groupname"></param>
        /// <param name="groupcomment"></param>
        public void AddComments(string memname, string month, string groupname, string groupcomment){
            foreach(HobbyGroup g in _groups){
                if( g.GroupName == groupname ){
                    string[] commentsInput = { memname + "'s comment on " + month + ": " + groupcomment };
                    List<string> allGroupComments = new List<string>(commentsInput);
                    g.Allcomments.AddRange(allGroupComments);
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: memname1, memname2, month, groupname and groupcomment
        /// Which is used to add a string object into the Allcomments list inside a specific hobby group
        /// </summary>
        /// <param name="memname1"></param>
        /// <param name="memname2"></param>
        /// <param name="month"></param>
        /// <param name="groupname"></param>
        /// <param name="groupcomment"></param>
        public void AddReplies(string memname1, string memname2, string month, string groupname, string groupcomment){
            foreach(HobbyGroup g in _groups){
                if( g.GroupName == groupname ){
                    string[] commentsInput = { memname1 + "'s reply to " + memname2 + " on " + month + ": " + groupcomment };
                    List<string> allGroupComments = new List<string>(commentsInput);
                    g.Allcomments.AddRange(allGroupComments);
                }
            }
        }

        /// <summary>
        /// This is a pass-by-value method which accepts parameters: groupname and returnMonth
        /// Which is used to print out the string objects in Allcomments list inside a specific hobby group
        /// </summary>
        /// <param name="groupname"></param>
        /// <param name="returnMonth"></param>
        public void PrintComments(string groupname, string returnMonth){
            foreach(HobbyGroup g in _groups){
                if ( g.GroupName == groupname){
                    foreach(var h in g.Allcomments){
                        if(h.Contains(returnMonth)){
                                Console.WriteLine(">> " + h); 
                        }
                    } 
                }
            }                
        }
    }
}