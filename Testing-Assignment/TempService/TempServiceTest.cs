using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempService;

namespace TempService
{
    [TestFixture]

    internal class TempServiceTest
    {
        [Test]

        public void TestCel()
        {
            temperature obj = new temperature();
            double expected = 150;
            double actual = obj.FTC(302);
            Assert.AreEqual(expected, actual);
            
        }

        [Test]

        public void TestFar()
        {
            temperature obj = new temperature();
            double expected = 302;
            double actual = obj.CTF(150);
            Assert.AreEqual(expected, actual);

        }

    }
}
