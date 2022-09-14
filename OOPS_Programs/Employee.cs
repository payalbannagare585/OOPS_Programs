using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Programs
{
    public class Employee
    {
        public int EmpID = 201;
        public string EmpName = "Payal Bannagare";
        public string EmpJobrole = "HR";
        public double EmpSalary = 5000;
        public string EmpCmp = "Cybase Pvt.Lmt.";

       public void displayEmp()
        {
            Console.WriteLine("*Employee Details*");
            Console.WriteLine("Employee ID is: " + EmpID);
            Console.WriteLine("Employee name is: " + EmpName);
            Console.WriteLine("Employee job role in company is: " + EmpJobrole);
            Console.WriteLine("Employee salary is: " + EmpSalary);
            Console.WriteLine("Employee company name is: " + EmpCmp);

        }

        
          
           
        
    }
}
