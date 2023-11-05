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
        public string approvalDate;
        public string approvedBy;
        public string deniedBy;
        public string approvalStatus;
        public string comments;

        public static List<PTOApproval> approvals = new List<PTOApproval> ();

        static void UpdatePTORequest()
        {

        }

        static void UpdatePayroll()
        {

        }

        //static void NotifyEmployee()
        //{

        //}

    

    public static void Main(string[] args)
    {
        approvals.Add(new PTOApproval() { approvalId = 0000001, approvalStatus = "Approved", approvalDate = "October 3 2023", approvedBy = "Jane Doe", deniedBy = null, comments = "Request approved. Enjoy your vacation!" });

    }
}
}
