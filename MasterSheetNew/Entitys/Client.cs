using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entitys
{
    public class Client
    {
        public string name;
        public bool showOnScreen;
        public bool criticality;
        public List<Step> steps;

        public Client(string Name, bool ShowOnScreen, bool Criticality, List<Step> Steps)
        {
            name = Name;
            showOnScreen = ShowOnScreen;
            criticality = Criticality;
            steps = Steps;
        }

    }

}
