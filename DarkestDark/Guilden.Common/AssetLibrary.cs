using System.Collections.Generic;

namespace Guilden.Common
{
    public class AssetLibrary
    {
        public Dictionary<string, Stats> Items =  new Dictionary<string, Stats>();
        public Dictionary<string, Stats> Chars =  new Dictionary<string, Stats>();
        public Dictionary<string, Quest> Quests = new Dictionary<string, Quest>();
    }

}
