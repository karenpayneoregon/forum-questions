using System;
using System.Collections.Generic;
using ManagerLibrary;
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
                Example.OnProcessingCompletedEvent += OnProcessingCompletedEvent;
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
        public void TestMethod1()
        {
            var example = new Example() {StartValue = 1, EndValue = 10};
            example.DoWork();

            Assert.IsTrue(StarterValue == 1 && EnderValue == 10);
            
        }
        private void OnProcessingCompletedEvent(WhatEver sender)
        {
            StarterValue = sender.StartLockDownCount;
            EnderValue = sender.EndLockDownCount;
        }
    }
}
