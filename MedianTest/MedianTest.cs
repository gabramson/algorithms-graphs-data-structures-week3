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
            Assert.AreEqual(10, medianMaintainer.GetRollingSum());
        }
    }
}
