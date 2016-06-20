using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using PasswordHasher;

namespace PasswordHasher.Test
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dnx.html
    public class SimpleHasherTest
    {
        [Fact]
        public void SimpleHasherHashesCorrectly()
        {
            var simpleHasher = new SimpleHasher();
            Assert.Equal("6a934b45144e3758911efa29ed68fb2d420fa7bd568739cdcda9251fa9609b1e", simpleHasher.hash("secure"));
        }
    }
}
