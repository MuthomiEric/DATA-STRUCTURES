using Data_STRUCTURES.Linked_List;
using DATA_STRUCTURES.Arrays;
using DATA_STRUCTURES.Linked_List;
using DATA_STRUCTURES.Queues;
using DATA_STRUCTURES.Stacks;
using System;

namespace DATA_STRUCTURES
{
    class Program
    {
        static void Main(string[] args)
        {

            #region QUEUES  LINKEDLIST IMPLEMENTATION
            CustomQueueLinkedList q1 = new CustomQueueLinkedList();

            q1.EnQueue(14);
            q1.EnQueue(22);
            q1.EnQueue(13);
            q1.EnQueue(-6);
            q1.EnQueue(2);
             
            q1.EnQueue(9);
            q1.EnQueue(7);
            q1.EnQueue(0);

            Console.WriteLine();
            #endregion

            #region QUEUES  ARRAY IMPLEMENTATION
            CustomQueueArray q = new CustomQueueArray(5);

            q.EnQueue(14);
            q.EnQueue(22);
            q.EnQueue(13);
            q.EnQueue(-6);
            q.EnQueue(2);
          
            q.DeQueue();
            q.DeQueue();

            q.EnQueue(9);
            q.EnQueue(7);
            q.EnQueue(0);

            Console.WriteLine();
            #endregion

            #region STACKS USING LINKED LIST

            CustomStackLinkedList<int> customStackLinkedList = new CustomStackLinkedList<int>();

            var isEmpty1 = customStackLinkedList.IsEmpty();

            customStackLinkedList.Push(1);
            customStackLinkedList.Push(2);
            customStackLinkedList.Push(3);
            customStackLinkedList.Push(4);
            customStackLinkedList.Push(5);
            customStackLinkedList.Push(6);
            customStackLinkedList.Push(7);
            customStackLinkedList.Push(8);
            customStackLinkedList.Push(9);
            customStackLinkedList.Push(10);

            var isEmptyAfter1 = customStackLinkedList.IsEmpty();

            var top1 = customStackLinkedList.Peek();

            var poped1 = customStackLinkedList.Pop();

            var topAfterPop1 = customStackLinkedList.Peek();

            Console.WriteLine();


            #endregion

            #region STACKS USING ARRAYS

            CustomStackUsingArray<int> customStackUsingArray = new CustomStackUsingArray<int>(20);

            var isEmpty = customStackUsingArray.IsEmpty();

            customStackUsingArray.Push(1);
            customStackUsingArray.Push(2);
            customStackUsingArray.Push(3);
            customStackUsingArray.Push(4);
            customStackUsingArray.Push(5);
            customStackUsingArray.Push(6);
            customStackUsingArray.Push(7);
            customStackUsingArray.Push(8);
            customStackUsingArray.Push(9);
            customStackUsingArray.Push(10);

            var isEmptyAfter = customStackUsingArray.IsEmpty();

            var top = customStackUsingArray.Peek();

            var poped = customStackUsingArray.Pop();

            var topAfterPop = customStackUsingArray.Peek();
            
            Console.WriteLine();


            #endregion

            #region DOUBLY LINKED LISTS

            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

            doublyLinkedList.Add(1, 2, 3, 4);

            doublyLinkedList.InsertInTheMiddle(doublyLinkedList,1,7);


            //doublyLinkedList.Remove(2);

            //doublyLinkedList.RemoveByIndex(2);

            Console.WriteLine();


            #endregion

            #region LINKED LISTS

            CustomLinkedList<int> linkedList = new CustomLinkedList<int>();

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
