using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM495_Team4
{
    public class PTOBalance
    {
        public static List<PTOBalance> ptoBal = new List<PTOBalance>();
        public double remainingHours;
        public double accruedHours;
        public int empId;
        public double ptoBalance;

        static void DisplayPTOBalance()
        {

        }

        static void NotifyEmployee()
        {

        }
        public static void Main(string[] args)
        {

            ptoBal.Add(new PTOBalance() { remainingHours = 25, accruedHours = 50, empId = 001, ptoBalance = 25 });
       
        
        }
        }
}
