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

        public static int[,] ptoBal = new int[,] { {001,25,50,25} }; 
        
        public int empId;
        public double remainingHours;
        public double accruedHours;
        public double ptoBalance;

        static void DisplayPTOBalance()
        {

        }

        static void NotifyEmployee()
        {

        }
        /*public static void Main(string[] args)
        {
        
        }*/
    }
}
