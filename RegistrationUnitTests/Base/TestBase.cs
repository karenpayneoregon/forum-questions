using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonStorage;

namespace RegistrationUnitTests.Base
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
        public void IntRegistration()
        {
            RegistrationContainer.Instance.Person.FirstName = "Karen";
            RegistrationContainer.Instance.Person.LastName = "Payne";
        }
    }
}
