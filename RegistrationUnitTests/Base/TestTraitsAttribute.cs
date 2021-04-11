using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RegistrationUnitTests.Base
{

    public enum Trait
    {
        /// <summary>
        /// Test for appsettings.json
        /// </summary>
        Configurations,
        /// <summary>
        /// Test category for singleton class, person registration
        /// </summary>
        Registration
    }
    /// <summary>
    /// Declarative class for using Trait enum about for traits on test method.
    /// </summary>
    public class TestTraitsAttribute : TestCategoryBaseAttribute
    {
        private readonly Trait[] _traits;

        public TestTraitsAttribute(params Trait[] traits)
        {
            _traits = traits;
        }

        public override IList<string> TestCategories => _traits.Select(trait => Enum.GetName(typeof(Trait), trait)).ToList();
    }

}