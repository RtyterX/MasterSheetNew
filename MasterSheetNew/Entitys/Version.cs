using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entitys
{
    internal class Version
    {
        public string Versao { get; set; }
        public string Descricao { get; set; }
        public DateTime CreateDate { get; set; }

        public Version(string name, string description, DateTime createDate)
        {
            Versao = name;
            Descricao = description;
            CreateDate = createDate;
        }
    }
}
