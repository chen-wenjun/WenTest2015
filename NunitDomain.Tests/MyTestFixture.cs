using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitDomain.Tests
{
    [TestFixture]
    public class MyTestFixture
    {
        [Test]
        public void MyFistTest()
        {
            var result = 2 + 2;
            Assert.AreEqual(4, result);
        }
    }
}
