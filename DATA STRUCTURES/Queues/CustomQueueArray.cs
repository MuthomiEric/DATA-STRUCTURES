using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURES.Queues
{
    public class CustomQueueArray
    {
        int _rear, _front, _size;

        private int[] queue;

        public CustomQueueArray(int size)
        {
            _size = size;
            _front = _rear = -1;
            queue = new int[size];
        }

        public void EnQueue(int data)
        {
            if ((_front == 0 && _rear == _size - 1) ||
              (_rear == (_front - 1) % (_size - 1)))  // check for a full queue
            {
                Console.WriteLine("Queue is Full");
            }

            else if (_front == -1)  // Means the queue is empty
            {
                _front = 0;
                _rear = 0;
                queue[_rear] = data;
            }

            // means our rear is at the full index but some items were dequeued
            // here we make the rear cross over to the lower index
            else if (_rear == _size - 1 && _front != 0) 
            {
                _rear = 0;
                queue[_rear] = data;
            }

            else  // is not full and rear has crossed over to lower index
            {
                _rear = (_rear + 1);
                queue[_rear] = data;
            }
        }

        public int DeQueue()
        {
            int temp;

            if (_front == -1)
            {
                Console.WriteLine("Queue is Empty");


                return -1;
            }

            temp = queue[_front];

            if (_front == _rear)
            {
                _front = -1;
                _rear = -1;
            }

            else if (_front == _size - 1)
            {
                _front = 0;
            }
            else
            {
                _front = _front + 1;
            }

            return temp;
        }

    }
}
