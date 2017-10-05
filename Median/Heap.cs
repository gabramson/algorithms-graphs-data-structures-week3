using System;
using System.Collections.Generic;
using System.Text;

namespace Median
{
    public abstract class Heap<valueType>
    {
        private List<(int key, valueType value)> heapList;
        public int Count{ private set;  get; }
        public (int, valueType) First { get { return heapList[0]; } }

        protected Heap()
        {
            heapList = new List<(int key, valueType value)>();
            Count = 0;
        }

        protected abstract bool IsInOrder(int first, int second);

        private int ParentIndexOf(int pos)
        {
            return (pos + 1) / 2 - 1;
        }

        private void PercolateUpFromBottom()
        {
            int pos;
            (int key, valueType) tmp = heapList[Count - 1];
            for (pos = Count - 1; pos > 0 && !IsInOrder(heapList[ParentIndexOf(pos)].key,tmp.key); pos = ParentIndexOf(pos))
            {
                heapList[pos] = heapList[ParentIndexOf(pos)];
            }
            heapList[pos] = tmp;
        }

        public void Add(int key, valueType value)
        {
            heapList.Add((key, value));
            Count += 1;
            PercolateUpFromBottom();
        }

        private int LeftChildIndexOf(int pos)
        {
            return (2 * (pos + 1) - 1);
        }

        private void PercolateDownFromTop()
        {
            int pos = 0;
            (int key, valueType) tmp = heapList[pos];
            for (int child = LeftChildIndexOf(pos); child <= Count - 1; pos = child, child = LeftChildIndexOf(pos))
            {
                if ((child < Count - 1) && (!IsInOrder(heapList[child].key, heapList[child + 1].key)))
                {
                    child += 1;
                }

                if (IsInOrder(heapList[child].key, tmp.key))
                {
                    heapList[pos] = heapList[child];
                }
                else
                {
                    break;
                }
            }
            heapList[pos] = tmp;
        }

        public (int, valueType) ExtractFirst()
        {
            (int key, valueType value) returnValue = heapList[0];
            heapList[0] = heapList[Count - 1];
            heapList.RemoveAt(Count - 1);
            Count -= 1;
            if (Count > 0)
            {
                PercolateDownFromTop();
            }
            return (returnValue);
        }

    }

}
