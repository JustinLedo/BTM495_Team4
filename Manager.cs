using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BTM495_Team4
{
    public class Manager
    {
        public string fName;
        public string lName;
        public string eAddress;
        public int managerId;
        public string payrollInfo;

        public Manager(string fName, string lName, string eAddress, int managerId, string payrollInfo)
        {
            this.fName = fName;
            this.lName = lName;
            this.eAddress = eAddress;
            this.managerId = managerId;
            this.payrollInfo = payrollInfo;
        }

        static void AccessOpenRequests()
        {
            PTORequest.ListOpenRequests();
        }

        static void SelectPTORequest(int empId)
        {
            PTORequest.DisplayPTORequest(empId);
        }

        public static void ApprovePTO(int empId, string newStatus)
        {
            PTOApproval.UpdatePTORequest(empId, newStatus);
        }

        public static void DeclinePTO(int empId, string newStatus)
        {
            PTOApproval.UpdatePTORequest(empId, newStatus);
        }

        static void ViewPTOBalance(int empId)
        {
            PTOBalance.DisplayPTOBalance(empId);
        }

        static void ConfirmRequest()
        {

        }
        public static void GeneratePTOCode(int empId, string newStatus)
        {
            //For simplicity, we will store the ptoCode as a PTORequest status update

            Random rnd = new Random();
            var ptoCode = rnd.Next();

            public List<PTOApproval> ptoCodes = new List<PTOApproval>() {new PTOApproval () empId = empId } };

        //PTOApproval.UpdatePTORequest(empId, newStatus);
        }
}
    /*public static void Main(string[] args)
    {



    }*/
}

