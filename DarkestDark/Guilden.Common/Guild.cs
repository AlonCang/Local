using System;
using System.Collections.Generic;
using System.Text;

namespace Guilden.Common
{
    public record Guild
    {
        public string Name;
        public int Gold;
        public HashSet<string> Chars = new();
        public HashSet<string> Items = new();
        public Dictionary<string, HashSet<string>> Kits = new();
    }
}
