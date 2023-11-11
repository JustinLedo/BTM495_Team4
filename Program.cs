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
            Application.Run(new Form1());
            new Employee("John", "Doe", "john.doe@company.com", 001, "Associate");
            new Manager("Jane", "Doe", "jane.doe@company.com", 1, "000012340011234567");

            //Console.WriteLine(Employee.ViewPTOBalance(001));


           /* for (int a = 0; a < PTORequest.ptoRequest.GetLength(0); a++)
            {
                for (int b = 0; b < PTORequest.ptoRequest.GetLength(1); b++)
                {
                    Console.Write(PTORequest.ptoRequest[a, b] + " ");
                }
                Console.WriteLine();
            }*/
     
        }
    }
}
