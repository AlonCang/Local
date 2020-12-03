namespace Guilden.Common
{
    public class Stats
    {
        public int Life;
        public int Damage;
        public int Support;
        public int Utility;

        public static Stats operator +(Stats a, Stats b) => new Stats
        {
            Life = a.Life + b.Life,
            Damage = a.Damage + b.Damage,
            Support = a.Support + b.Support,
            Utility = a.Utility + b.Utility,
        };

        public static Stats operator -(Stats a, Stats b) => new Stats
        {
            Life = a.Life - b.Life,
            Damage = a.Damage - b.Damage,
            Support = a.Support - b.Support,
            Utility = a.Utility - b.Utility,
        };

        public static Stats operator *(Stats a, int c) => new Stats
        {
            Life = a.Life * c,
            Damage = a.Damage * c,
            Support = a.Support * c,
            Utility = a.Utility * c,
        };

        public static Stats operator /(Stats a, int c) => new Stats
        {
            Life = a.Life / c,
            Damage = a.Damage / c,
            Support = a.Support / c,
            Utility = a.Utility / c,
        };
    }
}
