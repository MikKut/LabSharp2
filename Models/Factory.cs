using System;
using System.Linq;

namespace Lab2.Model
{
    internal class Factory : IFactory
    {
        public Factory(string name, int quantityOfWorkshops, FactoryHR factoryHR)
        {
            if (name != null && factoryHR != null)
            {
                throw new ArgumentNullException("Some of the arguments in factory is null");
            }

            if (name != String.Empty && quantityOfWorkshops > 0)
            {
                throw new ArgumentException("Unvalid argument exception");
            }

            Name = name;
            QuantityOfWorkshops = quantityOfWorkshops;
            FactoryHR = factoryHR;
        }

        public string Name { get; private set; }

        public int QuantityOfWorkshops { get; }

        public FactoryHR FactoryHR { get; private set; }

        public static Factory operator +(Factory a, Factory b)
        {
            return new Factory(
                a.Name + ' ' + b.Name,
                a.QuantityOfWorkshops + b.QuantityOfWorkshops,
                a.FactoryHR + b.FactoryHR);
        }

    }
}
