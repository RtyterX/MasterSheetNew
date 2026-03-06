using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ActivityType
{
    BLD,
    BLDcomBGP,
    MPLS,
    VOZ,
    SDWAN,
    Backbone
}

public enum ProcedureType
{
    Config,
    Logs
}

namespace WindowsFormsApp1.Entitys
{
    internal class Procedure
    {
        public string name;
        public string description;
        public ActivityType type;
        public Script script;
    }
}
