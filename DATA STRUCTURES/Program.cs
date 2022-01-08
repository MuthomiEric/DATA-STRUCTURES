using DATA_STRUCTURES.Arrays;
using System;

namespace DATA_STRUCTURES
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ARRAYS

            ArrayOperations arrayOperations = new ArrayOperations();

            var name = "Muthomi";
            var b = name.ToCharArray();

            var a = arrayOperations.reverseArray(b);

            int[][] arrs = new int[4][];

            arrs[0] = new int[] { 1, 2, 3, 4 };
            arrs[1] = new int[] { 5, 6, 7 };
            arrs[2] = new int[] { 8, 9 };
            arrs[3] = new int[] { 10, 11, 12, 13, 14, 15 };

            arrayOperations.TraverseThroughJaggedArray(arrs);

            #endregion
        }

    }
}
