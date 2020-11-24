using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Guilden.Common
{
    public record Stats
    {
        public int Life;
        public int Damage;
        public int Support;
        public int Utility;
    }

    public record Quest
    {

    }

    public class ItemLibrary
    {
        public Dictionary<string, Stats> Stats = new();
        public Dictionary<string, HashSet<Guid>> Instances = new();

        public Guid Instantiate(string itemKey)
        {
            var guid = Guid.NewGuid();
            if (!Instances.ContainsKey(itemKey))
            {
                Instances[itemKey] = new();
            }
            Instances[itemKey].Add(guid);
            return guid;
        }

        public Stats Get(Guid guid) => 
            Stats[Instances.Single(kvp => kvp.Value.Contains(guid)).Key];
    }

    public class AdventurerLibrary
    {
        public Dictionary<string, Stats> Stats = new();
    }
}
