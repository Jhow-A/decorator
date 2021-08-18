using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza) { }

        public override string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\ncom porção extra de bacon";

            return pizza;
        }
        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 4.00M;

            return preco;
        }
    }
}
