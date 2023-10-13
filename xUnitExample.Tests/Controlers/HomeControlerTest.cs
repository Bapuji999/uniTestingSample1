using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitExample.Controllers;

namespace xUnitExample.Tests.Controlers
{
    public class HomeControlerTest
    {
        [Fact]
        public void HomeControler_Index_ValidResult()
        {
            ///AAA

            ///Arange -
            HomeController controller = new HomeController();
            string expectedResult = "I am in Home.";

            ///Add
            string result = controller.Index();

            ///Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(101, "Worng ! try Smaller Number.")]
        [InlineData(99, "Worng ! try Greter Number.")]
        [InlineData(100, "You guessed correct number.")]
        public void HomeControler_CheckNumber_ValidResult(int guessedNumber, string expectedMessage)
        {
            // Arrange
            var controller = new HomeController(); 

            // Act
            var result = controller.CheckNumber(guessedNumber);

            // Assert
            Assert.Equal(expectedMessage, result);
        }
        [Theory]
        [ClassData(typeof(CheckNumberTestData))]
        public void CheckNumber_ReturnsExpectedResult(int guessedNumber, string expectedMessage)
        {
            // Arrange
            var controller = new HomeController(); // Create an instance of your controller

            // Act
            var result = controller.CheckNumber(guessedNumber);

            // Assert
            Assert.Equal(expectedMessage, result);
        }
    }
    public class CheckNumberTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 101, "Worng ! try Smaller Number." };
            yield return new object[] { 99, "Worng ! try Greter Number." };
            yield return new object[] { 100, "You guessed correct number." };
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
