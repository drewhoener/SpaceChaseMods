using System;
using System.Collections.Generic;
using GenericModConfigMenu.ModOption;

namespace GenericModConfigMenu.Framework
{
    internal class ModConfigPage
    {
        public string Name { get; }
        public string DisplayName { get; set; }
        public List<Action<string, object>> ChangeHandler { get; } = new();
        public List<BaseModOption> Options { get; set; } = new();

        public ModConfigPage(string name)
        {
            this.Name = name;
            this.DisplayName = this.Name;
        }
    }
}
