﻿namespace PboExplorer
{
    internal class PropertyItem
    {
        public PropertyItem(string name, string value)
        {
            Name = name;
            Value = value;
        }
        public string Name { get; }

        public string Value { get; }
    }
}