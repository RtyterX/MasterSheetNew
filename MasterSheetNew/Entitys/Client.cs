using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entitys
{
    public enum Criticality
    {
        NotCritical,
        Critical,
    }
    public enum ClientType
    {
        Prod,
        Gov
    }


    internal class Client : Procedure
    {
        bool showOnScreen;
        public Criticality criticality;
        public ClientType clientType;
        public Steps steps;

    }
}
