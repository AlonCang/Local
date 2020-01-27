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
        public Dictionary<string, bool> Requirements;
        public Dictionary<string, bool> Scenes;
        public string TargetName;

        public bool IsLegal(Dictionary<string, int> items)
        {
            if (Conditions != null)
            {
                foreach (var cond in Conditions)
                {
                    if (!items.ContainsKey(cond.Key))
                    {
                        return false;
                    }
                    return items[cond.Key] >= cond.Value;
                }
            }
            return true;
        }

        /// <summary>
        /// I want to make bool that checks if a scene has been complete, then prints a different text.
        /// Im not sre about this one. At 1st glance i think i can just use the "IsLegal" bool to achieve this.
        /// Then again im not sure its constructed to allow for this.
        /// Since it prints a different text for the same data member.
        /// So... Not only does it need to check for a condition, it also replaces the state value returned.
        /// </summary>
        /// <returns></returns>
        public bool IsComplete(Dictionary<string, int> sceneComplete)
        {
            if (sceneComplete.Value == true)
            {
                foreach (var scene in Scenes)
                {
                    if (Requirements.ContainsKey(scene.Value == true))
                    {
                        return true;
                    }
                    return false;
                }
            }
            // I dont fucking know how to set this up. It seemed simple, but too many things are involved. HALP!!
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
