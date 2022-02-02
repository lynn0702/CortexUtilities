using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CortexSceneTrait
    {
        public string Name { get; set; }
        public string Type { get; set; }

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
