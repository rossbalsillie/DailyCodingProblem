using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DailyCodingProblem_4;

namespace DailyCodingProblemTests
{
    [TestClass]
    public class DailyCodingProblem4_Tests
    {
        private readonly DCP4 _DCP4;

        public DailyCodingProblem4_Tests()
        {
            _DCP4 = new DCP4();
        }

        [TestMethod, TestCategory("Find Lowest Positive Integer Tests (DCP4)")]
        public void Find_Lowest_Positive_Integer_Sorted_List()
        {
            //Arrange
            List<int> ints = new List<int>() { 1, 2, 3, 4 };
            int expected = 5;
            //Act
            int actual = _DCP4.FindLowestPositiveIntegerNotInList(ints);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, TestCategory("Find Lowest Positive Integer Tests (DCP4)")]
        public void Find_Lowest_Positive_Integer_Non_Sorted_List()
        {
            //Arrange
            List<int> ints = new List<int>() { 1, 3, 2 };
            int expected = 4;
            //Act
            int actual = _DCP4.FindLowestPositiveIntegerNotInList(ints);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
