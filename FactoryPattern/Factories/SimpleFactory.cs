using FactoryPattern.Model.CPU;
using FactoryPattern.Model.GPU;
using FactoryPattern.Model.Monitors;

namespace FactoryPattern.Factories
{
    public class SimpleFactory
    {
        private static SimpleFactory instance = null;
        private static readonly object padlock = new object();

        public static SimpleFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SimpleFactory();
                        }
                    }
                }

                return instance;
            }
        }

        private SimpleFactory() { }

        public GPU CreateGPU(GPUType type)
        {
            switch (type)
            {
                case GPUType.GTX1060:
                    return new GTX1060();
                case GPUType.RadeonVII:
                    return new RadeonVII();
                case GPUType.RTX2080:
                    return new RTX2080();
                case GPUType.RX580:
                    return new RX580();
                default:
                    return null;
            }
        }

        public CPU CreateCPU(CPUType type)
        {
            switch (type)
            {
                default:
                    return null;
            }
        }

        public Monitor CreateMonitor(MonitorType type)
        {
            switch (type)
            {
                default:
                    return null;
            }
        }
    }
}
