using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURES.Stacks
{
    public class CustomStackUsingArray<T>
    {

        // Push
        // Pop
        // Peek
        // IsEmpty
        
        public T[] data;
        public CustomStackUsingArray(int size)
        {
            data = new T[size];
        }

        private int Top { get; set; } = -1;

        public bool IsEmpty()
        {
            if (Top==-1)
            {
                return true;
            }

            return false;
        }

        public void Push(T value)
        {
            if (Top >= data.Length-1)
            {
                throw new IndexOutOfRangeException();
            }

            data[++Top] = value;
        }

        public T Peek()
        {
            if (Top==-1)
            {
                throw new Exception("The stack is empty");
            }

            return data[Top];
        }

        public T Pop()
        {
            if (Top == -1)
            {
                throw new Exception("The stack is empty");
            }

            T poped = data[Top];

            Top--;

            return poped;
        }
    }
}
