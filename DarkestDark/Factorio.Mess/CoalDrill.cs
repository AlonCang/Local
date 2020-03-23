using System;
using System.Collections.Generic;
using System.Text;

namespace Factorio.Mess
{
    public class CoalDrill : Building
    {
        public CoalDrill() : base("Coal Drill") { }

        public Coal Mine()
        {
            return new Coal();
        }

        public int TotalMined()
        {
            var now = DateTime.Now;
            var timePassed = now - BuildTime;
            return (int)timePassed.TotalSeconds;
        }

        // HW: Implement a function that returns the amount mined since the last time the function was called.
        // Take into account the first time the func is called (what should happen then?)
        //public int MinedSoFar()
        //{
        //}
    }
}
