using System;
using System.Collections.Immutable;
using System.Linq;

namespace Guilden.Common
{
    public class Quest
    {
        public Stats Stats;
        public StatRange ItemRewardRange;
        public StatRange CharRewardRange;
        public int GoldReward;
    }
}
