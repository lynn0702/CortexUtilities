using System.Collections.Generic;

namespace Data
{
    public class CortexSceneTrait
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public int Rating { get; set; }

        public bool HasTrait { get; set; }

        public int TraitRating { get; set; }

        public string TraitName { get; set; }

        public bool HasAsset { get; set; }

        public int AssetRating { get; set; }

        public string AssetName { get; set; }


        public CortexSceneTrait()
        {

        }

        public CortexSceneTrait(IList<object> values)
        {
            Name = values[0].ToString();
            Type = values[1].ToString();
        }
    }
}
