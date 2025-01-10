using NUnit.Framework;

namespace BinaryDataNunit
{
    public class TestClass
    {
        [TestCaseSource(typeof(TestSource), nameof(TestSource.EmptyBinaryData))]
        public void TestMethod1(BinaryData binaryData)
        {
        }

        [TestCaseSource(typeof(TestSource), nameof(TestSource.NonEmptyBinaryData))]
        public void TestMethod2(BinaryData binaryData)
        {
        }
    }
}
