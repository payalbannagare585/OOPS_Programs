using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Programs
{
    public class StudentInfo
    {

        public int studID = 101;
        public string studname = "Payal Bannagare";
        public string clgname = "PRMIT&R";
        public string clgcity = "Amravati";
       public void display()
        {
            Console.WriteLine("*Student Information*");
            Console.WriteLine("sudent ID is: " + studID);
            Console.WriteLine("student Name is: " + studname);
            Console.WriteLine("student college name is: " + clgname);
            Console.WriteLine("student college city is: " + clgcity);
            Console.WriteLine("                                       ");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("                                         ");
        }

        
    }
}
