using System;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using Unittest;

namespace Tests
{
    public class Tests
    {
        public void CreateBog(string t, string a, int nop, string isbn)
        {
            Bog Bog1 = new Bog(t, a, nop, isbn);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AuthorSucces()
        {
            Bog Bog1 = new Bog("Test1", "Test1", 500, "1234567890123");

            Assert.AreEqual("Test1", Bog1.Author);
        }

        [Test]
        public void AuthorFail()
        {
            
            Exception exception;

            try
            {
                CreateBog("test2", "t", 500, "1234567890123");
            }
            catch(Exception e)
            {
                 exception = e;
            }

            Assert.AreEqual("Must be more than 2 characters", exception.Message);




        }

        [Test]
        public void NoOfPagesSucces()
        {
            Bog Bog3 = new Bog("Test3", "Test3", 500, "1234567890123");

            Assert.AreEqual(500, Bog3.NoOfPages);
        }

        [Test]
        public void NoOfPagesFail()
        {
            Bog Bog4 = new Bog("Test4", "Test4", 3, "1234567890123");

            Assert.AreEqual(Bog4, null);
        }

        [Test]
        public void IsbnSucces()
        {
            Bog Bog5 = new Bog("Test3", "Test3", 500, "1234567890123");

            Assert.AreEqual("1234567890123", Bog5.Isbn);
        }

        [Test]
        public void IsbnFail()
        {
            Bog Bog5 = new Bog("Test4", "Test4", 3, "12345678901234");

            Assert.AreEqual(Bog5, null);
        }

    }
}