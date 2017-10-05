using Microsoft.VisualStudio.TestTools.UnitTesting;
using Median;

namespace MedianTest
{
    [TestClass]
    public class MaxHeapTest
    {
        [TestMethod]
        public void TestMaxHeap()
        {
            MaxHeap<int> heap = new MaxHeap<int>();
            heap.Add(5, 1);
            heap.Add(10, 4);
            heap.Add(2, 3);
            heap.Add(3, 7);
            Assert.AreEqual(heap.Count, 4);
            Assert.AreEqual((10, 4), heap.ExtractFirst());
            Assert.AreEqual((5, 1), heap.ExtractFirst());
            Assert.AreEqual((3, 7), heap.ExtractFirst());
            Assert.AreEqual((2, 3), heap.ExtractFirst());
        }
    }
}
