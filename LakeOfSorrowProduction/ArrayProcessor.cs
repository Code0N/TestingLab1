using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LakeOfSorrowProduction
{
    public class ArrayProcessor
    {
        public int[] SortAndFilter(int[] a)
        {
            int[] InternalArray = (from elem in a where (((int)Math.Log10(elem) + 1) == 4) && (elem > 0) select elem).ToArray();
            Array.Sort(InternalArray);
            return InternalArray;
            //Array.Copy(a, InternalArray = new int[a.Length], a.Length);          
        }
    }
}
