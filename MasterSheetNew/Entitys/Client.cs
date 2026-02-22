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


    public class Client
    {
        public string name;
        public bool showOnScreen;
        public Criticality criticality;
        public ClientType clientType;
        public List<Step> steps;

        public Client(string Name, bool ShowOnScreen, Criticality Criticality, ClientType ClientType, List<Step> Steps)
        {
            name = Name;
            showOnScreen = ShowOnScreen;
            criticality = Criticality;
            clientType = ClientType;
            steps = Steps;
        }

    }

}
