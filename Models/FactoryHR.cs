using Lab2_Sharp.Errors;
using System;

namespace Lab2.Model
{
    internal class FactoryHR : IFactoryHR
    {
        private const int SlavesPerMaster = 10;
        public FactoryHR(decimal incomePerSlave, decimal incomePerMaster, int quantityOfMasters, int quantityOfSlaves)
        {
            if (quantityOfMasters < 0 && quantityOfSlaves < 0)
            {
                throw new ArgumentException("quantity of employees are less or euqal than 0");
            }
            IncomePerSlave = incomePerSlave;
            IncomePerMaster = incomePerMaster;
            QuantityOfMasters = quantityOfMasters;
            QuantityOfSlaves = quantityOfSlaves;
        }

        public decimal IncomePerSlave { get; private set; }
        public decimal IncomePerMaster { get; private set; }
        public int QuantityOfMasters { get; private set; }
        public int QuantityOfSlaves { get; private set; }

        public void AddMaster()
        {
            QuantityOfMasters++;
        }

        public void AddSlave()
        {
            if (FindOutQuantityOfSlavesToHire() > 0)
            {
                QuantityOfSlaves++;
            }
        }

        public bool RemoveMaster()
        {
            if (QuantityOfMasters <= 0)
            {
                return false;
            }

            QuantityOfMasters--;
            return true;
        }

        public bool RemoveSlave()
        {
            if (QuantityOfSlaves <= 0)
            {
                return false;
            }

            QuantityOfSlaves--;
            return true;
        }

        public static FactoryHR operator +(FactoryHR a, FactoryHR b)
        {
            int totalQuantityOfSlaves = a.QuantityOfSlaves + b.QuantityOfSlaves, totalQuantityOfMasters = a.QuantityOfMasters + b.QuantityOfMasters;
            return new FactoryHR(
                (a.IncomePerSlave*a.QuantityOfSlaves + b.IncomePerSlave*b.QuantityOfSlaves) / totalQuantityOfSlaves, // avarege salary per slave
                (a.IncomePerMaster*a.QuantityOfMasters + b.IncomePerMaster*b.QuantityOfMasters) / totalQuantityOfMasters, // avarege salary per master
                totalQuantityOfMasters,
                totalQuantityOfSlaves
                );
        }

        private int FindOutQuantityOfSlavesToHire()
        {
            if (QuantityOfSlaves == 0)
            {
                return SlavesPerMaster;
            }

            if (QuantityOfMasters == 0)
            {
                throw new NeedsMastersToHireException("There is no masters to lead slaves!", (int)Math.Ceiling(QuantityOfSlaves*0.1));
            }
            int needsSlaves = QuantityOfMasters * SlavesPerMaster - QuantityOfSlaves;
            if (needsSlaves < 0)
            {
                throw new NeedsSlavesToHireException("Needs slaves to hire!", needsSlaves * -1);
            }
            return needsSlaves;
        }
        private int FindOutQuantityOfMastersToHire()
        {
            if (QuantityOfSlaves == 0)
            {
                throw new NeedsSlavesToHireException("There is no slaves to work!", SlavesPerMaster);
            }

            if (QuantityOfMasters == 0)
            {
                return (int)Math.Ceiling(QuantityOfSlaves*0.1);
            }

            int needsMasters = (int)Math.Ceiling((double)(QuantityOfSlaves - QuantityOfMasters * SlavesPerMaster) / SlavesPerMaster);
            if (needsMasters <= 0)
            {
                throw new NeedsSlavesToHireException("Needs slaves to hire!", needsMasters * -1);
            }

            return needsMasters;
        }
    }
}
