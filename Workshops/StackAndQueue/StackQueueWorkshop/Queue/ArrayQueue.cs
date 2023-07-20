using System;
using System.Globalization;
using System.Net.Http;

namespace StackQueueWorkshop.Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private T[] items = new T[8];
        //private int tail = 0;
        private int index = 0;
        //private int head = 0;

        public int Size
        {
            get
            {
                return this.index;
            }
        }

        public bool IsEmpty
        {
            get
            {
                if (this.index == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Enqueue(T element)
        {
            //if (this.IsEmpty)
            //{
            //    this.head = 0;
            //    this.tail = 0;
            //}
            //else
            //{
            //    this.tail++;
            //}
            //items[tail] = element;
            //this.Size++;

            if (index == items.Length)
            {
                Resize();
                items[index] = element;
                index++;
            }
            else
            {
                items[index] = element;
                index++;
            }
        }

        public T Dequeue()
        {

            var item = items[0];
            if (index == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Remove();
                index--;
                return item;
            }
        }

        public T Peek()
        {
            if (index == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return items[0];
            }
        }

        public void Resize()
        {
            var itemsCount = items.Length;
            var resizeItems = new T[itemsCount * 2];

            for (int i = 0; i < itemsCount; i++)
            {
                resizeItems[i] = items[i];
            }

            this.items = resizeItems;
        }

        private void Remove()
        {
            //items[0] = default(T);

            var itemsCount = items.Length;
            var newItems = new T[itemsCount];

            for (int i = 1; i <= index; i++)
            {
                newItems[i - 1] = items[i];
            }

            this.items = newItems;
        }
    }
}
