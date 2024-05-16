using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //existing employee & family data using LIST/Collection

            var EmpData = new List<Biodata>()
            {
                //employee data with login for authorized personel

                new Biodata() {EmpID = 1, Category = "Employee", EmpName = "Muneeb", EmpDep = "HR", EmpDes = "Director" , EmpPayRate = 300, EmpPhone ="03000090109", EmpAge = 40, EmpEmail="director1@company.com", EmpAddress="House 1 DHA Phase 6 Lahore", EmpUsername = "director", EmpPassword = "director123" },

                new Biodata() {EmpID = 2, Category = "Employee", EmpName = "Abdul Raffay", EmpDep = "HR", EmpDes = "Finance Officer", EmpPayRate = 270, EmpPhone ="03004090209", EmpAge = 38, EmpEmail="finance1@company.com", EmpAddress="House 5 DHA Phase 4 Lahore", EmpUsername = "finance", EmpPassword = "finance123" },

                new Biodata() {EmpID = 3, Category = "Employee", EmpName = "Aqib", EmpDep = "HR", EmpDes = "Personal Officer", EmpPayRate = 240, EmpPhone ="03020090909", EmpAge = 32, EmpEmail="personal1@company.com", EmpAddress="House 7 DHA Phase 2 Lahore", EmpUsername = "personal", EmpPassword = "personal123" },

                new Biodata() {EmpID = 4, Category = "Employee", EmpName = "Asim", EmpDep = "HR", EmpDes = "Hiring Officer", EmpPayRate = 250, EmpPhone ="03050390309", EmpAge = 39, EmpEmail="hiring1@company.com", EmpAddress="House 9 DHA Phase 1 Lahore", EmpUsername = "hiring", EmpPassword = "hiring123" },

                new Biodata() {EmpID = 5, Category = "Employee", EmpName = "Aslam", EmpDep = "IT", EmpDes = "IT Consultant", EmpPayRate = 230, EmpPhone ="03100090209", EmpAge = 25, EmpEmail="itconsult1@company.com", EmpAddress="House 3 DHA Phase 7 Lahore" },

                new Biodata() {EmpID = 6, Category = "Employee", EmpName = "Amir", EmpDep = "Sales",  EmpDes = "Sales Officer", EmpPayRate = 230, EmpPhone ="03400090309", EmpAge = 25, EmpEmail="salesoffice1@company.com", EmpAddress="House 11 DHA Phase 8 Lahore" },

                new Biodata() {EmpID = 7, Category = "Employee", EmpName = "Qasim", EmpDep = "Security", EmpDes = "Security Officer", EmpPayRate = 220, EmpPhone ="03220009009", EmpAge = 27, EmpEmail="secuirty1@company.com", EmpAddress="House 21 DHA Phase 6 Lahore" },

                new Biodata() {EmpID = 8, Category = "Employee", EmpName = "Sadiq", EmpDep = "Health", EmpDes = "Medical Officer", EmpPayRate = 243, EmpPhone ="03300440109", EmpAge = 30, EmpEmail="medical1@company.com", EmpAddress="House 91 DHA Phase 5 Lahore" },

                new Biodata() {EmpID = 9, Category = "Employee", EmpName = "Ameen", EmpDep = "IT", EmpDes = "Sr. IT Consultant", EmpPayRate = 255, EmpPhone ="03000054109", EmpAge = 29, EmpEmail="sritconsult1@company.com", EmpAddress="House 27 DHA Phase 6 Lahore" },

                new Biodata() {EmpID = 10, Category = "Employee", EmpName = "Azhar", EmpDep = "Sales",  EmpDes = "Jr. Sales Officer", EmpPayRate = 210, EmpPhone ="03450090109", EmpAge = 20, EmpEmail="jrsalesoffice1@company.com", EmpAddress="House 88 DHA Phase 4 Lahore" },

                //family data

                new Biodata() { EmpID =1 , Category = "Family", Emp_RName = "Saeed" , Emp_Relation = "Father", Emp_RAge =50 },

                new Biodata() { EmpID =2 , Category = "Family", Emp_RName = "Saleem" , Emp_Relation = "Son" , Emp_RAge =17 },

                new Biodata() { EmpID =3 , Category = "Family", Emp_RName = "Laraib", Emp_Relation = "Wife", Emp_RAge =30 },

                new Biodata() { EmpID =4 ,  Category = "Family", Emp_RName = "Aqsa" , Emp_Relation = "Daughter" , Emp_RAge = 19},

                new Biodata() { EmpID =5 , Category = "Family", Emp_RName = "Marium", Emp_Relation = "Mother" , Emp_RAge = 52 },

                new Biodata() { EmpID =6 , Category = "Family", Emp_RName = "Aqil" , Emp_Relation = "Father", Emp_RAge =48 },

                new Biodata() { EmpID =7 , Category = "Family", Emp_RName = "Romaisa" , Emp_Relation = "Wife" , Emp_RAge =26 },

                new Biodata() { EmpID =8 , Category = "Family", Emp_RName = "Sabir" , Emp_Relation = "Son", Emp_RAge = 13 },

                new Biodata() { EmpID =9 , Category = "Family", Emp_RName = "Sana" , Emp_Relation = "Daughter" , Emp_RAge =9 },

                new Biodata() { EmpID =10 , Category = "Family", Emp_RName = "Razia", Emp_Relation = "Mother" , Emp_RAge = 47 },

           };

            //variable declaration
            string username, password;
            int c, s;

            // object creation 
            Reports Obj1 = new Reports();
            Quotes Obj2 = new Quotes();
            Biodata Obj3 = new Biodata();

            Console.WriteLine("\n\n\t\t***Welcome to HR Management System***");

        //jump statement
        RepMain:
            Console.Write("\n\n\tEnter Username: ");
            username = Console.ReadLine();
            Console.Write("\n\n\tEnter Password: ");
            password = Console.ReadLine();

            //if statement to authenticate user and then give access

            var loginauth = EmpData.Where(a => a.EmpUsername == username && a.EmpPassword == password).FirstOrDefault();

            if (loginauth != null)
            {

             var Employeeidcheck = loginauth.EmpID;

                if (loginauth.EmpID == 1)
                {

                d_Main:
                    Console.Clear();
                    Console.WriteLine("\t\t    WELCOME");
                    Console.WriteLine("\n\t\t***" + loginauth.EmpDes + ": " + loginauth.EmpName + " ***" + " Role ID: "+ loginauth.EmpID);

                    Console.WriteLine("\n1-View Existing Employee Record");
                    Console.WriteLine("\n2-View Existing & New Employee's Family Record");

                    Console.WriteLine("\n3-Hire New Employee");
                    Console.WriteLine("\n4-View New Employee's Record");

                    Console.WriteLine("\n5-Add New Employee's Family Information");
                    Console.WriteLine("\n6-Add New Employee's Work & Leave Days");

                    Console.WriteLine("\n7-Apply for New Employee's Loan");
                    Console.WriteLine("\n8-Generate New Employee's Salary Slip");
                    Console.WriteLine("\n9-Get New Employee's Working Days");
                    Console.WriteLine("\n10-Get New Employee's Leave Days");

                    Console.WriteLine("\n11-Create New Job Ad");
                    Console.WriteLine("\n12-View Published Job Ad");

                    Console.WriteLine("\n13-Job Details");
                    Console.WriteLine("\n14-Salary Information");

                    Console.WriteLine("\n15-Get Motivated");

                    Console.WriteLine("\n16-Logout");

                    Console.WriteLine("\nSelect Option(1-16)");
                    c = Convert.ToInt32(Console.ReadLine());

                    // switch statement for menu's working
                    switch (c)
                    {
                        case 1:
                            {
                                Console.Clear();

                                Console.WriteLine("***Existing Employee Information***");

                                //LINQ Query 
                                var empl = from i in EmpData
                                           where i.Category == "Employee"
                                           select i;

                                foreach (var sh in empl)
                                {
                                    Console.WriteLine("E-ID: " + sh.EmpID + "\tCategory: " + sh.Category + "\tName: " + sh.EmpName + "\tDepartment: " + sh.EmpDep + "\tDesignation: " + sh.EmpDes + "\tDaily Wage: " + sh.EmpPayRate + "\tPhone: " + sh.EmpPhone + "\tAge: " + sh.EmpAge + "\tEmail: " + sh.EmpEmail + "\tAddress: " + sh.EmpAddress);
                                }

                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("***Existing Employee's Family Information");
                                var empl = from i in EmpData
                                           where i.Category == "Family"
                                           select i;

                                foreach (var sh in empl)
                                {
                                    Console.WriteLine("E-ID: " + sh.EmpID + "\tCategory: " + sh.Category + "\tName: " + sh.Emp_RName + "\tRelation: " + sh.Emp_Relation + "\tAge: " + sh.Emp_RAge);
                                }
                                Console.WriteLine("\n\n\t\t***New Employee's Family Information***");
                                Obj1.FamilyOutput();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 3:
                            {
                                Console.Clear();
                                Obj1.EMPinput();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 4:
                            {
                                Console.Clear();
                                Obj1.EMPOutput();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 5:
                            {
                                Console.Clear();
                                Obj1.FamilyINPUT();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 6:
                            {
                                Console.Clear();
                                Obj1.work_leave();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 7:
                            {
                                Console.Clear();
                                Obj1.Loan();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 8:
                            {
                                Console.Clear();
                                Obj1.Salary_Slip();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 9:
                            {
                                Console.Clear();
                                Obj1.EMPWorkingDays();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 10:
                            {
                                Console.Clear();
                                Obj1.EMPLeaveDays();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 11:
                            {
                                Console.Clear();
                                Obj1.NewAD();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 12:
                            {
                                Console.Clear();
                                Obj1.RunningAD();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 13:
                            {
                                Console.Clear();
                                Obj1.Job_Details();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 14:
                            {
                                Console.Clear();
                                Obj1.Salary_Criteria();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 15:
                            {
                                Console.Clear();
                                Obj2.Quote();
                                Obj3.Quote();
                                Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                s = Convert.ToInt32(Console.ReadLine());
                                if (s == 1)
                                {
                                    Console.Clear();
                                    goto d_Main;
                                }
                                else
                                    break;
                            }

                        case 16:
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n\t\tGood Bye Sir");
                                Console.WriteLine("\n\n\t\tLogin Again");
                                goto RepMain;
                            }

                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("\n\nSelect valid option.\nSelect Again ");
                                goto d_Main;
                            }
                    }
                }


                else if (loginauth.EmpID == 2)
                {
                    {
                    f_Main:
                        Console.Clear();
                        Console.WriteLine("\t\t    WELCOME");
                        Console.WriteLine("\n\t\t***" + loginauth.EmpDes + ": " + loginauth.EmpName + " ***" + " Role ID: " + loginauth.EmpID);

                        Console.WriteLine("\n1-Apply for New Employee's Loan");
                        Console.WriteLine("\n2-Generate New Employee's Salary Slip");
                        Console.WriteLine("\n3-Salary Information");
                        Console.WriteLine("\n4-Get Motivated");

                        Console.WriteLine("\n5-Logout");

                        Console.WriteLine("\nSelect Option(1-5)");
                        c = Convert.ToInt32(Console.ReadLine());

                        // switch statement for menu's working
                        switch (c)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    Obj1.Loan();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto f_Main;
                                    }
                                    else
                                        break;
                                }

                            case 2:
                                {
                                    Console.Clear();
                                    Obj1.Salary_Slip();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto f_Main;
                                    }
                                    else
                                        break;
                                }

                            case 3:
                                {
                                    Console.Clear();
                                    Obj1.Salary_Criteria();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto f_Main;
                                    }
                                    else
                                        break;
                                }

                            case 4:
                                {
                                    Console.Clear();
                                    Obj2.Quote();
                                    Obj3.Quote();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto f_Main;
                                    }
                                    else
                                        break;
                                }

                            case 5:
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\n\t\tGood Bye Sir");
                                    Console.WriteLine("\n\n\t\tLogin Again");
                                    goto RepMain;
                                }

                            default:
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\nSelect valid option.\nSelect Again ");
                                    goto f_Main;
                                }
                        }
                    }
                }

                if (loginauth.EmpID == 3)
                {
                    {
                    p_Main:
                        Console.Clear();
                        Console.WriteLine("\t\t    WELCOME");
                        Console.WriteLine("\n\t\t***" + loginauth.EmpDes + ": " + loginauth.EmpName + " ***" + " Role ID: " + loginauth.EmpID);

                        Console.WriteLine("\n1-View Existing Employee Record");
                        Console.WriteLine("\n2-View Existing & New Employee's Family Record");

                        Console.WriteLine("\n3-Hire New Employee");
                        Console.WriteLine("\n4-Search New Employee's Record");

                        Console.WriteLine("\n5-Add New Employee's Family Information");
                        Console.WriteLine("\n6-Add New Employee's Working & Leave Days");

                        Console.WriteLine("\n7-Find New Employee's Working Days");
                        Console.WriteLine("\n8-Find New Employee's Leave Days");

                        Console.WriteLine("\n9-Get Motivated");

                        Console.WriteLine("\n10-Logout");

                        Console.WriteLine("\nSelect Option(1-10)");
                        c = Convert.ToInt32(Console.ReadLine());

                        // switch statement for menu's working
                        switch (c)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    Console.WriteLine("***Existing Employee Information***");
                                    var empl = from i in EmpData
                                               where i.Category == "Employee"
                                               select i;
                                    foreach (var sh in empl)
                                    {
                                        Console.WriteLine("E-ID: " + sh.EmpID + "\tCategory: " + sh.Category + "\tName: " + sh.EmpName + "\tDepartment: " + sh.EmpDep + "\tDesignation: " + sh.EmpDes + "\tDaily Wage: " + sh.EmpPayRate + "\tPhone: " + sh.EmpPhone + "\tAge: " + sh.EmpAge + "\tEmail: " + sh.EmpEmail + "\tAddress: " + sh.EmpAddress);
                                    }
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto p_Main;
                                    }
                                    else
                                        break;
                                }

                            case 2:
                                {
                                    Console.Clear();
                                    Console.WriteLine("***Existing Employee's Family Information***");

                                    var empl = from i in EmpData
                                               where i.Category == "Family"
                                               select i;

                                    foreach (var sh in empl)
                                    {
                                        Console.WriteLine("E-ID: " + sh.EmpID + "\tCategory: " + sh.Category + "\tName: " + sh.Emp_RName + "\tRelation: " + sh.Emp_Relation + "\tAge: " + sh.Emp_RAge);
                                    }
                                    Console.WriteLine("\n\n\t\t***New Employee's Family Information***");
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto p_Main;
                                    }
                                    else
                                        break;
                                }

                            case 3:
                                {
                                    Console.Clear();
                                    Obj1.EMPinput();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto p_Main;
                                    }
                                    else
                                        break;
                                }

                            case 4:
                                {
                                    Console.Clear();
                                    Obj1.EMPOutput();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto p_Main;
                                    }
                                    else
                                        break;
                                }

                            case 5:
                                {
                                    Console.Clear();
                                    Obj1.FamilyINPUT();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto p_Main;
                                    }
                                    else
                                        break;
                                }

                            case 6:
                                {
                                    Console.Clear();
                                    Obj1.work_leave();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto p_Main;
                                    }
                                    else
                                        break;
                                }

                            case 7:
                                {
                                    Console.Clear();
                                    Obj1.EMPWorkingDays();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto p_Main;
                                    }
                                    else
                                        break;
                                }

                            case 8:
                                {
                                    Console.Clear();
                                    Obj1.EMPLeaveDays();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto p_Main;
                                    }
                                    else
                                        break;
                                }

                            case 9:
                                {
                                    Console.Clear();
                                    Obj2.Quote();
                                    Obj3.Quote();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto p_Main;
                                    }
                                    else
                                        break;
                                }

                            case 10:
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\n\t\tGood Bye Sir");
                                    Console.WriteLine("\n\n\t\tLogin Again");
                                    goto RepMain;
                                }

                            default:
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\nSelect valid option.\nSelect Again ");
                                    goto p_Main;
                                }
                        }
                    }
                }

                if (loginauth.EmpID == 4)
                {
                    {

                    h_Main:
                        Console.Clear();
                        Console.WriteLine("\t\t    WELCOME");
                        Console.WriteLine("\n\t\t***" + loginauth.EmpDes + ": " + loginauth.EmpName + " ***" + " Role ID: " + loginauth.EmpID);

                        Console.WriteLine("\n1-Create New Job Ad");
                        Console.WriteLine("\n2-View Published Job Ad");

                        Console.WriteLine("\n3-Hire New Employee");
                        Console.WriteLine("\n4-Add New Employee's Family Information");

                        Console.WriteLine("\n5-Job Details");
                        Console.WriteLine("\n6-Salary Information");

                        Console.WriteLine("\n7-Get Motivated");

                        Console.WriteLine("\n8-Logout");

                        Console.WriteLine("\nSelect Option(1-8)");
                        c = Convert.ToInt32(Console.ReadLine());

                        // switch statement for menu's working
                        switch (c)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    Obj1.NewAD();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto h_Main;
                                    }
                                    else
                                        break;
                                }

                            case 2:
                                {
                                    Console.Clear();
                                    Obj1.RunningAD();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto h_Main;
                                    }
                                    else
                                        break;
                                }

                            case 3:
                                {
                                    Console.Clear();
                                    Obj1.EMPinput();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto h_Main;
                                    }
                                    else
                                        break;
                                }

                            case 4:
                                {
                                    Console.Clear();
                                    Obj1.FamilyINPUT();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto h_Main;
                                    }
                                    else
                                        break;
                                }

                            case 5:
                                {
                                    Console.Clear();
                                    Obj1.Job_Details();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto h_Main;
                                    }
                                    else
                                        break;
                                }

                            case 6:
                                {
                                    Console.Clear();
                                    Obj1.Salary_Criteria();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto h_Main;
                                    }
                                    else
                                        break;
                                }

                            case 7:
                                {
                                    Console.Clear();
                                    Obj2.Quote();
                                    Obj3.Quote();
                                    Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (s == 1)
                                    {
                                        Console.Clear();
                                        goto h_Main;
                                    }
                                    else
                                        break;
                                }

                            case 8:
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\n\t\tGood Bye Sir");
                                    Console.WriteLine("\n\n\t\tLogin Again");
                                    goto RepMain;
                                }

                            default:
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\nSelect valid option.\nSelect Again ");
                                    goto h_Main;
                                }

                        }

                    }
                }

            }
            else
            {
                Console.WriteLine("\n\nInvalid Username or Password");
                Console.WriteLine("Try Again");
                goto RepMain;
            }

            Console.ReadKey();
        }
    }
}

