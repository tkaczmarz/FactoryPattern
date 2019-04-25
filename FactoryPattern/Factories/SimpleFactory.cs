﻿using FactoryPattern.Model.CPU;
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
                case CPUType.Core_i5:
                    return new Core_i5();
                case CPUType.Core_i7:
                    return new Core_i7();
                case CPUType.Ryzen3:
                    return new Ryzen3();
                case CPUType.Ryzen7:
                    return new Ryzen7();
                default:
                    return null;
            }
        }

        public Monitor CreateMonitor(MonitorType type)
        {
            switch (type)
            {
                case MonitorType.Acer:
                    return new Acer();
                case MonitorType.AOC:
                    return new AOC();
                case MonitorType.Asus:
                    return new Asus();
                case MonitorType.Dell:
                    return new Dell();
                default:
                    return null;
            }
        }
    }
}
