using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singletone2;
using SingleTon2;
namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Logger logger = Logger.Instance;
            logger.LogInfo("FInstace");
            Logger logger2 = Logger.Instance;
            logger.LogInfo("Error Instace");
         var result=object.ReferenceEquals(logger, logger2);
         
            Assert.AreEqual(result,true);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Logger logger = Logger.Instance;
            logger.LogInfo("FInstace");
            Logger logger2 = Logger.Instance;
            logger.LogInfo("Error Instace");
            var result = object.ReferenceEquals(logger, logger2);

            Assert.AreNotEqual(result, false);
        }
    }
}
