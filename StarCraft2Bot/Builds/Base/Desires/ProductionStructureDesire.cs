﻿using Sharky;
using System;

namespace StarCraft2Bot.Builds.Base.Desires
{
    public class ProductionStructureDesire : IDesire
    {
        public UnitTypes StructureType { get; private set; }
        public int Count { get; private set; }
        public MacroData Data { get; private set; }
        public bool Enforced { get; set; }

        public ProductionStructureDesire(UnitTypes structureType, int count, MacroData data)
        {
            StructureType = structureType;
            Count = count;
            Data = data;
        }

        public void Enforce()
        {
            if (Enforced)
                return;

            Data.DesiredProductionCounts[StructureType] = Count;            

            Enforced = true;
        }
    }
}