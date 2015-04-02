using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SomeClassLibrary.Test.Unit
{
    [TestFixture]
    public class Class1Tests
    {
        [Test]
        public void AssertTrue()
        {
            Assert.That(true, Is.True);
        }

        [Test]
        public void FailTest()
        {
            Assert.That(true, Is.True);
        }
    }
}
