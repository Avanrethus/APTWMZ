using System;

using NUnit.Framework;
namespace UnitTestProject1
{

    [TestFixture]
    public class UnitTest1
    {
     
        [Test]
        public void TestMethodPass()
        {
            Assert.IsTrue(true);
        }
        [Test]
        //ZAMIANA kodu Kamila
        //ZAMIANA kodu Kamila
        public void TestMethodFail()
        {
            Assert.IsTrue(true);
        }
    }
}
