﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit39
{
    public class TestClass2
    {
        [TestCase]
        public void doubleTest()
        {
            double res = new ClassLibrary1.op().doubleIt(5);
            Assert.AreEqual(10.0, res, double.Epsilon);
        }
    }
}
