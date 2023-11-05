using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM495_Team4
{
    public class PTORequest
    {
        public int requestId;
        public string requestedDate;
        public string startDate;
        public string endDate;
        public int empId;
        public string requestedStatus;
        public string reasonForRequest;

        public static List<PTORequest> requests = new List<PTORequest>();

        static void CreatePTORequest()
        {

        }

        static void CancelRequest()
        {

        }

        static void ConfirmDetails()
        {

        }

        static void ListOpenRequests()
        {

        }

        static void DisplayPTORequest()
        {

        }

        //update payroll?


        public static void Main(string[] args)
        {

            requests.Add(new PTORequest() { requestId = 00001, requestedDate = "October 1 2023", startDate = "November 6 2023", endDate = "November 10 2023", requestedStatus = "Awaiting Approval", reasonForRequest = "Vacation" });
        }
    }
    }
