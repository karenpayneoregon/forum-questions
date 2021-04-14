using System;
using System.Collections.Generic;
using ManagerUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManagerUnitTestProject
{
    [TestClass]
    public class UnitTest1 : TestBase
    {
        [TestInitialize]
        public  void Init()
        {

            if (TestContext.TestName == "TestMethod1")
            {

            }
            
        }
        /// <summary>
        /// Creates an new instance of TestContext used above
        /// </summary>
        /// <param name="testContext"></param>
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }
        [TestMethod]
        [TestTraits(Trait.DelegatesEvents)]
        public void TestMethod1()
        {

            
        }

    }
}
