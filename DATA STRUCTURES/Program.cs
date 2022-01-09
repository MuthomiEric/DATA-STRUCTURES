using Data_STRUCTURES.Linked_List;
using DATA_STRUCTURES.Arrays;
using DATA_STRUCTURES.Linked_List;
using System;

namespace DATA_STRUCTURES
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DOUBLY LINKED LISTS

            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

            doublyLinkedList.Add(1, 2, 3, 4);

            doublyLinkedList.InsertInTheMiddle(doublyLinkedList,1,7);


            //doublyLinkedList.Remove(2);

            //doublyLinkedList.RemoveByIndex(2);

            Console.WriteLine();


            #endregion

            #region LINKED LISTS

            CustomLinkedList linkedList = new CustomLinkedList();

            //linkedList.Add(1, 2, 3, 4);

            //linkedList.Remove(2);

            //linkedList.RemoveByIndex(2);

            Console.WriteLine();


            #endregion

            #region ARRAYS

            int[] commonArray = new int[7];

            commonArray[0] = 10;
            commonArray[1] = 11;
            commonArray[2] = 12;
            commonArray[3] = 13;
            commonArray[4] = 14;
            commonArray[5] = 15;

            ArrayOperations arrayOperations = new ArrayOperations();

            var name = "Muthomi";
            var b = name.ToCharArray();

            var a = arrayOperations.reverseArray(b);

            int[][] arrs = new int[4][];

            arrs[0] = new int[] { 1, 2, 3, 4 };
            arrs[1] = new int[] { 5, 6, 7 };
            arrs[2] = new int[] { 8, 9 };
            arrs[3] = new int[] { 10, 11, 12, 13, 14, 15 };

            //arrayOperations.TraverseThroughJaggedArray(arrs);

            // Key Search

            //var ind = arrayOperations.IndexOfAKeySearch(commonArray,111);

            //var ind = arrayOperations.InsertInTheMiddleOfAnArray(commonArray, 7, 0, 8);

            var ind = arrayOperations.DeleteFromTheMiddleOfAnArray(commonArray,0);

            #endregion
        }

    }
}
