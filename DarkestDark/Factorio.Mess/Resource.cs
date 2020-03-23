using System;
using System.Collections.Generic;
using System.Text;

namespace Factorio.Mess
{
    public abstract class Resource : NamedKey
    {
        public Resource(string name) : base(name) { }
    }
}
