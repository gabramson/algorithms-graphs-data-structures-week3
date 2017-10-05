using System;
using System.Collections.Generic;
using System.Text;

namespace Median
{
    public class MinHeap<valueType>:Heap<valueType>
    {
        public MinHeap():base()
        {
        }

        protected override bool IsInOrder(int first, int second)
        {
            return (first <= second);
        }

    }

    public class MinHeap
    {
        private MinHeap<int> minHeap = new MinHeap<int>();
        public int Count { get { return minHeap.Count; } }
        public int First { get { return minHeap.First.Item1; } }

        public void Add(int key)
        {
            minHeap.Add(key, 0);
        }

        public int ExtractFirst()
        {
            return minHeap.ExtractFirst().Item1;
        }
    }
}
