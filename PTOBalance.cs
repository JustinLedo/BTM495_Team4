using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM495_Team4
{
    public class PTOBalance
    {
        //replace List with Array

        //public static List<PTOBalance> ptoBal = new List<PTOBalance>();


        public int empId { get; set; }
        public double remainingHours { get; set; }
        public double accruedHours { get; set; }
        public double ptoBalance { get; set; }

        public static List<PTOBalance> ptoBal = new List<PTOBalance>() {new PTOBalance() { empId = 001, remainingHours = 25, accruedHours = 50, ptoBalance = 25 }    };
        public static void DisplayPTOBalance(int empId)
        {

            var empIndex = ptoBal.FindIndex(a=>a.empId == empId);
            Console.WriteLine("For the Employee " + PTOBalance.ptoBal[empIndex] + ", your remaining number of hours are: " + ptoBal[empIndex + 1] + ", your accrued number of hours are: " + ptoBal[empIndex + 2] + ", and your total balance is: " + ptoBal[empIndex+ 3]);

            //Duplicate of ViewPTOBalance 

            /* for (int i = 0; i < PTOBalance.ptoBal.GetLength(0); i++)
             {
                 for (int j = 0; j < PTOBalance.ptoBal.GetLength(1); j++)
                 {
                     if (PTOBalance.ptoBal[i, j] == id)
                     { Console.WriteLine("For the Employee " + PTOBalance.ptoBal[i, j] + ", your remaining number of hours are: " + PTOBalance.ptoBal[i, j + 1] + ", your accrued number of hours are: " + PTOBalance.ptoBal[i, j + 2] + ", and your total balance is: " + PTOBalance.ptoBal[i, j + 3]); }
                 }
             }*/


        }


    }
}
