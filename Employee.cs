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
        public static List<Employee> empList = new List<Employee>();

        public void ViewPTOBalance(int id)
        {
            
            PTOBalance.ptoBal.Find(x => x.empId== id);
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

        public static void Main(string[] args)
        {
            empList.Add(new Employee() { fName = "John", lName = "Doe", eAddress = "john.doe@company.com", empId = 001, role = "Associate"});
        }    


        }
    }
