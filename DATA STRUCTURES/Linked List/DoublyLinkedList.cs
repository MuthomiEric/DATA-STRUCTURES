using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURES.Linked_List
{

    public class DoublyLinkedList
    {
        public DoublyNode head;

        public void InsertInTheMiddle(DoublyLinkedList list, int index, int value)
        {
            var current = head;

            if (list != null)
            {
                int counter = 0;

                while (current != null)
                {
                    if (counter==index)
                    {
                        var newNode = new DoublyNode(value);

                        current.Prev.Next = newNode;

                        newNode.Next = current.Next;

                        newNode.Prev = current.Prev;

                        current.Next.Prev = newNode;

                        return;
                    }

                    current = current.Next;

                    counter++;
                }
            }

        }

        public void Add(int value)
        {
            var current = head;

            if (head == null)
            {
                head = new DoublyNode(value);

                return;
            }
            while (current != null)
            {
                if (current.Next == null)
                {
                    var newNode = new DoublyNode(value);

                    current.Next = newNode;

                    newNode.Prev = current;

                    break;
                }

                current = current.Next;
            }
        }

        public void Add(params int[] DoublyNodes)
        {
            if (DoublyNodes == null)
            {
                throw new ArgumentNullException();
            }
            foreach (var item in DoublyNodes)
            {
                Add(item);
            }
        }

        public DoublyNode FindByIndex(int index)
        {
            DoublyNode current = head;

            int indexCounter = 0;

            if (head == null)
            {
                throw new NullReferenceException();
            }

            while (current.Next != null)
            {
                if (indexCounter == index)
                {
                    return current;
                }

                current = current.Next;

                indexCounter++;
            }

            return null;

        }
        // Assumes No Duplicates
        public void Remove(int value)
        {
            DoublyNode current = head;


            if (head == null)
            {
                throw new NullReferenceException();
            }

            while (current.Next != null)
            {
                if (current.Next.Data == value)
                {
                    current.Next = current.Next.Next;

                    if (current.Next != null)
                    {
                        current.Next.Prev = current;
                    }

                    return;
                }

            }

        }

        public void RemoveByIndex(int index)
        {
            DoublyNode current = head;

            int indexCounter = 0;

            if (head == null)
            {
                throw new NullReferenceException();
            }

            while (current.Next != null)
            {
                if ((indexCounter + 1) == index)
                {
                    current.Next = current.Next.Next;

                    if (current.Next != null)
                    {
                        current.Next.Prev = current;
                    }

                    return;
                }

                current = current.Next;

                indexCounter++;
            }

        }

        public DoublyNode Find(int value)
        {
            DoublyNode current = head;

            if (head == null)
            {
                throw new NullReferenceException();
            }

            while (current.Next != null)
            {
                if (current.Data == value)
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }
    }
}
