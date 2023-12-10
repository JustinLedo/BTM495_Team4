using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTM495_Team4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeLogin());
            new Employee("John", "Doe", "john.doe@company.com", 001, "Associate", 0);
            new Manager("Jane", "Doe", "jane.doe@company.com", 1, "000012340011234567");

        }
    }
}
