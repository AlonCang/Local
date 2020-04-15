using System;
using System.Collections.Generic;
using System.Text;

namespace DarkestDark.Game
{
    /// <summary>
    /// Transition represents Edges of the State Graph.
    /// </summary>
    public class Transition
    {
        public string Name;
        public string Text;
        public Dictionary<string, int> Conditions;
        public Dictionary<string, int> Items;
        public string TargetName;

        public bool IsLegal(Dictionary<string, int> items)
        {
            if (Conditions != null)
            {
                foreach (var cond in Conditions)
                {
                    if (cond.Key.Contains('~'))
                    {
                        var key = cond.Key.Substring(1);
                        if (!items.ContainsKey(key))
                        {
                            return true; //Meaning: Yes you have NOT aquired this item to satisfy condition.
                        }
                        return items[key] < cond.Value; //Meaning: If this returns 'false' then YES you have enough of this item
                    }
                    else
                    {
                        if (!items.ContainsKey(cond.Key))
                        {
                            return false; //Meaning: If you do not have this item return false.
                        }
                        return items[cond.Key] >= cond.Value; //Meaning: If you have enough of this item to satisfy condition return true.
                    }                    
                }
            }
            return true;
        }
    }
}
