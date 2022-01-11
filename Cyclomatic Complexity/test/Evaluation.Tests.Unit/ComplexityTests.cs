using NFluent;
using Xunit;

namespace Evaluation.Tests.Unit
{
    public class ComplexityTests
    {
        [Theory]
        [InlineData(1, "one")]
        [InlineData(2, "a couple")]
        [InlineData(3, "a few")]
        [InlineData(4, "lots")]
        [InlineData(0, "")]
        [InlineData(-12, "")]
        public void Good_ShouldReturnTheRightValue_WhenMaxValueIsValid(int number, string expected)
        {
            // Arrange

            // Act
            var result = Complexity.Good(number);

            // Assert
            Check.That(result).IsEqualTo(expected);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 3)]
        [InlineData(3, 6)]
        [InlineData(4, 6)]
        [InlineData(10, 18)]
        public void QuiteGood_ShouldReturnTheRightValue_WhenMaxValueIsValid(int max, int expected)
        {
            // Arrange

            // Act
            var result = Complexity.QuiteGood(max);

            // Assert
            Check.That(result).IsEqualTo(expected);
        }

        [Theory]
        [InlineData(-23, 0)]
        [InlineData(1, 1)]
        [InlineData(100, 0)]
        [InlineData(18, 171)]
        [InlineData(28, 902)]
        [InlineData(27, 779)]
        [InlineData(24, 1276)]
        public void Bad_ShouldReturnTheRightValue_WhenMaxValueIsValid(int max, int expected)
        {
            // Arrange

            // Act
            var result = Complexity.Bad(max);

            // Assert
            Check.That(result).IsEqualTo(expected);
        }
    }
}
