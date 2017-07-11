using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {
        private int Size;
        private int StackSize;
        private T[] stackyStack;

        public Stack(int StackSize)
        {
            Size = 0;
            this.StackSize = StackSize;
            stackyStack = new T[StackSize];
        }

        public void push(T newData)
        {
            if (Size + 1 != StackSize)
            {
                stackyStack[Size] = newData;
                Size++;
            }
            else
            {
                throw new ArgumentException("The stack is already full");
            }
        }

        public T pop()
        {
            if (Size == 0)
            {
                throw new ArgumentException("The stack is empty");
            }
            T lastItem = stackyStack[Size-1];
            Size--;
            Array.Resize(ref stackyStack, Size);
            Array.Resize(ref stackyStack, StackSize);
            return lastItem;
        }

        public T peek()
        {
            if (Size == 0)
            {
                throw new ArgumentException("The stack is empty");
            }
            return stackyStack[Size-1];
        }

        public int getSize()
        {
            return StackSize;
        }

        public int getUsedSize()
        {
            return Size;
        }

        public int getFreeSpaces()
        {
            return StackSize - Size;
        }




    }
}
