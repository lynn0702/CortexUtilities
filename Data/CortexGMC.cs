﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
