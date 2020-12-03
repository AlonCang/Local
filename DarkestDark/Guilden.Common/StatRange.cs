using System;

namespace Guilden.Common
{
    public class StatRange
    {
        public Stats Base;
        public Stats Range;

        public Stats New(Random rng)
        {
            return Base + Range / (int)(9 * rng.NextDouble() + 1);
        }
    }
}
