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


        public static void ViewPTOBalance(int empId)
        {
            PTOBalance.DisplayPTOBalance(empId);

        }

        public static void ProvidePTODetails(int empId, string startDate, string endDate, string reasonForRequest)
        {
            PTORequest.CreatePTORequest(empId, startDate, endDate, reasonForRequest);
        }

        public static void VerifyPTOCode(int empId, int ptoCode)
        {

            // Should have a pop up/user request option to confirm the code is indeed the same in the final protoype
            var codeInListIndex = PTOApproval.ptoCodes.FindIndex(x=>x.ptoCode==ptoCode);
            int codeInRequestIndex = PTORequest.ptoReqs.FindIndex(a =>a.requestedStatus == Convert.ToString(ptoCode));

            var codeInList = Convert.ToInt32(PTOApproval.ptoCodes[codeInListIndex]);
            var codeInRequest = Convert.ToInt32(PTORequest.ptoReqs[codeInRequestIndex]);

            if ((ptoCode == codeInList) && (ptoCode == codeInRequest) ){ Console.WriteLine("The codes match! The PTO has been successfully verified. Enjoy your " + PTORequest.ptoReqs[codeInRequestIndex - 1]); }
            else { Console.WriteLine("The code has not been verified! It is either different between the list of generated codes and the code displayed in the request OR it is non existant! Please review both sources."); }
            
        }




    }
}
