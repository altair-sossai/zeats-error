using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeats.Error.Extensions;

namespace Zeats.Error.UnitTest.Extensions
{
    [TestClass]
    public class ExceptionExtensionsTest
    {
        [TestMethod]
        public void ToErrorInfo()
        {
            var exception = new Exception("Lorem Ipsum");
            var errorInfo = exception.ToErrorInfo();

            Assert.IsNotNull(errorInfo);
            Assert.AreEqual("Lorem Ipsum", errorInfo.Message);
        }
    }
}