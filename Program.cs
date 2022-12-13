using System;
using System.Collections.Generic;

namespace PassTask13
{
    class Program
    {
        static void Main()
        {
        
        NekoNekoNyaa neko = new NekoNekoNyaa();
        ShopAdmin admin1 = new ShopAdmin("John", 1234);
        
        HobbyGroup g1 = new HobbyGroup("Tabletop Wargamers", 20);
        HobbyGroup g2 = new HobbyGroup("Magic the Gathering community", 30);
        HobbyGroup g3 = new HobbyGroup("Vanguard community", 50);
        HobbyGroup g4 = new HobbyGroup("Boardgamers community", 15);
        HobbyGroup g5 = new HobbyGroup("Cosplay community", 40);

        neko.AddGroup(g1);
        neko.AddGroup(g2);
        neko.AddGroup(g3);
        neko.AddGroup(g4);
        neko.AddGroup(g5);

        int loginNo = 0;
        while( loginNo != 3)
            {   
                Console.WriteLine("\n----------^--@--^----------");
                Console.WriteLine("\nWelcome to Neko Neko Nyaa!!");
                Console.WriteLine("\nLogin as? Admin(1) Member(2) QuitLogin(3)");
                loginNo = int.Parse(Console.ReadLine());

                switch(loginNo)
                {
                    case 1: 

                        Console.WriteLine("Admin Name: ");
                        string Adminlogin1 = (Console.ReadLine());

                        Console.WriteLine("Admin Pin: ");
                        int Adminlogin2 = int.Parse(Console.ReadLine());

                        if( Adminlogin1 == admin1.Name && Adminlogin2 == admin1.Pin){

                            admin1.DisplayMessage(Adminlogin1);

                            int MenuNo1 = 0;
                            while( MenuNo1 != 8){

                                Console.WriteLine("\nMain Menu: ");
                                Console.WriteLine("1. Manage Hobby Group");
                                Console.WriteLine("2. Register Members");
                                Console.WriteLine("3. Manage Members");
                                Console.WriteLine("4. Process Membership Subcription Fees");
                                Console.WriteLine("5. View Membership Renewal List");
                                Console.WriteLine("6. Manage News");
                                Console.WriteLine("7. Manage Hobby Events");
                                Console.WriteLine("8. Exit Menu");
                                Console.WriteLine("\nKey in the number of Content List: ");

                                MenuNo1 = int.Parse(Console.ReadLine());

                                switch(MenuNo1)
                                {
                                    case 1: 

                                        int HGMNo = 0;
                                        while( HGMNo != 4){

                                            Console.WriteLine("\nAll Hobby Groups: ");
                                            neko.DisplayGroup();

                                            Console.WriteLine("\nHobby Group Management: ");
                                            Console.WriteLine("1. Add Hobby Group");
                                            Console.WriteLine("2. Edit Hobby Group");
                                            Console.WriteLine("3. Delete Hobby Group");
                                            Console.WriteLine("4. Exit");
                                            Console.WriteLine("\nKey in the number of category: ");

                                            HGMNo = int.Parse(Console.ReadLine());
                                        
                                            switch(HGMNo){

                                                case 1:

                                                    Console.WriteLine("\n< Kindly remind that Group name is both Name & Case Sensitive >");
                                                    Console.WriteLine("\nEnter Hobby Group name: ");
                                                    string newgroup = Console.ReadLine();
                                                    Console.WriteLine("\nEnter Hobby Group Subcription Fees:");
                                                    int newGFees = int.Parse(Console.ReadLine());

                                                    HobbyGroup newg = new HobbyGroup(newgroup, newGFees);

                                                    neko.AddGroup(newg);

                                                break;
                                        
                                                case 2:

                                                    neko.DisplayGroup();

                                                    Console.WriteLine("\n< Kindly remind that Group name is both Name & Case Sensitive >");
                                                    Console.WriteLine("\nWhich group do you want to Edit? !Name & Case Sensitive");
                                                    string newname = Console.ReadLine();

                                                    Console.WriteLine("\nEnter new Subscription Fees: ");
                                                    int newFees1 = int.Parse(Console.ReadLine());

                                                    neko.EditGroup(newname, newFees1);
                                        
                                                break;

                                                case 3:
                                            
                                                    neko.DisplayGroup();

                                                    Console.WriteLine("\nWhich group do you want to Delete?");
                                                    Console.WriteLine("Number of the group: ");
                                                    int num1 = int.Parse(Console.ReadLine());

                                                    neko.DeleteGroup(neko[num1-1]);
                                                
                                                break;
                                            }
                                        }

                                    break ;
                                    
                                    case 2:

                                        Boolean Continue = true;
                                        while(Continue != false){
                                            
                                            Console.WriteLine("\n< Kindly remind that Group name and Registration Month are both Name & Case Sensitive >");
                                            Console.WriteLine("\nEnter new Member's Name: ");
                                            string MemName = Console.ReadLine();
                                            Console.WriteLine("\nEnter new Member's Group: ");
                                            string MemGroup = Console.ReadLine();
                                            Console.WriteLine("\nMember's Registration Month: (Example: January, February...)");
                                            string MemMonth = Console.ReadLine();
                                            //Default Password
                                            int MemPin = 56781234;

                                            GroupMember member1 = new GroupMember(MemName, MemPin, MemGroup, MemMonth);

                                            neko.AddAllMembers(member1);

                                            Console.WriteLine("\nDo you want to continue adding? (1)YES (2)NO");
                                            Console.WriteLine("Your choice: (Number)");
                                            int yesNo = int.Parse(Console.ReadLine());

                                            if(yesNo == 1){
                                                Continue = true;
                                            }else{
                                                Continue = false;
                                            }
                                        }

                                    break;

                                    case 3:
                                        
                                        HGMNo = 0;
                                        while( HGMNo != 3){

                                            Console.WriteLine("\nGroup Member Management: ");
                                            Console.WriteLine("1. View and edit Hobby Group Members");
                                            Console.WriteLine("2. Activate/Inactivate Hobby Group Members");
                                            Console.WriteLine("3. Quit");
                                            Console.WriteLine("\nKey in the number of category: ");

                                            HGMNo = int.Parse(Console.ReadLine());

                                            switch(HGMNo){
                                        
                                                case 1:

                                                    Boolean Continue1 = true;
                                                    while(Continue1 != false){

                                                        neko.ViewMembers();

                                                        Console.WriteLine("\n< Kindly remind that Member & Group name is both Name & Case Sensitive >");
                                                        Console.WriteLine("\nWhich Member do you want to Inspect?");
                                                        string newname1 = Console.ReadLine();

                                                        neko.ViewMember(newname1);

                                                        Console.WriteLine("\nEnter new Hobby Group: ");
                                                        string newgroup1 = Console.ReadLine();

                                                        Console.WriteLine("\nEnter new registration Month: (Example: January, February...)");
                                                        string newMonth = Console.ReadLine();

                                                        foreach( HobbyGroup g in neko.Groups ){
                                                            g.EditMember(newname1, newgroup1, newMonth);
                                                        }

                                                        Console.WriteLine("\nDo you want to continue Editing Members? (1)YES (2)NO");
                                                        Console.WriteLine("Your choice: (Number)");
                                                        int yesNo1 = int.Parse(Console.ReadLine());

                                                        if(yesNo1 == 1){
                                                            Continue1 = true;
                                                        }else{
                                                            Continue1 = false;
                                                        } 
                                                    }

                                                break;

                                                case 2:
                                            
                                                    Boolean Continue2 = true;
                                                    while(Continue2 != false){  

                                                        neko.ViewMembers2();
                                        
                                                        Console.WriteLine("\nWhich Member do you want to Activate/Inactivate?(Full Name is required)");
                                                        string newname3 = Console.ReadLine();

                                                        foreach( HobbyGroup g in neko.Groups ){
                                                            g.UpdateStatus(newname3);
                                                        }

                                                        Console.WriteLine("\nDo you want to continue Activating/Deactivating Members? (1)YES (2)NO");
                                                        int yesNo2 = int.Parse(Console.ReadLine());

                                                        if(yesNo2 == 1){
                                                            Continue2 = true;
                                                        }else{
                                                            Continue2 = false;
                                                        } 
                                                    }   

                                                break;
                                            }
                                        }

                                    break;

                                    case 4:

                                        Boolean Continue3 = true;
                                        while(Continue3 != false){                                        
                                            Console.WriteLine("\nMembership List: ");

                                            neko.ViewMembers3();

                                            Console.WriteLine("\nWhich Member do you want to Process?(Full Name is required)");
                                            string newname2 = Console.ReadLine();
                                            foreach( HobbyGroup g in neko.Groups ){
                                                g.UpdateMembership(newname2);   
                                            }   

                                            Console.WriteLine("\nDo you want to continue processing the Members? (1)YES (2)NO");
                                            int yesNo2 = int.Parse(Console.ReadLine());

                                            if(yesNo2 == 1){
                                                Continue3 = true;
                                            }else{
                                                Continue3 = false;
                                            }                            
                                        }

                                    break;

                                    case 5:

                                        Console.WriteLine("\nMonthly Renewal List: ");
                                        Console.WriteLine("##################################");

                                        neko.ShowMonthlyMem();

                                        Console.WriteLine("\n##################################");

                                    break;

                                    case 6:

                                        int MenuNo2 = 0;
                                        while( MenuNo2 != 3){

                                            Console.WriteLine("\nNews Management: ");
                                            Console.WriteLine("1. General News");
                                            Console.WriteLine("2. Individual Group News");
                                            Console.WriteLine("3. Exit ");
                                            Console.WriteLine("\nKey in the number of category: ");
                                            MenuNo2  = int.Parse(Console.ReadLine());

                                            switch(MenuNo2){

                                                case 1:

                                                    Console.WriteLine("\nGeneral News: ");
                                                    neko.PrintAllGeneralNews();

                                                    Console.WriteLine("\n1. Add General News");
                                                    Console.WriteLine("2. Edit General News");
                                                    Console.WriteLine("3. Delete General News");
                                                    Console.WriteLine("\nKey in the number of category: ");
                                                    int listnum1 = int.Parse(Console.ReadLine());

                                                    if(listnum1 == 1){
                                                        Console.WriteLine("\nType in new general news to Add: ");
                                                        string NewGeneralNews = Console.ReadLine();

                                                        neko.AddGenNews(NewGeneralNews);

                                                    }else if( listnum1 == 2){

                                                        Console.WriteLine("\nGeneral News: ");
                                                        neko.PrintAllGeneralNews();

                                                        Console.WriteLine("\nWhich general news do you want to Edit? ");
                                                        int editnum = int.Parse(Console.ReadLine());
                                                        Console.WriteLine("Key in new General News to replace: ");
                                                        string newgenNews = Console.ReadLine();

                                                        neko.EditGenNews(editnum-1, newgenNews);

                                                    }else if( listnum1 == 3){

                                                        Console.WriteLine("\nGeneral News: ");
                                                        neko.PrintAllGeneralNews();

                                                        Console.WriteLine("\nWhich general news do you want to delete? ");
                                                        int deletenum1 = int.Parse(Console.ReadLine());

                                                        neko.DeleteGenNews(deletenum1-1);                                            
                                                    }else{

                                                        Console.WriteLine("Key in a VALID cateogory number.. Thank you :>");

                                                    }

                                                break;

                                                case 2:
                                        
                                                    neko.PrintAllGroupNews();

                                                    Console.WriteLine("\n1. Add HobbyGroup News");
                                                    Console.WriteLine("2. Edit HobbyGroup News");
                                                    Console.WriteLine("3. Delete HobbyGroup News");
                                                    Console.WriteLine("\nKey in the number of category: ");
                                                    int listnum2 = int.Parse(Console.ReadLine());

                                                    if( listnum2 == 1){

                                                        Console.WriteLine("\nWhich HobbyGroup do you like to Add news to?");
                                                        string groupname = Console.ReadLine();

                                                        Console.WriteLine("\nNew HobbyGroup News: ");
                                                        string newHobbyGroupNews = Console.ReadLine();

                                                        neko.AddGroupNews(groupname, newHobbyGroupNews);

                                                    }else if( listnum2 == 2){

                                                        neko.PrintAllGroupNews();

                                                        Console.WriteLine("\nWhich group do you want to edit?");
                                                        string groupEdit = Console.ReadLine();

                                                        neko.PrintSingleGroupNews(groupEdit);

                                                        Console.WriteLine("\nWhich group news do you want to Edit? ");
                                                        int editnewsNo = int.Parse(Console.ReadLine());
                                                        Console.WriteLine("\nKey in new News to replace: ");
                                                        string newGNews = Console.ReadLine();

                                                        neko.EditGroupNews( groupEdit, editnewsNo-1, newGNews);

                                                    }else if( listnum2 == 3){

                                                        neko.PrintAllGroupNews();

                                                        Console.WriteLine("\nWhich group do you want to inspect?");
                                                        string groupDelete = Console.ReadLine();

                                                        neko.PrintSingleGroupNews(groupDelete);

                                                        Console.WriteLine("\nWhich group news do you want to delete? ");
                                                        int deletenum2 = int.Parse(Console.ReadLine());

                                                        neko.DeleteGroupNews(groupDelete, deletenum2-1);

                                                    }else{

                                                        Console.WriteLine("Key in a VALID cateogory number.. Thank you :>");

                                                    }
                                                break;
                                            }                                            
                                        }

                                    break;

                                    case 7:

                                        int listnum3 = 0;
                                        while(listnum3 != 4){

                                            Console.WriteLine("List of HobbyGroup Events: ");

                                            neko.PrintAllGroupEvents();

                                            Console.WriteLine("\n1. Add HobbyGroup Event");
                                            Console.WriteLine("2. Edit HobbyGroup Event");
                                            Console.WriteLine("3. Delete HobbyGroup Event");
                                            Console.WriteLine("4. Quit");
                                            Console.WriteLine("\nKey in the number of category: ");

                                            listnum3 = int.Parse(Console.ReadLine());

                                            switch(listnum3){

                                                case 1:

                                                    Boolean Continue4 = true;
                                                    while(Continue4 != false){ 

                                                        Console.WriteLine("\nWhich HobbyGroup do you like to Add event to? (Full name)");
                                                        string groupname1 = Console.ReadLine();

                                                        Console.WriteLine("\nNew HobbyGroup Event: (Month Name&Date REQUIRED,*1 January 2021: Events...*");
                                                        string newHobbyGroupEvent = Console.ReadLine();

                                                        neko.AddGroupEvents(groupname1, newHobbyGroupEvent);

                                                        Console.WriteLine("\nDo you want to continue Adding events? (1)YES (2)NO");
                                                        int yesNo3 = int.Parse(Console.ReadLine());

                                                        if(yesNo3 == 1){
                                                            Continue4 = true;
                                                        }else{
                                                            Continue4 = false;
                                                        }                            
                                                    }

                                                break;

                                                case 2:

                                                    Boolean Continue5 = true;
                                                    while(Continue5 != false){ 

                                                        neko.PrintAllGroupEvents();

                                                        Console.WriteLine("\nWhich group do you want to edit? (Full Name)");
                                                        string groupEdit2 = Console.ReadLine();

                                                        neko.PrintSingleGroupEvent(groupEdit2);

                                                        Console.WriteLine("\nWhich group Event do you want to Edit? (Num)");
                                                        int editEventNo = int.Parse(Console.ReadLine());
                                                        Console.WriteLine("\nKey in new Event to replace: ");
                                                        string newGEvent = Console.ReadLine();

                                                        neko.EditGroupEvents( groupEdit2, editEventNo-1, newGEvent);

                                                        Console.WriteLine("\nDo you want to continue Editing events? (1)YES (2)NO");
                                                        int yesNo4 = int.Parse(Console.ReadLine());

                                                        if(yesNo4 == 1){
                                                            Continue5 = true;
                                                        }else{
                                                            Continue5 = false;
                                                        }                            
                                                    }

                                                break;

                                                case 3:

                                                    Boolean Continue6 = true;
                                                    while(Continue6 != false){

                                                        neko.PrintAllGroupEvents();

                                                        Console.WriteLine("\nWhich group do you want to inspect? (Full Name)");
                                                        string groupDelete2 = Console.ReadLine();

                                                        neko.PrintSingleGroupEvent(groupDelete2);

                                                        Console.WriteLine("\nWhich group event do you want to delete? (Num)");
                                                        int deletenum3 = int.Parse(Console.ReadLine());

                                                        neko.DeleteGroupEvents(groupDelete2, deletenum3-1); 

                                                        Console.WriteLine("\nDo you want to continue Deleting events? (1)YES (2)NO");
                                                        int yesNo5 = int.Parse(Console.ReadLine());

                                                        if(yesNo5 == 1){
                                                            Continue6 = true;
                                                        }else{
                                                            Continue6 = false;
                                                        }                            
                                                    }

                                                break;
                                            }
                                        }
                                     
                                    break; 
                                }
                            }

                        }else{
                        Console.WriteLine("Key in Correct Name and Passcode, Thank you :>");
                        }

                    break;
                    
                    case 2:
                    
                        Console.WriteLine("Member Name: ");
                        string Memberlogin1 = (Console.ReadLine());

                        Console.WriteLine("Member Pin:  (Kindly Remind that default Passcode is 56781234)" );
                        int Memberlogin2 = int.Parse(Console.ReadLine());

                        foreach(GroupMember m in neko.Allmembers){
                                if( m.Name == Memberlogin1 && m.Status == MemberStatus.Activated){
                                    if( m.Pin == Memberlogin2){

                                        m.DisplayMessage(Memberlogin1);

                                        int MenuNo2 = 0;
                                        while( MenuNo2 != 5)
                                        {
                                            Console.WriteLine("\nMain Menu: ");
                                            Console.WriteLine("1. Manage Membership Details");
                                            Console.WriteLine("2. View News");
                                            Console.WriteLine("3. View Hobby Events");
                                            Console.WriteLine("4. Post Comments On Hobby Events");
                                            Console.WriteLine("5. Exit Menu");
                                            Console.WriteLine("\nKey in the number of Content List: ");

                                            MenuNo2 = int.Parse(Console.ReadLine());

                                            switch(MenuNo2)
                                            {
                                                case 1:
                                                    foreach( HobbyGroup h in neko.Groups){
                                                        foreach( GroupMember p in h.Members){
                                                            if( p.Name == Memberlogin1){

                                                                Console.WriteLine("\n1. Your Name: " + p.Name);
                                                                Console.WriteLine("2. Your Group: " + p.Group);
                                                                Console.WriteLine("3. Your Paying Method: " + p.PayMethod);
                                                                Console.WriteLine("4. Your Subcription Month: " + p.Month );
                                                                Console.WriteLine("5. Change your Passcode");

                                                                Console.WriteLine("\nWhich cateogory to you want to make changes? (num)");
                                                                int answer1 = int.Parse(Console.ReadLine());
                                                        
                                                                if(answer1 == 1){

                                                                    Console.WriteLine("You are not allowed to change your name (Report it to Admin)");

                                                                }else if(answer1 == 2){

                                                                    Console.WriteLine("You are not allowed to change your HobbyGroup (Report it to Admin)");
                                                        
                                                                }else if(answer1 == 3){

                                                                    Console.WriteLine(" Change your Paying Method? Yes(1) No(2)");
                                                                    int answer2 = int.Parse(Console.ReadLine());

                                                                    if(answer2 == 1){

                                                                        p.ChangePayingMethod();

                                                                    }else{

                                                                        Console.WriteLine("Paying Method remains the same..");

                                                                    }

                                                                }else if(answer1 == 4){

                                                                    Console.WriteLine("You are not allowed to change your HobbyGroup (Report it to Admin)");

                                                                }else if(answer1 ==5){

                                                                    Console.WriteLine("Change your Passcode to?");
                                                                    int newPasscode = int.Parse(Console.ReadLine());

                                                                    p.ChangePasscode(newPasscode);

                                                                }else{

                                                                    Console.WriteLine("\nKey in a VALID cateogory number.. Thank you :>");

                                                                }
                                                            }
                                                        }
                                                    }

                                                break;

                                                case 2:
                                                
                                                    Console.WriteLine("\nGeneral News: ");

                                                    int count8 = 0;
                                                    foreach( string s in neko.GeneralNews){
                                                        count8 ++ ;
                                                        Console.WriteLine(count8 + ". " + s);
                                                    }

                                                    foreach( HobbyGroup o in neko.Groups){
                                                        if( m.Group == o.GroupName){
                                                            Console.WriteLine("\nNews in: " + o.GroupName);

                                                            neko.PrintMemberGroupNews(o.GroupName);

                                                        }
                                                    }

                                                break;

                                                case 3:
                                               
                                                    Console.WriteLine("\nEvents in: " + m.Group);
                                                    for (int num2=0; num2<12; num2++){
                                                        var num3 = (Months)num2;
                                                        string returnMonth = num3.ToString();

                                                        Console.WriteLine( "\n* " + returnMonth + " events: ");
                                                        neko.FindEventDate(m.Group, returnMonth );
                                                    }

                                                break;

                                                case 4:

                                                    Console.WriteLine("\nPick a category: " );
                                                    Console.WriteLine("1. Make a comment on Events");
                                                    Console.WriteLine("2. Reply to comments on Events");
                                                    int answer3 = int.Parse(Console.ReadLine());

                                                    if(answer3 == 1){

                                                        Console.WriteLine("\nEvents in: " + m.Group);
                                                            for (int num2=0; num2<12; num2++){
                                                                var num3 = (Months)num2;
                                                                string returnMonth = num3.ToString();

                                                                Console.WriteLine( "\n* " + returnMonth + " events: ");
                                                                neko.FindEventDate(m.Group, returnMonth );

                                                                neko.PrintComments(m.Group, returnMonth);
                                                            }

                                                            Console.WriteLine("\nWhich month of the events?");
                                                            string monthname = Console.ReadLine();

                                                            Console.WriteLine("\nKey in your comments: ");
                                                            string comment1 = Console.ReadLine();

                                                            neko.AddComments(m.Name, monthname, m.Group, comment1);

                                                    }else if(answer3 == 2){

                                                        Console.WriteLine("\nEvents in: " + m.Group);
                                                        for (int num2=0; num2<12; num2++){

                                                            var num3 = (Months)num2;
                                                            string returnMonth = num3.ToString();
                                                            Console.WriteLine( "\n* " + returnMonth + " events: ");
                                                            neko.FindEventDate(m.Group, returnMonth );
                                                
                                                            neko.PrintComments(m.Group, returnMonth);

                                                        }
                                                        
                                                        Console.WriteLine("\nWhich month of the events?");
                                                        string monthname1 = Console.ReadLine();

                                                        Console.WriteLine("\nWho do you want to reply? ");
                                                        string name1 = Console.ReadLine();

                                                        Console.WriteLine("\nKey in your reply to " + name1 + " :");
                                                        string reply = Console.ReadLine();

                                                        neko.AddReplies(m.Name, name1, monthname1, m.Group, reply);

                                                    }else{
                                                        Console.WriteLine("\nKey in a VALID cateogory number.. Thank you :>");
                                                    }                                             
                                                break;
                                            }   
                                        }
                                    }
                                }
                            }   
                    break;
                }
            }
            Console.WriteLine("\n----------^--@--^----------");
            Console.WriteLine("\nSee You Next Time!");
            Console.WriteLine("\n");
        }
    }
}
