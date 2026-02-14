using Microsoft.Win32;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Session;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Entitys;
using static Org.BouncyCastle.Math.EC.ECCurve;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace MasterSheetNew
{
    public partial class Form1 : Form
    {
        // Theme
        bool nightMode;

        // Config Script 
        RouterType routerType;
        ActivityType activityType;
        bool backboneOrNot;
        bool logOrNot;
        bool finalsOrNot;
        string logType;
        string designacao;

        // Config Strings
        string loopbackCliente;
        string withVlan;
        string vlanNaWAN;
        string sourceLan;
        string mascaraStr;

        // Router List
        List<Router> routerList = new List<Router>();

        // Log Tools
        string suporteTitle;
        string commandStr;
        string fechamentoSubInfo;
        string pendenciaRestore;
        IPCalculator ipCalculator = new IPCalculator();

        // Log de Ligacao
        string ligacaoRestore;

        // Enable Edit
        public bool enableEdit { get; set; } = false;


        // --- Scripts ---
        List<Script> scripts = new List<Script>();
        List<Label> varName = new List<Label>();
        List<TextBox> varText = new List<TextBox>();
        List<Button> varDelete = new List<Button>();
        List<Label> varEx = new List<Label>();

        string scriptPrincipal;

        // BLD
        string ciscoBLD;
        string hpeBLD;
        string fortigateBLD;
        string huaweiBLD;
        // MPLS 
        string ciscoMPLS;
        string hpeMPLS;
        string fortigateMPLS;
        string huaweiMPLS;
        // VOZ
        string ciscoVOZR2;
        string ciscoPABXIP;
        string hpeVOZR2;
        string hpePABXIP;
        string aligera561;
        string aligera1600;
        string digistarVOZ;
        // LOGS 
        string ciscoBLDLogs;
        string ciscoMPLSLogs;
        string ciscoR2Logs;
        string ciscoPABXLogs;
        string hpeBLDLogs;
        string hpeMPLSLogs;
        string hpeR2Logs;
        string hpePABXLogs;
        string huaweiBLDLogs;
        string huaweiMPLSLogs;
        string foritgateBLDLogs;
        string foritgateMPLSLogs;
        string aligeraLogs;
        string digistarLogs;
        // ----
        string scriptParte2;
        string scriptLimpeza;
        // WizGat
        string wizgatCiscoBLD;
        string wizgatCiscoMPLS;
        string wizgatCiscoVOZ;
        string wizgatCiscoBGP;
        string wizgatNokiaBLD;
        string wizgatNokiaMPLS;
        string wizgatNokiaVOZ;
        string wizgatNokiaBGP;


        // - Sound Teste -
        SoundPlayer player = new SoundPlayer(Properties.Resources.Perdemo); // Use your resource name

        // -------------------------------------------------------------------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------------------------------------------------------------------



        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //-----------
            // SQL TEST
            //-----------

            //try
            // {
            //var conectionStr = "server=localhost;uid=seila;database=test";
            // var dbConection = new MySqlConnection(conectionStr);

            // dbConection.Open();

            // var sqlCommand = new MySqlCommand("SELECT * FROM clients", dbConection);
            //  var reader = sqlCommand.ExecuteReader();


            //while (reader.Read())
            // {
            // Display Buttons for every Important Client

            // Exemple
            //   MessageBox.Show($"{reader["id"]} --- {reader["name"]}");
            // }

            //  MessageBox.Show("Conexão com Banco de Dados Ok");

            // }
            // catch (Exception ex)
            // {
            //    MessageBox.Show("Erro ao conectar ao Banco de Dados: " +
            //        "\n" + ex.Message);
            // }



            // --------------------------------------------------------------------------------------

            //---------------------
            // Load Routers Info
            //---------------------

            nightMode = Properties.Settings.Default.darkMode;
            
            // Comeca com Logs Iniciais no WizGat
            Script_ComboBox.SelectedIndex = 0;
            Script_ISRBox.SelectedIndex = 1;
            Script_XRBox.SelectedIndex = 1;

            LoadRoutersInfo();
            ApplyRouteMapNokia();
            ListAllScriptVars();

            Script scriptClass = new Script(99,"Teste", "", "", DateTime.Parse("11/02/2026"));
            scripts = scriptClass.AddScripts();

            ApplyDarkTheme(this, nightMode);
        }

        public void ListAllScriptVars()
        {
            varName.Add(Script_VarName00);
            varName.Add(Script_VarName01);
            varName.Add(Script_VarName02);
            varName.Add(Script_VarName03);
            varName.Add(Script_VarName04);
            varName.Add(Script_VarName05);
            varName.Add(Script_VarName06);
            varName.Add(Script_VarName07);
            varName.Add(Script_VarName08);
            varName.Add(Script_VarName09);
            varName.Add(Script_VarName10);
            varName.Add(Script_VarName11);
            varName.Add(Script_VarName12);
            varName.Add(Script_VarName13);
            varName.Add(Script_VarName14);
            varName.Add(Script_VarName15);

            varText.Add(Script_VarText00);
            varText.Add(Script_VarText01);
            varText.Add(Script_VarText02);
            varText.Add(Script_VarText03);
            varText.Add(Script_VarText04);
            varText.Add(Script_VarText05);
            varText.Add(Script_VarText06);
            varText.Add(Script_VarText07);
            varText.Add(Script_VarText08);
            varText.Add(Script_VarText09);
            varText.Add(Script_VarText10);
            varText.Add(Script_VarText11);
            varText.Add(Script_VarText12);
            varText.Add(Script_VarText13);
            varText.Add(Script_VarText14);
            varText.Add(Script_VarText15);

            varDelete.Add(Script_DeleteVar00);
            varDelete.Add(Script_DeleteVar01);
            varDelete.Add(Script_DeleteVar02);
            varDelete.Add(Script_DeleteVar03);
            varDelete.Add(Script_DeleteVar04);
            varDelete.Add(Script_DeleteVar05);
            varDelete.Add(Script_DeleteVar06);
            varDelete.Add(Script_DeleteVar07);
            varDelete.Add(Script_DeleteVar08);
            varDelete.Add(Script_DeleteVar09);
            varDelete.Add(Script_DeleteVar10);
            varDelete.Add(Script_DeleteVar11);
            varDelete.Add(Script_DeleteVar12);
            varDelete.Add(Script_DeleteVar13);
            varDelete.Add(Script_DeleteVar14);
            varDelete.Add(Script_DeleteVar15);

            varEx.Add(Script_VarEx00);
            varEx.Add(Script_VarEx01);
            varEx.Add(Script_VarEx02);
            varEx.Add(Script_VarEx03);
            varEx.Add(Script_VarEx04);
            varEx.Add(Script_VarEx05);
            varEx.Add(Script_VarEx06);
            varEx.Add(Script_VarEx07);
            varEx.Add(Script_VarEx08);
            varEx.Add(Script_VarEx09);
            varEx.Add(Script_VarEx10);
            varEx.Add(Script_VarEx11);
            varEx.Add(Script_VarEx12);
            varEx.Add(Script_VarEx13);
            varEx.Add(Script_VarEx14);
            varEx.Add(Script_VarEx15);
        }


        public void LoadRoutersInfo()
        {
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


            DataGridRouters.DataSource = routerList;
        }


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // -------------------------- Main Buttons -----------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        // ------------------------
        // Logs
        // ------------------------

        private void Logs_Iniciais_Click(object sender, EventArgs e)
        {
            finalsOrNot = false;
            ApplyFinalsOrNot();
        }

        private void Logs_Finais_Click(object sender, EventArgs e)
        {
            finalsOrNot = true;
            ApplyFinalsOrNot();
        }

        public void ApplyFinalsOrNot()
        {
            tabControl2.SelectedTab = tabLogs;

            SwitchLabel.Text = finalsOrNot ? "FINAIS" : "INICIAIS";
            SwitchLabel.Text = finalsOrNot ? "FINAIS" : "INICIAIS";

            BackButton_Script.Hide();
            BackButton_Script2.Hide();
            BackButton_Script3.Visible = true;
        }

        private void WizGat_LogButton_Click(object sender, EventArgs e)
        {
            ApplyFinalsOrNot();
        }


        // ------------------------
        // Wizard Gat
        // ------------------------

        private void WizGat_Open1(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabWizGat;

            BackButton_Script2.Visible = true;
            BackButton_Script.Hide();
            BackButton_Script3.Hide();
        }


        // ------------------------
        // Configuracoes Buttons
        // ------------------------

        private void BLD_button_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabSelectRouter;

            BackButton_Script.Visible = true;
            BackButton_Script2.Hide();
            BackButton_Script3.Hide();

            ConfiguracaoCPE_SubTitle.Text = "BLD";

            activityType = ActivityType.BLD;
        }

        private void MPLS_button_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabSelectRouter;

            BackButton_Script.Visible = true;
            BackButton_Script2.Hide();
            BackButton_Script3.Hide();

            ConfiguracaoCPE_SubTitle.Text = "MPLS";

            activityType = ActivityType.MPLS;
        }
        

        // ------------------------
        // Back Buttons
        // ------------------------

        private void BackButton1_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabSelectRouter;
        }

        private void BackButton_Script2_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabWizGat;
        }

        private void BackButton_Script3_Click_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabLogs;
        }


        // ------------------------
        // Home Button
        // ------------------------

        private void HomeButton_Script_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabSelectProcedure;
        }


        // ------------------------------------------------------------------------------
        // Select Router Tab
        // ------------------------------------------------------------------------------

        private void Cisco_Button_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            routerType = RouterType.Cisco;
            backboneOrNot = false;
            logOrNot = false;

            //ApplyVariebleToScript(routerType);
            ScriptDispatch(routerType, activityType, false, false);
        }

        private void HPE_Button_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            routerType = RouterType.HPE;
            backboneOrNot = false;
            logOrNot = false;

            ApplyVariebleToScript(routerType);
        }

        private void Config_HPE_old_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            routerType = RouterType.HPE_old;
            backboneOrNot = false;
            logOrNot = false;

            ApplyVariebleToScript(routerType);
        }

        private void Config_Huawei_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            routerType = RouterType.Huawei;
            backboneOrNot = false;
            logOrNot = false;

            ApplyVariebleToScript(routerType);
        }

        private void Config_Fortigate_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            routerType = RouterType.Fortigate;
            backboneOrNot = false;
            logOrNot = false;

            ApplyVariebleToScript(routerType);

        }

        private void Logs_VOZ_Cisco_Click_1(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.VOZ;
            routerType = RouterType.Cisco;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        // Outras Configs
        private void buttonOC_SNMP_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabOutros;
            OutrosTitle.Text = "SNMP";

            Outros_VarName4.Hide();
            Outros_VarName3.Hide();
            Outros_VarText03.Hide();
            Outros_VarText04.Hide();
            Outros_VarDelete3.Hide();
            Outros_VarDelete4.Hide();
            Outros_VarEx3.Hide();
            Outros_VarEx4.Hide();

        }
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // -------------------------- Script Tab -------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        // ---------------------------
        // Varieble Buttons
        // ---------------------------

        private void BLD_Var0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyVariebleToScript(routerType);
            }
        }

        private void Script_XRBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyVariebleToScript(routerType);
        }

        private void Script_ISRBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyVariebleToScript(routerType);
        }

        private void Script_FortigateModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFortigateModel();
            ApplyVariebleToScript(routerType);
        }

        // ---------------------------
        // Apply Varieble To Script
        // ---------------------------

        public void ApplyLogType()
        {
            if (finalsOrNot)
            {
                logType = "FINAIS";
            }
            else
            {
                logType = "INICIAIS";
            }

        }

        public void ChangeMascaraLAN()
        {
            if (Script_LANMascaraText.SelectedIndex == 0)
            {
                mascaraStr = "255.255.255.252";
            }
            if (Script_LANMascaraText.SelectedIndex == 1)
            {
                mascaraStr = "255.255.255.248";
            }
            if (Script_LANMascaraText.SelectedIndex == 2)
            {
                mascaraStr = "255.255.255.240";
            }
            if (Script_LANMascaraText.SelectedIndex == 3)
            {
                mascaraStr = "255.255.255.192";
            }
            if (Script_LANMascaraText.SelectedIndex == 4)
            {
                mascaraStr = "255.255.255.0";
            }

        }

        public void GetDesignacao(string description)
        {
            if (description.Contains('|'))
            {
                string[] split = description.Split('|');
                split[2] = split[2].Trim();
                designacao = split[2];
            }
        }

        public void ApplyRouteMapNokia()
        {
            if (routerType == RouterType.Nokia && activityType == ActivityType.BLDcomBGP && backboneOrNot == true && logOrNot == true)
            {
                Script_RouteLabelHint.Show();
                Script_VarRouteI1.Show();
                Script_VarRouteI2.Show();
                Script_VarRouteE1.Show();
                Script_VarRouteE2.Show();
                Script_VarRouteI1Label.Show();
                Script_VarRouteI2Label.Show();
                Script_VarRouteE1Label.Show();
                Script_VarRouteE2Label.Show();
                Script_DeleteRouteI1.Show();
                Script_DeleteRouteI2.Show();
                Script_DeleteRouteE1.Show();
                Script_DeleteRouteE2.Show();
            }
            else
            {
                Script_RouteLabelHint.Hide();
                Script_VarRouteI1.Hide();
                Script_VarRouteI2.Hide();
                Script_VarRouteE1.Hide();
                Script_VarRouteE2.Hide();
                Script_VarRouteI1Label.Hide();
                Script_VarRouteI2Label.Hide();
                Script_VarRouteE1Label.Hide();
                Script_VarRouteE2Label.Hide();
                Script_DeleteRouteI1.Hide();
                Script_DeleteRouteI2.Hide();
                Script_DeleteRouteE1.Hide();
                Script_DeleteRouteE2.Hide();
            }
        }

        public void ChangeVlanNaWANVar()
        {
            if (logOrNot == true)
            {
                Script_VarName04.Text = "Interface Logica WAN: ";
            }
            else
            {
                Script_VarName04.Text = "N da Vlan: ";
            }

        }

        public void ChangeLANIPTextBoxSize()
        {
            if (logOrNot == false)
            {
                Script_VarText09.Size = new System.Drawing.Size(102, 25);
                Script_VarName04.Text = "Número VLAN na WAN:";
                Script_LANMascaraText.Show();
            }
            else
            {
                Script_VarText09.Size = new System.Drawing.Size(162, 25);
                Script_VarName04.Text = "Interface Logica WAN:";
                Script_LANMascaraText.Hide();
            }
        }

        public void ApplyFortigateModel()
        {
            if (Script_FortigateModelBox.SelectedIndex == 0)
            {
                Script_VarText03.Text = "wan";
                Script_VarText05.Text = "lan1";
            }
            if (Script_FortigateModelBox.SelectedIndex == 1)
            {
                Script_VarText03.Text = "wan1";
                Script_VarText05.Text = "internal1";
            }
            if (Script_FortigateModelBox.SelectedIndex == 2)
            {
                Script_VarText03.Text = "x1";
                Script_VarText05.Text = "port1";
            }
        }

        public void VarScriptDisplayControl(string numberOfVar)
        {    
            string[] split = numberOfVar.Split(',');
     
            int anterior = 99;

            for (int i = 0; i < varName.Count; i++)
            {
     
                foreach (string s in split)
                {
             
                    if (varName[i].Name.Contains(s))
                    {
                       
                        varName[i].Show();
                        if (anterior == 99)
                        {
                            varName[i].Location = new System.Drawing.Point(varName[i].Location.X, 150);

                        }
                        else
                        {
                            varName[i].Location = new System.Drawing.Point(varName[i].Location.X, varName[anterior].Location.Y + 30);
                        }

                        anterior = i;
                        break;
                    }

                    else
                    {
                        varName[i].Hide();
                    }
                }
            }

            anterior = 99;

            for (int i = 0; i < varText.Count; i++)
            {

                foreach (string s in split)
                {

                    if (varText[i].Name.Contains(s))
                    {
                        varText[i].Show();
                        if (s == "09")
                        {
                            Script_LANMascaraText.Location = new System.Drawing.Point(258, varText[anterior].Location.Y + 30);
                        }
                        if (anterior == 99)
                        {
                            varText[i].Location = new System.Drawing.Point(varText[i].Location.X, 150);
                        }
                        else
                        {
                            varText[i].Location = new System.Drawing.Point(varText[i].Location.X, varText[anterior].Location.Y + 30);
                        }

                        anterior = i;
                        break;
                    }
                    else
                    {
                        varText[i].Hide();
                    }
                }
            }


            anterior = 99;

            for (int i = 0; i < varDelete.Count; i++)
            {

                foreach (string s in split)
                {

                    if (varDelete[i].Name.Contains(s))
                    {
                        varDelete[i].Show();
                        if (anterior == 99)
                        {
                            varDelete[i].Location = new System.Drawing.Point(varDelete[i].Location.X, 150);
                        }
                        else
                        {
                            varDelete[i].Location = new System.Drawing.Point(varDelete[i].Location.X, varDelete[anterior].Location.Y + 30);
                        }

                        anterior = i;
                        break;
                    }
                    else
                    {
                        varDelete[i].Hide();
                    }
                }
            }

            anterior = 99;

            for (int i = 0; i < varEx.Count; i++)
            {

                foreach (string s in split)
                {

                    if (varEx[i].Name.Contains(s))
                    {
                        varEx[i].Show();

                        if (anterior == 99)
                        {
                            varEx[i].Location = new System.Drawing.Point(varEx[i].Location.X, 150);
                        }
                        else
                        {
                            varEx[i].Location = new System.Drawing.Point(varEx[i].Location.X, varEx[anterior].Location.Y + 30);
                        }

                        anterior = i;
                        break;
                    }
                    else
                    {
                        varEx[i].Hide();
                    }
                }

            }

            // Script_Hint1.Location = new System.Drawing.Point(54, varEx[anterior].Location.Y + 40);
        }

        // OLD
        #region
        public void ApplyVariebleToScript(RouterType type)
        {
            ApplyRouteMapNokia();
            ApplyLogType();
            ChangeMascaraLAN();
            ChangeVlanNaWANVar();
            GetDesignacao(Script_VarText01.Text);
            ChangeLANIPTextBoxSize();

            if (Script_ComboBox.Text == null)
            {
                Script_ComboBox.Text = "INICIAIS";
            }

            if (logOrNot && backboneOrNot == false)
            {
                SwitchLabel.Show();
                buttonSwitchScriptLog.Show();
            }
            else
            {
                SwitchLabel.Hide();
                buttonSwitchScriptLog.Hide();
            }

            // -----------------------------------------------------------------
            // Teste

            if (type == RouterType.Cisco && activityType == ActivityType.VOZ && logOrNot == true && backboneOrNot == false)
            {
                Script_ProcedureName.Text = "Teste";

                // --- Cluster Only the Usable Variables ---

                VarScriptDisplayControl("0,1,3,5");
                ChangeMascaraLAN();

                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Show();
                Script_ISRLabel.Show();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Hide();

                string testeStr = scripts[0].scriptString.Replace("var0", Script_VarText00.Text);
                testeStr = testeStr.Replace("var1", Script_VarText01.Text);
                testeStr = testeStr.Replace("var2", Script_VarText02.Text);
                testeStr = testeStr.Replace("var3", Script_VarText03.Text);
                testeStr = testeStr.Replace("var5", Script_VarText05.Text);
                testeStr = testeStr.Replace("var7", Script_VarText07.Text);
                testeStr = testeStr.Replace("var9", Script_VarText09.Text);
                testeStr = testeStr.Replace("mascara", mascaraStr);
                testeStr = testeStr.Replace("var10", Script_VarText10.Text);

                Script_TextBox.Text = testeStr;
            }

            // ------------------------------------------- Config - Cisco - BLD -------------------------------------------------------

            else if (type == RouterType.Cisco && activityType == ActivityType.BLD && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - CISCO - BLD";

                VarScriptDisplayControl("00,01,02,03,04,05,07,09,10");

                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Show();
                Script_ISRLabel.Show();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Hide();

                // --- Others ---
                string vlanNTP = "";

                if (Script_VarText04.Text != string.Empty)
                {
                    withVlan = "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "encapsulation dot1Q " + Script_VarText04.Text + "\r\n";

                    vlanNTP = "." + Script_VarText04.Text;

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    vlanNTP = "";
                    withVlan = "!\r\n";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = "conf t \r\n" +
                "!\r\n" +
                "!\r\n" +
                "hostname " + Script_VarText00.Text + "\r\n" +
                "!\r\n" +
                "ip domain name embratel \r\n" +
                "!\r\n" +
                "!\r\n" +
                "###################################################### \r\n" +
                "# CONFIGURACOES DE USUARIO # \r\n" +
                "###################################################### \r\n" +
                "!\r\n" +
                "service password-encryption\r\n" +
                "username EBT privilege 10 password CQMR\r\n" +
                "enable secret PRO1AN\r\n" +
                "logging buffered 4096 debugging\r\n" +
                "service tcp-keepalives-in\r\n" +
                "service tcp-keepalives-out\r\n" +
                "no enable password\r\n" +
                "service timestamps debug datetime msec localtime show-timezone\r\n" +
                "service timestamps log datetime msec localtime show-timezone\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# LIMPEZA \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "config-register 0x2102\r\n" +
                "no username cisco\r\n" +
                "no username admin\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no ip domain name yourdomain.com\r\n" +
                "no ip domain lookup\r\n" +
                "!\r\n" +
                "!\r\n" +
                "logging buffered 51200 warnings\r\n" +
                "no logging console\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no boot host\r\n" +
                "no boot network \r\n" +
                "!\r\n" +
                "!\r\n" +
                "no ip finger\r\n" +
                "no service pad\r\n" +
                "no service tcp-small-servers\r\n" +
                "no ip bootp server\r\n" +
                "no ip source-route\r\n" +
                "no cdp run\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no access-list 23 permit 10.10.10.0 0.0.0.7\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no ip http server\r\n" +
                "no ip http access-class 23\r\n" +
                "no ip http authentication local\r\n" +
                "no ip http secure-server\r\n" +
                "no ip http timeout-policy idle 60 life 86400 requests 10000\r\n" +
                "no logging trap notifications\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no ip dhcp excluded-address 10.10.10.1\r\n" +
                "no ip dhcp pool ccp-pool\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no ip ssh version 1\r\n" +
                "ip ssh version 2\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no crypto pki trustpoint TP-self-signed-4256465151\r\n" +
                "!\r\n" +
                "yes \r\n" +
                "!\r\n" +
                "!\r\n" +
                "no crypto pki certificate chain TP-self-signed-4256465151\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "crypto pki token default removal timeout 0\r\n" +
                "!\r\n" +
                "no crypto key generate rsa\r\n" +
                "crypto key generate rsa\r\n" +
                "y\r\n" +
                "1024\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# BLOQUEIO - ACCESS LIST \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "ip access-list extended BLOQUEIO_TELNET\r\n" +
                "remark IP LOOPBACK PE\r\n" +
                "permit ip host " + Script_VarText10.Text + " any\r\n" +
                "permit ip any host " + Script_VarText10.Text + "\r\n" +
                "!\r\n" +
                "remark IP PE - CCTO\r\n" +
                "permit ip host " + Script_VarText07.Text + " any\r\n" +
                "permit ip any host " + Script_VarText07.Text + "\r\n" +
                "!\r\n" +
                "remark IP GERENCIA GCPE\r\n" +
                "permit ip any 200.255.156.192 0.0.0.63\r\n" +
                "permit ip 200.255.156.192 0.0.0.63 any\r\n" +
                "!\r\n" +
                "!\r\n" +
                "line vty 0 4 \r\n" +
                "access-class BLOQUEIO_TELNET in\r\n" +
                "access-class BLOQUEIO_TELNET out\r\n" +
                "exec-timeout 15 0\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# POLICY MAP - QoS \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "policy-map SHAPE_OUT\r\n" +
                "class class-default\r\n" +
                " shape average " + Script_VarText02.Text + "000\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# CONFIGURACOES DE INTERFACES \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "interface " + Script_VarText03.Text + "\r\n" +
                " description " + Script_VarText01.Text + "\r\n" +
                " bandwidth " + Script_VarText02.Text + "\r\n" +
                " service-policy output SHAPE_OUT\r\n" +
                " no shut\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                withVlan +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "interface " + Script_VarText05.Text + "\r\n" +
                " description ** LAN **\r\n" +
                " ip address " + Script_VarText09.Text + " " + mascaraStr + "\r\n" +
                " no ip redirects\r\n" +
                " no ip unreachables\r\n" +
                " no ip proxy-arp\r\n" +
                " duplex auto\r\n" +
                " speed auto\r\n" +
                " no shutdown\r\n" +
                " no cdp enable\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# ROTA ESTATICA \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "ip route 0.0.0.0 0.0.0.0 " + Script_VarText07.Text + "\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# CONFIGURACOES DE SNMP \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "snmp-server community LIDER RO\r\n" +
                "snmp-server host 200.255.156.194 LIDER\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "###################################################### \r\n" +
                "# CONFIGURACOES DO RELOGIO INTERNO \r\n" +
                "###################################################### \r\n" +
                "!\r\n" +
                "clock timezone BR -3 0\r\n" +
                "clock summer-time BR recurring 1 Sun Oct 0:00 3 Sun Feb 0:00\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \n" +
                "!# CONFIGURACOES DE NTP \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "ntp server 200.20.186.75 prefer source " + Script_VarText03.Text + vlanNTP + "\r\n" +
                "ntp server 200.20.186.94 source " + Script_VarText03.Text + vlanNTP + "\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# BANNER - USER INTERFACE \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "!\r\n" +
                "banner motd ^C\r\n" +
                "||========================================||  \r\n" +
                "||========== CLARO Brasil S.A. ===========||  \r\n" +
                "||========================================||  \r\n" +
                "                                              \r\n" +
                "        SOMENTE USUARIOS AUTORIZADOS          \r\n" +
                "           AUTHORIZED USERS ONLY              \r\n" +
                "                                              \r\n" +
                "        OS ACESSOS SERAO MONITORADOS          \r\n" +
                "         ACCESSES WILL BE MONITORED           \r\n" +
                "                                              \r\n" +
                "||========================================||^ \r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no banner exec ^C\r\n" +
                "no banner login ^C\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "line con 0\r\n" +
                "no password\r\n" +
                "exec-timeout 15 0\r\n" +
                "login local\r\n" +
                "line aux 0\r\n" +
                "no password\r\n" +
                "login local\r\n" +
                "transport input none\r\n" +
                "line vty 0 4\r\n" +
                "no password\r\n" +
                "exec-timeout 15 0\r\n" +
                "login local\r\n" +
                "transport input telnet ssh\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "end\r\n";

            }

            // ------------------------------------------- Config - HPE - BLD -------------------------------------------------------

            else if ((type == RouterType.HPE) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - HPE - BLD";

                VarScriptDisplayControl("00,01,02,03,04,05,07,09,10");

                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                SwitchLabel.Hide();
                buttonSwitchScriptLog.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                // --- Others ---
                if (Script_VarText04.Text != string.Empty)
                {
                    withVlan = "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n";

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    withVlan = "#\r\n";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = "#\r\n" +
                    "system-view\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "sysname " + Script_VarText00.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###################################################### \r\n" +
                    "# CONFIGURACOES DE USUARIO # \r\n" +
                    "###################################################### \r\n" +
                    "#\r\n" +
                    "local-user EBT class manage\r\n" +
                    "password simple PRO1AN\r\n" +
                    "PRO1AN\r\n" +
                    "service-type telnet\r\n" +
                    "service-type telnet terminal\r\n" +
                    " service-type ftp\r\n" +
                    " authorization-attribute user-role network-admin\r\n" +
                    " authorization-attribute user-role network-operator\r\n" +
                    "telnet server enable\r\n" +
                    "password-recovery enable\r\n" +
                    "info-center logbuffer size 1024\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###################################################### \r\n" +
                    "# LIMPEZA # \r\n" +
                    "###################################################### \r\n" +
                    "#\r\n" +
                    "undo local-user admin class manage\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "undo dns proxy enable\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "interface GigabitEthernet0/0\r\n" +
                    "undo ip address dhcp-alloc\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "undo dhcp server ip-pool lan1\r\n" +
                    "undo dhcp enable\r\n" +
                    "undo dhcp server always-broadcast\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "undo interface Vlan-interface1\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "undo ip http enable\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "undo nqa entry imclinktopologypleaseignore ping\r\n" +
                    "undo nqa schedule imclinktopologypleaseignore ping\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###################################################### \r\n" +
                    "# CONFIGURACOES DE INTERFACES # \r\n" +
                    "###################################################### \r\n" +
                    "#\r\n" +
                    "interface " + Script_VarText03.Text + "\r\n" +
                    "port link-mode route\r\n" +
                    "undo virtualbaudrate\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "qos gts any cir " + Script_VarText02.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    withVlan +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "interface " + Script_VarText05.Text + "\r\n" +
                    "port link-mode route\r\n" +
                    "y\r\n" +
                    "description ** LAN **\r\n" +
                    "ip address " + Script_VarText09.Text + " " + mascaraStr + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###################################################### \r\n" +
                    "# ROTA ESTATICA # \r\n" +
                    "###################################################### \r\n" +
                    "#\r\n" +
                    "ip route-static 0.0.0.0 0.0.0.0 " + Script_VarText07.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###################################################### \r\n" +
                    "# BLOQUEIO - ACCESS LIST # \r\n" +
                    "###################################################### \r\n" +
                    "#\r\n" +
                    "acl advanced 3000\r\n" +
                    "#\r\n" +
                    "rule 5 permit ip source " + Script_VarText10.Text + " 0\r\n" +
                    "rule 10 permit ip destination " + Script_VarText10.Text + " 0\r\n" +
                    "rule 10 comment IP LOOPBACK PE\r\n" +
                    "#\r\n" +
                    "rule 15 permit ip source " + Script_VarText07.Text + " 0\r\n" +
                    "rule 20 permit ip destination " + Script_VarText07.Text + " 0\r\n" +
                    "rule 20 comment IP PE - CCTO\r\n" +
                    "#\r\n" +
                    "rule 25 permit ip destination 200.255.156.192 0.0.0.63\r\n" +
                    "rule 30 permit ip source 200.255.156.192 0.0.0.63\r\n" +
                    "rule 30 comment IP GERENCIA GCPE\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "telnet server acl 3000\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###################################################### \r\n" +
                    "# CONFIGURACOES DE SNMP \r\n" +
                    "###################################################### \r\n" +
                    "#\r\n" +
                    "snmp-agent community read LIDER\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###################################################### \r\n" +
                    "# CONFIGURACOES DO RELOGIO INTERNO \r\n" +
                    "###################################################### \r\n" +
                    "# \r\n" +
                    "clock timezone BR minus 03:00:00\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###################################################### \r\n" +
                    "# NTP PARA OS SERVIDORES NTP DO OBSERVATORIO NACIONAL \r\n" +
                    "###################################################### \r\n" +
                    "#\r\n" +
                    "ntp-service enable\r\n" +
                    "ntp-service unicast-server 200.20.186.75 priority source " + Script_VarText05.Text + "\r\n" +
                    "ntp-service unicast-server 200.20.186.94 source " + Script_VarText05.Text + "\r\n" +
                    "ntp-service refclock-master 12\r\n" +
                    "#\r\n" +
                    "clock protocol ntp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###################################################### \r\n" +
                    "# CONFIG PARA HABILITAR O SSH \r\n" +
                    "###################################################### \r\n" +
                    "#\r\n" +
                    "local-user EBT\r\n" +
                    " service-type telnet terminal ssh\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "public-key local create rsa\r\n" +
                    "y\r\n" +
                    "1024\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "ssh server enable\r\n" +
                    "ssh server acl 3000\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###################################################### \r\n" +
                    "# BANNER - USER INTERFACE \r\n" +
                    "###################################################### \r\n" +
                    "#\r\n" +
                    "user-interface con 0\r\n" +
                    " authentication-mode scheme\r\n" +
                    "user-interface tty 13\r\n" +
                    "user-interface aux 0\r\n" +
                    " authentication-mode scheme\r\n" +
                    "user-interface vty 0 4\r\n" +
                    " authentication-mode scheme\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "header motd %\r\n" +
                    "||========================================|| \r\n" +
                    "||===========CLARO Brasil S.A.============|| \r\n" +
                    "||========================================|| \r\n" +
                    "                                             \r\n" +
                    "        SOMENTE USUARIOS AUTORIZADOS         \r\n" +
                    "           AUTHORIZED USERS ONLY             \r\n" +
                    "                                             \r\n" +
                    "        OS ACESSOS SERAO MONITORADOS         \r\n" +
                    "         ACCESSES WILL BE MONITORED          \r\n" +
                    "                                             \r\n" +
                    "||========================================|| \r\n" +
                    "%\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "return\r\n" +
                    "#\r\n";

            }


            // ------------------------------------------- Config - Fortigate - BLD -------------------------------------------------------

            else if ((type == RouterType.Fortigate) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - FORTIGATE - BLD";


                VarScriptDisplayControl("00,01,02,03,04,05,07,09,10");

                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Show();
                Script_ModelLabel.Show();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Hide();

                // --- Others ---
                vlanNaWAN = "# \r\n";
                sourceLan = "";

                if (Script_VarText04.Text != string.Empty)
                {
                    vlanNaWAN = "################# Configuracao VLAN na WAN  #################### \r\n" +
                        "#\r\n" +
                        "    edit " + '"' + Script_VarText03.Text + "." + Script_VarText04.Text + '"' + "\r\n" +
                        "       set vdom " + '"' + "root" + '"' + "\r\n" +
                        "       set allowaccess ping https ssh telnet snmp\r\n" +
                        "       set description " + '"' + Script_VarText01.Text + '"' + "\r\n" +
                        "       set alias " + '"' + "WAN" + '"' + "\r\n" +
                        "       set role wan\r\n" +
                        "       set interface " + Script_VarText03.Text + "\r\n" +
                        "       set vlanid " + Script_VarText04.Text + "\r\n" +
                        "   next\r\n" +
                        "#\r\n" +
                        "#\r\n" +
                        "#\r\n";
                    sourceLan = "." + Script_VarText04.Text;

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    vlanNaWAN = "#\r\n";
                    sourceLan = "";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = "# \r\n" +
                    "# Jogar as configurações em blocos do 'edit' até o 'end' (Salva). \r\n" +
                    "#\r\n" +
                    "################# Configs - Hostname/Horario ############# \r\n" +
                    "#\r\n" +
                    "config system global\r\n" +
                    "    set hostname " + '"' + Script_VarText00.Text + '"' + "\r\n" +
                    "   set timezone 18\r\n" +
                    "   set dst disable\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Deleta DHCP na LAN ################# \r\n" +
                    "#\r\n" +
                    "config system dhcp server\r\n" +
                    "   delete 1\r\n" +
                    "   delete 2\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Limpar Firewall Policy ######################## \r\n" +
                    "#\r\n" +
                    "config firewall policy\r\n" +
                    "    purge\r\n" +
                    "    y\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Remove as Interfaces do Virtual-Switch ############ \r\n" +
                    "# \r\n" +
                    "config system virtual-switch\r\n" +
                    "    edit lan\r\n" +
                    "        set physical-switch " + '"' + "sw0" + '"' + "\r\n" +
                    "        config port\r\n" +
                    "            delete lan1\r\n" +
                    "            delete lan2\r\n" +
                    "            delete lan3\r\n" +
                    "            #\r\n" +
                    "        end\r\n" +
                    "    next\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "############## Limpeza Interface LAN ##################### \r\n" +
                    "# \r\n" +
                    "config system interface\r\n" +
                    "    edit lan\r\n" +
                    "       unset ip\r\n" +
                    "    next\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Config - BANER ################ \r\n" +
                    "#\r\n" +
                    "config system replacemsg admin pre_admin-disclaimer-text\r\n" +
                    "set buffer " + '"' + "\r\n" +
                    "||========================================||  \r\n" +
                    "||========== CLARO Brasil S.A. ===========||  \r\n" +
                    "||========================================||  \r\n" +
                    "                                              \r\n" +
                    "        SOMENTE USUARIOS AUTORIZADOS          \r\n" +
                    "           AUTHORIZED USERS ONLY              \r\n" +
                    "                                              \r\n" +
                    "        OS ACESSOS SERAO MONITORADOS          \r\n" +
                    "         ACCESSES WILL BE MONITORED           \r\n" +
                    "                                              \r\n" +
                    "||========================================||  \r\n" +
                    '"' + "\r\n" +
                    "end\r\n" +
                    "config system global\r\n" +
                    "     set pre-login-banner enable\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Config - Usuário/Trusthost ################### \r\n" +
                    "#\r\n" +
                    "config system admin\r\n" +
                    "    edit " + '"' + "EBT" + '"' + "\r\n" +
                    "       set accprofile " + '"' + "super_admin" + '"' + "\r\n" +
                    "       set vdom " + '"' + "root" + '"' + "\r\n" +
                    "       set password PRO1AN\r\n" +
                    "       set trusthost1 169.248.255.254 255.255.255.255\r\n" +
                    "       set trusthost2 200.255.156.192 255.255.255.192\r\n" +
                    "       set trusthost3 200.255.122.0 255.255.255.0\r\n" +
                    "       set trusthost5 200.244.28.61 255.255.255.255\r\n" +
                    "       set trusthost6 200.244.27.26 255.255.255.255\r\n" +
                    "       set trusthost7 " + Script_VarText07.Text + " 255.255.255.255\r\n" +
                    "       set trusthost8 " + Script_VarText10.Text + " 255.255.255.255\r\n" +
                    "       set accprofile " + '"' + "super_admin" + '"' + "\r\n" +
                    "    next\r\n" +
                    "#\r\n" +
                    "    delete " + '"' + "admin" + '"' + "\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Config - NTP Embratel ################ \r\n" +
                    "#\r\n" +
                    "config system ntp\r\n" +
                    "    set ntpsync enable\r\n" +
                    "    set type custom\r\n" +
                    "    set syncinterval 1\r\n" +
                    "    config ntpserver\r\n" +
                    "        edit 0\r\n" +
                    "            set server " + '"' + "200.20.186.75" + '"' + "\r\n" +
                    "            set server " + '"' + "200.20.186.94" + '"' + "\r\n" +
                    "        next\r\n" +
                    "    end\r\n" +
                    "    set server-mode enable\r\n" +
                    "    set interface " + '"' + "fortilink" + '"' + "\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Config - SNMP Embratel ################### \r\n" +
                    "#\r\n" +
                    "config system snmp community\r\n" +
                    "    edit 0\r\n" +
                    "    set name " + '"' + "LIDER RO" + '"' + "\r\n" +
                    "    config hosts\r\n" +
                    "      edit 0\r\n" +
                    "        set ip 200.255.156.194 255.255.255.255\r\n" +
                    "      next\r\n" +
                    "    end\r\n" +
                    "    next\r\n" +
                    "    end\r\n" +
                    "    config system snmp sysinfo\r\n" +
                    "      set status enable\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Config - Interfaces LAN / WAN ############### \r\n" +
                    "#\r\n" +
                    "config system interface \r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Configuracao de WAN ################## \r\n" +
                    "#\r\n" +
                    "    edit wan\r\n" +
                    "       set mode static\r\n" +
                    "       set vdom " + '"' + "root" + '"' + "\r\n" +
                    "       set allowaccess ping https ssh telnet snmp\r\n" +
                    "       set role wan\r\n" +
                    "       set description " + '"' + Script_VarText01.Text + '"' + "\r\n" +
                    "       set alias " + '"' + "WAN" + '"' + "\r\n" +
                    "    next\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    vlanNaWAN +
                    "################# Configuracao de LAN ####################### \r\n" +
                    "#\r\n" +
                    "    edit " + '"' + "lan1" + '"' + "\r\n" +
                    "       set vdom " + '"' + "root" + '"' + "\r\n" +
                    "       set ip " + Script_VarText09.Text + " " + mascaraStr + "\r\n" +
                    "       set allowaccess ping fgfm snmp \r\n" +
                    "       set description " + '"' + "CONEXAO LAN" + '"' + "\r\n" +
                    "       set alias " + '"' + "LAN" + '"' + "\r\n" +
                    "       set role lan\r\n" +
                    "    next\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################## Config - Policies Entrada/Saida ############# \r\n" +
                    "# \r\n" +
                    "config firewall policy\r\n" +
                    "     edit 1\r\n" +
                    "       set name " + '"' + "LAN_WAN" + '"' + "\r\n" +
                    "       set srcintf " + '"' + Script_VarText05.Text + '"' + "\r\n" +
                    "       set dstintf " + '"' + Script_VarText03.Text + sourceLan + '"' + "\r\n" +
                    "       set srcaddr " + '"' + "all" + '"' + "\r\n" +
                    "       set dstaddr " + '"' + "all" + '"' + "\r\n" +
                    "      set action accept\r\n" +
                    "      set schedule " + '"' + "always" + '"' + "\r\n" +
                    "       set service " + '"' + "ALL" + '"' + "\r\n" +
                    "       set fsso disable\r\n" +
                    "       set nat disable\r\n" +
                    "    next\r\n" +
                    "    edit 2\r\n" +
                    "       set name " + '"' + "WAN_LAN" + '"' + "\r\n" +
                    "       set srcintf " + '"' + Script_VarText03.Text + sourceLan + '"' + "\r\n" +
                    "       set dstintf " + '"' + Script_VarText05.Text + '"' + "\r\n" +
                    "       set srcaddr " + '"' + "all" + '"' + "\r\n" +
                    "       set dstaddr " + '"' + "all" + '"' + "\r\n" +
                    "       set action accept\r\n" +
                    "       set schedule " + '"' + "always" + '"' + "\r\n" +
                    "       set service " + '"' + "ALL" + '"' + "\r\n" +
                    "       set fsso disable\r\n" +
                    "      set nat disable\r\n" +
                    "    next\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Config - Rota Estatica ############################## \r\n" +
                    "#\r\n" +
                    "config router static\r\n" +
                    "    edit 1\r\n" +
                    "       set gateway " + Script_VarText07.Text + "\r\n" +
                    "       set device " + Script_VarText03.Text + sourceLan + "\r\n" +
                    "    next\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n";
            }


            // ------------------------------------------- Config - Huawei - BLD -------------------------------------------------------

            else if ((type == RouterType.Huawei) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - HUAWEI - BLD";

                VarScriptDisplayControl("00,01,02,03,04,05,07,09,10");


                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                // --- Others ---
                if (Script_VarText04.Text != string.Empty)
                {
                    withVlan = "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                        " description " + Script_VarText01.Text + "\r\n" +
                        " dot1q termination vid " + Script_VarText04.Text + "\r\n" +
                        " bandwidth " + Script_VarText02.Text + "\r\n";

                    MessageBox.Show("Com Vlan");
                    sourceLan = "." + Script_VarText04.Text;
                }
                else
                {
                    sourceLan = "";
                    withVlan = "#\r\n";
                }

                buttonSwitchScriptLog.Hide();


                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = "SYS\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "sysname " + Script_VarText00.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    " header login information " + '"' + "\r\n" +
                    "||========================================||  \r\n" +
                    "||===========CLARO Brasil S.A.============||  \r\n" +
                    "||========================================||  \r\n" +
                    "                                              \r\n" +
                    "        SOMENTE USUARIOS AUTORIZADOS          \r\n" +
                    "           AUTHORIZED USERS ONLY              \r\n" +
                    "                                              \r\n" +
                    "        OS ACESSOS SERAO MONITORADOS          \r\n" +
                    "         ACCESSES WILL BE MONITORED           \r\n" +
                    "                                              \r\n" +
                    "||========================================||  \r\n" +
                    '"' + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "aaa\r\n" +
                    "undo local-aaa-user password policy access-user\r\n" +
                    "undo local-aaa-user password policy administrator\r\n" +
                    "local-user EBT password irreversible-cipher PRO1AN@1\r\n" +
                    "PRO1AN@1\r\n" +
                    "local-user EBT service-type telnet terminal ssh\r\n" +
                    "y\r\n" +
                    "local-user EBT privilege level 15 \r\n" +
                    "#\r\n" +
                    "undo local-user admin\r\n" +
                    "quit\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "undo http secure-server ssl-policy\r\n" +
                    "y\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "undo http secure-server enable\r\n" +
                    "y\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "undo http server permit interface\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "interface Vlanif1\r\n" +
                    "undo ip address\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "acl 3000\r\n" +
                    "rule permit ip source " + Script_VarText10.Text + " 0\r\n" +
                    "rule permit ip destination " + Script_VarText10.Text + " 0\r\n" +
                    "#\r\n" +
                    "rule permit ip source " + Script_VarText07.Text + " 0\r\n" +
                    "rule permit ip destination " + Script_VarText07.Text + " 0\r\n" +
                    "#\r\n" +
                    "rule permit ip destination 200.255.156.192 0.0.0.63\r\n" +
                    "rule permit ip source 200.255.156.192 0.0.0.63\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "traffic classifier " + Script_VarText02.Text + " operator or\r\n" +
                    "if-match any\r\n" +
                    "# \r\n" +
                    "traffic behavior " + Script_VarText02.Text + "\r\n" +
                    "car cir " + Script_VarText02.Text + "\r\n" +
                    "#\r\n" +
                    "traffic policy " + Script_VarText02.Text + "\r\n" +
                    "classifier " + Script_VarText02.Text + " behavior " + Script_VarText02.Text + " precedence 5\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "interface " + Script_VarText03.Text + "\r\n" +
                    " description  " + Script_VarText01.Text + "\r\n" +
                    " bandwidth " + Script_VarText02.Text + "\r\n" +
                    " qos gts cir " + Script_VarText02.Text + "\r\n" +
                    " undo virtualbaudrate\r\n" +
                    " traffic-policy " + Script_VarText02.Text + " inbound\r\n" +
                    " traffic-policy " + Script_VarText02.Text + " outbound\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    withVlan +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "interface " + Script_VarText05.Text + "\r\n" +
                    " description  **LAN**\r\n" +
                    " ip address " + Script_VarText09.Text + " " + mascaraStr + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "ip route-static 0.0.0.0 0.0.0.0 " + Script_VarText07.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "fib regularly-refresh disable\r\n" +
                    "y\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "info-center loghost source " + Script_VarText03.Text + sourceLan + "\r\n" +
                    "info-center loghost " + Script_VarText07.Text + "\r\n" +
                    "info-center loghost " + Script_VarText09.Text + "\r\n" +
                    "info-center logbuffer size 1024\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "undo icmp name timestamp-request receive\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "telnet server enable\r\n" +
                    "telnet server permit interface " + Script_VarText03.Text + sourceLan + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "user-interface con 0\r\n" +
                    " authentication-mode aaa\r\n" +
                    "user-interface vty 0 4\r\n" +
                    " acl 3000 inbound\r\n" +
                    " authentication-mode aaa\r\n" +
                    " protocol inbound telnet\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "ntp-service refclock-master 12\r\n" +
                    "ntp-service unicast-server 200.20.186.94 source-interface " + Script_VarText05.Text + "\r\n" +
                    "ntp-service unicast-server 200.20.186.75 source-interface " + Script_VarText05.Text + " preference\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "return\r\n";

            }

            // ------------------------------------------- Config - Fortigate - MPLS -------------------------------------------------------

            else if ((type == RouterType.Fortigate) && (activityType == ActivityType.MPLS) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - FORTIGATE - MPLS";


                VarScriptDisplayControl("00,01,02,03,04,05,07,09,11,12");

                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Show();
                Script_ModelLabel.Show();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Hide();

                // --- Others ---
                vlanNaWAN = "# \r\n";

                if (Script_VarText04.Text != string.Empty)
                {
                    vlanNaWAN = "################# Configuracao VLAN na WAN  ##################### \r\n" +
                        "#\r\n" +
                        "    edit " + '"' + Script_VarText03.Text + "." + Script_VarText04.Text + '"' + "\r\n" +
                        "       set vdom " + '"' + "root" + '"' + "\r\n" +
                        "       set allowaccess ping https ssh telnet snmp\r\n" +
                        "       set description " + '"' + Script_VarText01.Text + '"' + "\r\n" +
                        "       set alias " + '"' + "WAN" + '"' + "\r\n" +
                        "       set role wan\r\n" +
                        "       set interface " + Script_VarText03.Text + "\r\n" +
                        "       set vlanid " + Script_VarText04.Text + "\r\n" +
                        "   next\r\n" +
                        "#\r\n" +
                        "#\r\n" +
                        "#\r\n";

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    vlanNaWAN = "# \r\n";
                }

                // ---------------------------------------------------------

                if (Script_VarText11.Text != string.Empty)
                {
                    loopbackCliente = "################# Loopback Cliente  ##################### \r\n" +
                        "#\r\n" +
                        "edit " + '"' + "Loopback21" + '"' + "\r\n" +
                        "        set vdom " + '"' + "root" + '"' + "\r\n" +
                        "        set ip " + Script_VarText11.Text + " " + " 255.255.255.255\r\n" +
                        "        set allowaccess ping ssh snmp telnet probe-response\r\n" +
                        "        set icmp-send-redirect disable\r\n" +
                        "        set icmp-accept-redirect disable\r\n" +
                        "        set type loopback\r\n" +
                        "        set description " + '"' + "Loopback21" + '"' + "\r\n" +
                        "        next\r\n" +
                        "end\r\n";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = "#\r\n" +
                    "# Jogar as configurações em blocos do 'edit' até o 'end' (Salva). \r\n" +
                    "#\r\n" +
                    "################# Configs - Hostname/Horario ################# \r\n" +
                    "#\r\n" +
                    "config system global\r\n" +
                    "   set hostname " + '"' + Script_VarText00.Text + '"' + "\r\n" +
                    "   set timezone 18\r\n" +
                    "   set dst disable\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Deleta DHCP na LAN ################## \r\n" +
                    "#\r\n" +
                    "config system dhcp server\r\n" +
                    "   delete 1\r\n" +
                    "   delete 2\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Limpar Firewall ####################### \r\n" +
                    "#\r\n" +
                    "config firewall policy\r\n" +
                    "    purge\r\n" +
                    "    y\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "config firewall address\r\n" +
                    "delete " + '"' + "lan" + '"' + "\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########### Remove as Interfaces do Virtual-Switch ########### \r\n" +
                    "#\r\n" +
                    "config system virtual-switch\r\n" +
                    "    edit lan\r\n" +
                    "        set physical-switch " + '"' + "sw0" + '"' + "\r\n" +
                    "        config port\r\n" +
                    "            delete lan1\r\n" +
                    "            delete lan2\r\n" +
                    "            delete lan3\r\n" +
                    "        end\r\n" +
                    "    next\r\n" +
                    "end\r\n" +
                    "# \r\n" +
                    "# \r\n" +
                    "############## Limpeza Interface LAN ################ \r\n" +
                    "#\r\n" +
                    "config system interface\r\n" +
                    "    edit lan\r\n" +
                    "       unset ip\r\n" +
                    "    next\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "############## Limpeza de Rota Estativa ############ \r\n" +
                    "#\r\n" +
                    "config router static\r\n" +
                    "purge\r\n" +
                    "y\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Config - BANER ################### \r\n" +
                    "#\r\n" +
                    "config system replacemsg admin pre_admin-disclaimer-text\r\n" +
                    "set buffer " + '"' + "\r\n" +
                    "||========================================||  \r\n" +
                    "||========== CLARO Brasil S.A. ===========||  \r\n" +
                    "||========================================||  \r\n" +
                    "                                              \r\n" +
                    "        SOMENTE USUARIOS AUTORIZADOS          \r\n" +
                    "           AUTHORIZED USERS ONLY              \r\n" +
                    "                                              \r\n" +
                    "        OS ACESSOS SERAO MONITORADOS          \r\n" +
                    "         ACCESSES WILL BE MONITORED           \r\n" +
                    "                                              \r\n" +
                    "||========================================||  \r\n" +
                    '"' + "\r\n" +
                    "end\r\n" +
                    "config system global\r\n" +
                    "     set pre-login-banner enable\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Config - Usuario e Senha ################# \r\n" +
                    "#\r\n" +
                    "config system admin\r\n" +
                    "edit " + '"' + "EBT" + '"' + "\r\n" +
                    "set accprofile " + '"' + "super_admin" + '"' + "\r\n" +
                    "set vdom " + '"' + "root" + '"' + "\r\n" +
                    "set password PRO1AN\r\n" +
                    "next\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "edit " + '"' + "admin" + '"' + "\r\n" +
                    "set password PRO1AN\r\n" +
                    "next\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################# Config - Interfaces LAN / WAN ################### \r\n" +
                    "#\r\n" +
                    "################# Configuracao de WAN ################## \r\n" +
                    "#\r\n" +
                    "config system interface\r\n" +
                    "    edit " + '"' + "wan" + '"' + "\r\n" +
                    "       set vdom " + '"' + "root" + '"' + "\r\n" +
                    "       set description " + '"' + Script_VarText01.Text + '"' + "\r\n" +
                    "       set allowaccess ping https ssh snmp http telnet\r\n" +
                    "       set inbandwidth " + Script_VarText02.Text + "\r\n" +
                    "       set outbandwidth " + Script_VarText02.Text + "\r\n" +
                    "       set alias " + '"' + "WAN" + '"' + "\r\n" +
                    "       set type physical\r\n" +
                    "       set role wan\r\n" +
                    "   next\r\n" +
                    "#\r\n" +
                    vlanNaWAN +
                    "#\r\n" +
                    "################# Configuracao de LAN ################## \r\n" +
                    "#\r\n" +
                    "    edit " + '"' + "lan1" + '"' + "\r\n" +
                    "        set vdom " + '"' + "root" + '"' + "\r\n" +
                    "        set speed auto\r\n" +
                    "        set description " + '"' + "CONEXAO LAN" + '"' + "\r\n" +
                    "        set ip " + Script_VarText09.Text + " " + mascaraStr + "\r\n" +
                    "        set allowaccess ping https ssh snmp http telnet\r\n" +
                    "        set type physical\r\n" +
                    "        set role lan\r\n" +
                    "    next\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    loopbackCliente +
                    "#\r\n" +
                    "#\r\n" +
                    "#################  ROTEAMENTO BGP ################## \r\n" +
                    "#\r\n" +
                    "config router bgp\r\n" +
                    "    set as " + Script_VarText12.Text + "\r\n" +
                    "    set log-neighbour-changes enable\r\n" +
                    "    set router-id " + Script_VarText07.Text + "\r\n" +
                    "    config neighbor\r\n" +
                    "    edit " + '"' + Script_VarText08.Text + '"' + "\r\n" +
                    "        set allowas-in-enable enable\r\n" +
                    "        set description " + '"' + designacao + '"' + "\r\n" +
                    "        set soft-reconfiguration enable\r\n" +
                    "        set remote-as 4230\r\n" +
                    "    next\r\n" +
                    "    end\r\n" +
                    "#\r\n" +
                    "    config redistribute " + '"' + "connected" + '"' + "\r\n" +
                    "    set status enable\r\n" +
                    "end\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "############ POLICY PARA LIBERAR TODO O TRÁFEGO ############# \r\n" +
                    "#\r\n" +
                    "config firewall policy\r\n" +
                    "    edit 1\r\n" +
                    "        set name " + '"' + "ANY" + '"' + "\r\n" +
                    "        set srcintf " + '"' + "any" + '"' + "\r\n" +
                    "        set dstintf " + '"' + "any" + '"' + "\r\n" +
                    "        set srcaddr " + '"' + "all" + '"' + "\r\n" +
                    "        set dstaddr " + '"' + "all" + '"' + "\r\n" +
                    "        set action accept\r\n" +
                    "        set schedule " + '"' + "always" + '"' + "\r\n" +
                    "        set service " + '"' + "ALL" + '"' + "\r\n" +
                    "        set logtraffic disable\r\n" +
                    "        set diffserv-forward enable\r\n" +
                    "        set diffservcode-forward 000000\r\n" +
                    "    next\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "#\r\n";

            }


            // ------------------------------------------- Logs - Cisco - BLD -------------------------------------------------------

            else if ((type == RouterType.Cisco) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - CISCO - BLD";

                VarScriptDisplayControl("03,04,05,06,07");

                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Hide();

                ButtonParte2.Show();
                ButtonLimpeza.Show();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Show();
                Script_ISRLabel.Show();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Show();


                // --- Others ---
                string vlanWan = "!\r\n";
                string intLan = "!\r\n";
                string vlanLan = "!\r\n";
                string policyLan = "!\r\n";

                if (Script_VarText05.Text != string.Empty)
                {
                    sourceLan = "source " + Script_VarText05.Text;
                    intLan = "show interface " + Script_VarText05.Text + "\r\n" +
                        "!\r\n" +
                        "!######################## \r\n";
                    policyLan = "show policy-map interface " + Script_VarText05.Text + "\r\n" + "!\r\n" + "!\r\n";
                }
                else
                {
                    policyLan = "!\r\n";
                    sourceLan = "";
                    intLan = "!\r\n";
                }
                if (Script_VarText04.Text != string.Empty)
                {
                    vlanWan = "show interface " + Script_VarText04.Text + "\r\n" +
                        "!\r\n" +
                        "!######################## \r\n"; ;
                }
                else
                {
                    vlanWan = "!\r\n";
                }
                if (Script_VarText06.Text != string.Empty)
                {
                    vlanLan = "show interface " + Script_VarText06.Text + "\r\n";
                }
                else
                {
                    vlanLan = "!\r\n";
                }


                // ---------------------------------------------------
                // Parte 1
                // ---------------------------------------------------
                Script_TextBox.Text = "terminal length 0 \r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "undebug all\r\n" +
                    "wr memory\r\n" +
                    "terminal length 0\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!############## CONFIGURACOES " + logType + " DO CPE ################ \r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#            CONFIGURACOES            #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "show startup-config\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "show ip int brief\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#            INTERFACES               #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "show interface " + Script_VarText03.Text + "\r\n" +
                    "!\r\n" +
                    "!######################## \r\n" +
                    "!\r\n" +
                    vlanWan +
                    "!\r\n" +
                    "!######################## \r\n" +
                    "!\r\n" +
                    intLan +
                    "!\r\n" +
                    "!######################## \r\n" +
                    "!\r\n" +
                    vlanLan +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#            SYSTEM INFO              #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "show version\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "show invent\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#              POLICY-MAP             #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "show policy-map\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "show policy-map interface " + Script_VarText03.Text + "\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    policyLan +
                    "!#######################################\r\n" +
                    "!#          TABELA DE ROTEAMENTO       #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "show ip route summary\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#                PING                 #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "ping " + Script_VarText07.Text + " repeat 200 size 1500 data 5050 " + sourceLan + "\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n";


                // ---------------------------------------------------
                // Parte 2
                // ---------------------------------------------------
                scriptParte2 = "##### Configuracoes " + logType + " no CPE - Parte II ##### \r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ HSRP ################\r\n" +
                "!\r\n" +
                "sh standby bri\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ VRRP ################\r\n" +
                "!\r\n" +
                "sh vrrp bri\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ GLBP ################\r\n" +
                "!\r\n" +
                "sh glbp standby detail active\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ NAT ################\r\n" +
                "!\r\n" +
                "sh ip nat trans\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ OSPF ################\r\n" +
                "!\r\n" +
                "show ip ospf neighbor\r\n" +
                "!\r\n" +
                "show ip ospf interface brief\r\n" +
                "!\r\n" +
                "show ip ospf database\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ RIP ################\r\n" +
                "!\r\n" +
                "show ip rip database\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ EIGRP ################\r\n" +
                "!\r\n" +
                "show ip eigrp neighbors\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n";


                // ---------------------------------------------------
                // Limpeza
                // ---------------------------------------------------
                scriptLimpeza = "!\r\n" +
                "conf t\r\n" +
                "!\r\n" +
                "no ip dhcp excluded-address 10.10.10.1\r\n" +
                "!\r\n" +
                "no ip dhcp pool ccp-pool\r\n" +
                "!\r\n" +
                "no ip domain name yourdomain.com\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no crypto pki trustpoint TP-self-signed-4256465151\r\n" +
                "!\r\n" +
                "yes\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no crypto pki certificate chain TP-self-signed-4256465151\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "default interface Vlan1\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "service password-encryption\r\n" +
                "username EBT privilege 10 password CQMR\r\n" +
                "enable secret PRO1AN\r\n" +
                "logging buffered 4096 debugging\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no ip http server\r\n" +
                "no ip http access-class 23\r\n" +
                "no ip http authentication local\r\n" +
                "no ip http secure-server\r\n" +
                "no ip http timeout-policy idle 60 life 86400 requests 10000\r\n" +
                "no logging trap notifications\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no access-list 23 permit 10.10.10.0 0.0.0.7\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no banner exec ^C\r\n" +
                "no banner login ^C\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "line con 0\r\n" +
                " no password\r\n" +
                " exec-timeout 15 0\r\n" +
                "login local\r\n" +
                "line aux 0\r\n" +
                " no password\r\n" +
                "login local\r\n" +
                " transport input none\r\n" +
                "line vty 0 4\r\n" +
                " no password\r\n" +
                " exec-timeout 15 0\r\n" +
                " login local\r\n" +
                " transport input telnet ssh\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "banner motd ^C\r\n" +
                "||========================================|| \r\n" +
                "||===========CLARO Brasil S.A.============|| \r\n" +
                "||========================================||  \r\n" +
                "                                             \r\n" +
                "        SOMENTE USUARIOS AUTORIZADOS         \r\n" +
                "           AUTHORIZED USERS ONLY             \r\n" +
                "                                             \r\n" +
                "        OS ACESSOS SERAO MONITORADOS         \r\n" +
                "         ACCESSES WILL BE MONITORED          \r\n" +
                "                                             \r\n" +
                "||========================================||^\r\n" +
                "end\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n";



            }

            // ------------------------------------------- Logs - HPE - BLD -------------------------------------------------------

            else if ((type == RouterType.HPE) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - HPE - BLD";

                VarScriptDisplayControl("03,04,05,06,07,09");

                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Hide();

                ButtonParte2.Show();
                ButtonLimpeza.Show();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Show();

                // --- Others ---
                string vlanWan = "#\r\n";
                string intLan = "#\r\n";
                string vlanLan = "#\r\n";

                if (Script_VarText09.Text != string.Empty)
                {
                    sourceLan = " -a " + Script_VarText09.Text;
                }
                else
                {
                    sourceLan = "";
                }
                if (Script_VarText04.Text != string.Empty)
                {
                    vlanWan = "display interface " + Script_VarText04.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n";
                }
                else
                {
                    vlanWan = "#\r\n";
                }
                if (Script_VarText05.Text != string.Empty)
                {
                    intLan = "display interface " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n";
                }
                else
                {
                    intLan = "#\r\n";
                }
                if (Script_VarText06.Text != string.Empty)
                {
                    vlanLan = "display interface " + Script_VarText06.Text + "\r\n";
                }
                else
                {
                    vlanLan = "#\r\n";
                }


                // ---------------------------------------------------
                // Parte 1
                // ---------------------------------------------------
                Script_TextBox.Text = "screen-length disable\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "############## CONFIGURAÇÕES " + logType + " DO CPE ################ \r\n" +
                    "#\r\n" +
                    "sys\r\n" +
                    "save f\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "#            CONFIGURACOES             #\r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "display saved-configuration\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ip interface brief\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "#             INTERFACES               #\r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "display interface " + Script_VarText03.Text + "\r\n" +
                    "#\r\n" +
                    "######################## \r\n" +
                    "#\r\n" +
                    vlanWan +
                    "#\r\n" +
                    "#\r\n" +
                    intLan +
                    "#\r\n" +
                    "#\r\n" +
                    vlanLan +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "!#######################################\r\n" +
                    "#            SYSTEM INFO               #\r\n" +
                    "!#######################################\r\n" +
                    "#\r\n" +
                    "display version\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display device manuinfo\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "#         TABELA DE ROTEAMENTO         #\r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "display ip routing-table\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ip routing-table statistics\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "#                 PING                 # \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "ping -s 1500 -c 20" + sourceLan + " " + Script_VarText07.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n";


                // ---------------------------------------------------
                // Parte 2
                // ---------------------------------------------------
                scriptParte2 = "##### Configuracoes " + logType + " no CPE - Parte II ##### \r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################ VRRP ################\r\n" +
                    "# \r\n" +
                    "display vrrp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################ NAT ################\r\n" +
                    "# \r\n" +
                    "display nat session\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################ OSPF ################\r\n" +
                    "#\r\n" +
                    "display ospf peer\r\n" +
                    "#\r\n" +
                    "display ospf interface\r\n" +
                    "#\r\n" +
                    "display ospf lsdb\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################ RIP ################\r\n" +
                    "#\r\n" +
                    "display rip 1 neighbor\r\n" +
                    "#\r\n" +
                    "display rip 1 database\r\n" +
                    "#\r\n" +
                    "display rip 1 route\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n";


                // ---------------------------------------------------
                // Limpeza
                // ---------------------------------------------------
                scriptLimpeza = "system-view\r\n" +
                    "#\r\n" +
                    "undo local-user admin class manage\r\n" +
                    "undo snmp-agent\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "domain system\r\n" +
                    "access-limit disable\r\n" +
                    "state active\r\n" +
                    "idle-cut disable\r\n" +
                    "self-service-url disable\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "telnet server enable\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "local-user EBT\r\n" +
                    "password cipher PRO1AN\r\n" +
                    "authorization-attribute level 3\r\n" +
                    "service-type telnet\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "interface Vlan-interface1\r\n" +
                    " undo ip address\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "undo interface Vlan-interface1 \r\n" +
                    "# \r\n" +
                    "# \r\n" +
                    "undo dhcp server ip-pool lan1\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "user-interface con 0\r\n" +
                    "user-interface tty 13\r\n" +
                    "user-interface vty 0 4\r\n" +
                    "authentication-mode scheme\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "header motd %\r\n" +
                    "||========================================|| \r\n" +
                    "||===========CLARO Brasil S.A.============|| \r\n" +
                    "||========================================|| \r\n" +
                    "                                             \r\n" +
                    "        SOMENTE USUARIOS AUTORIZADOS         \r\n" +
                    "           AUTHORIZED USERS ONLY             \r\n" +
                    "                                             \r\n" +
                    "        OS ACESSOS SERAO MONITORADOS         \r\n" +
                    "         ACCESSES WILL BE MONITORED          \r\n" +
                    "                                             \r\n" +
                    "||========================================|| \r\n" +
                    "%\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "quit\r\n";
            }

            // ------------------------------------------- Log - Fortigate - BLD -------------------------------------------------------

            else if ((type == RouterType.Fortigate) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - FORTIGATE - BLD";

                VarScriptDisplayControl("03,05,07,09");

                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Hide();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Show();
                Script_ModelLabel.Show();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Show();

                // --- Others ---
                if (Script_VarText09.Text != string.Empty)
                {
                    sourceLan = "execute ping-options source " + Script_VarText09.Text + "\r\n";
                }
                else
                {
                    sourceLan = "";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = "############ CONFIGURACOES  " + logType + " ############\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# SDWAN \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "########### Ver health-check #####################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan health-check status\r\n" +
                    "#\r\n" +
                    "########### Ver regras SDWAN ###################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan service\r\n" +
                    "#\r\n" +
                    "########### Ver membros SDWAN #################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan member\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# SNMP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system snmp community\r\n" +
                    "#\r\n" +
                    "show system snmp user\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# DHCP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system dhcp server\r\n" +
                    "#\r\n" +
                    "execute dhcp lease-list\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# NTP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system ntp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# VRRP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get router info vrrp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# OSPF \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get router info ospf interface\r\n" +
                    "#\r\n" +
                    "get router info ospf database brief\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# HA \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get system ha status\r\n" +
                    "#\r\n" +
                    "diagnose sys ha status\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# VPN \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "diagnose vpn ike gateway list\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "config system console\r\n" +
                    "set output standard\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# CONFIGURAÇÕES DO SYSTEMA \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show system global\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show system admin\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get system status\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show vpn certificate local\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# INTERFACES \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system interface\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get hardware nic " + Script_VarText03.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get hardware nic " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# FIREWALL POLICY \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "sho firewall policy\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# TABELA DE ROTEAMENTO \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get system arp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show router static\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# PING \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    sourceLan +
                    "#\r\n" +
                    "execute ping-options data 1500\r\n" +
                    "#\r\n" +
                    "execute ping-options repeat 20\r\n" +
                    "#\r\n" +
                    "execute ping " + Script_VarText07.Text + "\r\n" +
                    "#\r\n" +
                    "execute ping-options data 1400\r\n" +
                    "#\r\n" +
                    "execute ping 8.8.8.8\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n";
            }


            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log - Huawei - BLD -------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------

            else if ((type == RouterType.Huawei) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - HUAWEI - BLD";

                VarScriptDisplayControl("03,04,05,06,07,09");

                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Hide();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Show();

                string vlanLan = "#\r\n";
                string intLan = "#\r\n";

                // --- Others ---
                if (Script_VarText04.Text != string.Empty)
                {
                    vlanNaWAN = "display interface " + Script_VarText04.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n";
                }
                else
                {
                    vlanNaWAN = "#\r\n";
                }
                if (Script_VarText05.Text != string.Empty)
                {
                    intLan = "display interface " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n";
                }
                {
                    intLan = "#\r\n";
                }

                if (Script_VarText06.Text != string.Empty)
                {
                    vlanLan = "display interface " + Script_VarText06.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n";
                }
                else
                {
                    vlanLan = "#\r\n";
                }

                if (Script_VarText09.Text != string.Empty)
                {
                    sourceLan = "-a " + Script_VarText09.Text + " ";
                }
                else
                {
                    sourceLan = "";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = "########### Configuracoes " + logType + " ############\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "screen-length 0 temporary\r\n" +
                    "#\r\n" +
                    "########################################################\r\n" +
                    "#\r\n" +
                    "display vrrp brief\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display nat session all\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ospf peer\r\n" +
                    "#\r\n" +
                    "display ospf interface\r\n" +
                    "#\r\n" +
                    "display ospf lsdb\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display rip 1 neighbor\r\n" +
                    "#\r\n" +
                    "display rip 1 database\r\n" +
                    "#\r\n" +
                    "display rip 1 route\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "save\r\n" +
                    "y\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# CONFIGURACOES \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display saved-configuration\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# INTERFACES \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "display ip interface brief\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display interface " + Script_VarText03.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    vlanNaWAN +
                    "#\r\n" +
                    "#\r\n" +
                    "display interface " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    vlanLan +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# SYSTEM \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display version\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display sn\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# POLICIES \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display traffic-policy applied-record\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display traffic policy statistics interface " + Script_VarText03.Text + " outbound \r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display traffic policy user-defined\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# Tabela de Roteamento \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ip routing-table protocol static\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ip routing-table\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ip routing-table statistics\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "ping -s 1500 -c 20 " + sourceLan + Script_VarText07.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n";
            }


            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log - Fortigate - MPLS ---------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------

            else if ((type == RouterType.Fortigate) && (activityType == ActivityType.MPLS) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - FORTIGATE - MPLS";

                VarScriptDisplayControl("03,05,07,09");

                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Hide();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Show();
                Script_ModelLabel.Show();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Show();

                // --- Others ---
                if (Script_VarText09.Text != "")
                {
                    sourceLan = "execute ping-options source " + Script_VarText09.Text + "\r\n";
                }
                else
                {
                    sourceLan = "#\r\n";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = "############ CONFIGURACOES  " + logType + " ############\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# SDWAN \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "########### Ver health-check #####################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan health-check status\r\n" +
                    "#\r\n" +
                    "########### Ver regras SDWAN ###################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan service\r\n" +
                    "#\r\n" +
                    "########### Ver membros SDWAN #################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan member\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# SNMP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system snmp community\r\n" +
                    "#\r\n" +
                    "show system snmp user\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# DHCP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system dhcp server\r\n" +
                    "#\r\n" +
                    "execute dhcp lease-list\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# NTP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system ntp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# VRRP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get router info vrrp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# OSPF \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get router info ospf interface\r\n" +
                    "#\r\n" +
                    "get router info ospf database brief\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# HA \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get system ha status\r\n" +
                    "#\r\n" +
                    "diagnose sys ha status\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# VPN \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "diagnose vpn ike gateway list\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###########################################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "config system console\r\n" +
                    "set output standard\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# CONFIGURAÇÕES DO SYSTEMA \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system global\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show system admin\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get system status\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show vpn certificate local\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# INTERFACES \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system interface\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get hardware nic " + Script_VarText03.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get hardware nic " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# FIREWALL \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "sho firewall policy\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show firewall traffic-class\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show firewall shaping-profile\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show system dscp-based-priority\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show firewall service custom\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show firewall address\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "diagnose netlink interface list " + Script_VarText03.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# TABELA DE ROTEAMENTO \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get system arp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show router static\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get router info routing-table all\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show router route-map\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# BGP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show router bgp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get router info bgp summary\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get router info bgp neighbors " + Script_VarText07.Text + "  advertised\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get router info bgp neighbors " + Script_VarText07.Text + " routes | grep Total\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# PING \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    sourceLan +
                    "#\r\n" +
                    "execute ping-options data 1500\r\n" +
                    "#\r\n" +
                    "execute ping-options repeat 20\r\n" +
                    "#\r\n" +
                    "execute ping " + Script_VarText07.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n";

            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log CPE Aligera ----------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------

            else if ((type == RouterType.Aligera) && (activityType == ActivityType.VOZ) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - ALIGERA - VOZ";

                VarScriptDisplayControl("07");

                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
                Script_LANMascaraText.Hide();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Show();


                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = "!######### CONFIGURACOES " + logType + " DO CPE ######### \r\n" +
                    "!\r\n" +
                    "config apply\r\n" +
                    "config save\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!# SYSTEM INFO \r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "status network\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "system info\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!# PING \r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "tools ping -c 20 -s 1500 " + Script_VarText07.Text + "\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!# STATUS E1 \r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "status tdm\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!# CONFIGURACOES \r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "config show\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n";

            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log Backbone - Cisco - BLD -----------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------

            else if ((type == RouterType.Cisco) && (activityType == ActivityType.BLD) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - BLD";

                VarScriptDisplayControl("03,08");

                Script_LANMascaraText.Hide();
                Script_TypeLabel.Show();
                Script_ComboBox.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Hide();

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = "!######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# INTERFACE  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# ROTA ESTATICA  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config | inc " + Script_VarText08.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show running-config | inc " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# POLICY-MAP  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show policy-map interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# PING  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "ping\r\n" +
                " \r\n" +
                Script_VarText08.Text + "\r\n" +
                "15\r\n" +
                "1500\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";
            }

            else if ((type == RouterType.Cisco) && (activityType == ActivityType.MPLS) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - MPLS";


                VarScriptDisplayControl("03,08,14");

                Script_LANMascaraText.Hide();
                Script_TypeLabel.Show();
                Script_ComboBox.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Show();
                Script_XRLabel.Show();

                buttonSwitchScriptLog.Hide();


                // --- Others ---
                string xr = "";

                if (Script_XRBox.SelectedIndex == 0)
                {
                    xr = "vpnv4 ";
                }
                else
                {
                    xr = "";
                }


                // --------------------------- Script -----------------------------------------

                Script_TextBox.Text = "!######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# INTERFACE  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config interface " + Script_VarText03.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "show interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# VRF \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config vrf " + Script_VarText14.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# ROTA ESTATICA \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config | inc " + Script_VarText08.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show running-config | inc " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# POLICY-MAP \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show policy-map interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# BGP  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config router bgp 4230 vrf " + Script_VarText14.Text + " neighbor " + Script_VarText08.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!################################## \r\n" +
                " \r\n" +
                "show ip bgp " + xr + "vrf " + Script_VarText14.Text + " summary\r\n" +
                " \r\n" +
                " \r\n" +
                "!################################## \r\n" +
                " \r\n" +
                "show ip bgp " + xr + "vrf " + Script_VarText14.Text + " sum | inc " + Script_VarText08.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "!################################## \r\n" +
                " \r\n" +
                "show ip bgp " + xr + "vrf " + Script_VarText14.Text + " nei " + Script_VarText08.Text + " advertised-r | i xes r\n" +
                " \r\n" +
                " \r\n" +
                "!################################## \r\n" +
                " \r\n" +
                "show ip bgp " + xr + "vrf " + Script_VarText14.Text + " nei " + Script_VarText08.Text + " ro\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# PING  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "ping vrf " + Script_VarText14.Text + "\r\n" +
                "\r\n" +
                Script_VarText08.Text + "\r\n" +
                "15\r\n" +
                "1500\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";
            }

            else if ((type == RouterType.Cisco) && (activityType == ActivityType.VOZ) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - VOZ";

                VarScriptDisplayControl("03,08");

                Script_LANMascaraText.Hide();
                Script_TypeLabel.Show();
                Script_ComboBox.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Show();
                Script_XRLabel.Show();

                buttonSwitchScriptLog.Hide();

                // ------------------------------ Script ---------------------------------------
                Script_TextBox.Text = "!######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# INTERFACE  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# VRF  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config vrf REALIP_CLIENTE:5581\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# ROTA ESTATICA \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config | inc " + Script_VarText08.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show running-config | inc " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# POLICY-MAP  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show policy-map interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# PING  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "ping vrf REALIP_CLIENTE:5581\r\n" +
                " \r\n" +
                Script_VarText08.Text + "\r\n" +
                "15\r\n" +
                "1500\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";
            }


            else if ((type == RouterType.Cisco) && (activityType == ActivityType.BLDcomBGP) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - BLD com BGP";

                VarScriptDisplayControl("03,08");

                Script_LANMascaraText.Hide();
                Script_TypeLabel.Show();
                Script_ComboBox.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Hide();

                // ------------------------------ Script ---------------------------------------
                Script_TextBox.Text = "!######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# INTERFACE  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# ROTA ESTATICA  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config | inc " + Script_VarText08.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show running-config | inc " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# POLICY-MAP  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show policy-map interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# BGP  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config router bgp 4230 neighbor " + Script_VarText08.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show bgp sum | inc " + Script_VarText08.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show bgp neighbor " + Script_VarText08.Text + " routes\r\n" +
                " \r\n" +
                " \r\n" +
                "show bgp neig " + Script_VarText08.Text + " advertised-routes | inc xes\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# PING  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "ping\r\n" +
                " \r\n" +
                Script_VarText08.Text + "\r\n" +
                "15\r\n" +
                "1500\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";
            }



            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log Backbone Nokia -------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------

            else if ((type == RouterType.Nokia) && (activityType == ActivityType.BLD) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - BLD";

                VarScriptDisplayControl("03,07,08,13");

                Script_LANMascaraText.Hide();
                Script_TypeLabel.Show();
                Script_ComboBox.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Hide();


                // ------------------------------ Script ---------------------------------------
                Script_TextBox.Text = "######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# INTERFACE  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText07.Text + " context all\r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match expression " + Script_VarText03.Text + "[^0-9] context all\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "show router interface " + Script_VarText03.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# QoS  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show qos sap-ingress " + Script_VarText13.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show qos sap-egress " + Script_VarText13.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# ROTA ESTATICA  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText08.Text + " context all\r\n" +
                " \r\n" +
                " \r\n" +
                "show router static-route next-hop " + Script_VarText08.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText08.Text + " pre-line 1 post-lines 5\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# PING  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "ping " + Script_VarText08.Text + " size 1500 count 15 interface " + Script_VarText03.Text + " rapid\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";
            }


            else if ((type == RouterType.Nokia) && (activityType == ActivityType.MPLS) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - MPLS";

                VarScriptDisplayControl("03,07,08,13,14,15");

                Script_LANMascaraText.Hide();
                Script_TypeLabel.Show();
                Script_ComboBox.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Hide();


                // AS da VRF
                string vrfAS = " ";

                if (Script_VarText14.Text.Contains(':'))
                {
                    string[] splitStr = Script_VarText14.Text.Split(new char[] { ':' });
                    vrfAS = splitStr[1];
                }

                // ------------------------------ Script ---------------------------------------
                Script_TextBox.Text = "######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# INTERFACE  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText07.Text + " context all \r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match expression " + Script_VarText03.Text + "[^0-9] context all \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# VRF  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match expression " + '"' + "route-distinguisher " + "4230:" + vrfAS + '"' + " pre-line 8 post-lines 10" + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show router service-name " + Script_VarText15.Text + " interface " + Script_VarText03.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# QoS  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show qos sap-ingress " + Script_VarText13.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "show qos sap-egress " + Script_VarText13.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# ROTA ESTATICA  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show router service-name " + Script_VarText15.Text + " static-route next-hop " + Script_VarText08.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText08.Text + " pre-line 1 post-lines 6 \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# BGP  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText08.Text + " context all \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "################################# \r\n" +
                "\r\n" +
                "show router service-name " + Script_VarText15.Text + " bgp summary | match " + Script_VarText08.Text + " post-lines 3 \r\n" +
                " \r\n" +
                " \r\n" +
                "################################# \r\n" +
                " \r\n" +
                "show router service-name " + Script_VarText15.Text + " bgp neighbor " + Script_VarText08.Text + " received-routes \r\n" +
                " \r\n" +
                " \r\n" +
                "################################# \r\n" +
                " \r\n" +
                "show router service-name " + Script_VarText15.Text + " bgp neighbor " + Script_VarText08.Text + " advertised-routes | match Routes \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# PING  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "ping service-name " + Script_VarText15.Text + " " + Script_VarText08.Text + " size 1500 count 15 interface " + Script_VarText03.Text + " rapid \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";
            }

            else if ((type == RouterType.Nokia) && (activityType == ActivityType.VOZ) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - VOZ";

                VarScriptDisplayControl("03,07,08,13");

                Script_LANMascaraText.Hide();
                Script_TypeLabel.Show();
                Script_ComboBox.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Hide();


                // ------------------------------ Script ---------------------------------------
                Script_TextBox.Text = "######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# INTERFACE  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText07.Text + " context all \r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match expression " + Script_VarText03.Text + "[^0-9] context all \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# VRF  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match expression " + '"' + "route-distinguisher " + "4230:5581" + '"' + " pre-line 6 post-lines 6" + " \r\n" +
                " \r\n" +
                " \r\n" +
                "show router service-name 1000 interface " + Script_VarText03.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# QoS  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show qos sap-ingress " + Script_VarText13.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "show qos sap-egress " + Script_VarText13.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# ROTA ESTATICA  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText08.Text + " context all \r\n" +
                " \r\n" +
                " \r\n" +
                "show router service-name 1000 static-route next-hop " + Script_VarText08.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText08.Text + " pre-line 1 post-lines 5 \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# PING  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "ping service-name 1000 " + Script_VarText08.Text + " size 1500 count 15 interface " + Script_VarText03.Text + " rapid \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";
            }

            else if ((type == RouterType.Nokia) && (activityType == ActivityType.BLDcomBGP) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - BLD com BGP";

                VarScriptDisplayControl("03,07,08,13");

                Script_LANMascaraText.Hide();
                Script_TypeLabel.Show();
                Script_ComboBox.Show();

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Hide();


                // --- Others ---

                string policyExport2 = "\r\n";

                if (Script_VarRouteE2.Text != string.Empty)
                {
                    policyExport2 = "show router policy " + Script_VarRouteE2.Text + "\r\n" + "\r\n";
                }
                else
                {
                    policyExport2 = "\r\n";
                }


                // ------------------------------ Script ---------------------------------------

                Script_TextBox.Text = "######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# INTERFACE  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText07.Text + " context all \r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match expression " + Script_VarText03.Text + "[^0-9] context all \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "show router interface " + Script_VarText03.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# QoS  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show qos sap-ingress " + Script_VarText13.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "show qos sap-egress " + Script_VarText13.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# ROTA ESTATICA  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show router static-route next-hop " + Script_VarText08.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText08.Text + " pre-line 1 post-lines 56 \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# BGP   \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match " + Script_VarText08.Text + " context all \r\n" +
                " \r\n" +
                " \r\n" +
                "######## BGP - ROUTE MAPS ######## \r\n" +
                " \r\n" +
                "show router policy " + Script_VarRouteI1.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show router policy " + Script_VarRouteI2.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show router policy " + Script_VarRouteE1.Text + "\r\n" +
                " \r\n" +
                " \r\n" +
                policyExport2 +
                " \r\n" +
                " \r\n" +
                "######## BGP - NEIGHBORS ######## \r\n" +
                " \r\n" +
                "show router bgp neighbor " + Script_VarText08.Text + " advertised-routes | match Routes\r\n" +
                " \r\n" +
                " \r\n" +
                "show router bgp summary | match " + Script_VarText08.Text + " post-lines 3\r\n" +
                " \r\n" +
                " \r\n" +
                "show router bgp neighbor " + Script_VarText08.Text + " received-routes\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# PING  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "ping " + Script_VarText08.Text + " size 1500 count 15 interface " + Script_VarText03.Text + " rapid \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";
            }


            else
            {
                player.Play();
                MessageBox.Show("Not Implemented");

                Script_ProcedureName.Text = "ERROR";

                Script_VarName00.Hide();
                Script_VarName01.Hide();
                Script_VarName02.Hide();
                Script_VarName03.Hide();
                Script_VarName04.Hide();
                Script_VarName05.Hide();
                Script_VarName06.Hide();
                Script_VarName07.Hide();
                Script_VarName08.Hide();
                Script_VarName09.Hide();
                Script_VarName10.Hide();
                Script_VarName11.Hide();
                Script_VarName12.Hide();
                Script_VarName13.Hide();
                Script_VarName14.Hide();
                Script_VarName15.Hide();

                Script_VarText00.Hide();
                Script_VarText01.Hide();
                Script_VarText02.Hide();
                Script_VarText03.Hide();
                Script_VarText04.Hide();
                Script_VarText05.Hide();
                Script_VarText06.Hide();
                Script_VarText07.Hide();
                Script_VarText08.Hide();
                Script_VarText09.Hide();
                Script_VarText10.Hide();
                Script_VarText11.Hide();
                Script_VarText12.Hide();
                Script_VarText13.Hide();
                Script_VarText14.Hide();
                Script_VarText15.Hide();

                Script_DeleteVar00.Hide();
                Script_DeleteVar01.Hide();
                Script_DeleteVar02.Hide();
                Script_DeleteVar03.Hide();
                Script_DeleteVar04.Hide();
                Script_DeleteVar05.Hide();
                Script_DeleteVar06.Hide();
                Script_DeleteVar07.Hide();
                Script_DeleteVar08.Hide();
                Script_DeleteVar09.Hide();
                Script_DeleteVar10.Hide();
                Script_DeleteVar11.Hide();
                Script_DeleteVar12.Hide();
                Script_DeleteVar13.Hide();
                Script_DeleteVar14.Hide();
                Script_DeleteVar15.Hide();

                Script_LANMascaraText.Hide();
                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();

                Script_TextBox.Text = "";

                ButtonParte2.Hide();
                ButtonLimpeza.Hide();

                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
                Script_XRBox.Hide();
                Script_XRLabel.Hide();

                buttonSwitchScriptLog.Hide();
            }
        }
        #endregion


        // ---------------------------

        // NEW
        #region
        public void ScriptDispatch(RouterType routerType, ActivityType activityType, bool logOrNot, bool backboneOrNot)
        {
            ApplyRouteMapNokia();
            ApplyLogType();
            ChangeMascaraLAN();
            ChangeVlanNaWANVar();
            GetDesignacao(Script_VarText01.Text);
            ChangeLANIPTextBoxSize();

            if (Script_ComboBox.Text == null)
            {
                Script_ComboBox.Text = "INICIAIS";
            }

            if (logOrNot && backboneOrNot == false)
            {
                SwitchLabel.Show();
                buttonSwitchScriptLog.Show();
            }
            else
            {
                SwitchLabel.Hide();
                buttonSwitchScriptLog.Hide();
            }


            // ------------------------------------------- Config - Cisco - BLD -------------------------------------------------------

            if (routerType == RouterType.Cisco && activityType == ActivityType.BLD && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - CISCO - BLD";

                VarScriptDisplayControl("00,01,02,03,04,05,07,09,10");

                ExtraVariablesControl(false, false, true, false, false, false);

                ApplyScript(scripts[0]);


                // --- Others ---
                string vlanNTP = "";

                if (Script_VarText04.Text != string.Empty)
                {
                    withVlan = "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "encapsulation dot1Q " + Script_VarText04.Text + "\r\n";

                    vlanNTP = "." + Script_VarText04.Text;

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                   vlanNTP = "";
                   withVlan = "!\r\n";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;

            }

            // ------------------------------------------- Config - HPE - BLD -------------------------------------------------------

            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - HPE - BLD";

                VarScriptDisplayControl("00,01,02,03,04,05,07,09,10");

                ExtraVariablesControl(false, false, false, false, false, false);

                ApplyScript(scripts[0]);

                // --- Others ---
                if (Script_VarText04.Text != string.Empty)
                {
                    withVlan = "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n";

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    withVlan = "#\r\n";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;


            }


            // ------------------------------------------- Config - Fortigate - BLD -------------------------------------------------------

            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - FORTIGATE - BLD";

                VarScriptDisplayControl("00,01,02,03,04,05,07,09,10");

                ExtraVariablesControl(true, false, false, false, false, false);

                ApplyScript(scripts[0]);

                // --- Others ---
                vlanNaWAN = "# \r\n";
                sourceLan = "";

                if (Script_VarText04.Text != string.Empty)
                {
                    vlanNaWAN = "################# Configuracao VLAN na WAN  #################### \r\n" +
                        "#\r\n" +
                        "    edit " + '"' + Script_VarText03.Text + "." + Script_VarText04.Text + '"' + "\r\n" +
                        "       set vdom " + '"' + "root" + '"' + "\r\n" +
                        "       set allowaccess ping https ssh telnet snmp\r\n" +
                        "       set description " + '"' + Script_VarText01.Text + '"' + "\r\n" +
                        "       set alias " + '"' + "WAN" + '"' + "\r\n" +
                        "       set role wan\r\n" +
                        "       set interface " + Script_VarText03.Text + "\r\n" +
                        "       set vlanid " + Script_VarText04.Text + "\r\n" +
                        "   next\r\n" +
                        "#\r\n" +
                        "#\r\n" +
                        "#\r\n";
                    sourceLan = "." + Script_VarText04.Text;

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    vlanNaWAN = "#\r\n";
                    sourceLan = "";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;
            }


            // ------------------------------------------- Config - Huawei - BLD -------------------------------------------------------

            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - HUAWEI - BLD";

                VarScriptDisplayControl("00,01,02,03,04,05,07,09,10");

                ExtraVariablesControl(false, false, false, false, false, false);

                ApplyScript(scripts[0]);

                // --- Others ---
                if (Script_VarText04.Text != string.Empty)
                {
                    withVlan = "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                        " description " + Script_VarText01.Text + "\r\n" +
                        " dot1q termination vid " + Script_VarText04.Text + "\r\n" +
                        " bandwidth " + Script_VarText02.Text + "\r\n";

                    MessageBox.Show("Com Vlan");
                    sourceLan = "." + Script_VarText04.Text;
                }
                else
                {
                    sourceLan = "";
                    withVlan = "#\r\n";
                }

                buttonSwitchScriptLog.Hide();


                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;

            }

            // ------------------------------------------- Config - Fortigate - MPLS -------------------------------------------------------

            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.MPLS) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - FORTIGATE - MPLS";

                VarScriptDisplayControl("00,01,02,03,04,05,07,09,11,12");

                ExtraVariablesControl(true, false, false, false, false, false);

                ApplyScript(scripts[0]);

                // --- Others ---
                vlanNaWAN = "# \r\n";

                if (Script_VarText04.Text != string.Empty)
                {
                    vlanNaWAN = "################# Configuracao VLAN na WAN  ##################### \r\n" +
                        "#\r\n" +
                        "    edit " + '"' + Script_VarText03.Text + "." + Script_VarText04.Text + '"' + "\r\n" +
                        "       set vdom " + '"' + "root" + '"' + "\r\n" +
                        "       set allowaccess ping https ssh telnet snmp\r\n" +
                        "       set description " + '"' + Script_VarText01.Text + '"' + "\r\n" +
                        "       set alias " + '"' + "WAN" + '"' + "\r\n" +
                        "       set role wan\r\n" +
                        "       set interface " + Script_VarText03.Text + "\r\n" +
                        "       set vlanid " + Script_VarText04.Text + "\r\n" +
                        "   next\r\n" +
                        "#\r\n" +
                        "#\r\n" +
                        "#\r\n";

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    vlanNaWAN = "# \r\n";
                }

                // ---------------------------------------------------------

                if (Script_VarText11.Text != string.Empty)
                {
                    loopbackCliente = "################# Loopback Cliente  ##################### \r\n" +
                        "#\r\n" +
                        "edit " + '"' + "Loopback21" + '"' + "\r\n" +
                        "        set vdom " + '"' + "root" + '"' + "\r\n" +
                        "        set ip " + Script_VarText11.Text + " " + " 255.255.255.255\r\n" +
                        "        set allowaccess ping ssh snmp telnet probe-response\r\n" +
                        "        set icmp-send-redirect disable\r\n" +
                        "        set icmp-accept-redirect disable\r\n" +
                        "        set type loopback\r\n" +
                        "        set description " + '"' + "Loopback21" + '"' + "\r\n" +
                        "        next\r\n" +
                        "end\r\n";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;

            }


            // ------------------------------------------- Logs - Cisco - BLD -------------------------------------------------------

            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - CISCO - BLD";

                VarScriptDisplayControl("03,04,05,06,07");

                ExtraVariablesControl(false, false, true, true, true, false);

                ApplyScript(scripts[0]);

                // --- Others ---
                string vlanWan = "!\r\n";
                string intLan = "!\r\n";
                string vlanLan = "!\r\n";
                string policyLan = "!\r\n";

                if (Script_VarText05.Text != string.Empty)
                {
                    sourceLan = "source " + Script_VarText05.Text;
                    intLan = "show interface " + Script_VarText05.Text + "\r\n" +
                        "!\r\n" +
                        "!######################## \r\n";
                    policyLan = "show policy-map interface " + Script_VarText05.Text + "\r\n" + "!\r\n" + "!\r\n";
                }
                else
                {
                    policyLan = "!\r\n";
                    sourceLan = "";
                    intLan = "!\r\n";
                }
                if (Script_VarText04.Text != string.Empty)
                {
                    vlanWan = "show interface " + Script_VarText04.Text + "\r\n" +
                        "!\r\n" +
                        "!######################## \r\n"; ;
                }
                else
                {
                    vlanWan = "!\r\n";
                }
                if (Script_VarText06.Text != string.Empty)
                {
                    vlanLan = "show interface " + Script_VarText06.Text + "\r\n";
                }
                else
                {
                    vlanLan = "!\r\n";
                }


                // ---------------------------------------------------
                // Parte 1
                // ---------------------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;


                // ---------------------------------------------------
                // Parte 2
                // ---------------------------------------------------
                scriptParte2 = scripts[0].scriptString;


                // ---------------------------------------------------
                // Limpeza
                // ---------------------------------------------------
                scriptLimpeza = scripts[0].scriptString;

            }

            // ------------------------------------------- Logs - HPE - BLD -------------------------------------------------------

            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - HPE - BLD";

                VarScriptDisplayControl("03,04,05,06,07,09");

                ExtraVariablesControl(false, false, false, true, false, true);

                scriptPrincipal = scripts[0].scriptString;
                ApplyScript(scripts[0]);

                // --- Others ---
                string vlanWan = "#\r\n";
                string intLan = "#\r\n";
                string vlanLan = "#\r\n";

                if (Script_VarText09.Text != string.Empty)
                {
                    sourceLan = " -a " + Script_VarText09.Text;
                }
                else
                {
                    sourceLan = "";
                }
                if (Script_VarText04.Text != string.Empty)
                {
                    vlanWan = "display interface " + Script_VarText04.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n";
                }
                else
                {
                    vlanWan = "#\r\n";
                }
                if (Script_VarText05.Text != string.Empty)
                {
                    intLan = "display interface " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n";
                }
                else
                {
                    intLan = "#\r\n";
                }
                if (Script_VarText06.Text != string.Empty)
                {
                    vlanLan = "display interface " + Script_VarText06.Text + "\r\n";
                }
                else
                {
                    vlanLan = "#\r\n";
                }


                // ---------------------------------------------------
                // Parte 1
                // ---------------------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;


                // ---------------------------------------------------
                // Parte 2
                // ---------------------------------------------------
                scriptParte2 = scripts[0].scriptString;


                // ---------------------------------------------------
                // Limpeza
                // ---------------------------------------------------
                scriptLimpeza = scripts[0].scriptString;
            }

            // ------------------------------------------- Log - Fortigate - BLD -------------------------------------------------------

            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - FORTIGATE - BLD";

                VarScriptDisplayControl("03,05,07,09");

                ExtraVariablesControl(true, false, false, false, false, false);

                ApplyScript(scripts[0]);

                // --- Others ---
                if (Script_VarText09.Text != string.Empty)
                {
                    sourceLan = "execute ping-options source " + Script_VarText09.Text + "\r\n";
                }
                else
                {
                    sourceLan = "";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;
            }


            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log - Huawei - BLD -------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------

            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - HUAWEI - BLD";

                VarScriptDisplayControl("03,04,05,06,07,09");

                ExtraVariablesControl(false, false, false, false, false, false);

                ApplyScript(scripts[0]);

                string vlanLan = "#\r\n";
                string intLan = "#\r\n";

                // --- Others ---
                if (Script_VarText04.Text != string.Empty)
                {
                    vlanNaWAN = "display interface " + Script_VarText04.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n";
                }
                else
                {
                    vlanNaWAN = "#\r\n";
                }
                if (Script_VarText05.Text != string.Empty)
                {
                    intLan = "display interface " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n";
                }
                {
                    intLan = "#\r\n";
                }

                if (Script_VarText06.Text != string.Empty)
                {
                    vlanLan = "display interface " + Script_VarText06.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n";
                }
                else
                {
                    vlanLan = "#\r\n";
                }

                if (Script_VarText09.Text != string.Empty)
                {
                    sourceLan = "-a " + Script_VarText09.Text + " ";
                }
                else
                {
                    sourceLan = "";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;
            }


            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log - Fortigate - MPLS ---------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------

            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.MPLS) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - FORTIGATE - MPLS";

                VarScriptDisplayControl("03,05,07,09");

                ExtraVariablesControl(true, false, false, false, false, false);


                ApplyScript(scripts[0]);

                // --- Others ---
                if (Script_VarText09.Text != "")
                {
                    sourceLan = "execute ping-options source " + Script_VarText09.Text + "\r\n";
                }
                else
                {
                    sourceLan = "#\r\n";
                }

                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;

            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log CPE Aligera ----------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------

            else if ((routerType == RouterType.Aligera) && (activityType == ActivityType.VOZ) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - ALIGERA - VOZ";

                VarScriptDisplayControl("07");

                ExtraVariablesControl(false, false, false, false, false, false);



                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;

            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log Backbone - Cisco - BLD -----------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------

            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.BLD) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - BLD";

                VarScriptDisplayControl("03,08");

                ExtraVariablesControl(false, false, false, false, false, true);


                // --------------------------- Script -----------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;
            }

            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.MPLS) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - MPLS";

                VarScriptDisplayControl("03,08,14");

                ExtraVariablesControl(false, true, false, false, false, true);


                // --- Others ---
                string xr = "";

                if (Script_XRBox.SelectedIndex == 0)
                {
                    xr = "vpnv4 ";
                }
                else
                {
                    xr = "";
                }


                // --------------------------- Script -----------------------------------------

                Script_TextBox.Text = scripts[0].scriptString;
            }

            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.VOZ) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - VOZ";

                VarScriptDisplayControl("03,08");

                ExtraVariablesControl(false, true, false, false, false, true);


                // ------------------------------ Script ---------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;
            }


            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.BLDcomBGP) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - BLD com BGP";

                VarScriptDisplayControl("03,08");

                ExtraVariablesControl(false, false, false, false, false, true);


                // ------------------------------ Script ---------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;
            }



            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log Backbone Nokia -------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------

            else if ((routerType == RouterType.Nokia) && (activityType == ActivityType.BLD) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - BLD";

                VarScriptDisplayControl("03,07,08,13");

                ExtraVariablesControl(false, false, false, false, false, true);


                // ------------------------------ Script ---------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;
            }


            else if ((routerType == RouterType.Nokia) && (activityType == ActivityType.MPLS) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - MPLS";

                VarScriptDisplayControl("03,07,08,13,14,15");

                ExtraVariablesControl(false, false, false, false, false, true);


                // AS da VRF
                string vrfAS = " ";

                if (Script_VarText14.Text.Contains(':'))
                {
                    string[] splitStr = Script_VarText14.Text.Split(new char[] { ':' });
                    vrfAS = splitStr[1];
                }

                // ------------------------------ Script ---------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;
            }

            else if ((routerType == RouterType.Nokia) && (activityType == ActivityType.VOZ) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - VOZ";

                VarScriptDisplayControl("03,07,08,13");

                ExtraVariablesControl(false, false, false, false, false, true);



                // ------------------------------ Script ---------------------------------------
                Script_TextBox.Text = scripts[0].scriptString;
            }

            else if ((routerType == RouterType.Nokia) && (activityType == ActivityType.BLDcomBGP) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - BLD com BGP";

                VarScriptDisplayControl("03,07,08,13");

                ExtraVariablesControl(false, false, false, false, false, true);


                // --- Others ---

                string policyExport2 = "\r\n";

                if (Script_VarRouteE2.Text != string.Empty)
                {
                    policyExport2 = "show router policy " + Script_VarRouteE2.Text + "\r\n" + "\r\n";
                }
                else
                {
                    policyExport2 = "\r\n";
                }


                // ------------------------------ Script ---------------------------------------

                Script_TextBox.Text = scripts[0].scriptString;
            }


            else
            {
                player.Play();
                MessageBox.Show("Not Implemented");

                Script_ProcedureName.Text = "ERROR";

                ExtraVariablesControl(false, false, false, false, false, false);

                Script_VarName00.Hide();
                Script_VarName01.Hide();
                Script_VarName02.Hide();
                Script_VarName03.Hide();
                Script_VarName04.Hide();
                Script_VarName05.Hide();
                Script_VarName06.Hide();
                Script_VarName07.Hide();
                Script_VarName08.Hide();
                Script_VarName09.Hide();
                Script_VarName10.Hide();
                Script_VarName11.Hide();
                Script_VarName12.Hide();
                Script_VarName13.Hide();
                Script_VarName14.Hide();
                Script_VarName15.Hide();

                Script_VarText00.Hide();
                Script_VarText01.Hide();
                Script_VarText02.Hide();
                Script_VarText03.Hide();
                Script_VarText04.Hide();
                Script_VarText05.Hide();
                Script_VarText06.Hide();
                Script_VarText07.Hide();
                Script_VarText08.Hide();
                Script_VarText09.Hide();
                Script_VarText10.Hide();
                Script_VarText11.Hide();
                Script_VarText12.Hide();
                Script_VarText13.Hide();
                Script_VarText14.Hide();
                Script_VarText15.Hide();

                Script_DeleteVar00.Hide();
                Script_DeleteVar01.Hide();
                Script_DeleteVar02.Hide();
                Script_DeleteVar03.Hide();
                Script_DeleteVar04.Hide();
                Script_DeleteVar05.Hide();
                Script_DeleteVar06.Hide();
                Script_DeleteVar07.Hide();
                Script_DeleteVar08.Hide();
                Script_DeleteVar09.Hide();
                Script_DeleteVar10.Hide();
                Script_DeleteVar11.Hide();
                Script_DeleteVar12.Hide();
                Script_DeleteVar13.Hide();
                Script_DeleteVar14.Hide();
                Script_DeleteVar15.Hide();

                Script_LANMascaraText.Hide();

                Script_TextBox.Text = "";

            }
        }
        #endregion

        private void ApplyScript(Script script)
        {
            string variables = script.variables;
            Script_AlterDate.Text = script.alterDate.ToString("dd/MM/yyyy");

            string[] split = variables.Split(',');

            foreach (string variable in split)
            {
                foreach (TextBox box in varText)
                {
                    if (box.Name.Contains(variable))
                    {
                        script.scriptString = script.scriptString.Replace(variable, box.Text);
                    }

                }
                
            }

            Script_TextBox.Text = script.scriptString;
        }

        public void ExtraVariablesControl(bool FortigateModel, bool ciscoXR, bool ciscoISR, bool Limpeza, bool parte2, bool configTypeBox)
        {
            if (FortigateModel)
            {
                Script_FortigateModelBox.Show();
                Script_ModelLabel.Show();
            }
            else
            {
                Script_FortigateModelBox.Hide();
                Script_ModelLabel.Hide();
            }
            if (ciscoXR)
            {
                Script_XRBox.Show();
                Script_XRLabel.Show();
            }
            else
            {
                Script_XRBox.Hide();
                Script_XRLabel.Hide();
            }
            if (ciscoISR)
            {
                Script_ISRBox.Show();
                Script_ISRLabel.Show();
            }
            else
            {
                Script_ISRBox.Show();
                Script_ISRLabel.Show();
            }
            if (Limpeza)
            {
                ButtonLimpeza.Show();
            }
            else
            {
                ButtonLimpeza.Hide();
            }
            if (parte2)
            {
                ButtonParte2.Show();
            }
            else
            {
                ButtonParte2.Hide();
            }
            if (configTypeBox)
            {
                Script_TypeLabel.Show();
                Script_ComboBox.Show();
            }
            else
            {
                Script_TypeLabel.Hide();
                Script_ComboBox.Hide();
            }
        }



        // ----------------------------------------------------------------------------------------------

        private void Button_FormatarScript_Click(object sender, EventArgs e)
        {
            ApplyVariebleToScript(routerType);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Script_TextBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Script_VarText00.Text = string.Empty;
            Script_VarText01.Text = string.Empty;
            Script_VarText02.Text = string.Empty;
            Script_VarText03.Text = string.Empty;
            Script_VarText04.Text = string.Empty;
            Script_VarText05.Text = string.Empty;
            Script_VarText06.Text = string.Empty;
            Script_VarText07.Text = string.Empty;
            Script_VarText08.Text = string.Empty;
            Script_VarText09.Text = string.Empty;
            Script_VarText10.Text = string.Empty;
            Script_VarText11.Text = string.Empty;
            Script_VarText12.Text = string.Empty;
            Script_VarText13.Text = string.Empty;
            Script_VarText14.Text = string.Empty;
            Script_VarText15.Text = string.Empty;

            Script_VarRouteI1.Text = string.Empty;
            Script_VarRouteI2.Text = string.Empty;
            Script_VarRouteE1.Text = string.Empty;
            Script_VarRouteE2.Text = string.Empty;


            ApplyVariebleToScript(routerType);
        }
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ----------------------------- LOGS ----------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        private void Logs_Cisco_BLD_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.BLD;
            routerType = RouterType.Cisco;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void Logs_Cisco_MPLS_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.MPLS;
            routerType = RouterType.Cisco;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void Logs_HPE_BLD_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.BLD;
            routerType = RouterType.HPE;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void Logs_HPE_MPLS_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.MPLS;
            routerType = RouterType.HPE;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void Logs_VOZ_Aligera_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.VOZ;
            routerType = RouterType.Aligera;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void Logs_BLD_Huawei_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.BLD;
            routerType = RouterType.Huawei;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void Logs_MPLS_Huawei_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.MPLS;
            routerType = RouterType.Huawei;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void Logs_BLD_Fortigate_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.BLD;
            routerType = RouterType.Fortigate;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void Logs_MPLS_Fortigate_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.MPLS;
            routerType = RouterType.Fortigate;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);

        }

        private void Logs_VOZ_Digistar_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.VOZ;
            routerType = RouterType.Nokia;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void Logs_VOZ_HPE_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.VOZ;
            routerType = RouterType.HPE;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void Logs_VOZ_Cisco_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.VOZ;
            routerType = RouterType.Cisco;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void Logs_VOZ_Broadsoft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
            player.Play();
        }

        private void Logs_Ligacao_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabLigacoes;

            ApplyLogsDeLigacao();
        }

        // ---------------

        private void ButtonParte2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(scriptParte2);
            MessageBox.Show("Copiado");
        }

        private void ButtonLimpeza_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(scriptLimpeza);
            MessageBox.Show("Copiado");
        }
        private void buttonSwitchScriptLog_Click(object sender, EventArgs e)
        {
            SwitchLogs();

            ApplyVariebleToScript(routerType);
            ScriptDispatch(routerType, activityType, logOrNot, backboneOrNot);
        }

        public void SwitchLogs()
        {
            if (!finalsOrNot)
            {
                finalsOrNot = false;
                logType = "FINAIS";
                SwitchLabel.Text = "FINAIS";
                SwitchLabel.Text = "FINAIS";
            }
            else
            {
                finalsOrNot = true;
                logType = "INICIAIS";
                SwitchLabel.Text = "INICIAIS";
                SwitchLabel.Text = "INICIAIS";
            }
        }

        private void Script_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyVariebleToScript(routerType);
        }

        private void Script_LANMascara_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyVariebleToScript(routerType);
        }

        private void Script_DeleteVar0_Click(object sender, EventArgs e)
        {
            Script_VarText00.Text = string.Empty;
        }

        private void Script_DeleteVar1_Click(object sender, EventArgs e)
        {
            Script_VarText01.Text = string.Empty;
        }

        private void Script_DeleteVar2_Click(object sender, EventArgs e)
        {
            Script_VarText02.Text = string.Empty;
        }

        private void Script_DeleteVar3_Click(object sender, EventArgs e)
        {
            Script_VarText03.Text = string.Empty;
        }

        private void Script_DeleteVar4_Click(object sender, EventArgs e)
        {
            Script_VarText04.Text = string.Empty;
        }

        private void Script_DeleteVar5_Click(object sender, EventArgs e)
        {
            Script_VarText05.Text = string.Empty;
        }

        private void Script_DeleteVar6_Click(object sender, EventArgs e)
        {
            Script_VarText06.Text = string.Empty;
        }

        private void Script_DeleteVar7_Click(object sender, EventArgs e)
        {
            Script_VarText07.Text = string.Empty;
        }

        private void Script_DeleteVar8_Click(object sender, EventArgs e)
        {
            Script_VarText08.Text = string.Empty;
        }

        private void Script_DeleteVar9_Click(object sender, EventArgs e)
        {
            Script_VarText09.Text = string.Empty;
        }

        private void Script_DeleteVar10_Click(object sender, EventArgs e)
        {
            Script_VarText10.Text = string.Empty;
        }

        private void Script_DeleteVar11_Click(object sender, EventArgs e)
        {
            Script_VarText11.Text = string.Empty;
        }
        private void Script_DeleteVar12_Click(object sender, EventArgs e)
        {
            Script_VarText12.Text = string.Empty;
        }

        private void Script_DeleteVar13_Click(object sender, EventArgs e)
        {
            Script_VarText13.Text = string.Empty;
        }

        private void Script_DeleteVar14_Click(object sender, EventArgs e)
        {
            Script_VarText14.Text = string.Empty;
        }

        private void Script_DeleteVar15_Click(object sender, EventArgs e)
        {
            Script_VarText15.Text = string.Empty;
        }

        private void Script_DeleteRouteI1_Click(object sender, EventArgs e)
        {
            Script_VarRouteI1.Text = string.Empty;
        }

        private void Script_DeleteRouteI2_Click(object sender, EventArgs e)
        {
            Script_VarRouteI2.Text = string.Empty;
        }

        private void Script_DeleteRouteE1_Click(object sender, EventArgs e)
        {
            Script_VarRouteE1.Text = string.Empty;
        }

        private void Script_DeleteRouteE2_Click(object sender, EventArgs e)
        {
            Script_VarRouteE2.Text = string.Empty;
        }

        private void Button_FormatarECopiarScript_Click(object sender, EventArgs e)
        {
            ApplyVariebleToScript(routerType);
            Clipboard.SetText(Script_TextBox.Text);
        }
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // --------------------------- Wizard Gat ------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        // ----------------------
        // Nokia
        // ----------------------

        private void WizNokiaBLD_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.BLD;
            routerType = RouterType.Nokia;
            backboneOrNot = true;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void WizNokiaMPLS_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.MPLS;
            routerType = RouterType.Nokia;
            backboneOrNot = true;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void WizNokiaVoz_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.VOZ;
            routerType = RouterType.Nokia;
            backboneOrNot = true;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void WizNokiaBLDcBGP_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.BLDcomBGP;
            routerType = RouterType.Nokia;
            backboneOrNot = true;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        // ----------------------
        // Cisco
        // ----------------------

        private void WizCiscoBLD_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.BLD;
            routerType = RouterType.Cisco;
            backboneOrNot = true;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void WizCiscoMPLS_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.MPLS;
            routerType = RouterType.Cisco;
            backboneOrNot = true;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void WizCiscoVoz_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.VOZ;
            routerType = RouterType.Cisco;
            backboneOrNot = true;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }

        private void WizCiscoBGP_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabScript;

            activityType = ActivityType.BLDcomBGP;
            routerType = RouterType.Cisco;
            backboneOrNot = true;
            logOrNot = true;

            ApplyVariebleToScript(routerType);
        }
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // --------------------------- Velocloud -------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        private void Logs_Velo_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabVelocloud;

            activityType = ActivityType.SDWAN;
            routerType = RouterType.Velocloud;
            backboneOrNot = false;
            logOrNot = true;

            ApplyVeloLogs();
        }

        private void buttonSwitchVeloLog_Click(object sender, EventArgs e)
        {
            SwitchLogs();

            ApplyVeloLogs();
        }

        private void BackButton_Velo_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabLogs;
        }

        private void buttonVeloCopie_Click(object sender, EventArgs e)
        {
            ApplyVeloLogs();
            Clipboard.SetText(veloTextBoxFinal.Text);
        }

        private void buttonVeloClear_Click(object sender, EventArgs e)
        {
            veloTextBox0.Text = string.Empty;
            veloTextBox1.Text = string.Empty;
            veloTextBox2.Text = string.Empty;
            veloTextBox3.Text = string.Empty;
            veloTextBox4.Text = string.Empty;
            veloTextBox5.Text = string.Empty;
            veloTextBox6.Text = string.Empty;
            veloTextBox7.Text = string.Empty;
            veloTextBox8.Text = string.Empty;
            veloTextBox9.Text = string.Empty;
            veloTextBox10.Text = string.Empty;
            veloTextBox11.Text = string.Empty;
            veloTextBox12.Text = string.Empty;
            veloTextBox13.Text = string.Empty;
            veloTextBox14.Text = string.Empty;
            veloTextBox15.Text = string.Empty;
            veloTextBox16.Text = string.Empty;
            ApplyVeloLogs();
        }

        public void ApplyVeloLogs()
        {

            ApplyLogType();

            veloTextBoxFinal.Text = "################ Configurações " + logType + " ################ \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle0.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox0.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle1.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox1.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle2.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox2.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle3.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox3.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle4.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox4.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle5.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox5.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle6.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox6.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle7.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox7.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle8.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox8.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle9.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox9.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "####################### Diagnóstico Remoto ######################## \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle10.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox10.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle11.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox11.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle12.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox12.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle13.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox13.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "####################### Troubleshoot BGP ######################## \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle14.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox14.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle15.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox15.Text + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle16.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox16.Text + " \r\n" +
                " \r\n" +
                " \r\n";
        }

        private void veloDeleteButton0_Click(object sender, EventArgs e)
        {
            veloTextBox0.Text = string.Empty;
        }

        private void veloDeleteButton1_Click(object sender, EventArgs e)
        {
            veloTextBox1.Text = string.Empty;
        }

        private void veloDeleteButton2_Click(object sender, EventArgs e)
        {
            veloTextBox2.Text = string.Empty;
        }

        private void veloDeleteButton3_Click(object sender, EventArgs e)
        {
            veloTextBox3.Text = string.Empty;
        }

        private void veloDeleteButton4_Click(object sender, EventArgs e)
        {
            veloTextBox4.Text = string.Empty;
        }

        private void veloDeleteButton5_Click(object sender, EventArgs e)
        {
            veloTextBox5.Text = string.Empty;
        }

        private void veloDeleteButton6_Click(object sender, EventArgs e)
        {
            veloTextBox6.Text = string.Empty;
        }

        private void veloDeleteButton7_Click(object sender, EventArgs e)
        {
            veloTextBox7.Text = string.Empty;
        }

        private void veloDeleteButton8_Click(object sender, EventArgs e)
        {
            veloTextBox8.Text = string.Empty;
        }

        private void veloDeleteButton9_Click(object sender, EventArgs e)
        {
            veloTextBox9.Text = string.Empty;
        }

        private void veloDeleteButton10_Click(object sender, EventArgs e)
        {
            veloTextBox10.Text = string.Empty;
        }

        private void veloDeleteButton11_Click(object sender, EventArgs e)
        {
            veloTextBox11.Text = string.Empty;
        }

        private void veloDeleteButton12_Click(object sender, EventArgs e)
        {
            veloTextBox12.Text = string.Empty;
        }

        private void veloDeleteButton13_Click(object sender, EventArgs e)
        {
            veloTextBox13.Text = string.Empty;
        }

        private void veloDeleteButton14_Click(object sender, EventArgs e)
        {
            veloTextBox14.Text = string.Empty;
        }

        private void veloDeleteButton15_Click(object sender, EventArgs e)
        {
            veloTextBox15.Text = string.Empty;
        }

        private void veloDeleteButton16_Click(object sender, EventArgs e)
        {
            veloTextBox16.Text = string.Empty;
        }

        private void veloDeleteButtonAll_Click(object sender, EventArgs e)
        {
            veloTextBox0.Text = string.Empty;
            veloTextBox1.Text = string.Empty;
            veloTextBox2.Text = string.Empty;
            veloTextBox3.Text = string.Empty;
            veloTextBox4.Text = string.Empty;
            veloTextBox5.Text = string.Empty;
            veloTextBox6.Text = string.Empty;
            veloTextBox7.Text = string.Empty;
            veloTextBox8.Text = string.Empty;
            veloTextBox9.Text = string.Empty;
            veloTextBox10.Text = string.Empty;
            veloTextBox11.Text = string.Empty;
            veloTextBox12.Text = string.Empty;
            veloTextBox13.Text = string.Empty;
            veloTextBox14.Text = string.Empty;
            veloTextBox15.Text = string.Empty;
            veloTextBox16.Text = string.Empty;

            ApplyVeloLogs();
        }
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ------------------------- Logs de Ligacao ---------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        private void Ligacoes_BCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Ligacoes_FinalTextBox.Text);
            ApplyLogsDeLigacao();
        }

        private void Ligacoes_BFormat_Click(object sender, EventArgs e)
        {
            ApplyLogsDeLigacao();
        }

        private void Ligacoes_BRestore_Click(object sender, EventArgs e)
        {
            Ligacoes_FinalTextBox.Text = ligacaoRestore;
        }
        private void Ligacoes_BClear_Click(object sender, EventArgs e)
        {
            ApplyLigacoesRestore();

            Ligacoes_TextBox1.Text = string.Empty;
            Ligacoes_TextBox2.Text = string.Empty;
            Ligacoes_TextBox3.Text = string.Empty;
            Ligacoes_TextBox4.Text = string.Empty;
            Ligacoes_TextBox5.Text = string.Empty;
            Ligacoes_TextBox6.Text = string.Empty;

            ApplyLogsDeLigacao();
        }


        private void Ligacoes_BExemplos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fixo: 4002-0022 (Não funciona em todas as localidades)\r\nDDD: (48) 2106-0006\r\n0800: 0800 721 8004\r\n3 Dígitos: 102 / 135 \r\n \r\n \r\n :INTERNACIONAL:\r\n002114123919500\r\n1-800-246-8464    - AT&T\r\n00314970342740992 - Alemanha");
        }

        private void Ligacoes_BAligera_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("sip show channels\r\n" + " sip show channel ");
        }

        private void Ligacoes_BHPE_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("screen-length disable\r\n" + "display voice sip call\r\n" + "#\r\n" + "display voice call\r\n" + "#\r\n" + "display voice call-info all\r\n" + "#\r\n" + "display voice subscriber-line brief\r\n" + "#\r\n");
        }

        private void Ligacoes_BHPE_Antigo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("screen-length disable\r\n" + "display voice statistics call-active all\r\n" + "#\r\n" + "display voice cmc ccb\r\n" + "#\r\n" + "display voice subscriber-line brief\r\n" + "#\r\n");
        }

        private void Ligacoes_BCisco_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("terminal length 0\r\n" + "show voice port summary\r\n" + "!\r\n" + "show voice status\r\n" + "!\r\n" + "show voice call summary\r\n" + "!\r\n");
        }

        private void Ligacoes_BDigistar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("show voip sip channel\r\n" + "!\r\n" + "show pbx group status tdm\r\n" + "!\r\n");
        }

        private void Ligacoes_BDebug_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                 ************************\r\n" +
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
"show pbx digital-line status\r\n");
        }

        public void ApplyLigacoesRestore()
        {
            ligacaoRestore = Ligacoes_FinalTextBox.Text;
        }

        public void ApplyLogsDeLigacao()
        {
            string local = "";
            string ddd = "";
            string celular = "";
            string zero800 = "";
            string digitos3 = "";
            string entrada = "";

            if (Ligacoes_TextBox1.Text != string.Empty)
            {
                local = "########################### SAÍDA LOCAL ###########################\r\n" +
                    "\r\n" +
                    Ligacoes_TextBox1.Text + "\r\n" + "\r\n" + "\r\n";
            }
            if (Ligacoes_TextBox2.Text != string.Empty)
            {
                ddd = "########################### DDD ###########################\r\n" +
                    "\r\n" +
                    Ligacoes_TextBox2.Text + "\r\n" + "\r\n" + "\r\n";
            }
            if (Ligacoes_TextBox3.Text != string.Empty)
            {
                celular = "########################### CELULAR ###########################\r\n" +
                    "\r\n" +
                    Ligacoes_TextBox3.Text + "\r\n" + "\r\n" + "\r\n";
            }
            if (Ligacoes_TextBox4.Text != string.Empty)
            {
                zero800 = "########################### 0800 ###########################\r\n" +
                    "\r\n" +
                    Ligacoes_TextBox4.Text + "\r\n" + "\r\n" + "\r\n";
            }
            if (Ligacoes_TextBox5.Text != string.Empty)
            {
                digitos3 = "########################### 3 DÍGITOS ###########################\r\n" +
                    "\r\n" +
                    Ligacoes_TextBox5.Text + "\r\n" + "\r\n" + "\r\n";
            }
            if (Ligacoes_TextBox6.Text != string.Empty)
            {
                entrada = "########################### ENTRADA ###########################\r\n" +
                    "\r\n" +
                    Ligacoes_TextBox6.Text + "\r\n" + "\r\n" + "\r\n";
            }

            Ligacoes_FinalTextBox.Text = "*************************************************************************** \r\n" +
                "************************ LOGS DE LIGAÇÕES *********************************\r\n" +
                "***************************************************************************\r\n" +
                "\r\n" +
                local +
                ddd +
                celular +
                zero800 +
                digitos3 +
                entrada +
                "\r\n";
        }

        private void Ligacoes_Clear1_Click(object sender, EventArgs e)
        {
            Ligacoes_TextBox1.Text = string.Empty;
        }

        private void Ligacoes_Clear2_Click(object sender, EventArgs e)
        {
            Ligacoes_TextBox2.Text = string.Empty;
        }
        private void Ligacoes_Clear3_Click(object sender, EventArgs e)
        {
            Ligacoes_TextBox3.Text = string.Empty;
        }

        private void Ligacoes_Clear4_Click(object sender, EventArgs e)
        {
            Ligacoes_TextBox4.Text = string.Empty;
        }

        private void Ligacoes_Clear5_Click(object sender, EventArgs e)
        {
            Ligacoes_TextBox5.Text = string.Empty;
        }

        private void Ligacoes_Clear6_Click(object sender, EventArgs e)
        {
            Ligacoes_TextBox6.Text = string.Empty;
        }
        #endregion

        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // --------------------------- Log Tools -------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        public void ApplyLogTools()
        {
            Log_FinalTextBox.Text = "==================" + " \r\n" +
                "STATUS ANTERIOR: " + "\r\n" +
                "==================" + " \r\n" +
                Log_TextBox1.Text +
                "\r\n" +
                "\r\n" +
                "==================" + " \r\n" +
                "STATUS ATUAL: " + "\r\n" +
                "==================" + " \r\n" +
                Log_TextBox2.Text +
                "\r\n" +
                "\r\n" +
                "==================" + " \r\n" +
                "PRÓXIMOS PASSOS: " + "\r\n" +
                "==================" + " \r\n" +
                Log_TextBox3.Text +
                "\r\n" +
                "\r\n";

        }

        private void Log_Copy_Click(object sender, EventArgs e)
        {
            ApplyLogTools();
        }

        private void Log_Copy_Click_1(object sender, EventArgs e)
        {
            ApplyLogTools();
            Clipboard.SetText(Log_FinalTextBox.Text);
        }

        private void Log_Copy_Click_2(object sender, EventArgs e)
        {
            Clipboard.SetText(Log_FinalTextBox.Text);
        }

        private void Log_ButtonRestore_Click(object sender, EventArgs e)
        {
            if (pendenciaRestore != string.Empty)
            {
                Log_FinalTextBox.Text = pendenciaRestore;
            }
        }

        private void Log_Clear_Click(object sender, EventArgs e)
        {
            pendenciaRestore = Log_FinalTextBox.Text;

            Log_TextBox1.Text = "";
            Log_TextBox2.Text = "";
            Log_TextBox3.Text = "";
            Log_FinalTextBox.Text = "";
        }

        private void Log_Clear3_Click(object sender, EventArgs e)
        {
            Log_TextBox3.Text = string.Empty;
        }

        private void Log_Clear2_Click(object sender, EventArgs e)
        {
            Log_TextBox2.Text = string.Empty;
        }

        private void Log_Clear1_Click(object sender, EventArgs e)
        {
            Log_TextBox1.Text = string.Empty;
        }

        private void LogToolsPendencia_Click(object sender, EventArgs e)
        {
            tabControlLogTools.SelectedTab = tabPendencia;
        }

        private void LogToolsFechamento_Click(object sender, EventArgs e)
        {
            tabControlLogTools.SelectedTab = tabFechamento;
        }

        private void LogToolsSuporte_Click(object sender, EventArgs e)
        {
            tabControlLogTools.SelectedTab = tabSuporte;
        }


        // -----------------
        // Fechamento
        // -----------------

        private void LTFechamento_ButtonClear_Click(object sender, EventArgs e)
        {
            LTFechamento_ValidacaoTextBox.Text = "";
            LTFechamento_TextBox.Text = "";
            LTFechamento_TextBoxObs.Text = "";
            fechamentoSubInfo = "";
            ApplyFechamento();

        }

        private void LTFechamento_ValidacaoText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyFechamento();
            }
        }

        private void LTFechamento_TextBoxObs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyFechamento();
            }
        }

        private void LTFechamento_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LTFechamento_CheckBox2.Checked)
            {
                LTFechamento_CheckBox2.Checked = !LTFechamento_CheckBox2.Checked;
            }
            if (LTFechamento_CheckBox1.Checked)
            {
                LTFechamento_CheckBox1.Checked = !LTFechamento_CheckBox1.Checked;
            }
            if (LTFechamento_CheckBox3.Checked)
            {
                LTFechamento_CheckBox3.Checked = !LTFechamento_CheckBox3.Checked;
            }
            if (LTFechamento_CheckBox6.Checked)
            {
                LTFechamento_CheckBox6.Checked = !LTFechamento_CheckBox3.Checked;
            }
            ApplyFechamento();
        }

        private void LTFechamento_CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (LTFechamento_CheckBox0.Checked)
            {
                LTFechamento_CheckBox0.Checked = !LTFechamento_CheckBox0.Checked;
            }
            if (LTFechamento_CheckBox1.Checked)
            {
                LTFechamento_CheckBox1.Checked = !LTFechamento_CheckBox1.Checked;
            }
            if (LTFechamento_CheckBox3.Checked)
            {
                LTFechamento_CheckBox3.Checked = !LTFechamento_CheckBox3.Checked;
            }
            if (LTFechamento_CheckBox5.Checked)
            {
                LTFechamento_CheckBox5.Checked = !LTFechamento_CheckBox5.Checked;
            }
            if (LTFechamento_CheckBox6.Checked)
            {
                LTFechamento_CheckBox6.Checked = !LTFechamento_CheckBox3.Checked;
            }
            ApplyFechamento();
        }

        private void LTFechamento_CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (LTFechamento_CheckBox0.Checked)
            {
                LTFechamento_CheckBox0.Checked = !LTFechamento_CheckBox0.Checked;
            }
            if (LTFechamento_CheckBox2.Checked)
            {
                LTFechamento_CheckBox2.Checked = !LTFechamento_CheckBox2.Checked;
            }
            if (LTFechamento_CheckBox3.Checked)
            {
                LTFechamento_CheckBox3.Checked = !LTFechamento_CheckBox3.Checked;
            }
            if (LTFechamento_CheckBox5.Checked)
            {
                LTFechamento_CheckBox5.Checked = !LTFechamento_CheckBox5.Checked;
            }
            if (LTFechamento_CheckBox6.Checked)
            {
                LTFechamento_CheckBox6.Checked = !LTFechamento_CheckBox3.Checked;
            }
            ApplyFechamento();
        }

        private void LTFechamento_CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (LTFechamento_CheckBox0.Checked)
            {
                LTFechamento_CheckBox0.Checked = !LTFechamento_CheckBox0.Checked;
            }
            if (LTFechamento_CheckBox1.Checked)
            {
                LTFechamento_CheckBox1.Checked = !LTFechamento_CheckBox1.Checked;
            }
            if (LTFechamento_CheckBox2.Checked)
            {
                LTFechamento_CheckBox2.Checked = !LTFechamento_CheckBox2.Checked;
            }
            if (LTFechamento_CheckBox5.Checked)
            {
                LTFechamento_CheckBox5.Checked = !LTFechamento_CheckBox5.Checked;
            }
            if (LTFechamento_CheckBox6.Checked)
            {
                LTFechamento_CheckBox6.Checked = !LTFechamento_CheckBox3.Checked;
            }
            ApplyFechamento();
        }

        private void LTFechamento_CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (LTFechamento_CheckBox0.Checked)
            {
                LTFechamento_CheckBox0.Checked = !LTFechamento_CheckBox0.Checked;
            }
            if (LTFechamento_CheckBox1.Checked)
            {
                LTFechamento_CheckBox1.Checked = !LTFechamento_CheckBox1.Checked;
            }
            if (LTFechamento_CheckBox2.Checked)
            {
                LTFechamento_CheckBox2.Checked = !LTFechamento_CheckBox2.Checked;
            }
            if (LTFechamento_CheckBox3.Checked)
            {
                LTFechamento_CheckBox3.Checked = !LTFechamento_CheckBox3.Checked;
            }
            if (LTFechamento_CheckBox6.Checked)
            {
                LTFechamento_CheckBox6.Checked = !LTFechamento_CheckBox3.Checked;
            }
            ApplyFechamento();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (LTFechamento_CheckBox0.Checked)
            {
                LTFechamento_CheckBox0.Checked = !LTFechamento_CheckBox0.Checked;
            }
            if (LTFechamento_CheckBox1.Checked)
            {
                LTFechamento_CheckBox1.Checked = !LTFechamento_CheckBox1.Checked;
            }
            if (LTFechamento_CheckBox2.Checked)
            {
                LTFechamento_CheckBox2.Checked = !LTFechamento_CheckBox2.Checked;
            }
            if (LTFechamento_CheckBox3.Checked)
            {
                LTFechamento_CheckBox3.Checked = !LTFechamento_CheckBox3.Checked;
            }
            if (LTFechamento_CheckBox5.Checked)
            {
                LTFechamento_CheckBox5.Checked = !LTFechamento_CheckBox3.Checked;
            }
            ApplyFechamento();
        }

        private void ApplyFechamento()
        {
            fechamentoSubInfo = "";
            if (LTFechamento_CheckBox0.Checked)
            {
                fechamentoSubInfo = "Realizado Teste de Certidão com Sucesso. Técnico ciente." + "\r\n" + "\r\n";
            }
            if (LTFechamento_CheckBox2.Checked)
            {
                fechamentoSubInfo = "Teste de Certidão realizado pela Equipe de Degradação" + "\r\n" + "\r\n";
            }
            if (LTFechamento_CheckBox1.Checked)
            {
                fechamentoSubInfo = "Atividade IPVPN ou Voz" + "\r\n" + "\r\n";
            }
            if (LTFechamento_CheckBox3.Checked)
            {
                fechamentoSubInfo = "Visita Unica" + "\r\n" + "\r\n";
            }
            if (LTFechamento_CheckBox5.Checked)
            {
                fechamentoSubInfo = "Cliente não Autorizou o Teste de Certidão" + "\r\n" + "\r\n";
            }
            if (LTFechamento_CheckBox6.Checked)
            {
                fechamentoSubInfo = "Técnico não possui equipamento para realizar Teste de Certidão de Nascimento" + "\r\n" + "\r\n";
            }

            // --------------------------------------------------------------

            LTFechamento_TextBox.Text = "- Atividade Realizada com Sucesso -" +
            "\r\n" +
            "\r\n" +
            "Responsável do cliente pela Validação: \r\n" +
            LTFechamento_ValidacaoTextBox.Text +
            "\r\n" +
            "\r\n" +
            fechamentoSubInfo +
            LTFechamento_TextBoxObs.Text;


        }

        private void LTFechamento_ButtonClear1_Click(object sender, EventArgs e)
        {
            LTFechamento_ValidacaoTextBox.Text = string.Empty;
        }

        private void LTFechamento_ButtonClear2_Click(object sender, EventArgs e)
        {
            LTFechamento_TextBoxObs.Text = string.Empty;
        }

        private void LTFechamento_BFormatCopy_Click(object sender, EventArgs e)
        {
            ApplyFechamento();
            Clipboard.SetText(LTFechamento_TextBox.Text);
        }

        private void LTFechamento_ButtonFormat_Click(object sender, EventArgs e)
        {
            ApplyFechamento();
        }

        private void LTFechamento_ButtonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LTFechamento_TextBox.Text);
        }


        // -----------------
        // Suporte LT
        // -----------------

        private void ButtonLogTools_Suporte_Click(object sender, EventArgs e)
        {
            commandStr = LT_SuporteComTextBox.Text;
            ApplySuporteLog();
            Clipboard.SetText(LT_SuporteComTextBox.Text);
        }

        private void Button_LTSup_Limpar_Click(object sender, EventArgs e)
        {
            LTSuporteFinalTextBox.Text = "";
            LT_SuporteTitleTextBox.Text = "";
            LT_SuporteComTextBox.Text = "";
        }

        private void LTSup_buttonForm_Click(object sender, EventArgs e)
        {
            ApplySuporteLog();
        }

        private void ButtonLT_AdcCommand_Click(object sender, EventArgs e)
        {

            if (LT_SuporteTitleTextBox.Text == string.Empty)
            {
                LTSuporteFinalTextBox.Text = "===================================================\r\n" +
                    "\r\n" +
                    "# " + LT_SuporteTitleTextBox.Text + " # \r\n" +
                    "\r\n" +
                    "===================================================\r\n " +
                    "\r\n ";
            }

            if (commandStr == string.Empty)
            {
                ApplySuporteLog();
            }
            else
            {
                commandStr = LT_SuporteComTextBox.Text;

                LTSuporteFinalTextBox.Text = LTSuporteFinalTextBox.Text +
                    "\r\n " +
                    "\r\n " +
                    "\r\n " +
                    commandStr;


                // commandStr = commandStr +
                //    "\r\n " +
                //   "\r\n " +
                //   "\r\n " +
                //   LT_SuporteCom.Text;

            }

        }

        private void ButtonLT_ResetCommand_Click(object sender, EventArgs e)
        {
            commandStr = "";
            ApplySuporteLog();

        }

        private void ButtonLT_ClearCommand_Click(object sender, EventArgs e)
        {
            LT_SuporteComTextBox.Text = "";
        }

        private void LTSup_buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LTSuporteFinalTextBox.Text);
        }

        private void ApplySuporteLog()
        {
            suporteTitle = "===================================================\r\n" +
                "\r\n" +
                "# " + LT_SuporteTitleTextBox.Text + " # \r\n" +
                "\r\n" +
                "===================================================\r\n " +
                "\r\n ";

            LTSuporteFinalTextBox.Text = suporteTitle + commandStr;
        }



        // ----------------------
        // Calculo de Subrede
        // ----------------------

        private void button4_Click(object sender, EventArgs e)
        {
            tabControlLogTools.SelectedTab = tabCalculadoraDeIP;
        }

        private void LTCalc_IPTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LTCalc_Result.Text = ipCalculator.ApplyIPCalculator(LTCalc_IPTextBox.Text);
            }
        }

        private void LTCalc_buttonCalc_Click(object sender, EventArgs e)
        {
            LTCalc_Result.Text = ipCalculator.ApplyIPCalculator(LTCalc_IPTextBox.Text);
        }
        #endregion

        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ------------------------- Outras Config -----------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        public void ApplyScriptOutros()
        {
            if (Outros_TypeComboBox.SelectedIndex == 0)
            {
                if (Outros_VarText01.Text == string.Empty)
                {
                    Outros_FinalTextBox.Text = scripts[65].scriptString.Replace("VarCom", Outros_VarText00.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarTipo", Outros_VarText02.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = scripts[66].scriptString.Replace("VarCom", Outros_VarText00.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_VarText01.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarTipo", Outros_VarText02.Text);
                }

            }
            if (Outros_TypeComboBox.SelectedIndex == 1)
            {
                string typeSNMP = "read";

                if (Outros_VarText02.Text == "RO")
                {
                    typeSNMP = "read";
                }
                if (Outros_VarText02.Text == "RW")
                {
                    typeSNMP = "write";
                }
                if (Outros_VarText01.Text == string.Empty)
                {
                    Outros_FinalTextBox.Text = scripts[67].scriptString.Replace("VarCom", Outros_VarText00.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarTipo", typeSNMP);
                }
                else
                {
                    Outros_FinalTextBox.Text = scripts[68].scriptString.Replace("VarCom", Outros_VarText00.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_VarText01.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarTipo", typeSNMP);
                }

            }
            if (Outros_TypeComboBox.SelectedIndex == 2)
            {
                if (Outros_VarText01.Text == string.Empty)
                {
                    Outros_FinalTextBox.Text = scripts[69].scriptString.Replace("VarCom", Outros_VarText00.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = scripts[70].scriptString.Replace("VarCom", Outros_VarText00.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_VarText01.Text);
                }
            }
            if (Outros_TypeComboBox.SelectedIndex == 3)
            {
                Outros_FinalTextBox.Text = scripts[71].scriptString.Replace("VarCom", Outros_VarText00.Text);
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_VarText01.Text);
            }
        }

        private void Outros_VarDelete0_Click(object sender, EventArgs e)
        {
            Outros_VarText00.Text = string.Empty;
        }

        private void Outros_VarDelete1_Click(object sender, EventArgs e)
        {
            Outros_VarText01.Text = string.Empty;
        }

        private void Outros_VarDelete2_Click(object sender, EventArgs e)
        {
            Outros_VarText02.Text = string.Empty;
        }

        private void Outros_VarDelete3_Click(object sender, EventArgs e)
        {
            Outros_VarText03.Text = string.Empty;
        }

        private void Outros_VarDelete4_Click(object sender, EventArgs e)
        {
            Outros_VarText04.Text = string.Empty;
        }

        private void Outros_VarDeleteAll_Click(object sender, EventArgs e)
        {
            Outros_VarText00.Text = string.Empty;
            Outros_VarText01.Text = string.Empty;
            Outros_VarText02.Text = string.Empty;
            Outros_VarText03.Text = string.Empty;
            Outros_VarText04.Text = string.Empty;
        }

        private void Outros_TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyScriptOutros();
        }

        private void Outros_ButtonForCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Outros_FinalTextBox.Text);
            ApplyScriptOutros();
        }

        private void Outros_ButtonFormat_Click(object sender, EventArgs e)
        {
            ApplyScriptOutros();
        }

        private void Outros_ButtonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Outros_FinalTextBox.Text);
        }
        #endregion

        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ------------------------------ MISC ---------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        // ----------------------
        // Versionamento
        // ----------------------
        private void Version_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        // -------------------------------
        // Habilita Edição de Scripts
        // -------------------------------

        private void Button_EnableEdit_Click(object sender, EventArgs e)
        {
            FormEnableEdit passwordForm = new FormEnableEdit(this);
            passwordForm.Show();
        }

        // -------------------------------
        // Dark Theme
        // -------------------------------

        private void Button_DarkMode_Click(object sender, EventArgs e)
        {
            SwitchDarkTheme();
        }

        public void SwitchDarkTheme()
        {
            nightMode = !nightMode;
            ApplyDarkTheme(this, nightMode);

            Properties.Settings.Default.darkMode = nightMode;
            Properties.Settings.Default.Save();

        }

        public void ApplyDarkTheme(Control ctr, bool darkMode)
        {
            Button_DarkMode.Text = nightMode ? "Light Mode" : "Night Mode";

            if (darkMode)
            {
                // ------ DARK THEME ------
                if (!ctr.Name.Contains("MainTitle") || !ctr.Name.Contains("TemplatesLabel"))
                {
                    if (!ctr.Name.Contains("Text") || !ctr.Name.Contains("Script_Var"))
                    {
                        tabControl2.BackColor = Color.FromArgb(30, 30, 30);
                        tabControl2.ForeColor = Color.White;

                        ctr.BackColor = Color.FromArgb(30, 27, 27);
                        ctr.ForeColor = Color.White;
                    }

                    if (ctr.Name == "DataGridRouters")
                    {
                        DataGridRouters.DefaultCellStyle.BackColor = Color.FromArgb(30, 27, 27);
                        DataGridRouters.DefaultCellStyle.ForeColor = Color.White;
                    }
                    if (ctr.Name.Contains("ImageLogo"))
                    {
                        ImageLogo.Image = Properties.Resources.logo_hitss_white;
                    }
                }
            }
            else
            {
                // ------ LIGHT THEME -----
                if (!ctr.Name.Contains("MainTitle") || !ctr.Name.Contains("TemplatesLabel"))
                {
                    ctr.BackColor = SystemColors.Control;
                    ctr.ForeColor = SystemColors.ControlText;
                }
                if (ctr.Name.Contains("Text") || ctr.Name.Contains("Box") || ctr.Name.Contains("Route"))
                {
                    ctr.BackColor = Color.White;
                    ctr.ForeColor = SystemColors.ControlText;
                }
                if (ctr.Name == "DataGridRouters")
                {
                    DataGridRouters.DefaultCellStyle.BackColor = Color.White;
                    DataGridRouters.DefaultCellStyle.ForeColor = Color.Black;
                }
                if (ctr.Name.Contains("ImageLogo"))
                {
                    ImageLogo.Image = Properties.Resources.logo_hitss_black;
                }
            }

            if (ctr.Name.Contains("BackButton"))
            {
                ctr.BackColor = Color.DodgerBlue;
                ctr.ForeColor = Color.White;
            }
            if (ctr.Name.Contains("MainTitle"))
            {
                ctr.BackColor = Color.Red;
                ctr.ForeColor = Color.White;
            }
            if (ctr.Name.Contains("TemplatesLabel"))
            {
                ctr.BackColor = Color.DodgerBlue;
                ctr.ForeColor = Color.White;
            }

            // ------------------------------------------------------------------------------
            // Apply theme on All Control child elements
            // ------------------------------------------------------------------------------
            foreach (Control child in ctr.Controls)
            {
                ApplyDarkTheme(child, nightMode);
            }

        }


        // -------------------------------
        // Edit Scritps
        // -------------------------------
        private void Button_EditScript_Click(object sender, EventArgs e)
        {
            if (enableEdit)
            {
                FormEdit editForm = new FormEdit();
                editForm.Show();
            }
            else
            {
                MessageBox.Show("Sem Autorização");
            }

        }
        #endregion

        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------- Still in Progress ----------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------

        private void NotImplemented(object sender, EventArgs e)
        {
            player.Play();
            MessageBox.Show("Not Implemented");
        }


        // ---------------------------------------------------------------------------
        // ----------------------
        // Teste
        // ----------------------
        #region
        public void SendToDB()
        {
            string bancoStr = "";

            string[] teste = Teste_ScriptFinal.Text.Split(new[] { Environment.NewLine, "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < teste.Length; i++)
            {
                bancoStr = bancoStr + teste[i] + ';';
            }

            Teste_ScriptBanco.Text = bancoStr;
        }

        public void ReceiveFromDB()
        {
            string final = "";

            string[] teste = Teste_ScriptBanco.Text.Split(';');

            for (int i = 0; i < teste.Length; i++)
            {
                final = final + teste[i] + "\r\n";
            }

            Teste_ScriptFinal.Text = final;
        }


        // Botoes

        private void Teste_out_Click(object sender, EventArgs e)
        {
            ReceiveFromDB();
        }
        private void Teste_In_Click(object sender, EventArgs e)
        {
            SendToDB();
        }

        private void Teste_Enter_Click(object sender, EventArgs e)
        {
            if (Teste_ScriptFinal.Text.Contains("var"))
            {
                Teste_ScriptFinal.Text = Teste_ScriptFinal.Text.Replace("var", Script_VarTest.Text);
            }
        }

        private void Teste_ClearDB_Click(object sender, EventArgs e)
        {
            Teste_ScriptBanco.Text = string.Empty;
        }

        private void Teste_ClearF_Click(object sender, EventArgs e)
        {
            Teste_ScriptFinal.Text = string.Empty;
        }
        #endregion

    }
}
