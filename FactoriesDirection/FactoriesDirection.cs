using Lab2.Model;
using System;
using System.Collections.Generic;

namespace Lb2_Sharp.FactoriesDirection
{
    internal class FactoriesDirection
    {
        private static FactoriesDirection instance;
        private static object syncRoot;
        private Dictionary<string, Factory> _factories;
        private FactoriesDirection()
        {
            _factories = new Dictionary<string, Factory>();
        }

        public int Size { get => _factories.Count; }
        public static FactoriesDirection GetInstance()
        {
            if (instance == null)
            {
                syncRoot = new object();
                lock (syncRoot)
                {
                    instance = new FactoriesDirection();
                }
            }
            return instance;
        }
        public bool AddFactory(Factory factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException("Factory is null");
            }

            if (_factories.ContainsKey(factory.Name))
            {
                return false;
            }

            _factories.Add(factory.Name, factory);
            return true;
        }

        public bool DeleteFactory(IFactory factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException("Factory is null");
            }

            if (!_factories.ContainsKey(factory.Name))
            {
                return false;
            }

            _factories.Remove(factory.Name);
            return true;
        }

        public Dictionary<string, Factory> GetAllFactories()
        {
            return _factories;
        }

        public Factory GetFactory(string name)
        {
            return _factories[name];
        }
    }
}
