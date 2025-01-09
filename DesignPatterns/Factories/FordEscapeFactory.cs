using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;
using System;

namespace DesignPatterns.Factories
{
    public class FordEscapeFactory : CarFactory
    {

        
        public override Vehicle Create()
        {
            var builder = new CarModelBuilder();
            return builder
                .setColor("red")
                .setBrand("Ford")
                .setModel("Escape")
                .Build();
                
        }
    }
}
