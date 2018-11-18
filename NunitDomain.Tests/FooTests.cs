using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitDomain.Tests
{
    [TestFixture]
    class FooTests
    {
        [Test]
        public void Foo()
        {
            var measurements = new List<Measurement>()
            {
                new Measurement() { HighValue = 10, LowValue = 1}
            };

            
        }
    }
}
