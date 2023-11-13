using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTM495_Team4
{
    public class PTORequest
    {
        public int requestId { get; set; }
        public int empId { get; set; }
        public string requestedDate { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string requestedStatus { get; set; }
        public string reasonForRequest { get; set; }


        public static List<PTORequest> ptoReqs = new List<PTORequest>() { new PTORequest() { requestId = 00001, empId = 001, requestedDate = "October 1 2023", startDate = "November 6 2023", endDate = "November 10 2023", reasonForRequest = "Awaiting Approval", requestedStatus = "Vacation" } };

        public static void CreatePTORequest(int empId, string start, string end, string reason)
        {
            var prevIdIndex = ptoReqs.FindLastIndex(a => a.requestId > 0);
            var prevID = ptoReqs[prevIdIndex];
            var newID = Convert.ToInt32(prevID) + 1;
            var reqDayToday = DateTime.Today;
            ptoReqs.Add(new PTORequest() { requestId = newID, empId = empId, requestedDate = reqDayToday.ToString(), startDate = start, endDate = end, reasonForRequest = reason, requestedStatus = "Pending Review" });

        }



        public static void ConfirmDetails(int requestId)
        {
            var reqIndex = Convert.ToInt32(ptoReqs.FindIndex(a => a.requestId == requestId));
            foreach (var p in ptoReqs)
            {
                for (int i = reqIndex; i <= reqIndex + 5; i++)
                {
                    if (p == null || Convert.ToString(p) == "")
                    {
                        throw new Exception("The PTO detail " + p + "is missing or empty! Please provide the following information.");
                    }
                    else { Console.WriteLine("Everything looks good! Please await your manager's review and response to your request. Thank you!"); }
                }
            }

        }

        public static void ListOpenRequests()
        {
            // Print all empID with open requests. PTOApproval will have to remove/delete all completed requests

            foreach (PTORequest empId in ptoReqs)
            {
                Console.WriteLine("The following employees have open requests: " + empId);
            }
        }
            public static void DisplayPTORequest(int empId)
            {
                var empIndex = ptoReqs.FindIndex(a => a.empId == empId);
                Console.WriteLine("For the Employee " + PTORequest.ptoReqs[empIndex] + ", the PTO start date is: " + ptoReqs[empIndex + 2] + "and the end date is: " + ptoReqs[empIndex + 3] + ". The reason for this PTO is: " + ptoReqs[empIndex + 4] + ". This PTO was requested on " + ptoReqs[empIndex -1 ] + " and is currently " + ptoReqs[empIndex + 5]);

            }

             public static void CancelPTORequest(int empId)
            {
            var empIndex = ptoReqs.FindIndex(a => a.empId == empId);
            ptoReqs.RemoveRange(empIndex -1, empIndex + 5);
        }
        }
    }

