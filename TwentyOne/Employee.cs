﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //CREATE CLASS 'Employee' THAT INHERITS SUPERCLASS 'Person' 
    public class Employee : Person /*IQuittable*/
    {
        //CREATE PUBLIC PROPERTY 'Id' AS TYPE INTEGER
        public int Id { get; set; }

        public static bool operator==(Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1.Id, employee2.Id))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator!=(Employee employee1, Employee employee2)
        {
            return false;
        }
        
        

        ////IMPLEMENT THE ABSTRACT 'Person' CLASS 'SayName()' METHOD
        //public override void employeeInfo(int Id, string FirstName, out string Info, string LastName)
        //{
        //    Info = "EMPLOYEE: " + FirstName.ToUpper() + " " + LastName.ToUpper() +
        //    "\n\tID: " + Id; 
        //}

        ////IMPLEMENT INTERFACE METHOD 'Quit' 
        //public void Quit(Employee employee)
        //{
        //    Console.WriteLine("THIS EMPLOYEE QUIT");
        //}
    }
    
}

//namespace TwentyOne
//{
//    //CREATE PUBLIC CLASS 'TwentyOneGame' THAT INHERITS THE SUPERCLASS 'Game' 
//    public class TwentyOneGame : Game, IWalkAway
//    {
//        public override void Play() //'override' LETS US INHERIT THE CLASS 'Game' SINCE 'Play' IS AN ABSTRACT METHOD THAT MUST BE IMPLEMENTED FROM THE 'Game' SUPERCLASS
//        {
//            throw new NotImplementedException(); //THROWS AN ERROR WHEN THE METHOD IS USED
//        }
//        public override void ListPlayers()
//        {
//            Console.WriteLine("21 PLAYERS: ");
//            base.ListPlayers(); //THIS GETS AUTOGENERATED WHEN USING THE 'override' KEYWORD
//        }
//        public void WalkAway(Player player)
//        {
//            throw new NotImplementedException(); //THROWS AN ERROR WHEN THE METHOD IS USED
//        }
//    }
//}
