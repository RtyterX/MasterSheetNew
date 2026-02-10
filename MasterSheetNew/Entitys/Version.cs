using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entitys
{
    internal class Version
    {
        public string name;
        public string description;
        public DateTime createDate;

        public Version(string name, string description, DateTime createDate)
        {
            this.name = name;
            this.description = description;
            this.createDate = createDate;
        }
    }
}
