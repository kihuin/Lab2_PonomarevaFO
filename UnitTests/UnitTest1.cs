using Lab2_PonomarevaFO;

namespace UnitTests
{
    public class Tests
    {
        [Test]
        public void TypeTriangleEquilateral()
        {
            // Arrange
            string sideA = "5";
            string sideB = "5";
            string sideC = "5";

            // Act
            var result = new TriangleS().CalculateTriangleTypeAndCoordinates(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Тип треугольника: Равносторонний", result.Item1);
        }

        [TestCase("3", "3", "4")]
        [TestCase("3", "4", "3")]
        [TestCase("4", "3", "3")]
        public void TestIsoscelesTriangle(string sideA, string sideB, string sideC)
        {

            // Act
            var result = new TriangleS().CalculateTriangleTypeAndCoordinates(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Тип треугольника: Равнобедренный", result.Item1);
        }

        [TestCase("3", "4", "5")]
        [TestCase("4", "5", "3")]
        [TestCase("5", "3", "4")]
        public void TypeTriangleVersatile(string sideA, string sideB, string sideC)
        {

            // Act
            var result = new TriangleS().CalculateTriangleTypeAndCoordinates(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Тип треугольника: Разносторонний", result.Item1);
        }

        [TestCase("1", "2", "5")]
        [TestCase("2", "1", "5")]
        [TestCase("5", "2", "1")]
        public void TestNotTriangle(string sideA, string sideB, string sideC)
        {
            // Arrange


            // Act
            var result = new TriangleS().CalculateTriangleTypeAndCoordinates(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Тип треугольника: не треугольник", result.Item1);
        }

        [TestCase("a", "2", "5")]
        [TestCase("3", "a", "5")]
        [TestCase("3", "2", "a")]
        public void TestNotTriangleInvalid(string sideA, string sideB, string sideC)
        {

            // Act
            var result = new TriangleS().CalculateTriangleTypeAndCoordinates(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("", result.Item1);
        }

        [TestCase("a", "2", "5")]
        [TestCase("3", "a", "5")]
        [TestCase("3", "2", "a")]
        public void TestNotTriangleInvalidCoordinats(string sideA, string sideB, string sideC)
        {

            // Act
            var result = new TriangleS().CalculateTriangleTypeAndCoordinates(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(new List<(int, int)> { (-2, -2), (-2, -2), (-2, -2) }, result.Item2);
        }

        [TestCase("1", "2", "5")]
        [TestCase("2", "1", "5")]
        [TestCase("5", "2", "1")]
        public void TestNotTriangleCoordinats(string sideA, string sideB, string sideC)
        {
            // Arrange


            // Act
            var result = new TriangleS().CalculateTriangleTypeAndCoordinates(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(new List<(int, int)> { (-1, -1), (-1, -1), (-1, -1) }, result.Item2);
        }

        [Test]
        public void TestCoordinatesTriangle_LargeValues()
        {
            // Arrange
            string sideA = "10";
            string sideB = "20";
            string sideC = "15";
            float a = 10;
            float b = 20;
            float c = 15;
            int Ax, Ay, Bx, By, Cx, Cy;

            // Act
            new TriangleS().CoordinatesTriangle(sideA, sideB, sideC, a, b, c, out Ax, out Ay, out Bx, out By, out Cx, out Cy);

            // Assert
            Assert.AreEqual(50, Ax);
            Assert.AreEqual(0, Ay);
            Assert.AreEqual(68, Bx);
            Assert.AreEqual(72, By);
            Assert.AreEqual(0, Cx);
            Assert.AreEqual(75, Cy);
        }

        [Test]
        public void TestCoordinatesTriangle()
        {
            // Arrange
            string sideA = "10";
            string sideB = "10";
            string sideC = "10";
            float a = 10;
            float b = 10;
            float c = 10;
            int Ax, Ay, Bx, By, Cx, Cy;

            // Act
            new TriangleS().CoordinatesTriangle(sideA, sideB, sideC, a, b, c, out Ax, out Ay, out Bx, out By, out Cx, out Cy);

            // Assert
            Assert.AreEqual(100, Ax);
            Assert.AreEqual(0, Ay);
            Assert.AreEqual(49, Bx);
            Assert.AreEqual(86, By);
            Assert.AreEqual(0, Cx);
            Assert.AreEqual(100, Cy);
        }


    }
}