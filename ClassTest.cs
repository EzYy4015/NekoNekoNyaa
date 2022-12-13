using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PassTask13{
    [TestFixture()]
    public class ShopAdminTest{
        [Test()]
        public void TestAddGroup(){

            NekoNekoNyaa nekoneko = new NekoNekoNyaa();
            HobbyGroup group1 = new HobbyGroup("Tabletop Wargamers", 20);
            HobbyGroup group2 = new HobbyGroup("Tabletop Wargamers", 20);

            nekoneko.AddGroup(group1);
            nekoneko.AddGroup(group2);
        
            Assert.AreEqual(nekoneko.GroupCount,2);

        }

        [Test()]
        public void TestAddGeneralNews(){

            NekoNekoNyaa nekoneko = new NekoNekoNyaa();
            string news1 = "Welcome";
            string news2 = "Goodbye";

            nekoneko.AddGenNews(news1);
            nekoneko.AddGenNews(news2);

            Assert.AreEqual(nekoneko.GeneralNews.Count,2);

        }
        
        [Test()]
        public void TestAddMembers(){
            
            NekoNekoNyaa nekoneko = new NekoNekoNyaa();
            GroupMember member1 = new GroupMember("Ali", 1234 , "Cosplay community", "May");
            GroupMember member2 = new GroupMember("Mary", 1234 , "Vanguard community", "March");

            nekoneko.AddAllMembers(member1);
            nekoneko.AddAllMembers(member2);

            Assert.AreEqual(nekoneko.Allmembers.Count, 2);

        }
    }

    public class GroupMemberTest{
        [Test()]
        public void TestChangePasscode(){

            GroupMember member1 = new GroupMember("Ali", 56781234, "Cosplay community", "June");

            int newPasscode = 12345678;
            member1.ChangePasscode(newPasscode);

            Assert.AreEqual(member1.Pin, 12345678);

        }

        [Test()]
        public void TestPayingMethod(){

            GroupMember member1 = new GroupMember("Ali", 56781234, "Cosplay community", "June");

            member1.ChangePayingMethod();

            Assert.AreEqual(member1.PayMethod, PayMethods.Annually);

        }

        [Test()]
        public void TestComments(){

            //GroupMember member1 = new GroupMember("Ali", 56781234, "Cosplay community", "June");

            //string newComment1 = "Interesting..";
            //string newComment2 = "Looking forward to it!";
            //string month1 = "May";
            //string month2 = "June";


            //member1.Addcomments(member1.Name, month1, newComment1);
            //member1.Addcomments(member1.Name, month2, newComment2);

            //Assert.AreEqual(member1.Comments.Count, 2);

        }
    }
}