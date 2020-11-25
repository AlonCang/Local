using System.Collections.Generic;

namespace Guilden.Common
{
    public record Assignment
    {
        public Dictionary<string, HashSet<string>> QuestChars = new();
    }
}
