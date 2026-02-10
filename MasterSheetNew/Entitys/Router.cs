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
    Nokia,
    Velocloud
}

namespace WindowsFormsApp1.Entitys
{
    internal class Router
    {
        public RouterType Fabricante { get; set; }
        public string Modelo { get; set; }
        public string IOS_Dados { get; set; }
        public string IOS_Voz { get; set; }
        public int Max_Bandwidth { get; set; }
        public int Firewall_Bandwidth { get; set; }
        public int Licença_Boost { get; set; }
        public string Obsercaçao { get; set; }


        public Router(RouterType Fabricante, string Modelo, string IOS_Dados, string IOS_Voz, int Max_Bandwidth, int Firewall_Bandwidth, int Licença_Boost, string Obsercaçao)
        {
            this.Fabricante = Fabricante;
            this.Modelo = Modelo;
            this.IOS_Dados = IOS_Dados;
            this.IOS_Voz = IOS_Voz;
            this.Max_Bandwidth = Max_Bandwidth;
            this.Firewall_Bandwidth = Firewall_Bandwidth;
            this.Licença_Boost = Licença_Boost;
            this.Obsercaçao = Obsercaçao;
        }
    }
}
