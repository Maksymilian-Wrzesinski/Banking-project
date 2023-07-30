using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Class1
    {

        //EmpID, EmpName, SalaryPerHour, NoOfWorkingHours and NetSalary.
        public int empID;
        public string empName;
        public double salaryPerHour;
        public int noOfWorkingHours;
        public double netSalary;
        public static string organizationName = "Harsha Inc.";
        public const string typeOfEmployee = "Contract Based";
        public readonly string departamentName;

        public Class1()
        {
            departamentName = "Finance Departament";
    }


    }
}
