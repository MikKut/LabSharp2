namespace Lab2.Model
{
    public interface IFactory
    {
        FactoryHR FactoryHR { get; }
        string Name { get; }
        int QuantityOfWorkshops { get; }
    }
}