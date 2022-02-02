using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

    public class CortexScene
    {
        public string Title { get; set; }

        public string[] SettingTraits { get; set; }
        public int PoolDieSize { get; set; }
        public int PoolQuantity { get; set; }

        public int TraitCount { get; set; }

        public IList<CortexSceneTrait> SceneTraits { get; set; }




    }
}
