using System;
using SingletonStorage.Classes;

namespace SingletonStorage
{
    public sealed class RegistrationContainer
    {
        private static readonly Lazy<RegistrationContainer> Lazy = 
            new(() => new RegistrationContainer());
        
        public static RegistrationContainer Instance => Lazy.Value;
        
        public Person Person { get; set; }

        public void CreatePerson()
        {
            Person = new Person();
        }
        private RegistrationContainer()
        {
            CreatePerson();
        }
    }
}
