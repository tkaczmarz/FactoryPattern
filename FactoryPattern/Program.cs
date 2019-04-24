using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Factories;

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

            Console.ReadKey();
        }
    }
}
