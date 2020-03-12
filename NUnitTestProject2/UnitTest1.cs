using System;
using NUnit.Framework;
using Unittest;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAuthor1()
        {
            Bog _bog1;
            _bog1 = new Bog("Test1", "Test1", 500, "1234567890123");

            Assert.AreEqual("Test1", _bog1.Title);
            Assert.AreEqual("Test1", _bog1.Author);
            Assert.AreEqual(500, _bog1.NoOfPages);
            Assert.AreEqual("1234567890123", _bog1.Isbn);

            try
            {
                Bog Bog2 = new Bog("Test2", "T", 500, "1234567890123");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Must be more than 2 characters", e.Message);
            }
        }

        [Test]
        public void TestNoOfPages()
        {
            try
            {
                Bog Bog2 = new Bog("Test3", "Test3", 3, "1234567890123");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Number of pages must be between 4 and 1000", e.Message);
            }
        }

        [Test]
        public void TestISBN()
        {
            try
            {
                Bog Bog2 = new Bog("Test4", "Test4", 500, "12345678901234");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Isbn must be exactly 13 characters", e.Message);
            }
        }

    }
}