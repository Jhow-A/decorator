using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using System;

namespace DecoratorPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();

            Console.WriteLine("=== Pizza padrão === ");
            Console.WriteLine(pizza.Opcionais());
            Console.WriteLine($"Preço: R$ {pizza.Preco()}\n");

            IPizza massaEspecial = new MassaEspecialDecorator(pizza);
            IPizza baconDecorator = new BaconDecorator(massaEspecial);
            IPizza bordaDecorator = new BordaRecheadaDecorator(baconDecorator);

            Console.WriteLine("=== Pizza com Decorator === ");
            Console.WriteLine(bordaDecorator.Opcionais());
            Console.WriteLine($"Preço: R$ {bordaDecorator.Preco()}");

            Console.ReadKey();
        }
    }
}
