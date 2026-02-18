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
        // Night Mode
        bool nightMode;

        // Enable Edit
        public bool enableEdit = false;
        public bool canImportSAIP = false;

        // Scripts
        string scriptParte2;
        string scriptLimpeza;
        List<Script> scripts = new List<Script>();

        // Script Options 
        RouterType routerType;
        ActivityType activityType;
        bool finalsOrNot;
        bool logOrNot;
        bool backboneOrNot;

        // Config Strings
        string logType;
        string designacao;
        string mascaraStr;

        // Log Tools
        string suporteTitle;
        string commandStr;
        string fechamentoSubInfo;
        string pendenciaRestore;
        IPCalculator ipCalculator = new IPCalculator();

        // Log de Ligacao
        string ligacaoRestore;

        // UI Lists
        List<Label> varName = new List<Label>();
        List<TextBox> varText = new List<TextBox>();
        List<Button> varDelete = new List<Button>();
        List<Label> varEx = new List<Label>();

        // Sounds
        SoundPlayer player = new SoundPlayer(Properties.Resources.Perdemo);



        // ------------------------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------- Start Up -------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        private void Form1_Load(object sender, EventArgs e)
        {
            //---------------------
            // Start Up Info
            //---------------------

            // List Script and Routers 
            LoadRouterList();
            ListAllScriptVars();

            // Disable Route Map Variables
            ApplyRouteMapNokia();

            // Load Night Mode
            nightMode = Properties.Settings.Default.darkMode;
            ApplyNightMode(this, nightMode);

            // Load all Scripts
            Script scriptClass = new Script(99,"Teste", "", "", DateTime.Parse("11/02/2026"));
            scripts = scriptClass.AddScripts();

            // Startup ComboBox Options
            Script_ComboBox.SelectedIndex = 0;
            Script_ISRBox.SelectedIndex = 1;
            Script_XRBox.SelectedIndex = 1;

            CheckCanImportFromSAIP();

            // --------------------------------------------------------------------------------------

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
        }

        public void LoadRouterList()
        {
            // Router List
            Router routerClass = new Router();
            List<Router> routerList = routerClass.GetRouterList();

            // Set Router List in Data Grid
            DataGridRouters.DataSource = routerList;
        }

        public void CheckCanImportFromSAIP()
        {
            if (canImportSAIP) 
            {
                Button_ImportSAIP.Show();
            }
            else
            {
                Button_ImportSAIP.Hide();
            }
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
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // -------------------------- Main Buttons -----------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // ------------------------
        // Configuracao
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

            logOrNot = true;
            backboneOrNot = false;

            SwitchLabel.Text = finalsOrNot ? "FINAIS" : "INICIAIS";
            SwitchLabel.Text = finalsOrNot ? "FINAIS" : "INICIAIS";

            BackButton_Script.Hide();
            BackButton_Script2.Hide();
            BackButton_Script3.Visible = true;
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
        // Home Button
        // ------------------------

        private void HomeButton_Script_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabMainPage;
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
        // Outras Configs
        // ------------------------

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


        // -------------------------------------------------------------------
        // TEST
        private void Logs_VOZ_Cisco_Click_1(object sender, EventArgs e)
        {
            activityType = ActivityType.VOZ;
            tabControl2.SelectedTab = tabScript;
            ScriptDispatch(RouterType.Cisco, activityType, false, false);
        }

        // ---------------------------------------------------------------------------
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ------------------------- Select Router -----------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        private void Cisco_Button_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Cisco;
            backboneOrNot = false;
            logOrNot = false;
            tabControl2.SelectedTab = tabScript;
            ScriptDispatch(routerType, activityType, false, false);
        }

        private void HPE_Button_Click(object sender, EventArgs e)
        {
            routerType = RouterType.HPE;
            backboneOrNot = false;
            logOrNot = false;
            tabControl2.SelectedTab = tabScript;
            ScriptDispatch(routerType, activityType, false, false);
        }

        private void Config_HPE_old_Click(object sender, EventArgs e)
        {
            routerType = RouterType.HPE_old;
            backboneOrNot = false;
            logOrNot = false;
            tabControl2.SelectedTab = tabScript;
            ScriptDispatch(routerType, activityType, false, false);
        }

        private void Config_Huawei_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Huawei;
            backboneOrNot = false;
            logOrNot = false;
            tabControl2.SelectedTab = tabScript;
            ScriptDispatch(routerType, activityType, false, false);
        }

        private void Config_Fortigate_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Fortigate;
            backboneOrNot = false;
            logOrNot = false;
            tabControl2.SelectedTab = tabScript;
            ScriptDispatch(routerType, activityType, false, false);

        }
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ----------------------------- LOGS ----------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        public void OpenScriptLogTab(RouterType RouterType, ActivityType ActivityType)
        {
            tabControl2.SelectedTab = tabScript;
            ScriptDispatch(RouterType, ActivityType, true, false);
            logOrNot = true;
            backboneOrNot = false;
        }

        // ---------------------------
        // BLD
        // ---------------------------
        private void Logs_Cisco_BLD_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Cisco;
            activityType = ActivityType.BLD;
            OpenScriptLogTab(routerType, activityType);
        }

        private void Logs_HPE_BLD_Click(object sender, EventArgs e)
        {
            routerType = RouterType.HPE;
            activityType = ActivityType.BLD;
            OpenScriptLogTab(routerType, activityType);
        }

        private void Logs_BLD_Huawei_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Huawei;
            activityType = ActivityType.BLD;
            OpenScriptLogTab(routerType, activityType);
        }

        private void Logs_BLD_Fortigate_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Fortigate;
            activityType = ActivityType.BLD;
            OpenScriptLogTab(routerType, activityType);
        }

        // ---------------------------
        // MPLS
        // ---------------------------
        private void Logs_Cisco_MPLS_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Cisco;
            activityType = ActivityType.MPLS;
            OpenScriptLogTab(routerType, activityType);
        }
        private void Logs_HPE_MPLS_Click(object sender, EventArgs e)
        {
            routerType = RouterType.HPE;
            activityType = ActivityType.MPLS;
            OpenScriptLogTab(routerType, activityType);
        }
        private void Logs_MPLS_Huawei_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Huawei;
            activityType = ActivityType.MPLS;
            OpenScriptLogTab(routerType, activityType);
        }
        private void Logs_MPLS_Fortigate_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Fortigate;
            activityType = ActivityType.MPLS;
            OpenScriptLogTab(routerType, activityType);
        }

        // ---------------------------
        // VOZ
        // ---------------------------
        private void Logs_VOZ_Cisco_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Cisco;
            activityType = ActivityType.VOZ;
            OpenScriptLogTab(routerType, activityType);
        }

        private void Logs_VOZ_HPE_Click(object sender, EventArgs e)
        {
            routerType = RouterType.HPE;
            activityType = ActivityType.VOZ;
            OpenScriptLogTab(routerType, activityType);
        }

        private void Logs_VOZ_Aligera_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Aligera;
            activityType = ActivityType.VOZ;
            OpenScriptLogTab(routerType, activityType);
        }

        private void Logs_VOZ_Digistar_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Digistar;
            activityType = ActivityType.VOZ;
            OpenScriptLogTab(routerType, activityType);
        }

        // ---------------------------
        // OUTROS
        // ---------------------------

        private void Logs_VOZ_Broadsoft_Click(object sender, EventArgs e)
        {
            NotImplemented(this, null);
            //MessageBox.Show("Not Implemented");
            //player.Play();
        }

        private void Logs_Ligacao_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabLigacoes;
            ApplyLogsDeLigacao();
        }
        private void WizGat_LogButton_Click(object sender, EventArgs e)
        {
            ApplyFinalsOrNot();
        }

        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // --------------------------- Wizard Gat ------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        public void ApplyWizGat(RouterType RouterType, ActivityType ActivityType)
        {
            tabControl2.SelectedTab = tabScript;
            ScriptDispatch(RouterType, ActivityType, true, true);
            logOrNot = true;
            backboneOrNot = true;
        }

        // ----------------------
        // Nokia
        // ----------------------
        private void WizNokiaBLD_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Nokia;
            activityType = ActivityType.BLD;
            ApplyWizGat(routerType, activityType);
        }

        private void WizNokiaMPLS_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Nokia;
            activityType = ActivityType.MPLS;
            ApplyWizGat(routerType, activityType);
        }

        private void WizNokiaVoz_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Nokia;
            activityType = ActivityType.VOZ;
            ApplyWizGat(routerType, activityType);
        }

        private void WizNokiaBLDcBGP_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Nokia;
            activityType = ActivityType.BLDcomBGP;
            ApplyWizGat(routerType, activityType);
        }

        // ----------------------
        // Cisco
        // ----------------------
        private void WizCiscoBLD_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Cisco;
            activityType = ActivityType.BLD;
            ApplyWizGat(routerType, activityType);
        }

        private void WizCiscoMPLS_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Cisco;
            activityType = ActivityType.MPLS;
            ApplyWizGat(routerType, activityType);
        }

        private void WizCiscoVoz_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Cisco;
            activityType = ActivityType.VOZ;
            ApplyWizGat(routerType, activityType);
        }

        private void WizCiscoBGP_Click(object sender, EventArgs e)
        {
            routerType = RouterType.Cisco;
            activityType = ActivityType.BLDcomBGP;
            ApplyWizGat(routerType, activityType);
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
        #region
        private void Button_FormatarECopiarScript_Click(object sender, EventArgs e)
        {
            ScriptDispatch(routerType, activityType, logOrNot, backboneOrNot);
            Clipboard.SetText(Script_TextBox.Text);
        }

        private void Button_FormatarScript_Click(object sender, EventArgs e)
        {
            ScriptDispatch(routerType, activityType, logOrNot, backboneOrNot);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Script_TextBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox t in varText)
            {
                t.Text = string.Empty;
            }

            Script_VarRouteI1.Text = string.Empty;
            Script_VarRouteI2.Text = string.Empty;
            Script_VarRouteE1.Text = string.Empty;
            Script_VarRouteE2.Text = string.Empty;

            ScriptDispatch(routerType, activityType, logOrNot, backboneOrNot);
        }

        // --- Reused in all TextBoxes --- 
        private void BLD_Var0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ScriptDispatch(routerType, activityType, logOrNot, backboneOrNot);
            }
        }

        // --- ComboBoxes ---
        private void Script_XRBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptDispatch(routerType, activityType, logOrNot, backboneOrNot);
        }

        private void Script_ISRBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptDispatch(routerType, activityType, logOrNot, backboneOrNot);
        }

        private void Script_FortigateModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFortigateModel();
            ScriptDispatch(routerType, activityType, logOrNot, backboneOrNot);
        }
        private void Script_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptDispatch(routerType, activityType, logOrNot, backboneOrNot);
        }

        private void Script_LANMascara_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptDispatch(routerType, activityType, logOrNot, backboneOrNot);
        }

        // --- Others ---
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
            ScriptDispatch(routerType, activityType, true, false);
        }

        private void Script_ButtonRegraAdc_Click(object sender, EventArgs e)
        {

        }

        // --- Delete Individually ---
        #region
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
        #endregion

        // ---------------------------------------------------------------------------
        #endregion

        // ---------------------------
        // Script Dispatcher
        // ---------------------------
        // NEW 
        #region
        public void ScriptDispatch(RouterType routerType, ActivityType activityType, bool logOrNot, bool backboneOrNot)
        {
            ApplyVozVariables();
            ApplyRouteMapNokia();
            ChangeMascaraLAN();
            ChangeVlanNaWANVar();
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

            if (backboneOrNot)
            {
                SwitchLabel.Hide();
                logType = Script_ComboBox.Text;
            }
            else
            {
                if (logOrNot)
                {
                    SwitchLabel.Show();
                    logType = SwitchLabel.Text;
                }
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------------ CONFIGS -------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Config - Cisco - BLD -----------------------------------------------------
            if (routerType == RouterType.Cisco && activityType == ActivityType.BLD && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - CISCO - BLD";

                // Organize UI
                VarScriptDisplayControl(scripts[0].variables);
                ExtraVariablesControl(false, false, true, false, false, false);

                ApplyScript(scripts[0]);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "encapsulation dot1Q " + Script_VarText04.Text + "\r\n");

                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanNTP", "." + Script_VarText04.Text);

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "!\r\n");
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanNTP", "");
                }

            }

            // ------------------------------------------- Config - HPE - BLD -------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - HPE - BLD";

                VarScriptDisplayControl(scripts[1].variables);

                ExtraVariablesControl(false, false, false, false, false, false);

                ApplyScript(scripts[1]);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n");

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "#\r\n");
                }

            }

            // ------------------------------------------- Config - HPE Old - BLD ---------------------------------------------------
            else if ((routerType == RouterType.HPE_old) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - HPE Antigo - BLD";

                VarScriptDisplayControl(scripts[2].variables);

                ExtraVariablesControl(false, false, false, false, false, false);

                ApplyScript(scripts[2]);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n");

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "#\r\n");
                }

            }

            // ------------------------------------------- Config - Huawei - BLD ----------------------------------------------------
            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - HUAWEI - BLD";

                VarScriptDisplayControl(scripts[3].variables);

                ExtraVariablesControl(false, false, false, false, false, false);

                ApplyScript(scripts[3]);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                        " description " + Script_VarText01.Text + "\r\n" +
                        " dot1q termination vid " + Script_VarText04.Text + "\r\n" +
                        " bandwidth " + Script_VarText02.Text + "\r\n");

                    MessageBox.Show("Com Vlan");
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "." + Script_VarText04.Text);
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "");
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "#\r\n");
                }

                buttonSwitchScriptLog.Hide();

            }

            // ------------------------------------------- Config - Fortigate - BLD -------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - FORTIGATE - BLD";

                VarScriptDisplayControl(scripts[4].variables);

                ExtraVariablesControl(true, false, false, false, false, false);

                ApplyScript(scripts[4]);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "################# Configuracao VLAN na WAN  #################### \r\n" +
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
                        "#\r\n");
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "." + Script_VarText04.Text);

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "#\r\n");
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "");
                }

            }

            // ------------------------------------------- Config - Cisco - MPLS ----------------------------------------------------
            else if (routerType == RouterType.Cisco && activityType == ActivityType.MPLS && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - CISCO - MPLS";

                // Organize UI
                VarScriptDisplayControl(scripts[5].variables);
                ExtraVariablesControl(false, false, true, false, false, false);

                ApplyScript(scripts[5]);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "encapsulation dot1Q " + Script_VarText04.Text + "\r\n");

                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanNTP", "." + Script_VarText04.Text);

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "!\r\n");
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanNTP", "");
                }

            }

            // ------------------------------------------- Config - HPE - MPLS ------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.MPLS) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - HPE - MPLS";

                VarScriptDisplayControl(scripts[6].variables);

                ExtraVariablesControl(false, false, false, false, false, false);

                ApplyScript(scripts[6]);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n");

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "#\r\n");
                }

            }

            // ------------------------------------------- Config - HPE Old - MPLS --------------------------------------------------
            else if ((routerType == RouterType.HPE_old) && (activityType == ActivityType.MPLS) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - HPE Antigo - MPLS";

                VarScriptDisplayControl(scripts[7].variables);

                ExtraVariablesControl(false, false, false, false, false, false);

                ApplyScript(scripts[8]);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n");

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "#\r\n");
                }

            }

            // ------------------------------------------- Config - Huawei - MPLS ---------------------------------------------------
            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.MPLS) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - HUAWEI - MPLS";

                VarScriptDisplayControl(scripts[8].variables);

                ExtraVariablesControl(false, false, false, false, false, false);

                ApplyScript(scripts[8]);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "interface " + Script_VarText03.Text + "." + Script_VarText04.Text + "\r\n" +
                        " description " + Script_VarText01.Text + "\r\n" +
                        " dot1q termination vid " + Script_VarText04.Text + "\r\n" +
                        " bandwidth " + Script_VarText02.Text + "\r\n");

                    MessageBox.Show("Com Vlan");
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "." + Script_VarText04.Text);
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "");
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "#\r\n");
                }

            }

            // ------------------------------------------- Config - Fortigate - MPLS ------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.MPLS) && backboneOrNot == false && logOrNot == false)
            {
                Script_ProcedureName.Text = "CONFIG - FORTIGATE - MPLS";

                VarScriptDisplayControl(scripts[9].variables);

                ExtraVariablesControl(true, false, false, false, false, false);

                ApplyScript(scripts[9]);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "################# Configuracao VLAN na WAN  ##################### \r\n" +
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
                        "#\r\n");

                    MessageBox.Show("Com Vlan");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "# \r\n");
                }

                // ---------------------------------------------------------

                if (Script_VarText11.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("loopbackCliente", "################# Loopback Cliente  ##################### \r\n" +
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
                        "end\r\n" +
                        "#\r\n" +
                        "#\r\n" +
                        "#\r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("loopbackCliente", "#\r\n");
                }


            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------------- LOGS ---------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Logs - Cisco - BLD -------------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - CISCO - BLD";

                VarScriptDisplayControl(scripts[19].variables);

                ExtraVariablesControl(false, false, true, true, true, false);

                ApplyScript(scripts[19]);

                // Extra Options
                if (Script_VarText05.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "source " + Script_VarText05.Text);
                    Script_TextBox.Text = Script_TextBox.Text.Replace("intLan", "show interface " + Script_VarText05.Text + "\r\n" +
                        "!\r\n" +
                        "!######################## \r\n");
                    Script_TextBox.Text = Script_TextBox.Text.Replace("policyLan", "show policy-map interface " + Script_VarText05.Text + "\r\n" + "!\r\n" + "!\r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("policyLan", "!\r\n");
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "");
                    Script_TextBox.Text = Script_TextBox.Text.Replace("intLan", "!\r\n");
                }
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanWan", "show interface " + Script_VarText04.Text + "\r\n" +
                        "!\r\n" +
                        "!######################## \r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanWan","!\r\n");
                }
                if (Script_VarText06.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanLan", "show interface " + Script_VarText06.Text + "\r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanLan", "!\r\n");
                }

                //--------------------------------------------------------------------------------

                // ---------------------------------------------------
                // Parte 2
                // ---------------------------------------------------
                scriptParte2 = scripts[39].scriptString;

                // ---------------------------------------------------
                // Limpeza
                // ---------------------------------------------------
                scriptLimpeza = scripts[40].scriptString;
            }

            // ------------------------------------------- Logs - HPE - BLD ---------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - HPE - BLD";

                VarScriptDisplayControl(scripts[20].variables);

                ExtraVariablesControl(false, false, false, true, false, true);

                ApplyScript(scripts[20]);

                // Extra Options
                if (Script_VarText09.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", " -a " + Script_VarText09.Text);
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "");
                }
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanWan", "display interface " + Script_VarText04.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanWan", "#\r\n");
                }
                if (Script_VarText05.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("intLan", "display interface " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("intLan", "#\r\n");
                }
                if (Script_VarText06.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanLan", "display interface " + Script_VarText06.Text + "\r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanLan", "#\r\n");
                }

                //--------------------------------------------------------------------------------

                // ---------------------------------------------------
                // Parte 2
                // ---------------------------------------------------
                scriptParte2 = scripts[41].scriptString;

                // ---------------------------------------------------
                // Limpeza
                // ---------------------------------------------------
                scriptLimpeza = scripts[42].scriptString;
            }

            // ------------------------------------------- Log - Fortigate - BLD ----------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - FORTIGATE - BLD";

                VarScriptDisplayControl(scripts[21].variables);

                ExtraVariablesControl(true, false, false, false, false, false);

                ApplyScript(scripts[21]);

                // Extra Options
                if (Script_VarText09.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "execute ping-options source " + Script_VarText09.Text + "\r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "");
                }

            }

            // ------------------------------------------- Log - Huawei - BLD -------------------------------------------------------
            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.BLD) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - HUAWEI - BLD";

                VarScriptDisplayControl(scripts[22].variables);

                ExtraVariablesControl(false, false, false, false, false, false);

                ApplyScript(scripts[22]);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanNaWAN", "display interface " + Script_VarText04.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanNaWAN", "#\r\n");
                }
                if (Script_VarText05.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("intLan", "display interface " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n");
                }
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("intLan", "#\r\n");
                }

                if (Script_VarText06.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanLan", "display interface " + Script_VarText06.Text + "\r\n" +
                    "#\r\n" +
                    "#########################\r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vlanLan", "#\r\n");
                }

                if (Script_VarText09.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "-a " + Script_VarText09.Text + " ");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "");
                }

            }

            // ------------------------------------------- Log - Fortigate - MPLS ---------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.MPLS) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - FORTIGATE - MPLS";

                VarScriptDisplayControl(scripts[25].variables);

                ExtraVariablesControl(true, false, false, false, false, false);

                ApplyScript(scripts[25]);

                // Extra Options
                if (Script_VarText09.Text != "")
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "execute ping-options source " + Script_VarText09.Text + "\r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("sourceLan", "#\r\n");
                }

            }

            // ------------------------------------------- Log CPE Aligera ----------------------------------------------------------
            else if ((routerType == RouterType.Aligera) && (activityType == ActivityType.VOZ) && backboneOrNot == false && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOGS - ALIGERA - VOZ";

                VarScriptDisplayControl(scripts[31].variables);

                ExtraVariablesControl(false, false, false, false, false, false);

                ApplyScript(scripts[31]);
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log Backbone - Cisco -----------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.BLD) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - BLD";

                VarScriptDisplayControl(scripts[33].variables);

                ExtraVariablesControl(false, false, false, false, false, true);

                ApplyScript(scripts[33]);
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.MPLS) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - MPLS";

                VarScriptDisplayControl(scripts[34].variables);

                ExtraVariablesControl(false, true, false, false, false, true);

                ApplyScript(scripts[34]);

                // Extra Options
                if (Script_XRBox.SelectedIndex == 0)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("xr", "vpnv4 ");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("xr", "");
                }
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.VOZ) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - VOZ";

                VarScriptDisplayControl(scripts[35].variables);

                ExtraVariablesControl(false, true, false, false, false, true);

                ApplyScript(scripts[35]);
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.BLDcomBGP) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - CISCO - BLD com BGP";

                VarScriptDisplayControl(scripts[36].variables);

                ExtraVariablesControl(false, false, false, false, false, true);

                ApplyScript(scripts[36]);
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log Backbone Nokia -------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((routerType == RouterType.Nokia) && (activityType == ActivityType.BLD) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - BLD";

                VarScriptDisplayControl(scripts[37].variables);

                ExtraVariablesControl(false, false, false, false, false, true);

                ApplyScript(scripts[37]);
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((routerType == RouterType.Nokia) && (activityType == ActivityType.MPLS) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - MPLS";

                VarScriptDisplayControl(scripts[38].variables);

                ExtraVariablesControl(false, false, false, false, false, true);

                ApplyScript(scripts[38]);

                // Extra Options
                if (Script_VarText14.Text.Contains(':'))
                {
                    string vrfAS;
                    string[] splitStr = Script_VarText14.Text.Split(new char[] { ':' });
                    vrfAS = splitStr[1];
                    Script_TextBox.Text = Script_TextBox.Text.Replace("vrfAS", vrfAS);
                }

            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((routerType == RouterType.Nokia) && (activityType == ActivityType.VOZ) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - VOZ";

                VarScriptDisplayControl(scripts[39].variables);

                ExtraVariablesControl(false, false, false, false, false, true);

                ApplyScript(scripts[39]);
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((routerType == RouterType.Nokia) && (activityType == ActivityType.BLDcomBGP) && backboneOrNot == true && logOrNot == true)
            {
                Script_ProcedureName.Text = "LOG BACKBONE - NOKIA - BLD com BGP";

                VarScriptDisplayControl(scripts[40].variables);

                ExtraVariablesControl(false, false, false, false, false, true);

                ApplyScript(scripts[40]);

                // Extra Options
                if (Script_VarRouteE2.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("policyExport2", "show router policy " + Script_VarRouteE2.Text + "\r\n" + "\r\n");
                }
                else
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("policyExport2", "\r\n");
                }

            }

            // ----------------------------------------------------------------------------------------------------------------------
            // --------------------------------------------------- ERROR ------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            else
            {
                player.Play();
                MessageBox.Show("Not Implemented - Router: " + routerType + " Type: " + activityType + " LogsOrNot: " + logOrNot + " Backbone: " + backboneOrNot);

                Script_ProcedureName.Text = "ERROR";

                ExtraVariablesControl(false, false, false, false, false, false);

                foreach (Label l in varName)
                {
                    l.Hide();
                }

                foreach (TextBox t in varText)
                {
                    t.Hide();
                }

                foreach (Button b in varDelete)
                {
                    b.Hide();
                }

                foreach (Label l in varEx)
                {
                    l.Hide();
                }

                Script_LANMascaraBox.Hide();

                Script_TextBox.Text = "";
            }
            
            GetDesignacao(Script_VarText01.Text);
        }
        #endregion

        // ---------------------------
        // Apply Script to Text Box
        // ---------------------------
        #region
        private void ApplyScript(Script script)
        {
            // MessageBox.Show("Applied Script: " + script.name + " - Id: " + script.id);
            Script_TextBox.Text = script.scriptString;
            Script_AlterDate.Text = script.alterDate.ToString("dd/MM/yyyy");

            string variables = script.variables;
            string[] split = variables.Split(',');
            
            foreach (string variable in split)
            {
                foreach (TextBox box in varText)
                {
                    if (box.Name.Contains(variable))
                    {
                        if (variable == "09")
                        {
                            Script_TextBox.Text = Script_TextBox.Text.Replace("mascaraLAN", mascaraStr);
                        }
                        Script_TextBox.Text = Script_TextBox.Text.Replace("var" + variable, box.Text);
                    }
                }             
            }
            Script_TextBox.Text = Script_TextBox.Text.Replace("logType", logType);
        }
        #endregion

        // ---------------------------
        // UI Organizer
        // ---------------------------
        #region
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
                            varName[i].Location = new System.Drawing.Point(varName[i].Location.X, 152);
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
                            Script_LANMascaraBox.Location = new System.Drawing.Point(258, varText[anterior].Location.Y + 30);
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
                            varEx[i].Location = new System.Drawing.Point(varEx[i].Location.X, 156);
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
        #endregion

        // ---------------------------
        // Close/Show Extra Variables
        // ---------------------------
        #region
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
                Script_ISRBox.Hide();
                Script_ISRLabel.Hide();
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
        #endregion

        // ---------------------------
        // Auxiliary Functions
        // ---------------------------
        #region
        public void SwitchLogs()
        {
            if (!finalsOrNot)
            {
                MessageBox.Show("Aplicado Finais");
                finalsOrNot = true;
                logType = "FINAIS";
                SwitchLabel.Text = "FINAIS";
                buttonSwitchVeloLog.Text= "INICIAIS"; // Inverted
            }
            else
            {
                MessageBox.Show("Aplicado Inicias");
                finalsOrNot = false;
                logType = "INICIAIS";
                SwitchLabel.Text = "INICIAIS";
                buttonSwitchVeloLog.Text = "FINAIS"; // Inverted
            }
        }

        public void GetDesignacao(string description)
        {
            if (description.Contains('|'))
            {
                string[] split = description.Split('|');
                if (split.Length >= 2)
                {
                    split[2] = split[2].Trim();
                    designacao = split[2];

                    Script_TextBox.Text = Script_TextBox.Text.Replace("designacao", designacao);
                }
            }
        }

        public void ChangeMascaraLAN()
        {
            if (Script_LANMascaraBox.SelectedIndex == 0)
            {
                mascaraStr = "255.255.255.252";
            }
            if (Script_LANMascaraBox.SelectedIndex == 1)
            {
                mascaraStr = "255.255.255.248";
            }
            if (Script_LANMascaraBox.SelectedIndex == 2)
            {
                mascaraStr = "255.255.255.240";
            }
            if (Script_LANMascaraBox.SelectedIndex == 3)
            {
                mascaraStr = "255.255.255.224";
            }
            if (Script_LANMascaraBox.SelectedIndex == 4)
            {
                mascaraStr = "255.255.255.192";
            }
            if (Script_LANMascaraBox.SelectedIndex == 5)
            {
                mascaraStr = "255.255.255.128";
            }
            if (Script_LANMascaraBox.SelectedIndex == 6)
            {
                mascaraStr = "255.255.255.0";
            }
        }

        public void ApplyVozVariables()
        {
            if (activityType == ActivityType.VOZ)
            {
                Script_VozTitleLabel.Show();
                Script_SinalizSubTitle.Show();
                Script_SinalizBox.Show();
                Script_ButtonRegraAdc.Show();

                Script_VarName16.Show();
                Script_VarName17.Show();
                Script_VarName18.Show();
                Script_VarName19.Show();
                Script_VarName20.Show();
                Script_VarName21.Show();

                Script_VarText16.Show();
                Script_VarText17.Show();
                Script_VarText18.Show();
                Script_VarText19.Show();
                Script_VarText20.Show();
                Script_VarText21.Show();

                Script_VarDelete16.Show();
                Script_VarDelete17.Show();
                Script_VarDelete18.Show();
                Script_VarDelete19.Show();
                Script_VarDelete20.Show();
                Script_VarDelete21.Show();

                Script_VarEx16.Show();
                Script_VarEx17.Show();
                Script_VarEx18.Show();
                Script_VarEx19.Show();
                Script_VarEx20.Show();
                Script_VarEx21.Show();
            }
            else
            {
                Script_VozTitleLabel.Hide();
                Script_SinalizSubTitle.Hide();
                Script_SinalizBox.Hide();
                Script_ButtonRegraAdc.Hide();

                Script_VarName16.Hide();
                Script_VarName17.Hide();
                Script_VarName18.Hide();
                Script_VarName19.Hide();
                Script_VarName20.Hide();
                Script_VarName21.Hide();

                Script_VarText16.Hide();
                Script_VarText17.Hide();
                Script_VarText18.Hide();
                Script_VarText19.Hide();
                Script_VarText20.Hide();
                Script_VarText21.Hide();

                Script_VarDelete16.Hide();
                Script_VarDelete17.Hide();
                Script_VarDelete18.Hide();
                Script_VarDelete19.Hide();
                Script_VarDelete20.Hide();
                Script_VarDelete21.Hide();

                Script_VarEx16.Hide();
                Script_VarEx17.Hide();
                Script_VarEx18.Hide();
                Script_VarEx19.Hide();
                Script_VarEx20.Hide();
                Script_VarEx21.Hide();
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
                Script_VarName04.Text = "Nº da Vlan: ";
            }
        }

        public void ChangeLANIPTextBoxSize()
        {
            if (logOrNot == false)
            {
                Script_VarText09.Size = new System.Drawing.Size(102, 25);
                Script_VarName04.Text = "Número VLAN na WAN:";
                Script_LANMascaraBox.Show();
            }
            else
            {
                Script_VarText09.Size = new System.Drawing.Size(162, 25);
                Script_VarName04.Text = "Interface Logica WAN:";
                Script_LANMascaraBox.Hide();
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
        #endregion

        // ---------------------------
        // Importar do SAIP
        // ---------------------------
        #region
        private void Button_ImportSAIP_Click(object sender, EventArgs e)
        {
            string copiado = Clipboard.GetText();
            string[] split = copiado.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            // ------------------------------------------------
            try
            {
                if (split[4].Contains("Business Link Direct"))
                {
                    // Hostname / Description / Bandwidth
                    split[28] = split[28].Replace("Domínio  ", string.Empty).Trim();
                    Script_VarText00.Text = split[28] + "_BLD";
                    Script_VarText01.Text = split[58].Replace("Description Roteador  ", string.Empty).Trim(); ;
                    Script_VarText02.Text = split[40].Replace("Banda	", string.Empty).Trim(); ;

                    // Porta da WAN
                    Script_VarText03.Text = split[32].Replace("Porta  ", string.Empty).Trim();

                    // IPs da WAN
                    split[37] = split[37].Replace("IP Serial Usuário (IPv4)  ", string.Empty).Trim();
                    string[] ipPE = split[37].Split('/');
                    Script_VarText07.Text = GetBackboneInterfaceIP(ipPE[0], true);               // IP da Porta
                    Script_VarText08.Text = ipPE[0];                                             // IP da Porta + 1 (bloco /30)

                    // IP de LAN
                    split[54] = split[54].Replace("Blocos IPv4  ", string.Empty).Trim();
                    string[] ipLan = split[54].Split('/');
                    Script_VarText09.Text = GetBackboneInterfaceIP(ipLan[0], false);
                    MascaraLAN('/' + ipLan[1]);

                }
                // ------------------------------------------------
                else if (split[4].Contains("IPVPN"))
                {
                    // Hostname / Description / Bandwidth
                    split[59] = split[59].Replace("Description Roteador  ", string.Empty);
                    string[] hostname = split[59].Split('|');
                    Script_VarText00.Text = hostname[0].Trim() + "_" + hostname[2].Trim();
                    Script_VarText01.Text = split[59].Trim();
                    Script_VarText02.Text = split[41].Replace("Banda  ", string.Empty).Trim();

                    // Porta da WAN
                    Script_VarText03.Text = split[33].Replace("Porta  ", string.Empty).Trim();

                    // IPs do PE
                    split[38] = split[38].Replace("IP Serial Usuário (IPv4)  ", string.Empty).Trim();
                    string[] ipPE = split[54].Split('/');
                    Script_VarText07.Text = GetBackboneInterfaceIP(ipPE[0], true);              // IP da Porta
                    Script_VarText08.Text = ipPE[0];                                            // IP da Porta + 1 (bloco /30)

                    // IP de LAN
                    split[55] = split[55].Replace("Blocos IPv4  ", string.Empty).Trim();
                    string[] ipLan = split[55].Split('/');
                    Script_VarText09.Text = GetBackboneInterfaceIP(ipLan[0], false);
                    MascaraLAN(ipLan[1]);

                    // VRF
                    Script_VarText14.Text = split[30].Replace("Vrf  ", string.Empty).Trim();
                    Script_VarText15.Text = split[31].Replace("SERVICE_ID  ", string.Empty).Trim();
                }
                // ------------------------------------------------
                else if (split[4].Contains("Voice"))
                {
                    // Hostname / Description / Bandwidth
                    split[17] = split[17].Replace("Designação IP  ", string.Empty).Trim();
                    split[76] = split[76].Replace("Description Roteador  ", string.Empty).Trim();
                    string[] numero = split[17].Split('/');
                    string[] name = split[76].Split('|');
                    // --------
                    Script_VarText00.Text = name[0].Trim() + "-" + numero[2];
                    Script_VarText01.Text = split[76];
                    Script_VarText02.Text = split[58].Replace("Banda  ", string.Empty).Trim();

                    // Porta da WAN
                    Script_VarText03.Text = split[49].Replace("Porta  ", string.Empty).Trim();

                    // IPs do PE
                    split[40] = split[40].Replace("IP Wan:  ", string.Empty).Trim();
                    string[] ipPE = split[40].Split('/');
                    Script_VarText07.Text = GetBackboneInterfaceIP(ipPE[0], true).Trim();      // IP da Porta
                    Script_VarText08.Text = ipPE[0];                                           // IP da Porta + 1 (bloco /30)

                    // IP de LAN
                    split[41] = split[41].Replace("IP PABX:  ", string.Empty).Trim();
                    string[] ipLan = split[41].Split('/');
                    Script_VarText09.Text = GetBackboneInterfaceIP(ipLan[0], false).Trim();

                    // IP do SIP Server
                    Script_VarText16.Text = split[43].Replace("IP SIP Acesso: 	", string.Empty);
                    Script_VarText17.Text = numero[2];
                    Script_VarText18.Text = numero[2].Remove(2, 8);
                    Script_VarText19.Text = numero[2];
                    
                    // N de Canais
                    if (int.Parse(Script_VarText02.Text) >= 1500)
                    {
                        if (Script_SinalizBox.SelectedIndex == 0)
                        {
                            Script_VarText18.Text = "1-5,17-31";
                        }
                        else
                        {
                            Script_VarText18.Text = "1-31";
                        }
                    }
                    
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erro: " + exc.Message);
            }
        }

        public string GetBackboneInterfaceIP(string ip, bool minus)
        {
            int x;

            if (minus)
            { x = (-1); }
            else
            { x = 1; }

            string[] ipSplit = ip.Split('.');

            for (int i = 0; i < ipSplit.Length; i++)
            {
                char a = ipSplit[i][0];
                if (a == '0')
                {
                    ipSplit[i] = ipSplit[i].Remove(0, 1);
                    if (ipSplit[i].Substring(0) == "0")
                    {
                        ipSplit[i] = ipSplit[i].Remove(0, 1);
                    }
                }
            }

            int finalOctet = int.Parse(ipSplit[3]) + x;
            return ipSplit[0] + "." + ipSplit[1] + "." + ipSplit[2] + "." + finalOctet.ToString();
        }

        public void MascaraLAN(string mascara)
        {
            if (mascara == "/30")
            {
                Script_LANMascaraBox.SelectedIndex = 0;
            }
            else if (mascara == "/29")
            {
                Script_LANMascaraBox.SelectedIndex = 1;
            }
            else if (mascara == "/28")
            {
                Script_LANMascaraBox.SelectedIndex = 2;
            }
            else if (mascara == "/27")
            {
                Script_LANMascaraBox.SelectedIndex = 3;
            }
            else if (mascara == "/26")
            {
                Script_LANMascaraBox.SelectedIndex = 4;
            }
            else if (mascara == "/25")
            {
                Script_LANMascaraBox.SelectedIndex = 5;
            }
            else if (mascara == "/24")
            {
                Script_LANMascaraBox.SelectedIndex = 6;
            }
            else
            {
                MessageBox.Show("IP de LAN out of range");
            }
        }

        #endregion
        
        // ---------------------------------------------------------------------------
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
            FormVersionControl versionTab = new FormVersionControl();
            versionTab.Show();
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
            ApplyNightMode(this, nightMode);

            Properties.Settings.Default.darkMode = nightMode;
            Properties.Settings.Default.Save();

        }

        public void ApplyNightMode(Control ctr, bool darkMode)
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
                ApplyNightMode(child, nightMode);
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
        #region
        private void NotImplemented(object sender, EventArgs e)
        {
            player.Play();
            MessageBox.Show("Not Implemented");
        }
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ----------------------------- Test ----------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
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

        // ----------------------
        // Script Test Values
        // ----------------------
        private void Button_ApplyTestValues_Click(object sender, EventArgs e)
        {
            Script_VarText00.Text = "Teste_NAME";
            Script_VarText01.Text = "TESTE | nao sei | PNIS/IP/00024";
            Script_VarText02.Text = "50000";
            Script_VarText03.Text = "G0/0";
            Script_VarText04.Text = "5";
            Script_VarText05.Text = "G0/1";
            Script_VarText06.Text = "G0/1.12";
            Script_VarText07.Text = "192.168.1.1";
            Script_VarText08.Text = "192.168.1.2";
            Script_VarText09.Text = "10.10.10.1";
            Script_VarText10.Text = "172.40.165.37";
            Script_VarText11.Text = "21.21.21.21";
            Script_VarText12.Text = "65000";
            Script_VarText13.Text = "12025";
            Script_VarText14.Text = "VRFteste:666";
            Script_VarText15.Text = "100395";
            Script_LANMascaraBox.SelectedIndex = 2;
        }

        #endregion


    }

}