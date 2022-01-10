using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURES.Linked_List
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
       
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
        
    }

    public class DoublyNode
    {
        public int Data { get; set; }
        public DoublyNode Next { get; set; }
        public DoublyNode Prev { get; set; }

        public DoublyNode(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }

    }

}
