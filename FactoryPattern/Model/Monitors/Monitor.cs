namespace FactoryPattern.Model.Monitors
{
    public abstract class Monitor
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Resolution { get; set; }
        public int RefreshRate { get; set; }

        public string GetSpecs()
        {
            return string.Format("Specyfikacja monitora {0} {1}:\n Rozdzielczość: {2}\n Odświeżanie: {3}Hz", Make, Model, Resolution, RefreshRate);
        }
    }
}
