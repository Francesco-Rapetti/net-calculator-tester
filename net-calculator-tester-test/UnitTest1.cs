using net_calculator_tester;

namespace net_calculator_tester_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //public static float Add(int x, int y) => x + y;
        [Test]
        [TestCase(1, 2)]
        [TestCase(2.4f, 3.3f)]
        [TestCase(0, 0)]
        [TestCase(2.4f, 0)]
        [TestCase(0, 2.4f)]
        [TestCase(1, 0)]
        public void TestAdd(float x, float y)
        {
            Assert.That(Calculator.Add(x, y), Is.EqualTo(x + y));
        }

        //public static float Subtract(int x, int y) => x - y;
        [Test]
        [TestCase(1, 2)]
        [TestCase(2.4f, 3.3f)]
        [TestCase(0, 0)]
        [TestCase(2.4f, 0)]
        [TestCase(0, 2.4f)]
        [TestCase(1, 0)]
        public void TestSubtract(float x, float y)
        {
            Assert.That(Calculator.Subtract(x, y), Is.EqualTo(x - y));
        }

        //public static float Multiply(int x, int y) => x * y;
        [Test]
        [TestCase(1, 2)]
        [TestCase(2.4f, 3.3f)]
        [TestCase(0, 0)]
        [TestCase(2.4f, 0)]
        [TestCase(0, 2.4f)]
        [TestCase(1, 0)]
        public void TestMultiply(float x, float y)
        {
            Assert.That(Calculator.Multiply(x, y), Is.EqualTo(x * y));
        }

        //public static float? Divide(int x, int y) => x / y;
        [Test]
        [TestCase(1, 2)]
        [TestCase(2.4f, 3.3f)]
        [TestCase(0, 0)]
        [TestCase(2.4f, 0)]
        [TestCase(0, 2.4f)]
        [TestCase(1, 0)]
        public void TestDivide(float x, float y)
        {
            Assert.That(Calculator.Divide(x, y), Is.EqualTo(x / y));
        }
    }
}