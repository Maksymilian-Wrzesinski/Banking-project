using Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            for(int i= 0; i < 5; i++)
            {
                string employeenumer;
                switch(i) { 
                    case 0:employeenumer = "First employee";break;
                    case 1:employeenumer = "Second employee";break; 
                    case 2:employeenumer = "Third employee";break;
                    case 3: employeenumer = "Fourth employee"; break;
                    case 4: employeenumer = "Fifth employee"; break;
                }
                Class1 employee1; 
               //employee2, employee3, employee4, employee5;
                employee1 = new Class1();
                //employee2 = new Class1();
                // employee3 = new Class1();
                // employee4 = new Class1();
                // employee5 = new Class1();
                System.Console.WriteLine("Please type employee ID");
                employee1.empID = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Please type employee name");
                employee1.empName = System.Console.ReadLine();
                System.Console.WriteLine("Please type employee salary per hour");
                employee1.salaryPerHour = double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Please type employee number of working hours");
                employee1.noOfWorkingHours = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine(employee1.empID);
                System.Console.WriteLine(employee1.empName);
                System.Console.WriteLine(employee1.salaryPerHour);
                System.Console.WriteLine(employee1.noOfWorkingHours);
                System.Console.WriteLine("Net salary " + employee1.salaryPerHour * employee1.noOfWorkingHours);
                System.Console.WriteLine(Class1.organizationName);
                System.Console.WriteLine(Class1.typeOfEmployee);
                System.Console.WriteLine(employee1.departamentName);
                System.Console.ReadKey();
                
                System.Console.WriteLine("Do you want to continue to the next employee? Y/N");
                string choice = System.Console.ReadLine();
                if (!(choice == "YES" || choice =="Yes"|| choice =="yes"|| choice =="Y"))
                {
                    break;
                }
                System.Console.WriteLine("-----------------------------");
            }

        }
    }
}
