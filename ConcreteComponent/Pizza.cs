using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    class Pizza : IPizza
    {
        public decimal Preco()
        {
            var preco = 10.00M;
            return preco;
        }

        public string Opcionais()
        {
            var pizza = "Pizza padrão";
            return pizza;
        }
    }
}
