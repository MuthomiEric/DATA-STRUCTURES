﻿using DATA_STRUCTURES.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_STRUCTURES.Linked_List
{
    public class CustomLinkedList
    {
        public Node head;

        public void Add(int value)
        {
            var current = head;
            // edge case
            // check if this is the first item to be added in the list  
            // Defensive, break early/ exit early
            if (head == null)
            {
                head = new Node(value);
                return;
            }
            while (current != null)
            {
                if (current.Next == null)
                {
                    current.Next = new Node(value);

                    break;
                }

                current = current.Next;
            }
        }

        public void Add(params int[] nodes)
        {
            if (nodes == null)
            {
                throw new ArgumentNullException();
            }
            foreach (var item in nodes)
            {
                Add(item);
            }
        }

        // 7-7-7-7-7
        public Node FindByIndex(int index)
        {
            Node current = head;

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
            Node current = head;


            if (head == null)
            {
                throw new NullReferenceException();
            }

            while (current.Next != null)
            {
                if (current.Next.Data == value)
                {
                    current.Next = current.Next.Next;

                    return;
                }

            }

        }

        public void RemoveByIndex(int index)
        {
            Node current = head;

            int indexCounter = 0;

            if (head == null)
            {
                throw new NullReferenceException();
            }

            while (current.Next != null)
            {
                if ((indexCounter+1) == index)
                {
                    current.Next = current.Next.Next;

                    return;
                }

                current = current.Next;

                indexCounter++;
            }

        }

        public Node Find(int value)
        {
            Node current = head;

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
