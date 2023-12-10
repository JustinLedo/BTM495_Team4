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

        public static int currentUser = 0;

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

        public static void ApprovePTO( int requestId, string newStatus, string managerResponse = "Approved")
        {
            //New status must be a reason for accepting or just be a default "approved message" inputted by the manager in the front-end

            PTOApproval.UpdatePTORequest(requestId, newStatus);

            // Should update based on request ID as an employee may have multiple PTO requests outstanding. Try to pull the request ID from the system, internally, instead of expecting manager to remember and input the request ID
            PTOApproval.UpdatePayroll(requestId);
            PTOApproval.NotifyEmployee(managerResponse);
        }

        public static void DeclinePTO(int requestId, string newStatus, string managerResponse = "Declined")
        {
            //New status must be a reason for declining inputted by the manager in the front-end
            // Should update based on request ID as an employee may have multiple PTO requests outstanding. Try to pull the request ID from the system, internally, instead of expecting manager to remember and input the request ID

            PTOApproval.UpdatePTORequest(requestId, newStatus);
            PTOApproval.NotifyEmployee(managerResponse);
        }

        static void ViewPTOBalance(int empId)
        {
            PTOBalance.DisplayPTOBalance(empId);
        }

        static void ConfirmRequest(int requestId)
        {
            // Could be a duplicate for approve, but will use now as a scan for blank list items

            var reqIndex = Convert.ToInt32(PTORequest.ptoReqs.FindIndex(a => a.requestId == requestId));
            foreach (var p in PTORequest.ptoReqs)
            {
                for (int i = reqIndex; i <= reqIndex + 5; i++)
                {
                    if (p == null || Convert.ToString(p) == "")
                    {
                        throw new Exception("The PTO detail " + p + "is missing or empty! Please request the following information.");
                    }

                else { Console.WriteLine("Everything looks good! Please complete the PTO approval process by proceeding with the code generation. Thank you!"); }
                }
            }
        }
        public static void GeneratePTOCode(int empId, string newStatus)
        {
            //For simplicity, we will store the ptoCode as a PTORequest status update

            Random rnd = new Random();
            int newPTOCode = rnd.Next(1,100);


            if ((PTORequest.ptoReqs.Exists(x=>x.requestedStatus == Convert.ToString(newPTOCode)) || (PTOApproval.ptoCodes.Exists(a=>a.ptoCode == (newPTOCode)))))
            {
                newPTOCode = rnd.Next(1,100);
                PTOApproval.ptoCodes.Add(new PTOApproval() { empId = empId, ptoCode = newPTOCode });
                PTOApproval.UpdatePTORequest(empId = empId, newStatus = Convert.ToString(newPTOCode));
                Console.WriteLine("The generated code was already found. New code generated and sent!");
            }
            else
                {
                    PTOApproval.ptoCodes.Add( new PTOApproval() { empId = empId, ptoCode = newPTOCode });
                    PTOApproval.UpdatePTORequest(empId = empId, newStatus = Convert.ToString(newPTOCode));
                Console.WriteLine("No issues found with the code. It has been successfully sent!");
            }
                       
        }
    }

        
}

