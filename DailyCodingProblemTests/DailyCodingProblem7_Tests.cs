using DailyCodingProblem_7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCodingProblemTests
{
    [TestClass]
    public class DailyCodingProblem7_Tests
    {
        private readonly DCP7 _DCP7;

        public DailyCodingProblem7_Tests()
        {
            _DCP7 = new DCP7();
        }

        [TestMethod, TestCategory("(DCP7) Decode Alphabet")]
        public void Decode_111_To_All_Possibilities()
        {
            //Arrange
            string input = "aaa";
            int expected = 3;
            //Act
            int actual = _DCP7.FindAllPossibleDecodings(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
