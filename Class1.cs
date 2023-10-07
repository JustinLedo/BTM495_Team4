using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public class Employee
    {
        public string fName;
        public string lName;
        public string eAddress;
        public int empId;
        public string role;




    }

    public class Manager
    {
        public string fName;
        public string lName;
        public string eAddress;
        public int managerId;
        public string payrollInfo;


    }
    public class PTOBalance
    {
        public double remainingHours;
        public double accruedHours;
        public int empId;
        public double ptoBalance;


    }

    public class PTORequest
    {
        public string requestId;
        public string requestedDate;
        public string startDate;
        public string endDate;
        public int empId;
        public string requestedStatus;
        public string reasonForRequest;



    }

    public class PTOApproval
    {
        public string approvalId;
        public string approvalDate;
        public string approvedBy;
        public string deniedBy;
        public string approvalStatus;
        public string comments;



    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); 
            employee1.fName = "John";
            employee1.lName = "Doe";
            employee1.eAddress = "john.doe@company.com";
            employee1.empId = 001;
            employee1.role = "Associate";


            Manager manager1 = new Manager();
            manager1.fName = "Jane";
            manager1.lName = "Doe";
            manager1.eAddress = "jane.doe@company.com";
            manager1.managerId = 001;
            manager1.payrollInfo = "000012340011234567";

            PTOBalance ptoBal1 = new PTOBalance();
            ptoBal1.remainingHours = 25;
            ptoBal1.accruedHours = 50;
            ptoBal1.empId = employee1.empId;
            ptoBal1.ptoBalance = 25;

            PTORequest ptoReq1 = new PTORequest();
            ptoReq1.requestId = "JD00001";
            ptoReq1.requestedDate = "October 1 2023";
            ptoReq1.startDate = "November 6 2023";
            ptoReq1.endDate = "November 10 2023";
            ptoReq1.empId = employee1.empId;
            ptoReq1.requestedStatus = "Awaiting Approval";
            ptoReq1.reasonForRequest = "Vacation";

            PTOApproval ptoApp1 = new PTOApproval();
            ptoApp1.approvalId = "JD0000001";
            ptoApp1.approvalStatus = "Approved";
            ptoApp1.approvalDate = "October 3 2023";
            ptoApp1.approvedBy = "Jane Doe";
            ptoApp1.deniedBy = null;
            ptoApp1.comments = "Request approved. Enjoy your vacation!";

    }
    }

}