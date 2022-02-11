namespace Data
{
    public class CortexTrait
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public string Subtype { get; set; }
        public int Rating { get; set; }

        public CortexTrait()
        {

        }

        public CortexTrait(string[] values)
        {
            Name = values[0];
            Type = values[1];
            Subtype = values[2];
        }
    }
}
