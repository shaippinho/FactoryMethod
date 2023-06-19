using FactoryMethodPattern.Domain.Entities;

namespace FactoryMethodPattern.Domain.Factories.Screen
{
    public class ConcreteScreamWebFactory : ScreenFactory
    {
        public override Entities.Base.Screen Build()
        {
            return new ScreenWeb();
        }
    }
}
