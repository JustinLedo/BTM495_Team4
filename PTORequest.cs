using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Org.BouncyCastle.Ocsp;

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

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\justi\source\repos\JustinLedo\BTM495_Team4\Employee.mdf;Integrated Security=True;Connect Timeout=30");

        public static List<PTORequest> ptoReqs = new List<PTORequest>();
       /* public List<PTORequest> requests()

        {

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    string selectData = "SELECT * FROM ptoRequests WHERE requestStatus NOT IN ('Approved')";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            connect.Open();
                            PTORequest req = new PTORequest();
                            req.requestId = (int)reader["requestID"];
                            req.empId = (int)reader["empId"];
                            req.requestedDate = reader["requestedDate"].ToString();
                            req.startDate = reader["startDate"].ToString();
                            req.endDate = reader["endDate"].ToString();
                            req.requestedStatus = reader["requestedStatus"].ToString();
                            req.reasonForRequest = reader["reasonForRequest"].ToString();


                            ptoReqs.Add(req);
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error: " + ex); }
                finally { connect.Close(); }
            }
            return ptoReqs;
        }
       */

       





        public static void CreatePTORequest(int empId, string start, string end, string reason)
        {
            var prevIdIndex = PTORequest.ptoReqs.FindLastIndex(a => a.requestId > 0);
            var prevID = PTORequest.ptoReqs[prevIdIndex];
            var newID = Convert.ToInt32(prevID) + 1;
            var reqDayToday = DateTime.Today;
            PTORequest.ptoReqs.Add(new PTORequest() { requestId = newID, empId = empId, requestedDate = reqDayToday.ToString(), startDate = start, endDate = end, reasonForRequest = reason, requestedStatus = "Pending Review" });

        }



        public static void ConfirmDetails(int requestId)
        {
            var reqIndex = Convert.ToInt32(PTORequest.ptoReqs.FindIndex(a => a.requestId == requestId));
            foreach (var p in PTORequest.ptoReqs)
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

            foreach (PTORequest empId in PTORequest.ptoReqs)
            {
                Console.WriteLine("The following employees have open requests: " + empId);
            }
        }
        public static void DisplayPTORequest(int empId)
        {
            var empIndex = PTORequest.ptoReqs.FindIndex(a => a.empId == empId);
            Console.WriteLine("For the Employee " + PTORequest.ptoReqs[empIndex] + ", the PTO start date is: " + ptoReqs[empIndex + 2] + "and the end date is: " + ptoReqs[empIndex + 3] + ". The reason for this PTO is: " + ptoReqs[empIndex + 4] + ". This PTO was requested on " + ptoReqs[empIndex - 1] + " and is currently " + ptoReqs[empIndex + 5]);

        }

        public static void CancelPTORequest(int empId)
        {
            var empIndex = PTORequest.ptoReqs.FindIndex(a => a.empId == empId);
            PTORequest.ptoReqs.RemoveRange(empIndex - 1, empIndex + 5);
        }

    }
}
