using System;
using System.IO;

namespace Median
{
    class Program
    {
        static void Main(string[] args)
        {
            MedianMaintainer medianMaintainer = new MedianMaintainer();
            string line;
            using (StreamReader srStreamRdr = new StreamReader(@"Median.txt"))
            {
                while ((line = srStreamRdr.ReadLine()) != null)
                {
                    medianMaintainer.Add(int.Parse(line));
                }
            }
            Console.WriteLine(medianMaintainer.RollingSum);
            Console.ReadKey();
        }
     }
}
