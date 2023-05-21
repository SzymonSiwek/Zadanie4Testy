namespace RównanieKwadratowe.Tests
{
    public class RownanieKwadratoweTests
    {
        [Fact]
        public void ObliczPierwiastki_BrakPierwiastkowRzeczywistych_ReturnsNaN()
        {
            // Arrange
            double a = 2;
            double b = 3;
            double c = 4;

            // Act
            var (x1, x2) = RownanieKwadratowe.ObliczPierwiastki(a, b, c);

            // Assert
            Assert.Equal(double.NaN, x1);
            Assert.Equal(double.NaN, x2);
        }
    }
}
