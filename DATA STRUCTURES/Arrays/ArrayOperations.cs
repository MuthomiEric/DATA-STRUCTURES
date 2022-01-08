using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURES.Arrays
{
    public class ArrayOperations
    {
        public void TraverseThroughJaggedArray(int[][] jaggedArray)
        {

            for (int i = 0; i < jaggedArray.Length; i++)
            {

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                   
                    Console.Write($"{jaggedArray[i][j]} ");
                }

                Console.WriteLine();

            }

        }

        public char[] reverseArray(char[] arr)
        {
            int start = 0, end = arr.Length - 1;

            while (start < end)
            {
                char temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            return arr;
        }
    }
}
