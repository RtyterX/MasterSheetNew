using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entitys
{
    internal class Script
    {
        public string name;
        public string description;
        public ConfigBlock[] configBlocks;
        public string scriptString;
        private string v1;
        private string v2;

        public Script(string Name, string Description)
        {
            name = Name;
            description = Description;
        }
    }
}
