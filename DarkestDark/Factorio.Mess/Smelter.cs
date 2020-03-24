using System;
using System.Collections.Generic;
using System.Text;

namespace Factorio.Mess
{
    public class Smelter : Building
    {
        public Smelter() : base("Smelter") { }

        public Resource SmeltIron()
        {
            return new IronIngot();
        }
    }
}
