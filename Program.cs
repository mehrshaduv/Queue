using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int front = -1, rear  = -1, len =  0, temp, index;
            Console.Write("Enter len of Queue :");
            len = Convert.ToInt32(Console.ReadLine());
            int[] Queue = new int[len];
            while(true)
            {
                Console.Write("[1] for add the number at Queue\n[2] for delete the number at Queue\n>");
                index = Convert.ToInt32(Console.ReadLine());
                if(index == -1)
                {
                    break;
                }
                else if(index == 1)
                {
                    Console.Write("Enter a number :");
                    temp = Convert.ToInt32(Console.ReadLine());
                    addQ(ref Queue, ref len, ref rear, temp);
                }
                else if(index == 2)
                {
                    deleteQ(ref Queue, ref front, ref rear);
                }
            }
        }

        public static void addQ(ref int[] Queue, ref int len, ref int rear, int value)
        {
            if(rear == len-1)
            {
                Console.WriteLine("\nQueue is full.\n");
                return;
            }
            Queue[rear+1] = value;
            rear++;

        }

        public static void deleteQ(ref int[] Queue, ref int front, ref int rear)
        {
            if(rear == front)
            {
                Console.WriteLine("\nQueue is empty.\n");
                return;
            }
            Queue[front+1] = 0; //remove item !!
            front++;

        }
    }
}




