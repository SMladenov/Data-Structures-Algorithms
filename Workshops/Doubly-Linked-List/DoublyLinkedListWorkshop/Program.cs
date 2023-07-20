using DoublyLinkedListWorkshop;
using System;

class Program
{
    static void Main()
    {
        var testList = new LinkedList<int>();

        testList.AddFirst(1);
        testList.AddFirst(2);
        testList.AddFirst(3);

        testList.AddLast(4);
        testList.AddLast(5);

        Console.WriteLine(testList.Head);
        Console.WriteLine(testList.Tail);
        Console.WriteLine();


    }
}
