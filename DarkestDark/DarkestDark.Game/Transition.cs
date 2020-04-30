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

        public bool Any(bool[] bools)
        {
            foreach (var b in bools)
            {
                if (b)
                {
                    return true;
                }
            }
            return false;
        }
        public bool All(bool[] bools)
        {
            foreach (var b in bools)
            {
                if (!b)
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsLegal(Dictionary<string, int> items)
        {
            if (Conditions != null)
            {
                foreach (var cond in Conditions)
                {
                    if (cond.Key.Contains('~'))
                    {
                        var key = cond.Key.Substring(1);
                        if (items.ContainsKey(key))
                        {
                            if (items[key] >= cond.Value)
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        if (!items.ContainsKey(cond.Key))
                        {
                            return false; 
                        }
                        if (items[cond.Key] < cond.Value)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
