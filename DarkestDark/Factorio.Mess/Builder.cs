using System;
using System.Collections.Generic;
using System.Text;

namespace Factorio.Mess
{
    public class Builder
    {
        public Building BuildCoalDrill()
        {
            return new CoalDrill();
        }

        public Building BuildIronDrill()
        {
            return new IronDrill();
        }

        public Building BuildSmeltingFurnace()
        {
            return new Smelter();
        }
    }
}
