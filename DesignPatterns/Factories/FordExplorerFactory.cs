using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordExplorerFactory : CarFactory
    {


        public override Vehicle Create()
        {
            var builder = new CarModelBuilder();
            return builder
                .setColor("red")
                .setBrand("Ford")
                .setModel("Explorer")
                .Build();

        }
    }
}
