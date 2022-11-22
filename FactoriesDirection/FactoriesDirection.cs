using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2_Sharp.FactoriesDirection
{
    internal class FactoriesDirection
    {
        private static FactoriesDirection instance;
        private static object syncRoot = new Object();
        private Dictionary<string, Factory> _factories;
        private FactoriesDirection()
        {
            _factories = new Dictionary<string, Factory>();
        }

        public static FactoriesDirection GetInstance()
        {
            if (instance == null)
            {
                lock(syncRoot)
                {
                    instance = new FactoriesDirection();
                }
            }
            return instance;
        }
        public bool AddFactory()
        {

        }
    }
}
