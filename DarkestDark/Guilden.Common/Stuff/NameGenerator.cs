using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Guilden.Common.Stuff
{
    /// <summary>
    /// Disregard this plz
    /// </summary>
    public class StringGenerator
    {
        private static readonly Random _Random = new Random(0);

        public static Dictionary<string, StringGenerator> Generators { get; private set; }
            = new Dictionary<string, StringGenerator>();

        private readonly string[] _LetterGroups;
        private readonly string[] _SyllableCombinations;

        /// <summary>
        /// Creates and saves a generator with a name;
        /// Exmaple: 
        ///     Given the letter groups "ab" and "cd"
        ///     A combination of "01" would lead to one of "ac", "ad", "bc", "bd"
        ///     That is, one random letter from group 0 followed by one from group 1
        /// </summary>
        /// <param name="name">Name of the Generator Instance in the static Dictionary</param>
        /// <param name="letterGroups">Each entry is a group of characters in a string.</param>
        /// <param name="syllableCombinations">Legal combinations by index strings.</param>
        public StringGenerator(string name, string[] letterGroups, params string[] syllableCombinations)
        {
            _LetterGroups = letterGroups;
            _SyllableCombinations = syllableCombinations;
            Generators[name] = this;
        }

        public string GetName(int length)
        {
            var legend = _SyllableCombinations.RandomSequence(length, _Random);
            var name = legend
                .SelectMany(key =>
                    key.Select(c =>
                        _LetterGroups[int.Parse(c.ToString())].RandomElement(_Random)));
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(string.Join("", name));
        }

        public string GetName(int fromLength, int toLength)
        {
            int length = _Random.Next(fromLength, toLength + 1);
            return GetName(length);
        }
    }
}
