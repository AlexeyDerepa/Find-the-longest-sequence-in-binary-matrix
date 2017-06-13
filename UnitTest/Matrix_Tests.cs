using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindTheLongestSequence;

namespace UnitTest
{
    [TestClass]
    public class Matrix_Tests
    {
        [TestMethod]
        public void SophisticatedMatrix_GetWidthAndGetHeight()
        {
            // arrange  
            int[,] arr = {
                              {0,0,0,1,0,0},
                              {0,0,1,1,1,0},
                              {0,0,0,1,1,0}
                          };
            SophisticatedProcessingOfBinaryMatrix pm = new SophisticatedProcessingOfBinaryMatrix();
            // act  
            pm.SetArray(arr);

            // assert  
            int widthOfArray = pm.GetWidth;
            int heightOfArray = pm.GetHeight;
            Assert.AreEqual(widthOfArray, 6);
            Assert.AreEqual(heightOfArray, 3);
        }
        [TestMethod]
        public void SophisticatedMatrix_3x6()
        {
            // arrange  
            int[,] arr = {
                              {0,0,0,1,0,0},
                              {0,0,1,1,1,0},
                              {0,0,0,1,1,0}
                          };
            SophisticatedProcessingOfBinaryMatrix pm = new SophisticatedProcessingOfBinaryMatrix();
            // act  
            pm.SetArray(arr);

            // assert  
            int result = pm.Processing();
            Assert.AreEqual(result, 3);
            Assert.AreEqual(pm.GetCurrentLongestSequence.Length, 3);
        }

        [TestMethod]
        public void SophisticatedMatrix_9x9()
        {
            // arrange  
            int[,] arr = {
                              {0,0,1,0,1,0,0,1,0,1},
                              {1,1,0,0,0,1,1,0,0,1},
                              {1,1,0,0,1,1,1,0,0,1},
                              {1,0,0,0,1,1,1,0,0,1},
                              {1,1,0,0,0,1,1,0,0,1},
                              {0,1,0,0,1,0,1,0,0,0},
                              {1,0,0,0,1,1,1,0,0,1},
                              {1,1,1,1,1,1,1,1,0,1},
                              {1,1,0,0,1,1,0,0,0,1},
                              {0,1,1,1,0,1,1,1,1,0}
                          };
            SophisticatedProcessingOfBinaryMatrix pm = new SophisticatedProcessingOfBinaryMatrix();
            // act  
            pm.SetArray(arr);

            // assert  
            int result = pm.Processing();
            Assert.AreEqual(result, 8);
            Assert.AreEqual(pm.GetCurrentLongestSequence.Length, 8);
        }

        [TestMethod]
        public void SophisticatedMatrix_overide_Sequence_to_String()
        {
            // arrange  
            int[,] arr = {
                              {0,0,1,0,1,0,0,1,0,1},
                              {1,1,0,0,0,1,1,0,0,1},
                              {1,1,0,0,1,1,1,0,0,1},
                              {1,0,0,0,1,1,1,0,0,1},
                              {1,1,0,0,0,1,1,0,0,1},
                              {0,1,0,0,1,0,1,0,0,0},
                              {1,0,0,0,1,1,1,0,0,1},
                              {1,1,1,1,1,1,1,1,0,1},
                              {1,1,0,0,1,1,0,0,0,1},
                              {0,1,1,1,0,1,1,1,1,0}
                          };
            SophisticatedProcessingOfBinaryMatrix pm = new SophisticatedProcessingOfBinaryMatrix();
            // act  
            pm.SetArray(arr);

            // assert  
            pm.Processing();
            StringAssert.Contains(pm.GetCurrentLongestSequence.ToString(), "Point 1 => X: 0     Y: 7    \nPoint 2 => X: 7     Y: 7    ");
        }
        		


        [TestMethod]
        [ExpectedException(typeof(NotFoundArrayException))]
        public void SophisticatedMatrix_Exception()
        {
            // arrange  
            SophisticatedProcessingOfBinaryMatrix pm = new SophisticatedProcessingOfBinaryMatrix();
            // act  
            int result = pm.Processing();
            // assert  
        }


        [TestMethod]
        public void ElementaryMatrix_GetWidthAndGetHeight()
        {
            // arrange  
            int[,] arr = {
                              {0,0,0,1,0,0},
                              {0,0,1,1,1,0},
                              {0,0,0,1,1,0}
                          };
            ElementaryProcessingOfBinaryMatrix pm = new ElementaryProcessingOfBinaryMatrix();
            // act  
            pm.SetArray(arr);

            // assert  
            int widthOfArray = pm.GetWidth;
            int heightOfArray = pm.GetHeight;
            Assert.AreEqual(widthOfArray, 6);
            Assert.AreEqual(heightOfArray, 3);
        }
        [TestMethod]
        public void ElementaryMatrix_3x6()
        {
            // arrange  
            int[,] arr = {
                              {0,0,0,1,0,0},
                              {0,0,1,1,1,0},
                              {0,0,0,1,1,0}
                          };
            ElementaryProcessingOfBinaryMatrix pm = new ElementaryProcessingOfBinaryMatrix();
            // act  
            pm.SetArray(arr);

            // assert  
            int result = pm.Processing();
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void ElementaryMatrix_9x9()
        {
            // arrange  
            int[,] arr = {
                              {0,0,1,0,1,0,0,1,0,1},
                              {1,1,0,0,0,1,1,0,0,1},
                              {1,1,0,0,1,1,1,0,0,1},
                              {1,0,0,0,1,1,1,0,0,1},
                              {1,1,0,0,0,1,1,0,0,1},
                              {0,1,0,0,1,0,1,0,0,0},
                              {1,0,0,0,1,1,1,0,0,1},
                              {1,1,1,1,1,1,1,1,0,1},
                              {1,1,0,0,1,1,0,0,0,1},
                              {0,1,1,1,0,1,1,1,1,0}
                          };
            ElementaryProcessingOfBinaryMatrix pm = new ElementaryProcessingOfBinaryMatrix();
            // act  
            pm.SetArray(arr);

            // assert  
            int result = pm.Processing();
            Assert.AreEqual(result, 8);
        }


        [TestMethod]
        [ExpectedException(typeof(NotFoundArrayException))]
        public void ElementaryMatrix_Exception()
        {
            // arrange  
            ElementaryProcessingOfBinaryMatrix pm = new ElementaryProcessingOfBinaryMatrix();
            // act  
            int result = pm.Processing();
            // assert  
        }


    }
}
