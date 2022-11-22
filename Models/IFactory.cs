namespace Lab2.Model
{
    internal interface IFactory
    {
        FactoryHR FactoryHR { get; }
        string Name { get; }
        int QuantityOfWorkshops { get; }
    }
}