using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    //using interface
    interface IJobdetails
    {
        // Job Details
        void Job_Details();
    }

    // using inheritance
    public class Reports : Biodata, IJobdetails
    {
        // array & variable declaration
        public string[] Loan1 = new string[11];
        public string[] Present = new string[11];
        public string[] Absent = new string[11];
        public int Present1;

        //function to record employee information
        public void EMPinput()
        {
        repeats:
            newhire();
            for (int i = 0; i < hiring; i++)
            {
                Console.WriteLine("\n\n***Welcome to New Employee Hiring***");

                Employee_ID[i] = (i + 11);
                Console.WriteLine("\nNew Employee ID: " + Employee_ID[i]);

                //exception handling
                try
                {
                    Console.Write("\nEnter Employee Name: ");
                    Name[i] = Console.ReadLine();

                }

                catch
                {
                    if (Name[i].All(char.IsDigit) || string.IsNullOrEmpty(Name[i]))
                    {
                        Console.WriteLine("\nEnter Valid Name, No Numbers & Null Spaces Allowed.");
                        goto repeats;
                    }

                }

            repeat0:

                try
                {
                    Console.Write("\nEnter Employee Department: ");
                    Department[i] = Console.ReadLine();

                }

                catch
                {
                    if (Department[i].All(char.IsDigit) || string.IsNullOrEmpty(Department[i]))
                    {
                        Console.WriteLine("\nEnter Valid Department & No Null Spaces Allowed.");
                        goto repeat0;
                    }

                }

            repeat1:

                try
                {
                    Console.Write("\nEnter Employee Designation: ");
                    Designation[i] = Console.ReadLine();

                }

                catch
                {
                    if (Designation[i].All(char.IsDigit) || string.IsNullOrEmpty(Designation[i]))
                    {
                        Console.WriteLine("\nEnter Valid Designation & No Null Spaces Allowed.");
                        goto repeat1;
                    }

                }

            repeat2:

                try
                {
                    Console.Write("\nEnter Employee Daily Wage: ");
                    PayRate[i] = Console.ReadLine();
                    Pay1 = Convert.ToInt32(PayRate[i]);
                }

                catch
                {
                    if (!PayRate[i].All(char.IsDigit) || string.IsNullOrEmpty(PayRate[i]))
                    {
                        Console.WriteLine("\nEnter Pay Rate in Digits Only, No Alphabets & Null Spaces Allowed.");
                        goto repeat2;
                    }
                }
                
            repeat3:
                try
                {
                    Console.Write("\nEnter Employee Phone No: ");
                    Phone[i] = Console.ReadLine();
                    Phone1 = Convert.ToInt64(Phone[i]);

                }

                catch
                {
                    if (!Phone[i].All(char.IsDigit) || string.IsNullOrEmpty(Phone[i]))
                    {
                        Console.WriteLine("\nEnter Numbers Only, No Alphabets & Null Spaces Allowed.");
                        goto repeat3;

                    }
                }
                                

            repeat4:
                try
                {
                    Console.Write("\nEnter Employee Age: ");
                    Age[i] = Console.ReadLine();
                    Age1 = Convert.ToInt32(Age[i]);

                }

                catch
                {
                    if (!Age[i].All(char.IsDigit) || string.IsNullOrEmpty(Age[i]))
                    {
                        Console.WriteLine("\nEnter Number Only, No Alphabets & Null Spaces Allowed.");
                        goto repeat4;
                    }

                }

            repeat5:
                try
                {
                    Console.Write("\nEnter Employee Email: ");
                    Email[i] = Console.ReadLine();
                }

                catch
                {
                    if (Email[i].All(char.IsDigit) || string.IsNullOrEmpty(Email[i]))
                    {
                        Console.WriteLine("\nEnter Valid Email & No Null Spaces Allowed.");
                        goto repeat5;
                    }

                }

            repeat6:
                try
                {
                    Console.Write("\nEnter Employee Address: ");
                    Address[i] = Console.ReadLine();

                }

                catch
                {
                    if (Address[i].All(char.IsDigit) || string.IsNullOrEmpty(Address[i]))
                    {
                        Console.WriteLine("\nEnter Valid Address & No Null Spaces Allowed.");
                        goto repeat6;
                    }

                }

                Console.WriteLine("\n\nInformation Saved");

            }

        }

        //Function to Show Employee Record
        public void EMPOutput()
        {
            Console.WriteLine("\n\n***Employee Information***");
            for (int i = 0; i < hiring; i++)
            {

            repeats7:
                Console.Write("\nEnter Employee ID: ");
                check = Console.ReadLine();
                check1 = Convert.ToInt32(check);

                if (!check.All(char.IsDigit) || string.IsNullOrEmpty(check))
                {
                    Console.WriteLine("\nEnter Valid Employee ID Number Only & No Null Spaces Allowed.");
                    goto repeats7;
                }
                if (check1 == Employee_ID[i])
                {
                    Console.WriteLine("\n\n");
                    Console.Write("\nEmployee ID: " + Employee_ID[i]);
                    Console.Write("\nEmployee Name: " + Name[i]);
                    Console.Write("\nEmployee Department: " + Department[i]);
                    Console.Write("\nEmployee Designation: " + Designation[i]);
                    Console.Write("\nEmployee Daily Wage: " + PayRate[i] + " Rs");
                    Console.Write("\nEmployee Loan Amount: " + Loan1[i]);
                    Console.Write("\nEmployee Phone No: " + Phone[i]);
                    Console.Write("\nEmployee Age: " + Age[i]);
                    Console.Write("\nEmployee Email: " + Email[i]);
                    Console.Write("\nEmployee Address: " + Address[i]);
                }
            }
        }

        //function to enter working days & leaves
        public void work_leave()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("***Welcome to Employee Work & Leave Portal***");

        repeat8:
            for (int i = 0; i < hiring; i++)
            {
                Console.Write("\nEnter Employee ID: ");
                check = Console.ReadLine();
                check1 = Convert.ToInt32(check);
                if (!check.All(char.IsDigit) || string.IsNullOrEmpty(check))
                {
                    Console.WriteLine("\nEnter Valid Employee ID Number Only & No Null Spaces Allowed.");
                    goto repeat8;
                }
                if (check1 == Employee_ID[i])
                {

                repeat9:
                    Console.Write("\nEnter Total Working Days: ");
                    Present[i] = Console.ReadLine();
                    Present1 = Convert.ToInt32(Present[i]);

                    if (!Present[i].All(char.IsDigit) || string.IsNullOrEmpty(Present[i]))
                    {
                        Console.WriteLine("\nEnter Working Days in Digits Only, No Alphabets & Null Spaces Allowed.");
                        goto repeat9;
                    }

                repeat10:
                    Console.Write("\nEnter Total Leave Days: ");
                    Absent[i] = Console.ReadLine();

                    if (!Absent[i].All(char.IsDigit) || string.IsNullOrEmpty(Absent[i]))
                    {
                        Console.WriteLine("\nEnter Leave Days in Digits Only, No Alphabets & Null Spaces Allowed.");
                        goto repeat10;
                    }

                    Console.WriteLine("\n\nInformation Saved");
                }
            }
        }

        //function for employee loan
        public void Loan()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("***Welcome to Employee Loan Portal***");

        repeat11:
            for (int i = 0; i < hiring; i++)
            {
                Console.Write("\nEnter Employee ID: ");
                check = Console.ReadLine();
                check1 = Convert.ToInt32(check);
                if (!check.All(char.IsDigit) || string.IsNullOrEmpty(check))
                {
                    Console.WriteLine("\nEnter Valid Employee ID Number Only & No Null Spaces Allowed.");
                    goto repeat11;
                }

                if (check1 == Employee_ID[i])
                {
                repeat12:
                    Console.Write("\nHow Much Loan You Want to apply");
                    Loan1[i] = Console.ReadLine();
                    if (!Loan1[i].All(char.IsDigit) || string.IsNullOrEmpty(Loan1[i]))
                    {
                        Console.WriteLine("\nEnter Loan Amount in Digits Only, No Alphabets & Null Spaces Allowed.");
                        goto repeat12;
                    }
                    Console.WriteLine("\n\n\n");
                    Console.Write("Loan Amount " + Loan1[i] + " RS");
                }
                Console.WriteLine("\n\nInformation Saved");
            }
        }

        //Function To Record Employee Family Information
        public void FamilyINPUT()
        {
            Console.WriteLine("\n\n***Welcome to Family Information Portal***");
            for (int i = 0; i < hiring; i++)
            {
            repeat13:
                Console.Write("\nEnter Employee ID: ");
                check = Console.ReadLine();
                check1 = Convert.ToInt32(check);
                if (!check.All(char.IsDigit) || string.IsNullOrEmpty(check))
                {
                    Console.WriteLine("\nEnter Valid Employee ID Number Only & No Null Spaces Allowed.");
                    goto repeat13;
                }
                if (check1 == Employee_ID[i])
                {
                 repeat14:
                    Console.Write("\nEnter Relative Name: ");
                    Relative_Name[i] = Console.ReadLine();

                    if (Relative_Name[i].All(char.IsDigit) || string.IsNullOrEmpty(Relative_Name[i]))
                    {
                        Console.WriteLine("\nEnter Valid Name, No Numbers & Null Spaces Allowed.");
                        goto repeat14;
                    }

                repeat15:
                    Console.Write("\nEnter Relative Relation: ");
                    Relation[i] = Console.ReadLine();

                    if (Relation[i].All(char.IsDigit) || string.IsNullOrEmpty(Relation[i]))
                    {
                        Console.WriteLine("\nEnter Valid Name, No Numbers & Null Spaces Allowed.");
                        goto repeat15;
                    }

                repeat16:
                    Console.Write("\nEnter Relative's Age: ");
                    R_Age[i] = Console.ReadLine();
                    if (!R_Age[i].All(char.IsDigit) || string.IsNullOrEmpty(R_Age[i]))
                    {
                        Console.WriteLine("\nEnter Age in Number Only, No Alphabets & Null Spaces Allowed.");
                        goto repeat16;
                    }
                }
            }
        }

        //Function To show employee family Record
        public void FamilyOutput()
        {
            Console.WriteLine("\n\n***Employee's Family Information***");
        repeat17:

            for (int i = 0; i < hiring; i++)
            {
                Console.Write("\nEnter Employee ID: ");
                check = Console.ReadLine();
                check1 = Convert.ToInt32(check);

                if (!check.All(char.IsDigit) || string.IsNullOrEmpty(check))
                {
                    Console.WriteLine("\nEnter Valid Employee ID Number Only & No Null Spaces Allowed.");
                    goto repeat17;
                }
                if (check1 == Employee_ID[i])
                {
                    Console.Write("\nEmployee ID: " + Employee_ID[i]);
                    Console.Write("\nRelative Name: " + Relative_Name[i]);
                    Console.Write("\nRelative Relation: " + Relation[i]);
                    Console.Write("\nRelative's Age: " + R_Age[i]);
                }
            }

        }

        //function for creating salary slip
        public void Salary_Slip()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("***Welcome to Employee Salary Slip Portal***");

            for (int i = 0; i < hiring; i++)
            {
                work_leave();

                if (check1 == Employee_ID[i])
                {

                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("***Salary Slip***");
                    Console.Write("\nEmployee ID: " + Employee_ID[i]);
                    Console.Write("\nEmployee Name: " + Name[i]);
                    Console.Write("\nEmployee Department: " + Department[i]);
                    Console.Write("\nEmployee Designation: " + Designation[i]);
                    Console.Write("\nEmployee Daily Wage: " + PayRate[i] + " Rs");
                    Console.Write("\nEmployee Monthly Salary: " + (Pay1 * Present1) + " Rs");
                    Console.Write("\nEmployee Loan Amount: " + Loan1[i]);
                    Console.Write("\nEmployee Present Days: " + Present[i]);
                    Console.Write("\nEmployee Absent Days: " + Absent[i]);
                }

            }

        }

        //employee working days
        public void EMPWorkingDays()
        {
            Console.WriteLine("\n\n***Employee Information***");
            for (int i = 0; i < hiring; i++)
            {
            repeat18:

                Console.Write("\nEnter Employee ID: ");
                check = Console.ReadLine();
                check1 = Convert.ToInt32(check);

                if (!check.All(char.IsDigit) || string.IsNullOrEmpty(check))
                {
                    Console.WriteLine("\nEnter Valid Employee ID Number Only & No Null Spaces Allowed.");
                    goto repeat18;
                }
                if (check1 == Employee_ID[i])
                {
                    Console.WriteLine("\n\n");
                    Console.Write("\nEmployee ID: " + Employee_ID[i]);
                    Console.Write("\nEmployee Name: " + Name[i]);
                    Console.Write("\nEmployee Department: " + Department[i]);
                    Console.Write("\nEmployee Designation: " + Designation[i]);
                    Console.Write("\nEmployee Present Days: " + Present[i]);

                }
            }
        }

        // employee leave days
        public void EMPLeaveDays()
        {
            Console.WriteLine("\n\n***Employee Information***");
            for (int i = 0; i < hiring; i++)
            {
            repeat19:
                Console.Write("\nEnter Employee ID: ");
                check = Console.ReadLine();
                check1 = Convert.ToInt32(check);

                if (!check.All(char.IsDigit) || string.IsNullOrEmpty(check))
                {
                    Console.WriteLine("\nEnter Valid Employee ID Number Only & No Null Spaces Allowed.");
                    goto repeat19;
                }
                if (check1 == Employee_ID[i])
                {
                    Console.WriteLine("\n\n");
                    Console.Write("\nEmployee ID: " + Employee_ID[i]);
                    Console.Write("\nEmployee Name: " + Name[i]);
                    Console.Write("\nEmployee Department: " + Department[i]);
                    Console.Write("\nEmployee Designation: " + Designation[i]);
                    Console.Write("\nEmployee Present Days: " + Present[i]);

                }
            }
        }

        //function for entering number of new employees
        public void newhire()
        {
        EmpRep:

            Console.WriteLine("\n\nHow many Employees you want to hire? (Max 20) ");
            Console.WriteLine("\n");
            new_hire = Console.ReadLine();
            hiring = Convert.ToInt32(new_hire);

            if (string.IsNullOrEmpty(new_hire) || (!new_hire.All(char.IsDigit)) || hiring == 0)
            {
                Console.WriteLine("\nNo Alphabets & Null Spaces Allowed.");
                Console.WriteLine("\nEnter Employees in Positive Number(s) Only. ");
                goto EmpRep;
            }
            else if (hiring > 20)
            {
                Console.WriteLine("\n\nMaximum 20 Employees Allowed\n\nEnter Again. ");
                goto EmpRep;
            }

        }

        //function for creating new employment ad
        public void NewAD()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("***Welcome to New Job Adverstisement***");
            newhire();
            for (int i = 0; i < hiring; i++)
            {
                Console.WriteLine("\nEnter Job Details & Description for Ad:  " + (i + 1));
                job_ad[i] = Console.ReadLine();
                Console.Write("\nAd Successfully Published!!!");
            }
        }

        //function to show new  running ad
        public void RunningAD()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("***Welcome to Job Adverstisement Portal***");

            Console.Write("\n*New Running Ads*");
            for (int i = 0; i < hiring; i++)
            {
                Console.WriteLine("\n\nAd" + (i + 1));
                Console.WriteLine("\nJob Details & Description for Ad: " + job_ad[i]);
            }

        }
        
        // Job Details
        public void Job_Details()
        {
            Console.WriteLine("***Welcome to Job Details Portal***");
            Console.Write("\n1- Director HR ");
            Console.WriteLine("He is responsible for all HR operations in an organization. ");

            Console.Write("\n2- Personal Officer ");
            Console.WriteLine("He is responsible for employee records including family information & attendence and leave information as well ");

            Console.Write("\n3- Finance Officer ");
            Console.WriteLine("He is responsible for financial tasks like salary information & Loan too.");

            Console.Write("\n4- Hiring Manager ");
            Console.WriteLine("He is responsible for hiring new people & posting job ad too. ");
        }

        //Salary Criteria of different Jobs
        public void Salary_Criteria()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("***Welcome to Job Details Portal***");

            Console.Write("\n1- Director HR ");
            Console.WriteLine("\n-Working Days in a Month: 20");
            Console.WriteLine("\n-Daily Wage: 300 RS");

            Console.Write("\n2- Personal Officer ");
            Console.WriteLine("\n-Working Days in a Month: 20");
            Console.WriteLine("\n-Daily Wage: 240 RS");

            Console.Write("\n3- Finance Officer ");
            Console.WriteLine("\n-Working Days in a Month: 20");
            Console.WriteLine("\n-Daily Wage: 270 RS");

            Console.Write("\n4- Hiring Manager ");
            Console.WriteLine("\n-Working Days in a Month: 20");
            Console.WriteLine("\n-Daily Wage: 250 RS");

        }

    }

  }
