using NUnit.Framework;

namespace MindboxTestTask.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TestTriangleArea()
        {
            Triangle t = new Triangle(3, 4, 5);
            Assert.AreEqual(6, t.GetArea());
        }

        [Test]
        public void TestIsRightTriangle()
        {
            Triangle t = new Triangle(3, 4, 5);
            Assert.IsTrue(t.IsRightTriangle());
        }

    }
}
