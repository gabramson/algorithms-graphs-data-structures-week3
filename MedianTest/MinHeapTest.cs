using Microsoft.VisualStudio.TestTools.UnitTesting;
using Median;

namespace MedianTest
{
    [TestClass]
    public class MinHeapTest
    {
        [TestMethod]
        public void TestMinHeap()
        {
            MinHeap heap = new MinHeap();
            heap.Add(5);
            heap.Add(10);
            heap.Add(2);
            heap.Add(3);
            Assert.AreEqual(heap.Count, 4);
            Assert.AreEqual(2, heap.First);
            Assert.AreEqual(2, heap.ExtractFirst());
            Assert.AreEqual(3, heap.ExtractFirst());
            Assert.AreEqual(5, heap.ExtractFirst());
            Assert.AreEqual(10, heap.ExtractFirst());
        }
    }
}
