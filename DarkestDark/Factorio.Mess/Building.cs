using System;
using System.Collections.Generic;
using System.Text;

namespace Factorio.Mess
{
    public abstract class Building : NamedKey
    {
        public DateTime BuildTime;

        public Building(string name) : base(name)
        {
            BuildTime = DateTime.Now;
        }
    }
}
