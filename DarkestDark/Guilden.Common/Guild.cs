using System;
using System.Collections.Generic;
using System.Text;

namespace Guilden.Common
{
    public class Guild
    {
        public string Name;
        public int Gold;
        public HashSet<string> Chars = new HashSet<string>();
        public HashSet<string> Items = new HashSet<string>();
        public Dictionary<string, HashSet<string>> Kits = new Dictionary<string, HashSet<string>>();
    }
}
