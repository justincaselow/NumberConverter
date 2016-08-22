using NumberWorder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Unit
{
    [TestFixture]
    public class NumberWorderTests
    {
        [TestCase(1, ExpectedResult = "One")]
        [TestCase(2, ExpectedResult = "Two")]
        [TestCase(3, ExpectedResult = "Three")]
        [TestCase(4, ExpectedResult = "Four")]
        [TestCase(5, ExpectedResult = "Five")]
        [TestCase(6, ExpectedResult = "Six")]
        [TestCase(7, ExpectedResult = "Seven")]
        [TestCase(8, ExpectedResult = "Eight")]
        [TestCase(9, ExpectedResult = "Nine")]
        [TestCase(13, ExpectedResult = "Thirteen")]
        [TestCase(19, ExpectedResult = "Nineteen")]
        [TestCase(20, ExpectedResult = "Twenty")]
        [TestCase(25, ExpectedResult = "Twenty Five")]
        [TestCase(38, ExpectedResult = "Thirty Eight")]
        [TestCase(49, ExpectedResult = "Forty Nine")]
        [TestCase(100, ExpectedResult = "One Hundred")]
        [TestCase(198, ExpectedResult = "One Hundred and Ninety Eight")]
        [TestCase(999, ExpectedResult = "Nine Hundred and Ninety Nine")]
        [TestCase(1000, ExpectedResult = "One Thousand")]
        [TestCase(5000, ExpectedResult = "Five Thousand")]
        [TestCase(8765, ExpectedResult = "Eight Thousand Seven Hundred and Sixty Five")]
        [TestCase(9999, ExpectedResult = "Nine Thousand Nine Hundred and Ninety Nine")]
        [TestCase(10000, ExpectedResult = "Ten Thousand")]
        [TestCase(12345, ExpectedResult = "Twelve Thousand Three Hundred and Forty Five")]
        [TestCase(19999, ExpectedResult = "Nineteen Thousand Nine Hundred and Ninety Nine")]
        [TestCase(20000, ExpectedResult = "Twenty Thousand")]
        [TestCase(86452, ExpectedResult = "Eighty Six Thousand Four Hundred and Fifty Two")]
        [TestCase(99999, ExpectedResult = "Ninety Nine Thousand Nine Hundred and Ninety Nine")]
        public string Convert_WithSingleDigits_ReturnsExpectedResult(int number)
        {
            // Arrange
            var worder = new Converter();

            // Act
            var result = worder.Convert(number);

            // Assert
            return result;
        }
    }
}