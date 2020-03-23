using System;
using System.Collections.Generic;
using System.Text;

namespace Factorio.Mess
{
    public class Miner
    {
        public Resource MineCoal()
        {
            return new Coal();
        }

        public Resource MineIron()
        {
            return new Iron();
        }
    }
}
