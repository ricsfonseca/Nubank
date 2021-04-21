using System;
using Bogus;

namespace Nubank.Infra.Data.Extensions
{
    public static class BogusFakerExtension
    {
        public static Faker<T> UsePrivateConstructor<T>(this Faker<T> faker) where T : class
        {
            return faker.CustomInstantiator(f => Activator.CreateInstance(typeof(T), nonPublic: true) as T);
        }
    }
}
