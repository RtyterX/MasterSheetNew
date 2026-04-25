using MasterSheetNew.Entitys;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MasterSheetNew
{
    internal class ScriptHelper
    {
        // ---------------------------------------------------------------------------------------------------------------
        public string LogsExtras(RouterType routerType, List<Script> scriptList)
        {
            Debug.WriteLine("\r\n--> Getting Logs Parte 2 for Router Type: " + routerType);

            string scriptParte2 = string.Empty;

            if (routerType == RouterType.Cisco)
            {
                scriptParte2 = scriptList.Find(s => s.name == "Cisco-Logs-Parte2").scriptString;
            }
            else if (routerType == RouterType.HPE)
            {
                scriptParte2 = scriptList.Find(s => s.name == "HPE-Logs-Parte2").scriptString;
            }
            else if (routerType == RouterType.Huawei)
            {
                scriptParte2 = scriptList.Find(s => s.name == "Huawei-Logs-Parte2").scriptString;
            }
            else if (routerType == RouterType.Fortigate)
            {
                scriptParte2 = scriptList.Find(s => s.name == "Fortigate-Logs-Parte2").scriptString;
            }

            return scriptParte2;
        }


        // ---------------------------------------------------------------------------------------------------------------
        public string LogsLimpeza(RouterType routerType, ActivityType activityType, List<Script> scriptList)
        {
            Debug.WriteLine("\r\n--> Getting Logs Limpeza Script for Router Type: " + routerType + " and Activity Type: " + activityType);

            string scriptLimpeza = string.Empty;

            if (routerType == RouterType.Cisco)
            {
                if (activityType == ActivityType.BLD)
                {
                    scriptLimpeza = scriptList.Find(s => s.name == "Cisco-Logs-LimpezaBLD").scriptString;
                }
                else if (activityType == ActivityType.MPLS)
                {
                    scriptLimpeza = scriptList.Find(s => s.name == "Cisco-Logs-LimpezaMPLS").scriptString;
                }
                else if (activityType == ActivityType.VOZ)
                {
                    scriptLimpeza = scriptList.Find(s => s.name == "Cisco-Logs-LimpezaVOZ").scriptString;
                }
                else
                {
                    MessageBox.Show("Script de Limpeza não encontrado");
                }
            }
            else if (routerType == RouterType.HPE)
            {
                if (activityType == ActivityType.BLD)
                {
                    scriptLimpeza = scriptList.Find(s => s.name == "HPE-Logs-LimpezaBLD").scriptString;
                }
                else if (activityType == ActivityType.MPLS)
                {
                    scriptLimpeza = scriptList.Find(s => s.name == "HPE-Logs-LimpezaMPLS").scriptString;

                }
                else if (activityType == ActivityType.VOZ)
                {
                    scriptLimpeza = scriptList.Find(s => s.name == "HPE-Logs-LimpezaVOZ").scriptString;
                }
                else
                {
                    MessageBox.Show("Script de Limpeza não encontrado");
                }
            }
            else if (routerType == RouterType.Huawei)
            {
                if (activityType == ActivityType.BLD)
                {
                    scriptLimpeza = scriptList.Find(s => s.name == "Huawei-Logs-LimpezaBLD").scriptString;
                }
                else if (activityType == ActivityType.MPLS)
                {
                    scriptLimpeza = scriptList.Find(s => s.name == "Huawei-Logs-LimpezaMPLS").scriptString;
                }
                else
                {
                    MessageBox.Show("Script de Limpeza não encontrado");
                }
            }
            else
            {
                MessageBox.Show("Script de Limpeza não atribuido ao modelo: " + routerType);
            }

            return scriptLimpeza;
        }

        // ---------------------------------------------------------------------------------------------------------------
        public string ShowInterface(RouterType routerType, bool backboneOrNot, string routerInterface)
        {
            /////////////////////////
            ////// Need Rework //////
            /////////////////////////
            Debug.WriteLine("\r\n--> Show Port: " + routerType);

            string show = string.Empty;

            if (!backboneOrNot)
            {
                if (routerType == RouterType.Cisco)
                {
                    show = "show ip int brief\r\n";
                }
                else if (routerType == RouterType.HPE || routerType == RouterType.HPE_old || routerType == RouterType.Huawei)
                {
                    show = "display ip int brief\r\n";
                }
                else if (routerType == RouterType.Fortigate)
                {
                    show = "show system interface\r\n";
                }
            }
            else
            {
                if (routerType == RouterType.Cisco)
                {
                    show = "show ip route\r\n";
                }
                else if (routerType == RouterType.Nokia)
                {
                    show = "admin display-config | match " + routerInterface + " get all\r\n";
                }
            }

            return show;
        }


        // ---------------------------------------------------------------------------------------------------------------
        public string TelnetString(RouterType backboneType, ActivityType activityType, bool isXR, string ip, string sourcePE, string vrf)
        {
            string telnetCommand = string.Empty;

            // ---- MPLS ----
            if (activityType == ActivityType.MPLS)
            {
                if (ip != string.Empty && sourcePE != string.Empty && vrf != string.Empty)
                {
                    if (backboneType == RouterType.Cisco)
                    {
                        if (isXR == true)
                        {
                            telnetCommand = "telnet " + ip + " /vrf " + vrf + " /source " + sourcePE + "\r\n";
                        }
                        else
                        {
                            telnetCommand = "telnet vrf " + vrf + " " + ip + " source " + sourcePE + "\r\n";
                        }
                    }
                    else
                    {
                        telnetCommand = "telnet service-name " + vrf + " " + ip + "\r\n";
                    }
                }
                else
                {
                    MessageBox.Show("Telnet Falha: IP do CPE, Interace WAN ou VRF não preenchidas");
                }
            }
            else
            {
                if (ip != string.Empty && sourcePE != string.Empty)
                {
                    // ---- VOZ ----
                    if (activityType == ActivityType.VOZ)
                    {
                        if (backboneType == RouterType.Cisco)
                        {
                            if (isXR == true)
                            {
                                telnetCommand = "telnet " + ip + " /vrf REALIP_CLIENTE:5581 /source " + sourcePE + "\r\n";
                            }
                            else
                            {
                                telnetCommand = "telnet vrf REALIP_CLIENTE:5581 " + ip + " source " + sourcePE + "\r\n";
                            }
                        }
                        else
                        {
                            telnetCommand = "telnet service-name 1000 " + ip + "\r\n";
                        }
                    }
                    else // ---- BLD ----
                    {
                        if (backboneType == RouterType.Cisco)
                        {
                            if (isXR == true)
                            {
                                telnetCommand = "telnet " + ip + " /source " + sourcePE + "\r\n";
                            }
                            else
                            {
                                telnetCommand = "telnet " + ip + " source " + sourcePE + "\r\n";
                            }
                        }
                        else
                        {
                            telnetCommand = "telnet " + ip + "\r\n";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Telnet Falha: IP do CPE ou Interace WAN não preenchidas");
                }
            }
            // -----------------------------
            return telnetCommand;
        }

        public string GetTelnetUser(RouterType routerType)
        {
            string user = string.Empty;

            if (routerType == RouterType.Cisco)
            {
                user = "EBT\r\n" + "CQMR\r\n" + "EN\r\n" + "PRO1AN";
            }
            else if (routerType == RouterType.HPE)
            {
                user = "EBT\r\n" + "PRO1AN";
            }
            else if (routerType == RouterType.Huawei)
            {
                user = "EBT\r\n" + "PRO1AN@1";
            }
            else if (routerType == RouterType.Fortigate)
            {
                user = "EBT\r\n" + "PRO1AN\r\n" + "admin\r\n" + "PRO1AN";
            }
            else
            {
                MessageBox.Show("Usuário de Telnet não atribuido ao modelo: " + routerType);
            }

            return user;
        }

        public string TelnetCPE(RouterType backboneType, ActivityType activityType, bool isXR, string ip, string sourcePE, string vrf, RouterType routerType)
        {
            string user = string.Empty;

            return TelnetString(backboneType, activityType, isXR, ip, sourcePE, vrf) + "\r\n" + GetTelnetUser(routerType) + "\r\n\r\n\r\n\r\n\r\n\r\n";
        }

        public string TelnetWithTACACS(RouterType backboneType, ActivityType activityType, bool isXR, string ip, string sourcePE, string vrf, string userTacacs)
        {
            return TelnetString(backboneType, activityType, isXR, ip, sourcePE, vrf) + "\r\n" + userTacacs + "\r\n\r\n\r\n\r\n\r\n\r\n";
        }

        public string TelnetWorkAround(RouterType backboneType, ActivityType activityType, bool isXR, string ip, string sourcePE, string vrf, RouterType routerType, string userTacacs)
        {
            return TelnetString(backboneType, activityType, isXR, ip, sourcePE, vrf) + "\r\n" + GetTelnetUser(routerType) + "\r\n" + userTacacs + "\r\n\r\n\r\n\r\n\r\n\r\n";
        }

        // ---------------------------------------------------------------------------------------------------------------
        public string SSHString(RouterType backboneType, ActivityType activityType, bool isXR, string ip, string sourcePE, string vrf)
        {
            string sshCommand = string.Empty;

            // ---- MPLS ----
            if (activityType == ActivityType.MPLS)
            {
                if (ip != string.Empty && sourcePE != string.Empty && vrf != string.Empty)
                {
                    if (backboneType == RouterType.Cisco)
                    {
                        if (isXR == true)
                        {
                            sshCommand = "ssh " + ip + " /vrf " + vrf + " username EBT\r\n";
                        }
                        else
                        {
                            sshCommand = "ssh vrf " + vrf + " " + ip + " username EBT\r\n";
                        }
                    }
                    else
                    {
                        sshCommand = "ssh service-name " + vrf + " " + ip + " -l EBT\r\n";
                    }
                }
                else
                {
                    MessageBox.Show("SSH Falha: IP do CPE, Interace WAN ou VRF não preenchidas");
                }
            }
            else
            {
                if (ip != string.Empty && sourcePE != string.Empty)
                {
                    // ---- VOZ ----
                    if (activityType == ActivityType.VOZ)
                    {
                        if (backboneType == RouterType.Cisco)
                        {
                            if (isXR == true)
                            {
                                sshCommand = "ssh " + ip + " /vrf REALIP_CLIENTE:5581 username EBT\r\n";
                            }
                            else
                            {
                                sshCommand = "ssh vrf REALIP_CLIENTE:5581 " + ip + " username EBT\r\n";
                            }
                        }
                        else
                        {
                            sshCommand = "ssh service-name 1000 " + ip + " -l EBT\r\n";
                        }
                    }
                    else // ---- BLD ----
                    {
                        if (backboneType == RouterType.Cisco)
                        {
                            if (isXR == true)
                            {
                                sshCommand = "ssh " + ip + " username EBT\r\n";
                            }
                            else
                            {
                                sshCommand = "ssh " + ip + " username EBT\r\n";
                            }
                        }
                        else
                        {
                            sshCommand = "ssh " + ip + " -l EBT\r\n";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("SSH Falha: IP do CPE ou Interace WAN não preenchidas");
                }
            }
            // -----------------------------
            return sshCommand;
        }
    }
}
