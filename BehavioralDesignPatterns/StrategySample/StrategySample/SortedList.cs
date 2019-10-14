using System;
using System.Collections.Generic;

namespace StrategySample
{
    class SortedList
    {
        private List<string> list = new List<string>();
        private SortStrategy sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            list.Add(name);
        }

        public void Sort()
        {
            sortStrategy.Sort(list);

            // Iterate over list and display results
            foreach (string name in list)
            {
                Console.WriteLine($" {name}");
            }
            Console.WriteLine();
        }
    }
}
