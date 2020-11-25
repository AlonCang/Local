using System.Collections.Generic;

namespace Guilden.Common
{
    public class AssetLibrary
    {
        public Dictionary<string, Stats> Items = new();
        public Dictionary<string, Stats> Chars = new();
        public Dictionary<string, Quest> Quests = new();
    }

}
