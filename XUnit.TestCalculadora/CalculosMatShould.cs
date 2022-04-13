//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Xunit;

namespace XUnit.TestCalculadora
{
    public class CalculosMatShould
    {
        [Fact]
        public void Sum_ReturnsCorrectValue()
        {
            //Arrange
            var nA = 2;
            var nB = 2;

            //Act
            var nC = nA + nB;

            //Assert
            Assert.Equal(4, nC);
        }

        [Theory]
        [InlineData(1, 0, 1)]
        [InlineData(2, 2, 4)]
        public void Sum_MultipleParams_ReturnsCorrectValue(int nA, int nB, int expected)
        {
            //Arrange
          
            //Act
            var nC = nA + nB;

            //Assert
            Assert.Equal(expected, nC);
        }

    }
}
