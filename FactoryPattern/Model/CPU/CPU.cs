namespace FactoryPattern.Model.CPU
{
    public abstract class CPU
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Clock { get; set; }
        public int Cores { get; set; }

        public string Benchmark()
        {
            return string.Format("Procesor {0} {1} osiągnął {2} punktów w teście.", Make, Model, Clock * Cores);
        }
    }
}
