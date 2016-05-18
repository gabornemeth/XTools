﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XDotNet.Extensions;

namespace XDotNet.Tests
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void Random_String()
        {
            string s = StringExtensions.GetRandomString(20);
            Console.WriteLine(s);
            Assert.IsTrue(s.Length == 20);
        }
    }
}
