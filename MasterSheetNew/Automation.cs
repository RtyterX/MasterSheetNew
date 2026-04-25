using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterSheetNew
{
    internal class Automation
    {

        public ScriptHelper ScriptHelper = new ScriptHelper();

        // -------------------------------------------------------------------------------

        //////////////////////////////////////////////////
        ////////////////// FUNCTIONS /////////////////////
        //////////////////////////////////////////////////

        // -----------------------------------------------
        // Open PE
        // -----------------------------------------------
        #region
        public void OpenPE(string pe, string userPE, string puttyPath)
        {
            Debug.WriteLine("\r\n--> Opening PE...");

            // Block if PE User is empty
            if (userPE == "" || userPE == string.Empty)
            {
                MessageBox.Show("Usuário e senha do PE não configurados. Acesse as Preferências para configurar.");
                // return;
            }

            try
            {
                Process p = Process.Start(puttyPath);

                Thread.Sleep(200);

                // Colando nome do PE
                Clipboard.SetText(pe);
                SendKeys.Send("^v");
                SendKeys.SendWait("{ENTER}");

                Thread.Sleep(800);

                // Colando Senha para acessar o CPE
                Clipboard.SetText(userPE);

                SendKeys.SendWait("+{INSERT}");

                Debug.WriteLine("\r\n... PE Opened!");

                Clipboard.SetText("\r\n \r\n \r\n \r\n \r\n \r\n \r\n###################################################\r\n \r\n \r\n \r\n \r\n \r\n \r\n\r\n \r\n \r\n \r\n \r\n \r\n \r\n");
                SendKeys.SendWait("+{INSERT}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\r\n Error: \r\n" + ex.Message);
                MessageBox.Show("Falha ao Abrir o PE. Erro: --> " + ex.Message);
            }
        }
        #endregion

        // -----------------------------------------------
        // Acesso CPE via Telnet
        // -----------------------------------------------
        #region
        public void OpenWithTelnet(string pe, string userPE, string puttyPath, RouterType peType, RouterType routerType, ActivityType activityType, bool isXR, string ip, string source, string vrf)
        {
            try
            {
                OpenPE(pe, userPE, puttyPath);

                Thread.Sleep(300);

                Clipboard.SetText(ScriptHelper.TelnetWorkAround(peType, activityType, isXR, ip, source, vrf, routerType, Properties.Settings.Default.userTacacs));
                SendKeys.SendWait("+{INSERT}");

                if (routerType == RouterType.HPE || routerType == RouterType.HPE_old)
                {
                    Thread.Sleep(300);
                    Clipboard.SetText("PRO1AN\r\n");
                    SendKeys.SendWait("+{INSERT}");
                }

                Clipboard.SetText("\r\n \r\n \r\n \r\n \r\n \r\n \r\n\r\n \r\n \r\n \r\n \r\n \r\n \r\n");
                SendKeys.SendWait("+{INSERT}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\r\n Error: \r\n" + ex.Message);
                MessageBox.Show("Falha ao Abrir o PE. Erro: --> " + ex.Message);
            }
        }
        #endregion

        // -----------------------------------------------
        // Coleta de Logs PE
        // -----------------------------------------------
        #region
        public void LogsPE(bool finalsOrNot, string pe, string userPE, string puttyPath, string scriptPE)
        {
            OpenPE(pe, userPE, puttyPath);

            Thread.Sleep(300);

            if (finalsOrNot)
            {
                scriptPE = scriptPE.Replace("switchLog", "FINAIS");
            }
            else
            {
                scriptPE = scriptPE.Replace("switchLog", "INICIAIS");
            }

            Clipboard.SetText(scriptPE);
            SendKeys.SendWait("+{INSERT}");
        }
        #endregion

        // -----------------------------------------------
        // Coleta de Logs CPE
        // -----------------------------------------------
        #region
        public void LogsCPE(bool finalsOrNot, RouterType peType, RouterType routerType, ActivityType activityType, bool isXR, string ip, string source, string vrf, string pe, string userPE, string puttyPath, string scriptCPE)
        {
            OpenWithTelnet(pe, userPE, puttyPath, peType, routerType, activityType, isXR, ip, source, vrf);

            Thread.Sleep(500);

            if (finalsOrNot)
            {
                scriptCPE = scriptCPE.Replace("switchLog", "FINAIS");
            }
            else
            {
                scriptCPE = scriptCPE.Replace("switchLog", "INICIAIS");
            }

            Clipboard.SetText(scriptCPE + "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            SendKeys.SendWait("+{INSERT}");
        }
        #endregion

        // -----------------------------------------------
        // Coleta Completa de Logs - PE e CPE
        // -----------------------------------------------
        #region
        public void LogsComplete(bool finalsOrNot, RouterType peType, RouterType routerType, ActivityType activityType, bool isXR, string ip, string source, string vrf, string pe, string userPE, string puttyPath, string scriptPE, string scriptCPE)
        {
            LogsPE(finalsOrNot, pe, userPE, puttyPath, scriptPE);

            Thread.Sleep(10000);

            Clipboard.SetText("\r\n \r\n \r\n \r\n \r\n \r\n \r\n###################################################\r\n \r\n \r\n \r\n \r\n \r\n \r\n\r\n \r\n \r\n \r\n \r\n \r\n \r\n");
            SendKeys.SendWait("+{INSERT}");

            Clipboard.SetText(ScriptHelper.TelnetWorkAround(peType, activityType, isXR, ip, source, vrf, routerType, Properties.Settings.Default.userTacacs));
            SendKeys.SendWait("+{INSERT}");

            if (routerType == RouterType.HPE || routerType == RouterType.HPE_old)
            {
                Thread.Sleep(300);
                Clipboard.SetText("PRO1AN\r\n");
                SendKeys.SendWait("+{INSERT}");
            }

            Clipboard.SetText("\r\n \r\n \r\n \r\n \r\n \r\n \r\n\r\n \r\n \r\n \r\n \r\n \r\n \r\n");
            SendKeys.SendWait("+{INSERT}");

            Thread.Sleep(1000);

            Clipboard.SetText(scriptCPE + "\r\n\r\n\r\n");
            SendKeys.SendWait("+{INSERT}");
        }
        #endregion

    }
}
