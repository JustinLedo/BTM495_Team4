using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BTM495_Team4
{
    public class PTOApproval
    {
        public int approvalId;
        public string approvalStatus;
        public string approvalDate;
        public string approvedBy;
        public string deniedBy;
        public string comments;


        public int empId;
        public int ptoCode;
        public static List<PTOApproval> ptoCodes = new List<PTOApproval>();

        public static void UpdatePTORequest(int requestId, string newStatus)
        {
            // Should update based on request ID as an employee may have multiple PTO requests outstanding

                var requestIndex = PTORequest.ptoReqs.FindIndex(a => a.requestId == requestId);
                var oldStatusIndex = Convert.ToInt32(PTORequest.ptoReqs[requestIndex + 6]);
            PTORequest.ptoReqs.Insert(oldStatusIndex, new PTORequest() { reasonForRequest = newStatus });
        }

        public static void UpdatePayroll(int requestId)
        {
            //This adjusts the PTOBalance value after the approval goes through
            var requestIndex = PTORequest.ptoReqs.FindIndex(a => a.requestId == requestId);
            string startDate = Convert.ToString(PTORequest.ptoReqs[requestIndex + 3]);
           string endDate = Convert.ToString(PTORequest.ptoReqs[requestIndex + 4]);
            
            var startDay = DateTime.Parse(startDate);
            var endDay = DateTime.Parse(endDate);
            var ptoDaysDuration = endDay.Subtract(startDay);
            int ptoHours = Convert.ToInt32(ptoDaysDuration) * 8;

            var employeeId = Convert.ToInt32(PTORequest.ptoReqs[requestIndex + 1]);
            var ptoBalIndex = PTOBalance.ptoBal.FindIndex(x=>x.empId == employeeId);
            int ptoRemainingHours = (Convert.ToInt32(PTOBalance.ptoBal[ptoBalIndex + 1])) - ptoHours;
            int ptoTotalBal = (Convert.ToInt32(PTOBalance.ptoBal[ptoBalIndex + 3])) - ptoHours;

            Console.WriteLine("The PTO Balance for the employee " + employeeId + " has been successfully updated.");
            PTOBalance.DisplayPTOBalance(employeeId);


        }
        public static void NotifyEmployee(string managerResponse) //Might this need the empId as an argument? 
        {
            // Should be a pop-up or some sort of front-end notification for the employee in the final prototype
        
            if (managerResponse == "Approved") 
            {
                Console.WriteLine("Congratulations! Your PTO request has been officially approved.");
            }
            else if (managerResponse == "Declined")
            {
                Console.WriteLine("Apologies, unfortunately your PTO request has been officially declined.");
            }
          
        }
    }
}
