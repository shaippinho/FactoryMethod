namespace FactoryMethodPattern.Domain.Entities.Base
{
    public abstract class Screen
    {
        protected string? BackgroundColor { get; }
        
        private readonly string? _message;

        public Screen(string backgroundColor, string message)
        {
            BackgroundColor = backgroundColor;
            _message = message;
        }

        public string GetMessage()
        {
            return _message;
        }
    }
}
