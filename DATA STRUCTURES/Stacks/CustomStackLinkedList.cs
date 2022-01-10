using Data_STRUCTURES.Linked_List;
using DATA_STRUCTURES.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURES.Stacks
{
    public class CustomStackLinkedList<T>
    {
        
        public CustomLinkedList<T> data;

        public CustomStackLinkedList()
        {
            data = new CustomLinkedList<T>();
        }

        public bool IsEmpty()
        {
            if (data.head ==null)
            {
                return true;
            }

            return false;
        }

        public void Push(T value)
        {
            
            if (data.head==null)
            {
                data.head = new Node<T>(value);

                return;
            }

            var newNode = new Node<T>(value);

            newNode.Next = data.head;

            data.head = newNode;

        }

        public T Peek()
        {
            if (data.head == null)
            {
                throw new Exception("The stack is empty");
            }

            return data.head.Data;
        }

        public T Pop()
        {
            if (data.head == null)
            {
                throw new Exception("The stack is empty");
            }

            T poped = data.head.Data;

            data.head = data.head.Next;

            return poped;
        }
    }
}
