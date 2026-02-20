using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterSheetNew
{
    public partial class FormVoiceDebug : Form
    {
        public FormVoiceDebug()
        {
            InitializeComponent();
            DebugText();
        }

        public void DebugText()
        {
            Debug_TextBox.Text = "                 ************************\r\n" +
"                           HPE           \r\n" +
"                 ************************\r\n" +
"\r\n" +
"###############\r\n" +
"   DEBUG HP    \r\n" +
"###############\r\n" +
"\r\n" +
"- DEBUG ISDN -\r\n" +
"DEBUG VOICE SIP message\r\n" +
"debug isdn\r\n" +
"terminal monitor\r\n" +
"terminal debugging\r\n" +
"\r\n" +
"----------\r\n" +
"\r\n" +
"- DEBUG R2 -\r\n" +
"debug voice R2 ALL\r\n" +
"debugging voice r2 event\r\n" +
"terminal monitor\r\n" +
"terminal debugging\r\n" +
"\r\n" +
"----------\r\n" +
"\r\n" +
"- DEBUG SIP -\r\n" +
"DEBUG VOICE SIP message\r\n" +
"terminal monitor\r\n" +
"terminal debugging\r\n" +
"\r\n" +
"----------\r\n" +
"\r\n" +
"- Desabilitar DEBUG -\r\n" +
"undo DEBUG VOICE SIP message\r\n" +
"undo terminal monitor\r\n" +
"undo terminal debugging\r\n" +
"\r\n" +
"*********************************************\r\n" +
"                 ************************\r\n" +
"                           CISCO         \r\n" +
"                 ************************\r\n" +
"\r\n" +
"#############\r\n" +
"DEBUG CISCO\r\n" +
"#############\r\n" +
"!DEBUG SIP\r\n" +
"terminal monitor\r\n" +
"debug ccsip messages\r\n" +
"debug voice ccapi inout\r\n" +
"debug translation detail\r\n" +
"!\r\n" +
"----------\r\n" +
"\r\n" +
"terminal monitor\r\n" +
"debug ccsip messages\r\n" +
"- Habilita visualização das dial-peers (entrada e saída)\r\n" +
"terminal no monitor\r\n" +
"no debug ccsip messages\r\n" +
"no debug voice ccapi inout\r\n" +
"no debug translation detail\r\n" +
"\r\n" +
"----------\r\n" +
"\r\n" +
"-DEBUG R2 CISCO-\r\n" +
"terminal monitor\r\n" +
"debug ccsip messages\r\n" +
"debug vpm signal\r\n" +
"\r\n" +
"----------\r\n" +
"\r\n" +
"-DESATIVA O DEBUG CISCO-\r\n" +
"terminal no monitor\r\n" +
"no debug ccsip messages\r\n" +
"no debug vpm signal\r\n" +
"\r\n" +
"----------\r\n" +
"\r\n" +
"**Ver se está registrado\r\n" +
"sh sip register status\r\n" +
"sh sip-ua register status\r\n" +
"\r\n" +
"----------\r\n" +
"\r\n" +
"sh dial-peer voice sum\r\n" +
"\r\n" +
"**************Habilitar E1/T1\r\n" +
"#\r\n" +
"card type e1 0 2\r\n" +
"Placa de voz -> PVDM (Memoria para suportar a placa E1, PVDM 32 para 30 channels.\r\n" +
"Forçar chamada placa FXS, FXO\r\n" +
"CSIM START <número a ser discado>\r\n" +
"\r\n" +
"==================================================\r\n" +
"                 ************************\r\n" +
"                          ALIGERA        \r\n" +
"                 ************************\r\n" +
"\r\n" +
"################\r\n" +
"DEBUG ALIGERA\r\n" +
"################\r\n" +
"\r\n" +
"DEBUG - com sip\r\n" +
"debug\r\n" +
"core set debug 5\r\n" +
"core set verbose 5\r\n" +
"sip set debug on\r\n" +
"\r\n" +
"----------\r\n" +
"\r\n" +
"-Debug SIP-\r\n" +
"debug vip sip on\r\n" +
"\r\n" +
"----------\r\n" +
"\r\n" +
"-Debug R2-\r\n" +
"debug\r\n" +
"core set debug 5\r\n" +
"core set verbose 5\r\n" +
"mfcr2 set debug all\r\n" +
"debug mfcr2 on\r\n" +
"\r\n" +
"----------\r\n" +
"\r\n" +
"-Debug ISDN-\r\n" +
"debug\r\n" +
"core set debug 5\r\n" +
"core set verbose 5\r\n" +
"pri set debug on span 1\r\n" +
"\r\n" +
"==================================================\r\n" +
"                 ************************\r\n" +
"                        Digistar\r\n" +
"                 ************************\r\n" +
"\r\n" +
"################\r\n" +
"DEBUG DIGISTAR\r\n" +
"################\r\n" +
"\r\n" +
"!DEBUG SIP\r\n" +
"terminal monitor\r\n" +
"!\r\n" +
"conf t\r\n" +
"logging on\r\n" +
"debug pbx loglevel 5\r\n" +
"debug sip loglevel 5\r\n" +
"!\r\n" +
"end\r\n" +
"\r\n" +
"- Desabilitar DEBUG -\r\n" +
"terminal no monitor\r\n" +
"configure terminal\r\n" +
"no debug pbx loglevel\r\n" +
"no debug sip loglevel\r\n" +
"!\r\n" +
"\r\n" +
"############\r\n" +
"E1 ALINHADA\r\n" +
"############\r\n" +
"show pbx digital-line status\r\n";
        }
    }


}
