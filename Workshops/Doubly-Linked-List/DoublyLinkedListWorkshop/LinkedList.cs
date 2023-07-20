using System;
using System.Collections;
using System.Diagnostics;

namespace DoublyLinkedListWorkshop
{
    public class LinkedList<T> : IList<T>
    {
        private Node head;
        private Node tail;
        private int size = 0;

        public T Head
        {
            get
            {
                if (head == null)
                {
                    throw new InvalidOperationException();
                }
                return this.head.Value;
            }
        }

        public T Tail
        {
            get
            {
                if (tail == null)
                {
                    throw new InvalidOperationException();
                }
                return this.tail.Value;
            }
        }

        public int Count
        {
            get
            {
                return size;
            }
        }

        public void AddFirst(T value)
        {
            Node newNode = new Node(value);
            if (head != null)
            {
                this.head.Prev = newNode;
                newNode.Next = this.head;
                head = newNode;
                size++;
            }
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                size++;
            }
        }

        public void AddLast(T value)
        {
            Node newNode = new Node(value);
            if (head == null && tail == null)
            {
                head = newNode;
                tail = newNode;
                size++;
            }
            else
            {
                this.tail.Next = newNode;
                newNode.Prev = this.tail;
                tail = newNode;
                size++;
            }
        }

        public void Add(int index, T value)
        {
            Node newNode = new Node(value);

            if (index > size || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            else if (this.head != null)
            {
                Node temp = this.head;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }

                newNode.Next = temp.Next;
                newNode.Prev = temp;
                temp.Next = newNode;
                if (newNode.Next != null)
                {
                    newNode.Next.Prev = newNode;
                }

                size++;
            }
        }

        public T Get(int index)
        {
            if (index > size)
            {
                throw new ArgumentOutOfRangeException();
            }
            Node temp = this.head;

            for (int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp.Value;
        }

        public int IndexOf(T value)
        {
            Node temp = this.head;
            int tempIndex = 0;
            int foundIndex = -1;

            while (temp != null)
            {
                if (temp.Value.Equals(value))
                {
                    foundIndex = tempIndex;
                }
                tempIndex++;
                temp = temp.Next;
            }
            return foundIndex;
        }

        public T RemoveFirst()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            var elementToRemove = this.head.Value;
            PopFirst();
            size--;
            return elementToRemove;
        }

        public T RemoveLast()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            var elementToRemove = this.tail.Value;
            PopLast();
            size--;
            return elementToRemove;
        }

        public void PopFirst()
        {
            if (this.head != null)
            {
                Node temp = this.head;
                this.head = this.head.Next;
                temp = null;
                if (this.head != null)
                {
                    this.head.Prev = null;
                }
            }
        }

        public void PopLast()
        {
            if (this.head != null)
            {
                if (this.head.Next == null)
                {
                    this.head = null;
                }
                else
                {
                    Node temp = this.head;
                    while (temp.Next.Next != null)
                    {
                        temp = temp.Next;
                    }
                    Node lastNode = temp.Next;
                    temp.Next = null;
                    lastNode = null;
                }
            }
        }

        /// <summary>
        /// Enumerates over the linked list values from Head to Tail
        /// </summary>
        /// <returns>A Head to Tail enumerator</returns>
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            return new ListEnumerator(this.head);
        }

        /// <summary>
        /// Enumerates over the linked list values from Head to Tail
        /// </summary>
        /// <returns>A Head to Tail enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        }

        // Use private nested class so that LinkedList users
        // don't know about the LinkedList internal structure
        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }

            public T Value
            {
                get;
                private set;
            }

            public Node Next
            {
                get;
                set;
            }

            public Node Prev
            {
                get;
                set;
            }
        }

        // List enumerator that enables traversing all nodes of a list in a foreach loop
        private class ListEnumerator : System.Collections.Generic.IEnumerator<T>
        {
            private Node start;
            private Node current;

            internal ListEnumerator(Node head)
            {
                this.start = head;
                this.current = null;
            }

            public T Current
            {
                get
                {
                    if (this.current == null)
                    {
                        throw new InvalidOperationException();
                    }
                    return this.current.Value;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (current == null)
                {
                    current = this.start;
                    return true;
                }

                if (current.Next == null)
                {
                    return false;
                }

                current = current.Next;
                return true;
            }

            public void Reset()
            {
                this.current = null;
            }
        }
    }
}