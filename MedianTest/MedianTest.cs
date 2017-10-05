using Microsoft.VisualStudio.TestTools.UnitTesting;
using Median;

namespace MedianTest
{
    [TestClass]
    public class MedianTest
    {
        [TestMethod]
        public void TestMedianMaintainer()
        {
            MedianMaintainer medianMaintainer = new MedianMaintainer();
            medianMaintainer.Add(10);
            Assert.AreEqual(10, medianMaintainer.RollingSum);
            medianMaintainer.Add(20);
            Assert.AreEqual(20, medianMaintainer.RollingSum);
            medianMaintainer.Add(30);
            Assert.AreEqual(40, medianMaintainer.RollingSum);
            medianMaintainer.Add(15);
            Assert.AreEqual(55, medianMaintainer.RollingSum);
            medianMaintainer.Add(5);
            Assert.AreEqual(70, medianMaintainer.RollingSum);
            medianMaintainer.Add(15);
            Assert.AreEqual(85, medianMaintainer.RollingSum);
            medianMaintainer.Add(15);
            Assert.AreEqual(100, medianMaintainer.RollingSum);
            medianMaintainer.Add(100);
            Assert.AreEqual(115, medianMaintainer.RollingSum);
        }
    }
}
