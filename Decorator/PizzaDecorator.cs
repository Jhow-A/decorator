using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual decimal Preco()
        {
            var preco = _pizza.Preco();
            return preco;
        }

        public virtual string Opcionais()
        {
            var pizza = _pizza.Opcionais();
            return pizza;
        }
    }
}
