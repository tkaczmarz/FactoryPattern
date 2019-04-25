using FactoryPattern.Factories;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (GPUType type in Enum.GetValues(typeof(GPUType)))
            {
                Console.WriteLine(SimpleFactory.Instance.CreateGPU(type).Benchmark());
            }

            foreach (CPUType type in Enum.GetValues(typeof(CPUType)))
            {
                Console.WriteLine(SimpleFactory.Instance.CreateCPU(type).Benchmark());
            }

            foreach (MonitorType type in Enum.GetValues(typeof(MonitorType)))
            {
                Console.WriteLine(SimpleFactory.Instance.CreateMonitor(type).GetSpecs());
            }

            Console.WriteLine("ABSTRACT:");
            Console.WriteLine(GamingFactory.Instance.CreateCPU().Benchmark());
            Console.WriteLine(GamingFactory.Instance.CreateGPU().Benchmark());
            Console.WriteLine(GamingFactory.Instance.CreateMonitor().GetSpecs());

            Console.ReadKey();
        }
    }
}
