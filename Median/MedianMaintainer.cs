using System;
using System.Collections.Generic;
using System.Text;

namespace Median
{
    public class MedianMaintainer
    {
        private MinHeap highValues;
        private MaxHeap lowValues;
        private int size=0;
        private int currentMedian;
        public int RollingSum { private set; get; } = 0;

        public MedianMaintainer()
        {
            highValues = new MinHeap();
            lowValues = new MaxHeap();
        }

        public void Add(int value)
        {
            if (size == 0)
            {
                currentMedian = value;
                lowValues.Add(value);
            }
            else
            {
                if (size % 2 == 0 && value <= currentMedian)
                {
                    lowValues.Add(value);
                }
                else if (size % 2 == 0 && value > currentMedian)
                {
                    highValues.Add(value);
                    currentMedian = highValues.ExtractFirst();
                    lowValues.Add(currentMedian);
                }
                else if (size % 2 == 1 && value < currentMedian)
                {
                    lowValues.Add(value);
                    highValues.Add(lowValues.ExtractFirst());
                    currentMedian = lowValues.First;
                }
                else
                {
                    highValues.Add(value);
                }
            }
            RollingSum = (RollingSum + currentMedian) % 10000;
            size += 1;
        }

    }

}
