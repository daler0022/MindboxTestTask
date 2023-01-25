using NUnit.Framework;

namespace MindboxTestTask.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void TestCircleArea()
        {
            Circle c = new Circle(5);
            Assert.AreEqual(78.53981633974483, c.GetArea());
        }
    }

}
