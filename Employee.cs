using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
            for (int i = 0; i < PTOBalance.ptoBal.GetLength(0); i++)
            {
                for (int j = 0; j < PTOBalance.ptoBal.GetLength(1); j++)
                {
                    if (PTOBalance.ptoBal[i,j] == id) 
                    { Console.WriteLine("For the Employee " + PTOBalance.ptoBal[i, j] + ", your remaining number of hours are: " + PTOBalance.ptoBal[i, j + 1] + ", your accrued number of hours are: " + PTOBalance.ptoBal[i, j + 2] + ", and your total balance is: " + PTOBalance.ptoBal[i, j + 3]); }
                 }
            }
        }

        static void ProvidePTODetails()
        {

        }

        static void SubmitPTORequest(int empId, string requestedDate, string startDate, string endDate, string reasonForRequest)
        {
            PTORequest.CreatePTORequest(empId, requestedDate, startDate, endDate, reasonForRequest);
        }

        static void VerifyPTOCode()
        {

        }




    }
}
