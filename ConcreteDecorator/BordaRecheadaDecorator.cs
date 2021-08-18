using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    class BordaRecheadaDecorator : PizzaDecorator
    {
        public BordaRecheadaDecorator(IPizza pizza) : base(pizza) { }

        public override string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\r\ncom borda recheada";

            return pizza;
        }
        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 3.00M;

            return preco;
        }
    }
}
