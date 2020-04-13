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
                            return true;
                        }
                        return items[key] < cond.Value;
                    }
                    else
                    {
                        if (!items.ContainsKey(cond.Key))
                        {
                            return false;
                        }
                        return items[cond.Key] >= cond.Value;
                    }                    
                }
            }
            return true;
        }

        public override string ToString()
        {
            return "{" + $"\"Name\": \"{Name}\", " +
                $"\"Text\": \"{Text}\", " +
                $"\"Items\": [\"{string.Join(", ", Items)}\"], " +
                $"\"TargetName\": \"{TargetName}\"" + "}";
        }
    }
}
