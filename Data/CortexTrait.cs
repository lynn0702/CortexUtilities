using System.Collections.Generic;

namespace Data
{
    public class CortexTrait
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public string Subtype { get; set; }

        public string RelatedTo { get; set; }
        public int Rating { get; set; }

        public CortexTrait()
        {

        }

        public CortexTrait(IReadOnlyList<string> values)
        {
            Name = values[0] ;
            Type =  values[1];
            Subtype = values.Count >=3 ? values[2] : null;
            RelatedTo = values.Count >= 4 ? values[3] : null;
        }
    }
}
