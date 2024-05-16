using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    //polymorphism
     public class Quotes
    {
        public virtual void Quote()
        {
            Console.WriteLine("Motivational Quotes Below !!!");
        }
    }

    //inheritance from class
    //using accesss modifier
    public class Biodata : Quotes
    {
        // array declartion
        public int[] Employee_ID = new int[20];
        public string[] Name = new string[20];
        public string[] Department = new string[20];
        public string[] Designation = new string[20];
        public string[] PayRate = new string[20];
        public string[] Phone = new string[20];
        public string[] Age = new string[20];
        public string[] Email = new string[20];
        public string[] Address = new string[20];
        public string[] Relative_Name = new string[40];
        public string[] Relation = new string[40];
        public string[] R_Age = new string[40];
        public string[] job_ad = new string[20];

        //variable declaration
        public int Age1;
        public long Phone1;
        public int Pay1;
        public string check;
        public int check1;

        public string new_hire;
        public int hiring;

        //decalring variables for LIST/Collection of Existing Employee

        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Category { get; set; }
        public string EmpDep { get; set; }
        public string EmpDes { get; set; }
        public int EmpPayRate { get; set; }
        public string EmpPhone { get; set; }
        public int EmpAge { get; set; }
        public string EmpEmail { get; set; }
        public string EmpAddress { get; set; }

        //decalring variables for LIST/Collection of Employee's Family

        public string Emp_RName { get; set; }
        public string Emp_Relation { get; set; }
        public int Emp_RAge { get; set; }

        //decalring variables for LIST/Collection of Employee's Login

        public string EmpUsername { get; set; }
        public string EmpPassword { get; set; }

        //decalring variables for authentication of employee login in LIST/Collection

        public string Username { get; set; }
        public string Password { get; set; }

        //using polymorphism
        public override void Quote()
        {
            Console.WriteLine("\n\n1-Look in the Mirror that's your competition.");
            Console.WriteLine("\n\n2-Live as if you were to die tomorrow. Learn as if you were to live forever.");
            Console.WriteLine("\n\n3-Be yourself; everyone else is already taken.");
            Console.WriteLine("\n\n4-If opportunity doesn’t knock, build a door.");
            Console.WriteLine("\n\n5-I haven’t failed. I’ve just found 10,000 ways that won’t work.");
        }

    }

}