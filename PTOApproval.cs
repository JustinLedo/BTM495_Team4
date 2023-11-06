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

        string[,] ptoRequest = new string[1, 6] { { "0000001", "Approved", "October 3 2023", "Jane Doe", null, "Request approved. Enjoy your vacation!" } };
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
        approvals.Add(new PTOApproval() {  });

    }
}
}
