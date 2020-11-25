using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guilden.Common.Stuff
{
    /// <summary>
    /// Disregard this plz
    /// </summary>
    public static class IEnumerableRandomExtensions
    {
        public static TType RandomElement<TType>(this IEnumerable<TType> self, Random rng)
        {
            if (self == null || !self.Any())
            {
                return default;
            }
            return self.ElementAt(rng.Next(self.Count()));
        }

        public static TType RandomWeightedElement<TType>(this IEnumerable<TType> self, Random rng, double rate = 1 / 2d)
        {
            if (self == null || !self.Any())
            {
                return default;
            }
            return rng.NextDouble() < rate || self.Count() == 1 ? self.First() : self.Skip(1).RandomWeightedElement(rng, rate);
        }

        public static IEnumerable<TType> RandomSequence<TType>(this IEnumerable<TType> self, int length, Random rng)
        {
            while (length-- > 0)
            {
                yield return self.RandomElement(rng);
            }
        }
        public static IEnumerable<TType> RandomWeightedSequence<TType>(this IEnumerable<TType> self, int length, Random rng, double rate = 1 / 2d)
        {
            while (length-- > 0)
            {
                yield return self.RandomWeightedElement(rng, rate);
            }
        }
        public static IEnumerable<TType> Shuffled<TType>(this IEnumerable<TType> self, Random rng)
        {
            while (self.Any())
            {
                var x = self.RandomElement(rng);
                yield return x;
                self = self.Where(y => !y.Equals(x));
            }
        }
    }
}
