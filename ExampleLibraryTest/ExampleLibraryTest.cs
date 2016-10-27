using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
//using ExampleLibrary;

namespace Test
{
    [TestFixture]
    public class ExampleLibraryTest
        
    {
        [Test]
        public void TestNUnitWorks()
        {
            ExampleLibrary.Class1 ellib = new ExampleLibrary.Class1();
            Assert.AreEqual("jeg er en klasse", ellib.ToString());
        }

    }
}
