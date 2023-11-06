using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM495_Team4
{
    public class Employee
    {
        public string fName;
        public string lName;
        public string eAddress;
        public int empId;
        public string role;

        public Employee(string fName, string lName, string eAddress, int empId, string role)
        {
            this.fName = fName;
            this.lName = lName;
            this.eAddress = eAddress;
            this.empId = empId;
            this.role = role;
        }


        public static void ViewPTOBalance(int id)
        {
            PTOBalance.ptoBal({ });
            //Console.WriteLine(PTOBalance.ptoBal.Find(x => x.empId == id));
        }

        static void ProvidePTODetails()
        {

        }

        static void SubmitPTORequest()
        {

        }

        static void VerifyPTOCode()
        {

        }




    }
}
