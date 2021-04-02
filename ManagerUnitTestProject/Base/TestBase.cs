using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManagerUnitTestProject.Base
{
    public class TestBase
    {
        protected TestContext TestContextInstance;
        public TestContext TestContext
        {
            get => TestContextInstance;
            set
            {
                TestContextInstance = value;
                TestResults.Add(TestContext);
            }
        }

        public static IList<TestContext> TestResults;

        public int StarterValue { get; set; }
        public int EnderValue { get; set; }


    }
}