﻿using System;

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
        public void TestMethodFail()
        {
            Assert.IsTrue(true);
        }
    }
}
