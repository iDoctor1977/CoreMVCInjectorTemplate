using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectorUnitTest.Common
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void TestRunSetup()
        {
        }

        [SetUp]
        public virtual void Setup()
        {
        }
    }
}
