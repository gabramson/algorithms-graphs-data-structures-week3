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
            MinHeap<int> heap = new MinHeap<int>();
            heap.Add(5, 1);
            heap.Add(10, 4);
            heap.Add(2, 3);
            heap.Add(3, 7);
            Assert.AreEqual(heap.Count, 4);
            Assert.AreEqual((2, 3), heap.ExtractFirst());
            Assert.AreEqual((3, 7), heap.ExtractFirst());
            Assert.AreEqual((5, 1), heap.ExtractFirst());
            Assert.AreEqual((10, 4), heap.ExtractFirst());
        }
    }
}
