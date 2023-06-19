namespace FactoryMethodPattern.Domain.Factories.Screen
{
    public abstract class ScreenFactory
    {
        public abstract Entities.Base.Screen Build();
    }
}