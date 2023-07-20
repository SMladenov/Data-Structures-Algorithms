using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueWorkshop.Queue
{
    public class LinkedQueue<T> : IQueue<T>
    {
        private Node<T> head, tail;
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

        public void Enqueue(T element)
        {
            var newNode = new Node<T>();
            newNode.Data = element;

            if (size == 0)
            {
                this.tail = newNode;
                this.head = newNode;
                size++;
            }
            else
            {
                this.tail.Next = newNode;
                this.tail = newNode;
                size++;
            }
        }

        public T Dequeue()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }

            var elementToBeRemoved = this.head.Data;
            this.head.Next = this.head;
            this.head = null;
            size--;

            if (this.IsEmpty)
            {
                this.tail = null;
            }

            return elementToBeRemoved;
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return this.head.Data;
            }
        }
    }
}
