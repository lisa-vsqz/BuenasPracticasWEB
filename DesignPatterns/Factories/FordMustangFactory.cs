using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordMustangFactory : CarFactory
    {


        public override Vehicle Create()
        {
            var builder = new CarModelBuilder();
            return builder
                .setColor("purple")
                .setBrand("Ford")
                .setModel("Mustang")
                .Build();

        }
    }
}