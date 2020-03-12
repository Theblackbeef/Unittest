using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        public void CreateBog(string t, string a, int nop, string isbn)
        {
            Bog Bog1 = new Bog(t, a, nop, isbn);
        }


        [TestMethod]
        public void AuthorSucces()
        {
            Bog Bog1 = new Bog("Test1", "Test1", 500, "1234567890123");

            Assert.AreEqual("Test1", Bog1.Author);
        }
    }
}