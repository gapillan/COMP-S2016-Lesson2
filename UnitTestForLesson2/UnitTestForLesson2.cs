using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP_S2016_Lesson2;

namespace UnitTestForLesson2
{
    [TestClass]
    public class UnitTestForLesson2
    {
        [TestMethod]
        public void addXandYTestMethod()
        {

            // Arrange 
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            // Act
            int result = Program.addXandY(x, y);

            // Assert 
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void addYtoXTestMethod()
        {

            // Arrange 
            int x = 0;
            int y = 50;
            int expectedResult = 90;

            // Act
            int result = Program.addYtoX(ref x, ref y);

            // Assert 
            Assert.AreEqual(expectedResult, result);
        }

        public void readUntilEndTestMethod()
        {

            // Arrange 
            int numberOfEntries = 5; 
            //string[] returnedArray = new string[numberOfEntries]; 
            int expectedCount = 5;
            int actualCount = 0; 

            // Act
            actualCount = Program.readUntilEnd(numberOfEntries);
            //returnedArray = Program.readUntilEnd(numberOfEntries);
            //Console.WriteLine(returnedArray.Length);

            // Assert 
            Assert.AreEqual(expectedCount, actualCount);
            //Assert.IsTrue(returnedArray.Length == 0);
        }
    }
}
