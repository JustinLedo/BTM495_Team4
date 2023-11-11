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
        public int empId;
        public string requestedDate;
        public string startDate;
        public string endDate;
        public string requestedStatus;
        public string reasonForRequest;

        public static string[,] ptoRequest = new string[,] { { "00001", "001", "October 1 2023", "November 6 2023", "November 10 2023", "Awaiting Approval", "Vacation" } };

        public static void CreatePTORequest(int empId, string requestedDate, string startDate, string endDate, string reasonForRequest)
        {

            var prevId = ptoRequest.GetUpperBound(0);
            ptoRequest = new string[,] { { ptoRequest[prevId + 1,0], empId.ToString(), requestedDate, startDate, endDate, reasonForRequest } };

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
        }
    }

