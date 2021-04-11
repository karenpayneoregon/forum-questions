using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistrationUnitTests.Base;
using SingletonStorage;

namespace RegistrationUnitTests
{
    [TestClass]
    public class UnitTest1 : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.Registration)]
        public void RegistrationTestAcrossMethods()
        {
            var expectedFirstName = "Karen";
            var expectedLastName = "Payne";
            
            Assert.IsTrue(
                RegistrationContainer.Instance.Person.FirstName == expectedFirstName &&
                RegistrationContainer.Instance.Person.LastName == expectedLastName,
                $"Expected {expectedFirstName} {expectedLastName} in {nameof(RegistrationTestAcrossMethods)}");
        }

        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }
        
        [TestInitialize]
        public void Init()
        {
            if (TestContext.TestName == "RegistrationTestAcrossMethods")
            {
                IntRegistration();
            }
        }
    }
}
