namespace FactoryPattern.Model.GPU
{
    public abstract class GPU
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int CoreSpeed { get; set; }
        public int Memory { get; set; }

        public string Benchmark()
        {
            return string.Format("Karta graficzna {0} {1} osiągnęła {2} punktów w teście.", Make, Model, CoreSpeed * Memory);
        }
    }
}
