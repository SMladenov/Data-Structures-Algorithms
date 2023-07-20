using System;

namespace StackQueueWorkshop.Stack
{
    public class LinkedStack<T> : IStack<T>
    {
        private Node<T> top;
        private int size = 0;

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return this.size == 0 ? true : false;
            }
        }

        public void Push(T element)
        {
            // <- 1 <- 2 <- 3 
            var newNode = new Node<T>();
            newNode.Data = element;

            if(top is null)
            {
                top = newNode;
                size++;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
                size++;
            }
        }

        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                var element = this.top.Data;
                this.top = this.top.Next;
                this.size--;
                return element;
            }
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return top.Data;
            }
        }
    }
}
