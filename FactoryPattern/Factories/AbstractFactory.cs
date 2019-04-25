using FactoryPattern.Model;
using FactoryPattern.Model.CPU;
using FactoryPattern.Model.GPU;
using FactoryPattern.Model.Monitors;

namespace FactoryPattern.Factories
{
    public interface IAbstractFactory
    {
        CPU CreateCPU();
        GPU CreateGPU();
        Monitor CreateMonitor();
    }

    public class GamingFactory : IAbstractFactory
    {
        private static GamingFactory instance = null;
        private static readonly object padlock = new object();

        public static GamingFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new GamingFactory();
                        }
                    }
                }

                return instance;
            }
        }

        private GamingFactory() { }

        public CPU CreateCPU()
        {
            return new Core_i7();
        }

        public GPU CreateGPU()
        {
            return new RTX2080();
        }

        public Monitor CreateMonitor()
        {
            return new Asus();
        }
    }
}
