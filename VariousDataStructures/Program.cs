using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace VariousDataStructures
{
    class Program
    {
        public static Random rn = new Random();
        private static long nanoTime()
        {
            long nano = 10000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 100L;
            return nano;
        }
        public static void List()
        {
            List<int> arr = new List<int>();
            int i = 0;
            while (i < 10000)
            {
                arr.Add(rn.Next());
                i++;
            }
            long[] Time = new long[3];
            long start = nanoTime();
            arr.Add(rn.Next(i));
            long end = nanoTime();
            int j = 0;
            Time[j] = end - start;
            Console.Write("ArrayList Добавление " + Time[j] + " ");
            j++;

            long start1 = nanoTime();
            int a = arr[(rn.Next(i))];
            long end1 = nanoTime();
            Time[j] = end1 - start1;
            Console.Write(" Обращение " + Time[j] + " ");
            j++;

            long start2 = nanoTime();
            arr.Remove(rn.Next(i));
            long end2 = nanoTime();
            Time[j] = end2 - start2;
            Console.WriteLine(" Удаление " + Time[j]);
            j++;

        }

        public static void Link()
        {
            LinkedList<int> arr = new LinkedList<int>();
            int i = 0;
            while (i < 10000)
            {
                arr.AddFirst(rn.Next());
                i++;
            }
            long[] Time = new long[3];
            long start = nanoTime();
            arr.AddFirst(rn.Next(i));
            long end = nanoTime();
            int j = 0;
            Time[j] = end - start;
            Console.Write("LinkedList Добавление " + Time[j] + " ");
            j++;

            long start1 = nanoTime();
            int a = arr.ElementAt(rn.Next(i));
            long end1 = nanoTime();
            Time[j] = end1 - start1;
            Console.Write(" Обращение " + Time[j] + " ");
            j++;

            long start2 = nanoTime();
            arr.Remove(rn.Next(i));
            long end2 = nanoTime();
            Time[j] = end2 - start2;
            Console.WriteLine(" Удаление " + Time[j]);
            j++;
        }

        public static void Hash()
        {
            HashSet<int> arr = new HashSet<int>();
            int i = 0;
            while (i < 10000)
            {
                arr.Add(rn.Next());
                i++;
            }
            long[] Time = new long[3];
            long start = nanoTime();
            arr.Add(rn.Next(i));
            long end = nanoTime();
            int j = 0;
            Time[j] = end - start;
            Console.Write("HashSet Добавление " + Time[j] + " ");
            j++;

            long start1 = nanoTime();
            bool a = arr.Contains(rn.Next(i));
            long end1 = nanoTime();
            Time[j] = end1 - start1;
            Console.Write(" Обращение " + Time[j] + " ");
            j++;

            long start2 = nanoTime();
            arr.Remove(rn.Next(i));
            long end2 = nanoTime();
            Time[j] = end2 - start2;
            Console.WriteLine(" Удаление " + Time[j]);
            j++;
        }

        public static void Dictionary()
        {
            Dictionary<int, int> arr = new Dictionary<int, int>();
            int i = 0;
            while (i < 10000)
            {
                arr.Add(i, rn.Next());
                i++;
            }
            long[] Time = new long[3];
            long start = nanoTime();
            i++;
            arr.Add(i, rn.Next(i));
            long end = nanoTime();
            int j = 0;
            Time[j] = end - start;
            Console.Write("Dictionary Добавление " + Time[j] + " ");
            j++;

            long start1 = nanoTime();
            bool a = arr.ContainsValue(rn.Next(i));
            long end1 = nanoTime();
            Time[j] = end1 - start1;
            Console.Write(" Обращение " + Time[j] + " ");
            j++;

            long start2 = nanoTime();
            arr.Remove(rn.Next(i));
            long end2 = nanoTime();
            Time[j] = end2 - start2;
            Console.WriteLine(" Удаление " + Time[j]);
            j++;
        }
        public static void Queue()
        {
            Queue<int> arr = new Queue<int>();
            int i = 0;
            while (i < 10000)
            {
                arr.Enqueue(rn.Next());
                i++;
            }
            long[] Time = new long[3];
            long start = nanoTime();
            arr.Enqueue(rn.Next(i));
            long end = nanoTime();
            int j = 0;
            Time[j] = end - start;
            Console.Write("Queue Добавление " + Time[j] + " ");
            j++;

            long start1 = nanoTime();
            bool a = arr.Contains(rn.Next(i));
            long end1 = nanoTime();
            Time[j] = end1 - start1;
            Console.Write(" Обращение " + Time[j] + " ");
            j++;

            long start2 = nanoTime();
            arr.Dequeue();
            long end2 = nanoTime();
            Time[j] = end2 - start2;
            Console.WriteLine(" Удаление " + Time[j]);
            j++;
        }
        static void Main(string[] args)
        {
            long start = nanoTime();
            long end = nanoTime();
            long Time = end - start;
            List();
            Link();
            Hash();
            Dictionary();
            Queue();
            Console.ReadLine();
        }
    }
}
