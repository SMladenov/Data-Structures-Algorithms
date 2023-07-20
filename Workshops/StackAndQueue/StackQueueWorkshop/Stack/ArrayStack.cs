using System;

namespace StackQueueWorkshop.Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        private T[] items = new T[8];
        private int index = 0;      

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
                return this.index == 0 ? true : false;
            }
        }

        public void Push(T element)
        {

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

        public T Pop()
        {
            var item = Peek();
            Remove();
            index--;
            return item;
        }

        public T Peek()
        {
            if (index == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return items[index - 1];
            }
        }

        private void Resize()
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
            //items[index - 1] = default(T);

            var itemsCount = items.Length;
            var newItems = new T[itemsCount];

            for (int i = 0; i < index; i++)
            {
                newItems[i] = items[i];
            }

            this.items = newItems;
        }
    }
}
