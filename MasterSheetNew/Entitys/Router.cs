using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum RouterType
{
    Cisco,
    HPE,
    HPE_old,
    Huawei,
    Fortigate,
    Aligera,
    Digistar,
    Nokia
}

namespace WindowsFormsApp1.Entitys
{
    internal class Router
    {
        string name;
        string description;
        RouterType type;
        string IOS;
        int maxBandwidth;
        int withThroughput;
        bool hasThroughput;
    }
}
