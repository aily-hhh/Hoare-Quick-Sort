using System;
using System.Diagnostics;

namespace Hoare_Quick_Sort
{
    internal class Program
    {
        static void Main()
        {
            int N = 0;
            Stopwatch stopWatch = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                N += 1000;
                Sorting sorting = new Sorting(N);
                stopWatch.Start();
                long N_op = sorting.Hoare();
                stopWatch.Stop();
                Console.WriteLine($"№ сортировки: {i + 1}; Кол-во элементов: {N}; Время: {stopWatch.Elapsed}; Кол-во операций: {N_op}");
            }
            
            Console.ReadKey();
        }
    }
}
