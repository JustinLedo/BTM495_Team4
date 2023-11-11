using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM495_Team4
{
    public class ArrayHelper
    {
        public static void FindInDimensions(this object[,] target,
    object searchTerm)
        {
            object result = null;
            var rowLowerLimit = target.GetLowerBound(0);
            var rowUpperLimit = target.GetUpperBound(0);

            var colLowerLimit = target.GetLowerBound(1);
            var colUpperLimit = target.GetUpperBound(1);

            for (int row = rowLowerLimit; row < rowUpperLimit; row++)
            {
                for (int col = colLowerLimit; col < colUpperLimit; col++)
                {
                    Array.Find(target[], searchTerm);
                }
            }

        }
    }
}