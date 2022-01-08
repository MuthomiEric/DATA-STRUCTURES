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

        public int IndexOfAKeySearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)

                    return i;

            }

            return -1;
        }

        public int[] InsertInTheMiddleOfAnArray(int[] arr, int capacity, int index, int value)
        {
            if (index >= capacity)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                int temp;

                int prevtemp = 0;

                // 1,2,3,4,5
                for (int i = index; i < capacity; i++)
                {
                    temp = arr[i];

                    if (index == i)
                    {
                        arr[i] = value;

                        prevtemp = temp;

                        continue;
                    }

                    arr[i] = prevtemp;

                    prevtemp = temp;

                }
            }

            return arr;
        }

        public int[] DeleteFromTheMiddleOfAnArray(int[] arr, int index)
        {
            // 1,2,3,4,5,6

            if (index >= arr.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = index; i < arr.Length; i++)
            {
                if (i+1<arr.Length)
                    arr[i] = arr[i + 1];
                
            }

            arr[arr.Length - 1] = 0;


            return arr;
        }

    }
}
