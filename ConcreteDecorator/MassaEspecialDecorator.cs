using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    class MassaEspecialDecorator : PizzaDecorator
    {
        public MassaEspecialDecorator(IPizza pizza) : base(pizza) { }

        public override string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\r\ncom massa especial";
            return pizza;
        }
        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 2.50M;
            return preco;
        }
    }
}
