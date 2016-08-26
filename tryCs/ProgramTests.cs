using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using NUnit.Framework;

namespace tryCs
{
    [TestFixture]
    class ProgramTests : AssertionHelper
    {
        [Test]
        public void testAddition()
        {
            Assert.That(Program.Add(5, 4), Is.EqualTo(9));
            Assert.That(Program.Add(1, 2), Is.EqualTo(3));
        }
    }
}
