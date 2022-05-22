using System;
using System.Collections.Generic;
using System.Text;

namespace AIS_Hash
{
    class HashWithChaining
    {

        /*Метод-цепоцки. Суть этого метода проста: если хеш-функция выделяет один индекс сразу двум элементам, то храниться они будут 
         * в одном и том же индексе, но уже с помощью двусвязного списка. */



        public int SIZE = 10;
        int[][] table;

        public HashWithChaining()
        {
            table = new int[SIZE][];

            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new int[10];
            }
        }

        public int hash(int value)
        {
            return Math.Abs(value) % SIZE;
        }

        public void add(int value)
        {
            int code = hash(value);
            for (int i = 0; i < table[code].Length; i++)
            {
                if (table[code][i] == 0)
                {
                    table[code][i] = value;
                    return;
                }
            }
        }

        public void find(int value)
        {
            int code = hash(value);
            for (int i = 0; i < table[code].Length; i++)
            {
                if (table[code][i].Equals(value))
                {
                    Console.WriteLine("Найден элемент: code: " + code + " i: " + i + " value: " + value);
                    return;
                }
            }
            Console.WriteLine("Не нашли");
        }

        public bool delete(int value)
        {
            int code = hash(value);
            for (int i = 0; i < table[code].Length; i++)
            {
                if (table[code][i].Equals(value))
                {
                    for (int k = i; k < table[code].Length - 1; k++)
                    {
                        table[code][k] = table[code][k + 1];
                    }
                    return true;
                }
            }
            return false;
        }
        public void printTable()
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i].Length == 0)
                    continue;
                Console.Write(i + " ");
                for (int k = 0; k < table[i].Length; k++)
                {
                    if (!table[i][k].Equals(0))
                    {
                        Console.Write(table[i][k] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
