using System;
using System.Collections.Generic;
using System.Text;

namespace Factorio.Mess
{
    public abstract class NamedKey
    {
        public string Name;
        public NamedKey(string name)
        {
            this.Name = name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is NamedKey nk)
            {
                return Name.Equals(nk.Name);
            }
            return false;
        }
    }
}
