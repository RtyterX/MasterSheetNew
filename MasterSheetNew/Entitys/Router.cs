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

        public Router() 
        { 
            // Just for Start Class in Form1
        }

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

        public List<Router> GetRouterList()
        {
            List<Router> routerList = new List<Router>();

            // ------------------------ Cisco Voz ------------------------ 
            routerList.Add(new Router(RouterType.Cisco, "1905", "-", "c1900-universalk9-mz.SPA.152-4.M1.bin ou superior", 100, 60, 0, "IOS apenas para BROADSOFT"));
            routerList.Add(new Router(RouterType.Cisco, "2801", "-", "c2801-advipservicesk9-mz.151-4.M10.bin", 30, 20, 0, "(R2/ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "2811-2821", "-", "c2800nm-adventerprisek9-mz.151-4.M.bin", 0, 0, 0, "(R2/ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "2851", "-", "c2800nm-advipservicesk9-mz.151-4.M10.bin", 0, 0, 0, "(R2/ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "3825", "-", "c3825-advipservicesk9-mz.151-4.M10.bin", 0, 0, 0, "(R2/ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "3845", "-", "c3845-advipservicesk9-mz.151-4.M10.bin", 0, 0, 0, "(R2/ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "2901-2911-2921", "-", "c2900-universalk9-mz.SPA.156-1.T0a.bin", 0, 0, 0, "(R2/ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "2951", "-", "c2951-universalk9-mz.SPA.156-3.M8.bin", 0, 0, 0, "(R2/ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "3925 - 3945", "-", "c3900-universalk9-mz.SPA.151-4.M10.bin", 0, 0, 0, "(R2/ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "ISR4300", "-", "ISR4300 - UNIVERSALK9.17.06.03A.SPA.BIN", 0, 0, 0, "(R2 / ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "ISR4400", "-", "isr4400 - universalk9.03.16.04b.S.155 - 3.S4b - ext.SPA.bin", 0, 0, 0, "(R2 / ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "ISR1100", "-", "c1100 - universalk9.17.12.05a.SPA.bin", 0, 0, 0, "(R2 / ISDN)"));

            // ------------------------ Cisco Dados ------------------------ 
            routerList.Add(new Router(RouterType.Cisco, "C841", "c800m-universalk9-mz.SPA.159-3.M11.bin", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Cisco, "ISR 1111-4P", "c1100-universalk9.17.12.05a.SPA.bin", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Cisco, "ISR 4221", "isr4200-universalk9_ias.17.03.02.SPA.bin", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Cisco, "ISR 4321, 4331 e 4351", "isr4300-universalk9.17.12.05a.SPA.bin", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Cisco, "ISR 4451 e 4431", "isr4400-universalk9.17.12.05a.SPA.bin", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Cisco, "ASR 1001-X", "asr1001x-universalk9.17.09.07a.SPA.bin", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Cisco, "ASR 1001", "-", "-", 0, 0, 0, "-"));

            // ------------------------ Cisco Novos ------------------------ 
            routerList.Add(new Router(RouterType.Cisco, "Catalyst 8200L", "c8000be-universalk9.17.12.05a.SPA.bin", "c8000be-universalk9.17.12.05a.SPA.bin", 0, 0, 0, "(R2/ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "Catalyst 8300L", "c8000be-universalk9.17.12.05a.SPA.bin", "c8000be-universalk9.17.12.05a.SPA.bin", 0, 0, 0, "(R2/ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "Catalyst 8500L", "c8000aep-universalk9.17.12.06a.SPA.bin", "c8000aep-universalk9.17.12.05a.SPA.bin", 0, 0, 0, "(R2/ISDN)"));
            routerList.Add(new Router(RouterType.Cisco, "C921", "c900-universalk9-mz.SPA.159-3.M11", "c900-universalk9-mz.SPA.159-3.M11.bin", 0, 0, 0, "(R2/ISDN)"));


            // ------------------------ HPE ------------------------ 
            routerList.Add(new Router(RouterType.HPE, "MSR20-11", "-", "A_MSR201X-CMW520-R2514P14", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.HPE, "MSR30-10", "-", "A_MSR301X-CMW520-R2514P14-SI", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.HPE, "MSR30-20", "-", "A_MSR30-CMW520-R2516-SI", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.HPE, "MSR30-40", "-", "A_MSR30-CMW520-R2516-SI", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.HPE, "MSR30-60", "-", "A_MSR30-CMW520-R2516-SI", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.HPE, "MSR1002", "-", "MSR100X-CMW710-R0809P27.IPE", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.HPE, "MSR3012", "-", "MSR3000-CMW710-E0603.IPE", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.HPE, "MSR3044", "-", "MSR3000-CMW710-E0603.IPE", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.HPE, "MSR3064", "-", "MSR3000-CMW710-E0603.IPE", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.HPE, "MSR4080", "-", "MSR4000-CMW710-E0603.IPE", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.HPE, "HSR6602-XG", "-", "-", 0, 0, 0, "-"));



            // ------------------------ Aligera ------------------------ 
            routerList.Add(new Router(RouterType.Aligera, "AG561", "-", "8.10", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Aligera, "AG1600", "-", "4.57.40", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Aligera, "AG2000", "-", "4.57.40", 0, 0, 0, "-"));


            // ------------------------ Digistar ------------------------ 
            routerList.Add(new Router(RouterType.Digistar, "AG30", "-", "system_ag30plus_v1.12.img \n sip_ag30plus_v1.15.img \r\n xilinx_ag30plus_v2.5.img", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Digistar, "RCG5211", "-", "firmware_rcg5000_v1.16h_1dsp.img", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Digistar, "RCG5220", "-", "firmware_rcg5000_v1.16h_2dsp.img", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Digistar, "AG30_Plus_novo", "-", "firmware_ag30plus_v2.3b \r\n xilinx_ag30plus_v2.3", 0, 0, 0, "-"));


            // ------------------------ Fortigate ------------------------ 
            routerList.Add(new Router(RouterType.Fortigate, "Fortigate 40F", "v7.2.11.M-build1740 ou Superior", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Fortigate, "Fortigate 60F", "v7.2.11.M-build1740 ou Superior", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Fortigate, "Fortigate 100F", "v7.2.11.M-build1740 ou Superior", "-", 0, 0, 0, "-"));

            // ------------------------ Huawei ------------------------ 
            routerList.Add(new Router(RouterType.Huawei, "AR151", "V200R007C00SPC900", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Huawei, "AR160", "V200R007C00SPCb00", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Huawei, "AR6121", "V300R022C00SPC100", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Huawei, "AR650", "V300R024C00SPC100", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Huawei, "AR651", "V300R024C00SPC100", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Huawei, "AR1220", "V200R007SPH008", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Huawei, "AR6280", "V300R019C00SPC300", "-", 0, 0, 0, "-"));
            routerList.Add(new Router(RouterType.Huawei, "AR5710", "V600R024C00SPC100", "-", 0, 0, 0, "-"));

            return routerList; ;
        }
    }
}
