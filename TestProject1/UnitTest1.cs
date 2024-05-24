using Shapes;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestAdd()
        {
            Arithmetic arith = new Arithmetic();
            int expectedValue = 2;
            int actualValue = arith.Add(1, 1);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TestSubtract()
        {
            Arithmetic arith = new Arithmetic();
            int expected =  2;
            int actual = arith.Subtract(3, 1);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2, 6)]
        [TestCase(3, 3, 9)]
        [TestCase(5, 5, 25)]
        public void TestMultiply(int input,int input2, int expected)
        {
            Arithmetic arith = new Arithmetic();
            int result = arith.Multiply(input, input2);
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestDivide()
        {
            Arithmetic arith = new Arithmetic();
            int expected =  2;
            int actual = arith.Divide(4, 2);
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCircleArea()
        {
            Circle circle = new Circle();
            circle.Radius = 5;
            double expected = 78.54;
            double actual = circle.Area();
            
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestCase(5, 31.42)]
        [TestCase(10, 62.83)]
        public void TestCirclePerimeter(int input, double expected)
        {
            Circle circle = new Circle();
            circle.Radius = input;
            double result = circle.perimeter();
            
            Assert.AreEqual(expected, result, 0.01);
        }

        [TestCase(5, 10, 50)]
        [TestCase(10, 10, 100)]
        [TestCase(4, 12, 48)]
        public void TestRectangleArea(int width, int height, int expected)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = width;
            rectangle.Height = height;
            double result = rectangle.Area();
            
            Assert.AreEqual(expected, result, 0.01);
        }

        [Test]
        public void TestRectanglePerimeter()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;
            double expected = 30;
            double actual = rectangle.perimeter();
            
            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void TestTriangleArea()
        {
            Triangle triangle = new Triangle();
            triangle.SideA = 5;
            triangle.SideB = 5;
            triangle.SideC = 5;
            double expected = 10.83;
            double actual = triangle.Area();
            
            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void TestTrianglePerimeter()
        {
            Triangle triangle = new Triangle();
            triangle.SideA = 5;
            triangle.SideB = 5;
            triangle.SideC = 5;
            double expected = 15;
            double actual = triangle.perimeter();
            
            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}