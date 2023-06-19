using FactoryMethodPattern.Domain.Contracts;
using FactoryMethodPattern.Domain.Entities.Base;
using FactoryMethodPattern.Domain.Factories.Screen;

namespace FactoryMethodPattern.Domain.Services
{
    public class ScreenService : IScreenService
    {
        public string GetMessage()
        {
            Screen screenWeb = new ConcreteScreamWebFactory().Build();
            return screenWeb.GetMessage();
        }
    }
}
