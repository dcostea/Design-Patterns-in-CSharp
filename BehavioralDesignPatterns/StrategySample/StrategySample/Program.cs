using System;

namespace StrategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Cluj");
            studentRecords.Add("Oradea");
            studentRecords.Add("Arad");
            studentRecords.Add("Timisoara");
            studentRecords.Add("Iasi");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();


            // Wait for user
            Console.ReadKey(true);
        }
    }
}
