using System.Collections.Generic;

namespace Foundation.Data
{
    public class TowerData
    {
        public readonly string Name;

        public readonly int Index;

        public readonly ComponentData[] Components;

        public TowerData(string name, int index, ComponentData[] components)
        {
            Name = name;
            Index = index;
            Components = components;
        }
    }
}