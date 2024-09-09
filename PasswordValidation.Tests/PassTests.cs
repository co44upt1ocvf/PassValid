using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PasswordValidation.Tests
{
    [TestClass]
    public class PassTests
    {
        [TestMethod]
        public void Valid_EmptyPass_0return()
        {
            int mark = Pass.Valid("");
            Assert.AreEqual(0, mark);
        }
        [TestMethod]
        public void Valid_DigitChar_1return()
        {
            int mark = Pass.Valid("123193");
            Assert.AreEqual(1, mark);
        }
        [TestMethod]
        public void Valid_LowerChar_2return()
        {
            int mark = Pass.Valid("d00phakz");
            Assert.AreEqual(2, mark);
        }
        [TestMethod]
        public void Valid_UpperChar_3return()
        {
            int mark = Pass.Valid("D00PhaKz");
            Assert.AreEqual(3, mark);
        }
        [TestMethod]
        public void Valid_SpecialChar_4return()
        {
            int mark = Pass.Valid("D00Ph@Kz");
            Assert.AreEqual(4, mark);
        }
        [TestMethod]
        public void Valid_LengthCheck_5return()
        {
            int mark = Pass.Valid("D00Ph@Kzzzz");
            Assert.AreEqual(5, mark);
        }
    }
}
