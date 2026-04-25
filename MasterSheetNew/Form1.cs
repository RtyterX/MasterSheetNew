using MasterSheetNew.Entitys;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterSheetNew
{
    public partial class Form1 : Form
    {
        // Night Mode
        bool nightMode = Properties.Settings.Default.nightMode;

        // Password Values
        public bool firstAccess = Properties.Settings.Default.firstAccess;
        public bool enableTest = Properties.Settings.Default.enableTest;
        public bool enableEdit = Properties.Settings.Default.enableEdit;
        public bool canImportSAIP = Properties.Settings.Default.canImportSAIP;

        // Scripts
        private List<Script> scripts = new List<Script>();
        private readonly ScriptHelper ScriptHelper = new ScriptHelper();

        // Script Options 
        private RouterType routerType;
        private ActivityType activityType;
        private ProcedureType procedureType;
        private bool backboneOrNot;
        private bool finalsOrNot;
        private RouterType peType;

        // Config Strings
        private string logType;
        private string designacao;
        private string mascaraStr;

        // Log Tools
        private string suporteTitle;
        private string commandStr;
        private string fechamentoSubInfo;
        private string pendenciaRestore;
        private readonly IPCalculator ipCalculator = new IPCalculator();
        private readonly List<Button> logtoolsButtons = new List<Button>();

        // Log de Ligacao
        private string ligacaoRestore;

        // Outros 
        string outros;
        private string mascaraVlan;
        private string mascaraDHCP;

        // UI Lists
        private readonly List<Label> varName = new List<Label>();
        private readonly List<TextBox> varText = new List<TextBox>();
        private readonly List<Button> varDelete = new List<Button>();
        private readonly List<Label> varEx = new List<Label>();
        public readonly List<Client> clients = new List<Client>();
        private readonly List<Step> allSteps = new List<Step>();

        // Sounds
        private readonly SoundPlayer player = new SoundPlayer(Properties.Resources.Perdemo);

        // Preferences
        private string userPE = "";
        private string userTacacs = "";
        private string puttyPath = "";

        // Clients
        private int step;
        private Client usingClient;
        private readonly List<Label> clientVarName = new List<Label>();
        private readonly List<TextBox> clientVarText = new List<TextBox>();
        private readonly List<Button> clientVarDelete = new List<Button>();
        private readonly List<Label> clientVarEx = new List<Label>();

        // Velocloud
        private string veloRestore = "";

        // Automation
        public bool isXR = false;
        private readonly Automation Automation = new Automation();
        public string scriptPE = "";
        public string scriptCPE = "";

        // Degug
        private bool trueScript = false;
        private bool canPressAgain = true;

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
        // ---------------------------- START UP -------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        //---------------------
        // StartUP Function
        //---------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("\r\n--> Starting MasterSheet...\r\n");

            // Load Night Mode
            ApplyNightMode(this, nightMode);

            // Load Values and Lists
            GetAllClients();
            ListAllClientVarUI();
            ListLogToolsButtons();
            FillClientButtons();
            CheckTestUI();
            CheckCanImportFromSAIP();
            LoadPrefs();

            // List Script and Routers 
            LoadRouterList();
            ListAllScriptVars();

            // Load all Scripts
            Script scriptClass = new Script(99, "Teste", false, "", "", "", DateTime.Parse("11/02/2026"));
            scripts = scriptClass.AddScripts();

            // Startup ComboBox Options
            Script_LogBox.SelectedIndex = 0;
            Script_XRBox.SelectedIndex = 1;
            Script_LANMascaraBox.SelectedIndex = 2;
            Outros_TypeComboBox.SelectedIndex = 0;
            OpenPE_ComboBox.SelectedIndex = 0;
            Outros_RegraAdc_NumDaRegraComboBox.SelectedIndex = 1;
            ChangeAllPortBlockComboBox(1);

            // Return to Main Page
            tabControl2.SelectedTab = tabMainPage;

            // First Access Message
            if (firstAccess)
            {
                Debug.WriteLine("\r\n--> First Access");
                MessageBox.Show("Bem Vindo a MasterSheet!\n\n" +
                    "Para começar, selecione o tipo de atividade que deseja realizar (Configuração ou Coleta de Logs) e depois o modelo do equipamento.\n\n" +
                    "Se for sua primeira vez utilizando o programa, recomendamos acessar a seção de Preferências para preencher as informações de acesso rápido PE.\n\n" +
                    "Em caso de dúvidas ou sugestões, entre em contato com a equipe de desenvolvimento.");

                Properties.Settings.Default.firstAccess = false;
                Properties.Settings.Default.Save();
            }

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

            Debug.WriteLine("\r\n\r\n...MasteSheet Ready");
        }

        public void LoadRouterList()
        {
            // Router List
            Router routerClass = new Router();
            List<Router> routerList = routerClass.GetRouterList();

            // Set Router List in Data Grid
            IOS_DataGrid_Routers.DataSource = routerList;
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

        public void GetAllClients()
        {
            TesteFillClientList();
        }

        public void FillClientButtons()
        {
            List<Button> buttons = new List<Button>();
            List<Client> newList = clients;

            buttons.Add(MainPage_Button_Cliente0);
            buttons.Add(MainPage_Button_Cliente1);
            buttons.Add(MainPage_Button_Cliente2);
            buttons.Add(MainPage_Button_Cliente3);
            buttons.Add(MainPage_Button_Cliente4);
            buttons.Add(MainPage_Button_Cliente5);

            int count = 1;

            if (count <= 6)
            {
                foreach (Button b in buttons)
                {
                    foreach (Client c in newList)
                    {
                        if (c.showOnScreen)
                        {
                            count = ++count;
                            b.Name = "ButtonClient_" + c.name;
                            b.Text = c.name;
                            b.Click += new EventHandler(OpenClickClient);
                            newList.Remove(c);
                            break;
                        }
                    }
                }
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

        public void ListAllClientVarUI()
        {
            clientVarName.Add(Client_NameVar00);
            clientVarName.Add(Client_NameVar01);
            clientVarName.Add(Client_NameVar02);
            clientVarName.Add(Client_NameVar03);
            clientVarName.Add(Client_NameVar04);
            clientVarName.Add(Client_NameVar05);
            clientVarName.Add(Client_NameVar06);
            clientVarName.Add(Client_NameVar07);
            clientVarName.Add(Client_NameVar08);
            clientVarName.Add(Client_NameVar09);

            clientVarText.Add(Client_VarText00);
            clientVarText.Add(Client_VarText01);
            clientVarText.Add(Client_VarText02);
            clientVarText.Add(Client_VarText03);
            clientVarText.Add(Client_VarText04);
            clientVarText.Add(Client_VarText05);
            clientVarText.Add(Client_VarText06);
            clientVarText.Add(Client_VarText07);
            clientVarText.Add(Client_VarText08);
            clientVarText.Add(Client_VarText09);

            clientVarDelete.Add(Client_VarDelete00);
            clientVarDelete.Add(Client_VarDelete01);
            clientVarDelete.Add(Client_VarDelete02);
            clientVarDelete.Add(Client_VarDelete03);
            clientVarDelete.Add(Client_VarDelete04);
            clientVarDelete.Add(Client_VarDelete05);
            clientVarDelete.Add(Client_VarDelete06);
            clientVarDelete.Add(Client_VarDelete07);
            clientVarDelete.Add(Client_VarDelete08);
            clientVarDelete.Add(Client_VarDelete09);

            clientVarEx.Add(Client_VarEx00);
            clientVarEx.Add(Client_VarEx01);
            clientVarEx.Add(Client_VarEx02);
            clientVarEx.Add(Client_VarEx03);
            clientVarEx.Add(Client_VarEx04);
            clientVarEx.Add(Client_VarEx05);
            clientVarEx.Add(Client_VarEx06);
            clientVarEx.Add(Client_VarEx07);
            clientVarEx.Add(Client_VarEx08);
            clientVarEx.Add(Client_VarEx09);
        }

        public void ListLogToolsButtons()
        {     
            logtoolsButtons.Add(LogTools_Pendencia);
            logtoolsButtons.Add(LogTools_Fechamento);
            logtoolsButtons.Add(LogTools_Suporte);
            logtoolsButtons.Add(LogTools_Calc);
            logtoolsButtons.Add(LogTools_DBScript);

            HighlightLogToolsButtons(LogTools_Pendencia);
        }
        #endregion

        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // --------------------------- MAIN PAGE -------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // ------------------------
        // Configuracao
        // ------------------------

        private void BLD_button_Click(object sender, EventArgs e)
        {
            backboneOrNot = false;
            procedureType = ProcedureType.Config;
            tabControl2.SelectedTab = tabSelectRouter;

            BackButton_Script.Visible = true;
            BackButton_Script2.Hide();
            BackButton_Script3.Hide();

            Config_Button_Aligera.Hide();
            Config_Button_Digistar.Hide();
            Config_Button_Fortigate.Show();
            Config_Button_Huawei.Show();
            Config_Button_Broadsoft.Hide();

            Config_SubTitle.Text = "BLD";

            activityType = ActivityType.BLD;
        }

        private void MPLS_button_Click(object sender, EventArgs e)
        {
            backboneOrNot = false;
            procedureType = ProcedureType.Config;
            tabControl2.SelectedTab = tabSelectRouter;

            BackButton_Script.Visible = true;
            BackButton_Script2.Hide();
            BackButton_Script3.Hide();

            Config_Button_Aligera.Hide();
            Config_Button_Digistar.Hide();
            Config_Button_Fortigate.Show();
            Config_Button_Huawei.Show();
            Config_Button_Broadsoft.Hide();

            Config_SubTitle.Text = "MPLS";

            activityType = ActivityType.MPLS;
        }

        private void VOZ_Button_Click(object sender, EventArgs e)
        {
            backboneOrNot = false;
            procedureType = ProcedureType.Config;
            tabControl2.SelectedTab = tabSelectRouter;

            BackButton_Script.Visible = true;
            BackButton_Script2.Hide();
            BackButton_Script3.Hide();

            Config_Button_Aligera.Show();
            Config_Button_Digistar.Show();
            Config_Button_Fortigate.Hide();
            Config_Button_Huawei.Hide();
            Config_Button_Broadsoft.Show();

            Config_SubTitle.Text = "VOZ";

            activityType = ActivityType.VOZ;
        }

        // ------------------------
        // Logs
        // ------------------------

        private void Logs_Iniciais_Click(object sender, EventArgs e)
        {
            finalsOrNot = false;
            ApplyLogType();
        }

        private void Logs_Finais_Click(object sender, EventArgs e)
        {
            finalsOrNot = true;
            ApplyLogType();
        }

        public void ApplyLogType()
        {
            tabControl2.SelectedTab = tabLogs;

            procedureType = ProcedureType.Logs;
            backboneOrNot = false;

            Script_SwitchLabel.Text = finalsOrNot ? "FINAIS" : "INICIAIS";
            buttonSwitchVeloLog.Text = !finalsOrNot ? "FINAIS" : "INICIAIS";

            if (finalsOrNot)
            {
                Script_LogBox.Text = "FINAIS";
            }
            else
            {
                Script_LogBox.Text = "INICIAIS";
            }


            BackButton_Script.Hide();
            BackButton_Script2.Hide();
            BackButton_Script3.Visible = true;
        }


        // ------------------------
        // Wizard Gat
        // ------------------------

        private void WizGat_Open(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabWizGat;

            BackButton_Script2.Visible = true;
            BackButton_Script.Hide();
            BackButton_Script3.Hide();

            procedureType = ProcedureType.Logs;
            backboneOrNot = true;
        }

        // ------------------------
        // Clients
        // ------------------------

        private void AllClients_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllClientsButtonBuilder();
            tabControl2.SelectedTab = tabSelectClient;

        }

        private void OpenClickClient(object sender, EventArgs e)
        {
            string te = sender.ToString().Remove(0, 35);

            Client newCliente = clients.Find(c => c.name == te);

            OpenClient(newCliente);
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

        private void MainPage_Button_SNMP_Click(object sender, EventArgs e)
        {
            OpenOutrosSNMP();
        }
        private void MainPage_Button_QoS_Click(object sender, EventArgs e)
        {
            OpenOutrosQoS();
        }
        private void MainPage_Button_BGP_Click(object sender, EventArgs e)
        {
            OpenOutrosBGP();
        }

        private void MainPage_Button_VLAN_Click(object sender, EventArgs e)
        {
            OpenOutrosVLAN();
        }

        private void MainPage_Button_DHCP_Click(object sender, EventArgs e)
        {
            OpenOutrosDHCP();
        }

        private void MainPage_Button_IPFlow_Click(object sender, EventArgs e)
        {
            OpenOutrosIPFlow();
        }

        private void MainPage_Button_User_Click(object sender, EventArgs e)
        {
            OpenOutrosUSUARIOS();
        }

        private void MainPage_Button_RegraAdicional_Click(object sender, EventArgs e)
        {
            OpenOutrosRegraAdc();
        }

        private void MainPage_Button_RIP_Click(object sender, EventArgs e)
        {
            OpenOutrosRIP();
            NotTested();
        }

        private void MainPage_Button_OSPF_Click(object sender, EventArgs e)
        {
            OpenOutrosOSPF();
            NotTested();
        }

        private void MainPage_Button_VRRP_Click(object sender, EventArgs e)
        {
            OpenOutrosVRRP();
            NotTested();
        }

        private void MainPage_Button_GLBP_Click(object sender, EventArgs e)
        {
            OpenOutrosGLBP();
            NotTested();
        }

        private void MainPage_Button_HSRP_Click(object sender, EventArgs e)
        {
            OpenOutrosHSRP();
            NotTested();
        }

        private void MainPage_Button_EIGRP_Click(object sender, EventArgs e)
        {
            OpenOutrosEIGRP();
            NotTested();
        }

        private void MainPage_Button_Hotline_Click(object sender, EventArgs e)
        {
            OpenOutrosHotline();
            NotTested();
        }

        private void MainPage_Button_ExtrasFortigate_Click(object sender, EventArgs e)
        {
            FortigateExtra();
            NotTested();
        }

        private void MainPage_Button_BlockPort_Click(object sender, EventArgs e)
        {
            OpenOutrosBlockPort();
        }

        // ---------------------------------------------------------------------------
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // -------------------------- SELECT ROUTER ----------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        private void Cisco_Button_Click(object sender, EventArgs e)
        {
            Script_Button_Config.Text = "Logs";
            routerType = RouterType.Cisco;
            backboneOrNot = false;
            procedureType = ProcedureType.Config;
            tabControl2.SelectedTab = tabScript;
            DispatcherUI(routerType, activityType, procedureType, backboneOrNot, peType);
        }

        private void HPE_Button_Click(object sender, EventArgs e)
        {
            Script_Button_Config.Text = "Logs";
            routerType = RouterType.HPE;
            backboneOrNot = false;
            procedureType = ProcedureType.Config;
            DispatcherUI(routerType, activityType, procedureType, backboneOrNot, peType);
        }

        private void Config_HPE_old_Click(object sender, EventArgs e)
        {
            Script_Button_Config.Text = "Logs";
            routerType = RouterType.HPE_old;
            backboneOrNot = false;
            procedureType = ProcedureType.Config;
            DispatcherUI(routerType, activityType, procedureType, backboneOrNot, peType);
        }

        private void Config_Huawei_Click(object sender, EventArgs e)
        {
            Script_Button_Config.Text = "Logs";
            routerType = RouterType.Huawei;
            backboneOrNot = false;
            procedureType = ProcedureType.Config;
            DispatcherUI(routerType, activityType, procedureType, backboneOrNot, peType);
        }

        private void Config_Fortigate_Click(object sender, EventArgs e)
        {
            Script_Button_Config.Text = "Logs";
            routerType = RouterType.Fortigate;
            backboneOrNot = false;
            procedureType = ProcedureType.Config;
            DispatcherUI(routerType, activityType, procedureType, backboneOrNot, peType);
        }

        private void Config_Aligera_Click(object sender, EventArgs e)
        {
            Script_Button_Config.Text = "Logs";
            routerType = RouterType.Aligera;
            backboneOrNot = false;
            procedureType = ProcedureType.Config;
            DispatcherUI(routerType, activityType, procedureType, backboneOrNot, peType);
        }

        private void Config_Digistar_Click(object sender, EventArgs e)
        {
            Script_Button_Config.Text = "Logs";
            routerType = RouterType.Digistar;
            backboneOrNot = false;
            procedureType = ProcedureType.Config;
            DispatcherUI(routerType, activityType, procedureType, backboneOrNot, peType);
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
            Script_Button_Config.Text = "Config";
            procedureType = ProcedureType.Logs;
            backboneOrNot = false;
            DispatcherUI(RouterType, ActivityType, procedureType, backboneOrNot, peType);
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
            Script_TextBox.SelectionStart = 0;
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

        private void SelectRouter_LogButton_Click(object sender, EventArgs e)
        {
            ApplyLogType();
        }

        private void Logs_VOZ_Broadsoft_Click(object sender, EventArgs e)
        {
            NotImplemented(this, null);
        }

        private void Logs_Ligacao_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabLigacoes;
            ApplyLogsDeLigacao();
        }

        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // --------------------------- WIZARD GAT ------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        public void ApplyWizGat(RouterType backboneType, ActivityType ActivityType)
        {
            Debug.WriteLine("\r\n--> Wizard GAT UI Dispatched with Backbone Type: " + backboneType + " and Activity Type: " + ActivityType);

            tabControl2.SelectedTab = tabScript;
            procedureType = ProcedureType.Logs;
            backboneOrNot = true;
            DispatcherUI(routerType, ActivityType, procedureType, backboneOrNot, backboneType);

            Debug.WriteLine("Tab changed to Script Tab ");
        }

        // ----------------------
        // Cisco
        // ----------------------
        private void WizCiscoBLD_Click(object sender, EventArgs e)
        {
            peType = RouterType.Cisco;
            activityType = ActivityType.BLD;
            ApplyWizGat(peType, activityType);
        }

        private void WizCiscoMPLS_Click(object sender, EventArgs e)
        {
            peType = RouterType.Cisco;
            activityType = ActivityType.MPLS;
            ApplyWizGat(peType, activityType);
        }

        private void WizCiscoVoz_Click(object sender, EventArgs e)
        {
            peType = RouterType.Cisco;
            activityType = ActivityType.VOZ;
            ApplyWizGat(peType, activityType);
        }

        private void WizCiscoBGP_Click(object sender, EventArgs e)
        {
            peType = RouterType.Cisco;
            activityType = ActivityType.BLDcomBGP;
            ApplyWizGat(peType, activityType);
        }

        // ----------------------
        // Nokia
        // ----------------------
        private void WizNokiaBLD_Click(object sender, EventArgs e)
        {
            peType = RouterType.Nokia;
            activityType = ActivityType.BLD;
            ApplyWizGat(peType, activityType);
        }

        private void WizNokiaMPLS_Click(object sender, EventArgs e)
        {
            peType = RouterType.Nokia;
            activityType = ActivityType.MPLS;
            ApplyWizGat(peType, activityType);
        }

        private void WizNokiaVoz_Click(object sender, EventArgs e)
        {
            peType = RouterType.Nokia;
            activityType = ActivityType.VOZ;
            ApplyWizGat(peType, activityType);
        }

        private void WizNokiaBLDcBGP_Click(object sender, EventArgs e)
        {
            peType = RouterType.Nokia;
            activityType = ActivityType.BLDcomBGP;
            ApplyWizGat(peType, activityType);
        }
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // -------------------------- SCRIPT TAB -------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        // ---------------------------
        // Variable Buttons
        // ---------------------------
        #region
        private void Button_FormatarECopiarScript_Click(object sender, EventArgs e)
        {
            ApplyTextBoxScript();
            Clipboard.SetText(Script_TextBox.Text);
        }

        private void Button_FormatarScript_Click(object sender, EventArgs e)
        {
            ApplyTextBoxScript();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Script_TextBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllVar();
        }

        public void ClearAllVar()
        {
            foreach (TextBox t in varText)
            {
                t.Text = string.Empty;
            }

            OpenPE_ComboBox.SelectedIndex = 0;
            Script_LANMascaraBox.SelectedIndex = -1;
            Script_VarText03b.Text = string.Empty;

            Script_VarRouteI1.Text = string.Empty;
            Script_VarRouteI2.Text = string.Empty;
            Script_VarRouteE1.Text = string.Empty;
            Script_VarRouteE2.Text = string.Empty;

            Debug.WriteLine("\r\n--> All Script Variables Cleared");
        }

        private void Button_SwitchLog_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabSelectRouter;
            procedureType = ProcedureType.Config;
        }

        public void SwitchConfAndLogs()
        {
            if (procedureType == ProcedureType.Config)
            {
                tabControl2.SelectedTab = tabLogs;
                procedureType = ProcedureType.Logs;
            }
            else
            {
                tabControl2.SelectedTab = tabSelectRouter;
                procedureType = ProcedureType.Config;
            }
        }

        private void Script_Button_Inverter_Click(object sender, EventArgs e)
        {
            (Script_VarText05.Text, Script_VarText03.Text) = (Script_VarText03.Text, Script_VarText05.Text);
        }

        private void Script_Button_ClearPortas_Click(object sender, EventArgs e)
        {
            Script_VarText03.Text = string.Empty;
            Script_VarText03b.Text = string.Empty;
            Script_VarText04.Text = string.Empty;
            Script_VarText05.Text = string.Empty;
            Script_VarText06.Text = string.Empty;
        }

        // --- Reused in all TextBoxes --- 
        private void Script_VarText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyTextBoxScript();
            }
        }

        // --- ComboBoxes ---
        private void Script_XRBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("\r\n--> XRBox Selected Index Changed: " + Script_XRBox.SelectedIndex);

            if (Script_XRBox.SelectedIndex == 0)
            {
                isXR = true;
            }
            else
            {
                isXR = false;
            }

            if (tabControl2.SelectedTab == tabScript)
            {
                ApplyTextBoxScript();
            }
        }

        private void Script_LogBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("\r\n--> LogBox Selected Index Changed: " + Script_LogBox.SelectedIndex);

            if (tabControl2.SelectedTab == tabScript)
            {
                if (Script_XRBox.SelectedIndex == 0)
                {
                    isXR = true;
                }
                else
                {
                    isXR = false;
                }

                ApplyTextBoxScript();
            }
        }

        private void Script_LANMascara_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("\r\n--> Mascara LAN in Script Selection Index Changed: " + Script_LANMascaraBox.SelectedIndex);

            if (tabControl2.SelectedTab == tabScript)
            {
                ApplyTextBoxScript();
            }
        }

        private void Script_SinalizBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("\r\n--> Sinalização in Script Selection Index Changed: " + Script_SinalizBox.SelectedIndex);

            if (tabControl2.SelectedTab == tabScript)
            {
                ApplyTextBoxScript();
            }
        }

        private void Script_RouterModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("\r\n--> Router Model Changed in Script: " + Script_RouterModelBox.SelectedIndex);

            if (tabControl2.SelectedTab == tabScript)
            {
                if (Script_VarText03.Text == string.Empty || Script_VarText03b.Text == string.Empty || Script_VarText05.Text == string.Empty)
                {
                    ApplyTextBoxScript();
                }
            }
        }

        // --- Others ---
        private void ButtonParte2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ScriptHelper.LogsExtras(routerType, scripts).Replace("switchType", Script_LogBox.Text));
            MessageBox.Show("Copiado Logs Parte2");
        }

        private void ButtonLimpeza_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(ScriptHelper.LogsLimpeza(routerType, activityType, scripts));
            MessageBox.Show("Copiado Script de Limpeza");
        }

        private void ButtonSwitchScriptLog_Click(object sender, EventArgs e)
        {
            finalsOrNot = !finalsOrNot;
            SwitchLogs();
            DispatcherUI(routerType, activityType, procedureType, backboneOrNot, peType);
        }

        private void Script_ButtonRegraAdc_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabOutros;
            Outros_Title.Text = "Regras Adicionais - VOZ";

            OpenOutrosRegraAdc();
        }

        private void Script_DebugButton_Click(object sender, EventArgs e)
        {
            if (backboneOrNot)
            {
                if (routerType == RouterType.Cisco)
                {
                    FormDebug debugForm = new FormDebug(MasterSheetNew.Properties.Settings.Default.debugBBCisco);
                    debugForm.Show(Owner);
                }
                else    // NOKIA
                {
                    FormDebug debugForm = new FormDebug(MasterSheetNew.Properties.Settings.Default.debugBBNokia);
                    debugForm.Show(Owner);
                }
            }
            else    // CPE
            {
                if (routerType == RouterType.Cisco)
                {
                    FormDebug debugForm = new FormDebug(MasterSheetNew.Properties.Settings.Default.debugCisco);
                    debugForm.Show(Owner);
                }
                if (routerType == RouterType.HPE)
                {
                    FormDebug debugForm = new FormDebug(MasterSheetNew.Properties.Settings.Default.debugHPE);
                    debugForm.Show(Owner);
                }
                if (routerType == RouterType.Huawei)
                {
                    FormDebug debugForm = new FormDebug(MasterSheetNew.Properties.Settings.Default.debugHuawei);
                    debugForm.Show(Owner);
                }
                if (routerType == RouterType.Fortigate)
                {
                    FormDebug debugForm = new FormDebug(MasterSheetNew.Properties.Settings.Default.debugFortigate);
                    debugForm.Show(Owner);
                }
            }
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
        private void Script_DeleteVar03b_Click(object sender, EventArgs e)
        {
            Script_VarText03b.Text = string.Empty;
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
        private void Script_VarDelete21_Click(object sender, EventArgs e)
        {
            Script_VarText21.Text = string.Empty;
        }
        private void Script_VarDelete17_Click(object sender, EventArgs e)
        {
            Script_VarText17.Text = string.Empty;
        }
        private void Script_VarDelete18_Click(object sender, EventArgs e)
        {
            Script_VarText18.Text = string.Empty;
        }
        private void Script_VarDelete19_Click(object sender, EventArgs e)
        {
            Script_VarText19.Text = string.Empty;
        }
        private void Script_VarDelete20_Click(object sender, EventArgs e)
        {
            Script_VarText20.Text = string.Empty;
        }
        private void Script_VarDelete16_Click(object sender, EventArgs e)
        {
            Script_VarText16.Text = string.Empty;
        }
        #endregion

        // ---------------------------------------------------------------------------
        #endregion

        // ---------------------------
        // Dispatch Tab Script UI Organizaer
        // ---------------------------
        #region
        public void DispatcherUI(RouterType routerType, ActivityType activityType, ProcedureType procedureType, bool backboneOrNot, RouterType backboneType)
        {
            Debug.WriteLine("\r\n--> Script UI rearrenged\r\nRouterType: " + routerType + ", ActivityType: " + activityType + ", ProcedureType: " + procedureType + ", Backbone: " + backboneOrNot + ", PE: " + backboneType);

            ChangeLANIPTextBoxSize();

            // Switch Label Hide/Show
            if (backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_LogBox.Hide();
                Script_SwitchLabel.Show();
                Script_Button_SwitchLabel.Show();
            }
            else
            {
                Script_LogBox.Show();
                Script_SwitchLabel.Hide();
                Script_Button_SwitchLabel.Hide();
            }
            if (routerType == RouterType.Fortigate && procedureType == ProcedureType.Logs)
            {
                Script_SwitchLabel.Show();
                Script_Button_SwitchLabel.Show();
            }

            // Telnet Button
            if (backboneOrNot)
            {
                Script_Button_Telnet.Show();
                Script_Button_TelnetPlus.Hide();
            }
            else
            {
                Script_Button_Telnet.Hide();
                Script_Button_TelnetPlus.Show();
            }

            // -------------------------
            // SubTab Variables
            if (backboneOrNot && activityType == ActivityType.BLDcomBGP && backboneType == RouterType.Nokia)
            {
                Script_VarSubTab.SelectedTab = Script_SubTab_RouteMap;
            }
            else if (procedureType == ProcedureType.Config && activityType == ActivityType.VOZ)
            {
                Script_VarSubTab.SelectedTab = Script_SubTab_VozVar;
            }
            else
            {
                Script_VarSubTab.SelectedTab = Script_VarSubTab_Hollow;
            }

            // -------------------------
            // SubTab Buttons
            if (procedureType == ProcedureType.Logs)
            {
                Script_ButtonsSubTab.SelectedTab = Script_ButtonsSubTab_Logs;
            }
            else if (activityType == ActivityType.VOZ)
            {
                Script_ButtonsSubTab.SelectedTab = Script_ButtonsSubTab_Voz;
            }
            else if (backboneOrNot)
            {
                Script_ButtonsSubTab.SelectedTab = Script_ButtonsSubTab_BackboneBGP;
            }
            else
            {
                Script_ButtonsSubTab.SelectedTab = Script_ButtonsSubTab_Hollow;
            }


            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------------ CONFIGS -------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Config - Cisco - BLD -----------------------------------------------------
            if (routerType == RouterType.Cisco && activityType == ActivityType.BLD && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - CISCO - BLD";

                // Organize UI
                ScriptUIOrganizer(scripts[0].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - HPE - BLD -------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - HPE - BLD";

                // Organize UI
                ScriptUIOrganizer(scripts[1].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - HPE Old - BLD ---------------------------------------------------
            else if ((routerType == RouterType.HPE_old) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - HPE Antigo - BLD";

                // Organize UI
                ScriptUIOrganizer(scripts[2].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - Huawei - BLD ----------------------------------------------------
            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - HUAWEI - BLD";

                // Organize UI
                ScriptUIOrganizer(scripts[3].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - Fortigate - BLD -------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - FORTIGATE - BLD";

                // Organize UI
                ScriptUIOrganizer(scripts[4].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // -------------------------------------------------- MPLS --------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Config - Cisco - MPLS ----------------------------------------------------
            else if (routerType == RouterType.Cisco && activityType == ActivityType.MPLS && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - CISCO - MPLS";

                // Organize UI
                ScriptUIOrganizer(scripts[5].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - HPE - MPLS ------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - HPE - MPLS";

                // Organize UI
                ScriptUIOrganizer(scripts[6].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - HPE Old - MPLS --------------------------------------------------
            else if ((routerType == RouterType.HPE_old) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - HPE Antigo - MPLS";

                // Organize UI
                ScriptUIOrganizer(scripts[7].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - Huawei - MPLS ---------------------------------------------------
            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - HUAWEI - MPLS";

                // Organize UI
                ScriptUIOrganizer(scripts[8].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - Fortigate - MPLS ------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - FORTIGATE - MPLS";

                // Organize UI
                ScriptUIOrganizer(scripts[9].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // -------------------------------------------------- VOZ ---------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Config - Cisco - VOZ -----------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - CISCO - VOZ";

                // Organize UI
                ScriptUIOrganizer(scripts[10].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - HPE - VOZ -----------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - HPE - VOZ";

                // Organize UI
                ScriptUIOrganizer(scripts[13].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - HPE Antigo - VOZ -----------------------------------------------------
            else if ((routerType == RouterType.HPE_old) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - HPE Antigo - VOZ";

                // Organize UI
                ScriptUIOrganizer(scripts[15].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - Aligera - VOZ -----------------------------------------------------
            else if ((routerType == RouterType.Aligera) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - ALIGERA - VOZ";

                // Organize UI
                ScriptUIOrganizer(scripts[17].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Config - Digistar - VOZ -----------------------------------------------------
            else if ((routerType == RouterType.Digistar) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_ProcedureName.Text = "CONFIG - DIGISTAR - VOZ";

                // Organize UI
                ScriptUIOrganizer(scripts[12].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------------- LOGS ---------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Logs - Cisco - BLD -------------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - CISCO - BLD";

                // Organize UI
                ScriptUIOrganizer(scripts[19].variables);
                ExtraVariablesControl(true, false, true, true, false);
            }
            // ------------------------------------------- Logs - HPE - BLD ---------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - HPE - BLD";

                // Organize UI
                ScriptUIOrganizer(scripts[20].variables);
                ExtraVariablesControl(true, false, true, true, false);
            }
            // ------------------------------------------- Log - Fortigate - BLD ----------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - FORTIGATE - BLD";

                // Organize UI
                ScriptUIOrganizer(scripts[21].variables);
                ExtraVariablesControl(true, false, false, false, true);
            }
            // ------------------------------------------- Log - Huawei - BLD -------------------------------------------------------
            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - HUAWEI - BLD";

                // Organize UI
                ScriptUIOrganizer(scripts[22].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ---------------------------------------------- MPLS -------------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log - Cisco - MPLS -------------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - CISCO - MPLS";

                // Organize UI
                ScriptUIOrganizer(scripts[23].variables);
                ExtraVariablesControl(true, false, true, true, false);
            }
            // ------------------------------------------- Log - HPE - MPLS ---------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - HPE - MPLS";

                // Organize UI
                ScriptUIOrganizer(scripts[24].variables);
                ExtraVariablesControl(true, false, true, true, false);
            }
            // ------------------------------------------- Log - Huawei - MPLS ------------------------------------------------------
            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - HUAWEI - MPLS";

                // Organize UI
                ScriptUIOrganizer(scripts[26].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Log - Fortigate - MPLS ---------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - FORTIGATE - MPLS";

                // Organize UI
                ScriptUIOrganizer(scripts[25].variables);
                ExtraVariablesControl(true, false, false, false, true);
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ---------------------------------------------- VOZ -------------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log - Cisco - VOZ --------------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - CISCO - VOZ";

                // Organize UI
                ScriptUIOrganizer(scripts[27].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Log - HPE - VOZ ----------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - HPE - VOZ";

                // Organize UI
                ScriptUIOrganizer(scripts[28].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Log CPE Aligera ----------------------------------------------------------
            else if ((routerType == RouterType.Aligera) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - ALIGERA - VOZ";

                // Organize UI
                ScriptUIOrganizer(scripts[29].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }
            // ------------------------------------------- Log CPE Digistar ----------------------------------------------------------
            else if ((routerType == RouterType.Digistar) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "LOGS - DIGISTAR - VOZ";

                // Organize UI
                ScriptUIOrganizer(scripts[30].variables);
                ExtraVariablesControl(true, false, false, false, false);
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log Backbone - Cisco -----------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Cisco) && (activityType == ActivityType.BLD) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "BACKBONE - CISCO - BLD";

                // Organize UI
                ScriptUIOrganizer(scripts[31].variables);
                ExtraVariablesControl(false, true, false, false, true);
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Cisco) && (activityType == ActivityType.MPLS) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "BACKBONE - CISCO - MPLS";

                // Organize UI
                ScriptUIOrganizer(scripts[32].variables);
                ExtraVariablesControl(false, true, false, false, true);
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Cisco) && (activityType == ActivityType.VOZ) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "BACKBONE - CISCO - VOZ";

                // Organize UI
                ScriptUIOrganizer(scripts[33].variables);
                ExtraVariablesControl(false, true, false, false, true);
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Cisco) && (activityType == ActivityType.BLDcomBGP) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "BACKBONE - CISCO - BLD com BGP";

                // Organize UI
                ScriptUIOrganizer(scripts[34].variables);
                ExtraVariablesControl(false, true, false, false, true);
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log Backbone Nokia -------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Nokia) && (activityType == ActivityType.BLD) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "BACKBONE - NOKIA - BLD";

                // Organize UI
                ScriptUIOrganizer(scripts[35].variables);
                ExtraVariablesControl(false, false, false, false, true);
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Nokia) && (activityType == ActivityType.MPLS) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "BACKBONE - NOKIA - MPLS";

                // Organize UI
                ScriptUIOrganizer(scripts[36].variables);
                ExtraVariablesControl(false, false, false, false, true);
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Nokia) && (activityType == ActivityType.VOZ) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "BACKBONE - NOKIA - VOZ";

                // Organize UI
                ScriptUIOrganizer(scripts[37].variables);
                ExtraVariablesControl(false, false, false, false, true);
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Nokia) && (activityType == ActivityType.BLDcomBGP) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                Script_ProcedureName.Text = "BACKBONE - NOKIA - BLD com BGP";

                // Organize UI
                ScriptUIOrganizer(scripts[38].variables);
                ExtraVariablesControl(false, false, false, false, true);
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // --------------------------------------------------- ERROR ------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            else
            {
                player.Play();
                MessageBox.Show("Not Implemented - Router: " + routerType + " Type: " + activityType + " Procedure Type: " + procedureType.ToString() + " Backbone: " + backboneOrNot);

                Script_ProcedureName.Text = "ERROR";

                ExtraVariablesControl(false, false, false, false, false);

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

                MessageBox.Show("Erro ao Aplicar UI");
                Debug.WriteLine("Erro ao Aplicar UI\r\n\r\nRouterType: " + routerType + ", ActivityType: " + activityType + ", ProcedureType: " + procedureType + ", Backbone" + backboneOrNot);
            }


            // Others
            ChangeWANTextBox();

            ApplyTextBoxScript();  

            // Switch to Script Tab only after the Var UI construction
            tabControl2.SelectedTab = tabScript;

            Debug.WriteLine("\r\n--> Tab changed to Script Tab");
        }
        #endregion

        public void ApplyTextBoxScript()
        {
            Script_TextBox.Text = ScriptDispatcher(routerType, activityType, procedureType, backboneOrNot, peType);
        }

        // ---------------------------
        // Apply Script Dispatcher
        // ---------------------------
        #region

        public string ScriptDispatcher(RouterType routerType, ActivityType activityType, ProcedureType procedureType, bool backboneOrNot, RouterType backboneType)
        {
            Debug.WriteLine("\r\n--> Applied Script");
            Debug.WriteLine("\r\nRouterType: " + routerType + ", ActivityType: " + activityType + ", ProcedureType: " + procedureType + ", Backbone: " + backboneOrNot + ", PE: " + backboneType);


            string script = string.Empty;

            string bandaQoS = "";
            string vlanStr = "";

            Script actualScript = new Script(666, "token", false, "Nothing", "", "", DateTime.Parse("12/06/1997"));

            ChangeChannelNumber();
            GetDesignacao(Script_VarText01.Text);
            mascaraStr = ChangeMascaraLAN(Script_LANMascaraBox);

            if (Script_VarText03.Text == string.Empty && Script_VarText05.Text == string.Empty)
            {
                GetRouterModel(Script_RouterModelBox.Text);
            }

            // Log Type Box
            if (Script_LogBox.Text == null)
            {
                Script_LogBox.Text = "INICIAIS";
            }
            logType = Script_LogBox.Text;

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------------ CONFIGS -------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Config - Cisco - BLD -----------------------------------------------------
            if (routerType == RouterType.Cisco && activityType == ActivityType.BLD && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                actualScript = scripts[0];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "interface " + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "encapsulation dot1Q " + Script_VarText04.Text + "\r\n" +
                    "quit\r\n");

                    script = script.Replace("vlanNTP", "." + Script_VarText04.Text);
                }
                else
                {
                    script = script.Replace("withVlan", "!\r\n");
                    script = script.Replace("vlanNTP", "");
                }

            }
            // ------------------------------------------- Config - HPE - BLD -------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                actualScript = scripts[1];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "interface " + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n" +
                    "quit\r\n");
                }
                else
                {
                    script = script.Replace("withVlan", "#\r\n");
                }
            }
            // ------------------------------------------- Config - HPE Old - BLD ---------------------------------------------------
            else if ((routerType == RouterType.HPE_old) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                actualScript = scripts[2];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "interface " + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n");
                }
                else
                {
                    script = script.Replace("withVlan", "#\r\n");
                }
            }
            // ------------------------------------------- Config - Huawei - BLD ----------------------------------------------------
            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                actualScript = scripts[3];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "interface " + Script_VarText04.Text + "\r\n" +
                        " description " + Script_VarText01.Text + "\r\n" +
                        " dot1q termination vid " + Script_VarText04.Text + "\r\n" +
                        " bandwidth " + Script_VarText02.Text +
                        "#\r\n");

                    script = script.Replace("telsource", "." + Script_VarText04.Text);
                    script = script.Replace("infosource", "." + Script_VarText04.Text);
                }
                else
                {
                    script = script.Replace("telsource", "");
                    script = script.Replace("infosource", "");
                    script = script.Replace("withVlan", "#");
                }

                Script_Button_SwitchLabel.Hide();
            }
            // ------------------------------------------- Config - Fortigate - BLD -------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                actualScript = scripts[4];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "################# Configuracao VLAN na WAN  #################### \r\n" +
                        "#\r\n" +
                        "    edit " + '"' + Script_VarText04.Text + '"' + "\r\n" +
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
                    script = script.Replace("sourceLan", "." + Script_VarText04.Text);
                }
                else
                {
                    script = script.Replace("withVlan", "#");
                    script = script.Replace("sourceLan", "");
                }
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // -------------------------------------------------- MPLS --------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Config - Cisco - MPLS ----------------------------------------------------
            else if (routerType == RouterType.Cisco && activityType == ActivityType.MPLS && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                actualScript = scripts[5];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    Script_TextBox.Text = Script_TextBox.Text.Replace("withVlan", "interface " + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "encapsulation dot1Q " + Script_VarText04.Text + "\r\n" +
                    "quit\r\n");
                }
                else
                {
                    script = script.Replace("withVlan", "!");
                }
            }
            // ------------------------------------------- Config - HPE - MPLS ------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                actualScript = scripts[6];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "interface " + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n" +
                    "quit\r\n");
                }
                else
                {
                    script = script.Replace("withVlan", "#");
                }
            }
            // ------------------------------------------- Config - HPE Old - MPLS --------------------------------------------------
            else if ((routerType == RouterType.HPE_old) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                actualScript = scripts[7];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "interface " + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n");
                }
                else
                {
                    script = script.Replace("withVlan", "#");
                }
            }
            // ------------------------------------------- Config - Huawei - MPLS ---------------------------------------------------
            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                actualScript = scripts[8];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "interface " + Script_VarText04.Text + "\r\n" +
                        " description " + Script_VarText01.Text + "\r\n" +
                        " dot1q termination vid " + Script_VarText04.Text + "\r\n" +
                        " bandwidth " + Script_VarText02.Text +
                        "#\r\n");

                    script = script.Replace("telsource", "." + Script_VarText04.Text);
                    script = script.Replace("infosource", "." + Script_VarText04.Text);
                }
                else
                {
                    script = script.Replace("telsource", "");
                    script = script.Replace("infosource", "");
                    script = script.Replace("withVlan", "#");
                }
            }
            // ------------------------------------------- Config - Fortigate - MPLS ------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                actualScript = scripts[9];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "################# Configuracao VLAN na WAN  ##################### \r\n" +
                        "#\r\n" +
                        "    edit " + '"' + Script_VarText04.Text + '"' + "\r\n" +
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
                }
                else
                {
                    script = script.Replace("withVlan", "#");
                }

                script = script.Replace("var08", GetBackboneInterfaceIP(Script_VarText07.Text, false));

                // ---------------------------------------------------------

                if (Script_VarText11.Text != string.Empty)
                {
                        script = script.Replace("loopbackCliente", "################# Loopback Cliente  ##################### \r\n" +
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
                    script = script.Replace("loopbackCliente", "#\r\n");
                }
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // -------------------------------------------------- VOZ ---------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Config - Cisco - VOZ -----------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                // Sinalização
                if (Script_SinalizBox.SelectedIndex == 0 || Script_SinalizBox.SelectedIndex == 1)
                {
                    // ISR
                    if (Script_RouterModelBox.Text.Contains("ISR"))
                    {
                        actualScript = scripts[11];
                        script = ApplyScript(actualScript);

                        if (Script_SinalizBox.SelectedIndex == 0)
                        {
                            script = script.Replace("sinalizacao", "controller E1 " + Script_VarText21.Text + "\r\n isdn switch-type primary-net5\r\n line-termination 75-ohm\r\npri-group timeslots " + Script_VarText20.Text + "\r\n!\r\n!\r\ninterface Serial" + Script_VarText21.Text + ":15\r\nisdn protocol-emulate network\r\n!\r\n encapsulation hdlc\r\n isdn switch-type primary-net5\r\n isdn incoming-voice voice\r\n isdn bchan-number-order ascending\r\n!\r\n!\r\nvoice-port portVoice\r\n input gain 3\r\n output attenuation 3\r\n no echo-cancel enable\r\n no comfort-noise\r\n cptone BR\r\n translation-profile incoming EBT_BSOD\r\n!\r\n!\r\n");
                            script = script.Replace("portVoice", Script_VarText21.Text + ":0");
                        }
                        else
                        {
                            script = script.Replace("sinalizacao", "controller E1 " + Script_VarText21.Text + "\r\n framing no-crc4\r\n clock source line primary\r\n line-termination 75-ohm\r\nds0-group 0 timeslots " + Script_VarText20.Text + " type r2-digital r2-compelled ani\r\n cas-custom 0\r\n  country brazil\r\n  reanswer-time 90000\r\n!\r\n  alert-wait-time 30\r\n  disconnect-tone\r\n  answer-signal group-b 1\r\n  dnis-digits min 3 max 23\r\n  ani-digits min 4 max 8\r\n  timer interdigit outgoing 15000\r\n  trunk-group troncor2\r\n!\r\n!\r\n controller E1 \r\ncc-pattern 90 " + Script_VarText20.Text + "\r\n!\r\n!\r\nvoice-port portVoice\r\n translation-profile incoming EBT_BSOD\r\n no vad\r\n no comfort-noise\r\n cptone BR\r\n timeouts interdigit 5\r\n timeouts ringing 90\r\n timeouts wait-release 1\r\n !\r\n !");
                            script = script.Replace("portVoice", Script_VarText21.Text + ":15");
                        }
                    }
                    else // Not ISR
                    {
                        actualScript = scripts[10];
                        script = ApplyScript(actualScript);

                        if (Script_SinalizBox.SelectedIndex == 0)
                        {
                            script = script.Replace("sinalizacao", "network-clock-select 1 E1 " + Script_VarText21.Text + "\r\ntrunk group troncor2\r\n hunt-scheme sequential both down\r\n!\r\ncontroller E1 portVoice\r\n framing NO-CRC4 \r\n ds0-group 0 timeslots " + Script_VarText20.Text + " type r2-digital r2-compelled ani\r\n cas-custom 0\r\n  country brazil use-defaults\r\n  metering\r\n  category 1\r\n!\r\n  answer-signal group-b 1\r\n  trunk-group troncor2\r\n!");
                            script = script.Replace("portVoice", Script_VarText21.Text + ":1");
                        }
                        else
                        {
                            script = script.Replace("sinalizacao", "controller E1 " + Script_VarText21.Text + "\r\n clock source internal\r\n pri-group timeslots " + Script_VarText20.Text + "\r\n!\r\ninterface portVoice\r\n no ip address\r\n encapsulation hdlc\r\n no logging event link-status\r\n isdn bchan-number-order ascending\r\n!\r\n isdn switch-type primary-net5\r\n isdn overlap-receiving T302 5000\r\n isdn protocol-emulate network\r\n isdn incoming-voice voice\r\n no cdp enable\r\n!");
                            script = script.Replace("portVoice", Script_VarText21.Text + ":15");
                        }
                    }

                }
                else if (Script_SinalizBox.SelectedIndex == 2)
                {
                    actualScript = scripts[12];
                    script = ApplyScript(actualScript);
                }

                script = ApplyScriptVoz(script);

                if (Script_VarText02.Text != string.Empty)
                {
                    int t = int.Parse(Script_VarText02.Text) - 64;
                    bandaQoS = t.ToString();
                    script = script.Replace("bandaQoS", bandaQoS);
                }

                if (Script_VarText19.Text != string.Empty)
                {
                    string saidaMCDU = Script_VarText19.Text.Remove(4);
                    script = script.Replace("SaidaRegra1", Script_VarText19.Text.Replace(saidaMCDU, ""));
                    script = script.Replace("SaidaRegra2", saidaMCDU);
                }

                // Vlan na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "interface " + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "encapsulation dot1Q " + Script_VarText04.Text + "\r\n" +
                    "quit\r\n");
                }
                else
                {
                    script = script.Replace("withVlan", "!");
                }
            }
            // ------------------------------------------- Config - HPE - VOZ -----------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                try
                {
                    int t = int.Parse(Script_VarText02.Text) - 64;
                    bandaQoS = t.ToString();
                }
                catch
                {
                    if (Script_VarText02.Text != string.Empty)
                    {
                        Debug.WriteLine("Incorrect Bandwidth");
                        MessageBox.Show("Valor de Banda incorreto");
                    }
                }

                // Sinalização
                if (Script_SinalizBox.SelectedIndex == 0 || Script_SinalizBox.SelectedIndex == 1)
                {
                    actualScript = scripts[13];
                    script = ApplyScript(actualScript);

                    if (Script_SinalizBox.SelectedIndex == 0)
                    {
                        script = script.Replace("sinalizacao", "controller E1 " + Script_VarText21.Text + "\r\ntimeslot-set 1 timeslot-list Var21 signal r2\r\n tdm-clock line\r\n idle-code ff\r\n cable short\r\n#\r\ncas 1\r\n  mode brazil default-standard\r\n  re-answer enable\r\n  timer dl answer 120000\r\n  timer dl re-answer 90000\r\n  ani all\r\n  register-value billingcategory 1\r\n#\r\n#");                        
                        script = script.Replace("portaV", Script_VarText21.Text + ":1");
                        script = script.Replace("ReverseR2", "reverse-charge prefix 90");
                        
                    }
                    else if (Script_SinalizBox.SelectedIndex == 1)
                    {
                        script = script.Replace("sinalizacao", "controller E1 " + Script_VarText21.Text + "\r\npri-set timeslot-list Var21\r\n pri-set\r\n tdm-clock line primary\r\n frame-format crc4\r\n idle-code ff\r\n cable short\r\n#\r\ninterface SerialportaV\r\n isdn protocol-mode network\r\n isdn ignore connect-ack incoming\r\n#");
                        script = script.Replace("portaV", Script_VarText21.Text + ":15");
                        script = script.Replace("ReverseR2", "#");
                    }
                }
                else if (Script_SinalizBox.SelectedIndex == 2)
                {
                    actualScript = scripts[14];
                    script = ApplyScript(actualScript);
                }

                script = ApplyScriptVoz(script);

                if (Script_VarText19.Text != string.Empty)
                {
                    string regraSaida = Script_VarText19.Text;
                    int q = Script_VarText19.Text.Count(c => c == '-');

                    int p = 0;
                    string final = regraSaida;

                    if (q > 0)
                    {
                        // Remove cada digito de regra
                        for (int i = 1; i <= q; i++)
                        {
                            ++p;
                            final = final.Remove(final.Length - 5);
                        }

                        // Adiciona '.' para cada digito
                        for (int j = 1; j <= p; j++)
                        {
                            final += ".";
                        }
                    }

                    script = script.Replace("Var19", Script_VarText19.Text);
                    script = script.Replace("SaidaRegra", final);

                    string saidaMCDU = final.Remove(0, 4);
                    script = script.Replace("SaidaMCDU", saidaMCDU);
                }

                script = script.Replace("bandaQoS", bandaQoS);

                // Vlan na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "interface " + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n" +
                    "quit\r\n");
                }
                else
                {
                    script = script.Replace("vlanWan", "!\r\n");
                }
            }
            // ------------------------------------------- Config - HPE Antigo - VOZ -----------------------------------------------------
            else if ((routerType == RouterType.HPE_old) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                // Sinalização
                if (Script_SinalizBox.SelectedIndex == 0 || Script_SinalizBox.SelectedIndex == 1)
                {
                    actualScript = scripts[15];
                    script = ApplyScript(actualScript);

                    if (Script_SinalizBox.SelectedIndex == 0)
                    {
                        script = script.Replace("portVoice", Script_VarText19.Text + ":1");
                    }
                    else if (Script_SinalizBox.SelectedIndex == 1)
                    {
                        script = script.Replace("portVoice", Script_VarText19.Text + ":15");
                    }
                }
                else if (Script_SinalizBox.SelectedIndex == 2)
                {
                    actualScript = scripts[14];
                    script = ApplyScript(actualScript);
                }

                script = ApplyScriptVoz(script);

                if (Script_VarText19.Text != string.Empty)
                {
                    string regraSaida = Script_VarText19.Text;
                    int q = Script_VarText19.Text.Count(c => c == '-');

                    int p = 0;
                    string final = regraSaida;

                    if (q > 0)
                    {
                        // Remove cada digito de regra
                        for (int i = 1; i <= q; i++)
                        {
                            ++p;
                            final = final.Remove(final.Length - 5);
                        }

                        // Adiciona '.' para cada digito
                        for (int j = 1; j <= p; j++)
                        {
                            final += ".";
                        }
                    }

                    script = script.Replace("SaidaRegra", final);

                    string saidaMCDU = final.Remove(0, 4);
                    script = script.Replace("SaidaMCDU", saidaMCDU);
                }

                script = script.Replace("bandaQoS", bandaQoS);

                // Vlan na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "interface " + Script_VarText04.Text + "\r\n" +
                    "description " + Script_VarText01.Text + "\r\n" +
                    "bandwidth " + Script_VarText02.Text + "\r\n" +
                    "vlan-type dot1q vid " + Script_VarText04.Text + "\r\n" +
                    "quit\r\n");
                }
                else
                {
                    script = script.Replace("vlanWan", "!\r\n");
                }
            }
            // ------------------------------------------- Config - Aligera - VOZ -----------------------------------------------------
            else if ((routerType == RouterType.Aligera) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                Script_VarText21.Text = "port 1";

                if (Script_RouterModelBox.Text.Contains("AG 1600") || Script_RouterModelBox.Text.Contains("AG 2000"))
                {
                    actualScript = scripts[18];
                    script = ApplyScript(actualScript);
                }
                else
                {
                    actualScript = scripts[17];
                    script = ApplyScript(actualScript);
                }

                // Sinalização
                if (Script_SinalizBox.SelectedIndex == 0 || Script_SinalizBox.SelectedIndex == 1)
                {
                    if (Script_SinalizBox.SelectedIndex == 0)
                    {
                        script = script.Replace("sinalizacao", "config tdm port1 crc disable\r\nconfig tdm port1 signalling mfcr2\r\nconfig tdm port1 timeslots " + Script_VarText20.Text + "\r\nconfig tdm port1 keepalive_host " + Script_VarText07.Text + "\r\nconfig tdm port1 mfcr2 max_ani 10\r\nconfig tdm port1 mfcr2 max_dnis 20\r\nconfig tdm port1 mfcr2 get_ani_first yes\r\nconfig tdm port1 mfcr2 reanswer_timeout 90000\r\nconfig tdm mfcr2_tone_amp 150\r\n!");
                    }
                    else if (Script_SinalizBox.SelectedIndex == 1)
                    {
                        script = script.Replace("sinalizacao", "config tdm port1 crc enable\r\nconfig tdm port1 clock 0\r\nconfig tdm port1 signalling isdn_net\r\nconfig tdm port1 timeslots " + Script_VarText20.Text + "\r\nconfig tdm port1 keepalive_host " + Script_VarText07.Text + "\r\nconfig tdm port1 isdn switchtype euroisdn\r\nconfig tdm port1 isdn overlapdial no\r\n!");
                    }

                }
                else if (Script_SinalizBox.SelectedIndex == 2)
                {
                    MessageBox.Show("Não configuramos PABX IP em CPEs Aligera");
                }

                script = ApplyScriptVoz(script);

                if (Script_VarText19.Text != string.Empty)
                {
                    script = script.Replace("regraMCDU", Script_VarText19.Text.Remove(0, 4));
                    script = script.Replace("regra4Digitos", Script_VarText19.Text.Remove(4));
                }
            }
            // ------------------------------------------- Config - Digistar - VOZ -----------------------------------------------------
            else if ((routerType == RouterType.Digistar) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Config)
            {
                actualScript = scripts[16];
                script = ApplyScript(actualScript);

                // Sinalização
                if (Script_SinalizBox.SelectedIndex == 0 || Script_SinalizBox.SelectedIndex == 1)
                {
                    if (Script_SinalizBox.SelectedIndex == 0)
                    {
                        script = script.Replace("sinalizacao", "pbx\r\ndigital-line\r\nclock-mode master\r\ntrunk-mode r2\r\nno crc-4\r\ndigits 4\r\nenable idc\r\nenable ccb\r\ndigit-timeout 4\r\nmfc-absent-time 20\r\nchannels quantCanais");
                    }
                    else if (Script_SinalizBox.SelectedIndex == 1)
                    {
                        script = script.Replace("sinalizacao", "pbx \r\ndigital-line \r\nclock-mode master \r\ntrunk-mode isdn \r\ncrc-4 \r\ndialling-mode enblock\r\nforward presentation-indicator \r\ndigits 4 \r\nenable idc \r\nenable ccb \r\ndigit-timeout 4 \r\nmfc-absent-time 20 \r\nchannels quantCanais");
                    }
                }
                else if (Script_SinalizBox.SelectedIndex == 2)
                {
                    MessageBox.Show("Não configuramos PABX IP em CPEs Digistar");
                }

                script = ApplyScriptVoz(script);

                // Vlan na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "interface ethernet 1\r\nmulticast\r\n!\r\ninterface ethernet 1.Var04\r\ndescription Var01\r\nbandwidth Var02k\r\nno shutdown\r\n!");
                }
                else
                {
                    script = script.Replace("vlanWan", "!\r\n");
                }

                // Account Rules Loop
                if (Script_VarText19.Text != string.Empty)
                {
                    if (Script_VarText19.TextLength > 8)
                    {
                        string RegraAccounts = string.Empty;

                        // ---------------------------------------------------------------
                        // Get Number of Units used inside New Rule
                        int numeroUnid = Script_VarText19.Text.Count(c => c == '[');

                        // Check if Rule is Valid
                        if (numeroUnid == 0 || Script_VarText19.Text.Count(c => c == ']') == 0 || Script_VarText19.Text.Count(c => c == '-') == 0)
                        {
                            MessageBox.Show("Regra inválida. Verifique o campo Regras de Ramal e tente novamente.");
                            return "";
                        }

                        // Get new Rule
                        string novaRegra = Script_VarText19.Text;

                        // Remove "[ - ]" 
                        string regraInicial = novaRegra.Remove(novaRegra.Length - (5 * numeroUnid));
                        string regraFinal = regraInicial;

                        string teste = novaRegra;

                        // For each Unit... Set First and Final possible numbers
                        for (int j = 0; j < numeroUnid; j++)
                        {
                            // Get '[' position number
                            int position = teste.IndexOf('[');

                            // Remove characters before '['
                            teste = teste.Remove(0, position + 1);

                            // Set New Rule first and final possible numbers
                            regraInicial += teste[0];
                            regraFinal += teste[2];
                        }

                        // Get New Rule Total Length
                        int totalLength = int.Parse(regraFinal) - int.Parse(regraInicial);

                        int number = 0;

                        // Loop for every possible number
                        // ------------------------------------------
                        for (int i = 1; i <= totalLength + 1; i++)
                        {
                            // Get Rule Number and the number of Rule
                            int regra = int.Parse(regraInicial) + (i - 1);
                            int accNumber = number + i;

                            // Config String
                            string account = "sip\r\n    account NumRegra0\r\n    user VarNovaRegra\r\n    no auth-user\r\n    no display-name\r\n    no contact\r\n    no restricted-id\r\n    allow - simult\r\n    server 1\r\n    !\r\n!\r\n";

                            // Replace Variables
                            account = account.Replace("NumRegra0", accNumber.ToString());
                            account = account.Replace("VarNovaRegra", regra.ToString());

                            // Add new Account to string
                            RegraAccounts += account;
                        }

                        // Add Accounts to Final String
                        // ------------------------------------------
                        script = script.Replace("RegraAccounts", RegraAccounts);
                    }
                    else if (Script_VarText19.TextLength == 8)
                    {
                        if (Script_VarText19.Text.All(char.IsDigit))
                        {
                            script = script.Replace("RegraAccounts", "sip\r\n account 1\r\n    user " + Script_VarText19.Text + "\r\n    no auth-user\r\n    no display-name\r\n    no contact\r\n    no restricted-id\r\n    allow - simult\r\n    server 1\r\n    !\r\n!\r\n");
                        }
                        else
                        {
                            MessageBox.Show("Regra inválida. Verifique o campo Regras de Ramal e tente novamente.");
                            return "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Regra inválida. Verifique o campo Regras de Ramal e tente novamente.");
                    }
                }
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------------- LOGS ---------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Logs - Cisco - BLD -------------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[19];
                script = ApplyScript(actualScript);

                // Extra Options
                // LAN
                if (Script_VarText05.Text != string.Empty)
                {
                    script = script.Replace("sourceLan", "source " + Script_VarText05.Text);
                    script = script.Replace("intLan", "!######################## \r\n" +
                        "!\r\n" +
                        "show interface " + Script_VarText05.Text + "\r\n" +
                        "!\r\n" +
                        "!\r\n");
                }
                else
                {
                    script = script.Replace("sourceLan", "");
                    script = script.Replace("intLan", "!\r\n");
                }
                // VLAN na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("vlanWan", "!######################## \r\n" +
                        "!\r\n" +
                        "show interface " + Script_VarText04.Text + "\r\n" +
                        "!\r\n" +
                        "!\r\n");
                }
                else
                {
                    script = script.Replace("vlanWan", "!\r\n");
                }
                // VLan na LAN
                if (Script_VarText06.Text != string.Empty)
                {
                    script = script.Replace("vlanLan", "!######################## \r\n" +
                        "!\r\n" +
                        "show interface " + Script_VarText06.Text + "\r\n" +
                        "!\r\n" +
                        "!\r\n");
                }
                else
                {
                    script = script.Replace("vlanLan", "!\r\n");
                }
                // ISR - Extended Data
                if (Script_RouterModelBox.Text.Contains("ISR"))
                {
                    script = script.Replace("isr", "extended-");
                }
                else
                {
                    script = script.Replace("isr", "");
                }
            }
            // ------------------------------------------- Logs - HPE - BLD ---------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[20];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText09.Text != string.Empty)
                {
                    script = script.Replace("sourceLan", " -a " + Script_VarText09.Text);
                }
                else
                {
                    script = script.Replace("sourceLan", "");
                }
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("vlanWan", "######################### \r\n" +
                        "#\r\n" +
                        "display interface " + Script_VarText04.Text + "\r\n" +
                        "#\r\n" +
                        "#\r\n");
                }
                else
                {
                    script = script.Replace("vlanWan", "#\r\n");
                }
                if (Script_VarText05.Text != string.Empty)
                {
                    script = script.Replace("intLan", "######################### \r\n" +
                        "#\r\n" +
                        "display interface " + Script_VarText05.Text + "\r\n" +
                        "#\r\n" +
                        "#\r\n");
                }
                else
                {
                    script = script.Replace("intLan", "#\r\n");
                }
                if (Script_VarText06.Text != string.Empty)
                {
                    script = script.Replace("vlanLan", "######################### \r\n" +
                        "#\r\n" +
                        "display interface " + Script_VarText06.Text + "\r\n" +
                        "#\r\n" +
                        "#\r\n");
                }
                else
                {
                    script = script.Replace("vlanLan", "#\r\n");
                }

            }
            // ------------------------------------------- Log - Huawei - BLD -------------------------------------------------------
            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[22];
                script = ApplyScript(actualScript);

                // Extra Options
                // Vlan na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "display interface " + Script_VarText04.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n");
                    script = script.Replace("outVlan", Script_VarText04.Text);
                }
                else
                {
                    script = script.Replace("withVlan", "");
                    script = script.Replace("outVlan", Script_VarText03.Text);
                }
                // Porta LAN
                if (Script_VarText05.Text != string.Empty)
                {
                    script = script.Replace("withLan", "display interface " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n");
                }
                else
                {
                    script = script.Replace("withLan", "#\r\n");
                }
                // VLAN na LAN
                if (Script_VarText06.Text != string.Empty)
                {
                    script = script.Replace("lanWithVlan", "display interface " + Script_VarText06.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n");
                }
                else
                {
                    script = script.Replace("lanWithVlan", "#\r\n");
                }
                // Source LAN
                if (Script_VarText09.Text != string.Empty)
                {
                    script = script.Replace("sourceLan", "-a " + Script_VarText09.Text + " ");
                }
                else
                {
                    script = script.Replace("sourceLan", "");
                }
            }
            // ------------------------------------------- Log - Fortigate - BLD ----------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.BLD) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[21];
                script = ApplyScript(actualScript);

                // Interface LAN
                if (Script_VarText05.Text != string.Empty)
                {
                    script = script.Replace("nicLan", "get hardware nic " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n");
                }
                else
                {
                    script = script.Replace("nicLan", "#\r\n");
                }

                // Source LAN
                if (Script_VarText09.Text != string.Empty)
                {
                    script = script.Replace("sourceLan", "execute ping-options source " + Script_VarText09.Text + "\r\n");
                }
                else
                {
                    script = script.Replace("sourceLan", "");
                }
            }


            // ----------------------------------------------------------------------------------------------------------------------
            // ---------------------------------------------- MPLS -------------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log - Cisco - MPLS -------------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[23];
                script = ApplyScript(actualScript);

                // Extra Options
                // Vlan na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "!########################\r\n" +
                        "show interface " + Script_VarText04.Text + "\r\n" +
                        "!\r\n" +
                        "!\r\n" +
                        "!");
                }
                else
                {
                    script = script.Replace("withVlan", "!");
                }

                // Interface LAN
                if (Script_VarText05.Text != string.Empty)
                {
                    script = script.Replace("sourceLan", "source " + Script_VarText05.Text);
                    script = script.Replace("withLan", "!########################\r\n" +
                        "show interface " + Script_VarText05.Text + "\r\n" +
                        "!\r\n" +
                        "!\r\n" +
                        "!");
                }
                else
                {
                    script = script.Replace("sourceLan", "");
                    script = script.Replace("withLan", "!");
                }

                // Vlan na LAN
                if (Script_VarText06.Text != string.Empty)
                {
                    script = script.Replace("LanWithVlan", "!########################\r\n" +
                        "show interface " + Script_VarText06.Text + "\r\n" +
                        "!\r\n" +
                        "!\r\n" +
                        "!");
                }
                else
                {
                    script = script.Replace("LanWithVlan", "!");
                }
                // ISR - Extended Data
                if (Script_RouterModelBox.Text.Contains("ISR"))
                {
                    script = script.Replace("isr", "extended-");
                }
                else
                {
                    script = script.Replace("isr", "");
                }
            }
            // ------------------------------------------- Log - HPE - MPLS ---------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[24];
                script = ApplyScript(actualScript);

                // Extra Options
                if (Script_VarText09.Text != string.Empty)
                {
                    script = script.Replace("sourceLan", " -a " + Script_VarText09.Text + " ");
                }
                else
                {
                    script = script.Replace("sourceLan", "");
                }
                // Vlan na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "#########################\r\n" +
                        "display interface " + Script_VarText04.Text + "\r\n" +
                        "#\r\n" +
                        "#\r\n" +
                        "#");
                }
                else
                {
                    script = script.Replace("withVlan", "");
                }

                // Interface LAN
                if (Script_VarText05.Text != string.Empty)
                {
                    script = script.Replace("withLan", "#########################\r\n" +
                        "display interface " + Script_VarText05.Text + "\r\n" +
                        "#\r\n" +
                        "#\r\n" +
                        "#");
                }
                else
                {
                    script = script.Replace("withLan", "#");
                }

                // Vlan na LAN
                if (Script_VarText06.Text != string.Empty)
                {
                    script = script.Replace("LanWithVlan", "#########################\r\n" +
                        "display interface " + Script_VarText06.Text + "\r\n" +
                        "#\r\n" +
                        "#\r\n" +
                        "#");
                }
                else
                {
                    script = script.Replace("LanWithVlan", "#");
                }
            }
            // ------------------------------------------- Log - Huawei - MPLS ------------------------------------------------------
            else if ((routerType == RouterType.Huawei) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[26];
                script = ApplyScript(actualScript);

                // Extra Options
                // Vlan na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "display interface " + Script_VarText04.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n");
                    script = script.Replace("outVlan", Script_VarText04.Text);
                }
                else
                {
                    script = script.Replace("withVlan", "");
                    script = script.Replace("outVlan", Script_VarText03.Text);
                }
                // Porta LAN
                if (Script_VarText05.Text != string.Empty)
                {
                    script = script.Replace("withLan", "display interface " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n");
                }
                else
                {
                    script = script.Replace("withLan", "#\r\n");
                }
                // VLAN na LAN
                if (Script_VarText06.Text != string.Empty)
                {
                    script = script.Replace("lanWithVlan", "display interface " + Script_VarText06.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n");
                }
                else
                {
                    script = script.Replace("lanWithVlan", "#\r\n");
                }
                // Source LAN
                if (Script_VarText09.Text != string.Empty)
                {
                    script = script.Replace("sourceLan", "-a " + Script_VarText09.Text + " ");
                }
                else
                {
                    script = script.Replace("sourceLan", "");
                }
            }
            // ------------------------------------------- Log - Fortigate - MPLS ---------------------------------------------------
            else if ((routerType == RouterType.Fortigate) && (activityType == ActivityType.MPLS) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[25];
                script = ApplyScript(actualScript);

                // Extra Options

                // Interface LAN
                if (Script_VarText05.Text != string.Empty)
                {
                    script = script.Replace("nicLan", "get hardware nic " + Script_VarText05.Text + "\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n");
                }
                else
                {
                    script = script.Replace("nicLan", "#\r\n");
                }

                // Source LAN
                if (Script_VarText09.Text != "")
                {
                    script = script.Replace("sourceLan", "execute ping-options source " + Script_VarText09.Text + "\r\n");
                }
                else
                {
                    script = script.Replace("sourceLan", "#\r\n");
                }

            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ---------------------------------------------- VOZ -------------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log - Cisco - VOZ --------------------------------------------------------
            else if ((routerType == RouterType.Cisco) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[27];
                script = ApplyScript(actualScript);

                // Vlan na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "!######################## \r\n" +
                        "!\r\n" +
                        "show interface " + Script_VarText04.Text + "\r\n" +
                        "!\r\n" +
                        "!\r\n" +
                        "!");
                }
                else
                {
                    script = script.Replace("withVlan", "!");
                }

                // Sinalização
                if (Script_VarText05.Text != string.Empty)
                {
                    script = script.Replace("pabxip", "!######################## \r\n" +
                        "!\r\n" +
                        "show interface " + Script_VarText05.Text + "\r\n" +
                        "!\r\n" +
                        "!\r\n" +
                        "!");
                    script = script.Replace("sinalizacao", "!");
                    script = script.Replace("sourceLan", "source " + Script_VarText05.Text);
                }
                else
                {
                    script = script.Replace("pabxip", "!");
                    string sinalizacao = "!#######################################\r\n!#             STATUS E1               #\r\n!#######################################\r\n!\r\nshow controller e1\r\n!\r\n!\r\n!";
                    script = script.Replace("sinalizacao", sinalizacao);
                    script = script.Replace("sourceLan", "");
                }

                // ISR - Extended Data
                if (Script_RouterModelBox.Text.Contains("ISR"))
                {
                    script = script.Replace("isr", "extended-");
                }
                else
                {
                    script = script.Replace("isr", "");
                }

            }
            // ------------------------------------------- Log - HPE - VOZ ----------------------------------------------------------
            else if ((routerType == RouterType.HPE) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[28];
                script = ApplyScript(actualScript);

                // Vlan na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "######################### \r\n" +
                        "#\r\n" +
                        "display interface " + Script_VarText04.Text + "\r\n" +
                        "#\r\n" +
                        "#\r\n" +
                        "#");
                }
                else
                {
                    script = script.Replace("withVlan", "#");
                }

                // Sinalização
                if (Script_VarText05.Text != string.Empty)
                {
                    script = script.Replace("pabxip", "######################### \r\n" +
                        "#\r\n" +
                        "display interface " + Script_VarText05.Text + "\r\n" +
                        "#\r\n" +
                        "#\r\n" +
                        "#");
                    script = script.Replace("sourceLan", "-a " + Script_VarText09.Text + " ");
                    script = script.Replace("sinalizacao", "#");
                }
                else
                {
                    script = script.Replace("pabxip", "#");
                    string sinalizacao = "########################################\r\n#              STATUS E1               #\r\n########################################\r\n#\r\ndisplay controller e1\r\n#\r\n#\r\n#";
                    script = script.Replace("sinalizacao", sinalizacao);
                    script = script.Replace("sourceLan", "");
                }

            }
            // ------------------------------------------- Log CPE Aligera ----------------------------------------------------------
            else if ((routerType == RouterType.Aligera) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[29];
                script = ApplyScript(actualScript);
            }
            // ------------------------------------------- Log CPE Digistar ----------------------------------------------------------
            else if ((routerType == RouterType.Digistar) && (activityType == ActivityType.VOZ) && backboneOrNot == false && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[30];
                script = ApplyScript(actualScript);

                // Vlan na WAN
                if (Script_VarText04.Text != string.Empty)
                {
                    script = script.Replace("withVlan", "!######################## \r\n" +
                        "!\r\n" +
                        "show interface " + Script_VarText04.Text + "\r\n" +
                        "!\r\n" +
                        "!\r\n" +
                        "!\r\n");
                }
                else
                {
                    script = script.Replace("withVlan", "!\r\n");
                }
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log Backbone - Cisco -----------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Cisco) && (activityType == ActivityType.BLD) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[31];
                script = ApplyScript(actualScript);
                Debug.WriteLine("Script Backbone Cisco BLD");
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Cisco) && (activityType == ActivityType.MPLS) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[32];
                script = ApplyScript(actualScript);
                Debug.WriteLine("Script Backbone Cisco MPLS");

                // Extra Options
                if (isXR == true)
                {
                    script = script.Replace("xf", " | inc rd|redis|import|export|route-targ");
                    script = script.Replace("xr", " vpnv4");
                    script = script.Replace("xv", "");
                }
                else
                {
                    script = script.Replace("xf", "");
                    script = script.Replace("xr", "");
                    script = script.Replace("xv", "show running-config router bgp 4230 vrf " + Script_VarText14.Text + " neighbor " + Script_VarText08.Text + "\r\n" +
                         "!\r\n" +
                         "!\r\n" +
                         "!################################## \r\n" +
                         "!\r\n");
                }
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Cisco) && (activityType == ActivityType.VOZ) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[33];
                script = ApplyScript(actualScript);
                Debug.WriteLine("Script Backbone Cisco VOZ");
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Cisco) && (activityType == ActivityType.BLDcomBGP) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[34];
                script = ApplyScript(actualScript);
                Debug.WriteLine("Script Backbone Cisco BLD com BGP");
            }

            // ----------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log Backbone Nokia -------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Nokia) && (activityType == ActivityType.BLD) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[35];
                script = ApplyScript(actualScript);
                Debug.WriteLine("Script Backbone Nokia BLD");
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Nokia) && (activityType == ActivityType.MPLS) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[36];
                script = ApplyScript(actualScript);
                Debug.WriteLine("Script Backbone Nokia MPLS");

                // Extra Options
                if (Script_VarText14.Text.Contains(':'))
                {
                    string vrfAS;
                    string[] splitStr = Script_VarText14.Text.Split(new char[] { ':' });
                    vrfAS = splitStr[1];
                    script = script.Replace("vrfAS", vrfAS);
                }

            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Nokia) && (activityType == ActivityType.VOZ) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[37];
                script = ApplyScript(actualScript);
                Debug.WriteLine("Script Backbone Cisco VOZ");
            }
            // ----------------------------------------------------------------------------------------------------------------------
            else if ((backboneType == RouterType.Nokia) && (activityType == ActivityType.BLDcomBGP) && backboneOrNot == true && procedureType == ProcedureType.Logs)
            {
                actualScript = scripts[38];
                script = ApplyScript(actualScript);
                Debug.WriteLine("Script Backbone Cisco BLD com BGP");

                // Extra Options
                if (Script_VarRouteI1.Text != string.Empty)
                {
                    script = script.Replace("VarRouteI1", Script_VarRouteI1.Text);
                }
                else
                {
                    script = script.Replace("VarRouteI1", "");
                }
                if (Script_VarRouteI2.Text != string.Empty)
                {
                    script = script.Replace("VarRouteI2", Script_VarRouteI2.Text);
                }
                else
                {
                    script = script.Replace("VarRouteI2", "");
                }
                if (Script_VarRouteE1.Text != string.Empty)
                {
                    script = script.Replace("VarRouteE1", Script_VarRouteE1.Text);
                }
                else
                {
                    script = script.Replace("VarRouteE1", "");
                }
                if (Script_VarRouteE2.Text != string.Empty)
                {
                    script = script.Replace("policyExport2", "show router policy " + Script_VarRouteE2.Text + "\r\n" + "\r\n");
                }
                else
                {
                    script = script.Replace("policyExport2", "\r\n");
                }

            }

            // ----------------------------------------------------------------------------------------------------------------------
            // --------------------------------------------------- ERROR ------------------------------------------------------------
            // ----------------------------------------------------------------------------------------------------------------------
            else
            {
                Script_TextBox.Text = "";
                Debug.WriteLine("\r\n-->Script não Encontrado\r\n\r\nRouterType: " + routerType + ", ActivityType: " + activityType + ", ProcedureType: " + procedureType + ", Backbone" + backboneOrNot);
                MessageBox.Show("Erro: Script não Encontrado");
            }

            // Debug
            if (trueScript)
            {
                script = actualScript.scriptString;
            }

            return script;
        }
        #endregion

        // ---------------------------
        // Apply Script to TextBox
        // ---------------------------
        #region
        private string ApplyScript(Script script)
        {
            string final = "";

            // MessageBox.Show("Applied Script: " + script.name + " - Id: " + script.id);
            final = script.scriptString;
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
                            final = final.Replace("mascaraLAN", mascaraStr);
                        }
                        if (variable == "03" && backboneOrNot)
                        {
                            final = final.Replace("var03", Script_VarText03b.Text);
                        }
                        else
                        {
                            final = final.Replace("var" + variable, box.Text);
                        }
                    }
                }
            }

            final = final.Replace("switchType", Script_SwitchLabel.Text);
            final = final.Replace("logType", logType);

            return final;
        }

        public string ApplyScriptVoz(string script)
        {
            script = script.Replace("Var16", Script_VarText16.Text);
            // Check if Trunk if correct
            if (Script_VarText17.Text != string.Empty)
            {
                if (Script_VarText17.Text.All(char.IsDigit) && Script_VarText17.TextLength == 8)
                {
                    script = script.Replace("Var17", Script_VarText17.Text);
                }
                else
                {
                    MessageBox.Show("Tronco-Chave inválido. Verifique e tente novamente.");
                    return script;
                }
            }
            script = script.Replace("Var18", Script_VarText18.Text);
            script = script.Replace("Var19", Script_VarText19.Text);
            script = script.Replace("Var20", Script_VarText20.Text);
            script = script.Replace("Var21", Script_VarText21.Text);

            return script;
        }
        #endregion

        // ---------------------------
        // UI Organizer
        // ---------------------------
        #region
        public void ScriptUIOrganizer(string numberOfVar)
        {
            Debug.WriteLine("\r\n--> Script UI Organizer applied");

            if (numberOfVar != null)
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
                                varName[i].Location = new System.Drawing.Point(varName[i].Location.X, 75);
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
                                varText[i].Location = new System.Drawing.Point(varText[i].Location.X, 75);
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
                                varDelete[i].Location = new System.Drawing.Point(varDelete[i].Location.X, 75);
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
                                varEx[i].Location = new System.Drawing.Point(varEx[i].Location.X, 80);
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
                if (procedureType == ProcedureType.Config || ActivityType.VOZ == activityType)
                {
                    Script_Hint1.Hide();
                    Script_VarSubTab.Show();
                    Script_VarSubTab.Location = new System.Drawing.Point(3, varEx[anterior].Location.Y + 20);
                    Script_VarSubTab.Size = new System.Drawing.Size(400, 234);
                }
                else
                {
                    if (routerType != RouterType.Nokia && activityType != ActivityType.BLDcomBGP)
                    {
                        Script_Hint1.Show();
                        Script_Hint1.Location = new System.Drawing.Point(54, varEx[anterior].Location.Y + 40);
                        Script_VarSubTab.Size = new System.Drawing.Size(400, 10);
                        Script_VarSubTab.Hide();
                        
                    }
                }
            }
        }
        #endregion

        // ---------------------------
        // Close/Show Extra Variables
        // ---------------------------
        #region
        public void ExtraVariablesControl(bool FortigateModel, bool ciscoXR, bool Limpeza, bool parte2, bool configTypeBox)
        {
            if (FortigateModel)
            {
                Script_RouterModelBox.Show();
                Script_ModelLabel.Show();
            }
            else
            {
                Script_RouterModelBox.Hide();
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
            if (Limpeza)
            {
                Script_Button_Limpeza.Show();
            }
            else
            {
                Script_Button_Limpeza.Hide();
            }
            if (parte2)
            {
                Script_Button_Parte2.Show();
            }
            else
            {
                Script_Button_Parte2.Hide();
            }
            if (configTypeBox)
            {
                Script_LogBox_Label.Show();
                Script_LogBox.Show();
                Script_Button_SwitchLabel.Hide();
                Script_SwitchLabel.Hide();
            }
            else
            {
                Script_LogBox_Label.Hide();
                Script_LogBox.Hide();
                Script_Button_SwitchLabel.Show();
                Script_SwitchLabel.Show();
            }
        }
        #endregion

        // ---------------------------
        // Auxiliary Functions
        // ---------------------------
        #region
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

        public string ChangeMascaraLAN(ComboBox LanBox)
        {
            string mascara = "";

            if (LanBox.SelectedIndex == 0)
            {
                mascara = "255.255.255.252";
            }
            if (LanBox.SelectedIndex == 1)
            {
                mascara = "255.255.255.248";
            }
            if (LanBox.SelectedIndex == 2)
            {
                mascara = "255.255.255.240";
            }
            if (LanBox.SelectedIndex == 3)
            {
                mascara = "255.255.255.224";
            }
            if (LanBox.SelectedIndex == 4)
            {
                mascara = "255.255.255.192";
            }
            if (LanBox.SelectedIndex == 5)
            {
                mascara = "255.255.255.128";
            }
            if (LanBox.SelectedIndex == 6)
            {
                mascara = "255.255.255.0";
            }

            return mascara;
        }

        public void GetRouterModel(string model)
        {
            if (model == "40F")
            {
                Script_VarText03.Text = "wan";
                Script_VarText05.Text = "lan1";
            }
            if (model == "60F")
            {
                Script_VarText03.Text = "wan1";
                Script_VarText05.Text = "internal1";
            }
            if (model == "100F")
            {
                Script_VarText03.Text = "x1";
                Script_VarText05.Text = "port1";
            }
            if (model == "Cisco Catalyst")
            {
                Script_VarText03.Text = "GigabitEthernet4";
                Script_VarText05.Text = "GigabitEthernet5";
            }
            if (model == "Cisco ISR")
            {
                Script_VarText03.Text = "GigabitEthernet0/0/0";
                Script_VarText05.Text = "GigabitEthernet0/0/1";
            }
            if (model == "c841")
            {
                Script_VarText03.Text = "GigabitEthernet0/4";
                Script_VarText05.Text = "GigabitEthernet0/5";
            }
            if (model == "c921")
            {
                Script_VarText03.Text = "GigabitEthernet4";
                Script_VarText05.Text = "GigabitEthernet5";
            }
            if (model == "1905")
            {
                Script_VarText03.Text = "GigabitEthernet0/0";
                Script_VarText05.Text = "GigabitEthernet0/1";
            }
            if (model == "1841")
            {
                Script_VarText03.Text = "FastEthernet0/0";
                Script_VarText05.Text = "FastEthernet0/1";
            }
            if (model == "HPE")
            {
                Script_VarText03.Text = "GigabitEthernet0/0";
                Script_VarText05.Text = "GigabitEthernet0/1";
            }
            if (model == "Huawei")
            {
                Script_VarText03.Text = "GigabitEthernet0/9";
                Script_VarText05.Text = "GigabitEthernet0/10";
            }
        }

        public void ChangeChannelNumber()
        {
            if (Script_VarText02.Text != string.Empty)
            {
                try
                {
                    int banda = int.Parse(Script_VarText02.Text);
                    if (banda >= 1500)
                    {
                        if (Script_SinalizBox.SelectedIndex == 0)
                        {
                            Script_VarText20.Text = "1-15,17-31";
                        }
                        else if (Script_SinalizBox.SelectedIndex == 1)
                        {
                            Script_VarText20.Text = "1-31";
                        }
                    }
                    if (banda == 1200)
                    {
                        if (Script_SinalizBox.SelectedIndex == 0)
                        {
                            Script_VarText20.Text = "1-15,17-26";
                        }
                        else if (Script_SinalizBox.SelectedIndex == 1)
                        {
                            Script_VarText20.Text = "1-26";
                        }
                    }
                    if (banda == 1000)
                    {
                        if (Script_SinalizBox.SelectedIndex == 0)
                        {
                            Script_VarText20.Text = "1-15,17-21";
                        }
                        else if (Script_SinalizBox.SelectedIndex == 1)
                        {
                            Script_VarText20.Text = "1-21";
                        }
                    }
                    if (banda == 800)
                    {
                        Script_VarText20.Text = "1-15";
                    }
                    if (banda == 500)
                    {
                        Script_VarText20.Text = "1-10";
                    }
                }
                catch
                {
                    MessageBox.Show("Bandwidth precisa ser um Número");
                }
            }
        }

        public void ChangeWANTextBox()
        {
            Script_VarText03b.Location = Script_VarText03.Location;

            if (routerType != RouterType.Aligera)
            {
                if (backboneOrNot)
                {
                    Script_VarText03b.Show();
                    Script_DeleteVar03b.Show();
                    Script_VarText03.Hide();
                    Script_DeleteVar03.Hide();
                    Script_DeleteVar03b.Location = Script_DeleteVar03.Location;
                }
                else
                {
                    Script_VarText03b.Hide();
                    Script_DeleteVar03b.Hide();
                    Script_VarText03.Show();
                    Script_DeleteVar03.Show();
                }
            }
            else
            {
                Script_VarText03b.Hide();
                Script_DeleteVar03b.Hide();
                Script_VarText03.Hide();
                Script_DeleteVar03.Hide();
            }
        }

        public void ChangeLANIPTextBoxSize()
        {
            if (procedureType == ProcedureType.Config && activityType != ActivityType.VOZ)
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
            if (Script_RouterModelBox.SelectedIndex == 0)
            {
                Script_VarText03.Text = "wan";
                Script_VarText05.Text = "lan1";
            }
            if (Script_RouterModelBox.SelectedIndex == 1)
            {
                Script_VarText03.Text = "wan1";
                Script_VarText05.Text = "internal1";
            }
            if (Script_RouterModelBox.SelectedIndex == 2)
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
            ImportSAIP(Clipboard.GetText());
        }

        public void ImportSAIP(string importStr)
        {
            Debug.WriteLine("\r\n--> Import SAIP applied");

            ClearAllVar();

            bool banda = true;
            bool porta = true;

            string actual = "";
            int i = 0;

  
            importStr = importStr.Replace("DADOS CLIENTE", ";");
            string[] limpeza = importStr.Split(';');
            // ------------------------------------------------
            try
            {
                string var;
                string[] split = limpeza[1].Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                // ------------------------------------------------
                // Import BLD
                // ------------------------------------------------
                #region
                if (split[1].Contains("Business Link Direct"))
                {
                    Debug.WriteLine("\r\n--> Produto do tipo BLD encontrado...");
                    MessageBox.Show("Import BLD OK");

                    foreach (string s in split)
                    {
                        i = ++i;
                        actual = (i + " - " + s);

                        if (s.Contains("PE:"))
                        {
                            SetPE(s);
                        }

                        if (s.Contains("Domínio"))
                        {
                            // Hostname
                            var = s.Replace("Domínio", string.Empty).Trim();
                            Script_VarText00.Text = DoHostname(var) + "_BLD";
                        }
                        else if (s.Contains("Description Roteador"))
                        {
                            // Description 
                            Script_VarText01.Text = s.Replace("Description Roteador", string.Empty).Trim();
                        }
                        else if (s.Contains("Serial Usuário (IPv4"))
                        {
                            // IPs da WAN
                            var = s.Replace("IP Serial Usuário (IPv4)", string.Empty).Trim();
                            string[] ipPE = var.Split('/');
                            Script_VarText07.Text = GetBackboneInterfaceIP(ipPE[0], true);                           // IP da Porta
                            Script_VarText08.Text = RemoveZero(ipPE[0]);                                             // IP da Porta + 1 (bloco /30)
                        }
                        else if (s.Contains("Blocos IPv4"))
                        {
                            // IP de LAN
                            var = s.Replace("Blocos IPv4", string.Empty).Trim();
                            string[] ipLan = var.Split('/');
                            Script_VarText09.Text = GetBackboneInterfaceIP(ipLan[0], false);
                            MascaraLAN('/' + ipLan[1]);
                        }
                        if (banda)
                        {
                            if (!s.Contains("IP Banda Larga"))
                            {
                                if (s.Contains("Banda"))
                                {
                                    // Bandwidth
                                    Script_VarText02.Text = s.Replace("Banda", string.Empty).Trim();
                                    banda = false;
                                }
                            }
                        }
                        if (porta)
                        {
                            if (s.Contains("Porta"))
                            {
                                // Porta da WAN
                                var = s.Replace("Porta", string.Empty).Trim();
                                
                                Script_VarText03b.Text = GigaOrTenGiga(var);
                                porta = false;
                            }
                        }
                    }
                }
                #endregion
                // ------------------------------------------------
                // Import MPLS
                // ------------------------------------------------
                #region
                else if (split[1].Contains("VPN"))
                {
                    Debug.WriteLine("\r\n--> Produto do tipo MPLS encontrado...");
                    MessageBox.Show("Import MPLS OK");

                    bool qos = false;

                    foreach (string s in split)
                    {
                        i = ++i;
                        actual = (i + " - " + s);

                        if (s.Contains("PE:"))
                        {
                            SetPE(s);
                        }

                        if (s.Contains("Description Roteador"))
                        {
                            // Hostname / Description
                            var = s.Replace("Description Roteador", string.Empty);
                            string[] hostname = var.Split('|');
                            Script_VarText00.Text = DoHostname(hostname[0]);
                            Script_VarText01.Text = var.Trim();
                        }
                        if (banda)
                        {
                            if (s.Contains("Banda"))
                            {
                                // Bandwidth
                                Script_VarText02.Text = s.Replace("Banda", string.Empty).Trim();
                                banda = false;
                            }
                        }
                        if (porta)
                        {
                            if (s.Contains("Porta"))
                            {
                                // Porta da WAN
                                var = s.Replace("Porta", string.Empty).Trim();
                                Script_VarText03b.Text = GigaOrTenGiga(var);
                                porta = false;
                            }
                        }
                        if (s.Contains("IP Serial Usuário (IPv4)"))
                        {
                            // IPs do PE
                            var = s.Replace("IP Serial Usuário (IPv4)", string.Empty).Trim();
                            string[] ipPE = var.Split('/');
                            Script_VarText07.Text = GetBackboneInterfaceIP(ipPE[0], true);                // IP da Porta
                            Script_VarText08.Text = RemoveZero(ipPE[0]);                                  // IP da Porta + 1 (bloco /30)
                        }
                        if (s.Contains("Blocos IPv4"))
                        {
                            // IP de LAN
                            var = s.Replace("Blocos IPv4", string.Empty).Trim();
                            string[] ipLan = var.Split('/');
                            Script_VarText09.Text = GetBackboneInterfaceIP(ipLan[0], false);
                            MascaraLAN(ipLan[1]);
                        }
                        if (s.Contains("Vrf"))
                        {
                            // VRF Name
                            Script_VarText14.Text = s.Replace("Vrf", string.Empty).Trim();
                        }
                        if (s.Contains("SERVICE_ID"))
                        {
                            // VRF Service ID
                            Script_VarText15.Text = s.Replace("SERVICE_ID", string.Empty).Trim();
                        }
                        // ------------------------------------------
                        // QoS

                        if (s.Contains("Dados de QoS\t: CANAIS"))
                        {
                            MessageBox.Show("Possui QoS - Importando");
                            qos = true;
                        }
                        if (qos)
                        {
                            if (s.Contains("VOZ"))
                            {
                                Outros_QoS_VarText01.Text = s.Replace("VOZ :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("VIDEO"))
                            {
                                Outros_QoS_VarText02.Text = s.Replace("VIDEO :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("MISSÃO"))
                            {
                                Outros_QoS_VarText03.Text = s.Replace("MISSÃO CRÍTICA :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("INTERATIVA"))
                            {
                                Outros_QoS_VarText04.Text = s.Replace("INTERATIVA :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("BULK"))
                            {
                                Outros_QoS_VarText05.Text = s.Replace("BULK :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("NETWORK CONTROL"))
                            {
                                Outros_QoS_VarText06.Text = s.Replace("NETWORK CONTROL :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("BEST EFFORT"))
                            {
                                Outros_QoS_VarText07.Text = s.Replace("BEST EFFORT :", string.Empty).Replace("Kbps", string.Empty).Trim();
                                qos = false;
                            }
                        }
                    }
                }
                #endregion
                // ------------------------------------------------
                // Import Voz
                // ------------------------------------------------
                #region
                else if (split[1].Contains("Tronco"))
                {
                    string[] numero = split;
                    string[] name = split;
                    string iplan = "";

                    Debug.WriteLine("\r\n--> Produto do tipo VOZ encontrado...");
                    MessageBox.Show("Import SAIP - VOZ");

                    foreach (string s in split)
                    {
                        i = ++i;
                        actual = (i + " - " + s);

                        if (s.Contains("PE:"))
                        {
                            SetPE(s);
                        }

                        if (s.Contains("Description Roteador"))
                        {
                            // Description
                            Script_VarText01.Text = s.Replace("Description Roteador", string.Empty).Trim();
                            name = Script_VarText01.Text.Split('|');
                            // ---------------
                            // Hostname
                            Script_VarText00.Text = DoHostname(name[0]) + "-" + numero[2].Trim();
                        }
                        if (s.Contains("Designação IP"))
                        {
                            // Designacação / Tronco-chave 
                            var = s.Replace("Designação IP", string.Empty).Trim();
                            numero = s.Split('/');
                        }
                        if (banda)
                        {
                            if (s.Contains("Banda"))
                            {
                                // Bandwidth
                                Script_VarText02.Text = s.Replace("Banda", string.Empty).Trim();
                                banda = false;
                            }
                        }
                        if (porta)
                        {
                            if (s.Contains("Porta"))
                            {
                                // Porta da WAN
                                var = s.Replace("Porta", string.Empty).Trim();
                                Script_VarText03b.Text = GigaOrTenGiga(var);
                                porta = false;
                            }
                        }
                        if (s.Contains("IP Serial Usuário (IPv4)"))
                        {
                            // IPs do PE
                            var = s.Replace("IP Serial Usuário (IPv4)", string.Empty).Trim();
                            string[] ipPE = var.Split('/');
                            Script_VarText07.Text = GetBackboneInterfaceIP(ipPE[0], true).Trim();          // IP da Porta
                            Script_VarText08.Text = RemoveZero(ipPE[0]);                                   // IP da Porta + 1 (bloco /30)
                        }
                        if (s.Contains("IP SIP Acesso"))
                        {
                            // IP do SIP Server e Regras
                            var = s.Replace("IP SIP Acesso:", string.Empty).Trim();
                            Script_VarText16.Text = var;
                            Script_VarText17.Text = numero[2].Remove(0, 2).Trim();
                            Script_VarText18.Text = numero[2].Remove(2, 8).Trim();
                            Script_VarText19.Text = numero[2].Remove(0, 2).Trim();
                        }
                        if (s.Contains("IP PABX:"))
                        {
                            // IP de LAN
                            iplan = s.Replace("IP PABX:", string.Empty).Trim();
                            iplan = GetBackboneInterfaceIP(iplan, true).Trim();
                        }
                        if (s.Contains("Sinalização:"))
                        {
                            // Sinalizaçäo 
                            if (s.Contains("PABX IP"))
                            {
                                Script_SinalizBox.SelectedIndex = 2;
                            }
                            else if (s.Contains("TDM.R2D"))
                            {
                                Script_SinalizBox.SelectedIndex = 0;
                            }
                            else if (s.Contains("ISDN"))
                            {
                                Script_SinalizBox.SelectedIndex = 1;
                            }
                        }
                        if (Script_SinalizBox.SelectedIndex == 2)
                        {
                            Script_VarText09.Text = iplan;
                            Script_LANMascaraBox.SelectedIndex = 0;
                        }
                        else
                        {
                            Script_VarText09.Text = "";
                        }
                    }

                    // N de Canais
                    if (Script_SinalizBox.SelectedIndex != 2)
                    {
                        if (Script_SinalizBox.SelectedIndex == 0 || Script_SinalizBox.SelectedIndex == 1)
                        {
                            if (Script_SinalizBox.SelectedIndex == 0)
                            {
                                Script_VarText20.Text = "1-5,17-31";
                            }
                            else if (Script_SinalizBox.SelectedIndex == 1)
                            {
                                Script_VarText20.Text = "1-31";
                            }
                            try
                            {
                                if (int.Parse(Script_VarText02.Text) > 1500)
                                {
                                    MessageBox.Show("Possui mais de uma E1");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Valor no campo Bandwidth não é um número");
                            }
                        }
                        else
                        {
                            if (Script_SinalizBox.SelectedIndex == 2)
                            {
                                MessageBox.Show("Sinalização: PABX IP");
                                Script_VarText20.Text = "1-31";
                            }
                        }
                    }
                    else
                    {
                        Script_LANMascaraBox.SelectedIndex = 0;
                    }

                    if (OpenPE_ComboBox.Text.Contains("IACC") || OpenPE_ComboBox.Text.Contains("GACC"))
                    {
                        Script_XRBox.SelectedIndex = 0;
                    }
                    else
                    {
                        Script_XRBox.SelectedIndex = 1;
                    }

                }
                #endregion
                // ------------------------------------------------
                // Import Outros
                // ------------------------------------------------
                #region
                else
                {
                    Debug.WriteLine("\r\n--> Produto do tipo Outros encontrado...");

                    bool qos = false;

                    foreach (string s in split)
                    {
                        i = ++i;
                        actual = (i + " - " + s);

                        if (s.Contains("PE:"))
                        {
                            SetPE(s);
                        }

                        if (s.Contains("Description Roteador"))
                        {
                            // Hostname / Description
                            var = s.Replace("Description Roteador", string.Empty);
                            string[] hostname = var.Split('|');
                            Script_VarText00.Text = DoHostname(hostname[0]);
                            Script_VarText01.Text = var.Trim();
                        }
                        if (banda)
                        {
                            if (s.Contains("Banda"))
                            {
                                // Bandwidth
                                Script_VarText02.Text = s.Replace("Banda", string.Empty).Trim();
                                banda = false;
                            }
                        }
                        if (porta)
                        {
                            if (s.Contains("Porta"))
                            {
                                // Porta da WAN
                                var = s.Replace("Porta", string.Empty).Trim();
                                Script_VarText03b.Text = GigaOrTenGiga(var);
                                porta = false;
                            }
                        }
                        if (s.Contains("IP Serial Usuário (IPv4)"))
                        {
                            // IPs do PE
                            var = s.Replace("IP Serial Usuário (IPv4)", string.Empty).Trim();
                            string[] ipPE = var.Split('/');
                            Script_VarText07.Text = GetBackboneInterfaceIP(ipPE[0], true);                // IP da Porta
                            Script_VarText08.Text = RemoveZero(ipPE[0]);                                  // IP da Porta + 1 (bloco /30)
                        }
                        if (s.Contains("Blocos IPv4"))
                        {
                            // IP de LAN
                            var = s.Replace("Blocos IPv4", string.Empty).Trim();
                            string[] ipLan = var.Split('/');
                            Script_VarText09.Text = GetBackboneInterfaceIP(ipLan[0], false);
                            MascaraLAN(ipLan[1]);
                        }
                        if (s.Contains("Vrf"))
                        {
                            // VRF Name
                            Script_VarText14.Text = s.Replace("Vrf", string.Empty).Trim();
                        }
                        if (s.Contains("SERVICE_ID"))
                        {
                            // VRF Service ID
                            Script_VarText15.Text = s.Replace("SERVICE_ID", string.Empty).Trim();
                        }
                        // ------------------------------------------
                        // QoS

                        if (s.Contains("Dados de QoS\t: CANAIS"))
                        {
                            MessageBox.Show("Possui QoS - Importando");
                            qos = true;
                        }
                        if (qos)
                        {
                            if (s.Contains("VOZ"))
                            {
                                Outros_QoS_VarText01.Text = s.Replace("VOZ :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("VIDEO"))
                            {
                                Outros_QoS_VarText02.Text = s.Replace("VIDEO :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("MISSÃO"))
                            {
                                Outros_QoS_VarText03.Text = s.Replace("MISSÃO CRÍTICA :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("INTERATIVA"))
                            {
                                Outros_QoS_VarText04.Text = s.Replace("INTERATIVA :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("BULK"))
                            {
                                Outros_QoS_VarText05.Text = s.Replace("BULK :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("NETWORK CONTROL"))
                            {
                                Outros_QoS_VarText06.Text = s.Replace("NETWORK CONTROL :", string.Empty).Replace("Kbps", string.Empty).Trim();
                            }
                            if (s.Contains("BEST EFFORT"))
                            {
                                Outros_QoS_VarText07.Text = s.Replace("BEST EFFORT :", string.Empty).Replace("Kbps", string.Empty).Trim();
                                qos = false;
                            }
                        }
                    }
                }
                #endregion
                // ------------------------------------------------
            }
            catch (Exception exc)
            {
                Debug.WriteLine("\r\n--> Import Incorreto\r\n\r\n Error: " + exc);
                MessageBox.Show("Import Incorreto\r\n\r\n Error: " + exc);

                if (enableTest)
                {
                    if (actual != "" || actual != string.Empty)
                    {
                        Debug.WriteLine("\r\nErro Line --> " + actual);
                        MessageBox.Show("Erro Line --> " + actual);
                    }
                }
            }
        }
        // ----------------------------------------------------------------------------------
        #endregion

        // ---------------------------
        // Import String Functions
        // ---------------------------
        #region
        public void SetPE(string peStr)
        {
            OpenPE_ComboBox.Text = peStr.Replace("PE:", string.Empty).Trim();
            if (OpenPE_ComboBox.Text.Contains("IACC") || OpenPE_ComboBox.Text.Contains("GACC"))
            {
                Script_XRBox.SelectedIndex = 0;
            }
            else
            {
                Script_XRBox.SelectedIndex = 1;
            }
        }

        public string DoHostname(string hostname)
        {
            hostname = hostname.Trim();

            if (hostname.Contains('.'))
            {
                hostname = hostname.Replace(" ", "_");
            }
            if (hostname.Contains(' '))
            {
                hostname = hostname.Replace(" ", "_");
            }
            if (hostname.Length > 15)
            {
                hostname = hostname.Remove(15);
            }

            return hostname;
        }


        public string GigaOrTenGiga(string str)
        {
            if (!str.Contains(":"))
            {
                peType = RouterType.Cisco;

                if (str.Contains("TENGIGA"))
                {
                    str = str.Replace("TENGIGA", string.Empty).Trim();
                    str = "TenGigE" + str;
                }
                else if (str.Contains("GIGA"))
                {
                    str = str.Replace("GIGA", string.Empty).Trim();
                    str = "GigabitEthernet" + str;
                }
                else if (str.Contains("FAST"))
                {
                    str = str.Replace("FAST", string.Empty).Trim();
                    str = "FastEthernet" + str;
                }
            }
            else
            {
                peType = RouterType.Nokia;

                if (str.Contains("ESAT"))
                {
                    str = str.Replace("ESAT", string.Empty).Trim();
                    str = "Gigaesat-" + str;
                }
                else
                {
                    str = str.Replace("TENGIGA", string.Empty).Trim();
                    str = "Tengige" + str;
                }
            }

            return str;
        }

        public string GetBackboneInterfaceIP(string ip, bool minus)
        {
            ip = RemoveZero(ip);

            int x;

            if (minus)
            { x = (-1); }
            else
            { x = 1; }

            string[] ipSplit = ip.Split('.');

            if (ipSplit.Length > 1)
            {
                int finalOctet = int.Parse(ipSplit[3]) + x;
                return ipSplit[0] + "." + ipSplit[1] + "." + ipSplit[2] + "." + finalOctet.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public string RemoveZero(string ip)
        {
            string[] ipSplit = ip.Split('.');

            if (ipSplit.Length >= 4)
            {
                for (int i = 0; i < ipSplit.Length; i++)
                {
                    if (int.Parse(ipSplit[i]) > 0)
                    {

                        char a = ipSplit[i][0];
                        if (a == '0')
                        {
                            ipSplit[i] = ipSplit[i].Remove(0, 1);

                            char b = ipSplit[i][0];
                            if (b == '0')
                            {
                                ipSplit[i] = ipSplit[i].Remove(0, 1);
                            }
                        }
                    }
                    else
                    {
                        ipSplit[i] = "0";
                    }
                }

                return ipSplit[0] + "." + ipSplit[1] + "." + ipSplit[2] + "." + ipSplit[3];
            }
            else
            {
                return string.Empty;
            }
        }

        public string MascaraLAN(string mascara)
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
                Script_LANMascaraBox.SelectedIndex = -1;
            }

            return mascara;
        }

        #endregion

        // ---------------------------
        // Telnet Button
        // ---------------------------
        #region
        private void Script_TelnetButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ScriptHelper.TelnetString(peType, activityType, isXR, Script_VarText08.Text, Script_VarText03b.Text, Script_VarText14.Text));
            Debug.WriteLine("\r\n--> Telnet Copiado com Backbone: " + peType);
        }
        private void Script_Button_SSH_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ScriptHelper.SSHString(peType, activityType, isXR, Script_VarText08.Text, Script_VarText03b.Text, Script_VarText14.Text));
            Debug.WriteLine("\r\n--> SSH Copiado com Backbone: " + peType);
        }

        private void Script_TelnetButtonTACACS_Click(object sender, EventArgs e)
        {
            if (userTacacs != "")
            {
                Clipboard.SetText(ScriptHelper.TelnetString(peType, activityType, isXR, Script_VarText08.Text, Script_VarText03b.Text, Script_VarText14.Text)
                    + "\r\n" + userTacacs + "\r\n\r\n\r\n\r\n\r\n\r\n");
            }
            else
            {
                MessageBox.Show("Usuário TACACS não definido");
            }
        }

        private void Script_TelnetButtonPlus_Click(object sender, EventArgs e)
        {
            string final = string.Empty;
            string telnet = ScriptHelper.TelnetString(peType, activityType, isXR, Script_VarText08.Text, Script_VarText03b.Text, Script_VarText14.Text);

            if (routerType == RouterType.Cisco)
            {
                final = telnet + "\r\n" + "EBT\r\n" + "CQMR\r\n" + "EN\r\n" + "PRO1AN\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (routerType == RouterType.HPE)
            {
                final = telnet + "\r\n" + "EBT\r\n" + "PRO1AN\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (routerType == RouterType.Huawei)
            {
                final = telnet + "\r\n" + "EBT\r\n" + "PRO1AN@1\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (routerType == RouterType.Fortigate)
            {
                final = telnet + "\r\n" + "EBT\r\n" + "PRO1AN\r\n" + "admin\r\n" + "PRO1AN\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }

            Clipboard.SetText(final);
        }
        #endregion

        // ---------------------------------------------------------------------------
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // --------------------------- VELOCLOUD -------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        public void SwitchLogs()
        {
            if (finalsOrNot)
            {
                finalsOrNot = true;
                logType = "FINAIS";
                Velo_TypeLabel.Text = "FINAIS";
                Script_SwitchLabel.Text = "FINAIS";
                buttonSwitchVeloLog.Text = "INICIAIS";    // Inverted
            }
            else
            {
                finalsOrNot = false;
                logType = "INICIAIS";
                Velo_TypeLabel.Text = "INICIAIS";
                Script_SwitchLabel.Text = "INICIAIS";
                buttonSwitchVeloLog.Text = "FINAIS";     // Inverted
            }

            Debug.WriteLine("Switching Logs: " + Velo_TypeLabel.Text);
        }

        private void Logs_Velo_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabVelocloud;

            // activityType = ActivityType.SDWAN;
            // routerType = RouterType.Velocloud;
            backboneOrNot = false;
            procedureType = ProcedureType.Logs;

            SwitchLogs();
            ApplyVeloLogs();
        }

        private void SwitchVeloLog_Click(object sender, EventArgs e)
        {
            finalsOrNot = !finalsOrNot;
            SwitchLogs();
            ApplyVeloLogs();
        }

        private void BackButton_Velo_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabLogs;
        }

        private void VeloCopie_Click(object sender, EventArgs e)
        {
            ApplyVeloLogs();
            Clipboard.SetText(veloTextBoxFinal.Text);
        }

        private void VeloClear_Click(object sender, EventArgs e)
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
            Debug.WriteLine("Applying Velocloud Logs: " + Velo_TypeLabel.Text);

            veloTextBoxFinal.Text = "################ CONFIGURACOES switchType ################ \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle0.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox0.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle1.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox1.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle2.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox2.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle3.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox3.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle4.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox4.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle5.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox5.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle6.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox6.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle7.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox7.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle8.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox8.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "####################### Diagnóstico Remoto ######################## \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle9.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox9.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle10.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox10.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle11.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox11.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle12.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox12.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle13.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox13.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "####################### Troubleshoot BGP ######################## \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle14.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox14.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle15.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox15.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n" +
                "################## " + labelVeloSubtitle16.Text + " ################## \r\n" +
                " \r\n" +
                veloTextBox16.Text.Trim() + " \r\n" +
                " \r\n" +
                " \r\n";

            veloTextBoxFinal.Text = veloTextBoxFinal.Text.Replace("switchType", Script_SwitchLabel.Text);
        }

        private void VeloDeleteButton0_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox0.Text = string.Empty;
        }

        private void VeloDeleteButton1_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox1.Text = string.Empty;
        }

        private void VeloDeleteButton2_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox2.Text = string.Empty;
        }

        private void VeloDeleteButton3_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox3.Text = string.Empty;
        }

        private void VeloDeleteButton4_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox4.Text = string.Empty;
        }

        private void VeloDeleteButton5_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox5.Text = string.Empty;
        }

        private void VeloDeleteButton6_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox6.Text = string.Empty;
        }

        private void VeloDeleteButton7_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox7.Text = string.Empty;
        }

        private void VeloDeleteButton8_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox8.Text = string.Empty;
        }

        private void VeloDeleteButton9_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox9.Text = string.Empty;
        }

        private void VeloDeleteButton10_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox10.Text = string.Empty;
        }

        private void VeloDeleteButton11_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox11.Text = string.Empty;
        }

        private void VeloDeleteButton12_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox12.Text = string.Empty;
        }

        private void VeloDeleteButton13_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox13.Text = string.Empty;
        }

        private void VeloDeleteButton14_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox14.Text = string.Empty;
        }

        private void VeloDeleteButton15_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox15.Text = string.Empty;
        }

        private void VeloDeleteButton16_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;
            veloTextBox16.Text = string.Empty;
        }

        private void VeloRestoreButton_Click(object sender, EventArgs e)
        {
            if (veloRestore != string.Empty)
            {
                MessageBox.Show("Restauração realizada");
                veloTextBoxFinal.Text = veloRestore;
            }
        }

        private void VeloDeleteButtonAll_Click(object sender, EventArgs e)
        {
            veloRestore = veloTextBoxFinal.Text;

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
        // ------------------------- LOGS DE LIGAÇÃO ---------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        private void Ligacoes_BCopy_Click(object sender, EventArgs e)
        {
            ApplyLogsDeLigacao();
            Clipboard.SetText(Ligacoes_FinalTextBox.Text);
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
            MessageBox.Show("Fixo: 4002-0022 (Não funciona em todas as localidades)\r\nDDD: (48) 2106-0006\r\n0800: 0800 721 8004\r\n3 Dígitos: 102 / 135 \r\n \r\n \r\n :INTERNACIONAL:\r\n0021 1 412-391-9500\r\n1-800-246-8464  - AT&T\r\n003149 703-427-40992  - Alemanha");
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
            Clipboard.SetText("terminal length 0\r\n" + "show voice port summary\r\n" + "!\r\n" + "show voice call status\r\n" + "!\r\n" + "show voice call summary\r\n" + "!\r\n");
        }

        private void Ligacoes_BDigistar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("show voip sip channel\r\n" + "!\r\n" + "show pbx group status tdm\r\n" + "!\r\n");
        }

        private void Ligacoes_BDebug_Click(object sender, EventArgs e)
        {
            FormDebug debugForm = new FormDebug(MasterSheetNew.Properties.Settings.Default.debugVoz);
            debugForm.Show(Owner);
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

            Debug.WriteLine("\r\n--> Applied Logs de Ligação");
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

        private void Ligacoes_ConfigWiseButton_Click(object sender, EventArgs e)
        {
            FormDebug debugForm = new FormDebug(MasterSheetNew.Properties.Settings.Default.configWiseVoz);
            debugForm.Show(Owner);
        }
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // --------------------------- LOG TOOLS -------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        private void LogTools_DBScriptButton_Click(object sender, EventArgs e)
        {
            tabControlLogTools.SelectedTab = tabScriptDB;
            HighlightLogToolsButtons(LogTools_DBScript);
        }

        // -----------------
        // Pendencia
        // -----------------
        #region
        public void ApplyLogTools()
        {
            Log_FinalTextBox.Text = "==================" + " \r\n" +
                "STATUS ANTERIOR: " + "\r\n" +
                "==================" + " \r\n" +
                Log_TextBox1.Text.Trim() +
                "\r\n" +
                "\r\n" +
                "==================" + " \r\n" +
                "STATUS ATUAL: " + "\r\n" +
                "==================" + " \r\n" +
                Log_TextBox2.Text.Trim() +
                "\r\n" +
                "\r\n" +
                "==================" + " \r\n" +
                "PRÓXIMOS PASSOS: " + "\r\n" +
                "==================" + " \r\n" +
                Log_TextBox3.Text.Trim() +
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
            HighlightLogToolsButtons(LogTools_Pendencia);
        }

        private void LogToolsFechamento_Click(object sender, EventArgs e)
        {
            tabControlLogTools.SelectedTab = tabFechamento;
            HighlightLogToolsButtons(LogTools_Fechamento);
        }

        private void LogToolsSuporte_Click(object sender, EventArgs e)
        {
            tabControlLogTools.SelectedTab = tabSuporte;
            HighlightLogToolsButtons(LogTools_Suporte);
        }

        public void HighlightLogToolsButtons(Button button)
        {
            foreach (Button b in logtoolsButtons)
            {
                if (b.Name == button.Name)
                {
                    b.BackColor = SystemColors.Control;
                    Debug.Write("\r\n--> Button: " + button + " highlighted");
                }
                else
                {
                    b.BackColor = Color.FromArgb(228, 230, 235);
                }
            }
        }
        #endregion

        // -----------------
        // Fechamento
        // -----------------
        #region
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
            if (LTFechamento_CheckBox3.Checked)
            {
                LTFechamento_CheckBox3.Checked = !LTFechamento_CheckBox3.Checked;
            }
            if (LTFechamento_CheckBox1.Checked)
            {
                LTFechamento_CheckBox1.Checked = !LTFechamento_CheckBox1.Checked;
            }
            if (LTFechamento_CheckBox4.Checked)
            {
                LTFechamento_CheckBox4.Checked = !LTFechamento_CheckBox4.Checked;
            }
            if (LTFechamento_CheckBox5.Checked)
            {
                LTFechamento_CheckBox5.Checked = !LTFechamento_CheckBox4.Checked;
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
            if (LTFechamento_CheckBox4.Checked)
            {
                LTFechamento_CheckBox4.Checked = !LTFechamento_CheckBox4.Checked;
            }
            if (LTFechamento_CheckBox2.Checked)
            {
                LTFechamento_CheckBox2.Checked = !LTFechamento_CheckBox2.Checked;
            }
            if (LTFechamento_CheckBox5.Checked)
            {
                LTFechamento_CheckBox5.Checked = !LTFechamento_CheckBox4.Checked;
            }
            ApplyFechamento();
        }

        private void LTFechamento_CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (LTFechamento_CheckBox0.Checked)
            {
                LTFechamento_CheckBox0.Checked = !LTFechamento_CheckBox0.Checked;
            }
            if (LTFechamento_CheckBox3.Checked)
            {
                LTFechamento_CheckBox3.Checked = !LTFechamento_CheckBox3.Checked;
            }
            if (LTFechamento_CheckBox4.Checked)
            {
                LTFechamento_CheckBox4.Checked = !LTFechamento_CheckBox4.Checked;
            }
            if (LTFechamento_CheckBox2.Checked)
            {
                LTFechamento_CheckBox2.Checked = !LTFechamento_CheckBox2.Checked;
            }
            if (LTFechamento_CheckBox5.Checked)
            {
                LTFechamento_CheckBox5.Checked = !LTFechamento_CheckBox4.Checked;
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
            if (LTFechamento_CheckBox3.Checked)
            {
                LTFechamento_CheckBox3.Checked = !LTFechamento_CheckBox3.Checked;
            }
            if (LTFechamento_CheckBox2.Checked)
            {
                LTFechamento_CheckBox2.Checked = !LTFechamento_CheckBox2.Checked;
            }
            if (LTFechamento_CheckBox5.Checked)
            {
                LTFechamento_CheckBox5.Checked = !LTFechamento_CheckBox4.Checked;
            }
            ApplyFechamento();
        }

        private void LTFechamento_CheckBox4_CheckedChanged(object sender, EventArgs e)
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
            if (LTFechamento_CheckBox4.Checked)
            {
                LTFechamento_CheckBox4.Checked = !LTFechamento_CheckBox4.Checked;
            }
            if (LTFechamento_CheckBox5.Checked)
            {
                LTFechamento_CheckBox5.Checked = !LTFechamento_CheckBox4.Checked;
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
            if (LTFechamento_CheckBox3.Checked)
            {
                LTFechamento_CheckBox3.Checked = !LTFechamento_CheckBox3.Checked;
            }
            if (LTFechamento_CheckBox4.Checked)
            {
                LTFechamento_CheckBox4.Checked = !LTFechamento_CheckBox4.Checked;
            }
            if (LTFechamento_CheckBox2.Checked)
            {
                LTFechamento_CheckBox2.Checked = !LTFechamento_CheckBox4.Checked;
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
            if (LTFechamento_CheckBox3.Checked)
            {
                fechamentoSubInfo = "Teste de Certidão realizado pela Equipe de Degradação" + "\r\n" + "\r\n";
            }
            if (LTFechamento_CheckBox1.Checked)
            {
                fechamentoSubInfo = "Atividade IP VPN ou Voz" + "\r\n" + "\r\n";
            }
            if (LTFechamento_CheckBox4.Checked)
            {
                fechamentoSubInfo = "Visita Unica" + "\r\n" + "\r\n";
            }
            if (LTFechamento_CheckBox2.Checked)
            {
                fechamentoSubInfo = "Cliente não Autorizou o Teste de Certidão" + "\r\n" + "\r\n";
            }
            if (LTFechamento_CheckBox5.Checked)
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
        #endregion

        // -----------------
        // Suporte
        // -----------------
        #region
        private void ButtonLogTools_Suporte_Click(object sender, EventArgs e)
        {
            commandStr = LT_SuporteComTextBox.Text;
            ApplySuporteLog();
            Clipboard.SetText(LTSuporteFinalTextBox.Text);
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
                    "# " + LT_SuporteTitleTextBox.Text.Trim() + " # \r\n" +
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
                commandStr = LT_SuporteComTextBox.Text.Trim();

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
                "# " + LT_SuporteTitleTextBox.Text.Trim() + " # \r\n" +
                "\r\n" +
                "===================================================\r\n " +
                "\r\n ";

            LTSuporteFinalTextBox.Text = suporteTitle + commandStr;
        }
        #endregion

        // ----------------------
        // Calculo de Subrede
        // ----------------------
        #region
        private void LT_IPCalculator_TabChange(object sender, EventArgs e)
        {
            tabControlLogTools.SelectedTab = tabCalculadoraDeIP;
            HighlightLogToolsButtons(LogTools_Calc); 
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
        private void LTCalc_ButtonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LTCalc_Result.Text);
        }
        #endregion

        // ---------------------------------------------------------------------------
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // -------------------------- OUTRAS CONFIGS ---------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region

        // ---------------------------
        // SNMP
        // ---------------------------
        #region
        public void OpenOutrosSNMP()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 1;
            Outros_Title.Text = "SNMP";
            outros = "snmp";

            FormatScriptOutrosDispatch(outros);
        }

        public void ApplytOutrosSNMP()
        {
            if (Outros_TypeComboBox.SelectedIndex == 0)     // Ciscos
            {
                string typeSNMP = "RO";

                if (Outros_SNMP_VarPrivComboBox.SelectedIndex == 0)
                {
                    typeSNMP = "RO";
                }
                if (Outros_SNMP_VarPrivComboBox.SelectedIndex == 1)
                {
                    typeSNMP = "RW";
                }
                if (Outros_SNMP_VarText1.Text == string.Empty)
                {
                    Outros_FinalTextBox.Text = scripts[39].scriptString.Replace("VarCom", Outros_SNMP_VarText0.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarTipo", typeSNMP);
                }
                else
                {
                    Outros_FinalTextBox.Text = scripts[40].scriptString.Replace("VarCom", Outros_SNMP_VarText0.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_SNMP_VarText1.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarTipo", typeSNMP);
                }

            }
            if (Outros_TypeComboBox.SelectedIndex == 1)     // HPE
            {
                string typeSNMP = "read";

                if (Outros_SNMP_VarPrivComboBox.SelectedIndex == 0)
                {
                    typeSNMP = "read";
                }
                if (Outros_SNMP_VarPrivComboBox.SelectedIndex == 1)
                {
                    typeSNMP = "write";
                }
                if (Outros_SNMP_VarText1.Text == string.Empty)
                {
                    Outros_FinalTextBox.Text = scripts[41].scriptString.Replace("VarCom", Outros_SNMP_VarText0.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarTipo", typeSNMP);
                }
                else
                {
                    Outros_FinalTextBox.Text = scripts[42].scriptString.Replace("VarCom", Outros_SNMP_VarText0.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_SNMP_VarText1.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarTipo", typeSNMP);
                }

            }
            if (Outros_TypeComboBox.SelectedIndex == 2)     // Huawei
            {
                if (Outros_SNMP_VarText1.Text == string.Empty)
                {
                    Outros_FinalTextBox.Text = scripts[43].scriptString.Replace("VarCom", Outros_SNMP_VarText0.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = scripts[44].scriptString.Replace("VarCom", Outros_SNMP_VarText0.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_SNMP_VarText1.Text);
                }
            }
            if (Outros_TypeComboBox.SelectedIndex == 3)     // Fortigate
            {
                if (Outros_SNMP_VarText1.Text == string.Empty)
                {
                    Outros_FinalTextBox.Text = scripts[45].scriptString.Replace("VarCom", Outros_SNMP_VarText0.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = scripts[46].scriptString.Replace("VarCom", Outros_SNMP_VarText0.Text);
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_SNMP_VarText1.Text);
                }
            }
        }
        #endregion

        // ---------------------------
        // QoS
        // ---------------------------
        #region
        public void OpenOutrosQoS()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 0;
            Outros_Title.Text = "QoS";
            outros = "qos";

            Outros_QoS_VarText00.Text = Script_VarText02.Text;
            Outros_QoS_VarText08.Text = Script_VarText03.Text;
            Outros_QoS_VarText09.Text = Script_VarText05.Text;

            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosQoS()
        {
            CalcQoSTotal();

            if (Outros_TypeComboBox.SelectedIndex == 0) // Cisco
            {
                Outros_FinalTextBox.Text = scripts[51].scriptString;
            }
            else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
            {
                Outros_FinalTextBox.Text = scripts[52].scriptString;
            }
            else if (Outros_TypeComboBox.SelectedIndex == 2)   // Huawei
            {
                Outros_FinalTextBox.Text = scripts[53].scriptString;
            }
            else if (Outros_TypeComboBox.SelectedIndex == 3)    // Fortigate
            {
                Outros_FinalTextBox.Text = scripts[54].scriptString;
            }
            else
            {
                Outros_FinalTextBox.Text = "";
            }

            // --------------------------------------------------------------
            if (Outros_TypeComboBox.SelectedIndex == 0 )    // Cisco
            {
                // ---------------------------------------
                if (Outros_QoS_VarTextShow1.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVoz", "class-map match-any MarcacaoVoz\r\nmatch access-group name TrafegoVoz\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVoz", "class-map match-any Voz\r\nmatch ip dscp ef cs5\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVoz", "policy-map EntradaLanCE\r\nclass MarcacaoVoz\r\nset ip dscp ef");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpVoz", "class Voz\r\n priority level VarVoz\r\npolice cir percent 1 conform-action transmit  exceed-action drop\r\n!");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarVoz", Outros_QoS_VarTextShow1.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVoz", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVoz", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVoz", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpVoz", "!");

                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow2.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVideo", "class-map match-any MarcacaoVideo\r\nmatch access-group name TrafegoVideo\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVideo", "class-map match-any Video\r\nmatch ip dscp af41\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVideo", "class MarcacaoVideo\r\nset ip dscp af41");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpVideo", "class Video\r\n  priority level VarVideo\r\npolice cir percent 1 conform-action transmit  exceed-action drop\r\n!");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarVideo", Outros_QoS_VarTextShow2.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVideo", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVideo", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVideo", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpVideo", "!");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow3.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMissao", "class-map match-any MarcacaoMissaoCritica\r\nmatch access-group name TrafegoMissaoCritica\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpMissao", "class-map match-any MissaoCritica\r\nmatch ip dscp af31 af32 af33 cs3\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMissao", "class MarcacaoMissaoCritica\r\nset ip dscp af31");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpMissao", "class MissaoCritica\r\nbandwidth percent VarMissao");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarMissao", Outros_QoS_VarTextShow3.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMissao", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpMissao", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMissao", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpMissao", "!");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow4.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnInterativa", "class-map match-any MarcacaoInterativa\r\nmatch access-group name TrafegoInterativo\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpInterativa", "class-map match-any Interativa\r\nmatch ip dscp af21 af22 af23\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiInterativa", "Class MarcacaoInterativa\r\nset ip dscp af21");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpInterativa", "class Interativa\r\nbandwidth percent VarInterativa");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarInterativa", Outros_QoS_VarTextShow4.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnInterativa", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpInterativa", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiInterativa", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpInterativa", "!");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow5.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnBulk", "class-map match-any MarcacaoBulk\r\nmatch access-group name TrafegoBulk\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBulk", "class-map match-any Bulk\r\nmatch ip dscp af11 af12 af13 cs1 cs4\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiBulk", "Class MarcacaoBulk\r\nset ip dscp af11");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBulk", "class Bulk\r\nbandwidth percent VarBulk");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarBulk", Outros_QoS_VarTextShow5.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnBulk", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBulk", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiBulk", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBulk", "!");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow6.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnNetwork", "class-map match-any MarcacaoNetworkControl\r\nmatch access-group name TrafegoNetworkControl\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpNetwork", "class-map match-any NetworkControl\r\nmatch ip dscp CS6 CS7 CS2\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiNetwork", "class MarcacaoNetworkControl\r\nset ip dscp CS2\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpNetwork", "class NetworkControl\r\nbandwidth percent VarNetwork");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarNetwork", Outros_QoS_VarTextShow6.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnNetwork", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpNetwork", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiNetwork", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpNetwork", "!");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow7.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBest", "class-map match-any BestEffort\r\nmatch any\r\n!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBest", "class BestEffort\r\nbandwidth percent VarBest\r\n!");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarBest", Outros_QoS_VarTextShow7.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBest", "!");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBest", "!");
                }
                // ---------------------------------------

            }

            // --------------------------------------------------------------
            if (Outros_TypeComboBox.SelectedIndex == 1)    // HPE
            {
                // ---------------------------------------
                if (Outros_QoS_VarTextShow1.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcaVoz", "traffic classifier MarcacaoVoz\r\n if-match acl 3000");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVoz", "traffic behavior MarcacaoVoz\r\n remark dscp ef");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVoz", " classifier MarcacaoVoz behavior MarcacaoVoz");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaVoz", "traffic classifier Voz\r\n if-match dscp ef");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVoz", "traffic behavior Voz\r\n queue ef bandwidth pct VarVoz");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpVoz", " classifier Voz behavior Voz");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarVoz", Outros_QoS_VarTextShow1.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcaVoz", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVoz", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVoz", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaVoz", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVoz", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpVoz", "#");

                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow2.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcaVideo", "traffic classifier MarcacaoVideo\r\n if-match acl 3001");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVideo", "traffic behavior MarcacaoVideo\r\n remark dscp af41");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVideo", " classifier MarcacaoVideo behavior MarcacaoVideo");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaVideo", "traffic classifier Video\r\n if-match dscp af41");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVideo", "traffic behavior Video\r\n queue af bandwidth pct VarVideo");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpVideo", " classifier Video behavior Video");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarVideo", Outros_QoS_VarTextShow2.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcaVideo", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVideo", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVideo", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaVideo", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVideo", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpVideo", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow3.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcaMissao", "traffic classifier MarcacaoMissaoCritica\r\n if-match acl 3002");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMissao", "traffic behavior MarcacaoMissaoCritica\r\n remark dscp af31");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpMissao", " classifier MarcacaoMissaoCritica behavior MarcacaoMissaoCritica");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaMissao", "traffic classifier MissaoCritica\r\n if-match dscp af31 af32 af33 cs3");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMissao", "traffic behavior MissaoCritica\r\n queue af bandwidth pct VarMissao");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpMissao", " classifier MissaoCritica behavior MissaoCritica");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarMissao", Outros_QoS_VarTextShow3.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcMissao", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMissao", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpMissao", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcMissao", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMissao", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpMissao", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow4.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcaInterativa", "traffic classifier MarcacaoInterativa\r\n if-match acl 3003");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnInterativa", "traffic behavior MarcacaoInterativa\r\n remark dscp af21");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpInterativa", " classifier MarcacaoInterativa behavior MarcacaoInterativa");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaInterativa", "traffic classifier Interativa\r\n if-match dscp af21 af22 af23");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiInterativa", "traffic behavior Interativa\r\n queue af bandwidth pct VarInterativa");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpInterativa", " classifier Interativa behavior Interativa");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarInterativa", Outros_QoS_VarTextShow4.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcaInterativa", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnInterativa", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpInterativa", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaInterativa", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiInterativa", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpInterativa", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow5.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcaBulk", "traffic classifier MarcacaoBulk\r\n if-match acl 3004");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnBulk", "traffic behavior MarcacaoBulk\r\n remark dscp af11");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBulk", " classifier MarcacaoBulk behavior MarcacaoBulk");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaBulk", "traffic classifier Bulk\r\n if-match dscp af11 af12 af13 cs1 cs4");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiBulk", "traffic behavior Bulk\r\n queue af bandwidth pct VarBulk");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBulk", " classifier Bulk behavior Bulk");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarBulk", Outros_QoS_VarTextShow5.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcaBulk", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnBulk", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBulk", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaBulk", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiBulk", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBulk", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow6.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcaNetwork", "traffic classifier MarcacaoNetworkControl\r\nif-match acl 3005");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnNetwork", "traffic behavior MarcacaoNetworkControl\r\nremark dscp cs6");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpNetwork", " classifier MarcacaoNetworkControl behavior MarcacaoNetworkControl");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaNetwork", "traffic classifier NetworkControl\r\n if-match dscp CS6 CS7 CS2");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiNetwork", "traffic behavior NetworkControl\r\n queue af bandwidth pct VarNetwork");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpNetwork", " classifier NetworkControl behavior NetworkControl");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarNetwork", Outros_QoS_VarTextShow6.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMarcaNetwork", "");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnNetwork", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpNetwork", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaNetwork", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiNetwork", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpNetwork", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow7.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaBest", "traffic classifier BestEffort\r\n if-match any");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiBest", "traffic behavior BestEffort\r\n queue af bandwidth pct VarBest");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBest", " classifier BestEffort behavior BestEffort");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarBest", Outros_QoS_VarTextShow7.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMarcaBest", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiBest", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBest", "#");
                }
            }
            
            // --------------------------------------------------------------
            if (Outros_TypeComboBox.SelectedIndex == 2)    // Huawei
            {
                // ---------------------------------------
                if (Outros_QoS_VarTextShow1.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVoz", "traffic classifier MarcacaoVoz\r\n if-match acl 3000");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVoz", "traffic behavior MarcacaoVoz\r\n remark dscp ef\r\n statistic enable\r\n car cir VarBanda");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVoz", " classifier MarcacaoVoz behavior MarcacaoVoz precedence VarVoz");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarVoz", Outros_QoS_VarTextShow1.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVoz", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVoz", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVoz", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow2.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVideo", "traffic classifier MarcacaoVideo\r\n if-match acl 3001");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVideo", "traffic behavior MarcacaoVideo\r\n remark dscp af41\r\n statistic enable\r\n car cir VarBanda");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVideo", " classifier MarcacaoVideo behavior MarcacaoVideo precedence VarVideo");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarVideo", Outros_QoS_VarTextShow2.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVideo", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVideo", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVideo", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow3.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMissao", "traffic classifier MarcacaoMissaoCritica\r\n if-match acl 3002");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpMissao", "traffic behavior MarcacaoMissaoCritica\r\n remark dscp af31\r\n statistic enable\r\n car cir VarBanda");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMissao", " classifier MarcacaoMissaoCritica behavior MarcacaoMissaoCritica precedence VarMissao");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarMissao", Outros_QoS_VarTextShow3.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMissao", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpMissao", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMissao", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow4.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnInterativa", "traffic classifier MarcacaoInterativa\r\n if-match acl 3003");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpInterativa", "traffic behavior MarcacaoInterativa\r\n remark dscp af21\r\n statistic enable");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiInterativa", " classifier MarcacaoInterativa behavior MarcacaoInterativa precedence VarInterativa");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarInterativa", Outros_QoS_VarTextShow4.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnInterativa", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpInterativa", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiInterativa", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow5.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnBulk", "traffic classifier MarcacaoBulk\r\n if-match acl 3004");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBulk", "traffic behavior MarcacaoBulk\r\n remark dscp af11\r\n statistic enable");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiBulk", " classifier MarcacaoBulk behavior MarcacaoBulk precedence VarBulk");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarBulk", Outros_QoS_VarTextShow5.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnBulk", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBulk", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiBulk", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow6.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnNetwork", "traffic classifier MarcacaoNetworkControl\r\n if-match acl 3005");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpNetwork", "traffic behavior MarcacaoNetworkControl\r\n remark dscp af11\r\n statistic enable");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiNetwork", " classifier MarcacaoNetworkControl behavior MarcacaoNetworkControl precedence VarNetwork");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarNetwork", Outros_QoS_VarTextShow6.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnNetwork", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpNetwork", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiNetwork", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow7.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnpBest", "traffic classifier MarcacaoBestEffort\r\n if-match acl 3006");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBest", "traffic behavior MarcacaoBestEffort\r\n remark dscp af11\r\n statistic enable");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBest", " classifier MarcacaoBestEffort behavior MarcacaoBestEffort precedence VarBest");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarBest", Outros_QoS_VarTextShow7.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnpBest", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBest", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBest", "#");
                }
            }

            // --------------------------------------------------------------
            if (Outros_TypeComboBox.SelectedIndex == 3)    // Fortigate
            {
                // ---------------------------------------
                if (Outros_QoS_VarTextShow1.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVoz", "   edit 10\r\n       set class-name \"Voz\"\r\n    next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVoz", " edit 100\r\n        set name \"Voz\"\r\n        set comment \"CS5,EF\"\r\n        set service \"ALL\"\r\n        set dstintf \"any\"\r\n        set tos-mask 0xE0\r\n        set tos 0xA0\r\n        set class-id 10\r\n        set srcaddr \"all\"\r\n        set dstaddr \"all\"\r\n    next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVoz", "            edit 10\r\n                ## VOZ ##\r\n                set class-id 10\r\n                set priority top\r\n                set guaranteed-bandwidth-percentage VarVoz\r\n                set maximum-bandwidth-percentage VarVoz\r\n            next");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarVoz", Outros_QoS_VarTextShow1.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVoz", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVoz", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVoz", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow2.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVideo", "    edit 11\r\n       set class-name \"Video\"\r\n     next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVideo", " edit 110\r\n       set name \"Video\"\r\n       set comment \"AF41\"\r\n       set service \"ALL\"\r\n       set dstintf \"any\"\r\n       set tos-mask 0xFF\r\n       set tos 0x88\r\n       set class-id 11\r\n       set srcaddr \"all\"\r\n       set dstaddr \"all\"\r\n   next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVideo", "            edit 11\r\n                ## VIDEO ##\r\n                set class-id 11\r\n                set priority top\r\n                set guaranteed-bandwidth-percentage VarVideo\r\n                set maximum-bandwidth-percentage VarVideo\r\n            next");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarVideo", Outros_QoS_VarTextShow2.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnVideo", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpVideo", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiVideo", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow3.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMissao", "    edit 12\r\n        set class-name \"MissaoCritica\"\r\n    next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpMissao", " edit 120\r\n       set name \"MissaoCritica\"\r\n       set comment \"CS3,AF31,AF32,AF33\"\r\n       set service \"ALL\"\r\n       set dstintf \"any\"\r\n       set tos-mask 0xE0\r\n       set tos 0x60\r\n       set class-id 12\r\n       set srcaddr \"all\"\r\n       set dstaddr \"all\"\r\n     next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMissao", "            edit 12\r\n                ## MISSAO CRITICA ##\r\n                set class-id 12\r\n                set priority critical\r\n                set guaranteed-bandwidth-percentage VarMissao\r\n                set maximum-bandwidth-percentage 100\r\n            next");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarMissao", Outros_QoS_VarTextShow3.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnMissao", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpMissao", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiMissao", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow4.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnInterativa", "    edit 14\r\n       set class-name \"Interativa\"\r\n    next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpInterativa", " edit 140\r\n        set name \"Interativa\"\r\n        set comment \"AF21,AF22,AF23\"\r\n        set service \"ALL\"\r\n        set dstintf \"any\"\r\n        set tos-mask 0xE0\r\n        set tos 0x40\r\n        set class-id 14\r\n        set srcaddr \"all\"\r\n        set dstaddr \"all\"\r\n  next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiInterativa", "            edit 14\r\n                ## INTERATIVA ##\r\n                set class-id 14\r\n                set priority critical\r\n                set guaranteed-bandwidth-percentage VarInterativa\r\n                set maximum-bandwidth-percentage 100\r\n            next");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarInterativa", Outros_QoS_VarTextShow4.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnInterativa", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpInterativa", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiInterativa", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow5.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnBulk", "    edit 15\r\n       set class-name \"Bulk\"\r\n    next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBulk", " edit 150\r\n        set name \"Bulk\"\r\n        set comment \"CS1,AF11,AF12,AF13\"\r\n        set service \"ALL\"\r\n        set dstintf \"any\"\r\n        set tos-mask 0xE0\r\n        set tos 0x20\r\n        set class-id 15\r\n        set srcaddr \"all\"\r\n        set dstaddr \"all\"\r\n next\r\n edit 151\r\n        set name \"Bulk_2\"\r\n        set comment \"CS4\"\r\n        set service \"ALL\"\r\n        set dstintf \"any\"\r\n        set tos-mask 0xFF\r\n        set tos 0x80\r\n        set class-id 15\r\n        set srcaddr \"all\"\r\n        set dstaddr \"all\"\r\n next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiBulk", "            edit 15\r\n                ## BULK ##\r\n                set class-id 15\r\n                set priority critical\r\n                set guaranteed-bandwidth-percentage VarBulk\r\n                set maximum-bandwidth-percentage 100\r\n            next");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarBulk", Outros_QoS_VarTextShow5.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnBulk", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBulk", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiBulk", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow6.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnNetwork", "    edit 13\r\n       set class-name \"NetworkControl\"\r\n    next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpNetwork", " edit 130\r\n        set name \"NetworkControl\"\r\n        set comment \"CS6,CS7\"\r\n        set service \"ALL\"\r\n        set dstintf \"any\"\r\n        set tos-mask 0xc0\r\n        set tos 0xc0\r\n        set class-id 13\r\n        set srcaddr \"all\"\r\n        set dstaddr \"all\"\r\n  next\r\n edit 131\r\n        set name \"NetworkControl_2\"\r\n        set comment \"CS2\"\r\n        set service \"ALL\"\r\n        set dstintf \"any\"\r\n        set tos-mask 0xFF\r\n        set tos 0x40\r\n        set class-id 13\r\n        set srcaddr \"all\"\r\n        set dstaddr \"all\"\r\n  next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiNetwork", "            edit 13\r\n                ## NETWORK CONTROL ##\r\n                set class-id 13\r\n                set priority critical\r\n                set guaranteed-bandwidth-percentage VarNetwork\r\n                set maximum-bandwidth-percentage 100\r\n            next");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarNetwork", Outros_QoS_VarTextShow6.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnNetwork", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpNetwork", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiNetwork", "#");
                }
                // ---------------------------------------
                if (Outros_QoS_VarTextShow7.Text != "0")
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnBest", "    edit 16\r\n       set class-name \"BestEffort\"\r\n    next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBest", " edit 160\r\n        set name \"BestEffort\"\r\n        set comment \"CS0\"\r\n        set service \"ALL\"\r\n        set dstintf \"any\"\r\n        set tos-mask 0xff\r\n        set tos 0x00\r\n        set class-id 16\r\n        set srcaddr \"all\"\r\n        set dstaddr \"all\"\r\n  next");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBest", "            edit 16\r\n                ## BEST EFFORT ##\r\n                set class-id 16\r\n                set priority critical\r\n                set guaranteed-bandwidth-percentage VarBest\r\n                set maximum-bandwidth-percentage 100\r\n            next");

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarBest", Outros_QoS_VarTextShow7.Text);
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnBest", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarEnDscpBest", "#");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarSaiDscpBest", "#");
                }
            }

            // -----------------------------------------------------------------------------------------------------------------
            // Total
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarTotal", Outros_QoS_VarText00.Text);
            // Interfaces
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWan", Outros_QoS_VarText08.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLan", Outros_QoS_VarText09.Text);

        }
        public void CalcQoSTotal()
        {
            float voz = 0;
            float video = 0;
            float missao = 0;
            float interativa = 0;
            float bulk = 0;
            float network = 0;
            float best = 0;

            // Check if total value is empty
            if (Outros_QoS_VarText00.Text != string.Empty)
            {
                // Alter all the values to %
                if (Outros_QoS_VarText01.Text != string.Empty)
                {
                    voz = (float)Math.Ceiling(float.Parse(Outros_QoS_VarText01.Text) / int.Parse(Outros_QoS_VarText00.Text) * 100);
                    Outros_QoS_VarTextShow1.Text = voz.ToString();
                }
                else
                {
                    Outros_QoS_VarTextShow1.Text = "0";
                }
                if (Outros_QoS_VarText02.Text != string.Empty)
                {
                    video = (float)Math.Ceiling(float.Parse(Outros_QoS_VarText02.Text) / int.Parse(Outros_QoS_VarText00.Text) * 100);
                    Outros_QoS_VarTextShow2.Text = video.ToString();
                }
                else
                {
                    Outros_QoS_VarTextShow2.Text = "0";
                }
                if (Outros_QoS_VarText03.Text != string.Empty)
                {
                    missao = (float)Math.Ceiling(float.Parse(Outros_QoS_VarText03.Text) / float.Parse(Outros_QoS_VarText00.Text) * 100);
                    Outros_QoS_VarTextShow3.Text = missao.ToString();
                }
                else
                {
                    Outros_QoS_VarTextShow3.Text = "0";
                }
                if (Outros_QoS_VarText04.Text != string.Empty)
                {
                    interativa = (float)Math.Ceiling(float.Parse(Outros_QoS_VarText04.Text) / float.Parse(Outros_QoS_VarText00.Text) * 100);
                    Outros_QoS_VarTextShow4.Text = interativa.ToString();
                }
                else
                {
                    Outros_QoS_VarTextShow4.Text = "0";
                }
                if (Outros_QoS_VarText05.Text != string.Empty)
                {
                    bulk = (float)Math.Ceiling(float.Parse(Outros_QoS_VarText05.Text) / float.Parse(Outros_QoS_VarText00.Text) * 100);
                    Outros_QoS_VarTextShow5.Text = bulk.ToString();
                }
                else
                {
                    Outros_QoS_VarTextShow5.Text = "0";
                }
                if (Outros_QoS_VarText06.Text != string.Empty)
                {
                    network = (float)Math.Ceiling(float.Parse(Outros_QoS_VarText06.Text) / float.Parse(Outros_QoS_VarText00.Text) * 100);
                    Outros_QoS_VarTextShow6.Text = network.ToString();
                }
                else
                {
                    Outros_QoS_VarTextShow6.Text = "0";
                }
                if (Outros_QoS_VarText07.Text != string.Empty)
                {
                    best = (float)Math.Ceiling(float.Parse(Outros_QoS_VarText07.Text) / float.Parse(Outros_QoS_VarText00.Text) * 100);
                    Outros_QoS_VarTextShow7.Text = best.ToString();
                }
                else
                {
                    Outros_QoS_VarTextShow7.Text = "0";
                }

                // Sum all the values
                float total = voz + video + missao + interativa + bulk + network + best;

                // Display on Screen
                Outros_QoS_TextCalcTotal.Text = Math.Ceiling(total).ToString();

                // Check if is above 99%
                if (total > 99)
                {
                    // Make it Red if does
                    Outros_QoS_TextCalcTotal.ForeColor = Color.Red;
                    MessageBox.Show("Total acima do permitido");
                }
                else
                {
                    if (nightMode)
                    {
                        Outros_QoS_TextCalcTotal.ForeColor = Color.White;
                    }
                    else
                    {
                        Outros_QoS_TextCalcTotal.ForeColor = Color.Black;
                    }
                }

                if (total < 96)
                {
                    // Make it Red if does
                    Outros_QoS_TextCalcTotal.ForeColor = Color.Red;
                    MessageBox.Show("Total abaixo de normal");
                }

            }
            else
            {
                Outros_QoS_TextCalcTotal.Text = 0.ToString();
                Outros_QoS_TextCalcTotal.ForeColor = Color.Black;
                Outros_QoS_VarTextShow1.Text = 0.ToString();
                Outros_QoS_VarTextShow2.Text = 0.ToString();
                Outros_QoS_VarTextShow3.Text = 0.ToString();
                Outros_QoS_VarTextShow4.Text = 0.ToString();
                Outros_QoS_VarTextShow5.Text = 0.ToString();
                Outros_QoS_VarTextShow6.Text = 0.ToString();
                Outros_QoS_VarTextShow7.Text = 0.ToString();
            }
        }
        #endregion

        // ---------------------------
        // BGP
        // ---------------------------
        #region
        public void OpenOutrosBGP()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 3;
            Outros_Title.Text = "BGP";
            outros = "bgp";

            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosBGP()
        {
            if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
            {
                Outros_FinalTextBox.Text = scripts[55].scriptString;

                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarAS", Outros_BGP_VarText0.Text);
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarIP", Outros_BGP_VarText1.Text);
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("designacao", Outros_BGP_VarText2.Text);

                if (Outros_BGP_VarText3.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", "neighbor VarHost remote-as VarRemote\r\nneighbor VarHost send-community ** Cliente **\r\nneighbor VarHost allowas-in\r\nneighbor VarHost description designacao\r\nneighbor VarHost soft-reconfiguration inbound");
                    // ------------------------------------------------------------------------------------------------------------
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", Outros_BGP_VarText3.Text);

                    if (Outros_BGP_VarText4.Text != string.Empty)
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_BGP_VarText4.Text);
                    }
                    else
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", "");
                    }
                    if (Outros_BGP_VarText5.Text != string.Empty)
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPassword", "set password " + Outros_BGP_VarText5.Text);
                    }
                    else
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPassword", "");
                    }
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", "");
                }
            }
            else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
            {
                Outros_FinalTextBox.Text = scripts[56].scriptString;

                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarAS", Outros_BGP_VarText0.Text);
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarIP", Outros_BGP_VarText1.Text);
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("designacao", Outros_BGP_VarText2.Text);

                if (Outros_BGP_VarText3.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", "peer VarHost as-number VarRemote\r\npeer VarHost description ** Cliente **\r\naddress-family ipv4 unicast\r\nimport-route direct\r\npeer VarHost enable\r\npeer VarHost allow-as-loop 10\r\npeer VarHost advertise-community");
                    // ------------------------------------------------------------------------------------------------------------
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", Outros_BGP_VarText3.Text);

                    if (Outros_BGP_VarText4.Text != string.Empty)
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_BGP_VarText4.Text);
                    }
                    else
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", "");
                    }
                    if (Outros_BGP_VarText5.Text != string.Empty)
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPassword", "set password " + Outros_BGP_VarText5.Text);
                    }
                    else
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPassword", "");
                    }
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", "");
                }
            }
            else if (Outros_TypeComboBox.SelectedIndex == 2)   // Huawei
            {
                Outros_FinalTextBox.Text = scripts[57].scriptString;

                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarAS", Outros_BGP_VarText0.Text);
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarIP", Outros_BGP_VarText1.Text);
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("designacao", Outros_BGP_VarText2.Text);

                if (Outros_BGP_VarText3.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", "peer VarHost as-number VarRemote\r\n peer VarHost description ** Cliente **\r\n ipv4-family unicast\r\n peer VarHost enable\r\n  peer VarHost allow-as-loop 10");
                    // ------------------------------------------------------------------------------------------------------------

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", Outros_BGP_VarText3.Text);

                    if (Outros_BGP_VarText4.Text != string.Empty)
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_BGP_VarText4.Text);
                    }
                    else
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", "");
                    }
                    if (Outros_BGP_VarText5.Text != string.Empty)
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPassword", "set password " + Outros_BGP_VarText5.Text);
                    }
                    else
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPassword", "");
                    }
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", "");
                }
            }
            else if (Outros_TypeComboBox.SelectedIndex == 3)    // Fortigate
            {
                Outros_FinalTextBox.Text = scripts[58].scriptString;

                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarAS", Outros_BGP_VarText0.Text);
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarIP", Outros_BGP_VarText1.Text);
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarCPE", GetBackboneInterfaceIP(Outros_BGP_VarText1.Text, false));
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("designacao", Outros_BGP_VarText2.Text);

                if (Outros_BGP_VarText3.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", "edit \"VarHost\"\r\nset allowas-in-enable enable\r\nset description \"** Cliente **\"\r\nset soft-reconfiguration enable\r\nset remote-as VarRemote\r\nVarPassword");
                    // ------------------------------------------------------------------------------------------------------------
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", Outros_BGP_VarText3.Text);

                    if (Outros_BGP_VarText4.Text != string.Empty)
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", Outros_BGP_VarText4.Text);
                    }
                    else
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarHost", "");
                    }
                    if (Outros_BGP_VarText5.Text != string.Empty)
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPassword", "set password " + Outros_BGP_VarText5.Text);
                    }
                    else
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPassword", "");
                    }
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRemote", "");
                }

            }
            else
            {
                Outros_FinalTextBox.Text = "";
            }
        }

        #endregion

        // ---------------------------
        // Regras Adicionais
        // ---------------------------
        #region
        public void OpenOutrosRegraAdc()
        {
            // UI
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 2;
            Outros_Title.Text = "Regra Adicional";
            outros = "regraAdc";

            Outros_SNMP_VarText0.Text = Script_VarText17.Text;
            Outros_SNMP_VarText0.Text = Script_VarText18.Text;

            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosRegraAdc()
        {
            int number = int.Parse(Outros_RegraAdc_NumDaRegraComboBox.SelectedIndex.ToString());

            if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
            {
                if (!Outros_RegraAdc_ISRCheckBox.Checked)
                {
                    Outros_FinalTextBox.Text = scripts[59].scriptString;
                }
                else                                     // Cisco ISR
                {
                    Outros_FinalTextBox.Text = scripts[60].scriptString;
                }

                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra0", (number + 12).ToString());

                int numberMult = number * 2;
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegraSaida0", numberMult.ToString());
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegraSaida1", (numberMult + 1).ToString());
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegraSaida2", (numberMult + 2).ToString());

                if (Outros_RegraAdc_VarText0.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("Var18", Outros_RegraAdc_VarText0.Text);
                }
                if (Outros_RegraAdc_VarText1.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("Var17", Outros_RegraAdc_VarText1.Text);
                }
                if (Outros_RegraAdc_VarText2.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarNovaRegra", Outros_RegraAdc_VarText2.Text);

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("regraMCDU", Outros_RegraAdc_VarText2.Text.Remove(0, 4));
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("regra4Digitos", Outros_RegraAdc_VarText2.Text.Remove(4));
                }
                if (Outros_RegraAdc_VarText3.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("portVoice", Outros_RegraAdc_VarText3.Text);
                }
            }
            if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
            {
                Outros_FinalTextBox.Text = scripts[61].scriptString;

                int numberMult = number * 2;
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegraSaida0", numberMult.ToString());
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegraSaida1", (numberMult + 1).ToString());
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegraSaida2", (numberMult + 2).ToString());
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegraSaida3", (numberMult + 2).ToString());

                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra0", (number + 12).ToString());
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra1", (number + 13).ToString());
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra2", (number + 14).ToString());

                if (Outros_RegraAdc_VarText0.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("Var18", Outros_RegraAdc_VarText0.Text);
                }
                if (Outros_RegraAdc_VarText1.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("Var17", Outros_RegraAdc_VarText1.Text);
                }
                if (Outros_RegraAdc_VarText2.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarNovaRegra", Outros_RegraAdc_VarText2.Text);

                    if (Outros_RegraAdc_VarText2.Text != string.Empty)
                    {
                        string regraSaida = Outros_RegraAdc_VarText2.Text;
                        int q = Outros_RegraAdc_VarText2.Text.Count(c => c == '-');

                        int p = 0;
                        string final = regraSaida;

                        if (q > 0)
                        {
                            // Remove cada digito de regra
                            for (int i = 1; i <= q; i++)
                            {
                                ++p;
                                final = final.Remove(final.Length - 5);
                            }

                            // Adiciona '.' para cada digito
                            for (int j = 1; j <= p; j++)
                            {
                                final += ".";
                            }
                        }

                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("SaidaRegra", final);

                        string saidaMCDU = final.Remove(0, 4);
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("SaidaMCDU", saidaMCDU);
                    }
                }
                if (Outros_RegraAdc_VarText3.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("portVoice", Outros_RegraAdc_VarText3.Text);
                }
            }
            if (Outros_TypeComboBox.SelectedIndex == 2)   // Huawei
            {
                MessageBox.Show("Regra Adicional não é suportada para Huawei");
            }
            if (Outros_TypeComboBox.SelectedIndex == 3)   // Fortigate
            {
                MessageBox.Show("Regra Adicional não é suportada para Fortigate");
            }
            if (Outros_TypeComboBox.SelectedIndex == 4)   // Aligera 561
            {

                if (!Outros_RegraAdc_AligeraCheckBox.Checked)
                {
                    Outros_FinalTextBox.Text = scripts[62].scriptString;

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra0", number.ToString());

                    int numberMulti = number * 3;
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra1", numberMulti.ToString());
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra2", (numberMulti + 1).ToString());
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra3", (numberMulti + 2).ToString());
                }
                else                                     // Aligera 1600/2000
                {
                    Outros_FinalTextBox.Text = scripts[63].scriptString;

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra0", number.ToString());

                    int numberMulti = number * 4;
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra1", numberMulti.ToString());
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra2", (numberMulti + 1).ToString());
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra3", (numberMulti + 2).ToString());
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("NumRegra4", (numberMulti + 3).ToString());
                }

                if (Outros_RegraAdc_VarText0.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("Var18", Outros_RegraAdc_VarText0.Text);
                }
                if (Outros_RegraAdc_VarText1.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("Var17", Outros_RegraAdc_VarText1.Text);
                }
                if (Outros_RegraAdc_VarText2.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarNovaRegra", Outros_RegraAdc_VarText2.Text);

                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("regraMCDU", Outros_RegraAdc_VarText2.Text.Remove(0, 4));
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("regra4Digitos", Outros_RegraAdc_VarText2.Text.Remove(4));
                }
            }
            if (Outros_TypeComboBox.SelectedIndex == 5)   // Digistar
            {
                string RegraAccounts = " ";

                Outros_FinalTextBox.Text = scripts[64].scriptString;

                if (Outros_RegraAdc_VarText0.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("Var18", Outros_RegraAdc_VarText0.Text);
                }
                if (Outros_RegraAdc_VarText1.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("Var17", Outros_RegraAdc_VarText1.Text);
                }
                if (Outros_RegraAdc_VarText2.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarNovaRegra", Outros_RegraAdc_VarText2.Text);

                    if (Outros_RegraAdc_VarText2.TextLength > 8)
                    {
                        // ---------------------------------------------------------------
                        // Get Number of Units used inside New Rule
                        int numeroUnid = Outros_RegraAdc_VarText2.Text.Count(c => c == ']');

                        // Check if Rule is Valid
                        if (numeroUnid == 0 || Outros_RegraAdc_VarText2.Text.Count(c => c == '[') == 0 || Outros_RegraAdc_VarText2.Text.Count(c => c == '-') == 0)
                        {
                            MessageBox.Show("Regra inválida. Verifique o formato da regra e tente novamente.");
                            return;
                        }

                        // Get new Rule
                        string novaRegra = Outros_RegraAdc_VarText2.Text;

                        // Remove "[ - ]" 
                        string regraInicial = novaRegra.Remove(novaRegra.Length - (5 * numeroUnid));
                        string regraFinal = regraInicial;

                        string ruleBloc = novaRegra;

                        // For each Unit... Set First and Final possible numbers
                        for (int j = 0; j < numeroUnid; j++)
                        {
                            // Get '[' position number
                            int position = ruleBloc.IndexOf('[');

                            // Remove characters before '['
                            ruleBloc = ruleBloc.Remove(0, position + 1);

                            // Set New Rule first and final possible numbers
                            regraInicial += ruleBloc[0];
                            regraFinal += ruleBloc[2];
                        }

                        // Get New Rule Total Length
                        int totalLength = int.Parse(regraFinal) - int.Parse(regraInicial);

                        number = int.Parse(Outros_RegraAdc_VarText4.Text);

                        // Loop for every possible number
                        // ------------------------------------------
                        for (int i = 1; i <= totalLength + 1; i++)
                        {
                            // Get Rule Number and the number of Rule
                            int regra = int.Parse(regraInicial) + (i - 1);
                            int accNumber = number + (i - 1);

                            // Config String
                            string account = "sip\r\n    account NumRegra0\r\n    user VarNovaRegra\r\n    no auth-user\r\n    no display-name\r\n    no contact\r\n    no restricted-id\r\n    allow - simult\r\n    server 1\r\n    !\r\n!\r\n";

                            // Replace Variables
                            account = account.Replace("NumRegra0", accNumber.ToString());
                            account = account.Replace("VarNovaRegra", regra.ToString());

                            // Add new Account to string
                            RegraAccounts += account;
                        }

                        // Add Accounts to Final String
                        // ------------------------------------------
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("RegraAccounts", RegraAccounts);
                    }
                    else if (Outros_RegraAdc_VarText2.TextLength == 8)
                    {
                        Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("RegraAccounts", "sip\r\n account 1\r\n    user " + Outros_RegraAdc_VarText2.Text + "\r\n    no auth-user\r\n    no display-name\r\n    no contact\r\n    no restricted-id\r\n    allow - simult\r\n    server 1\r\n    !\r\n!\r\n");
                    }
                    else
                    {
                        MessageBox.Show("Regra inválida. Verifique o campo Regras de Ramal e tente novamente.");
                    }
                }
            }
        }
        #endregion

        // ---------------------------
        // VLAN
        // ---------------------------
        #region
        public void OpenOutrosVLAN()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 5;
            Outros_Title.Text = "VLAN";
            outros = "vlan";

            FormatScriptOutrosDispatch(outros);
        }

        private void Outros_VLAN_FortigateButton_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 7;
            Outros_Title.Text = "Fortigate VLAN";
            outros = "fortiVlan";

            FormatScriptOutrosDispatch(outros);
            NotTested();
        }

        public void ApplytOutrosVLAN()
        {
            if (!Outros_VLAN_CatalystCheckBox.Checked && Outros_TypeComboBox.SelectedIndex != 0)
            {
                Outros_VLAN_CatalystCheckBox.Checked = false;
            }

            // -----------------------------------------------------------------
            if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
            {
                if (!Outros_VLAN_CatalystCheckBox.Checked)
                {
                    Outros_FinalTextBox.Text = scripts[65].scriptString;
                }
                else
                {
                    Outros_FinalTextBox.Text = scripts[66].scriptString;
                }
            }
            if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
            {
                Outros_FinalTextBox.Text = scripts[67].scriptString;
            }
            if (Outros_TypeComboBox.SelectedIndex == 2)   // Huawei
            {
                Outros_FinalTextBox.Text = scripts[68].scriptString;
            }
            if (Outros_TypeComboBox.SelectedIndex == 3)   // Fortigate
            {
                Outros_FinalTextBox.Text = scripts[69].scriptString;
            }

            mascaraVlan = ChangeMascaraLAN(Outros_VLAN_MascaraBox);

            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarIP", Outros_VLAN_VarText1.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarInterface", Outros_VLAN_VarText0.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("mascaraIP", mascaraVlan);
        }

        #endregion

        // ---------------------------
        // DHCP
        // ---------------------------
        #region
        public void OpenOutrosDHCP()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 4;
            Outros_Title.Text = "DHCP";
            outros = "dhcp";

            FormatScriptOutrosDispatch(outros);
        }

        public void ApplytOutrosDHCP()
        {
            mascaraDHCP = ChangeMascaraLAN(Outros_DHCP_MascaraBox);

            if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
            {
                Outros_FinalTextBox.Text = scripts[70].scriptString;

                // DHCP Relay
                if (Outros_DHCP_VarText8.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRelay", "conf t\r\n!\r\ninterface VarInterface\r\nip helper-address VarIpRelay\r\n!\r\n!\r\nend\r\n");
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRelay", "");
                }

                // Exclusão de IPs
                if (Outros_DHCP_VarText4.Text != string.Empty || Outros_DHCP_VarText5.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExclude", "!########Só adicionar se tiver range a ser excluido.#############\t\r\nip dhcp excluded-address VarExPrimeiro VarExUltimo\r\n!\r\n!");
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExclude", "");
                }
            }
            if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
            {
                Outros_FinalTextBox.Text = scripts[71].scriptString;

                // DHCP Relay
                if (Outros_DHCP_VarText8.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRelay", "sys\r\n!\r\ninterface VarInterface\r\ndhcp select relay\r\ndhcp relay server-address VarIpRelay\r\n#\r\n#\r\nreturn");
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRelay", "");
                }

                // Exclusão de IPs
                if (Outros_DHCP_VarText4.Text != string.Empty || Outros_DHCP_VarText5.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExclude", "######Só adicionar se tiver range a ser excluido.########\r\ndhcp server forbidden-ip VarExPrimeiro VarExUltimo\r\n#\r\n#");
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExclude", "");
                }
            }
            if (Outros_TypeComboBox.SelectedIndex == 2)   // Huawei
            {
                if (scripts[0].scriptString == "")
                {
                    MessageBox.Show("Não há Script DHCP para Huawei.");
                }
                Outros_FinalTextBox.Text = scripts[72].scriptString;
            }
            if (Outros_TypeComboBox.SelectedIndex == 3)   // Fortigate
            {
                Outros_FinalTextBox.Text = scripts[73].scriptString;

                // DHCP Relay
                if (Outros_DHCP_VarText8.Text != string.Empty)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRelay", "config system interface\r\nedit VarInterface\r\nset dhcp-relay-service enable\r\nset dhcp-relay-ip VarIpRelay\r\nset dhcp-relay-agent-option enable\r\nnext\r\nend");
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarRelay", "");
                }
            }

            // Apply Variables
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarIPGateway", Outros_DHCP_VarText1.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarIPNet", GetBackboneInterfaceIP(Outros_DHCP_VarText1.Text, true));
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("mascaraLAN", mascaraDHCP);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarInterface", Outros_DHCP_VarText0.Text);

            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPrimeiro", Outros_DHCP_VarText2.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarUltimo", Outros_DHCP_VarText3.Text);

            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarDNS1", Outros_DHCP_VarText6.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarDNS2", Outros_DHCP_VarText7.Text);

            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExPrimeiro", Outros_DHCP_VarText4.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExUltimo", Outros_DHCP_VarText5.Text);

            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarIpRelay", Outros_DHCP_VarText8.Text);

            // Dominio
            if (Outros_FinalTextBox.Text != string.Empty)
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarDominio", "" + Outros_DHCP_VarText9.Text);
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarDominio", "");
            }

        }
        #endregion

        // ---------------------------
        // USUARIO
        // ---------------------------
        #region
        public void OpenOutrosUSUARIOS()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 6;
            Outros_Title.Text = "USUARIOS";
            outros = "user";

            FormatScriptOutrosDispatch(outros);
        }

        public void ApplytOutrosUSUARIOS()
        {
            if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
            {
                Outros_FinalTextBox.Text = scripts[74].scriptString;

                if (Outros_User_VarPrivBox.SelectedIndex == 0)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPriv", "6");
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPriv", "10");
                }
            }
            if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
            {
                Outros_FinalTextBox.Text = scripts[75].scriptString;

                if (Outros_User_VarPrivBox.SelectedIndex == 0)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPriv", "authorization-attribute user-role network-operator");
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPriv", "authorization-attribute user-role network-admin");
                }
            }
            if (Outros_TypeComboBox.SelectedIndex == 2)   // Huawei
            {
                Outros_FinalTextBox.Text = scripts[76].scriptString;

                if (Outros_User_VarPrivBox.SelectedIndex == 0)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPriv", "2");
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPriv", "3");
                }
            }
            if (Outros_TypeComboBox.SelectedIndex == 3)   // Fortigate
            {
                Outros_FinalTextBox.Text = scripts[77].scriptString;

                if (Outros_User_VarPrivBox.SelectedIndex == 0)
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPriv", "set accprofile \"read_only\"");
                }
                else
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPriv", "set accprofile \"super_admin\"");
                }
            }

            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarName", Outros_User_VarText0.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarPassword", Outros_User_VarText1.Text);
        }

        #endregion

        // ---------------------------
        // IP FLOW
        // ---------------------------
        #region
        public void OpenOutrosIPFlow()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 9;
            Outros_Title.Text = "IP Flow";
            outros = "ipflow";

            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosIPFlow()
        {
            if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
            {
                if (!Outros_IPFlow_ISRCheckBox.Checked)
                {
                    Outros_FinalTextBox.Text = scripts[78].scriptString;
                }
                else
                {
                    Outros_FinalTextBox.Text = scripts[79].scriptString;
                }
            }
            else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
            {
                Outros_FinalTextBox.Text = scripts[80].scriptString;
            }
            else if (Outros_TypeComboBox.SelectedIndex == 2)   // Huawei
            {
                Outros_FinalTextBox.Text = scripts[81].scriptString;
                MessageBox.Show("Não há Script IP Flow para Huawei.");
            }
            else if (Outros_TypeComboBox.SelectedIndex == 3)   // Fortigate
            {
                Outros_FinalTextBox.Text = scripts[82].scriptString;
            }

            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarInterface", Outros_IPFlow_VarText0.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarIPDestino", Outros_IPFlow_VarText1.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarUDP", Outros_IPFlow_VarText2.Text);
        }
        #endregion

        // ---------------------------
        // Fortigate Extras
        // ---------------------------
        #region
        public void FortigateExtra()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 8;
            Outros_Title.Text = "Fortigate Extras";
            outros = "fortiExtras";

            FormatScriptOutrosDispatch(outros);
        }
        #endregion

        // ---------------------------
        // RIP
        // ---------------------------
        #region
        public void OpenOutrosRIP()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 10;
            Outros_Title.Text = "RIP";
            outros = "rip";
            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosRIP()
        {

        }

        #endregion

        // ---------------------------
        // OSPF
        // ---------------------------
        #region
        public void OpenOutrosOSPF()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 11;
            Outros_Title.Text = "OSPF";
            outros = "ospf";
            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosOSPF()
        {

        }

        #endregion

        // ---------------------------
        // VRRP
        // ---------------------------
        #region
        public void OpenOutrosVRRP()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 12;
            Outros_Title.Text = "VRRP";
            outros = "vrrp";
            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosVRRP()
        {

        }

        #endregion

        // ---------------------------
        // GLBP
        // ---------------------------
        #region
        public void OpenOutrosGLBP()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 13;
            Outros_Title.Text = "GLBP";
            outros = "glbp";
            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosGLBP()
        {
        }

        #endregion

        // ---------------------------
        // HSRP
        // ---------------------------
        #region
        public void OpenOutrosHSRP()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 16;
            Outros_Title.Text = "HSRP";
            outros = "hsrp";
            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosHSRP()
        {

        }

        #endregion

        // ---------------------------
        // EIGRP
        // ---------------------------
        #region
        public void OpenOutrosEIGRP()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 14;
            Outros_Title.Text = "EIGRP";
            outros = "eigrp";
            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosEIGRP()
        {

        }

        #endregion

        // ---------------------------
        // HOTLINE
        // ---------------------------
        #region
        public void OpenOutrosHotline()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 15;
            Outros_Title.Text = "Hotline";
            outros = "hotline";
            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosHotline()
        {

        }

        #endregion

        // ---------------------------
        // Bloqueio de Portas
        // ---------------------------
        #region
        public void OpenOutrosBlockPort()
        {
            tabControl2.SelectedTab = tabOutros;
            TabSubOutros.SelectedIndex = 17;
            Outros_Title.Text = "Bloqueio de Portas";
            outros = "blockPort";

            Outros_PortBlock_TextBox0.Text = Script_VarText03.Text;
            Outros_PortBlock_TextBox1.Text = Script_VarText08.Text;
            Outros_PortBlock_TextBox2.Text = Script_VarText09.Text;

            FormatScriptOutrosDispatch(outros);
        }

        public void ApplyOutrosBlockPort()
        {
            if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
            {
                Outros_FinalTextBox.Text = scripts[83].scriptString;
            }
            else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
            {
                if (!Outros_PortBlock_HPEold.Checked)
                {
                    Outros_FinalTextBox.Text = scripts[84].scriptString;
                }
            }
            else if (Outros_TypeComboBox.SelectedIndex == 2)   // Huawei
            {
                MessageBox.Show("Não há Script de Bloqueio de Portas para Huawei.");
                Outros_FinalTextBox.Text = "";
            }
            else if (Outros_TypeComboBox.SelectedIndex == 3)   // Fortigate
            {
                MessageBox.Show("Não há Script de Bloqueio de Portas para Fortigate.");
                Outros_FinalTextBox.Text = "";
            }
            if (Outros_PortBlock_HPEold.Checked)   // HPE Old
            {
                Outros_FinalTextBox.Text = scripts[85].scriptString;
            }

            // Interface + IPs
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarInterface", Outros_PortBlock_TextBox0.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarIPwan", Outros_PortBlock_TextBox1.Text);
            Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarIPLan", Outros_PortBlock_TextBox2.Text);

            // SSH Server
            if (Outros_PortBLock_ComboBox2.SelectedIndex == 1)
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("sshServer", "#");
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("sshServer", "undo ssh server enable\r\nundo ssh server acl 3000\r\n");
            }

            // Portas
            #region
            if (Outros_PortBLock_ComboBox0.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANftpData", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq ftp-data\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq ftp-data\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANftpData", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq ftp-data\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq ftp-data\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANftpData", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq ftp-data\r\n"
                        + "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq ftp-data\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANftpData", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq ftp-data\r\n"
                        + "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq ftp-data\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANftpData", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANftpData", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox1.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANftpLog", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq ftp\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq ftp\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANftpLog", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq ftp\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq ftp\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANftpLog", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq ftp\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq ftp\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANftpLog", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq ftp\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq ftp\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANftpLog", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANftpLog", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox2.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANssh", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq 22 logging\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq 22 logging\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANssh", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq 22 logging\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq 22 logging\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANssh", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 22 logging\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 22 logging\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANssh", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 22 logging\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 22 logging\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANssh", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANssh", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox3.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANdns", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq dns\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq dns\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANdns", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq dns\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq dns\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANdns", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq dns\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq dns\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANdns", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq dns\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq dns\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANdns", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANdns", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox4.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANbootps", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq bootps\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq bootps\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANbootps", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq bootps\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq bootps\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANbootps", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq bootps\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq bootps\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANbootps", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq bootps\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq bootps\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANbootps", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANbootps", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox5.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANbootpc", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq bootpc\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq bootpc\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANbootpc", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq bootpc\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq bootpc\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANbootpc", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq bootpc\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq bootpc\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANbootpc", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq bootpc\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq bootpc\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANbootpc", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANbootpc", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox6.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANtftp", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq tftp\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq tftp\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANtftp", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq tftp\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq tftp\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANtftp", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq tftp\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq tftp\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANtftp", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq tftp\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq tftp\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANtftp", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANtftp", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox7.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANwww", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq www\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq 80\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANwww", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq www\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq 80\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANwww", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq www\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 80\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANwww", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq www\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 80\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANwww", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANwww", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox8.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANntp", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq 123\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq ntp\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANntp", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq 123\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq ntp\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANntp", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 123\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq ntp\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANntp", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 123\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq ntp\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANntp", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANntp", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox9.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANsnmp", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq 161\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq snmp\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANsnmp", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq 161\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq snmp\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANsnmp", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 161\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq snmp\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANsnmp", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 161\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq snmp\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANsnmp", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANsnmp", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox10.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANtrap", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq 162\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq snmptrap\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANtrap", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq 162\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq snmptrap\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANtrap", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 162\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq snmptrap\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANtrap", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 162\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq snmptrap\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANtrap", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANtrap", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox11.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN442", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq 442\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq 442\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN442", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq 442\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq 442\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN442t", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 442\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 442\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN442t", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 442\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 442\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN442t", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN442t", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox12.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN443t", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq 443\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq 443\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN443t", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq 443\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq 443\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN443t", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 443\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 443\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN443t", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 443\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 443\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN443t", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN443t", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox13.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANcmd", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq syslog\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq syslog\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANcmd", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq syslog\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq syslog\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANcmd", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq syslog\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq syslog\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANcmd", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq syslog\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq syslog\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANcmd", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANcmd", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox14.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN4422", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq 4422\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq 4422\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN4422", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq 4422\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq 4422\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN4422", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 4422\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 4422\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN4422", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 4422\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 4422\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN4422", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN4422", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox15.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN4433", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq 4433\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq 4433\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN4433", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq 4433\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq 4433\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN4433", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 4433\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 4433\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN4433", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 4433\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 4433\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWAN4433", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLAN4433", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBLock_ComboBox16.SelectedIndex == 0)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANdhcp", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq 647\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq 647\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANdhcp", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq 647\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq 647\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANdhcp", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 647\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq 647\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANdhcp", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 647\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq 647\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarWANdhcp", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarLANdhcp", "");
            }
            // ------------------------------------------------------------------------------------------------------------------
            if (Outros_PortBlock_TextBox3.Text != string.Empty)
            {
                if (Outros_TypeComboBox.SelectedIndex == 0)   // Cisco
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExtraWAN", "deny tcp any host " + Outros_PortBlock_TextBox1.Text + " eq " + Outros_PortBlock_TextBox3.Text + "\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox1.Text + " eq " + Outros_PortBlock_TextBox3.Text + "\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExtraLAN", "deny tcp any host " + Outros_PortBlock_TextBox2.Text + " eq " + Outros_PortBlock_TextBox3.Text + "\r\n"
                        + "deny udp any host " + Outros_PortBlock_TextBox2.Text + " eq " + Outros_PortBlock_TextBox3.Text + "\r\n");
                }
                else if (Outros_TypeComboBox.SelectedIndex == 1)   // HPE
                {
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExtraWAN", "rule deny tcp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq " + Outros_PortBlock_TextBox3.Text + "\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox1.Text + " 0 destination-port eq " + Outros_PortBlock_TextBox3.Text + "\r\n");
                    Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExtraLAN", "rule deny tcp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq " + Outros_PortBlock_TextBox3.Text + "\r\n"
                        + "rule deny udp source any destination " + Outros_PortBlock_TextBox2.Text + " 0 destination-port eq " + Outros_PortBlock_TextBox3.Text + "\r\n");
                }
            }
            else
            {
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExtraWAN", "");
                Outros_FinalTextBox.Text = Outros_FinalTextBox.Text.Replace("VarExtraLAN", "");
            }
            #endregion
        }
        #endregion

        // -----------------------------------------------------

        // ---------------------------
        // UI Buttons
        // ---------------------------
        #region
        public void FormatScriptOutrosDispatch(string type)
        {
            Debug.Write("Script - " + outros + " - Aplicado");

            try
            {
                if (type == "snmp")
                {
                    ApplytOutrosSNMP();
                }
                if (type == "bgp")
                {
                    ApplyOutrosBGP();
                }
                if (type == "qos")
                {
                    ApplyOutrosQoS();
                }
                if (type == "regraAdc")
                {
                    ApplyOutrosRegraAdc();
                }
                if (type == "vlan")
                {
                    ApplytOutrosVLAN();
                }
                if (type == "dhcp")
                {
                    ApplytOutrosDHCP();
                }
                if (type == "user")
                {
                    ApplytOutrosUSUARIOS();
                }
                if (type == "vrrp")
                {
                    ApplyOutrosVRRP();
                }
                if (type == "blockPort")
                {
                    ApplyOutrosBlockPort();
                }
                else
                {
                    Debug.Write("Tipo de script não reconhecido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao Formatar Script do " + outros + " --> " + ex);
                Debug.Write("Falha ao Formatar. Script " + outros + ". \r\n\r\nErro --> " + ex);
            }
        }

        private void Outros_VarDelete0_Click(object sender, EventArgs e)
        {
            Outros_SNMP_VarText0.Text = string.Empty;
        }

        private void Outros_VarDelete1_Click(object sender, EventArgs e)
        {
            Outros_SNMP_VarText1.Text = string.Empty;
        }

        private void Outros_VarDeleteAll_Click(object sender, EventArgs e)
        {
            Outros_SNMP_VarText0.Text = string.Empty;
            Outros_SNMP_VarText1.Text = string.Empty;
            Outros_SNMP_VarPrivComboBox.SelectedIndex = 0;
        }

        private void Outros_TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatScriptOutrosDispatch(outros);
        }

        private void Outros_ButtonForCopy_Click(object sender, EventArgs e)
        {
            FormatScriptOutrosDispatch(outros);
            Clipboard.SetText(Outros_FinalTextBox.Text);
        }

        private void Outros_ButtonFormat_Click(object sender, EventArgs e)
        {
            FormatScriptOutrosDispatch(outros);
        }

        private void Outros_ButtonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Outros_FinalTextBox.Text);
        }
        private void HomeButton_Outros_Click(object sender, EventArgs e)
        {
            HomeButton_Script_Click(sender, e);
        }
        private void Outros_VarTextQoS00_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyOutrosQoS();
            }
        }

        private void Outros_VarDeleteQoS0_Click(object sender, EventArgs e)
        {
            Outros_QoS_VarText01.Text = string.Empty;
            Outros_QoS_VarTextShow1.Text = string.Empty;
        }
        private void Outros_VarDeleteQoS1_Click(object sender, EventArgs e)
        {
            Outros_QoS_VarText02.Text = string.Empty;
            Outros_QoS_VarTextShow2.Text = string.Empty;
        }
        private void Outros_VarDeleteQoS2_Click(object sender, EventArgs e)
        {
            Outros_QoS_VarText03.Text = string.Empty;
            Outros_QoS_VarTextShow3.Text = string.Empty;
        }
        private void Outros_VarDeleteQoS3_Click(object sender, EventArgs e)
        {
            Outros_QoS_VarText04.Text = string.Empty;
            Outros_QoS_VarTextShow4.Text = string.Empty;
        }
        private void Outros_VarDeleteQoS4_Click(object sender, EventArgs e)
        {
            Outros_QoS_VarText05.Text = string.Empty;
            Outros_QoS_VarTextShow5.Text = string.Empty;
        }
        private void Outros_VarDeleteQoS5_Click(object sender, EventArgs e)
        {
            Outros_QoS_VarText06.Text = string.Empty;
            Outros_QoS_VarTextShow6.Text = string.Empty;
        }
        private void Outros_VarDeleteQoS6_Click(object sender, EventArgs e)
        {
            Outros_QoS_VarText07.Text = string.Empty;
            Outros_QoS_VarTextShow7.Text = string.Empty;
        }
        private void Outros_VarDeleteQoS7_Click(object sender, EventArgs e)
        {
            Outros_QoS_VarText08.Text = string.Empty;
        }
        private void Outros_VarDeleteQoS8_Click(object sender, EventArgs e)
        {
            Outros_QoS_VarText09.Text = string.Empty;
        }

        #endregion

        // ---------------------------------------------------------------------------
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // --------------------------- PREFERENCES -----------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        // ---------------------------
        // Buttons
        // ---------------------------
        private void Password_Click(object sender, EventArgs e)
        {
            FormPassword passwordForm = new FormPassword(this);
            passwordForm.Show();
        }

        private void OpenPE_Button_Click(object sender, EventArgs e)
        {
            if (OpenPE_ComboBox.SelectedIndex != 0 || OpenPE_ComboBox.Text != "Nenhum PE")
            {
                Automation.OpenPE(OpenPE_ComboBox.Text, userPE, puttyPath);
            }
            else
            {
                MessageBox.Show("Selecione um PE para abrir.");
            }
        }

        private void Pref_Putty_SaveButton_Click(object sender, EventArgs e)
        {
            SaveUserPE(Pref_User_NameTextBox.Text, Pref_User_PasswordTextBox.Text);
            SaveUserTACACS(Pref_TACACS_UserTextBox.Text, Pref_TACACS_PasswordTextBox.Text);
            SavePuttyPath(SetPuttyPath(Pref_Putty_PathTextBox.Text));
            LoadPrefs();
        }

        public string SetPuttyPath(string path)
        {
            if (path.Length > 9)
            {
                string check = path.Remove(0, path.Length - 9);
    
                if (check == "putty.exe" || check == "PUTTY.exe")
                {
                    return path;
                }
                else
                {
                    MessageBox.Show("O caminho selecionado não é o executável do Putty. Selecione o arquivo putty.exe para salvar o caminho.");
                    return "";
                }
            }
            // -----------
            return path;
        }

        private void Pref_Putty_SearchButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new CommonOpenFileDialog())
            {
                dialog.Title = "Select the folder where Putty is located";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.Filters.Add(new CommonFileDialogFilter("Executable Files", "*.exe"));

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    // Do something with the selected folder path
                    string selectedPath = dialog.FileName;
                    Pref_Putty_PathTextBox.Text = SetPuttyPath(selectedPath);
                }
            }
        }

        // ---------------------------
        // Functions
        // ---------------------------
        public void SaveUserPE(string name, string password)
        {
            string final = name + "\r\n" + password;

            Properties.Settings.Default.userPE = final;
            Properties.Settings.Default.Save();

            Pref_User_NameTextBox.Text = name;
            Pref_User_PasswordTextBox.Text = password;
        }

        public void SaveUserTACACS(string name, string password)
        {
            string final = name + "\r\n" + password;

            Properties.Settings.Default.userTacacs = final;
            Properties.Settings.Default.Save();

            Pref_TACACS_UserTextBox.Text = name;
            Pref_TACACS_PasswordTextBox.Text = password;
        }

        public void SavePuttyPath(string path)
        {
            Properties.Settings.Default.puttyPath = path;
            Properties.Settings.Default.Save();

            Pref_Putty_PathTextBox.Text = Properties.Settings.Default.puttyPath;
        }

        public void LoadPrefs()
        {
            userPE = Properties.Settings.Default.userPE;
            userTacacs = Properties.Settings.Default.userTacacs;
            puttyPath = Properties.Settings.Default.puttyPath;

            if (userPE != "")
            {
                string[] userPESplit = userPE.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                Pref_User_NameTextBox.Text = userPESplit[0];
                Pref_User_PasswordTextBox.Text = userPESplit[1];
            }

            if (userTacacs != "")
            {
                string[] userTacacsSplit = userTacacs.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                Pref_TACACS_UserTextBox.Text = userTacacsSplit[0];
                Pref_TACACS_PasswordTextBox.Text = userTacacsSplit[1];
            }

            Pref_Putty_PathTextBox.Text = puttyPath;
        }

        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ----------------------------- CLIENTES ------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        #region
        public void OpenClient(Client Client)
        {
            tabControl2.SelectedTab = tabClient;

            Client_NameTitle.Text = Client.name;

            step = 0;
            usingClient = Client;
            try
            {
                OpenClientStep(Client.steps[step]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }


            if (usingClient.criticality)
            {
                Client_CriticalyLabel.Show();
            }
            else
            {
                Client_CriticalyLabel.Hide();
            }

            CheckSteps();
        }

        public void CheckSteps()
        {
            if (step == 0)
            {
                Client_BackStep.Hide();
            }
            else
            {
                Client_BackStep.Show();
            }
            if (step >= (usingClient.steps.Count - 1))
            {
                Client_NextStep.Hide();
            }
            else
            {
                Client_NextStep.Show();
            }
        }

        public void AllClientsButtonBuilder()
        {
            int h = 100;
            int w = 100;

            foreach (Client c in clients)
            {
                h += 50;
                if (h > 400)
                {
                    w += 150;
                    h = 150;
                }

                Button button = new Button
                {
                    Name = "ButtonClient_" + c.name,
                    Text = c.name,
                    Size = new Size(150, 40),
                    Location = new System.Drawing.Point(w, h)
                };

                // ------ Night Mode ------
                if (nightMode)
                {
                    button.BackColor = Color.FromArgb(30, 27, 27);
                    button.ForeColor = Color.White;
                }
                else
                {
                    button.BackColor = SystemColors.Control;
                    button.ForeColor = SystemColors.ControlText;
                }

                this.tabSelectClient.Controls.Add(button);

                button.Click += new EventHandler(OpenClickClient);
            }
        }

        public void ApplyStepScript()
        {
            foreach (TextBox t in clientVarText)
            {
                if (t.Text != string.Empty)
                {
                    string name = t.Name.Replace("Client_", "");
                    name = name.Replace("Text", "");
                    Client_StepScript.Text = Client_StepScript.Text.Replace(name, t.Text);
                }
            }
        }

        // ---------------------------
        // Steps UI Build
        // ---------------------------
        #region
        public void OpenClientStep(Step selectedStep)
        {
            DeleteAllClientVar();

            if (selectedStep.image == null)
            {
                MessageBox.Show("has no image");
            }

            Client_StepPicture.Image = selectedStep.image;
            Client_StepPicture.SizeMode = PictureBoxSizeMode.Zoom;
            Client_StepText.Text = selectedStep.text;
            Client_StepScript.Text = selectedStep.script.scriptString;


            // Check if has Restore
            if (usingClient.steps[0].restore)
            {
                Client_ButtonRestore.Show();
            }
            else
            {
                Client_ButtonRestore.Hide();
            }

            // Check if has Script
            if (selectedStep.script.scriptString == string.Empty)
            {
                Client_StepScript.Hide();
                Client_ButtonCopy.Hide();
                Client_ButtonFormat.Hide();
                Client_ButtonCopyForm.Hide();
                Client_ButtonRestore.Hide();

                CloseAllClientVar();
            }
            else
            {
                Client_StepScript.Show();
                Client_ButtonCopy.Show();
                Client_ButtonFormat.Show();
                Client_ButtonCopyForm.Show();
                Client_ButtonRestore.Show();

                BuildClientVarUI(selectedStep.script.variables, selectedStep.script.variableNames);
            }

        }


        public void BuildClientVarUI(string variableNumber, string variableNames)
        {
            string[] split = variableNumber.Split(',');

            // Clear Variable Name
            for (int i = 0; i <= split.Length - 1; i++)
            {
                split[i] = split[i].Replace("Client_VarText", "");
            }

            int anterior = 99;

            for (int i = 0; i < clientVarName.Count; i++)
            {
                foreach (string s in split)
                {
                    if (clientVarName[i].Name.Contains(s))
                    {
                        clientVarName[i].Show();

                        if (anterior == 99)
                        {
                            clientVarName[i].Location = new System.Drawing.Point(clientVarName[i].Location.X, 152);
                        }
                        else
                        {
                            clientVarName[i].Location = new System.Drawing.Point(clientVarName[i].Location.X, clientVarName[anterior].Location.Y + 30);
                        }

                        anterior = i;
                        break;
                    }
                    else
                    {
                        clientVarName[i].Hide();
                    }
                }
            }

            anterior = 99;

            for (int i = 0; i < clientVarText.Count; i++)
            {
                foreach (string s in split)
                {
                    if (clientVarText[i].Name.Contains(s))
                    {
                        clientVarText[i].Show();
                        if (s == "09")
                        {
                            // Client_LANMascaraBox.Location = new System.Drawing.Point(258, clientVarText[anterior].Location.Y + 30);
                        }
                        if (anterior == 99)
                        {
                            clientVarText[i].Location = new System.Drawing.Point(clientVarText[i].Location.X, 150);
                        }
                        else
                        {
                            clientVarText[i].Location = new System.Drawing.Point(clientVarText[i].Location.X, clientVarText[anterior].Location.Y + 30);
                        }

                        anterior = i;
                        break;
                    }
                    else
                    {
                        clientVarText[i].Hide();
                    }
                }
            }

            anterior = 99;

            for (int i = 0; i < clientVarDelete.Count; i++)
            {
                foreach (string s in split)
                {
                    if (clientVarDelete[i].Name.Contains(s))
                    {
                        clientVarDelete[i].Show();
                        if (anterior == 99)
                        {
                            clientVarDelete[i].Location = new System.Drawing.Point(clientVarDelete[i].Location.X, 150);
                        }
                        else
                        {
                            clientVarDelete[i].Location = new System.Drawing.Point(clientVarDelete[i].Location.X, clientVarDelete[anterior].Location.Y + 30);
                        }

                        anterior = i;
                        break;
                    }
                    else
                    {
                        clientVarDelete[i].Hide();
                    }
                }
            }

            ChangeClientVarNames(variableNames);

        }

        public void ChangeClientVarNames(string names)
        {
            string[] split = names.Split(',');

            int i = 0;
            foreach (string s in split)
            {
                clientVarName[i].Text = split[i];
                i = ++i;
            }
        }

        public void CloseAllClientVar()
        {
            Client_VarSubTitle.Hide();
            Client_ButtonDeleteAll.Hide();
            Client_ExSubTitle.Hide();

            foreach (Label l in clientVarName)
            {
                l.Hide();
            }
            foreach (TextBox t in clientVarText)
            {
                t.Hide();
            }
            foreach (Button b in clientVarDelete)
            {
                b.Hide();
            }
            foreach (Label l in clientVarEx)
            {
                l.Hide();
            }
        }

        #endregion

        // ---------------------------
        // UI Buttons
        // ---------------------------
        #region
        private void Client_Restore_Click(object sender, EventArgs e)
        {
            string contentToSave = Client_StepScript.Text;
            string filePath = @"C:\Users\Z410854\OneDrive - HITSS DO BRASIL SERVIÇOS TECNOLOGICOS LTDA\Área de Trabalho";
            //string filePath = @"C:\Users\Ricardo";

            try
            {
                // +usingClient.name + ".conf"
                File.WriteAllText(filePath, contentToSave);

                MessageBox.Show("Restore salvo na Área de Trabalho");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
            }
        }

        private void Client_NextStep_Click(object sender, EventArgs e)
        {
            step = ++step;
            OpenClientStep(usingClient.steps[step]);

            CheckSteps();
        }

        private void Client_BackStep_Click(object sender, EventArgs e)
        {
            step = --step;
            OpenClientStep(usingClient.steps[step]);

            CheckSteps();
        }

        private void Client_ButtonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Client_StepScript.Text);
        }

        private void Client_ButtonFormat_Click(object sender, EventArgs e)
        {
            ApplyStepScript();
        }

        private void Client_ButtonCopyForm_Click(object sender, EventArgs e)
        {
            ApplyStepScript();
            Clipboard.SetText(Client_StepScript.Text);
        }

        private void BackButton_ClientSteps_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabSelectClient;
        }
        private void Client_TesteClient_Click(object sender, EventArgs e)
        {
            OpenClient(clients[0]);
        }

        private void Client_NovoButton_Click(object sender, EventArgs e)
        {
            FormNewClient newClientForm = new FormNewClient(this, clients.Count - 1);
            newClientForm.Show();
        }

        private void Client_DeleteAll_Click(object sender, EventArgs e)
        {
            DeleteAllClientVar();

        }
        public void DeleteAllClientVar()
        {
            Client_VarText00.Text = string.Empty;
            Client_VarText01.Text = string.Empty;
            Client_VarText02.Text = string.Empty;
            Client_VarText03.Text = string.Empty;
            Client_VarText04.Text = string.Empty;
            Client_VarText05.Text = string.Empty;
            Client_VarText06.Text = string.Empty;
            Client_VarText07.Text = string.Empty;
            Client_VarText08.Text = string.Empty;
            Client_VarText09.Text = string.Empty;
        }
        private void Client_VarDelete00_Click(object sender, EventArgs e)
        {
            Client_VarText00.Text = string.Empty;
        }
        private void Client_VarDelete01_Click(object sender, EventArgs e)
        {
            Client_VarText01.Text = string.Empty;
        }
        private void Client_VarDelete02_Click(object sender, EventArgs e)
        {
            Client_VarText02.Text = string.Empty;
        }
        private void Client_VarDelete03_Click(object sender, EventArgs e)
        {
            Client_VarText03.Text = string.Empty;
        }
        private void Client_VarDelete04_Click(object sender, EventArgs e)
        {
            Client_VarText04.Text = string.Empty;
        }
        private void Client_VarDelete05_Click(object sender, EventArgs e)
        {
            Client_VarText05.Text = string.Empty;
        }
        private void Client_VarDelete06_Click(object sender, EventArgs e)
        {
            Client_VarText06.Text = string.Empty;
        }
        private void Client_VarDelete07_Click(object sender, EventArgs e)
        {
            Client_VarText07.Text = string.Empty;
        }
        private void Client_VarDelete08_Click(object sender, EventArgs e)
        {
            Client_VarText08.Text = string.Empty;
        }
        private void Client_VarDelete09_Click(object sender, EventArgs e)
        {
            Client_VarText09.Text = string.Empty;
        }
        #endregion

        // ---------------------------------------------------------------------------
        #endregion


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ------------------------------- MISC --------------------------------------
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
        // Night Mode
        // -------------------------------
        private void Button_DarkMode_Click(object sender, EventArgs e)
        {
            SwitchNightMode();
        }

        public void SwitchNightMode()
        {
            nightMode = !nightMode;
            ApplyNightMode(this, nightMode);

            Properties.Settings.Default.nightMode = nightMode;
            Properties.Settings.Default.Save();
        }

        public void ApplyNightMode(Control ctr, bool darkMode)
        {
            Button_NightMode.Text = nightMode ? "Light Mode" : "Night Mode";

            if (darkMode)
            {
                // ------ DARK THEME ------
                if (!ctr.Name.Contains("MainTitle") || !ctr.Name.Contains("TemplatesLabel") || !ctr.Name.Contains("Home"))
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
                        IOS_DataGrid_Routers.DefaultCellStyle.BackColor = Color.FromArgb(30, 27, 27);
                        IOS_DataGrid_Routers.DefaultCellStyle.ForeColor = Color.White;
                    }
                    if (ctr.Name.Contains("ImageLogo"))
                    {
                        ImageLogo.Image = Properties.Resources.logo_hitss_white;
                    }
                }
                if (ctr.Name.Contains("tab"))
                {
                    //ctr.BackColor = Color.Black;
                    //ctr.ForeColor = Color.Black;
                }

                if (ctr.Name.Contains("Row"))
                {
                    ctr.BackColor = Color.LightGray;
                }
            }
            else
            {
                // ------ LIGHT THEME -----
                if (!ctr.Name.Contains("MainTitle") || !ctr.Name.Contains("TemplatesLabel") || !ctr.Name.Contains("HomeButton"))
                {
                    ctr.BackColor = SystemColors.Control;
                    ctr.ForeColor = SystemColors.ControlText;
                }
                if (ctr.Name.Contains("Text") || ctr.Name.Contains("Box"))
                {
                    ctr.BackColor = Color.White;
                    ctr.ForeColor = SystemColors.ControlText;
                }
                if (ctr.Name == "DataGridRouters")
                {
                    IOS_DataGrid_Routers.DefaultCellStyle.BackColor = Color.White;
                    IOS_DataGrid_Routers.DefaultCellStyle.ForeColor = Color.Black;
                }
                if (ctr.Name.Contains("ImageLogo"))
                {
                    ImageLogo.Image = Properties.Resources.logo_hitss_black;
                }
                if (ctr.Name.Contains("tabSelectRouter"))
                {
                    ctr.BackColor = SystemColors.Control;
                }
            }

            if (ctr.Name.Contains("Row"))
            {
                ctr.BackColor = Color.Gray;
            }

            if (ctr.Name.Contains("BackButton"))
            {
                ctr.BackColor = Color.DodgerBlue;
                ctr.ForeColor = Color.White;

            }
            if (ctr.Name.Contains("MainTitle"))
            {
                ctr.BackColor = Color.FromArgb(255, 212, 0, 0);
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
                MessageBox.Show("Habilite a opção de Editar para acessar o Editor de Scripts.");
            }
        }

        public void EnableImportSAIP()
        {
            canImportSAIP = true;
            Properties.Settings.Default.canImportSAIP = canImportSAIP;
            Properties.Settings.Default.Save();
            CheckCanImportFromSAIP();
        }

        public void EnableEditing()
        {
            EnableImportSAIP();
            enableEdit = true;
            Properties.Settings.Default.enableEdit = enableEdit;
            Properties.Settings.Default.Save();
        }

        // -------------------------------
        // Open PE - Automação
        // -------------------------------
        public void OpenPE(string pe)
        {
            Debug.WriteLine("\r\n--> Opening PE...");

            // Block if PE User is empty
            if (userPE == "" || userPE == string.Empty)
            {
                MessageBox.Show("Usuário e senha do PE não configurados. Acesse as Preferências para configurar.");
                return;
            }

            try
            {
                Process p = Process.Start(puttyPath);

                Thread.Sleep(300);

                // Colando nome do PE
                Clipboard.SetText(pe);
                SendKeys.Send("^v");
                SendKeys.SendWait("{ENTER}");

                Thread.Sleep(500);

                // Colando Senha para acessar o CPE
                Clipboard.SetText(userPE + "\r\n \r\n \r\n \r\n \r\n \r\n \r\n");

                SendKeys.SendWait("+{INSERT}");

                Debug.WriteLine("\r\n... PE Opened!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\r\n Error: \r\n" + ex.Message);
                MessageBox.Show("Falha ao Abrir o PE. Erro: --> " + ex.Message);
            }
        }

        private void Button_IOS_Click(object sender, EventArgs e)
        {
            FormDebug debugForm = new FormDebug("-----------------------------------------\r\nCPE\r\n-----------------------------------------\r\n1) COPIANDO A IOS\r\n\r\nVIA TFTP\r\nConfigurar uma interface vaga no roteador com um IP qualquer (Ex: 10.10.10.10/24) e solicitar ao técnico que configure seu notebook no mesmo range (Ex: 10.10.10.11/24)\r\nInserir o comando: COPY TFTP FLASH\r\nNa sequencia: Address or name of remote host? <Inserir IP da máquina do técnico>\r\nSource filename: <Inserir o nome do arquivo da IOS> \" (Ex: c1900-universalK9-mz.SPA.152-1.T3.bin)\r\nDestination filename <Pressionar Enter>\r\nSe a licença não estiver com problemas e for copiada com sucesso, receberá a seguinte mensagem:\r\nAccessing tftp://10.149.59.2/c1900-universalK9-mz.SPA.152-1.T3.bin...\r\nLoading c1900-universalK9-mz.SPA.152-1.T3.bin from 10.149.59.2 (via GigabitEthernet0/0): !\r\n[OK - 1159 bytes]\r\n1159 bytes copied in 0.716 secs (1619 bytes/sec)\r\n\r\n\r\nVIA USB\r\nPedir para o técnico inserir o pendrive no roteador (podemos monitorar se o dispositivo foi reconhecido inserindo \"terminal monitor\" na linha de comando)\r\nApós o reconhecimento do dispositivo, inserir o comando DIR ? Para vermos a nomenclatura usada no CPE para o pendrive (EX: usbflash1:)\r\nReconhecido o nome da pendrive, inserir o comando: COPY USBFLASH1: FLASH\r\nSource filename: <Inserir o nome do arquivo da IOS> (Ex: c1900-universalK9-mz.SPA.152-1.T3.bin)\r\nDestination filename <Pressionar Enter>\r\n\r\n2) INSTALANDO A IOS\r\nApós copiar a IOS, inserir o seguinte comando dentro do modo de configuração (conf t):\r\nboot system flash <nome_do_arquivo_.bin> (Ex: c1900-universalK9-mz.SPA.152-1.T3.bin)\r\nApós inserir o comando, salvar com WR e reiniciar o roteador\r\n\r\n\r\n-----------------------------------------\r\nHPE\r\n-----------------------------------------\r\n\r\n1) COPIANDO A IOS\r\n\r\nVIA TFTP\r\nConfigurar uma interface vaga no roteador com um IP qualquer (Ex: 10.10.10.10/24) e solicitar ao técnico que configure seu notebook no mesmo range (Ex: 10.10.10.11/24)\r\nInserir o comando: tftp <TFTP server IP> get <file> <Destination filename>\r\n\r\nVIA USB\r\nPedir para o técnico inserir o pendrive no roteador (podemos monitorar se o dispositivo foi reconhecido inserindo \"terminal monitor\" na linha de comando)\r\nApós o reconhecimento do dispositivo, inserir o comando DIR ? Para vermos a nomenclatura usada no CPE para o pendrive (EX: usbflash1:)\r\nReconhecido o nome da pendrive, inserir o comando: COPY USBFLASH1:/<Nome do arquivo> FLASH:\r\n\r\n2) INSTALANDO A IOS\r\n\r\nApós copiar a IOS, inserir o seguinte comando:\r\nboot-loader file <Nome_do_arquivo>  main (Ex: a_msr30-cmw520-r2207-si.bin)\r\nApós inserir o comando, salvar com SAVE e reiniciar o roteador\r\n\r\nOBS:\r\nExistem casos onde temos que atualizar a IOS e o HP não possui memória suficiente para carregar uma nova IOS.\r\nNesses casos devemos deletar o arquivo da IOS atual e logo após baixar a nova.\r\nPrimeiro, é necessário identificar o nome do arquivo da IOS atual com o comando: DIR <Nome_da_flash> (Inserir ? Para verificar o nome da flash)\r\nApós saber o nome do arquivo, usar o seguinte comando para apagar permanentemente o arquivo da memória:\r\ndelete /unreserved <nome_da_ios> (O processo leva alguns minutos)\r\nTomar cuidado após deletar a IOS para não desligar o Router, caso contrário ele não se inicia novamente.\r\n\r\n\r\nSTEP-BY-STEP PARA ATUALIZAÇÃO DA FLASH HP\r\n#1. Download new firmware at HP My Networking:\r\nhttps://h10145.www1.hp.com/sso/index.aspx\r\n\r\n=====================================================================\r\n#2. Uncompress downloaded file and place in a FTP Server\r\n\r\n=====================================================================\r\n#3. Check if router has enough space in flash:\r\ndir flash:/\r\n#Note: This command must be executed outside system-view mode\r\n\r\n=====================================================================\r\n#4. If there is no space left, delete unused files.\r\ndelete /unreserved <file>\r\n\r\n=====================================================================\r\n#5. Copy firmware from TFTP\r\ntftp <TFTP server IP> get <file> <Destination filename>\r\n\r\nExample:\r\ntftp 10.0.0.2 get a_msr301x-cmw520-r2512p04-si.bin a_msr301x-cmw520-r2512p04-si.bin\r\n\r\n=====================================================================\r\n#6. Update boot-loader to the new firmware\r\nboot-loader file flash:/<file> main\r\n#Note: This command must be executed outside system-view mode\r\n\r\n=====================================================================\r\n#7. Optionally, you can refer old version as backup firmware\r\nboot-loader file flash:/<old-file> backup\r\n\r\n=====================================================================\r\n#8. Save configuration\r\nsave\r\n\r\n=====================================================================\r\n#9. Reboot router\r\nreboot\r\n\r\n=====================================================================\r\n#10 Check boot-loader\r\ndisplay boot-loader");
            debugForm.Show(Owner);
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

        public void NotTested()
        {
            player.Play();
            MessageBox.Show("Not Tested");
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

            string[] teste = Script_DB_TextBox2.Text.Split(new[] { Environment.NewLine, "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < teste.Length; i++)
            {
                bancoStr = bancoStr + teste[i] + ';';
            }

            Script_DB_TextBox1.Text = bancoStr;
        }

        public void ReceiveFromDB()
        {
            string final = "";

            string[] teste = Script_DB_TextBox1.Text.Split(';');

            for (int i = 0; i < teste.Length; i++)
            {
                final = final + teste[i] + "\r\n";
            }

            Script_DB_TextBox2.Text = final;
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
            if (Script_DB_TextBox2.Text.Contains("var"))
            {
                Script_DB_TextBox2.Text = Script_DB_TextBox2.Text.Replace("var", Script_DB_VarTextBox.Text);
            }
        }

        private void Teste_ClearDB_Click(object sender, EventArgs e)
        {
            Script_DB_TextBox1.Text = string.Empty;
        }

        private void Teste_ClearF_Click(object sender, EventArgs e)
        {
            Script_DB_TextBox2.Text = string.Empty;
        }

        // ----------------------
        // Script Test Values
        // ----------------------
        private void Button_ApplyTestValues_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("\r\n--> Applied Test Values");

            Script_VarText00.Text = "Teste_NAME";
            Script_VarText01.Text = "TESTE | nao sei | PNIS/IP/00024";
            Script_VarText02.Text = "50000";
            Script_VarText03.Text = "GigaEthernet0/0";
            Script_VarText03b.Text = "TenGigabitEthernet12/2/0.57";
            Script_VarText04.Text = "GigaEthernet0/0.5";
            Script_VarText05.Text = "GigaEthernet0/1";
            Script_VarText06.Text = "GigaEthernet0/1.12";
            Script_VarText07.Text = "192.168.1.1";
            Script_VarText08.Text = "192.168.1.2";
            Script_VarText09.Text = "10.10.10.1";
            Script_VarText10.Text = "172.40.165.37";
            Script_VarText11.Text = "21.21.21.21";
            Script_VarText12.Text = "65000";
            Script_VarText13.Text = "12025";
            Script_VarText14.Text = "VRFteste:666";
            Script_VarText15.Text = "100395";
            Script_VarText16.Text = "189.55.37.89";
            Script_VarText17.Text = "21045000";
            Script_VarText18.Text = "19";
            Script_VarText19.Text = "210450[0-4][0-9]";
            Script_VarText20.Text = "1-15,17-31";
            Script_VarText21.Text = "0/1";

            Script_LANMascaraBox.SelectedIndex = 2;
            Script_RouterModelBox.SelectedIndex = 0;
            Script_XRBox.SelectedIndex = 1;
            Script_SinalizBox.SelectedIndex = 1;

            Script_VarRouteI1.Text = "Import 1";
            Script_VarRouteI2.Text = "Import 2";
            Script_VarRouteE1.Text = "Export 1";
            Script_VarRouteE2.Text = "Export 2";

            // SNMP
            Outros_SNMP_VarText0.Text = "public";
            Outros_SNMP_VarText1.Text = "10.10.10.1";
            Outros_SNMP_VarPrivComboBox.SelectedIndex = 0;

            // Regra Adicional 
            Outros_RegraAdc_NumDaRegraComboBox.SelectedIndex = 1;
            Outros_RegraAdc_VarText0.Text = "19";
            Outros_RegraAdc_VarText1.Text = "32035000";
            Outros_RegraAdc_VarText2.Text = "320350[0-4][0-9]";
            Outros_RegraAdc_VarText3.Text = "0/1:15";
            Outros_RegraAdc_VarText4.Text = "51";

            // Port Block
            Outros_PortBlock_TextBox0.Text = "GigaEthernet0/1";
            Outros_PortBlock_TextBox1.Text = "192.168.1.1";
            Outros_PortBlock_TextBox2.Text = "10.10.10.1";
            ChangeAllPortBlockComboBox(1);

            // VLAN
            Outros_VLAN_VarText0.Text = "GigaEthernet0/1";
            Outros_VLAN_VarText1.Text = "10.10.10.1";
            Outros_VLAN_MascaraBox.SelectedIndex = 2;

            // BGP
            Outros_BGP_VarText0.Text = "65000";
            Outros_BGP_VarText1.Text = "192.168.1.1";
            Outros_BGP_VarText2.Text = "PNIS/IP/00024";
            Outros_BGP_VarText3.Text = "4231";
            Outros_BGP_VarText4.Text = "172.31.10.8";
            Outros_BGP_VarText5.Text = "Senha";

            // IP FLOW
            Outros_IPFlow_VarText0.Text = "GigaEthernet0/1";
            Outros_IPFlow_VarText1.Text = "172.31.10.8";
            Outros_IPFlow_VarText2.Text = "9996";

            // User
            Outros_User_VarText0.Text = "Tyter";
            Outros_User_VarText1.Text = "Nicholas67";
            Outros_User_VarPrivBox.SelectedIndex = 0;

            // DHCP
            Outros_DHCP_VarText0.Text = "GigaEthernet0/1";
            Outros_DHCP_VarText1.Text = "10.10.10.1";
            Outros_DHCP_MascaraBox.SelectedIndex = 2;
            Outros_DHCP_VarText2.Text = "10.10.10.2";
            Outros_DHCP_VarText3.Text = "10.10.10.240";
            Outros_DHCP_VarText4.Text = "10.10.10.241";
            Outros_DHCP_VarText5.Text = "10.10.10.254";
            Outros_DHCP_VarText6.Text = "8.8.8.8";
            Outros_DHCP_VarText7.Text = "1.1.1.1";
            Outros_DHCP_VarText8.Text = "172.31.8.12";
            Outros_DHCP_VarText9.Text = "embratel";

            // QoS
            Outros_QoS_VarText00.Text = "20000";
            Outros_QoS_VarText01.Text = "1000";
            Outros_QoS_VarText02.Text = "2000";
            Outros_QoS_VarText03.Text = "1000";
            Outros_QoS_VarText04.Text = "4000";
            Outros_QoS_VarText05.Text = "1000";
            Outros_QoS_VarText06.Text = "500";
            Outros_QoS_VarText07.Text = "10000";
            Outros_QoS_VarText08.Text = "GigaEthernet0/0";
            Outros_QoS_VarText09.Text = "GigaEthernet0/1";
            CalcQoSTotal();

        }

        private void TestImportSAIP(object sender, EventArgs e)
        {
            string copiado = Clipboard.GetText();
            try
            {
                string[] teste = copiado.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                string novo = "";

                for (int i = 0; i < teste.Length; i++)
                {
                    novo = novo + i + " - " + teste[i] + "\r\n";
                }
                Script_TextBox.Text = novo;
            }
            catch
            {
                MessageBox.Show("Import Incorreto");
            }
        }

        public void TesteFillClientList()
        {
            Script newScript = new Script(999, "script", true, "Script de Teste", "00,01,02,03,04,05", "Teste,Deu Certo, Opa, Vlw, Nao sei", DateTime.Now);
            Step testStep = new Step(0, "Passo a Passo OK", newScript, null, false, 1);
            Step testStep2 = new Step(1, "Passo a Passo Pagina 2", newScript, null, false, 1);

            List<Step> testSteps = new List<Step>
            {
                testStep,
                testStep2
            };

            clients.Add(new Client("Teste", true, false, testSteps));
            clients.Add(new Client("Novo Teste", false, false, testSteps));
        }

        private void Button_ResetPassword_Click(object sender, EventArgs e)
        {
            enableEdit = false;
            canImportSAIP = false;
            enableTest = false;
            Properties.Settings.Default.enableEdit = enableEdit;
            Properties.Settings.Default.canImportSAIP = canImportSAIP;
            Properties.Settings.Default.enableTest = enableTest;
            Properties.Settings.Default.Save();

            CheckTestUI();
            CheckCanImportFromSAIP();
        }

        private void Pref_Button_ResetAll_Click(object sender, EventArgs e)
        {
            nightMode = false;
            enableEdit = false;
            canImportSAIP = false;
            enableTest = false;
            firstAccess = true;
            userPE = "";
            userTacacs = "";
            puttyPath = "";

            Pref_User_NameTextBox.Text = string.Empty;
            Pref_User_PasswordTextBox.Text = string.Empty;
            Pref_TACACS_UserTextBox.Text = string.Empty;
            Pref_TACACS_PasswordTextBox.Text = string.Empty;
            Pref_Putty_PathTextBox.Text = string.Empty;

            Properties.Settings.Default.nightMode = nightMode;
            Properties.Settings.Default.enableEdit = enableEdit;
            Properties.Settings.Default.canImportSAIP = canImportSAIP;
            Properties.Settings.Default.enableTest = enableTest;
            Properties.Settings.Default.firstAccess = firstAccess;
            Properties.Settings.Default.userPE = userPE;
            Properties.Settings.Default.userTacacs = userTacacs;
            Properties.Settings.Default.puttyPath = puttyPath;
            Properties.Settings.Default.Save();

            Application.Restart();
        }

        private void Test_CheckBox_ShowVarOnScript_CheckedChanged(object sender, EventArgs e)
        {
            if (canPressAgain)
            {
                _ = ChangeTrueScriptAsync();
            }
        }

        public async Task ChangeTrueScriptAsync()
        {
            Debug.WriteLine("\r\n--> True Script changed to: " + !trueScript);

            // Stack Overflow Block
            canPressAgain = false;

            trueScript = !trueScript;

            // Change UI
            if (!canPressAgain)
            {
                Test_CheckBox_ShowVarOnScript.Checked = trueScript;
            }

            // Wait 0,3 Seconds before allow pressing again
            await Task.Delay(300);
            canPressAgain = true;

            Debug.WriteLine("Button can be pressed again");
        }

        public void EnableTesting()
        {
            enableTest = true;
            MasterSheetNew.Properties.Settings.Default.enableTest = enableTest;
            MasterSheetNew.Properties.Settings.Default.Save();
            CheckTestUI();
            EnableEditing();
        }

        public void CheckTestUI()
        {
            if (enableTest)
            {
                Test_CheckBox_ShowVarOnScript.Show();
                LogTools_DBScript.Show();
                Script_Button_ApplyTestValues.Show();
                Outros_Button_ApplyTestValues.Show();
                List_All_Scritps.Show();
                Test_Button_TestImport.Show();
                Automation_Button.Show();
            }
            else
            {
                Test_CheckBox_ShowVarOnScript.Hide();
                LogTools_DBScript.Hide();
                Script_Button_ApplyTestValues.Hide();
                Outros_Button_ApplyTestValues.Hide();
                List_All_Scritps.Hide();
                Test_Button_TestImport.Hide();
                Automation_Button.Hide();
            }
        }
        #endregion

        private void TotalScripts_Test(object sender, EventArgs e)
        {
            MessageBox.Show("Total de Scripts: " + scripts.Count);

            string final = "";
            int i = 0;

            foreach (Script s in scripts)
            {
                final = final + i + " - " + s.name + " -> ID: " + s.id + "\r\n";
                i++;
            }

            FormDebug debugForm = new FormDebug(final);
            debugForm.Show(Owner);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://corpclarobr.sharepoint.com/:x:/r/sites/USER-IOSHomologados/_layouts/15/Doc.aspx?sourcedoc=%7b4F8B0100-951C-469D-BA2C-44AF33E272F6%7d&file=Painel%20de%20Versoes%20-%20Revisao%2035.xlsx&_DSL=1&action=default&mobileredirect=true");
        }

        private void Outros_PortBlock_ClearButton_Click(object sender, EventArgs e)
        {
            Outros_PortBlock_TextBox0.Text = String.Empty;
            Outros_PortBlock_TextBox1.Text = String.Empty;
            Outros_PortBlock_TextBox2.Text = String.Empty;
            Outros_PortBlock_TextBox3.Text = String.Empty;

            ChangeAllPortBlockComboBox(1);
        }

        private void Outros_PortBlock_ChangeAllButton_Click(object sender, EventArgs e)
        {
            if (Outros_PortBLock_ComboBox0.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox1.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox2.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox3.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox4.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox5.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox6.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox7.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox8.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox9.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox10.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox11.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox12.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox13.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox14.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox15.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else if (Outros_PortBLock_ComboBox16.SelectedIndex == 0)
            {
                ChangeAllPortBlockComboBox(1);
            }
            else
            {
                ChangeAllPortBlockComboBox(0);
            }
        }

        public void ChangeAllPortBlockComboBox(int index)
        {
            Outros_PortBLock_ComboBox0.SelectedIndex = index;
            Outros_PortBLock_ComboBox1.SelectedIndex = index;
            Outros_PortBLock_ComboBox2.SelectedIndex = index;
            Outros_PortBLock_ComboBox3.SelectedIndex = index;
            Outros_PortBLock_ComboBox4.SelectedIndex = index;
            Outros_PortBLock_ComboBox5.SelectedIndex = index;
            Outros_PortBLock_ComboBox6.SelectedIndex = index;
            Outros_PortBLock_ComboBox7.SelectedIndex = index;
            Outros_PortBLock_ComboBox8.SelectedIndex = index;
            Outros_PortBLock_ComboBox9.SelectedIndex = index;
            Outros_PortBLock_ComboBox10.SelectedIndex = index;
            Outros_PortBLock_ComboBox11.SelectedIndex = index;
            Outros_PortBLock_ComboBox12.SelectedIndex = index;
            Outros_PortBLock_ComboBox13.SelectedIndex = index;
            Outros_PortBLock_ComboBox14.SelectedIndex = index;
            Outros_PortBLock_ComboBox15.SelectedIndex = index;
            Outros_PortBLock_ComboBox16.SelectedIndex = index;
        }

        private void Outros_RegraAdc_ClearButton_Click(object sender, EventArgs e)
        {
            Outros_RegraAdc_NumDaRegraComboBox.SelectedIndex = 0;
            Outros_RegraAdc_VarText0.Text = String.Empty;
            Outros_RegraAdc_VarText1.Text = String.Empty;
            Outros_RegraAdc_VarText2.Text = String.Empty;
            Outros_RegraAdc_VarText3.Text = String.Empty;
            Outros_RegraAdc_VarText4.Text = String.Empty;

            Outros_RegraAdc_AligeraCheckBox.Checked = false;
            Outros_RegraAdc_ISRCheckBox.Checked = false;
        }

        private void Outros_RegraAdc_DelButton0_Click(object sender, EventArgs e)
        {
            Outros_RegraAdc_VarText0.Text = string.Empty;
        }

        private void Outros_RegraAdc_DelButton1_Click(object sender, EventArgs e)
        {
            Outros_RegraAdc_VarText1.Text = string.Empty;
        }

        private void Outros_RegraAdc_DelButton2_Click(object sender, EventArgs e)
        {
            Outros_RegraAdc_VarText2.Text = string.Empty;
        }

        private void Outros_RegraAdc_DelButton3_Click(object sender, EventArgs e)
        {
            Outros_RegraAdc_VarText3.Text = string.Empty;
        }

        private void Outros_RegraAdc_DelButton4_Click(object sender, EventArgs e)
        {
            Outros_RegraAdc_VarText4.Text = string.Empty;
        }

        private void Outros_User_ClearButton_Click(object sender, EventArgs e)
        {
            Outros_User_VarText0.Text = String.Empty;
            Outros_User_VarText1.Text = String.Empty;
            Outros_User_VarPrivBox.SelectedIndex = 0;
        }

        private void Outros_QoS_ClearButton_Click(object sender, EventArgs e)
        {
            Outros_QoS_VarText08.Text = String.Empty;
            Outros_QoS_VarText09.Text = String.Empty;
            Outros_QoS_VarText01.Text = String.Empty;
            Outros_QoS_VarText02.Text = String.Empty;
            Outros_QoS_VarText03.Text = String.Empty;
            Outros_QoS_VarText04.Text = String.Empty;
            Outros_QoS_VarText05.Text = String.Empty;
            Outros_QoS_VarText06.Text = String.Empty;
            Outros_QoS_VarText07.Text = String.Empty;
            Outros_QoS_VarText00.Text = String.Empty;
            CalcQoSTotal();
        }

        private void Script_TracertButton_Click(object sender, EventArgs e)
        {
            if (Script_VarText16.Text != string.Empty)
            {
                if (routerType == RouterType.Cisco)
                {
                    if (Script_VarText05.Text == string.Empty)
                    {
                        Clipboard.SetText("ping " + Script_VarText16.Text + "\r\n" +
                            "!\r\n");
                    }
                    else
                    {
                        Clipboard.SetText("ping " + Script_VarText16.Text + " source " + Script_VarText05.Text + "\r\n" +
                            "!\r\n" +
                            "!\r\n" +
                            "!\r\n" +
                            "traceroute " + Script_VarText16.Text + " source " + Script_VarText05.Text + " numeric timeout 1\r\n" +
                            "!\r\n");
                    }
                }
                else if (routerType == RouterType.HPE || routerType == RouterType.HPE_old)
                {
                    if (Script_VarText09.Text == string.Empty)
                    {
                        Clipboard.SetText("ping " + Script_VarText16.Text + "\r\n" +
                            "#\r\n");
                    }
                    else
                    {
                        Clipboard.SetText("ping -a " + Script_VarText05.Text + " " + Script_VarText16.Text + "\r\n" +
                            "#\r\n" +
                            "#\r\n" +
                            "#\r\n" +
                            "tracert -a " + Script_VarText09.Text + " " + Script_VarText16.Text + "\r\n" +
                            "#\r\n");
                    }
                }
                else if (routerType == RouterType.Aligera)
                {
                    Clipboard.SetText("tools ping " + Script_VarText16.Text + "\r\n");
                }
                else if (routerType == RouterType.Digistar)
                {
                    Clipboard.SetText("ping " + Script_VarText16.Text + "\r\n" +
                        "!\r\n");
                }
                else
                {
                    MessageBox.Show("Modelo de Router Incorreto");
                }
            }
            else
            {
                MessageBox.Show("IP do SIP não preenchido");
            }
        }

        private void Config_HPE_old_Click_1(object sender, EventArgs e)
        {
            routerType = RouterType.HPE_old;
            backboneOrNot = false;
            procedureType = ProcedureType.Config;
            DispatcherUI(routerType, activityType, procedureType, backboneOrNot, peType);
        }

        private void Outros_PortBlock_Delete0_Click(object sender, EventArgs e)
        {
            Outros_PortBlock_TextBox0.Text = string.Empty;
        }

        private void Outros_PortBlock_Delete1_Click(object sender, EventArgs e)
        {
            Outros_PortBlock_TextBox1.Text = string.Empty;
        }

        private void Outros_PortBlock_Delete2_Click(object sender, EventArgs e)
        {
            Outros_PortBlock_TextBox2.Text = string.Empty;
        }

        private void Outros_PortBlock_Delete3_Click(object sender, EventArgs e)
        {
            Outros_PortBlock_TextBox3.Text = string.Empty;
        }

        private void Outros_VarDeleteAll_Click_1(object sender, EventArgs e)
        {
            Outros_SNMP_VarText0.Text = string.Empty;
            Outros_SNMP_VarText1.Text = string.Empty;
            Outros_SNMP_VarPrivComboBox.SelectedIndex = 0;
        }

        private void Outros_VarDelete1_Click_1(object sender, EventArgs e)
        {
            Outros_SNMP_VarText1.Text = string.Empty;
        }

        private void Outros_VarDelete0_Click_1(object sender, EventArgs e)
        {
            Outros_SNMP_VarText0.Text = string.Empty;
        }

        private void Outros_VarDeleteCalc_Click(object sender, EventArgs e)
        {
            Outros_QoS_VarText00.Text = string.Empty;
        }

        private void Outros_BGP_DeleteAll_Click(object sender, EventArgs e)
        {
            Outros_BGP_VarText0.Text = string.Empty;
            Outros_BGP_VarText1.Text = string.Empty;
            Outros_BGP_VarText2.Text = string.Empty;
            Outros_BGP_VarText3.Text = string.Empty;
            Outros_BGP_VarText4.Text = string.Empty;
            Outros_BGP_VarText5.Text = string.Empty;
        }

        private void Outros_BGP_DeleteVar1_Click(object sender, EventArgs e)
        {
            Outros_BGP_VarText1.Text = string.Empty;
        }

        private void Outros_BGP_DeleteVar2_Click(object sender, EventArgs e)
        {
            Outros_BGP_VarText2.Text = string.Empty;
        }

        private void Outros_BGP_DeleteVar3_Click(object sender, EventArgs e)
        {
            Outros_BGP_VarText3.Text = string.Empty;
        }

        private void Outros_BGP_DeleteVar4_Click(object sender, EventArgs e)
        {
            Outros_BGP_VarText4.Text = string.Empty;
        }

        private void Outros_BGP_DeleteVar5_Click(object sender, EventArgs e)
        {
            Outros_BGP_VarText5.Text = string.Empty;
        }

        private void Outros_BGP_DeleteVar0_Click(object sender, EventArgs e)
        {
            Outros_BGP_VarText0.Text = string.Empty;
        }
        private void Outros_VLAN_ClearAllButton_Click(object sender, EventArgs e)
        {
            Outros_VLAN_VarText0.Text = string.Empty;
            Outros_VLAN_VarText1.Text = string.Empty;
            Outros_VLAN_CatalystCheckBox.Checked = false;
        }

        private void Outros_VLAN_VarDel1_Click(object sender, EventArgs e)
        {
            Outros_VLAN_VarText1.Text = string.Empty;
        }

        private void Outros_VLAN_VarDel0_Click(object sender, EventArgs e)
        {
            Outros_VLAN_VarText0.Text = string.Empty;
        }

        private void Outros_User_VarDelete0_Click(object sender, EventArgs e)
        {
            Outros_User_VarText0.Text = string.Empty;
        }

        private void Outros_User_VarDelete1_Click(object sender, EventArgs e)
        {
            Outros_User_VarText1.Text = string.Empty;
        }

        private void SwitchConfAndLogs(object sender, EventArgs e)
        {
            SwitchConfAndLogs();
        }

        private void Automation_Button_Click(object sender, EventArgs e)
        {
            scriptPE = ScriptDispatcher(routerType, activityType, ProcedureType.Logs, true, peType);
            scriptCPE = ScriptDispatcher(routerType, activityType, ProcedureType.Logs, false, peType);

            FormAutomation newForm = new FormAutomation(OpenPE_ComboBox.Text, userPE, puttyPath, peType, isXR, routerType, activityType, Script_VarText08.Text,
               Script_VarText03b.Text, Script_VarText14.Text, scriptPE, scriptCPE);
            newForm.Show();
        }

    }
}