using System;
using System.Collections.Generic;
using System.Text;

namespace Median
{
    public class MaxHeap<valueType> : Heap<valueType>
    {
        public MaxHeap() : base()
        {
        }

        protected override bool IsInOrder(int first, int second)
        {
            return (first >= second);
        }

    }

    public class MaxHeap
    {
        private MaxHeap<int> maxHeap = new MaxHeap<int>();
        public int Count { get { return maxHeap.Count; } }
        public int First { get { return maxHeap.First.Item1; } }

        public void Add(int key)
        {
            maxHeap.Add(key, 0);
        }

        public int ExtractFirst()
        {
            return maxHeap.ExtractFirst().Item1;
        }
    }
}
