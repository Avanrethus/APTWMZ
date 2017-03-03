using System;

using NUnit.Framework;
namespace UnitTestProject1
{

    [TestFixture]
    public class UnitTest1
    {
        //Kamil
        [Test]
        public void TestMethodPass()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void TestMethodFail()
        {
            Assert.IsTrue(true);
        }
    }
}
