using FactoryMethodPattern.Domain.Entities;

namespace FactoryMethodPattern.Domain
{
    public abstract class ScreamFactory
    {
        public abstract Scream Build();
    }
}