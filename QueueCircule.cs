using System;

namespace QueueCircule
{
    class Program
    {
        static void Main(string[] args)
        {
            int front = -1, rear  = -1, len =  0, temp, index, size = 0;
            Console.Write("Enter len of Queue :");
            len = Convert.ToInt32(Console.ReadLine());
            int[] Queue = new int[len];
            front = -1;
            rear  = -1;
            while(true)
            {
                Console.Write("[1] for add the number at Queue\n[2] for delete the number at Queue\n[3] for show\n[99] to exit :)\n>");
                index = Convert.ToInt32(Console.ReadLine());
                if(index == 99)
                {
                    break;
                }
                else if(index == 1)
                {
                    Console.Write("Enter a number :");
                    temp = Convert.ToInt32(Console.ReadLine());
                    addQ(ref Queue, ref len, ref front, ref rear, ref size, temp);
                }
                else if(index == 2)
                {
                    deleteQ(ref Queue, ref len, ref front, ref rear, ref size);
                }
                else if(index == 3)
                {
                    showQ(ref Queue);
                }
            }
        }

        public static void addQ(ref int[] Queue, ref int len, ref int front, ref int rear, ref int size, int value)
        {
            if(size == len)
            {
                Console.WriteLine("\nQueue is full.\n");
                return;
            }
            rear = (rear + 1 ) % len;
            Queue[rear] = value;
            size++;

        }

        public static void deleteQ(ref int[] Queue, ref int len, ref int front, ref int rear, ref int size)
        {
            if(rear == front && size != len)
            {
                Console.WriteLine("\nQueue is empty.\n");
                return;
            }
            front = (front + 1) % len;
            Queue[front] = 0; //remove item !!
            size--;

        }

        public static void showQ(ref int[] Queue)
        {
            for(int i = 0; i < Queue.Length; i++)
            {
                Console.Write("{0}\t", Queue[i]);
            }
            Console.WriteLine();
        }
    }
}

