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

        [Test]
        public void TestMultiply()
        {
            Arithmetic arith = new Arithmetic();
            int expected =  6;
            int actual = arith.Multiply(3, 2);
            
            Assert.AreEqual(expected, actual);
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

        [Test]
        public void TestCirclePerimeter()
        {
            Circle circle = new Circle();
            circle.Radius = 5;
            double expected = 31.42;
            double actual = circle.perimeter();
            
            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void TestRectangleArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;
            double expected = 50;
            double actual = rectangle.Area();
            
            Assert.AreEqual(expected, actual, 0.01);
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