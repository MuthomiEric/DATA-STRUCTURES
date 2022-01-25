using Data_STRUCTURES.Linked_List;
using DATA_STRUCTURES.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURES.Queues
{
    public class CustomQueueLinkedList
    {
        Node<int> front, rear;

        public void EnQueue(int value)
        {
            var newNode = new Node<int>(value);

            if (rear == null)
            {
                front = rear = newNode;

                return;
            }

            rear.Next = newNode;

            rear = newNode;
        }

        public void dequeue()
        {
            if (front == null) // nothing in here 
                return;

            front = front.Next; // since we delete from the from we just need to tell the front to go to the next

            if (front == null) // means after moving nothing remained in the queue so make rear null also
                rear = null;
        }
    }
}
