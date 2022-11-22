namespace Lab2.Model
{
    internal interface IFactoryHR
    {
        decimal IncomePerMaster { get; }
        decimal IncomePerSlave { get; }
        int QuantityOfMasters { get; }
        int QuantityOfSlaves { get; }
        void AddMaster();
        void AddSlave();
        bool RemoveMaster();
        bool RemoveSlave();
    }
}