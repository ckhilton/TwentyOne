﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args) 
        {
            //INSTANTIATE AND INITIATE 'Employee' OBJECT WITH ASSIGNED 'FirstName' AND 'LastName' VALUES
            Employee person = new Employee() { FirstName = "SAMPLE ", LastName = "STUDENT" };
            //CALL SUPERCLASS METHOD 'SayName' ON THE 'Employee' CLASS OBJECT NAMED 'person'
            person.SayName(); 
            
            Console.ReadLine();          
        }
    }
}