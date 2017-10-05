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
}
