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
}
