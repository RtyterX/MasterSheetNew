using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterSheetNew.Entitys;

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
        public string TelnetString(RouterType routerType, ActivityType activityType, ComboBox isXR, string ip, string sourcePE, string vrf)
        {
            string telnetCommand = string.Empty;

            // ---- MPLS ----
            if (activityType == ActivityType.MPLS)
            {
                if (ip != string.Empty && sourcePE != string.Empty && vrf != string.Empty)
                {
                    if (routerType == RouterType.Cisco)
                    {
                        if (isXR.SelectedIndex == 0)
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
                    MessageBox.Show("IP do CPE, Interace WAN ou VRF não preenchidas");
                }
            }
            else
            {
                if (ip != string.Empty && sourcePE != string.Empty)
                {
                    // ---- VOZ ----
                    if (activityType == ActivityType.VOZ)
                    {
                        if (routerType == RouterType.Cisco)
                        {
                            if (isXR.SelectedIndex == 0)
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
                        if (routerType == RouterType.Cisco)
                        {
                            if (isXR.SelectedIndex == 0)
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
                    MessageBox.Show("IP do CPE ou Interace WAN não preenchidas");
                }
            }
            // -----------------------------
            return telnetCommand;
        }
    }
}
