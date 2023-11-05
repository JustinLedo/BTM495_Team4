using System;
using System.Collections.Generic;
using System.Linq;
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

        public static List<Manager> manaList = new List<Manager>();

        static void AccessOpenRequests()
        {

        }

        static void SelectPTORequest()
        {

        }

        static void ApprovePTO()
        {

        }

        static void ViewPTOBalance()
        {

        }

        static void ConfirmRequest()
        {

        }
        static void GeneratePTOCode()
        {

        }

        public static void Main(string[] args)
        {


            manaList.Add(new Manager() { fName = "Jane", lName = "Doe", eAddress = "jane.doe@company.com", managerId = 001, payrollInfo = "000012340011234567" });
        }
        }
}
