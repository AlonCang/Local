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
        public List<string> Conditions;
        public List<string> Items;
        public string TargetName;
        
        public bool IsLegal(List<string> items)
        {
            if (Conditions != null)
            {
                foreach (var cond in Conditions)
                {
                    if (!items.Contains(cond))
                    {
                        return false;
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
