using System.Collections.Generic;

namespace Data
{
    public class CortexGMC
    {
        public string Name { get; set; }

        public int CatalystDieSize { get; set; }

        public List<CortexTrait> Traits { get; set; }

        public List<CortexTrait> Distinctions { get; set; }

    }
}
