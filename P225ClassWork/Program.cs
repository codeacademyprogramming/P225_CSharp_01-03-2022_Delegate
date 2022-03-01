using System;
using System.Collections;
using System.Collections.Generic;

namespace P225ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("Ismayil");
            queue.Enqueue("Tural");
            queue.Enqueue("Onur");

            foreach (var item in ReverseQueue(queue))
            {
                Console.WriteLine(item);
            }
        }

        static Queue ReverseQueue(Queue queue)
        {
            int count = queue.Count;

            Stack stack = new Stack();

            for (int i = 0; i < count; i++)
            {
                stack.Push(queue.Dequeue());
            }

            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }
    }
}
