using System;
using System.Collections.Generic;
using System.Linq;
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

        public static void UpdatePTORequest(int empId, string newStatus)
        {
                var empIndex = PTORequest.ptoReqs.FindIndex(a => a.empId == empId);
                var oldStatusIndex = Convert.ToInt32(PTORequest.ptoReqs[empIndex + 5]);
            PTORequest.ptoReqs.Insert(oldStatusIndex, new PTORequest() { reasonForRequest = newStatus });
        }

        static void UpdatePayroll()
        {
            //This adjusts the PTOBalance value after the approval goes through
        }
        public static void NotifyEmployee()
        {
            Console.WriteLine();
        }
        //static void NotifyEmployee()
        //{

        //}
    }
}
