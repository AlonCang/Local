using System;
using System.Collections.Generic;
using System.Text;

namespace Factorio.Mess
{
    public class IronDrill : Building
    {
        public IronDrill() : base("Iron Drill") { }

        public Iron Mine()
        {
            return new Iron();
        }
    }
}
