using System.Drawing;
using System.Windows.Forms;

namespace MasterSheetNew
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl tabControl3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IOS_Button = new System.Windows.Forms.Button();
            this.IOS_Label0 = new System.Windows.Forms.Label();
            this.IOS_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.IOS_LabelInfo = new System.Windows.Forms.Label();
            this.IOS_DataGrid_Routers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainTitle = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMaster = new System.Windows.Forms.TabPage();
            this.OpenPE_ComboBox = new System.Windows.Forms.ComboBox();
            this.OpenPE_Label = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.MainPage_ColetaLigacoes_Button = new System.Windows.Forms.Button();
            this.MainPage_Velo_Button = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_Hotline = new System.Windows.Forms.Button();
            this.MainPage_Button_BLD = new System.Windows.Forms.Button();
            this.MainPage_Button_Cliente4 = new System.Windows.Forms.Button();
            this.MainPage_Button_Cliente5 = new System.Windows.Forms.Button();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.ImageLogo = new System.Windows.Forms.PictureBox();
            this.MainPage_Button_OC_QoS = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_Vago = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_Balanceamento = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_EIGRP = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_GLBP = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_IPFlow = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_BGP = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_HSRP = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_VRRP = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_OSPF = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_RIP = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_User = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_DHCP = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_ExtrasFortigate = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_RegraAdicional = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_SNMP = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_BlockPort = new System.Windows.Forms.Button();
            this.MainPage_Button_OC_VLAN = new System.Windows.Forms.Button();
            this.MainPage_Button_WizGat = new System.Windows.Forms.Button();
            this.MainPage_SubTitle4 = new System.Windows.Forms.Label();
            this.MainPage_SubTitle3 = new System.Windows.Forms.Label();
            this.MainPage_Button_ClienteList = new System.Windows.Forms.LinkLabel();
            this.MainPage_Button_Cliente3 = new System.Windows.Forms.Button();
            this.MainPage_Button_Cliente2 = new System.Windows.Forms.Button();
            this.MainPage_Button_Cliente1 = new System.Windows.Forms.Button();
            this.MainPage_Button_Cliente0 = new System.Windows.Forms.Button();
            this.MainPage_Button_LogsFinais = new System.Windows.Forms.Button();
            this.MainPage_Button_LogsIniciais = new System.Windows.Forms.Button();
            this.MainPage_SubTitle0 = new System.Windows.Forms.Label();
            this.MainPage_SubTitle1 = new System.Windows.Forms.Label();
            this.MainPage_SubTitle2 = new System.Windows.Forms.Label();
            this.MainPage_TemplatesLabel = new System.Windows.Forms.Label();
            this.MainPage_TemplatesLabel_BG = new System.Windows.Forms.PictureBox();
            this.MainPage_Button_Voz = new System.Windows.Forms.Button();
            this.MainPage_Button_MPLS = new System.Windows.Forms.Button();
            this.tabScript = new System.Windows.Forms.TabPage();
            this.Test_CheckBox_ShowVarOnScript = new System.Windows.Forms.CheckBox();
            this.Script_Row = new System.Windows.Forms.PictureBox();
            this.Script_Button_TACACS = new System.Windows.Forms.Button();
            this.Script_Button_ApplyTestValues = new System.Windows.Forms.Button();
            this.Script_AlterDate = new System.Windows.Forms.Label();
            this.Script_AlterDate_Label = new System.Windows.Forms.Label();
            this.Script_Button_Config = new System.Windows.Forms.Button();
            this.Script_Button_Copy = new System.Windows.Forms.Button();
            this.Script_Button_SwitchLabel = new System.Windows.Forms.Button();
            this.Script_LogBox_Label = new System.Windows.Forms.Label();
            this.HomeButton_Script = new System.Windows.Forms.Button();
            this.Script_SubTitle = new System.Windows.Forms.Label();
            this.Script_SwitchLabel = new System.Windows.Forms.Label();
            this.Script_LogBox = new System.Windows.Forms.ComboBox();
            this.Script_Button_Debug = new System.Windows.Forms.Button();
            this.BackButton_Script2 = new System.Windows.Forms.Button();
            this.Script_Button_FormCopy = new System.Windows.Forms.Button();
            this.Script_Button_Format = new System.Windows.Forms.Button();
            this.Script_ButtonsSubTab = new System.Windows.Forms.TabControl();
            this.Script_ButtonsSubTab_Voz = new System.Windows.Forms.TabPage();
            this.Script_ButtonRegraAdc = new System.Windows.Forms.Button();
            this.Script_Button_Tracert = new System.Windows.Forms.Button();
            this.Script_ButtonsSubTab_Logs = new System.Windows.Forms.TabPage();
            this.Script_Button_Limpeza = new System.Windows.Forms.Button();
            this.Script_Button_Parte2 = new System.Windows.Forms.Button();
            this.Script_ButtonsSubTab_BackboneBGP = new System.Windows.Forms.TabPage();
            this.Script_Button_IPv6 = new System.Windows.Forms.Button();
            this.Script_Button_Multihop = new System.Windows.Forms.Button();
            this.Script_ButtonsSubTab_Hollow = new System.Windows.Forms.TabPage();
            this.BackButton_Script = new System.Windows.Forms.Button();
            this.BackButton_Script3 = new System.Windows.Forms.Button();
            this.Script_TextBox = new System.Windows.Forms.RichTextBox();
            this.Test_Button_TestImport = new System.Windows.Forms.Button();
            this.Script_ProcedureName = new System.Windows.Forms.Label();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Script_Button_ClearPortas = new System.Windows.Forms.Button();
            this.Script_Button_Inverter = new System.Windows.Forms.Button();
            this.Script_VarSubTab = new System.Windows.Forms.TabControl();
            this.Script_SubTab_VozVar = new System.Windows.Forms.TabPage();
            this.Script_SinalizLabel = new System.Windows.Forms.Label();
            this.Script_SinalizBox = new System.Windows.Forms.ComboBox();
            this.Script_VarEx21 = new System.Windows.Forms.Label();
            this.Script_DeleteVar21 = new System.Windows.Forms.Button();
            this.Script_VarName21 = new System.Windows.Forms.Label();
            this.BigTitle_Label = new System.Windows.Forms.Label();
            this.Script_DeleteVar16 = new System.Windows.Forms.Button();
            this.Script_VarEx18 = new System.Windows.Forms.Label();
            this.Script_VarEx19 = new System.Windows.Forms.Label();
            this.Script_VarEx20 = new System.Windows.Forms.Label();
            this.Script_VarEx17 = new System.Windows.Forms.Label();
            this.Script_VarEx16 = new System.Windows.Forms.Label();
            this.Script_DeleteVar20 = new System.Windows.Forms.Button();
            this.Script_VarText20 = new System.Windows.Forms.TextBox();
            this.Script_VarName20 = new System.Windows.Forms.Label();
            this.Script_DeleteVar19 = new System.Windows.Forms.Button();
            this.Script_VarText19 = new System.Windows.Forms.TextBox();
            this.Script_VarName19 = new System.Windows.Forms.Label();
            this.Script_DeleteVar18 = new System.Windows.Forms.Button();
            this.Script_VarText18 = new System.Windows.Forms.TextBox();
            this.Script_VarName18 = new System.Windows.Forms.Label();
            this.Script_DeleteVar17 = new System.Windows.Forms.Button();
            this.Script_VarText17 = new System.Windows.Forms.TextBox();
            this.Script_VarName17 = new System.Windows.Forms.Label();
            this.Script_VarText16 = new System.Windows.Forms.TextBox();
            this.Script_VarName16 = new System.Windows.Forms.Label();
            this.Script_VarText21 = new System.Windows.Forms.TextBox();
            this.Script_SubTab_RouteMap = new System.Windows.Forms.TabPage();
            this.Script_DeleteRouteI1 = new System.Windows.Forms.Button();
            this.Script_DeleteRouteI2 = new System.Windows.Forms.Button();
            this.Script_DeleteRouteE1 = new System.Windows.Forms.Button();
            this.Script_DeleteRouteE2 = new System.Windows.Forms.Button();
            this.Script_VarRouteE2 = new System.Windows.Forms.TextBox();
            this.Script_VarRouteE1 = new System.Windows.Forms.TextBox();
            this.Script_VarRouteE2Label = new System.Windows.Forms.Label();
            this.Script_VarRouteE1Label = new System.Windows.Forms.Label();
            this.Script_VarRouteI2Label = new System.Windows.Forms.Label();
            this.Script_VarRouteI2 = new System.Windows.Forms.TextBox();
            this.Script_VarRouteI1Label = new System.Windows.Forms.Label();
            this.Script_VarRouteI1 = new System.Windows.Forms.TextBox();
            this.Script_RouteLabelHint = new System.Windows.Forms.Label();
            this.Script_VarSubTab_Hollow = new System.Windows.Forms.TabPage();
            this.Script_VarText06 = new System.Windows.Forms.TextBox();
            this.Script_DeleteVar02 = new System.Windows.Forms.Button();
            this.Script_DeleteVar09 = new System.Windows.Forms.Button();
            this.Script_DeleteVar08 = new System.Windows.Forms.Button();
            this.Script_DeleteVar07 = new System.Windows.Forms.Button();
            this.Script_DeleteVar10 = new System.Windows.Forms.Button();
            this.Script_DeleteVar11 = new System.Windows.Forms.Button();
            this.Script_VarText09 = new System.Windows.Forms.TextBox();
            this.Script_Hint1 = new System.Windows.Forms.Label();
            this.Script_Button_PortImport = new System.Windows.Forms.Button();
            this.Script_VarText03b = new System.Windows.Forms.TextBox();
            this.Script_ExLabel = new System.Windows.Forms.Label();
            this.Script_VarEx13 = new System.Windows.Forms.Label();
            this.Script_VarEx14 = new System.Windows.Forms.Label();
            this.Script_DeleteVar06 = new System.Windows.Forms.Button();
            this.Script_VarEx15 = new System.Windows.Forms.Label();
            this.Script_VarEx12 = new System.Windows.Forms.Label();
            this.Script_VarEx11 = new System.Windows.Forms.Label();
            this.Script_VarEx10 = new System.Windows.Forms.Label();
            this.Script_VarEx09 = new System.Windows.Forms.Label();
            this.Script_LANMascaraBox = new System.Windows.Forms.ComboBox();
            this.Script_VarEx08 = new System.Windows.Forms.Label();
            this.Script_VarEx07 = new System.Windows.Forms.Label();
            this.Script_VarEx06 = new System.Windows.Forms.Label();
            this.Script_VarEx05 = new System.Windows.Forms.Label();
            this.Script_VarEx04 = new System.Windows.Forms.Label();
            this.Script_VarEx03 = new System.Windows.Forms.Label();
            this.Script_VarEx02 = new System.Windows.Forms.Label();
            this.Script_VarEx01 = new System.Windows.Forms.Label();
            this.Script_VarEx00 = new System.Windows.Forms.Label();
            this.Script_DeleteVar15 = new System.Windows.Forms.Button();
            this.Script_VarText15 = new System.Windows.Forms.TextBox();
            this.Script_VarName15 = new System.Windows.Forms.Label();
            this.Script_DeleteVar14 = new System.Windows.Forms.Button();
            this.Script_VarText14 = new System.Windows.Forms.TextBox();
            this.Script_VarName14 = new System.Windows.Forms.Label();
            this.Script_DeleteVar13 = new System.Windows.Forms.Button();
            this.Script_VarText13 = new System.Windows.Forms.TextBox();
            this.Script_VarName13 = new System.Windows.Forms.Label();
            this.Script_DeleteVar12 = new System.Windows.Forms.Button();
            this.Script_VarText12 = new System.Windows.Forms.TextBox();
            this.Script_VarName12 = new System.Windows.Forms.Label();
            this.Script_DeleteVar05 = new System.Windows.Forms.Button();
            this.Script_DeleteVar04 = new System.Windows.Forms.Button();
            this.Script_DeleteVar01 = new System.Windows.Forms.Button();
            this.Script_DeleteVar00 = new System.Windows.Forms.Button();
            this.Script_ModelLabel = new System.Windows.Forms.Label();
            this.Script_RouterModelBox = new System.Windows.Forms.ComboBox();
            this.Script_VarText11 = new System.Windows.Forms.TextBox();
            this.Script_VarName11 = new System.Windows.Forms.Label();
            this.Script_VarText10 = new System.Windows.Forms.TextBox();
            this.Script_VarName10 = new System.Windows.Forms.Label();
            this.Script_VarName09 = new System.Windows.Forms.Label();
            this.Script_VarText08 = new System.Windows.Forms.TextBox();
            this.Script_VarName08 = new System.Windows.Forms.Label();
            this.Script_VarText07 = new System.Windows.Forms.TextBox();
            this.Script_VarName07 = new System.Windows.Forms.Label();
            this.Script_VarName06 = new System.Windows.Forms.Label();
            this.Script_Button_Clear = new System.Windows.Forms.Button();
            this.Script_VarTitle = new System.Windows.Forms.Label();
            this.Script_VarText05 = new System.Windows.Forms.TextBox();
            this.Script_VarText04 = new System.Windows.Forms.TextBox();
            this.Script_VarText03 = new System.Windows.Forms.TextBox();
            this.Script_VarText02 = new System.Windows.Forms.TextBox();
            this.Script_VarText01 = new System.Windows.Forms.TextBox();
            this.Script_VarName05 = new System.Windows.Forms.Label();
            this.Script_VarName03 = new System.Windows.Forms.Label();
            this.Script_VarName04 = new System.Windows.Forms.Label();
            this.Script_VarName02 = new System.Windows.Forms.Label();
            this.Script_VarName01 = new System.Windows.Forms.Label();
            this.Script_VarName00 = new System.Windows.Forms.Label();
            this.Script_VarText00 = new System.Windows.Forms.TextBox();
            this.Script_XRLabel = new System.Windows.Forms.Label();
            this.Script_XRBox = new System.Windows.Forms.ComboBox();
            this.Script_DeleteVar03 = new System.Windows.Forms.Button();
            this.Script_DeleteVar03b = new System.Windows.Forms.Button();
            this.Script_Button_Telnet = new System.Windows.Forms.Button();
            this.Script_Button_TelnetPlus = new System.Windows.Forms.Button();
            this.tabSelectRouter = new System.Windows.Forms.TabPage();
            this.Config_Button_WizGat = new System.Windows.Forms.Button();
            this.Config_Button_Broadsoft = new System.Windows.Forms.Button();
            this.Config_Button_Logs = new System.Windows.Forms.Button();
            this.Config_SubTitleType = new System.Windows.Forms.Label();
            this.Config_Button_VOZ = new System.Windows.Forms.Button();
            this.Config_Button_MPLS = new System.Windows.Forms.Button();
            this.Config_Button_BLD = new System.Windows.Forms.Button();
            this.Config_SubTitle = new System.Windows.Forms.Label();
            this.Config_Button_HPE_old = new System.Windows.Forms.Button();
            this.Config_Title = new System.Windows.Forms.Label();
            this.HomeButton_SelectRouter = new System.Windows.Forms.Button();
            this.Config_Button_HPE = new System.Windows.Forms.Button();
            this.Config_Button_Huawei = new System.Windows.Forms.Button();
            this.Config_Button_Fortigate = new System.Windows.Forms.Button();
            this.Config_Button_Cisco = new System.Windows.Forms.Button();
            this.Config_Button_Aligera = new System.Windows.Forms.Button();
            this.Config_Button_Digistar = new System.Windows.Forms.Button();
            this.ClientStepsPage = new System.Windows.Forms.TabPage();
            this.tabWizGat = new System.Windows.Forms.TabPage();
            this.WizGat_Button_Config = new System.Windows.Forms.Button();
            this.WizGat_Row = new System.Windows.Forms.PictureBox();
            this.WizGat_Button_Log = new System.Windows.Forms.Button();
            this.BackButton_WizGat = new System.Windows.Forms.Button();
            this.WizGat_Button_CiscoBLDcBGP = new System.Windows.Forms.Button();
            this.WizGat_Button_CiscoVoz = new System.Windows.Forms.Button();
            this.WizGat_Button_CiscoMPLS = new System.Windows.Forms.Button();
            this.WizGat_Button_CiscoBLD = new System.Windows.Forms.Button();
            this.WizGat_CiscoTitle = new System.Windows.Forms.Label();
            this.WizGat_NokiaTitle = new System.Windows.Forms.Label();
            this.WizGat_Button_NokiaBLDcBGP = new System.Windows.Forms.Button();
            this.WizGat_Button_NokiaVoz = new System.Windows.Forms.Button();
            this.WizGat_Button_NokiaMPLS = new System.Windows.Forms.Button();
            this.WizGat_Button_NokiaBLD = new System.Windows.Forms.Button();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.Logs_Button_Config = new System.Windows.Forms.Button();
            this.Logs_Button_WizGat = new System.Windows.Forms.Button();
            this.Logs_Button_Broadsoft = new System.Windows.Forms.Button();
            this.Logs_Button_VOZ_Digistar = new System.Windows.Forms.Button();
            this.Logs_Button_VOZ_HPE = new System.Windows.Forms.Button();
            this.Logs_Button_VOZ_Cisco = new System.Windows.Forms.Button();
            this.Logs_Button_MPLS_Huawei = new System.Windows.Forms.Button();
            this.Logs_Button_Ligacoes = new System.Windows.Forms.Button();
            this.Logs_Button_MPLS_Fortigate = new System.Windows.Forms.Button();
            this.Logs_Label_SubTitle2 = new System.Windows.Forms.Label();
            this.Logs_Button_BLD_Fortigate = new System.Windows.Forms.Button();
            this.Logs_Button_Velo = new System.Windows.Forms.Button();
            this.Logs_Label_SubTitle3 = new System.Windows.Forms.Label();
            this.Logs_Label_SubTitle1 = new System.Windows.Forms.Label();
            this.Logs_Label_SubTitle0 = new System.Windows.Forms.Label();
            this.Logs_Button_MPLS_HPE = new System.Windows.Forms.Button();
            this.Logs_Button_MPLS_Cisco = new System.Windows.Forms.Button();
            this.Logs_Button_VOZ_Aligera = new System.Windows.Forms.Button();
            this.Logs_Button_BLD_HPE = new System.Windows.Forms.Button();
            this.Logs_HomeButton = new System.Windows.Forms.Button();
            this.Logs_Label_Title = new System.Windows.Forms.Label();
            this.Logs_Button_CiscoBLD = new System.Windows.Forms.Button();
            this.Logs_Button_BLD_Huawei = new System.Windows.Forms.Button();
            this.Logs_Row2 = new System.Windows.Forms.PictureBox();
            this.Logs_Row1 = new System.Windows.Forms.PictureBox();
            this.Logs_Row0 = new System.Windows.Forms.PictureBox();
            this.tabVelocloud = new System.Windows.Forms.TabPage();
            this.veloRestoreButton = new System.Windows.Forms.Button();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tab_VeloVars = new System.Windows.Forms.TabPage();
            this.veloTextBox13 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox16 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox15 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox11 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox12 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox14 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox9 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox10 = new System.Windows.Forms.RichTextBox();
            this.labelVeloSubtitle14 = new System.Windows.Forms.Label();
            this.labelVeloSubtitle15 = new System.Windows.Forms.Label();
            this.labelVeloSubtitle16 = new System.Windows.Forms.Label();
            this.veloDeleteButton14 = new System.Windows.Forms.Button();
            this.veloDeleteButton15 = new System.Windows.Forms.Button();
            this.veloDeleteButton13 = new System.Windows.Forms.Button();
            this.veloDeleteButton16 = new System.Windows.Forms.Button();
            this.labelVeloSubtitle13 = new System.Windows.Forms.Label();
            this.labelVeloSubtitle9 = new System.Windows.Forms.Label();
            this.veloDeleteButton12 = new System.Windows.Forms.Button();
            this.labelVeloSubtitle10 = new System.Windows.Forms.Label();
            this.veloDeleteButton11 = new System.Windows.Forms.Button();
            this.veloDeleteButton10 = new System.Windows.Forms.Button();
            this.labelVeloSubtitle12 = new System.Windows.Forms.Label();
            this.veloDeleteButton9 = new System.Windows.Forms.Button();
            this.Velo_Testes_Label = new System.Windows.Forms.Label();
            this.labelVeloSubtitle11 = new System.Windows.Forms.Label();
            this.veloTextBox4 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox5 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox3 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox8 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox7 = new System.Windows.Forms.RichTextBox();
            this.veloTextBox6 = new System.Windows.Forms.RichTextBox();
            this.veloDeleteButton5 = new System.Windows.Forms.Button();
            this.veloDeleteButton8 = new System.Windows.Forms.Button();
            this.Velo_Configuracao_Label = new System.Windows.Forms.Label();
            this.veloDeleteButton7 = new System.Windows.Forms.Button();
            this.veloTextBox1 = new System.Windows.Forms.RichTextBox();
            this.veloDeleteButton6 = new System.Windows.Forms.Button();
            this.veloTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Velo_Monitor_Label = new System.Windows.Forms.Label();
            this.labelVeloSubtitle5 = new System.Windows.Forms.Label();
            this.labelVeloSubtitle6 = new System.Windows.Forms.Label();
            this.veloTextBox0 = new System.Windows.Forms.RichTextBox();
            this.labelVeloSubtitle7 = new System.Windows.Forms.Label();
            this.labelVeloSubtitle8 = new System.Windows.Forms.Label();
            this.veloDeleteButton4 = new System.Windows.Forms.Button();
            this.veloDeleteButton3 = new System.Windows.Forms.Button();
            this.veloDeleteButton2 = new System.Windows.Forms.Button();
            this.veloDeleteButton1 = new System.Windows.Forms.Button();
            this.veloDeleteButton0 = new System.Windows.Forms.Button();
            this.labelVeloSubtitle4 = new System.Windows.Forms.Label();
            this.labelVeloSubtitle3 = new System.Windows.Forms.Label();
            this.labelVeloSubtitle2 = new System.Windows.Forms.Label();
            this.labelVeloSubtitle1 = new System.Windows.Forms.Label();
            this.labelVeloSubtitle0 = new System.Windows.Forms.Label();
            this.Velo_TypeLabel = new System.Windows.Forms.Label();
            this.veloDeleteButtonAll = new System.Windows.Forms.Button();
            this.buttonSwitchVeloLog = new System.Windows.Forms.Button();
            this.labelVelocloudTitle = new System.Windows.Forms.Label();
            this.HomeButton_Velo = new System.Windows.Forms.Button();
            this.buttonVeloCopie = new System.Windows.Forms.Button();
            this.veloTextBoxFinal = new System.Windows.Forms.RichTextBox();
            this.tabLigacoes = new System.Windows.Forms.TabPage();
            this.Ligacoes_ConfigWiseButton = new System.Windows.Forms.Button();
            this.Ligacoes_BHPE_Antigo = new System.Windows.Forms.Button();
            this.Ligacoes_BLogs = new System.Windows.Forms.Button();
            this.Ligacoes_BDigistar = new System.Windows.Forms.Button();
            this.Ligacoes_BCisco = new System.Windows.Forms.Button();
            this.Ligacoes_BHPE = new System.Windows.Forms.Button();
            this.Ligacoes_BDebug = new System.Windows.Forms.Button();
            this.Ligacoes_BAligera = new System.Windows.Forms.Button();
            this.HomeButton_Ligacoes = new System.Windows.Forms.Button();
            this.Ligacoes_Title = new System.Windows.Forms.Label();
            this.Ligacoes_BRestore = new System.Windows.Forms.Button();
            this.Ligacoes_BCopy = new System.Windows.Forms.Button();
            this.Ligacoes_BFormat = new System.Windows.Forms.Button();
            this.Ligacoes_BClear = new System.Windows.Forms.Button();
            this.Ligacoes_Clear3 = new System.Windows.Forms.Button();
            this.Ligacoes_Clear2 = new System.Windows.Forms.Button();
            this.Ligacoes_Clear1 = new System.Windows.Forms.Button();
            this.Ligacoes_Clear4 = new System.Windows.Forms.Button();
            this.Ligacoes_Clear5 = new System.Windows.Forms.Button();
            this.Ligacoes_Clear6 = new System.Windows.Forms.Button();
            this.Ligacoes_TextBox5 = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle5 = new System.Windows.Forms.Label();
            this.Ligacoes_TextBox6 = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle6 = new System.Windows.Forms.Label();
            this.Ligacoes_TextBox4 = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle4 = new System.Windows.Forms.Label();
            this.Ligacoes_TextBox3 = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle3 = new System.Windows.Forms.Label();
            this.Ligacoes_TextBox2 = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle2 = new System.Windows.Forms.Label();
            this.Ligacoes_TextBox1 = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle1 = new System.Windows.Forms.Label();
            this.Ligacoes_FinalTextBox = new System.Windows.Forms.RichTextBox();
            this.Ligacoes_BExemplos = new System.Windows.Forms.Button();
            this.LigacoesRow2 = new System.Windows.Forms.PictureBox();
            this.LigacoesRow1 = new System.Windows.Forms.PictureBox();
            this.tabOutros = new System.Windows.Forms.TabPage();
            this.Outros_CheckBox_ShowTrueScript = new System.Windows.Forms.CheckBox();
            this.Outros_Button_Logs = new System.Windows.Forms.Button();
            this.Outros_Button_ApplyTestValues = new System.Windows.Forms.Button();
            this.Outros_TypeLabel = new System.Windows.Forms.Label();
            this.Outros_TypeComboBox = new System.Windows.Forms.ComboBox();
            this.Outros_ButtonForCopy = new System.Windows.Forms.Button();
            this.Outros_ButtonCopy = new System.Windows.Forms.Button();
            this.Outros_ButtonFormat = new System.Windows.Forms.Button();
            this.HomeButton_Outros = new System.Windows.Forms.Button();
            this.Outros_Script_Title = new System.Windows.Forms.Label();
            this.Outros_FinalTextBox = new System.Windows.Forms.RichTextBox();
            this.Outros_Title = new System.Windows.Forms.Label();
            this.TabSubOutros = new System.Windows.Forms.TabControl();
            this.Outros_TabQoS = new System.Windows.Forms.TabPage();
            this.Outros_VarDeleteCalc = new System.Windows.Forms.Button();
            this.Outros_QoS_CiscoCheckBox = new System.Windows.Forms.CheckBox();
            this.Outros_VarDeleteQoS8 = new System.Windows.Forms.Button();
            this.Outros_VarDeleteQoS7 = new System.Windows.Forms.Button();
            this.Outros_VarDeleteQoS3 = new System.Windows.Forms.Button();
            this.Outros_VarDeleteQoS2 = new System.Windows.Forms.Button();
            this.Outros_VarDeleteQoS4 = new System.Windows.Forms.Button();
            this.Outros_VarDeleteQoS1 = new System.Windows.Forms.Button();
            this.Outros_VarDeleteQoS0 = new System.Windows.Forms.Button();
            this.Outros_QoSCalcLabel = new System.Windows.Forms.Label();
            this.Outros_QoS_ClearButton = new System.Windows.Forms.Button();
            this.Outros_QoS_Guide = new System.Windows.Forms.Label();
            this.Outros_VarTextPercQoS03 = new System.Windows.Forms.TextBox();
            this.Outros_VarTextPercQoS06 = new System.Windows.Forms.TextBox();
            this.Outros_VarTextPercQoS05 = new System.Windows.Forms.TextBox();
            this.Outros_VarTextPercQoS02 = new System.Windows.Forms.TextBox();
            this.Outros_VarTextPercQoS04 = new System.Windows.Forms.TextBox();
            this.Outros_VarTextPercQoS01 = new System.Windows.Forms.TextBox();
            this.Outros_VarTextPercQoS00 = new System.Windows.Forms.TextBox();
            this.Outros_VarTextQoS03 = new System.Windows.Forms.TextBox();
            this.Outros_VarNameQoS3 = new System.Windows.Forms.Label();
            this.Outros_QoSDispTotal = new System.Windows.Forms.Label();
            this.Outros_QoSCalcEx = new System.Windows.Forms.Label();
            this.Outros_QoSCalcText = new System.Windows.Forms.TextBox();
            this.Outros_VarTextQoS08 = new System.Windows.Forms.TextBox();
            this.Outros_VarNameQoS8 = new System.Windows.Forms.Label();
            this.Outros_VarTextQoS07 = new System.Windows.Forms.TextBox();
            this.Outros_VarNameQoS7 = new System.Windows.Forms.Label();
            this.Outros_VarDeleteQoS6 = new System.Windows.Forms.Button();
            this.Outros_VarTextQoS06 = new System.Windows.Forms.TextBox();
            this.Outros_VarNameQoS6 = new System.Windows.Forms.Label();
            this.Outros_VarDeleteQoS5 = new System.Windows.Forms.Button();
            this.Outros_VarTextQoS05 = new System.Windows.Forms.TextBox();
            this.Outros_VarTextQoS02 = new System.Windows.Forms.TextBox();
            this.Outros_VarTextQoS04 = new System.Windows.Forms.TextBox();
            this.Outros_VarTextQoS01 = new System.Windows.Forms.TextBox();
            this.Outros_VarNameQoS2 = new System.Windows.Forms.Label();
            this.Outros_VarNameQoS5 = new System.Windows.Forms.Label();
            this.Outros_VarNameQoS4 = new System.Windows.Forms.Label();
            this.Outros_VarNameQoS1 = new System.Windows.Forms.Label();
            this.Outros_VarNameQoS0 = new System.Windows.Forms.Label();
            this.Outros_VarTextQoS00 = new System.Windows.Forms.TextBox();
            this.Outros_TabSNMP = new System.Windows.Forms.TabPage();
            this.Outros_SNMP_VarLabel2 = new System.Windows.Forms.Label();
            this.Outros_SNMP_VarPrivComboBox = new System.Windows.Forms.ComboBox();
            this.Outros_SNMP_ExLabel2 = new System.Windows.Forms.Label();
            this.Outros_SNMP_VarDelete1 = new System.Windows.Forms.Button();
            this.Outros_SNMP_ExTitle = new System.Windows.Forms.Label();
            this.Outros_SNMP_ExLabel1 = new System.Windows.Forms.Label();
            this.Outros_SNMP_ExLabel0 = new System.Windows.Forms.Label();
            this.Outros_SNMP_VarDelete0 = new System.Windows.Forms.Button();
            this.Outros_SNMP_ClearButton = new System.Windows.Forms.Button();
            this.Outros_SNMP_VarText1 = new System.Windows.Forms.TextBox();
            this.Outros_SNMP_VarLabel1 = new System.Windows.Forms.Label();
            this.Outros_SNMP_VarLabel0 = new System.Windows.Forms.Label();
            this.Outros_SNMP_VarText0 = new System.Windows.Forms.TextBox();
            this.Outros_SNMP_Guide = new System.Windows.Forms.Label();
            this.Outros_SNMP_VarTitle = new System.Windows.Forms.Label();
            this.Outros_TabRegraAdc = new System.Windows.Forms.TabPage();
            this.Outros_RegraAdc_ExLabel4 = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_DelButton4 = new System.Windows.Forms.Button();
            this.Outros_RegraAdc_Label4 = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_VarText4 = new System.Windows.Forms.TextBox();
            this.Outros_RegraAdc_DelButton3 = new System.Windows.Forms.Button();
            this.Outros_RegraAdc_ExLabel3 = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_VarText3 = new System.Windows.Forms.TextBox();
            this.Outros_RegraAdc_Label3 = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_AligeraCheckBox = new System.Windows.Forms.CheckBox();
            this.Outros_RegraAdc_ISRCheckBox = new System.Windows.Forms.CheckBox();
            this.Outros_RegraAdc_NumDaRegraComboBox = new System.Windows.Forms.ComboBox();
            this.Outros_RegraAdc_Guide = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_DelButton2 = new System.Windows.Forms.Button();
            this.Outros_RegraAdc_DelButton1 = new System.Windows.Forms.Button();
            this.Outros_RegraAdc_ExTitle = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_ExLabel2 = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_ExLabel1 = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_ExLabel0 = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_DelButton0 = new System.Windows.Forms.Button();
            this.Outros_RegraAdc_ClearButton = new System.Windows.Forms.Button();
            this.Outros_RegraAdc_VarText2 = new System.Windows.Forms.TextBox();
            this.Outros_RegraAdc_VarText1 = new System.Windows.Forms.TextBox();
            this.Outros_RegraAdc_Label1 = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_Label0 = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_VarText0 = new System.Windows.Forms.TextBox();
            this.Outros_RegraAdc_VarTitle = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_NumRegraLabel = new System.Windows.Forms.Label();
            this.Outros_RegraAdc_Label2 = new System.Windows.Forms.Label();
            this.Outros_TabBGP = new System.Windows.Forms.TabPage();
            this.Outros_BGP_ExLabel5 = new System.Windows.Forms.Label();
            this.Outros_BGP_DeleteVar5 = new System.Windows.Forms.Button();
            this.Outros_BGP_Label5 = new System.Windows.Forms.Label();
            this.Outros_BGP_VarText5 = new System.Windows.Forms.TextBox();
            this.Outros_BGP_ExLabel4 = new System.Windows.Forms.Label();
            this.Outros_BGP_DeleteVar4 = new System.Windows.Forms.Button();
            this.Outros_BGP_Label4 = new System.Windows.Forms.Label();
            this.Outros_BGP_VarText4 = new System.Windows.Forms.TextBox();
            this.Outros_BGP_ExLabel3 = new System.Windows.Forms.Label();
            this.Outros_BGP_DeleteVar3 = new System.Windows.Forms.Button();
            this.Outros_BGP_Label3 = new System.Windows.Forms.Label();
            this.Outros_BGP_VarText3 = new System.Windows.Forms.TextBox();
            this.Outros_BGP_Guide = new System.Windows.Forms.Label();
            this.Outros_BGP_DeleteVar2 = new System.Windows.Forms.Button();
            this.Outros_BGP_DeleteVar1 = new System.Windows.Forms.Button();
            this.Outros_BGP_ExTitle = new System.Windows.Forms.Label();
            this.Outros_BGP_ExLabel2 = new System.Windows.Forms.Label();
            this.Outros_BGP_ExLabel1 = new System.Windows.Forms.Label();
            this.Outros_BGP_ExLabel0 = new System.Windows.Forms.Label();
            this.Outros_BGP_DeleteVar0 = new System.Windows.Forms.Button();
            this.Outros_BGP_DeleteAll = new System.Windows.Forms.Button();
            this.Outros_BGP_VarText2 = new System.Windows.Forms.TextBox();
            this.Outros_BGP_VarText1 = new System.Windows.Forms.TextBox();
            this.Outros_BGP_Label2 = new System.Windows.Forms.Label();
            this.Outros_BGP_Label1 = new System.Windows.Forms.Label();
            this.Outros_BGP_Label0 = new System.Windows.Forms.Label();
            this.Outros_BGP_VarText0 = new System.Windows.Forms.TextBox();
            this.Outros_BGP_VarTitle = new System.Windows.Forms.Label();
            this.Outros_TabDHCP = new System.Windows.Forms.TabPage();
            this.Outros_DHCP_ExLabel5 = new System.Windows.Forms.Label();
            this.Outros_DHCP_ExLabel4 = new System.Windows.Forms.Label();
            this.Outros_DHCP_DelButton0 = new System.Windows.Forms.Button();
            this.Outros_DHCP_VarText0 = new System.Windows.Forms.TextBox();
            this.Outros_DHCP_MascaraBox = new System.Windows.Forms.ComboBox();
            this.Outros_DHCP_DelButton5 = new System.Windows.Forms.Button();
            this.Outros_DHCP_VarText10 = new System.Windows.Forms.TextBox();
            this.Outros_DHCP_Label5 = new System.Windows.Forms.Label();
            this.Outros_DHCP_DelButton4 = new System.Windows.Forms.Button();
            this.Outros_DHCP_VarText9 = new System.Windows.Forms.TextBox();
            this.Outros_DHCP_Label4 = new System.Windows.Forms.Label();
            this.Outros_DHCP_SubTitle = new System.Windows.Forms.Label();
            this.Outros_DHCP_DelButton8 = new System.Windows.Forms.Button();
            this.Outros_DHCP_ExLabel8 = new System.Windows.Forms.Label();
            this.Outros_DHCP_VarText7 = new System.Windows.Forms.TextBox();
            this.Outros_DHCP_Label8 = new System.Windows.Forms.Label();
            this.Outros_DHCP_DelButton7 = new System.Windows.Forms.Button();
            this.Outros_DHCP_ExLabel7 = new System.Windows.Forms.Label();
            this.Outros_DHCP_VarText6 = new System.Windows.Forms.TextBox();
            this.Outros_DHCP_Label7 = new System.Windows.Forms.Label();
            this.Outros_DHCP_DelButton6 = new System.Windows.Forms.Button();
            this.Outros_DHCP_ExLabel6 = new System.Windows.Forms.Label();
            this.Outros_DHCP_VarText5 = new System.Windows.Forms.TextBox();
            this.Outros_DHCP_Label6 = new System.Windows.Forms.Label();
            this.Outros_DHCP_DelButton3 = new System.Windows.Forms.Button();
            this.Outros_DHCP_ExLabel3 = new System.Windows.Forms.Label();
            this.Outros_DHCP_VarText4 = new System.Windows.Forms.TextBox();
            this.Outros_DHCP_Label3 = new System.Windows.Forms.Label();
            this.Outros_DHCP_DelButton2 = new System.Windows.Forms.Button();
            this.Outros_DHCP_ExLabel2 = new System.Windows.Forms.Label();
            this.Outros_DHCP_VarText3 = new System.Windows.Forms.TextBox();
            this.Outros_DHCP_Label2 = new System.Windows.Forms.Label();
            this.Outros_DHCP_Guide = new System.Windows.Forms.Label();
            this.Outros_DHCP_DelButton1 = new System.Windows.Forms.Button();
            this.Outros_DHCP_DelButton9 = new System.Windows.Forms.Button();
            this.Outros_DHCP_ExTitle = new System.Windows.Forms.Label();
            this.Outros_DHCP_ExLabel1 = new System.Windows.Forms.Label();
            this.Outros_DHCP_ExLabel9 = new System.Windows.Forms.Label();
            this.Outros_DHCP_ExLabel0 = new System.Windows.Forms.Label();
            this.Outros_DHCP_ClearButton = new System.Windows.Forms.Button();
            this.Outros_DHCP_VarText1 = new System.Windows.Forms.TextBox();
            this.Outros_DHCP_VarText8 = new System.Windows.Forms.TextBox();
            this.Outros_DHCP_Label1 = new System.Windows.Forms.Label();
            this.Outros_DHCP_Label9 = new System.Windows.Forms.Label();
            this.Outros_DHCP_Label0 = new System.Windows.Forms.Label();
            this.Outros_DHCP_VarTitle = new System.Windows.Forms.Label();
            this.Outros_TabVlan = new System.Windows.Forms.TabPage();
            this.Outros_VLAN_FortigateButton = new System.Windows.Forms.Button();
            this.Outros_VLAN_CatalystCheckBox = new System.Windows.Forms.CheckBox();
            this.Outros_VLAN_MascaraBox = new System.Windows.Forms.ComboBox();
            this.Outros_VLAN_Guide = new System.Windows.Forms.Label();
            this.Outros_VLAN_VarDel1 = new System.Windows.Forms.Button();
            this.Outros_VLAN_ExTitleLabel = new System.Windows.Forms.Label();
            this.Outros_VLAN_ExLabel1 = new System.Windows.Forms.Label();
            this.Outros_VLAN_ExLabel0 = new System.Windows.Forms.Label();
            this.Outros_VLAN_VarDel0 = new System.Windows.Forms.Button();
            this.Outros_VLAN_ClearAllButton = new System.Windows.Forms.Button();
            this.Outros_VLAN_VarText1 = new System.Windows.Forms.TextBox();
            this.Outros_VLAN_VarLabel1 = new System.Windows.Forms.Label();
            this.Outros_VLAN_VarLabel0 = new System.Windows.Forms.Label();
            this.Outros_VLAN_VarText0 = new System.Windows.Forms.TextBox();
            this.Outros_VLAN_LabelTitle = new System.Windows.Forms.Label();
            this.Outros_TabUSUARIOS = new System.Windows.Forms.TabPage();
            this.Outros_User_Hint = new System.Windows.Forms.Label();
            this.Outros_User_Guide = new System.Windows.Forms.Label();
            this.Outros_User_Label2 = new System.Windows.Forms.Label();
            this.Outros_User_VarPrivBox = new System.Windows.Forms.ComboBox();
            this.Outros_User_VarDelete1 = new System.Windows.Forms.Button();
            this.Outros_User_ExTitle = new System.Windows.Forms.Label();
            this.Outros_User_ExLabel2 = new System.Windows.Forms.Label();
            this.Outros_User_ExLabel1 = new System.Windows.Forms.Label();
            this.Outros_User_ExLabel0 = new System.Windows.Forms.Label();
            this.Outros_User_VarDelete0 = new System.Windows.Forms.Button();
            this.Outros_User_ClearButton = new System.Windows.Forms.Button();
            this.Outros_User_VarText1 = new System.Windows.Forms.TextBox();
            this.Outros_User_Label1 = new System.Windows.Forms.Label();
            this.Outros_User_Label0 = new System.Windows.Forms.Label();
            this.Outros_User_VarText0 = new System.Windows.Forms.TextBox();
            this.Outros_User_VarTitle = new System.Windows.Forms.Label();
            this.Outros_Tab_FortiVlan = new System.Windows.Forms.TabPage();
            this.Outros_FortiVlan_Label = new System.Windows.Forms.Label();
            this.Outros_TabFortiExtras = new System.Windows.Forms.TabPage();
            this.label72 = new System.Windows.Forms.Label();
            this.Outros_TabIPFLow = new System.Windows.Forms.TabPage();
            this.Outros_IPFlow_DelButton2 = new System.Windows.Forms.Button();
            this.Outros_IPFlow_DelButton1 = new System.Windows.Forms.Button();
            this.Outros_IPFlow_ExTitle = new System.Windows.Forms.Label();
            this.Outros_IPFlow_ExLabel2 = new System.Windows.Forms.Label();
            this.Outros_IPFlow_ExLabel1 = new System.Windows.Forms.Label();
            this.Outros_IPFlow_ExLabel0 = new System.Windows.Forms.Label();
            this.Outros_IPFlow_DelButton0 = new System.Windows.Forms.Button();
            this.Outros_IPFlow_ClearButton = new System.Windows.Forms.Button();
            this.Outros_IPFlow_VarText2 = new System.Windows.Forms.TextBox();
            this.Outros_IPFlow_VarText1 = new System.Windows.Forms.TextBox();
            this.Outros_IPFlow_Label2 = new System.Windows.Forms.Label();
            this.Outros_IPFlow_Label1 = new System.Windows.Forms.Label();
            this.Outros_IPFlow_Label0 = new System.Windows.Forms.Label();
            this.Outros_IPFlow_VarText0 = new System.Windows.Forms.TextBox();
            this.Outros_IPFlow_VarTitle = new System.Windows.Forms.Label();
            this.Outros_IPFlow_Guide = new System.Windows.Forms.Label();
            this.Outros_TabRIP = new System.Windows.Forms.TabPage();
            this.label73 = new System.Windows.Forms.Label();
            this.Outros_TabOSPF = new System.Windows.Forms.TabPage();
            this.label74 = new System.Windows.Forms.Label();
            this.Outros_TabVRRP = new System.Windows.Forms.TabPage();
            this.Outro_VRRP_DelButton12 = new System.Windows.Forms.Button();
            this.Outro_VRRP_VarText12 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_Label12 = new System.Windows.Forms.Label();
            this.Outro_VRRP_DelButton11 = new System.Windows.Forms.Button();
            this.Outro_VRRP_VarText11 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_Label11 = new System.Windows.Forms.Label();
            this.Outro_VRRP_DelButton7 = new System.Windows.Forms.Button();
            this.Outro_VRRP_VarText7 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_Label7 = new System.Windows.Forms.Label();
            this.Outro_VRRP_DelButton6 = new System.Windows.Forms.Button();
            this.Outro_VRRP_VarText6 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_Label6 = new System.Windows.Forms.Label();
            this.Outro_VRRP_DelButton10 = new System.Windows.Forms.Button();
            this.Outro_VRRP_DelButton9 = new System.Windows.Forms.Button();
            this.Outro_VRRP_ExTitle2 = new System.Windows.Forms.Label();
            this.Outro_VRRP_ExLabel10 = new System.Windows.Forms.Label();
            this.Outro_VRRP_ExLabel9 = new System.Windows.Forms.Label();
            this.Outro_VRRP_ExLabel8 = new System.Windows.Forms.Label();
            this.Outro_VRRP_DelButton8 = new System.Windows.Forms.Button();
            this.Outro_VRRP_ClearButton2 = new System.Windows.Forms.Button();
            this.Outro_VRRP_VarText10 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_VarText9 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_Label10 = new System.Windows.Forms.Label();
            this.Outro_VRRP_Label9 = new System.Windows.Forms.Label();
            this.Outro_VRRP_VarText8 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_Label8 = new System.Windows.Forms.Label();
            this.Outro_VRRP_SubTitle2 = new System.Windows.Forms.Label();
            this.Outro_VRRP_DelButton5 = new System.Windows.Forms.Button();
            this.Outro_VRRP_DelButton4 = new System.Windows.Forms.Button();
            this.Outro_VRRP_ExTitle1 = new System.Windows.Forms.Label();
            this.Outro_VRRP_ExLabel5 = new System.Windows.Forms.Label();
            this.Outro_VRRP_ExLabel4 = new System.Windows.Forms.Label();
            this.Outro_VRRP_ExLabel3 = new System.Windows.Forms.Label();
            this.Outro_VRRP_DelButton3 = new System.Windows.Forms.Button();
            this.Outro_VRRP_ClearButton1 = new System.Windows.Forms.Button();
            this.Outro_VRRP_VarText5 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_VarText4 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_Label5 = new System.Windows.Forms.Label();
            this.Outro_VRRP_Label4 = new System.Windows.Forms.Label();
            this.Outro_VRRP_Label3 = new System.Windows.Forms.Label();
            this.Outro_VRRP_VarText3 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_SubTitle1 = new System.Windows.Forms.Label();
            this.Outro_VRRP_DelButton2 = new System.Windows.Forms.Button();
            this.Outro_VRRP_DelButton1 = new System.Windows.Forms.Button();
            this.Outro_VRRP_ExTitle0 = new System.Windows.Forms.Label();
            this.Outro_VRRP_ExLabel2 = new System.Windows.Forms.Label();
            this.Outro_VRRP_ExLabel1 = new System.Windows.Forms.Label();
            this.Outro_VRRP_ExLabel0 = new System.Windows.Forms.Label();
            this.Outro_VRRP_DelButton0 = new System.Windows.Forms.Button();
            this.Outro_VRRP_ClearButton0 = new System.Windows.Forms.Button();
            this.Outro_VRRP_VarText2 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_VarText1 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_Label2 = new System.Windows.Forms.Label();
            this.Outro_VRRP_Label1 = new System.Windows.Forms.Label();
            this.Outro_VRRP_Label0 = new System.Windows.Forms.Label();
            this.Outro_VRRP_VarText0 = new System.Windows.Forms.TextBox();
            this.Outro_VRRP_SubTitle0 = new System.Windows.Forms.Label();
            this.Outro_VRRP_CheckBoxCisco = new System.Windows.Forms.CheckBox();
            this.Outro_VRRP_Guide = new System.Windows.Forms.Label();
            this.Outros_TabGLBP = new System.Windows.Forms.TabPage();
            this.label76 = new System.Windows.Forms.Label();
            this.Outros_TabEIGRP = new System.Windows.Forms.TabPage();
            this.label77 = new System.Windows.Forms.Label();
            this.Outros_TabHotline = new System.Windows.Forms.TabPage();
            this.label78 = new System.Windows.Forms.Label();
            this.Outros_Tab_HSRP = new System.Windows.Forms.TabPage();
            this.Outros_HSRP_Label = new System.Windows.Forms.Label();
            this.Outros_TabPortBlock = new System.Windows.Forms.TabPage();
            this.Outros_PortBlock_ExLabel3 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Delete3 = new System.Windows.Forms.Button();
            this.Outros_PortBlock_Label3 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_TextBox3 = new System.Windows.Forms.TextBox();
            this.Outros_PortBlock_ClearButton = new System.Windows.Forms.Button();
            this.Outros_PortBlock_HPEold = new System.Windows.Forms.CheckBox();
            this.Outros_PortBlock_ExLabel2 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Delete2 = new System.Windows.Forms.Button();
            this.Outros_PortBlock_Label2 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_TextBox2 = new System.Windows.Forms.TextBox();
            this.Outros_PortBlock_ExLabel1 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Delete1 = new System.Windows.Forms.Button();
            this.Outros_PortBlock_Label1 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_TextBox1 = new System.Windows.Forms.TextBox();
            this.Outros_PortBlock_Label19 = new System.Windows.Forms.Label();
            this.Outros_PortBLock_ComboBox15 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox16 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBlock_Label18 = new System.Windows.Forms.Label();
            this.Outros_PortBLock_ComboBox14 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBlock_Label17 = new System.Windows.Forms.Label();
            this.Outros_PortBLock_ComboBox13 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBlock_Label16 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label15 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label13 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label12 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label11 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label10 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label9 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label8 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label7 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label6 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_ChangeAllButton = new System.Windows.Forms.Button();
            this.Outros_PortBlock_Guide = new System.Windows.Forms.Label();
            this.Outros_PortBlock_ExLabelTitle = new System.Windows.Forms.Label();
            this.Outros_PortBlock_ExLabel0 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Delete0 = new System.Windows.Forms.Button();
            this.Outros_PortBlock_Label0 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_TextBox0 = new System.Windows.Forms.TextBox();
            this.Outros_PortBlock_LabelTitle = new System.Windows.Forms.Label();
            this.Outros_PortBLock_ComboBox12 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox11 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox10 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox9 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox8 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox7 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox6 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox5 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox4 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox3 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBLock_ComboBox0 = new System.Windows.Forms.ComboBox();
            this.Outros_PortBlock_Label4 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label5 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label14 = new System.Windows.Forms.Label();
            this.Outros_PortBlock_Label20 = new System.Windows.Forms.Label();
            this.tabSelectClient = new System.Windows.Forms.TabPage();
            this.Client_NovoButton = new System.Windows.Forms.Button();
            this.Client_TesteClient = new System.Windows.Forms.Button();
            this.SelectClientTitle = new System.Windows.Forms.Label();
            this.HomeButton_ClientList = new System.Windows.Forms.Button();
            this.SelectClientRow = new System.Windows.Forms.PictureBox();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.Client_ButtonCopyForm = new System.Windows.Forms.Button();
            this.Client_ButtonCopy = new System.Windows.Forms.Button();
            this.Client_ButtonFormat = new System.Windows.Forms.Button();
            this.Client_ButtonRestore = new System.Windows.Forms.Button();
            this.Client_CriticalyLabel = new System.Windows.Forms.Label();
            this.Client_VarEx09 = new System.Windows.Forms.Label();
            this.Client_VarDelete09 = new System.Windows.Forms.Button();
            this.Client_NameVar09 = new System.Windows.Forms.Label();
            this.Client_VarText09 = new System.Windows.Forms.TextBox();
            this.Client_VarEx08 = new System.Windows.Forms.Label();
            this.Client_VarDelete08 = new System.Windows.Forms.Button();
            this.Client_NameVar08 = new System.Windows.Forms.Label();
            this.Client_VarText08 = new System.Windows.Forms.TextBox();
            this.Client_VarEx07 = new System.Windows.Forms.Label();
            this.Client_VarDelete07 = new System.Windows.Forms.Button();
            this.Client_NameVar07 = new System.Windows.Forms.Label();
            this.Client_VarText07 = new System.Windows.Forms.TextBox();
            this.Client_VarEx06 = new System.Windows.Forms.Label();
            this.Client_VarDelete06 = new System.Windows.Forms.Button();
            this.Client_NameVar06 = new System.Windows.Forms.Label();
            this.Client_VarText06 = new System.Windows.Forms.TextBox();
            this.Client_VarEx05 = new System.Windows.Forms.Label();
            this.Client_VarDelete05 = new System.Windows.Forms.Button();
            this.Client_NameVar05 = new System.Windows.Forms.Label();
            this.Client_VarText05 = new System.Windows.Forms.TextBox();
            this.Client_VarEx04 = new System.Windows.Forms.Label();
            this.Client_VarDelete04 = new System.Windows.Forms.Button();
            this.Client_NameVar04 = new System.Windows.Forms.Label();
            this.Client_VarText04 = new System.Windows.Forms.TextBox();
            this.Client_VarEx03 = new System.Windows.Forms.Label();
            this.Client_VarDelete03 = new System.Windows.Forms.Button();
            this.Client_NameVar03 = new System.Windows.Forms.Label();
            this.Client_VarText03 = new System.Windows.Forms.TextBox();
            this.Client_VarEx02 = new System.Windows.Forms.Label();
            this.Client_VarDelete02 = new System.Windows.Forms.Button();
            this.Client_NameVar02 = new System.Windows.Forms.Label();
            this.Client_VarText02 = new System.Windows.Forms.TextBox();
            this.Client_VarEx01 = new System.Windows.Forms.Label();
            this.Client_VarDelete01 = new System.Windows.Forms.Button();
            this.Client_NameVar01 = new System.Windows.Forms.Label();
            this.Client_VarText01 = new System.Windows.Forms.TextBox();
            this.Client_ExSubTitle = new System.Windows.Forms.Label();
            this.Client_VarEx00 = new System.Windows.Forms.Label();
            this.Client_VarDelete00 = new System.Windows.Forms.Button();
            this.Client_ButtonDeleteAll = new System.Windows.Forms.Button();
            this.Client_VarSubTitle = new System.Windows.Forms.Label();
            this.Client_NameVar00 = new System.Windows.Forms.Label();
            this.Client_VarText00 = new System.Windows.Forms.TextBox();
            this.Client_StepScript = new System.Windows.Forms.RichTextBox();
            this.Client_NameTitle = new System.Windows.Forms.Label();
            this.Client_StepText = new System.Windows.Forms.Label();
            this.BackButton_ClientSteps = new System.Windows.Forms.Button();
            this.HomeButton_ClientSteps = new System.Windows.Forms.Button();
            this.Client_NextStep = new System.Windows.Forms.Button();
            this.Client_BackStep = new System.Windows.Forms.Button();
            this.Client_StepPicture = new System.Windows.Forms.PictureBox();
            this.Client_Row0 = new System.Windows.Forms.PictureBox();
            this.Client_Row1 = new System.Windows.Forms.PictureBox();
            this.OpenPE_Button = new System.Windows.Forms.Button();
            this.OpenPE_PictureBox = new System.Windows.Forms.PictureBox();
            this.Button_ImportSAIP = new System.Windows.Forms.Button();
            this.tabLogTools = new System.Windows.Forms.TabPage();
            this.LogTools_MainRow = new System.Windows.Forms.PictureBox();
            this.LogTools_DBScriptButton = new System.Windows.Forms.Button();
            this.LogToolsCalc = new System.Windows.Forms.Button();
            this.LogToolsSuporte = new System.Windows.Forms.Button();
            this.LogToolsFechamento = new System.Windows.Forms.Button();
            this.LogToolsPendencia = new System.Windows.Forms.Button();
            this.tabControlLogTools = new System.Windows.Forms.TabControl();
            this.tabPendencia = new System.Windows.Forms.TabPage();
            this.Log_TextBox2 = new System.Windows.Forms.RichTextBox();
            this.Log_TextBox3 = new System.Windows.Forms.RichTextBox();
            this.Log_TextBox1 = new System.Windows.Forms.RichTextBox();
            this.Log_Copy = new System.Windows.Forms.Button();
            this.Log_FinalTextBox = new System.Windows.Forms.RichTextBox();
            this.Log_ButtonRestore = new System.Windows.Forms.Button();
            this.Log_Clear3 = new System.Windows.Forms.Button();
            this.Log_Clear2 = new System.Windows.Forms.Button();
            this.Log_Clear1 = new System.Windows.Forms.Button();
            this.Log_CopyF = new System.Windows.Forms.Button();
            this.Log_ClearAll = new System.Windows.Forms.Button();
            this.Log_Format = new System.Windows.Forms.Button();
            this.Log_ProximosPassos = new System.Windows.Forms.Label();
            this.Log_StatusAtual = new System.Windows.Forms.Label();
            this.Log_StatusAnterior = new System.Windows.Forms.Label();
            this.tabFechamento = new System.Windows.Forms.TabPage();
            this.LTFechamento_TextBoxObs = new System.Windows.Forms.RichTextBox();
            this.LTFechamento_ValidacaoTextBox = new System.Windows.Forms.RichTextBox();
            this.LTFechamento_TextBox = new System.Windows.Forms.RichTextBox();
            this.LTFechamento_CheckBox5 = new System.Windows.Forms.CheckBox();
            this.LTFechamento_ButtonCopy = new System.Windows.Forms.Button();
            this.LTFechamento_ButtonFormat = new System.Windows.Forms.Button();
            this.LTFechamento_ButtonClear2 = new System.Windows.Forms.Button();
            this.LTFechamento_ButtonClear1 = new System.Windows.Forms.Button();
            this.LTFechamento_CheckBox2 = new System.Windows.Forms.CheckBox();
            this.LTFechamento_CheckBox4 = new System.Windows.Forms.CheckBox();
            this.LTFechamento_CheckBox1 = new System.Windows.Forms.CheckBox();
            this.LTFechamento_OBSTitle = new System.Windows.Forms.Label();
            this.LTFechamento_ButtonClear = new System.Windows.Forms.Button();
            this.LTFechamento_CheckBox3 = new System.Windows.Forms.CheckBox();
            this.LTFechamento_BFormatCopy = new System.Windows.Forms.Button();
            this.LTFechamento_CheckBox0 = new System.Windows.Forms.CheckBox();
            this.LTFechamento_Title = new System.Windows.Forms.Label();
            this.LTFechamento_ContatoLabel = new System.Windows.Forms.Label();
            this.LTFechamento_Row = new System.Windows.Forms.PictureBox();
            this.tabCalculadoraDeIP = new System.Windows.Forms.TabPage();
            this.LTCalc_ButtonCopy = new System.Windows.Forms.Button();
            this.LTCalc_SubTitle = new System.Windows.Forms.Label();
            this.LTCalc_buttonCalc = new System.Windows.Forms.Button();
            this.LTCalc_Hint = new System.Windows.Forms.Label();
            this.LTCalc_Title = new System.Windows.Forms.Label();
            this.LTCalc_Result = new System.Windows.Forms.Label();
            this.LTCalc_IPTextBox = new System.Windows.Forms.RichTextBox();
            this.tabSuporte = new System.Windows.Forms.TabPage();
            this.LTSup_buttonCopy = new System.Windows.Forms.Button();
            this.LTSup_buttonForm = new System.Windows.Forms.Button();
            this.ButtonLT_ClearCommand = new System.Windows.Forms.Button();
            this.ButtonLT_ResetCommand = new System.Windows.Forms.Button();
            this.LTSup_buttonClear = new System.Windows.Forms.Button();
            this.ButtonLT_AdcCommand = new System.Windows.Forms.Button();
            this.LTSuporte_DescripTitle = new System.Windows.Forms.Label();
            this.LTSuporte_ComandoTitle = new System.Windows.Forms.Label();
            this.LogToolsSuporteTitle = new System.Windows.Forms.Label();
            this.LTSup_buttonCopyF = new System.Windows.Forms.Button();
            this.LT_SuporteTitleTextBox = new System.Windows.Forms.RichTextBox();
            this.LT_SuporteComTextBox = new System.Windows.Forms.RichTextBox();
            this.LTSuporteFinalTextBox = new System.Windows.Forms.RichTextBox();
            this.LT_Suporte_Row = new System.Windows.Forms.PictureBox();
            this.tabScriptDB = new System.Windows.Forms.TabPage();
            this.Script_DB_Label = new System.Windows.Forms.Label();
            this.Script_DB_ClearButton1 = new System.Windows.Forms.Button();
            this.Script_DB_ClearButton2 = new System.Windows.Forms.Button();
            this.Script_DB_Hint2 = new System.Windows.Forms.Label();
            this.Script_DB_VarTextBox = new System.Windows.Forms.TextBox();
            this.Script_DB_LabelTest = new System.Windows.Forms.Label();
            this.Script_DB_VarEnterButton = new System.Windows.Forms.Button();
            this.Script_DB_InButton = new System.Windows.Forms.Button();
            this.Script_DB_OutButton = new System.Windows.Forms.Button();
            this.Script_DB_SubLabel2 = new System.Windows.Forms.Label();
            this.Script_DB_Hint1 = new System.Windows.Forms.Label();
            this.Script_DB_SubLabel1 = new System.Windows.Forms.Label();
            this.Script_DB_TextBox1 = new System.Windows.Forms.TextBox();
            this.Script_DB_TextBox2 = new System.Windows.Forms.TextBox();
            this.tabRouters = new System.Windows.Forms.TabPage();
            this.tabPreferencias = new System.Windows.Forms.TabPage();
            this.Prefs_Row0 = new System.Windows.Forms.PictureBox();
            this.Prefs_Row1 = new System.Windows.Forms.PictureBox();
            this.Prefs_Row2 = new System.Windows.Forms.PictureBox();
            this.List_All_Scritps = new System.Windows.Forms.Button();
            this.Button_NightMode = new System.Windows.Forms.Button();
            this.Button_EditScript = new System.Windows.Forms.Button();
            this.Pref_Putty_SearchButton = new System.Windows.Forms.Button();
            this.Pref_Putty_SaveButton = new System.Windows.Forms.Button();
            this.Pref_Putty_PathTextBox = new System.Windows.Forms.TextBox();
            this.ResetValue_Button = new System.Windows.Forms.Button();
            this.Pref_Putty_TitleLabel = new System.Windows.Forms.Label();
            this.Pref_TACACS_TitleLabel = new System.Windows.Forms.Label();
            this.Pref_TACACS_SubLabel2 = new System.Windows.Forms.Label();
            this.Pref_TACACS_SubLabel1 = new System.Windows.Forms.Label();
            this.Pref_TACACS_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Pref_TACACS_UserTextBox = new System.Windows.Forms.TextBox();
            this.Pref_User_TitleLabel = new System.Windows.Forms.Label();
            this.Pref_User_SubLabel2 = new System.Windows.Forms.Label();
            this.Pref_User_SubLabel1 = new System.Windows.Forms.Label();
            this.Pref_User_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Pref_User_NameTextBox = new System.Windows.Forms.TextBox();
            this.Button_PassWordForm = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            tabControl3 = new System.Windows.Forms.TabControl();
            tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IOS_DataGrid_Routers)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMaster.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPage_TemplatesLabel_BG)).BeginInit();
            this.tabScript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Script_Row)).BeginInit();
            this.Script_ButtonsSubTab.SuspendLayout();
            this.Script_ButtonsSubTab_Voz.SuspendLayout();
            this.Script_ButtonsSubTab_Logs.SuspendLayout();
            this.Script_ButtonsSubTab_BackboneBGP.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.Script_VarSubTab.SuspendLayout();
            this.Script_SubTab_VozVar.SuspendLayout();
            this.Script_SubTab_RouteMap.SuspendLayout();
            this.tabSelectRouter.SuspendLayout();
            this.tabWizGat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WizGat_Row)).BeginInit();
            this.tabLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logs_Row2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logs_Row1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logs_Row0)).BeginInit();
            this.tabVelocloud.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.tab_VeloVars.SuspendLayout();
            this.tabLigacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LigacoesRow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LigacoesRow1)).BeginInit();
            this.tabOutros.SuspendLayout();
            this.TabSubOutros.SuspendLayout();
            this.Outros_TabQoS.SuspendLayout();
            this.Outros_TabSNMP.SuspendLayout();
            this.Outros_TabRegraAdc.SuspendLayout();
            this.Outros_TabBGP.SuspendLayout();
            this.Outros_TabDHCP.SuspendLayout();
            this.Outros_TabVlan.SuspendLayout();
            this.Outros_TabUSUARIOS.SuspendLayout();
            this.Outros_Tab_FortiVlan.SuspendLayout();
            this.Outros_TabFortiExtras.SuspendLayout();
            this.Outros_TabIPFLow.SuspendLayout();
            this.Outros_TabRIP.SuspendLayout();
            this.Outros_TabOSPF.SuspendLayout();
            this.Outros_TabVRRP.SuspendLayout();
            this.Outros_TabGLBP.SuspendLayout();
            this.Outros_TabEIGRP.SuspendLayout();
            this.Outros_TabHotline.SuspendLayout();
            this.Outros_Tab_HSRP.SuspendLayout();
            this.Outros_TabPortBlock.SuspendLayout();
            this.tabSelectClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectClientRow)).BeginInit();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Client_StepPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Client_Row0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Client_Row1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenPE_PictureBox)).BeginInit();
            this.tabLogTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogTools_MainRow)).BeginInit();
            this.tabControlLogTools.SuspendLayout();
            this.tabPendencia.SuspendLayout();
            this.tabFechamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LTFechamento_Row)).BeginInit();
            this.tabCalculadoraDeIP.SuspendLayout();
            this.tabSuporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LT_Suporte_Row)).BeginInit();
            this.tabScriptDB.SuspendLayout();
            this.tabRouters.SuspendLayout();
            this.tabPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prefs_Row0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prefs_Row1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prefs_Row2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl3
            // 
            tabControl3.AllowDrop = true;
            tabControl3.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            tabControl3.Controls.Add(this.tabPage1);
            tabControl3.Controls.Add(this.tabPage2);
            tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl3.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tabControl3.HotTrack = true;
            tabControl3.ItemSize = new System.Drawing.Size(0, 1);
            tabControl3.Location = new System.Drawing.Point(3, 3);
            tabControl3.Margin = new System.Windows.Forms.Padding(0);
            tabControl3.Name = "tabControl3";
            tabControl3.Padding = new System.Drawing.Point(0, 0);
            tabControl3.SelectedIndex = 0;
            tabControl3.ShowToolTips = true;
            tabControl3.Size = new System.Drawing.Size(1120, 593);
            tabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl3.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.IOS_Button);
            this.tabPage1.Controls.Add(this.IOS_Label0);
            this.tabPage1.Controls.Add(this.IOS_LinkLabel);
            this.tabPage1.Controls.Add(this.IOS_LabelInfo);
            this.tabPage1.Controls.Add(this.IOS_DataGrid_Routers);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1112, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // IOS_Button
            // 
            this.IOS_Button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IOS_Button.Location = new System.Drawing.Point(905, 55);
            this.IOS_Button.Name = "IOS_Button";
            this.IOS_Button.Size = new System.Drawing.Size(165, 48);
            this.IOS_Button.TabIndex = 6;
            this.IOS_Button.Text = "Instalar IOS";
            this.IOS_Button.UseVisualStyleBackColor = true;
            this.IOS_Button.Click += new System.EventHandler(this.Button_IOS_Click);
            // 
            // IOS_Label0
            // 
            this.IOS_Label0.AutoSize = true;
            this.IOS_Label0.Location = new System.Drawing.Point(6, 60);
            this.IOS_Label0.Name = "IOS_Label0";
            this.IOS_Label0.Size = new System.Drawing.Size(0, 19);
            this.IOS_Label0.TabIndex = 8;
            // 
            // IOS_LinkLabel
            // 
            this.IOS_LinkLabel.Location = new System.Drawing.Point(5, 25);
            this.IOS_LinkLabel.Name = "IOS_LinkLabel";
            this.IOS_LinkLabel.Size = new System.Drawing.Size(1090, 43);
            this.IOS_LinkLabel.TabIndex = 7;
            this.IOS_LinkLabel.TabStop = true;
            this.IOS_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // IOS_LabelInfo
            // 
            this.IOS_LabelInfo.AllowDrop = true;
            this.IOS_LabelInfo.AutoSize = true;
            this.IOS_LabelInfo.Location = new System.Drawing.Point(6, 5);
            this.IOS_LabelInfo.Name = "IOS_LabelInfo";
            this.IOS_LabelInfo.Size = new System.Drawing.Size(958, 19);
            this.IOS_LabelInfo.TabIndex = 5;
            this.IOS_LabelInfo.Text = "Caso haja questionamentos sobre as versão informadas nas tabelas abaixo, acessar " +
    "o sharepoint da Embratel pois a planilha é atualizada em tempo real. \t\t\t\t\t\r\n";
            // 
            // IOS_DataGrid_Routers
            // 
            this.IOS_DataGrid_Routers.AllowUserToAddRows = false;
            this.IOS_DataGrid_Routers.AllowUserToDeleteRows = false;
            this.IOS_DataGrid_Routers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.IOS_DataGrid_Routers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.45F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IOS_DataGrid_Routers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.IOS_DataGrid_Routers.Location = new System.Drawing.Point(0, 114);
            this.IOS_DataGrid_Routers.Name = "IOS_DataGrid_Routers";
            this.IOS_DataGrid_Routers.ReadOnly = true;
            this.IOS_DataGrid_Routers.RowHeadersVisible = false;
            this.IOS_DataGrid_Routers.Size = new System.Drawing.Size(1095, 384);
            this.IOS_DataGrid_Routers.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1112, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainTitle
            // 
            this.MainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainTitle.Location = new System.Drawing.Point(3, 3);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(1120, 71);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "MasterSheet+";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1134, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(27, 17);
            this.ToolStripStatusLabel1.Text = "Test";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMaster);
            this.tabControl1.Controls.Add(this.tabLogTools);
            this.tabControl1.Controls.Add(this.tabRouters);
            this.tabControl1.Controls.Add(this.tabPreferencias);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.45F, System.Drawing.FontStyle.Bold);
            this.tabControl1.ItemSize = new System.Drawing.Size(68, 32);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 639);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabMaster
            // 
            this.tabMaster.Controls.Add(this.OpenPE_ComboBox);
            this.tabMaster.Controls.Add(this.OpenPE_Label);
            this.tabMaster.Controls.Add(this.tabControl2);
            this.tabMaster.Controls.Add(this.OpenPE_Button);
            this.tabMaster.Controls.Add(this.OpenPE_PictureBox);
            this.tabMaster.Controls.Add(this.Button_ImportSAIP);
            this.tabMaster.Controls.Add(this.MainTitle);
            this.tabMaster.Location = new System.Drawing.Point(4, 36);
            this.tabMaster.Name = "tabMaster";
            this.tabMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaster.Size = new System.Drawing.Size(1126, 599);
            this.tabMaster.TabIndex = 0;
            this.tabMaster.Text = "Master";
            this.tabMaster.UseVisualStyleBackColor = true;
            // 
            // OpenPE_ComboBox
            // 
            this.OpenPE_ComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.45F, System.Drawing.FontStyle.Bold);
            this.OpenPE_ComboBox.FormattingEnabled = true;
            this.OpenPE_ComboBox.Items.AddRange(new object[] {
            "Nenhum PE",
            "ACC09.RJO",
            "ACR01.AJU",
            "ACR01.BHE",
            "ACR01.BLM",
            "ACR01.BRE",
            "ACR01.BRU",
            "ACR01.BSA",
            "ACR01.BVA",
            "ACR01.CAS",
            "ACR01.CBA",
            "ACR01.CEM",
            "ACR01.CIM",
            "ACR01.CPE",
            "ACR01.CPS",
            "ACR01.CSL",
            "ACR01.CTACL6",
            "ACR01.CTAMC",
            "ACR01.CTAMR",
            "ACR01.FLA",
            "ACR01.FLAJN",
            "ACR01.FNS",
            "ACR01.FSA",
            "ACR01.FSASC5",
            "ACR01.GNA",
            "ACR01.GVS",
            "ACR01.JFA",
            "ACR01.JPA",
            "ACR01.LDA",
            "ACR01.MBA",
            "ACR01.MCE",
            "ACR01.MCO",
            "ACR01.MGA",
            "ACR01.MNS",
            "ACR01.MPA",
            "ACR01.NTL",
            "ACR01.OCO",
            "ACR01.PAE",
            "ACR01.PAEMF",
            "ACR01.PMJSO",
            "ACR01.PTA",
            "ACR01.PVO",
            "ACR01.RBO",
            "ACR01.RCE",
            "ACR01.RJO",
            "ACR01.RJOEN",
            "ACR01.RPO",
            "ACR01.SBO",
            "ACR01.SDR",
            "ACR01.SJC",
            "ACR01.SLS",
            "ACR01.SNE",
            "ACR01.SOC",
            "ACR01.SPO",
            "ACR01.SPOLP",
            "ACR01.SPOMB",
            "ACR01.SPOPH",
            "ACR01.SRM",
            "ACR01.STSWL3",
            "ACR01.TSA",
            "ACR01.ULA",
            "ACR01.VRD",
            "ACR01.VTA",
            "ACR02.AJU",
            "ACR02.BHE",
            "ACR02.BLM",
            "ACR02.BR",
            "ACR02.BRU",
            "ACR02.BS",
            "ACR02.BVA",
            "ACR02.CAS",
            "ACR02.CBA",
            "ACR02.CPE",
            "ACR02.CSL",
            "ACR02.FLA",
            "ACR02.FLAJN",
            "ACR02.GNA",
            "ACR02.GVS",
            "ACR02.JFA",
            "ACR02.JPA",
            "ACR02.MBA",
            "ACR02.MCO",
            "ACR02.MNS",
            "ACR02.MPA",
            "ACR02.NTL",
            "ACR02.OCO",
            "ACR02.PAE",
            "ACR02.PAEMF",
            "ACR02.PMJSO",
            "ACR02.PVO",
            "ACR02.RBO",
            "ACR02.RCE",
            "ACR02.RJO",
            "ACR02.RJOEN",
            "ACR02.RPO",
            "ACR02.SDR",
            "ACR02.SJC",
            "ACR02.SLS",
            "ACR02.SNE",
            "ACR02.SPO",
            "ACR02.SPOLP",
            "ACR02.SPOMB",
            "ACR02.SRM",
            "ACR02.STSWL3",
            "ACR02.TSA",
            "ACR02.ULA",
            "ACR02.VTA",
            "AGG01.ADABR",
            "AGG01.AJU",
            "AGG01.AMRHZ",
            "AGG01.ANSGC",
            "AGG01.APSNT",
            "AGG01.ARCHZ",
            "AGG01.ARQARN",
            "AGG01.BERT0DW",
            "AGG01.BET0HH",
            "AGG01.BGEACM",
            "AGG01.BGP0AO",
            "AGG01.BHEGM",
            "AGG01.BNUNEO",
            "AGG01.BQE0FK",
            "AGG01.BRE",
            "AGG01.BREDV",
            "AGG01.BREEQU",
            "AGG01.BREXOX",
            "AGG01.BRU",
            "AGG01.BRUTS",
            "AGG01.BSAGC",
            "AGG01.BTUTV",
            "AGG01.BVA",
            "AGG01.CANNET",
            "AGG01.CAS",
            "AGG01.CASQB",
            "AGG01.CASTS",
            "AGG01.CAS16X",
            "AGG01.CAS2FJ",
            "AGG01.CBAAL",
            "AGG01.CCOCS",
            "AGG01.CGE0FE",
            "AGG01.CIM",
            "AGG01.COASA",
            "AGG01.CPE",
            "AGG01.CPEJM",
            "AGG01.CPS",
            "AGG01.CRUCJV",
            "AGG01.CSCTV",
            "AGG01.CSL",
            "AGG01.CSLNET",
            "AGG01.CSLTH",
            "AGG01.CTACL6",
            "AGG01.CTAMC",
            "AGG01.CTAMR",
            "AGG01.CTANJ",
            "AGG01.CUATV",
            "AGG01.CZAJV1",
            "AGG01.DOSCS",
            "AGG01.DQXTB",
            "AGG01.DVLAPJ",
            "AGG01.ERE0ET",
            "AGG01.FACFF",
            "AGG01.FLABC",
            "AGG01.FLAPFU",
            "AGG01.FNS",
            "AGG01.FSASC5",
            "AGG01.FSASM",
            "AGG01.GJANET",
            "AGG01.GNA",
            "AGG01.GNAAME",
            "AGG01.GNAGC",
            "AGG01.GRPMA",
            "AGG01.GRSNET",
            "AGG01.GVS",
            "AGG01.GVS0F6",
            "AGG01.HORTEI",
            "AGG01.IAI",
            "AGG01.IDUGC",
            "AGG01.IGAVV",
            "AGG01.IIG0EZ",
            "AGG01.ITUXN",
            "AGG01.JAIGC",
            "AGG01.JAUTV",
            "AGG01.JFA",
            "AGG01.JFAJZ",
            "AGG01.JPALM",
            "AGG01.JVELN",
            "AGG01.JVEUQ8",
            "AGG01.KDKUF",
            "AGG01.LDA",
            "AGG01.LJODE",
            "AGG01.MBA",
            "AGG01.MCE",
            "AGG01.MCLDR",
            "AGG01.MCO",
            "AGG01.MCOBJ",
            "AGG01.MCO0FN",
            "AGG01.MCZNEW",
            "AGG01.MESQV2E",
            "AGG01.MGA",
            "AGG01.MIATV",
            "AGG01.MNSHZ",
            "AGG01.MPA",
            "AGG01.NHOLO",
            "AGG01.NRI",
            "AGG01.NTL",
            "AGG01.NTLBE",
            "AGG01.OCO",
            "AGG01.PAARON",
            "AGG01.PAE",
            "AGG01.PAECL",
            "AGG01.PAEMF",
            "AGG01.PAENR",
            "AGG01.PASPDR",
            "AGG01.PBAWT",
            "AGG01.PGORB",
            "AGG01.PLTQN",
            "AGG01.PLTTF",
            "AGG01.PMJAT",
            "AGG01.PMJSO",
            "AGG01.PPEAT",
            "AGG01.PTS",
            "AGG01.RBO",
            "AGG01.RBOAI",
            "AGG01.RCE",
            "AGG01.RCEAU",
            "AGG01.RCEBV",
            "AGG01.RCEEAC",
            "AGG01.RJODEO",
            "AGG01.RJONBF",
            "AGG01.RJONT0",
            "AGG01.RJO0TD",
            "AGG01.RJO0TF",
            "AGG01.RJO0TL",
            "AGG01.RJO2AT",
            "AGG01.RJO4CL",
            "AGG01.ROIMD",
            "AGG01.RPO",
            "AGG01.RPONZ",
            "AGG01.RPOTZ",
            "AGG01.RSDVV",
            "AGG01.SCLNT",
            "AGG01.SCRTV",
            "AGG01.SDRDCN",
            "AGG01.SDRZX",
            "AGG01.SJC",
            "AGG01.SJCEZ",
            "AGG01.SLA0H3",
            "AGG01.SLOOCE",
            "AGG01.SLS",
            "AGG01.SMACLA",
            "AGG01.SMATT",
            "AGG01.SNE",
            "AGG01.SOC",
            "AGG01.SOCRN",
            "AGG01.SOONS",
            "AGG01.SPBEQI",
            "AGG01.SPO",
            "AGG01.SPOLP",
            "AGG01.SPOMPU",
            "AGG01.SPOPH",
            "AGG01.SPOSLB",
            "AGG01.SPO0CG",
            "AGG01.SPO0JG",
            "AGG01.SPO0KA",
            "AGG01.SPO0PE",
            "AGG01.SRM",
            "AGG01.SRRQN",
            "AGG01.SRRTE",
            "AGG01.STSTB",
            "AGG01.STSWL3",
            "AGG01.STZTV",
            "AGG01.SVENEW",
            "AGG01.TANGBR",
            "AGG01.TOTJR",
            "AGG01.TRL0E8",
            "AGG01.TSA",
            "AGG01.TSAMF",
            "AGG01.TTE",
            "AGG01.UGN0EG",
            "AGG01.ULA",
            "AGG01.URAFR",
            "AGG01.VCANET",
            "AGG01.VCAVC",
            "AGG01.VGAJGP",
            "AGG01.VGATG",
            "AGG01.VOSTV",
            "AGG01.VRD",
            "AGG01.VTA",
            "AGG01.VTAGK",
            "AGG02.ADABR",
            "AGG02.AJU",
            "AGG02.AMRHZ",
            "AGG02.ANSGC",
            "AGG02.APSNT",
            "AGG02.ARCHZ",
            "AGG02.ARQARN",
            "AGG02.BERT0DW",
            "AGG02.BET0HH",
            "AGG02.BGEACM",
            "AGG02.BGP0AO",
            "AGG02.BHEGM",
            "AGG02.BNUNEO",
            "AGG02.BQE0FK",
            "AGG02.BRE",
            "AGG02.BREEQU",
            "AGG02.BREXOX",
            "AGG02.BRU",
            "AGG02.BRUTS",
            "AGG02.BSAGC",
            "AGG02.BTUTV",
            "AGG02.BVA",
            "AGG02.CANNET",
            "AGG02.CAS",
            "AGG02.CASQB",
            "AGG02.CASTS",
            "AGG02.CAS16X",
            "AGG02.CAS2FJ",
            "AGG02.CBAAL",
            "AGG02.CCOCS",
            "AGG02.CGE0FE",
            "AGG02.CIM",
            "AGG02.CPE",
            "AGG02.CPEJM",
            "AGG02.CPS",
            "AGG02.CRUCJV",
            "AGG02.CSCTV",
            "AGG02.CSL",
            "AGG02.CSLNET",
            "AGG02.CSLTH",
            "AGG02.CTACL6",
            "AGG02.CTAMC",
            "AGG02.CTAMR",
            "AGG02.CTANJ",
            "AGG02.CUATV",
            "AGG02.CZAJV1",
            "AGG02.DOSCS",
            "AGG02.DQXTB",
            "AGG02.DVLAPJ",
            "AGG02.ERE0ET",
            "AGG02.FACFF",
            "AGG02.FLABC",
            "AGG02.FLAPFU",
            "AGG02.FNS",
            "AGG02.FSASC5",
            "AGG02.FSASM",
            "AGG02.GJANET",
            "AGG02.GNA",
            "AGG02.GNAAME",
            "AGG02.GNAGC",
            "AGG02.GRPMA",
            "AGG02.GRSNET",
            "AGG02.GVS",
            "AGG02.GVS0F6",
            "AGG02.IAI",
            "AGG02.IDUGC",
            "AGG02.IGAVV",
            "AGG02.IIG0EZ",
            "AGG02.ITUXN",
            "AGG02.JAIGC",
            "AGG02.JAUTV",
            "AGG02.JFA",
            "AGG02.JFAJZ",
            "AGG02.JPALM",
            "AGG02.JVELN",
            "AGG02.JVEUQ8",
            "AGG02.KDKUF",
            "AGG02.LDA",
            "AGG02.LJODE",
            "AGG02.MBA",
            "AGG02.MCE",
            "AGG02.MCLDR",
            "AGG02.MCO",
            "AGG02.MCOBJ",
            "AGG02.MCO0FN",
            "AGG02.MCZNEW",
            "AGG02.MESQV2E",
            "AGG02.MGA",
            "AGG02.MIATV",
            "AGG02.MNSHZ",
            "AGG02.MPA",
            "AGG02.NHOLO",
            "AGG02.NRI",
            "AGG02.NTL",
            "AGG02.NTLBE",
            "AGG02.OCO",
            "AGG02.PAARON",
            "AGG02.PAE",
            "AGG02.PAECL",
            "AGG02.PAEMF",
            "AGG02.PAENR",
            "AGG02.PASPDR",
            "AGG02.PBAWT",
            "AGG02.PGORB",
            "AGG02.PLTQN",
            "AGG02.PLTTF",
            "AGG02.PMJAT",
            "AGG02.PMJSO",
            "AGG02.PPEAT",
            "AGG02.PTS",
            "AGG02.RBO",
            "AGG02.RBOAI",
            "AGG02.RCE",
            "AGG02.RCEAU",
            "AGG02.RCEBV",
            "AGG02.RCEEAC",
            "AGG02.RJO",
            "AGG02.RJONBF",
            "AGG02.RJONT0",
            "AGG02.RJO0TD",
            "AGG02.RJO0TF",
            "AGG02.RJO0TL",
            "AGG02.RJO2AT",
            "AGG02.RJO4CL",
            "AGG02.ROIMD",
            "AGG02.RPO",
            "AGG02.RPONZ",
            "AGG02.RPOTZ",
            "AGG02.RSDVV",
            "AGG02.SCLNT",
            "AGG02.SCRTV",
            "AGG02.SDRDCN",
            "AGG02.SDRZX",
            "AGG02.SJC",
            "AGG02.SJCEZ",
            "AGG02.SLA0H3",
            "AGG02.SLOOCE",
            "AGG02.SLS",
            "AGG02.SMACLA",
            "AGG02.SMATT",
            "AGG02.SNE",
            "AGG02.SOC",
            "AGG02.SOCRN",
            "AGG02.SOONS",
            "AGG02.SPO",
            "AGG02.SPOLP",
            "AGG02.SPOMPU",
            "AGG02.SPOPH",
            "AGG02.SPOSLB",
            "AGG02.SPO0CG",
            "AGG02.SPO0JG",
            "AGG02.SPO0KA",
            "AGG02.SPO0PE",
            "AGG02.SRM",
            "AGG02.SRRQN",
            "AGG02.SRRTE",
            "AGG02.STSTB",
            "AGG02.STSWL3",
            "AGG02.STZTV",
            "AGG02.SVENEW",
            "AGG02.TANGBR",
            "AGG02.TOTJR",
            "AGG02.TRL0E8",
            "AGG02.TSA",
            "AGG02.TSAMF",
            "AGG02.TTE",
            "AGG02.UGN0EG",
            "AGG02.ULA",
            "AGG02.URAFR",
            "AGG02.VCANET",
            "AGG02.VCAVC",
            "AGG02.VGAJGP",
            "AGG02.VGATG",
            "AGG02.VOSTV",
            "AGG02.VRD",
            "AGG02.VTA",
            "AGG02.VTAGK",
            "AGG03.BHE",
            "AGG03.BLM",
            "AGG03.BLMSZ",
            "AGG03.BSA",
            "AGG03.BSASN",
            "AGG03.CBA",
            "AGG03.CEM",
            "AGG03.FLA",
            "AGG03.FLAJN",
            "AGG03.JPA",
            "AGG03.MNS",
            "AGG03.PMJSO",
            "AGG03.PVO",
            "AGG03.RBO",
            "AGG03.RCE",
            "AGG03.RJO",
            "AGG03.RJOEN",
            "AGG03.SDR",
            "AGG03.SDRIT",
            "AGG03.SPO",
            "AGG03.SPOMB",
            "AGG03.ULA",
            "AGG04.BHE",
            "AGG04.BLM",
            "AGG04.BLMSZ",
            "AGG04.BSA",
            "AGG04.BSASN",
            "AGG04.CBA",
            "AGG04.CEM",
            "AGG04.FLA",
            "AGG04.FLAJN",
            "AGG04.JPA",
            "AGG04.MNS",
            "AGG04.PMJSO",
            "AGG04.PVO",
            "AGG04.RBO",
            "AGG04.RCE",
            "AGG04.RJOEN",
            "AGG04.SDR",
            "AGG04.SDRIT",
            "AGG04.SPO",
            "AGG04.SPOMB",
            "AGG04.ULA",
            "IACC01.BRE",
            "IACC01.BRU",
            "IACC01.BVA",
            "IACC01.CAS",
            "IACC01.CEM",
            "IACC01.CSL",
            "IACC01.CTA",
            "IACC01.CTAMR",
            "IACC01.FNS",
            "IACC01.GNA",
            "IACC01.GVS",
            "IACC01.JFA",
            "IACC01.LDA",
            "IACC01.MCE",
            "IACC01.PAE",
            "IACC01.PVO",
            "IACC01.RJO",
            "IACC01.RJOST",
            "IACC01.RPO",
            "IACC01.SJC",
            "IACC01.SNE",
            "IACC01.SOC",
            "IACC01.SPO",
            "IACC01.SPOLP",
            "IACC01.SPOMB",
            "IACC01.STS",
            "IACC02.BRU",
            "IACC02.CTA",
            "IACC02.CTAMR",
            "IACC02.FNS",
            "IACC02.GNA",
            "IACC02.LDA",
            "IACC02.MCE",
            "IACC02.PAE",
            "IACC02.PVO",
            "IACC02.RJO",
            "IACC02.RJOST",
            "IACC02.RPO",
            "IACC02.SJC",
            "IACC02.SPO",
            "IACC02.SPOLP",
            "IACC02.SPOMB",
            "IACC03.GNA",
            "IACC03.PAE",
            "IACC03.RJO",
            "IACC03.SPO",
            "IACC03.SPOMB",
            "IACC04.GNA",
            "IACC04.PAE",
            "IACC04.RJO",
            "IACC05.GNA",
            "IACC05.PAE",
            "IACC05.RJO",
            "IACC06.RJO",
            "UACC01.BHE",
            "UACC01.CPS",
            "UACC01.FLA",
            "UACC01.PAEMF",
            "UACC01.PMJSO",
            "UACC01.RJO",
            "UACC01.RJOEN",
            "UACC01.SPO",
            "UACC01.SPOLP",
            "UACC01.SPOMB",
            "UACC01.VRD",
            "UACC02.FLA",
            "UACC02.PAE",
            "UACC02.RJOEN",
            "UACC02.SPO",
            "UACC02.SPOLP",
            "UACC02.SPOMB",
            "UACC03.RJO",
            "UACC03.RJOEN",
            "UACC03.SPOLP",
            "UACC03.SPOPH",
            "UACC04.RJO",
            "UACC04.RJOEN",
            "UACC04.SPOMB",
            "UACC05.SPOPH",
            "UACC06.SPOPH",
            "ITT01.RJO",
            "ITT01.SPO",
            "--------------",
            "::Outros::",
            "--------------",
            "BLK01.RJOEN",
            "BLK01.SPOMB",
            "BLK01.SPOPH",
            "BLK02.RJO",
            "BLK03.RJO",
            "BRAS01.SPO",
            "BRBHEE001AR01",
            "BRBHEE001BR01",
            "BRBHEE001BR02",
            "BRBSAE001AR01",
            "BRCASE001AR01",
            "BRCTAE001RAR01",
            "BRPAEE001RAR01",
            "BRRJOE001AR01",
            "BRRJOE001AR02",
            "BRRJOE001AR03",
            "BRRJOE001BR01",
            "BRRJOE001BR02",
            "BRSPOE001AR01",
            "BRSPOE001AR02",
            "BRSPOE001AR03",
            "BRSPOE001AR04",
            "BRSPOE001AR05",
            "BRSPOE001AR06",
            "BRSPOE001AR07",
            "BRSPOE001BR01",
            "BRSPOE001BR02",
            "BRSPOE001IR01",
            "BRSPOE001IR02",
            "BRSPOE001IR03",
            "BRSPOE001NAP01",
            "BRSPOE001NAP02",
            "BRSPOE001PE01",
            "BRSPOE001PE02",
            "BRSPOE001RR01",
            "BRSPOE001RR02",
            "CLNS01.BRUTS",
            "CLNS01.CAS",
            "CLNS01.CASTS",
            "CLNS01.CSLTH",
            "CLNS01.CTAMC",
            "CLNS01.FNS",
            "CLNS01.JVELN",
            "CLNS01.PAECL",
            "CLNS01.PLTTF",
            "CLNS01.RJO0TD",
            "CLNS01.RJO0TL",
            "CLNS01.RJO2AT",
            "CLNS01.RJO4CL",
            "CLNS01.RPOTZ",
            "CLNS01.SJCEZ",
            "CLNS01.SMATT",
            "CLNS01.SOCRN",
            "CLNS01.SPO0CG",
            "CLNS01.SPO0JG",
            "CLNS01.SPO0KA",
            "CLNS01.SPO0PE",
            "CLNS01.SRRTE",
            "CLNS01.STSTB",
            "CORE01.CAS",
            "CORE01.CASQB",
            "CORE01.CTAMC",
            "CORE01.CTAMR",
            "CORE01.RJO",
            "CORE01.RJOEN",
            "CORE01.SDR",
            "CORE01.SDRIT",
            "CORE01.SPO",
            "CORE01.SPOMB",
            "CORE02.BHE",
            "CORE02.BSA",
            "CORE02.BSASN",
            "CORE02.CEM",
            "CORE02.FLA",
            "CORE02.FLAJN",
            "CORE02.SDR",
            "CORE02.SDRIT",
            "INTL01.ATL",
            "INTL01.MIANAP",
            "INTL02.ATL",
            "INTL02.MIANAP",
            "INTL03.ATL",
            "INTL03.NYK",
            "INTL04.ATL",
            "INTL04.NYK",
            "ISACC01.RJOEN",
            "ISACC01.SPOLP",
            "ISACC02.RJOEN",
            "ISACC02.SPOLP",
            "MXACC01.RJO",
            "MXACC01.SPOPH",
            "MXACC02.RJO",
            "MXACC02.SPOPH",
            "NIACC01.PAEMF",
            "NXACC01.BHE",
            "NXACC01.BLM",
            "NXACC01.BSA",
            "NXACC01.CAS",
            "NXACC01.CTACL6",
            "NXACC01.MNS",
            "NXACC01.PAE",
            "NXACC01.RJO",
            "NXACC01.SDR",
            "NXACC01.SPO",
            "NXACC01.SPOPH",
            "NXACC02.BHE",
            "NXACC02.BLM",
            "NXACC02.BSA",
            "NXACC02.CAS",
            "NXACC02.CTACL6",
            "NXACC02.MNS",
            "NXACC02.PAE",
            "NXACC02.SDR",
            "NXACC02.SPO",
            "NXACC03.RJO",
            "NXACC04.RJO",
            "PUACC01.SPOPH",
            "PUACC03.RJO",
            "RR01.ATL",
            "RR01.MIANAP",
            "RR01.NYK",
            "RR02.ATL",
            "RR02.MIANAP",
            "RR02.NYK",
            "RR10.AMRHZ",
            "RR10.BHE",
            "RR10.BLMSZ",
            "RR10.BRU",
            "RR10.BSA",
            "RR10.BSASN",
            "RR10.CAS",
            "RR10.CASQB",
            "RR10.CBA",
            "RR10.CEM",
            "RR10.CPE",
            "RR10.CPS",
            "RR10.CSLNET",
            "RR10.CTAMC",
            "RR10.CTAMR",
            "RR10.FLA",
            "RR10.FLAJN",
            "RR10.GNAGC",
            "RR10.GVS0F6",
            "RR10.JPA",
            "RR10.JVEUQ8",
            "RR10.LDA",
            "RR10.MCE",
            "RR10.MCO0FN",
            "RR10.MGA",
            "RR10.MNSHZ",
            "RR10.PAE",
            "RR10.PAEMF",
            "RR10.PLTQN",
            "RR10.PPEAT",
            "RR10.RCEEAC",
            "RR10.RJO",
            "RR10.RJOEN",
            "RR10.RPONZ",
            "RR10.SCLNT",
            "RR10.SDR",
            "RR10.SDRIT",
            "RR10.SJC",
            "RR10.SMACLA",
            "RR10.SNE",
            "RR10.SOC",
            "RR10.SOONS",
            "RR10.SPO",
            "RR10.SPOMB",
            "RR10.STSWL3",
            "RR10.ULA",
            "RR10.VRD",
            "RR10.VTA",
            "RSERV01.RJOEN",
            "RSERV01.SPOMB",
            "RTA01.APUTL",
            "RTA01.CAS",
            "RTA01.CSCTE",
            "RTA01.CSLTH",
            "RTA01.CTACL6",
            "RTA01.DQXTB",
            "RTA01.FNS",
            "RTA01.JVELN",
            "RTA01.LDA",
            "RTA01.MGACLA",
            "RTA01.MGAZT",
            "RTA01.PAECL",
            "RTA01.PAETT",
            "RTA01.PGORB",
            "RTA01.PGOTL",
            "RTA01.PLTTF",
            "RTA01.PPETS",
            "RTA01.RJO0TD",
            "RTA01.RJO2AT",
            "RTA01.RPOTZ",
            "RTA01.SMATT",
            "RTA01.SOCRN",
            "RTA01.SRRTE",
            "RTA01.STSTB",
            "RTA02.APUTL",
            "RTA02.CAS",
            "RTA02.CSCTE",
            "RTA02.CSLTH",
            "RTA02.CTACL6",
            "RTA02.DQXTB",
            "RTA02.FNS",
            "RTA02.JVELN",
            "RTA02.LDA",
            "RTA02.MGACLA",
            "RTA02.MGAZT",
            "RTA02.PAECL",
            "RTA02.PAETT",
            "RTA02.PGORB",
            "RTA02.PGOTL",
            "RTA02.PLTTF",
            "RTA02.PPETS",
            "RTA02.RJO0TD",
            "RTA02.RJO2AT",
            "RTA02.RPOTZ",
            "RTA02.SMATT",
            "RTA02.SOCRN",
            "RTA02.SPO0PE",
            "RTA02.SRRTE",
            "RTA02.STSTB",
            "RTL01.BRUTS",
            "RTL01.CASTS",
            "RTL01.CTAXH",
            "RTL01.CTA0LT",
            "RTL01.DQXTB",
            "RTL01.PAECL",
            "RTL01.PAETT",
            "RTL01.RJO0TF",
            "RTL01.RJO4CL",
            "RTL01.SJCEZ",
            "RTL01.SPO0JG",
            "RTL01.SPO0PE",
            "RTL02.BRUTS",
            "RTL02.CASTS",
            "RTL02.CTAXH",
            "RTL02.CTA0LT",
            "RTL02.DQXTB",
            "RTL02.PAECL",
            "RTL02.PAETT",
            "RTL02.RJO0TF",
            "RTL02.RJO4CL",
            "RTL02.SJCEZ",
            "RTL02.SPO0JG",
            "RTL02.SPO0PE",
            "RTL03.PAECL",
            "RTL03.SPO0JG",
            "RTL04.PAECL",
            "RTL04.SPO0JG",
            "RTS01.RJO2AT",
            "RTS01.SPO0JG",
            "RTS02.RJO2AT",
            "RTS02.SPO0JG",
            "SACC01.BRU",
            "SACC01.BSA",
            "SACC01.CTAMR",
            "SACC01.GNA",
            "SACC01.LDA",
            "SACC01.RCE",
            "SACC01.RJOEN",
            "SACC01.RPO",
            "SACC01.SNE",
            "SACC01.SOC",
            "SACC01.SPOMB",
            "SACC01.SPOPH",
            "SACC02.BRU",
            "SACC02.BSA",
            "SACC02.CPE",
            "SACC02.CTAMR",
            "SACC02.FNS",
            "SACC02.GNA",
            "SACC02.LDA",
            "SACC02.RCE",
            "SACC02.RJOEN",
            "SACC02.RPO",
            "SACC02.SNE",
            "SACC02.SOC",
            "SACC02.SPOMB",
            "SACC02.SPOPH",
            "SACC03.CPE",
            "SHSLA01.CPE",
            "SHSLA01.PVO",
            "SHSLA03.AJU",
            "SHSLA03.BHE",
            "SHSLA03.BLM",
            "SHSLA03.BRE",
            "SHSLA03.BRU",
            "SHSLA03.BSA",
            "SHSLA03.BVA",
            "SHSLA03.CAS",
            "SHSLA03.CBA",
            "SHSLA03.CEM",
            "SHSLA03.CIM",
            "SHSLA03.CPE",
            "SHSLA03.CSL",
            "SHSLA03.CTACL6",
            "SHSLA03.CTAMR",
            "SHSLA03.FLA",
            "SHSLA03.FLAJN",
            "SHSLA03.FNS",
            "SHSLA03.FSA",
            "SHSLA03.GNA",
            "SHSLA03.GVS",
            "SHSLA03.JFA",
            "SHSLA03.JPA",
            "SHSLA03.LDA",
            "SHSLA03.MCO",
            "SHSLA03.MNS",
            "SHSLA03.MPA",
            "SHSLA03.NTL",
            "SHSLA03.OCO",
            "SHSLA03.PAE",
            "SHSLA03.PAEMF",
            "SHSLA03.PMJSO",
            "SHSLA03.PTA",
            "SHSLA03.PVO",
            "SHSLA03.RBO",
            "SHSLA03.RCE",
            "SHSLA03.RJO",
            "SHSLA03.RJOEN",
            "SHSLA03.RPO",
            "SHSLA03.SDR",
            "SHSLA03.SJC",
            "SHSLA03.SLS",
            "SHSLA03.SNE",
            "SHSLA03.SOC",
            "SHSLA03.SPO",
            "SHSLA03.SPOMB",
            "SHSLA03.SRM",
            "SHSLA03.TSA",
            "SHSLA03.ULA",
            "SHSLA03.VTA",
            "SRMS10.BHE",
            "SRMS10.BSASN",
            "SRMS10.CAS",
            "SRMS10.CTAMR",
            "SRMS10.FLAJN",
            "SRMS10.MNSHZ",
            "SRMS10.PAEMF",
            "SRMS10.RJO",
            "SRMS10.SDRIT",
            "SRMS10.SPO",
            "SWCORE01.RJO",
            "SWCORE01.RJOEN",
            "SWCORE02.RJO",
            "SWCORE02.RJOEN",
            "SWCORE03.RJO",
            "SWCORE03.RJOEN",
            "SWCORE04.RJO",
            "SWCORE04.RJOEN",
            "SWCORE05.RJOEN",
            "SWGGC01.CTAMC",
            "SWGGC01.CTAMR",
            "SWGGC01.FLAJN",
            "SWGGC01.PAE",
            "SWPWR01.I",
            "SWSAN01.RJO",
            "SWSAN01.RJOEN",
            "SWSRV01.RJO",
            "SWSRV01.RJOEN",
            "SWSRV02.RJO",
            "SWSRV02.RJOEN",
            "SWSRV03.RJO",
            "SWSRV03.RJOEN",
            "SWSRV04.RJO",
            "SWSRV05.RJO",
            "SWSRV06.RJO",
            "SWSRV09.RJO",
            "SWSRV10.RJO",
            "SWSRV14.RJO",
            "SWSRV15.RJO",
            "SWSRV17.RJO",
            "SWSRV20.RJO",
            "SWSRV21.RJO",
            "SWSRV78.RJO",
            "SWT301.I",
            "SWVM01.RJO",
            "SWVM02.RJO",
            "SWVM90.RJO",
            "SWVM90.RJOEN",
            "SWVM91.RJO",
            "SWVM91.RJOEN",
            "SWWEB01.BHE",
            "SWWEB01.SPOLP",
            "SWWEB05.SPO",
            "SW01.AJU",
            "SW01.ATL",
            "SW01.BLM",
            "SW01.BRU",
            "SW01.CPE",
            "SW01.CTAMR",
            "SW01.FNS",
            "SW01.GNA",
            "SW01.JPA",
            "SW01.LDA",
            "SW01.MBA",
            "SW01.MCO",
            "SW01.MIANAP",
            "SW01.MPA",
            "SW01.NTL",
            "SW01.NYK",
            "SW01.OCO",
            "SW01.RCE",
            "SW01.SJC",
            "SW01.SLS",
            "SW01.SNE",
            "SW01.SOC",
            "SW01.SRM",
            "SW01.STS",
            "SW01.TSA",
            "SW01.VTA",
            "SW02.AJU",
            "SW02.ATL",
            "SW02.BLM",
            "SW02.BRU",
            "SW02.CPE",
            "SW02.CTAMR",
            "SW02.FNS",
            "SW02.GNA",
            "SW02.JPA",
            "SW02.LDA",
            "SW02.MCO",
            "SW02.MIANAP",
            "SW02.NTL",
            "SW02.NYK",
            "SW02.OCO",
            "SW02.RCE",
            "SW02.SJC",
            "SW02.SLS",
            "SW02.SNE",
            "SW02.SOC",
            "SW02.STS",
            "SW02.TSA",
            "SW02.VTA",
            "SW12.RJO",
            "SW13.RJO",
            "TCORE01.CTAMC",
            "TCORE01.CTAMR",
            "TCORE01.PAE",
            "TCORE01.PAEMF",
            "TCORE01.SPOLP",
            "TCORE01.SPOPH",
            "UDIST01.CEM",
            "UDIST01.CPS",
            "UDIST01.MBA",
            "UDIST01.MCE",
            "UDIST01.RJO",
            "UDIST01.RJOEN",
            "UDIST01.SPO",
            "UDIST01.SPOLP",
            "UDIST02.CEM",
            "UDIST02.CPS",
            "UDIST02.MBA",
            "UDIST02.MCE",
            "UDIST02.RJO",
            "UDIST02.RJOEN",
            "UDIST02.SPO",
            "UDIST02.SPOLP",
            "VCLNS01.RJOEN",
            "VCLNS01.SPO",
            "VRR10.AMRHZ",
            "VRR10.BHE",
            "VRR10.BLMSZ",
            "VRR10.BRU",
            "VRR10.BSA",
            "VRR10.BSASN",
            "VRR10.CAS",
            "VRR10.CASQB",
            "VRR10.CBA",
            "VRR10.CEM",
            "VRR10.CPE",
            "VRR10.CPS",
            "VRR10.CSLNET",
            "VRR10.CTAMC",
            "VRR10.CTAMR",
            "VRR10.FLA",
            "VRR10.FLAJN",
            "VRR10.GNAGC",
            "VRR10.GVS0F6",
            "VRR10.JPA",
            "VRR10.JVEUQ8",
            "VRR10.LDA",
            "VRR10.MCE",
            "VRR10.MCO0FN",
            "VRR10.MGA",
            "VRR10.MNSHZ",
            "VRR10.PAE",
            "VRR10.PAEMF",
            "VRR10.PLTQN",
            "VRR10.PPEAT",
            "VRR10.RCEEAC",
            "VRR10.RJO",
            "VRR10.RJOEN",
            "VRR10.RPONZ",
            "VRR10.SCLNT",
            "VRR10.SDR",
            "VRR10.SDRIT",
            "VRR10.SJC",
            "VRR10.SMACLA",
            "VRR10.SNE",
            "VRR10.SOC",
            "VRR10.SOONS",
            "VRR10.SPO",
            "VRR10.SPOMB",
            "VRR10.STSWL3",
            "VRR10.ULA",
            "VRR10.VRD",
            "VRR10.VTA",
            "VSR-NRC01.RJOEN",
            "VSR-NRC01.RJO2AT",
            "XACC01.AJU",
            "XACC01.BRU",
            "XACC01.BSA",
            "XACC01.CBA",
            "XACC01.CEM",
            "XACC01.CPE",
            "XACC01.CPS",
            "XACC01.FLA",
            "XACC01.FNS",
            "XACC01.GNA",
            "XACC01.GVS",
            "XACC01.JPA",
            "XACC01.LDA",
            "XACC01.MCE",
            "XACC01.MCO",
            "XACC01.NTL",
            "XACC01.OCO",
            "XACC01.PMJSO",
            "XACC01.PVO",
            "XACC01.RBO",
            "XACC01.RCE",
            "XACC01.RJO",
            "XACC01.RJOEN",
            "XACC01.RPO",
            "XACC01.SJC",
            "XACC01.SLS",
            "XACC01.SNE",
            "XACC01.SOC",
            "XACC01.SPOLP",
            "XACC01.SPOMB",
            "XACC01.SPOPH",
            "XACC01.STS",
            "XACC01.TSA",
            "XACC01.ULA",
            "XACC01.VRD",
            "XACC01.VTA",
            "XACC02.AJU",
            "XACC02.BRU",
            "XACC02.BSA",
            "XACC02.CBA",
            "XACC02.CEM",
            "XACC02.CPE",
            "XACC02.CPS",
            "XACC02.FLA",
            "XACC02.FNS",
            "XACC02.GNA",
            "XACC02.GVS",
            "XACC02.JPA",
            "XACC02.LDA",
            "XACC02.MCE",
            "XACC02.MCO",
            "XACC02.NTL",
            "XACC02.OCO",
            "XACC02.PMJSO",
            "XACC02.PVO",
            "XACC02.RBO",
            "XACC02.RCE",
            "XACC02.RJO",
            "XACC02.RJOEN",
            "XACC02.RPO",
            "XACC02.SJC",
            "XACC02.SLS",
            "XACC02.SNE",
            "XACC02.SOC",
            "XACC02.SPOLP",
            "XACC02.SPOMB",
            "XACC02.SPOPH",
            "XACC02.STS",
            "XACC02.TSA",
            "XACC02.ULA",
            "XACC02.VRD",
            "XACC02.VTA",
            "XACC03.CTAMR",
            "XACC04.CTAMR",
            "XTC01.CAS",
            "XTC01.SPO"});
            this.OpenPE_ComboBox.Location = new System.Drawing.Point(33, 9);
            this.OpenPE_ComboBox.Name = "OpenPE_ComboBox";
            this.OpenPE_ComboBox.Size = new System.Drawing.Size(121, 25);
            this.OpenPE_ComboBox.TabIndex = 10;
            // 
            // OpenPE_Label
            // 
            this.OpenPE_Label.BackColor = System.Drawing.Color.White;
            this.OpenPE_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPE_Label.ForeColor = System.Drawing.Color.Black;
            this.OpenPE_Label.Location = new System.Drawing.Point(4, 12);
            this.OpenPE_Label.Name = "OpenPE_Label";
            this.OpenPE_Label.Size = new System.Drawing.Size(28, 19);
            this.OpenPE_Label.TabIndex = 9;
            this.OpenPE_Label.Text = "PE:";
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl2.Controls.Add(this.tabMainPage);
            this.tabControl2.Controls.Add(this.tabScript);
            this.tabControl2.Controls.Add(this.tabSelectRouter);
            this.tabControl2.Controls.Add(this.ClientStepsPage);
            this.tabControl2.Controls.Add(this.tabWizGat);
            this.tabControl2.Controls.Add(this.tabLogs);
            this.tabControl2.Controls.Add(this.tabVelocloud);
            this.tabControl2.Controls.Add(this.tabLigacoes);
            this.tabControl2.Controls.Add(this.tabOutros);
            this.tabControl2.Controls.Add(this.tabSelectClient);
            this.tabControl2.Controls.Add(this.tabClient);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl2.Location = new System.Drawing.Point(3, 74);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1120, 522);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 0;
            // 
            // tabMainPage
            // 
            this.tabMainPage.BackColor = System.Drawing.SystemColors.Control;
            this.tabMainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabMainPage.Controls.Add(this.MainPage_ColetaLigacoes_Button);
            this.tabMainPage.Controls.Add(this.MainPage_Velo_Button);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_Hotline);
            this.tabMainPage.Controls.Add(this.MainPage_Button_BLD);
            this.tabMainPage.Controls.Add(this.MainPage_Button_Cliente4);
            this.tabMainPage.Controls.Add(this.MainPage_Button_Cliente5);
            this.tabMainPage.Controls.Add(this.CreatedLabel);
            this.tabMainPage.Controls.Add(this.ImageLogo);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_QoS);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_Vago);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_Balanceamento);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_EIGRP);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_GLBP);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_IPFlow);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_BGP);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_HSRP);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_VRRP);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_OSPF);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_RIP);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_User);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_DHCP);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_ExtrasFortigate);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_RegraAdicional);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_SNMP);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_BlockPort);
            this.tabMainPage.Controls.Add(this.MainPage_Button_OC_VLAN);
            this.tabMainPage.Controls.Add(this.MainPage_Button_WizGat);
            this.tabMainPage.Controls.Add(this.MainPage_SubTitle4);
            this.tabMainPage.Controls.Add(this.MainPage_SubTitle3);
            this.tabMainPage.Controls.Add(this.MainPage_Button_ClienteList);
            this.tabMainPage.Controls.Add(this.MainPage_Button_Cliente3);
            this.tabMainPage.Controls.Add(this.MainPage_Button_Cliente2);
            this.tabMainPage.Controls.Add(this.MainPage_Button_Cliente1);
            this.tabMainPage.Controls.Add(this.MainPage_Button_Cliente0);
            this.tabMainPage.Controls.Add(this.MainPage_Button_LogsFinais);
            this.tabMainPage.Controls.Add(this.MainPage_Button_LogsIniciais);
            this.tabMainPage.Controls.Add(this.MainPage_SubTitle0);
            this.tabMainPage.Controls.Add(this.MainPage_SubTitle1);
            this.tabMainPage.Controls.Add(this.MainPage_SubTitle2);
            this.tabMainPage.Controls.Add(this.MainPage_TemplatesLabel);
            this.tabMainPage.Controls.Add(this.MainPage_TemplatesLabel_BG);
            this.tabMainPage.Controls.Add(this.MainPage_Button_Voz);
            this.tabMainPage.Controls.Add(this.MainPage_Button_MPLS);
            this.tabMainPage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabMainPage.Location = new System.Drawing.Point(4, 5);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainPage.Size = new System.Drawing.Size(1112, 513);
            this.tabMainPage.TabIndex = 0;
            this.tabMainPage.Text = "tabPage4";
            // 
            // MainPage_ColetaLigacoes_Button
            // 
            this.MainPage_ColetaLigacoes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPage_ColetaLigacoes_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_ColetaLigacoes_Button.Location = new System.Drawing.Point(976, 382);
            this.MainPage_ColetaLigacoes_Button.MaximumSize = new System.Drawing.Size(242, 120);
            this.MainPage_ColetaLigacoes_Button.Name = "MainPage_ColetaLigacoes_Button";
            this.MainPage_ColetaLigacoes_Button.Size = new System.Drawing.Size(121, 37);
            this.MainPage_ColetaLigacoes_Button.TabIndex = 45;
            this.MainPage_ColetaLigacoes_Button.Text = "Ligações";
            this.MainPage_ColetaLigacoes_Button.UseVisualStyleBackColor = true;
            this.MainPage_ColetaLigacoes_Button.Click += new System.EventHandler(this.Logs_Ligacao_Click);
            // 
            // MainPage_Velo_Button
            // 
            this.MainPage_Velo_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPage_Velo_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Velo_Button.Location = new System.Drawing.Point(843, 382);
            this.MainPage_Velo_Button.MaximumSize = new System.Drawing.Size(242, 120);
            this.MainPage_Velo_Button.Name = "MainPage_Velo_Button";
            this.MainPage_Velo_Button.Size = new System.Drawing.Size(121, 37);
            this.MainPage_Velo_Button.TabIndex = 44;
            this.MainPage_Velo_Button.Text = "Velocloud";
            this.MainPage_Velo_Button.UseVisualStyleBackColor = true;
            this.MainPage_Velo_Button.Click += new System.EventHandler(this.Logs_Velo_Click);
            // 
            // MainPage_Button_OC_Hotline
            // 
            this.MainPage_Button_OC_Hotline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_Hotline.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_Hotline.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_Hotline.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_Hotline.Location = new System.Drawing.Point(112, 375);
            this.MainPage_Button_OC_Hotline.Name = "MainPage_Button_OC_Hotline";
            this.MainPage_Button_OC_Hotline.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_Hotline.TabIndex = 30;
            this.MainPage_Button_OC_Hotline.Text = "Hotline";
            this.MainPage_Button_OC_Hotline.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_Hotline.Click += new System.EventHandler(this.MainPage_Button_Hotline_Click);
            // 
            // MainPage_Button_BLD
            // 
            this.MainPage_Button_BLD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_BLD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_BLD.Location = new System.Drawing.Point(47, 141);
            this.MainPage_Button_BLD.Name = "MainPage_Button_BLD";
            this.MainPage_Button_BLD.Size = new System.Drawing.Size(120, 55);
            this.MainPage_Button_BLD.TabIndex = 1;
            this.MainPage_Button_BLD.Text = "BLD";
            this.MainPage_Button_BLD.UseVisualStyleBackColor = true;
            this.MainPage_Button_BLD.Click += new System.EventHandler(this.BLD_button_Click);
            // 
            // MainPage_Button_Cliente4
            // 
            this.MainPage_Button_Cliente4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_Cliente4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_Cliente4.Location = new System.Drawing.Point(800, 239);
            this.MainPage_Button_Cliente4.Name = "MainPage_Button_Cliente4";
            this.MainPage_Button_Cliente4.Size = new System.Drawing.Size(133, 50);
            this.MainPage_Button_Cliente4.TabIndex = 11;
            this.MainPage_Button_Cliente4.Text = "Teste 5";
            this.MainPage_Button_Cliente4.UseVisualStyleBackColor = true;
            // 
            // MainPage_Button_Cliente5
            // 
            this.MainPage_Button_Cliente5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_Cliente5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_Cliente5.Location = new System.Drawing.Point(934, 239);
            this.MainPage_Button_Cliente5.Name = "MainPage_Button_Cliente5";
            this.MainPage_Button_Cliente5.Size = new System.Drawing.Size(130, 50);
            this.MainPage_Button_Cliente5.TabIndex = 12;
            this.MainPage_Button_Cliente5.Text = "Teste 6";
            this.MainPage_Button_Cliente5.UseVisualStyleBackColor = true;
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedLabel.Location = new System.Drawing.Point(502, 493);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(200, 17);
            this.CreatedLabel.TabIndex = 43;
            this.CreatedLabel.Text = "Criado por: Ricardo Thiago Firmino";
            // 
            // ImageLogo
            // 
            this.ImageLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImageLogo.Image")));
            this.ImageLogo.InitialImage = null;
            this.ImageLogo.Location = new System.Drawing.Point(831, 425);
            this.ImageLogo.Name = "ImageLogo";
            this.ImageLogo.Size = new System.Drawing.Size(275, 85);
            this.ImageLogo.TabIndex = 4;
            this.ImageLogo.TabStop = false;
            // 
            // MainPage_Button_OC_QoS
            // 
            this.MainPage_Button_OC_QoS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_QoS.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_QoS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_QoS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_QoS.Location = new System.Drawing.Point(379, 258);
            this.MainPage_Button_OC_QoS.Name = "MainPage_Button_OC_QoS";
            this.MainPage_Button_OC_QoS.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_QoS.TabIndex = 18;
            this.MainPage_Button_OC_QoS.Text = "QOS";
            this.MainPage_Button_OC_QoS.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_QoS.Click += new System.EventHandler(this.MainPage_Button_QoS_Click);
            // 
            // MainPage_Button_OC_Vago
            // 
            this.MainPage_Button_OC_Vago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_Vago.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_Vago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_Vago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_Vago.Location = new System.Drawing.Point(201, 375);
            this.MainPage_Button_OC_Vago.Name = "MainPage_Button_OC_Vago";
            this.MainPage_Button_OC_Vago.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_Vago.TabIndex = 31;
            this.MainPage_Button_OC_Vago.Text = "Vago";
            this.MainPage_Button_OC_Vago.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_Vago.Click += new System.EventHandler(this.NotImplemented);
            // 
            // MainPage_Button_OC_Balanceamento
            // 
            this.MainPage_Button_OC_Balanceamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_Balanceamento.BackColor = System.Drawing.Color.DarkGray;
            this.MainPage_Button_OC_Balanceamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_Balanceamento.Location = new System.Drawing.Point(290, 375);
            this.MainPage_Button_OC_Balanceamento.Name = "MainPage_Button_OC_Balanceamento";
            this.MainPage_Button_OC_Balanceamento.Size = new System.Drawing.Size(179, 40);
            this.MainPage_Button_OC_Balanceamento.TabIndex = 32;
            this.MainPage_Button_OC_Balanceamento.Text = "Balanceamento";
            this.MainPage_Button_OC_Balanceamento.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_Balanceamento.Click += new System.EventHandler(this.NotImplemented);
            // 
            // MainPage_Button_OC_EIGRP
            // 
            this.MainPage_Button_OC_EIGRP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_EIGRP.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_EIGRP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_EIGRP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_EIGRP.Location = new System.Drawing.Point(379, 336);
            this.MainPage_Button_OC_EIGRP.Name = "MainPage_Button_OC_EIGRP";
            this.MainPage_Button_OC_EIGRP.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_EIGRP.TabIndex = 28;
            this.MainPage_Button_OC_EIGRP.Text = "EIGRP";
            this.MainPage_Button_OC_EIGRP.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_EIGRP.Click += new System.EventHandler(this.MainPage_Button_EIGRP_Click);
            // 
            // MainPage_Button_OC_GLBP
            // 
            this.MainPage_Button_OC_GLBP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_GLBP.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_GLBP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_GLBP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_GLBP.Location = new System.Drawing.Point(201, 336);
            this.MainPage_Button_OC_GLBP.Name = "MainPage_Button_OC_GLBP";
            this.MainPage_Button_OC_GLBP.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_GLBP.TabIndex = 26;
            this.MainPage_Button_OC_GLBP.Text = "GLBP";
            this.MainPage_Button_OC_GLBP.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_GLBP.Click += new System.EventHandler(this.MainPage_Button_GLBP_Click);
            // 
            // MainPage_Button_OC_IPFlow
            // 
            this.MainPage_Button_OC_IPFlow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_IPFlow.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_IPFlow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_IPFlow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_IPFlow.Location = new System.Drawing.Point(201, 297);
            this.MainPage_Button_OC_IPFlow.Name = "MainPage_Button_OC_IPFlow";
            this.MainPage_Button_OC_IPFlow.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_IPFlow.TabIndex = 21;
            this.MainPage_Button_OC_IPFlow.Text = "IP FLOW";
            this.MainPage_Button_OC_IPFlow.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_IPFlow.Click += new System.EventHandler(this.MainPage_Button_IPFlow_Click);
            // 
            // MainPage_Button_OC_BGP
            // 
            this.MainPage_Button_OC_BGP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_BGP.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_BGP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_BGP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_BGP.Location = new System.Drawing.Point(112, 258);
            this.MainPage_Button_OC_BGP.Name = "MainPage_Button_OC_BGP";
            this.MainPage_Button_OC_BGP.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_BGP.TabIndex = 15;
            this.MainPage_Button_OC_BGP.Text = "BGP";
            this.MainPage_Button_OC_BGP.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_BGP.Click += new System.EventHandler(this.MainPage_Button_BGP_Click);
            // 
            // MainPage_Button_OC_HSRP
            // 
            this.MainPage_Button_OC_HSRP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_HSRP.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_HSRP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_HSRP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_HSRP.Location = new System.Drawing.Point(290, 336);
            this.MainPage_Button_OC_HSRP.Name = "MainPage_Button_OC_HSRP";
            this.MainPage_Button_OC_HSRP.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_HSRP.TabIndex = 27;
            this.MainPage_Button_OC_HSRP.Text = "HSRP";
            this.MainPage_Button_OC_HSRP.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_HSRP.Click += new System.EventHandler(this.MainPage_Button_HSRP_Click);
            // 
            // MainPage_Button_OC_VRRP
            // 
            this.MainPage_Button_OC_VRRP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_VRRP.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_VRRP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_VRRP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_VRRP.Location = new System.Drawing.Point(112, 336);
            this.MainPage_Button_OC_VRRP.Name = "MainPage_Button_OC_VRRP";
            this.MainPage_Button_OC_VRRP.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_VRRP.TabIndex = 25;
            this.MainPage_Button_OC_VRRP.Text = "VRRP";
            this.MainPage_Button_OC_VRRP.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_VRRP.Click += new System.EventHandler(this.MainPage_Button_VRRP_Click);
            // 
            // MainPage_Button_OC_OSPF
            // 
            this.MainPage_Button_OC_OSPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_OSPF.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_OSPF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_OSPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_OSPF.Location = new System.Drawing.Point(23, 336);
            this.MainPage_Button_OC_OSPF.Name = "MainPage_Button_OC_OSPF";
            this.MainPage_Button_OC_OSPF.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_OSPF.TabIndex = 24;
            this.MainPage_Button_OC_OSPF.Text = "OSPF";
            this.MainPage_Button_OC_OSPF.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_OSPF.Click += new System.EventHandler(this.MainPage_Button_OSPF_Click);
            // 
            // MainPage_Button_OC_RIP
            // 
            this.MainPage_Button_OC_RIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_RIP.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_RIP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_RIP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_RIP.Location = new System.Drawing.Point(112, 297);
            this.MainPage_Button_OC_RIP.Name = "MainPage_Button_OC_RIP";
            this.MainPage_Button_OC_RIP.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_RIP.TabIndex = 20;
            this.MainPage_Button_OC_RIP.Text = "RIP";
            this.MainPage_Button_OC_RIP.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_RIP.Click += new System.EventHandler(this.MainPage_Button_RIP_Click);
            // 
            // MainPage_Button_OC_User
            // 
            this.MainPage_Button_OC_User.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_User.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_User.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_User.Location = new System.Drawing.Point(23, 297);
            this.MainPage_Button_OC_User.Name = "MainPage_Button_OC_User";
            this.MainPage_Button_OC_User.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_User.TabIndex = 19;
            this.MainPage_Button_OC_User.Text = "Usuário";
            this.MainPage_Button_OC_User.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_User.Click += new System.EventHandler(this.MainPage_Button_User_Click);
            // 
            // MainPage_Button_OC_DHCP
            // 
            this.MainPage_Button_OC_DHCP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_DHCP.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_DHCP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_DHCP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_DHCP.Location = new System.Drawing.Point(290, 258);
            this.MainPage_Button_OC_DHCP.Name = "MainPage_Button_OC_DHCP";
            this.MainPage_Button_OC_DHCP.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_DHCP.TabIndex = 17;
            this.MainPage_Button_OC_DHCP.Text = "DHCP";
            this.MainPage_Button_OC_DHCP.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_DHCP.Click += new System.EventHandler(this.MainPage_Button_DHCP_Click);
            // 
            // MainPage_Button_OC_ExtrasFortigate
            // 
            this.MainPage_Button_OC_ExtrasFortigate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_ExtrasFortigate.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_ExtrasFortigate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_ExtrasFortigate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_ExtrasFortigate.Location = new System.Drawing.Point(290, 297);
            this.MainPage_Button_OC_ExtrasFortigate.Name = "MainPage_Button_OC_ExtrasFortigate";
            this.MainPage_Button_OC_ExtrasFortigate.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_ExtrasFortigate.TabIndex = 22;
            this.MainPage_Button_OC_ExtrasFortigate.Text = "Extras Fortigate";
            this.MainPage_Button_OC_ExtrasFortigate.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_ExtrasFortigate.Click += new System.EventHandler(this.MainPage_Button_ExtrasFortigate_Click);
            // 
            // MainPage_Button_OC_RegraAdicional
            // 
            this.MainPage_Button_OC_RegraAdicional.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_RegraAdicional.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_RegraAdicional.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_RegraAdicional.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_RegraAdicional.Location = new System.Drawing.Point(23, 375);
            this.MainPage_Button_OC_RegraAdicional.Name = "MainPage_Button_OC_RegraAdicional";
            this.MainPage_Button_OC_RegraAdicional.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_RegraAdicional.TabIndex = 29;
            this.MainPage_Button_OC_RegraAdicional.Text = "Regra Adicional";
            this.MainPage_Button_OC_RegraAdicional.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_RegraAdicional.Click += new System.EventHandler(this.MainPage_Button_RegraAdicional_Click);
            // 
            // MainPage_Button_OC_SNMP
            // 
            this.MainPage_Button_OC_SNMP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_SNMP.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_SNMP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_SNMP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_SNMP.Location = new System.Drawing.Point(201, 258);
            this.MainPage_Button_OC_SNMP.Name = "MainPage_Button_OC_SNMP";
            this.MainPage_Button_OC_SNMP.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_SNMP.TabIndex = 16;
            this.MainPage_Button_OC_SNMP.Text = "SNMP";
            this.MainPage_Button_OC_SNMP.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_SNMP.Click += new System.EventHandler(this.MainPage_Button_SNMP_Click);
            // 
            // MainPage_Button_OC_BlockPort
            // 
            this.MainPage_Button_OC_BlockPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_BlockPort.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_BlockPort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_BlockPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_BlockPort.Location = new System.Drawing.Point(379, 297);
            this.MainPage_Button_OC_BlockPort.Name = "MainPage_Button_OC_BlockPort";
            this.MainPage_Button_OC_BlockPort.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_BlockPort.TabIndex = 23;
            this.MainPage_Button_OC_BlockPort.Text = "Bloqueio de Porta";
            this.MainPage_Button_OC_BlockPort.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_BlockPort.Click += new System.EventHandler(this.MainPage_Button_BlockPort_Click);
            // 
            // MainPage_Button_OC_VLAN
            // 
            this.MainPage_Button_OC_VLAN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_OC_VLAN.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage_Button_OC_VLAN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_OC_VLAN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPage_Button_OC_VLAN.Location = new System.Drawing.Point(23, 258);
            this.MainPage_Button_OC_VLAN.Name = "MainPage_Button_OC_VLAN";
            this.MainPage_Button_OC_VLAN.Size = new System.Drawing.Size(90, 40);
            this.MainPage_Button_OC_VLAN.TabIndex = 14;
            this.MainPage_Button_OC_VLAN.Text = "VLAN";
            this.MainPage_Button_OC_VLAN.UseVisualStyleBackColor = false;
            this.MainPage_Button_OC_VLAN.Click += new System.EventHandler(this.MainPage_Button_VLAN_Click);
            // 
            // MainPage_Button_WizGat
            // 
            this.MainPage_Button_WizGat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_WizGat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_WizGat.Location = new System.Drawing.Point(554, 261);
            this.MainPage_Button_WizGat.Name = "MainPage_Button_WizGat";
            this.MainPage_Button_WizGat.Size = new System.Drawing.Size(131, 55);
            this.MainPage_Button_WizGat.TabIndex = 6;
            this.MainPage_Button_WizGat.Text = "Abrir";
            this.MainPage_Button_WizGat.UseVisualStyleBackColor = true;
            this.MainPage_Button_WizGat.Click += new System.EventHandler(this.WizGat_Open);
            // 
            // MainPage_SubTitle4
            // 
            this.MainPage_SubTitle4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_SubTitle4.AutoSize = true;
            this.MainPage_SubTitle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.MainPage_SubTitle4.Location = new System.Drawing.Point(564, 228);
            this.MainPage_SubTitle4.Name = "MainPage_SubTitle4";
            this.MainPage_SubTitle4.Size = new System.Drawing.Size(106, 25);
            this.MainPage_SubTitle4.TabIndex = 22;
            this.MainPage_SubTitle4.Text = "WizardGat";
            // 
            // MainPage_SubTitle3
            // 
            this.MainPage_SubTitle3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_SubTitle3.AutoSize = true;
            this.MainPage_SubTitle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.MainPage_SubTitle3.Location = new System.Drawing.Point(153, 228);
            this.MainPage_SubTitle3.Name = "MainPage_SubTitle3";
            this.MainPage_SubTitle3.Size = new System.Drawing.Size(205, 25);
            this.MainPage_SubTitle3.TabIndex = 21;
            this.MainPage_SubTitle3.Text = "Outras Configurações";
            // 
            // MainPage_Button_ClienteList
            // 
            this.MainPage_Button_ClienteList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_ClienteList.AutoSize = true;
            this.MainPage_Button_ClienteList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_ClienteList.Location = new System.Drawing.Point(806, 292);
            this.MainPage_Button_ClienteList.Name = "MainPage_Button_ClienteList";
            this.MainPage_Button_ClienteList.Size = new System.Drawing.Size(115, 17);
            this.MainPage_Button_ClienteList.TabIndex = 13;
            this.MainPage_Button_ClienteList.TabStop = true;
            this.MainPage_Button_ClienteList.Text = "Outros Clientes...";
            this.MainPage_Button_ClienteList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AllClients_LinkClicked);
            // 
            // MainPage_Button_Cliente3
            // 
            this.MainPage_Button_Cliente3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_Cliente3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_Cliente3.Location = new System.Drawing.Point(934, 189);
            this.MainPage_Button_Cliente3.Name = "MainPage_Button_Cliente3";
            this.MainPage_Button_Cliente3.Size = new System.Drawing.Size(130, 50);
            this.MainPage_Button_Cliente3.TabIndex = 10;
            this.MainPage_Button_Cliente3.Text = "Teste 4";
            this.MainPage_Button_Cliente3.UseVisualStyleBackColor = true;
            this.MainPage_Button_Cliente3.Click += new System.EventHandler(this.NotImplemented);
            // 
            // MainPage_Button_Cliente2
            // 
            this.MainPage_Button_Cliente2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_Cliente2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_Cliente2.Location = new System.Drawing.Point(800, 189);
            this.MainPage_Button_Cliente2.Name = "MainPage_Button_Cliente2";
            this.MainPage_Button_Cliente2.Size = new System.Drawing.Size(133, 50);
            this.MainPage_Button_Cliente2.TabIndex = 9;
            this.MainPage_Button_Cliente2.Text = "Teste 3";
            this.MainPage_Button_Cliente2.UseVisualStyleBackColor = true;
            this.MainPage_Button_Cliente2.Click += new System.EventHandler(this.NotImplemented);
            // 
            // MainPage_Button_Cliente1
            // 
            this.MainPage_Button_Cliente1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_Cliente1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_Cliente1.Location = new System.Drawing.Point(934, 139);
            this.MainPage_Button_Cliente1.Name = "MainPage_Button_Cliente1";
            this.MainPage_Button_Cliente1.Size = new System.Drawing.Size(130, 50);
            this.MainPage_Button_Cliente1.TabIndex = 8;
            this.MainPage_Button_Cliente1.Text = "Teste 2";
            this.MainPage_Button_Cliente1.UseVisualStyleBackColor = true;
            this.MainPage_Button_Cliente1.Click += new System.EventHandler(this.NotImplemented);
            // 
            // MainPage_Button_Cliente0
            // 
            this.MainPage_Button_Cliente0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_Cliente0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_Cliente0.Location = new System.Drawing.Point(800, 139);
            this.MainPage_Button_Cliente0.Name = "MainPage_Button_Cliente0";
            this.MainPage_Button_Cliente0.Size = new System.Drawing.Size(133, 50);
            this.MainPage_Button_Cliente0.TabIndex = 7;
            this.MainPage_Button_Cliente0.Text = "Teste 1";
            this.MainPage_Button_Cliente0.UseVisualStyleBackColor = true;
            this.MainPage_Button_Cliente0.Click += new System.EventHandler(this.Client_TesteClient_Click);
            // 
            // MainPage_Button_LogsFinais
            // 
            this.MainPage_Button_LogsFinais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_LogsFinais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_LogsFinais.Location = new System.Drawing.Point(618, 141);
            this.MainPage_Button_LogsFinais.Name = "MainPage_Button_LogsFinais";
            this.MainPage_Button_LogsFinais.Size = new System.Drawing.Size(120, 55);
            this.MainPage_Button_LogsFinais.TabIndex = 5;
            this.MainPage_Button_LogsFinais.Text = "FINAIS";
            this.MainPage_Button_LogsFinais.UseVisualStyleBackColor = true;
            this.MainPage_Button_LogsFinais.Click += new System.EventHandler(this.Logs_Finais_Click);
            // 
            // MainPage_Button_LogsIniciais
            // 
            this.MainPage_Button_LogsIniciais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_LogsIniciais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_LogsIniciais.Location = new System.Drawing.Point(492, 141);
            this.MainPage_Button_LogsIniciais.Name = "MainPage_Button_LogsIniciais";
            this.MainPage_Button_LogsIniciais.Size = new System.Drawing.Size(120, 55);
            this.MainPage_Button_LogsIniciais.TabIndex = 4;
            this.MainPage_Button_LogsIniciais.Text = "INICIAIS";
            this.MainPage_Button_LogsIniciais.UseVisualStyleBackColor = true;
            this.MainPage_Button_LogsIniciais.Click += new System.EventHandler(this.Logs_Iniciais_Click);
            // 
            // MainPage_SubTitle0
            // 
            this.MainPage_SubTitle0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_SubTitle0.AutoSize = true;
            this.MainPage_SubTitle0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.MainPage_SubTitle0.Location = new System.Drawing.Point(168, 106);
            this.MainPage_SubTitle0.Name = "MainPage_SubTitle0";
            this.MainPage_SubTitle0.Size = new System.Drawing.Size(141, 25);
            this.MainPage_SubTitle0.TabIndex = 0;
            this.MainPage_SubTitle0.Text = "Configurações";
            // 
            // MainPage_SubTitle1
            // 
            this.MainPage_SubTitle1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_SubTitle1.AutoSize = true;
            this.MainPage_SubTitle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.MainPage_SubTitle1.Location = new System.Drawing.Point(586, 106);
            this.MainPage_SubTitle1.Name = "MainPage_SubTitle1";
            this.MainPage_SubTitle1.Size = new System.Drawing.Size(54, 25);
            this.MainPage_SubTitle1.TabIndex = 12;
            this.MainPage_SubTitle1.Text = "Logs";
            // 
            // MainPage_SubTitle2
            // 
            this.MainPage_SubTitle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_SubTitle2.AutoSize = true;
            this.MainPage_SubTitle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.MainPage_SubTitle2.Location = new System.Drawing.Point(899, 106);
            this.MainPage_SubTitle2.Name = "MainPage_SubTitle2";
            this.MainPage_SubTitle2.Size = new System.Drawing.Size(81, 25);
            this.MainPage_SubTitle2.TabIndex = 11;
            this.MainPage_SubTitle2.Text = "Clientes";
            // 
            // MainPage_TemplatesLabel
            // 
            this.MainPage_TemplatesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_TemplatesLabel.AutoSize = true;
            this.MainPage_TemplatesLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.MainPage_TemplatesLabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MainPage_TemplatesLabel.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_TemplatesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPage_TemplatesLabel.Location = new System.Drawing.Point(469, 22);
            this.MainPage_TemplatesLabel.Name = "MainPage_TemplatesLabel";
            this.MainPage_TemplatesLabel.Size = new System.Drawing.Size(171, 45);
            this.MainPage_TemplatesLabel.TabIndex = 10;
            this.MainPage_TemplatesLabel.Text = "Templates";
            // 
            // MainPage_TemplatesLabel_BG
            // 
            this.MainPage_TemplatesLabel_BG.BackColor = System.Drawing.Color.DodgerBlue;
            this.MainPage_TemplatesLabel_BG.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPage_TemplatesLabel_BG.Location = new System.Drawing.Point(3, 3);
            this.MainPage_TemplatesLabel_BG.Name = "MainPage_TemplatesLabel_BG";
            this.MainPage_TemplatesLabel_BG.Size = new System.Drawing.Size(1106, 81);
            this.MainPage_TemplatesLabel_BG.TabIndex = 9;
            this.MainPage_TemplatesLabel_BG.TabStop = false;
            // 
            // MainPage_Button_Voz
            // 
            this.MainPage_Button_Voz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_Voz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_Voz.Location = new System.Drawing.Point(299, 141);
            this.MainPage_Button_Voz.Name = "MainPage_Button_Voz";
            this.MainPage_Button_Voz.Size = new System.Drawing.Size(120, 55);
            this.MainPage_Button_Voz.TabIndex = 3;
            this.MainPage_Button_Voz.Text = "VOZ";
            this.MainPage_Button_Voz.UseVisualStyleBackColor = true;
            this.MainPage_Button_Voz.Click += new System.EventHandler(this.VOZ_Button_Click);
            // 
            // MainPage_Button_MPLS
            // 
            this.MainPage_Button_MPLS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage_Button_MPLS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage_Button_MPLS.Location = new System.Drawing.Point(173, 141);
            this.MainPage_Button_MPLS.Name = "MainPage_Button_MPLS";
            this.MainPage_Button_MPLS.Size = new System.Drawing.Size(120, 55);
            this.MainPage_Button_MPLS.TabIndex = 2;
            this.MainPage_Button_MPLS.Text = "MPLS";
            this.MainPage_Button_MPLS.UseVisualStyleBackColor = true;
            this.MainPage_Button_MPLS.Click += new System.EventHandler(this.MPLS_button_Click);
            // 
            // tabScript
            // 
            this.tabScript.AutoScroll = true;
            this.tabScript.AutoScrollMinSize = new System.Drawing.Size(0, 100);
            this.tabScript.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabScript.Controls.Add(this.Test_CheckBox_ShowVarOnScript);
            this.tabScript.Controls.Add(this.Script_Row);
            this.tabScript.Controls.Add(this.Script_Button_TACACS);
            this.tabScript.Controls.Add(this.Script_Button_ApplyTestValues);
            this.tabScript.Controls.Add(this.Script_AlterDate);
            this.tabScript.Controls.Add(this.Script_AlterDate_Label);
            this.tabScript.Controls.Add(this.Script_Button_Config);
            this.tabScript.Controls.Add(this.Script_Button_Copy);
            this.tabScript.Controls.Add(this.Script_Button_SwitchLabel);
            this.tabScript.Controls.Add(this.Script_LogBox_Label);
            this.tabScript.Controls.Add(this.HomeButton_Script);
            this.tabScript.Controls.Add(this.Script_SubTitle);
            this.tabScript.Controls.Add(this.Script_SwitchLabel);
            this.tabScript.Controls.Add(this.Script_LogBox);
            this.tabScript.Controls.Add(this.Script_Button_Debug);
            this.tabScript.Controls.Add(this.BackButton_Script2);
            this.tabScript.Controls.Add(this.Script_Button_FormCopy);
            this.tabScript.Controls.Add(this.Script_Button_Format);
            this.tabScript.Controls.Add(this.Script_ButtonsSubTab);
            this.tabScript.Controls.Add(this.BackButton_Script);
            this.tabScript.Controls.Add(this.BackButton_Script3);
            this.tabScript.Controls.Add(this.Script_TextBox);
            this.tabScript.Controls.Add(this.Test_Button_TestImport);
            this.tabScript.Controls.Add(this.Script_ProcedureName);
            this.tabScript.Controls.Add(this.tabControl4);
            this.tabScript.Controls.Add(this.Script_Button_Telnet);
            this.tabScript.Controls.Add(this.Script_Button_TelnetPlus);
            this.tabScript.Location = new System.Drawing.Point(4, 5);
            this.tabScript.Margin = new System.Windows.Forms.Padding(86, 87, 86, 87);
            this.tabScript.Name = "tabScript";
            this.tabScript.Padding = new System.Windows.Forms.Padding(3);
            this.tabScript.Size = new System.Drawing.Size(1112, 513);
            this.tabScript.TabIndex = 1;
            this.tabScript.Text = "Script";
            // 
            // Test_CheckBox_ShowVarOnScript
            // 
            this.Test_CheckBox_ShowVarOnScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Test_CheckBox_ShowVarOnScript.AutoSize = true;
            this.Test_CheckBox_ShowVarOnScript.Location = new System.Drawing.Point(711, 21);
            this.Test_CheckBox_ShowVarOnScript.Name = "Test_CheckBox_ShowVarOnScript";
            this.Test_CheckBox_ShowVarOnScript.Size = new System.Drawing.Size(135, 23);
            this.Test_CheckBox_ShowVarOnScript.TabIndex = 172;
            this.Test_CheckBox_ShowVarOnScript.Text = "Show True Script";
            this.Test_CheckBox_ShowVarOnScript.UseVisualStyleBackColor = true;
            this.Test_CheckBox_ShowVarOnScript.CheckedChanged += new System.EventHandler(this.Test_CheckBox_ShowVarOnScript_CheckedChanged);
            // 
            // Script_Row
            // 
            this.Script_Row.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Script_Row.BackColor = System.Drawing.Color.Gray;
            this.Script_Row.Location = new System.Drawing.Point(24, 69);
            this.Script_Row.MaximumSize = new System.Drawing.Size(2000, 1);
            this.Script_Row.MinimumSize = new System.Drawing.Size(500, 1);
            this.Script_Row.Name = "Script_Row";
            this.Script_Row.Size = new System.Drawing.Size(1033, 1);
            this.Script_Row.TabIndex = 171;
            this.Script_Row.TabStop = false;
            // 
            // Script_Button_TACACS
            // 
            this.Script_Button_TACACS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_Button_TACACS.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Script_Button_TACACS.Location = new System.Drawing.Point(1027, 314);
            this.Script_Button_TACACS.Name = "Script_Button_TACACS";
            this.Script_Button_TACACS.Size = new System.Drawing.Size(74, 43);
            this.Script_Button_TACACS.TabIndex = 165;
            this.Script_Button_TACACS.Text = "TACACS";
            this.Script_Button_TACACS.UseVisualStyleBackColor = true;
            this.Script_Button_TACACS.Click += new System.EventHandler(this.Script_TelnetButtonTACACS_Click);
            // 
            // Script_Button_ApplyTestValues
            // 
            this.Script_Button_ApplyTestValues.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Button_ApplyTestValues.Location = new System.Drawing.Point(236, 11);
            this.Script_Button_ApplyTestValues.Name = "Script_Button_ApplyTestValues";
            this.Script_Button_ApplyTestValues.Size = new System.Drawing.Size(84, 47);
            this.Script_Button_ApplyTestValues.TabIndex = 121;
            this.Script_Button_ApplyTestValues.Text = "Apply Test Values";
            this.Script_Button_ApplyTestValues.UseVisualStyleBackColor = true;
            this.Script_Button_ApplyTestValues.Click += new System.EventHandler(this.Button_ApplyTestValues_Click);
            // 
            // Script_AlterDate
            // 
            this.Script_AlterDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_AlterDate.AutoSize = true;
            this.Script_AlterDate.Location = new System.Drawing.Point(912, 477);
            this.Script_AlterDate.Name = "Script_AlterDate";
            this.Script_AlterDate.Size = new System.Drawing.Size(38, 19);
            this.Script_AlterDate.TabIndex = 120;
            this.Script_AlterDate.Text = "Data";
            // 
            // Script_AlterDate_Label
            // 
            this.Script_AlterDate_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_AlterDate_Label.AutoSize = true;
            this.Script_AlterDate_Label.Location = new System.Drawing.Point(908, 455);
            this.Script_AlterDate_Label.Name = "Script_AlterDate_Label";
            this.Script_AlterDate_Label.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Script_AlterDate_Label.Size = new System.Drawing.Size(121, 29);
            this.Script_AlterDate_Label.TabIndex = 119;
            this.Script_AlterDate_Label.Text = "Ultima Alteração: ";
            // 
            // Script_Button_Config
            // 
            this.Script_Button_Config.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Button_Config.Location = new System.Drawing.Point(121, 10);
            this.Script_Button_Config.Name = "Script_Button_Config";
            this.Script_Button_Config.Size = new System.Drawing.Size(104, 43);
            this.Script_Button_Config.TabIndex = 117;
            this.Script_Button_Config.Text = "Config";
            this.Script_Button_Config.UseVisualStyleBackColor = true;
            this.Script_Button_Config.Click += new System.EventHandler(this.Button_SwitchLog_Click);
            // 
            // Script_Button_Copy
            // 
            this.Script_Button_Copy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_Button_Copy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Button_Copy.Location = new System.Drawing.Point(824, 100);
            this.Script_Button_Copy.Name = "Script_Button_Copy";
            this.Script_Button_Copy.Size = new System.Drawing.Size(85, 34);
            this.Script_Button_Copy.TabIndex = 51;
            this.Script_Button_Copy.Text = "Copiar";
            this.Script_Button_Copy.UseVisualStyleBackColor = true;
            this.Script_Button_Copy.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // Script_Button_SwitchLabel
            // 
            this.Script_Button_SwitchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_Button_SwitchLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Script_Button_SwitchLabel.Location = new System.Drawing.Point(673, 81);
            this.Script_Button_SwitchLabel.Name = "Script_Button_SwitchLabel";
            this.Script_Button_SwitchLabel.Size = new System.Drawing.Size(97, 29);
            this.Script_Button_SwitchLabel.TabIndex = 43;
            this.Script_Button_SwitchLabel.Text = "Trocar";
            this.Script_Button_SwitchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Script_Button_SwitchLabel.UseVisualStyleBackColor = true;
            this.Script_Button_SwitchLabel.Click += new System.EventHandler(this.ButtonSwitchScriptLog_Click);
            // 
            // Script_LogBox_Label
            // 
            this.Script_LogBox_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_LogBox_Label.AutoSize = true;
            this.Script_LogBox_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_LogBox_Label.Location = new System.Drawing.Point(624, 115);
            this.Script_LogBox_Label.Name = "Script_LogBox_Label";
            this.Script_LogBox_Label.Size = new System.Drawing.Size(39, 17);
            this.Script_LogBox_Label.TabIndex = 28;
            this.Script_LogBox_Label.Text = "Logs:";
            // 
            // HomeButton_Script
            // 
            this.HomeButton_Script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton_Script.BackColor = System.Drawing.SystemColors.Highlight;
            this.HomeButton_Script.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton_Script.ForeColor = System.Drawing.Color.White;
            this.HomeButton_Script.Location = new System.Drawing.Point(953, 11);
            this.HomeButton_Script.Name = "HomeButton_Script";
            this.HomeButton_Script.Size = new System.Drawing.Size(104, 43);
            this.HomeButton_Script.TabIndex = 4;
            this.HomeButton_Script.Text = "Home";
            this.HomeButton_Script.UseVisualStyleBackColor = false;
            this.HomeButton_Script.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // Script_SubTitle
            // 
            this.Script_SubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_SubTitle.AutoSize = true;
            this.Script_SubTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_SubTitle.Location = new System.Drawing.Point(527, 97);
            this.Script_SubTitle.Name = "Script_SubTitle";
            this.Script_SubTitle.Size = new System.Drawing.Size(70, 30);
            this.Script_SubTitle.TabIndex = 3;
            this.Script_SubTitle.Text = "Script";
            // 
            // Script_SwitchLabel
            // 
            this.Script_SwitchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_SwitchLabel.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Bold);
            this.Script_SwitchLabel.Location = new System.Drawing.Point(673, 108);
            this.Script_SwitchLabel.Name = "Script_SwitchLabel";
            this.Script_SwitchLabel.Size = new System.Drawing.Size(97, 30);
            this.Script_SwitchLabel.TabIndex = 118;
            this.Script_SwitchLabel.Text = "Iniciais";
            this.Script_SwitchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Script_LogBox
            // 
            this.Script_LogBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_LogBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_LogBox.FormattingEnabled = true;
            this.Script_LogBox.Items.AddRange(new object[] {
            "INICIAIS",
            "APLICADAS",
            "FINAIS",
            "FALLBACK"});
            this.Script_LogBox.Location = new System.Drawing.Point(669, 109);
            this.Script_LogBox.Name = "Script_LogBox";
            this.Script_LogBox.Size = new System.Drawing.Size(106, 29);
            this.Script_LogBox.TabIndex = 25;
            this.Script_LogBox.SelectedIndexChanged += new System.EventHandler(this.Script_LogBox_SelectedIndexChanged);
            // 
            // Script_Button_Debug
            // 
            this.Script_Button_Debug.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_Button_Debug.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Script_Button_Debug.Location = new System.Drawing.Point(916, 367);
            this.Script_Button_Debug.Name = "Script_Button_Debug";
            this.Script_Button_Debug.Size = new System.Drawing.Size(104, 42);
            this.Script_Button_Debug.TabIndex = 154;
            this.Script_Button_Debug.Text = "Debug";
            this.Script_Button_Debug.UseVisualStyleBackColor = true;
            this.Script_Button_Debug.Click += new System.EventHandler(this.Script_DebugButton_Click);
            // 
            // BackButton_Script2
            // 
            this.BackButton_Script2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_Script2.Location = new System.Drawing.Point(11, 10);
            this.BackButton_Script2.Name = "BackButton_Script2";
            this.BackButton_Script2.Size = new System.Drawing.Size(102, 43);
            this.BackButton_Script2.TabIndex = 29;
            this.BackButton_Script2.Text = "Voltar";
            this.BackButton_Script2.UseVisualStyleBackColor = true;
            this.BackButton_Script2.Click += new System.EventHandler(this.BackButton_Script2_Click);
            // 
            // Script_Button_FormCopy
            // 
            this.Script_Button_FormCopy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_Button_FormCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Button_FormCopy.Location = new System.Drawing.Point(916, 100);
            this.Script_Button_FormCopy.Name = "Script_Button_FormCopy";
            this.Script_Button_FormCopy.Size = new System.Drawing.Size(77, 52);
            this.Script_Button_FormCopy.TabIndex = 71;
            this.Script_Button_FormCopy.Text = "Copiar e Formatar";
            this.Script_Button_FormCopy.UseVisualStyleBackColor = true;
            this.Script_Button_FormCopy.Click += new System.EventHandler(this.Button_FormatarECopiarScript_Click);
            // 
            // Script_Button_Format
            // 
            this.Script_Button_Format.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_Button_Format.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Script_Button_Format.Location = new System.Drawing.Point(916, 154);
            this.Script_Button_Format.Name = "Script_Button_Format";
            this.Script_Button_Format.Size = new System.Drawing.Size(77, 37);
            this.Script_Button_Format.TabIndex = 27;
            this.Script_Button_Format.Text = "Formatar";
            this.Script_Button_Format.UseVisualStyleBackColor = true;
            this.Script_Button_Format.Click += new System.EventHandler(this.Button_FormatarScript_Click);
            // 
            // Script_ButtonsSubTab
            // 
            this.Script_ButtonsSubTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_ButtonsSubTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Script_ButtonsSubTab.Controls.Add(this.Script_ButtonsSubTab_Voz);
            this.Script_ButtonsSubTab.Controls.Add(this.Script_ButtonsSubTab_Logs);
            this.Script_ButtonsSubTab.Controls.Add(this.Script_ButtonsSubTab_BackboneBGP);
            this.Script_ButtonsSubTab.Controls.Add(this.Script_ButtonsSubTab_Hollow);
            this.Script_ButtonsSubTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.Script_ButtonsSubTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Script_ButtonsSubTab.ItemSize = new System.Drawing.Size(0, 1);
            this.Script_ButtonsSubTab.Location = new System.Drawing.Point(908, 198);
            this.Script_ButtonsSubTab.Multiline = true;
            this.Script_ButtonsSubTab.Name = "Script_ButtonsSubTab";
            this.Script_ButtonsSubTab.Padding = new System.Drawing.Point(0, 0);
            this.Script_ButtonsSubTab.SelectedIndex = 0;
            this.Script_ButtonsSubTab.Size = new System.Drawing.Size(125, 110);
            this.Script_ButtonsSubTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Script_ButtonsSubTab.TabIndex = 167;
            // 
            // Script_ButtonsSubTab_Voz
            // 
            this.Script_ButtonsSubTab_Voz.AutoScroll = true;
            this.Script_ButtonsSubTab_Voz.BackColor = System.Drawing.SystemColors.Control;
            this.Script_ButtonsSubTab_Voz.Controls.Add(this.Script_ButtonRegraAdc);
            this.Script_ButtonsSubTab_Voz.Controls.Add(this.Script_Button_Tracert);
            this.Script_ButtonsSubTab_Voz.Location = new System.Drawing.Point(4, 5);
            this.Script_ButtonsSubTab_Voz.Name = "Script_ButtonsSubTab_Voz";
            this.Script_ButtonsSubTab_Voz.Padding = new System.Windows.Forms.Padding(3);
            this.Script_ButtonsSubTab_Voz.Size = new System.Drawing.Size(117, 101);
            this.Script_ButtonsSubTab_Voz.TabIndex = 0;
            this.Script_ButtonsSubTab_Voz.Text = "Voz";
            // 
            // Script_ButtonRegraAdc
            // 
            this.Script_ButtonRegraAdc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Script_ButtonRegraAdc.Location = new System.Drawing.Point(6, 45);
            this.Script_ButtonRegraAdc.Name = "Script_ButtonRegraAdc";
            this.Script_ButtonRegraAdc.Size = new System.Drawing.Size(107, 50);
            this.Script_ButtonRegraAdc.TabIndex = 162;
            this.Script_ButtonRegraAdc.Text = "Regra Adicional";
            this.Script_ButtonRegraAdc.UseVisualStyleBackColor = true;
            // 
            // Script_Button_Tracert
            // 
            this.Script_Button_Tracert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Button_Tracert.Location = new System.Drawing.Point(6, 7);
            this.Script_Button_Tracert.Name = "Script_Button_Tracert";
            this.Script_Button_Tracert.Size = new System.Drawing.Size(107, 36);
            this.Script_Button_Tracert.TabIndex = 163;
            this.Script_Button_Tracert.Text = "Traceroute";
            this.Script_Button_Tracert.UseVisualStyleBackColor = true;
            this.Script_Button_Tracert.Click += new System.EventHandler(this.Script_TracertButton_Click);
            // 
            // Script_ButtonsSubTab_Logs
            // 
            this.Script_ButtonsSubTab_Logs.BackColor = System.Drawing.SystemColors.Control;
            this.Script_ButtonsSubTab_Logs.Controls.Add(this.Script_Button_Limpeza);
            this.Script_ButtonsSubTab_Logs.Controls.Add(this.Script_Button_Parte2);
            this.Script_ButtonsSubTab_Logs.Location = new System.Drawing.Point(4, 5);
            this.Script_ButtonsSubTab_Logs.Name = "Script_ButtonsSubTab_Logs";
            this.Script_ButtonsSubTab_Logs.Padding = new System.Windows.Forms.Padding(3);
            this.Script_ButtonsSubTab_Logs.Size = new System.Drawing.Size(117, 101);
            this.Script_ButtonsSubTab_Logs.TabIndex = 1;
            this.Script_ButtonsSubTab_Logs.Text = "Logs";
            // 
            // Script_Button_Limpeza
            // 
            this.Script_Button_Limpeza.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Button_Limpeza.Location = new System.Drawing.Point(6, 46);
            this.Script_Button_Limpeza.Name = "Script_Button_Limpeza";
            this.Script_Button_Limpeza.Size = new System.Drawing.Size(98, 34);
            this.Script_Button_Limpeza.TabIndex = 42;
            this.Script_Button_Limpeza.Text = "Limpeza";
            this.Script_Button_Limpeza.UseVisualStyleBackColor = true;
            this.Script_Button_Limpeza.Click += new System.EventHandler(this.ButtonLimpeza_Click);
            // 
            // Script_Button_Parte2
            // 
            this.Script_Button_Parte2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Button_Parte2.Location = new System.Drawing.Point(6, 5);
            this.Script_Button_Parte2.Name = "Script_Button_Parte2";
            this.Script_Button_Parte2.Size = new System.Drawing.Size(98, 34);
            this.Script_Button_Parte2.TabIndex = 41;
            this.Script_Button_Parte2.Text = "Parte 2";
            this.Script_Button_Parte2.UseVisualStyleBackColor = true;
            this.Script_Button_Parte2.Click += new System.EventHandler(this.ButtonParte2_Click);
            // 
            // Script_ButtonsSubTab_BackboneBGP
            // 
            this.Script_ButtonsSubTab_BackboneBGP.BackColor = System.Drawing.SystemColors.Control;
            this.Script_ButtonsSubTab_BackboneBGP.Controls.Add(this.Script_Button_IPv6);
            this.Script_ButtonsSubTab_BackboneBGP.Controls.Add(this.Script_Button_Multihop);
            this.Script_ButtonsSubTab_BackboneBGP.Location = new System.Drawing.Point(4, 5);
            this.Script_ButtonsSubTab_BackboneBGP.Name = "Script_ButtonsSubTab_BackboneBGP";
            this.Script_ButtonsSubTab_BackboneBGP.Padding = new System.Windows.Forms.Padding(3);
            this.Script_ButtonsSubTab_BackboneBGP.Size = new System.Drawing.Size(117, 101);
            this.Script_ButtonsSubTab_BackboneBGP.TabIndex = 2;
            this.Script_ButtonsSubTab_BackboneBGP.Text = "Route-Map";
            // 
            // Script_Button_IPv6
            // 
            this.Script_Button_IPv6.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.Script_Button_IPv6.Location = new System.Drawing.Point(6, 6);
            this.Script_Button_IPv6.Name = "Script_Button_IPv6";
            this.Script_Button_IPv6.Size = new System.Drawing.Size(104, 43);
            this.Script_Button_IPv6.TabIndex = 161;
            this.Script_Button_IPv6.Text = "IPv6";
            this.Script_Button_IPv6.UseVisualStyleBackColor = true;
            // 
            // Script_Button_Multihop
            // 
            this.Script_Button_Multihop.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.Script_Button_Multihop.Location = new System.Drawing.Point(6, 56);
            this.Script_Button_Multihop.Name = "Script_Button_Multihop";
            this.Script_Button_Multihop.Size = new System.Drawing.Size(104, 43);
            this.Script_Button_Multihop.TabIndex = 162;
            this.Script_Button_Multihop.Text = "Multihop";
            this.Script_Button_Multihop.UseVisualStyleBackColor = true;
            // 
            // Script_ButtonsSubTab_Hollow
            // 
            this.Script_ButtonsSubTab_Hollow.Location = new System.Drawing.Point(4, 5);
            this.Script_ButtonsSubTab_Hollow.Name = "Script_ButtonsSubTab_Hollow";
            this.Script_ButtonsSubTab_Hollow.Size = new System.Drawing.Size(117, 101);
            this.Script_ButtonsSubTab_Hollow.TabIndex = 3;
            this.Script_ButtonsSubTab_Hollow.Text = "Vazio";
            this.Script_ButtonsSubTab_Hollow.UseVisualStyleBackColor = true;
            // 
            // BackButton_Script
            // 
            this.BackButton_Script.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_Script.Location = new System.Drawing.Point(9, 6);
            this.BackButton_Script.Name = "BackButton_Script";
            this.BackButton_Script.Size = new System.Drawing.Size(104, 43);
            this.BackButton_Script.TabIndex = 26;
            this.BackButton_Script.Text = "Voltar";
            this.BackButton_Script.UseVisualStyleBackColor = true;
            this.BackButton_Script.Click += new System.EventHandler(this.BackButton1_Click);
            // 
            // BackButton_Script3
            // 
            this.BackButton_Script3.BackColor = System.Drawing.SystemColors.Control;
            this.BackButton_Script3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_Script3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton_Script3.Location = new System.Drawing.Point(9, 6);
            this.BackButton_Script3.Name = "BackButton_Script3";
            this.BackButton_Script3.Size = new System.Drawing.Size(104, 43);
            this.BackButton_Script3.TabIndex = 30;
            this.BackButton_Script3.Text = "Voltar";
            this.BackButton_Script3.UseVisualStyleBackColor = false;
            this.BackButton_Script3.Click += new System.EventHandler(this.BackButton_Script3_Click_Click);
            // 
            // Script_TextBox
            // 
            this.Script_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Script_TextBox.Location = new System.Drawing.Point(528, 141);
            this.Script_TextBox.Name = "Script_TextBox";
            this.Script_TextBox.Size = new System.Drawing.Size(378, 361);
            this.Script_TextBox.TabIndex = 116;
            this.Script_TextBox.Text = "";
            this.Script_TextBox.WordWrap = false;
            // 
            // Test_Button_TestImport
            // 
            this.Test_Button_TestImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Test_Button_TestImport.AutoSize = true;
            this.Test_Button_TestImport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_Button_TestImport.Location = new System.Drawing.Point(852, 15);
            this.Test_Button_TestImport.Name = "Test_Button_TestImport";
            this.Test_Button_TestImport.Size = new System.Drawing.Size(95, 36);
            this.Test_Button_TestImport.TabIndex = 152;
            this.Test_Button_TestImport.Text = "Teste Import";
            this.Test_Button_TestImport.UseVisualStyleBackColor = true;
            this.Test_Button_TestImport.Click += new System.EventHandler(this.TestImportSAIP);
            // 
            // Script_ProcedureName
            // 
            this.Script_ProcedureName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Script_ProcedureName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_ProcedureName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Script_ProcedureName.Location = new System.Drawing.Point(3, 11);
            this.Script_ProcedureName.Margin = new System.Windows.Forms.Padding(0);
            this.Script_ProcedureName.Name = "Script_ProcedureName";
            this.Script_ProcedureName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Script_ProcedureName.Size = new System.Drawing.Size(1072, 45);
            this.Script_ProcedureName.TabIndex = 5;
            this.Script_ProcedureName.Text = "Procedure Name";
            this.Script_ProcedureName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl4
            // 
            this.tabControl4.AllowDrop = true;
            this.tabControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl4.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl4.HotTrack = true;
            this.tabControl4.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl4.Location = new System.Drawing.Point(2, 69);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.Padding = new System.Drawing.Point(0, 0);
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(487, 443);
            this.tabControl4.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl4.TabIndex = 170;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.Script_Button_ClearPortas);
            this.tabPage4.Controls.Add(this.Script_Button_Inverter);
            this.tabPage4.Controls.Add(this.Script_VarSubTab);
            this.tabPage4.Controls.Add(this.Script_VarText06);
            this.tabPage4.Controls.Add(this.Script_DeleteVar02);
            this.tabPage4.Controls.Add(this.Script_DeleteVar09);
            this.tabPage4.Controls.Add(this.Script_DeleteVar08);
            this.tabPage4.Controls.Add(this.Script_DeleteVar07);
            this.tabPage4.Controls.Add(this.Script_DeleteVar10);
            this.tabPage4.Controls.Add(this.Script_DeleteVar11);
            this.tabPage4.Controls.Add(this.Script_VarText09);
            this.tabPage4.Controls.Add(this.Script_Hint1);
            this.tabPage4.Controls.Add(this.Script_Button_PortImport);
            this.tabPage4.Controls.Add(this.Script_VarText03b);
            this.tabPage4.Controls.Add(this.Script_ExLabel);
            this.tabPage4.Controls.Add(this.Script_VarEx13);
            this.tabPage4.Controls.Add(this.Script_VarEx14);
            this.tabPage4.Controls.Add(this.Script_DeleteVar06);
            this.tabPage4.Controls.Add(this.Script_VarEx15);
            this.tabPage4.Controls.Add(this.Script_VarEx12);
            this.tabPage4.Controls.Add(this.Script_VarEx11);
            this.tabPage4.Controls.Add(this.Script_VarEx10);
            this.tabPage4.Controls.Add(this.Script_VarEx09);
            this.tabPage4.Controls.Add(this.Script_LANMascaraBox);
            this.tabPage4.Controls.Add(this.Script_VarEx08);
            this.tabPage4.Controls.Add(this.Script_VarEx07);
            this.tabPage4.Controls.Add(this.Script_VarEx06);
            this.tabPage4.Controls.Add(this.Script_VarEx05);
            this.tabPage4.Controls.Add(this.Script_VarEx04);
            this.tabPage4.Controls.Add(this.Script_VarEx03);
            this.tabPage4.Controls.Add(this.Script_VarEx02);
            this.tabPage4.Controls.Add(this.Script_VarEx01);
            this.tabPage4.Controls.Add(this.Script_VarEx00);
            this.tabPage4.Controls.Add(this.Script_DeleteVar15);
            this.tabPage4.Controls.Add(this.Script_VarText15);
            this.tabPage4.Controls.Add(this.Script_VarName15);
            this.tabPage4.Controls.Add(this.Script_DeleteVar14);
            this.tabPage4.Controls.Add(this.Script_VarText14);
            this.tabPage4.Controls.Add(this.Script_VarName14);
            this.tabPage4.Controls.Add(this.Script_DeleteVar13);
            this.tabPage4.Controls.Add(this.Script_VarText13);
            this.tabPage4.Controls.Add(this.Script_VarName13);
            this.tabPage4.Controls.Add(this.Script_DeleteVar12);
            this.tabPage4.Controls.Add(this.Script_VarText12);
            this.tabPage4.Controls.Add(this.Script_VarName12);
            this.tabPage4.Controls.Add(this.Script_DeleteVar05);
            this.tabPage4.Controls.Add(this.Script_DeleteVar04);
            this.tabPage4.Controls.Add(this.Script_DeleteVar01);
            this.tabPage4.Controls.Add(this.Script_DeleteVar00);
            this.tabPage4.Controls.Add(this.Script_ModelLabel);
            this.tabPage4.Controls.Add(this.Script_RouterModelBox);
            this.tabPage4.Controls.Add(this.Script_VarText11);
            this.tabPage4.Controls.Add(this.Script_VarName11);
            this.tabPage4.Controls.Add(this.Script_VarText10);
            this.tabPage4.Controls.Add(this.Script_VarName10);
            this.tabPage4.Controls.Add(this.Script_VarName09);
            this.tabPage4.Controls.Add(this.Script_VarText08);
            this.tabPage4.Controls.Add(this.Script_VarName08);
            this.tabPage4.Controls.Add(this.Script_VarText07);
            this.tabPage4.Controls.Add(this.Script_VarName07);
            this.tabPage4.Controls.Add(this.Script_VarName06);
            this.tabPage4.Controls.Add(this.Script_Button_Clear);
            this.tabPage4.Controls.Add(this.Script_VarTitle);
            this.tabPage4.Controls.Add(this.Script_VarText05);
            this.tabPage4.Controls.Add(this.Script_VarText04);
            this.tabPage4.Controls.Add(this.Script_VarText03);
            this.tabPage4.Controls.Add(this.Script_VarText02);
            this.tabPage4.Controls.Add(this.Script_VarText01);
            this.tabPage4.Controls.Add(this.Script_VarName05);
            this.tabPage4.Controls.Add(this.Script_VarName03);
            this.tabPage4.Controls.Add(this.Script_VarName04);
            this.tabPage4.Controls.Add(this.Script_VarName02);
            this.tabPage4.Controls.Add(this.Script_VarName01);
            this.tabPage4.Controls.Add(this.Script_VarName00);
            this.tabPage4.Controls.Add(this.Script_VarText00);
            this.tabPage4.Controls.Add(this.Script_XRLabel);
            this.tabPage4.Controls.Add(this.Script_XRBox);
            this.tabPage4.Controls.Add(this.Script_DeleteVar03);
            this.tabPage4.Controls.Add(this.Script_DeleteVar03b);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(479, 434);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Script_Button_ClearPortas
            // 
            this.Script_Button_ClearPortas.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.Script_Button_ClearPortas.Location = new System.Drawing.Point(195, -1);
            this.Script_Button_ClearPortas.Name = "Script_Button_ClearPortas";
            this.Script_Button_ClearPortas.Size = new System.Drawing.Size(89, 26);
            this.Script_Button_ClearPortas.TabIndex = 266;
            this.Script_Button_ClearPortas.Text = "Limpar Portas";
            this.Script_Button_ClearPortas.UseVisualStyleBackColor = true;
            this.Script_Button_ClearPortas.Click += new System.EventHandler(this.Script_Button_ClearPortas_Click);
            // 
            // Script_Button_Inverter
            // 
            this.Script_Button_Inverter.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.Script_Button_Inverter.Location = new System.Drawing.Point(285, -1);
            this.Script_Button_Inverter.Name = "Script_Button_Inverter";
            this.Script_Button_Inverter.Size = new System.Drawing.Size(95, 26);
            this.Script_Button_Inverter.TabIndex = 265;
            this.Script_Button_Inverter.Text = "Inverter Portas";
            this.Script_Button_Inverter.UseVisualStyleBackColor = true;
            this.Script_Button_Inverter.Click += new System.EventHandler(this.Script_Button_Inverter_Click);
            // 
            // Script_VarSubTab
            // 
            this.Script_VarSubTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Script_VarSubTab.Controls.Add(this.Script_SubTab_VozVar);
            this.Script_VarSubTab.Controls.Add(this.Script_SubTab_RouteMap);
            this.Script_VarSubTab.Controls.Add(this.Script_VarSubTab_Hollow);
            this.Script_VarSubTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Script_VarSubTab.ItemSize = new System.Drawing.Size(0, 1);
            this.Script_VarSubTab.Location = new System.Drawing.Point(18, 351);
            this.Script_VarSubTab.Multiline = true;
            this.Script_VarSubTab.Name = "Script_VarSubTab";
            this.Script_VarSubTab.SelectedIndex = 0;
            this.Script_VarSubTab.Size = new System.Drawing.Size(414, 234);
            this.Script_VarSubTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Script_VarSubTab.TabIndex = 264;
            // 
            // Script_SubTab_VozVar
            // 
            this.Script_SubTab_VozVar.Controls.Add(this.Script_SinalizLabel);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_SinalizBox);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarEx21);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_DeleteVar21);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarName21);
            this.Script_SubTab_VozVar.Controls.Add(this.BigTitle_Label);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_DeleteVar16);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarEx18);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarEx19);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarEx20);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarEx17);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarEx16);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_DeleteVar20);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarText20);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarName20);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_DeleteVar19);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarText19);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarName19);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_DeleteVar18);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarText18);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarName18);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_DeleteVar17);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarText17);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarName17);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarText16);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarName16);
            this.Script_SubTab_VozVar.Controls.Add(this.Script_VarText21);
            this.Script_SubTab_VozVar.Location = new System.Drawing.Point(4, 5);
            this.Script_SubTab_VozVar.Name = "Script_SubTab_VozVar";
            this.Script_SubTab_VozVar.Padding = new System.Windows.Forms.Padding(3);
            this.Script_SubTab_VozVar.Size = new System.Drawing.Size(406, 225);
            this.Script_SubTab_VozVar.TabIndex = 0;
            this.Script_SubTab_VozVar.Text = "Script_SubTab_Voz";
            this.Script_SubTab_VozVar.UseVisualStyleBackColor = true;
            // 
            // Script_SinalizLabel
            // 
            this.Script_SinalizLabel.AutoSize = true;
            this.Script_SinalizLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_SinalizLabel.Location = new System.Drawing.Point(314, 14);
            this.Script_SinalizLabel.Name = "Script_SinalizLabel";
            this.Script_SinalizLabel.Size = new System.Drawing.Size(73, 17);
            this.Script_SinalizLabel.TabIndex = 204;
            this.Script_SinalizLabel.Text = "Sinalização:";
            // 
            // Script_SinalizBox
            // 
            this.Script_SinalizBox.FormattingEnabled = true;
            this.Script_SinalizBox.Items.AddRange(new object[] {
            "R2",
            "ISDN",
            "PABXIP"});
            this.Script_SinalizBox.Location = new System.Drawing.Point(315, 37);
            this.Script_SinalizBox.Name = "Script_SinalizBox";
            this.Script_SinalizBox.Size = new System.Drawing.Size(72, 27);
            this.Script_SinalizBox.TabIndex = 203;
            this.Script_SinalizBox.SelectedIndexChanged += new System.EventHandler(this.Script_SinalizBox_SelectedIndexChanged);
            // 
            // Script_VarEx21
            // 
            this.Script_VarEx21.AutoSize = true;
            this.Script_VarEx21.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx21.Location = new System.Drawing.Point(235, 167);
            this.Script_VarEx21.Name = "Script_VarEx21";
            this.Script_VarEx21.Size = new System.Drawing.Size(24, 15);
            this.Script_VarEx21.TabIndex = 201;
            this.Script_VarEx21.Text = "0/1";
            // 
            // Script_DeleteVar21
            // 
            this.Script_DeleteVar21.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar21.Location = new System.Drawing.Point(206, 162);
            this.Script_DeleteVar21.Name = "Script_DeleteVar21";
            this.Script_DeleteVar21.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar21.TabIndex = 200;
            this.Script_DeleteVar21.Text = "-";
            this.Script_DeleteVar21.UseVisualStyleBackColor = true;
            this.Script_DeleteVar21.Click += new System.EventHandler(this.Script_VarDelete21_Click);
            // 
            // Script_VarName21
            // 
            this.Script_VarName21.AutoSize = true;
            this.Script_VarName21.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName21.Location = new System.Drawing.Point(12, 165);
            this.Script_VarName21.Name = "Script_VarName21";
            this.Script_VarName21.Size = new System.Drawing.Size(60, 17);
            this.Script_VarName21.TabIndex = 198;
            this.Script_VarName21.Text = "Porta E1:";
            // 
            // BigTitle_Label
            // 
            this.BigTitle_Label.AutoSize = true;
            this.BigTitle_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigTitle_Label.Location = new System.Drawing.Point(120, -64);
            this.BigTitle_Label.Name = "BigTitle_Label";
            this.BigTitle_Label.Size = new System.Drawing.Size(150, 25);
            this.BigTitle_Label.TabIndex = 197;
            this.BigTitle_Label.Text = "Variáveis de Voz";
            // 
            // Script_DeleteVar16
            // 
            this.Script_DeleteVar16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar16.Location = new System.Drawing.Point(206, 11);
            this.Script_DeleteVar16.Name = "Script_DeleteVar16";
            this.Script_DeleteVar16.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar16.TabIndex = 196;
            this.Script_DeleteVar16.Text = "-";
            this.Script_DeleteVar16.UseVisualStyleBackColor = true;
            this.Script_DeleteVar16.Click += new System.EventHandler(this.Script_VarDelete16_Click);
            // 
            // Script_VarEx18
            // 
            this.Script_VarEx18.AutoSize = true;
            this.Script_VarEx18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx18.Location = new System.Drawing.Point(235, 77);
            this.Script_VarEx18.Name = "Script_VarEx18";
            this.Script_VarEx18.Size = new System.Drawing.Size(19, 15);
            this.Script_VarEx18.TabIndex = 195;
            this.Script_VarEx18.Text = "21";
            // 
            // Script_VarEx19
            // 
            this.Script_VarEx19.AutoSize = true;
            this.Script_VarEx19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx19.Location = new System.Drawing.Point(235, 107);
            this.Script_VarEx19.Name = "Script_VarEx19";
            this.Script_VarEx19.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.Script_VarEx19.Size = new System.Drawing.Size(111, 13);
            this.Script_VarEx19.TabIndex = 194;
            this.Script_VarEx19.Text = "000000[0-9][0-9]";
            // 
            // Script_VarEx20
            // 
            this.Script_VarEx20.AutoSize = true;
            this.Script_VarEx20.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx20.Location = new System.Drawing.Point(235, 137);
            this.Script_VarEx20.Name = "Script_VarEx20";
            this.Script_VarEx20.Size = new System.Drawing.Size(60, 15);
            this.Script_VarEx20.TabIndex = 193;
            this.Script_VarEx20.Text = "1-15,17-31";
            // 
            // Script_VarEx17
            // 
            this.Script_VarEx17.AutoSize = true;
            this.Script_VarEx17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx17.Location = new System.Drawing.Point(235, 46);
            this.Script_VarEx17.Name = "Script_VarEx17";
            this.Script_VarEx17.Size = new System.Drawing.Size(63, 15);
            this.Script_VarEx17.TabIndex = 192;
            this.Script_VarEx17.Text = "00000000";
            // 
            // Script_VarEx16
            // 
            this.Script_VarEx16.AutoSize = true;
            this.Script_VarEx16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx16.Location = new System.Drawing.Point(235, 16);
            this.Script_VarEx16.Name = "Script_VarEx16";
            this.Script_VarEx16.Size = new System.Drawing.Size(76, 15);
            this.Script_VarEx16.TabIndex = 191;
            this.Script_VarEx16.Text = "189.55.37.89";
            // 
            // Script_DeleteVar20
            // 
            this.Script_DeleteVar20.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar20.Location = new System.Drawing.Point(206, 132);
            this.Script_DeleteVar20.Name = "Script_DeleteVar20";
            this.Script_DeleteVar20.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar20.TabIndex = 190;
            this.Script_DeleteVar20.Text = "-";
            this.Script_DeleteVar20.UseVisualStyleBackColor = true;
            this.Script_DeleteVar20.Click += new System.EventHandler(this.Script_VarDelete20_Click);
            // 
            // Script_VarText20
            // 
            this.Script_VarText20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText20.Location = new System.Drawing.Point(107, 132);
            this.Script_VarText20.Name = "Script_VarText20";
            this.Script_VarText20.Size = new System.Drawing.Size(93, 25);
            this.Script_VarText20.TabIndex = 189;
            this.Script_VarText20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName20
            // 
            this.Script_VarName20.AutoSize = true;
            this.Script_VarName20.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName20.Location = new System.Drawing.Point(12, 135);
            this.Script_VarName20.Name = "Script_VarName20";
            this.Script_VarName20.Size = new System.Drawing.Size(87, 17);
            this.Script_VarName20.TabIndex = 188;
            this.Script_VarName20.Text = "N° de Canais:";
            // 
            // Script_DeleteVar19
            // 
            this.Script_DeleteVar19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar19.Location = new System.Drawing.Point(206, 101);
            this.Script_DeleteVar19.Name = "Script_DeleteVar19";
            this.Script_DeleteVar19.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar19.TabIndex = 187;
            this.Script_DeleteVar19.Text = "-";
            this.Script_DeleteVar19.UseVisualStyleBackColor = true;
            this.Script_DeleteVar19.Click += new System.EventHandler(this.Script_VarDelete19_Click);
            // 
            // Script_VarText19
            // 
            this.Script_VarText19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText19.Location = new System.Drawing.Point(107, 101);
            this.Script_VarText19.Name = "Script_VarText19";
            this.Script_VarText19.Size = new System.Drawing.Size(93, 25);
            this.Script_VarText19.TabIndex = 186;
            this.Script_VarText19.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName19
            // 
            this.Script_VarName19.AutoSize = true;
            this.Script_VarName19.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName19.Location = new System.Drawing.Point(11, 105);
            this.Script_VarName19.Name = "Script_VarName19";
            this.Script_VarName19.Size = new System.Drawing.Size(86, 17);
            this.Script_VarName19.TabIndex = 185;
            this.Script_VarName19.Text = "Regra Ramal:";
            // 
            // Script_DeleteVar18
            // 
            this.Script_DeleteVar18.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar18.Location = new System.Drawing.Point(206, 71);
            this.Script_DeleteVar18.Name = "Script_DeleteVar18";
            this.Script_DeleteVar18.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar18.TabIndex = 184;
            this.Script_DeleteVar18.Text = "-";
            this.Script_DeleteVar18.UseVisualStyleBackColor = true;
            this.Script_DeleteVar18.Click += new System.EventHandler(this.Script_VarDelete18_Click);
            // 
            // Script_VarText18
            // 
            this.Script_VarText18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText18.Location = new System.Drawing.Point(107, 71);
            this.Script_VarText18.Name = "Script_VarText18";
            this.Script_VarText18.Size = new System.Drawing.Size(93, 25);
            this.Script_VarText18.TabIndex = 183;
            this.Script_VarText18.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName18
            // 
            this.Script_VarName18.AutoSize = true;
            this.Script_VarName18.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName18.Location = new System.Drawing.Point(12, 75);
            this.Script_VarName18.Name = "Script_VarName18";
            this.Script_VarName18.Size = new System.Drawing.Size(38, 17);
            this.Script_VarName18.TabIndex = 182;
            this.Script_VarName18.Text = "DDD:";
            // 
            // Script_DeleteVar17
            // 
            this.Script_DeleteVar17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar17.Location = new System.Drawing.Point(206, 41);
            this.Script_DeleteVar17.Name = "Script_DeleteVar17";
            this.Script_DeleteVar17.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar17.TabIndex = 181;
            this.Script_DeleteVar17.Text = "-";
            this.Script_DeleteVar17.UseVisualStyleBackColor = true;
            this.Script_DeleteVar17.Click += new System.EventHandler(this.Script_VarDelete17_Click);
            // 
            // Script_VarText17
            // 
            this.Script_VarText17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText17.Location = new System.Drawing.Point(107, 41);
            this.Script_VarText17.Name = "Script_VarText17";
            this.Script_VarText17.Size = new System.Drawing.Size(93, 25);
            this.Script_VarText17.TabIndex = 180;
            this.Script_VarText17.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName17
            // 
            this.Script_VarName17.AutoSize = true;
            this.Script_VarName17.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName17.Location = new System.Drawing.Point(12, 45);
            this.Script_VarName17.Name = "Script_VarName17";
            this.Script_VarName17.Size = new System.Drawing.Size(91, 17);
            this.Script_VarName17.TabIndex = 179;
            this.Script_VarName17.Text = "Tronco-Chave:";
            // 
            // Script_VarText16
            // 
            this.Script_VarText16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText16.Location = new System.Drawing.Point(107, 11);
            this.Script_VarText16.Name = "Script_VarText16";
            this.Script_VarText16.Size = new System.Drawing.Size(93, 25);
            this.Script_VarText16.TabIndex = 178;
            this.Script_VarText16.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName16
            // 
            this.Script_VarName16.AutoSize = true;
            this.Script_VarName16.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName16.Location = new System.Drawing.Point(10, 14);
            this.Script_VarName16.Name = "Script_VarName16";
            this.Script_VarName16.Size = new System.Drawing.Size(87, 17);
            this.Script_VarName16.TabIndex = 177;
            this.Script_VarName16.Text = "IP SIP Acesso:";
            // 
            // Script_VarText21
            // 
            this.Script_VarText21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText21.Location = new System.Drawing.Point(107, 162);
            this.Script_VarText21.Name = "Script_VarText21";
            this.Script_VarText21.Size = new System.Drawing.Size(93, 25);
            this.Script_VarText21.TabIndex = 199;
            this.Script_VarText21.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_SubTab_RouteMap
            // 
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_DeleteRouteI1);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_DeleteRouteI2);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_DeleteRouteE1);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_DeleteRouteE2);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_VarRouteE2);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_VarRouteE1);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_VarRouteE2Label);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_VarRouteE1Label);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_VarRouteI2Label);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_VarRouteI2);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_VarRouteI1Label);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_VarRouteI1);
            this.Script_SubTab_RouteMap.Controls.Add(this.Script_RouteLabelHint);
            this.Script_SubTab_RouteMap.Location = new System.Drawing.Point(4, 5);
            this.Script_SubTab_RouteMap.Name = "Script_SubTab_RouteMap";
            this.Script_SubTab_RouteMap.Padding = new System.Windows.Forms.Padding(3);
            this.Script_SubTab_RouteMap.Size = new System.Drawing.Size(406, 225);
            this.Script_SubTab_RouteMap.TabIndex = 1;
            this.Script_SubTab_RouteMap.Text = "Script_VarSubTab_RouteMap";
            this.Script_SubTab_RouteMap.UseVisualStyleBackColor = true;
            // 
            // Script_DeleteRouteI1
            // 
            this.Script_DeleteRouteI1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteRouteI1.Location = new System.Drawing.Point(285, 57);
            this.Script_DeleteRouteI1.Name = "Script_DeleteRouteI1";
            this.Script_DeleteRouteI1.Size = new System.Drawing.Size(20, 20);
            this.Script_DeleteRouteI1.TabIndex = 243;
            this.Script_DeleteRouteI1.Text = "-";
            this.Script_DeleteRouteI1.UseVisualStyleBackColor = true;
            this.Script_DeleteRouteI1.Click += new System.EventHandler(this.Script_DeleteRouteI1_Click);
            // 
            // Script_DeleteRouteI2
            // 
            this.Script_DeleteRouteI2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteRouteI2.Location = new System.Drawing.Point(285, 97);
            this.Script_DeleteRouteI2.Name = "Script_DeleteRouteI2";
            this.Script_DeleteRouteI2.Size = new System.Drawing.Size(20, 20);
            this.Script_DeleteRouteI2.TabIndex = 242;
            this.Script_DeleteRouteI2.Text = "-";
            this.Script_DeleteRouteI2.UseVisualStyleBackColor = true;
            // 
            // Script_DeleteRouteE1
            // 
            this.Script_DeleteRouteE1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteRouteE1.Location = new System.Drawing.Point(285, 142);
            this.Script_DeleteRouteE1.Name = "Script_DeleteRouteE1";
            this.Script_DeleteRouteE1.Size = new System.Drawing.Size(20, 20);
            this.Script_DeleteRouteE1.TabIndex = 241;
            this.Script_DeleteRouteE1.Text = "-";
            this.Script_DeleteRouteE1.UseVisualStyleBackColor = true;
            // 
            // Script_DeleteRouteE2
            // 
            this.Script_DeleteRouteE2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteRouteE2.Location = new System.Drawing.Point(285, 187);
            this.Script_DeleteRouteE2.Name = "Script_DeleteRouteE2";
            this.Script_DeleteRouteE2.Size = new System.Drawing.Size(20, 20);
            this.Script_DeleteRouteE2.TabIndex = 240;
            this.Script_DeleteRouteE2.Text = "-";
            this.Script_DeleteRouteE2.UseVisualStyleBackColor = true;
            // 
            // Script_VarRouteE2
            // 
            this.Script_VarRouteE2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteE2.Location = new System.Drawing.Point(44, 187);
            this.Script_VarRouteE2.Name = "Script_VarRouteE2";
            this.Script_VarRouteE2.Size = new System.Drawing.Size(235, 20);
            this.Script_VarRouteE2.TabIndex = 239;
            this.Script_VarRouteE2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarRouteE1
            // 
            this.Script_VarRouteE1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteE1.Location = new System.Drawing.Point(44, 142);
            this.Script_VarRouteE1.Name = "Script_VarRouteE1";
            this.Script_VarRouteE1.Size = new System.Drawing.Size(235, 20);
            this.Script_VarRouteE1.TabIndex = 231;
            this.Script_VarRouteE1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarRouteE2Label
            // 
            this.Script_VarRouteE2Label.AutoSize = true;
            this.Script_VarRouteE2Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteE2Label.Location = new System.Drawing.Point(32, 167);
            this.Script_VarRouteE2Label.Name = "Script_VarRouteE2Label";
            this.Script_VarRouteE2Label.Size = new System.Drawing.Size(129, 17);
            this.Script_VarRouteE2Label.TabIndex = 238;
            this.Script_VarRouteE2Label.Text = "Route-map export 2:";
            // 
            // Script_VarRouteE1Label
            // 
            this.Script_VarRouteE1Label.AutoSize = true;
            this.Script_VarRouteE1Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteE1Label.Location = new System.Drawing.Point(33, 122);
            this.Script_VarRouteE1Label.Name = "Script_VarRouteE1Label";
            this.Script_VarRouteE1Label.Size = new System.Drawing.Size(129, 17);
            this.Script_VarRouteE1Label.TabIndex = 237;
            this.Script_VarRouteE1Label.Text = "Route-map export 1:";
            // 
            // Script_VarRouteI2Label
            // 
            this.Script_VarRouteI2Label.AutoSize = true;
            this.Script_VarRouteI2Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteI2Label.Location = new System.Drawing.Point(31, 80);
            this.Script_VarRouteI2Label.Name = "Script_VarRouteI2Label";
            this.Script_VarRouteI2Label.Size = new System.Drawing.Size(130, 17);
            this.Script_VarRouteI2Label.TabIndex = 236;
            this.Script_VarRouteI2Label.Text = "Route-map import 2:";
            // 
            // Script_VarRouteI2
            // 
            this.Script_VarRouteI2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteI2.Location = new System.Drawing.Point(44, 97);
            this.Script_VarRouteI2.Name = "Script_VarRouteI2";
            this.Script_VarRouteI2.Size = new System.Drawing.Size(235, 20);
            this.Script_VarRouteI2.TabIndex = 235;
            this.Script_VarRouteI2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarRouteI1Label
            // 
            this.Script_VarRouteI1Label.AutoSize = true;
            this.Script_VarRouteI1Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteI1Label.Location = new System.Drawing.Point(33, 36);
            this.Script_VarRouteI1Label.Name = "Script_VarRouteI1Label";
            this.Script_VarRouteI1Label.Size = new System.Drawing.Size(130, 17);
            this.Script_VarRouteI1Label.TabIndex = 234;
            this.Script_VarRouteI1Label.Text = "Route-map import 1:";
            // 
            // Script_VarRouteI1
            // 
            this.Script_VarRouteI1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteI1.Location = new System.Drawing.Point(44, 56);
            this.Script_VarRouteI1.Name = "Script_VarRouteI1";
            this.Script_VarRouteI1.Size = new System.Drawing.Size(235, 20);
            this.Script_VarRouteI1.TabIndex = 233;
            this.Script_VarRouteI1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_RouteLabelHint
            // 
            this.Script_RouteLabelHint.AutoSize = true;
            this.Script_RouteLabelHint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_RouteLabelHint.Location = new System.Drawing.Point(23, 16);
            this.Script_RouteLabelHint.Name = "Script_RouteLabelHint";
            this.Script_RouteLabelHint.Size = new System.Drawing.Size(294, 17);
            this.Script_RouteLabelHint.TabIndex = 232;
            this.Script_RouteLabelHint.Text = "Valores de Route-map estão no 1 comando de BGP";
            this.Script_RouteLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Script_VarSubTab_Hollow
            // 
            this.Script_VarSubTab_Hollow.Location = new System.Drawing.Point(4, 5);
            this.Script_VarSubTab_Hollow.Name = "Script_VarSubTab_Hollow";
            this.Script_VarSubTab_Hollow.Padding = new System.Windows.Forms.Padding(3);
            this.Script_VarSubTab_Hollow.Size = new System.Drawing.Size(406, 225);
            this.Script_VarSubTab_Hollow.TabIndex = 2;
            this.Script_VarSubTab_Hollow.Text = "Hollow";
            this.Script_VarSubTab_Hollow.UseVisualStyleBackColor = true;
            // 
            // Script_VarText06
            // 
            this.Script_VarText06.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText06.Location = new System.Drawing.Point(150, 252);
            this.Script_VarText06.Name = "Script_VarText06";
            this.Script_VarText06.Size = new System.Drawing.Size(162, 25);
            this.Script_VarText06.TabIndex = 263;
            this.Script_VarText06.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_DeleteVar02
            // 
            this.Script_DeleteVar02.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar02.Location = new System.Drawing.Point(318, 133);
            this.Script_DeleteVar02.Name = "Script_DeleteVar02";
            this.Script_DeleteVar02.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar02.TabIndex = 262;
            this.Script_DeleteVar02.Text = "-";
            this.Script_DeleteVar02.UseVisualStyleBackColor = true;
            this.Script_DeleteVar02.Click += new System.EventHandler(this.Script_DeleteVar2_Click);
            // 
            // Script_DeleteVar09
            // 
            this.Script_DeleteVar09.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar09.Location = new System.Drawing.Point(318, 345);
            this.Script_DeleteVar09.Name = "Script_DeleteVar09";
            this.Script_DeleteVar09.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar09.TabIndex = 261;
            this.Script_DeleteVar09.Text = "-";
            this.Script_DeleteVar09.UseVisualStyleBackColor = true;
            this.Script_DeleteVar09.Click += new System.EventHandler(this.Script_DeleteVar9_Click);
            // 
            // Script_DeleteVar08
            // 
            this.Script_DeleteVar08.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar08.Location = new System.Drawing.Point(318, 314);
            this.Script_DeleteVar08.Name = "Script_DeleteVar08";
            this.Script_DeleteVar08.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar08.TabIndex = 260;
            this.Script_DeleteVar08.Text = "-";
            this.Script_DeleteVar08.UseVisualStyleBackColor = true;
            this.Script_DeleteVar08.Click += new System.EventHandler(this.Script_DeleteVar8_Click);
            // 
            // Script_DeleteVar07
            // 
            this.Script_DeleteVar07.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar07.Location = new System.Drawing.Point(318, 283);
            this.Script_DeleteVar07.Name = "Script_DeleteVar07";
            this.Script_DeleteVar07.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar07.TabIndex = 259;
            this.Script_DeleteVar07.Text = "-";
            this.Script_DeleteVar07.UseVisualStyleBackColor = true;
            this.Script_DeleteVar07.Click += new System.EventHandler(this.Script_DeleteVar7_Click);
            // 
            // Script_DeleteVar10
            // 
            this.Script_DeleteVar10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar10.Location = new System.Drawing.Point(318, 374);
            this.Script_DeleteVar10.Name = "Script_DeleteVar10";
            this.Script_DeleteVar10.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar10.TabIndex = 256;
            this.Script_DeleteVar10.Text = "-";
            this.Script_DeleteVar10.UseVisualStyleBackColor = true;
            this.Script_DeleteVar10.Click += new System.EventHandler(this.Script_DeleteVar10_Click);
            // 
            // Script_DeleteVar11
            // 
            this.Script_DeleteVar11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar11.Location = new System.Drawing.Point(318, 403);
            this.Script_DeleteVar11.Name = "Script_DeleteVar11";
            this.Script_DeleteVar11.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar11.TabIndex = 254;
            this.Script_DeleteVar11.Text = "-";
            this.Script_DeleteVar11.UseVisualStyleBackColor = true;
            this.Script_DeleteVar11.Click += new System.EventHandler(this.Script_DeleteVar11_Click);
            // 
            // Script_VarText09
            // 
            this.Script_VarText09.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText09.Location = new System.Drawing.Point(151, 343);
            this.Script_VarText09.Name = "Script_VarText09";
            this.Script_VarText09.Size = new System.Drawing.Size(102, 25);
            this.Script_VarText09.TabIndex = 252;
            this.Script_VarText09.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_Hint1
            // 
            this.Script_Hint1.AutoSize = true;
            this.Script_Hint1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Hint1.Location = new System.Drawing.Point(74, 566);
            this.Script_Hint1.Name = "Script_Hint1";
            this.Script_Hint1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Script_Hint1.Size = new System.Drawing.Size(282, 54);
            this.Script_Hint1.TabIndex = 251;
            this.Script_Hint1.Text = "Pressionar ENTER dentro de uma Caixa de Texto \n Já aplica formatação";
            this.Script_Hint1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Script_Button_PortImport
            // 
            this.Script_Button_PortImport.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.Script_Button_PortImport.Location = new System.Drawing.Point(381, -1);
            this.Script_Button_PortImport.Name = "Script_Button_PortImport";
            this.Script_Button_PortImport.Size = new System.Drawing.Size(79, 26);
            this.Script_Button_PortImport.TabIndex = 250;
            this.Script_Button_PortImport.Text = "Port Import";
            this.Script_Button_PortImport.UseVisualStyleBackColor = true;
            this.Script_Button_PortImport.Click += new System.EventHandler(this.NotImplemented);
            // 
            // Script_VarText03b
            // 
            this.Script_VarText03b.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText03b.Location = new System.Drawing.Point(151, 163);
            this.Script_VarText03b.Name = "Script_VarText03b";
            this.Script_VarText03b.Size = new System.Drawing.Size(162, 25);
            this.Script_VarText03b.TabIndex = 248;
            this.Script_VarText03b.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_ExLabel
            // 
            this.Script_ExLabel.AutoSize = true;
            this.Script_ExLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_ExLabel.Location = new System.Drawing.Point(349, 44);
            this.Script_ExLabel.Name = "Script_ExLabel";
            this.Script_ExLabel.Size = new System.Drawing.Size(77, 20);
            this.Script_ExLabel.TabIndex = 247;
            this.Script_ExLabel.Text = "Exemplos:";
            // 
            // Script_VarEx13
            // 
            this.Script_VarEx13.AutoSize = true;
            this.Script_VarEx13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx13.Location = new System.Drawing.Point(349, 471);
            this.Script_VarEx13.Name = "Script_VarEx13";
            this.Script_VarEx13.Size = new System.Drawing.Size(38, 15);
            this.Script_VarEx13.TabIndex = 246;
            this.Script_VarEx13.Text = "12001";
            // 
            // Script_VarEx14
            // 
            this.Script_VarEx14.AutoSize = true;
            this.Script_VarEx14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx14.Location = new System.Drawing.Point(349, 499);
            this.Script_VarEx14.Name = "Script_VarEx14";
            this.Script_VarEx14.Size = new System.Drawing.Size(83, 15);
            this.Script_VarEx14.TabIndex = 245;
            this.Script_VarEx14.Text = "NomeVRF:123";
            // 
            // Script_DeleteVar06
            // 
            this.Script_DeleteVar06.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar06.Location = new System.Drawing.Point(318, 252);
            this.Script_DeleteVar06.Name = "Script_DeleteVar06";
            this.Script_DeleteVar06.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar06.TabIndex = 64;
            this.Script_DeleteVar06.Text = "-";
            this.Script_DeleteVar06.UseVisualStyleBackColor = true;
            this.Script_DeleteVar06.Click += new System.EventHandler(this.Script_DeleteVar6_Click);
            // 
            // Script_VarEx15
            // 
            this.Script_VarEx15.AutoSize = true;
            this.Script_VarEx15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx15.Location = new System.Drawing.Point(349, 530);
            this.Script_VarEx15.Name = "Script_VarEx15";
            this.Script_VarEx15.Size = new System.Drawing.Size(52, 15);
            this.Script_VarEx15.TabIndex = 244;
            this.Script_VarEx15.Text = "1003921";
            // 
            // Script_VarEx12
            // 
            this.Script_VarEx12.AutoSize = true;
            this.Script_VarEx12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx12.Location = new System.Drawing.Point(349, 441);
            this.Script_VarEx12.Name = "Script_VarEx12";
            this.Script_VarEx12.Size = new System.Drawing.Size(42, 15);
            this.Script_VarEx12.TabIndex = 243;
            this.Script_VarEx12.Text = "65000";
            // 
            // Script_VarEx11
            // 
            this.Script_VarEx11.AutoSize = true;
            this.Script_VarEx11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx11.Location = new System.Drawing.Point(349, 411);
            this.Script_VarEx11.Name = "Script_VarEx11";
            this.Script_VarEx11.Size = new System.Drawing.Size(64, 15);
            this.Script_VarEx11.TabIndex = 242;
            this.Script_VarEx11.Text = "21.21.21.21";
            // 
            // Script_VarEx10
            // 
            this.Script_VarEx10.AutoSize = true;
            this.Script_VarEx10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx10.Location = new System.Drawing.Point(349, 381);
            this.Script_VarEx10.Name = "Script_VarEx10";
            this.Script_VarEx10.Size = new System.Drawing.Size(80, 15);
            this.Script_VarEx10.TabIndex = 241;
            this.Script_VarEx10.Text = "172.40.165.37";
            // 
            // Script_VarEx09
            // 
            this.Script_VarEx09.AutoSize = true;
            this.Script_VarEx09.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx09.Location = new System.Drawing.Point(349, 351);
            this.Script_VarEx09.Name = "Script_VarEx09";
            this.Script_VarEx09.Size = new System.Drawing.Size(73, 15);
            this.Script_VarEx09.TabIndex = 240;
            this.Script_VarEx09.Text = "182.63.2.131";
            // 
            // Script_LANMascaraBox
            // 
            this.Script_LANMascaraBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_LANMascaraBox.FormattingEnabled = true;
            this.Script_LANMascaraBox.Items.AddRange(new object[] {
            "/30",
            "/29",
            "/28",
            "/27",
            "/26",
            "/25",
            "/24"});
            this.Script_LANMascaraBox.Location = new System.Drawing.Point(259, 343);
            this.Script_LANMascaraBox.Name = "Script_LANMascaraBox";
            this.Script_LANMascaraBox.Size = new System.Drawing.Size(54, 25);
            this.Script_LANMascaraBox.TabIndex = 31;
            this.Script_LANMascaraBox.SelectedIndexChanged += new System.EventHandler(this.Script_LANMascara_SelectedIndexChanged);
            // 
            // Script_VarEx08
            // 
            this.Script_VarEx08.AutoSize = true;
            this.Script_VarEx08.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx08.Location = new System.Drawing.Point(349, 320);
            this.Script_VarEx08.Name = "Script_VarEx08";
            this.Script_VarEx08.Size = new System.Drawing.Size(56, 15);
            this.Script_VarEx08.TabIndex = 239;
            this.Script_VarEx08.Text = "201.2.2.2";
            // 
            // Script_VarEx07
            // 
            this.Script_VarEx07.AutoSize = true;
            this.Script_VarEx07.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx07.Location = new System.Drawing.Point(349, 288);
            this.Script_VarEx07.Name = "Script_VarEx07";
            this.Script_VarEx07.Size = new System.Drawing.Size(54, 15);
            this.Script_VarEx07.TabIndex = 238;
            this.Script_VarEx07.Text = "201.2.2.1";
            // 
            // Script_VarEx06
            // 
            this.Script_VarEx06.AutoSize = true;
            this.Script_VarEx06.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx06.Location = new System.Drawing.Point(349, 260);
            this.Script_VarEx06.Name = "Script_VarEx06";
            this.Script_VarEx06.Size = new System.Drawing.Size(107, 15);
            this.Script_VarEx06.TabIndex = 237;
            this.Script_VarEx06.Text = "GigaEthernet0/1.12";
            // 
            // Script_VarEx05
            // 
            this.Script_VarEx05.AutoSize = true;
            this.Script_VarEx05.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx05.Location = new System.Drawing.Point(349, 230);
            this.Script_VarEx05.Name = "Script_VarEx05";
            this.Script_VarEx05.Size = new System.Drawing.Size(92, 15);
            this.Script_VarEx05.TabIndex = 236;
            this.Script_VarEx05.Text = "GigaEthernet0/1";
            // 
            // Script_VarEx04
            // 
            this.Script_VarEx04.AutoSize = true;
            this.Script_VarEx04.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx04.Location = new System.Drawing.Point(350, 199);
            this.Script_VarEx04.Name = "Script_VarEx04";
            this.Script_VarEx04.Size = new System.Drawing.Size(14, 15);
            this.Script_VarEx04.TabIndex = 235;
            this.Script_VarEx04.Text = "5";
            // 
            // Script_VarEx03
            // 
            this.Script_VarEx03.AutoSize = true;
            this.Script_VarEx03.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx03.Location = new System.Drawing.Point(349, 171);
            this.Script_VarEx03.Name = "Script_VarEx03";
            this.Script_VarEx03.Size = new System.Drawing.Size(94, 15);
            this.Script_VarEx03.TabIndex = 234;
            this.Script_VarEx03.Text = "GigaEthernet0/0";
            // 
            // Script_VarEx02
            // 
            this.Script_VarEx02.AutoSize = true;
            this.Script_VarEx02.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx02.Location = new System.Drawing.Point(349, 140);
            this.Script_VarEx02.Name = "Script_VarEx02";
            this.Script_VarEx02.Size = new System.Drawing.Size(42, 15);
            this.Script_VarEx02.TabIndex = 233;
            this.Script_VarEx02.Text = "50000";
            // 
            // Script_VarEx01
            // 
            this.Script_VarEx01.AutoSize = true;
            this.Script_VarEx01.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx01.Location = new System.Drawing.Point(349, 105);
            this.Script_VarEx01.Name = "Script_VarEx01";
            this.Script_VarEx01.Size = new System.Drawing.Size(105, 15);
            this.Script_VarEx01.TabIndex = 232;
            this.Script_VarEx01.Text = "Description (SAIP)";
            // 
            // Script_VarEx00
            // 
            this.Script_VarEx00.AutoSize = true;
            this.Script_VarEx00.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx00.Location = new System.Drawing.Point(349, 75);
            this.Script_VarEx00.Name = "Script_VarEx00";
            this.Script_VarEx00.Size = new System.Drawing.Size(61, 15);
            this.Script_VarEx00.TabIndex = 231;
            this.Script_VarEx00.Text = "Teste_BLD";
            // 
            // Script_DeleteVar15
            // 
            this.Script_DeleteVar15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar15.Location = new System.Drawing.Point(318, 524);
            this.Script_DeleteVar15.Name = "Script_DeleteVar15";
            this.Script_DeleteVar15.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar15.TabIndex = 230;
            this.Script_DeleteVar15.Text = "-";
            this.Script_DeleteVar15.UseVisualStyleBackColor = true;
            this.Script_DeleteVar15.Click += new System.EventHandler(this.Script_DeleteVar15_Click);
            // 
            // Script_VarText15
            // 
            this.Script_VarText15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText15.Location = new System.Drawing.Point(151, 524);
            this.Script_VarText15.Name = "Script_VarText15";
            this.Script_VarText15.Size = new System.Drawing.Size(161, 25);
            this.Script_VarText15.TabIndex = 229;
            this.Script_VarText15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName15
            // 
            this.Script_VarName15.AutoSize = true;
            this.Script_VarName15.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName15.Location = new System.Drawing.Point(17, 528);
            this.Script_VarName15.Name = "Script_VarName15";
            this.Script_VarName15.Size = new System.Drawing.Size(68, 17);
            this.Script_VarName15.TabIndex = 228;
            this.Script_VarName15.Text = "Service ID:";
            // 
            // Script_DeleteVar14
            // 
            this.Script_DeleteVar14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar14.Location = new System.Drawing.Point(318, 493);
            this.Script_DeleteVar14.Name = "Script_DeleteVar14";
            this.Script_DeleteVar14.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar14.TabIndex = 227;
            this.Script_DeleteVar14.Text = "-";
            this.Script_DeleteVar14.UseVisualStyleBackColor = true;
            this.Script_DeleteVar14.Click += new System.EventHandler(this.Script_DeleteVar14_Click);
            // 
            // Script_VarText14
            // 
            this.Script_VarText14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText14.Location = new System.Drawing.Point(151, 493);
            this.Script_VarText14.Name = "Script_VarText14";
            this.Script_VarText14.Size = new System.Drawing.Size(161, 25);
            this.Script_VarText14.TabIndex = 226;
            this.Script_VarText14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName14
            // 
            this.Script_VarName14.AutoSize = true;
            this.Script_VarName14.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName14.Location = new System.Drawing.Point(17, 498);
            this.Script_VarName14.Name = "Script_VarName14";
            this.Script_VarName14.Size = new System.Drawing.Size(92, 17);
            this.Script_VarName14.TabIndex = 225;
            this.Script_VarName14.Text = "Nome da VRF:";
            // 
            // Script_DeleteVar13
            // 
            this.Script_DeleteVar13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar13.Location = new System.Drawing.Point(318, 463);
            this.Script_DeleteVar13.Name = "Script_DeleteVar13";
            this.Script_DeleteVar13.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar13.TabIndex = 224;
            this.Script_DeleteVar13.Text = "-";
            this.Script_DeleteVar13.UseVisualStyleBackColor = true;
            this.Script_DeleteVar13.Click += new System.EventHandler(this.Script_DeleteVar13_Click);
            // 
            // Script_VarText13
            // 
            this.Script_VarText13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText13.Location = new System.Drawing.Point(151, 463);
            this.Script_VarText13.Name = "Script_VarText13";
            this.Script_VarText13.Size = new System.Drawing.Size(161, 25);
            this.Script_VarText13.TabIndex = 223;
            this.Script_VarText13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName13
            // 
            this.Script_VarName13.AutoSize = true;
            this.Script_VarName13.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName13.Location = new System.Drawing.Point(17, 468);
            this.Script_VarName13.Name = "Script_VarName13";
            this.Script_VarName13.Size = new System.Drawing.Size(52, 17);
            this.Script_VarName13.TabIndex = 222;
            this.Script_VarName13.Text = "QoS ID:";
            // 
            // Script_DeleteVar12
            // 
            this.Script_DeleteVar12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar12.Location = new System.Drawing.Point(318, 434);
            this.Script_DeleteVar12.Name = "Script_DeleteVar12";
            this.Script_DeleteVar12.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar12.TabIndex = 221;
            this.Script_DeleteVar12.Text = "-";
            this.Script_DeleteVar12.UseVisualStyleBackColor = true;
            this.Script_DeleteVar12.Click += new System.EventHandler(this.Script_DeleteVar12_Click);
            // 
            // Script_VarText12
            // 
            this.Script_VarText12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText12.Location = new System.Drawing.Point(151, 433);
            this.Script_VarText12.Name = "Script_VarText12";
            this.Script_VarText12.Size = new System.Drawing.Size(161, 25);
            this.Script_VarText12.TabIndex = 220;
            this.Script_VarText12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName12
            // 
            this.Script_VarName12.AutoSize = true;
            this.Script_VarName12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName12.Location = new System.Drawing.Point(17, 438);
            this.Script_VarName12.Name = "Script_VarName12";
            this.Script_VarName12.Size = new System.Drawing.Size(73, 17);
            this.Script_VarName12.TabIndex = 219;
            this.Script_VarName12.Text = "AS do BGP:";
            // 
            // Script_DeleteVar05
            // 
            this.Script_DeleteVar05.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar05.Location = new System.Drawing.Point(318, 224);
            this.Script_DeleteVar05.Name = "Script_DeleteVar05";
            this.Script_DeleteVar05.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar05.TabIndex = 201;
            this.Script_DeleteVar05.Text = "-";
            this.Script_DeleteVar05.UseVisualStyleBackColor = true;
            this.Script_DeleteVar05.Click += new System.EventHandler(this.Script_DeleteVar5_Click);
            // 
            // Script_DeleteVar04
            // 
            this.Script_DeleteVar04.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar04.Location = new System.Drawing.Point(318, 193);
            this.Script_DeleteVar04.Name = "Script_DeleteVar04";
            this.Script_DeleteVar04.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar04.TabIndex = 200;
            this.Script_DeleteVar04.Text = "-";
            this.Script_DeleteVar04.UseVisualStyleBackColor = true;
            this.Script_DeleteVar04.Click += new System.EventHandler(this.Script_DeleteVar4_Click);
            // 
            // Script_DeleteVar01
            // 
            this.Script_DeleteVar01.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar01.Location = new System.Drawing.Point(318, 103);
            this.Script_DeleteVar01.Name = "Script_DeleteVar01";
            this.Script_DeleteVar01.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar01.TabIndex = 198;
            this.Script_DeleteVar01.Text = "-";
            this.Script_DeleteVar01.UseVisualStyleBackColor = true;
            this.Script_DeleteVar01.Click += new System.EventHandler(this.Script_DeleteVar1_Click);
            // 
            // Script_DeleteVar00
            // 
            this.Script_DeleteVar00.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar00.Location = new System.Drawing.Point(318, 73);
            this.Script_DeleteVar00.Name = "Script_DeleteVar00";
            this.Script_DeleteVar00.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar00.TabIndex = 197;
            this.Script_DeleteVar00.Text = "-";
            this.Script_DeleteVar00.UseVisualStyleBackColor = true;
            this.Script_DeleteVar00.Click += new System.EventHandler(this.Script_DeleteVar0_Click);
            // 
            // Script_ModelLabel
            // 
            this.Script_ModelLabel.AutoSize = true;
            this.Script_ModelLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_ModelLabel.Location = new System.Drawing.Point(155, 23);
            this.Script_ModelLabel.Name = "Script_ModelLabel";
            this.Script_ModelLabel.Size = new System.Drawing.Size(54, 17);
            this.Script_ModelLabel.TabIndex = 196;
            this.Script_ModelLabel.Text = "Modelo";
            // 
            // Script_RouterModelBox
            // 
            this.Script_RouterModelBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_RouterModelBox.FormattingEnabled = true;
            this.Script_RouterModelBox.Items.AddRange(new object[] {
            "40F",
            "60F",
            "100F",
            "c841",
            "c921",
            "Cisco ISR",
            "Cisco Catalyst",
            "1905",
            "1841",
            "HPE",
            "Huawei",
            "AG 561",
            "AG 1600",
            "AG 2000",
            "AG 30",
            "AG 30 Plus"});
            this.Script_RouterModelBox.Location = new System.Drawing.Point(151, 43);
            this.Script_RouterModelBox.Name = "Script_RouterModelBox";
            this.Script_RouterModelBox.Size = new System.Drawing.Size(104, 25);
            this.Script_RouterModelBox.TabIndex = 195;
            this.Script_RouterModelBox.SelectedIndexChanged += new System.EventHandler(this.Script_RouterModelBox_SelectedIndexChanged);
            // 
            // Script_VarText11
            // 
            this.Script_VarText11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText11.Location = new System.Drawing.Point(151, 403);
            this.Script_VarText11.Name = "Script_VarText11";
            this.Script_VarText11.Size = new System.Drawing.Size(161, 25);
            this.Script_VarText11.TabIndex = 194;
            this.Script_VarText11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName11
            // 
            this.Script_VarName11.AutoSize = true;
            this.Script_VarName11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName11.Location = new System.Drawing.Point(17, 408);
            this.Script_VarName11.Name = "Script_VarName11";
            this.Script_VarName11.Size = new System.Drawing.Size(111, 17);
            this.Script_VarName11.TabIndex = 193;
            this.Script_VarName11.Text = "Loopback Cliente:";
            // 
            // Script_VarText10
            // 
            this.Script_VarText10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText10.Location = new System.Drawing.Point(151, 373);
            this.Script_VarText10.Name = "Script_VarText10";
            this.Script_VarText10.Size = new System.Drawing.Size(161, 25);
            this.Script_VarText10.TabIndex = 192;
            this.Script_VarText10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName10
            // 
            this.Script_VarName10.AutoSize = true;
            this.Script_VarName10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName10.Location = new System.Drawing.Point(17, 378);
            this.Script_VarName10.Name = "Script_VarName10";
            this.Script_VarName10.Size = new System.Drawing.Size(106, 17);
            this.Script_VarName10.TabIndex = 191;
            this.Script_VarName10.Text = "Loopback do PE:";
            // 
            // Script_VarName09
            // 
            this.Script_VarName09.AutoSize = true;
            this.Script_VarName09.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName09.Location = new System.Drawing.Point(17, 347);
            this.Script_VarName09.Name = "Script_VarName09";
            this.Script_VarName09.Size = new System.Drawing.Size(68, 17);
            this.Script_VarName09.TabIndex = 189;
            this.Script_VarName09.Text = "IP de LAN:";
            // 
            // Script_VarText08
            // 
            this.Script_VarText08.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText08.Location = new System.Drawing.Point(151, 312);
            this.Script_VarText08.Name = "Script_VarText08";
            this.Script_VarText08.Size = new System.Drawing.Size(162, 25);
            this.Script_VarText08.TabIndex = 188;
            this.Script_VarText08.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName08
            // 
            this.Script_VarName08.AutoSize = true;
            this.Script_VarName08.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName08.Location = new System.Drawing.Point(17, 317);
            this.Script_VarName08.Name = "Script_VarName08";
            this.Script_VarName08.Size = new System.Drawing.Size(67, 17);
            this.Script_VarName08.TabIndex = 187;
            this.Script_VarName08.Text = "IP do CPE:";
            // 
            // Script_VarText07
            // 
            this.Script_VarText07.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText07.Location = new System.Drawing.Point(151, 282);
            this.Script_VarText07.Name = "Script_VarText07";
            this.Script_VarText07.Size = new System.Drawing.Size(162, 25);
            this.Script_VarText07.TabIndex = 186;
            this.Script_VarText07.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName07
            // 
            this.Script_VarName07.AutoSize = true;
            this.Script_VarName07.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName07.Location = new System.Drawing.Point(17, 287);
            this.Script_VarName07.Name = "Script_VarName07";
            this.Script_VarName07.Size = new System.Drawing.Size(59, 17);
            this.Script_VarName07.TabIndex = 185;
            this.Script_VarName07.Text = "IP do PE:";
            // 
            // Script_VarName06
            // 
            this.Script_VarName06.AutoSize = true;
            this.Script_VarName06.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName06.Location = new System.Drawing.Point(17, 257);
            this.Script_VarName06.Name = "Script_VarName06";
            this.Script_VarName06.Size = new System.Drawing.Size(131, 17);
            this.Script_VarName06.TabIndex = 184;
            this.Script_VarName06.Text = "Interface Logica LAN:";
            // 
            // Script_Button_Clear
            // 
            this.Script_Button_Clear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Button_Clear.Location = new System.Drawing.Point(259, 39);
            this.Script_Button_Clear.Name = "Script_Button_Clear";
            this.Script_Button_Clear.Size = new System.Drawing.Size(79, 30);
            this.Script_Button_Clear.TabIndex = 183;
            this.Script_Button_Clear.Text = "Limpar";
            this.Script_Button_Clear.UseVisualStyleBackColor = true;
            this.Script_Button_Clear.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Script_VarTitle
            // 
            this.Script_VarTitle.AutoSize = true;
            this.Script_VarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarTitle.Location = new System.Drawing.Point(27, 33);
            this.Script_VarTitle.Name = "Script_VarTitle";
            this.Script_VarTitle.Size = new System.Drawing.Size(88, 25);
            this.Script_VarTitle.TabIndex = 182;
            this.Script_VarTitle.Text = "Variáveis";
            // 
            // Script_VarText05
            // 
            this.Script_VarText05.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText05.Location = new System.Drawing.Point(151, 222);
            this.Script_VarText05.Name = "Script_VarText05";
            this.Script_VarText05.Size = new System.Drawing.Size(162, 25);
            this.Script_VarText05.TabIndex = 181;
            this.Script_VarText05.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarText04
            // 
            this.Script_VarText04.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText04.Location = new System.Drawing.Point(151, 192);
            this.Script_VarText04.Name = "Script_VarText04";
            this.Script_VarText04.Size = new System.Drawing.Size(161, 25);
            this.Script_VarText04.TabIndex = 180;
            this.Script_VarText04.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarText03
            // 
            this.Script_VarText03.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText03.Location = new System.Drawing.Point(151, 162);
            this.Script_VarText03.Name = "Script_VarText03";
            this.Script_VarText03.Size = new System.Drawing.Size(161, 25);
            this.Script_VarText03.TabIndex = 179;
            this.Script_VarText03.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarText02
            // 
            this.Script_VarText02.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText02.Location = new System.Drawing.Point(151, 132);
            this.Script_VarText02.Name = "Script_VarText02";
            this.Script_VarText02.Size = new System.Drawing.Size(161, 25);
            this.Script_VarText02.TabIndex = 178;
            this.Script_VarText02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarText01
            // 
            this.Script_VarText01.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText01.Location = new System.Drawing.Point(151, 102);
            this.Script_VarText01.Name = "Script_VarText01";
            this.Script_VarText01.Size = new System.Drawing.Size(161, 22);
            this.Script_VarText01.TabIndex = 177;
            this.Script_VarText01.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_VarName05
            // 
            this.Script_VarName05.AutoSize = true;
            this.Script_VarName05.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName05.Location = new System.Drawing.Point(17, 227);
            this.Script_VarName05.Name = "Script_VarName05";
            this.Script_VarName05.Size = new System.Drawing.Size(89, 17);
            this.Script_VarName05.TabIndex = 176;
            this.Script_VarName05.Text = "Interface LAN:";
            // 
            // Script_VarName03
            // 
            this.Script_VarName03.AutoSize = true;
            this.Script_VarName03.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName03.Location = new System.Drawing.Point(17, 167);
            this.Script_VarName03.Name = "Script_VarName03";
            this.Script_VarName03.Size = new System.Drawing.Size(94, 17);
            this.Script_VarName03.TabIndex = 175;
            this.Script_VarName03.Text = "Interface WAN:";
            // 
            // Script_VarName04
            // 
            this.Script_VarName04.AutoSize = true;
            this.Script_VarName04.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName04.Location = new System.Drawing.Point(17, 197);
            this.Script_VarName04.Name = "Script_VarName04";
            this.Script_VarName04.Size = new System.Drawing.Size(82, 17);
            this.Script_VarName04.TabIndex = 174;
            this.Script_VarName04.Text = "Nº da VLAN:";
            // 
            // Script_VarName02
            // 
            this.Script_VarName02.AutoSize = true;
            this.Script_VarName02.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName02.Location = new System.Drawing.Point(17, 137);
            this.Script_VarName02.Name = "Script_VarName02";
            this.Script_VarName02.Size = new System.Drawing.Size(71, 17);
            this.Script_VarName02.TabIndex = 173;
            this.Script_VarName02.Text = "Bandwidth:";
            // 
            // Script_VarName01
            // 
            this.Script_VarName01.AutoSize = true;
            this.Script_VarName01.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName01.Location = new System.Drawing.Point(17, 105);
            this.Script_VarName01.Name = "Script_VarName01";
            this.Script_VarName01.Size = new System.Drawing.Size(77, 17);
            this.Script_VarName01.TabIndex = 172;
            this.Script_VarName01.Text = "Description:";
            // 
            // Script_VarName00
            // 
            this.Script_VarName00.AutoSize = true;
            this.Script_VarName00.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarName00.Location = new System.Drawing.Point(17, 75);
            this.Script_VarName00.Name = "Script_VarName00";
            this.Script_VarName00.Size = new System.Drawing.Size(70, 17);
            this.Script_VarName00.TabIndex = 171;
            this.Script_VarName00.Text = "Hostname:";
            // 
            // Script_VarText00
            // 
            this.Script_VarText00.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarText00.Location = new System.Drawing.Point(151, 72);
            this.Script_VarText00.Name = "Script_VarText00";
            this.Script_VarText00.Size = new System.Drawing.Size(161, 25);
            this.Script_VarText00.TabIndex = 170;
            this.Script_VarText00.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Script_VarText_KeyDown);
            // 
            // Script_XRLabel
            // 
            this.Script_XRLabel.AutoSize = true;
            this.Script_XRLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_XRLabel.Location = new System.Drawing.Point(148, 23);
            this.Script_XRLabel.Name = "Script_XRLabel";
            this.Script_XRLabel.Size = new System.Drawing.Size(71, 17);
            this.Script_XRLabel.TabIndex = 207;
            this.Script_XRLabel.Text = "Tipo de PE";
            // 
            // Script_XRBox
            // 
            this.Script_XRBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_XRBox.FormattingEnabled = true;
            this.Script_XRBox.Items.AddRange(new object[] {
            "IACC / GACC",
            "AGG / ACR / UACC"});
            this.Script_XRBox.Location = new System.Drawing.Point(139, 44);
            this.Script_XRBox.Name = "Script_XRBox";
            this.Script_XRBox.Size = new System.Drawing.Size(116, 23);
            this.Script_XRBox.TabIndex = 206;
            this.Script_XRBox.SelectedIndexChanged += new System.EventHandler(this.Script_LogBox_SelectedIndexChanged);
            // 
            // Script_DeleteVar03
            // 
            this.Script_DeleteVar03.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar03.Location = new System.Drawing.Point(319, 163);
            this.Script_DeleteVar03.Name = "Script_DeleteVar03";
            this.Script_DeleteVar03.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar03.TabIndex = 199;
            this.Script_DeleteVar03.Text = "-";
            this.Script_DeleteVar03.UseVisualStyleBackColor = true;
            this.Script_DeleteVar03.Click += new System.EventHandler(this.Script_DeleteVar3_Click);
            // 
            // Script_DeleteVar03b
            // 
            this.Script_DeleteVar03b.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar03b.Location = new System.Drawing.Point(318, 163);
            this.Script_DeleteVar03b.Name = "Script_DeleteVar03b";
            this.Script_DeleteVar03b.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar03b.TabIndex = 249;
            this.Script_DeleteVar03b.Text = "-";
            this.Script_DeleteVar03b.UseVisualStyleBackColor = true;
            this.Script_DeleteVar03b.Click += new System.EventHandler(this.Script_DeleteVar03b_Click);
            // 
            // Script_Button_Telnet
            // 
            this.Script_Button_Telnet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_Button_Telnet.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.Script_Button_Telnet.Location = new System.Drawing.Point(917, 314);
            this.Script_Button_Telnet.Name = "Script_Button_Telnet";
            this.Script_Button_Telnet.Size = new System.Drawing.Size(104, 43);
            this.Script_Button_Telnet.TabIndex = 153;
            this.Script_Button_Telnet.Text = "Telnet";
            this.Script_Button_Telnet.UseVisualStyleBackColor = true;
            this.Script_Button_Telnet.Click += new System.EventHandler(this.Script_TelnetButton_Click);
            // 
            // Script_Button_TelnetPlus
            // 
            this.Script_Button_TelnetPlus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Script_Button_TelnetPlus.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.Script_Button_TelnetPlus.Location = new System.Drawing.Point(916, 314);
            this.Script_Button_TelnetPlus.Name = "Script_Button_TelnetPlus";
            this.Script_Button_TelnetPlus.Size = new System.Drawing.Size(104, 43);
            this.Script_Button_TelnetPlus.TabIndex = 166;
            this.Script_Button_TelnetPlus.Text = "Telnet+";
            this.Script_Button_TelnetPlus.UseVisualStyleBackColor = true;
            this.Script_Button_TelnetPlus.Click += new System.EventHandler(this.Script_TelnetButtonPlus_Click);
            // 
            // tabSelectRouter
            // 
            this.tabSelectRouter.Controls.Add(this.Config_Button_WizGat);
            this.tabSelectRouter.Controls.Add(this.Config_Button_Broadsoft);
            this.tabSelectRouter.Controls.Add(this.Config_Button_Logs);
            this.tabSelectRouter.Controls.Add(this.Config_SubTitleType);
            this.tabSelectRouter.Controls.Add(this.Config_Button_VOZ);
            this.tabSelectRouter.Controls.Add(this.Config_Button_MPLS);
            this.tabSelectRouter.Controls.Add(this.Config_Button_BLD);
            this.tabSelectRouter.Controls.Add(this.Config_SubTitle);
            this.tabSelectRouter.Controls.Add(this.Config_Button_HPE_old);
            this.tabSelectRouter.Controls.Add(this.Config_Title);
            this.tabSelectRouter.Controls.Add(this.HomeButton_SelectRouter);
            this.tabSelectRouter.Controls.Add(this.Config_Button_HPE);
            this.tabSelectRouter.Controls.Add(this.Config_Button_Huawei);
            this.tabSelectRouter.Controls.Add(this.Config_Button_Fortigate);
            this.tabSelectRouter.Controls.Add(this.Config_Button_Cisco);
            this.tabSelectRouter.Controls.Add(this.Config_Button_Aligera);
            this.tabSelectRouter.Controls.Add(this.Config_Button_Digistar);
            this.tabSelectRouter.Location = new System.Drawing.Point(4, 5);
            this.tabSelectRouter.Name = "tabSelectRouter";
            this.tabSelectRouter.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectRouter.Size = new System.Drawing.Size(1112, 513);
            this.tabSelectRouter.TabIndex = 2;
            this.tabSelectRouter.Text = "tabPage4";
            this.tabSelectRouter.UseVisualStyleBackColor = true;
            // 
            // Config_Button_WizGat
            // 
            this.Config_Button_WizGat.AutoSize = true;
            this.Config_Button_WizGat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_WizGat.Location = new System.Drawing.Point(142, 16);
            this.Config_Button_WizGat.Name = "Config_Button_WizGat";
            this.Config_Button_WizGat.Size = new System.Drawing.Size(120, 48);
            this.Config_Button_WizGat.TabIndex = 19;
            this.Config_Button_WizGat.Text = "WizGat";
            this.Config_Button_WizGat.UseVisualStyleBackColor = true;
            this.Config_Button_WizGat.Click += new System.EventHandler(this.WizGat_Open);
            // 
            // Config_Button_Broadsoft
            // 
            this.Config_Button_Broadsoft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Config_Button_Broadsoft.AutoSize = true;
            this.Config_Button_Broadsoft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_Broadsoft.Location = new System.Drawing.Point(457, 357);
            this.Config_Button_Broadsoft.MaximumSize = new System.Drawing.Size(252, 90);
            this.Config_Button_Broadsoft.MinimumSize = new System.Drawing.Size(171, 60);
            this.Config_Button_Broadsoft.Name = "Config_Button_Broadsoft";
            this.Config_Button_Broadsoft.Size = new System.Drawing.Size(171, 60);
            this.Config_Button_Broadsoft.TabIndex = 18;
            this.Config_Button_Broadsoft.Text = "Broadsoft";
            this.Config_Button_Broadsoft.UseVisualStyleBackColor = true;
            this.Config_Button_Broadsoft.Click += new System.EventHandler(this.NotImplemented);
            // 
            // Config_Button_Logs
            // 
            this.Config_Button_Logs.AutoSize = true;
            this.Config_Button_Logs.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_Logs.Location = new System.Drawing.Point(16, 16);
            this.Config_Button_Logs.Name = "Config_Button_Logs";
            this.Config_Button_Logs.Size = new System.Drawing.Size(120, 48);
            this.Config_Button_Logs.TabIndex = 15;
            this.Config_Button_Logs.Text = "Logs";
            this.Config_Button_Logs.UseVisualStyleBackColor = true;
            this.Config_Button_Logs.Click += new System.EventHandler(this.SelectRouter_LogButton_Click);
            // 
            // Config_SubTitleType
            // 
            this.Config_SubTitleType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Config_SubTitleType.AutoSize = true;
            this.Config_SubTitleType.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_SubTitleType.Location = new System.Drawing.Point(1008, 114);
            this.Config_SubTitleType.Name = "Config_SubTitleType";
            this.Config_SubTitleType.Size = new System.Drawing.Size(49, 25);
            this.Config_SubTitleType.TabIndex = 14;
            this.Config_SubTitleType.Text = "Tipo";
            // 
            // Config_Button_VOZ
            // 
            this.Config_Button_VOZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Config_Button_VOZ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_VOZ.Location = new System.Drawing.Point(973, 307);
            this.Config_Button_VOZ.Name = "Config_Button_VOZ";
            this.Config_Button_VOZ.Size = new System.Drawing.Size(117, 60);
            this.Config_Button_VOZ.TabIndex = 13;
            this.Config_Button_VOZ.Text = "VOZ";
            this.Config_Button_VOZ.UseVisualStyleBackColor = true;
            this.Config_Button_VOZ.Click += new System.EventHandler(this.VOZ_Button_Click);
            // 
            // Config_Button_MPLS
            // 
            this.Config_Button_MPLS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Config_Button_MPLS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_MPLS.Location = new System.Drawing.Point(973, 229);
            this.Config_Button_MPLS.Name = "Config_Button_MPLS";
            this.Config_Button_MPLS.Size = new System.Drawing.Size(117, 60);
            this.Config_Button_MPLS.TabIndex = 12;
            this.Config_Button_MPLS.Text = "MPLS";
            this.Config_Button_MPLS.UseVisualStyleBackColor = true;
            this.Config_Button_MPLS.Click += new System.EventHandler(this.MPLS_button_Click);
            // 
            // Config_Button_BLD
            // 
            this.Config_Button_BLD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Config_Button_BLD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_BLD.Location = new System.Drawing.Point(973, 151);
            this.Config_Button_BLD.Name = "Config_Button_BLD";
            this.Config_Button_BLD.Size = new System.Drawing.Size(117, 60);
            this.Config_Button_BLD.TabIndex = 11;
            this.Config_Button_BLD.Text = "BLD";
            this.Config_Button_BLD.UseVisualStyleBackColor = true;
            this.Config_Button_BLD.Click += new System.EventHandler(this.BLD_button_Click);
            // 
            // Config_SubTitle
            // 
            this.Config_SubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Config_SubTitle.AutoSize = true;
            this.Config_SubTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_SubTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Config_SubTitle.Location = new System.Drawing.Point(504, 76);
            this.Config_SubTitle.Name = "Config_SubTitle";
            this.Config_SubTitle.Size = new System.Drawing.Size(68, 32);
            this.Config_SubTitle.TabIndex = 10;
            this.Config_SubTitle.Text = "Type";
            this.Config_SubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Config_Button_HPE_old
            // 
            this.Config_Button_HPE_old.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Config_Button_HPE_old.AutoSize = true;
            this.Config_Button_HPE_old.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_HPE_old.Location = new System.Drawing.Point(666, 162);
            this.Config_Button_HPE_old.MaximumSize = new System.Drawing.Size(252, 90);
            this.Config_Button_HPE_old.MinimumSize = new System.Drawing.Size(171, 60);
            this.Config_Button_HPE_old.Name = "Config_Button_HPE_old";
            this.Config_Button_HPE_old.Size = new System.Drawing.Size(171, 60);
            this.Config_Button_HPE_old.TabIndex = 7;
            this.Config_Button_HPE_old.Text = "HPE - Antigo";
            this.Config_Button_HPE_old.UseVisualStyleBackColor = true;
            this.Config_Button_HPE_old.Click += new System.EventHandler(this.Config_HPE_old_Click);
            // 
            // Config_Title
            // 
            this.Config_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Config_Title.AutoSize = true;
            this.Config_Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Config_Title.Location = new System.Drawing.Point(404, 19);
            this.Config_Title.Name = "Config_Title";
            this.Config_Title.Size = new System.Drawing.Size(287, 45);
            this.Config_Title.TabIndex = 6;
            this.Config_Title.Text = "Configuração CPE";
            this.Config_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeButton_SelectRouter
            // 
            this.HomeButton_SelectRouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton_SelectRouter.BackColor = System.Drawing.Color.DodgerBlue;
            this.HomeButton_SelectRouter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton_SelectRouter.ForeColor = System.Drawing.Color.White;
            this.HomeButton_SelectRouter.Location = new System.Drawing.Point(973, 23);
            this.HomeButton_SelectRouter.Name = "HomeButton_SelectRouter";
            this.HomeButton_SelectRouter.Size = new System.Drawing.Size(120, 48);
            this.HomeButton_SelectRouter.TabIndex = 5;
            this.HomeButton_SelectRouter.Text = "Home";
            this.HomeButton_SelectRouter.UseVisualStyleBackColor = false;
            this.HomeButton_SelectRouter.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // Config_Button_HPE
            // 
            this.Config_Button_HPE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Config_Button_HPE.AutoSize = true;
            this.Config_Button_HPE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_HPE.Location = new System.Drawing.Point(457, 162);
            this.Config_Button_HPE.MaximumSize = new System.Drawing.Size(252, 90);
            this.Config_Button_HPE.MinimumSize = new System.Drawing.Size(171, 60);
            this.Config_Button_HPE.Name = "Config_Button_HPE";
            this.Config_Button_HPE.Size = new System.Drawing.Size(171, 60);
            this.Config_Button_HPE.TabIndex = 2;
            this.Config_Button_HPE.Text = "HPE";
            this.Config_Button_HPE.UseVisualStyleBackColor = true;
            this.Config_Button_HPE.Click += new System.EventHandler(this.HPE_Button_Click);
            // 
            // Config_Button_Huawei
            // 
            this.Config_Button_Huawei.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Config_Button_Huawei.AutoSize = true;
            this.Config_Button_Huawei.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_Huawei.Location = new System.Drawing.Point(352, 264);
            this.Config_Button_Huawei.MaximumSize = new System.Drawing.Size(252, 90);
            this.Config_Button_Huawei.MinimumSize = new System.Drawing.Size(171, 60);
            this.Config_Button_Huawei.Name = "Config_Button_Huawei";
            this.Config_Button_Huawei.Size = new System.Drawing.Size(171, 60);
            this.Config_Button_Huawei.TabIndex = 8;
            this.Config_Button_Huawei.Text = "Huawei";
            this.Config_Button_Huawei.UseVisualStyleBackColor = true;
            this.Config_Button_Huawei.Click += new System.EventHandler(this.Config_Huawei_Click);
            // 
            // Config_Button_Fortigate
            // 
            this.Config_Button_Fortigate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Config_Button_Fortigate.AutoSize = true;
            this.Config_Button_Fortigate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_Fortigate.Location = new System.Drawing.Point(574, 264);
            this.Config_Button_Fortigate.MaximumSize = new System.Drawing.Size(252, 90);
            this.Config_Button_Fortigate.MinimumSize = new System.Drawing.Size(171, 60);
            this.Config_Button_Fortigate.Name = "Config_Button_Fortigate";
            this.Config_Button_Fortigate.Size = new System.Drawing.Size(171, 60);
            this.Config_Button_Fortigate.TabIndex = 9;
            this.Config_Button_Fortigate.Text = "Fortigate";
            this.Config_Button_Fortigate.UseVisualStyleBackColor = true;
            this.Config_Button_Fortigate.Click += new System.EventHandler(this.Config_Fortigate_Click);
            // 
            // Config_Button_Cisco
            // 
            this.Config_Button_Cisco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Config_Button_Cisco.AutoSize = true;
            this.Config_Button_Cisco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_Cisco.Location = new System.Drawing.Point(251, 162);
            this.Config_Button_Cisco.MaximumSize = new System.Drawing.Size(252, 90);
            this.Config_Button_Cisco.MinimumSize = new System.Drawing.Size(171, 60);
            this.Config_Button_Cisco.Name = "Config_Button_Cisco";
            this.Config_Button_Cisco.Size = new System.Drawing.Size(171, 60);
            this.Config_Button_Cisco.TabIndex = 1;
            this.Config_Button_Cisco.Text = "Cisco";
            this.Config_Button_Cisco.UseVisualStyleBackColor = true;
            this.Config_Button_Cisco.Click += new System.EventHandler(this.Cisco_Button_Click);
            // 
            // Config_Button_Aligera
            // 
            this.Config_Button_Aligera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Config_Button_Aligera.AutoSize = true;
            this.Config_Button_Aligera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_Aligera.Location = new System.Drawing.Point(352, 264);
            this.Config_Button_Aligera.Name = "Config_Button_Aligera";
            this.Config_Button_Aligera.Size = new System.Drawing.Size(171, 60);
            this.Config_Button_Aligera.TabIndex = 16;
            this.Config_Button_Aligera.Text = "Aligera";
            this.Config_Button_Aligera.UseVisualStyleBackColor = true;
            this.Config_Button_Aligera.Click += new System.EventHandler(this.Config_Aligera_Click);
            // 
            // Config_Button_Digistar
            // 
            this.Config_Button_Digistar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Config_Button_Digistar.AutoSize = true;
            this.Config_Button_Digistar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Button_Digistar.Location = new System.Drawing.Point(574, 264);
            this.Config_Button_Digistar.Name = "Config_Button_Digistar";
            this.Config_Button_Digistar.Size = new System.Drawing.Size(171, 60);
            this.Config_Button_Digistar.TabIndex = 17;
            this.Config_Button_Digistar.Text = "Digistar";
            this.Config_Button_Digistar.UseVisualStyleBackColor = true;
            this.Config_Button_Digistar.Click += new System.EventHandler(this.Config_Digistar_Click);
            // 
            // ClientStepsPage
            // 
            this.ClientStepsPage.Location = new System.Drawing.Point(4, 5);
            this.ClientStepsPage.Name = "ClientStepsPage";
            this.ClientStepsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientStepsPage.Size = new System.Drawing.Size(1112, 513);
            this.ClientStepsPage.TabIndex = 3;
            this.ClientStepsPage.Text = "ClientStepsPage";
            this.ClientStepsPage.UseVisualStyleBackColor = true;
            // 
            // tabWizGat
            // 
            this.tabWizGat.Controls.Add(this.WizGat_Button_Config);
            this.tabWizGat.Controls.Add(this.WizGat_Row);
            this.tabWizGat.Controls.Add(this.WizGat_Button_Log);
            this.tabWizGat.Controls.Add(this.BackButton_WizGat);
            this.tabWizGat.Controls.Add(this.WizGat_Button_CiscoBLDcBGP);
            this.tabWizGat.Controls.Add(this.WizGat_Button_CiscoVoz);
            this.tabWizGat.Controls.Add(this.WizGat_Button_CiscoMPLS);
            this.tabWizGat.Controls.Add(this.WizGat_Button_CiscoBLD);
            this.tabWizGat.Controls.Add(this.WizGat_CiscoTitle);
            this.tabWizGat.Controls.Add(this.WizGat_NokiaTitle);
            this.tabWizGat.Controls.Add(this.WizGat_Button_NokiaBLDcBGP);
            this.tabWizGat.Controls.Add(this.WizGat_Button_NokiaVoz);
            this.tabWizGat.Controls.Add(this.WizGat_Button_NokiaMPLS);
            this.tabWizGat.Controls.Add(this.WizGat_Button_NokiaBLD);
            this.tabWizGat.Location = new System.Drawing.Point(4, 5);
            this.tabWizGat.Name = "tabWizGat";
            this.tabWizGat.Padding = new System.Windows.Forms.Padding(3);
            this.tabWizGat.Size = new System.Drawing.Size(1112, 513);
            this.tabWizGat.TabIndex = 4;
            this.tabWizGat.Text = "WizGat";
            this.tabWizGat.UseVisualStyleBackColor = true;
            // 
            // WizGat_Button_Config
            // 
            this.WizGat_Button_Config.AutoSize = true;
            this.WizGat_Button_Config.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_Button_Config.Location = new System.Drawing.Point(146, 17);
            this.WizGat_Button_Config.Name = "WizGat_Button_Config";
            this.WizGat_Button_Config.Size = new System.Drawing.Size(120, 48);
            this.WizGat_Button_Config.TabIndex = 157;
            this.WizGat_Button_Config.Text = "Config";
            this.WizGat_Button_Config.UseVisualStyleBackColor = true;
            this.WizGat_Button_Config.Click += new System.EventHandler(this.Button_SwitchLog_Click);
            // 
            // WizGat_Row
            // 
            this.WizGat_Row.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizGat_Row.BackColor = System.Drawing.Color.Gray;
            this.WizGat_Row.Location = new System.Drawing.Point(175, 265);
            this.WizGat_Row.MaximumSize = new System.Drawing.Size(2000, 1);
            this.WizGat_Row.MinimumSize = new System.Drawing.Size(500, 1);
            this.WizGat_Row.Name = "WizGat_Row";
            this.WizGat_Row.Size = new System.Drawing.Size(753, 1);
            this.WizGat_Row.TabIndex = 156;
            this.WizGat_Row.TabStop = false;
            // 
            // WizGat_Button_Log
            // 
            this.WizGat_Button_Log.AutoSize = true;
            this.WizGat_Button_Log.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_Button_Log.Location = new System.Drawing.Point(20, 17);
            this.WizGat_Button_Log.Name = "WizGat_Button_Log";
            this.WizGat_Button_Log.Size = new System.Drawing.Size(120, 48);
            this.WizGat_Button_Log.TabIndex = 11;
            this.WizGat_Button_Log.Text = "Logs";
            this.WizGat_Button_Log.UseVisualStyleBackColor = true;
            this.WizGat_Button_Log.Click += new System.EventHandler(this.SelectRouter_LogButton_Click);
            // 
            // BackButton_WizGat
            // 
            this.BackButton_WizGat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton_WizGat.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackButton_WizGat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_WizGat.ForeColor = System.Drawing.Color.White;
            this.BackButton_WizGat.Location = new System.Drawing.Point(976, 15);
            this.BackButton_WizGat.Name = "BackButton_WizGat";
            this.BackButton_WizGat.Size = new System.Drawing.Size(120, 48);
            this.BackButton_WizGat.TabIndex = 10;
            this.BackButton_WizGat.Text = "Home";
            this.BackButton_WizGat.UseVisualStyleBackColor = false;
            this.BackButton_WizGat.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // WizGat_Button_CiscoBLDcBGP
            // 
            this.WizGat_Button_CiscoBLDcBGP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizGat_Button_CiscoBLDcBGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_Button_CiscoBLDcBGP.Location = new System.Drawing.Point(716, 165);
            this.WizGat_Button_CiscoBLDcBGP.Name = "WizGat_Button_CiscoBLDcBGP";
            this.WizGat_Button_CiscoBLDcBGP.Size = new System.Drawing.Size(140, 55);
            this.WizGat_Button_CiscoBLDcBGP.TabIndex = 9;
            this.WizGat_Button_CiscoBLDcBGP.Text = "BLD c/ BGP";
            this.WizGat_Button_CiscoBLDcBGP.UseVisualStyleBackColor = true;
            this.WizGat_Button_CiscoBLDcBGP.Click += new System.EventHandler(this.WizCiscoBGP_Click);
            // 
            // WizGat_Button_CiscoVoz
            // 
            this.WizGat_Button_CiscoVoz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizGat_Button_CiscoVoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_Button_CiscoVoz.Location = new System.Drawing.Point(570, 165);
            this.WizGat_Button_CiscoVoz.Name = "WizGat_Button_CiscoVoz";
            this.WizGat_Button_CiscoVoz.Size = new System.Drawing.Size(140, 55);
            this.WizGat_Button_CiscoVoz.TabIndex = 8;
            this.WizGat_Button_CiscoVoz.Text = "VOZ";
            this.WizGat_Button_CiscoVoz.UseVisualStyleBackColor = true;
            this.WizGat_Button_CiscoVoz.Click += new System.EventHandler(this.WizCiscoVoz_Click);
            // 
            // WizGat_Button_CiscoMPLS
            // 
            this.WizGat_Button_CiscoMPLS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizGat_Button_CiscoMPLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_Button_CiscoMPLS.Location = new System.Drawing.Point(424, 165);
            this.WizGat_Button_CiscoMPLS.Name = "WizGat_Button_CiscoMPLS";
            this.WizGat_Button_CiscoMPLS.Size = new System.Drawing.Size(140, 55);
            this.WizGat_Button_CiscoMPLS.TabIndex = 7;
            this.WizGat_Button_CiscoMPLS.Text = "MPLS";
            this.WizGat_Button_CiscoMPLS.UseVisualStyleBackColor = true;
            this.WizGat_Button_CiscoMPLS.Click += new System.EventHandler(this.WizCiscoMPLS_Click);
            // 
            // WizGat_Button_CiscoBLD
            // 
            this.WizGat_Button_CiscoBLD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizGat_Button_CiscoBLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_Button_CiscoBLD.Location = new System.Drawing.Point(278, 165);
            this.WizGat_Button_CiscoBLD.Name = "WizGat_Button_CiscoBLD";
            this.WizGat_Button_CiscoBLD.Size = new System.Drawing.Size(140, 55);
            this.WizGat_Button_CiscoBLD.TabIndex = 6;
            this.WizGat_Button_CiscoBLD.Text = "BLD";
            this.WizGat_Button_CiscoBLD.UseVisualStyleBackColor = true;
            this.WizGat_Button_CiscoBLD.Click += new System.EventHandler(this.WizCiscoBLD_Click);
            // 
            // WizGat_CiscoTitle
            // 
            this.WizGat_CiscoTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizGat_CiscoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_CiscoTitle.Location = new System.Drawing.Point(501, 99);
            this.WizGat_CiscoTitle.Name = "WizGat_CiscoTitle";
            this.WizGat_CiscoTitle.Size = new System.Drawing.Size(139, 39);
            this.WizGat_CiscoTitle.TabIndex = 5;
            this.WizGat_CiscoTitle.Text = "CISCO";
            this.WizGat_CiscoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WizGat_NokiaTitle
            // 
            this.WizGat_NokiaTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizGat_NokiaTitle.BackColor = System.Drawing.SystemColors.Control;
            this.WizGat_NokiaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_NokiaTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WizGat_NokiaTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WizGat_NokiaTitle.Location = new System.Drawing.Point(512, 298);
            this.WizGat_NokiaTitle.Name = "WizGat_NokiaTitle";
            this.WizGat_NokiaTitle.Size = new System.Drawing.Size(129, 39);
            this.WizGat_NokiaTitle.TabIndex = 4;
            this.WizGat_NokiaTitle.Text = "NOKIA";
            this.WizGat_NokiaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WizGat_Button_NokiaBLDcBGP
            // 
            this.WizGat_Button_NokiaBLDcBGP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizGat_Button_NokiaBLDcBGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_Button_NokiaBLDcBGP.Location = new System.Drawing.Point(716, 359);
            this.WizGat_Button_NokiaBLDcBGP.Name = "WizGat_Button_NokiaBLDcBGP";
            this.WizGat_Button_NokiaBLDcBGP.Size = new System.Drawing.Size(140, 55);
            this.WizGat_Button_NokiaBLDcBGP.TabIndex = 3;
            this.WizGat_Button_NokiaBLDcBGP.Text = "BLD c/ BGP";
            this.WizGat_Button_NokiaBLDcBGP.UseVisualStyleBackColor = true;
            this.WizGat_Button_NokiaBLDcBGP.Click += new System.EventHandler(this.WizNokiaBLDcBGP_Click);
            // 
            // WizGat_Button_NokiaVoz
            // 
            this.WizGat_Button_NokiaVoz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizGat_Button_NokiaVoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_Button_NokiaVoz.Location = new System.Drawing.Point(570, 359);
            this.WizGat_Button_NokiaVoz.Name = "WizGat_Button_NokiaVoz";
            this.WizGat_Button_NokiaVoz.Size = new System.Drawing.Size(140, 55);
            this.WizGat_Button_NokiaVoz.TabIndex = 2;
            this.WizGat_Button_NokiaVoz.Text = "VOZ";
            this.WizGat_Button_NokiaVoz.UseVisualStyleBackColor = true;
            this.WizGat_Button_NokiaVoz.Click += new System.EventHandler(this.WizNokiaVoz_Click);
            // 
            // WizGat_Button_NokiaMPLS
            // 
            this.WizGat_Button_NokiaMPLS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizGat_Button_NokiaMPLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_Button_NokiaMPLS.Location = new System.Drawing.Point(424, 359);
            this.WizGat_Button_NokiaMPLS.Name = "WizGat_Button_NokiaMPLS";
            this.WizGat_Button_NokiaMPLS.Size = new System.Drawing.Size(140, 55);
            this.WizGat_Button_NokiaMPLS.TabIndex = 1;
            this.WizGat_Button_NokiaMPLS.Text = "MPLS";
            this.WizGat_Button_NokiaMPLS.UseVisualStyleBackColor = true;
            this.WizGat_Button_NokiaMPLS.Click += new System.EventHandler(this.WizNokiaMPLS_Click);
            // 
            // WizGat_Button_NokiaBLD
            // 
            this.WizGat_Button_NokiaBLD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizGat_Button_NokiaBLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_Button_NokiaBLD.Location = new System.Drawing.Point(278, 359);
            this.WizGat_Button_NokiaBLD.Name = "WizGat_Button_NokiaBLD";
            this.WizGat_Button_NokiaBLD.Size = new System.Drawing.Size(140, 55);
            this.WizGat_Button_NokiaBLD.TabIndex = 0;
            this.WizGat_Button_NokiaBLD.Text = "BLD";
            this.WizGat_Button_NokiaBLD.UseVisualStyleBackColor = true;
            this.WizGat_Button_NokiaBLD.Click += new System.EventHandler(this.WizNokiaBLD_Click);
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.Logs_Button_Config);
            this.tabLogs.Controls.Add(this.Logs_Button_WizGat);
            this.tabLogs.Controls.Add(this.Logs_Button_Broadsoft);
            this.tabLogs.Controls.Add(this.Logs_Button_VOZ_Digistar);
            this.tabLogs.Controls.Add(this.Logs_Button_VOZ_HPE);
            this.tabLogs.Controls.Add(this.Logs_Button_VOZ_Cisco);
            this.tabLogs.Controls.Add(this.Logs_Button_MPLS_Huawei);
            this.tabLogs.Controls.Add(this.Logs_Button_Ligacoes);
            this.tabLogs.Controls.Add(this.Logs_Button_MPLS_Fortigate);
            this.tabLogs.Controls.Add(this.Logs_Label_SubTitle2);
            this.tabLogs.Controls.Add(this.Logs_Button_BLD_Fortigate);
            this.tabLogs.Controls.Add(this.Logs_Button_Velo);
            this.tabLogs.Controls.Add(this.Logs_Label_SubTitle3);
            this.tabLogs.Controls.Add(this.Logs_Label_SubTitle1);
            this.tabLogs.Controls.Add(this.Logs_Label_SubTitle0);
            this.tabLogs.Controls.Add(this.Logs_Button_MPLS_HPE);
            this.tabLogs.Controls.Add(this.Logs_Button_MPLS_Cisco);
            this.tabLogs.Controls.Add(this.Logs_Button_VOZ_Aligera);
            this.tabLogs.Controls.Add(this.Logs_Button_BLD_HPE);
            this.tabLogs.Controls.Add(this.Logs_HomeButton);
            this.tabLogs.Controls.Add(this.Logs_Label_Title);
            this.tabLogs.Controls.Add(this.Logs_Button_CiscoBLD);
            this.tabLogs.Controls.Add(this.Logs_Button_BLD_Huawei);
            this.tabLogs.Controls.Add(this.Logs_Row2);
            this.tabLogs.Controls.Add(this.Logs_Row1);
            this.tabLogs.Controls.Add(this.Logs_Row0);
            this.tabLogs.Location = new System.Drawing.Point(4, 5);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(1112, 513);
            this.tabLogs.TabIndex = 5;
            this.tabLogs.Text = "tabLogs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // Logs_Button_Config
            // 
            this.Logs_Button_Config.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_Config.Location = new System.Drawing.Point(16, 17);
            this.Logs_Button_Config.Name = "Logs_Button_Config";
            this.Logs_Button_Config.Size = new System.Drawing.Size(117, 52);
            this.Logs_Button_Config.TabIndex = 118;
            this.Logs_Button_Config.Text = "Config";
            this.Logs_Button_Config.UseVisualStyleBackColor = true;
            this.Logs_Button_Config.Click += new System.EventHandler(this.Button_SwitchLog_Click);
            // 
            // Logs_Button_WizGat
            // 
            this.Logs_Button_WizGat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_WizGat.Location = new System.Drawing.Point(139, 17);
            this.Logs_Button_WizGat.Name = "Logs_Button_WizGat";
            this.Logs_Button_WizGat.Size = new System.Drawing.Size(125, 52);
            this.Logs_Button_WizGat.TabIndex = 32;
            this.Logs_Button_WizGat.Text = "WizardGat";
            this.Logs_Button_WizGat.UseVisualStyleBackColor = true;
            this.Logs_Button_WizGat.Click += new System.EventHandler(this.WizGat_Open);
            // 
            // Logs_Button_Broadsoft
            // 
            this.Logs_Button_Broadsoft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_Broadsoft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_Broadsoft.Location = new System.Drawing.Point(782, 308);
            this.Logs_Button_Broadsoft.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_Broadsoft.Name = "Logs_Button_Broadsoft";
            this.Logs_Button_Broadsoft.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_Broadsoft.TabIndex = 31;
            this.Logs_Button_Broadsoft.Text = "Broadsoft";
            this.Logs_Button_Broadsoft.UseVisualStyleBackColor = true;
            this.Logs_Button_Broadsoft.Click += new System.EventHandler(this.NotImplemented);
            // 
            // Logs_Button_VOZ_Digistar
            // 
            this.Logs_Button_VOZ_Digistar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_VOZ_Digistar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_VOZ_Digistar.Location = new System.Drawing.Point(576, 377);
            this.Logs_Button_VOZ_Digistar.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_VOZ_Digistar.Name = "Logs_Button_VOZ_Digistar";
            this.Logs_Button_VOZ_Digistar.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_VOZ_Digistar.TabIndex = 30;
            this.Logs_Button_VOZ_Digistar.Text = "Digistar";
            this.Logs_Button_VOZ_Digistar.UseVisualStyleBackColor = true;
            this.Logs_Button_VOZ_Digistar.Click += new System.EventHandler(this.Logs_VOZ_Digistar_Click);
            // 
            // Logs_Button_VOZ_HPE
            // 
            this.Logs_Button_VOZ_HPE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_VOZ_HPE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_VOZ_HPE.Location = new System.Drawing.Point(576, 240);
            this.Logs_Button_VOZ_HPE.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_VOZ_HPE.Name = "Logs_Button_VOZ_HPE";
            this.Logs_Button_VOZ_HPE.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_VOZ_HPE.TabIndex = 29;
            this.Logs_Button_VOZ_HPE.Text = "HPE";
            this.Logs_Button_VOZ_HPE.UseVisualStyleBackColor = true;
            this.Logs_Button_VOZ_HPE.Click += new System.EventHandler(this.Logs_VOZ_HPE_Click);
            // 
            // Logs_Button_VOZ_Cisco
            // 
            this.Logs_Button_VOZ_Cisco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_VOZ_Cisco.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Logs_Button_VOZ_Cisco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_VOZ_Cisco.Location = new System.Drawing.Point(576, 171);
            this.Logs_Button_VOZ_Cisco.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_VOZ_Cisco.Name = "Logs_Button_VOZ_Cisco";
            this.Logs_Button_VOZ_Cisco.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_VOZ_Cisco.TabIndex = 28;
            this.Logs_Button_VOZ_Cisco.Text = "Cisco";
            this.Logs_Button_VOZ_Cisco.UseVisualStyleBackColor = true;
            this.Logs_Button_VOZ_Cisco.Click += new System.EventHandler(this.Logs_VOZ_Cisco_Click);
            // 
            // Logs_Button_MPLS_Huawei
            // 
            this.Logs_Button_MPLS_Huawei.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_MPLS_Huawei.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_MPLS_Huawei.Location = new System.Drawing.Point(365, 308);
            this.Logs_Button_MPLS_Huawei.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_MPLS_Huawei.Name = "Logs_Button_MPLS_Huawei";
            this.Logs_Button_MPLS_Huawei.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_MPLS_Huawei.TabIndex = 27;
            this.Logs_Button_MPLS_Huawei.Text = "Huawei";
            this.Logs_Button_MPLS_Huawei.UseVisualStyleBackColor = true;
            this.Logs_Button_MPLS_Huawei.Click += new System.EventHandler(this.Logs_MPLS_Huawei_Click);
            // 
            // Logs_Button_Ligacoes
            // 
            this.Logs_Button_Ligacoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_Ligacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_Ligacoes.Location = new System.Drawing.Point(782, 171);
            this.Logs_Button_Ligacoes.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_Ligacoes.Name = "Logs_Button_Ligacoes";
            this.Logs_Button_Ligacoes.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_Ligacoes.TabIndex = 26;
            this.Logs_Button_Ligacoes.Text = "Ligações";
            this.Logs_Button_Ligacoes.UseVisualStyleBackColor = true;
            this.Logs_Button_Ligacoes.Click += new System.EventHandler(this.Logs_Ligacao_Click);
            // 
            // Logs_Button_MPLS_Fortigate
            // 
            this.Logs_Button_MPLS_Fortigate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_MPLS_Fortigate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_MPLS_Fortigate.Location = new System.Drawing.Point(365, 377);
            this.Logs_Button_MPLS_Fortigate.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_MPLS_Fortigate.Name = "Logs_Button_MPLS_Fortigate";
            this.Logs_Button_MPLS_Fortigate.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_MPLS_Fortigate.TabIndex = 24;
            this.Logs_Button_MPLS_Fortigate.Text = "Fortigate";
            this.Logs_Button_MPLS_Fortigate.UseVisualStyleBackColor = true;
            this.Logs_Button_MPLS_Fortigate.Click += new System.EventHandler(this.Logs_MPLS_Fortigate_Click);
            // 
            // Logs_Label_SubTitle2
            // 
            this.Logs_Label_SubTitle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Label_SubTitle2.AutoSize = true;
            this.Logs_Label_SubTitle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Label_SubTitle2.Location = new System.Drawing.Point(638, 128);
            this.Logs_Label_SubTitle2.Name = "Logs_Label_SubTitle2";
            this.Logs_Label_SubTitle2.Size = new System.Drawing.Size(51, 25);
            this.Logs_Label_SubTitle2.TabIndex = 22;
            this.Logs_Label_SubTitle2.Text = "VOZ";
            // 
            // Logs_Button_BLD_Fortigate
            // 
            this.Logs_Button_BLD_Fortigate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_BLD_Fortigate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_BLD_Fortigate.Location = new System.Drawing.Point(149, 377);
            this.Logs_Button_BLD_Fortigate.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_BLD_Fortigate.Name = "Logs_Button_BLD_Fortigate";
            this.Logs_Button_BLD_Fortigate.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_BLD_Fortigate.TabIndex = 21;
            this.Logs_Button_BLD_Fortigate.Text = "Fortigate";
            this.Logs_Button_BLD_Fortigate.UseVisualStyleBackColor = true;
            this.Logs_Button_BLD_Fortigate.Click += new System.EventHandler(this.Logs_BLD_Fortigate_Click);
            // 
            // Logs_Button_Velo
            // 
            this.Logs_Button_Velo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_Velo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_Velo.Location = new System.Drawing.Point(782, 240);
            this.Logs_Button_Velo.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_Velo.Name = "Logs_Button_Velo";
            this.Logs_Button_Velo.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_Velo.TabIndex = 18;
            this.Logs_Button_Velo.Text = "Velocloud";
            this.Logs_Button_Velo.UseVisualStyleBackColor = true;
            this.Logs_Button_Velo.Click += new System.EventHandler(this.Logs_Velo_Click);
            // 
            // Logs_Label_SubTitle3
            // 
            this.Logs_Label_SubTitle3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Label_SubTitle3.AutoSize = true;
            this.Logs_Label_SubTitle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Label_SubTitle3.Location = new System.Drawing.Point(835, 128);
            this.Logs_Label_SubTitle3.Name = "Logs_Label_SubTitle3";
            this.Logs_Label_SubTitle3.Size = new System.Drawing.Size(73, 25);
            this.Logs_Label_SubTitle3.TabIndex = 17;
            this.Logs_Label_SubTitle3.Text = "Outros";
            // 
            // Logs_Label_SubTitle1
            // 
            this.Logs_Label_SubTitle1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Label_SubTitle1.AutoSize = true;
            this.Logs_Label_SubTitle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Label_SubTitle1.Location = new System.Drawing.Point(418, 128);
            this.Logs_Label_SubTitle1.Name = "Logs_Label_SubTitle1";
            this.Logs_Label_SubTitle1.Size = new System.Drawing.Size(63, 25);
            this.Logs_Label_SubTitle1.TabIndex = 16;
            this.Logs_Label_SubTitle1.Text = "MPLS";
            // 
            // Logs_Label_SubTitle0
            // 
            this.Logs_Label_SubTitle0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Label_SubTitle0.AutoSize = true;
            this.Logs_Label_SubTitle0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Label_SubTitle0.Location = new System.Drawing.Point(208, 128);
            this.Logs_Label_SubTitle0.Name = "Logs_Label_SubTitle0";
            this.Logs_Label_SubTitle0.Size = new System.Drawing.Size(48, 25);
            this.Logs_Label_SubTitle0.TabIndex = 15;
            this.Logs_Label_SubTitle0.Text = "BLD";
            // 
            // Logs_Button_MPLS_HPE
            // 
            this.Logs_Button_MPLS_HPE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_MPLS_HPE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_MPLS_HPE.Location = new System.Drawing.Point(365, 240);
            this.Logs_Button_MPLS_HPE.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_MPLS_HPE.Name = "Logs_Button_MPLS_HPE";
            this.Logs_Button_MPLS_HPE.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_MPLS_HPE.TabIndex = 14;
            this.Logs_Button_MPLS_HPE.Text = "HPE";
            this.Logs_Button_MPLS_HPE.UseVisualStyleBackColor = true;
            this.Logs_Button_MPLS_HPE.Click += new System.EventHandler(this.Logs_HPE_MPLS_Click);
            // 
            // Logs_Button_MPLS_Cisco
            // 
            this.Logs_Button_MPLS_Cisco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_MPLS_Cisco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_MPLS_Cisco.Location = new System.Drawing.Point(365, 171);
            this.Logs_Button_MPLS_Cisco.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_MPLS_Cisco.Name = "Logs_Button_MPLS_Cisco";
            this.Logs_Button_MPLS_Cisco.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_MPLS_Cisco.TabIndex = 13;
            this.Logs_Button_MPLS_Cisco.Text = "Cisco";
            this.Logs_Button_MPLS_Cisco.UseVisualStyleBackColor = true;
            this.Logs_Button_MPLS_Cisco.Click += new System.EventHandler(this.Logs_Cisco_MPLS_Click);
            // 
            // Logs_Button_VOZ_Aligera
            // 
            this.Logs_Button_VOZ_Aligera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_VOZ_Aligera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_VOZ_Aligera.Location = new System.Drawing.Point(576, 308);
            this.Logs_Button_VOZ_Aligera.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_VOZ_Aligera.Name = "Logs_Button_VOZ_Aligera";
            this.Logs_Button_VOZ_Aligera.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_VOZ_Aligera.TabIndex = 10;
            this.Logs_Button_VOZ_Aligera.Text = "Aligera";
            this.Logs_Button_VOZ_Aligera.UseVisualStyleBackColor = true;
            this.Logs_Button_VOZ_Aligera.Click += new System.EventHandler(this.Logs_VOZ_Aligera_Click);
            // 
            // Logs_Button_BLD_HPE
            // 
            this.Logs_Button_BLD_HPE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_BLD_HPE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_BLD_HPE.Location = new System.Drawing.Point(149, 240);
            this.Logs_Button_BLD_HPE.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_BLD_HPE.Name = "Logs_Button_BLD_HPE";
            this.Logs_Button_BLD_HPE.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_BLD_HPE.TabIndex = 9;
            this.Logs_Button_BLD_HPE.Text = "HPE";
            this.Logs_Button_BLD_HPE.UseVisualStyleBackColor = true;
            this.Logs_Button_BLD_HPE.Click += new System.EventHandler(this.Logs_HPE_BLD_Click);
            // 
            // Logs_HomeButton
            // 
            this.Logs_HomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logs_HomeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Logs_HomeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_HomeButton.ForeColor = System.Drawing.Color.White;
            this.Logs_HomeButton.Location = new System.Drawing.Point(976, 17);
            this.Logs_HomeButton.Name = "Logs_HomeButton";
            this.Logs_HomeButton.Size = new System.Drawing.Size(120, 48);
            this.Logs_HomeButton.TabIndex = 8;
            this.Logs_HomeButton.Text = "Home";
            this.Logs_HomeButton.UseVisualStyleBackColor = false;
            this.Logs_HomeButton.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // Logs_Label_Title
            // 
            this.Logs_Label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Label_Title.AutoSize = true;
            this.Logs_Label_Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Label_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Logs_Label_Title.Location = new System.Drawing.Point(523, 21);
            this.Logs_Label_Title.Name = "Logs_Label_Title";
            this.Logs_Label_Title.Size = new System.Drawing.Size(90, 45);
            this.Logs_Label_Title.TabIndex = 7;
            this.Logs_Label_Title.Text = "Logs";
            this.Logs_Label_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logs_Button_CiscoBLD
            // 
            this.Logs_Button_CiscoBLD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_CiscoBLD.AutoSize = true;
            this.Logs_Button_CiscoBLD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_CiscoBLD.Location = new System.Drawing.Point(149, 171);
            this.Logs_Button_CiscoBLD.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_CiscoBLD.Name = "Logs_Button_CiscoBLD";
            this.Logs_Button_CiscoBLD.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_CiscoBLD.TabIndex = 2;
            this.Logs_Button_CiscoBLD.Text = "Cisco";
            this.Logs_Button_CiscoBLD.UseVisualStyleBackColor = true;
            this.Logs_Button_CiscoBLD.Click += new System.EventHandler(this.Logs_Cisco_BLD_Click);
            // 
            // Logs_Button_BLD_Huawei
            // 
            this.Logs_Button_BLD_Huawei.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Button_BLD_Huawei.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Button_BLD_Huawei.Location = new System.Drawing.Point(149, 308);
            this.Logs_Button_BLD_Huawei.MaximumSize = new System.Drawing.Size(242, 120);
            this.Logs_Button_BLD_Huawei.Name = "Logs_Button_BLD_Huawei";
            this.Logs_Button_BLD_Huawei.Size = new System.Drawing.Size(171, 60);
            this.Logs_Button_BLD_Huawei.TabIndex = 25;
            this.Logs_Button_BLD_Huawei.Text = "Huawei";
            this.Logs_Button_BLD_Huawei.UseVisualStyleBackColor = true;
            this.Logs_Button_BLD_Huawei.Click += new System.EventHandler(this.Logs_BLD_Huawei_Click);
            // 
            // Logs_Row2
            // 
            this.Logs_Row2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Row2.BackColor = System.Drawing.Color.Gray;
            this.Logs_Row2.Location = new System.Drawing.Point(764, 148);
            this.Logs_Row2.Name = "Logs_Row2";
            this.Logs_Row2.Size = new System.Drawing.Size(1, 303);
            this.Logs_Row2.TabIndex = 23;
            this.Logs_Row2.TabStop = false;
            // 
            // Logs_Row1
            // 
            this.Logs_Row1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Row1.BackColor = System.Drawing.Color.Gray;
            this.Logs_Row1.Location = new System.Drawing.Point(557, 148);
            this.Logs_Row1.Name = "Logs_Row1";
            this.Logs_Row1.Size = new System.Drawing.Size(1, 303);
            this.Logs_Row1.TabIndex = 12;
            this.Logs_Row1.TabStop = false;
            // 
            // Logs_Row0
            // 
            this.Logs_Row0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Row0.BackColor = System.Drawing.Color.Gray;
            this.Logs_Row0.Location = new System.Drawing.Point(342, 148);
            this.Logs_Row0.Name = "Logs_Row0";
            this.Logs_Row0.Size = new System.Drawing.Size(1, 303);
            this.Logs_Row0.TabIndex = 11;
            this.Logs_Row0.TabStop = false;
            // 
            // tabVelocloud
            // 
            this.tabVelocloud.AutoScroll = true;
            this.tabVelocloud.Controls.Add(this.veloRestoreButton);
            this.tabVelocloud.Controls.Add(this.tabControl6);
            this.tabVelocloud.Controls.Add(this.Velo_TypeLabel);
            this.tabVelocloud.Controls.Add(this.veloDeleteButtonAll);
            this.tabVelocloud.Controls.Add(this.buttonSwitchVeloLog);
            this.tabVelocloud.Controls.Add(this.labelVelocloudTitle);
            this.tabVelocloud.Controls.Add(this.HomeButton_Velo);
            this.tabVelocloud.Controls.Add(this.buttonVeloCopie);
            this.tabVelocloud.Controls.Add(this.veloTextBoxFinal);
            this.tabVelocloud.Location = new System.Drawing.Point(4, 5);
            this.tabVelocloud.Name = "tabVelocloud";
            this.tabVelocloud.Padding = new System.Windows.Forms.Padding(3);
            this.tabVelocloud.Size = new System.Drawing.Size(1112, 513);
            this.tabVelocloud.TabIndex = 6;
            this.tabVelocloud.Text = "tabPage1";
            this.tabVelocloud.UseVisualStyleBackColor = true;
            // 
            // veloRestoreButton
            // 
            this.veloRestoreButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.veloRestoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloRestoreButton.Location = new System.Drawing.Point(752, 464);
            this.veloRestoreButton.Name = "veloRestoreButton";
            this.veloRestoreButton.Size = new System.Drawing.Size(166, 39);
            this.veloRestoreButton.TabIndex = 169;
            this.veloRestoreButton.Text = "Restore";
            this.veloRestoreButton.UseVisualStyleBackColor = true;
            this.veloRestoreButton.Click += new System.EventHandler(this.VeloRestoreButton_Click);
            // 
            // tabControl6
            // 
            this.tabControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl6.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl6.Controls.Add(this.tab_VeloVars);
            this.tabControl6.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl6.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl6.Location = new System.Drawing.Point(26, 88);
            this.tabControl6.Multiline = true;
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(697, 425);
            this.tabControl6.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl6.TabIndex = 168;
            // 
            // tab_VeloVars
            // 
            this.tab_VeloVars.AutoScroll = true;
            this.tab_VeloVars.BackColor = System.Drawing.SystemColors.Control;
            this.tab_VeloVars.Controls.Add(this.veloTextBox13);
            this.tab_VeloVars.Controls.Add(this.veloTextBox16);
            this.tab_VeloVars.Controls.Add(this.veloTextBox15);
            this.tab_VeloVars.Controls.Add(this.veloTextBox11);
            this.tab_VeloVars.Controls.Add(this.veloTextBox12);
            this.tab_VeloVars.Controls.Add(this.veloTextBox14);
            this.tab_VeloVars.Controls.Add(this.veloTextBox9);
            this.tab_VeloVars.Controls.Add(this.veloTextBox10);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle14);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle15);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle16);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton14);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton15);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton13);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton16);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle13);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle9);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton12);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle10);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton11);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton10);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle12);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton9);
            this.tab_VeloVars.Controls.Add(this.Velo_Testes_Label);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle11);
            this.tab_VeloVars.Controls.Add(this.veloTextBox4);
            this.tab_VeloVars.Controls.Add(this.veloTextBox5);
            this.tab_VeloVars.Controls.Add(this.veloTextBox3);
            this.tab_VeloVars.Controls.Add(this.veloTextBox8);
            this.tab_VeloVars.Controls.Add(this.veloTextBox7);
            this.tab_VeloVars.Controls.Add(this.veloTextBox6);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton5);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton8);
            this.tab_VeloVars.Controls.Add(this.Velo_Configuracao_Label);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton7);
            this.tab_VeloVars.Controls.Add(this.veloTextBox1);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton6);
            this.tab_VeloVars.Controls.Add(this.veloTextBox2);
            this.tab_VeloVars.Controls.Add(this.Velo_Monitor_Label);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle5);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle6);
            this.tab_VeloVars.Controls.Add(this.veloTextBox0);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle7);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle8);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton4);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton3);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton2);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton1);
            this.tab_VeloVars.Controls.Add(this.veloDeleteButton0);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle4);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle3);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle2);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle1);
            this.tab_VeloVars.Controls.Add(this.labelVeloSubtitle0);
            this.tab_VeloVars.Location = new System.Drawing.Point(4, 5);
            this.tab_VeloVars.Name = "tab_VeloVars";
            this.tab_VeloVars.Padding = new System.Windows.Forms.Padding(3);
            this.tab_VeloVars.Size = new System.Drawing.Size(689, 416);
            this.tab_VeloVars.TabIndex = 0;
            this.tab_VeloVars.Text = "tab_VeloVars";
            // 
            // veloTextBox13
            // 
            this.veloTextBox13.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox13.Location = new System.Drawing.Point(371, 395);
            this.veloTextBox13.Name = "veloTextBox13";
            this.veloTextBox13.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox13.TabIndex = 211;
            this.veloTextBox13.Text = "";
            this.veloTextBox13.WordWrap = false;
            // 
            // veloTextBox16
            // 
            this.veloTextBox16.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox16.Location = new System.Drawing.Point(371, 639);
            this.veloTextBox16.Name = "veloTextBox16";
            this.veloTextBox16.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox16.TabIndex = 215;
            this.veloTextBox16.Text = "";
            this.veloTextBox16.WordWrap = false;
            // 
            // veloTextBox15
            // 
            this.veloTextBox15.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox15.Location = new System.Drawing.Point(371, 560);
            this.veloTextBox15.Name = "veloTextBox15";
            this.veloTextBox15.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox15.TabIndex = 214;
            this.veloTextBox15.Text = "";
            this.veloTextBox15.WordWrap = false;
            // 
            // veloTextBox11
            // 
            this.veloTextBox11.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox11.Location = new System.Drawing.Point(371, 239);
            this.veloTextBox11.Name = "veloTextBox11";
            this.veloTextBox11.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox11.TabIndex = 213;
            this.veloTextBox11.Text = "";
            this.veloTextBox11.WordWrap = false;
            // 
            // veloTextBox12
            // 
            this.veloTextBox12.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox12.Location = new System.Drawing.Point(371, 320);
            this.veloTextBox12.Name = "veloTextBox12";
            this.veloTextBox12.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox12.TabIndex = 212;
            this.veloTextBox12.Text = "";
            this.veloTextBox12.WordWrap = false;
            // 
            // veloTextBox14
            // 
            this.veloTextBox14.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox14.Location = new System.Drawing.Point(371, 479);
            this.veloTextBox14.Name = "veloTextBox14";
            this.veloTextBox14.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox14.TabIndex = 210;
            this.veloTextBox14.Text = "";
            this.veloTextBox14.WordWrap = false;
            // 
            // veloTextBox9
            // 
            this.veloTextBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox9.Location = new System.Drawing.Point(369, 64);
            this.veloTextBox9.Name = "veloTextBox9";
            this.veloTextBox9.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox9.TabIndex = 208;
            this.veloTextBox9.Text = "";
            this.veloTextBox9.WordWrap = false;
            // 
            // veloTextBox10
            // 
            this.veloTextBox10.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox10.Location = new System.Drawing.Point(371, 155);
            this.veloTextBox10.Name = "veloTextBox10";
            this.veloTextBox10.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox10.TabIndex = 209;
            this.veloTextBox10.Text = "";
            this.veloTextBox10.WordWrap = false;
            // 
            // labelVeloSubtitle14
            // 
            this.labelVeloSubtitle14.AutoSize = true;
            this.labelVeloSubtitle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle14.Location = new System.Drawing.Point(438, 461);
            this.labelVeloSubtitle14.Name = "labelVeloSubtitle14";
            this.labelVeloSubtitle14.Size = new System.Drawing.Size(121, 15);
            this.labelVeloSubtitle14.TabIndex = 192;
            this.labelVeloSubtitle14.Text = "Show BGP Summary";
            // 
            // labelVeloSubtitle15
            // 
            this.labelVeloSubtitle15.AutoSize = true;
            this.labelVeloSubtitle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle15.Location = new System.Drawing.Point(378, 546);
            this.labelVeloSubtitle15.Name = "labelVeloSubtitle15";
            this.labelVeloSubtitle15.Size = new System.Drawing.Size(215, 15);
            this.labelVeloSubtitle15.TabIndex = 193;
            this.labelVeloSubtitle15.Text = "Show BGP Neighbors Learned Routes";
            // 
            // labelVeloSubtitle16
            // 
            this.labelVeloSubtitle16.AutoSize = true;
            this.labelVeloSubtitle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle16.Location = new System.Drawing.Point(448, 621);
            this.labelVeloSubtitle16.Name = "labelVeloSubtitle16";
            this.labelVeloSubtitle16.Size = new System.Drawing.Size(97, 15);
            this.labelVeloSubtitle16.TabIndex = 194;
            this.labelVeloSubtitle16.Text = "Show BGP Table";
            // 
            // veloDeleteButton14
            // 
            this.veloDeleteButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton14.Location = new System.Drawing.Point(609, 482);
            this.veloDeleteButton14.Name = "veloDeleteButton14";
            this.veloDeleteButton14.Size = new System.Drawing.Size(31, 46);
            this.veloDeleteButton14.TabIndex = 195;
            this.veloDeleteButton14.Text = "-";
            this.veloDeleteButton14.UseVisualStyleBackColor = true;
            this.veloDeleteButton14.Click += new System.EventHandler(this.VeloDeleteButton14_Click);
            // 
            // veloDeleteButton15
            // 
            this.veloDeleteButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton15.Location = new System.Drawing.Point(609, 570);
            this.veloDeleteButton15.Name = "veloDeleteButton15";
            this.veloDeleteButton15.Size = new System.Drawing.Size(31, 46);
            this.veloDeleteButton15.TabIndex = 196;
            this.veloDeleteButton15.Text = "-";
            this.veloDeleteButton15.UseVisualStyleBackColor = true;
            this.veloDeleteButton15.Click += new System.EventHandler(this.VeloDeleteButton15_Click);
            // 
            // veloDeleteButton13
            // 
            this.veloDeleteButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton13.Location = new System.Drawing.Point(609, 393);
            this.veloDeleteButton13.Name = "veloDeleteButton13";
            this.veloDeleteButton13.Size = new System.Drawing.Size(31, 53);
            this.veloDeleteButton13.TabIndex = 207;
            this.veloDeleteButton13.Text = "-";
            this.veloDeleteButton13.UseVisualStyleBackColor = true;
            this.veloDeleteButton13.Click += new System.EventHandler(this.VeloDeleteButton13_Click);
            // 
            // veloDeleteButton16
            // 
            this.veloDeleteButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton16.Location = new System.Drawing.Point(609, 654);
            this.veloDeleteButton16.Name = "veloDeleteButton16";
            this.veloDeleteButton16.Size = new System.Drawing.Size(31, 46);
            this.veloDeleteButton16.TabIndex = 197;
            this.veloDeleteButton16.Text = "-";
            this.veloDeleteButton16.UseVisualStyleBackColor = true;
            this.veloDeleteButton16.Click += new System.EventHandler(this.VeloDeleteButton16_Click);
            // 
            // labelVeloSubtitle13
            // 
            this.labelVeloSubtitle13.AutoSize = true;
            this.labelVeloSubtitle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle13.Location = new System.Drawing.Point(482, 380);
            this.labelVeloSubtitle13.Name = "labelVeloSubtitle13";
            this.labelVeloSubtitle13.Size = new System.Drawing.Size(31, 15);
            this.labelVeloSubtitle13.TabIndex = 206;
            this.labelVeloSubtitle13.Text = "Ping";
            // 
            // labelVeloSubtitle9
            // 
            this.labelVeloSubtitle9.AutoSize = true;
            this.labelVeloSubtitle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle9.Location = new System.Drawing.Point(462, 46);
            this.labelVeloSubtitle9.Name = "labelVeloSubtitle9";
            this.labelVeloSubtitle9.Size = new System.Drawing.Size(68, 15);
            this.labelVeloSubtitle9.TabIndex = 198;
            this.labelVeloSubtitle9.Text = "Tabela ARP";
            // 
            // veloDeleteButton12
            // 
            this.veloDeleteButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton12.Location = new System.Drawing.Point(607, 320);
            this.veloDeleteButton12.Name = "veloDeleteButton12";
            this.veloDeleteButton12.Size = new System.Drawing.Size(31, 58);
            this.veloDeleteButton12.TabIndex = 205;
            this.veloDeleteButton12.Text = "-";
            this.veloDeleteButton12.UseVisualStyleBackColor = true;
            this.veloDeleteButton12.Click += new System.EventHandler(this.VeloDeleteButton12_Click);
            // 
            // labelVeloSubtitle10
            // 
            this.labelVeloSubtitle10.AutoSize = true;
            this.labelVeloSubtitle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle10.Location = new System.Drawing.Point(481, 133);
            this.labelVeloSubtitle10.Name = "labelVeloSubtitle10";
            this.labelVeloSubtitle10.Size = new System.Drawing.Size(24, 15);
            this.labelVeloSubtitle10.TabIndex = 199;
            this.labelVeloSubtitle10.Text = "HA";
            // 
            // veloDeleteButton11
            // 
            this.veloDeleteButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton11.Location = new System.Drawing.Point(607, 239);
            this.veloDeleteButton11.Name = "veloDeleteButton11";
            this.veloDeleteButton11.Size = new System.Drawing.Size(31, 58);
            this.veloDeleteButton11.TabIndex = 204;
            this.veloDeleteButton11.Text = "-";
            this.veloDeleteButton11.UseVisualStyleBackColor = true;
            this.veloDeleteButton11.Click += new System.EventHandler(this.VeloDeleteButton11_Click);
            // 
            // veloDeleteButton10
            // 
            this.veloDeleteButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton10.Location = new System.Drawing.Point(607, 155);
            this.veloDeleteButton10.Name = "veloDeleteButton10";
            this.veloDeleteButton10.Size = new System.Drawing.Size(31, 58);
            this.veloDeleteButton10.TabIndex = 203;
            this.veloDeleteButton10.Text = "-";
            this.veloDeleteButton10.UseVisualStyleBackColor = true;
            this.veloDeleteButton10.Click += new System.EventHandler(this.VeloDeleteButton10_Click);
            // 
            // labelVeloSubtitle12
            // 
            this.labelVeloSubtitle12.AutoSize = true;
            this.labelVeloSubtitle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle12.Location = new System.Drawing.Point(465, 304);
            this.labelVeloSubtitle12.Name = "labelVeloSubtitle12";
            this.labelVeloSubtitle12.Size = new System.Drawing.Size(59, 15);
            this.labelVeloSubtitle12.TabIndex = 201;
            this.labelVeloSubtitle12.Text = "List Paths";
            // 
            // veloDeleteButton9
            // 
            this.veloDeleteButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton9.Location = new System.Drawing.Point(607, 64);
            this.veloDeleteButton9.Name = "veloDeleteButton9";
            this.veloDeleteButton9.Size = new System.Drawing.Size(31, 58);
            this.veloDeleteButton9.TabIndex = 202;
            this.veloDeleteButton9.Text = "-";
            this.veloDeleteButton9.UseVisualStyleBackColor = true;
            this.veloDeleteButton9.Click += new System.EventHandler(this.VeloDeleteButton9_Click);
            // 
            // Velo_Testes_Label
            // 
            this.Velo_Testes_Label.AutoSize = true;
            this.Velo_Testes_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Velo_Testes_Label.Location = new System.Drawing.Point(465, 8);
            this.Velo_Testes_Label.Name = "Velo_Testes_Label";
            this.Velo_Testes_Label.Size = new System.Drawing.Size(56, 21);
            this.Velo_Testes_Label.TabIndex = 191;
            this.Velo_Testes_Label.Text = "Testes";
            // 
            // labelVeloSubtitle11
            // 
            this.labelVeloSubtitle11.AutoSize = true;
            this.labelVeloSubtitle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle11.Location = new System.Drawing.Point(445, 221);
            this.labelVeloSubtitle11.Name = "labelVeloSubtitle11";
            this.labelVeloSubtitle11.Size = new System.Drawing.Size(97, 15);
            this.labelVeloSubtitle11.TabIndex = 200;
            this.labelVeloSubtitle11.Text = "Interface Status";
            // 
            // veloTextBox4
            // 
            this.veloTextBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox4.Location = new System.Drawing.Point(15, 386);
            this.veloTextBox4.Name = "veloTextBox4";
            this.veloTextBox4.Size = new System.Drawing.Size(232, 41);
            this.veloTextBox4.TabIndex = 189;
            this.veloTextBox4.Text = "";
            this.veloTextBox4.WordWrap = false;
            // 
            // veloTextBox5
            // 
            this.veloTextBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox5.Location = new System.Drawing.Point(15, 458);
            this.veloTextBox5.Name = "veloTextBox5";
            this.veloTextBox5.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox5.TabIndex = 188;
            this.veloTextBox5.Text = "";
            this.veloTextBox5.WordWrap = false;
            // 
            // veloTextBox3
            // 
            this.veloTextBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox3.Location = new System.Drawing.Point(15, 325);
            this.veloTextBox3.Name = "veloTextBox3";
            this.veloTextBox3.Size = new System.Drawing.Size(232, 41);
            this.veloTextBox3.TabIndex = 187;
            this.veloTextBox3.Text = "";
            this.veloTextBox3.WordWrap = false;
            // 
            // veloTextBox8
            // 
            this.veloTextBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox8.Location = new System.Drawing.Point(15, 700);
            this.veloTextBox8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.veloTextBox8.Name = "veloTextBox8";
            this.veloTextBox8.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox8.TabIndex = 186;
            this.veloTextBox8.Text = "";
            this.veloTextBox8.WordWrap = false;
            // 
            // veloTextBox7
            // 
            this.veloTextBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox7.Location = new System.Drawing.Point(15, 621);
            this.veloTextBox7.Name = "veloTextBox7";
            this.veloTextBox7.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox7.TabIndex = 185;
            this.veloTextBox7.Text = "";
            this.veloTextBox7.WordWrap = false;
            // 
            // veloTextBox6
            // 
            this.veloTextBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox6.Location = new System.Drawing.Point(15, 541);
            this.veloTextBox6.Name = "veloTextBox6";
            this.veloTextBox6.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox6.TabIndex = 184;
            this.veloTextBox6.Text = "";
            this.veloTextBox6.WordWrap = false;
            // 
            // veloDeleteButton5
            // 
            this.veloDeleteButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton5.Location = new System.Drawing.Point(253, 457);
            this.veloDeleteButton5.Name = "veloDeleteButton5";
            this.veloDeleteButton5.Size = new System.Drawing.Size(31, 59);
            this.veloDeleteButton5.TabIndex = 183;
            this.veloDeleteButton5.Text = "-";
            this.veloDeleteButton5.UseVisualStyleBackColor = true;
            this.veloDeleteButton5.Click += new System.EventHandler(this.VeloDeleteButton5_Click);
            // 
            // veloDeleteButton8
            // 
            this.veloDeleteButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton8.Location = new System.Drawing.Point(253, 700);
            this.veloDeleteButton8.Name = "veloDeleteButton8";
            this.veloDeleteButton8.Size = new System.Drawing.Size(31, 59);
            this.veloDeleteButton8.TabIndex = 172;
            this.veloDeleteButton8.Text = "-";
            this.veloDeleteButton8.UseVisualStyleBackColor = true;
            this.veloDeleteButton8.Click += new System.EventHandler(this.VeloDeleteButton8_Click);
            // 
            // Velo_Configuracao_Label
            // 
            this.Velo_Configuracao_Label.AutoSize = true;
            this.Velo_Configuracao_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Velo_Configuracao_Label.Location = new System.Drawing.Point(87, 269);
            this.Velo_Configuracao_Label.Name = "Velo_Configuracao_Label";
            this.Velo_Configuracao_Label.Size = new System.Drawing.Size(113, 21);
            this.Velo_Configuracao_Label.TabIndex = 182;
            this.Velo_Configuracao_Label.Text = "Configuração";
            // 
            // veloDeleteButton7
            // 
            this.veloDeleteButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton7.Location = new System.Drawing.Point(253, 621);
            this.veloDeleteButton7.Name = "veloDeleteButton7";
            this.veloDeleteButton7.Size = new System.Drawing.Size(31, 57);
            this.veloDeleteButton7.TabIndex = 171;
            this.veloDeleteButton7.Text = "-";
            this.veloDeleteButton7.UseVisualStyleBackColor = true;
            this.veloDeleteButton7.Click += new System.EventHandler(this.VeloDeleteButton7_Click);
            // 
            // veloTextBox1
            // 
            this.veloTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox1.Location = new System.Drawing.Point(16, 126);
            this.veloTextBox1.Name = "veloTextBox1";
            this.veloTextBox1.Size = new System.Drawing.Size(232, 41);
            this.veloTextBox1.TabIndex = 181;
            this.veloTextBox1.Text = "";
            this.veloTextBox1.WordWrap = false;
            // 
            // veloDeleteButton6
            // 
            this.veloDeleteButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton6.Location = new System.Drawing.Point(253, 541);
            this.veloDeleteButton6.Name = "veloDeleteButton6";
            this.veloDeleteButton6.Size = new System.Drawing.Size(31, 58);
            this.veloDeleteButton6.TabIndex = 170;
            this.veloDeleteButton6.Text = "-";
            this.veloDeleteButton6.UseVisualStyleBackColor = true;
            this.veloDeleteButton6.Click += new System.EventHandler(this.VeloDeleteButton6_Click);
            // 
            // veloTextBox2
            // 
            this.veloTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox2.Location = new System.Drawing.Point(16, 190);
            this.veloTextBox2.Name = "veloTextBox2";
            this.veloTextBox2.Size = new System.Drawing.Size(232, 58);
            this.veloTextBox2.TabIndex = 180;
            this.veloTextBox2.Text = "";
            this.veloTextBox2.WordWrap = false;
            // 
            // Velo_Monitor_Label
            // 
            this.Velo_Monitor_Label.AutoSize = true;
            this.Velo_Monitor_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Velo_Monitor_Label.Location = new System.Drawing.Point(101, 8);
            this.Velo_Monitor_Label.Name = "Velo_Monitor_Label";
            this.Velo_Monitor_Label.Size = new System.Drawing.Size(87, 21);
            this.Velo_Monitor_Label.TabIndex = 179;
            this.Velo_Monitor_Label.Text = "Monitorar";
            // 
            // labelVeloSubtitle5
            // 
            this.labelVeloSubtitle5.AutoSize = true;
            this.labelVeloSubtitle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle5.Location = new System.Drawing.Point(86, 439);
            this.labelVeloSubtitle5.Name = "labelVeloSubtitle5";
            this.labelVeloSubtitle5.Size = new System.Drawing.Size(101, 15);
            this.labelVeloSubtitle5.TabIndex = 166;
            this.labelVeloSubtitle5.Text = "Interfaces Físicas";
            // 
            // labelVeloSubtitle6
            // 
            this.labelVeloSubtitle6.AutoSize = true;
            this.labelVeloSubtitle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle6.Location = new System.Drawing.Point(96, 522);
            this.labelVeloSubtitle6.Name = "labelVeloSubtitle6";
            this.labelVeloSubtitle6.Size = new System.Drawing.Size(87, 15);
            this.labelVeloSubtitle6.TabIndex = 167;
            this.labelVeloSubtitle6.Text = "Sobreposições";
            // 
            // veloTextBox0
            // 
            this.veloTextBox0.Font = new System.Drawing.Font("Segoe UI Semibold", 7.45F, System.Drawing.FontStyle.Bold);
            this.veloTextBox0.Location = new System.Drawing.Point(16, 64);
            this.veloTextBox0.Name = "veloTextBox0";
            this.veloTextBox0.Size = new System.Drawing.Size(232, 41);
            this.veloTextBox0.TabIndex = 178;
            this.veloTextBox0.Text = "";
            this.veloTextBox0.WordWrap = false;
            // 
            // labelVeloSubtitle7
            // 
            this.labelVeloSubtitle7.AutoSize = true;
            this.labelVeloSubtitle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle7.Location = new System.Drawing.Point(97, 606);
            this.labelVeloSubtitle7.Name = "labelVeloSubtitle7";
            this.labelVeloSubtitle7.Size = new System.Drawing.Size(78, 15);
            this.labelVeloSubtitle7.TabIndex = 168;
            this.labelVeloSubtitle7.Text = "Rota Estática";
            // 
            // labelVeloSubtitle8
            // 
            this.labelVeloSubtitle8.AutoSize = true;
            this.labelVeloSubtitle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle8.Location = new System.Drawing.Point(119, 687);
            this.labelVeloSubtitle8.Name = "labelVeloSubtitle8";
            this.labelVeloSubtitle8.Size = new System.Drawing.Size(31, 15);
            this.labelVeloSubtitle8.TabIndex = 169;
            this.labelVeloSubtitle8.Text = "BGP";
            // 
            // veloDeleteButton4
            // 
            this.veloDeleteButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton4.Location = new System.Drawing.Point(253, 388);
            this.veloDeleteButton4.Name = "veloDeleteButton4";
            this.veloDeleteButton4.Size = new System.Drawing.Size(31, 37);
            this.veloDeleteButton4.TabIndex = 177;
            this.veloDeleteButton4.Text = "-";
            this.veloDeleteButton4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.veloDeleteButton4.UseVisualStyleBackColor = true;
            this.veloDeleteButton4.Click += new System.EventHandler(this.VeloDeleteButton4_Click);
            // 
            // veloDeleteButton3
            // 
            this.veloDeleteButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton3.Location = new System.Drawing.Point(252, 325);
            this.veloDeleteButton3.Name = "veloDeleteButton3";
            this.veloDeleteButton3.Size = new System.Drawing.Size(31, 32);
            this.veloDeleteButton3.TabIndex = 176;
            this.veloDeleteButton3.Text = "-";
            this.veloDeleteButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.veloDeleteButton3.UseVisualStyleBackColor = true;
            this.veloDeleteButton3.Click += new System.EventHandler(this.VeloDeleteButton3_Click);
            // 
            // veloDeleteButton2
            // 
            this.veloDeleteButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton2.Location = new System.Drawing.Point(253, 190);
            this.veloDeleteButton2.Name = "veloDeleteButton2";
            this.veloDeleteButton2.Size = new System.Drawing.Size(31, 58);
            this.veloDeleteButton2.TabIndex = 175;
            this.veloDeleteButton2.Text = "-";
            this.veloDeleteButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.veloDeleteButton2.UseVisualStyleBackColor = true;
            this.veloDeleteButton2.Click += new System.EventHandler(this.VeloDeleteButton2_Click);
            // 
            // veloDeleteButton1
            // 
            this.veloDeleteButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton1.Location = new System.Drawing.Point(253, 126);
            this.veloDeleteButton1.Name = "veloDeleteButton1";
            this.veloDeleteButton1.Size = new System.Drawing.Size(31, 41);
            this.veloDeleteButton1.TabIndex = 174;
            this.veloDeleteButton1.Text = "-";
            this.veloDeleteButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.veloDeleteButton1.UseVisualStyleBackColor = true;
            this.veloDeleteButton1.Click += new System.EventHandler(this.VeloDeleteButton1_Click);
            // 
            // veloDeleteButton0
            // 
            this.veloDeleteButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton0.Location = new System.Drawing.Point(253, 64);
            this.veloDeleteButton0.Name = "veloDeleteButton0";
            this.veloDeleteButton0.Size = new System.Drawing.Size(31, 41);
            this.veloDeleteButton0.TabIndex = 173;
            this.veloDeleteButton0.Text = "-";
            this.veloDeleteButton0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.veloDeleteButton0.UseVisualStyleBackColor = true;
            this.veloDeleteButton0.Click += new System.EventHandler(this.VeloDeleteButton0_Click);
            // 
            // labelVeloSubtitle4
            // 
            this.labelVeloSubtitle4.AutoSize = true;
            this.labelVeloSubtitle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle4.Location = new System.Drawing.Point(104, 368);
            this.labelVeloSubtitle4.Name = "labelVeloSubtitle4";
            this.labelVeloSubtitle4.Size = new System.Drawing.Size(60, 15);
            this.labelVeloSubtitle4.TabIndex = 165;
            this.labelVeloSubtitle4.Text = "Loopback";
            // 
            // labelVeloSubtitle3
            // 
            this.labelVeloSubtitle3.AutoSize = true;
            this.labelVeloSubtitle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle3.Location = new System.Drawing.Point(65, 305);
            this.labelVeloSubtitle3.Name = "labelVeloSubtitle3";
            this.labelVeloSubtitle3.Size = new System.Drawing.Size(129, 15);
            this.labelVeloSubtitle3.TabIndex = 164;
            this.labelVeloSubtitle3.Text = "Configuração de Vlans";
            // 
            // labelVeloSubtitle2
            // 
            this.labelVeloSubtitle2.AutoSize = true;
            this.labelVeloSubtitle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle2.Location = new System.Drawing.Point(87, 170);
            this.labelVeloSubtitle2.Name = "labelVeloSubtitle2";
            this.labelVeloSubtitle2.Size = new System.Drawing.Size(104, 15);
            this.labelVeloSubtitle2.TabIndex = 163;
            this.labelVeloSubtitle2.Text = "Estado de Ligação";
            // 
            // labelVeloSubtitle1
            // 
            this.labelVeloSubtitle1.AutoSize = true;
            this.labelVeloSubtitle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle1.Location = new System.Drawing.Point(115, 107);
            this.labelVeloSubtitle1.Name = "labelVeloSubtitle1";
            this.labelVeloSubtitle1.Size = new System.Drawing.Size(50, 15);
            this.labelVeloSubtitle1.TabIndex = 162;
            this.labelVeloSubtitle1.Text = "NodeID";
            // 
            // labelVeloSubtitle0
            // 
            this.labelVeloSubtitle0.AutoSize = true;
            this.labelVeloSubtitle0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle0.Location = new System.Drawing.Point(109, 45);
            this.labelVeloSubtitle0.Name = "labelVeloSubtitle0";
            this.labelVeloSubtitle0.Size = new System.Drawing.Size(64, 15);
            this.labelVeloSubtitle0.TabIndex = 161;
            this.labelVeloSubtitle0.Text = "Hostname";
            // 
            // Velo_TypeLabel
            // 
            this.Velo_TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Velo_TypeLabel.Font = new System.Drawing.Font("Segoe UI", 16.75F, System.Drawing.FontStyle.Bold);
            this.Velo_TypeLabel.Location = new System.Drawing.Point(782, 83);
            this.Velo_TypeLabel.Name = "Velo_TypeLabel";
            this.Velo_TypeLabel.Size = new System.Drawing.Size(109, 30);
            this.Velo_TypeLabel.TabIndex = 119;
            this.Velo_TypeLabel.Text = "Iniciais";
            this.Velo_TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // veloDeleteButtonAll
            // 
            this.veloDeleteButtonAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.veloDeleteButtonAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButtonAll.Location = new System.Drawing.Point(941, 88);
            this.veloDeleteButtonAll.Name = "veloDeleteButtonAll";
            this.veloDeleteButtonAll.Size = new System.Drawing.Size(144, 34);
            this.veloDeleteButtonAll.TabIndex = 71;
            this.veloDeleteButtonAll.Text = "Limpar Campos";
            this.veloDeleteButtonAll.UseVisualStyleBackColor = true;
            this.veloDeleteButtonAll.Click += new System.EventHandler(this.VeloDeleteButtonAll_Click);
            // 
            // buttonSwitchVeloLog
            // 
            this.buttonSwitchVeloLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSwitchVeloLog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwitchVeloLog.Location = new System.Drawing.Point(861, 21);
            this.buttonSwitchVeloLog.Name = "buttonSwitchVeloLog";
            this.buttonSwitchVeloLog.Size = new System.Drawing.Size(104, 43);
            this.buttonSwitchVeloLog.TabIndex = 69;
            this.buttonSwitchVeloLog.Text = "Switch";
            this.buttonSwitchVeloLog.UseVisualStyleBackColor = true;
            this.buttonSwitchVeloLog.Click += new System.EventHandler(this.SwitchVeloLog_Click);
            // 
            // labelVelocloudTitle
            // 
            this.labelVelocloudTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelVelocloudTitle.AutoSize = true;
            this.labelVelocloudTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocloudTitle.Location = new System.Drawing.Point(275, 21);
            this.labelVelocloudTitle.Name = "labelVelocloudTitle";
            this.labelVelocloudTitle.Size = new System.Drawing.Size(172, 37);
            this.labelVelocloudTitle.TabIndex = 68;
            this.labelVelocloudTitle.Text = "VELOCLOUD";
            this.labelVelocloudTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeButton_Velo
            // 
            this.HomeButton_Velo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton_Velo.BackColor = System.Drawing.SystemColors.Highlight;
            this.HomeButton_Velo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton_Velo.ForeColor = System.Drawing.Color.White;
            this.HomeButton_Velo.Location = new System.Drawing.Point(971, 21);
            this.HomeButton_Velo.Name = "HomeButton_Velo";
            this.HomeButton_Velo.Size = new System.Drawing.Size(104, 43);
            this.HomeButton_Velo.TabIndex = 32;
            this.HomeButton_Velo.Text = "Home";
            this.HomeButton_Velo.UseVisualStyleBackColor = false;
            this.HomeButton_Velo.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // buttonVeloCopie
            // 
            this.buttonVeloCopie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonVeloCopie.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.buttonVeloCopie.Location = new System.Drawing.Point(925, 464);
            this.buttonVeloCopie.Name = "buttonVeloCopie";
            this.buttonVeloCopie.Size = new System.Drawing.Size(162, 39);
            this.buttonVeloCopie.TabIndex = 0;
            this.buttonVeloCopie.Text = "Formatar e Copiar";
            this.buttonVeloCopie.UseVisualStyleBackColor = true;
            this.buttonVeloCopie.Click += new System.EventHandler(this.VeloCopie_Click);
            // 
            // veloTextBoxFinal
            // 
            this.veloTextBoxFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.veloTextBoxFinal.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBoxFinal.Location = new System.Drawing.Point(752, 131);
            this.veloTextBoxFinal.Name = "veloTextBoxFinal";
            this.veloTextBoxFinal.Size = new System.Drawing.Size(335, 328);
            this.veloTextBoxFinal.TabIndex = 88;
            this.veloTextBoxFinal.Text = "";
            this.veloTextBoxFinal.WordWrap = false;
            // 
            // tabLigacoes
            // 
            this.tabLigacoes.Controls.Add(this.Ligacoes_ConfigWiseButton);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BHPE_Antigo);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BLogs);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BDigistar);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BCisco);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BHPE);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BDebug);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BAligera);
            this.tabLigacoes.Controls.Add(this.HomeButton_Ligacoes);
            this.tabLigacoes.Controls.Add(this.Ligacoes_Title);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BRestore);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BCopy);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BFormat);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BClear);
            this.tabLigacoes.Controls.Add(this.Ligacoes_Clear3);
            this.tabLigacoes.Controls.Add(this.Ligacoes_Clear2);
            this.tabLigacoes.Controls.Add(this.Ligacoes_Clear1);
            this.tabLigacoes.Controls.Add(this.Ligacoes_Clear4);
            this.tabLigacoes.Controls.Add(this.Ligacoes_Clear5);
            this.tabLigacoes.Controls.Add(this.Ligacoes_Clear6);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TextBox5);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle5);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TextBox6);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle6);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TextBox4);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle4);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TextBox3);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle3);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TextBox2);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle2);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TextBox1);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle1);
            this.tabLigacoes.Controls.Add(this.Ligacoes_FinalTextBox);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BExemplos);
            this.tabLigacoes.Controls.Add(this.LigacoesRow2);
            this.tabLigacoes.Controls.Add(this.LigacoesRow1);
            this.tabLigacoes.Location = new System.Drawing.Point(4, 5);
            this.tabLigacoes.Name = "tabLigacoes";
            this.tabLigacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabLigacoes.Size = new System.Drawing.Size(1112, 513);
            this.tabLigacoes.TabIndex = 7;
            this.tabLigacoes.Text = "tabLigacoes";
            this.tabLigacoes.UseVisualStyleBackColor = true;
            // 
            // Ligacoes_ConfigWiseButton
            // 
            this.Ligacoes_ConfigWiseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_ConfigWiseButton.ForeColor = System.Drawing.Color.DarkRed;
            this.Ligacoes_ConfigWiseButton.Location = new System.Drawing.Point(689, 19);
            this.Ligacoes_ConfigWiseButton.Name = "Ligacoes_ConfigWiseButton";
            this.Ligacoes_ConfigWiseButton.Size = new System.Drawing.Size(247, 41);
            this.Ligacoes_ConfigWiseButton.TabIndex = 158;
            this.Ligacoes_ConfigWiseButton.Text = "Configurações Wise";
            this.Ligacoes_ConfigWiseButton.UseVisualStyleBackColor = true;
            this.Ligacoes_ConfigWiseButton.Click += new System.EventHandler(this.Ligacoes_ConfigWiseButton_Click);
            // 
            // Ligacoes_BHPE_Antigo
            // 
            this.Ligacoes_BHPE_Antigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_BHPE_Antigo.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BHPE_Antigo.Location = new System.Drawing.Point(608, 255);
            this.Ligacoes_BHPE_Antigo.Name = "Ligacoes_BHPE_Antigo";
            this.Ligacoes_BHPE_Antigo.Size = new System.Drawing.Size(66, 44);
            this.Ligacoes_BHPE_Antigo.TabIndex = 34;
            this.Ligacoes_BHPE_Antigo.Text = "Coleta HPE (Antigo)";
            this.Ligacoes_BHPE_Antigo.UseVisualStyleBackColor = true;
            this.Ligacoes_BHPE_Antigo.Click += new System.EventHandler(this.Ligacoes_BHPE_Antigo_Click);
            // 
            // Ligacoes_BLogs
            // 
            this.Ligacoes_BLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ligacoes_BLogs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BLogs.Location = new System.Drawing.Point(992, 19);
            this.Ligacoes_BLogs.Name = "Ligacoes_BLogs";
            this.Ligacoes_BLogs.Size = new System.Drawing.Size(104, 41);
            this.Ligacoes_BLogs.TabIndex = 33;
            this.Ligacoes_BLogs.Text = "Logs Finais";
            this.Ligacoes_BLogs.UseVisualStyleBackColor = true;
            this.Ligacoes_BLogs.Click += new System.EventHandler(this.Logs_Finais_Click);
            // 
            // Ligacoes_BDigistar
            // 
            this.Ligacoes_BDigistar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_BDigistar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BDigistar.Location = new System.Drawing.Point(608, 351);
            this.Ligacoes_BDigistar.Name = "Ligacoes_BDigistar";
            this.Ligacoes_BDigistar.Size = new System.Drawing.Size(66, 44);
            this.Ligacoes_BDigistar.TabIndex = 32;
            this.Ligacoes_BDigistar.Text = "Coleta Digistar";
            this.Ligacoes_BDigistar.UseVisualStyleBackColor = true;
            this.Ligacoes_BDigistar.Click += new System.EventHandler(this.Ligacoes_BDigistar_Click);
            // 
            // Ligacoes_BCisco
            // 
            this.Ligacoes_BCisco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_BCisco.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BCisco.Location = new System.Drawing.Point(608, 303);
            this.Ligacoes_BCisco.Name = "Ligacoes_BCisco";
            this.Ligacoes_BCisco.Size = new System.Drawing.Size(66, 44);
            this.Ligacoes_BCisco.TabIndex = 31;
            this.Ligacoes_BCisco.Text = "Coleta Cisco";
            this.Ligacoes_BCisco.UseVisualStyleBackColor = true;
            this.Ligacoes_BCisco.Click += new System.EventHandler(this.Ligacoes_BCisco_Click);
            // 
            // Ligacoes_BHPE
            // 
            this.Ligacoes_BHPE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_BHPE.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BHPE.Location = new System.Drawing.Point(608, 208);
            this.Ligacoes_BHPE.Name = "Ligacoes_BHPE";
            this.Ligacoes_BHPE.Size = new System.Drawing.Size(66, 44);
            this.Ligacoes_BHPE.TabIndex = 30;
            this.Ligacoes_BHPE.Text = "Coleta HPE";
            this.Ligacoes_BHPE.UseVisualStyleBackColor = true;
            this.Ligacoes_BHPE.Click += new System.EventHandler(this.Ligacoes_BHPE_Click);
            // 
            // Ligacoes_BDebug
            // 
            this.Ligacoes_BDebug.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_BDebug.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BDebug.Location = new System.Drawing.Point(608, 408);
            this.Ligacoes_BDebug.Name = "Ligacoes_BDebug";
            this.Ligacoes_BDebug.Size = new System.Drawing.Size(66, 52);
            this.Ligacoes_BDebug.TabIndex = 29;
            this.Ligacoes_BDebug.Text = "Debug";
            this.Ligacoes_BDebug.UseVisualStyleBackColor = true;
            this.Ligacoes_BDebug.Click += new System.EventHandler(this.Ligacoes_BDebug_Click);
            // 
            // Ligacoes_BAligera
            // 
            this.Ligacoes_BAligera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_BAligera.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BAligera.Location = new System.Drawing.Point(608, 159);
            this.Ligacoes_BAligera.Name = "Ligacoes_BAligera";
            this.Ligacoes_BAligera.Size = new System.Drawing.Size(66, 44);
            this.Ligacoes_BAligera.TabIndex = 26;
            this.Ligacoes_BAligera.Text = "Coleta Aligera";
            this.Ligacoes_BAligera.UseVisualStyleBackColor = true;
            this.Ligacoes_BAligera.Click += new System.EventHandler(this.Ligacoes_BAligera_Click);
            // 
            // HomeButton_Ligacoes
            // 
            this.HomeButton_Ligacoes.BackColor = System.Drawing.SystemColors.Highlight;
            this.HomeButton_Ligacoes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton_Ligacoes.ForeColor = System.Drawing.Color.White;
            this.HomeButton_Ligacoes.Location = new System.Drawing.Point(6, 6);
            this.HomeButton_Ligacoes.Name = "HomeButton_Ligacoes";
            this.HomeButton_Ligacoes.Size = new System.Drawing.Size(104, 43);
            this.HomeButton_Ligacoes.TabIndex = 24;
            this.HomeButton_Ligacoes.Text = "Home";
            this.HomeButton_Ligacoes.UseVisualStyleBackColor = false;
            this.HomeButton_Ligacoes.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // Ligacoes_Title
            // 
            this.Ligacoes_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_Title.AutoSize = true;
            this.Ligacoes_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ligacoes_Title.Location = new System.Drawing.Point(206, 19);
            this.Ligacoes_Title.Name = "Ligacoes_Title";
            this.Ligacoes_Title.Size = new System.Drawing.Size(268, 37);
            this.Ligacoes_Title.TabIndex = 23;
            this.Ligacoes_Title.Text = "Logs de Ligação";
            this.Ligacoes_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ligacoes_BRestore
            // 
            this.Ligacoes_BRestore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_BRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BRestore.Location = new System.Drawing.Point(689, 87);
            this.Ligacoes_BRestore.Name = "Ligacoes_BRestore";
            this.Ligacoes_BRestore.Size = new System.Drawing.Size(90, 40);
            this.Ligacoes_BRestore.TabIndex = 22;
            this.Ligacoes_BRestore.Text = "Restore";
            this.Ligacoes_BRestore.UseVisualStyleBackColor = true;
            this.Ligacoes_BRestore.Click += new System.EventHandler(this.Ligacoes_BRestore_Click);
            // 
            // Ligacoes_BCopy
            // 
            this.Ligacoes_BCopy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_BCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BCopy.Location = new System.Drawing.Point(1002, 87);
            this.Ligacoes_BCopy.Name = "Ligacoes_BCopy";
            this.Ligacoes_BCopy.Size = new System.Drawing.Size(90, 40);
            this.Ligacoes_BCopy.TabIndex = 21;
            this.Ligacoes_BCopy.Text = "Formatar e Copiar";
            this.Ligacoes_BCopy.UseVisualStyleBackColor = true;
            this.Ligacoes_BCopy.Click += new System.EventHandler(this.Ligacoes_BCopy_Click);
            // 
            // Ligacoes_BFormat
            // 
            this.Ligacoes_BFormat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_BFormat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BFormat.Location = new System.Drawing.Point(898, 87);
            this.Ligacoes_BFormat.Name = "Ligacoes_BFormat";
            this.Ligacoes_BFormat.Size = new System.Drawing.Size(90, 40);
            this.Ligacoes_BFormat.TabIndex = 20;
            this.Ligacoes_BFormat.Text = "Formatar";
            this.Ligacoes_BFormat.UseVisualStyleBackColor = true;
            this.Ligacoes_BFormat.Click += new System.EventHandler(this.Ligacoes_BFormat_Click);
            // 
            // Ligacoes_BClear
            // 
            this.Ligacoes_BClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_BClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BClear.Location = new System.Drawing.Point(795, 87);
            this.Ligacoes_BClear.Name = "Ligacoes_BClear";
            this.Ligacoes_BClear.Size = new System.Drawing.Size(90, 40);
            this.Ligacoes_BClear.TabIndex = 19;
            this.Ligacoes_BClear.Text = "Limpar";
            this.Ligacoes_BClear.UseVisualStyleBackColor = true;
            this.Ligacoes_BClear.Click += new System.EventHandler(this.Ligacoes_BClear_Click);
            // 
            // Ligacoes_Clear3
            // 
            this.Ligacoes_Clear3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_Clear3.Location = new System.Drawing.Point(234, 234);
            this.Ligacoes_Clear3.Name = "Ligacoes_Clear3";
            this.Ligacoes_Clear3.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear3.TabIndex = 18;
            this.Ligacoes_Clear3.Text = "Limpar";
            this.Ligacoes_Clear3.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear3.Click += new System.EventHandler(this.Ligacoes_Clear3_Click);
            // 
            // Ligacoes_Clear2
            // 
            this.Ligacoes_Clear2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_Clear2.Location = new System.Drawing.Point(524, 118);
            this.Ligacoes_Clear2.Name = "Ligacoes_Clear2";
            this.Ligacoes_Clear2.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear2.TabIndex = 17;
            this.Ligacoes_Clear2.Text = "Limpar";
            this.Ligacoes_Clear2.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear2.Click += new System.EventHandler(this.Ligacoes_Clear2_Click);
            // 
            // Ligacoes_Clear1
            // 
            this.Ligacoes_Clear1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_Clear1.Location = new System.Drawing.Point(234, 118);
            this.Ligacoes_Clear1.Name = "Ligacoes_Clear1";
            this.Ligacoes_Clear1.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear1.TabIndex = 16;
            this.Ligacoes_Clear1.Text = "Limpar";
            this.Ligacoes_Clear1.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear1.Click += new System.EventHandler(this.Ligacoes_Clear1_Click);
            // 
            // Ligacoes_Clear4
            // 
            this.Ligacoes_Clear4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_Clear4.Location = new System.Drawing.Point(524, 234);
            this.Ligacoes_Clear4.Name = "Ligacoes_Clear4";
            this.Ligacoes_Clear4.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear4.TabIndex = 15;
            this.Ligacoes_Clear4.Text = "Limpar";
            this.Ligacoes_Clear4.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear4.Click += new System.EventHandler(this.Ligacoes_Clear4_Click);
            // 
            // Ligacoes_Clear5
            // 
            this.Ligacoes_Clear5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_Clear5.Location = new System.Drawing.Point(234, 353);
            this.Ligacoes_Clear5.Name = "Ligacoes_Clear5";
            this.Ligacoes_Clear5.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear5.TabIndex = 14;
            this.Ligacoes_Clear5.Text = "Limpar";
            this.Ligacoes_Clear5.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear5.Click += new System.EventHandler(this.Ligacoes_Clear5_Click);
            // 
            // Ligacoes_Clear6
            // 
            this.Ligacoes_Clear6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_Clear6.Location = new System.Drawing.Point(524, 352);
            this.Ligacoes_Clear6.Name = "Ligacoes_Clear6";
            this.Ligacoes_Clear6.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear6.TabIndex = 13;
            this.Ligacoes_Clear6.Text = "Limpar";
            this.Ligacoes_Clear6.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear6.Click += new System.EventHandler(this.Ligacoes_Clear6_Click);
            // 
            // Ligacoes_TextBox5
            // 
            this.Ligacoes_TextBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_TextBox5.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TextBox5.Location = new System.Drawing.Point(39, 377);
            this.Ligacoes_TextBox5.Multiline = true;
            this.Ligacoes_TextBox5.Name = "Ligacoes_TextBox5";
            this.Ligacoes_TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TextBox5.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TextBox5.TabIndex = 12;
            this.Ligacoes_TextBox5.WordWrap = false;
            // 
            // Ligacoes_SubTitle5
            // 
            this.Ligacoes_SubTitle5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_SubTitle5.AutoSize = true;
            this.Ligacoes_SubTitle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle5.Location = new System.Drawing.Point(128, 353);
            this.Ligacoes_SubTitle5.Name = "Ligacoes_SubTitle5";
            this.Ligacoes_SubTitle5.Size = new System.Drawing.Size(78, 21);
            this.Ligacoes_SubTitle5.TabIndex = 11;
            this.Ligacoes_SubTitle5.Text = "3 Dígitos";
            // 
            // Ligacoes_TextBox6
            // 
            this.Ligacoes_TextBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_TextBox6.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TextBox6.Location = new System.Drawing.Point(329, 376);
            this.Ligacoes_TextBox6.Multiline = true;
            this.Ligacoes_TextBox6.Name = "Ligacoes_TextBox6";
            this.Ligacoes_TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TextBox6.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TextBox6.TabIndex = 8;
            this.Ligacoes_TextBox6.WordWrap = false;
            // 
            // Ligacoes_SubTitle6
            // 
            this.Ligacoes_SubTitle6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_SubTitle6.AutoSize = true;
            this.Ligacoes_SubTitle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle6.Location = new System.Drawing.Point(422, 352);
            this.Ligacoes_SubTitle6.Name = "Ligacoes_SubTitle6";
            this.Ligacoes_SubTitle6.Size = new System.Drawing.Size(69, 21);
            this.Ligacoes_SubTitle6.TabIndex = 7;
            this.Ligacoes_SubTitle6.Text = "Entrada";
            // 
            // Ligacoes_TextBox4
            // 
            this.Ligacoes_TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_TextBox4.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TextBox4.Location = new System.Drawing.Point(329, 258);
            this.Ligacoes_TextBox4.Multiline = true;
            this.Ligacoes_TextBox4.Name = "Ligacoes_TextBox4";
            this.Ligacoes_TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TextBox4.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TextBox4.TabIndex = 10;
            this.Ligacoes_TextBox4.WordWrap = false;
            // 
            // Ligacoes_SubTitle4
            // 
            this.Ligacoes_SubTitle4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_SubTitle4.AutoSize = true;
            this.Ligacoes_SubTitle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle4.Location = new System.Drawing.Point(431, 234);
            this.Ligacoes_SubTitle4.Name = "Ligacoes_SubTitle4";
            this.Ligacoes_SubTitle4.Size = new System.Drawing.Size(46, 21);
            this.Ligacoes_SubTitle4.TabIndex = 9;
            this.Ligacoes_SubTitle4.Text = "0800";
            // 
            // Ligacoes_TextBox3
            // 
            this.Ligacoes_TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_TextBox3.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TextBox3.Location = new System.Drawing.Point(39, 258);
            this.Ligacoes_TextBox3.Multiline = true;
            this.Ligacoes_TextBox3.Name = "Ligacoes_TextBox3";
            this.Ligacoes_TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TextBox3.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TextBox3.TabIndex = 6;
            this.Ligacoes_TextBox3.WordWrap = false;
            // 
            // Ligacoes_SubTitle3
            // 
            this.Ligacoes_SubTitle3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_SubTitle3.AutoSize = true;
            this.Ligacoes_SubTitle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle3.Location = new System.Drawing.Point(127, 234);
            this.Ligacoes_SubTitle3.Name = "Ligacoes_SubTitle3";
            this.Ligacoes_SubTitle3.Size = new System.Drawing.Size(64, 21);
            this.Ligacoes_SubTitle3.TabIndex = 5;
            this.Ligacoes_SubTitle3.Text = "Celular";
            // 
            // Ligacoes_TextBox2
            // 
            this.Ligacoes_TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_TextBox2.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TextBox2.Location = new System.Drawing.Point(329, 142);
            this.Ligacoes_TextBox2.Multiline = true;
            this.Ligacoes_TextBox2.Name = "Ligacoes_TextBox2";
            this.Ligacoes_TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TextBox2.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TextBox2.TabIndex = 4;
            this.Ligacoes_TextBox2.WordWrap = false;
            // 
            // Ligacoes_SubTitle2
            // 
            this.Ligacoes_SubTitle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_SubTitle2.AutoSize = true;
            this.Ligacoes_SubTitle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle2.Location = new System.Drawing.Point(431, 118);
            this.Ligacoes_SubTitle2.Name = "Ligacoes_SubTitle2";
            this.Ligacoes_SubTitle2.Size = new System.Drawing.Size(46, 21);
            this.Ligacoes_SubTitle2.TabIndex = 3;
            this.Ligacoes_SubTitle2.Text = "DDD";
            // 
            // Ligacoes_TextBox1
            // 
            this.Ligacoes_TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_TextBox1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TextBox1.Location = new System.Drawing.Point(39, 142);
            this.Ligacoes_TextBox1.Multiline = true;
            this.Ligacoes_TextBox1.Name = "Ligacoes_TextBox1";
            this.Ligacoes_TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TextBox1.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TextBox1.TabIndex = 2;
            this.Ligacoes_TextBox1.WordWrap = false;
            // 
            // Ligacoes_SubTitle1
            // 
            this.Ligacoes_SubTitle1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_SubTitle1.AutoSize = true;
            this.Ligacoes_SubTitle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle1.Location = new System.Drawing.Point(121, 118);
            this.Ligacoes_SubTitle1.Name = "Ligacoes_SubTitle1";
            this.Ligacoes_SubTitle1.Size = new System.Drawing.Size(86, 21);
            this.Ligacoes_SubTitle1.TabIndex = 0;
            this.Ligacoes_SubTitle1.Text = "Fixo Local";
            // 
            // Ligacoes_FinalTextBox
            // 
            this.Ligacoes_FinalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_FinalTextBox.Location = new System.Drawing.Point(689, 135);
            this.Ligacoes_FinalTextBox.Name = "Ligacoes_FinalTextBox";
            this.Ligacoes_FinalTextBox.Size = new System.Drawing.Size(407, 360);
            this.Ligacoes_FinalTextBox.TabIndex = 35;
            this.Ligacoes_FinalTextBox.Text = "";
            this.Ligacoes_FinalTextBox.WordWrap = false;
            // 
            // Ligacoes_BExemplos
            // 
            this.Ligacoes_BExemplos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_BExemplos.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BExemplos.Location = new System.Drawing.Point(608, 87);
            this.Ligacoes_BExemplos.Name = "Ligacoes_BExemplos";
            this.Ligacoes_BExemplos.Size = new System.Drawing.Size(66, 62);
            this.Ligacoes_BExemplos.TabIndex = 25;
            this.Ligacoes_BExemplos.Text = "Numeros de Exemplo";
            this.Ligacoes_BExemplos.UseVisualStyleBackColor = true;
            this.Ligacoes_BExemplos.Click += new System.EventHandler(this.Ligacoes_BExemplos_Click);
            // 
            // LigacoesRow2
            // 
            this.LigacoesRow2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LigacoesRow2.BackColor = System.Drawing.Color.Gray;
            this.LigacoesRow2.Location = new System.Drawing.Point(606, 401);
            this.LigacoesRow2.MaximumSize = new System.Drawing.Size(2000, 1);
            this.LigacoesRow2.Name = "LigacoesRow2";
            this.LigacoesRow2.Size = new System.Drawing.Size(70, 1);
            this.LigacoesRow2.TabIndex = 157;
            this.LigacoesRow2.TabStop = false;
            // 
            // LigacoesRow1
            // 
            this.LigacoesRow1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LigacoesRow1.BackColor = System.Drawing.Color.Gray;
            this.LigacoesRow1.Location = new System.Drawing.Point(606, 153);
            this.LigacoesRow1.MaximumSize = new System.Drawing.Size(2000, 1);
            this.LigacoesRow1.Name = "LigacoesRow1";
            this.LigacoesRow1.Size = new System.Drawing.Size(70, 1);
            this.LigacoesRow1.TabIndex = 156;
            this.LigacoesRow1.TabStop = false;
            // 
            // tabOutros
            // 
            this.tabOutros.Controls.Add(this.Outros_CheckBox_ShowTrueScript);
            this.tabOutros.Controls.Add(this.Outros_Button_Logs);
            this.tabOutros.Controls.Add(this.Outros_Button_ApplyTestValues);
            this.tabOutros.Controls.Add(this.Outros_TypeLabel);
            this.tabOutros.Controls.Add(this.Outros_TypeComboBox);
            this.tabOutros.Controls.Add(this.Outros_ButtonForCopy);
            this.tabOutros.Controls.Add(this.Outros_ButtonCopy);
            this.tabOutros.Controls.Add(this.Outros_ButtonFormat);
            this.tabOutros.Controls.Add(this.HomeButton_Outros);
            this.tabOutros.Controls.Add(this.Outros_Script_Title);
            this.tabOutros.Controls.Add(this.Outros_FinalTextBox);
            this.tabOutros.Controls.Add(this.Outros_Title);
            this.tabOutros.Controls.Add(this.TabSubOutros);
            this.tabOutros.Location = new System.Drawing.Point(4, 5);
            this.tabOutros.Name = "tabOutros";
            this.tabOutros.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutros.Size = new System.Drawing.Size(1112, 513);
            this.tabOutros.TabIndex = 8;
            this.tabOutros.Text = "Outras Configuracoes";
            this.tabOutros.UseVisualStyleBackColor = true;
            // 
            // Outros_CheckBox_ShowTrueScript
            // 
            this.Outros_CheckBox_ShowTrueScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_CheckBox_ShowTrueScript.AutoSize = true;
            this.Outros_CheckBox_ShowTrueScript.Location = new System.Drawing.Point(839, 29);
            this.Outros_CheckBox_ShowTrueScript.Name = "Outros_CheckBox_ShowTrueScript";
            this.Outros_CheckBox_ShowTrueScript.Size = new System.Drawing.Size(135, 23);
            this.Outros_CheckBox_ShowTrueScript.TabIndex = 196;
            this.Outros_CheckBox_ShowTrueScript.Text = "Show True Script";
            this.Outros_CheckBox_ShowTrueScript.UseVisualStyleBackColor = true;
            this.Outros_CheckBox_ShowTrueScript.CheckedChanged += new System.EventHandler(this.Test_CheckBox_ShowVarOnScript_CheckedChanged);
            // 
            // Outros_Button_Logs
            // 
            this.Outros_Button_Logs.AutoSize = true;
            this.Outros_Button_Logs.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_Button_Logs.Location = new System.Drawing.Point(11, 12);
            this.Outros_Button_Logs.Name = "Outros_Button_Logs";
            this.Outros_Button_Logs.Size = new System.Drawing.Size(120, 48);
            this.Outros_Button_Logs.TabIndex = 195;
            this.Outros_Button_Logs.Text = "Logs";
            this.Outros_Button_Logs.UseVisualStyleBackColor = true;
            this.Outros_Button_Logs.Click += new System.EventHandler(this.SelectRouter_LogButton_Click);
            // 
            // Outros_Button_ApplyTestValues
            // 
            this.Outros_Button_ApplyTestValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_Button_ApplyTestValues.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_Button_ApplyTestValues.Location = new System.Drawing.Point(1001, 90);
            this.Outros_Button_ApplyTestValues.Name = "Outros_Button_ApplyTestValues";
            this.Outros_Button_ApplyTestValues.Size = new System.Drawing.Size(84, 47);
            this.Outros_Button_ApplyTestValues.TabIndex = 194;
            this.Outros_Button_ApplyTestValues.Text = "Apply Test Values";
            this.Outros_Button_ApplyTestValues.UseVisualStyleBackColor = true;
            this.Outros_Button_ApplyTestValues.Click += new System.EventHandler(this.Button_ApplyTestValues_Click);
            // 
            // Outros_TypeLabel
            // 
            this.Outros_TypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_TypeLabel.AutoSize = true;
            this.Outros_TypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_TypeLabel.Location = new System.Drawing.Point(641, 113);
            this.Outros_TypeLabel.Name = "Outros_TypeLabel";
            this.Outros_TypeLabel.Size = new System.Drawing.Size(93, 21);
            this.Outros_TypeLabel.TabIndex = 145;
            this.Outros_TypeLabel.Text = "Fabricante: ";
            // 
            // Outros_TypeComboBox
            // 
            this.Outros_TypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_TypeComboBox.FormattingEnabled = true;
            this.Outros_TypeComboBox.Items.AddRange(new object[] {
            "Cisco",
            "HPE",
            "Huawei",
            "Fortigate",
            "Aligera",
            "Digistar"});
            this.Outros_TypeComboBox.Location = new System.Drawing.Point(735, 113);
            this.Outros_TypeComboBox.Name = "Outros_TypeComboBox";
            this.Outros_TypeComboBox.Size = new System.Drawing.Size(110, 27);
            this.Outros_TypeComboBox.TabIndex = 144;
            this.Outros_TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.Outros_TypeComboBox_SelectedIndexChanged);
            // 
            // Outros_ButtonForCopy
            // 
            this.Outros_ButtonForCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_ButtonForCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_ButtonForCopy.Location = new System.Drawing.Point(639, 143);
            this.Outros_ButtonForCopy.Name = "Outros_ButtonForCopy";
            this.Outros_ButtonForCopy.Size = new System.Drawing.Size(90, 47);
            this.Outros_ButtonForCopy.TabIndex = 137;
            this.Outros_ButtonForCopy.Text = "Copiar e Formatar";
            this.Outros_ButtonForCopy.UseVisualStyleBackColor = true;
            this.Outros_ButtonForCopy.Click += new System.EventHandler(this.Outros_ButtonForCopy_Click);
            // 
            // Outros_ButtonCopy
            // 
            this.Outros_ButtonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_ButtonCopy.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.Outros_ButtonCopy.Location = new System.Drawing.Point(639, 256);
            this.Outros_ButtonCopy.Name = "Outros_ButtonCopy";
            this.Outros_ButtonCopy.Size = new System.Drawing.Size(90, 47);
            this.Outros_ButtonCopy.TabIndex = 131;
            this.Outros_ButtonCopy.Text = "Copiar";
            this.Outros_ButtonCopy.UseVisualStyleBackColor = true;
            this.Outros_ButtonCopy.Click += new System.EventHandler(this.Outros_ButtonCopy_Click);
            // 
            // Outros_ButtonFormat
            // 
            this.Outros_ButtonFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_ButtonFormat.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.Outros_ButtonFormat.Location = new System.Drawing.Point(639, 199);
            this.Outros_ButtonFormat.Name = "Outros_ButtonFormat";
            this.Outros_ButtonFormat.Size = new System.Drawing.Size(90, 47);
            this.Outros_ButtonFormat.TabIndex = 130;
            this.Outros_ButtonFormat.Text = "Formatar";
            this.Outros_ButtonFormat.UseVisualStyleBackColor = true;
            this.Outros_ButtonFormat.Click += new System.EventHandler(this.Outros_ButtonFormat_Click);
            // 
            // HomeButton_Outros
            // 
            this.HomeButton_Outros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton_Outros.AutoSize = true;
            this.HomeButton_Outros.BackColor = System.Drawing.SystemColors.Highlight;
            this.HomeButton_Outros.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton_Outros.ForeColor = System.Drawing.Color.White;
            this.HomeButton_Outros.Location = new System.Drawing.Point(992, 15);
            this.HomeButton_Outros.MaximumSize = new System.Drawing.Size(208, 86);
            this.HomeButton_Outros.Name = "HomeButton_Outros";
            this.HomeButton_Outros.Size = new System.Drawing.Size(104, 43);
            this.HomeButton_Outros.TabIndex = 119;
            this.HomeButton_Outros.Text = "Home";
            this.HomeButton_Outros.UseVisualStyleBackColor = false;
            this.HomeButton_Outros.Click += new System.EventHandler(this.HomeButton_Outros_Click);
            // 
            // Outros_Script_Title
            // 
            this.Outros_Script_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_Script_Title.AutoSize = true;
            this.Outros_Script_Title.Font = new System.Drawing.Font("Segoe UI", 16.75F, System.Drawing.FontStyle.Bold);
            this.Outros_Script_Title.Location = new System.Drawing.Point(868, 89);
            this.Outros_Script_Title.Name = "Outros_Script_Title";
            this.Outros_Script_Title.Size = new System.Drawing.Size(77, 31);
            this.Outros_Script_Title.TabIndex = 118;
            this.Outros_Script_Title.Text = "Script";
            // 
            // Outros_FinalTextBox
            // 
            this.Outros_FinalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_FinalTextBox.Location = new System.Drawing.Point(735, 144);
            this.Outros_FinalTextBox.Name = "Outros_FinalTextBox";
            this.Outros_FinalTextBox.Size = new System.Drawing.Size(350, 349);
            this.Outros_FinalTextBox.TabIndex = 1;
            this.Outros_FinalTextBox.Text = "";
            this.Outros_FinalTextBox.WordWrap = false;
            // 
            // Outros_Title
            // 
            this.Outros_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_Title.Font = new System.Drawing.Font("Segoe UI", 22.75F, System.Drawing.FontStyle.Bold);
            this.Outros_Title.Location = new System.Drawing.Point(6, 10);
            this.Outros_Title.Name = "Outros_Title";
            this.Outros_Title.Size = new System.Drawing.Size(1100, 42);
            this.Outros_Title.TabIndex = 0;
            this.Outros_Title.Text = "Titulo";
            this.Outros_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabSubOutros
            // 
            this.TabSubOutros.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabSubOutros.Controls.Add(this.Outros_TabQoS);
            this.TabSubOutros.Controls.Add(this.Outros_TabSNMP);
            this.TabSubOutros.Controls.Add(this.Outros_TabRegraAdc);
            this.TabSubOutros.Controls.Add(this.Outros_TabBGP);
            this.TabSubOutros.Controls.Add(this.Outros_TabDHCP);
            this.TabSubOutros.Controls.Add(this.Outros_TabVlan);
            this.TabSubOutros.Controls.Add(this.Outros_TabUSUARIOS);
            this.TabSubOutros.Controls.Add(this.Outros_Tab_FortiVlan);
            this.TabSubOutros.Controls.Add(this.Outros_TabFortiExtras);
            this.TabSubOutros.Controls.Add(this.Outros_TabIPFLow);
            this.TabSubOutros.Controls.Add(this.Outros_TabRIP);
            this.TabSubOutros.Controls.Add(this.Outros_TabOSPF);
            this.TabSubOutros.Controls.Add(this.Outros_TabVRRP);
            this.TabSubOutros.Controls.Add(this.Outros_TabGLBP);
            this.TabSubOutros.Controls.Add(this.Outros_TabEIGRP);
            this.TabSubOutros.Controls.Add(this.Outros_TabHotline);
            this.TabSubOutros.Controls.Add(this.Outros_Tab_HSRP);
            this.TabSubOutros.Controls.Add(this.Outros_TabPortBlock);
            this.TabSubOutros.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabSubOutros.ItemSize = new System.Drawing.Size(0, 1);
            this.TabSubOutros.Location = new System.Drawing.Point(-7, 74);
            this.TabSubOutros.Multiline = true;
            this.TabSubOutros.Name = "TabSubOutros";
            this.TabSubOutros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabSubOutros.SelectedIndex = 0;
            this.TabSubOutros.Size = new System.Drawing.Size(637, 445);
            this.TabSubOutros.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabSubOutros.TabIndex = 0;
            // 
            // Outros_TabQoS
            // 
            this.Outros_TabQoS.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabQoS.Controls.Add(this.Outros_VarDeleteCalc);
            this.Outros_TabQoS.Controls.Add(this.Outros_QoS_CiscoCheckBox);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarDeleteQoS8);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarDeleteQoS7);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarDeleteQoS3);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarDeleteQoS2);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarDeleteQoS4);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarDeleteQoS1);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarDeleteQoS0);
            this.Outros_TabQoS.Controls.Add(this.Outros_QoSCalcLabel);
            this.Outros_TabQoS.Controls.Add(this.Outros_QoS_ClearButton);
            this.Outros_TabQoS.Controls.Add(this.Outros_QoS_Guide);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextPercQoS03);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextPercQoS06);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextPercQoS05);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextPercQoS02);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextPercQoS04);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextPercQoS01);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextPercQoS00);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextQoS03);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarNameQoS3);
            this.Outros_TabQoS.Controls.Add(this.Outros_QoSDispTotal);
            this.Outros_TabQoS.Controls.Add(this.Outros_QoSCalcEx);
            this.Outros_TabQoS.Controls.Add(this.Outros_QoSCalcText);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextQoS08);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarNameQoS8);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextQoS07);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarNameQoS7);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarDeleteQoS6);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextQoS06);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarNameQoS6);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarDeleteQoS5);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextQoS05);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextQoS02);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextQoS04);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextQoS01);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarNameQoS2);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarNameQoS5);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarNameQoS4);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarNameQoS1);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarNameQoS0);
            this.Outros_TabQoS.Controls.Add(this.Outros_VarTextQoS00);
            this.Outros_TabQoS.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabQoS.Name = "Outros_TabQoS";
            this.Outros_TabQoS.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabQoS.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabQoS.TabIndex = 1;
            this.Outros_TabQoS.Text = "QoS";
            // 
            // Outros_VarDeleteCalc
            // 
            this.Outros_VarDeleteCalc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarDeleteCalc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarDeleteCalc.Location = new System.Drawing.Point(580, 45);
            this.Outros_VarDeleteCalc.Name = "Outros_VarDeleteCalc";
            this.Outros_VarDeleteCalc.Size = new System.Drawing.Size(20, 25);
            this.Outros_VarDeleteCalc.TabIndex = 239;
            this.Outros_VarDeleteCalc.Text = "-";
            this.Outros_VarDeleteCalc.UseVisualStyleBackColor = true;
            this.Outros_VarDeleteCalc.Click += new System.EventHandler(this.Outros_VarDeleteCalc_Click);
            // 
            // Outros_QoS_CiscoCheckBox
            // 
            this.Outros_QoS_CiscoCheckBox.AutoSize = true;
            this.Outros_QoS_CiscoCheckBox.Location = new System.Drawing.Point(249, 47);
            this.Outros_QoS_CiscoCheckBox.Name = "Outros_QoS_CiscoCheckBox";
            this.Outros_QoS_CiscoCheckBox.Size = new System.Drawing.Size(100, 23);
            this.Outros_QoS_CiscoCheckBox.TabIndex = 238;
            this.Outros_QoS_CiscoCheckBox.Text = "Cisco Novo";
            this.Outros_QoS_CiscoCheckBox.UseVisualStyleBackColor = true;
            // 
            // Outros_VarDeleteQoS8
            // 
            this.Outros_VarDeleteQoS8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarDeleteQoS8.Location = new System.Drawing.Point(579, 319);
            this.Outros_VarDeleteQoS8.Name = "Outros_VarDeleteQoS8";
            this.Outros_VarDeleteQoS8.Size = new System.Drawing.Size(20, 25);
            this.Outros_VarDeleteQoS8.TabIndex = 237;
            this.Outros_VarDeleteQoS8.Text = "-";
            this.Outros_VarDeleteQoS8.UseVisualStyleBackColor = true;
            this.Outros_VarDeleteQoS8.Click += new System.EventHandler(this.Outros_VarDeleteQoS8_Click);
            // 
            // Outros_VarDeleteQoS7
            // 
            this.Outros_VarDeleteQoS7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarDeleteQoS7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarDeleteQoS7.Location = new System.Drawing.Point(579, 288);
            this.Outros_VarDeleteQoS7.Name = "Outros_VarDeleteQoS7";
            this.Outros_VarDeleteQoS7.Size = new System.Drawing.Size(20, 25);
            this.Outros_VarDeleteQoS7.TabIndex = 236;
            this.Outros_VarDeleteQoS7.Text = "-";
            this.Outros_VarDeleteQoS7.UseVisualStyleBackColor = true;
            this.Outros_VarDeleteQoS7.Click += new System.EventHandler(this.Outros_VarDeleteQoS7_Click);
            // 
            // Outros_VarDeleteQoS3
            // 
            this.Outros_VarDeleteQoS3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarDeleteQoS3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarDeleteQoS3.Location = new System.Drawing.Point(580, 164);
            this.Outros_VarDeleteQoS3.Name = "Outros_VarDeleteQoS3";
            this.Outros_VarDeleteQoS3.Size = new System.Drawing.Size(20, 25);
            this.Outros_VarDeleteQoS3.TabIndex = 235;
            this.Outros_VarDeleteQoS3.Text = "-";
            this.Outros_VarDeleteQoS3.UseVisualStyleBackColor = true;
            this.Outros_VarDeleteQoS3.Click += new System.EventHandler(this.Outros_VarDeleteQoS3_Click);
            // 
            // Outros_VarDeleteQoS2
            // 
            this.Outros_VarDeleteQoS2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarDeleteQoS2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarDeleteQoS2.Location = new System.Drawing.Point(580, 136);
            this.Outros_VarDeleteQoS2.Name = "Outros_VarDeleteQoS2";
            this.Outros_VarDeleteQoS2.Size = new System.Drawing.Size(20, 25);
            this.Outros_VarDeleteQoS2.TabIndex = 234;
            this.Outros_VarDeleteQoS2.Text = "-";
            this.Outros_VarDeleteQoS2.UseVisualStyleBackColor = true;
            this.Outros_VarDeleteQoS2.Click += new System.EventHandler(this.Outros_VarDeleteQoS2_Click);
            // 
            // Outros_VarDeleteQoS4
            // 
            this.Outros_VarDeleteQoS4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarDeleteQoS4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarDeleteQoS4.Location = new System.Drawing.Point(580, 197);
            this.Outros_VarDeleteQoS4.Name = "Outros_VarDeleteQoS4";
            this.Outros_VarDeleteQoS4.Size = new System.Drawing.Size(20, 25);
            this.Outros_VarDeleteQoS4.TabIndex = 233;
            this.Outros_VarDeleteQoS4.Text = "-";
            this.Outros_VarDeleteQoS4.UseVisualStyleBackColor = true;
            this.Outros_VarDeleteQoS4.Click += new System.EventHandler(this.Outros_VarDeleteQoS4_Click);
            // 
            // Outros_VarDeleteQoS1
            // 
            this.Outros_VarDeleteQoS1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarDeleteQoS1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarDeleteQoS1.Location = new System.Drawing.Point(580, 105);
            this.Outros_VarDeleteQoS1.Name = "Outros_VarDeleteQoS1";
            this.Outros_VarDeleteQoS1.Size = new System.Drawing.Size(20, 25);
            this.Outros_VarDeleteQoS1.TabIndex = 232;
            this.Outros_VarDeleteQoS1.Text = "-";
            this.Outros_VarDeleteQoS1.UseVisualStyleBackColor = true;
            this.Outros_VarDeleteQoS1.Click += new System.EventHandler(this.Outros_VarDeleteQoS1_Click);
            // 
            // Outros_VarDeleteQoS0
            // 
            this.Outros_VarDeleteQoS0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarDeleteQoS0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarDeleteQoS0.Location = new System.Drawing.Point(580, 74);
            this.Outros_VarDeleteQoS0.Name = "Outros_VarDeleteQoS0";
            this.Outros_VarDeleteQoS0.Size = new System.Drawing.Size(20, 25);
            this.Outros_VarDeleteQoS0.TabIndex = 231;
            this.Outros_VarDeleteQoS0.Text = "-";
            this.Outros_VarDeleteQoS0.UseVisualStyleBackColor = true;
            this.Outros_VarDeleteQoS0.Click += new System.EventHandler(this.Outros_VarDeleteQoS0_Click);
            // 
            // Outros_QoSCalcLabel
            // 
            this.Outros_QoSCalcLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_QoSCalcLabel.AutoSize = true;
            this.Outros_QoSCalcLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_QoSCalcLabel.Location = new System.Drawing.Point(355, 49);
            this.Outros_QoSCalcLabel.Name = "Outros_QoSCalcLabel";
            this.Outros_QoSCalcLabel.Size = new System.Drawing.Size(103, 17);
            this.Outros_QoSCalcLabel.TabIndex = 230;
            this.Outros_QoSCalcLabel.Text = "Bandwidth Total:";
            // 
            // Outros_QoS_ClearButton
            // 
            this.Outros_QoS_ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_QoS_ClearButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_QoS_ClearButton.Location = new System.Drawing.Point(521, 13);
            this.Outros_QoS_ClearButton.Name = "Outros_QoS_ClearButton";
            this.Outros_QoS_ClearButton.Size = new System.Drawing.Size(100, 26);
            this.Outros_QoS_ClearButton.TabIndex = 229;
            this.Outros_QoS_ClearButton.Text = "Limpar";
            this.Outros_QoS_ClearButton.UseVisualStyleBackColor = true;
            this.Outros_QoS_ClearButton.Click += new System.EventHandler(this.Outros_QoS_ClearButton_Click);
            // 
            // Outros_QoS_Guide
            // 
            this.Outros_QoS_Guide.AutoSize = true;
            this.Outros_QoS_Guide.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outros_QoS_Guide.Location = new System.Drawing.Point(16, 41);
            this.Outros_QoS_Guide.Name = "Outros_QoS_Guide";
            this.Outros_QoS_Guide.Size = new System.Drawing.Size(74, 20);
            this.Outros_QoS_Guide.TabIndex = 228;
            this.Outros_QoS_Guide.Text = "Guia aqui";
            // 
            // Outros_VarTextPercQoS03
            // 
            this.Outros_VarTextPercQoS03.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextPercQoS03.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextPercQoS03.Location = new System.Drawing.Point(462, 166);
            this.Outros_VarTextPercQoS03.Name = "Outros_VarTextPercQoS03";
            this.Outros_VarTextPercQoS03.Size = new System.Drawing.Size(33, 25);
            this.Outros_VarTextPercQoS03.TabIndex = 225;
            // 
            // Outros_VarTextPercQoS06
            // 
            this.Outros_VarTextPercQoS06.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextPercQoS06.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextPercQoS06.Location = new System.Drawing.Point(462, 258);
            this.Outros_VarTextPercQoS06.Name = "Outros_VarTextPercQoS06";
            this.Outros_VarTextPercQoS06.Size = new System.Drawing.Size(33, 25);
            this.Outros_VarTextPercQoS06.TabIndex = 224;
            // 
            // Outros_VarTextPercQoS05
            // 
            this.Outros_VarTextPercQoS05.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextPercQoS05.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextPercQoS05.Location = new System.Drawing.Point(462, 227);
            this.Outros_VarTextPercQoS05.Name = "Outros_VarTextPercQoS05";
            this.Outros_VarTextPercQoS05.Size = new System.Drawing.Size(33, 25);
            this.Outros_VarTextPercQoS05.TabIndex = 223;
            // 
            // Outros_VarTextPercQoS02
            // 
            this.Outros_VarTextPercQoS02.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextPercQoS02.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextPercQoS02.Location = new System.Drawing.Point(462, 136);
            this.Outros_VarTextPercQoS02.Name = "Outros_VarTextPercQoS02";
            this.Outros_VarTextPercQoS02.Size = new System.Drawing.Size(33, 25);
            this.Outros_VarTextPercQoS02.TabIndex = 222;
            // 
            // Outros_VarTextPercQoS04
            // 
            this.Outros_VarTextPercQoS04.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextPercQoS04.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextPercQoS04.Location = new System.Drawing.Point(462, 197);
            this.Outros_VarTextPercQoS04.Name = "Outros_VarTextPercQoS04";
            this.Outros_VarTextPercQoS04.Size = new System.Drawing.Size(33, 25);
            this.Outros_VarTextPercQoS04.TabIndex = 221;
            // 
            // Outros_VarTextPercQoS01
            // 
            this.Outros_VarTextPercQoS01.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextPercQoS01.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextPercQoS01.Location = new System.Drawing.Point(462, 105);
            this.Outros_VarTextPercQoS01.Name = "Outros_VarTextPercQoS01";
            this.Outros_VarTextPercQoS01.Size = new System.Drawing.Size(33, 25);
            this.Outros_VarTextPercQoS01.TabIndex = 220;
            // 
            // Outros_VarTextPercQoS00
            // 
            this.Outros_VarTextPercQoS00.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextPercQoS00.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextPercQoS00.Location = new System.Drawing.Point(462, 75);
            this.Outros_VarTextPercQoS00.Name = "Outros_VarTextPercQoS00";
            this.Outros_VarTextPercQoS00.Size = new System.Drawing.Size(33, 25);
            this.Outros_VarTextPercQoS00.TabIndex = 219;
            // 
            // Outros_VarTextQoS03
            // 
            this.Outros_VarTextQoS03.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextQoS03.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextQoS03.Location = new System.Drawing.Point(499, 166);
            this.Outros_VarTextQoS03.Name = "Outros_VarTextQoS03";
            this.Outros_VarTextQoS03.Size = new System.Drawing.Size(75, 25);
            this.Outros_VarTextQoS03.TabIndex = 218;
            // 
            // Outros_VarNameQoS3
            // 
            this.Outros_VarNameQoS3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarNameQoS3.AutoSize = true;
            this.Outros_VarNameQoS3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_VarNameQoS3.Location = new System.Drawing.Point(375, 170);
            this.Outros_VarNameQoS3.Name = "Outros_VarNameQoS3";
            this.Outros_VarNameQoS3.Size = new System.Drawing.Size(61, 17);
            this.Outros_VarNameQoS3.TabIndex = 217;
            this.Outros_VarNameQoS3.Text = "Interativa";
            // 
            // Outros_QoSDispTotal
            // 
            this.Outros_QoSDispTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_QoSDispTotal.AutoSize = true;
            this.Outros_QoSDispTotal.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.Outros_QoSDispTotal.Location = new System.Drawing.Point(259, 142);
            this.Outros_QoSDispTotal.Name = "Outros_QoSDispTotal";
            this.Outros_QoSDispTotal.Size = new System.Drawing.Size(95, 23);
            this.Outros_QoSDispTotal.TabIndex = 216;
            this.Outros_QoSDispTotal.Text = "TOTAL aqui";
            // 
            // Outros_QoSCalcEx
            // 
            this.Outros_QoSCalcEx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_QoSCalcEx.AutoSize = true;
            this.Outros_QoSCalcEx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_QoSCalcEx.Location = new System.Drawing.Point(463, 27);
            this.Outros_QoSCalcEx.Name = "Outros_QoSCalcEx";
            this.Outros_QoSCalcEx.Size = new System.Drawing.Size(54, 15);
            this.Outros_QoSCalcEx.TabIndex = 215;
            this.Outros_QoSCalcEx.Text = "Ex: 50000";
            // 
            // Outros_QoSCalcText
            // 
            this.Outros_QoSCalcText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_QoSCalcText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_QoSCalcText.Location = new System.Drawing.Point(462, 45);
            this.Outros_QoSCalcText.Name = "Outros_QoSCalcText";
            this.Outros_QoSCalcText.Size = new System.Drawing.Size(112, 25);
            this.Outros_QoSCalcText.TabIndex = 214;
            // 
            // Outros_VarTextQoS08
            // 
            this.Outros_VarTextQoS08.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextQoS08.Location = new System.Drawing.Point(438, 319);
            this.Outros_VarTextQoS08.Name = "Outros_VarTextQoS08";
            this.Outros_VarTextQoS08.Size = new System.Drawing.Size(136, 25);
            this.Outros_VarTextQoS08.TabIndex = 213;
            // 
            // Outros_VarNameQoS8
            // 
            this.Outros_VarNameQoS8.AutoSize = true;
            this.Outros_VarNameQoS8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_VarNameQoS8.Location = new System.Drawing.Point(356, 324);
            this.Outros_VarNameQoS8.Name = "Outros_VarNameQoS8";
            this.Outros_VarNameQoS8.Size = new System.Drawing.Size(67, 17);
            this.Outros_VarNameQoS8.TabIndex = 212;
            this.Outros_VarNameQoS8.Text = "Porta LAN";
            // 
            // Outros_VarTextQoS07
            // 
            this.Outros_VarTextQoS07.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextQoS07.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextQoS07.Location = new System.Drawing.Point(438, 288);
            this.Outros_VarTextQoS07.Name = "Outros_VarTextQoS07";
            this.Outros_VarTextQoS07.Size = new System.Drawing.Size(136, 25);
            this.Outros_VarTextQoS07.TabIndex = 211;
            // 
            // Outros_VarNameQoS7
            // 
            this.Outros_VarNameQoS7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarNameQoS7.AutoSize = true;
            this.Outros_VarNameQoS7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_VarNameQoS7.Location = new System.Drawing.Point(356, 293);
            this.Outros_VarNameQoS7.Name = "Outros_VarNameQoS7";
            this.Outros_VarNameQoS7.Size = new System.Drawing.Size(72, 17);
            this.Outros_VarNameQoS7.TabIndex = 210;
            this.Outros_VarNameQoS7.Text = "Porta WAN";
            // 
            // Outros_VarDeleteQoS6
            // 
            this.Outros_VarDeleteQoS6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarDeleteQoS6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarDeleteQoS6.Location = new System.Drawing.Point(580, 259);
            this.Outros_VarDeleteQoS6.Name = "Outros_VarDeleteQoS6";
            this.Outros_VarDeleteQoS6.Size = new System.Drawing.Size(20, 25);
            this.Outros_VarDeleteQoS6.TabIndex = 209;
            this.Outros_VarDeleteQoS6.Text = "-";
            this.Outros_VarDeleteQoS6.UseVisualStyleBackColor = true;
            this.Outros_VarDeleteQoS6.Click += new System.EventHandler(this.Outros_VarDeleteQoS6_Click);
            // 
            // Outros_VarTextQoS06
            // 
            this.Outros_VarTextQoS06.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextQoS06.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextQoS06.Location = new System.Drawing.Point(499, 258);
            this.Outros_VarTextQoS06.Name = "Outros_VarTextQoS06";
            this.Outros_VarTextQoS06.Size = new System.Drawing.Size(75, 25);
            this.Outros_VarTextQoS06.TabIndex = 208;
            // 
            // Outros_VarNameQoS6
            // 
            this.Outros_VarNameQoS6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarNameQoS6.AutoSize = true;
            this.Outros_VarNameQoS6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_VarNameQoS6.Location = new System.Drawing.Point(374, 262);
            this.Outros_VarNameQoS6.Name = "Outros_VarNameQoS6";
            this.Outros_VarNameQoS6.Size = new System.Drawing.Size(68, 17);
            this.Outros_VarNameQoS6.TabIndex = 207;
            this.Outros_VarNameQoS6.Text = "Best Effort";
            // 
            // Outros_VarDeleteQoS5
            // 
            this.Outros_VarDeleteQoS5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarDeleteQoS5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarDeleteQoS5.Location = new System.Drawing.Point(580, 228);
            this.Outros_VarDeleteQoS5.Name = "Outros_VarDeleteQoS5";
            this.Outros_VarDeleteQoS5.Size = new System.Drawing.Size(20, 25);
            this.Outros_VarDeleteQoS5.TabIndex = 206;
            this.Outros_VarDeleteQoS5.Text = "-";
            this.Outros_VarDeleteQoS5.UseVisualStyleBackColor = true;
            this.Outros_VarDeleteQoS5.Click += new System.EventHandler(this.Outros_VarDeleteQoS5_Click);
            // 
            // Outros_VarTextQoS05
            // 
            this.Outros_VarTextQoS05.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextQoS05.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextQoS05.Location = new System.Drawing.Point(499, 227);
            this.Outros_VarTextQoS05.Name = "Outros_VarTextQoS05";
            this.Outros_VarTextQoS05.Size = new System.Drawing.Size(75, 25);
            this.Outros_VarTextQoS05.TabIndex = 205;
            // 
            // Outros_VarTextQoS02
            // 
            this.Outros_VarTextQoS02.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextQoS02.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextQoS02.Location = new System.Drawing.Point(499, 136);
            this.Outros_VarTextQoS02.Name = "Outros_VarTextQoS02";
            this.Outros_VarTextQoS02.Size = new System.Drawing.Size(75, 25);
            this.Outros_VarTextQoS02.TabIndex = 204;
            // 
            // Outros_VarTextQoS04
            // 
            this.Outros_VarTextQoS04.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextQoS04.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextQoS04.Location = new System.Drawing.Point(499, 197);
            this.Outros_VarTextQoS04.Name = "Outros_VarTextQoS04";
            this.Outros_VarTextQoS04.Size = new System.Drawing.Size(75, 25);
            this.Outros_VarTextQoS04.TabIndex = 203;
            // 
            // Outros_VarTextQoS01
            // 
            this.Outros_VarTextQoS01.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextQoS01.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextQoS01.Location = new System.Drawing.Point(499, 105);
            this.Outros_VarTextQoS01.Name = "Outros_VarTextQoS01";
            this.Outros_VarTextQoS01.Size = new System.Drawing.Size(75, 25);
            this.Outros_VarTextQoS01.TabIndex = 202;
            // 
            // Outros_VarNameQoS2
            // 
            this.Outros_VarNameQoS2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarNameQoS2.AutoSize = true;
            this.Outros_VarNameQoS2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_VarNameQoS2.Location = new System.Drawing.Point(364, 139);
            this.Outros_VarNameQoS2.Name = "Outros_VarNameQoS2";
            this.Outros_VarNameQoS2.Size = new System.Drawing.Size(90, 17);
            this.Outros_VarNameQoS2.TabIndex = 201;
            this.Outros_VarNameQoS2.Text = "Missao Critica";
            // 
            // Outros_VarNameQoS5
            // 
            this.Outros_VarNameQoS5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarNameQoS5.AutoSize = true;
            this.Outros_VarNameQoS5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_VarNameQoS5.Location = new System.Drawing.Point(359, 231);
            this.Outros_VarNameQoS5.Name = "Outros_VarNameQoS5";
            this.Outros_VarNameQoS5.Size = new System.Drawing.Size(104, 17);
            this.Outros_VarNameQoS5.TabIndex = 200;
            this.Outros_VarNameQoS5.Text = "Network Control";
            // 
            // Outros_VarNameQoS4
            // 
            this.Outros_VarNameQoS4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarNameQoS4.AutoSize = true;
            this.Outros_VarNameQoS4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_VarNameQoS4.Location = new System.Drawing.Point(389, 201);
            this.Outros_VarNameQoS4.Name = "Outros_VarNameQoS4";
            this.Outros_VarNameQoS4.Size = new System.Drawing.Size(31, 17);
            this.Outros_VarNameQoS4.TabIndex = 199;
            this.Outros_VarNameQoS4.Text = "Bulk";
            // 
            // Outros_VarNameQoS1
            // 
            this.Outros_VarNameQoS1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarNameQoS1.AutoSize = true;
            this.Outros_VarNameQoS1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_VarNameQoS1.Location = new System.Drawing.Point(385, 108);
            this.Outros_VarNameQoS1.Name = "Outros_VarNameQoS1";
            this.Outros_VarNameQoS1.Size = new System.Drawing.Size(42, 17);
            this.Outros_VarNameQoS1.TabIndex = 198;
            this.Outros_VarNameQoS1.Text = "Video";
            // 
            // Outros_VarNameQoS0
            // 
            this.Outros_VarNameQoS0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarNameQoS0.AutoSize = true;
            this.Outros_VarNameQoS0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarNameQoS0.Location = new System.Drawing.Point(392, 77);
            this.Outros_VarNameQoS0.Name = "Outros_VarNameQoS0";
            this.Outros_VarNameQoS0.Size = new System.Drawing.Size(29, 17);
            this.Outros_VarNameQoS0.TabIndex = 197;
            this.Outros_VarNameQoS0.Text = "Voz";
            // 
            // Outros_VarTextQoS00
            // 
            this.Outros_VarTextQoS00.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VarTextQoS00.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VarTextQoS00.Location = new System.Drawing.Point(499, 75);
            this.Outros_VarTextQoS00.Name = "Outros_VarTextQoS00";
            this.Outros_VarTextQoS00.Size = new System.Drawing.Size(75, 25);
            this.Outros_VarTextQoS00.TabIndex = 196;
            // 
            // Outros_TabSNMP
            // 
            this.Outros_TabSNMP.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_VarLabel2);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_VarPrivComboBox);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_ExLabel2);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_VarDelete1);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_ExTitle);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_ExLabel1);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_ExLabel0);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_VarDelete0);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_ClearButton);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_VarText1);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_VarLabel1);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_VarLabel0);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_VarText0);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_Guide);
            this.Outros_TabSNMP.Controls.Add(this.Outros_SNMP_VarTitle);
            this.Outros_TabSNMP.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabSNMP.Name = "Outros_TabSNMP";
            this.Outros_TabSNMP.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabSNMP.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabSNMP.TabIndex = 0;
            this.Outros_TabSNMP.Text = "SNMP";
            // 
            // Outros_SNMP_VarLabel2
            // 
            this.Outros_SNMP_VarLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_SNMP_VarLabel2.AutoSize = true;
            this.Outros_SNMP_VarLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_VarLabel2.Location = new System.Drawing.Point(273, 134);
            this.Outros_SNMP_VarLabel2.Name = "Outros_SNMP_VarLabel2";
            this.Outros_SNMP_VarLabel2.Size = new System.Drawing.Size(64, 17);
            this.Outros_SNMP_VarLabel2.TabIndex = 264;
            this.Outros_SNMP_VarLabel2.Text = "Privilégio:";
            // 
            // Outros_SNMP_VarPrivComboBox
            // 
            this.Outros_SNMP_VarPrivComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_SNMP_VarPrivComboBox.FormattingEnabled = true;
            this.Outros_SNMP_VarPrivComboBox.Items.AddRange(new object[] {
            "Leitura",
            "Escrita"});
            this.Outros_SNMP_VarPrivComboBox.Location = new System.Drawing.Point(372, 131);
            this.Outros_SNMP_VarPrivComboBox.Name = "Outros_SNMP_VarPrivComboBox";
            this.Outros_SNMP_VarPrivComboBox.Size = new System.Drawing.Size(129, 27);
            this.Outros_SNMP_VarPrivComboBox.TabIndex = 263;
            // 
            // Outros_SNMP_ExLabel2
            // 
            this.Outros_SNMP_ExLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_ExLabel2.AutoSize = true;
            this.Outros_SNMP_ExLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_ExLabel2.Location = new System.Drawing.Point(513, 135);
            this.Outros_SNMP_ExLabel2.Name = "Outros_SNMP_ExLabel2";
            this.Outros_SNMP_ExLabel2.Size = new System.Drawing.Size(97, 15);
            this.Outros_SNMP_ExLabel2.TabIndex = 262;
            this.Outros_SNMP_ExLabel2.Text = "Escrita ou Leitura";
            // 
            // Outros_SNMP_VarDelete1
            // 
            this.Outros_SNMP_VarDelete1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_VarDelete1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_VarDelete1.Location = new System.Drawing.Point(481, 100);
            this.Outros_SNMP_VarDelete1.Name = "Outros_SNMP_VarDelete1";
            this.Outros_SNMP_VarDelete1.Size = new System.Drawing.Size(20, 25);
            this.Outros_SNMP_VarDelete1.TabIndex = 228;
            this.Outros_SNMP_VarDelete1.Text = "-";
            this.Outros_SNMP_VarDelete1.UseVisualStyleBackColor = true;
            this.Outros_SNMP_VarDelete1.Click += new System.EventHandler(this.Outros_VarDelete1_Click_1);
            // 
            // Outros_SNMP_ExTitle
            // 
            this.Outros_SNMP_ExTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_ExTitle.AutoSize = true;
            this.Outros_SNMP_ExTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_ExTitle.Location = new System.Drawing.Point(513, 40);
            this.Outros_SNMP_ExTitle.Name = "Outros_SNMP_ExTitle";
            this.Outros_SNMP_ExTitle.Size = new System.Drawing.Size(77, 20);
            this.Outros_SNMP_ExTitle.TabIndex = 210;
            this.Outros_SNMP_ExTitle.Text = "Exemplos:";
            // 
            // Outros_SNMP_ExLabel1
            // 
            this.Outros_SNMP_ExLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_ExLabel1.AutoSize = true;
            this.Outros_SNMP_ExLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_ExLabel1.Location = new System.Drawing.Point(513, 106);
            this.Outros_SNMP_ExLabel1.Name = "Outros_SNMP_ExLabel1";
            this.Outros_SNMP_ExLabel1.Size = new System.Drawing.Size(64, 15);
            this.Outros_SNMP_ExLabel1.TabIndex = 206;
            this.Outros_SNMP_ExLabel1.Text = "192.168.1.1";
            // 
            // Outros_SNMP_ExLabel0
            // 
            this.Outros_SNMP_ExLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_ExLabel0.AutoSize = true;
            this.Outros_SNMP_ExLabel0.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_ExLabel0.Location = new System.Drawing.Point(513, 75);
            this.Outros_SNMP_ExLabel0.Name = "Outros_SNMP_ExLabel0";
            this.Outros_SNMP_ExLabel0.Size = new System.Drawing.Size(101, 15);
            this.Outros_SNMP_ExLabel0.TabIndex = 205;
            this.Outros_SNMP_ExLabel0.Text = "snmpComunity21";
            // 
            // Outros_SNMP_VarDelete0
            // 
            this.Outros_SNMP_VarDelete0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_VarDelete0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_VarDelete0.Location = new System.Drawing.Point(481, 70);
            this.Outros_SNMP_VarDelete0.Name = "Outros_SNMP_VarDelete0";
            this.Outros_SNMP_VarDelete0.Size = new System.Drawing.Size(20, 25);
            this.Outros_SNMP_VarDelete0.TabIndex = 204;
            this.Outros_SNMP_VarDelete0.Text = "-";
            this.Outros_SNMP_VarDelete0.UseVisualStyleBackColor = true;
            this.Outros_SNMP_VarDelete0.Click += new System.EventHandler(this.Outros_VarDelete0_Click_1);
            // 
            // Outros_SNMP_ClearButton
            // 
            this.Outros_SNMP_ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_ClearButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_ClearButton.Location = new System.Drawing.Point(423, 35);
            this.Outros_SNMP_ClearButton.Name = "Outros_SNMP_ClearButton";
            this.Outros_SNMP_ClearButton.Size = new System.Drawing.Size(79, 30);
            this.Outros_SNMP_ClearButton.TabIndex = 203;
            this.Outros_SNMP_ClearButton.Text = "Limpar";
            this.Outros_SNMP_ClearButton.UseVisualStyleBackColor = true;
            this.Outros_SNMP_ClearButton.Click += new System.EventHandler(this.Outros_VarDeleteAll_Click_1);
            // 
            // Outros_SNMP_VarText1
            // 
            this.Outros_SNMP_VarText1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_VarText1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_VarText1.Location = new System.Drawing.Point(372, 100);
            this.Outros_SNMP_VarText1.Name = "Outros_SNMP_VarText1";
            this.Outros_SNMP_VarText1.Size = new System.Drawing.Size(104, 25);
            this.Outros_SNMP_VarText1.TabIndex = 199;
            // 
            // Outros_SNMP_VarLabel1
            // 
            this.Outros_SNMP_VarLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_VarLabel1.AutoSize = true;
            this.Outros_SNMP_VarLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_SNMP_VarLabel1.Location = new System.Drawing.Point(273, 103);
            this.Outros_SNMP_VarLabel1.Name = "Outros_SNMP_VarLabel1";
            this.Outros_SNMP_VarLabel1.Size = new System.Drawing.Size(38, 17);
            this.Outros_SNMP_VarLabel1.TabIndex = 195;
            this.Outros_SNMP_VarLabel1.Text = "Host:";
            // 
            // Outros_SNMP_VarLabel0
            // 
            this.Outros_SNMP_VarLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_VarLabel0.AutoSize = true;
            this.Outros_SNMP_VarLabel0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_VarLabel0.Location = new System.Drawing.Point(273, 72);
            this.Outros_SNMP_VarLabel0.Name = "Outros_SNMP_VarLabel0";
            this.Outros_SNMP_VarLabel0.Size = new System.Drawing.Size(76, 17);
            this.Outros_SNMP_VarLabel0.TabIndex = 194;
            this.Outros_SNMP_VarLabel0.Text = "Community:";
            // 
            // Outros_SNMP_VarText0
            // 
            this.Outros_SNMP_VarText0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_VarText0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_VarText0.Location = new System.Drawing.Point(372, 70);
            this.Outros_SNMP_VarText0.Name = "Outros_SNMP_VarText0";
            this.Outros_SNMP_VarText0.Size = new System.Drawing.Size(104, 25);
            this.Outros_SNMP_VarText0.TabIndex = 193;
            // 
            // Outros_SNMP_Guide
            // 
            this.Outros_SNMP_Guide.AutoSize = true;
            this.Outros_SNMP_Guide.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outros_SNMP_Guide.Location = new System.Drawing.Point(12, 29);
            this.Outros_SNMP_Guide.Name = "Outros_SNMP_Guide";
            this.Outros_SNMP_Guide.Size = new System.Drawing.Size(74, 20);
            this.Outros_SNMP_Guide.TabIndex = 179;
            this.Outros_SNMP_Guide.Text = "Guia aqui";
            // 
            // Outros_SNMP_VarTitle
            // 
            this.Outros_SNMP_VarTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_SNMP_VarTitle.AutoSize = true;
            this.Outros_SNMP_VarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_SNMP_VarTitle.Location = new System.Drawing.Point(271, 33);
            this.Outros_SNMP_VarTitle.Name = "Outros_SNMP_VarTitle";
            this.Outros_SNMP_VarTitle.Size = new System.Drawing.Size(88, 25);
            this.Outros_SNMP_VarTitle.TabIndex = 128;
            this.Outros_SNMP_VarTitle.Text = "Variáveis";
            // 
            // Outros_TabRegraAdc
            // 
            this.Outros_TabRegraAdc.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_ExLabel4);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_DelButton4);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_Label4);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_VarText4);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_DelButton3);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_ExLabel3);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_VarText3);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_Label3);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_AligeraCheckBox);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_ISRCheckBox);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_NumDaRegraComboBox);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_Guide);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_DelButton2);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_DelButton1);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_ExTitle);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_ExLabel2);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_ExLabel1);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_ExLabel0);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_DelButton0);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_ClearButton);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_VarText2);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_VarText1);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_Label1);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_Label0);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_VarText0);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_VarTitle);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_NumRegraLabel);
            this.Outros_TabRegraAdc.Controls.Add(this.Outros_RegraAdc_Label2);
            this.Outros_TabRegraAdc.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabRegraAdc.Name = "Outros_TabRegraAdc";
            this.Outros_TabRegraAdc.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabRegraAdc.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabRegraAdc.TabIndex = 2;
            this.Outros_TabRegraAdc.Text = "Regras Adc";
            // 
            // Outros_RegraAdc_ExLabel4
            // 
            this.Outros_RegraAdc_ExLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_ExLabel4.AutoSize = true;
            this.Outros_RegraAdc_ExLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_ExLabel4.Location = new System.Drawing.Point(500, 221);
            this.Outros_RegraAdc_ExLabel4.Name = "Outros_RegraAdc_ExLabel4";
            this.Outros_RegraAdc_ExLabel4.Size = new System.Drawing.Size(19, 15);
            this.Outros_RegraAdc_ExLabel4.TabIndex = 261;
            this.Outros_RegraAdc_ExLabel4.Text = "51";
            // 
            // Outros_RegraAdc_DelButton4
            // 
            this.Outros_RegraAdc_DelButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_DelButton4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_DelButton4.Location = new System.Drawing.Point(467, 216);
            this.Outros_RegraAdc_DelButton4.Name = "Outros_RegraAdc_DelButton4";
            this.Outros_RegraAdc_DelButton4.Size = new System.Drawing.Size(20, 25);
            this.Outros_RegraAdc_DelButton4.TabIndex = 260;
            this.Outros_RegraAdc_DelButton4.Text = "-";
            this.Outros_RegraAdc_DelButton4.UseVisualStyleBackColor = true;
            this.Outros_RegraAdc_DelButton4.Click += new System.EventHandler(this.Outros_RegraAdc_DelButton4_Click);
            // 
            // Outros_RegraAdc_Label4
            // 
            this.Outros_RegraAdc_Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_Label4.AutoSize = true;
            this.Outros_RegraAdc_Label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_Label4.Location = new System.Drawing.Point(206, 219);
            this.Outros_RegraAdc_Label4.Name = "Outros_RegraAdc_Label4";
            this.Outros_RegraAdc_Label4.Size = new System.Drawing.Size(167, 17);
            this.Outros_RegraAdc_Label4.TabIndex = 259;
            this.Outros_RegraAdc_Label4.Text = "Nº Inicial Account (Digistar)";
            // 
            // Outros_RegraAdc_VarText4
            // 
            this.Outros_RegraAdc_VarText4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_VarText4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_VarText4.Location = new System.Drawing.Point(418, 216);
            this.Outros_RegraAdc_VarText4.Name = "Outros_RegraAdc_VarText4";
            this.Outros_RegraAdc_VarText4.Size = new System.Drawing.Size(44, 25);
            this.Outros_RegraAdc_VarText4.TabIndex = 258;
            // 
            // Outros_RegraAdc_DelButton3
            // 
            this.Outros_RegraAdc_DelButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_DelButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_DelButton3.Location = new System.Drawing.Point(467, 185);
            this.Outros_RegraAdc_DelButton3.Name = "Outros_RegraAdc_DelButton3";
            this.Outros_RegraAdc_DelButton3.Size = new System.Drawing.Size(20, 25);
            this.Outros_RegraAdc_DelButton3.TabIndex = 256;
            this.Outros_RegraAdc_DelButton3.Text = "-";
            this.Outros_RegraAdc_DelButton3.UseVisualStyleBackColor = true;
            this.Outros_RegraAdc_DelButton3.Click += new System.EventHandler(this.Outros_RegraAdc_DelButton3_Click);
            // 
            // Outros_RegraAdc_ExLabel3
            // 
            this.Outros_RegraAdc_ExLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_ExLabel3.AutoSize = true;
            this.Outros_RegraAdc_ExLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_ExLabel3.Location = new System.Drawing.Point(499, 193);
            this.Outros_RegraAdc_ExLabel3.Name = "Outros_RegraAdc_ExLabel3";
            this.Outros_RegraAdc_ExLabel3.Size = new System.Drawing.Size(39, 15);
            this.Outros_RegraAdc_ExLabel3.TabIndex = 255;
            this.Outros_RegraAdc_ExLabel3.Text = "0/1:15";
            // 
            // Outros_RegraAdc_VarText3
            // 
            this.Outros_RegraAdc_VarText3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_VarText3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_VarText3.Location = new System.Drawing.Point(333, 185);
            this.Outros_RegraAdc_VarText3.Name = "Outros_RegraAdc_VarText3";
            this.Outros_RegraAdc_VarText3.Size = new System.Drawing.Size(129, 25);
            this.Outros_RegraAdc_VarText3.TabIndex = 254;
            // 
            // Outros_RegraAdc_Label3
            // 
            this.Outros_RegraAdc_Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_Label3.AutoSize = true;
            this.Outros_RegraAdc_Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_Label3.Location = new System.Drawing.Point(206, 191);
            this.Outros_RegraAdc_Label3.Name = "Outros_RegraAdc_Label3";
            this.Outros_RegraAdc_Label3.Size = new System.Drawing.Size(67, 17);
            this.Outros_RegraAdc_Label3.TabIndex = 257;
            this.Outros_RegraAdc_Label3.Text = "Voice Port";
            // 
            // Outros_RegraAdc_AligeraCheckBox
            // 
            this.Outros_RegraAdc_AligeraCheckBox.AutoSize = true;
            this.Outros_RegraAdc_AligeraCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.45F, System.Drawing.FontStyle.Bold);
            this.Outros_RegraAdc_AligeraCheckBox.Location = new System.Drawing.Point(209, 259);
            this.Outros_RegraAdc_AligeraCheckBox.Name = "Outros_RegraAdc_AligeraCheckBox";
            this.Outros_RegraAdc_AligeraCheckBox.Size = new System.Drawing.Size(132, 21);
            this.Outros_RegraAdc_AligeraCheckBox.TabIndex = 253;
            this.Outros_RegraAdc_AligeraCheckBox.Text = "Aligera 1600/2000";
            this.Outros_RegraAdc_AligeraCheckBox.UseVisualStyleBackColor = true;
            // 
            // Outros_RegraAdc_ISRCheckBox
            // 
            this.Outros_RegraAdc_ISRCheckBox.AutoSize = true;
            this.Outros_RegraAdc_ISRCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.45F, System.Drawing.FontStyle.Bold);
            this.Outros_RegraAdc_ISRCheckBox.Location = new System.Drawing.Point(375, 259);
            this.Outros_RegraAdc_ISRCheckBox.Name = "Outros_RegraAdc_ISRCheckBox";
            this.Outros_RegraAdc_ISRCheckBox.Size = new System.Drawing.Size(81, 21);
            this.Outros_RegraAdc_ISRCheckBox.TabIndex = 252;
            this.Outros_RegraAdc_ISRCheckBox.Text = "Cisco ISR";
            this.Outros_RegraAdc_ISRCheckBox.UseVisualStyleBackColor = true;
            // 
            // Outros_RegraAdc_NumDaRegraComboBox
            // 
            this.Outros_RegraAdc_NumDaRegraComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_NumDaRegraComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_RegraAdc_NumDaRegraComboBox.FormattingEnabled = true;
            this.Outros_RegraAdc_NumDaRegraComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.Outros_RegraAdc_NumDaRegraComboBox.Location = new System.Drawing.Point(333, 63);
            this.Outros_RegraAdc_NumDaRegraComboBox.Name = "Outros_RegraAdc_NumDaRegraComboBox";
            this.Outros_RegraAdc_NumDaRegraComboBox.Size = new System.Drawing.Size(44, 25);
            this.Outros_RegraAdc_NumDaRegraComboBox.TabIndex = 250;
            // 
            // Outros_RegraAdc_Guide
            // 
            this.Outros_RegraAdc_Guide.AutoSize = true;
            this.Outros_RegraAdc_Guide.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outros_RegraAdc_Guide.Location = new System.Drawing.Point(12, 33);
            this.Outros_RegraAdc_Guide.Name = "Outros_RegraAdc_Guide";
            this.Outros_RegraAdc_Guide.Size = new System.Drawing.Size(74, 20);
            this.Outros_RegraAdc_Guide.TabIndex = 249;
            this.Outros_RegraAdc_Guide.Text = "Guia aqui";
            // 
            // Outros_RegraAdc_DelButton2
            // 
            this.Outros_RegraAdc_DelButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_DelButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_DelButton2.Location = new System.Drawing.Point(467, 154);
            this.Outros_RegraAdc_DelButton2.Name = "Outros_RegraAdc_DelButton2";
            this.Outros_RegraAdc_DelButton2.Size = new System.Drawing.Size(20, 25);
            this.Outros_RegraAdc_DelButton2.TabIndex = 248;
            this.Outros_RegraAdc_DelButton2.Text = "-";
            this.Outros_RegraAdc_DelButton2.UseVisualStyleBackColor = true;
            this.Outros_RegraAdc_DelButton2.Click += new System.EventHandler(this.Outros_RegraAdc_DelButton2_Click);
            // 
            // Outros_RegraAdc_DelButton1
            // 
            this.Outros_RegraAdc_DelButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_DelButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_DelButton1.Location = new System.Drawing.Point(467, 124);
            this.Outros_RegraAdc_DelButton1.Name = "Outros_RegraAdc_DelButton1";
            this.Outros_RegraAdc_DelButton1.Size = new System.Drawing.Size(20, 25);
            this.Outros_RegraAdc_DelButton1.TabIndex = 247;
            this.Outros_RegraAdc_DelButton1.Text = "-";
            this.Outros_RegraAdc_DelButton1.UseVisualStyleBackColor = true;
            this.Outros_RegraAdc_DelButton1.Click += new System.EventHandler(this.Outros_RegraAdc_DelButton1_Click);
            // 
            // Outros_RegraAdc_ExTitle
            // 
            this.Outros_RegraAdc_ExTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_ExTitle.AutoSize = true;
            this.Outros_RegraAdc_ExTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_ExTitle.Location = new System.Drawing.Point(499, 64);
            this.Outros_RegraAdc_ExTitle.Name = "Outros_RegraAdc_ExTitle";
            this.Outros_RegraAdc_ExTitle.Size = new System.Drawing.Size(77, 20);
            this.Outros_RegraAdc_ExTitle.TabIndex = 245;
            this.Outros_RegraAdc_ExTitle.Text = "Exemplos:";
            // 
            // Outros_RegraAdc_ExLabel2
            // 
            this.Outros_RegraAdc_ExLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_ExLabel2.AutoSize = true;
            this.Outros_RegraAdc_ExLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_ExLabel2.Location = new System.Drawing.Point(499, 162);
            this.Outros_RegraAdc_ExLabel2.Name = "Outros_RegraAdc_ExLabel2";
            this.Outros_RegraAdc_ExLabel2.Size = new System.Drawing.Size(103, 15);
            this.Outros_RegraAdc_ExLabel2.TabIndex = 244;
            this.Outros_RegraAdc_ExLabel2.Text = "320350[0-4][0-9]";
            // 
            // Outros_RegraAdc_ExLabel1
            // 
            this.Outros_RegraAdc_ExLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_ExLabel1.AutoSize = true;
            this.Outros_RegraAdc_ExLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_ExLabel1.Location = new System.Drawing.Point(499, 131);
            this.Outros_RegraAdc_ExLabel1.Name = "Outros_RegraAdc_ExLabel1";
            this.Outros_RegraAdc_ExLabel1.Size = new System.Drawing.Size(63, 15);
            this.Outros_RegraAdc_ExLabel1.TabIndex = 243;
            this.Outros_RegraAdc_ExLabel1.Text = "32035000";
            // 
            // Outros_RegraAdc_ExLabel0
            // 
            this.Outros_RegraAdc_ExLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_ExLabel0.AutoSize = true;
            this.Outros_RegraAdc_ExLabel0.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_ExLabel0.Location = new System.Drawing.Point(499, 100);
            this.Outros_RegraAdc_ExLabel0.Name = "Outros_RegraAdc_ExLabel0";
            this.Outros_RegraAdc_ExLabel0.Size = new System.Drawing.Size(19, 15);
            this.Outros_RegraAdc_ExLabel0.TabIndex = 242;
            this.Outros_RegraAdc_ExLabel0.Text = "19";
            // 
            // Outros_RegraAdc_DelButton0
            // 
            this.Outros_RegraAdc_DelButton0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_DelButton0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_DelButton0.Location = new System.Drawing.Point(467, 94);
            this.Outros_RegraAdc_DelButton0.Name = "Outros_RegraAdc_DelButton0";
            this.Outros_RegraAdc_DelButton0.Size = new System.Drawing.Size(20, 25);
            this.Outros_RegraAdc_DelButton0.TabIndex = 241;
            this.Outros_RegraAdc_DelButton0.Text = "-";
            this.Outros_RegraAdc_DelButton0.UseVisualStyleBackColor = true;
            this.Outros_RegraAdc_DelButton0.Click += new System.EventHandler(this.Outros_RegraAdc_DelButton0_Click);
            // 
            // Outros_RegraAdc_ClearButton
            // 
            this.Outros_RegraAdc_ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_ClearButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_ClearButton.Location = new System.Drawing.Point(409, 60);
            this.Outros_RegraAdc_ClearButton.Name = "Outros_RegraAdc_ClearButton";
            this.Outros_RegraAdc_ClearButton.Size = new System.Drawing.Size(79, 30);
            this.Outros_RegraAdc_ClearButton.TabIndex = 240;
            this.Outros_RegraAdc_ClearButton.Text = "Limpar";
            this.Outros_RegraAdc_ClearButton.UseVisualStyleBackColor = true;
            this.Outros_RegraAdc_ClearButton.Click += new System.EventHandler(this.Outros_RegraAdc_ClearButton_Click);
            // 
            // Outros_RegraAdc_VarText2
            // 
            this.Outros_RegraAdc_VarText2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_VarText2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_VarText2.Location = new System.Drawing.Point(333, 154);
            this.Outros_RegraAdc_VarText2.Name = "Outros_RegraAdc_VarText2";
            this.Outros_RegraAdc_VarText2.Size = new System.Drawing.Size(129, 25);
            this.Outros_RegraAdc_VarText2.TabIndex = 239;
            // 
            // Outros_RegraAdc_VarText1
            // 
            this.Outros_RegraAdc_VarText1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_VarText1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_VarText1.Location = new System.Drawing.Point(333, 124);
            this.Outros_RegraAdc_VarText1.Name = "Outros_RegraAdc_VarText1";
            this.Outros_RegraAdc_VarText1.Size = new System.Drawing.Size(129, 25);
            this.Outros_RegraAdc_VarText1.TabIndex = 238;
            // 
            // Outros_RegraAdc_Label1
            // 
            this.Outros_RegraAdc_Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_Label1.AutoSize = true;
            this.Outros_RegraAdc_Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_RegraAdc_Label1.Location = new System.Drawing.Point(206, 128);
            this.Outros_RegraAdc_Label1.Name = "Outros_RegraAdc_Label1";
            this.Outros_RegraAdc_Label1.Size = new System.Drawing.Size(88, 17);
            this.Outros_RegraAdc_Label1.TabIndex = 236;
            this.Outros_RegraAdc_Label1.Text = "Tronco-Chave";
            // 
            // Outros_RegraAdc_Label0
            // 
            this.Outros_RegraAdc_Label0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_Label0.AutoSize = true;
            this.Outros_RegraAdc_Label0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_Label0.Location = new System.Drawing.Point(206, 97);
            this.Outros_RegraAdc_Label0.Name = "Outros_RegraAdc_Label0";
            this.Outros_RegraAdc_Label0.Size = new System.Drawing.Size(35, 17);
            this.Outros_RegraAdc_Label0.TabIndex = 235;
            this.Outros_RegraAdc_Label0.Text = "DDD";
            // 
            // Outros_RegraAdc_VarText0
            // 
            this.Outros_RegraAdc_VarText0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_VarText0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_VarText0.Location = new System.Drawing.Point(333, 94);
            this.Outros_RegraAdc_VarText0.Name = "Outros_RegraAdc_VarText0";
            this.Outros_RegraAdc_VarText0.Size = new System.Drawing.Size(129, 25);
            this.Outros_RegraAdc_VarText0.TabIndex = 234;
            // 
            // Outros_RegraAdc_VarTitle
            // 
            this.Outros_RegraAdc_VarTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_VarTitle.AutoSize = true;
            this.Outros_RegraAdc_VarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_VarTitle.Location = new System.Drawing.Point(206, 29);
            this.Outros_RegraAdc_VarTitle.Name = "Outros_RegraAdc_VarTitle";
            this.Outros_RegraAdc_VarTitle.Size = new System.Drawing.Size(88, 25);
            this.Outros_RegraAdc_VarTitle.TabIndex = 233;
            this.Outros_RegraAdc_VarTitle.Text = "Variáveis";
            // 
            // Outros_RegraAdc_NumRegraLabel
            // 
            this.Outros_RegraAdc_NumRegraLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_NumRegraLabel.AutoSize = true;
            this.Outros_RegraAdc_NumRegraLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_NumRegraLabel.Location = new System.Drawing.Point(206, 67);
            this.Outros_RegraAdc_NumRegraLabel.Name = "Outros_RegraAdc_NumRegraLabel";
            this.Outros_RegraAdc_NumRegraLabel.Size = new System.Drawing.Size(121, 17);
            this.Outros_RegraAdc_NumRegraLabel.TabIndex = 232;
            this.Outros_RegraAdc_NumRegraLabel.Text = "Número da Regra: ";
            // 
            // Outros_RegraAdc_Label2
            // 
            this.Outros_RegraAdc_Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_RegraAdc_Label2.AutoSize = true;
            this.Outros_RegraAdc_Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_RegraAdc_Label2.Location = new System.Drawing.Point(206, 160);
            this.Outros_RegraAdc_Label2.Name = "Outros_RegraAdc_Label2";
            this.Outros_RegraAdc_Label2.Size = new System.Drawing.Size(50, 17);
            this.Outros_RegraAdc_Label2.TabIndex = 251;
            this.Outros_RegraAdc_Label2.Text = "Regra: ";
            // 
            // Outros_TabBGP
            // 
            this.Outros_TabBGP.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_ExLabel5);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_DeleteVar5);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_Label5);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_VarText5);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_ExLabel4);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_DeleteVar4);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_Label4);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_VarText4);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_ExLabel3);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_DeleteVar3);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_Label3);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_VarText3);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_Guide);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_DeleteVar2);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_DeleteVar1);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_ExTitle);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_ExLabel2);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_ExLabel1);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_ExLabel0);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_DeleteVar0);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_DeleteAll);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_VarText2);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_VarText1);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_Label2);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_Label1);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_Label0);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_VarText0);
            this.Outros_TabBGP.Controls.Add(this.Outros_BGP_VarTitle);
            this.Outros_TabBGP.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabBGP.Name = "Outros_TabBGP";
            this.Outros_TabBGP.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabBGP.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabBGP.TabIndex = 3;
            this.Outros_TabBGP.Text = "BGP";
            // 
            // Outros_BGP_ExLabel5
            // 
            this.Outros_BGP_ExLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_ExLabel5.AutoSize = true;
            this.Outros_BGP_ExLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_ExLabel5.Location = new System.Drawing.Point(516, 237);
            this.Outros_BGP_ExLabel5.Name = "Outros_BGP_ExLabel5";
            this.Outros_BGP_ExLabel5.Size = new System.Drawing.Size(40, 15);
            this.Outros_BGP_ExLabel5.TabIndex = 262;
            this.Outros_BGP_ExLabel5.Text = "Senha";
            // 
            // Outros_BGP_DeleteVar5
            // 
            this.Outros_BGP_DeleteVar5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_DeleteVar5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_DeleteVar5.Location = new System.Drawing.Point(484, 234);
            this.Outros_BGP_DeleteVar5.Name = "Outros_BGP_DeleteVar5";
            this.Outros_BGP_DeleteVar5.Size = new System.Drawing.Size(20, 25);
            this.Outros_BGP_DeleteVar5.TabIndex = 261;
            this.Outros_BGP_DeleteVar5.Text = "-";
            this.Outros_BGP_DeleteVar5.UseVisualStyleBackColor = true;
            this.Outros_BGP_DeleteVar5.Click += new System.EventHandler(this.Outros_BGP_DeleteVar5_Click);
            // 
            // Outros_BGP_Label5
            // 
            this.Outros_BGP_Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_Label5.AutoSize = true;
            this.Outros_BGP_Label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_Label5.Location = new System.Drawing.Point(254, 237);
            this.Outros_BGP_Label5.Name = "Outros_BGP_Label5";
            this.Outros_BGP_Label5.Size = new System.Drawing.Size(67, 17);
            this.Outros_BGP_Label5.TabIndex = 260;
            this.Outros_BGP_Label5.Text = "Password:";
            // 
            // Outros_BGP_VarText5
            // 
            this.Outros_BGP_VarText5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_VarText5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_VarText5.Location = new System.Drawing.Point(350, 234);
            this.Outros_BGP_VarText5.Name = "Outros_BGP_VarText5";
            this.Outros_BGP_VarText5.Size = new System.Drawing.Size(129, 25);
            this.Outros_BGP_VarText5.TabIndex = 259;
            // 
            // Outros_BGP_ExLabel4
            // 
            this.Outros_BGP_ExLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_ExLabel4.AutoSize = true;
            this.Outros_BGP_ExLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_ExLabel4.Location = new System.Drawing.Point(516, 206);
            this.Outros_BGP_ExLabel4.Name = "Outros_BGP_ExLabel4";
            this.Outros_BGP_ExLabel4.Size = new System.Drawing.Size(57, 15);
            this.Outros_BGP_ExLabel4.TabIndex = 258;
            this.Outros_BGP_ExLabel4.Text = "10.10.10.1";
            // 
            // Outros_BGP_DeleteVar4
            // 
            this.Outros_BGP_DeleteVar4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_DeleteVar4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_DeleteVar4.Location = new System.Drawing.Point(484, 203);
            this.Outros_BGP_DeleteVar4.Name = "Outros_BGP_DeleteVar4";
            this.Outros_BGP_DeleteVar4.Size = new System.Drawing.Size(20, 25);
            this.Outros_BGP_DeleteVar4.TabIndex = 257;
            this.Outros_BGP_DeleteVar4.Text = "-";
            this.Outros_BGP_DeleteVar4.UseVisualStyleBackColor = true;
            this.Outros_BGP_DeleteVar4.Click += new System.EventHandler(this.Outros_BGP_DeleteVar4_Click);
            // 
            // Outros_BGP_Label4
            // 
            this.Outros_BGP_Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_Label4.AutoSize = true;
            this.Outros_BGP_Label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_Label4.Location = new System.Drawing.Point(254, 206);
            this.Outros_BGP_Label4.Name = "Outros_BGP_Label4";
            this.Outros_BGP_Label4.Size = new System.Drawing.Size(71, 17);
            this.Outros_BGP_Label4.TabIndex = 256;
            this.Outros_BGP_Label4.Text = "IP de Host:";
            // 
            // Outros_BGP_VarText4
            // 
            this.Outros_BGP_VarText4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_VarText4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_VarText4.Location = new System.Drawing.Point(350, 202);
            this.Outros_BGP_VarText4.Name = "Outros_BGP_VarText4";
            this.Outros_BGP_VarText4.Size = new System.Drawing.Size(129, 25);
            this.Outros_BGP_VarText4.TabIndex = 255;
            // 
            // Outros_BGP_ExLabel3
            // 
            this.Outros_BGP_ExLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_ExLabel3.AutoSize = true;
            this.Outros_BGP_ExLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_ExLabel3.Location = new System.Drawing.Point(516, 175);
            this.Outros_BGP_ExLabel3.Name = "Outros_BGP_ExLabel3";
            this.Outros_BGP_ExLabel3.Size = new System.Drawing.Size(40, 15);
            this.Outros_BGP_ExLabel3.TabIndex = 254;
            this.Outros_BGP_ExLabel3.Text = "65851";
            // 
            // Outros_BGP_DeleteVar3
            // 
            this.Outros_BGP_DeleteVar3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_DeleteVar3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_DeleteVar3.Location = new System.Drawing.Point(484, 172);
            this.Outros_BGP_DeleteVar3.Name = "Outros_BGP_DeleteVar3";
            this.Outros_BGP_DeleteVar3.Size = new System.Drawing.Size(20, 25);
            this.Outros_BGP_DeleteVar3.TabIndex = 253;
            this.Outros_BGP_DeleteVar3.Text = "-";
            this.Outros_BGP_DeleteVar3.UseVisualStyleBackColor = true;
            this.Outros_BGP_DeleteVar3.Click += new System.EventHandler(this.Outros_BGP_DeleteVar3_Click);
            // 
            // Outros_BGP_Label3
            // 
            this.Outros_BGP_Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_Label3.AutoSize = true;
            this.Outros_BGP_Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_Label3.Location = new System.Drawing.Point(254, 175);
            this.Outros_BGP_Label3.Name = "Outros_BGP_Label3";
            this.Outros_BGP_Label3.Size = new System.Drawing.Size(75, 17);
            this.Outros_BGP_Label3.TabIndex = 252;
            this.Outros_BGP_Label3.Text = "Remote AS:";
            // 
            // Outros_BGP_VarText3
            // 
            this.Outros_BGP_VarText3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_VarText3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_VarText3.Location = new System.Drawing.Point(350, 171);
            this.Outros_BGP_VarText3.Name = "Outros_BGP_VarText3";
            this.Outros_BGP_VarText3.Size = new System.Drawing.Size(129, 25);
            this.Outros_BGP_VarText3.TabIndex = 251;
            // 
            // Outros_BGP_Guide
            // 
            this.Outros_BGP_Guide.AutoSize = true;
            this.Outros_BGP_Guide.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outros_BGP_Guide.Location = new System.Drawing.Point(12, 29);
            this.Outros_BGP_Guide.Name = "Outros_BGP_Guide";
            this.Outros_BGP_Guide.Size = new System.Drawing.Size(74, 20);
            this.Outros_BGP_Guide.TabIndex = 250;
            this.Outros_BGP_Guide.Text = "Guia aqui";
            // 
            // Outros_BGP_DeleteVar2
            // 
            this.Outros_BGP_DeleteVar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_DeleteVar2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_DeleteVar2.Location = new System.Drawing.Point(484, 140);
            this.Outros_BGP_DeleteVar2.Name = "Outros_BGP_DeleteVar2";
            this.Outros_BGP_DeleteVar2.Size = new System.Drawing.Size(20, 25);
            this.Outros_BGP_DeleteVar2.TabIndex = 245;
            this.Outros_BGP_DeleteVar2.Text = "-";
            this.Outros_BGP_DeleteVar2.UseVisualStyleBackColor = true;
            this.Outros_BGP_DeleteVar2.Click += new System.EventHandler(this.Outros_BGP_DeleteVar2_Click);
            // 
            // Outros_BGP_DeleteVar1
            // 
            this.Outros_BGP_DeleteVar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_DeleteVar1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_DeleteVar1.Location = new System.Drawing.Point(484, 110);
            this.Outros_BGP_DeleteVar1.Name = "Outros_BGP_DeleteVar1";
            this.Outros_BGP_DeleteVar1.Size = new System.Drawing.Size(20, 25);
            this.Outros_BGP_DeleteVar1.TabIndex = 244;
            this.Outros_BGP_DeleteVar1.Text = "-";
            this.Outros_BGP_DeleteVar1.UseVisualStyleBackColor = true;
            this.Outros_BGP_DeleteVar1.Click += new System.EventHandler(this.Outros_BGP_DeleteVar1_Click);
            // 
            // Outros_BGP_ExTitle
            // 
            this.Outros_BGP_ExTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_ExTitle.AutoSize = true;
            this.Outros_BGP_ExTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_ExTitle.Location = new System.Drawing.Point(516, 50);
            this.Outros_BGP_ExTitle.Name = "Outros_BGP_ExTitle";
            this.Outros_BGP_ExTitle.Size = new System.Drawing.Size(77, 20);
            this.Outros_BGP_ExTitle.TabIndex = 242;
            this.Outros_BGP_ExTitle.Text = "Exemplos:";
            // 
            // Outros_BGP_ExLabel2
            // 
            this.Outros_BGP_ExLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_ExLabel2.AutoSize = true;
            this.Outros_BGP_ExLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_ExLabel2.Location = new System.Drawing.Point(517, 146);
            this.Outros_BGP_ExLabel2.Name = "Outros_BGP_ExLabel2";
            this.Outros_BGP_ExLabel2.Size = new System.Drawing.Size(83, 15);
            this.Outros_BGP_ExLabel2.TabIndex = 241;
            this.Outros_BGP_ExLabel2.Text = "CAS/IP/00021";
            // 
            // Outros_BGP_ExLabel1
            // 
            this.Outros_BGP_ExLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_ExLabel1.AutoSize = true;
            this.Outros_BGP_ExLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_ExLabel1.Location = new System.Drawing.Point(516, 113);
            this.Outros_BGP_ExLabel1.Name = "Outros_BGP_ExLabel1";
            this.Outros_BGP_ExLabel1.Size = new System.Drawing.Size(64, 15);
            this.Outros_BGP_ExLabel1.TabIndex = 240;
            this.Outros_BGP_ExLabel1.Text = "192.168.1.1";
            // 
            // Outros_BGP_ExLabel0
            // 
            this.Outros_BGP_ExLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_ExLabel0.AutoSize = true;
            this.Outros_BGP_ExLabel0.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_ExLabel0.Location = new System.Drawing.Point(516, 83);
            this.Outros_BGP_ExLabel0.Name = "Outros_BGP_ExLabel0";
            this.Outros_BGP_ExLabel0.Size = new System.Drawing.Size(42, 15);
            this.Outros_BGP_ExLabel0.TabIndex = 239;
            this.Outros_BGP_ExLabel0.Text = "65000";
            // 
            // Outros_BGP_DeleteVar0
            // 
            this.Outros_BGP_DeleteVar0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_DeleteVar0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_DeleteVar0.Location = new System.Drawing.Point(484, 81);
            this.Outros_BGP_DeleteVar0.Name = "Outros_BGP_DeleteVar0";
            this.Outros_BGP_DeleteVar0.Size = new System.Drawing.Size(20, 25);
            this.Outros_BGP_DeleteVar0.TabIndex = 238;
            this.Outros_BGP_DeleteVar0.Text = "-";
            this.Outros_BGP_DeleteVar0.UseVisualStyleBackColor = true;
            this.Outros_BGP_DeleteVar0.Click += new System.EventHandler(this.Outros_BGP_DeleteVar0_Click);
            // 
            // Outros_BGP_DeleteAll
            // 
            this.Outros_BGP_DeleteAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_DeleteAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_DeleteAll.Location = new System.Drawing.Point(426, 45);
            this.Outros_BGP_DeleteAll.Name = "Outros_BGP_DeleteAll";
            this.Outros_BGP_DeleteAll.Size = new System.Drawing.Size(79, 30);
            this.Outros_BGP_DeleteAll.TabIndex = 237;
            this.Outros_BGP_DeleteAll.Text = "Limpar";
            this.Outros_BGP_DeleteAll.UseVisualStyleBackColor = true;
            this.Outros_BGP_DeleteAll.Click += new System.EventHandler(this.Outros_BGP_DeleteAll_Click);
            // 
            // Outros_BGP_VarText2
            // 
            this.Outros_BGP_VarText2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_VarText2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_VarText2.Location = new System.Drawing.Point(350, 141);
            this.Outros_BGP_VarText2.Name = "Outros_BGP_VarText2";
            this.Outros_BGP_VarText2.Size = new System.Drawing.Size(129, 25);
            this.Outros_BGP_VarText2.TabIndex = 236;
            // 
            // Outros_BGP_VarText1
            // 
            this.Outros_BGP_VarText1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_VarText1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_VarText1.Location = new System.Drawing.Point(350, 110);
            this.Outros_BGP_VarText1.Name = "Outros_BGP_VarText1";
            this.Outros_BGP_VarText1.Size = new System.Drawing.Size(129, 25);
            this.Outros_BGP_VarText1.TabIndex = 235;
            // 
            // Outros_BGP_Label2
            // 
            this.Outros_BGP_Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_Label2.AutoSize = true;
            this.Outros_BGP_Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_BGP_Label2.Location = new System.Drawing.Point(254, 144);
            this.Outros_BGP_Label2.Name = "Outros_BGP_Label2";
            this.Outros_BGP_Label2.Size = new System.Drawing.Size(79, 17);
            this.Outros_BGP_Label2.TabIndex = 234;
            this.Outros_BGP_Label2.Text = "Designação:";
            // 
            // Outros_BGP_Label1
            // 
            this.Outros_BGP_Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_Label1.AutoSize = true;
            this.Outros_BGP_Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_BGP_Label1.Location = new System.Drawing.Point(254, 114);
            this.Outros_BGP_Label1.Name = "Outros_BGP_Label1";
            this.Outros_BGP_Label1.Size = new System.Drawing.Size(59, 17);
            this.Outros_BGP_Label1.TabIndex = 233;
            this.Outros_BGP_Label1.Text = "IP do PE:";
            // 
            // Outros_BGP_Label0
            // 
            this.Outros_BGP_Label0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_Label0.AutoSize = true;
            this.Outros_BGP_Label0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_Label0.Location = new System.Drawing.Point(254, 83);
            this.Outros_BGP_Label0.Name = "Outros_BGP_Label0";
            this.Outros_BGP_Label0.Size = new System.Drawing.Size(26, 17);
            this.Outros_BGP_Label0.TabIndex = 232;
            this.Outros_BGP_Label0.Text = "AS:";
            // 
            // Outros_BGP_VarText0
            // 
            this.Outros_BGP_VarText0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_VarText0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_VarText0.Location = new System.Drawing.Point(351, 79);
            this.Outros_BGP_VarText0.Name = "Outros_BGP_VarText0";
            this.Outros_BGP_VarText0.Size = new System.Drawing.Size(129, 25);
            this.Outros_BGP_VarText0.TabIndex = 231;
            // 
            // Outros_BGP_VarTitle
            // 
            this.Outros_BGP_VarTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_BGP_VarTitle.AutoSize = true;
            this.Outros_BGP_VarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_BGP_VarTitle.Location = new System.Drawing.Point(252, 44);
            this.Outros_BGP_VarTitle.Name = "Outros_BGP_VarTitle";
            this.Outros_BGP_VarTitle.Size = new System.Drawing.Size(88, 25);
            this.Outros_BGP_VarTitle.TabIndex = 230;
            this.Outros_BGP_VarTitle.Text = "Variáveis";
            // 
            // Outros_TabDHCP
            // 
            this.Outros_TabDHCP.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ExLabel5);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ExLabel4);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_DelButton0);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_VarText0);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_MascaraBox);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_DelButton5);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_VarText10);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_Label5);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_DelButton4);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_VarText9);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_Label4);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_SubTitle);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_DelButton8);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ExLabel8);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_VarText7);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_Label8);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_DelButton7);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ExLabel7);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_VarText6);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_Label7);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_DelButton6);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ExLabel6);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_VarText5);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_Label6);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_DelButton3);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ExLabel3);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_VarText4);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_Label3);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_DelButton2);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ExLabel2);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_VarText3);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_Label2);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_Guide);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_DelButton1);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_DelButton9);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ExTitle);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ExLabel1);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ExLabel9);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ExLabel0);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_ClearButton);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_VarText1);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_VarText8);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_Label1);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_Label9);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_Label0);
            this.Outros_TabDHCP.Controls.Add(this.Outros_DHCP_VarTitle);
            this.Outros_TabDHCP.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabDHCP.Name = "Outros_TabDHCP";
            this.Outros_TabDHCP.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabDHCP.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabDHCP.TabIndex = 4;
            this.Outros_TabDHCP.Text = "DHCP";
            // 
            // Outros_DHCP_ExLabel5
            // 
            this.Outros_DHCP_ExLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ExLabel5.AutoSize = true;
            this.Outros_DHCP_ExLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ExLabel5.Location = new System.Drawing.Point(517, 231);
            this.Outros_DHCP_ExLabel5.Name = "Outros_DHCP_ExLabel5";
            this.Outros_DHCP_ExLabel5.Size = new System.Drawing.Size(85, 15);
            this.Outros_DHCP_ExLabel5.TabIndex = 285;
            this.Outros_DHCP_ExLabel5.Text = "200.183.111.30";
            // 
            // Outros_DHCP_ExLabel4
            // 
            this.Outros_DHCP_ExLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ExLabel4.AutoSize = true;
            this.Outros_DHCP_ExLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ExLabel4.Location = new System.Drawing.Point(518, 202);
            this.Outros_DHCP_ExLabel4.Name = "Outros_DHCP_ExLabel4";
            this.Outros_DHCP_ExLabel4.Size = new System.Drawing.Size(78, 15);
            this.Outros_DHCP_ExLabel4.TabIndex = 284;
            this.Outros_DHCP_ExLabel4.Text = "200.183.111.2";
            // 
            // Outros_DHCP_DelButton0
            // 
            this.Outros_DHCP_DelButton0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_DelButton0.Location = new System.Drawing.Point(485, 73);
            this.Outros_DHCP_DelButton0.Name = "Outros_DHCP_DelButton0";
            this.Outros_DHCP_DelButton0.Size = new System.Drawing.Size(20, 25);
            this.Outros_DHCP_DelButton0.TabIndex = 283;
            this.Outros_DHCP_DelButton0.Text = "-";
            this.Outros_DHCP_DelButton0.UseVisualStyleBackColor = true;
            // 
            // Outros_DHCP_VarText0
            // 
            this.Outros_DHCP_VarText0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_VarText0.Location = new System.Drawing.Point(317, 73);
            this.Outros_DHCP_VarText0.Name = "Outros_DHCP_VarText0";
            this.Outros_DHCP_VarText0.Size = new System.Drawing.Size(102, 25);
            this.Outros_DHCP_VarText0.TabIndex = 282;
            // 
            // Outros_DHCP_MascaraBox
            // 
            this.Outros_DHCP_MascaraBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_MascaraBox.FormattingEnabled = true;
            this.Outros_DHCP_MascaraBox.Items.AddRange(new object[] {
            "/30",
            "/29",
            "/28",
            "/27",
            "/26",
            "/25",
            "/24"});
            this.Outros_DHCP_MascaraBox.Location = new System.Drawing.Point(424, 73);
            this.Outros_DHCP_MascaraBox.Name = "Outros_DHCP_MascaraBox";
            this.Outros_DHCP_MascaraBox.Size = new System.Drawing.Size(54, 25);
            this.Outros_DHCP_MascaraBox.TabIndex = 281;
            // 
            // Outros_DHCP_DelButton5
            // 
            this.Outros_DHCP_DelButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_DelButton5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_DelButton5.Location = new System.Drawing.Point(485, 228);
            this.Outros_DHCP_DelButton5.Name = "Outros_DHCP_DelButton5";
            this.Outros_DHCP_DelButton5.Size = new System.Drawing.Size(20, 25);
            this.Outros_DHCP_DelButton5.TabIndex = 280;
            this.Outros_DHCP_DelButton5.Text = "-";
            this.Outros_DHCP_DelButton5.UseVisualStyleBackColor = true;
            // 
            // Outros_DHCP_VarText10
            // 
            this.Outros_DHCP_VarText10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_VarText10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_VarText10.Location = new System.Drawing.Point(374, 228);
            this.Outros_DHCP_VarText10.Name = "Outros_DHCP_VarText10";
            this.Outros_DHCP_VarText10.Size = new System.Drawing.Size(106, 25);
            this.Outros_DHCP_VarText10.TabIndex = 278;
            // 
            // Outros_DHCP_Label5
            // 
            this.Outros_DHCP_Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_Label5.AutoSize = true;
            this.Outros_DHCP_Label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_DHCP_Label5.Location = new System.Drawing.Point(252, 229);
            this.Outros_DHCP_Label5.Name = "Outros_DHCP_Label5";
            this.Outros_DHCP_Label5.Size = new System.Drawing.Size(101, 17);
            this.Outros_DHCP_Label5.TabIndex = 277;
            this.Outros_DHCP_Label5.Text = "Ultimo Excluido:";
            // 
            // Outros_DHCP_DelButton4
            // 
            this.Outros_DHCP_DelButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_DelButton4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_DelButton4.Location = new System.Drawing.Point(485, 197);
            this.Outros_DHCP_DelButton4.Name = "Outros_DHCP_DelButton4";
            this.Outros_DHCP_DelButton4.Size = new System.Drawing.Size(20, 25);
            this.Outros_DHCP_DelButton4.TabIndex = 276;
            this.Outros_DHCP_DelButton4.Text = "-";
            this.Outros_DHCP_DelButton4.UseVisualStyleBackColor = true;
            // 
            // Outros_DHCP_VarText9
            // 
            this.Outros_DHCP_VarText9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_VarText9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_VarText9.Location = new System.Drawing.Point(374, 197);
            this.Outros_DHCP_VarText9.Name = "Outros_DHCP_VarText9";
            this.Outros_DHCP_VarText9.Size = new System.Drawing.Size(106, 25);
            this.Outros_DHCP_VarText9.TabIndex = 274;
            // 
            // Outros_DHCP_Label4
            // 
            this.Outros_DHCP_Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_Label4.AutoSize = true;
            this.Outros_DHCP_Label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_DHCP_Label4.Location = new System.Drawing.Point(252, 200);
            this.Outros_DHCP_Label4.Name = "Outros_DHCP_Label4";
            this.Outros_DHCP_Label4.Size = new System.Drawing.Size(112, 17);
            this.Outros_DHCP_Label4.TabIndex = 273;
            this.Outros_DHCP_Label4.Text = "Primeiro Excluido:";
            // 
            // Outros_DHCP_SubTitle
            // 
            this.Outros_DHCP_SubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_SubTitle.AutoSize = true;
            this.Outros_DHCP_SubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold);
            this.Outros_DHCP_SubTitle.Location = new System.Drawing.Point(11, 310);
            this.Outros_DHCP_SubTitle.Name = "Outros_DHCP_SubTitle";
            this.Outros_DHCP_SubTitle.Size = new System.Drawing.Size(84, 17);
            this.Outros_DHCP_SubTitle.TabIndex = 271;
            this.Outros_DHCP_SubTitle.Text = "DHCP RELAY";
            // 
            // Outros_DHCP_DelButton8
            // 
            this.Outros_DHCP_DelButton8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_DelButton8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_DelButton8.Location = new System.Drawing.Point(263, 334);
            this.Outros_DHCP_DelButton8.Name = "Outros_DHCP_DelButton8";
            this.Outros_DHCP_DelButton8.Size = new System.Drawing.Size(20, 25);
            this.Outros_DHCP_DelButton8.TabIndex = 270;
            this.Outros_DHCP_DelButton8.Text = "-";
            this.Outros_DHCP_DelButton8.UseVisualStyleBackColor = true;
            // 
            // Outros_DHCP_ExLabel8
            // 
            this.Outros_DHCP_ExLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ExLabel8.AutoSize = true;
            this.Outros_DHCP_ExLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ExLabel8.Location = new System.Drawing.Point(296, 339);
            this.Outros_DHCP_ExLabel8.Name = "Outros_DHCP_ExLabel8";
            this.Outros_DHCP_ExLabel8.Size = new System.Drawing.Size(57, 15);
            this.Outros_DHCP_ExLabel8.TabIndex = 269;
            this.Outros_DHCP_ExLabel8.Text = "10.10.10.1";
            // 
            // Outros_DHCP_VarText7
            // 
            this.Outros_DHCP_VarText7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_VarText7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_VarText7.Location = new System.Drawing.Point(128, 334);
            this.Outros_DHCP_VarText7.Name = "Outros_DHCP_VarText7";
            this.Outros_DHCP_VarText7.Size = new System.Drawing.Size(129, 25);
            this.Outros_DHCP_VarText7.TabIndex = 268;
            // 
            // Outros_DHCP_Label8
            // 
            this.Outros_DHCP_Label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_Label8.AutoSize = true;
            this.Outros_DHCP_Label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_DHCP_Label8.Location = new System.Drawing.Point(13, 338);
            this.Outros_DHCP_Label8.Name = "Outros_DHCP_Label8";
            this.Outros_DHCP_Label8.Size = new System.Drawing.Size(110, 17);
            this.Outros_DHCP_Label8.TabIndex = 267;
            this.Outros_DHCP_Label8.Text = "IP do DHCP Relay";
            // 
            // Outros_DHCP_DelButton7
            // 
            this.Outros_DHCP_DelButton7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_DelButton7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_DelButton7.Location = new System.Drawing.Point(550, 273);
            this.Outros_DHCP_DelButton7.Name = "Outros_DHCP_DelButton7";
            this.Outros_DHCP_DelButton7.Size = new System.Drawing.Size(20, 25);
            this.Outros_DHCP_DelButton7.TabIndex = 266;
            this.Outros_DHCP_DelButton7.Text = "-";
            this.Outros_DHCP_DelButton7.UseVisualStyleBackColor = true;
            // 
            // Outros_DHCP_ExLabel7
            // 
            this.Outros_DHCP_ExLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ExLabel7.AutoSize = true;
            this.Outros_DHCP_ExLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ExLabel7.Location = new System.Drawing.Point(508, 301);
            this.Outros_DHCP_ExLabel7.Name = "Outros_DHCP_ExLabel7";
            this.Outros_DHCP_ExLabel7.Size = new System.Drawing.Size(36, 15);
            this.Outros_DHCP_ExLabel7.TabIndex = 265;
            this.Outros_DHCP_ExLabel7.Text = "1.1.1.1";
            // 
            // Outros_DHCP_VarText6
            // 
            this.Outros_DHCP_VarText6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_VarText6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_VarText6.Location = new System.Drawing.Point(438, 273);
            this.Outros_DHCP_VarText6.Name = "Outros_DHCP_VarText6";
            this.Outros_DHCP_VarText6.Size = new System.Drawing.Size(106, 25);
            this.Outros_DHCP_VarText6.TabIndex = 264;
            // 
            // Outros_DHCP_Label7
            // 
            this.Outros_DHCP_Label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_Label7.AutoSize = true;
            this.Outros_DHCP_Label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_DHCP_Label7.Location = new System.Drawing.Point(344, 276);
            this.Outros_DHCP_Label7.Name = "Outros_DHCP_Label7";
            this.Outros_DHCP_Label7.Size = new System.Drawing.Size(89, 17);
            this.Outros_DHCP_Label7.TabIndex = 263;
            this.Outros_DHCP_Label7.Text = "DNS Server 2:";
            // 
            // Outros_DHCP_DelButton6
            // 
            this.Outros_DHCP_DelButton6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_DelButton6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_DelButton6.Location = new System.Drawing.Point(313, 273);
            this.Outros_DHCP_DelButton6.Name = "Outros_DHCP_DelButton6";
            this.Outros_DHCP_DelButton6.Size = new System.Drawing.Size(20, 25);
            this.Outros_DHCP_DelButton6.TabIndex = 262;
            this.Outros_DHCP_DelButton6.Text = "-";
            this.Outros_DHCP_DelButton6.UseVisualStyleBackColor = true;
            // 
            // Outros_DHCP_ExLabel6
            // 
            this.Outros_DHCP_ExLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ExLabel6.AutoSize = true;
            this.Outros_DHCP_ExLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ExLabel6.Location = new System.Drawing.Point(263, 301);
            this.Outros_DHCP_ExLabel6.Name = "Outros_DHCP_ExLabel6";
            this.Outros_DHCP_ExLabel6.Size = new System.Drawing.Size(44, 15);
            this.Outros_DHCP_ExLabel6.TabIndex = 261;
            this.Outros_DHCP_ExLabel6.Text = "8.8.8.8";
            // 
            // Outros_DHCP_VarText5
            // 
            this.Outros_DHCP_VarText5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_VarText5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_VarText5.Location = new System.Drawing.Point(201, 273);
            this.Outros_DHCP_VarText5.Name = "Outros_DHCP_VarText5";
            this.Outros_DHCP_VarText5.Size = new System.Drawing.Size(106, 25);
            this.Outros_DHCP_VarText5.TabIndex = 260;
            // 
            // Outros_DHCP_Label6
            // 
            this.Outros_DHCP_Label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_Label6.AutoSize = true;
            this.Outros_DHCP_Label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_DHCP_Label6.Location = new System.Drawing.Point(107, 277);
            this.Outros_DHCP_Label6.Name = "Outros_DHCP_Label6";
            this.Outros_DHCP_Label6.Size = new System.Drawing.Size(89, 17);
            this.Outros_DHCP_Label6.TabIndex = 259;
            this.Outros_DHCP_Label6.Text = "DNS Server 1:";
            // 
            // Outros_DHCP_DelButton3
            // 
            this.Outros_DHCP_DelButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_DelButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_DelButton3.Location = new System.Drawing.Point(485, 166);
            this.Outros_DHCP_DelButton3.Name = "Outros_DHCP_DelButton3";
            this.Outros_DHCP_DelButton3.Size = new System.Drawing.Size(20, 25);
            this.Outros_DHCP_DelButton3.TabIndex = 258;
            this.Outros_DHCP_DelButton3.Text = "-";
            this.Outros_DHCP_DelButton3.UseVisualStyleBackColor = true;
            // 
            // Outros_DHCP_ExLabel3
            // 
            this.Outros_DHCP_ExLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ExLabel3.AutoSize = true;
            this.Outros_DHCP_ExLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ExLabel3.Location = new System.Drawing.Point(518, 171);
            this.Outros_DHCP_ExLabel3.Name = "Outros_DHCP_ExLabel3";
            this.Outros_DHCP_ExLabel3.Size = new System.Drawing.Size(85, 15);
            this.Outros_DHCP_ExLabel3.TabIndex = 257;
            this.Outros_DHCP_ExLabel3.Text = "200.183.111.30";
            // 
            // Outros_DHCP_VarText4
            // 
            this.Outros_DHCP_VarText4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_VarText4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_VarText4.Location = new System.Drawing.Point(374, 166);
            this.Outros_DHCP_VarText4.Name = "Outros_DHCP_VarText4";
            this.Outros_DHCP_VarText4.Size = new System.Drawing.Size(106, 25);
            this.Outros_DHCP_VarText4.TabIndex = 256;
            // 
            // Outros_DHCP_Label3
            // 
            this.Outros_DHCP_Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_Label3.AutoSize = true;
            this.Outros_DHCP_Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_DHCP_Label3.Location = new System.Drawing.Point(252, 169);
            this.Outros_DHCP_Label3.Name = "Outros_DHCP_Label3";
            this.Outros_DHCP_Label3.Size = new System.Drawing.Size(112, 17);
            this.Outros_DHCP_Label3.TabIndex = 255;
            this.Outros_DHCP_Label3.Text = "Ultimo disponìvel:";
            // 
            // Outros_DHCP_DelButton2
            // 
            this.Outros_DHCP_DelButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_DelButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_DelButton2.Location = new System.Drawing.Point(485, 135);
            this.Outros_DHCP_DelButton2.Name = "Outros_DHCP_DelButton2";
            this.Outros_DHCP_DelButton2.Size = new System.Drawing.Size(20, 25);
            this.Outros_DHCP_DelButton2.TabIndex = 254;
            this.Outros_DHCP_DelButton2.Text = "-";
            this.Outros_DHCP_DelButton2.UseVisualStyleBackColor = true;
            // 
            // Outros_DHCP_ExLabel2
            // 
            this.Outros_DHCP_ExLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ExLabel2.AutoSize = true;
            this.Outros_DHCP_ExLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ExLabel2.Location = new System.Drawing.Point(516, 140);
            this.Outros_DHCP_ExLabel2.Name = "Outros_DHCP_ExLabel2";
            this.Outros_DHCP_ExLabel2.Size = new System.Drawing.Size(78, 15);
            this.Outros_DHCP_ExLabel2.TabIndex = 253;
            this.Outros_DHCP_ExLabel2.Text = "200.183.111.2";
            // 
            // Outros_DHCP_VarText3
            // 
            this.Outros_DHCP_VarText3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_VarText3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_VarText3.Location = new System.Drawing.Point(374, 135);
            this.Outros_DHCP_VarText3.Name = "Outros_DHCP_VarText3";
            this.Outros_DHCP_VarText3.Size = new System.Drawing.Size(106, 25);
            this.Outros_DHCP_VarText3.TabIndex = 252;
            // 
            // Outros_DHCP_Label2
            // 
            this.Outros_DHCP_Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_Label2.AutoSize = true;
            this.Outros_DHCP_Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_DHCP_Label2.Location = new System.Drawing.Point(248, 138);
            this.Outros_DHCP_Label2.Name = "Outros_DHCP_Label2";
            this.Outros_DHCP_Label2.Size = new System.Drawing.Size(120, 17);
            this.Outros_DHCP_Label2.TabIndex = 251;
            this.Outros_DHCP_Label2.Text = "Primeiro disponivel";
            // 
            // Outros_DHCP_Guide
            // 
            this.Outros_DHCP_Guide.AutoSize = true;
            this.Outros_DHCP_Guide.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outros_DHCP_Guide.Location = new System.Drawing.Point(22, 33);
            this.Outros_DHCP_Guide.Name = "Outros_DHCP_Guide";
            this.Outros_DHCP_Guide.Size = new System.Drawing.Size(74, 20);
            this.Outros_DHCP_Guide.TabIndex = 250;
            this.Outros_DHCP_Guide.Text = "Guia aqui";
            // 
            // Outros_DHCP_DelButton1
            // 
            this.Outros_DHCP_DelButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_DelButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_DelButton1.Location = new System.Drawing.Point(485, 104);
            this.Outros_DHCP_DelButton1.Name = "Outros_DHCP_DelButton1";
            this.Outros_DHCP_DelButton1.Size = new System.Drawing.Size(20, 25);
            this.Outros_DHCP_DelButton1.TabIndex = 245;
            this.Outros_DHCP_DelButton1.Text = "-";
            this.Outros_DHCP_DelButton1.UseVisualStyleBackColor = true;
            // 
            // Outros_DHCP_DelButton9
            // 
            this.Outros_DHCP_DelButton9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_DelButton9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_DelButton9.Location = new System.Drawing.Point(263, 365);
            this.Outros_DHCP_DelButton9.Name = "Outros_DHCP_DelButton9";
            this.Outros_DHCP_DelButton9.Size = new System.Drawing.Size(20, 25);
            this.Outros_DHCP_DelButton9.TabIndex = 244;
            this.Outros_DHCP_DelButton9.Text = "-";
            this.Outros_DHCP_DelButton9.UseVisualStyleBackColor = true;
            // 
            // Outros_DHCP_ExTitle
            // 
            this.Outros_DHCP_ExTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ExTitle.AutoSize = true;
            this.Outros_DHCP_ExTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ExTitle.Location = new System.Drawing.Point(516, 40);
            this.Outros_DHCP_ExTitle.Name = "Outros_DHCP_ExTitle";
            this.Outros_DHCP_ExTitle.Size = new System.Drawing.Size(77, 20);
            this.Outros_DHCP_ExTitle.TabIndex = 242;
            this.Outros_DHCP_ExTitle.Text = "Exemplos:";
            // 
            // Outros_DHCP_ExLabel1
            // 
            this.Outros_DHCP_ExLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ExLabel1.AutoSize = true;
            this.Outros_DHCP_ExLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ExLabel1.Location = new System.Drawing.Point(516, 109);
            this.Outros_DHCP_ExLabel1.Name = "Outros_DHCP_ExLabel1";
            this.Outros_DHCP_ExLabel1.Size = new System.Drawing.Size(108, 15);
            this.Outros_DHCP_ExLabel1.TabIndex = 241;
            this.Outros_DHCP_ExLabel1.Text = "GigabitEthernet0/0";
            // 
            // Outros_DHCP_ExLabel9
            // 
            this.Outros_DHCP_ExLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ExLabel9.AutoSize = true;
            this.Outros_DHCP_ExLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ExLabel9.Location = new System.Drawing.Point(296, 370);
            this.Outros_DHCP_ExLabel9.Name = "Outros_DHCP_ExLabel9";
            this.Outros_DHCP_ExLabel9.Size = new System.Drawing.Size(100, 15);
            this.Outros_DHCP_ExLabel9.TabIndex = 240;
            this.Outros_DHCP_ExLabel9.Text = "255.255.255.252";
            // 
            // Outros_DHCP_ExLabel0
            // 
            this.Outros_DHCP_ExLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ExLabel0.AutoSize = true;
            this.Outros_DHCP_ExLabel0.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ExLabel0.Location = new System.Drawing.Point(518, 76);
            this.Outros_DHCP_ExLabel0.Name = "Outros_DHCP_ExLabel0";
            this.Outros_DHCP_ExLabel0.Size = new System.Drawing.Size(76, 15);
            this.Outros_DHCP_ExLabel0.TabIndex = 239;
            this.Outros_DHCP_ExLabel0.Text = "200.183.111.1";
            // 
            // Outros_DHCP_ClearButton
            // 
            this.Outros_DHCP_ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_ClearButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_ClearButton.Location = new System.Drawing.Point(426, 35);
            this.Outros_DHCP_ClearButton.Name = "Outros_DHCP_ClearButton";
            this.Outros_DHCP_ClearButton.Size = new System.Drawing.Size(79, 30);
            this.Outros_DHCP_ClearButton.TabIndex = 237;
            this.Outros_DHCP_ClearButton.Text = "Limpar";
            this.Outros_DHCP_ClearButton.UseVisualStyleBackColor = true;
            // 
            // Outros_DHCP_VarText1
            // 
            this.Outros_DHCP_VarText1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_VarText1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_VarText1.Location = new System.Drawing.Point(317, 103);
            this.Outros_DHCP_VarText1.Name = "Outros_DHCP_VarText1";
            this.Outros_DHCP_VarText1.Size = new System.Drawing.Size(161, 25);
            this.Outros_DHCP_VarText1.TabIndex = 236;
            // 
            // Outros_DHCP_VarText8
            // 
            this.Outros_DHCP_VarText8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_VarText8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_VarText8.Location = new System.Drawing.Point(128, 365);
            this.Outros_DHCP_VarText8.Name = "Outros_DHCP_VarText8";
            this.Outros_DHCP_VarText8.Size = new System.Drawing.Size(129, 25);
            this.Outros_DHCP_VarText8.TabIndex = 235;
            // 
            // Outros_DHCP_Label1
            // 
            this.Outros_DHCP_Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_Label1.AutoSize = true;
            this.Outros_DHCP_Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_DHCP_Label1.Location = new System.Drawing.Point(199, 106);
            this.Outros_DHCP_Label1.Name = "Outros_DHCP_Label1";
            this.Outros_DHCP_Label1.Size = new System.Drawing.Size(108, 17);
            this.Outros_DHCP_Label1.TabIndex = 234;
            this.Outros_DHCP_Label1.Text = "Interface de LAN:";
            // 
            // Outros_DHCP_Label9
            // 
            this.Outros_DHCP_Label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_Label9.AutoSize = true;
            this.Outros_DHCP_Label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_DHCP_Label9.Location = new System.Drawing.Point(13, 368);
            this.Outros_DHCP_Label9.Name = "Outros_DHCP_Label9";
            this.Outros_DHCP_Label9.Size = new System.Drawing.Size(57, 17);
            this.Outros_DHCP_Label9.TabIndex = 233;
            this.Outros_DHCP_Label9.Text = "Dominio";
            // 
            // Outros_DHCP_Label0
            // 
            this.Outros_DHCP_Label0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_Label0.AutoSize = true;
            this.Outros_DHCP_Label0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_Label0.Location = new System.Drawing.Point(199, 76);
            this.Outros_DHCP_Label0.Name = "Outros_DHCP_Label0";
            this.Outros_DHCP_Label0.Size = new System.Drawing.Size(68, 17);
            this.Outros_DHCP_Label0.TabIndex = 232;
            this.Outros_DHCP_Label0.Text = "IP de LAN:";
            // 
            // Outros_DHCP_VarTitle
            // 
            this.Outros_DHCP_VarTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_DHCP_VarTitle.AutoSize = true;
            this.Outros_DHCP_VarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_DHCP_VarTitle.Location = new System.Drawing.Point(210, 36);
            this.Outros_DHCP_VarTitle.Name = "Outros_DHCP_VarTitle";
            this.Outros_DHCP_VarTitle.Size = new System.Drawing.Size(88, 25);
            this.Outros_DHCP_VarTitle.TabIndex = 230;
            this.Outros_DHCP_VarTitle.Text = "Variáveis";
            // 
            // Outros_TabVlan
            // 
            this.Outros_TabVlan.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_FortigateButton);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_CatalystCheckBox);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_MascaraBox);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_Guide);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_VarDel1);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_ExTitleLabel);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_ExLabel1);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_ExLabel0);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_VarDel0);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_ClearAllButton);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_VarText1);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_VarLabel1);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_VarLabel0);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_VarText0);
            this.Outros_TabVlan.Controls.Add(this.Outros_VLAN_LabelTitle);
            this.Outros_TabVlan.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabVlan.Name = "Outros_TabVlan";
            this.Outros_TabVlan.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabVlan.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabVlan.TabIndex = 5;
            this.Outros_TabVlan.Text = "VLAN";
            // 
            // Outros_VLAN_FortigateButton
            // 
            this.Outros_VLAN_FortigateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_FortigateButton.Location = new System.Drawing.Point(341, 171);
            this.Outros_VLAN_FortigateButton.Name = "Outros_VLAN_FortigateButton";
            this.Outros_VLAN_FortigateButton.Size = new System.Drawing.Size(104, 44);
            this.Outros_VLAN_FortigateButton.TabIndex = 287;
            this.Outros_VLAN_FortigateButton.Text = "Fortigate";
            this.Outros_VLAN_FortigateButton.UseVisualStyleBackColor = true;
            this.Outros_VLAN_FortigateButton.Click += new System.EventHandler(this.Outros_VLAN_FortigateButton_Click);
            // 
            // Outros_VLAN_CatalystCheckBox
            // 
            this.Outros_VLAN_CatalystCheckBox.AutoSize = true;
            this.Outros_VLAN_CatalystCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Outros_VLAN_CatalystCheckBox.Location = new System.Drawing.Point(312, 40);
            this.Outros_VLAN_CatalystCheckBox.Name = "Outros_VLAN_CatalystCheckBox";
            this.Outros_VLAN_CatalystCheckBox.Size = new System.Drawing.Size(98, 19);
            this.Outros_VLAN_CatalystCheckBox.TabIndex = 286;
            this.Outros_VLAN_CatalystCheckBox.Text = "Cisco Catalyst";
            this.Outros_VLAN_CatalystCheckBox.UseVisualStyleBackColor = true;
            // 
            // Outros_VLAN_MascaraBox
            // 
            this.Outros_VLAN_MascaraBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_MascaraBox.FormattingEnabled = true;
            this.Outros_VLAN_MascaraBox.Items.AddRange(new object[] {
            "/30",
            "/29",
            "/28",
            "/27",
            "/26",
            "/25",
            "/24"});
            this.Outros_VLAN_MascaraBox.Location = new System.Drawing.Point(420, 104);
            this.Outros_VLAN_MascaraBox.Name = "Outros_VLAN_MascaraBox";
            this.Outros_VLAN_MascaraBox.Size = new System.Drawing.Size(54, 25);
            this.Outros_VLAN_MascaraBox.TabIndex = 285;
            // 
            // Outros_VLAN_Guide
            // 
            this.Outros_VLAN_Guide.AutoSize = true;
            this.Outros_VLAN_Guide.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outros_VLAN_Guide.Location = new System.Drawing.Point(12, 40);
            this.Outros_VLAN_Guide.Name = "Outros_VLAN_Guide";
            this.Outros_VLAN_Guide.Size = new System.Drawing.Size(74, 20);
            this.Outros_VLAN_Guide.TabIndex = 250;
            this.Outros_VLAN_Guide.Text = "Guia aqui";
            // 
            // Outros_VLAN_VarDel1
            // 
            this.Outros_VLAN_VarDel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VLAN_VarDel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_VarDel1.Location = new System.Drawing.Point(480, 104);
            this.Outros_VLAN_VarDel1.Name = "Outros_VLAN_VarDel1";
            this.Outros_VLAN_VarDel1.Size = new System.Drawing.Size(20, 25);
            this.Outros_VLAN_VarDel1.TabIndex = 244;
            this.Outros_VLAN_VarDel1.Text = "-";
            this.Outros_VLAN_VarDel1.UseVisualStyleBackColor = true;
            this.Outros_VLAN_VarDel1.Click += new System.EventHandler(this.Outros_VLAN_VarDel1_Click);
            // 
            // Outros_VLAN_ExTitleLabel
            // 
            this.Outros_VLAN_ExTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VLAN_ExTitleLabel.AutoSize = true;
            this.Outros_VLAN_ExTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_ExTitleLabel.Location = new System.Drawing.Point(511, 40);
            this.Outros_VLAN_ExTitleLabel.Name = "Outros_VLAN_ExTitleLabel";
            this.Outros_VLAN_ExTitleLabel.Size = new System.Drawing.Size(77, 20);
            this.Outros_VLAN_ExTitleLabel.TabIndex = 242;
            this.Outros_VLAN_ExTitleLabel.Text = "Exemplos:";
            // 
            // Outros_VLAN_ExLabel1
            // 
            this.Outros_VLAN_ExLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VLAN_ExLabel1.AutoSize = true;
            this.Outros_VLAN_ExLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_ExLabel1.Location = new System.Drawing.Point(512, 109);
            this.Outros_VLAN_ExLabel1.Name = "Outros_VLAN_ExLabel1";
            this.Outros_VLAN_ExLabel1.Size = new System.Drawing.Size(57, 15);
            this.Outros_VLAN_ExLabel1.TabIndex = 240;
            this.Outros_VLAN_ExLabel1.Text = "10.10.10.1";
            // 
            // Outros_VLAN_ExLabel0
            // 
            this.Outros_VLAN_ExLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VLAN_ExLabel0.AutoSize = true;
            this.Outros_VLAN_ExLabel0.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_ExLabel0.Location = new System.Drawing.Point(512, 76);
            this.Outros_VLAN_ExLabel0.Name = "Outros_VLAN_ExLabel0";
            this.Outros_VLAN_ExLabel0.Size = new System.Drawing.Size(108, 15);
            this.Outros_VLAN_ExLabel0.TabIndex = 239;
            this.Outros_VLAN_ExLabel0.Text = "GigabitEthernet0/0";
            // 
            // Outros_VLAN_VarDel0
            // 
            this.Outros_VLAN_VarDel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VLAN_VarDel0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_VarDel0.Location = new System.Drawing.Point(480, 70);
            this.Outros_VLAN_VarDel0.Name = "Outros_VLAN_VarDel0";
            this.Outros_VLAN_VarDel0.Size = new System.Drawing.Size(20, 25);
            this.Outros_VLAN_VarDel0.TabIndex = 238;
            this.Outros_VLAN_VarDel0.Text = "-";
            this.Outros_VLAN_VarDel0.UseVisualStyleBackColor = true;
            this.Outros_VLAN_VarDel0.Click += new System.EventHandler(this.Outros_VLAN_VarDel0_Click);
            // 
            // Outros_VLAN_ClearAllButton
            // 
            this.Outros_VLAN_ClearAllButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VLAN_ClearAllButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_ClearAllButton.Location = new System.Drawing.Point(421, 35);
            this.Outros_VLAN_ClearAllButton.Name = "Outros_VLAN_ClearAllButton";
            this.Outros_VLAN_ClearAllButton.Size = new System.Drawing.Size(79, 30);
            this.Outros_VLAN_ClearAllButton.TabIndex = 237;
            this.Outros_VLAN_ClearAllButton.Text = "Limpar";
            this.Outros_VLAN_ClearAllButton.UseVisualStyleBackColor = true;
            this.Outros_VLAN_ClearAllButton.Click += new System.EventHandler(this.Outros_VLAN_ClearAllButton_Click);
            // 
            // Outros_VLAN_VarText1
            // 
            this.Outros_VLAN_VarText1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VLAN_VarText1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_VarText1.Location = new System.Drawing.Point(312, 70);
            this.Outros_VLAN_VarText1.Name = "Outros_VLAN_VarText1";
            this.Outros_VLAN_VarText1.Size = new System.Drawing.Size(162, 25);
            this.Outros_VLAN_VarText1.TabIndex = 235;
            // 
            // Outros_VLAN_VarLabel1
            // 
            this.Outros_VLAN_VarLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VLAN_VarLabel1.AutoSize = true;
            this.Outros_VLAN_VarLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_VLAN_VarLabel1.Location = new System.Drawing.Point(212, 109);
            this.Outros_VLAN_VarLabel1.Name = "Outros_VLAN_VarLabel1";
            this.Outros_VLAN_VarLabel1.Size = new System.Drawing.Size(68, 17);
            this.Outros_VLAN_VarLabel1.TabIndex = 233;
            this.Outros_VLAN_VarLabel1.Text = "IP de LAN:";
            // 
            // Outros_VLAN_VarLabel0
            // 
            this.Outros_VLAN_VarLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VLAN_VarLabel0.AutoSize = true;
            this.Outros_VLAN_VarLabel0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_VarLabel0.Location = new System.Drawing.Point(212, 74);
            this.Outros_VLAN_VarLabel0.Name = "Outros_VLAN_VarLabel0";
            this.Outros_VLAN_VarLabel0.Size = new System.Drawing.Size(89, 17);
            this.Outros_VLAN_VarLabel0.TabIndex = 232;
            this.Outros_VLAN_VarLabel0.Text = "Interface LAN:";
            // 
            // Outros_VLAN_VarText0
            // 
            this.Outros_VLAN_VarText0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VLAN_VarText0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_VarText0.Location = new System.Drawing.Point(312, 104);
            this.Outros_VLAN_VarText0.Name = "Outros_VLAN_VarText0";
            this.Outros_VLAN_VarText0.Size = new System.Drawing.Size(102, 25);
            this.Outros_VLAN_VarText0.TabIndex = 231;
            // 
            // Outros_VLAN_LabelTitle
            // 
            this.Outros_VLAN_LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_VLAN_LabelTitle.AutoSize = true;
            this.Outros_VLAN_LabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_VLAN_LabelTitle.Location = new System.Drawing.Point(210, 35);
            this.Outros_VLAN_LabelTitle.Name = "Outros_VLAN_LabelTitle";
            this.Outros_VLAN_LabelTitle.Size = new System.Drawing.Size(88, 25);
            this.Outros_VLAN_LabelTitle.TabIndex = 230;
            this.Outros_VLAN_LabelTitle.Text = "Variáveis";
            // 
            // Outros_TabUSUARIOS
            // 
            this.Outros_TabUSUARIOS.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_Hint);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_Guide);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_Label2);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_VarPrivBox);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_VarDelete1);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_ExTitle);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_ExLabel2);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_ExLabel1);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_ExLabel0);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_VarDelete0);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_ClearButton);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_VarText1);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_Label1);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_Label0);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_VarText0);
            this.Outros_TabUSUARIOS.Controls.Add(this.Outros_User_VarTitle);
            this.Outros_TabUSUARIOS.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabUSUARIOS.Name = "Outros_TabUSUARIOS";
            this.Outros_TabUSUARIOS.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabUSUARIOS.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabUSUARIOS.TabIndex = 6;
            this.Outros_TabUSUARIOS.Text = "USUARIOS";
            // 
            // Outros_User_Hint
            // 
            this.Outros_User_Hint.AutoSize = true;
            this.Outros_User_Hint.Location = new System.Drawing.Point(253, 186);
            this.Outros_User_Hint.Name = "Outros_User_Hint";
            this.Outros_User_Hint.Size = new System.Drawing.Size(359, 38);
            this.Outros_User_Hint.TabIndex = 263;
            this.Outros_User_Hint.Text = "Cisco? Nível de Privilégio 15 da Acesso Total ao usuario.\r\nSendo utilizado apenas" +
    " em clientes especiais";
            // 
            // Outros_User_Guide
            // 
            this.Outros_User_Guide.AutoSize = true;
            this.Outros_User_Guide.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outros_User_Guide.Location = new System.Drawing.Point(21, 39);
            this.Outros_User_Guide.Name = "Outros_User_Guide";
            this.Outros_User_Guide.Size = new System.Drawing.Size(74, 20);
            this.Outros_User_Guide.TabIndex = 262;
            this.Outros_User_Guide.Text = "Guia aqui";
            // 
            // Outros_User_Label2
            // 
            this.Outros_User_Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_User_Label2.AutoSize = true;
            this.Outros_User_Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_Label2.Location = new System.Drawing.Point(274, 137);
            this.Outros_User_Label2.Name = "Outros_User_Label2";
            this.Outros_User_Label2.Size = new System.Drawing.Size(64, 17);
            this.Outros_User_Label2.TabIndex = 261;
            this.Outros_User_Label2.Text = "Privilégio:";
            // 
            // Outros_User_VarPrivBox
            // 
            this.Outros_User_VarPrivBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Outros_User_VarPrivBox.FormattingEnabled = true;
            this.Outros_User_VarPrivBox.Items.AddRange(new object[] {
            "Leitura",
            "Escrita"});
            this.Outros_User_VarPrivBox.Location = new System.Drawing.Point(357, 131);
            this.Outros_User_VarPrivBox.Name = "Outros_User_VarPrivBox";
            this.Outros_User_VarPrivBox.Size = new System.Drawing.Size(133, 27);
            this.Outros_User_VarPrivBox.TabIndex = 260;
            // 
            // Outros_User_VarDelete1
            // 
            this.Outros_User_VarDelete1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_VarDelete1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_VarDelete1.Location = new System.Drawing.Point(470, 100);
            this.Outros_User_VarDelete1.Name = "Outros_User_VarDelete1";
            this.Outros_User_VarDelete1.Size = new System.Drawing.Size(20, 25);
            this.Outros_User_VarDelete1.TabIndex = 259;
            this.Outros_User_VarDelete1.Text = "-";
            this.Outros_User_VarDelete1.UseVisualStyleBackColor = true;
            this.Outros_User_VarDelete1.Click += new System.EventHandler(this.Outros_User_VarDelete1_Click);
            // 
            // Outros_User_ExTitle
            // 
            this.Outros_User_ExTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_ExTitle.AutoSize = true;
            this.Outros_User_ExTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_ExTitle.Location = new System.Drawing.Point(501, 40);
            this.Outros_User_ExTitle.Name = "Outros_User_ExTitle";
            this.Outros_User_ExTitle.Size = new System.Drawing.Size(77, 20);
            this.Outros_User_ExTitle.TabIndex = 258;
            this.Outros_User_ExTitle.Text = "Exemplos:";
            // 
            // Outros_User_ExLabel2
            // 
            this.Outros_User_ExLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_ExLabel2.AutoSize = true;
            this.Outros_User_ExLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_ExLabel2.Location = new System.Drawing.Point(501, 138);
            this.Outros_User_ExLabel2.Name = "Outros_User_ExLabel2";
            this.Outros_User_ExLabel2.Size = new System.Drawing.Size(97, 15);
            this.Outros_User_ExLabel2.TabIndex = 257;
            this.Outros_User_ExLabel2.Text = "Escrita ou Leitura";
            // 
            // Outros_User_ExLabel1
            // 
            this.Outros_User_ExLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_ExLabel1.AutoSize = true;
            this.Outros_User_ExLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_ExLabel1.Location = new System.Drawing.Point(501, 106);
            this.Outros_User_ExLabel1.Name = "Outros_User_ExLabel1";
            this.Outros_User_ExLabel1.Size = new System.Drawing.Size(42, 15);
            this.Outros_User_ExLabel1.TabIndex = 256;
            this.Outros_User_ExLabel1.Text = "S3nh4";
            // 
            // Outros_User_ExLabel0
            // 
            this.Outros_User_ExLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_ExLabel0.AutoSize = true;
            this.Outros_User_ExLabel0.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_ExLabel0.Location = new System.Drawing.Point(501, 73);
            this.Outros_User_ExLabel0.Name = "Outros_User_ExLabel0";
            this.Outros_User_ExLabel0.Size = new System.Drawing.Size(27, 15);
            this.Outros_User_ExLabel0.TabIndex = 255;
            this.Outros_User_ExLabel0.Text = "EBT";
            // 
            // Outros_User_VarDelete0
            // 
            this.Outros_User_VarDelete0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_VarDelete0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_VarDelete0.Location = new System.Drawing.Point(470, 70);
            this.Outros_User_VarDelete0.Name = "Outros_User_VarDelete0";
            this.Outros_User_VarDelete0.Size = new System.Drawing.Size(20, 25);
            this.Outros_User_VarDelete0.TabIndex = 254;
            this.Outros_User_VarDelete0.Text = "-";
            this.Outros_User_VarDelete0.UseVisualStyleBackColor = true;
            this.Outros_User_VarDelete0.Click += new System.EventHandler(this.Outros_User_VarDelete0_Click);
            // 
            // Outros_User_ClearButton
            // 
            this.Outros_User_ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_ClearButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_ClearButton.Location = new System.Drawing.Point(411, 35);
            this.Outros_User_ClearButton.Name = "Outros_User_ClearButton";
            this.Outros_User_ClearButton.Size = new System.Drawing.Size(79, 30);
            this.Outros_User_ClearButton.TabIndex = 253;
            this.Outros_User_ClearButton.Text = "Limpar";
            this.Outros_User_ClearButton.UseVisualStyleBackColor = true;
            this.Outros_User_ClearButton.Click += new System.EventHandler(this.Outros_User_ClearButton_Click);
            // 
            // Outros_User_VarText1
            // 
            this.Outros_User_VarText1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_VarText1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_VarText1.Location = new System.Drawing.Point(357, 100);
            this.Outros_User_VarText1.Name = "Outros_User_VarText1";
            this.Outros_User_VarText1.Size = new System.Drawing.Size(107, 25);
            this.Outros_User_VarText1.TabIndex = 251;
            // 
            // Outros_User_Label1
            // 
            this.Outros_User_Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_Label1.AutoSize = true;
            this.Outros_User_Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_User_Label1.Location = new System.Drawing.Point(274, 105);
            this.Outros_User_Label1.Name = "Outros_User_Label1";
            this.Outros_User_Label1.Size = new System.Drawing.Size(67, 17);
            this.Outros_User_Label1.TabIndex = 249;
            this.Outros_User_Label1.Text = "Password:";
            // 
            // Outros_User_Label0
            // 
            this.Outros_User_Label0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_Label0.AutoSize = true;
            this.Outros_User_Label0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_Label0.Location = new System.Drawing.Point(274, 74);
            this.Outros_User_Label0.Name = "Outros_User_Label0";
            this.Outros_User_Label0.Size = new System.Drawing.Size(70, 17);
            this.Outros_User_Label0.TabIndex = 248;
            this.Outros_User_Label0.Text = "Username:";
            // 
            // Outros_User_VarText0
            // 
            this.Outros_User_VarText0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_VarText0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_VarText0.Location = new System.Drawing.Point(357, 70);
            this.Outros_User_VarText0.Name = "Outros_User_VarText0";
            this.Outros_User_VarText0.Size = new System.Drawing.Size(107, 25);
            this.Outros_User_VarText0.TabIndex = 247;
            // 
            // Outros_User_VarTitle
            // 
            this.Outros_User_VarTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_User_VarTitle.AutoSize = true;
            this.Outros_User_VarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_User_VarTitle.Location = new System.Drawing.Point(272, 35);
            this.Outros_User_VarTitle.Name = "Outros_User_VarTitle";
            this.Outros_User_VarTitle.Size = new System.Drawing.Size(88, 25);
            this.Outros_User_VarTitle.TabIndex = 246;
            this.Outros_User_VarTitle.Text = "Variáveis";
            // 
            // Outros_Tab_FortiVlan
            // 
            this.Outros_Tab_FortiVlan.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_Tab_FortiVlan.Controls.Add(this.Outros_FortiVlan_Label);
            this.Outros_Tab_FortiVlan.Location = new System.Drawing.Point(4, 5);
            this.Outros_Tab_FortiVlan.Name = "Outros_Tab_FortiVlan";
            this.Outros_Tab_FortiVlan.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_Tab_FortiVlan.Size = new System.Drawing.Size(629, 436);
            this.Outros_Tab_FortiVlan.TabIndex = 7;
            this.Outros_Tab_FortiVlan.Text = "Vlan Fortigate";
            // 
            // Outros_FortiVlan_Label
            // 
            this.Outros_FortiVlan_Label.AutoSize = true;
            this.Outros_FortiVlan_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outros_FortiVlan_Label.Location = new System.Drawing.Point(21, 33);
            this.Outros_FortiVlan_Label.Name = "Outros_FortiVlan_Label";
            this.Outros_FortiVlan_Label.Size = new System.Drawing.Size(74, 20);
            this.Outros_FortiVlan_Label.TabIndex = 263;
            this.Outros_FortiVlan_Label.Text = "Guia aqui";
            // 
            // Outros_TabFortiExtras
            // 
            this.Outros_TabFortiExtras.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabFortiExtras.Controls.Add(this.label72);
            this.Outros_TabFortiExtras.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabFortiExtras.Name = "Outros_TabFortiExtras";
            this.Outros_TabFortiExtras.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabFortiExtras.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabFortiExtras.TabIndex = 8;
            this.Outros_TabFortiExtras.Text = "Fortigate Extras";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label72.Location = new System.Drawing.Point(12, 29);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(74, 20);
            this.label72.TabIndex = 263;
            this.label72.Text = "Guia aqui";
            // 
            // Outros_TabIPFLow
            // 
            this.Outros_TabIPFLow.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_DelButton2);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_DelButton1);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_ExTitle);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_ExLabel2);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_ExLabel1);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_ExLabel0);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_DelButton0);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_ClearButton);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_VarText2);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_VarText1);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_Label2);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_Label1);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_Label0);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_VarText0);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_VarTitle);
            this.Outros_TabIPFLow.Controls.Add(this.Outros_IPFlow_Guide);
            this.Outros_TabIPFLow.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabIPFLow.Name = "Outros_TabIPFLow";
            this.Outros_TabIPFLow.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabIPFLow.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabIPFLow.TabIndex = 9;
            this.Outros_TabIPFLow.Text = "IP Flow";
            // 
            // Outros_IPFlow_DelButton2
            // 
            this.Outros_IPFlow_DelButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_DelButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_DelButton2.Location = new System.Drawing.Point(487, 130);
            this.Outros_IPFlow_DelButton2.Name = "Outros_IPFlow_DelButton2";
            this.Outros_IPFlow_DelButton2.Size = new System.Drawing.Size(20, 25);
            this.Outros_IPFlow_DelButton2.TabIndex = 279;
            this.Outros_IPFlow_DelButton2.Text = "-";
            this.Outros_IPFlow_DelButton2.UseVisualStyleBackColor = true;
            // 
            // Outros_IPFlow_DelButton1
            // 
            this.Outros_IPFlow_DelButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_DelButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_DelButton1.Location = new System.Drawing.Point(487, 100);
            this.Outros_IPFlow_DelButton1.Name = "Outros_IPFlow_DelButton1";
            this.Outros_IPFlow_DelButton1.Size = new System.Drawing.Size(20, 25);
            this.Outros_IPFlow_DelButton1.TabIndex = 278;
            this.Outros_IPFlow_DelButton1.Text = "-";
            this.Outros_IPFlow_DelButton1.UseVisualStyleBackColor = true;
            // 
            // Outros_IPFlow_ExTitle
            // 
            this.Outros_IPFlow_ExTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_ExTitle.AutoSize = true;
            this.Outros_IPFlow_ExTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_ExTitle.Location = new System.Drawing.Point(519, 40);
            this.Outros_IPFlow_ExTitle.Name = "Outros_IPFlow_ExTitle";
            this.Outros_IPFlow_ExTitle.Size = new System.Drawing.Size(77, 20);
            this.Outros_IPFlow_ExTitle.TabIndex = 277;
            this.Outros_IPFlow_ExTitle.Text = "Exemplos:";
            // 
            // Outros_IPFlow_ExLabel2
            // 
            this.Outros_IPFlow_ExLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_ExLabel2.AutoSize = true;
            this.Outros_IPFlow_ExLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_ExLabel2.Location = new System.Drawing.Point(519, 135);
            this.Outros_IPFlow_ExLabel2.Name = "Outros_IPFlow_ExLabel2";
            this.Outros_IPFlow_ExLabel2.Size = new System.Drawing.Size(35, 15);
            this.Outros_IPFlow_ExLabel2.TabIndex = 276;
            this.Outros_IPFlow_ExLabel2.Text = "9996";
            // 
            // Outros_IPFlow_ExLabel1
            // 
            this.Outros_IPFlow_ExLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_ExLabel1.AutoSize = true;
            this.Outros_IPFlow_ExLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_ExLabel1.Location = new System.Drawing.Point(519, 106);
            this.Outros_IPFlow_ExLabel1.Name = "Outros_IPFlow_ExLabel1";
            this.Outros_IPFlow_ExLabel1.Size = new System.Drawing.Size(57, 15);
            this.Outros_IPFlow_ExLabel1.TabIndex = 275;
            this.Outros_IPFlow_ExLabel1.Text = "10.10.10.1";
            // 
            // Outros_IPFlow_ExLabel0
            // 
            this.Outros_IPFlow_ExLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_ExLabel0.AutoSize = true;
            this.Outros_IPFlow_ExLabel0.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_ExLabel0.Location = new System.Drawing.Point(519, 75);
            this.Outros_IPFlow_ExLabel0.Name = "Outros_IPFlow_ExLabel0";
            this.Outros_IPFlow_ExLabel0.Size = new System.Drawing.Size(108, 15);
            this.Outros_IPFlow_ExLabel0.TabIndex = 274;
            this.Outros_IPFlow_ExLabel0.Text = "GigabitEthernet0/0";
            // 
            // Outros_IPFlow_DelButton0
            // 
            this.Outros_IPFlow_DelButton0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_DelButton0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_DelButton0.Location = new System.Drawing.Point(487, 70);
            this.Outros_IPFlow_DelButton0.Name = "Outros_IPFlow_DelButton0";
            this.Outros_IPFlow_DelButton0.Size = new System.Drawing.Size(20, 25);
            this.Outros_IPFlow_DelButton0.TabIndex = 273;
            this.Outros_IPFlow_DelButton0.Text = "-";
            this.Outros_IPFlow_DelButton0.UseVisualStyleBackColor = true;
            // 
            // Outros_IPFlow_ClearButton
            // 
            this.Outros_IPFlow_ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_ClearButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_ClearButton.Location = new System.Drawing.Point(429, 35);
            this.Outros_IPFlow_ClearButton.Name = "Outros_IPFlow_ClearButton";
            this.Outros_IPFlow_ClearButton.Size = new System.Drawing.Size(79, 30);
            this.Outros_IPFlow_ClearButton.TabIndex = 272;
            this.Outros_IPFlow_ClearButton.Text = "Limpar";
            this.Outros_IPFlow_ClearButton.UseVisualStyleBackColor = true;
            // 
            // Outros_IPFlow_VarText2
            // 
            this.Outros_IPFlow_VarText2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_VarText2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_VarText2.Location = new System.Drawing.Point(353, 130);
            this.Outros_IPFlow_VarText2.Name = "Outros_IPFlow_VarText2";
            this.Outros_IPFlow_VarText2.Size = new System.Drawing.Size(129, 25);
            this.Outros_IPFlow_VarText2.TabIndex = 271;
            // 
            // Outros_IPFlow_VarText1
            // 
            this.Outros_IPFlow_VarText1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_VarText1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_VarText1.Location = new System.Drawing.Point(353, 100);
            this.Outros_IPFlow_VarText1.Name = "Outros_IPFlow_VarText1";
            this.Outros_IPFlow_VarText1.Size = new System.Drawing.Size(129, 25);
            this.Outros_IPFlow_VarText1.TabIndex = 270;
            // 
            // Outros_IPFlow_Label2
            // 
            this.Outros_IPFlow_Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_Label2.AutoSize = true;
            this.Outros_IPFlow_Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_IPFlow_Label2.Location = new System.Drawing.Point(238, 134);
            this.Outros_IPFlow_Label2.Name = "Outros_IPFlow_Label2";
            this.Outros_IPFlow_Label2.Size = new System.Drawing.Size(36, 17);
            this.Outros_IPFlow_Label2.TabIndex = 269;
            this.Outros_IPFlow_Label2.Text = "UDP:";
            // 
            // Outros_IPFlow_Label1
            // 
            this.Outros_IPFlow_Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_Label1.AutoSize = true;
            this.Outros_IPFlow_Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Outros_IPFlow_Label1.Location = new System.Drawing.Point(238, 104);
            this.Outros_IPFlow_Label1.Name = "Outros_IPFlow_Label1";
            this.Outros_IPFlow_Label1.Size = new System.Drawing.Size(88, 17);
            this.Outros_IPFlow_Label1.TabIndex = 268;
            this.Outros_IPFlow_Label1.Text = "IP de Destino:";
            // 
            // Outros_IPFlow_Label0
            // 
            this.Outros_IPFlow_Label0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_Label0.AutoSize = true;
            this.Outros_IPFlow_Label0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_Label0.Location = new System.Drawing.Point(238, 73);
            this.Outros_IPFlow_Label0.Name = "Outros_IPFlow_Label0";
            this.Outros_IPFlow_Label0.Size = new System.Drawing.Size(89, 17);
            this.Outros_IPFlow_Label0.TabIndex = 267;
            this.Outros_IPFlow_Label0.Text = "Interface LAN:";
            // 
            // Outros_IPFlow_VarText0
            // 
            this.Outros_IPFlow_VarText0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_VarText0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_VarText0.Location = new System.Drawing.Point(353, 70);
            this.Outros_IPFlow_VarText0.Name = "Outros_IPFlow_VarText0";
            this.Outros_IPFlow_VarText0.Size = new System.Drawing.Size(129, 25);
            this.Outros_IPFlow_VarText0.TabIndex = 266;
            // 
            // Outros_IPFlow_VarTitle
            // 
            this.Outros_IPFlow_VarTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_IPFlow_VarTitle.AutoSize = true;
            this.Outros_IPFlow_VarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_IPFlow_VarTitle.Location = new System.Drawing.Point(236, 34);
            this.Outros_IPFlow_VarTitle.Name = "Outros_IPFlow_VarTitle";
            this.Outros_IPFlow_VarTitle.Size = new System.Drawing.Size(88, 25);
            this.Outros_IPFlow_VarTitle.TabIndex = 265;
            this.Outros_IPFlow_VarTitle.Text = "Variáveis";
            // 
            // Outros_IPFlow_Guide
            // 
            this.Outros_IPFlow_Guide.AutoSize = true;
            this.Outros_IPFlow_Guide.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outros_IPFlow_Guide.Location = new System.Drawing.Point(33, 33);
            this.Outros_IPFlow_Guide.Name = "Outros_IPFlow_Guide";
            this.Outros_IPFlow_Guide.Size = new System.Drawing.Size(74, 20);
            this.Outros_IPFlow_Guide.TabIndex = 264;
            this.Outros_IPFlow_Guide.Text = "Guia aqui";
            // 
            // Outros_TabRIP
            // 
            this.Outros_TabRIP.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabRIP.Controls.Add(this.label73);
            this.Outros_TabRIP.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabRIP.Name = "Outros_TabRIP";
            this.Outros_TabRIP.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabRIP.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabRIP.TabIndex = 10;
            this.Outros_TabRIP.Text = "RIP";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label73.Location = new System.Drawing.Point(24, 43);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(0, 20);
            this.label73.TabIndex = 265;
            // 
            // Outros_TabOSPF
            // 
            this.Outros_TabOSPF.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabOSPF.Controls.Add(this.label74);
            this.Outros_TabOSPF.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabOSPF.Name = "Outros_TabOSPF";
            this.Outros_TabOSPF.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabOSPF.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabOSPF.TabIndex = 11;
            this.Outros_TabOSPF.Text = "OSPF";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label74.Location = new System.Drawing.Point(9, 28);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(0, 15);
            this.label74.TabIndex = 265;
            // 
            // Outros_TabVRRP
            // 
            this.Outros_TabVRRP.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton12);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText12);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label12);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton11);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText11);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label11);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton7);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText7);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label7);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton6);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText6);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label6);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton10);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton9);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExTitle2);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExLabel10);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExLabel9);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExLabel8);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton8);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ClearButton2);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText10);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText9);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label10);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label9);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText8);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label8);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_SubTitle2);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton5);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton4);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExTitle1);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExLabel5);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExLabel4);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExLabel3);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton3);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ClearButton1);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText5);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText4);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label5);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label4);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label3);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText3);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_SubTitle1);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton2);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton1);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExTitle0);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExLabel2);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExLabel1);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ExLabel0);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_DelButton0);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_ClearButton0);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText2);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText1);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label2);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label1);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Label0);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_VarText0);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_SubTitle0);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_CheckBoxCisco);
            this.Outros_TabVRRP.Controls.Add(this.Outro_VRRP_Guide);
            this.Outros_TabVRRP.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabVRRP.Name = "Outros_TabVRRP";
            this.Outros_TabVRRP.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabVRRP.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabVRRP.TabIndex = 12;
            this.Outros_TabVRRP.Text = "VRRP";
            // 
            // Outro_VRRP_DelButton12
            // 
            this.Outro_VRRP_DelButton12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton12.Location = new System.Drawing.Point(529, 312);
            this.Outro_VRRP_DelButton12.Name = "Outro_VRRP_DelButton12";
            this.Outro_VRRP_DelButton12.Size = new System.Drawing.Size(20, 25);
            this.Outro_VRRP_DelButton12.TabIndex = 344;
            this.Outro_VRRP_DelButton12.Text = "-";
            this.Outro_VRRP_DelButton12.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_VarText12
            // 
            this.Outro_VRRP_VarText12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText12.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText12.Location = new System.Drawing.Point(423, 312);
            this.Outro_VRRP_VarText12.Name = "Outro_VRRP_VarText12";
            this.Outro_VRRP_VarText12.Size = new System.Drawing.Size(98, 21);
            this.Outro_VRRP_VarText12.TabIndex = 343;
            // 
            // Outro_VRRP_Label12
            // 
            this.Outro_VRRP_Label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label12.AutoSize = true;
            this.Outro_VRRP_Label12.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label12.Location = new System.Drawing.Point(323, 317);
            this.Outro_VRRP_Label12.Name = "Outro_VRRP_Label12";
            this.Outro_VRRP_Label12.Size = new System.Drawing.Size(95, 13);
            this.Outro_VRRP_Label12.TabIndex = 342;
            this.Outro_VRRP_Label12.Text = "Leitura ou Escrita";
            // 
            // Outro_VRRP_DelButton11
            // 
            this.Outro_VRRP_DelButton11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton11.Location = new System.Drawing.Point(529, 288);
            this.Outro_VRRP_DelButton11.Name = "Outro_VRRP_DelButton11";
            this.Outro_VRRP_DelButton11.Size = new System.Drawing.Size(20, 25);
            this.Outro_VRRP_DelButton11.TabIndex = 341;
            this.Outro_VRRP_DelButton11.Text = "-";
            this.Outro_VRRP_DelButton11.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_VarText11
            // 
            this.Outro_VRRP_VarText11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText11.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText11.Location = new System.Drawing.Point(423, 288);
            this.Outro_VRRP_VarText11.Name = "Outro_VRRP_VarText11";
            this.Outro_VRRP_VarText11.Size = new System.Drawing.Size(98, 21);
            this.Outro_VRRP_VarText11.TabIndex = 340;
            // 
            // Outro_VRRP_Label11
            // 
            this.Outro_VRRP_Label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label11.AutoSize = true;
            this.Outro_VRRP_Label11.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label11.Location = new System.Drawing.Point(322, 293);
            this.Outro_VRRP_Label11.Name = "Outro_VRRP_Label11";
            this.Outro_VRRP_Label11.Size = new System.Drawing.Size(95, 13);
            this.Outro_VRRP_Label11.TabIndex = 339;
            this.Outro_VRRP_Label11.Text = "Leitura ou Escrita";
            // 
            // Outro_VRRP_DelButton7
            // 
            this.Outro_VRRP_DelButton7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton7.Location = new System.Drawing.Point(213, 317);
            this.Outro_VRRP_DelButton7.Name = "Outro_VRRP_DelButton7";
            this.Outro_VRRP_DelButton7.Size = new System.Drawing.Size(20, 25);
            this.Outro_VRRP_DelButton7.TabIndex = 338;
            this.Outro_VRRP_DelButton7.Text = "-";
            this.Outro_VRRP_DelButton7.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_VarText7
            // 
            this.Outro_VRRP_VarText7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText7.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText7.Location = new System.Drawing.Point(108, 317);
            this.Outro_VRRP_VarText7.Name = "Outro_VRRP_VarText7";
            this.Outro_VRRP_VarText7.Size = new System.Drawing.Size(98, 21);
            this.Outro_VRRP_VarText7.TabIndex = 337;
            // 
            // Outro_VRRP_Label7
            // 
            this.Outro_VRRP_Label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label7.AutoSize = true;
            this.Outro_VRRP_Label7.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label7.Location = new System.Drawing.Point(7, 322);
            this.Outro_VRRP_Label7.Name = "Outro_VRRP_Label7";
            this.Outro_VRRP_Label7.Size = new System.Drawing.Size(95, 13);
            this.Outro_VRRP_Label7.TabIndex = 336;
            this.Outro_VRRP_Label7.Text = "Leitura ou Escrita";
            // 
            // Outro_VRRP_DelButton6
            // 
            this.Outro_VRRP_DelButton6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton6.Location = new System.Drawing.Point(213, 292);
            this.Outro_VRRP_DelButton6.Name = "Outro_VRRP_DelButton6";
            this.Outro_VRRP_DelButton6.Size = new System.Drawing.Size(20, 25);
            this.Outro_VRRP_DelButton6.TabIndex = 335;
            this.Outro_VRRP_DelButton6.Text = "-";
            this.Outro_VRRP_DelButton6.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_VarText6
            // 
            this.Outro_VRRP_VarText6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText6.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText6.Location = new System.Drawing.Point(108, 292);
            this.Outro_VRRP_VarText6.Name = "Outro_VRRP_VarText6";
            this.Outro_VRRP_VarText6.Size = new System.Drawing.Size(98, 21);
            this.Outro_VRRP_VarText6.TabIndex = 334;
            // 
            // Outro_VRRP_Label6
            // 
            this.Outro_VRRP_Label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label6.AutoSize = true;
            this.Outro_VRRP_Label6.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label6.Location = new System.Drawing.Point(7, 297);
            this.Outro_VRRP_Label6.Name = "Outro_VRRP_Label6";
            this.Outro_VRRP_Label6.Size = new System.Drawing.Size(95, 13);
            this.Outro_VRRP_Label6.TabIndex = 333;
            this.Outro_VRRP_Label6.Text = "Leitura ou Escrita";
            // 
            // Outro_VRRP_DelButton10
            // 
            this.Outro_VRRP_DelButton10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton10.Location = new System.Drawing.Point(529, 264);
            this.Outro_VRRP_DelButton10.Name = "Outro_VRRP_DelButton10";
            this.Outro_VRRP_DelButton10.Size = new System.Drawing.Size(20, 25);
            this.Outro_VRRP_DelButton10.TabIndex = 332;
            this.Outro_VRRP_DelButton10.Text = "-";
            this.Outro_VRRP_DelButton10.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_DelButton9
            // 
            this.Outro_VRRP_DelButton9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton9.Location = new System.Drawing.Point(529, 240);
            this.Outro_VRRP_DelButton9.Name = "Outro_VRRP_DelButton9";
            this.Outro_VRRP_DelButton9.Size = new System.Drawing.Size(20, 25);
            this.Outro_VRRP_DelButton9.TabIndex = 331;
            this.Outro_VRRP_DelButton9.Text = "-";
            this.Outro_VRRP_DelButton9.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_ExTitle2
            // 
            this.Outro_VRRP_ExTitle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExTitle2.AutoSize = true;
            this.Outro_VRRP_ExTitle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_ExTitle2.Location = new System.Drawing.Point(558, 186);
            this.Outro_VRRP_ExTitle2.Name = "Outro_VRRP_ExTitle2";
            this.Outro_VRRP_ExTitle2.Size = new System.Drawing.Size(77, 20);
            this.Outro_VRRP_ExTitle2.TabIndex = 330;
            this.Outro_VRRP_ExTitle2.Text = "Exemplos:";
            // 
            // Outro_VRRP_ExLabel10
            // 
            this.Outro_VRRP_ExLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExLabel10.AutoSize = true;
            this.Outro_VRRP_ExLabel10.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_ExLabel10.Location = new System.Drawing.Point(558, 269);
            this.Outro_VRRP_ExLabel10.Name = "Outro_VRRP_ExLabel10";
            this.Outro_VRRP_ExLabel10.Size = new System.Drawing.Size(61, 13);
            this.Outro_VRRP_ExLabel10.TabIndex = 329;
            this.Outro_VRRP_ExLabel10.Text = "RO ou RW";
            // 
            // Outro_VRRP_ExLabel9
            // 
            this.Outro_VRRP_ExLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExLabel9.AutoSize = true;
            this.Outro_VRRP_ExLabel9.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_ExLabel9.Location = new System.Drawing.Point(558, 246);
            this.Outro_VRRP_ExLabel9.Name = "Outro_VRRP_ExLabel9";
            this.Outro_VRRP_ExLabel9.Size = new System.Drawing.Size(64, 13);
            this.Outro_VRRP_ExLabel9.TabIndex = 328;
            this.Outro_VRRP_ExLabel9.Text = "192.168.1.1";
            // 
            // Outro_VRRP_ExLabel8
            // 
            this.Outro_VRRP_ExLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExLabel8.AutoSize = true;
            this.Outro_VRRP_ExLabel8.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_ExLabel8.Location = new System.Drawing.Point(558, 221);
            this.Outro_VRRP_ExLabel8.Name = "Outro_VRRP_ExLabel8";
            this.Outro_VRRP_ExLabel8.Size = new System.Drawing.Size(96, 13);
            this.Outro_VRRP_ExLabel8.TabIndex = 327;
            this.Outro_VRRP_ExLabel8.Text = "snmpComunity21";
            // 
            // Outro_VRRP_DelButton8
            // 
            this.Outro_VRRP_DelButton8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton8.Location = new System.Drawing.Point(529, 216);
            this.Outro_VRRP_DelButton8.Name = "Outro_VRRP_DelButton8";
            this.Outro_VRRP_DelButton8.Size = new System.Drawing.Size(20, 25);
            this.Outro_VRRP_DelButton8.TabIndex = 326;
            this.Outro_VRRP_DelButton8.Text = "-";
            this.Outro_VRRP_DelButton8.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_ClearButton2
            // 
            this.Outro_VRRP_ClearButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ClearButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_ClearButton2.Location = new System.Drawing.Point(468, 181);
            this.Outro_VRRP_ClearButton2.Name = "Outro_VRRP_ClearButton2";
            this.Outro_VRRP_ClearButton2.Size = new System.Drawing.Size(79, 30);
            this.Outro_VRRP_ClearButton2.TabIndex = 325;
            this.Outro_VRRP_ClearButton2.Text = "Limpar";
            this.Outro_VRRP_ClearButton2.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_VarText10
            // 
            this.Outro_VRRP_VarText10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText10.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText10.Location = new System.Drawing.Point(423, 264);
            this.Outro_VRRP_VarText10.Name = "Outro_VRRP_VarText10";
            this.Outro_VRRP_VarText10.Size = new System.Drawing.Size(98, 21);
            this.Outro_VRRP_VarText10.TabIndex = 324;
            // 
            // Outro_VRRP_VarText9
            // 
            this.Outro_VRRP_VarText9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText9.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText9.Location = new System.Drawing.Point(423, 240);
            this.Outro_VRRP_VarText9.Name = "Outro_VRRP_VarText9";
            this.Outro_VRRP_VarText9.Size = new System.Drawing.Size(98, 21);
            this.Outro_VRRP_VarText9.TabIndex = 323;
            // 
            // Outro_VRRP_Label10
            // 
            this.Outro_VRRP_Label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label10.AutoSize = true;
            this.Outro_VRRP_Label10.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label10.Location = new System.Drawing.Point(327, 269);
            this.Outro_VRRP_Label10.Name = "Outro_VRRP_Label10";
            this.Outro_VRRP_Label10.Size = new System.Drawing.Size(95, 13);
            this.Outro_VRRP_Label10.TabIndex = 322;
            this.Outro_VRRP_Label10.Text = "Leitura ou Escrita";
            // 
            // Outro_VRRP_Label9
            // 
            this.Outro_VRRP_Label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label9.AutoSize = true;
            this.Outro_VRRP_Label9.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label9.Location = new System.Drawing.Point(327, 245);
            this.Outro_VRRP_Label9.Name = "Outro_VRRP_Label9";
            this.Outro_VRRP_Label9.Size = new System.Drawing.Size(34, 13);
            this.Outro_VRRP_Label9.TabIndex = 321;
            this.Outro_VRRP_Label9.Text = "Host:";
            // 
            // Outro_VRRP_VarText8
            // 
            this.Outro_VRRP_VarText8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText8.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText8.Location = new System.Drawing.Point(423, 216);
            this.Outro_VRRP_VarText8.Name = "Outro_VRRP_VarText8";
            this.Outro_VRRP_VarText8.Size = new System.Drawing.Size(98, 21);
            this.Outro_VRRP_VarText8.TabIndex = 319;
            // 
            // Outro_VRRP_Label8
            // 
            this.Outro_VRRP_Label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label8.AutoSize = true;
            this.Outro_VRRP_Label8.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label8.Location = new System.Drawing.Point(328, 220);
            this.Outro_VRRP_Label8.Name = "Outro_VRRP_Label8";
            this.Outro_VRRP_Label8.Size = new System.Drawing.Size(68, 13);
            this.Outro_VRRP_Label8.TabIndex = 320;
            this.Outro_VRRP_Label8.Text = "Community:";
            // 
            // Outro_VRRP_SubTitle2
            // 
            this.Outro_VRRP_SubTitle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_SubTitle2.AutoSize = true;
            this.Outro_VRRP_SubTitle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_SubTitle2.Location = new System.Drawing.Point(326, 181);
            this.Outro_VRRP_SubTitle2.Name = "Outro_VRRP_SubTitle2";
            this.Outro_VRRP_SubTitle2.Size = new System.Drawing.Size(47, 25);
            this.Outro_VRRP_SubTitle2.TabIndex = 318;
            this.Outro_VRRP_SubTitle2.Text = "HPE";
            // 
            // Outro_VRRP_DelButton5
            // 
            this.Outro_VRRP_DelButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton5.Location = new System.Drawing.Point(213, 267);
            this.Outro_VRRP_DelButton5.Name = "Outro_VRRP_DelButton5";
            this.Outro_VRRP_DelButton5.Size = new System.Drawing.Size(20, 25);
            this.Outro_VRRP_DelButton5.TabIndex = 317;
            this.Outro_VRRP_DelButton5.Text = "-";
            this.Outro_VRRP_DelButton5.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_DelButton4
            // 
            this.Outro_VRRP_DelButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton4.Location = new System.Drawing.Point(213, 242);
            this.Outro_VRRP_DelButton4.Name = "Outro_VRRP_DelButton4";
            this.Outro_VRRP_DelButton4.Size = new System.Drawing.Size(20, 25);
            this.Outro_VRRP_DelButton4.TabIndex = 316;
            this.Outro_VRRP_DelButton4.Text = "-";
            this.Outro_VRRP_DelButton4.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_ExTitle1
            // 
            this.Outro_VRRP_ExTitle1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExTitle1.AutoSize = true;
            this.Outro_VRRP_ExTitle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_ExTitle1.Location = new System.Drawing.Point(245, 187);
            this.Outro_VRRP_ExTitle1.Name = "Outro_VRRP_ExTitle1";
            this.Outro_VRRP_ExTitle1.Size = new System.Drawing.Size(77, 20);
            this.Outro_VRRP_ExTitle1.TabIndex = 315;
            this.Outro_VRRP_ExTitle1.Text = "Exemplos:";
            // 
            // Outro_VRRP_ExLabel5
            // 
            this.Outro_VRRP_ExLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExLabel5.AutoSize = true;
            this.Outro_VRRP_ExLabel5.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_ExLabel5.Location = new System.Drawing.Point(245, 272);
            this.Outro_VRRP_ExLabel5.Name = "Outro_VRRP_ExLabel5";
            this.Outro_VRRP_ExLabel5.Size = new System.Drawing.Size(61, 13);
            this.Outro_VRRP_ExLabel5.TabIndex = 314;
            this.Outro_VRRP_ExLabel5.Text = "RO ou RW";
            // 
            // Outro_VRRP_ExLabel4
            // 
            this.Outro_VRRP_ExLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExLabel4.AutoSize = true;
            this.Outro_VRRP_ExLabel4.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_ExLabel4.Location = new System.Drawing.Point(245, 248);
            this.Outro_VRRP_ExLabel4.Name = "Outro_VRRP_ExLabel4";
            this.Outro_VRRP_ExLabel4.Size = new System.Drawing.Size(64, 13);
            this.Outro_VRRP_ExLabel4.TabIndex = 313;
            this.Outro_VRRP_ExLabel4.Text = "192.168.1.1";
            // 
            // Outro_VRRP_ExLabel3
            // 
            this.Outro_VRRP_ExLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExLabel3.AutoSize = true;
            this.Outro_VRRP_ExLabel3.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_ExLabel3.Location = new System.Drawing.Point(245, 222);
            this.Outro_VRRP_ExLabel3.Name = "Outro_VRRP_ExLabel3";
            this.Outro_VRRP_ExLabel3.Size = new System.Drawing.Size(96, 13);
            this.Outro_VRRP_ExLabel3.TabIndex = 312;
            this.Outro_VRRP_ExLabel3.Text = "snmpComunity21";
            // 
            // Outro_VRRP_DelButton3
            // 
            this.Outro_VRRP_DelButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton3.Location = new System.Drawing.Point(213, 217);
            this.Outro_VRRP_DelButton3.Name = "Outro_VRRP_DelButton3";
            this.Outro_VRRP_DelButton3.Size = new System.Drawing.Size(20, 25);
            this.Outro_VRRP_DelButton3.TabIndex = 311;
            this.Outro_VRRP_DelButton3.Text = "-";
            this.Outro_VRRP_DelButton3.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_ClearButton1
            // 
            this.Outro_VRRP_ClearButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ClearButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_ClearButton1.Location = new System.Drawing.Point(154, 182);
            this.Outro_VRRP_ClearButton1.Name = "Outro_VRRP_ClearButton1";
            this.Outro_VRRP_ClearButton1.Size = new System.Drawing.Size(79, 30);
            this.Outro_VRRP_ClearButton1.TabIndex = 310;
            this.Outro_VRRP_ClearButton1.Text = "Limpar";
            this.Outro_VRRP_ClearButton1.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_VarText5
            // 
            this.Outro_VRRP_VarText5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText5.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText5.Location = new System.Drawing.Point(108, 267);
            this.Outro_VRRP_VarText5.Name = "Outro_VRRP_VarText5";
            this.Outro_VRRP_VarText5.Size = new System.Drawing.Size(98, 21);
            this.Outro_VRRP_VarText5.TabIndex = 309;
            // 
            // Outro_VRRP_VarText4
            // 
            this.Outro_VRRP_VarText4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText4.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText4.Location = new System.Drawing.Point(108, 242);
            this.Outro_VRRP_VarText4.Name = "Outro_VRRP_VarText4";
            this.Outro_VRRP_VarText4.Size = new System.Drawing.Size(98, 21);
            this.Outro_VRRP_VarText4.TabIndex = 308;
            // 
            // Outro_VRRP_Label5
            // 
            this.Outro_VRRP_Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label5.AutoSize = true;
            this.Outro_VRRP_Label5.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label5.Location = new System.Drawing.Point(7, 272);
            this.Outro_VRRP_Label5.Name = "Outro_VRRP_Label5";
            this.Outro_VRRP_Label5.Size = new System.Drawing.Size(95, 13);
            this.Outro_VRRP_Label5.TabIndex = 307;
            this.Outro_VRRP_Label5.Text = "Leitura ou Escrita";
            // 
            // Outro_VRRP_Label4
            // 
            this.Outro_VRRP_Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label4.AutoSize = true;
            this.Outro_VRRP_Label4.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label4.Location = new System.Drawing.Point(7, 247);
            this.Outro_VRRP_Label4.Name = "Outro_VRRP_Label4";
            this.Outro_VRRP_Label4.Size = new System.Drawing.Size(34, 13);
            this.Outro_VRRP_Label4.TabIndex = 306;
            this.Outro_VRRP_Label4.Text = "Host:";
            // 
            // Outro_VRRP_Label3
            // 
            this.Outro_VRRP_Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label3.AutoSize = true;
            this.Outro_VRRP_Label3.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label3.Location = new System.Drawing.Point(7, 221);
            this.Outro_VRRP_Label3.Name = "Outro_VRRP_Label3";
            this.Outro_VRRP_Label3.Size = new System.Drawing.Size(68, 13);
            this.Outro_VRRP_Label3.TabIndex = 305;
            this.Outro_VRRP_Label3.Text = "Community:";
            // 
            // Outro_VRRP_VarText3
            // 
            this.Outro_VRRP_VarText3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText3.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText3.Location = new System.Drawing.Point(108, 217);
            this.Outro_VRRP_VarText3.Name = "Outro_VRRP_VarText3";
            this.Outro_VRRP_VarText3.Size = new System.Drawing.Size(98, 21);
            this.Outro_VRRP_VarText3.TabIndex = 304;
            // 
            // Outro_VRRP_SubTitle1
            // 
            this.Outro_VRRP_SubTitle1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_SubTitle1.AutoSize = true;
            this.Outro_VRRP_SubTitle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_SubTitle1.Location = new System.Drawing.Point(5, 182);
            this.Outro_VRRP_SubTitle1.Name = "Outro_VRRP_SubTitle1";
            this.Outro_VRRP_SubTitle1.Size = new System.Drawing.Size(91, 25);
            this.Outro_VRRP_SubTitle1.TabIndex = 303;
            this.Outro_VRRP_SubTitle1.Text = "Fortigate";
            // 
            // Outro_VRRP_DelButton2
            // 
            this.Outro_VRRP_DelButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton2.Location = new System.Drawing.Point(501, 103);
            this.Outro_VRRP_DelButton2.Name = "Outro_VRRP_DelButton2";
            this.Outro_VRRP_DelButton2.Size = new System.Drawing.Size(20, 21);
            this.Outro_VRRP_DelButton2.TabIndex = 302;
            this.Outro_VRRP_DelButton2.Text = "-";
            this.Outro_VRRP_DelButton2.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_DelButton1
            // 
            this.Outro_VRRP_DelButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton1.Location = new System.Drawing.Point(501, 78);
            this.Outro_VRRP_DelButton1.Name = "Outro_VRRP_DelButton1";
            this.Outro_VRRP_DelButton1.Size = new System.Drawing.Size(20, 21);
            this.Outro_VRRP_DelButton1.TabIndex = 301;
            this.Outro_VRRP_DelButton1.Text = "-";
            this.Outro_VRRP_DelButton1.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_ExTitle0
            // 
            this.Outro_VRRP_ExTitle0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExTitle0.AutoSize = true;
            this.Outro_VRRP_ExTitle0.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_ExTitle0.Location = new System.Drawing.Point(533, 24);
            this.Outro_VRRP_ExTitle0.Name = "Outro_VRRP_ExTitle0";
            this.Outro_VRRP_ExTitle0.Size = new System.Drawing.Size(77, 20);
            this.Outro_VRRP_ExTitle0.TabIndex = 300;
            this.Outro_VRRP_ExTitle0.Text = "Exemplos:";
            // 
            // Outro_VRRP_ExLabel2
            // 
            this.Outro_VRRP_ExLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExLabel2.AutoSize = true;
            this.Outro_VRRP_ExLabel2.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_ExLabel2.Location = new System.Drawing.Point(533, 108);
            this.Outro_VRRP_ExLabel2.Name = "Outro_VRRP_ExLabel2";
            this.Outro_VRRP_ExLabel2.Size = new System.Drawing.Size(61, 13);
            this.Outro_VRRP_ExLabel2.TabIndex = 299;
            this.Outro_VRRP_ExLabel2.Text = "RO ou RW";
            // 
            // Outro_VRRP_ExLabel1
            // 
            this.Outro_VRRP_ExLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExLabel1.AutoSize = true;
            this.Outro_VRRP_ExLabel1.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_ExLabel1.Location = new System.Drawing.Point(533, 84);
            this.Outro_VRRP_ExLabel1.Name = "Outro_VRRP_ExLabel1";
            this.Outro_VRRP_ExLabel1.Size = new System.Drawing.Size(64, 13);
            this.Outro_VRRP_ExLabel1.TabIndex = 298;
            this.Outro_VRRP_ExLabel1.Text = "192.168.1.1";
            // 
            // Outro_VRRP_ExLabel0
            // 
            this.Outro_VRRP_ExLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ExLabel0.AutoSize = true;
            this.Outro_VRRP_ExLabel0.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_ExLabel0.Location = new System.Drawing.Point(533, 59);
            this.Outro_VRRP_ExLabel0.Name = "Outro_VRRP_ExLabel0";
            this.Outro_VRRP_ExLabel0.Size = new System.Drawing.Size(96, 13);
            this.Outro_VRRP_ExLabel0.TabIndex = 297;
            this.Outro_VRRP_ExLabel0.Text = "snmpComunity21";
            // 
            // Outro_VRRP_DelButton0
            // 
            this.Outro_VRRP_DelButton0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_DelButton0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_DelButton0.Location = new System.Drawing.Point(501, 54);
            this.Outro_VRRP_DelButton0.Name = "Outro_VRRP_DelButton0";
            this.Outro_VRRP_DelButton0.Size = new System.Drawing.Size(20, 21);
            this.Outro_VRRP_DelButton0.TabIndex = 296;
            this.Outro_VRRP_DelButton0.Text = "-";
            this.Outro_VRRP_DelButton0.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_ClearButton0
            // 
            this.Outro_VRRP_ClearButton0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_ClearButton0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_ClearButton0.Location = new System.Drawing.Point(443, 19);
            this.Outro_VRRP_ClearButton0.Name = "Outro_VRRP_ClearButton0";
            this.Outro_VRRP_ClearButton0.Size = new System.Drawing.Size(79, 30);
            this.Outro_VRRP_ClearButton0.TabIndex = 295;
            this.Outro_VRRP_ClearButton0.Text = "Limpar";
            this.Outro_VRRP_ClearButton0.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_VarText2
            // 
            this.Outro_VRRP_VarText2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText2.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText2.Location = new System.Drawing.Point(397, 103);
            this.Outro_VRRP_VarText2.Name = "Outro_VRRP_VarText2";
            this.Outro_VRRP_VarText2.Size = new System.Drawing.Size(99, 21);
            this.Outro_VRRP_VarText2.TabIndex = 294;
            // 
            // Outro_VRRP_VarText1
            // 
            this.Outro_VRRP_VarText1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText1.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText1.Location = new System.Drawing.Point(397, 78);
            this.Outro_VRRP_VarText1.Name = "Outro_VRRP_VarText1";
            this.Outro_VRRP_VarText1.Size = new System.Drawing.Size(99, 21);
            this.Outro_VRRP_VarText1.TabIndex = 293;
            // 
            // Outro_VRRP_Label2
            // 
            this.Outro_VRRP_Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label2.AutoSize = true;
            this.Outro_VRRP_Label2.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label2.Location = new System.Drawing.Point(302, 108);
            this.Outro_VRRP_Label2.Name = "Outro_VRRP_Label2";
            this.Outro_VRRP_Label2.Size = new System.Drawing.Size(95, 13);
            this.Outro_VRRP_Label2.TabIndex = 292;
            this.Outro_VRRP_Label2.Text = "Leitura ou Escrita";
            // 
            // Outro_VRRP_Label1
            // 
            this.Outro_VRRP_Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label1.AutoSize = true;
            this.Outro_VRRP_Label1.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label1.Location = new System.Drawing.Point(302, 83);
            this.Outro_VRRP_Label1.Name = "Outro_VRRP_Label1";
            this.Outro_VRRP_Label1.Size = new System.Drawing.Size(34, 13);
            this.Outro_VRRP_Label1.TabIndex = 291;
            this.Outro_VRRP_Label1.Text = "Host:";
            // 
            // Outro_VRRP_Label0
            // 
            this.Outro_VRRP_Label0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_Label0.AutoSize = true;
            this.Outro_VRRP_Label0.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_Label0.Location = new System.Drawing.Point(302, 57);
            this.Outro_VRRP_Label0.Name = "Outro_VRRP_Label0";
            this.Outro_VRRP_Label0.Size = new System.Drawing.Size(68, 13);
            this.Outro_VRRP_Label0.TabIndex = 290;
            this.Outro_VRRP_Label0.Text = "Community:";
            // 
            // Outro_VRRP_VarText0
            // 
            this.Outro_VRRP_VarText0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_VarText0.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outro_VRRP_VarText0.Location = new System.Drawing.Point(397, 54);
            this.Outro_VRRP_VarText0.Name = "Outro_VRRP_VarText0";
            this.Outro_VRRP_VarText0.Size = new System.Drawing.Size(99, 21);
            this.Outro_VRRP_VarText0.TabIndex = 289;
            // 
            // Outro_VRRP_SubTitle0
            // 
            this.Outro_VRRP_SubTitle0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outro_VRRP_SubTitle0.AutoSize = true;
            this.Outro_VRRP_SubTitle0.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outro_VRRP_SubTitle0.Location = new System.Drawing.Point(300, 19);
            this.Outro_VRRP_SubTitle0.Name = "Outro_VRRP_SubTitle0";
            this.Outro_VRRP_SubTitle0.Size = new System.Drawing.Size(57, 25);
            this.Outro_VRRP_SubTitle0.TabIndex = 288;
            this.Outro_VRRP_SubTitle0.Text = "Cisco";
            // 
            // Outro_VRRP_CheckBoxCisco
            // 
            this.Outro_VRRP_CheckBoxCisco.AutoSize = true;
            this.Outro_VRRP_CheckBoxCisco.Location = new System.Drawing.Point(397, 130);
            this.Outro_VRRP_CheckBoxCisco.Name = "Outro_VRRP_CheckBoxCisco";
            this.Outro_VRRP_CheckBoxCisco.Size = new System.Drawing.Size(138, 23);
            this.Outro_VRRP_CheckBoxCisco.TabIndex = 287;
            this.Outro_VRRP_CheckBoxCisco.Text = "Cisco Porta Serial";
            this.Outro_VRRP_CheckBoxCisco.UseVisualStyleBackColor = true;
            // 
            // Outro_VRRP_Guide
            // 
            this.Outro_VRRP_Guide.AutoSize = true;
            this.Outro_VRRP_Guide.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outro_VRRP_Guide.Location = new System.Drawing.Point(23, 46);
            this.Outro_VRRP_Guide.Name = "Outro_VRRP_Guide";
            this.Outro_VRRP_Guide.Size = new System.Drawing.Size(74, 20);
            this.Outro_VRRP_Guide.TabIndex = 265;
            this.Outro_VRRP_Guide.Text = "Guia aqui";
            // 
            // Outros_TabGLBP
            // 
            this.Outros_TabGLBP.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabGLBP.Controls.Add(this.label76);
            this.Outros_TabGLBP.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabGLBP.Name = "Outros_TabGLBP";
            this.Outros_TabGLBP.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabGLBP.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabGLBP.TabIndex = 13;
            this.Outros_TabGLBP.Text = "GLBP";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label76.Location = new System.Drawing.Point(21, 33);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(0, 20);
            this.label76.TabIndex = 265;
            // 
            // Outros_TabEIGRP
            // 
            this.Outros_TabEIGRP.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabEIGRP.Controls.Add(this.label77);
            this.Outros_TabEIGRP.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabEIGRP.Name = "Outros_TabEIGRP";
            this.Outros_TabEIGRP.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabEIGRP.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabEIGRP.TabIndex = 14;
            this.Outros_TabEIGRP.Text = "EIGRP";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label77.Location = new System.Drawing.Point(25, 33);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(0, 20);
            this.label77.TabIndex = 265;
            // 
            // Outros_TabHotline
            // 
            this.Outros_TabHotline.BackColor = System.Drawing.SystemColors.Control;
            this.Outros_TabHotline.Controls.Add(this.label78);
            this.Outros_TabHotline.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabHotline.Name = "Outros_TabHotline";
            this.Outros_TabHotline.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_TabHotline.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabHotline.TabIndex = 15;
            this.Outros_TabHotline.Text = "Hotline";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label78.Location = new System.Drawing.Point(28, 33);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(74, 20);
            this.label78.TabIndex = 265;
            this.label78.Text = "Guia aqui";
            // 
            // Outros_Tab_HSRP
            // 
            this.Outros_Tab_HSRP.Controls.Add(this.Outros_HSRP_Label);
            this.Outros_Tab_HSRP.Location = new System.Drawing.Point(4, 5);
            this.Outros_Tab_HSRP.Name = "Outros_Tab_HSRP";
            this.Outros_Tab_HSRP.Padding = new System.Windows.Forms.Padding(3);
            this.Outros_Tab_HSRP.Size = new System.Drawing.Size(629, 436);
            this.Outros_Tab_HSRP.TabIndex = 16;
            this.Outros_Tab_HSRP.Text = "HSRP";
            this.Outros_Tab_HSRP.UseVisualStyleBackColor = true;
            // 
            // Outros_HSRP_Label
            // 
            this.Outros_HSRP_Label.AutoSize = true;
            this.Outros_HSRP_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outros_HSRP_Label.Location = new System.Drawing.Point(32, 40);
            this.Outros_HSRP_Label.Name = "Outros_HSRP_Label";
            this.Outros_HSRP_Label.Size = new System.Drawing.Size(0, 20);
            this.Outros_HSRP_Label.TabIndex = 266;
            // 
            // Outros_TabPortBlock
            // 
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_ExLabel3);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Delete3);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label3);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_TextBox3);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_ClearButton);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_HPEold);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_ExLabel2);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Delete2);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label2);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_TextBox2);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_ExLabel1);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Delete1);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label1);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_TextBox1);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label19);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox15);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox16);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label18);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox14);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label17);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox13);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label16);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label15);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label13);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label12);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label11);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label10);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label9);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label8);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label7);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label6);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_ChangeAllButton);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Guide);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_ExLabelTitle);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_ExLabel0);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Delete0);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label0);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_TextBox0);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_LabelTitle);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox12);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox11);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox10);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox9);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox8);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox7);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox6);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox5);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox4);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox3);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox2);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox1);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBLock_ComboBox0);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label4);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label5);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label14);
            this.Outros_TabPortBlock.Controls.Add(this.Outros_PortBlock_Label20);
            this.Outros_TabPortBlock.Location = new System.Drawing.Point(4, 5);
            this.Outros_TabPortBlock.Name = "Outros_TabPortBlock";
            this.Outros_TabPortBlock.Size = new System.Drawing.Size(629, 436);
            this.Outros_TabPortBlock.TabIndex = 17;
            this.Outros_TabPortBlock.Text = "PortBlock";
            this.Outros_TabPortBlock.UseVisualStyleBackColor = true;
            // 
            // Outros_PortBlock_ExLabel3
            // 
            this.Outros_PortBlock_ExLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_ExLabel3.AutoSize = true;
            this.Outros_PortBlock_ExLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_ExLabel3.Location = new System.Drawing.Point(277, 328);
            this.Outros_PortBlock_ExLabel3.Name = "Outros_PortBlock_ExLabel3";
            this.Outros_PortBlock_ExLabel3.Size = new System.Drawing.Size(21, 15);
            this.Outros_PortBlock_ExLabel3.TabIndex = 305;
            this.Outros_PortBlock_ExLabel3.Text = "23";
            // 
            // Outros_PortBlock_Delete3
            // 
            this.Outros_PortBlock_Delete3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_Delete3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_Delete3.Location = new System.Drawing.Point(252, 322);
            this.Outros_PortBlock_Delete3.Name = "Outros_PortBlock_Delete3";
            this.Outros_PortBlock_Delete3.Size = new System.Drawing.Size(20, 25);
            this.Outros_PortBlock_Delete3.TabIndex = 304;
            this.Outros_PortBlock_Delete3.Text = "-";
            this.Outros_PortBlock_Delete3.UseVisualStyleBackColor = true;
            this.Outros_PortBlock_Delete3.Click += new System.EventHandler(this.Outros_PortBlock_Delete3_Click);
            // 
            // Outros_PortBlock_Label3
            // 
            this.Outros_PortBlock_Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_Label3.AutoSize = true;
            this.Outros_PortBlock_Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_Label3.Location = new System.Drawing.Point(67, 325);
            this.Outros_PortBlock_Label3.Name = "Outros_PortBlock_Label3";
            this.Outros_PortBlock_Label3.Size = new System.Drawing.Size(103, 17);
            this.Outros_PortBlock_Label3.TabIndex = 303;
            this.Outros_PortBlock_Label3.Text = "Porta Especifíca:";
            // 
            // Outros_PortBlock_TextBox3
            // 
            this.Outros_PortBlock_TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_TextBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_TextBox3.Location = new System.Drawing.Point(176, 322);
            this.Outros_PortBlock_TextBox3.Name = "Outros_PortBlock_TextBox3";
            this.Outros_PortBlock_TextBox3.Size = new System.Drawing.Size(70, 25);
            this.Outros_PortBlock_TextBox3.TabIndex = 302;
            // 
            // Outros_PortBlock_ClearButton
            // 
            this.Outros_PortBlock_ClearButton.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBlock_ClearButton.Location = new System.Drawing.Point(200, 200);
            this.Outros_PortBlock_ClearButton.Name = "Outros_PortBlock_ClearButton";
            this.Outros_PortBlock_ClearButton.Size = new System.Drawing.Size(72, 23);
            this.Outros_PortBlock_ClearButton.TabIndex = 301;
            this.Outros_PortBlock_ClearButton.Text = "Limpar";
            this.Outros_PortBlock_ClearButton.UseVisualStyleBackColor = true;
            this.Outros_PortBlock_ClearButton.Click += new System.EventHandler(this.Outros_PortBlock_ClearButton_Click);
            // 
            // Outros_PortBlock_HPEold
            // 
            this.Outros_PortBlock_HPEold.AutoSize = true;
            this.Outros_PortBlock_HPEold.Location = new System.Drawing.Point(18, 376);
            this.Outros_PortBlock_HPEold.Name = "Outros_PortBlock_HPEold";
            this.Outros_PortBlock_HPEold.Size = new System.Drawing.Size(152, 23);
            this.Outros_PortBlock_HPEold.TabIndex = 300;
            this.Outros_PortBlock_HPEold.Text = "HPE/Huawei Antigo";
            this.Outros_PortBlock_HPEold.UseVisualStyleBackColor = true;
            // 
            // Outros_PortBlock_ExLabel2
            // 
            this.Outros_PortBlock_ExLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_ExLabel2.AutoSize = true;
            this.Outros_PortBlock_ExLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_ExLabel2.Location = new System.Drawing.Point(278, 292);
            this.Outros_PortBlock_ExLabel2.Name = "Outros_PortBlock_ExLabel2";
            this.Outros_PortBlock_ExLabel2.Size = new System.Drawing.Size(57, 15);
            this.Outros_PortBlock_ExLabel2.TabIndex = 299;
            this.Outros_PortBlock_ExLabel2.Text = "10.10.10.1";
            // 
            // Outros_PortBlock_Delete2
            // 
            this.Outros_PortBlock_Delete2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_Delete2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_Delete2.Location = new System.Drawing.Point(252, 289);
            this.Outros_PortBlock_Delete2.Name = "Outros_PortBlock_Delete2";
            this.Outros_PortBlock_Delete2.Size = new System.Drawing.Size(20, 25);
            this.Outros_PortBlock_Delete2.TabIndex = 298;
            this.Outros_PortBlock_Delete2.Text = "-";
            this.Outros_PortBlock_Delete2.UseVisualStyleBackColor = true;
            this.Outros_PortBlock_Delete2.Click += new System.EventHandler(this.Outros_PortBlock_Delete2_Click);
            // 
            // Outros_PortBlock_Label2
            // 
            this.Outros_PortBlock_Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_Label2.AutoSize = true;
            this.Outros_PortBlock_Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_Label2.Location = new System.Drawing.Point(18, 293);
            this.Outros_PortBlock_Label2.Name = "Outros_PortBlock_Label2";
            this.Outros_PortBlock_Label2.Size = new System.Drawing.Size(68, 17);
            this.Outros_PortBlock_Label2.TabIndex = 297;
            this.Outros_PortBlock_Label2.Text = "IP de LAN:";
            // 
            // Outros_PortBlock_TextBox2
            // 
            this.Outros_PortBlock_TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_TextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_TextBox2.Location = new System.Drawing.Point(117, 289);
            this.Outros_PortBlock_TextBox2.Name = "Outros_PortBlock_TextBox2";
            this.Outros_PortBlock_TextBox2.Size = new System.Drawing.Size(129, 25);
            this.Outros_PortBlock_TextBox2.TabIndex = 296;
            // 
            // Outros_PortBlock_ExLabel1
            // 
            this.Outros_PortBlock_ExLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_ExLabel1.AutoSize = true;
            this.Outros_PortBlock_ExLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_ExLabel1.Location = new System.Drawing.Point(278, 261);
            this.Outros_PortBlock_ExLabel1.Name = "Outros_PortBlock_ExLabel1";
            this.Outros_PortBlock_ExLabel1.Size = new System.Drawing.Size(66, 15);
            this.Outros_PortBlock_ExLabel1.TabIndex = 295;
            this.Outros_PortBlock_ExLabel1.Text = "192.168.0.1";
            // 
            // Outros_PortBlock_Delete1
            // 
            this.Outros_PortBlock_Delete1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_Delete1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_Delete1.Location = new System.Drawing.Point(252, 258);
            this.Outros_PortBlock_Delete1.Name = "Outros_PortBlock_Delete1";
            this.Outros_PortBlock_Delete1.Size = new System.Drawing.Size(20, 25);
            this.Outros_PortBlock_Delete1.TabIndex = 294;
            this.Outros_PortBlock_Delete1.Text = "-";
            this.Outros_PortBlock_Delete1.UseVisualStyleBackColor = true;
            this.Outros_PortBlock_Delete1.Click += new System.EventHandler(this.Outros_PortBlock_Delete1_Click);
            // 
            // Outros_PortBlock_Label1
            // 
            this.Outros_PortBlock_Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_Label1.AutoSize = true;
            this.Outros_PortBlock_Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_Label1.Location = new System.Drawing.Point(18, 262);
            this.Outros_PortBlock_Label1.Name = "Outros_PortBlock_Label1";
            this.Outros_PortBlock_Label1.Size = new System.Drawing.Size(73, 17);
            this.Outros_PortBlock_Label1.TabIndex = 293;
            this.Outros_PortBlock_Label1.Text = "IP de WAN:";
            // 
            // Outros_PortBlock_TextBox1
            // 
            this.Outros_PortBlock_TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_TextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_TextBox1.Location = new System.Drawing.Point(117, 258);
            this.Outros_PortBlock_TextBox1.Name = "Outros_PortBlock_TextBox1";
            this.Outros_PortBlock_TextBox1.Size = new System.Drawing.Size(129, 25);
            this.Outros_PortBlock_TextBox1.TabIndex = 292;
            // 
            // Outros_PortBlock_Label19
            // 
            this.Outros_PortBlock_Label19.AutoSize = true;
            this.Outros_PortBlock_Label19.Location = new System.Drawing.Point(403, 359);
            this.Outros_PortBlock_Label19.Name = "Outros_PortBlock_Label19";
            this.Outros_PortBlock_Label19.Size = new System.Drawing.Size(41, 19);
            this.Outros_PortBlock_Label19.TabIndex = 291;
            this.Outros_PortBlock_Label19.Text = "4433";
            // 
            // Outros_PortBLock_ComboBox15
            // 
            this.Outros_PortBLock_ComboBox15.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox15.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox15.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox15.Location = new System.Drawing.Point(531, 359);
            this.Outros_PortBLock_ComboBox15.Name = "Outros_PortBLock_ComboBox15";
            this.Outros_PortBLock_ComboBox15.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox15.TabIndex = 290;
            // 
            // Outros_PortBLock_ComboBox16
            // 
            this.Outros_PortBLock_ComboBox16.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox16.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox16.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox16.Location = new System.Drawing.Point(531, 379);
            this.Outros_PortBLock_ComboBox16.Name = "Outros_PortBLock_ComboBox16";
            this.Outros_PortBLock_ComboBox16.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox16.TabIndex = 288;
            // 
            // Outros_PortBlock_Label18
            // 
            this.Outros_PortBlock_Label18.AutoSize = true;
            this.Outros_PortBlock_Label18.Location = new System.Drawing.Point(403, 339);
            this.Outros_PortBlock_Label18.Name = "Outros_PortBlock_Label18";
            this.Outros_PortBlock_Label18.Size = new System.Drawing.Size(41, 19);
            this.Outros_PortBlock_Label18.TabIndex = 287;
            this.Outros_PortBlock_Label18.Text = "4422";
            // 
            // Outros_PortBLock_ComboBox14
            // 
            this.Outros_PortBLock_ComboBox14.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox14.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox14.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox14.Location = new System.Drawing.Point(531, 339);
            this.Outros_PortBLock_ComboBox14.Name = "Outros_PortBLock_ComboBox14";
            this.Outros_PortBLock_ComboBox14.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox14.TabIndex = 286;
            // 
            // Outros_PortBlock_Label17
            // 
            this.Outros_PortBlock_Label17.AutoSize = true;
            this.Outros_PortBlock_Label17.Location = new System.Drawing.Point(403, 319);
            this.Outros_PortBlock_Label17.Name = "Outros_PortBlock_Label17";
            this.Outros_PortBlock_Label17.Size = new System.Drawing.Size(72, 19);
            this.Outros_PortBlock_Label17.TabIndex = 285;
            this.Outros_PortBlock_Label17.Text = "514 - cmd";
            // 
            // Outros_PortBLock_ComboBox13
            // 
            this.Outros_PortBLock_ComboBox13.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox13.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox13.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox13.Location = new System.Drawing.Point(531, 319);
            this.Outros_PortBLock_ComboBox13.Name = "Outros_PortBLock_ComboBox13";
            this.Outros_PortBLock_ComboBox13.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox13.TabIndex = 284;
            // 
            // Outros_PortBlock_Label16
            // 
            this.Outros_PortBlock_Label16.AutoSize = true;
            this.Outros_PortBlock_Label16.Location = new System.Drawing.Point(403, 299);
            this.Outros_PortBlock_Label16.Name = "Outros_PortBlock_Label16";
            this.Outros_PortBlock_Label16.Size = new System.Drawing.Size(89, 19);
            this.Outros_PortBlock_Label16.TabIndex = 283;
            this.Outros_PortBlock_Label16.Text = "443 - HTTPS";
            // 
            // Outros_PortBlock_Label15
            // 
            this.Outros_PortBlock_Label15.AutoSize = true;
            this.Outros_PortBlock_Label15.Location = new System.Drawing.Point(403, 278);
            this.Outros_PortBlock_Label15.Name = "Outros_PortBlock_Label15";
            this.Outros_PortBlock_Label15.Size = new System.Drawing.Size(33, 19);
            this.Outros_PortBlock_Label15.TabIndex = 282;
            this.Outros_PortBlock_Label15.Text = "442";
            // 
            // Outros_PortBlock_Label13
            // 
            this.Outros_PortBlock_Label13.AutoSize = true;
            this.Outros_PortBlock_Label13.Location = new System.Drawing.Point(403, 238);
            this.Outros_PortBlock_Label13.Name = "Outros_PortBlock_Label13";
            this.Outros_PortBlock_Label13.Size = new System.Drawing.Size(83, 19);
            this.Outros_PortBlock_Label13.TabIndex = 280;
            this.Outros_PortBlock_Label13.Text = "161 - SNMP";
            // 
            // Outros_PortBlock_Label12
            // 
            this.Outros_PortBlock_Label12.AutoSize = true;
            this.Outros_PortBlock_Label12.Location = new System.Drawing.Point(403, 219);
            this.Outros_PortBlock_Label12.Name = "Outros_PortBlock_Label12";
            this.Outros_PortBlock_Label12.Size = new System.Drawing.Size(72, 19);
            this.Outros_PortBlock_Label12.TabIndex = 279;
            this.Outros_PortBlock_Label12.Text = "123 - NTP";
            // 
            // Outros_PortBlock_Label11
            // 
            this.Outros_PortBlock_Label11.AutoSize = true;
            this.Outros_PortBlock_Label11.Location = new System.Drawing.Point(403, 199);
            this.Outros_PortBlock_Label11.Name = "Outros_PortBlock_Label11";
            this.Outros_PortBlock_Label11.Size = new System.Drawing.Size(73, 19);
            this.Outros_PortBlock_Label11.TabIndex = 278;
            this.Outros_PortBlock_Label11.Text = "80 - HTTP";
            // 
            // Outros_PortBlock_Label10
            // 
            this.Outros_PortBlock_Label10.AutoSize = true;
            this.Outros_PortBlock_Label10.Location = new System.Drawing.Point(403, 182);
            this.Outros_PortBlock_Label10.Name = "Outros_PortBlock_Label10";
            this.Outros_PortBlock_Label10.Size = new System.Drawing.Size(62, 19);
            this.Outros_PortBlock_Label10.TabIndex = 277;
            this.Outros_PortBlock_Label10.Text = "69 - tftp";
            // 
            // Outros_PortBlock_Label9
            // 
            this.Outros_PortBlock_Label9.AutoSize = true;
            this.Outros_PortBlock_Label9.Location = new System.Drawing.Point(403, 158);
            this.Outros_PortBlock_Label9.Name = "Outros_PortBlock_Label9";
            this.Outros_PortBlock_Label9.Size = new System.Drawing.Size(83, 19);
            this.Outros_PortBlock_Label9.TabIndex = 276;
            this.Outros_PortBlock_Label9.Text = "68 - bootpc";
            // 
            // Outros_PortBlock_Label8
            // 
            this.Outros_PortBlock_Label8.AutoSize = true;
            this.Outros_PortBlock_Label8.Location = new System.Drawing.Point(403, 138);
            this.Outros_PortBlock_Label8.Name = "Outros_PortBlock_Label8";
            this.Outros_PortBlock_Label8.Size = new System.Drawing.Size(82, 19);
            this.Outros_PortBlock_Label8.TabIndex = 275;
            this.Outros_PortBlock_Label8.Text = "67 - bootps";
            // 
            // Outros_PortBlock_Label7
            // 
            this.Outros_PortBlock_Label7.AutoSize = true;
            this.Outros_PortBlock_Label7.Location = new System.Drawing.Point(403, 118);
            this.Outros_PortBlock_Label7.Name = "Outros_PortBlock_Label7";
            this.Outros_PortBlock_Label7.Size = new System.Drawing.Size(68, 19);
            this.Outros_PortBlock_Label7.TabIndex = 274;
            this.Outros_PortBlock_Label7.Text = "53 - DNS";
            // 
            // Outros_PortBlock_Label6
            // 
            this.Outros_PortBlock_Label6.AutoSize = true;
            this.Outros_PortBlock_Label6.Location = new System.Drawing.Point(403, 101);
            this.Outros_PortBlock_Label6.Name = "Outros_PortBlock_Label6";
            this.Outros_PortBlock_Label6.Size = new System.Drawing.Size(65, 19);
            this.Outros_PortBlock_Label6.TabIndex = 273;
            this.Outros_PortBlock_Label6.Text = "22 - SSH";
            // 
            // Outros_PortBlock_ChangeAllButton
            // 
            this.Outros_PortBlock_ChangeAllButton.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBlock_ChangeAllButton.Location = new System.Drawing.Point(406, 32);
            this.Outros_PortBlock_ChangeAllButton.Margin = new System.Windows.Forms.Padding(0);
            this.Outros_PortBlock_ChangeAllButton.Name = "Outros_PortBlock_ChangeAllButton";
            this.Outros_PortBlock_ChangeAllButton.Size = new System.Drawing.Size(181, 23);
            this.Outros_PortBlock_ChangeAllButton.TabIndex = 270;
            this.Outros_PortBlock_ChangeAllButton.Text = "Mudar Todos";
            this.Outros_PortBlock_ChangeAllButton.UseVisualStyleBackColor = true;
            this.Outros_PortBlock_ChangeAllButton.Click += new System.EventHandler(this.Outros_PortBlock_ChangeAllButton_Click);
            // 
            // Outros_PortBlock_Guide
            // 
            this.Outros_PortBlock_Guide.AutoSize = true;
            this.Outros_PortBlock_Guide.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Outros_PortBlock_Guide.Location = new System.Drawing.Point(25, 27);
            this.Outros_PortBlock_Guide.Name = "Outros_PortBlock_Guide";
            this.Outros_PortBlock_Guide.Size = new System.Drawing.Size(74, 20);
            this.Outros_PortBlock_Guide.TabIndex = 269;
            this.Outros_PortBlock_Guide.Text = "Guia aqui";
            // 
            // Outros_PortBlock_ExLabelTitle
            // 
            this.Outros_PortBlock_ExLabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_ExLabelTitle.AutoSize = true;
            this.Outros_PortBlock_ExLabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_ExLabelTitle.Location = new System.Drawing.Point(281, 199);
            this.Outros_PortBlock_ExLabelTitle.Name = "Outros_PortBlock_ExLabelTitle";
            this.Outros_PortBlock_ExLabelTitle.Size = new System.Drawing.Size(77, 20);
            this.Outros_PortBlock_ExLabelTitle.TabIndex = 268;
            this.Outros_PortBlock_ExLabelTitle.Text = "Exemplos:";
            // 
            // Outros_PortBlock_ExLabel0
            // 
            this.Outros_PortBlock_ExLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_ExLabel0.AutoSize = true;
            this.Outros_PortBlock_ExLabel0.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_ExLabel0.Location = new System.Drawing.Point(278, 232);
            this.Outros_PortBlock_ExLabel0.Name = "Outros_PortBlock_ExLabel0";
            this.Outros_PortBlock_ExLabel0.Size = new System.Drawing.Size(108, 15);
            this.Outros_PortBlock_ExLabel0.TabIndex = 267;
            this.Outros_PortBlock_ExLabel0.Text = "GigabitEthernet0/0";
            // 
            // Outros_PortBlock_Delete0
            // 
            this.Outros_PortBlock_Delete0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_Delete0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_Delete0.Location = new System.Drawing.Point(252, 229);
            this.Outros_PortBlock_Delete0.Name = "Outros_PortBlock_Delete0";
            this.Outros_PortBlock_Delete0.Size = new System.Drawing.Size(20, 25);
            this.Outros_PortBlock_Delete0.TabIndex = 266;
            this.Outros_PortBlock_Delete0.Text = "-";
            this.Outros_PortBlock_Delete0.UseVisualStyleBackColor = true;
            this.Outros_PortBlock_Delete0.Click += new System.EventHandler(this.Outros_PortBlock_Delete0_Click);
            // 
            // Outros_PortBlock_Label0
            // 
            this.Outros_PortBlock_Label0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_Label0.AutoSize = true;
            this.Outros_PortBlock_Label0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_Label0.Location = new System.Drawing.Point(18, 233);
            this.Outros_PortBlock_Label0.Name = "Outros_PortBlock_Label0";
            this.Outros_PortBlock_Label0.Size = new System.Drawing.Size(94, 17);
            this.Outros_PortBlock_Label0.TabIndex = 265;
            this.Outros_PortBlock_Label0.Text = "Interface WAN:";
            // 
            // Outros_PortBlock_TextBox0
            // 
            this.Outros_PortBlock_TextBox0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_TextBox0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_TextBox0.Location = new System.Drawing.Point(117, 229);
            this.Outros_PortBlock_TextBox0.Name = "Outros_PortBlock_TextBox0";
            this.Outros_PortBlock_TextBox0.Size = new System.Drawing.Size(129, 25);
            this.Outros_PortBlock_TextBox0.TabIndex = 264;
            // 
            // Outros_PortBlock_LabelTitle
            // 
            this.Outros_PortBlock_LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Outros_PortBlock_LabelTitle.AutoSize = true;
            this.Outros_PortBlock_LabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros_PortBlock_LabelTitle.Location = new System.Drawing.Point(16, 194);
            this.Outros_PortBlock_LabelTitle.Name = "Outros_PortBlock_LabelTitle";
            this.Outros_PortBlock_LabelTitle.Size = new System.Drawing.Size(88, 25);
            this.Outros_PortBlock_LabelTitle.TabIndex = 263;
            this.Outros_PortBlock_LabelTitle.Text = "Variáveis";
            // 
            // Outros_PortBLock_ComboBox12
            // 
            this.Outros_PortBLock_ComboBox12.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox12.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox12.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox12.Location = new System.Drawing.Point(531, 299);
            this.Outros_PortBLock_ComboBox12.Name = "Outros_PortBLock_ComboBox12";
            this.Outros_PortBLock_ComboBox12.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox12.TabIndex = 12;
            // 
            // Outros_PortBLock_ComboBox11
            // 
            this.Outros_PortBLock_ComboBox11.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox11.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox11.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox11.Location = new System.Drawing.Point(531, 279);
            this.Outros_PortBLock_ComboBox11.Name = "Outros_PortBLock_ComboBox11";
            this.Outros_PortBLock_ComboBox11.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox11.TabIndex = 11;
            // 
            // Outros_PortBLock_ComboBox10
            // 
            this.Outros_PortBLock_ComboBox10.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox10.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox10.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox10.Location = new System.Drawing.Point(531, 259);
            this.Outros_PortBLock_ComboBox10.Name = "Outros_PortBLock_ComboBox10";
            this.Outros_PortBLock_ComboBox10.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox10.TabIndex = 10;
            // 
            // Outros_PortBLock_ComboBox9
            // 
            this.Outros_PortBLock_ComboBox9.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox9.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox9.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox9.Location = new System.Drawing.Point(531, 239);
            this.Outros_PortBLock_ComboBox9.Name = "Outros_PortBLock_ComboBox9";
            this.Outros_PortBLock_ComboBox9.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox9.TabIndex = 9;
            // 
            // Outros_PortBLock_ComboBox8
            // 
            this.Outros_PortBLock_ComboBox8.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox8.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox8.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox8.Location = new System.Drawing.Point(531, 219);
            this.Outros_PortBLock_ComboBox8.Name = "Outros_PortBLock_ComboBox8";
            this.Outros_PortBLock_ComboBox8.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox8.TabIndex = 8;
            // 
            // Outros_PortBLock_ComboBox7
            // 
            this.Outros_PortBLock_ComboBox7.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox7.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox7.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox7.Location = new System.Drawing.Point(531, 199);
            this.Outros_PortBLock_ComboBox7.Name = "Outros_PortBLock_ComboBox7";
            this.Outros_PortBLock_ComboBox7.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox7.TabIndex = 7;
            // 
            // Outros_PortBLock_ComboBox6
            // 
            this.Outros_PortBLock_ComboBox6.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox6.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox6.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox6.Location = new System.Drawing.Point(531, 179);
            this.Outros_PortBLock_ComboBox6.Name = "Outros_PortBLock_ComboBox6";
            this.Outros_PortBLock_ComboBox6.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox6.TabIndex = 6;
            // 
            // Outros_PortBLock_ComboBox5
            // 
            this.Outros_PortBLock_ComboBox5.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox5.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox5.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox5.Location = new System.Drawing.Point(531, 159);
            this.Outros_PortBLock_ComboBox5.Name = "Outros_PortBLock_ComboBox5";
            this.Outros_PortBLock_ComboBox5.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox5.TabIndex = 5;
            // 
            // Outros_PortBLock_ComboBox4
            // 
            this.Outros_PortBLock_ComboBox4.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox4.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox4.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox4.Location = new System.Drawing.Point(531, 139);
            this.Outros_PortBLock_ComboBox4.Name = "Outros_PortBLock_ComboBox4";
            this.Outros_PortBLock_ComboBox4.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox4.TabIndex = 4;
            // 
            // Outros_PortBLock_ComboBox3
            // 
            this.Outros_PortBLock_ComboBox3.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox3.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox3.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox3.Location = new System.Drawing.Point(531, 119);
            this.Outros_PortBLock_ComboBox3.Name = "Outros_PortBLock_ComboBox3";
            this.Outros_PortBLock_ComboBox3.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox3.TabIndex = 3;
            // 
            // Outros_PortBLock_ComboBox2
            // 
            this.Outros_PortBLock_ComboBox2.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox2.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox2.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox2.Location = new System.Drawing.Point(531, 99);
            this.Outros_PortBLock_ComboBox2.Name = "Outros_PortBLock_ComboBox2";
            this.Outros_PortBLock_ComboBox2.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox2.TabIndex = 2;
            // 
            // Outros_PortBLock_ComboBox1
            // 
            this.Outros_PortBLock_ComboBox1.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox1.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox1.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox1.Location = new System.Drawing.Point(531, 79);
            this.Outros_PortBLock_ComboBox1.Name = "Outros_PortBLock_ComboBox1";
            this.Outros_PortBLock_ComboBox1.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox1.TabIndex = 1;
            // 
            // Outros_PortBLock_ComboBox0
            // 
            this.Outros_PortBLock_ComboBox0.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Outros_PortBLock_ComboBox0.FormattingEnabled = true;
            this.Outros_PortBLock_ComboBox0.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Outros_PortBLock_ComboBox0.Location = new System.Drawing.Point(531, 59);
            this.Outros_PortBLock_ComboBox0.Name = "Outros_PortBLock_ComboBox0";
            this.Outros_PortBLock_ComboBox0.Size = new System.Drawing.Size(56, 20);
            this.Outros_PortBLock_ComboBox0.TabIndex = 0;
            // 
            // Outros_PortBlock_Label4
            // 
            this.Outros_PortBlock_Label4.AutoSize = true;
            this.Outros_PortBlock_Label4.Location = new System.Drawing.Point(403, 60);
            this.Outros_PortBlock_Label4.Name = "Outros_PortBlock_Label4";
            this.Outros_PortBlock_Label4.Size = new System.Drawing.Size(142, 19);
            this.Outros_PortBlock_Label4.TabIndex = 271;
            this.Outros_PortBlock_Label4.Text = "20 - ftp-data logging";
            // 
            // Outros_PortBlock_Label5
            // 
            this.Outros_PortBlock_Label5.AutoSize = true;
            this.Outros_PortBlock_Label5.Location = new System.Drawing.Point(403, 81);
            this.Outros_PortBlock_Label5.Name = "Outros_PortBlock_Label5";
            this.Outros_PortBlock_Label5.Size = new System.Drawing.Size(107, 19);
            this.Outros_PortBlock_Label5.TabIndex = 272;
            this.Outros_PortBlock_Label5.Text = "21 - ftp logging";
            // 
            // Outros_PortBlock_Label14
            // 
            this.Outros_PortBlock_Label14.AutoSize = true;
            this.Outros_PortBlock_Label14.Location = new System.Drawing.Point(403, 258);
            this.Outros_PortBlock_Label14.Name = "Outros_PortBlock_Label14";
            this.Outros_PortBlock_Label14.Size = new System.Drawing.Size(114, 19);
            this.Outros_PortBlock_Label14.TabIndex = 281;
            this.Outros_PortBlock_Label14.Text = "162 - SNMP trap";
            // 
            // Outros_PortBlock_Label20
            // 
            this.Outros_PortBlock_Label20.AutoSize = true;
            this.Outros_PortBlock_Label20.Location = new System.Drawing.Point(403, 381);
            this.Outros_PortBlock_Label20.Name = "Outros_PortBlock_Label20";
            this.Outros_PortBlock_Label20.Size = new System.Drawing.Size(126, 19);
            this.Outros_PortBlock_Label20.TabIndex = 289;
            this.Outros_PortBlock_Label20.Text = "647 - DHCP (UDP)";
            // 
            // tabSelectClient
            // 
            this.tabSelectClient.AutoScroll = true;
            this.tabSelectClient.Controls.Add(this.Client_NovoButton);
            this.tabSelectClient.Controls.Add(this.Client_TesteClient);
            this.tabSelectClient.Controls.Add(this.SelectClientTitle);
            this.tabSelectClient.Controls.Add(this.HomeButton_ClientList);
            this.tabSelectClient.Controls.Add(this.SelectClientRow);
            this.tabSelectClient.Location = new System.Drawing.Point(4, 5);
            this.tabSelectClient.Name = "tabSelectClient";
            this.tabSelectClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectClient.Size = new System.Drawing.Size(1112, 513);
            this.tabSelectClient.TabIndex = 9;
            this.tabSelectClient.Text = "tabSelectClient";
            this.tabSelectClient.UseVisualStyleBackColor = true;
            // 
            // Client_NovoButton
            // 
            this.Client_NovoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_NovoButton.Location = new System.Drawing.Point(54, 40);
            this.Client_NovoButton.Name = "Client_NovoButton";
            this.Client_NovoButton.Size = new System.Drawing.Size(124, 54);
            this.Client_NovoButton.TabIndex = 16;
            this.Client_NovoButton.Text = "Novo";
            this.Client_NovoButton.UseVisualStyleBackColor = true;
            this.Client_NovoButton.Click += new System.EventHandler(this.Client_NovoButton_Click);
            // 
            // Client_TesteClient
            // 
            this.Client_TesteClient.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_TesteClient.Location = new System.Drawing.Point(211, 40);
            this.Client_TesteClient.Name = "Client_TesteClient";
            this.Client_TesteClient.Size = new System.Drawing.Size(169, 54);
            this.Client_TesteClient.TabIndex = 15;
            this.Client_TesteClient.Text = "Teste Client";
            this.Client_TesteClient.UseVisualStyleBackColor = true;
            this.Client_TesteClient.Click += new System.EventHandler(this.Client_TesteClient_Click);
            // 
            // SelectClientTitle
            // 
            this.SelectClientTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectClientTitle.AutoSize = true;
            this.SelectClientTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectClientTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SelectClientTitle.Location = new System.Drawing.Point(511, 40);
            this.SelectClientTitle.Name = "SelectClientTitle";
            this.SelectClientTitle.Size = new System.Drawing.Size(137, 45);
            this.SelectClientTitle.TabIndex = 13;
            this.SelectClientTitle.Text = "Clientes";
            this.SelectClientTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeButton_ClientList
            // 
            this.HomeButton_ClientList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton_ClientList.BackColor = System.Drawing.SystemColors.Highlight;
            this.HomeButton_ClientList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton_ClientList.ForeColor = System.Drawing.Color.White;
            this.HomeButton_ClientList.Location = new System.Drawing.Point(992, 18);
            this.HomeButton_ClientList.Name = "HomeButton_ClientList";
            this.HomeButton_ClientList.Size = new System.Drawing.Size(104, 43);
            this.HomeButton_ClientList.TabIndex = 6;
            this.HomeButton_ClientList.Text = "Home";
            this.HomeButton_ClientList.UseVisualStyleBackColor = false;
            this.HomeButton_ClientList.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // SelectClientRow
            // 
            this.SelectClientRow.BackColor = System.Drawing.Color.Gray;
            this.SelectClientRow.Location = new System.Drawing.Point(73, 138);
            this.SelectClientRow.Name = "SelectClientRow";
            this.SelectClientRow.Size = new System.Drawing.Size(1, 303);
            this.SelectClientRow.TabIndex = 14;
            this.SelectClientRow.TabStop = false;
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.Client_ButtonCopyForm);
            this.tabClient.Controls.Add(this.Client_ButtonCopy);
            this.tabClient.Controls.Add(this.Client_ButtonFormat);
            this.tabClient.Controls.Add(this.Client_ButtonRestore);
            this.tabClient.Controls.Add(this.Client_CriticalyLabel);
            this.tabClient.Controls.Add(this.Client_VarEx09);
            this.tabClient.Controls.Add(this.Client_VarDelete09);
            this.tabClient.Controls.Add(this.Client_NameVar09);
            this.tabClient.Controls.Add(this.Client_VarText09);
            this.tabClient.Controls.Add(this.Client_VarEx08);
            this.tabClient.Controls.Add(this.Client_VarDelete08);
            this.tabClient.Controls.Add(this.Client_NameVar08);
            this.tabClient.Controls.Add(this.Client_VarText08);
            this.tabClient.Controls.Add(this.Client_VarEx07);
            this.tabClient.Controls.Add(this.Client_VarDelete07);
            this.tabClient.Controls.Add(this.Client_NameVar07);
            this.tabClient.Controls.Add(this.Client_VarText07);
            this.tabClient.Controls.Add(this.Client_VarEx06);
            this.tabClient.Controls.Add(this.Client_VarDelete06);
            this.tabClient.Controls.Add(this.Client_NameVar06);
            this.tabClient.Controls.Add(this.Client_VarText06);
            this.tabClient.Controls.Add(this.Client_VarEx05);
            this.tabClient.Controls.Add(this.Client_VarDelete05);
            this.tabClient.Controls.Add(this.Client_NameVar05);
            this.tabClient.Controls.Add(this.Client_VarText05);
            this.tabClient.Controls.Add(this.Client_VarEx04);
            this.tabClient.Controls.Add(this.Client_VarDelete04);
            this.tabClient.Controls.Add(this.Client_NameVar04);
            this.tabClient.Controls.Add(this.Client_VarText04);
            this.tabClient.Controls.Add(this.Client_VarEx03);
            this.tabClient.Controls.Add(this.Client_VarDelete03);
            this.tabClient.Controls.Add(this.Client_NameVar03);
            this.tabClient.Controls.Add(this.Client_VarText03);
            this.tabClient.Controls.Add(this.Client_VarEx02);
            this.tabClient.Controls.Add(this.Client_VarDelete02);
            this.tabClient.Controls.Add(this.Client_NameVar02);
            this.tabClient.Controls.Add(this.Client_VarText02);
            this.tabClient.Controls.Add(this.Client_VarEx01);
            this.tabClient.Controls.Add(this.Client_VarDelete01);
            this.tabClient.Controls.Add(this.Client_NameVar01);
            this.tabClient.Controls.Add(this.Client_VarText01);
            this.tabClient.Controls.Add(this.Client_ExSubTitle);
            this.tabClient.Controls.Add(this.Client_VarEx00);
            this.tabClient.Controls.Add(this.Client_VarDelete00);
            this.tabClient.Controls.Add(this.Client_ButtonDeleteAll);
            this.tabClient.Controls.Add(this.Client_VarSubTitle);
            this.tabClient.Controls.Add(this.Client_NameVar00);
            this.tabClient.Controls.Add(this.Client_VarText00);
            this.tabClient.Controls.Add(this.Client_StepScript);
            this.tabClient.Controls.Add(this.Client_NameTitle);
            this.tabClient.Controls.Add(this.Client_StepText);
            this.tabClient.Controls.Add(this.BackButton_ClientSteps);
            this.tabClient.Controls.Add(this.HomeButton_ClientSteps);
            this.tabClient.Controls.Add(this.Client_NextStep);
            this.tabClient.Controls.Add(this.Client_BackStep);
            this.tabClient.Controls.Add(this.Client_StepPicture);
            this.tabClient.Controls.Add(this.Client_Row0);
            this.tabClient.Controls.Add(this.Client_Row1);
            this.tabClient.Location = new System.Drawing.Point(4, 5);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(1112, 513);
            this.tabClient.TabIndex = 10;
            this.tabClient.Text = "tabClient";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // Client_ButtonCopyForm
            // 
            this.Client_ButtonCopyForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_ButtonCopyForm.BackColor = System.Drawing.SystemColors.Control;
            this.Client_ButtonCopyForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_ButtonCopyForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Client_ButtonCopyForm.Location = new System.Drawing.Point(1006, 65);
            this.Client_ButtonCopyForm.Name = "Client_ButtonCopyForm";
            this.Client_ButtonCopyForm.Size = new System.Drawing.Size(90, 51);
            this.Client_ButtonCopyForm.TabIndex = 163;
            this.Client_ButtonCopyForm.Text = "Copiar e\r\n Formatar";
            this.Client_ButtonCopyForm.UseVisualStyleBackColor = false;
            this.Client_ButtonCopyForm.Click += new System.EventHandler(this.Client_ButtonCopyForm_Click);
            // 
            // Client_ButtonCopy
            // 
            this.Client_ButtonCopy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_ButtonCopy.BackColor = System.Drawing.SystemColors.Control;
            this.Client_ButtonCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_ButtonCopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Client_ButtonCopy.Location = new System.Drawing.Point(905, 65);
            this.Client_ButtonCopy.Name = "Client_ButtonCopy";
            this.Client_ButtonCopy.Size = new System.Drawing.Size(90, 51);
            this.Client_ButtonCopy.TabIndex = 162;
            this.Client_ButtonCopy.Text = "Copiar";
            this.Client_ButtonCopy.UseVisualStyleBackColor = false;
            this.Client_ButtonCopy.Click += new System.EventHandler(this.Client_ButtonCopy_Click);
            // 
            // Client_ButtonFormat
            // 
            this.Client_ButtonFormat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_ButtonFormat.BackColor = System.Drawing.SystemColors.Control;
            this.Client_ButtonFormat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_ButtonFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Client_ButtonFormat.Location = new System.Drawing.Point(803, 65);
            this.Client_ButtonFormat.Name = "Client_ButtonFormat";
            this.Client_ButtonFormat.Size = new System.Drawing.Size(90, 51);
            this.Client_ButtonFormat.TabIndex = 161;
            this.Client_ButtonFormat.Text = "Formatar";
            this.Client_ButtonFormat.UseVisualStyleBackColor = false;
            this.Client_ButtonFormat.Click += new System.EventHandler(this.Client_ButtonFormat_Click);
            // 
            // Client_ButtonRestore
            // 
            this.Client_ButtonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Client_ButtonRestore.BackColor = System.Drawing.SystemColors.Control;
            this.Client_ButtonRestore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_ButtonRestore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Client_ButtonRestore.Location = new System.Drawing.Point(803, 454);
            this.Client_ButtonRestore.Name = "Client_ButtonRestore";
            this.Client_ButtonRestore.Size = new System.Drawing.Size(104, 43);
            this.Client_ButtonRestore.TabIndex = 160;
            this.Client_ButtonRestore.Text = "Restore";
            this.Client_ButtonRestore.UseVisualStyleBackColor = false;
            this.Client_ButtonRestore.Click += new System.EventHandler(this.Client_Restore_Click);
            // 
            // Client_CriticalyLabel
            // 
            this.Client_CriticalyLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_CriticalyLabel.AutoSize = true;
            this.Client_CriticalyLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.Client_CriticalyLabel.ForeColor = System.Drawing.Color.Red;
            this.Client_CriticalyLabel.Location = new System.Drawing.Point(663, 28);
            this.Client_CriticalyLabel.Name = "Client_CriticalyLabel";
            this.Client_CriticalyLabel.Size = new System.Drawing.Size(85, 31);
            this.Client_CriticalyLabel.TabIndex = 159;
            this.Client_CriticalyLabel.Text = "Crítico";
            this.Client_CriticalyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Client_VarEx09
            // 
            this.Client_VarEx09.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarEx09.AutoSize = true;
            this.Client_VarEx09.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.Client_VarEx09.Location = new System.Drawing.Point(728, 407);
            this.Client_VarEx09.Name = "Client_VarEx09";
            this.Client_VarEx09.Size = new System.Drawing.Size(50, 12);
            this.Client_VarEx09.TabIndex = 158;
            this.Client_VarEx09.Text = "Teste_BLD";
            // 
            // Client_VarDelete09
            // 
            this.Client_VarDelete09.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarDelete09.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_VarDelete09.Location = new System.Drawing.Point(702, 401);
            this.Client_VarDelete09.Name = "Client_VarDelete09";
            this.Client_VarDelete09.Size = new System.Drawing.Size(20, 25);
            this.Client_VarDelete09.TabIndex = 157;
            this.Client_VarDelete09.Text = "-";
            this.Client_VarDelete09.UseVisualStyleBackColor = true;
            this.Client_VarDelete09.Click += new System.EventHandler(this.Client_VarDelete09_Click);
            // 
            // Client_NameVar09
            // 
            this.Client_NameVar09.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_NameVar09.AutoSize = true;
            this.Client_NameVar09.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_NameVar09.Location = new System.Drawing.Point(529, 407);
            this.Client_NameVar09.Name = "Client_NameVar09";
            this.Client_NameVar09.Size = new System.Drawing.Size(62, 13);
            this.Client_NameVar09.TabIndex = 156;
            this.Client_NameVar09.Text = "Hostname:";
            // 
            // Client_VarText09
            // 
            this.Client_VarText09.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarText09.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_VarText09.Location = new System.Drawing.Point(597, 404);
            this.Client_VarText09.Name = "Client_VarText09";
            this.Client_VarText09.Size = new System.Drawing.Size(99, 21);
            this.Client_VarText09.TabIndex = 155;
            // 
            // Client_VarEx08
            // 
            this.Client_VarEx08.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarEx08.AutoSize = true;
            this.Client_VarEx08.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.Client_VarEx08.Location = new System.Drawing.Point(728, 379);
            this.Client_VarEx08.Name = "Client_VarEx08";
            this.Client_VarEx08.Size = new System.Drawing.Size(50, 12);
            this.Client_VarEx08.TabIndex = 154;
            this.Client_VarEx08.Text = "Teste_BLD";
            // 
            // Client_VarDelete08
            // 
            this.Client_VarDelete08.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarDelete08.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_VarDelete08.Location = new System.Drawing.Point(702, 373);
            this.Client_VarDelete08.Name = "Client_VarDelete08";
            this.Client_VarDelete08.Size = new System.Drawing.Size(20, 25);
            this.Client_VarDelete08.TabIndex = 153;
            this.Client_VarDelete08.Text = "-";
            this.Client_VarDelete08.UseVisualStyleBackColor = true;
            this.Client_VarDelete08.Click += new System.EventHandler(this.Client_VarDelete08_Click);
            // 
            // Client_NameVar08
            // 
            this.Client_NameVar08.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_NameVar08.AutoSize = true;
            this.Client_NameVar08.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_NameVar08.Location = new System.Drawing.Point(529, 379);
            this.Client_NameVar08.Name = "Client_NameVar08";
            this.Client_NameVar08.Size = new System.Drawing.Size(62, 13);
            this.Client_NameVar08.TabIndex = 152;
            this.Client_NameVar08.Text = "Hostname:";
            // 
            // Client_VarText08
            // 
            this.Client_VarText08.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarText08.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_VarText08.Location = new System.Drawing.Point(597, 376);
            this.Client_VarText08.Name = "Client_VarText08";
            this.Client_VarText08.Size = new System.Drawing.Size(99, 21);
            this.Client_VarText08.TabIndex = 151;
            // 
            // Client_VarEx07
            // 
            this.Client_VarEx07.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarEx07.AutoSize = true;
            this.Client_VarEx07.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.Client_VarEx07.Location = new System.Drawing.Point(728, 352);
            this.Client_VarEx07.Name = "Client_VarEx07";
            this.Client_VarEx07.Size = new System.Drawing.Size(50, 12);
            this.Client_VarEx07.TabIndex = 150;
            this.Client_VarEx07.Text = "Teste_BLD";
            // 
            // Client_VarDelete07
            // 
            this.Client_VarDelete07.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarDelete07.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_VarDelete07.Location = new System.Drawing.Point(702, 346);
            this.Client_VarDelete07.Name = "Client_VarDelete07";
            this.Client_VarDelete07.Size = new System.Drawing.Size(20, 25);
            this.Client_VarDelete07.TabIndex = 149;
            this.Client_VarDelete07.Text = "-";
            this.Client_VarDelete07.UseVisualStyleBackColor = true;
            this.Client_VarDelete07.Click += new System.EventHandler(this.Client_VarDelete07_Click);
            // 
            // Client_NameVar07
            // 
            this.Client_NameVar07.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_NameVar07.AutoSize = true;
            this.Client_NameVar07.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_NameVar07.Location = new System.Drawing.Point(529, 352);
            this.Client_NameVar07.Name = "Client_NameVar07";
            this.Client_NameVar07.Size = new System.Drawing.Size(62, 13);
            this.Client_NameVar07.TabIndex = 148;
            this.Client_NameVar07.Text = "Hostname:";
            // 
            // Client_VarText07
            // 
            this.Client_VarText07.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarText07.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_VarText07.Location = new System.Drawing.Point(597, 349);
            this.Client_VarText07.Name = "Client_VarText07";
            this.Client_VarText07.Size = new System.Drawing.Size(99, 21);
            this.Client_VarText07.TabIndex = 147;
            // 
            // Client_VarEx06
            // 
            this.Client_VarEx06.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarEx06.AutoSize = true;
            this.Client_VarEx06.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.Client_VarEx06.Location = new System.Drawing.Point(728, 325);
            this.Client_VarEx06.Name = "Client_VarEx06";
            this.Client_VarEx06.Size = new System.Drawing.Size(50, 12);
            this.Client_VarEx06.TabIndex = 146;
            this.Client_VarEx06.Text = "Teste_BLD";
            // 
            // Client_VarDelete06
            // 
            this.Client_VarDelete06.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarDelete06.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_VarDelete06.Location = new System.Drawing.Point(702, 319);
            this.Client_VarDelete06.Name = "Client_VarDelete06";
            this.Client_VarDelete06.Size = new System.Drawing.Size(20, 25);
            this.Client_VarDelete06.TabIndex = 145;
            this.Client_VarDelete06.Text = "-";
            this.Client_VarDelete06.UseVisualStyleBackColor = true;
            this.Client_VarDelete06.Click += new System.EventHandler(this.Client_VarDelete06_Click);
            // 
            // Client_NameVar06
            // 
            this.Client_NameVar06.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_NameVar06.AutoSize = true;
            this.Client_NameVar06.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_NameVar06.Location = new System.Drawing.Point(529, 325);
            this.Client_NameVar06.Name = "Client_NameVar06";
            this.Client_NameVar06.Size = new System.Drawing.Size(62, 13);
            this.Client_NameVar06.TabIndex = 144;
            this.Client_NameVar06.Text = "Hostname:";
            // 
            // Client_VarText06
            // 
            this.Client_VarText06.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarText06.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_VarText06.Location = new System.Drawing.Point(597, 322);
            this.Client_VarText06.Name = "Client_VarText06";
            this.Client_VarText06.Size = new System.Drawing.Size(99, 21);
            this.Client_VarText06.TabIndex = 143;
            // 
            // Client_VarEx05
            // 
            this.Client_VarEx05.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarEx05.AutoSize = true;
            this.Client_VarEx05.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.Client_VarEx05.Location = new System.Drawing.Point(728, 297);
            this.Client_VarEx05.Name = "Client_VarEx05";
            this.Client_VarEx05.Size = new System.Drawing.Size(50, 12);
            this.Client_VarEx05.TabIndex = 142;
            this.Client_VarEx05.Text = "Teste_BLD";
            // 
            // Client_VarDelete05
            // 
            this.Client_VarDelete05.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarDelete05.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_VarDelete05.Location = new System.Drawing.Point(702, 291);
            this.Client_VarDelete05.Name = "Client_VarDelete05";
            this.Client_VarDelete05.Size = new System.Drawing.Size(20, 25);
            this.Client_VarDelete05.TabIndex = 141;
            this.Client_VarDelete05.Text = "-";
            this.Client_VarDelete05.UseVisualStyleBackColor = true;
            this.Client_VarDelete05.Click += new System.EventHandler(this.Client_VarDelete05_Click);
            // 
            // Client_NameVar05
            // 
            this.Client_NameVar05.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_NameVar05.AutoSize = true;
            this.Client_NameVar05.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_NameVar05.Location = new System.Drawing.Point(529, 297);
            this.Client_NameVar05.Name = "Client_NameVar05";
            this.Client_NameVar05.Size = new System.Drawing.Size(62, 13);
            this.Client_NameVar05.TabIndex = 140;
            this.Client_NameVar05.Text = "Hostname:";
            // 
            // Client_VarText05
            // 
            this.Client_VarText05.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarText05.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_VarText05.Location = new System.Drawing.Point(597, 294);
            this.Client_VarText05.Name = "Client_VarText05";
            this.Client_VarText05.Size = new System.Drawing.Size(99, 21);
            this.Client_VarText05.TabIndex = 139;
            // 
            // Client_VarEx04
            // 
            this.Client_VarEx04.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarEx04.AutoSize = true;
            this.Client_VarEx04.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.Client_VarEx04.Location = new System.Drawing.Point(728, 270);
            this.Client_VarEx04.Name = "Client_VarEx04";
            this.Client_VarEx04.Size = new System.Drawing.Size(50, 12);
            this.Client_VarEx04.TabIndex = 138;
            this.Client_VarEx04.Text = "Teste_BLD";
            // 
            // Client_VarDelete04
            // 
            this.Client_VarDelete04.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarDelete04.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_VarDelete04.Location = new System.Drawing.Point(702, 264);
            this.Client_VarDelete04.Name = "Client_VarDelete04";
            this.Client_VarDelete04.Size = new System.Drawing.Size(20, 25);
            this.Client_VarDelete04.TabIndex = 137;
            this.Client_VarDelete04.Text = "-";
            this.Client_VarDelete04.UseVisualStyleBackColor = true;
            this.Client_VarDelete04.Click += new System.EventHandler(this.Client_VarDelete04_Click);
            // 
            // Client_NameVar04
            // 
            this.Client_NameVar04.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_NameVar04.AutoSize = true;
            this.Client_NameVar04.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_NameVar04.Location = new System.Drawing.Point(529, 270);
            this.Client_NameVar04.Name = "Client_NameVar04";
            this.Client_NameVar04.Size = new System.Drawing.Size(62, 13);
            this.Client_NameVar04.TabIndex = 136;
            this.Client_NameVar04.Text = "Hostname:";
            // 
            // Client_VarText04
            // 
            this.Client_VarText04.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarText04.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_VarText04.Location = new System.Drawing.Point(597, 267);
            this.Client_VarText04.Name = "Client_VarText04";
            this.Client_VarText04.Size = new System.Drawing.Size(99, 21);
            this.Client_VarText04.TabIndex = 135;
            // 
            // Client_VarEx03
            // 
            this.Client_VarEx03.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarEx03.AutoSize = true;
            this.Client_VarEx03.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.Client_VarEx03.Location = new System.Drawing.Point(728, 243);
            this.Client_VarEx03.Name = "Client_VarEx03";
            this.Client_VarEx03.Size = new System.Drawing.Size(50, 12);
            this.Client_VarEx03.TabIndex = 134;
            this.Client_VarEx03.Text = "Teste_BLD";
            // 
            // Client_VarDelete03
            // 
            this.Client_VarDelete03.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarDelete03.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_VarDelete03.Location = new System.Drawing.Point(702, 237);
            this.Client_VarDelete03.Name = "Client_VarDelete03";
            this.Client_VarDelete03.Size = new System.Drawing.Size(20, 25);
            this.Client_VarDelete03.TabIndex = 133;
            this.Client_VarDelete03.Text = "-";
            this.Client_VarDelete03.UseVisualStyleBackColor = true;
            this.Client_VarDelete03.Click += new System.EventHandler(this.Client_VarDelete03_Click);
            // 
            // Client_NameVar03
            // 
            this.Client_NameVar03.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_NameVar03.AutoSize = true;
            this.Client_NameVar03.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_NameVar03.Location = new System.Drawing.Point(529, 243);
            this.Client_NameVar03.Name = "Client_NameVar03";
            this.Client_NameVar03.Size = new System.Drawing.Size(62, 13);
            this.Client_NameVar03.TabIndex = 132;
            this.Client_NameVar03.Text = "Hostname:";
            // 
            // Client_VarText03
            // 
            this.Client_VarText03.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarText03.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_VarText03.Location = new System.Drawing.Point(597, 240);
            this.Client_VarText03.Name = "Client_VarText03";
            this.Client_VarText03.Size = new System.Drawing.Size(99, 21);
            this.Client_VarText03.TabIndex = 131;
            // 
            // Client_VarEx02
            // 
            this.Client_VarEx02.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarEx02.AutoSize = true;
            this.Client_VarEx02.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.Client_VarEx02.Location = new System.Drawing.Point(728, 216);
            this.Client_VarEx02.Name = "Client_VarEx02";
            this.Client_VarEx02.Size = new System.Drawing.Size(50, 12);
            this.Client_VarEx02.TabIndex = 130;
            this.Client_VarEx02.Text = "Teste_BLD";
            // 
            // Client_VarDelete02
            // 
            this.Client_VarDelete02.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarDelete02.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_VarDelete02.Location = new System.Drawing.Point(702, 210);
            this.Client_VarDelete02.Name = "Client_VarDelete02";
            this.Client_VarDelete02.Size = new System.Drawing.Size(20, 25);
            this.Client_VarDelete02.TabIndex = 129;
            this.Client_VarDelete02.Text = "-";
            this.Client_VarDelete02.UseVisualStyleBackColor = true;
            this.Client_VarDelete02.Click += new System.EventHandler(this.Client_VarDelete02_Click);
            // 
            // Client_NameVar02
            // 
            this.Client_NameVar02.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_NameVar02.AutoSize = true;
            this.Client_NameVar02.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_NameVar02.Location = new System.Drawing.Point(529, 216);
            this.Client_NameVar02.Name = "Client_NameVar02";
            this.Client_NameVar02.Size = new System.Drawing.Size(62, 13);
            this.Client_NameVar02.TabIndex = 128;
            this.Client_NameVar02.Text = "Hostname:";
            // 
            // Client_VarText02
            // 
            this.Client_VarText02.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarText02.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_VarText02.Location = new System.Drawing.Point(597, 213);
            this.Client_VarText02.Name = "Client_VarText02";
            this.Client_VarText02.Size = new System.Drawing.Size(99, 21);
            this.Client_VarText02.TabIndex = 127;
            // 
            // Client_VarEx01
            // 
            this.Client_VarEx01.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarEx01.AutoSize = true;
            this.Client_VarEx01.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.Client_VarEx01.Location = new System.Drawing.Point(728, 189);
            this.Client_VarEx01.Name = "Client_VarEx01";
            this.Client_VarEx01.Size = new System.Drawing.Size(50, 12);
            this.Client_VarEx01.TabIndex = 126;
            this.Client_VarEx01.Text = "Teste_BLD";
            // 
            // Client_VarDelete01
            // 
            this.Client_VarDelete01.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarDelete01.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_VarDelete01.Location = new System.Drawing.Point(702, 183);
            this.Client_VarDelete01.Name = "Client_VarDelete01";
            this.Client_VarDelete01.Size = new System.Drawing.Size(20, 25);
            this.Client_VarDelete01.TabIndex = 125;
            this.Client_VarDelete01.Text = "-";
            this.Client_VarDelete01.UseVisualStyleBackColor = true;
            this.Client_VarDelete01.Click += new System.EventHandler(this.Client_VarDelete01_Click);
            // 
            // Client_NameVar01
            // 
            this.Client_NameVar01.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_NameVar01.AutoSize = true;
            this.Client_NameVar01.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_NameVar01.Location = new System.Drawing.Point(529, 189);
            this.Client_NameVar01.Name = "Client_NameVar01";
            this.Client_NameVar01.Size = new System.Drawing.Size(62, 13);
            this.Client_NameVar01.TabIndex = 124;
            this.Client_NameVar01.Text = "Hostname:";
            // 
            // Client_VarText01
            // 
            this.Client_VarText01.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarText01.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_VarText01.Location = new System.Drawing.Point(597, 186);
            this.Client_VarText01.Name = "Client_VarText01";
            this.Client_VarText01.Size = new System.Drawing.Size(99, 21);
            this.Client_VarText01.TabIndex = 123;
            // 
            // Client_ExSubTitle
            // 
            this.Client_ExSubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_ExSubTitle.AutoSize = true;
            this.Client_ExSubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Client_ExSubTitle.Location = new System.Drawing.Point(728, 133);
            this.Client_ExSubTitle.Name = "Client_ExSubTitle";
            this.Client_ExSubTitle.Size = new System.Drawing.Size(58, 13);
            this.Client_ExSubTitle.TabIndex = 122;
            this.Client_ExSubTitle.Text = "Exemplos:";
            // 
            // Client_VarEx00
            // 
            this.Client_VarEx00.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarEx00.AutoSize = true;
            this.Client_VarEx00.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.Client_VarEx00.Location = new System.Drawing.Point(728, 162);
            this.Client_VarEx00.Name = "Client_VarEx00";
            this.Client_VarEx00.Size = new System.Drawing.Size(50, 12);
            this.Client_VarEx00.TabIndex = 121;
            this.Client_VarEx00.Text = "Teste_BLD";
            // 
            // Client_VarDelete00
            // 
            this.Client_VarDelete00.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarDelete00.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_VarDelete00.Location = new System.Drawing.Point(702, 156);
            this.Client_VarDelete00.Name = "Client_VarDelete00";
            this.Client_VarDelete00.Size = new System.Drawing.Size(20, 25);
            this.Client_VarDelete00.TabIndex = 120;
            this.Client_VarDelete00.Text = "-";
            this.Client_VarDelete00.UseVisualStyleBackColor = true;
            this.Client_VarDelete00.Click += new System.EventHandler(this.Client_VarDelete00_Click);
            // 
            // Client_ButtonDeleteAll
            // 
            this.Client_ButtonDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_ButtonDeleteAll.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Client_ButtonDeleteAll.Location = new System.Drawing.Point(643, 127);
            this.Client_ButtonDeleteAll.Name = "Client_ButtonDeleteAll";
            this.Client_ButtonDeleteAll.Size = new System.Drawing.Size(79, 22);
            this.Client_ButtonDeleteAll.TabIndex = 119;
            this.Client_ButtonDeleteAll.Text = "Limpar";
            this.Client_ButtonDeleteAll.UseVisualStyleBackColor = true;
            this.Client_ButtonDeleteAll.Click += new System.EventHandler(this.Client_DeleteAll_Click);
            // 
            // Client_VarSubTitle
            // 
            this.Client_VarSubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarSubTitle.AutoSize = true;
            this.Client_VarSubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.Client_VarSubTitle.Location = new System.Drawing.Point(544, 129);
            this.Client_VarSubTitle.Name = "Client_VarSubTitle";
            this.Client_VarSubTitle.Size = new System.Drawing.Size(64, 19);
            this.Client_VarSubTitle.TabIndex = 118;
            this.Client_VarSubTitle.Text = "Variáveis";
            // 
            // Client_NameVar00
            // 
            this.Client_NameVar00.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_NameVar00.AutoSize = true;
            this.Client_NameVar00.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_NameVar00.Location = new System.Drawing.Point(529, 162);
            this.Client_NameVar00.Name = "Client_NameVar00";
            this.Client_NameVar00.Size = new System.Drawing.Size(62, 13);
            this.Client_NameVar00.TabIndex = 117;
            this.Client_NameVar00.Text = "Hostname:";
            // 
            // Client_VarText00
            // 
            this.Client_VarText00.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_VarText00.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.Client_VarText00.Location = new System.Drawing.Point(597, 159);
            this.Client_VarText00.Name = "Client_VarText00";
            this.Client_VarText00.Size = new System.Drawing.Size(99, 21);
            this.Client_VarText00.TabIndex = 116;
            // 
            // Client_StepScript
            // 
            this.Client_StepScript.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_StepScript.Font = new System.Drawing.Font("Segoe UI Semibold", 8.45F, System.Drawing.FontStyle.Bold);
            this.Client_StepScript.Location = new System.Drawing.Point(803, 122);
            this.Client_StepScript.Name = "Client_StepScript";
            this.Client_StepScript.Size = new System.Drawing.Size(293, 326);
            this.Client_StepScript.TabIndex = 35;
            this.Client_StepScript.Text = "";
            this.Client_StepScript.WordWrap = false;
            // 
            // Client_NameTitle
            // 
            this.Client_NameTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_NameTitle.AutoSize = true;
            this.Client_NameTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_NameTitle.Location = new System.Drawing.Point(457, 21);
            this.Client_NameTitle.Name = "Client_NameTitle";
            this.Client_NameTitle.Size = new System.Drawing.Size(203, 45);
            this.Client_NameTitle.TabIndex = 33;
            this.Client_NameTitle.Text = "Client Name";
            this.Client_NameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Client_StepText
            // 
            this.Client_StepText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_StepText.AutoSize = true;
            this.Client_StepText.Location = new System.Drawing.Point(22, 133);
            this.Client_StepText.Name = "Client_StepText";
            this.Client_StepText.Size = new System.Drawing.Size(125, 19);
            this.Client_StepText.TabIndex = 32;
            this.Client_StepText.Text = "Passo a Passo aqui";
            // 
            // BackButton_ClientSteps
            // 
            this.BackButton_ClientSteps.BackColor = System.Drawing.SystemColors.Control;
            this.BackButton_ClientSteps.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_ClientSteps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton_ClientSteps.Location = new System.Drawing.Point(17, 21);
            this.BackButton_ClientSteps.Name = "BackButton_ClientSteps";
            this.BackButton_ClientSteps.Size = new System.Drawing.Size(104, 43);
            this.BackButton_ClientSteps.TabIndex = 31;
            this.BackButton_ClientSteps.Text = "Voltar";
            this.BackButton_ClientSteps.UseVisualStyleBackColor = false;
            this.BackButton_ClientSteps.Click += new System.EventHandler(this.BackButton_ClientSteps_Click);
            // 
            // HomeButton_ClientSteps
            // 
            this.HomeButton_ClientSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton_ClientSteps.BackColor = System.Drawing.SystemColors.Highlight;
            this.HomeButton_ClientSteps.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton_ClientSteps.ForeColor = System.Drawing.Color.White;
            this.HomeButton_ClientSteps.Location = new System.Drawing.Point(992, 16);
            this.HomeButton_ClientSteps.Name = "HomeButton_ClientSteps";
            this.HomeButton_ClientSteps.Size = new System.Drawing.Size(104, 43);
            this.HomeButton_ClientSteps.TabIndex = 5;
            this.HomeButton_ClientSteps.Text = "Home";
            this.HomeButton_ClientSteps.UseVisualStyleBackColor = false;
            this.HomeButton_ClientSteps.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // Client_NextStep
            // 
            this.Client_NextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Client_NextStep.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.Client_NextStep.Location = new System.Drawing.Point(1047, 454);
            this.Client_NextStep.Name = "Client_NextStep";
            this.Client_NextStep.Size = new System.Drawing.Size(50, 42);
            this.Client_NextStep.TabIndex = 1;
            this.Client_NextStep.Text = ">";
            this.Client_NextStep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Client_NextStep.UseVisualStyleBackColor = true;
            this.Client_NextStep.Click += new System.EventHandler(this.Client_NextStep_Click);
            // 
            // Client_BackStep
            // 
            this.Client_BackStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Client_BackStep.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.Client_BackStep.Location = new System.Drawing.Point(17, 448);
            this.Client_BackStep.Name = "Client_BackStep";
            this.Client_BackStep.Size = new System.Drawing.Size(50, 42);
            this.Client_BackStep.TabIndex = 0;
            this.Client_BackStep.Text = "<";
            this.Client_BackStep.UseVisualStyleBackColor = true;
            this.Client_BackStep.Click += new System.EventHandler(this.Client_BackStep_Click);
            // 
            // Client_StepPicture
            // 
            this.Client_StepPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_StepPicture.Location = new System.Drawing.Point(308, 159);
            this.Client_StepPicture.Name = "Client_StepPicture";
            this.Client_StepPicture.Size = new System.Drawing.Size(197, 226);
            this.Client_StepPicture.TabIndex = 37;
            this.Client_StepPicture.TabStop = false;
            // 
            // Client_Row0
            // 
            this.Client_Row0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_Row0.BackColor = System.Drawing.Color.Gray;
            this.Client_Row0.Location = new System.Drawing.Point(289, 128);
            this.Client_Row0.Name = "Client_Row0";
            this.Client_Row0.Size = new System.Drawing.Size(1, 303);
            this.Client_Row0.TabIndex = 36;
            this.Client_Row0.TabStop = false;
            // 
            // Client_Row1
            // 
            this.Client_Row1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Client_Row1.BackColor = System.Drawing.Color.Gray;
            this.Client_Row1.Location = new System.Drawing.Point(522, 128);
            this.Client_Row1.Name = "Client_Row1";
            this.Client_Row1.Size = new System.Drawing.Size(1, 303);
            this.Client_Row1.TabIndex = 34;
            this.Client_Row1.TabStop = false;
            // 
            // OpenPE_Button
            // 
            this.OpenPE_Button.BackColor = System.Drawing.Color.White;
            this.OpenPE_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.OpenPE_Button.Location = new System.Drawing.Point(157, 3);
            this.OpenPE_Button.Margin = new System.Windows.Forms.Padding(0);
            this.OpenPE_Button.Name = "OpenPE_Button";
            this.OpenPE_Button.Size = new System.Drawing.Size(89, 37);
            this.OpenPE_Button.TabIndex = 7;
            this.OpenPE_Button.Text = "Acessar";
            this.OpenPE_Button.UseVisualStyleBackColor = false;
            this.OpenPE_Button.Click += new System.EventHandler(this.OpenPE_Button_Click);
            // 
            // OpenPE_PictureBox
            // 
            this.OpenPE_PictureBox.BackColor = System.Drawing.Color.White;
            this.OpenPE_PictureBox.Location = new System.Drawing.Point(3, 3);
            this.OpenPE_PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.OpenPE_PictureBox.Name = "OpenPE_PictureBox";
            this.OpenPE_PictureBox.Size = new System.Drawing.Size(243, 38);
            this.OpenPE_PictureBox.TabIndex = 49;
            this.OpenPE_PictureBox.TabStop = false;
            // 
            // Button_ImportSAIP
            // 
            this.Button_ImportSAIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ImportSAIP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ImportSAIP.Location = new System.Drawing.Point(965, 18);
            this.Button_ImportSAIP.Name = "Button_ImportSAIP";
            this.Button_ImportSAIP.Size = new System.Drawing.Size(138, 37);
            this.Button_ImportSAIP.TabIndex = 122;
            this.Button_ImportSAIP.Text = "Importar SAIP";
            this.Button_ImportSAIP.UseVisualStyleBackColor = true;
            this.Button_ImportSAIP.Click += new System.EventHandler(this.Button_ImportSAIP_Click);
            // 
            // tabLogTools
            // 
            this.tabLogTools.Controls.Add(this.LogTools_MainRow);
            this.tabLogTools.Controls.Add(this.LogTools_DBScriptButton);
            this.tabLogTools.Controls.Add(this.LogToolsCalc);
            this.tabLogTools.Controls.Add(this.LogToolsSuporte);
            this.tabLogTools.Controls.Add(this.LogToolsFechamento);
            this.tabLogTools.Controls.Add(this.LogToolsPendencia);
            this.tabLogTools.Controls.Add(this.tabControlLogTools);
            this.tabLogTools.Location = new System.Drawing.Point(4, 36);
            this.tabLogTools.Name = "tabLogTools";
            this.tabLogTools.Size = new System.Drawing.Size(1126, 599);
            this.tabLogTools.TabIndex = 2;
            this.tabLogTools.Text = "LogTools";
            this.tabLogTools.UseVisualStyleBackColor = true;
            // 
            // LogTools_MainRow
            // 
            this.LogTools_MainRow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LogTools_MainRow.BackColor = System.Drawing.Color.Gray;
            this.LogTools_MainRow.Location = new System.Drawing.Point(152, -1);
            this.LogTools_MainRow.Name = "LogTools_MainRow";
            this.LogTools_MainRow.Size = new System.Drawing.Size(1, 520);
            this.LogTools_MainRow.TabIndex = 17;
            this.LogTools_MainRow.TabStop = false;
            // 
            // LogTools_DBScriptButton
            // 
            this.LogTools_DBScriptButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTools_DBScriptButton.Location = new System.Drawing.Point(20, 335);
            this.LogTools_DBScriptButton.Name = "LogTools_DBScriptButton";
            this.LogTools_DBScriptButton.Size = new System.Drawing.Size(114, 54);
            this.LogTools_DBScriptButton.TabIndex = 16;
            this.LogTools_DBScriptButton.Text = "Script Banco de Dados";
            this.LogTools_DBScriptButton.UseVisualStyleBackColor = true;
            this.LogTools_DBScriptButton.Click += new System.EventHandler(this.LogTools_DBScriptButton_Click);
            // 
            // LogToolsCalc
            // 
            this.LogToolsCalc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogToolsCalc.Location = new System.Drawing.Point(20, 255);
            this.LogToolsCalc.Name = "LogToolsCalc";
            this.LogToolsCalc.Size = new System.Drawing.Size(114, 54);
            this.LogToolsCalc.TabIndex = 15;
            this.LogToolsCalc.Text = "Cálculo de Bloco de IP";
            this.LogToolsCalc.UseVisualStyleBackColor = true;
            this.LogToolsCalc.Click += new System.EventHandler(this.LT_IPCalculator_TabChange);
            // 
            // LogToolsSuporte
            // 
            this.LogToolsSuporte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogToolsSuporte.Location = new System.Drawing.Point(20, 96);
            this.LogToolsSuporte.Name = "LogToolsSuporte";
            this.LogToolsSuporte.Size = new System.Drawing.Size(114, 54);
            this.LogToolsSuporte.TabIndex = 14;
            this.LogToolsSuporte.Text = "Suporte";
            this.LogToolsSuporte.UseVisualStyleBackColor = true;
            this.LogToolsSuporte.Click += new System.EventHandler(this.LogToolsSuporte_Click);
            // 
            // LogToolsFechamento
            // 
            this.LogToolsFechamento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogToolsFechamento.Location = new System.Drawing.Point(20, 176);
            this.LogToolsFechamento.Name = "LogToolsFechamento";
            this.LogToolsFechamento.Size = new System.Drawing.Size(114, 54);
            this.LogToolsFechamento.TabIndex = 13;
            this.LogToolsFechamento.Text = "Fechamento";
            this.LogToolsFechamento.UseVisualStyleBackColor = true;
            this.LogToolsFechamento.Click += new System.EventHandler(this.LogToolsFechamento_Click);
            // 
            // LogToolsPendencia
            // 
            this.LogToolsPendencia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogToolsPendencia.Location = new System.Drawing.Point(20, 22);
            this.LogToolsPendencia.Name = "LogToolsPendencia";
            this.LogToolsPendencia.Size = new System.Drawing.Size(114, 54);
            this.LogToolsPendencia.TabIndex = 12;
            this.LogToolsPendencia.Text = "Pendencia";
            this.LogToolsPendencia.UseVisualStyleBackColor = true;
            this.LogToolsPendencia.Click += new System.EventHandler(this.LogToolsPendencia_Click);
            // 
            // tabControlLogTools
            // 
            this.tabControlLogTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlLogTools.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlLogTools.Controls.Add(this.tabPendencia);
            this.tabControlLogTools.Controls.Add(this.tabFechamento);
            this.tabControlLogTools.Controls.Add(this.tabCalculadoraDeIP);
            this.tabControlLogTools.Controls.Add(this.tabSuporte);
            this.tabControlLogTools.Controls.Add(this.tabScriptDB);
            this.tabControlLogTools.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlLogTools.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControlLogTools.Location = new System.Drawing.Point(154, 3);
            this.tabControlLogTools.Name = "tabControlLogTools";
            this.tabControlLogTools.SelectedIndex = 0;
            this.tabControlLogTools.Size = new System.Drawing.Size(972, 596);
            this.tabControlLogTools.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlLogTools.TabIndex = 11;
            // 
            // tabPendencia
            // 
            this.tabPendencia.Controls.Add(this.Log_TextBox2);
            this.tabPendencia.Controls.Add(this.Log_TextBox3);
            this.tabPendencia.Controls.Add(this.Log_TextBox1);
            this.tabPendencia.Controls.Add(this.Log_Copy);
            this.tabPendencia.Controls.Add(this.Log_FinalTextBox);
            this.tabPendencia.Controls.Add(this.Log_ButtonRestore);
            this.tabPendencia.Controls.Add(this.Log_Clear3);
            this.tabPendencia.Controls.Add(this.Log_Clear2);
            this.tabPendencia.Controls.Add(this.Log_Clear1);
            this.tabPendencia.Controls.Add(this.Log_CopyF);
            this.tabPendencia.Controls.Add(this.Log_ClearAll);
            this.tabPendencia.Controls.Add(this.Log_Format);
            this.tabPendencia.Controls.Add(this.Log_ProximosPassos);
            this.tabPendencia.Controls.Add(this.Log_StatusAtual);
            this.tabPendencia.Controls.Add(this.Log_StatusAnterior);
            this.tabPendencia.Location = new System.Drawing.Point(4, 5);
            this.tabPendencia.Name = "tabPendencia";
            this.tabPendencia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPendencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPendencia.Size = new System.Drawing.Size(964, 587);
            this.tabPendencia.TabIndex = 0;
            this.tabPendencia.Text = "Pendencia";
            this.tabPendencia.UseVisualStyleBackColor = true;
            // 
            // Log_TextBox2
            // 
            this.Log_TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_TextBox2.Location = new System.Drawing.Point(33, 191);
            this.Log_TextBox2.Name = "Log_TextBox2";
            this.Log_TextBox2.Size = new System.Drawing.Size(391, 100);
            this.Log_TextBox2.TabIndex = 21;
            this.Log_TextBox2.Text = "-";
            this.Log_TextBox2.WordWrap = false;
            // 
            // Log_TextBox3
            // 
            this.Log_TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_TextBox3.Location = new System.Drawing.Point(32, 327);
            this.Log_TextBox3.Name = "Log_TextBox3";
            this.Log_TextBox3.Size = new System.Drawing.Size(392, 100);
            this.Log_TextBox3.TabIndex = 22;
            this.Log_TextBox3.Text = "-";
            this.Log_TextBox3.WordWrap = false;
            // 
            // Log_TextBox1
            // 
            this.Log_TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_TextBox1.Location = new System.Drawing.Point(33, 55);
            this.Log_TextBox1.Name = "Log_TextBox1";
            this.Log_TextBox1.Size = new System.Drawing.Size(391, 100);
            this.Log_TextBox1.TabIndex = 20;
            this.Log_TextBox1.Text = "-";
            this.Log_TextBox1.WordWrap = false;
            // 
            // Log_Copy
            // 
            this.Log_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Log_Copy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Copy.Location = new System.Drawing.Point(805, 26);
            this.Log_Copy.Name = "Log_Copy";
            this.Log_Copy.Size = new System.Drawing.Size(120, 40);
            this.Log_Copy.TabIndex = 16;
            this.Log_Copy.Text = "Copiar";
            this.Log_Copy.UseVisualStyleBackColor = true;
            this.Log_Copy.Click += new System.EventHandler(this.Log_Copy_Click_2);
            // 
            // Log_FinalTextBox
            // 
            this.Log_FinalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log_FinalTextBox.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Log_FinalTextBox.Location = new System.Drawing.Point(460, 25);
            this.Log_FinalTextBox.Name = "Log_FinalTextBox";
            this.Log_FinalTextBox.Size = new System.Drawing.Size(465, 454);
            this.Log_FinalTextBox.TabIndex = 19;
            this.Log_FinalTextBox.Text = "================== \nSTATUS ANTERIOR: \n================== \n\n\n================== \nS" +
    "TATUS ATUAL: \n================== \n\n\n================== \nPRÓXIMOS PASSOS: \n======" +
    "============ \n\n\n";
            this.Log_FinalTextBox.WordWrap = false;
            // 
            // Log_ButtonRestore
            // 
            this.Log_ButtonRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_ButtonRestore.Location = new System.Drawing.Point(33, 445);
            this.Log_ButtonRestore.Name = "Log_ButtonRestore";
            this.Log_ButtonRestore.Size = new System.Drawing.Size(90, 40);
            this.Log_ButtonRestore.TabIndex = 18;
            this.Log_ButtonRestore.Text = "Restore";
            this.Log_ButtonRestore.UseVisualStyleBackColor = true;
            this.Log_ButtonRestore.Click += new System.EventHandler(this.Log_ButtonRestore_Click);
            // 
            // Log_Clear3
            // 
            this.Log_Clear3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Clear3.Location = new System.Drawing.Point(352, 297);
            this.Log_Clear3.Name = "Log_Clear3";
            this.Log_Clear3.Size = new System.Drawing.Size(73, 29);
            this.Log_Clear3.TabIndex = 15;
            this.Log_Clear3.Text = "Limpar";
            this.Log_Clear3.UseVisualStyleBackColor = true;
            this.Log_Clear3.Click += new System.EventHandler(this.Log_Clear3_Click);
            // 
            // Log_Clear2
            // 
            this.Log_Clear2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Clear2.Location = new System.Drawing.Point(352, 161);
            this.Log_Clear2.Name = "Log_Clear2";
            this.Log_Clear2.Size = new System.Drawing.Size(73, 29);
            this.Log_Clear2.TabIndex = 14;
            this.Log_Clear2.Text = "Limpar";
            this.Log_Clear2.UseVisualStyleBackColor = true;
            this.Log_Clear2.Click += new System.EventHandler(this.Log_Clear2_Click);
            // 
            // Log_Clear1
            // 
            this.Log_Clear1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Clear1.Location = new System.Drawing.Point(352, 25);
            this.Log_Clear1.Name = "Log_Clear1";
            this.Log_Clear1.Size = new System.Drawing.Size(73, 29);
            this.Log_Clear1.TabIndex = 13;
            this.Log_Clear1.Text = "Limpar";
            this.Log_Clear1.UseVisualStyleBackColor = true;
            this.Log_Clear1.Click += new System.EventHandler(this.Log_Clear1_Click);
            // 
            // Log_CopyF
            // 
            this.Log_CopyF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_CopyF.Location = new System.Drawing.Point(327, 445);
            this.Log_CopyF.Name = "Log_CopyF";
            this.Log_CopyF.Size = new System.Drawing.Size(98, 40);
            this.Log_CopyF.TabIndex = 12;
            this.Log_CopyF.Text = "Formatar e Copiar";
            this.Log_CopyF.UseVisualStyleBackColor = true;
            this.Log_CopyF.Click += new System.EventHandler(this.Log_Copy_Click_1);
            // 
            // Log_ClearAll
            // 
            this.Log_ClearAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_ClearAll.Location = new System.Drawing.Point(128, 445);
            this.Log_ClearAll.Name = "Log_ClearAll";
            this.Log_ClearAll.Size = new System.Drawing.Size(90, 40);
            this.Log_ClearAll.TabIndex = 11;
            this.Log_ClearAll.Text = "Limpar";
            this.Log_ClearAll.UseVisualStyleBackColor = true;
            this.Log_ClearAll.Click += new System.EventHandler(this.Log_Clear_Click);
            // 
            // Log_Format
            // 
            this.Log_Format.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Format.Location = new System.Drawing.Point(223, 445);
            this.Log_Format.Name = "Log_Format";
            this.Log_Format.Size = new System.Drawing.Size(100, 40);
            this.Log_Format.TabIndex = 7;
            this.Log_Format.Text = "Formatar";
            this.Log_Format.UseVisualStyleBackColor = true;
            this.Log_Format.Click += new System.EventHandler(this.Log_Copy_Click);
            // 
            // Log_ProximosPassos
            // 
            this.Log_ProximosPassos.AutoSize = true;
            this.Log_ProximosPassos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_ProximosPassos.Location = new System.Drawing.Point(27, 294);
            this.Log_ProximosPassos.Name = "Log_ProximosPassos";
            this.Log_ProximosPassos.Size = new System.Drawing.Size(187, 30);
            this.Log_ProximosPassos.TabIndex = 5;
            this.Log_ProximosPassos.Text = " Próximos Passos:";
            // 
            // Log_StatusAtual
            // 
            this.Log_StatusAtual.AutoSize = true;
            this.Log_StatusAtual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_StatusAtual.Location = new System.Drawing.Point(28, 158);
            this.Log_StatusAtual.Name = "Log_StatusAtual";
            this.Log_StatusAtual.Size = new System.Drawing.Size(169, 30);
            this.Log_StatusAtual.TabIndex = 3;
            this.Log_StatusAtual.Text = " O que foi feito:";
            // 
            // Log_StatusAnterior
            // 
            this.Log_StatusAnterior.AutoSize = true;
            this.Log_StatusAnterior.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_StatusAnterior.Location = new System.Drawing.Point(27, 18);
            this.Log_StatusAnterior.Name = "Log_StatusAnterior";
            this.Log_StatusAnterior.Size = new System.Drawing.Size(174, 30);
            this.Log_StatusAnterior.TabIndex = 1;
            this.Log_StatusAnterior.Text = " Status Anterior:";
            // 
            // tabFechamento
            // 
            this.tabFechamento.Controls.Add(this.LTFechamento_TextBoxObs);
            this.tabFechamento.Controls.Add(this.LTFechamento_ValidacaoTextBox);
            this.tabFechamento.Controls.Add(this.LTFechamento_TextBox);
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox5);
            this.tabFechamento.Controls.Add(this.LTFechamento_ButtonCopy);
            this.tabFechamento.Controls.Add(this.LTFechamento_ButtonFormat);
            this.tabFechamento.Controls.Add(this.LTFechamento_ButtonClear2);
            this.tabFechamento.Controls.Add(this.LTFechamento_ButtonClear1);
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox2);
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox4);
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox1);
            this.tabFechamento.Controls.Add(this.LTFechamento_OBSTitle);
            this.tabFechamento.Controls.Add(this.LTFechamento_ButtonClear);
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox3);
            this.tabFechamento.Controls.Add(this.LTFechamento_BFormatCopy);
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox0);
            this.tabFechamento.Controls.Add(this.LTFechamento_Title);
            this.tabFechamento.Controls.Add(this.LTFechamento_ContatoLabel);
            this.tabFechamento.Controls.Add(this.LTFechamento_Row);
            this.tabFechamento.Location = new System.Drawing.Point(4, 5);
            this.tabFechamento.Name = "tabFechamento";
            this.tabFechamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabFechamento.Size = new System.Drawing.Size(964, 587);
            this.tabFechamento.TabIndex = 1;
            this.tabFechamento.Text = "Fechamento";
            this.tabFechamento.UseVisualStyleBackColor = true;
            // 
            // LTFechamento_TextBoxObs
            // 
            this.LTFechamento_TextBoxObs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LTFechamento_TextBoxObs.Location = new System.Drawing.Point(56, 339);
            this.LTFechamento_TextBoxObs.Name = "LTFechamento_TextBoxObs";
            this.LTFechamento_TextBoxObs.Size = new System.Drawing.Size(336, 109);
            this.LTFechamento_TextBoxObs.TabIndex = 29;
            this.LTFechamento_TextBoxObs.Text = "";
            this.LTFechamento_TextBoxObs.WordWrap = false;
            // 
            // LTFechamento_ValidacaoTextBox
            // 
            this.LTFechamento_ValidacaoTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LTFechamento_ValidacaoTextBox.Location = new System.Drawing.Point(56, 131);
            this.LTFechamento_ValidacaoTextBox.Name = "LTFechamento_ValidacaoTextBox";
            this.LTFechamento_ValidacaoTextBox.Size = new System.Drawing.Size(336, 40);
            this.LTFechamento_ValidacaoTextBox.TabIndex = 28;
            this.LTFechamento_ValidacaoTextBox.Text = "";
            // 
            // LTFechamento_TextBox
            // 
            this.LTFechamento_TextBox.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.LTFechamento_TextBox.Location = new System.Drawing.Point(486, 131);
            this.LTFechamento_TextBox.Name = "LTFechamento_TextBox";
            this.LTFechamento_TextBox.Size = new System.Drawing.Size(417, 196);
            this.LTFechamento_TextBox.TabIndex = 27;
            this.LTFechamento_TextBox.Text = "- Atividade Realizada com Sucesso - \n \nResponsável do cliente pela Validação: \n \n" +
    "";
            this.LTFechamento_TextBox.WordWrap = false;
            // 
            // LTFechamento_CheckBox5
            // 
            this.LTFechamento_CheckBox5.AutoSize = true;
            this.LTFechamento_CheckBox5.Location = new System.Drawing.Point(270, 253);
            this.LTFechamento_CheckBox5.Name = "LTFechamento_CheckBox5";
            this.LTFechamento_CheckBox5.Size = new System.Drawing.Size(143, 23);
            this.LTFechamento_CheckBox5.TabIndex = 26;
            this.LTFechamento_CheckBox5.Text = "Técnico sem JDSU";
            this.LTFechamento_CheckBox5.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox5.CheckedChanged += new System.EventHandler(this.LTFechamento_CheckBox5_CheckedChanged);
            // 
            // LTFechamento_ButtonCopy
            // 
            this.LTFechamento_ButtonCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTFechamento_ButtonCopy.Location = new System.Drawing.Point(780, 348);
            this.LTFechamento_ButtonCopy.Name = "LTFechamento_ButtonCopy";
            this.LTFechamento_ButtonCopy.Size = new System.Drawing.Size(123, 48);
            this.LTFechamento_ButtonCopy.TabIndex = 25;
            this.LTFechamento_ButtonCopy.Text = "Copiar";
            this.LTFechamento_ButtonCopy.UseVisualStyleBackColor = true;
            this.LTFechamento_ButtonCopy.Click += new System.EventHandler(this.LTFechamento_ButtonCopy_Click);
            // 
            // LTFechamento_ButtonFormat
            // 
            this.LTFechamento_ButtonFormat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTFechamento_ButtonFormat.Location = new System.Drawing.Point(633, 348);
            this.LTFechamento_ButtonFormat.Name = "LTFechamento_ButtonFormat";
            this.LTFechamento_ButtonFormat.Size = new System.Drawing.Size(123, 48);
            this.LTFechamento_ButtonFormat.TabIndex = 24;
            this.LTFechamento_ButtonFormat.Text = "Formatar";
            this.LTFechamento_ButtonFormat.UseVisualStyleBackColor = true;
            this.LTFechamento_ButtonFormat.Click += new System.EventHandler(this.LTFechamento_ButtonFormat_Click);
            // 
            // LTFechamento_ButtonClear2
            // 
            this.LTFechamento_ButtonClear2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTFechamento_ButtonClear2.Location = new System.Drawing.Point(331, 314);
            this.LTFechamento_ButtonClear2.Name = "LTFechamento_ButtonClear2";
            this.LTFechamento_ButtonClear2.Size = new System.Drawing.Size(61, 21);
            this.LTFechamento_ButtonClear2.TabIndex = 23;
            this.LTFechamento_ButtonClear2.Text = "Limpar";
            this.LTFechamento_ButtonClear2.UseVisualStyleBackColor = true;
            this.LTFechamento_ButtonClear2.Click += new System.EventHandler(this.LTFechamento_ButtonClear2_Click);
            // 
            // LTFechamento_ButtonClear1
            // 
            this.LTFechamento_ButtonClear1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTFechamento_ButtonClear1.Location = new System.Drawing.Point(329, 107);
            this.LTFechamento_ButtonClear1.Name = "LTFechamento_ButtonClear1";
            this.LTFechamento_ButtonClear1.Size = new System.Drawing.Size(61, 21);
            this.LTFechamento_ButtonClear1.TabIndex = 22;
            this.LTFechamento_ButtonClear1.Text = "Limpar";
            this.LTFechamento_ButtonClear1.UseVisualStyleBackColor = true;
            this.LTFechamento_ButtonClear1.Click += new System.EventHandler(this.LTFechamento_ButtonClear1_Click);
            // 
            // LTFechamento_CheckBox2
            // 
            this.LTFechamento_CheckBox2.AutoSize = true;
            this.LTFechamento_CheckBox2.Location = new System.Drawing.Point(67, 253);
            this.LTFechamento_CheckBox2.Name = "LTFechamento_CheckBox2";
            this.LTFechamento_CheckBox2.Size = new System.Drawing.Size(201, 23);
            this.LTFechamento_CheckBox2.TabIndex = 20;
            this.LTFechamento_CheckBox2.Text = "Cliente não Autorizou Teste";
            this.LTFechamento_CheckBox2.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox2.CheckedChanged += new System.EventHandler(this.LTFechamento_CheckBox4_CheckedChanged);
            // 
            // LTFechamento_CheckBox4
            // 
            this.LTFechamento_CheckBox4.AutoSize = true;
            this.LTFechamento_CheckBox4.Location = new System.Drawing.Point(271, 224);
            this.LTFechamento_CheckBox4.Name = "LTFechamento_CheckBox4";
            this.LTFechamento_CheckBox4.Size = new System.Drawing.Size(103, 23);
            this.LTFechamento_CheckBox4.TabIndex = 18;
            this.LTFechamento_CheckBox4.Text = "Visita Unica";
            this.LTFechamento_CheckBox4.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox4.CheckedChanged += new System.EventHandler(this.LTFechamento_CheckBox3_CheckedChanged);
            // 
            // LTFechamento_CheckBox1
            // 
            this.LTFechamento_CheckBox1.AutoSize = true;
            this.LTFechamento_CheckBox1.Location = new System.Drawing.Point(67, 224);
            this.LTFechamento_CheckBox1.Name = "LTFechamento_CheckBox1";
            this.LTFechamento_CheckBox1.Size = new System.Drawing.Size(182, 23);
            this.LTFechamento_CheckBox1.TabIndex = 17;
            this.LTFechamento_CheckBox1.Text = "Atividade IP VPN ou Voz";
            this.LTFechamento_CheckBox1.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox1.CheckedChanged += new System.EventHandler(this.LTFechamento_CheckBox1_CheckedChanged);
            // 
            // LTFechamento_OBSTitle
            // 
            this.LTFechamento_OBSTitle.AutoSize = true;
            this.LTFechamento_OBSTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTFechamento_OBSTitle.Location = new System.Drawing.Point(156, 306);
            this.LTFechamento_OBSTitle.Name = "LTFechamento_OBSTitle";
            this.LTFechamento_OBSTitle.Size = new System.Drawing.Size(113, 25);
            this.LTFechamento_OBSTitle.TabIndex = 16;
            this.LTFechamento_OBSTitle.Text = "Observação";
            // 
            // LTFechamento_ButtonClear
            // 
            this.LTFechamento_ButtonClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTFechamento_ButtonClear.Location = new System.Drawing.Point(486, 348);
            this.LTFechamento_ButtonClear.Name = "LTFechamento_ButtonClear";
            this.LTFechamento_ButtonClear.Size = new System.Drawing.Size(123, 48);
            this.LTFechamento_ButtonClear.TabIndex = 14;
            this.LTFechamento_ButtonClear.Text = "Limpar";
            this.LTFechamento_ButtonClear.UseVisualStyleBackColor = true;
            this.LTFechamento_ButtonClear.Click += new System.EventHandler(this.LTFechamento_ButtonClear_Click);
            // 
            // LTFechamento_CheckBox3
            // 
            this.LTFechamento_CheckBox3.AutoSize = true;
            this.LTFechamento_CheckBox3.Location = new System.Drawing.Point(271, 194);
            this.LTFechamento_CheckBox3.Name = "LTFechamento_CheckBox3";
            this.LTFechamento_CheckBox3.Size = new System.Drawing.Size(102, 23);
            this.LTFechamento_CheckBox3.TabIndex = 13;
            this.LTFechamento_CheckBox3.Text = "Degradação";
            this.LTFechamento_CheckBox3.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox3.CheckedChanged += new System.EventHandler(this.LTFechamento_CheckBox2_CheckedChanged);
            // 
            // LTFechamento_BFormatCopy
            // 
            this.LTFechamento_BFormatCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTFechamento_BFormatCopy.Location = new System.Drawing.Point(601, 415);
            this.LTFechamento_BFormatCopy.Name = "LTFechamento_BFormatCopy";
            this.LTFechamento_BFormatCopy.Size = new System.Drawing.Size(184, 42);
            this.LTFechamento_BFormatCopy.TabIndex = 12;
            this.LTFechamento_BFormatCopy.Text = "Formatar e Copiar";
            this.LTFechamento_BFormatCopy.UseVisualStyleBackColor = true;
            this.LTFechamento_BFormatCopy.Click += new System.EventHandler(this.LTFechamento_BFormatCopy_Click);
            // 
            // LTFechamento_CheckBox0
            // 
            this.LTFechamento_CheckBox0.AutoSize = true;
            this.LTFechamento_CheckBox0.Location = new System.Drawing.Point(67, 194);
            this.LTFechamento_CheckBox0.Name = "LTFechamento_CheckBox0";
            this.LTFechamento_CheckBox0.Size = new System.Drawing.Size(136, 23);
            this.LTFechamento_CheckBox0.TabIndex = 11;
            this.LTFechamento_CheckBox0.Text = "Teste de Certidão";
            this.LTFechamento_CheckBox0.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox0.CheckedChanged += new System.EventHandler(this.LTFechamento_CheckBox_CheckedChanged);
            // 
            // LTFechamento_Title
            // 
            this.LTFechamento_Title.AutoSize = true;
            this.LTFechamento_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTFechamento_Title.Location = new System.Drawing.Point(331, 43);
            this.LTFechamento_Title.Name = "LTFechamento_Title";
            this.LTFechamento_Title.Size = new System.Drawing.Size(215, 31);
            this.LTFechamento_Title.TabIndex = 9;
            this.LTFechamento_Title.Text = "FECHAMENTO";
            this.LTFechamento_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LTFechamento_ContatoLabel
            // 
            this.LTFechamento_ContatoLabel.AutoSize = true;
            this.LTFechamento_ContatoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTFechamento_ContatoLabel.Location = new System.Drawing.Point(52, 107);
            this.LTFechamento_ContatoLabel.Name = "LTFechamento_ContatoLabel";
            this.LTFechamento_ContatoLabel.Size = new System.Drawing.Size(165, 21);
            this.LTFechamento_ContatoLabel.TabIndex = 8;
            this.LTFechamento_ContatoLabel.Text = "Contato de Validação";
            // 
            // LTFechamento_Row
            // 
            this.LTFechamento_Row.BackColor = System.Drawing.Color.Gray;
            this.LTFechamento_Row.Location = new System.Drawing.Point(444, 125);
            this.LTFechamento_Row.Name = "LTFechamento_Row";
            this.LTFechamento_Row.Size = new System.Drawing.Size(1, 320);
            this.LTFechamento_Row.TabIndex = 19;
            this.LTFechamento_Row.TabStop = false;
            // 
            // tabCalculadoraDeIP
            // 
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_ButtonCopy);
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_SubTitle);
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_buttonCalc);
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_Hint);
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_Title);
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_Result);
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_IPTextBox);
            this.tabCalculadoraDeIP.Location = new System.Drawing.Point(4, 5);
            this.tabCalculadoraDeIP.Name = "tabCalculadoraDeIP";
            this.tabCalculadoraDeIP.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculadoraDeIP.Size = new System.Drawing.Size(964, 587);
            this.tabCalculadoraDeIP.TabIndex = 3;
            this.tabCalculadoraDeIP.Text = "Calculadora de IP";
            this.tabCalculadoraDeIP.UseVisualStyleBackColor = true;
            // 
            // LTCalc_ButtonCopy
            // 
            this.LTCalc_ButtonCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTCalc_ButtonCopy.Location = new System.Drawing.Point(481, 257);
            this.LTCalc_ButtonCopy.Name = "LTCalc_ButtonCopy";
            this.LTCalc_ButtonCopy.Size = new System.Drawing.Size(84, 54);
            this.LTCalc_ButtonCopy.TabIndex = 7;
            this.LTCalc_ButtonCopy.Text = "Copiar";
            this.LTCalc_ButtonCopy.UseVisualStyleBackColor = true;
            this.LTCalc_ButtonCopy.Click += new System.EventHandler(this.LTCalc_ButtonCopy_Click);
            // 
            // LTCalc_SubTitle
            // 
            this.LTCalc_SubTitle.AutoSize = true;
            this.LTCalc_SubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTCalc_SubTitle.Location = new System.Drawing.Point(149, 114);
            this.LTCalc_SubTitle.Name = "LTCalc_SubTitle";
            this.LTCalc_SubTitle.Size = new System.Drawing.Size(26, 20);
            this.LTCalc_SubTitle.TabIndex = 5;
            this.LTCalc_SubTitle.Text = "IP";
            // 
            // LTCalc_buttonCalc
            // 
            this.LTCalc_buttonCalc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTCalc_buttonCalc.Location = new System.Drawing.Point(474, 137);
            this.LTCalc_buttonCalc.Name = "LTCalc_buttonCalc";
            this.LTCalc_buttonCalc.Size = new System.Drawing.Size(98, 33);
            this.LTCalc_buttonCalc.TabIndex = 4;
            this.LTCalc_buttonCalc.Text = "Calcular";
            this.LTCalc_buttonCalc.UseVisualStyleBackColor = true;
            this.LTCalc_buttonCalc.Click += new System.EventHandler(this.LTCalc_buttonCalc_Click);
            // 
            // LTCalc_Hint
            // 
            this.LTCalc_Hint.AutoSize = true;
            this.LTCalc_Hint.Location = new System.Drawing.Point(330, 118);
            this.LTCalc_Hint.Name = "LTCalc_Hint";
            this.LTCalc_Hint.Size = new System.Drawing.Size(117, 19);
            this.LTCalc_Hint.TabIndex = 3;
            this.LTCalc_Hint.Text = "Ex: 192.168.1.1/30";
            // 
            // LTCalc_Title
            // 
            this.LTCalc_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTCalc_Title.AutoSize = true;
            this.LTCalc_Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTCalc_Title.Location = new System.Drawing.Point(334, 33);
            this.LTCalc_Title.Name = "LTCalc_Title";
            this.LTCalc_Title.Size = new System.Drawing.Size(275, 30);
            this.LTCalc_Title.TabIndex = 2;
            this.LTCalc_Title.Text = "Calculadora de Bloco de IP";
            // 
            // LTCalc_Result
            // 
            this.LTCalc_Result.AutoSize = true;
            this.LTCalc_Result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTCalc_Result.Location = new System.Drawing.Point(148, 235);
            this.LTCalc_Result.Name = "LTCalc_Result";
            this.LTCalc_Result.Size = new System.Drawing.Size(78, 21);
            this.LTCalc_Result.TabIndex = 1;
            this.LTCalc_Result.Text = "Resultado";
            // 
            // LTCalc_IPTextBox
            // 
            this.LTCalc_IPTextBox.Location = new System.Drawing.Point(143, 137);
            this.LTCalc_IPTextBox.Name = "LTCalc_IPTextBox";
            this.LTCalc_IPTextBox.Size = new System.Drawing.Size(299, 33);
            this.LTCalc_IPTextBox.TabIndex = 6;
            this.LTCalc_IPTextBox.Text = "";
            // 
            // tabSuporte
            // 
            this.tabSuporte.Controls.Add(this.LTSup_buttonCopy);
            this.tabSuporte.Controls.Add(this.LTSup_buttonForm);
            this.tabSuporte.Controls.Add(this.ButtonLT_ClearCommand);
            this.tabSuporte.Controls.Add(this.ButtonLT_ResetCommand);
            this.tabSuporte.Controls.Add(this.LTSup_buttonClear);
            this.tabSuporte.Controls.Add(this.ButtonLT_AdcCommand);
            this.tabSuporte.Controls.Add(this.LTSuporte_DescripTitle);
            this.tabSuporte.Controls.Add(this.LTSuporte_ComandoTitle);
            this.tabSuporte.Controls.Add(this.LogToolsSuporteTitle);
            this.tabSuporte.Controls.Add(this.LTSup_buttonCopyF);
            this.tabSuporte.Controls.Add(this.LT_SuporteTitleTextBox);
            this.tabSuporte.Controls.Add(this.LT_SuporteComTextBox);
            this.tabSuporte.Controls.Add(this.LTSuporteFinalTextBox);
            this.tabSuporte.Controls.Add(this.LT_Suporte_Row);
            this.tabSuporte.Location = new System.Drawing.Point(4, 5);
            this.tabSuporte.Name = "tabSuporte";
            this.tabSuporte.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuporte.Size = new System.Drawing.Size(964, 587);
            this.tabSuporte.TabIndex = 2;
            this.tabSuporte.Text = "Suporte";
            this.tabSuporte.UseVisualStyleBackColor = true;
            // 
            // LTSup_buttonCopy
            // 
            this.LTSup_buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LTSup_buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTSup_buttonCopy.Location = new System.Drawing.Point(820, 76);
            this.LTSup_buttonCopy.Name = "LTSup_buttonCopy";
            this.LTSup_buttonCopy.Size = new System.Drawing.Size(110, 35);
            this.LTSup_buttonCopy.TabIndex = 14;
            this.LTSup_buttonCopy.Text = "Copiar";
            this.LTSup_buttonCopy.UseVisualStyleBackColor = true;
            this.LTSup_buttonCopy.Click += new System.EventHandler(this.LTSup_buttonCopy_Click);
            // 
            // LTSup_buttonForm
            // 
            this.LTSup_buttonForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTSup_buttonForm.Location = new System.Drawing.Point(187, 411);
            this.LTSup_buttonForm.Name = "LTSup_buttonForm";
            this.LTSup_buttonForm.Size = new System.Drawing.Size(127, 53);
            this.LTSup_buttonForm.TabIndex = 13;
            this.LTSup_buttonForm.Text = "Formatar";
            this.LTSup_buttonForm.UseVisualStyleBackColor = true;
            this.LTSup_buttonForm.Click += new System.EventHandler(this.LTSup_buttonForm_Click);
            // 
            // ButtonLT_ClearCommand
            // 
            this.ButtonLT_ClearCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLT_ClearCommand.Location = new System.Drawing.Point(316, 322);
            this.ButtonLT_ClearCommand.Name = "ButtonLT_ClearCommand";
            this.ButtonLT_ClearCommand.Size = new System.Drawing.Size(60, 25);
            this.ButtonLT_ClearCommand.TabIndex = 11;
            this.ButtonLT_ClearCommand.Text = "Limpar";
            this.ButtonLT_ClearCommand.UseVisualStyleBackColor = true;
            this.ButtonLT_ClearCommand.Click += new System.EventHandler(this.ButtonLT_ClearCommand_Click);
            // 
            // ButtonLT_ResetCommand
            // 
            this.ButtonLT_ResetCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLT_ResetCommand.Location = new System.Drawing.Point(250, 322);
            this.ButtonLT_ResetCommand.Name = "ButtonLT_ResetCommand";
            this.ButtonLT_ResetCommand.Size = new System.Drawing.Size(60, 25);
            this.ButtonLT_ResetCommand.TabIndex = 10;
            this.ButtonLT_ResetCommand.Text = "Reset";
            this.ButtonLT_ResetCommand.UseVisualStyleBackColor = true;
            this.ButtonLT_ResetCommand.Click += new System.EventHandler(this.ButtonLT_ResetCommand_Click);
            // 
            // LTSup_buttonClear
            // 
            this.LTSup_buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTSup_buttonClear.Location = new System.Drawing.Point(48, 411);
            this.LTSup_buttonClear.Name = "LTSup_buttonClear";
            this.LTSup_buttonClear.Size = new System.Drawing.Size(135, 53);
            this.LTSup_buttonClear.TabIndex = 9;
            this.LTSup_buttonClear.Text = "Limpar";
            this.LTSup_buttonClear.UseVisualStyleBackColor = true;
            this.LTSup_buttonClear.Click += new System.EventHandler(this.Button_LTSup_Limpar_Click);
            // 
            // ButtonLT_AdcCommand
            // 
            this.ButtonLT_AdcCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLT_AdcCommand.Location = new System.Drawing.Point(382, 322);
            this.ButtonLT_AdcCommand.Name = "ButtonLT_AdcCommand";
            this.ButtonLT_AdcCommand.Size = new System.Drawing.Size(60, 25);
            this.ButtonLT_AdcCommand.TabIndex = 7;
            this.ButtonLT_AdcCommand.Text = "Adicionar";
            this.ButtonLT_AdcCommand.UseVisualStyleBackColor = true;
            this.ButtonLT_AdcCommand.Click += new System.EventHandler(this.ButtonLT_AdcCommand_Click);
            // 
            // LTSuporte_DescripTitle
            // 
            this.LTSuporte_DescripTitle.AutoSize = true;
            this.LTSuporte_DescripTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTSuporte_DescripTitle.Location = new System.Drawing.Point(37, 93);
            this.LTSuporte_DescripTitle.Name = "LTSuporte_DescripTitle";
            this.LTSuporte_DescripTitle.Size = new System.Drawing.Size(76, 18);
            this.LTSuporte_DescripTitle.TabIndex = 6;
            this.LTSuporte_DescripTitle.Text = "Descrição";
            // 
            // LTSuporte_ComandoTitle
            // 
            this.LTSuporte_ComandoTitle.AutoSize = true;
            this.LTSuporte_ComandoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTSuporte_ComandoTitle.Location = new System.Drawing.Point(37, 189);
            this.LTSuporte_ComandoTitle.Name = "LTSuporte_ComandoTitle";
            this.LTSuporte_ComandoTitle.Size = new System.Drawing.Size(82, 18);
            this.LTSuporte_ComandoTitle.TabIndex = 5;
            this.LTSuporte_ComandoTitle.Text = "Comandos";
            // 
            // LogToolsSuporteTitle
            // 
            this.LogToolsSuporteTitle.AutoSize = true;
            this.LogToolsSuporteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogToolsSuporteTitle.Location = new System.Drawing.Point(386, 42);
            this.LogToolsSuporteTitle.Name = "LogToolsSuporteTitle";
            this.LogToolsSuporteTitle.Size = new System.Drawing.Size(153, 31);
            this.LogToolsSuporteTitle.TabIndex = 3;
            this.LogToolsSuporteTitle.Text = "SUPORTE";
            this.LogToolsSuporteTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LTSup_buttonCopyF
            // 
            this.LTSup_buttonCopyF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTSup_buttonCopyF.Location = new System.Drawing.Point(317, 411);
            this.LTSup_buttonCopyF.Name = "LTSup_buttonCopyF";
            this.LTSup_buttonCopyF.Size = new System.Drawing.Size(127, 53);
            this.LTSup_buttonCopyF.TabIndex = 0;
            this.LTSup_buttonCopyF.Text = "Formatar e Copiar";
            this.LTSup_buttonCopyF.UseVisualStyleBackColor = true;
            this.LTSup_buttonCopyF.Click += new System.EventHandler(this.ButtonLogTools_Suporte_Click);
            // 
            // LT_SuporteTitleTextBox
            // 
            this.LT_SuporteTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LT_SuporteTitleTextBox.Location = new System.Drawing.Point(48, 113);
            this.LT_SuporteTitleTextBox.Name = "LT_SuporteTitleTextBox";
            this.LT_SuporteTitleTextBox.Size = new System.Drawing.Size(396, 48);
            this.LT_SuporteTitleTextBox.TabIndex = 15;
            this.LT_SuporteTitleTextBox.Text = "";
            this.LT_SuporteTitleTextBox.WordWrap = false;
            // 
            // LT_SuporteComTextBox
            // 
            this.LT_SuporteComTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LT_SuporteComTextBox.Location = new System.Drawing.Point(48, 210);
            this.LT_SuporteComTextBox.Name = "LT_SuporteComTextBox";
            this.LT_SuporteComTextBox.Size = new System.Drawing.Size(396, 106);
            this.LT_SuporteComTextBox.TabIndex = 16;
            this.LT_SuporteComTextBox.Text = "";
            this.LT_SuporteComTextBox.WordWrap = false;
            // 
            // LTSuporteFinalTextBox
            // 
            this.LTSuporteFinalTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTSuporteFinalTextBox.Location = new System.Drawing.Point(523, 113);
            this.LTSuporteFinalTextBox.Name = "LTSuporteFinalTextBox";
            this.LTSuporteFinalTextBox.Size = new System.Drawing.Size(407, 437);
            this.LTSuporteFinalTextBox.TabIndex = 17;
            this.LTSuporteFinalTextBox.Text = "";
            this.LTSuporteFinalTextBox.WordWrap = false;
            // 
            // LT_Suporte_Row
            // 
            this.LT_Suporte_Row.BackColor = System.Drawing.Color.Gray;
            this.LT_Suporte_Row.Location = new System.Drawing.Point(480, 113);
            this.LT_Suporte_Row.Name = "LT_Suporte_Row";
            this.LT_Suporte_Row.Size = new System.Drawing.Size(1, 430);
            this.LT_Suporte_Row.TabIndex = 8;
            this.LT_Suporte_Row.TabStop = false;
            // 
            // tabScriptDB
            // 
            this.tabScriptDB.Controls.Add(this.Script_DB_Label);
            this.tabScriptDB.Controls.Add(this.Script_DB_ClearButton1);
            this.tabScriptDB.Controls.Add(this.Script_DB_ClearButton2);
            this.tabScriptDB.Controls.Add(this.Script_DB_Hint2);
            this.tabScriptDB.Controls.Add(this.Script_DB_VarTextBox);
            this.tabScriptDB.Controls.Add(this.Script_DB_LabelTest);
            this.tabScriptDB.Controls.Add(this.Script_DB_VarEnterButton);
            this.tabScriptDB.Controls.Add(this.Script_DB_InButton);
            this.tabScriptDB.Controls.Add(this.Script_DB_OutButton);
            this.tabScriptDB.Controls.Add(this.Script_DB_SubLabel2);
            this.tabScriptDB.Controls.Add(this.Script_DB_Hint1);
            this.tabScriptDB.Controls.Add(this.Script_DB_SubLabel1);
            this.tabScriptDB.Controls.Add(this.Script_DB_TextBox1);
            this.tabScriptDB.Controls.Add(this.Script_DB_TextBox2);
            this.tabScriptDB.Location = new System.Drawing.Point(4, 5);
            this.tabScriptDB.Name = "tabScriptDB";
            this.tabScriptDB.Padding = new System.Windows.Forms.Padding(3);
            this.tabScriptDB.Size = new System.Drawing.Size(964, 587);
            this.tabScriptDB.TabIndex = 4;
            this.tabScriptDB.Text = "tabPage3";
            this.tabScriptDB.UseVisualStyleBackColor = true;
            // 
            // Script_DB_Label
            // 
            this.Script_DB_Label.AutoSize = true;
            this.Script_DB_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DB_Label.Location = new System.Drawing.Point(412, 35);
            this.Script_DB_Label.Name = "Script_DB_Label";
            this.Script_DB_Label.Size = new System.Drawing.Size(126, 31);
            this.Script_DB_Label.TabIndex = 32;
            this.Script_DB_Label.Text = "TESTES";
            // 
            // Script_DB_ClearButton1
            // 
            this.Script_DB_ClearButton1.Location = new System.Drawing.Point(307, 93);
            this.Script_DB_ClearButton1.Name = "Script_DB_ClearButton1";
            this.Script_DB_ClearButton1.Size = new System.Drawing.Size(75, 28);
            this.Script_DB_ClearButton1.TabIndex = 31;
            this.Script_DB_ClearButton1.Text = "Limpar";
            this.Script_DB_ClearButton1.UseVisualStyleBackColor = true;
            this.Script_DB_ClearButton1.Click += new System.EventHandler(this.Teste_ClearDB_Click);
            // 
            // Script_DB_ClearButton2
            // 
            this.Script_DB_ClearButton2.Location = new System.Drawing.Point(818, 93);
            this.Script_DB_ClearButton2.Name = "Script_DB_ClearButton2";
            this.Script_DB_ClearButton2.Size = new System.Drawing.Size(75, 28);
            this.Script_DB_ClearButton2.TabIndex = 30;
            this.Script_DB_ClearButton2.Text = "Limpar";
            this.Script_DB_ClearButton2.UseVisualStyleBackColor = true;
            this.Script_DB_ClearButton2.Click += new System.EventHandler(this.Teste_ClearF_Click);
            // 
            // Script_DB_Hint2
            // 
            this.Script_DB_Hint2.AutoSize = true;
            this.Script_DB_Hint2.Location = new System.Drawing.Point(325, 476);
            this.Script_DB_Hint2.Name = "Script_DB_Hint2";
            this.Script_DB_Hint2.Size = new System.Drawing.Size(177, 19);
            this.Script_DB_Hint2.TabIndex = 29;
            this.Script_DB_Hint2.Text = "utilize \"var\" para substituir";
            // 
            // Script_DB_VarTextBox
            // 
            this.Script_DB_VarTextBox.Location = new System.Drawing.Point(412, 447);
            this.Script_DB_VarTextBox.Name = "Script_DB_VarTextBox";
            this.Script_DB_VarTextBox.Size = new System.Drawing.Size(100, 26);
            this.Script_DB_VarTextBox.TabIndex = 28;
            // 
            // Script_DB_LabelTest
            // 
            this.Script_DB_LabelTest.AutoSize = true;
            this.Script_DB_LabelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DB_LabelTest.Location = new System.Drawing.Point(326, 449);
            this.Script_DB_LabelTest.Name = "Script_DB_LabelTest";
            this.Script_DB_LabelTest.Size = new System.Drawing.Size(75, 16);
            this.Script_DB_LabelTest.TabIndex = 27;
            this.Script_DB_LabelTest.Text = "Var Teste";
            // 
            // Script_DB_VarEnterButton
            // 
            this.Script_DB_VarEnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DB_VarEnterButton.Location = new System.Drawing.Point(518, 447);
            this.Script_DB_VarEnterButton.Name = "Script_DB_VarEnterButton";
            this.Script_DB_VarEnterButton.Size = new System.Drawing.Size(110, 45);
            this.Script_DB_VarEnterButton.TabIndex = 26;
            this.Script_DB_VarEnterButton.Text = "Enter";
            this.Script_DB_VarEnterButton.UseVisualStyleBackColor = true;
            this.Script_DB_VarEnterButton.Click += new System.EventHandler(this.Teste_Enter_Click);
            // 
            // Script_DB_InButton
            // 
            this.Script_DB_InButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DB_InButton.Location = new System.Drawing.Point(431, 200);
            this.Script_DB_InButton.Name = "Script_DB_InButton";
            this.Script_DB_InButton.Size = new System.Drawing.Size(110, 45);
            this.Script_DB_InButton.TabIndex = 25;
            this.Script_DB_InButton.Text = "<--";
            this.Script_DB_InButton.UseVisualStyleBackColor = true;
            this.Script_DB_InButton.Click += new System.EventHandler(this.Teste_In_Click);
            // 
            // Script_DB_OutButton
            // 
            this.Script_DB_OutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DB_OutButton.Location = new System.Drawing.Point(431, 279);
            this.Script_DB_OutButton.Name = "Script_DB_OutButton";
            this.Script_DB_OutButton.Size = new System.Drawing.Size(110, 45);
            this.Script_DB_OutButton.TabIndex = 24;
            this.Script_DB_OutButton.Text = "-->";
            this.Script_DB_OutButton.UseVisualStyleBackColor = true;
            this.Script_DB_OutButton.Click += new System.EventHandler(this.Teste_out_Click);
            // 
            // Script_DB_SubLabel2
            // 
            this.Script_DB_SubLabel2.AutoSize = true;
            this.Script_DB_SubLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DB_SubLabel2.Location = new System.Drawing.Point(580, 90);
            this.Script_DB_SubLabel2.Name = "Script_DB_SubLabel2";
            this.Script_DB_SubLabel2.Size = new System.Drawing.Size(115, 24);
            this.Script_DB_SubLabel2.TabIndex = 23;
            this.Script_DB_SubLabel2.Text = "Script Final";
            // 
            // Script_DB_Hint1
            // 
            this.Script_DB_Hint1.AutoSize = true;
            this.Script_DB_Hint1.Location = new System.Drawing.Point(68, 415);
            this.Script_DB_Hint1.Name = "Script_DB_Hint1";
            this.Script_DB_Hint1.Size = new System.Drawing.Size(339, 19);
            this.Script_DB_Hint1.TabIndex = 22;
            this.Script_DB_Hint1.Text = "O banco de dados recebe apenas uma String Unica**";
            // 
            // Script_DB_SubLabel1
            // 
            this.Script_DB_SubLabel1.AutoSize = true;
            this.Script_DB_SubLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DB_SubLabel1.Location = new System.Drawing.Point(69, 90);
            this.Script_DB_SubLabel1.Name = "Script_DB_SubLabel1";
            this.Script_DB_SubLabel1.Size = new System.Drawing.Size(164, 24);
            this.Script_DB_SubLabel1.TabIndex = 21;
            this.Script_DB_SubLabel1.Text = "Banco de Dados";
            // 
            // Script_DB_TextBox1
            // 
            this.Script_DB_TextBox1.Location = new System.Drawing.Point(73, 122);
            this.Script_DB_TextBox1.Multiline = true;
            this.Script_DB_TextBox1.Name = "Script_DB_TextBox1";
            this.Script_DB_TextBox1.Size = new System.Drawing.Size(309, 290);
            this.Script_DB_TextBox1.TabIndex = 20;
            this.Script_DB_TextBox1.WordWrap = false;
            // 
            // Script_DB_TextBox2
            // 
            this.Script_DB_TextBox2.Location = new System.Drawing.Point(584, 122);
            this.Script_DB_TextBox2.Multiline = true;
            this.Script_DB_TextBox2.Name = "Script_DB_TextBox2";
            this.Script_DB_TextBox2.Size = new System.Drawing.Size(309, 290);
            this.Script_DB_TextBox2.TabIndex = 19;
            this.Script_DB_TextBox2.WordWrap = false;
            // 
            // tabRouters
            // 
            this.tabRouters.Controls.Add(tabControl3);
            this.tabRouters.Location = new System.Drawing.Point(4, 36);
            this.tabRouters.Name = "tabRouters";
            this.tabRouters.Padding = new System.Windows.Forms.Padding(3);
            this.tabRouters.Size = new System.Drawing.Size(1126, 599);
            this.tabRouters.TabIndex = 1;
            this.tabRouters.Text = "Routers";
            this.tabRouters.UseVisualStyleBackColor = true;
            // 
            // tabPreferencias
            // 
            this.tabPreferencias.BackColor = System.Drawing.SystemColors.Control;
            this.tabPreferencias.Controls.Add(this.Prefs_Row0);
            this.tabPreferencias.Controls.Add(this.Prefs_Row1);
            this.tabPreferencias.Controls.Add(this.Prefs_Row2);
            this.tabPreferencias.Controls.Add(this.List_All_Scritps);
            this.tabPreferencias.Controls.Add(this.Button_NightMode);
            this.tabPreferencias.Controls.Add(this.Button_EditScript);
            this.tabPreferencias.Controls.Add(this.Pref_Putty_SearchButton);
            this.tabPreferencias.Controls.Add(this.Pref_Putty_SaveButton);
            this.tabPreferencias.Controls.Add(this.Pref_Putty_PathTextBox);
            this.tabPreferencias.Controls.Add(this.ResetValue_Button);
            this.tabPreferencias.Controls.Add(this.Pref_Putty_TitleLabel);
            this.tabPreferencias.Controls.Add(this.Pref_TACACS_TitleLabel);
            this.tabPreferencias.Controls.Add(this.Pref_TACACS_SubLabel2);
            this.tabPreferencias.Controls.Add(this.Pref_TACACS_SubLabel1);
            this.tabPreferencias.Controls.Add(this.Pref_TACACS_PasswordTextBox);
            this.tabPreferencias.Controls.Add(this.Pref_TACACS_UserTextBox);
            this.tabPreferencias.Controls.Add(this.Pref_User_TitleLabel);
            this.tabPreferencias.Controls.Add(this.Pref_User_SubLabel2);
            this.tabPreferencias.Controls.Add(this.Pref_User_SubLabel1);
            this.tabPreferencias.Controls.Add(this.Pref_User_PasswordTextBox);
            this.tabPreferencias.Controls.Add(this.Pref_User_NameTextBox);
            this.tabPreferencias.Controls.Add(this.Button_PassWordForm);
            this.tabPreferencias.Location = new System.Drawing.Point(4, 36);
            this.tabPreferencias.Name = "tabPreferencias";
            this.tabPreferencias.Size = new System.Drawing.Size(1126, 599);
            this.tabPreferencias.TabIndex = 3;
            this.tabPreferencias.Text = "Preferências";
            // 
            // Prefs_Row0
            // 
            this.Prefs_Row0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Prefs_Row0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prefs_Row0.Location = new System.Drawing.Point(498, 0);
            this.Prefs_Row0.Name = "Prefs_Row0";
            this.Prefs_Row0.Size = new System.Drawing.Size(1, 650);
            this.Prefs_Row0.TabIndex = 135;
            this.Prefs_Row0.TabStop = false;
            // 
            // Prefs_Row1
            // 
            this.Prefs_Row1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prefs_Row1.Location = new System.Drawing.Point(30, 167);
            this.Prefs_Row1.Name = "Prefs_Row1";
            this.Prefs_Row1.Size = new System.Drawing.Size(420, 1);
            this.Prefs_Row1.TabIndex = 134;
            this.Prefs_Row1.TabStop = false;
            // 
            // Prefs_Row2
            // 
            this.Prefs_Row2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prefs_Row2.Location = new System.Drawing.Point(30, 320);
            this.Prefs_Row2.Name = "Prefs_Row2";
            this.Prefs_Row2.Size = new System.Drawing.Size(420, 1);
            this.Prefs_Row2.TabIndex = 133;
            this.Prefs_Row2.TabStop = false;
            // 
            // List_All_Scritps
            // 
            this.List_All_Scritps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.List_All_Scritps.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.List_All_Scritps.Location = new System.Drawing.Point(987, 454);
            this.List_All_Scritps.Name = "List_All_Scritps";
            this.List_All_Scritps.Size = new System.Drawing.Size(90, 47);
            this.List_All_Scritps.TabIndex = 132;
            this.List_All_Scritps.Text = "Show All Scripts";
            this.List_All_Scritps.UseVisualStyleBackColor = true;
            this.List_All_Scritps.Click += new System.EventHandler(this.TotalScripts_Test);
            // 
            // Button_NightMode
            // 
            this.Button_NightMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_NightMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_NightMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_NightMode.Location = new System.Drawing.Point(969, 97);
            this.Button_NightMode.MaximumSize = new System.Drawing.Size(240, 90);
            this.Button_NightMode.MinimumSize = new System.Drawing.Size(120, 45);
            this.Button_NightMode.Name = "Button_NightMode";
            this.Button_NightMode.Size = new System.Drawing.Size(134, 45);
            this.Button_NightMode.TabIndex = 65;
            this.Button_NightMode.Text = "Night Mode";
            this.Button_NightMode.UseVisualStyleBackColor = true;
            this.Button_NightMode.Click += new System.EventHandler(this.Button_DarkMode_Click);
            // 
            // Button_EditScript
            // 
            this.Button_EditScript.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_EditScript.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_EditScript.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_EditScript.Location = new System.Drawing.Point(567, 34);
            this.Button_EditScript.Name = "Button_EditScript";
            this.Button_EditScript.Size = new System.Drawing.Size(162, 63);
            this.Button_EditScript.TabIndex = 64;
            this.Button_EditScript.Text = "Edição";
            this.Button_EditScript.UseVisualStyleBackColor = true;
            this.Button_EditScript.Click += new System.EventHandler(this.Button_EditScript_Click);
            // 
            // Pref_Putty_SearchButton
            // 
            this.Pref_Putty_SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Pref_Putty_SearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Pref_Putty_SearchButton.Location = new System.Drawing.Point(132, 439);
            this.Pref_Putty_SearchButton.Name = "Pref_Putty_SearchButton";
            this.Pref_Putty_SearchButton.Size = new System.Drawing.Size(106, 39);
            this.Pref_Putty_SearchButton.TabIndex = 63;
            this.Pref_Putty_SearchButton.Text = "Procurar";
            this.Pref_Putty_SearchButton.UseVisualStyleBackColor = true;
            this.Pref_Putty_SearchButton.Click += new System.EventHandler(this.Pref_Putty_SearchButton_Click);
            // 
            // Pref_Putty_SaveButton
            // 
            this.Pref_Putty_SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Pref_Putty_SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Pref_Putty_SaveButton.Location = new System.Drawing.Point(265, 439);
            this.Pref_Putty_SaveButton.Name = "Pref_Putty_SaveButton";
            this.Pref_Putty_SaveButton.Size = new System.Drawing.Size(106, 39);
            this.Pref_Putty_SaveButton.TabIndex = 62;
            this.Pref_Putty_SaveButton.Text = "Save";
            this.Pref_Putty_SaveButton.UseVisualStyleBackColor = true;
            this.Pref_Putty_SaveButton.Click += new System.EventHandler(this.Pref_Putty_SaveButton_Click);
            // 
            // Pref_Putty_PathTextBox
            // 
            this.Pref_Putty_PathTextBox.Location = new System.Drawing.Point(60, 393);
            this.Pref_Putty_PathTextBox.Name = "Pref_Putty_PathTextBox";
            this.Pref_Putty_PathTextBox.Size = new System.Drawing.Size(378, 26);
            this.Pref_Putty_PathTextBox.TabIndex = 61;
            // 
            // ResetValue_Button
            // 
            this.ResetValue_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetValue_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetValue_Button.Location = new System.Drawing.Point(963, 514);
            this.ResetValue_Button.Name = "ResetValue_Button";
            this.ResetValue_Button.Size = new System.Drawing.Size(140, 64);
            this.ResetValue_Button.TabIndex = 60;
            this.ResetValue_Button.Text = "Reset";
            this.ResetValue_Button.UseVisualStyleBackColor = true;
            this.ResetValue_Button.Click += new System.EventHandler(this.ResetValues_Click);
            // 
            // Pref_Putty_TitleLabel
            // 
            this.Pref_Putty_TitleLabel.AutoSize = true;
            this.Pref_Putty_TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pref_Putty_TitleLabel.Location = new System.Drawing.Point(57, 361);
            this.Pref_Putty_TitleLabel.Name = "Pref_Putty_TitleLabel";
            this.Pref_Putty_TitleLabel.Size = new System.Drawing.Size(99, 17);
            this.Pref_Putty_TitleLabel.TabIndex = 58;
            this.Pref_Putty_TitleLabel.Text = "Caminho Putty";
            // 
            // Pref_TACACS_TitleLabel
            // 
            this.Pref_TACACS_TitleLabel.AutoSize = true;
            this.Pref_TACACS_TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pref_TACACS_TitleLabel.Location = new System.Drawing.Point(58, 200);
            this.Pref_TACACS_TitleLabel.Name = "Pref_TACACS_TitleLabel";
            this.Pref_TACACS_TitleLabel.Size = new System.Drawing.Size(58, 17);
            this.Pref_TACACS_TitleLabel.TabIndex = 55;
            this.Pref_TACACS_TitleLabel.Text = "TACAC\'S";
            // 
            // Pref_TACACS_SubLabel2
            // 
            this.Pref_TACACS_SubLabel2.AutoSize = true;
            this.Pref_TACACS_SubLabel2.Location = new System.Drawing.Point(55, 262);
            this.Pref_TACACS_SubLabel2.Name = "Pref_TACACS_SubLabel2";
            this.Pref_TACACS_SubLabel2.Size = new System.Drawing.Size(50, 19);
            this.Pref_TACACS_SubLabel2.TabIndex = 54;
            this.Pref_TACACS_SubLabel2.Text = "Senha:";
            // 
            // Pref_TACACS_SubLabel1
            // 
            this.Pref_TACACS_SubLabel1.AutoSize = true;
            this.Pref_TACACS_SubLabel1.Location = new System.Drawing.Point(55, 231);
            this.Pref_TACACS_SubLabel1.Name = "Pref_TACACS_SubLabel1";
            this.Pref_TACACS_SubLabel1.Size = new System.Drawing.Size(60, 19);
            this.Pref_TACACS_SubLabel1.TabIndex = 53;
            this.Pref_TACACS_SubLabel1.Text = "Usuario:";
            // 
            // Pref_TACACS_PasswordTextBox
            // 
            this.Pref_TACACS_PasswordTextBox.Location = new System.Drawing.Point(125, 259);
            this.Pref_TACACS_PasswordTextBox.Name = "Pref_TACACS_PasswordTextBox";
            this.Pref_TACACS_PasswordTextBox.PasswordChar = '●';
            this.Pref_TACACS_PasswordTextBox.Size = new System.Drawing.Size(130, 26);
            this.Pref_TACACS_PasswordTextBox.TabIndex = 52;
            // 
            // Pref_TACACS_UserTextBox
            // 
            this.Pref_TACACS_UserTextBox.Location = new System.Drawing.Point(125, 228);
            this.Pref_TACACS_UserTextBox.Name = "Pref_TACACS_UserTextBox";
            this.Pref_TACACS_UserTextBox.Size = new System.Drawing.Size(130, 26);
            this.Pref_TACACS_UserTextBox.TabIndex = 51;
            // 
            // Pref_User_TitleLabel
            // 
            this.Pref_User_TitleLabel.AutoSize = true;
            this.Pref_User_TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pref_User_TitleLabel.Location = new System.Drawing.Point(58, 49);
            this.Pref_User_TitleLabel.Name = "Pref_User_TitleLabel";
            this.Pref_User_TitleLabel.Size = new System.Drawing.Size(54, 17);
            this.Pref_User_TitleLabel.TabIndex = 50;
            this.Pref_User_TitleLabel.Text = "User PE";
            // 
            // Pref_User_SubLabel2
            // 
            this.Pref_User_SubLabel2.AutoSize = true;
            this.Pref_User_SubLabel2.Location = new System.Drawing.Point(55, 111);
            this.Pref_User_SubLabel2.Name = "Pref_User_SubLabel2";
            this.Pref_User_SubLabel2.Size = new System.Drawing.Size(50, 19);
            this.Pref_User_SubLabel2.TabIndex = 49;
            this.Pref_User_SubLabel2.Text = "Senha:";
            // 
            // Pref_User_SubLabel1
            // 
            this.Pref_User_SubLabel1.AutoSize = true;
            this.Pref_User_SubLabel1.Location = new System.Drawing.Point(55, 80);
            this.Pref_User_SubLabel1.Name = "Pref_User_SubLabel1";
            this.Pref_User_SubLabel1.Size = new System.Drawing.Size(60, 19);
            this.Pref_User_SubLabel1.TabIndex = 48;
            this.Pref_User_SubLabel1.Text = "Usuario:";
            // 
            // Pref_User_PasswordTextBox
            // 
            this.Pref_User_PasswordTextBox.Location = new System.Drawing.Point(125, 108);
            this.Pref_User_PasswordTextBox.Name = "Pref_User_PasswordTextBox";
            this.Pref_User_PasswordTextBox.PasswordChar = '●';
            this.Pref_User_PasswordTextBox.Size = new System.Drawing.Size(130, 26);
            this.Pref_User_PasswordTextBox.TabIndex = 47;
            // 
            // Pref_User_NameTextBox
            // 
            this.Pref_User_NameTextBox.Location = new System.Drawing.Point(125, 77);
            this.Pref_User_NameTextBox.Name = "Pref_User_NameTextBox";
            this.Pref_User_NameTextBox.Size = new System.Drawing.Size(130, 26);
            this.Pref_User_NameTextBox.TabIndex = 46;
            // 
            // Button_PassWordForm
            // 
            this.Button_PassWordForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_PassWordForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_PassWordForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Button_PassWordForm.Location = new System.Drawing.Point(970, 28);
            this.Button_PassWordForm.Name = "Button_PassWordForm";
            this.Button_PassWordForm.Size = new System.Drawing.Size(133, 58);
            this.Button_PassWordForm.TabIndex = 45;
            this.Button_PassWordForm.Text = "Senha de Desbloqueio";
            this.Button_PassWordForm.UseVisualStyleBackColor = true;
            this.Button_PassWordForm.Click += new System.EventHandler(this.Password_Click);
            // 
            // Version
            // 
            this.Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Version.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Italic);
            this.Version.Location = new System.Drawing.Point(1030, 641);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(88, 19);
            this.Version.TabIndex = 7;
            this.Version.Text = "Versão: 1.9.3e";
            this.Version.Click += new System.EventHandler(this.Version_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MasterSheet";
            tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IOS_DataGrid_Routers)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabMaster.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.tabMainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPage_TemplatesLabel_BG)).EndInit();
            this.tabScript.ResumeLayout(false);
            this.tabScript.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Script_Row)).EndInit();
            this.Script_ButtonsSubTab.ResumeLayout(false);
            this.Script_ButtonsSubTab_Voz.ResumeLayout(false);
            this.Script_ButtonsSubTab_Logs.ResumeLayout(false);
            this.Script_ButtonsSubTab_BackboneBGP.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.Script_VarSubTab.ResumeLayout(false);
            this.Script_SubTab_VozVar.ResumeLayout(false);
            this.Script_SubTab_VozVar.PerformLayout();
            this.Script_SubTab_RouteMap.ResumeLayout(false);
            this.Script_SubTab_RouteMap.PerformLayout();
            this.tabSelectRouter.ResumeLayout(false);
            this.tabSelectRouter.PerformLayout();
            this.tabWizGat.ResumeLayout(false);
            this.tabWizGat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WizGat_Row)).EndInit();
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logs_Row2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logs_Row1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logs_Row0)).EndInit();
            this.tabVelocloud.ResumeLayout(false);
            this.tabVelocloud.PerformLayout();
            this.tabControl6.ResumeLayout(false);
            this.tab_VeloVars.ResumeLayout(false);
            this.tab_VeloVars.PerformLayout();
            this.tabLigacoes.ResumeLayout(false);
            this.tabLigacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LigacoesRow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LigacoesRow1)).EndInit();
            this.tabOutros.ResumeLayout(false);
            this.tabOutros.PerformLayout();
            this.TabSubOutros.ResumeLayout(false);
            this.Outros_TabQoS.ResumeLayout(false);
            this.Outros_TabQoS.PerformLayout();
            this.Outros_TabSNMP.ResumeLayout(false);
            this.Outros_TabSNMP.PerformLayout();
            this.Outros_TabRegraAdc.ResumeLayout(false);
            this.Outros_TabRegraAdc.PerformLayout();
            this.Outros_TabBGP.ResumeLayout(false);
            this.Outros_TabBGP.PerformLayout();
            this.Outros_TabDHCP.ResumeLayout(false);
            this.Outros_TabDHCP.PerformLayout();
            this.Outros_TabVlan.ResumeLayout(false);
            this.Outros_TabVlan.PerformLayout();
            this.Outros_TabUSUARIOS.ResumeLayout(false);
            this.Outros_TabUSUARIOS.PerformLayout();
            this.Outros_Tab_FortiVlan.ResumeLayout(false);
            this.Outros_Tab_FortiVlan.PerformLayout();
            this.Outros_TabFortiExtras.ResumeLayout(false);
            this.Outros_TabFortiExtras.PerformLayout();
            this.Outros_TabIPFLow.ResumeLayout(false);
            this.Outros_TabIPFLow.PerformLayout();
            this.Outros_TabRIP.ResumeLayout(false);
            this.Outros_TabRIP.PerformLayout();
            this.Outros_TabOSPF.ResumeLayout(false);
            this.Outros_TabOSPF.PerformLayout();
            this.Outros_TabVRRP.ResumeLayout(false);
            this.Outros_TabVRRP.PerformLayout();
            this.Outros_TabGLBP.ResumeLayout(false);
            this.Outros_TabGLBP.PerformLayout();
            this.Outros_TabEIGRP.ResumeLayout(false);
            this.Outros_TabEIGRP.PerformLayout();
            this.Outros_TabHotline.ResumeLayout(false);
            this.Outros_TabHotline.PerformLayout();
            this.Outros_Tab_HSRP.ResumeLayout(false);
            this.Outros_Tab_HSRP.PerformLayout();
            this.Outros_TabPortBlock.ResumeLayout(false);
            this.Outros_TabPortBlock.PerformLayout();
            this.tabSelectClient.ResumeLayout(false);
            this.tabSelectClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectClientRow)).EndInit();
            this.tabClient.ResumeLayout(false);
            this.tabClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Client_StepPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Client_Row0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Client_Row1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenPE_PictureBox)).EndInit();
            this.tabLogTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogTools_MainRow)).EndInit();
            this.tabControlLogTools.ResumeLayout(false);
            this.tabPendencia.ResumeLayout(false);
            this.tabPendencia.PerformLayout();
            this.tabFechamento.ResumeLayout(false);
            this.tabFechamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LTFechamento_Row)).EndInit();
            this.tabCalculadoraDeIP.ResumeLayout(false);
            this.tabCalculadoraDeIP.PerformLayout();
            this.tabSuporte.ResumeLayout(false);
            this.tabSuporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LT_Suporte_Row)).EndInit();
            this.tabScriptDB.ResumeLayout(false);
            this.tabScriptDB.PerformLayout();
            this.tabRouters.ResumeLayout(false);
            this.tabPreferencias.ResumeLayout(false);
            this.tabPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prefs_Row0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prefs_Row1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prefs_Row2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label MainTitle;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private PictureBox ImageLogo;
        private TabControl tabControl1;
        private TabPage tabMaster;
        private TabPage tabRouters;
        private TabControl tabControl2;
        private TabPage tabMainPage;
        private Button MainPage_Button_BLD;
        private Label Version;
        private Button MainPage_Button_Voz;
        private Button MainPage_Button_MPLS;
        private TabPage tabSelectRouter;
        private Button Config_Button_Cisco;
        private Button Config_Button_HPE;
        private Button HomeButton_SelectRouter;
        private PictureBox MainPage_TemplatesLabel_BG;
        private Label MainPage_TemplatesLabel;
        private Label MainPage_SubTitle2;
        private Label MainPage_SubTitle0;
        private LinkLabel MainPage_Button_ClienteList;
        private Button MainPage_Button_Cliente3;
        private Button MainPage_Button_Cliente2;
        private Button MainPage_Button_Cliente1;
        private Button MainPage_Button_Cliente0;
        private TabPage ClientStepsPage;
        private Button MainPage_Button_WizGat;
        private Label MainPage_SubTitle4;
        private Label MainPage_SubTitle3;
        private Button MainPage_Button_OC_VLAN;
        private Button MainPage_Button_OC_BlockPort;
        private DataGridView IOS_DataGrid_Routers;
        private TabPage tabWizGat;
        private Button WizGat_Button_NokiaBLDcBGP;
        private Button WizGat_Button_NokiaVoz;
        private Button WizGat_Button_NokiaMPLS;
        private Button WizGat_Button_NokiaBLD;
        private Button WizGat_Button_CiscoBLDcBGP;
        private Button WizGat_Button_CiscoVoz;
        private Button WizGat_Button_CiscoMPLS;
        private Button WizGat_Button_CiscoBLD;
        private Label WizGat_CiscoTitle;
        private Label WizGat_NokiaTitle;
        private Button BackButton_WizGat;
        private Label Config_Title;
        private Button Config_Button_Fortigate;
        private Button Config_Button_Huawei;
        private Button Config_Button_HPE_old;
        private TabPage tabLogTools;
        private TabControl tabControlLogTools;
        private TabPage tabPendencia;
        private Button Log_CopyF;
        private Button Log_Format;
        private Label Log_ProximosPassos;
        private Label Log_StatusAtual;
        private Label Log_StatusAnterior;
        private TabPage tabFechamento;
        private Button Log_ClearAll;
        private Button LogToolsPendencia;
        private Button LogToolsFechamento;
        private Button LogToolsSuporte;
        private TabPage tabSuporte;
        private Button LTSup_buttonCopyF;
        private Label LogToolsSuporteTitle;
        private Button ButtonLT_AdcCommand;
        private Label LTSuporte_DescripTitle;
        private Label LTSuporte_ComandoTitle;
        private Button LTSup_buttonClear;
        private PictureBox LT_Suporte_Row;
        private Label LTFechamento_ContatoLabel;
        private Label LTFechamento_Title;
        private Button LTFechamento_BFormatCopy;
        private CheckBox LTFechamento_CheckBox0;
        private TabPage tabLogs;
        private Button Logs_Button_CiscoBLD;
        private Button Logs_Button_VOZ_Aligera;
        private Button Logs_Button_BLD_HPE;
        private Button Logs_HomeButton;
        private Label Logs_Label_Title;
        private PictureBox Logs_Row1;
        private PictureBox Logs_Row0;
        private Label Logs_Label_SubTitle0;
        private Button Logs_Button_MPLS_HPE;
        private Button Logs_Button_MPLS_Cisco;
        private Label Logs_Label_SubTitle1;
        private Button MainPage_Button_LogsFinais;
        private Button MainPage_Button_LogsIniciais;
        private Label MainPage_SubTitle1;
        private TabPage tabScript;
        private Button Script_Button_SwitchLabel;
        private Button BackButton_Script3;
        private Button BackButton_Script2;
        private Label Script_LogBox_Label;
        private Button Script_Button_Format;
        private Button BackButton_Script;
        private ComboBox Script_LogBox;
        private Label Script_ProcedureName;
        private Button HomeButton_Script;
        private Label Script_SubTitle;
        private Button Script_Button_Copy;
        private Button MainPage_Button_OC_GLBP;
        private Button MainPage_Button_OC_IPFlow;
        private Button MainPage_Button_OC_BGP;
        private Button MainPage_Button_OC_HSRP;
        private Button MainPage_Button_OC_VRRP;
        private Button MainPage_Button_OC_OSPF;
        private Button MainPage_Button_OC_RIP;
        private Button MainPage_Button_OC_User;
        private Button MainPage_Button_OC_DHCP;
        private Button MainPage_Button_OC_ExtrasFortigate;
        private Button MainPage_Button_OC_RegraAdicional;
        private Button MainPage_Button_OC_SNMP;
        private Button MainPage_Button_OC_QoS;
        private Button MainPage_Button_OC_Vago;
        private Button MainPage_Button_OC_Balanceamento;
        private Button MainPage_Button_OC_EIGRP;
        private Label IOS_LabelInfo;
        private Button ButtonLT_ClearCommand;
        private Button ButtonLT_ResetCommand;
        private CheckBox LTFechamento_CheckBox3;
        private Button LTFechamento_ButtonClear;
        private Label LTFechamento_OBSTitle;
        private CheckBox LTFechamento_CheckBox1;
        private CheckBox LTFechamento_CheckBox4;
        private Button Logs_Button_Velo;
        private Label Logs_Label_SubTitle3;
        private TabPage tabVelocloud;
        private Button buttonVeloCopie;
        private Button HomeButton_Velo;
        private Label labelVelocloudTitle;
        private Button buttonSwitchVeloLog;
        private PictureBox LTFechamento_Row;
        private TabPage tabPage1;
        private Button IOS_Button;
        private TabPage tabPage2;
        private Button Logs_Button_MPLS_Fortigate;
        private PictureBox Logs_Row2;
        private Label Logs_Label_SubTitle2;
        private Button Logs_Button_BLD_Fortigate;
        private CheckBox LTFechamento_CheckBox2;
        private Button veloDeleteButtonAll;
        private Button LTFechamento_ButtonClear2;
        private Button LTFechamento_ButtonClear1;
        private Button Script_Button_FormCopy;
        private Button Logs_Button_BLD_Huawei;
        private Button Log_Clear3;
        private Button Log_Clear2;
        private Button Log_Clear1;
        private Button LTFechamento_ButtonCopy;
        private Button LTFechamento_ButtonFormat;
        private Button LogToolsCalc;
        private TabPage tabCalculadoraDeIP;
        private Label LTCalc_SubTitle;
        private Button LTCalc_buttonCalc;
        private Label LTCalc_Hint;
        private Label LTCalc_Title;
        private Label LTCalc_Result;
        private Button LTSup_buttonForm;
        private Button Logs_Button_Ligacoes;
        private TabPage tabLigacoes;
        private Label Ligacoes_SubTitle1;
        private Button Ligacoes_Clear3;
        private Button Ligacoes_Clear2;
        private Button Ligacoes_Clear1;
        private Button Ligacoes_Clear4;
        private Button Ligacoes_Clear5;
        private Button Ligacoes_Clear6;
        private TextBox Ligacoes_TextBox5;
        private Label Ligacoes_SubTitle5;
        private TextBox Ligacoes_TextBox6;
        private Label Ligacoes_SubTitle6;
        private TextBox Ligacoes_TextBox4;
        private Label Ligacoes_SubTitle4;
        private TextBox Ligacoes_TextBox3;
        private Label Ligacoes_SubTitle3;
        private TextBox Ligacoes_TextBox2;
        private Label Ligacoes_SubTitle2;
        private TextBox Ligacoes_TextBox1;
        private Button Ligacoes_BRestore;
        private Button Ligacoes_BCopy;
        private Button Ligacoes_BFormat;
        private Button Ligacoes_BClear;
        private Label Ligacoes_Title;
        private Button HomeButton_Ligacoes;
        private Button Logs_Button_MPLS_Huawei;
        private Button Logs_Button_Broadsoft;
        private Button Logs_Button_VOZ_Digistar;
        private Button Logs_Button_VOZ_HPE;
        private Button Logs_Button_VOZ_Cisco;
        private Button Logs_Button_WizGat;
        private Button LTSup_buttonCopy;
        private Button Log_Copy;
        private Button Ligacoes_BExemplos;
        private Button Ligacoes_BDigistar;
        private Button Ligacoes_BCisco;
        private Button Ligacoes_BHPE;
        private Button Ligacoes_BDebug;
        private Button Ligacoes_BAligera;
        private Button Ligacoes_BLogs;
        private Button Ligacoes_BHPE_Antigo;
        private Label Config_SubTitle;
        private Button Config_Button_VOZ;
        private Button Config_Button_MPLS;
        private Button Config_Button_BLD;
        private CheckBox LTFechamento_CheckBox5;
        private Label CreatedLabel;
        private RichTextBox Script_TextBox;
        private Label Config_SubTitleType;
        private Button Log_ButtonRestore;
        private RichTextBox Log_FinalTextBox;
        private RichTextBox Log_TextBox2;
        private RichTextBox Log_TextBox3;
        private RichTextBox Log_TextBox1;
        private RichTextBox LTFechamento_TextBox;
        private RichTextBox LTFechamento_TextBoxObs;
        private RichTextBox LTFechamento_ValidacaoTextBox;
        private RichTextBox LTCalc_IPTextBox;
        private RichTextBox LT_SuporteTitleTextBox;
        private RichTextBox LT_SuporteComTextBox;
        private RichTextBox LTSuporteFinalTextBox;
        private RichTextBox veloTextBoxFinal;
        private RichTextBox Ligacoes_FinalTextBox;
        private TabPage tabOutros;
        private Label Outros_TypeLabel;
        private ComboBox Outros_TypeComboBox;
        private Button Outros_ButtonForCopy;
        private Button Outros_ButtonCopy;
        private Button Outros_ButtonFormat;
        private Button HomeButton_Outros;
        private Label Outros_Script_Title;
        private RichTextBox Outros_FinalTextBox;
        private Label Outros_Title;
        private Button Script_Button_Config;
        private Label Script_SwitchLabel;
        private Button WizGat_Button_Log;
        private Button Config_Button_Logs;
        private Label Script_AlterDate;
        private Label Script_AlterDate_Label;
        private Button Script_Button_ApplyTestValues;
        private Button Button_ImportSAIP;
        private Button Test_Button_TestImport;
        private TabPage tabSelectClient;
        private Button HomeButton_ClientList;
        private TabPage tabClient;
        private Button BackButton_ClientSteps;
        private Button HomeButton_ClientSteps;
        private Button Client_NextStep;
        private Button Client_BackStep;
        private Label SelectClientTitle;
        private PictureBox SelectClientRow;
        private PictureBox Client_Row0;
        private RichTextBox Client_StepScript;
        private Label Client_NameTitle;
        private PictureBox Client_Row1;
        private Label Client_StepText;
        private PictureBox Client_StepPicture;
        private Label Client_VarEx09;
        private Button Client_VarDelete09;
        private Label Client_NameVar09;
        private TextBox Client_VarText09;
        private Label Client_VarEx08;
        private Button Client_VarDelete08;
        private Label Client_NameVar08;
        private TextBox Client_VarText08;
        private Label Client_VarEx07;
        private Button Client_VarDelete07;
        private Label Client_NameVar07;
        private TextBox Client_VarText07;
        private Label Client_VarEx06;
        private Button Client_VarDelete06;
        private Label Client_NameVar06;
        private TextBox Client_VarText06;
        private Label Client_VarEx05;
        private Button Client_VarDelete05;
        private Label Client_NameVar05;
        private TextBox Client_VarText05;
        private Label Client_VarEx04;
        private Button Client_VarDelete04;
        private Label Client_NameVar04;
        private TextBox Client_VarText04;
        private Label Client_VarEx03;
        private Button Client_VarDelete03;
        private Label Client_NameVar03;
        private TextBox Client_VarText03;
        private Label Client_VarEx02;
        private Button Client_VarDelete02;
        private Label Client_NameVar02;
        private TextBox Client_VarText02;
        private Label Client_VarEx01;
        private Button Client_VarDelete01;
        private Label Client_NameVar01;
        private TextBox Client_VarText01;
        private Label Client_ExSubTitle;
        private Label Client_VarEx00;
        private Button Client_VarDelete00;
        private Button Client_ButtonDeleteAll;
        private Label Client_VarSubTitle;
        private Label Client_NameVar00;
        private TextBox Client_VarText00;
        private Button Client_TesteClient;
        private Button MainPage_Button_Cliente4;
        private Button MainPage_Button_Cliente5;
        private Button Client_NovoButton;
        private Label Client_CriticalyLabel;
        private Button Config_Button_Digistar;
        private Button Config_Button_Aligera;
        private Button Client_ButtonRestore;
        private Button Script_Button_Debug;
        private Button Script_Button_Telnet;
        private Button LTCalc_ButtonCopy;
        private PictureBox WizGat_Row;
        private Button Client_ButtonCopyForm;
        private Button Client_ButtonCopy;
        private Button Client_ButtonFormat;
        private Button LogTools_DBScriptButton;
        private TabPage tabScriptDB;
        private Label Script_DB_Label;
        private Button Script_DB_ClearButton1;
        private Button Script_DB_ClearButton2;
        private Label Script_DB_Hint2;
        private TextBox Script_DB_VarTextBox;
        private Label Script_DB_LabelTest;
        private Button Script_DB_VarEnterButton;
        private Button Script_DB_InButton;
        private Button Script_DB_OutButton;
        private Label Script_DB_SubLabel2;
        private Label Script_DB_Hint1;
        private Label Script_DB_SubLabel1;
        private TextBox Script_DB_TextBox1;
        private TextBox Script_DB_TextBox2;
        private PictureBox LogTools_MainRow;
        private TabControl TabSubOutros;
        private TabPage Outros_TabQoS;
        private Label Outros_QoSCalcLabel;
        private Button Outros_QoS_ClearButton;
        private Label Outros_QoS_Guide;
        private TextBox Outros_VarTextPercQoS03;
        private TextBox Outros_VarTextPercQoS06;
        private TextBox Outros_VarTextPercQoS05;
        private TextBox Outros_VarTextPercQoS02;
        private TextBox Outros_VarTextPercQoS04;
        private TextBox Outros_VarTextPercQoS01;
        private TextBox Outros_VarTextPercQoS00;
        private TextBox Outros_VarTextQoS03;
        private Label Outros_VarNameQoS3;
        private Label Outros_QoSDispTotal;
        private Label Outros_QoSCalcEx;
        private TextBox Outros_QoSCalcText;
        private TextBox Outros_VarTextQoS08;
        private Label Outros_VarNameQoS8;
        private TextBox Outros_VarTextQoS07;
        private Label Outros_VarNameQoS7;
        private Button Outros_VarDeleteQoS6;
        private TextBox Outros_VarTextQoS06;
        private Label Outros_VarNameQoS6;
        private Button Outros_VarDeleteQoS5;
        private TextBox Outros_VarTextQoS05;
        private TextBox Outros_VarTextQoS02;
        private TextBox Outros_VarTextQoS04;
        private TextBox Outros_VarTextQoS01;
        private Label Outros_VarNameQoS2;
        private Label Outros_VarNameQoS5;
        private Label Outros_VarNameQoS4;
        private Label Outros_VarNameQoS1;
        private Label Outros_VarNameQoS0;
        private TextBox Outros_VarTextQoS00;
        private TabPage Outros_TabSNMP;
        private Label Outros_SNMP_ExTitle;
        private Label Outros_SNMP_ExLabel1;
        private Label Outros_SNMP_ExLabel0;
        private Button Outros_SNMP_ClearButton;
        private TextBox Outros_SNMP_VarText1;
        private Label Outros_SNMP_VarLabel1;
        private Label Outros_SNMP_VarLabel0;
        private TextBox Outros_SNMP_VarText0;
        private Label Outros_SNMP_Guide;
        private Label Outros_SNMP_VarTitle;
        private Button Outros_VarDeleteQoS8;
        private Button Outros_VarDeleteQoS7;
        private Button Outros_VarDeleteQoS3;
        private Button Outros_VarDeleteQoS2;
        private Button Outros_VarDeleteQoS4;
        private Button Outros_VarDeleteQoS1;
        private Button Outros_VarDeleteQoS0;
        private Button Outros_SNMP_VarDelete1;
        private Button Outros_SNMP_VarDelete0;
        private TabPage Outros_TabRegraAdc;
        private TabPage Outros_TabBGP;
        private TabPage Outros_TabDHCP;
        private Button Outros_RegraAdc_DelButton2;
        private Button Outros_RegraAdc_DelButton1;
        private Label Outros_RegraAdc_ExTitle;
        private Label Outros_RegraAdc_ExLabel2;
        private Label Outros_RegraAdc_ExLabel1;
        private Label Outros_RegraAdc_ExLabel0;
        private Button Outros_RegraAdc_DelButton0;
        private Button Outros_RegraAdc_ClearButton;
        private TextBox Outros_RegraAdc_VarText2;
        private TextBox Outros_RegraAdc_VarText1;
        private Label Outros_RegraAdc_Label1;
        private Label Outros_RegraAdc_Label0;
        private TextBox Outros_RegraAdc_VarText0;
        private Label Outros_RegraAdc_VarTitle;
        private Label Outros_RegraAdc_NumRegraLabel;
        private Button Outros_BGP_DeleteVar2;
        private Button Outros_BGP_DeleteVar1;
        private Label Outros_BGP_ExTitle;
        private Label Outros_BGP_ExLabel2;
        private Label Outros_BGP_ExLabel1;
        private Label Outros_BGP_ExLabel0;
        private Button Outros_BGP_DeleteVar0;
        private Button Outros_BGP_DeleteAll;
        private TextBox Outros_BGP_VarText2;
        private TextBox Outros_BGP_VarText1;
        private Label Outros_BGP_Label2;
        private Label Outros_BGP_Label1;
        private Label Outros_BGP_Label0;
        private TextBox Outros_BGP_VarText0;
        private Label Outros_BGP_VarTitle;
        private Button Outros_DHCP_DelButton1;
        private Button Outros_DHCP_DelButton9;
        private Label Outros_DHCP_ExTitle;
        private Label Outros_DHCP_ExLabel1;
        private Label Outros_DHCP_ExLabel9;
        private Label Outros_DHCP_ExLabel0;
        private Button Outros_DHCP_ClearButton;
        private TextBox Outros_DHCP_VarText1;
        private TextBox Outros_DHCP_VarText8;
        private Label Outros_DHCP_Label1;
        private Label Outros_DHCP_Label9;
        private Label Outros_DHCP_Label0;
        private Label Outros_DHCP_VarTitle;
        private ComboBox Outros_RegraAdc_NumDaRegraComboBox;
        private Label Outros_RegraAdc_Guide;
        private Label Outros_BGP_ExLabel5;
        private Button Outros_BGP_DeleteVar5;
        private Label Outros_BGP_Label5;
        private TextBox Outros_BGP_VarText5;
        private Label Outros_BGP_ExLabel4;
        private Button Outros_BGP_DeleteVar4;
        private Label Outros_BGP_Label4;
        private TextBox Outros_BGP_VarText4;
        private Label Outros_BGP_ExLabel3;
        private Button Outros_BGP_DeleteVar3;
        private Label Outros_BGP_Label3;
        private TextBox Outros_BGP_VarText3;
        private Label Outros_BGP_Guide;
        private Label Outros_DHCP_Guide;
        private TabPage Outros_TabVlan;
        private Label Outros_VLAN_Guide;
        private Button Outros_VLAN_VarDel1;
        private Label Outros_VLAN_ExTitleLabel;
        private Label Outros_VLAN_ExLabel1;
        private Label Outros_VLAN_ExLabel0;
        private Button Outros_VLAN_VarDel0;
        private Button Outros_VLAN_ClearAllButton;
        private TextBox Outros_VLAN_VarText1;
        private Label Outros_VLAN_VarLabel1;
        private Label Outros_VLAN_VarLabel0;
        private TextBox Outros_VLAN_VarText0;
        private Label Outros_VLAN_LabelTitle;
        private Label Outros_RegraAdc_Label2;
        private Button Outros_DHCP_DelButton8;
        private Label Outros_DHCP_ExLabel8;
        private TextBox Outros_DHCP_VarText7;
        private Label Outros_DHCP_Label8;
        private Button Outros_DHCP_DelButton7;
        private Label Outros_DHCP_ExLabel7;
        private TextBox Outros_DHCP_VarText6;
        private Label Outros_DHCP_Label7;
        private Button Outros_DHCP_DelButton6;
        private Label Outros_DHCP_ExLabel6;
        private TextBox Outros_DHCP_VarText5;
        private Label Outros_DHCP_Label6;
        private Button Outros_DHCP_DelButton3;
        private Label Outros_DHCP_ExLabel3;
        private TextBox Outros_DHCP_VarText4;
        private Label Outros_DHCP_Label3;
        private Button Outros_DHCP_DelButton2;
        private Label Outros_DHCP_ExLabel2;
        private TextBox Outros_DHCP_VarText3;
        private Label Outros_DHCP_Label2;
        private Label Outros_DHCP_SubTitle;
        private PictureBox LigacoesRow1;
        private PictureBox LigacoesRow2;
        private TabPage Outros_TabUSUARIOS;
        private Button MainPage_Button_OC_Hotline;
        private Button Outros_User_VarDelete1;
        private Label Outros_User_ExTitle;
        private Label Outros_User_ExLabel2;
        private Label Outros_User_ExLabel1;
        private Label Outros_User_ExLabel0;
        private Button Outros_User_VarDelete0;
        private Button Outros_User_ClearButton;
        private TextBox Outros_User_VarText1;
        private Label Outros_User_Label1;
        private Label Outros_User_Label0;
        private TextBox Outros_User_VarText0;
        private Label Outros_User_VarTitle;
        private Label Outros_User_Label2;
        private ComboBox Outros_User_VarPrivBox;
        private Button Outros_DHCP_DelButton5;
        private TextBox Outros_DHCP_VarText10;
        private Label Outros_DHCP_Label5;
        private Button Outros_DHCP_DelButton4;
        private TextBox Outros_DHCP_VarText9;
        private Label Outros_DHCP_Label4;
        private Button Outros_DHCP_DelButton0;
        private TextBox Outros_DHCP_VarText0;
        private ComboBox Outros_DHCP_MascaraBox;
        private ComboBox Outros_VLAN_MascaraBox;
        private Label Outros_DHCP_ExLabel5;
        private Label Outros_DHCP_ExLabel4;
        private CheckBox Outros_QoS_CiscoCheckBox;
        private Label Outros_User_Guide;
        private CheckBox Outros_VLAN_CatalystCheckBox;
        private Button Outros_VLAN_FortigateButton;
        private TabPage Outros_Tab_FortiVlan;
        private TabPage Outros_TabFortiExtras;
        private Label Outros_User_Hint;
        private Label Outros_FortiVlan_Label;
        private Label label72;
        private TabPage Outros_TabIPFLow;
        private Label Outros_IPFlow_Guide;
        private TabPage Outros_TabRIP;
        private TabPage Outros_TabOSPF;
        private TabPage Outros_TabVRRP;
        private TabPage Outros_TabGLBP;
        private TabPage Outros_TabEIGRP;
        private TabPage Outros_TabHotline;
        private Label label73;
        private Label label74;
        private Label Outro_VRRP_Guide;
        private Label label76;
        private Label label77;
        private Label label78;
        private Button Outros_IPFlow_DelButton2;
        private Button Outros_IPFlow_DelButton1;
        private Label Outros_IPFlow_ExTitle;
        private Label Outros_IPFlow_ExLabel2;
        private Label Outros_IPFlow_ExLabel1;
        private Label Outros_IPFlow_ExLabel0;
        private Button Outros_IPFlow_DelButton0;
        private Button Outros_IPFlow_ClearButton;
        private TextBox Outros_IPFlow_VarText2;
        private TextBox Outros_IPFlow_VarText1;
        private Label Outros_IPFlow_Label2;
        private Label Outros_IPFlow_Label1;
        private Label Outros_IPFlow_Label0;
        private TextBox Outros_IPFlow_VarText0;
        private Label Outros_IPFlow_VarTitle;
        private Button Outro_VRRP_DelButton10;
        private Button Outro_VRRP_DelButton9;
        private Label Outro_VRRP_ExTitle2;
        private Label Outro_VRRP_ExLabel10;
        private Label Outro_VRRP_ExLabel9;
        private Label Outro_VRRP_ExLabel8;
        private Button Outro_VRRP_DelButton8;
        private Button Outro_VRRP_ClearButton2;
        private TextBox Outro_VRRP_VarText10;
        private TextBox Outro_VRRP_VarText9;
        private Label Outro_VRRP_Label10;
        private Label Outro_VRRP_Label9;
        private TextBox Outro_VRRP_VarText8;
        private Label Outro_VRRP_Label8;
        private Label Outro_VRRP_SubTitle2;
        private Button Outro_VRRP_DelButton5;
        private Button Outro_VRRP_DelButton4;
        private Label Outro_VRRP_ExTitle1;
        private Label Outro_VRRP_ExLabel5;
        private Label Outro_VRRP_ExLabel4;
        private Label Outro_VRRP_ExLabel3;
        private Button Outro_VRRP_DelButton3;
        private Button Outro_VRRP_ClearButton1;
        private TextBox Outro_VRRP_VarText5;
        private TextBox Outro_VRRP_VarText4;
        private Label Outro_VRRP_Label5;
        private Label Outro_VRRP_Label4;
        private Label Outro_VRRP_Label3;
        private TextBox Outro_VRRP_VarText3;
        private Label Outro_VRRP_SubTitle1;
        private Button Outro_VRRP_DelButton2;
        private Button Outro_VRRP_DelButton1;
        private Label Outro_VRRP_ExTitle0;
        private Label Outro_VRRP_ExLabel2;
        private Label Outro_VRRP_ExLabel1;
        private Label Outro_VRRP_ExLabel0;
        private Button Outro_VRRP_DelButton0;
        private Button Outro_VRRP_ClearButton0;
        private TextBox Outro_VRRP_VarText2;
        private TextBox Outro_VRRP_VarText1;
        private Label Outro_VRRP_Label2;
        private Label Outro_VRRP_Label1;
        private Label Outro_VRRP_Label0;
        private TextBox Outro_VRRP_VarText0;
        private Label Outro_VRRP_SubTitle0;
        private CheckBox Outro_VRRP_CheckBoxCisco;
        private TabPage tabPreferencias;
        private Label Pref_User_SubLabel2;
        private Label Pref_User_SubLabel1;
        private TextBox Pref_User_PasswordTextBox;
        private TextBox Pref_User_NameTextBox;
        private Button Button_PassWordForm;
        private Label Pref_Putty_TitleLabel;
        private Label Pref_TACACS_TitleLabel;
        private Label Pref_TACACS_SubLabel2;
        private Label Pref_TACACS_SubLabel1;
        private TextBox Pref_TACACS_PasswordTextBox;
        private TextBox Pref_TACACS_UserTextBox;
        private Label Pref_User_TitleLabel;
        private Button Pref_Putty_SearchButton;
        private Button Pref_Putty_SaveButton;
        private TextBox Pref_Putty_PathTextBox;
        private Button ResetValue_Button;
        private Button OpenPE_Button;
        private Button Button_EditScript;
        private Button Button_NightMode;
        private TabPage Outros_Tab_HSRP;
        private Label Outros_HSRP_Label;
        private Button Outro_VRRP_DelButton12;
        private TextBox Outro_VRRP_VarText12;
        private Label Outro_VRRP_Label12;
        private Button Outro_VRRP_DelButton11;
        private TextBox Outro_VRRP_VarText11;
        private Label Outro_VRRP_Label11;
        private Button Outro_VRRP_DelButton7;
        private TextBox Outro_VRRP_VarText7;
        private Label Outro_VRRP_Label7;
        private Button Outro_VRRP_DelButton6;
        private TextBox Outro_VRRP_VarText6;
        private Label Outro_VRRP_Label6;
        private TabPage Outros_TabPortBlock;
        private Label IOS_Label0;
        private LinkLabel IOS_LinkLabel;
        private ComboBox Outros_PortBLock_ComboBox12;
        private ComboBox Outros_PortBLock_ComboBox11;
        private ComboBox Outros_PortBLock_ComboBox10;
        private ComboBox Outros_PortBLock_ComboBox9;
        private ComboBox Outros_PortBLock_ComboBox8;
        private ComboBox Outros_PortBLock_ComboBox7;
        private ComboBox Outros_PortBLock_ComboBox6;
        private ComboBox Outros_PortBLock_ComboBox5;
        private ComboBox Outros_PortBLock_ComboBox4;
        private ComboBox Outros_PortBLock_ComboBox3;
        private ComboBox Outros_PortBLock_ComboBox2;
        private ComboBox Outros_PortBLock_ComboBox1;
        private ComboBox Outros_PortBLock_ComboBox0;
        private Label Outros_PortBlock_Label16;
        private Label Outros_PortBlock_Label15;
        private Label Outros_PortBlock_Label14;
        private Label Outros_PortBlock_Label13;
        private Label Outros_PortBlock_Label12;
        private Label Outros_PortBlock_Label11;
        private Label Outros_PortBlock_Label10;
        private Label Outros_PortBlock_Label9;
        private Label Outros_PortBlock_Label8;
        private Label Outros_PortBlock_Label7;
        private Label Outros_PortBlock_Label6;
        private Label Outros_PortBlock_Label5;
        private Label Outros_PortBlock_Label4;
        private Button Outros_PortBlock_ChangeAllButton;
        private Label Outros_PortBlock_Guide;
        private Label Outros_PortBlock_ExLabelTitle;
        private Label Outros_PortBlock_ExLabel0;
        private Button Outros_PortBlock_Delete0;
        private Label Outros_PortBlock_Label0;
        private TextBox Outros_PortBlock_TextBox0;
        private Label Outros_PortBlock_LabelTitle;
        private Button Config_Button_Broadsoft;
        private ComboBox Outros_PortBLock_ComboBox16;
        private Label Outros_PortBlock_Label18;
        private ComboBox Outros_PortBLock_ComboBox14;
        private Label Outros_PortBlock_Label17;
        private ComboBox Outros_PortBLock_ComboBox13;
        private Label Outros_PortBlock_Label20;
        private Label Outros_PortBlock_Label19;
        private ComboBox Outros_PortBLock_ComboBox15;
        private Label Outros_PortBlock_ExLabel2;
        private Button Outros_PortBlock_Delete2;
        private Label Outros_PortBlock_Label2;
        private TextBox Outros_PortBlock_TextBox2;
        private Label Outros_PortBlock_ExLabel1;
        private Button Outros_PortBlock_Delete1;
        private Label Outros_PortBlock_Label1;
        private TextBox Outros_PortBlock_TextBox1;
        private CheckBox Outros_PortBlock_HPEold;
        private Button Ligacoes_ConfigWiseButton;
        private Button List_All_Scritps;
        private Button Outros_Button_ApplyTestValues;
        private Label OpenPE_Label;
        private ComboBox OpenPE_ComboBox;
        private PictureBox OpenPE_PictureBox;
        private Button Outros_PortBlock_ClearButton;
        private Label Outros_SNMP_VarLabel2;
        private ComboBox Outros_SNMP_VarPrivComboBox;
        private Label Outros_SNMP_ExLabel2;
        private Button Script_Button_TelnetPlus;
        private Button Script_Button_TACACS;
        private TabControl Script_ButtonsSubTab;
        private TabPage Script_ButtonsSubTab_Logs;
        private TabPage Script_ButtonsSubTab_Voz;
        private Button Script_ButtonRegraAdc;
        private Button Script_Button_Tracert;
        private Button Script_Button_Limpeza;
        private Button Script_Button_Parte2;
        private TabPage Script_ButtonsSubTab_BackboneBGP;
        private Button Script_Button_IPv6;
        private Button Script_Button_Multihop;
        private Label Velo_TypeLabel;
        private TabControl tabControl6;
        private TabPage tab_VeloVars;
        private RichTextBox veloTextBox4;
        private RichTextBox veloTextBox5;
        private RichTextBox veloTextBox3;
        private RichTextBox veloTextBox8;
        private RichTextBox veloTextBox7;
        private RichTextBox veloTextBox6;
        private Button veloDeleteButton5;
        private Button veloDeleteButton8;
        private Label Velo_Configuracao_Label;
        private Button veloDeleteButton7;
        private RichTextBox veloTextBox1;
        private Button veloDeleteButton6;
        private RichTextBox veloTextBox2;
        private Label Velo_Monitor_Label;
        private Label labelVeloSubtitle5;
        private Label labelVeloSubtitle6;
        private RichTextBox veloTextBox0;
        private Label labelVeloSubtitle7;
        private Label labelVeloSubtitle8;
        private Button veloDeleteButton4;
        private Button veloDeleteButton3;
        private Button veloDeleteButton2;
        private Button veloDeleteButton1;
        private Button veloDeleteButton0;
        private Label labelVeloSubtitle4;
        private Label labelVeloSubtitle3;
        private Label labelVeloSubtitle2;
        private Label labelVeloSubtitle1;
        private Label labelVeloSubtitle0;
        private RichTextBox veloTextBox13;
        private RichTextBox veloTextBox16;
        private RichTextBox veloTextBox15;
        private RichTextBox veloTextBox11;
        private RichTextBox veloTextBox12;
        private RichTextBox veloTextBox14;
        private RichTextBox veloTextBox9;
        private RichTextBox veloTextBox10;
        private Label labelVeloSubtitle14;
        private Label labelVeloSubtitle15;
        private Label labelVeloSubtitle16;
        private Button veloDeleteButton14;
        private Button veloDeleteButton15;
        private Button veloDeleteButton13;
        private Button veloDeleteButton16;
        private Label labelVeloSubtitle13;
        private Label labelVeloSubtitle9;
        private Button veloDeleteButton12;
        private Label labelVeloSubtitle10;
        private Button veloDeleteButton11;
        private Button veloDeleteButton10;
        private Label labelVeloSubtitle12;
        private Button veloDeleteButton9;
        private Label Velo_Testes_Label;
        private Label labelVeloSubtitle11;
        private Label Outros_PortBlock_ExLabel3;
        private Button Outros_PortBlock_Delete3;
        private Label Outros_PortBlock_Label3;
        private TextBox Outros_PortBlock_TextBox3;
        private CheckBox Outros_RegraAdc_ISRCheckBox;
        private CheckBox Outros_RegraAdc_AligeraCheckBox;
        private Button MainPage_ColetaLigacoes_Button;
        private Button MainPage_Velo_Button;
        private Button veloRestoreButton;
        private Button Outros_VarDeleteCalc;
        private Button Outros_RegraAdc_DelButton3;
        private Label Outros_RegraAdc_ExLabel3;
        private TextBox Outros_RegraAdc_VarText3;
        private Label Outros_RegraAdc_Label3;
        private Button Outros_RegraAdc_DelButton4;
        private Label Outros_RegraAdc_Label4;
        private TextBox Outros_RegraAdc_VarText4;
        private Label Outros_RegraAdc_ExLabel4;
        private PictureBox Prefs_Row0;
        private PictureBox Prefs_Row1;
        private PictureBox Prefs_Row2;
        private TabControl tabControl4;
        private TabPage tabPage4;
        private ComboBox Script_LANMascaraBox;
        private Button Script_Button_PortImport;
        private Button Script_DeleteVar03b;
        private TextBox Script_VarText03b;
        private Label Script_ExLabel;
        private Label Script_VarEx13;
        private Label Script_VarEx14;
        private Label Script_VarEx15;
        private Label Script_VarEx12;
        private Label Script_VarEx11;
        private Label Script_VarEx10;
        private Label Script_VarEx09;
        private Label Script_VarEx08;
        private Label Script_VarEx07;
        private Label Script_VarEx06;
        private Label Script_VarEx05;
        private Label Script_VarEx04;
        private Label Script_VarEx03;
        private Label Script_VarEx02;
        private Label Script_VarEx01;
        private Label Script_VarEx00;
        private TextBox Script_VarText15;
        private Label Script_VarName15;
        private TextBox Script_VarText14;
        private Label Script_VarName14;
        private TextBox Script_VarText13;
        private Label Script_VarName13;
        private TextBox Script_VarText12;
        private Label Script_VarName12;
        private Label Script_ModelLabel;
        private ComboBox Script_RouterModelBox;
        private TextBox Script_VarText11;
        private Label Script_VarName11;
        private TextBox Script_VarText10;
        private Label Script_VarName10;
        private Label Script_VarName09;
        private TextBox Script_VarText08;
        private Label Script_VarName08;
        private TextBox Script_VarText07;
        private Label Script_VarName07;
        private Label Script_VarName06;
        private Button Script_Button_Clear;
        private Label Script_VarTitle;
        private TextBox Script_VarText05;
        private TextBox Script_VarText04;
        private TextBox Script_VarText03;
        private TextBox Script_VarText02;
        private TextBox Script_VarText01;
        private Label Script_VarName05;
        private Label Script_VarName03;
        private Label Script_VarName04;
        private Label Script_VarName02;
        private Label Script_VarName01;
        private Label Script_VarName00;
        private TextBox Script_VarText00;
        private Label Script_XRLabel;
        private ComboBox Script_XRBox;
        private TextBox Script_VarText09;
        private Label Script_Hint1;
        private Button Script_DeleteVar09;
        private Button Script_DeleteVar08;
        private Button Script_DeleteVar07;
        private Button Script_DeleteVar10;
        private Button Script_DeleteVar11;
        private Button Script_DeleteVar06;
        private Button Script_DeleteVar15;
        private Button Script_DeleteVar14;
        private Button Script_DeleteVar13;
        private Button Script_DeleteVar12;
        private Button Script_DeleteVar05;
        private Button Script_DeleteVar04;
        private Button Script_DeleteVar03;
        private Button Script_DeleteVar01;
        private Button Script_DeleteVar00;
        private Button Script_DeleteVar02;
        private TabControl Script_VarSubTab;
        private TabPage Script_SubTab_VozVar;
        private TabPage Script_SubTab_RouteMap;
        private TextBox Script_VarText06;
        private ComboBox Script_SinalizBox;
        private Label Script_VarEx21;
        private Button Script_DeleteVar21;
        private Label Script_VarName21;
        private Label BigTitle_Label;
        private Button Script_DeleteVar16;
        private Label Script_VarEx18;
        private Label Script_VarEx19;
        private Label Script_VarEx20;
        private Label Script_VarEx17;
        private Label Script_VarEx16;
        private Button Script_DeleteVar20;
        private TextBox Script_VarText20;
        private Label Script_VarName20;
        private Button Script_DeleteVar19;
        private TextBox Script_VarText19;
        private Label Script_VarName19;
        private Button Script_DeleteVar18;
        private TextBox Script_VarText18;
        private Label Script_VarName18;
        private Button Script_DeleteVar17;
        private TextBox Script_VarText17;
        private Label Script_VarName17;
        private TextBox Script_VarText16;
        private Label Script_VarName16;
        private TextBox Script_VarText21;
        private Button Script_DeleteRouteI1;
        private Button Script_DeleteRouteI2;
        private Button Script_DeleteRouteE1;
        private Button Script_DeleteRouteE2;
        private TextBox Script_VarRouteE2;
        private TextBox Script_VarRouteE1;
        private Label Script_VarRouteE2Label;
        private Label Script_VarRouteE1Label;
        private Label Script_VarRouteI2Label;
        private TextBox Script_VarRouteI2;
        private Label Script_VarRouteI1Label;
        private TextBox Script_VarRouteI1;
        private Label Script_RouteLabelHint;
        private Label Script_SinalizLabel;
        private TabPage Script_VarSubTab_Hollow;
        private PictureBox Script_Row;
        private TabPage Script_ButtonsSubTab_Hollow;
        private Button Script_Button_Inverter;
        private CheckBox Test_CheckBox_ShowVarOnScript;
        private Button Logs_Button_Config;
        private Button Config_Button_WizGat;
        private Button Outros_Button_Logs;
        private Button WizGat_Button_Config;
        private CheckBox Outros_CheckBox_ShowTrueScript;
        private Button Script_Button_ClearPortas;
    }
}

