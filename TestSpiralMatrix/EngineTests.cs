using NUnit.Framework;
using SpiralMatrix;

namespace TestSpiralMatrix
{
    [TestFixture]
    public class EngineTests
    {
        [Test]
        public void OneByOneMatrix()
        {
            //Arrange
            var engine = new Engine();
            
            //Act
            var finalArray = engine.Calculate(1);


            //Assert
            Assert.IsNotNull(finalArray);
            Assert.AreEqual(finalArray.Length, 1);
            Assert.AreEqual(finalArray[0,0], 1);
        }

        [Test]
        public void TwoByTwoMatrix()
        {
            //Arrange
            var engine = new Engine();

            //Act
            var finalArray = engine.Calculate(2);


            //Assert
            Assert.IsNotNull(finalArray);
            Assert.AreEqual(finalArray.Length, 4);
            Assert.AreEqual(1 , finalArray[0, 0] );
            Assert.AreEqual(2 , finalArray[1, 0] );
            Assert.AreEqual(3 , finalArray[1, 1] );
            Assert.AreEqual(4 , finalArray[0, 1] );
        }

        [Test]
        public void ThreeByThreeMatrix()
        {
            //Arrange
            var engine = new Engine();

            //Act
            var finalArray = engine.Calculate(3);


            //Assert
            Assert.IsNotNull(finalArray);
            Assert.AreEqual(finalArray.Length, 9);
            Assert.AreEqual( 1 , finalArray[0, 0]);
            Assert.AreEqual( 2 , finalArray[1, 0]);
            Assert.AreEqual( 3 , finalArray[2, 0]);
            Assert.AreEqual( 4 , finalArray[2, 1]);
            Assert.AreEqual( 5 , finalArray[2, 2]);
            Assert.AreEqual( 6 , finalArray[1, 2]);
            Assert.AreEqual( 7 , finalArray[0, 2]);
            Assert.AreEqual( 8 , finalArray[0, 1]);
            Assert.AreEqual( 9 , finalArray[1, 1]);

        }

        [Test]
        public void FourByFourMatrix()
        {
            //Arrange
            var engine = new Engine();

            //Act
            var finalArray = engine.Calculate(4);


            //Assert
            Assert.IsNotNull(finalArray);
            Assert.AreEqual(finalArray.Length, 16);
            Assert.AreEqual(1, finalArray[0, 0]);
            Assert.AreEqual(2, finalArray[1, 0]);
            Assert.AreEqual(3, finalArray[2, 0]);
            Assert.AreEqual(4, finalArray[3, 0]);
            Assert.AreEqual(5, finalArray[3, 1]);
            Assert.AreEqual(6, finalArray[3, 2]);
            Assert.AreEqual(7, finalArray[3, 3]);
            Assert.AreEqual(8, finalArray[2, 3]);
            Assert.AreEqual(9, finalArray[1, 3]);
            Assert.AreEqual(10, finalArray[0, 3]);
            Assert.AreEqual(11, finalArray[0, 2]);
            Assert.AreEqual(12, finalArray[0, 1]);
            Assert.AreEqual(13, finalArray[1, 1]);
            Assert.AreEqual(14, finalArray[2, 1]);
            Assert.AreEqual(15, finalArray[2, 2]);
            Assert.AreEqual(16, finalArray[1, 2]);

        }

        [Test]
        public void FiveByFiveMatrix()
        {
            //Arrange
            var engine = new Engine();

            //Act
            var finalArray = engine.Calculate(5);


            //Assert
            Assert.IsNotNull(finalArray);
            Assert.AreEqual(finalArray.Length, 25);
            Assert.AreEqual(1, finalArray[0, 0]);
            Assert.AreEqual(2, finalArray[1, 0]);
            Assert.AreEqual(3, finalArray[2, 0]);
            Assert.AreEqual(4, finalArray[3, 0]);
            Assert.AreEqual(5, finalArray[4, 0]);

            Assert.AreEqual(6, finalArray[4, 1]);
            Assert.AreEqual(7, finalArray[4, 2]);
            Assert.AreEqual(8, finalArray[4, 3]);
            Assert.AreEqual(9, finalArray[4, 4]);

            Assert.AreEqual(10, finalArray[3, 4]);
            Assert.AreEqual(11, finalArray[2, 4]);
            Assert.AreEqual(12, finalArray[1, 4]);
            Assert.AreEqual(13, finalArray[0, 4]);

            Assert.AreEqual(14, finalArray[0, 3]);
            Assert.AreEqual(15, finalArray[0, 2]);
            Assert.AreEqual(16, finalArray[0, 1]);

            Assert.AreEqual(17, finalArray[1, 1]);
            Assert.AreEqual(18, finalArray[2, 1]);
            Assert.AreEqual(19, finalArray[3, 1]); 
            
            Assert.AreEqual(20, finalArray[3, 2]);
            Assert.AreEqual(21, finalArray[3, 3]);

            Assert.AreEqual(22, finalArray[2, 3]);
            Assert.AreEqual(23, finalArray[1, 3]);

            Assert.AreEqual(24, finalArray[1, 2]);
            Assert.AreEqual(25, finalArray[2, 2]);

        }
    }
}
