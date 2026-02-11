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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Button_IOS = new System.Windows.Forms.Button();
            this.labelRouterInfo = new System.Windows.Forms.Label();
            this.dataGridRouters = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainTitle = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMaster = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabSelectProcedure = new System.Windows.Forms.TabPage();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.buttonOC_QoS = new System.Windows.Forms.Button();
            this.buttonOC_IOSInstal = new System.Windows.Forms.Button();
            this.buttonOC_Balanceamento = new System.Windows.Forms.Button();
            this.buttonOC_EIGRP = new System.Windows.Forms.Button();
            this.buttonOC_GLBP = new System.Windows.Forms.Button();
            this.buttonOC_IPFlow = new System.Windows.Forms.Button();
            this.buttonOC_NTP = new System.Windows.Forms.Button();
            this.buttonOC_HSRP = new System.Windows.Forms.Button();
            this.buttonOC_VRRP = new System.Windows.Forms.Button();
            this.buttonOC_OSPF = new System.Windows.Forms.Button();
            this.buttonOC_RIP = new System.Windows.Forms.Button();
            this.buttonOC_User = new System.Windows.Forms.Button();
            this.buttonOC_DHCP = new System.Windows.Forms.Button();
            this.buttonOC_IPsecundario = new System.Windows.Forms.Button();
            this.buttonOC_RotaEstatica = new System.Windows.Forms.Button();
            this.buttonOC_Tacacs = new System.Windows.Forms.Button();
            this.buttonOC_SNMP = new System.Windows.Forms.Button();
            this.buttonOC_BlocPort = new System.Windows.Forms.Button();
            this.buttonOC_VLAN = new System.Windows.Forms.Button();
            this.WizGat_Open = new System.Windows.Forms.Button();
            this.WizardGatLabel = new System.Windows.Forms.Label();
            this.OutrasConfigs = new System.Windows.Forms.Label();
            this.AllClients = new System.Windows.Forms.LinkLabel();
            this.ClienteButton_Test4 = new System.Windows.Forms.Button();
            this.ClienteButton_Test3 = new System.Windows.Forms.Button();
            this.ClienteButton_Test2 = new System.Windows.Forms.Button();
            this.ClienteButton_Teste1 = new System.Windows.Forms.Button();
            this.Logs_Finais = new System.Windows.Forms.Button();
            this.Logs_Iniciais = new System.Windows.Forms.Button();
            this.ScriptsSubTitle = new System.Windows.Forms.Label();
            this.LogsSubTitle = new System.Windows.Forms.Label();
            this.ClientesSubTitle = new System.Windows.Forms.Label();
            this.TemplatesLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Version = new System.Windows.Forms.Label();
            this.VOZ_Button = new System.Windows.Forms.Button();
            this.MPLS_button = new System.Windows.Forms.Button();
            this.BLD_button = new System.Windows.Forms.Button();
            this.tabScript = new System.Windows.Forms.TabPage();
            this.Script_TextBox = new System.Windows.Forms.RichTextBox();
            this.Script_ExLabel = new System.Windows.Forms.Label();
            this.Script_VarEx13 = new System.Windows.Forms.Label();
            this.Script_VarEx14 = new System.Windows.Forms.Label();
            this.Script_VarEx15 = new System.Windows.Forms.Label();
            this.Script_VarEx12 = new System.Windows.Forms.Label();
            this.Script_VarEx11 = new System.Windows.Forms.Label();
            this.Script_VarEx10 = new System.Windows.Forms.Label();
            this.Script_VarEx9 = new System.Windows.Forms.Label();
            this.Script_VarEx8 = new System.Windows.Forms.Label();
            this.Script_VarEx7 = new System.Windows.Forms.Label();
            this.Script_VarEx6 = new System.Windows.Forms.Label();
            this.Script_VarEx5 = new System.Windows.Forms.Label();
            this.Script_VarEx4 = new System.Windows.Forms.Label();
            this.Script_VarEx3 = new System.Windows.Forms.Label();
            this.Script_VarEx2 = new System.Windows.Forms.Label();
            this.Script_VarEx1 = new System.Windows.Forms.Label();
            this.Script_VarEx0 = new System.Windows.Forms.Label();
            this.Script_DeleteVar15 = new System.Windows.Forms.Button();
            this.Script_Var15 = new System.Windows.Forms.TextBox();
            this.Script_VarName15 = new System.Windows.Forms.Label();
            this.Script_DeleteVar14 = new System.Windows.Forms.Button();
            this.Script_Var14 = new System.Windows.Forms.TextBox();
            this.Script_VarName14 = new System.Windows.Forms.Label();
            this.Script_DeleteVar13 = new System.Windows.Forms.Button();
            this.Script_Var13 = new System.Windows.Forms.TextBox();
            this.Script_VarName13 = new System.Windows.Forms.Label();
            this.Script_DeleteVar12 = new System.Windows.Forms.Button();
            this.Script_Var12 = new System.Windows.Forms.TextBox();
            this.Script_VarName12 = new System.Windows.Forms.Label();
            this.Script_DeleteRouteE2 = new System.Windows.Forms.Button();
            this.Script_VarRouteE2Label = new System.Windows.Forms.Label();
            this.Script_VarRouteE2 = new System.Windows.Forms.TextBox();
            this.Script_DeleteRouteE1 = new System.Windows.Forms.Button();
            this.Script_VarRouteE1Label = new System.Windows.Forms.Label();
            this.Script_VarRouteE1 = new System.Windows.Forms.TextBox();
            this.Script_DeleteRouteI2 = new System.Windows.Forms.Button();
            this.Script_VarRouteI2Label = new System.Windows.Forms.Label();
            this.Script_VarRouteI2 = new System.Windows.Forms.TextBox();
            this.Script_DeleteRouteI1 = new System.Windows.Forms.Button();
            this.Script_VarRouteI1Label = new System.Windows.Forms.Label();
            this.Script_VarRouteI1 = new System.Windows.Forms.TextBox();
            this.Script_RouteLabelHint = new System.Windows.Forms.Label();
            this.Script_XRLabel = new System.Windows.Forms.Label();
            this.Script_XRBox = new System.Windows.Forms.ComboBox();
            this.Button_FormatarECopiarScript = new System.Windows.Forms.Button();
            this.Script_DeleteVar11 = new System.Windows.Forms.Button();
            this.Script_DeleteVar10 = new System.Windows.Forms.Button();
            this.Script_DeleteVar9 = new System.Windows.Forms.Button();
            this.Script_DeleteVar8 = new System.Windows.Forms.Button();
            this.Script_DeleteVar7 = new System.Windows.Forms.Button();
            this.Script_DeleteVar6 = new System.Windows.Forms.Button();
            this.Script_DeleteVar5 = new System.Windows.Forms.Button();
            this.Script_DeleteVar4 = new System.Windows.Forms.Button();
            this.Script_DeleteVar3 = new System.Windows.Forms.Button();
            this.Script_DeleteVar2 = new System.Windows.Forms.Button();
            this.Script_DeleteVar1 = new System.Windows.Forms.Button();
            this.Script_DeleteVar0 = new System.Windows.Forms.Button();
            this.Script_ISRBox = new System.Windows.Forms.ComboBox();
            this.Script_ISRLabel = new System.Windows.Forms.Label();
            this.Script_ModelLabel = new System.Windows.Forms.Label();
            this.Script_FortigateModel = new System.Windows.Forms.ComboBox();
            this.hint1 = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.Script_Var11 = new System.Windows.Forms.TextBox();
            this.Script_VarName11 = new System.Windows.Forms.Label();
            this.Script_Var10 = new System.Windows.Forms.TextBox();
            this.Script_VarName10 = new System.Windows.Forms.Label();
            this.buttonSwitchScriptLog = new System.Windows.Forms.Button();
            this.ButtonLimpeza = new System.Windows.Forms.Button();
            this.ButtonParte2 = new System.Windows.Forms.Button();
            this.Script_Var9 = new System.Windows.Forms.TextBox();
            this.Script_VarName9 = new System.Windows.Forms.Label();
            this.Script_Var8 = new System.Windows.Forms.TextBox();
            this.Script_VarName8 = new System.Windows.Forms.Label();
            this.Script_Var7 = new System.Windows.Forms.TextBox();
            this.Script_VarName7 = new System.Windows.Forms.Label();
            this.Script_LANMascara = new System.Windows.Forms.ComboBox();
            this.BackButton_Script3 = new System.Windows.Forms.Button();
            this.BackButton_Script2 = new System.Windows.Forms.Button();
            this.Script_TypeLabel = new System.Windows.Forms.Label();
            this.Button_FormatarScript = new System.Windows.Forms.Button();
            this.BackButton_Script = new System.Windows.Forms.Button();
            this.Script_ComboBox = new System.Windows.Forms.ComboBox();
            this.Script_Var6 = new System.Windows.Forms.TextBox();
            this.Script_VarName6 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.VarText = new System.Windows.Forms.Label();
            this.Script_Var5 = new System.Windows.Forms.TextBox();
            this.Script_Var4 = new System.Windows.Forms.TextBox();
            this.Script_Var3 = new System.Windows.Forms.TextBox();
            this.Script_Var2 = new System.Windows.Forms.TextBox();
            this.Script_Var1 = new System.Windows.Forms.TextBox();
            this.Script_VarName5 = new System.Windows.Forms.Label();
            this.Script_VarName3 = new System.Windows.Forms.Label();
            this.Script_VarName4 = new System.Windows.Forms.Label();
            this.Script_VarName2 = new System.Windows.Forms.Label();
            this.Script_VarName1 = new System.Windows.Forms.Label();
            this.ProcedureName = new System.Windows.Forms.Label();
            this.HomeButton_Script = new System.Windows.Forms.Button();
            this.Script_LabelScript = new System.Windows.Forms.Label();
            this.Script_VarName0 = new System.Windows.Forms.Label();
            this.Script_Var0 = new System.Windows.Forms.TextBox();
            this.tabSelectRouter = new System.Windows.Forms.TabPage();
            this.Config_ChangeVOZ = new System.Windows.Forms.Button();
            this.Config_ChangeMPLS = new System.Windows.Forms.Button();
            this.Config_ChangeBLD = new System.Windows.Forms.Button();
            this.ConfiguracaoCPE_SubTitle = new System.Windows.Forms.Label();
            this.Config_Fortigate = new System.Windows.Forms.Button();
            this.Config_Huawei = new System.Windows.Forms.Button();
            this.Config_HPE_old = new System.Windows.Forms.Button();
            this.ConfiguracaoCPETitle = new System.Windows.Forms.Label();
            this.BackButton_SelectRouter = new System.Windows.Forms.Button();
            this.Config_HPE = new System.Windows.Forms.Button();
            this.Config_Cisco = new System.Windows.Forms.Button();
            this.ClientStepsPage = new System.Windows.Forms.TabPage();
            this.tabWizGat = new System.Windows.Forms.TabPage();
            this.BackButton_WizGat = new System.Windows.Forms.Button();
            this.WizCiscoBGP = new System.Windows.Forms.Button();
            this.WizCiscoVoz = new System.Windows.Forms.Button();
            this.WizCiscoMPLS = new System.Windows.Forms.Button();
            this.WizCiscoBLD = new System.Windows.Forms.Button();
            this.WizCiscoTitle = new System.Windows.Forms.Label();
            this.WizNokiaTitle = new System.Windows.Forms.Label();
            this.WizNokiaBLDcBGP = new System.Windows.Forms.Button();
            this.WizNokiaVoz = new System.Windows.Forms.Button();
            this.WizNokiaMPLS = new System.Windows.Forms.Button();
            this.WizNokiaBLD = new System.Windows.Forms.Button();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.Logs_WizGat = new System.Windows.Forms.Button();
            this.Logs_VOZ_Broadsoft = new System.Windows.Forms.Button();
            this.Logs_VOZ_Digistar = new System.Windows.Forms.Button();
            this.Logs_VOZ_HPE = new System.Windows.Forms.Button();
            this.Logs_VOZ_Cisco = new System.Windows.Forms.Button();
            this.Logs_MPLS_Huawei = new System.Windows.Forms.Button();
            this.Logs_Ligacao = new System.Windows.Forms.Button();
            this.Logs_BLD_Huawei = new System.Windows.Forms.Button();
            this.Logs_MPLS_Fortigate = new System.Windows.Forms.Button();
            this.row6 = new System.Windows.Forms.PictureBox();
            this.Logs_SubTitle2 = new System.Windows.Forms.Label();
            this.Logs_BLD_Fortigate = new System.Windows.Forms.Button();
            this.Logs_Velo = new System.Windows.Forms.Button();
            this.Logs_SubTitle4 = new System.Windows.Forms.Label();
            this.Logs_SubTitle1 = new System.Windows.Forms.Label();
            this.Logs_SubTitle0 = new System.Windows.Forms.Label();
            this.Logs_HPE_MPLS = new System.Windows.Forms.Button();
            this.Logs_Cisco_MPLS = new System.Windows.Forms.Button();
            this.LogsRow1 = new System.Windows.Forms.PictureBox();
            this.LogsRow0 = new System.Windows.Forms.PictureBox();
            this.Logs_VOZ_Aligera = new System.Windows.Forms.Button();
            this.Logs_HPE_BLD = new System.Windows.Forms.Button();
            this.Logs_BackButton = new System.Windows.Forms.Button();
            this.Logs_Title = new System.Windows.Forms.Label();
            this.Logs_Cisco_BLD = new System.Windows.Forms.Button();
            this.tabVelocloud = new System.Windows.Forms.TabPage();
            this.veloDeleteButton4 = new System.Windows.Forms.Button();
            this.veloDeleteButton3 = new System.Windows.Forms.Button();
            this.veloDeleteButton2 = new System.Windows.Forms.Button();
            this.veloDeleteButton1 = new System.Windows.Forms.Button();
            this.veloDeleteButton0 = new System.Windows.Forms.Button();
            this.veloDeleteButton16 = new System.Windows.Forms.Button();
            this.veloDeleteButton15 = new System.Windows.Forms.Button();
            this.veloDeleteButton14 = new System.Windows.Forms.Button();
            this.veloDeleteButton13 = new System.Windows.Forms.Button();
            this.veloDeleteButton12 = new System.Windows.Forms.Button();
            this.veloDeleteButton11 = new System.Windows.Forms.Button();
            this.veloDeleteButton10 = new System.Windows.Forms.Button();
            this.veloDeleteButton9 = new System.Windows.Forms.Button();
            this.veloDeleteButton8 = new System.Windows.Forms.Button();
            this.veloDeleteButton7 = new System.Windows.Forms.Button();
            this.veloDeleteButton6 = new System.Windows.Forms.Button();
            this.veloDeleteButtonAll = new System.Windows.Forms.Button();
            this.veloDeleteButton5 = new System.Windows.Forms.Button();
            this.buttonSwitchVeloLog = new System.Windows.Forms.Button();
            this.labelVelocloudTitle = new System.Windows.Forms.Label();
            this.veloTextBox16 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle16 = new System.Windows.Forms.Label();
            this.veloTextBoxFinal = new System.Windows.Forms.TextBox();
            this.veloTextBox15 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle15 = new System.Windows.Forms.Label();
            this.veloTextBox14 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle14 = new System.Windows.Forms.Label();
            this.veloTextBox13 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle13 = new System.Windows.Forms.Label();
            this.veloTextBox12 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle12 = new System.Windows.Forms.Label();
            this.veloTextBox11 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle11 = new System.Windows.Forms.Label();
            this.veloTextBox10 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle10 = new System.Windows.Forms.Label();
            this.veloTextBox9 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle9 = new System.Windows.Forms.Label();
            this.veloTextBox8 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle8 = new System.Windows.Forms.Label();
            this.veloTextBox7 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle7 = new System.Windows.Forms.Label();
            this.veloTextBox6 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle6 = new System.Windows.Forms.Label();
            this.veloTextBox5 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle5 = new System.Windows.Forms.Label();
            this.veloTextBox4 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle4 = new System.Windows.Forms.Label();
            this.veloTextBox3 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle3 = new System.Windows.Forms.Label();
            this.veloTextBox2 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle2 = new System.Windows.Forms.Label();
            this.veloTextBox1 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle1 = new System.Windows.Forms.Label();
            this.veloTextBox0 = new System.Windows.Forms.TextBox();
            this.labelVeloSubtitle0 = new System.Windows.Forms.Label();
            this.HomeButton_Velo = new System.Windows.Forms.Button();
            this.BackButton_Velo = new System.Windows.Forms.Button();
            this.buttonVeloClear = new System.Windows.Forms.Button();
            this.buttonVeloCopie = new System.Windows.Forms.Button();
            this.tabLigacoes = new System.Windows.Forms.TabPage();
            this.Ligacoes_BHPE_Antigo = new System.Windows.Forms.Button();
            this.Ligacoes_BLogs = new System.Windows.Forms.Button();
            this.Ligacoes_BDigistar = new System.Windows.Forms.Button();
            this.Ligacoes_BCisco = new System.Windows.Forms.Button();
            this.Ligacoes_BHPE = new System.Windows.Forms.Button();
            this.Ligacoes_BDebug = new System.Windows.Forms.Button();
            this.Ligacoes_BAligera = new System.Windows.Forms.Button();
            this.Ligacoes_BExemplos = new System.Windows.Forms.Button();
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
            this.Ligacoes_TB5 = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle5 = new System.Windows.Forms.Label();
            this.Ligacoes_TB6 = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle6 = new System.Windows.Forms.Label();
            this.Ligacoes_TB4 = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle4 = new System.Windows.Forms.Label();
            this.Ligacoes_TB3 = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle3 = new System.Windows.Forms.Label();
            this.Ligacoes_TB2 = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle2 = new System.Windows.Forms.Label();
            this.Ligacoes_TB1 = new System.Windows.Forms.TextBox();
            this.Ligacoes_TBFinal = new System.Windows.Forms.TextBox();
            this.Ligacoes_SubTitle1 = new System.Windows.Forms.Label();
            this.tabRouters = new System.Windows.Forms.TabPage();
            this.tabLogTools = new System.Windows.Forms.TabPage();
            this.LogToolsCalc = new System.Windows.Forms.Button();
            this.LogToolsSuporte = new System.Windows.Forms.Button();
            this.LogToolsFechamento = new System.Windows.Forms.Button();
            this.LogToolsPendencia = new System.Windows.Forms.Button();
            this.tabControlLogTools = new System.Windows.Forms.TabControl();
            this.tabPendencia = new System.Windows.Forms.TabPage();
            this.Log_Copy = new System.Windows.Forms.Button();
            this.Log_Clear3 = new System.Windows.Forms.Button();
            this.Log_Clear2 = new System.Windows.Forms.Button();
            this.Log_Clear1 = new System.Windows.Forms.Button();
            this.Log_FinalTextBox = new System.Windows.Forms.TextBox();
            this.Log_CopyF = new System.Windows.Forms.Button();
            this.Log_ClearAll = new System.Windows.Forms.Button();
            this.Log_Format = new System.Windows.Forms.Button();
            this.Log_TextBox3 = new System.Windows.Forms.TextBox();
            this.Log_ProximosPassos = new System.Windows.Forms.Label();
            this.Log_TextBox2 = new System.Windows.Forms.TextBox();
            this.Log_StatusAtual = new System.Windows.Forms.Label();
            this.Log_TextBox1 = new System.Windows.Forms.TextBox();
            this.Log_StatusAnterior = new System.Windows.Forms.Label();
            this.tabSuporte = new System.Windows.Forms.TabPage();
            this.LTSup_buttonCopy = new System.Windows.Forms.Button();
            this.LTSup_buttonForm = new System.Windows.Forms.Button();
            this.LTSuporteFinalTextBox = new System.Windows.Forms.TextBox();
            this.ButtonLT_ClearCommand = new System.Windows.Forms.Button();
            this.ButtonLT_ResetCommand = new System.Windows.Forms.Button();
            this.LTSup_buttonClear = new System.Windows.Forms.Button();
            this.row4 = new System.Windows.Forms.PictureBox();
            this.ButtonLT_AdcCommand = new System.Windows.Forms.Button();
            this.LTSuporte_DescripTitle = new System.Windows.Forms.Label();
            this.LTSuporte_ComandoTitle = new System.Windows.Forms.Label();
            this.LogToolsSuporteTitle = new System.Windows.Forms.Label();
            this.LT_SuporteCom = new System.Windows.Forms.TextBox();
            this.LT_SuporteTitle = new System.Windows.Forms.TextBox();
            this.LTSup_buttonCopyF = new System.Windows.Forms.Button();
            this.tabFechamento = new System.Windows.Forms.TabPage();
            this.LTFechamento_CheckBox6 = new System.Windows.Forms.CheckBox();
            this.LTFechamento_ButtonCopy = new System.Windows.Forms.Button();
            this.LTFechamento_ButtonFormat = new System.Windows.Forms.Button();
            this.LTFechamento_ButtonClear2 = new System.Windows.Forms.Button();
            this.LTFechamento_ButtonClear1 = new System.Windows.Forms.Button();
            this.LTFechamento_CheckBox5 = new System.Windows.Forms.CheckBox();
            this.row3 = new System.Windows.Forms.PictureBox();
            this.LTFechamento_CheckBox3 = new System.Windows.Forms.CheckBox();
            this.LTFechamento_CheckBox1 = new System.Windows.Forms.CheckBox();
            this.ObservacaoTitle = new System.Windows.Forms.Label();
            this.LTFechamento_TextBoxObs = new System.Windows.Forms.TextBox();
            this.LTFechamento_ButtonClear = new System.Windows.Forms.Button();
            this.LTFechamento_CheckBox2 = new System.Windows.Forms.CheckBox();
            this.LTFechamento_BFormatCopy = new System.Windows.Forms.Button();
            this.LTFechamento_CheckBox0 = new System.Windows.Forms.CheckBox();
            this.LTFechamento_TextBox = new System.Windows.Forms.TextBox();
            this.LTFechamento_Title = new System.Windows.Forms.Label();
            this.LTFechamento_ContatoLabel = new System.Windows.Forms.Label();
            this.LTFechamento_ValidacaoText = new System.Windows.Forms.TextBox();
            this.tabCalculadoraDeIP = new System.Windows.Forms.TabPage();
            this.LTCalc_SubTitle = new System.Windows.Forms.Label();
            this.LTCalc_buttonCalc = new System.Windows.Forms.Button();
            this.LTCalc_Hint = new System.Windows.Forms.Label();
            this.LTCalc_Title = new System.Windows.Forms.Label();
            this.LTCalc_Result = new System.Windows.Forms.Label();
            this.LTCalc_IPTextBox = new System.Windows.Forms.TextBox();
            this.tabTroubleShoot = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_DarkMode = new System.Windows.Forms.Button();
            this.Button_EnableEdit = new System.Windows.Forms.Button();
            this.Teste_ClearDB = new System.Windows.Forms.Button();
            this.Teste_ClearF = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Script_VarTest = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Teste_Enter = new System.Windows.Forms.Button();
            this.Teste_In = new System.Windows.Forms.Button();
            this.Teste_out = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Teste_ScriptBanco = new System.Windows.Forms.TextBox();
            this.Teste_ScriptFinal = new System.Windows.Forms.TextBox();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label4 = new System.Windows.Forms.Label();
            tabControl3 = new System.Windows.Forms.TabControl();
            tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRouters)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMaster.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabSelectProcedure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabScript.SuspendLayout();
            this.tabSelectRouter.SuspendLayout();
            this.tabWizGat.SuspendLayout();
            this.tabLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogsRow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogsRow0)).BeginInit();
            this.tabVelocloud.SuspendLayout();
            this.tabLigacoes.SuspendLayout();
            this.tabRouters.SuspendLayout();
            this.tabLogTools.SuspendLayout();
            this.tabControlLogTools.SuspendLayout();
            this.tabPendencia.SuspendLayout();
            this.tabSuporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row4)).BeginInit();
            this.tabFechamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row3)).BeginInit();
            this.tabCalculadoraDeIP.SuspendLayout();
            this.tabTroubleShoot.SuspendLayout();
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
            tabControl3.Size = new System.Drawing.Size(1113, 523);
            tabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl3.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Button_IOS);
            this.tabPage1.Controls.Add(this.labelRouterInfo);
            this.tabPage1.Controls.Add(this.dataGridRouters);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1105, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Button_IOS
            // 
            this.Button_IOS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_IOS.Location = new System.Drawing.Point(914, 60);
            this.Button_IOS.Name = "Button_IOS";
            this.Button_IOS.Size = new System.Drawing.Size(135, 48);
            this.Button_IOS.TabIndex = 6;
            this.Button_IOS.Text = "IOS";
            this.Button_IOS.UseVisualStyleBackColor = true;
            // 
            // labelRouterInfo
            // 
            this.labelRouterInfo.AllowDrop = true;
            this.labelRouterInfo.AutoSize = true;
            this.labelRouterInfo.Location = new System.Drawing.Point(6, 19);
            this.labelRouterInfo.Name = "labelRouterInfo";
            this.labelRouterInfo.Size = new System.Drawing.Size(1235, 65);
            this.labelRouterInfo.TabIndex = 5;
            this.labelRouterInfo.Text = resources.GetString("labelRouterInfo.Text");
            // 
            // dataGridRouters
            // 
            this.dataGridRouters.AllowUserToAddRows = false;
            this.dataGridRouters.AllowUserToDeleteRows = false;
            this.dataGridRouters.Location = new System.Drawing.Point(0, 114);
            this.dataGridRouters.Name = "dataGridRouters";
            this.dataGridRouters.ReadOnly = true;
            this.dataGridRouters.Size = new System.Drawing.Size(1095, 384);
            this.dataGridRouters.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1105, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainTitle
            // 
            this.MainTitle.BackColor = System.Drawing.Color.Red;
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainTitle.Location = new System.Drawing.Point(3, 3);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(1113, 71);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "MasterSheet+";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1127, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel1.Text = "Test";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(824, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 85);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMaster);
            this.tabControl1.Controls.Add(this.tabRouters);
            this.tabControl1.Controls.Add(this.tabLogTools);
            this.tabControl1.Controls.Add(this.tabTroubleShoot);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 555);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // tabMaster
            // 
            this.tabMaster.Controls.Add(this.tabControl2);
            this.tabMaster.Controls.Add(this.MainTitle);
            this.tabMaster.Location = new System.Drawing.Point(4, 22);
            this.tabMaster.Name = "tabMaster";
            this.tabMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaster.Size = new System.Drawing.Size(1119, 529);
            this.tabMaster.TabIndex = 0;
            this.tabMaster.Text = "Home";
            this.tabMaster.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl2.Controls.Add(this.tabSelectProcedure);
            this.tabControl2.Controls.Add(this.tabScript);
            this.tabControl2.Controls.Add(this.tabSelectRouter);
            this.tabControl2.Controls.Add(this.ClientStepsPage);
            this.tabControl2.Controls.Add(this.tabWizGat);
            this.tabControl2.Controls.Add(this.tabLogs);
            this.tabControl2.Controls.Add(this.tabVelocloud);
            this.tabControl2.Controls.Add(this.tabLigacoes);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl2.Location = new System.Drawing.Point(3, 74);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1113, 452);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 0;
            // 
            // tabSelectProcedure
            // 
            this.tabSelectProcedure.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabSelectProcedure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabSelectProcedure.Controls.Add(this.CreatedLabel);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_QoS);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_IOSInstal);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_Balanceamento);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_EIGRP);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_GLBP);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_IPFlow);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_NTP);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_HSRP);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_VRRP);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_OSPF);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_RIP);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_User);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_DHCP);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_IPsecundario);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_RotaEstatica);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_Tacacs);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_SNMP);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_BlocPort);
            this.tabSelectProcedure.Controls.Add(this.buttonOC_VLAN);
            this.tabSelectProcedure.Controls.Add(this.WizGat_Open);
            this.tabSelectProcedure.Controls.Add(this.WizardGatLabel);
            this.tabSelectProcedure.Controls.Add(this.OutrasConfigs);
            this.tabSelectProcedure.Controls.Add(this.AllClients);
            this.tabSelectProcedure.Controls.Add(this.ClienteButton_Test4);
            this.tabSelectProcedure.Controls.Add(this.ClienteButton_Test3);
            this.tabSelectProcedure.Controls.Add(this.ClienteButton_Test2);
            this.tabSelectProcedure.Controls.Add(this.ClienteButton_Teste1);
            this.tabSelectProcedure.Controls.Add(this.Logs_Finais);
            this.tabSelectProcedure.Controls.Add(this.Logs_Iniciais);
            this.tabSelectProcedure.Controls.Add(this.ScriptsSubTitle);
            this.tabSelectProcedure.Controls.Add(this.LogsSubTitle);
            this.tabSelectProcedure.Controls.Add(this.ClientesSubTitle);
            this.tabSelectProcedure.Controls.Add(this.TemplatesLabel);
            this.tabSelectProcedure.Controls.Add(this.pictureBox2);
            this.tabSelectProcedure.Controls.Add(this.Version);
            this.tabSelectProcedure.Controls.Add(this.VOZ_Button);
            this.tabSelectProcedure.Controls.Add(this.pictureBox1);
            this.tabSelectProcedure.Controls.Add(this.MPLS_button);
            this.tabSelectProcedure.Controls.Add(this.BLD_button);
            this.tabSelectProcedure.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabSelectProcedure.Location = new System.Drawing.Point(4, 5);
            this.tabSelectProcedure.Name = "tabSelectProcedure";
            this.tabSelectProcedure.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectProcedure.Size = new System.Drawing.Size(1105, 443);
            this.tabSelectProcedure.TabIndex = 0;
            this.tabSelectProcedure.Text = "tabPage4";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(492, 415);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(326, 25);
            this.CreatedLabel.TabIndex = 43;
            this.CreatedLabel.Text = "Created by: Ricardo Thiago Firmino";
            // 
            // buttonOC_QoS
            // 
            this.buttonOC_QoS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_QoS.Location = new System.Drawing.Point(372, 259);
            this.buttonOC_QoS.Name = "buttonOC_QoS";
            this.buttonOC_QoS.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_QoS.TabIndex = 42;
            this.buttonOC_QoS.Text = "QOS";
            this.buttonOC_QoS.UseVisualStyleBackColor = true;
            this.buttonOC_QoS.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_IOSInstal
            // 
            this.buttonOC_IOSInstal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_IOSInstal.Location = new System.Drawing.Point(197, 370);
            this.buttonOC_IOSInstal.Name = "buttonOC_IOSInstal";
            this.buttonOC_IOSInstal.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_IOSInstal.TabIndex = 41;
            this.buttonOC_IOSInstal.Text = "Instalar IOS";
            this.buttonOC_IOSInstal.UseVisualStyleBackColor = true;
            this.buttonOC_IOSInstal.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_Balanceamento
            // 
            this.buttonOC_Balanceamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_Balanceamento.Location = new System.Drawing.Point(284, 370);
            this.buttonOC_Balanceamento.Name = "buttonOC_Balanceamento";
            this.buttonOC_Balanceamento.Size = new System.Drawing.Size(178, 40);
            this.buttonOC_Balanceamento.TabIndex = 40;
            this.buttonOC_Balanceamento.Text = "Balanceamento";
            this.buttonOC_Balanceamento.UseVisualStyleBackColor = true;
            this.buttonOC_Balanceamento.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_EIGRP
            // 
            this.buttonOC_EIGRP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_EIGRP.Location = new System.Drawing.Point(372, 332);
            this.buttonOC_EIGRP.Name = "buttonOC_EIGRP";
            this.buttonOC_EIGRP.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_EIGRP.TabIndex = 39;
            this.buttonOC_EIGRP.Text = "EIGRP";
            this.buttonOC_EIGRP.UseVisualStyleBackColor = true;
            this.buttonOC_EIGRP.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_GLBP
            // 
            this.buttonOC_GLBP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_GLBP.Location = new System.Drawing.Point(197, 332);
            this.buttonOC_GLBP.Name = "buttonOC_GLBP";
            this.buttonOC_GLBP.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_GLBP.TabIndex = 38;
            this.buttonOC_GLBP.Text = "GLBP";
            this.buttonOC_GLBP.UseVisualStyleBackColor = true;
            this.buttonOC_GLBP.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_IPFlow
            // 
            this.buttonOC_IPFlow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_IPFlow.Location = new System.Drawing.Point(110, 370);
            this.buttonOC_IPFlow.Name = "buttonOC_IPFlow";
            this.buttonOC_IPFlow.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_IPFlow.TabIndex = 37;
            this.buttonOC_IPFlow.Text = "IP FLOW";
            this.buttonOC_IPFlow.UseVisualStyleBackColor = true;
            this.buttonOC_IPFlow.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_NTP
            // 
            this.buttonOC_NTP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_NTP.Location = new System.Drawing.Point(197, 258);
            this.buttonOC_NTP.Name = "buttonOC_NTP";
            this.buttonOC_NTP.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_NTP.TabIndex = 36;
            this.buttonOC_NTP.Text = "NTP";
            this.buttonOC_NTP.UseVisualStyleBackColor = true;
            this.buttonOC_NTP.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_HSRP
            // 
            this.buttonOC_HSRP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_HSRP.Location = new System.Drawing.Point(284, 332);
            this.buttonOC_HSRP.Name = "buttonOC_HSRP";
            this.buttonOC_HSRP.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_HSRP.TabIndex = 35;
            this.buttonOC_HSRP.Text = "HSRP";
            this.buttonOC_HSRP.UseVisualStyleBackColor = true;
            this.buttonOC_HSRP.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_VRRP
            // 
            this.buttonOC_VRRP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_VRRP.Location = new System.Drawing.Point(110, 332);
            this.buttonOC_VRRP.Name = "buttonOC_VRRP";
            this.buttonOC_VRRP.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_VRRP.TabIndex = 34;
            this.buttonOC_VRRP.Text = "VRRP";
            this.buttonOC_VRRP.UseVisualStyleBackColor = true;
            this.buttonOC_VRRP.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_OSPF
            // 
            this.buttonOC_OSPF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_OSPF.Location = new System.Drawing.Point(23, 332);
            this.buttonOC_OSPF.Name = "buttonOC_OSPF";
            this.buttonOC_OSPF.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_OSPF.TabIndex = 33;
            this.buttonOC_OSPF.Text = "OSPF";
            this.buttonOC_OSPF.UseVisualStyleBackColor = true;
            this.buttonOC_OSPF.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_RIP
            // 
            this.buttonOC_RIP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_RIP.Location = new System.Drawing.Point(23, 369);
            this.buttonOC_RIP.Name = "buttonOC_RIP";
            this.buttonOC_RIP.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_RIP.TabIndex = 32;
            this.buttonOC_RIP.Text = "RIP";
            this.buttonOC_RIP.UseVisualStyleBackColor = true;
            this.buttonOC_RIP.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_User
            // 
            this.buttonOC_User.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_User.Location = new System.Drawing.Point(372, 294);
            this.buttonOC_User.Name = "buttonOC_User";
            this.buttonOC_User.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_User.TabIndex = 31;
            this.buttonOC_User.Text = "Usuário";
            this.buttonOC_User.UseVisualStyleBackColor = true;
            this.buttonOC_User.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_DHCP
            // 
            this.buttonOC_DHCP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_DHCP.Location = new System.Drawing.Point(284, 259);
            this.buttonOC_DHCP.Name = "buttonOC_DHCP";
            this.buttonOC_DHCP.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_DHCP.TabIndex = 30;
            this.buttonOC_DHCP.Text = "DHCP";
            this.buttonOC_DHCP.UseVisualStyleBackColor = true;
            this.buttonOC_DHCP.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_IPsecundario
            // 
            this.buttonOC_IPsecundario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_IPsecundario.Location = new System.Drawing.Point(197, 295);
            this.buttonOC_IPsecundario.Name = "buttonOC_IPsecundario";
            this.buttonOC_IPsecundario.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_IPsecundario.TabIndex = 29;
            this.buttonOC_IPsecundario.Text = "IP Secundario";
            this.buttonOC_IPsecundario.UseVisualStyleBackColor = true;
            this.buttonOC_IPsecundario.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_RotaEstatica
            // 
            this.buttonOC_RotaEstatica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_RotaEstatica.Location = new System.Drawing.Point(110, 295);
            this.buttonOC_RotaEstatica.Name = "buttonOC_RotaEstatica";
            this.buttonOC_RotaEstatica.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_RotaEstatica.TabIndex = 28;
            this.buttonOC_RotaEstatica.Text = "Rota Estática";
            this.buttonOC_RotaEstatica.UseVisualStyleBackColor = true;
            this.buttonOC_RotaEstatica.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_Tacacs
            // 
            this.buttonOC_Tacacs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_Tacacs.Location = new System.Drawing.Point(284, 294);
            this.buttonOC_Tacacs.Name = "buttonOC_Tacacs";
            this.buttonOC_Tacacs.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_Tacacs.TabIndex = 27;
            this.buttonOC_Tacacs.Text = "TACAC\'S";
            this.buttonOC_Tacacs.UseVisualStyleBackColor = true;
            this.buttonOC_Tacacs.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_SNMP
            // 
            this.buttonOC_SNMP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_SNMP.Location = new System.Drawing.Point(110, 258);
            this.buttonOC_SNMP.Name = "buttonOC_SNMP";
            this.buttonOC_SNMP.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_SNMP.TabIndex = 26;
            this.buttonOC_SNMP.Text = "SNMP";
            this.buttonOC_SNMP.UseVisualStyleBackColor = true;
            this.buttonOC_SNMP.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_BlocPort
            // 
            this.buttonOC_BlocPort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_BlocPort.Location = new System.Drawing.Point(23, 295);
            this.buttonOC_BlocPort.Name = "buttonOC_BlocPort";
            this.buttonOC_BlocPort.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_BlocPort.TabIndex = 25;
            this.buttonOC_BlocPort.Text = "Bloqueio de Porta";
            this.buttonOC_BlocPort.UseVisualStyleBackColor = true;
            this.buttonOC_BlocPort.Click += new System.EventHandler(this.NotImplemented);
            // 
            // buttonOC_VLAN
            // 
            this.buttonOC_VLAN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOC_VLAN.Location = new System.Drawing.Point(23, 258);
            this.buttonOC_VLAN.Name = "buttonOC_VLAN";
            this.buttonOC_VLAN.Size = new System.Drawing.Size(90, 40);
            this.buttonOC_VLAN.TabIndex = 24;
            this.buttonOC_VLAN.Text = "VLAN";
            this.buttonOC_VLAN.UseVisualStyleBackColor = true;
            this.buttonOC_VLAN.Click += new System.EventHandler(this.NotImplemented);
            // 
            // WizGat_Open
            // 
            this.WizGat_Open.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_Open.Location = new System.Drawing.Point(539, 265);
            this.WizGat_Open.Name = "WizGat_Open";
            this.WizGat_Open.Size = new System.Drawing.Size(150, 60);
            this.WizGat_Open.TabIndex = 23;
            this.WizGat_Open.Text = "Abrir";
            this.WizGat_Open.UseVisualStyleBackColor = true;
            this.WizGat_Open.Click += new System.EventHandler(this.WizGat_Open1);
            // 
            // WizardGatLabel
            // 
            this.WizardGatLabel.AutoSize = true;
            this.WizardGatLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.WizardGatLabel.Location = new System.Drawing.Point(564, 228);
            this.WizardGatLabel.Name = "WizardGatLabel";
            this.WizardGatLabel.Size = new System.Drawing.Size(106, 25);
            this.WizardGatLabel.TabIndex = 22;
            this.WizardGatLabel.Text = "WizardGat";
            // 
            // OutrasConfigs
            // 
            this.OutrasConfigs.AutoSize = true;
            this.OutrasConfigs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.OutrasConfigs.Location = new System.Drawing.Point(153, 228);
            this.OutrasConfigs.Name = "OutrasConfigs";
            this.OutrasConfigs.Size = new System.Drawing.Size(205, 25);
            this.OutrasConfigs.TabIndex = 21;
            this.OutrasConfigs.Text = "Outras Configurações";
            // 
            // AllClients
            // 
            this.AllClients.AutoSize = true;
            this.AllClients.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllClients.Location = new System.Drawing.Point(811, 239);
            this.AllClients.Name = "AllClients";
            this.AllClients.Size = new System.Drawing.Size(115, 17);
            this.AllClients.TabIndex = 20;
            this.AllClients.TabStop = true;
            this.AllClients.Text = "Outros Clientes...";
            this.AllClients.Click += new System.EventHandler(this.NotImplemented);
            // 
            // ClienteButton_Test4
            // 
            this.ClienteButton_Test4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteButton_Test4.Location = new System.Drawing.Point(939, 186);
            this.ClienteButton_Test4.Name = "ClienteButton_Test4";
            this.ClienteButton_Test4.Size = new System.Drawing.Size(140, 50);
            this.ClienteButton_Test4.TabIndex = 19;
            this.ClienteButton_Test4.Text = "Teste 4";
            this.ClienteButton_Test4.UseVisualStyleBackColor = true;
            this.ClienteButton_Test4.Click += new System.EventHandler(this.NotImplemented);
            // 
            // ClienteButton_Test3
            // 
            this.ClienteButton_Test3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteButton_Test3.Location = new System.Drawing.Point(804, 186);
            this.ClienteButton_Test3.Name = "ClienteButton_Test3";
            this.ClienteButton_Test3.Size = new System.Drawing.Size(140, 50);
            this.ClienteButton_Test3.TabIndex = 18;
            this.ClienteButton_Test3.Text = "Teste 3";
            this.ClienteButton_Test3.UseVisualStyleBackColor = true;
            this.ClienteButton_Test3.Click += new System.EventHandler(this.NotImplemented);
            // 
            // ClienteButton_Test2
            // 
            this.ClienteButton_Test2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteButton_Test2.Location = new System.Drawing.Point(939, 139);
            this.ClienteButton_Test2.Name = "ClienteButton_Test2";
            this.ClienteButton_Test2.Size = new System.Drawing.Size(140, 50);
            this.ClienteButton_Test2.TabIndex = 17;
            this.ClienteButton_Test2.Text = "Teste 2";
            this.ClienteButton_Test2.UseVisualStyleBackColor = true;
            this.ClienteButton_Test2.Click += new System.EventHandler(this.NotImplemented);
            // 
            // ClienteButton_Teste1
            // 
            this.ClienteButton_Teste1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteButton_Teste1.Location = new System.Drawing.Point(804, 139);
            this.ClienteButton_Teste1.Name = "ClienteButton_Teste1";
            this.ClienteButton_Teste1.Size = new System.Drawing.Size(140, 50);
            this.ClienteButton_Teste1.TabIndex = 16;
            this.ClienteButton_Teste1.Text = "Teste 1";
            this.ClienteButton_Teste1.UseVisualStyleBackColor = true;
            this.ClienteButton_Teste1.Click += new System.EventHandler(this.NotImplemented);
            // 
            // Logs_Finais
            // 
            this.Logs_Finais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Finais.Location = new System.Drawing.Point(618, 139);
            this.Logs_Finais.Name = "Logs_Finais";
            this.Logs_Finais.Size = new System.Drawing.Size(128, 60);
            this.Logs_Finais.TabIndex = 15;
            this.Logs_Finais.Text = "FINAIS";
            this.Logs_Finais.UseVisualStyleBackColor = true;
            this.Logs_Finais.Click += new System.EventHandler(this.Logs_Finais_Click);
            // 
            // Logs_Iniciais
            // 
            this.Logs_Iniciais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Iniciais.Location = new System.Drawing.Point(484, 139);
            this.Logs_Iniciais.Name = "Logs_Iniciais";
            this.Logs_Iniciais.Size = new System.Drawing.Size(128, 60);
            this.Logs_Iniciais.TabIndex = 14;
            this.Logs_Iniciais.Text = "INICIAIS";
            this.Logs_Iniciais.UseVisualStyleBackColor = true;
            this.Logs_Iniciais.Click += new System.EventHandler(this.Logs_Iniciais_Click);
            // 
            // ScriptsSubTitle
            // 
            this.ScriptsSubTitle.AutoSize = true;
            this.ScriptsSubTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ScriptsSubTitle.Location = new System.Drawing.Point(168, 106);
            this.ScriptsSubTitle.Name = "ScriptsSubTitle";
            this.ScriptsSubTitle.Size = new System.Drawing.Size(141, 25);
            this.ScriptsSubTitle.TabIndex = 13;
            this.ScriptsSubTitle.Text = "Configurações";
            // 
            // LogsSubTitle
            // 
            this.LogsSubTitle.AutoSize = true;
            this.LogsSubTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.LogsSubTitle.Location = new System.Drawing.Point(589, 106);
            this.LogsSubTitle.Name = "LogsSubTitle";
            this.LogsSubTitle.Size = new System.Drawing.Size(54, 25);
            this.LogsSubTitle.TabIndex = 12;
            this.LogsSubTitle.Text = "Logs";
            // 
            // ClientesSubTitle
            // 
            this.ClientesSubTitle.AutoSize = true;
            this.ClientesSubTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ClientesSubTitle.Location = new System.Drawing.Point(899, 106);
            this.ClientesSubTitle.Name = "ClientesSubTitle";
            this.ClientesSubTitle.Size = new System.Drawing.Size(81, 25);
            this.ClientesSubTitle.TabIndex = 11;
            this.ClientesSubTitle.Text = "Clientes";
            // 
            // TemplatesLabel
            // 
            this.TemplatesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TemplatesLabel.AutoSize = true;
            this.TemplatesLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TemplatesLabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TemplatesLabel.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplatesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TemplatesLabel.Location = new System.Drawing.Point(465, 22);
            this.TemplatesLabel.Name = "TemplatesLabel";
            this.TemplatesLabel.Size = new System.Drawing.Size(171, 45);
            this.TemplatesLabel.TabIndex = 10;
            this.TemplatesLabel.Text = "Templates";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1099, 81);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Version
            // 
            this.Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Version.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(3, 425);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(91, 15);
            this.Version.TabIndex = 7;
            this.Version.Text = "Versão: 1.4.3";
            this.Version.Click += new System.EventHandler(this.Version_Click);
            // 
            // VOZ_Button
            // 
            this.VOZ_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VOZ_Button.Location = new System.Drawing.Point(299, 141);
            this.VOZ_Button.Name = "VOZ_Button";
            this.VOZ_Button.Size = new System.Drawing.Size(120, 55);
            this.VOZ_Button.TabIndex = 2;
            this.VOZ_Button.Text = "VOZ";
            this.VOZ_Button.UseVisualStyleBackColor = true;
            this.VOZ_Button.Click += new System.EventHandler(this.NotImplemented);
            // 
            // MPLS_button
            // 
            this.MPLS_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPLS_button.Location = new System.Drawing.Point(173, 141);
            this.MPLS_button.Name = "MPLS_button";
            this.MPLS_button.Size = new System.Drawing.Size(120, 55);
            this.MPLS_button.TabIndex = 1;
            this.MPLS_button.Text = "MPLS";
            this.MPLS_button.UseVisualStyleBackColor = true;
            this.MPLS_button.Click += new System.EventHandler(this.MPLS_button_Click);
            // 
            // BLD_button
            // 
            this.BLD_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLD_button.Location = new System.Drawing.Point(47, 141);
            this.BLD_button.Name = "BLD_button";
            this.BLD_button.Size = new System.Drawing.Size(120, 55);
            this.BLD_button.TabIndex = 3;
            this.BLD_button.Text = "BLD";
            this.BLD_button.UseVisualStyleBackColor = true;
            this.BLD_button.Click += new System.EventHandler(this.BLD_button_Click);
            // 
            // tabScript
            // 
            this.tabScript.AutoScroll = true;
            this.tabScript.AutoScrollMinSize = new System.Drawing.Size(0, 100);
            this.tabScript.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabScript.Controls.Add(this.Script_TextBox);
            this.tabScript.Controls.Add(this.Script_ExLabel);
            this.tabScript.Controls.Add(this.Script_VarEx13);
            this.tabScript.Controls.Add(this.Script_VarEx14);
            this.tabScript.Controls.Add(this.Script_VarEx15);
            this.tabScript.Controls.Add(this.Script_VarEx12);
            this.tabScript.Controls.Add(this.Script_VarEx11);
            this.tabScript.Controls.Add(this.Script_VarEx10);
            this.tabScript.Controls.Add(this.Script_VarEx9);
            this.tabScript.Controls.Add(this.Script_VarEx8);
            this.tabScript.Controls.Add(this.Script_VarEx7);
            this.tabScript.Controls.Add(this.Script_VarEx6);
            this.tabScript.Controls.Add(this.Script_VarEx5);
            this.tabScript.Controls.Add(this.Script_VarEx4);
            this.tabScript.Controls.Add(this.Script_VarEx3);
            this.tabScript.Controls.Add(this.Script_VarEx2);
            this.tabScript.Controls.Add(this.Script_VarEx1);
            this.tabScript.Controls.Add(this.Script_VarEx0);
            this.tabScript.Controls.Add(this.Script_DeleteVar15);
            this.tabScript.Controls.Add(this.Script_Var15);
            this.tabScript.Controls.Add(this.Script_VarName15);
            this.tabScript.Controls.Add(this.Script_DeleteVar14);
            this.tabScript.Controls.Add(this.Script_Var14);
            this.tabScript.Controls.Add(this.Script_VarName14);
            this.tabScript.Controls.Add(this.Script_DeleteVar13);
            this.tabScript.Controls.Add(this.Script_Var13);
            this.tabScript.Controls.Add(this.Script_VarName13);
            this.tabScript.Controls.Add(this.Script_DeleteVar12);
            this.tabScript.Controls.Add(this.Script_Var12);
            this.tabScript.Controls.Add(this.Script_VarName12);
            this.tabScript.Controls.Add(this.Script_DeleteRouteE2);
            this.tabScript.Controls.Add(this.Script_VarRouteE2Label);
            this.tabScript.Controls.Add(this.Script_VarRouteE2);
            this.tabScript.Controls.Add(this.Script_DeleteRouteE1);
            this.tabScript.Controls.Add(this.Script_VarRouteE1Label);
            this.tabScript.Controls.Add(this.Script_VarRouteE1);
            this.tabScript.Controls.Add(this.Script_DeleteRouteI2);
            this.tabScript.Controls.Add(this.Script_VarRouteI2Label);
            this.tabScript.Controls.Add(this.Script_VarRouteI2);
            this.tabScript.Controls.Add(this.Script_DeleteRouteI1);
            this.tabScript.Controls.Add(this.Script_VarRouteI1Label);
            this.tabScript.Controls.Add(this.Script_VarRouteI1);
            this.tabScript.Controls.Add(this.Script_RouteLabelHint);
            this.tabScript.Controls.Add(this.Script_XRLabel);
            this.tabScript.Controls.Add(this.Script_XRBox);
            this.tabScript.Controls.Add(this.Button_FormatarECopiarScript);
            this.tabScript.Controls.Add(this.Script_DeleteVar11);
            this.tabScript.Controls.Add(this.Script_DeleteVar10);
            this.tabScript.Controls.Add(this.Script_DeleteVar9);
            this.tabScript.Controls.Add(this.Script_DeleteVar8);
            this.tabScript.Controls.Add(this.Script_DeleteVar7);
            this.tabScript.Controls.Add(this.Script_DeleteVar6);
            this.tabScript.Controls.Add(this.Script_DeleteVar5);
            this.tabScript.Controls.Add(this.Script_DeleteVar4);
            this.tabScript.Controls.Add(this.Script_DeleteVar3);
            this.tabScript.Controls.Add(this.Script_DeleteVar2);
            this.tabScript.Controls.Add(this.Script_DeleteVar1);
            this.tabScript.Controls.Add(this.Script_DeleteVar0);
            this.tabScript.Controls.Add(this.Script_ISRBox);
            this.tabScript.Controls.Add(this.Script_ISRLabel);
            this.tabScript.Controls.Add(this.Script_ModelLabel);
            this.tabScript.Controls.Add(this.Script_FortigateModel);
            this.tabScript.Controls.Add(this.hint1);
            this.tabScript.Controls.Add(this.CopyButton);
            this.tabScript.Controls.Add(this.Script_Var11);
            this.tabScript.Controls.Add(this.Script_VarName11);
            this.tabScript.Controls.Add(this.Script_Var10);
            this.tabScript.Controls.Add(this.Script_VarName10);
            this.tabScript.Controls.Add(this.buttonSwitchScriptLog);
            this.tabScript.Controls.Add(this.ButtonLimpeza);
            this.tabScript.Controls.Add(this.ButtonParte2);
            this.tabScript.Controls.Add(this.Script_Var9);
            this.tabScript.Controls.Add(this.Script_VarName9);
            this.tabScript.Controls.Add(this.Script_Var8);
            this.tabScript.Controls.Add(this.Script_VarName8);
            this.tabScript.Controls.Add(this.Script_Var7);
            this.tabScript.Controls.Add(this.Script_VarName7);
            this.tabScript.Controls.Add(this.Script_LANMascara);
            this.tabScript.Controls.Add(this.BackButton_Script3);
            this.tabScript.Controls.Add(this.BackButton_Script2);
            this.tabScript.Controls.Add(this.Script_TypeLabel);
            this.tabScript.Controls.Add(this.Button_FormatarScript);
            this.tabScript.Controls.Add(this.BackButton_Script);
            this.tabScript.Controls.Add(this.Script_ComboBox);
            this.tabScript.Controls.Add(this.Script_Var6);
            this.tabScript.Controls.Add(this.Script_VarName6);
            this.tabScript.Controls.Add(this.ClearButton);
            this.tabScript.Controls.Add(this.VarText);
            this.tabScript.Controls.Add(this.Script_Var5);
            this.tabScript.Controls.Add(this.Script_Var4);
            this.tabScript.Controls.Add(this.Script_Var3);
            this.tabScript.Controls.Add(this.Script_Var2);
            this.tabScript.Controls.Add(this.Script_Var1);
            this.tabScript.Controls.Add(this.Script_VarName5);
            this.tabScript.Controls.Add(this.Script_VarName3);
            this.tabScript.Controls.Add(this.Script_VarName4);
            this.tabScript.Controls.Add(this.Script_VarName2);
            this.tabScript.Controls.Add(this.Script_VarName1);
            this.tabScript.Controls.Add(this.ProcedureName);
            this.tabScript.Controls.Add(this.HomeButton_Script);
            this.tabScript.Controls.Add(this.Script_LabelScript);
            this.tabScript.Controls.Add(this.Script_VarName0);
            this.tabScript.Controls.Add(this.Script_Var0);
            this.tabScript.Location = new System.Drawing.Point(4, 5);
            this.tabScript.Margin = new System.Windows.Forms.Padding(86, 87, 86, 87);
            this.tabScript.Name = "tabScript";
            this.tabScript.Padding = new System.Windows.Forms.Padding(3);
            this.tabScript.Size = new System.Drawing.Size(1105, 443);
            this.tabScript.TabIndex = 1;
            this.tabScript.Text = "tabPage5";
            // 
            // Script_TextBox
            // 
            this.Script_TextBox.Location = new System.Drawing.Point(488, 120);
            this.Script_TextBox.Name = "Script_TextBox";
            this.Script_TextBox.Size = new System.Drawing.Size(315, 356);
            this.Script_TextBox.TabIndex = 116;
            this.Script_TextBox.Text = "";
            // 
            // Script_ExLabel
            // 
            this.Script_ExLabel.AutoSize = true;
            this.Script_ExLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_ExLabel.Location = new System.Drawing.Point(349, 79);
            this.Script_ExLabel.Name = "Script_ExLabel";
            this.Script_ExLabel.Size = new System.Drawing.Size(77, 20);
            this.Script_ExLabel.TabIndex = 115;
            this.Script_ExLabel.Text = "Exemplos:";
            // 
            // Script_VarEx13
            // 
            this.Script_VarEx13.AutoSize = true;
            this.Script_VarEx13.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx13.Location = new System.Drawing.Point(349, 514);
            this.Script_VarEx13.Name = "Script_VarEx13";
            this.Script_VarEx13.Size = new System.Drawing.Size(36, 17);
            this.Script_VarEx13.TabIndex = 114;
            this.Script_VarEx13.Text = "1001";
            // 
            // Script_VarEx14
            // 
            this.Script_VarEx14.AutoSize = true;
            this.Script_VarEx14.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx14.Location = new System.Drawing.Point(349, 542);
            this.Script_VarEx14.Name = "Script_VarEx14";
            this.Script_VarEx14.Size = new System.Drawing.Size(90, 17);
            this.Script_VarEx14.TabIndex = 113;
            this.Script_VarEx14.Text = "NomeVRF:123";
            // 
            // Script_VarEx15
            // 
            this.Script_VarEx15.AutoSize = true;
            this.Script_VarEx15.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx15.Location = new System.Drawing.Point(349, 573);
            this.Script_VarEx15.Name = "Script_VarEx15";
            this.Script_VarEx15.Size = new System.Drawing.Size(43, 17);
            this.Script_VarEx15.TabIndex = 112;
            this.Script_VarEx15.Text = "10921";
            // 
            // Script_VarEx12
            // 
            this.Script_VarEx12.AutoSize = true;
            this.Script_VarEx12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx12.Location = new System.Drawing.Point(349, 484);
            this.Script_VarEx12.Name = "Script_VarEx12";
            this.Script_VarEx12.Size = new System.Drawing.Size(43, 17);
            this.Script_VarEx12.TabIndex = 111;
            this.Script_VarEx12.Text = "65000";
            // 
            // Script_VarEx11
            // 
            this.Script_VarEx11.AutoSize = true;
            this.Script_VarEx11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx11.Location = new System.Drawing.Point(349, 454);
            this.Script_VarEx11.Name = "Script_VarEx11";
            this.Script_VarEx11.Size = new System.Drawing.Size(73, 17);
            this.Script_VarEx11.TabIndex = 110;
            this.Script_VarEx11.Text = "21.21.21.21";
            // 
            // Script_VarEx10
            // 
            this.Script_VarEx10.AutoSize = true;
            this.Script_VarEx10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx10.Location = new System.Drawing.Point(349, 424);
            this.Script_VarEx10.Name = "Script_VarEx10";
            this.Script_VarEx10.Size = new System.Drawing.Size(59, 17);
            this.Script_VarEx10.TabIndex = 109;
            this.Script_VarEx10.Text = "201.1.1.1";
            // 
            // Script_VarEx9
            // 
            this.Script_VarEx9.AutoSize = true;
            this.Script_VarEx9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx9.Location = new System.Drawing.Point(349, 394);
            this.Script_VarEx9.Name = "Script_VarEx9";
            this.Script_VarEx9.Size = new System.Drawing.Size(59, 17);
            this.Script_VarEx9.TabIndex = 108;
            this.Script_VarEx9.Text = "201.1.1.1";
            // 
            // Script_VarEx8
            // 
            this.Script_VarEx8.AutoSize = true;
            this.Script_VarEx8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx8.Location = new System.Drawing.Point(349, 363);
            this.Script_VarEx8.Name = "Script_VarEx8";
            this.Script_VarEx8.Size = new System.Drawing.Size(59, 17);
            this.Script_VarEx8.TabIndex = 107;
            this.Script_VarEx8.Text = "201.2.2.2";
            // 
            // Script_VarEx7
            // 
            this.Script_VarEx7.AutoSize = true;
            this.Script_VarEx7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx7.Location = new System.Drawing.Point(349, 331);
            this.Script_VarEx7.Name = "Script_VarEx7";
            this.Script_VarEx7.Size = new System.Drawing.Size(59, 17);
            this.Script_VarEx7.TabIndex = 106;
            this.Script_VarEx7.Text = "201.2.2.1";
            // 
            // Script_VarEx6
            // 
            this.Script_VarEx6.AutoSize = true;
            this.Script_VarEx6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx6.Location = new System.Drawing.Point(349, 303);
            this.Script_VarEx6.Name = "Script_VarEx6";
            this.Script_VarEx6.Size = new System.Drawing.Size(119, 17);
            this.Script_VarEx6.TabIndex = 105;
            this.Script_VarEx6.Text = "GigaEthernet0/1.12";
            // 
            // Script_VarEx5
            // 
            this.Script_VarEx5.AutoSize = true;
            this.Script_VarEx5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx5.Location = new System.Drawing.Point(349, 273);
            this.Script_VarEx5.Name = "Script_VarEx5";
            this.Script_VarEx5.Size = new System.Drawing.Size(102, 17);
            this.Script_VarEx5.TabIndex = 104;
            this.Script_VarEx5.Text = "GigaEthernet0/1";
            // 
            // Script_VarEx4
            // 
            this.Script_VarEx4.AutoSize = true;
            this.Script_VarEx4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx4.Location = new System.Drawing.Point(350, 242);
            this.Script_VarEx4.Name = "Script_VarEx4";
            this.Script_VarEx4.Size = new System.Drawing.Size(22, 17);
            this.Script_VarEx4.TabIndex = 103;
            this.Script_VarEx4.Text = "21";
            // 
            // Script_VarEx3
            // 
            this.Script_VarEx3.AutoSize = true;
            this.Script_VarEx3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx3.Location = new System.Drawing.Point(349, 214);
            this.Script_VarEx3.Name = "Script_VarEx3";
            this.Script_VarEx3.Size = new System.Drawing.Size(102, 17);
            this.Script_VarEx3.TabIndex = 102;
            this.Script_VarEx3.Text = "GigaEthernet0/0";
            // 
            // Script_VarEx2
            // 
            this.Script_VarEx2.AutoSize = true;
            this.Script_VarEx2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx2.Location = new System.Drawing.Point(349, 183);
            this.Script_VarEx2.Name = "Script_VarEx2";
            this.Script_VarEx2.Size = new System.Drawing.Size(43, 17);
            this.Script_VarEx2.TabIndex = 101;
            this.Script_VarEx2.Text = "50000";
            // 
            // Script_VarEx1
            // 
            this.Script_VarEx1.AutoSize = true;
            this.Script_VarEx1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarEx1.Location = new System.Drawing.Point(349, 152);
            this.Script_VarEx1.Name = "Script_VarEx1";
            this.Script_VarEx1.Size = new System.Drawing.Size(111, 17);
            this.Script_VarEx1.TabIndex = 100;
            this.Script_VarEx1.Text = "Description (SAIP)";
            // 
            // Script_VarEx0
            // 
            this.Script_VarEx0.AutoSize = true;
            this.Script_VarEx0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarEx0.Location = new System.Drawing.Point(349, 122);
            this.Script_VarEx0.Name = "Script_VarEx0";
            this.Script_VarEx0.Size = new System.Drawing.Size(65, 17);
            this.Script_VarEx0.TabIndex = 99;
            this.Script_VarEx0.Text = "Teste_BLD";
            // 
            // Script_DeleteVar15
            // 
            this.Script_DeleteVar15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar15.Location = new System.Drawing.Point(318, 567);
            this.Script_DeleteVar15.Name = "Script_DeleteVar15";
            this.Script_DeleteVar15.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar15.TabIndex = 98;
            this.Script_DeleteVar15.Text = "-";
            this.Script_DeleteVar15.UseVisualStyleBackColor = true;
            this.Script_DeleteVar15.Click += new System.EventHandler(this.Script_DeleteVar15_Click);
            // 
            // Script_Var15
            // 
            this.Script_Var15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var15.Location = new System.Drawing.Point(151, 567);
            this.Script_Var15.Name = "Script_Var15";
            this.Script_Var15.Size = new System.Drawing.Size(161, 25);
            this.Script_Var15.TabIndex = 97;
            this.Script_Var15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_VarName15
            // 
            this.Script_VarName15.AutoSize = true;
            this.Script_VarName15.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName15.Location = new System.Drawing.Point(24, 445);
            this.Script_VarName15.Name = "Script_VarName15";
            this.Script_VarName15.Size = new System.Drawing.Size(68, 17);
            this.Script_VarName15.TabIndex = 96;
            this.Script_VarName15.Text = "Service ID:";
            // 
            // Script_DeleteVar14
            // 
            this.Script_DeleteVar14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar14.Location = new System.Drawing.Point(318, 536);
            this.Script_DeleteVar14.Name = "Script_DeleteVar14";
            this.Script_DeleteVar14.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar14.TabIndex = 95;
            this.Script_DeleteVar14.Text = "-";
            this.Script_DeleteVar14.UseVisualStyleBackColor = true;
            this.Script_DeleteVar14.Click += new System.EventHandler(this.Script_DeleteVar14_Click);
            // 
            // Script_Var14
            // 
            this.Script_Var14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var14.Location = new System.Drawing.Point(151, 536);
            this.Script_Var14.Name = "Script_Var14";
            this.Script_Var14.Size = new System.Drawing.Size(161, 25);
            this.Script_Var14.TabIndex = 94;
            this.Script_Var14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_VarName14
            // 
            this.Script_VarName14.AutoSize = true;
            this.Script_VarName14.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName14.Location = new System.Drawing.Point(23, 541);
            this.Script_VarName14.Name = "Script_VarName14";
            this.Script_VarName14.Size = new System.Drawing.Size(92, 17);
            this.Script_VarName14.TabIndex = 93;
            this.Script_VarName14.Text = "Nome da VRF:";
            // 
            // Script_DeleteVar13
            // 
            this.Script_DeleteVar13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar13.Location = new System.Drawing.Point(318, 506);
            this.Script_DeleteVar13.Name = "Script_DeleteVar13";
            this.Script_DeleteVar13.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar13.TabIndex = 92;
            this.Script_DeleteVar13.Text = "-";
            this.Script_DeleteVar13.UseVisualStyleBackColor = true;
            this.Script_DeleteVar13.Click += new System.EventHandler(this.Script_DeleteVar13_Click);
            // 
            // Script_Var13
            // 
            this.Script_Var13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var13.Location = new System.Drawing.Point(151, 506);
            this.Script_Var13.Name = "Script_Var13";
            this.Script_Var13.Size = new System.Drawing.Size(161, 25);
            this.Script_Var13.TabIndex = 91;
            this.Script_Var13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_VarName13
            // 
            this.Script_VarName13.AutoSize = true;
            this.Script_VarName13.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName13.Location = new System.Drawing.Point(23, 511);
            this.Script_VarName13.Name = "Script_VarName13";
            this.Script_VarName13.Size = new System.Drawing.Size(52, 17);
            this.Script_VarName13.TabIndex = 90;
            this.Script_VarName13.Text = "QoS ID:";
            // 
            // Script_DeleteVar12
            // 
            this.Script_DeleteVar12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar12.Location = new System.Drawing.Point(318, 476);
            this.Script_DeleteVar12.Name = "Script_DeleteVar12";
            this.Script_DeleteVar12.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar12.TabIndex = 89;
            this.Script_DeleteVar12.Text = "-";
            this.Script_DeleteVar12.UseVisualStyleBackColor = true;
            this.Script_DeleteVar12.Click += new System.EventHandler(this.Script_DeleteVar12_Click);
            // 
            // Script_Var12
            // 
            this.Script_Var12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var12.Location = new System.Drawing.Point(151, 476);
            this.Script_Var12.Name = "Script_Var12";
            this.Script_Var12.Size = new System.Drawing.Size(161, 25);
            this.Script_Var12.TabIndex = 88;
            this.Script_Var12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_VarName12
            // 
            this.Script_VarName12.AutoSize = true;
            this.Script_VarName12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName12.Location = new System.Drawing.Point(23, 481);
            this.Script_VarName12.Name = "Script_VarName12";
            this.Script_VarName12.Size = new System.Drawing.Size(73, 17);
            this.Script_VarName12.TabIndex = 87;
            this.Script_VarName12.Text = "AS do BGP:";
            // 
            // Script_DeleteRouteE2
            // 
            this.Script_DeleteRouteE2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteRouteE2.Location = new System.Drawing.Point(1060, 414);
            this.Script_DeleteRouteE2.Name = "Script_DeleteRouteE2";
            this.Script_DeleteRouteE2.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteRouteE2.TabIndex = 86;
            this.Script_DeleteRouteE2.Text = "-";
            this.Script_DeleteRouteE2.UseVisualStyleBackColor = true;
            this.Script_DeleteRouteE2.Click += new System.EventHandler(this.Script_DeleteRouteE2_Click);
            // 
            // Script_VarRouteE2Label
            // 
            this.Script_VarRouteE2Label.AutoSize = true;
            this.Script_VarRouteE2Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteE2Label.Location = new System.Drawing.Point(818, 393);
            this.Script_VarRouteE2Label.Name = "Script_VarRouteE2Label";
            this.Script_VarRouteE2Label.Size = new System.Drawing.Size(129, 17);
            this.Script_VarRouteE2Label.TabIndex = 85;
            this.Script_VarRouteE2Label.Text = "Route-map export 2:";
            // 
            // Script_VarRouteE2
            // 
            this.Script_VarRouteE2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteE2.Location = new System.Drawing.Point(821, 413);
            this.Script_VarRouteE2.Name = "Script_VarRouteE2";
            this.Script_VarRouteE2.Size = new System.Drawing.Size(233, 20);
            this.Script_VarRouteE2.TabIndex = 84;
            this.Script_VarRouteE2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_DeleteRouteE1
            // 
            this.Script_DeleteRouteE1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteRouteE1.Location = new System.Drawing.Point(1061, 361);
            this.Script_DeleteRouteE1.Name = "Script_DeleteRouteE1";
            this.Script_DeleteRouteE1.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteRouteE1.TabIndex = 83;
            this.Script_DeleteRouteE1.Text = "-";
            this.Script_DeleteRouteE1.UseVisualStyleBackColor = true;
            this.Script_DeleteRouteE1.Click += new System.EventHandler(this.Script_DeleteRouteE1_Click);
            // 
            // Script_VarRouteE1Label
            // 
            this.Script_VarRouteE1Label.AutoSize = true;
            this.Script_VarRouteE1Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteE1Label.Location = new System.Drawing.Point(819, 341);
            this.Script_VarRouteE1Label.Name = "Script_VarRouteE1Label";
            this.Script_VarRouteE1Label.Size = new System.Drawing.Size(129, 17);
            this.Script_VarRouteE1Label.TabIndex = 82;
            this.Script_VarRouteE1Label.Text = "Route-map export 1:";
            // 
            // Script_VarRouteE1
            // 
            this.Script_VarRouteE1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteE1.Location = new System.Drawing.Point(822, 360);
            this.Script_VarRouteE1.Name = "Script_VarRouteE1";
            this.Script_VarRouteE1.Size = new System.Drawing.Size(233, 20);
            this.Script_VarRouteE1.TabIndex = 81;
            this.Script_VarRouteE1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_DeleteRouteI2
            // 
            this.Script_DeleteRouteI2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteRouteI2.Location = new System.Drawing.Point(1061, 307);
            this.Script_DeleteRouteI2.Name = "Script_DeleteRouteI2";
            this.Script_DeleteRouteI2.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteRouteI2.TabIndex = 80;
            this.Script_DeleteRouteI2.Text = "-";
            this.Script_DeleteRouteI2.UseVisualStyleBackColor = true;
            this.Script_DeleteRouteI2.Click += new System.EventHandler(this.Script_DeleteRouteI2_Click);
            // 
            // Script_VarRouteI2Label
            // 
            this.Script_VarRouteI2Label.AutoSize = true;
            this.Script_VarRouteI2Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteI2Label.Location = new System.Drawing.Point(818, 289);
            this.Script_VarRouteI2Label.Name = "Script_VarRouteI2Label";
            this.Script_VarRouteI2Label.Size = new System.Drawing.Size(130, 17);
            this.Script_VarRouteI2Label.TabIndex = 79;
            this.Script_VarRouteI2Label.Text = "Route-map import 2:";
            // 
            // Script_VarRouteI2
            // 
            this.Script_VarRouteI2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteI2.Location = new System.Drawing.Point(822, 306);
            this.Script_VarRouteI2.Name = "Script_VarRouteI2";
            this.Script_VarRouteI2.Size = new System.Drawing.Size(233, 20);
            this.Script_VarRouteI2.TabIndex = 78;
            this.Script_VarRouteI2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_DeleteRouteI1
            // 
            this.Script_DeleteRouteI1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteRouteI1.Location = new System.Drawing.Point(1061, 255);
            this.Script_DeleteRouteI1.Name = "Script_DeleteRouteI1";
            this.Script_DeleteRouteI1.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteRouteI1.TabIndex = 77;
            this.Script_DeleteRouteI1.Text = "-";
            this.Script_DeleteRouteI1.UseVisualStyleBackColor = true;
            this.Script_DeleteRouteI1.Click += new System.EventHandler(this.Script_DeleteRouteI1_Click);
            // 
            // Script_VarRouteI1Label
            // 
            this.Script_VarRouteI1Label.AutoSize = true;
            this.Script_VarRouteI1Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteI1Label.Location = new System.Drawing.Point(818, 235);
            this.Script_VarRouteI1Label.Name = "Script_VarRouteI1Label";
            this.Script_VarRouteI1Label.Size = new System.Drawing.Size(130, 17);
            this.Script_VarRouteI1Label.TabIndex = 76;
            this.Script_VarRouteI1Label.Text = "Route-map import 1:";
            // 
            // Script_VarRouteI1
            // 
            this.Script_VarRouteI1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarRouteI1.Location = new System.Drawing.Point(821, 255);
            this.Script_VarRouteI1.Name = "Script_VarRouteI1";
            this.Script_VarRouteI1.Size = new System.Drawing.Size(233, 20);
            this.Script_VarRouteI1.TabIndex = 75;
            this.Script_VarRouteI1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_RouteLabelHint
            // 
            this.Script_RouteLabelHint.AutoSize = true;
            this.Script_RouteLabelHint.Location = new System.Drawing.Point(832, 219);
            this.Script_RouteLabelHint.Name = "Script_RouteLabelHint";
            this.Script_RouteLabelHint.Size = new System.Drawing.Size(252, 13);
            this.Script_RouteLabelHint.TabIndex = 74;
            this.Script_RouteLabelHint.Text = "Valores de Route-map estão no 1 comando de BGP";
            this.Script_RouteLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Script_XRLabel
            // 
            this.Script_XRLabel.AutoSize = true;
            this.Script_XRLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_XRLabel.Location = new System.Drawing.Point(945, 152);
            this.Script_XRLabel.Name = "Script_XRLabel";
            this.Script_XRLabel.Size = new System.Drawing.Size(71, 17);
            this.Script_XRLabel.TabIndex = 73;
            this.Script_XRLabel.Text = "Tipo de PE";
            // 
            // Script_XRBox
            // 
            this.Script_XRBox.FormattingEnabled = true;
            this.Script_XRBox.Items.AddRange(new object[] {
            "IACC / GACC",
            "AGG / ACR / UACC"});
            this.Script_XRBox.Location = new System.Drawing.Point(948, 172);
            this.Script_XRBox.Name = "Script_XRBox";
            this.Script_XRBox.Size = new System.Drawing.Size(104, 21);
            this.Script_XRBox.TabIndex = 72;
            this.Script_XRBox.SelectedIndexChanged += new System.EventHandler(this.Script_XRBox_SelectedIndexChanged);
            // 
            // Button_FormatarECopiarScript
            // 
            this.Button_FormatarECopiarScript.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FormatarECopiarScript.Location = new System.Drawing.Point(809, 74);
            this.Button_FormatarECopiarScript.Name = "Button_FormatarECopiarScript";
            this.Button_FormatarECopiarScript.Size = new System.Drawing.Size(104, 52);
            this.Button_FormatarECopiarScript.TabIndex = 71;
            this.Button_FormatarECopiarScript.Text = "Copiar e Formatar";
            this.Button_FormatarECopiarScript.UseVisualStyleBackColor = true;
            this.Button_FormatarECopiarScript.Click += new System.EventHandler(this.Button_FormatarECopiarScript_Click);
            // 
            // Script_DeleteVar11
            // 
            this.Script_DeleteVar11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar11.Location = new System.Drawing.Point(318, 446);
            this.Script_DeleteVar11.Name = "Script_DeleteVar11";
            this.Script_DeleteVar11.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar11.TabIndex = 70;
            this.Script_DeleteVar11.Text = "-";
            this.Script_DeleteVar11.UseVisualStyleBackColor = true;
            this.Script_DeleteVar11.Click += new System.EventHandler(this.Script_DeleteVar11_Click);
            // 
            // Script_DeleteVar10
            // 
            this.Script_DeleteVar10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar10.Location = new System.Drawing.Point(318, 416);
            this.Script_DeleteVar10.Name = "Script_DeleteVar10";
            this.Script_DeleteVar10.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar10.TabIndex = 69;
            this.Script_DeleteVar10.Text = "-";
            this.Script_DeleteVar10.UseVisualStyleBackColor = true;
            this.Script_DeleteVar10.Click += new System.EventHandler(this.Script_DeleteVar10_Click);
            // 
            // Script_DeleteVar9
            // 
            this.Script_DeleteVar9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar9.Location = new System.Drawing.Point(319, 385);
            this.Script_DeleteVar9.Name = "Script_DeleteVar9";
            this.Script_DeleteVar9.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar9.TabIndex = 68;
            this.Script_DeleteVar9.Text = "-";
            this.Script_DeleteVar9.UseVisualStyleBackColor = true;
            this.Script_DeleteVar9.Click += new System.EventHandler(this.Script_DeleteVar9_Click);
            // 
            // Script_DeleteVar8
            // 
            this.Script_DeleteVar8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar8.Location = new System.Drawing.Point(319, 355);
            this.Script_DeleteVar8.Name = "Script_DeleteVar8";
            this.Script_DeleteVar8.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar8.TabIndex = 67;
            this.Script_DeleteVar8.Text = "-";
            this.Script_DeleteVar8.UseVisualStyleBackColor = true;
            this.Script_DeleteVar8.Click += new System.EventHandler(this.Script_DeleteVar8_Click);
            // 
            // Script_DeleteVar7
            // 
            this.Script_DeleteVar7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar7.Location = new System.Drawing.Point(319, 325);
            this.Script_DeleteVar7.Name = "Script_DeleteVar7";
            this.Script_DeleteVar7.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar7.TabIndex = 65;
            this.Script_DeleteVar7.Text = "-";
            this.Script_DeleteVar7.UseVisualStyleBackColor = true;
            this.Script_DeleteVar7.Click += new System.EventHandler(this.Script_DeleteVar7_Click);
            // 
            // Script_DeleteVar6
            // 
            this.Script_DeleteVar6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar6.Location = new System.Drawing.Point(318, 299);
            this.Script_DeleteVar6.Name = "Script_DeleteVar6";
            this.Script_DeleteVar6.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar6.TabIndex = 64;
            this.Script_DeleteVar6.Text = "-";
            this.Script_DeleteVar6.UseVisualStyleBackColor = true;
            this.Script_DeleteVar6.Click += new System.EventHandler(this.Script_DeleteVar6_Click);
            // 
            // Script_DeleteVar5
            // 
            this.Script_DeleteVar5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar5.Location = new System.Drawing.Point(318, 267);
            this.Script_DeleteVar5.Name = "Script_DeleteVar5";
            this.Script_DeleteVar5.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar5.TabIndex = 63;
            this.Script_DeleteVar5.Text = "-";
            this.Script_DeleteVar5.UseVisualStyleBackColor = true;
            this.Script_DeleteVar5.Click += new System.EventHandler(this.Script_DeleteVar5_Click);
            // 
            // Script_DeleteVar4
            // 
            this.Script_DeleteVar4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar4.Location = new System.Drawing.Point(318, 236);
            this.Script_DeleteVar4.Name = "Script_DeleteVar4";
            this.Script_DeleteVar4.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar4.TabIndex = 62;
            this.Script_DeleteVar4.Text = "-";
            this.Script_DeleteVar4.UseVisualStyleBackColor = true;
            this.Script_DeleteVar4.Click += new System.EventHandler(this.Script_DeleteVar4_Click);
            // 
            // Script_DeleteVar3
            // 
            this.Script_DeleteVar3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar3.Location = new System.Drawing.Point(318, 206);
            this.Script_DeleteVar3.Name = "Script_DeleteVar3";
            this.Script_DeleteVar3.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar3.TabIndex = 61;
            this.Script_DeleteVar3.Text = "-";
            this.Script_DeleteVar3.UseVisualStyleBackColor = true;
            this.Script_DeleteVar3.Click += new System.EventHandler(this.Script_DeleteVar3_Click);
            // 
            // Script_DeleteVar2
            // 
            this.Script_DeleteVar2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar2.Location = new System.Drawing.Point(318, 176);
            this.Script_DeleteVar2.Name = "Script_DeleteVar2";
            this.Script_DeleteVar2.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar2.TabIndex = 60;
            this.Script_DeleteVar2.Text = "-";
            this.Script_DeleteVar2.UseVisualStyleBackColor = true;
            this.Script_DeleteVar2.Click += new System.EventHandler(this.Script_DeleteVar2_Click);
            // 
            // Script_DeleteVar1
            // 
            this.Script_DeleteVar1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar1.Location = new System.Drawing.Point(318, 146);
            this.Script_DeleteVar1.Name = "Script_DeleteVar1";
            this.Script_DeleteVar1.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar1.TabIndex = 59;
            this.Script_DeleteVar1.Text = "-";
            this.Script_DeleteVar1.UseVisualStyleBackColor = true;
            this.Script_DeleteVar1.Click += new System.EventHandler(this.Script_DeleteVar1_Click);
            // 
            // Script_DeleteVar0
            // 
            this.Script_DeleteVar0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_DeleteVar0.Location = new System.Drawing.Point(318, 116);
            this.Script_DeleteVar0.Name = "Script_DeleteVar0";
            this.Script_DeleteVar0.Size = new System.Drawing.Size(20, 25);
            this.Script_DeleteVar0.TabIndex = 58;
            this.Script_DeleteVar0.Text = "-";
            this.Script_DeleteVar0.UseVisualStyleBackColor = true;
            this.Script_DeleteVar0.Click += new System.EventHandler(this.Script_DeleteVar0_Click);
            // 
            // Script_ISRBox
            // 
            this.Script_ISRBox.FormattingEnabled = true;
            this.Script_ISRBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Script_ISRBox.Location = new System.Drawing.Point(948, 136);
            this.Script_ISRBox.Name = "Script_ISRBox";
            this.Script_ISRBox.Size = new System.Drawing.Size(71, 21);
            this.Script_ISRBox.TabIndex = 56;
            this.Script_ISRBox.SelectedIndexChanged += new System.EventHandler(this.Script_ISRBox_SelectedIndexChanged);
            // 
            // Script_ISRLabel
            // 
            this.Script_ISRLabel.AutoSize = true;
            this.Script_ISRLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_ISRLabel.Location = new System.Drawing.Point(953, 109);
            this.Script_ISRLabel.Name = "Script_ISRLabel";
            this.Script_ISRLabel.Size = new System.Drawing.Size(26, 17);
            this.Script_ISRLabel.TabIndex = 55;
            this.Script_ISRLabel.Text = "ISR";
            // 
            // Script_ModelLabel
            // 
            this.Script_ModelLabel.AutoSize = true;
            this.Script_ModelLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_ModelLabel.Location = new System.Drawing.Point(952, 109);
            this.Script_ModelLabel.Name = "Script_ModelLabel";
            this.Script_ModelLabel.Size = new System.Drawing.Size(54, 17);
            this.Script_ModelLabel.TabIndex = 54;
            this.Script_ModelLabel.Text = "Modelo";
            // 
            // Script_FortigateModel
            // 
            this.Script_FortigateModel.FormattingEnabled = true;
            this.Script_FortigateModel.Items.AddRange(new object[] {
            "40F",
            "60F",
            "100F"});
            this.Script_FortigateModel.Location = new System.Drawing.Point(948, 136);
            this.Script_FortigateModel.Name = "Script_FortigateModel";
            this.Script_FortigateModel.Size = new System.Drawing.Size(71, 21);
            this.Script_FortigateModel.TabIndex = 53;
            this.Script_FortigateModel.SelectedIndexChanged += new System.EventHandler(this.Script_FortigateModel_SelectedIndexChanged);
            // 
            // hint1
            // 
            this.hint1.AutoSize = true;
            this.hint1.Location = new System.Drawing.Point(54, 599);
            this.hint1.Name = "hint1";
            this.hint1.Size = new System.Drawing.Size(244, 26);
            this.hint1.TabIndex = 52;
            this.hint1.Text = "Pressionar ENTER dentro de uma Caixa de Texto \n Já aplica formatação";
            this.hint1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyButton
            // 
            this.CopyButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(718, 74);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(85, 34);
            this.CopyButton.TabIndex = 51;
            this.CopyButton.Text = "Copiar";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // Script_Var11
            // 
            this.Script_Var11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var11.Location = new System.Drawing.Point(151, 446);
            this.Script_Var11.Name = "Script_Var11";
            this.Script_Var11.Size = new System.Drawing.Size(161, 25);
            this.Script_Var11.TabIndex = 47;
            this.Script_Var11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_VarName11
            // 
            this.Script_VarName11.AutoSize = true;
            this.Script_VarName11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName11.Location = new System.Drawing.Point(23, 451);
            this.Script_VarName11.Name = "Script_VarName11";
            this.Script_VarName11.Size = new System.Drawing.Size(111, 17);
            this.Script_VarName11.TabIndex = 46;
            this.Script_VarName11.Text = "Loopback Cliente:";
            // 
            // Script_Var10
            // 
            this.Script_Var10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var10.Location = new System.Drawing.Point(151, 416);
            this.Script_Var10.Name = "Script_Var10";
            this.Script_Var10.Size = new System.Drawing.Size(161, 25);
            this.Script_Var10.TabIndex = 45;
            this.Script_Var10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_VarName10
            // 
            this.Script_VarName10.AutoSize = true;
            this.Script_VarName10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName10.Location = new System.Drawing.Point(23, 421);
            this.Script_VarName10.Name = "Script_VarName10";
            this.Script_VarName10.Size = new System.Drawing.Size(106, 17);
            this.Script_VarName10.TabIndex = 44;
            this.Script_VarName10.Text = "Loopback do PE:";
            // 
            // buttonSwitchScriptLog
            // 
            this.buttonSwitchScriptLog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwitchScriptLog.Location = new System.Drawing.Point(123, 10);
            this.buttonSwitchScriptLog.Name = "buttonSwitchScriptLog";
            this.buttonSwitchScriptLog.Size = new System.Drawing.Size(104, 43);
            this.buttonSwitchScriptLog.TabIndex = 43;
            this.buttonSwitchScriptLog.Text = "Switch";
            this.buttonSwitchScriptLog.UseVisualStyleBackColor = true;
            this.buttonSwitchScriptLog.Click += new System.EventHandler(this.buttonSwitchScriptLog_Click);
            // 
            // ButtonLimpeza
            // 
            this.ButtonLimpeza.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLimpeza.Location = new System.Drawing.Point(948, 161);
            this.ButtonLimpeza.Name = "ButtonLimpeza";
            this.ButtonLimpeza.Size = new System.Drawing.Size(104, 34);
            this.ButtonLimpeza.TabIndex = 40;
            this.ButtonLimpeza.Text = "Limpeza";
            this.ButtonLimpeza.UseVisualStyleBackColor = true;
            this.ButtonLimpeza.Click += new System.EventHandler(this.ButtonLimpeza_Click);
            // 
            // ButtonParte2
            // 
            this.ButtonParte2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonParte2.Location = new System.Drawing.Point(948, 115);
            this.ButtonParte2.Name = "ButtonParte2";
            this.ButtonParte2.Size = new System.Drawing.Size(104, 34);
            this.ButtonParte2.TabIndex = 39;
            this.ButtonParte2.Text = "Parte 2";
            this.ButtonParte2.UseVisualStyleBackColor = true;
            this.ButtonParte2.Click += new System.EventHandler(this.ButtonParte2_Click);
            // 
            // Script_Var9
            // 
            this.Script_Var9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var9.Location = new System.Drawing.Point(151, 385);
            this.Script_Var9.Name = "Script_Var9";
            this.Script_Var9.Size = new System.Drawing.Size(102, 25);
            this.Script_Var9.TabIndex = 38;
            this.Script_Var9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_VarName9
            // 
            this.Script_VarName9.AutoSize = true;
            this.Script_VarName9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName9.Location = new System.Drawing.Point(23, 390);
            this.Script_VarName9.Name = "Script_VarName9";
            this.Script_VarName9.Size = new System.Drawing.Size(68, 17);
            this.Script_VarName9.TabIndex = 37;
            this.Script_VarName9.Text = "IP de LAN:";
            // 
            // Script_Var8
            // 
            this.Script_Var8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var8.Location = new System.Drawing.Point(151, 355);
            this.Script_Var8.Name = "Script_Var8";
            this.Script_Var8.Size = new System.Drawing.Size(162, 25);
            this.Script_Var8.TabIndex = 36;
            this.Script_Var8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_VarName8
            // 
            this.Script_VarName8.AutoSize = true;
            this.Script_VarName8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName8.Location = new System.Drawing.Point(23, 360);
            this.Script_VarName8.Name = "Script_VarName8";
            this.Script_VarName8.Size = new System.Drawing.Size(67, 17);
            this.Script_VarName8.TabIndex = 35;
            this.Script_VarName8.Text = "IP do CPE:";
            // 
            // Script_Var7
            // 
            this.Script_Var7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var7.Location = new System.Drawing.Point(151, 325);
            this.Script_Var7.Name = "Script_Var7";
            this.Script_Var7.Size = new System.Drawing.Size(162, 25);
            this.Script_Var7.TabIndex = 34;
            this.Script_Var7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_VarName7
            // 
            this.Script_VarName7.AutoSize = true;
            this.Script_VarName7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName7.Location = new System.Drawing.Point(23, 330);
            this.Script_VarName7.Name = "Script_VarName7";
            this.Script_VarName7.Size = new System.Drawing.Size(59, 17);
            this.Script_VarName7.TabIndex = 33;
            this.Script_VarName7.Text = "IP do PE:";
            // 
            // Script_LANMascara
            // 
            this.Script_LANMascara.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_LANMascara.FormattingEnabled = true;
            this.Script_LANMascara.Items.AddRange(new object[] {
            "/30",
            "/29",
            "/28",
            "/26",
            "/24"});
            this.Script_LANMascara.Location = new System.Drawing.Point(259, 385);
            this.Script_LANMascara.Name = "Script_LANMascara";
            this.Script_LANMascara.Size = new System.Drawing.Size(53, 25);
            this.Script_LANMascara.TabIndex = 31;
            this.Script_LANMascara.SelectedIndexChanged += new System.EventHandler(this.Script_LANMascara_SelectedIndexChanged);
            // 
            // BackButton_Script3
            // 
            this.BackButton_Script3.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackButton_Script3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_Script3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton_Script3.Location = new System.Drawing.Point(965, 20);
            this.BackButton_Script3.Name = "BackButton_Script3";
            this.BackButton_Script3.Size = new System.Drawing.Size(104, 43);
            this.BackButton_Script3.TabIndex = 30;
            this.BackButton_Script3.Text = "Voltar";
            this.BackButton_Script3.UseVisualStyleBackColor = false;
            this.BackButton_Script3.Click += new System.EventHandler(this.BackButton_Script3_Click_Click);
            // 
            // BackButton_Script2
            // 
            this.BackButton_Script2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_Script2.Location = new System.Drawing.Point(965, 20);
            this.BackButton_Script2.Name = "BackButton_Script2";
            this.BackButton_Script2.Size = new System.Drawing.Size(104, 43);
            this.BackButton_Script2.TabIndex = 29;
            this.BackButton_Script2.Text = "Voltar";
            this.BackButton_Script2.UseVisualStyleBackColor = true;
            this.BackButton_Script2.Click += new System.EventHandler(this.BackButton_Script2_Click);
            // 
            // Script_TypeLabel
            // 
            this.Script_TypeLabel.AutoSize = true;
            this.Script_TypeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_TypeLabel.Location = new System.Drawing.Point(542, 87);
            this.Script_TypeLabel.Name = "Script_TypeLabel";
            this.Script_TypeLabel.Size = new System.Drawing.Size(39, 17);
            this.Script_TypeLabel.TabIndex = 28;
            this.Script_TypeLabel.Text = "Logs:";
            // 
            // Button_FormatarScript
            // 
            this.Button_FormatarScript.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FormatarScript.Location = new System.Drawing.Point(809, 133);
            this.Button_FormatarScript.Name = "Button_FormatarScript";
            this.Button_FormatarScript.Size = new System.Drawing.Size(104, 43);
            this.Button_FormatarScript.TabIndex = 27;
            this.Button_FormatarScript.Text = "Formatar";
            this.Button_FormatarScript.UseVisualStyleBackColor = true;
            this.Button_FormatarScript.Click += new System.EventHandler(this.Button_FormatarScript_Click);
            // 
            // BackButton_Script
            // 
            this.BackButton_Script.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_Script.Location = new System.Drawing.Point(965, 20);
            this.BackButton_Script.Name = "BackButton_Script";
            this.BackButton_Script.Size = new System.Drawing.Size(104, 43);
            this.BackButton_Script.TabIndex = 26;
            this.BackButton_Script.Text = "Voltar";
            this.BackButton_Script.UseVisualStyleBackColor = true;
            this.BackButton_Script.Click += new System.EventHandler(this.BackButton1_Click);
            // 
            // Script_ComboBox
            // 
            this.Script_ComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_ComboBox.FormattingEnabled = true;
            this.Script_ComboBox.Items.AddRange(new object[] {
            "INICIAIS",
            "APLICADAS",
            "FINAIS",
            "FALLBACK"});
            this.Script_ComboBox.Location = new System.Drawing.Point(587, 84);
            this.Script_ComboBox.Name = "Script_ComboBox";
            this.Script_ComboBox.Size = new System.Drawing.Size(106, 25);
            this.Script_ComboBox.TabIndex = 25;
            this.Script_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Script_ComboBox_SelectedIndexChanged);
            // 
            // Script_Var6
            // 
            this.Script_Var6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var6.Location = new System.Drawing.Point(151, 295);
            this.Script_Var6.Name = "Script_Var6";
            this.Script_Var6.Size = new System.Drawing.Size(162, 25);
            this.Script_Var6.TabIndex = 22;
            this.Script_Var6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_VarName6
            // 
            this.Script_VarName6.AutoSize = true;
            this.Script_VarName6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName6.Location = new System.Drawing.Point(23, 300);
            this.Script_VarName6.Name = "Script_VarName6";
            this.Script_VarName6.Size = new System.Drawing.Size(131, 17);
            this.Script_VarName6.TabIndex = 21;
            this.Script_VarName6.Text = "Interface Logica LAN:";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(259, 80);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(79, 30);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Limpar";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // VarText
            // 
            this.VarText.AutoSize = true;
            this.VarText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarText.Location = new System.Drawing.Point(27, 74);
            this.VarText.Name = "VarText";
            this.VarText.Size = new System.Drawing.Size(88, 25);
            this.VarText.TabIndex = 18;
            this.VarText.Text = "Variáveis";
            // 
            // Script_Var5
            // 
            this.Script_Var5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var5.Location = new System.Drawing.Point(151, 265);
            this.Script_Var5.Name = "Script_Var5";
            this.Script_Var5.Size = new System.Drawing.Size(162, 25);
            this.Script_Var5.TabIndex = 17;
            this.Script_Var5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_Var4
            // 
            this.Script_Var4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var4.Location = new System.Drawing.Point(151, 235);
            this.Script_Var4.Name = "Script_Var4";
            this.Script_Var4.Size = new System.Drawing.Size(161, 25);
            this.Script_Var4.TabIndex = 16;
            this.Script_Var4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_Var3
            // 
            this.Script_Var3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var3.Location = new System.Drawing.Point(151, 206);
            this.Script_Var3.Name = "Script_Var3";
            this.Script_Var3.Size = new System.Drawing.Size(161, 25);
            this.Script_Var3.TabIndex = 15;
            this.Script_Var3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_Var2
            // 
            this.Script_Var2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var2.Location = new System.Drawing.Point(151, 175);
            this.Script_Var2.Name = "Script_Var2";
            this.Script_Var2.Size = new System.Drawing.Size(161, 25);
            this.Script_Var2.TabIndex = 14;
            this.Script_Var2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_Var1
            // 
            this.Script_Var1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var1.Location = new System.Drawing.Point(151, 145);
            this.Script_Var1.Name = "Script_Var1";
            this.Script_Var1.Size = new System.Drawing.Size(161, 25);
            this.Script_Var1.TabIndex = 13;
            this.Script_Var1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // Script_VarName5
            // 
            this.Script_VarName5.AutoSize = true;
            this.Script_VarName5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName5.Location = new System.Drawing.Point(23, 270);
            this.Script_VarName5.Name = "Script_VarName5";
            this.Script_VarName5.Size = new System.Drawing.Size(89, 17);
            this.Script_VarName5.TabIndex = 12;
            this.Script_VarName5.Text = "Interface LAN:";
            // 
            // Script_VarName3
            // 
            this.Script_VarName3.AutoSize = true;
            this.Script_VarName3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName3.Location = new System.Drawing.Point(23, 210);
            this.Script_VarName3.Name = "Script_VarName3";
            this.Script_VarName3.Size = new System.Drawing.Size(94, 17);
            this.Script_VarName3.TabIndex = 11;
            this.Script_VarName3.Text = "Interface WAN:";
            // 
            // Script_VarName4
            // 
            this.Script_VarName4.AutoSize = true;
            this.Script_VarName4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName4.Location = new System.Drawing.Point(23, 240);
            this.Script_VarName4.Name = "Script_VarName4";
            this.Script_VarName4.Size = new System.Drawing.Size(76, 17);
            this.Script_VarName4.TabIndex = 10;
            this.Script_VarName4.Text = "N da VLAN:";
            // 
            // Script_VarName2
            // 
            this.Script_VarName2.AutoSize = true;
            this.Script_VarName2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName2.Location = new System.Drawing.Point(23, 180);
            this.Script_VarName2.Name = "Script_VarName2";
            this.Script_VarName2.Size = new System.Drawing.Size(71, 17);
            this.Script_VarName2.TabIndex = 9;
            this.Script_VarName2.Text = "Bandwidth:";
            // 
            // Script_VarName1
            // 
            this.Script_VarName1.AutoSize = true;
            this.Script_VarName1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName1.Location = new System.Drawing.Point(23, 150);
            this.Script_VarName1.Name = "Script_VarName1";
            this.Script_VarName1.Size = new System.Drawing.Size(77, 17);
            this.Script_VarName1.TabIndex = 8;
            this.Script_VarName1.Text = "Description:";
            // 
            // ProcedureName
            // 
            this.ProcedureName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcedureName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcedureName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProcedureName.Location = new System.Drawing.Point(447, 8);
            this.ProcedureName.Margin = new System.Windows.Forms.Padding(0);
            this.ProcedureName.Name = "ProcedureName";
            this.ProcedureName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProcedureName.Size = new System.Drawing.Size(254, 45);
            this.ProcedureName.TabIndex = 5;
            this.ProcedureName.Text = "Procedure Name";
            this.ProcedureName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeButton_Script
            // 
            this.HomeButton_Script.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton_Script.Location = new System.Drawing.Point(13, 10);
            this.HomeButton_Script.Name = "HomeButton_Script";
            this.HomeButton_Script.Size = new System.Drawing.Size(104, 43);
            this.HomeButton_Script.TabIndex = 4;
            this.HomeButton_Script.Text = "Home";
            this.HomeButton_Script.UseVisualStyleBackColor = true;
            this.HomeButton_Script.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // Script_LabelScript
            // 
            this.Script_LabelScript.AutoSize = true;
            this.Script_LabelScript.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_LabelScript.Location = new System.Drawing.Point(466, 79);
            this.Script_LabelScript.Name = "Script_LabelScript";
            this.Script_LabelScript.Size = new System.Drawing.Size(70, 30);
            this.Script_LabelScript.TabIndex = 3;
            this.Script_LabelScript.Text = "Script";
            // 
            // Script_VarName0
            // 
            this.Script_VarName0.AutoSize = true;
            this.Script_VarName0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarName0.Location = new System.Drawing.Point(23, 120);
            this.Script_VarName0.Name = "Script_VarName0";
            this.Script_VarName0.Size = new System.Drawing.Size(70, 17);
            this.Script_VarName0.TabIndex = 2;
            this.Script_VarName0.Text = "Hostname:";
            // 
            // Script_Var0
            // 
            this.Script_Var0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_Var0.Location = new System.Drawing.Point(151, 115);
            this.Script_Var0.Name = "Script_Var0";
            this.Script_Var0.Size = new System.Drawing.Size(161, 25);
            this.Script_Var0.TabIndex = 1;
            this.Script_Var0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // tabSelectRouter
            // 
            this.tabSelectRouter.Controls.Add(this.label4);
            this.tabSelectRouter.Controls.Add(this.Config_ChangeVOZ);
            this.tabSelectRouter.Controls.Add(this.Config_ChangeMPLS);
            this.tabSelectRouter.Controls.Add(this.Config_ChangeBLD);
            this.tabSelectRouter.Controls.Add(this.ConfiguracaoCPE_SubTitle);
            this.tabSelectRouter.Controls.Add(this.Config_Fortigate);
            this.tabSelectRouter.Controls.Add(this.Config_Huawei);
            this.tabSelectRouter.Controls.Add(this.Config_HPE_old);
            this.tabSelectRouter.Controls.Add(this.ConfiguracaoCPETitle);
            this.tabSelectRouter.Controls.Add(this.BackButton_SelectRouter);
            this.tabSelectRouter.Controls.Add(this.Config_HPE);
            this.tabSelectRouter.Controls.Add(this.Config_Cisco);
            this.tabSelectRouter.Location = new System.Drawing.Point(4, 5);
            this.tabSelectRouter.Name = "tabSelectRouter";
            this.tabSelectRouter.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectRouter.Size = new System.Drawing.Size(1105, 443);
            this.tabSelectRouter.TabIndex = 2;
            this.tabSelectRouter.Text = "tabPage4";
            this.tabSelectRouter.UseVisualStyleBackColor = true;
            // 
            // Config_ChangeVOZ
            // 
            this.Config_ChangeVOZ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_ChangeVOZ.Location = new System.Drawing.Point(960, 293);
            this.Config_ChangeVOZ.Name = "Config_ChangeVOZ";
            this.Config_ChangeVOZ.Size = new System.Drawing.Size(117, 60);
            this.Config_ChangeVOZ.TabIndex = 13;
            this.Config_ChangeVOZ.Text = "VOZ";
            this.Config_ChangeVOZ.UseVisualStyleBackColor = true;
            this.Config_ChangeVOZ.Click += new System.EventHandler(this.NotImplemented);
            // 
            // Config_ChangeMPLS
            // 
            this.Config_ChangeMPLS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_ChangeMPLS.Location = new System.Drawing.Point(960, 227);
            this.Config_ChangeMPLS.Name = "Config_ChangeMPLS";
            this.Config_ChangeMPLS.Size = new System.Drawing.Size(117, 60);
            this.Config_ChangeMPLS.TabIndex = 12;
            this.Config_ChangeMPLS.Text = "MPLS";
            this.Config_ChangeMPLS.UseVisualStyleBackColor = true;
            this.Config_ChangeMPLS.Click += new System.EventHandler(this.MPLS_button_Click);
            // 
            // Config_ChangeBLD
            // 
            this.Config_ChangeBLD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_ChangeBLD.Location = new System.Drawing.Point(960, 161);
            this.Config_ChangeBLD.Name = "Config_ChangeBLD";
            this.Config_ChangeBLD.Size = new System.Drawing.Size(117, 60);
            this.Config_ChangeBLD.TabIndex = 11;
            this.Config_ChangeBLD.Text = "BLD";
            this.Config_ChangeBLD.UseVisualStyleBackColor = true;
            this.Config_ChangeBLD.Click += new System.EventHandler(this.BLD_button_Click);
            // 
            // ConfiguracaoCPE_SubTitle
            // 
            this.ConfiguracaoCPE_SubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfiguracaoCPE_SubTitle.AutoSize = true;
            this.ConfiguracaoCPE_SubTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfiguracaoCPE_SubTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConfiguracaoCPE_SubTitle.Location = new System.Drawing.Point(512, 75);
            this.ConfiguracaoCPE_SubTitle.Name = "ConfiguracaoCPE_SubTitle";
            this.ConfiguracaoCPE_SubTitle.Size = new System.Drawing.Size(68, 32);
            this.ConfiguracaoCPE_SubTitle.TabIndex = 10;
            this.ConfiguracaoCPE_SubTitle.Text = "Type";
            this.ConfiguracaoCPE_SubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Config_Fortigate
            // 
            this.Config_Fortigate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Fortigate.Location = new System.Drawing.Point(582, 263);
            this.Config_Fortigate.Name = "Config_Fortigate";
            this.Config_Fortigate.Size = new System.Drawing.Size(171, 60);
            this.Config_Fortigate.TabIndex = 9;
            this.Config_Fortigate.Text = "Fortigate";
            this.Config_Fortigate.UseVisualStyleBackColor = true;
            this.Config_Fortigate.Click += new System.EventHandler(this.Config_Fortigate_Click);
            // 
            // Config_Huawei
            // 
            this.Config_Huawei.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Huawei.Location = new System.Drawing.Point(360, 263);
            this.Config_Huawei.Name = "Config_Huawei";
            this.Config_Huawei.Size = new System.Drawing.Size(171, 60);
            this.Config_Huawei.TabIndex = 8;
            this.Config_Huawei.Text = "Huawei";
            this.Config_Huawei.UseVisualStyleBackColor = true;
            this.Config_Huawei.Click += new System.EventHandler(this.Config_Huawei_Click);
            // 
            // Config_HPE_old
            // 
            this.Config_HPE_old.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_HPE_old.Location = new System.Drawing.Point(674, 161);
            this.Config_HPE_old.Name = "Config_HPE_old";
            this.Config_HPE_old.Size = new System.Drawing.Size(171, 60);
            this.Config_HPE_old.TabIndex = 7;
            this.Config_HPE_old.Text = "HPE - Antigo";
            this.Config_HPE_old.UseVisualStyleBackColor = true;
            this.Config_HPE_old.Click += new System.EventHandler(this.NotImplemented);
            // 
            // ConfiguracaoCPETitle
            // 
            this.ConfiguracaoCPETitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfiguracaoCPETitle.AutoSize = true;
            this.ConfiguracaoCPETitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfiguracaoCPETitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConfiguracaoCPETitle.Location = new System.Drawing.Point(410, 18);
            this.ConfiguracaoCPETitle.Name = "ConfiguracaoCPETitle";
            this.ConfiguracaoCPETitle.Size = new System.Drawing.Size(287, 45);
            this.ConfiguracaoCPETitle.TabIndex = 6;
            this.ConfiguracaoCPETitle.Text = "Configuracão CPE";
            this.ConfiguracaoCPETitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BackButton_SelectRouter
            // 
            this.BackButton_SelectRouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton_SelectRouter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_SelectRouter.Location = new System.Drawing.Point(982, 18);
            this.BackButton_SelectRouter.Name = "BackButton_SelectRouter";
            this.BackButton_SelectRouter.Size = new System.Drawing.Size(104, 43);
            this.BackButton_SelectRouter.TabIndex = 5;
            this.BackButton_SelectRouter.Text = "Voltar";
            this.BackButton_SelectRouter.UseVisualStyleBackColor = true;
            this.BackButton_SelectRouter.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // Config_HPE
            // 
            this.Config_HPE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_HPE.Location = new System.Drawing.Point(465, 161);
            this.Config_HPE.Name = "Config_HPE";
            this.Config_HPE.Size = new System.Drawing.Size(171, 60);
            this.Config_HPE.TabIndex = 2;
            this.Config_HPE.Text = "HPE";
            this.Config_HPE.UseVisualStyleBackColor = true;
            this.Config_HPE.Click += new System.EventHandler(this.HPE_Button_Click);
            // 
            // Config_Cisco
            // 
            this.Config_Cisco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_Cisco.Location = new System.Drawing.Point(259, 161);
            this.Config_Cisco.Name = "Config_Cisco";
            this.Config_Cisco.Size = new System.Drawing.Size(171, 60);
            this.Config_Cisco.TabIndex = 1;
            this.Config_Cisco.Text = "Cisco";
            this.Config_Cisco.UseVisualStyleBackColor = true;
            this.Config_Cisco.Click += new System.EventHandler(this.Cisco_Button_Click);
            // 
            // ClientStepsPage
            // 
            this.ClientStepsPage.Location = new System.Drawing.Point(4, 5);
            this.ClientStepsPage.Name = "ClientStepsPage";
            this.ClientStepsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientStepsPage.Size = new System.Drawing.Size(1105, 443);
            this.ClientStepsPage.TabIndex = 3;
            this.ClientStepsPage.Text = "ClientStepsPage";
            this.ClientStepsPage.UseVisualStyleBackColor = true;
            // 
            // tabWizGat
            // 
            this.tabWizGat.Controls.Add(this.BackButton_WizGat);
            this.tabWizGat.Controls.Add(this.WizCiscoBGP);
            this.tabWizGat.Controls.Add(this.WizCiscoVoz);
            this.tabWizGat.Controls.Add(this.WizCiscoMPLS);
            this.tabWizGat.Controls.Add(this.WizCiscoBLD);
            this.tabWizGat.Controls.Add(this.WizCiscoTitle);
            this.tabWizGat.Controls.Add(this.WizNokiaTitle);
            this.tabWizGat.Controls.Add(this.WizNokiaBLDcBGP);
            this.tabWizGat.Controls.Add(this.WizNokiaVoz);
            this.tabWizGat.Controls.Add(this.WizNokiaMPLS);
            this.tabWizGat.Controls.Add(this.WizNokiaBLD);
            this.tabWizGat.Location = new System.Drawing.Point(4, 5);
            this.tabWizGat.Name = "tabWizGat";
            this.tabWizGat.Padding = new System.Windows.Forms.Padding(3);
            this.tabWizGat.Size = new System.Drawing.Size(1105, 443);
            this.tabWizGat.TabIndex = 4;
            this.tabWizGat.Text = "WizGat";
            this.tabWizGat.UseVisualStyleBackColor = true;
            // 
            // BackButton_WizGat
            // 
            this.BackButton_WizGat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton_WizGat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_WizGat.Location = new System.Drawing.Point(985, 16);
            this.BackButton_WizGat.Name = "BackButton_WizGat";
            this.BackButton_WizGat.Size = new System.Drawing.Size(104, 43);
            this.BackButton_WizGat.TabIndex = 10;
            this.BackButton_WizGat.Text = "Voltar";
            this.BackButton_WizGat.UseVisualStyleBackColor = true;
            this.BackButton_WizGat.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // WizCiscoBGP
            // 
            this.WizCiscoBGP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizCiscoBGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizCiscoBGP.Location = new System.Drawing.Point(695, 273);
            this.WizCiscoBGP.Name = "WizCiscoBGP";
            this.WizCiscoBGP.Size = new System.Drawing.Size(140, 55);
            this.WizCiscoBGP.TabIndex = 9;
            this.WizCiscoBGP.Text = "BLD c/ BGP";
            this.WizCiscoBGP.UseVisualStyleBackColor = true;
            this.WizCiscoBGP.Click += new System.EventHandler(this.WizCiscoBGP_Click);
            // 
            // WizCiscoVoz
            // 
            this.WizCiscoVoz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizCiscoVoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizCiscoVoz.Location = new System.Drawing.Point(549, 273);
            this.WizCiscoVoz.Name = "WizCiscoVoz";
            this.WizCiscoVoz.Size = new System.Drawing.Size(140, 55);
            this.WizCiscoVoz.TabIndex = 8;
            this.WizCiscoVoz.Text = "VOZ";
            this.WizCiscoVoz.UseVisualStyleBackColor = true;
            this.WizCiscoVoz.Click += new System.EventHandler(this.WizCiscoVoz_Click);
            // 
            // WizCiscoMPLS
            // 
            this.WizCiscoMPLS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizCiscoMPLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizCiscoMPLS.Location = new System.Drawing.Point(403, 273);
            this.WizCiscoMPLS.Name = "WizCiscoMPLS";
            this.WizCiscoMPLS.Size = new System.Drawing.Size(140, 55);
            this.WizCiscoMPLS.TabIndex = 7;
            this.WizCiscoMPLS.Text = "MPLS";
            this.WizCiscoMPLS.UseVisualStyleBackColor = true;
            this.WizCiscoMPLS.Click += new System.EventHandler(this.WizCiscoMPLS_Click);
            // 
            // WizCiscoBLD
            // 
            this.WizCiscoBLD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizCiscoBLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizCiscoBLD.Location = new System.Drawing.Point(257, 273);
            this.WizCiscoBLD.Name = "WizCiscoBLD";
            this.WizCiscoBLD.Size = new System.Drawing.Size(140, 55);
            this.WizCiscoBLD.TabIndex = 6;
            this.WizCiscoBLD.Text = "BLD";
            this.WizCiscoBLD.UseVisualStyleBackColor = true;
            this.WizCiscoBLD.Click += new System.EventHandler(this.WizCiscoBLD_Click);
            // 
            // WizCiscoTitle
            // 
            this.WizCiscoTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizCiscoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizCiscoTitle.Location = new System.Drawing.Point(480, 207);
            this.WizCiscoTitle.Name = "WizCiscoTitle";
            this.WizCiscoTitle.Size = new System.Drawing.Size(139, 39);
            this.WizCiscoTitle.TabIndex = 5;
            this.WizCiscoTitle.Text = "CISCO";
            this.WizCiscoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WizNokiaTitle
            // 
            this.WizNokiaTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizNokiaTitle.BackColor = System.Drawing.SystemColors.Control;
            this.WizNokiaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizNokiaTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WizNokiaTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WizNokiaTitle.Location = new System.Drawing.Point(490, 52);
            this.WizNokiaTitle.Name = "WizNokiaTitle";
            this.WizNokiaTitle.Size = new System.Drawing.Size(129, 39);
            this.WizNokiaTitle.TabIndex = 4;
            this.WizNokiaTitle.Text = "NOKIA";
            this.WizNokiaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WizNokiaBLDcBGP
            // 
            this.WizNokiaBLDcBGP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizNokiaBLDcBGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizNokiaBLDcBGP.Location = new System.Drawing.Point(695, 105);
            this.WizNokiaBLDcBGP.Name = "WizNokiaBLDcBGP";
            this.WizNokiaBLDcBGP.Size = new System.Drawing.Size(140, 55);
            this.WizNokiaBLDcBGP.TabIndex = 3;
            this.WizNokiaBLDcBGP.Text = "BLD c/ BGP";
            this.WizNokiaBLDcBGP.UseVisualStyleBackColor = true;
            this.WizNokiaBLDcBGP.Click += new System.EventHandler(this.WizNokiaBLDcBGP_Click);
            // 
            // WizNokiaVoz
            // 
            this.WizNokiaVoz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizNokiaVoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizNokiaVoz.Location = new System.Drawing.Point(549, 105);
            this.WizNokiaVoz.Name = "WizNokiaVoz";
            this.WizNokiaVoz.Size = new System.Drawing.Size(140, 55);
            this.WizNokiaVoz.TabIndex = 2;
            this.WizNokiaVoz.Text = "VOZ";
            this.WizNokiaVoz.UseVisualStyleBackColor = true;
            this.WizNokiaVoz.Click += new System.EventHandler(this.WizNokiaVoz_Click);
            // 
            // WizNokiaMPLS
            // 
            this.WizNokiaMPLS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizNokiaMPLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizNokiaMPLS.Location = new System.Drawing.Point(403, 105);
            this.WizNokiaMPLS.Name = "WizNokiaMPLS";
            this.WizNokiaMPLS.Size = new System.Drawing.Size(140, 55);
            this.WizNokiaMPLS.TabIndex = 1;
            this.WizNokiaMPLS.Text = "MPLS";
            this.WizNokiaMPLS.UseVisualStyleBackColor = true;
            this.WizNokiaMPLS.Click += new System.EventHandler(this.WizNokiaMPLS_Click);
            // 
            // WizNokiaBLD
            // 
            this.WizNokiaBLD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizNokiaBLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizNokiaBLD.Location = new System.Drawing.Point(257, 105);
            this.WizNokiaBLD.Name = "WizNokiaBLD";
            this.WizNokiaBLD.Size = new System.Drawing.Size(140, 55);
            this.WizNokiaBLD.TabIndex = 0;
            this.WizNokiaBLD.Text = "BLD";
            this.WizNokiaBLD.UseVisualStyleBackColor = true;
            this.WizNokiaBLD.Click += new System.EventHandler(this.WizNokiaBLD_Click);
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.Logs_WizGat);
            this.tabLogs.Controls.Add(this.Logs_VOZ_Broadsoft);
            this.tabLogs.Controls.Add(this.Logs_VOZ_Digistar);
            this.tabLogs.Controls.Add(this.Logs_VOZ_HPE);
            this.tabLogs.Controls.Add(this.Logs_VOZ_Cisco);
            this.tabLogs.Controls.Add(this.Logs_MPLS_Huawei);
            this.tabLogs.Controls.Add(this.Logs_Ligacao);
            this.tabLogs.Controls.Add(this.Logs_BLD_Huawei);
            this.tabLogs.Controls.Add(this.Logs_MPLS_Fortigate);
            this.tabLogs.Controls.Add(this.row6);
            this.tabLogs.Controls.Add(this.Logs_SubTitle2);
            this.tabLogs.Controls.Add(this.Logs_BLD_Fortigate);
            this.tabLogs.Controls.Add(this.Logs_Velo);
            this.tabLogs.Controls.Add(this.Logs_SubTitle4);
            this.tabLogs.Controls.Add(this.Logs_SubTitle1);
            this.tabLogs.Controls.Add(this.Logs_SubTitle0);
            this.tabLogs.Controls.Add(this.Logs_HPE_MPLS);
            this.tabLogs.Controls.Add(this.Logs_Cisco_MPLS);
            this.tabLogs.Controls.Add(this.LogsRow1);
            this.tabLogs.Controls.Add(this.LogsRow0);
            this.tabLogs.Controls.Add(this.Logs_VOZ_Aligera);
            this.tabLogs.Controls.Add(this.Logs_HPE_BLD);
            this.tabLogs.Controls.Add(this.Logs_BackButton);
            this.tabLogs.Controls.Add(this.Logs_Title);
            this.tabLogs.Controls.Add(this.Logs_Cisco_BLD);
            this.tabLogs.Location = new System.Drawing.Point(4, 5);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(1105, 443);
            this.tabLogs.TabIndex = 5;
            this.tabLogs.Text = "tabLogs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // Logs_WizGat
            // 
            this.Logs_WizGat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_WizGat.Location = new System.Drawing.Point(18, 15);
            this.Logs_WizGat.Name = "Logs_WizGat";
            this.Logs_WizGat.Size = new System.Drawing.Size(139, 52);
            this.Logs_WizGat.TabIndex = 32;
            this.Logs_WizGat.Text = "WizardGat";
            this.Logs_WizGat.UseVisualStyleBackColor = true;
            this.Logs_WizGat.Click += new System.EventHandler(this.Logs_WizGat_Click);
            // 
            // Logs_VOZ_Broadsoft
            // 
            this.Logs_VOZ_Broadsoft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_VOZ_Broadsoft.Location = new System.Drawing.Point(780, 281);
            this.Logs_VOZ_Broadsoft.Name = "Logs_VOZ_Broadsoft";
            this.Logs_VOZ_Broadsoft.Size = new System.Drawing.Size(171, 60);
            this.Logs_VOZ_Broadsoft.TabIndex = 31;
            this.Logs_VOZ_Broadsoft.Text = "Broadsoft";
            this.Logs_VOZ_Broadsoft.UseVisualStyleBackColor = true;
            this.Logs_VOZ_Broadsoft.Click += new System.EventHandler(this.NotImplemented);
            // 
            // Logs_VOZ_Digistar
            // 
            this.Logs_VOZ_Digistar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_VOZ_Digistar.Location = new System.Drawing.Point(574, 350);
            this.Logs_VOZ_Digistar.Name = "Logs_VOZ_Digistar";
            this.Logs_VOZ_Digistar.Size = new System.Drawing.Size(171, 60);
            this.Logs_VOZ_Digistar.TabIndex = 30;
            this.Logs_VOZ_Digistar.Text = "Digistar";
            this.Logs_VOZ_Digistar.UseVisualStyleBackColor = true;
            this.Logs_VOZ_Digistar.Click += new System.EventHandler(this.NotImplemented);
            // 
            // Logs_VOZ_HPE
            // 
            this.Logs_VOZ_HPE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_VOZ_HPE.Location = new System.Drawing.Point(574, 213);
            this.Logs_VOZ_HPE.Name = "Logs_VOZ_HPE";
            this.Logs_VOZ_HPE.Size = new System.Drawing.Size(171, 60);
            this.Logs_VOZ_HPE.TabIndex = 29;
            this.Logs_VOZ_HPE.Text = "HPE";
            this.Logs_VOZ_HPE.UseVisualStyleBackColor = true;
            this.Logs_VOZ_HPE.Click += new System.EventHandler(this.NotImplemented);
            // 
            // Logs_VOZ_Cisco
            // 
            this.Logs_VOZ_Cisco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_VOZ_Cisco.Location = new System.Drawing.Point(574, 144);
            this.Logs_VOZ_Cisco.Name = "Logs_VOZ_Cisco";
            this.Logs_VOZ_Cisco.Size = new System.Drawing.Size(171, 60);
            this.Logs_VOZ_Cisco.TabIndex = 28;
            this.Logs_VOZ_Cisco.Text = "Cisco";
            this.Logs_VOZ_Cisco.UseVisualStyleBackColor = true;
            this.Logs_VOZ_Cisco.Click += new System.EventHandler(this.NotImplemented);
            // 
            // Logs_MPLS_Huawei
            // 
            this.Logs_MPLS_Huawei.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_MPLS_Huawei.Location = new System.Drawing.Point(363, 350);
            this.Logs_MPLS_Huawei.Name = "Logs_MPLS_Huawei";
            this.Logs_MPLS_Huawei.Size = new System.Drawing.Size(171, 60);
            this.Logs_MPLS_Huawei.TabIndex = 27;
            this.Logs_MPLS_Huawei.Text = "Huawei";
            this.Logs_MPLS_Huawei.UseVisualStyleBackColor = true;
            this.Logs_MPLS_Huawei.Click += new System.EventHandler(this.NotImplemented);
            // 
            // Logs_Ligacao
            // 
            this.Logs_Ligacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Ligacao.Location = new System.Drawing.Point(780, 144);
            this.Logs_Ligacao.Name = "Logs_Ligacao";
            this.Logs_Ligacao.Size = new System.Drawing.Size(171, 60);
            this.Logs_Ligacao.TabIndex = 26;
            this.Logs_Ligacao.Text = "Ligacao";
            this.Logs_Ligacao.UseVisualStyleBackColor = true;
            this.Logs_Ligacao.Click += new System.EventHandler(this.Logs_Ligacao_Click);
            // 
            // Logs_BLD_Huawei
            // 
            this.Logs_BLD_Huawei.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_BLD_Huawei.Location = new System.Drawing.Point(147, 350);
            this.Logs_BLD_Huawei.Name = "Logs_BLD_Huawei";
            this.Logs_BLD_Huawei.Size = new System.Drawing.Size(171, 60);
            this.Logs_BLD_Huawei.TabIndex = 25;
            this.Logs_BLD_Huawei.Text = "Huawei";
            this.Logs_BLD_Huawei.UseVisualStyleBackColor = true;
            this.Logs_BLD_Huawei.Click += new System.EventHandler(this.Logs_BLD_Huawei_Click);
            // 
            // Logs_MPLS_Fortigate
            // 
            this.Logs_MPLS_Fortigate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_MPLS_Fortigate.Location = new System.Drawing.Point(363, 281);
            this.Logs_MPLS_Fortigate.Name = "Logs_MPLS_Fortigate";
            this.Logs_MPLS_Fortigate.Size = new System.Drawing.Size(171, 60);
            this.Logs_MPLS_Fortigate.TabIndex = 24;
            this.Logs_MPLS_Fortigate.Text = "Fortigate";
            this.Logs_MPLS_Fortigate.UseVisualStyleBackColor = true;
            this.Logs_MPLS_Fortigate.Click += new System.EventHandler(this.Logs_MPLS_Fortigate_Click);
            // 
            // row6
            // 
            this.row6.BackColor = System.Drawing.Color.Gray;
            this.row6.Location = new System.Drawing.Point(762, 121);
            this.row6.Name = "row6";
            this.row6.Size = new System.Drawing.Size(1, 303);
            this.row6.TabIndex = 23;
            this.row6.TabStop = false;
            // 
            // Logs_SubTitle2
            // 
            this.Logs_SubTitle2.AutoSize = true;
            this.Logs_SubTitle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_SubTitle2.Location = new System.Drawing.Point(639, 101);
            this.Logs_SubTitle2.Name = "Logs_SubTitle2";
            this.Logs_SubTitle2.Size = new System.Drawing.Size(51, 25);
            this.Logs_SubTitle2.TabIndex = 22;
            this.Logs_SubTitle2.Text = "VOZ";
            // 
            // Logs_BLD_Fortigate
            // 
            this.Logs_BLD_Fortigate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_BLD_Fortigate.Location = new System.Drawing.Point(147, 281);
            this.Logs_BLD_Fortigate.Name = "Logs_BLD_Fortigate";
            this.Logs_BLD_Fortigate.Size = new System.Drawing.Size(171, 60);
            this.Logs_BLD_Fortigate.TabIndex = 21;
            this.Logs_BLD_Fortigate.Text = "Fortigate";
            this.Logs_BLD_Fortigate.UseVisualStyleBackColor = true;
            this.Logs_BLD_Fortigate.Click += new System.EventHandler(this.Logs_BLD_Fortigate_Click);
            // 
            // Logs_Velo
            // 
            this.Logs_Velo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Velo.Location = new System.Drawing.Point(780, 213);
            this.Logs_Velo.Name = "Logs_Velo";
            this.Logs_Velo.Size = new System.Drawing.Size(171, 60);
            this.Logs_Velo.TabIndex = 18;
            this.Logs_Velo.Text = "Velocloud";
            this.Logs_Velo.UseVisualStyleBackColor = true;
            this.Logs_Velo.Click += new System.EventHandler(this.Logs_Velo_Click);
            // 
            // Logs_SubTitle4
            // 
            this.Logs_SubTitle4.AutoSize = true;
            this.Logs_SubTitle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_SubTitle4.Location = new System.Drawing.Point(820, 101);
            this.Logs_SubTitle4.Name = "Logs_SubTitle4";
            this.Logs_SubTitle4.Size = new System.Drawing.Size(73, 25);
            this.Logs_SubTitle4.TabIndex = 17;
            this.Logs_SubTitle4.Text = "Outros";
            // 
            // Logs_SubTitle1
            // 
            this.Logs_SubTitle1.AutoSize = true;
            this.Logs_SubTitle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_SubTitle1.Location = new System.Drawing.Point(416, 101);
            this.Logs_SubTitle1.Name = "Logs_SubTitle1";
            this.Logs_SubTitle1.Size = new System.Drawing.Size(63, 25);
            this.Logs_SubTitle1.TabIndex = 16;
            this.Logs_SubTitle1.Text = "MPLS";
            // 
            // Logs_SubTitle0
            // 
            this.Logs_SubTitle0.AutoSize = true;
            this.Logs_SubTitle0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_SubTitle0.Location = new System.Drawing.Point(206, 101);
            this.Logs_SubTitle0.Name = "Logs_SubTitle0";
            this.Logs_SubTitle0.Size = new System.Drawing.Size(48, 25);
            this.Logs_SubTitle0.TabIndex = 15;
            this.Logs_SubTitle0.Text = "BLD";
            // 
            // Logs_HPE_MPLS
            // 
            this.Logs_HPE_MPLS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_HPE_MPLS.Location = new System.Drawing.Point(363, 213);
            this.Logs_HPE_MPLS.Name = "Logs_HPE_MPLS";
            this.Logs_HPE_MPLS.Size = new System.Drawing.Size(171, 60);
            this.Logs_HPE_MPLS.TabIndex = 14;
            this.Logs_HPE_MPLS.Text = "HPE";
            this.Logs_HPE_MPLS.UseVisualStyleBackColor = true;
            this.Logs_HPE_MPLS.Click += new System.EventHandler(this.NotImplemented);
            // 
            // Logs_Cisco_MPLS
            // 
            this.Logs_Cisco_MPLS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Cisco_MPLS.Location = new System.Drawing.Point(363, 144);
            this.Logs_Cisco_MPLS.Name = "Logs_Cisco_MPLS";
            this.Logs_Cisco_MPLS.Size = new System.Drawing.Size(171, 60);
            this.Logs_Cisco_MPLS.TabIndex = 13;
            this.Logs_Cisco_MPLS.Text = "Cisco";
            this.Logs_Cisco_MPLS.UseVisualStyleBackColor = true;
            this.Logs_Cisco_MPLS.Click += new System.EventHandler(this.NotImplemented);
            // 
            // LogsRow1
            // 
            this.LogsRow1.BackColor = System.Drawing.Color.Gray;
            this.LogsRow1.Location = new System.Drawing.Point(555, 121);
            this.LogsRow1.Name = "LogsRow1";
            this.LogsRow1.Size = new System.Drawing.Size(1, 303);
            this.LogsRow1.TabIndex = 12;
            this.LogsRow1.TabStop = false;
            // 
            // LogsRow0
            // 
            this.LogsRow0.BackColor = System.Drawing.Color.Gray;
            this.LogsRow0.Location = new System.Drawing.Point(340, 121);
            this.LogsRow0.Name = "LogsRow0";
            this.LogsRow0.Size = new System.Drawing.Size(1, 303);
            this.LogsRow0.TabIndex = 11;
            this.LogsRow0.TabStop = false;
            // 
            // Logs_VOZ_Aligera
            // 
            this.Logs_VOZ_Aligera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_VOZ_Aligera.Location = new System.Drawing.Point(574, 281);
            this.Logs_VOZ_Aligera.Name = "Logs_VOZ_Aligera";
            this.Logs_VOZ_Aligera.Size = new System.Drawing.Size(171, 60);
            this.Logs_VOZ_Aligera.TabIndex = 10;
            this.Logs_VOZ_Aligera.Text = "Aligera";
            this.Logs_VOZ_Aligera.UseVisualStyleBackColor = true;
            this.Logs_VOZ_Aligera.Click += new System.EventHandler(this.Logs_VOZ_Aligera_Click);
            // 
            // Logs_HPE_BLD
            // 
            this.Logs_HPE_BLD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_HPE_BLD.Location = new System.Drawing.Point(147, 213);
            this.Logs_HPE_BLD.Name = "Logs_HPE_BLD";
            this.Logs_HPE_BLD.Size = new System.Drawing.Size(171, 60);
            this.Logs_HPE_BLD.TabIndex = 9;
            this.Logs_HPE_BLD.Text = "HPE";
            this.Logs_HPE_BLD.UseVisualStyleBackColor = true;
            this.Logs_HPE_BLD.Click += new System.EventHandler(this.Logs_HPE_BLD_Click);
            // 
            // Logs_BackButton
            // 
            this.Logs_BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logs_BackButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_BackButton.Location = new System.Drawing.Point(985, 15);
            this.Logs_BackButton.Name = "Logs_BackButton";
            this.Logs_BackButton.Size = new System.Drawing.Size(104, 43);
            this.Logs_BackButton.TabIndex = 8;
            this.Logs_BackButton.Text = "Voltar";
            this.Logs_BackButton.UseVisualStyleBackColor = true;
            this.Logs_BackButton.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // Logs_Title
            // 
            this.Logs_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logs_Title.AutoSize = true;
            this.Logs_Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Logs_Title.Location = new System.Drawing.Point(519, 21);
            this.Logs_Title.Name = "Logs_Title";
            this.Logs_Title.Size = new System.Drawing.Size(90, 45);
            this.Logs_Title.TabIndex = 7;
            this.Logs_Title.Text = "Logs";
            this.Logs_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logs_Cisco_BLD
            // 
            this.Logs_Cisco_BLD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Cisco_BLD.Location = new System.Drawing.Point(147, 144);
            this.Logs_Cisco_BLD.Name = "Logs_Cisco_BLD";
            this.Logs_Cisco_BLD.Size = new System.Drawing.Size(171, 60);
            this.Logs_Cisco_BLD.TabIndex = 2;
            this.Logs_Cisco_BLD.Text = "Cisco";
            this.Logs_Cisco_BLD.UseVisualStyleBackColor = true;
            this.Logs_Cisco_BLD.Click += new System.EventHandler(this.Logs_Cisco_BLD_Click);
            // 
            // tabVelocloud
            // 
            this.tabVelocloud.Controls.Add(this.veloDeleteButton4);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton3);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton2);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton1);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton0);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton16);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton15);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton14);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton13);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton12);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton11);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton10);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton9);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton8);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton7);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton6);
            this.tabVelocloud.Controls.Add(this.veloDeleteButtonAll);
            this.tabVelocloud.Controls.Add(this.veloDeleteButton5);
            this.tabVelocloud.Controls.Add(this.buttonSwitchVeloLog);
            this.tabVelocloud.Controls.Add(this.labelVelocloudTitle);
            this.tabVelocloud.Controls.Add(this.veloTextBox16);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle16);
            this.tabVelocloud.Controls.Add(this.veloTextBoxFinal);
            this.tabVelocloud.Controls.Add(this.veloTextBox15);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle15);
            this.tabVelocloud.Controls.Add(this.veloTextBox14);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle14);
            this.tabVelocloud.Controls.Add(this.veloTextBox13);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle13);
            this.tabVelocloud.Controls.Add(this.veloTextBox12);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle12);
            this.tabVelocloud.Controls.Add(this.veloTextBox11);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle11);
            this.tabVelocloud.Controls.Add(this.veloTextBox10);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle10);
            this.tabVelocloud.Controls.Add(this.veloTextBox9);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle9);
            this.tabVelocloud.Controls.Add(this.veloTextBox8);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle8);
            this.tabVelocloud.Controls.Add(this.veloTextBox7);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle7);
            this.tabVelocloud.Controls.Add(this.veloTextBox6);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle6);
            this.tabVelocloud.Controls.Add(this.veloTextBox5);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle5);
            this.tabVelocloud.Controls.Add(this.veloTextBox4);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle4);
            this.tabVelocloud.Controls.Add(this.veloTextBox3);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle3);
            this.tabVelocloud.Controls.Add(this.veloTextBox2);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle2);
            this.tabVelocloud.Controls.Add(this.veloTextBox1);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle1);
            this.tabVelocloud.Controls.Add(this.veloTextBox0);
            this.tabVelocloud.Controls.Add(this.labelVeloSubtitle0);
            this.tabVelocloud.Controls.Add(this.HomeButton_Velo);
            this.tabVelocloud.Controls.Add(this.BackButton_Velo);
            this.tabVelocloud.Controls.Add(this.buttonVeloClear);
            this.tabVelocloud.Controls.Add(this.buttonVeloCopie);
            this.tabVelocloud.Location = new System.Drawing.Point(4, 5);
            this.tabVelocloud.Name = "tabVelocloud";
            this.tabVelocloud.Padding = new System.Windows.Forms.Padding(3);
            this.tabVelocloud.Size = new System.Drawing.Size(1105, 443);
            this.tabVelocloud.TabIndex = 6;
            this.tabVelocloud.Text = "tabPage1";
            this.tabVelocloud.UseVisualStyleBackColor = true;
            // 
            // veloDeleteButton4
            // 
            this.veloDeleteButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton4.Location = new System.Drawing.Point(184, 377);
            this.veloDeleteButton4.Name = "veloDeleteButton4";
            this.veloDeleteButton4.Size = new System.Drawing.Size(31, 32);
            this.veloDeleteButton4.TabIndex = 87;
            this.veloDeleteButton4.Text = "-";
            this.veloDeleteButton4.UseVisualStyleBackColor = true;
            this.veloDeleteButton4.Click += new System.EventHandler(this.veloDeleteButton4_Click);
            // 
            // veloDeleteButton3
            // 
            this.veloDeleteButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton3.Location = new System.Drawing.Point(184, 313);
            this.veloDeleteButton3.Name = "veloDeleteButton3";
            this.veloDeleteButton3.Size = new System.Drawing.Size(31, 32);
            this.veloDeleteButton3.TabIndex = 86;
            this.veloDeleteButton3.Text = "-";
            this.veloDeleteButton3.UseVisualStyleBackColor = true;
            this.veloDeleteButton3.Click += new System.EventHandler(this.veloDeleteButton3_Click);
            // 
            // veloDeleteButton2
            // 
            this.veloDeleteButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton2.Location = new System.Drawing.Point(184, 236);
            this.veloDeleteButton2.Name = "veloDeleteButton2";
            this.veloDeleteButton2.Size = new System.Drawing.Size(31, 32);
            this.veloDeleteButton2.TabIndex = 85;
            this.veloDeleteButton2.Text = "-";
            this.veloDeleteButton2.UseVisualStyleBackColor = true;
            this.veloDeleteButton2.Click += new System.EventHandler(this.veloDeleteButton2_Click);
            // 
            // veloDeleteButton1
            // 
            this.veloDeleteButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton1.Location = new System.Drawing.Point(184, 166);
            this.veloDeleteButton1.Name = "veloDeleteButton1";
            this.veloDeleteButton1.Size = new System.Drawing.Size(31, 32);
            this.veloDeleteButton1.TabIndex = 84;
            this.veloDeleteButton1.Text = "-";
            this.veloDeleteButton1.UseVisualStyleBackColor = true;
            this.veloDeleteButton1.Click += new System.EventHandler(this.veloDeleteButton1_Click);
            // 
            // veloDeleteButton0
            // 
            this.veloDeleteButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton0.Location = new System.Drawing.Point(184, 106);
            this.veloDeleteButton0.Name = "veloDeleteButton0";
            this.veloDeleteButton0.Size = new System.Drawing.Size(31, 32);
            this.veloDeleteButton0.TabIndex = 83;
            this.veloDeleteButton0.Text = "-";
            this.veloDeleteButton0.UseVisualStyleBackColor = true;
            this.veloDeleteButton0.Click += new System.EventHandler(this.veloDeleteButton0_Click);
            // 
            // veloDeleteButton16
            // 
            this.veloDeleteButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton16.Location = new System.Drawing.Point(838, 366);
            this.veloDeleteButton16.Name = "veloDeleteButton16";
            this.veloDeleteButton16.Size = new System.Drawing.Size(31, 46);
            this.veloDeleteButton16.TabIndex = 82;
            this.veloDeleteButton16.Text = "-";
            this.veloDeleteButton16.UseVisualStyleBackColor = true;
            this.veloDeleteButton16.Click += new System.EventHandler(this.veloDeleteButton16_Click);
            // 
            // veloDeleteButton15
            // 
            this.veloDeleteButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton15.Location = new System.Drawing.Point(838, 282);
            this.veloDeleteButton15.Name = "veloDeleteButton15";
            this.veloDeleteButton15.Size = new System.Drawing.Size(31, 46);
            this.veloDeleteButton15.TabIndex = 81;
            this.veloDeleteButton15.Text = "-";
            this.veloDeleteButton15.UseVisualStyleBackColor = true;
            this.veloDeleteButton15.Click += new System.EventHandler(this.veloDeleteButton15_Click);
            // 
            // veloDeleteButton14
            // 
            this.veloDeleteButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton14.Location = new System.Drawing.Point(838, 194);
            this.veloDeleteButton14.Name = "veloDeleteButton14";
            this.veloDeleteButton14.Size = new System.Drawing.Size(31, 46);
            this.veloDeleteButton14.TabIndex = 80;
            this.veloDeleteButton14.Text = "-";
            this.veloDeleteButton14.UseVisualStyleBackColor = true;
            this.veloDeleteButton14.Click += new System.EventHandler(this.veloDeleteButton14_Click);
            // 
            // veloDeleteButton13
            // 
            this.veloDeleteButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton13.Location = new System.Drawing.Point(838, 106);
            this.veloDeleteButton13.Name = "veloDeleteButton13";
            this.veloDeleteButton13.Size = new System.Drawing.Size(31, 47);
            this.veloDeleteButton13.TabIndex = 79;
            this.veloDeleteButton13.Text = "-";
            this.veloDeleteButton13.UseVisualStyleBackColor = true;
            this.veloDeleteButton13.Click += new System.EventHandler(this.veloDeleteButton13_Click);
            // 
            // veloDeleteButton12
            // 
            this.veloDeleteButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton12.Location = new System.Drawing.Point(625, 366);
            this.veloDeleteButton12.Name = "veloDeleteButton12";
            this.veloDeleteButton12.Size = new System.Drawing.Size(31, 43);
            this.veloDeleteButton12.TabIndex = 78;
            this.veloDeleteButton12.Text = "-";
            this.veloDeleteButton12.UseVisualStyleBackColor = true;
            this.veloDeleteButton12.Click += new System.EventHandler(this.veloDeleteButton12_Click);
            // 
            // veloDeleteButton11
            // 
            this.veloDeleteButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton11.Location = new System.Drawing.Point(625, 285);
            this.veloDeleteButton11.Name = "veloDeleteButton11";
            this.veloDeleteButton11.Size = new System.Drawing.Size(31, 43);
            this.veloDeleteButton11.TabIndex = 77;
            this.veloDeleteButton11.Text = "-";
            this.veloDeleteButton11.UseVisualStyleBackColor = true;
            this.veloDeleteButton11.Click += new System.EventHandler(this.veloDeleteButton11_Click);
            // 
            // veloDeleteButton10
            // 
            this.veloDeleteButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton10.Location = new System.Drawing.Point(625, 197);
            this.veloDeleteButton10.Name = "veloDeleteButton10";
            this.veloDeleteButton10.Size = new System.Drawing.Size(31, 43);
            this.veloDeleteButton10.TabIndex = 76;
            this.veloDeleteButton10.Text = "-";
            this.veloDeleteButton10.UseVisualStyleBackColor = true;
            this.veloDeleteButton10.Click += new System.EventHandler(this.veloDeleteButton10_Click);
            // 
            // veloDeleteButton9
            // 
            this.veloDeleteButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton9.Location = new System.Drawing.Point(625, 106);
            this.veloDeleteButton9.Name = "veloDeleteButton9";
            this.veloDeleteButton9.Size = new System.Drawing.Size(31, 47);
            this.veloDeleteButton9.TabIndex = 75;
            this.veloDeleteButton9.Text = "-";
            this.veloDeleteButton9.UseVisualStyleBackColor = true;
            this.veloDeleteButton9.Click += new System.EventHandler(this.veloDeleteButton9_Click);
            // 
            // veloDeleteButton8
            // 
            this.veloDeleteButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton8.Location = new System.Drawing.Point(403, 366);
            this.veloDeleteButton8.Name = "veloDeleteButton8";
            this.veloDeleteButton8.Size = new System.Drawing.Size(31, 46);
            this.veloDeleteButton8.TabIndex = 74;
            this.veloDeleteButton8.Text = "-";
            this.veloDeleteButton8.UseVisualStyleBackColor = true;
            this.veloDeleteButton8.Click += new System.EventHandler(this.veloDeleteButton8_Click);
            // 
            // veloDeleteButton7
            // 
            this.veloDeleteButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton7.Location = new System.Drawing.Point(403, 282);
            this.veloDeleteButton7.Name = "veloDeleteButton7";
            this.veloDeleteButton7.Size = new System.Drawing.Size(31, 46);
            this.veloDeleteButton7.TabIndex = 73;
            this.veloDeleteButton7.Text = "-";
            this.veloDeleteButton7.UseVisualStyleBackColor = true;
            this.veloDeleteButton7.Click += new System.EventHandler(this.veloDeleteButton7_Click);
            // 
            // veloDeleteButton6
            // 
            this.veloDeleteButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton6.Location = new System.Drawing.Point(403, 194);
            this.veloDeleteButton6.Name = "veloDeleteButton6";
            this.veloDeleteButton6.Size = new System.Drawing.Size(31, 46);
            this.veloDeleteButton6.TabIndex = 72;
            this.veloDeleteButton6.Text = "-";
            this.veloDeleteButton6.UseVisualStyleBackColor = true;
            this.veloDeleteButton6.Click += new System.EventHandler(this.veloDeleteButton6_Click);
            // 
            // veloDeleteButtonAll
            // 
            this.veloDeleteButtonAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButtonAll.Location = new System.Drawing.Point(822, 22);
            this.veloDeleteButtonAll.Name = "veloDeleteButtonAll";
            this.veloDeleteButtonAll.Size = new System.Drawing.Size(139, 43);
            this.veloDeleteButtonAll.TabIndex = 71;
            this.veloDeleteButtonAll.Text = "Limpar Campos";
            this.veloDeleteButtonAll.UseVisualStyleBackColor = true;
            this.veloDeleteButtonAll.Click += new System.EventHandler(this.veloDeleteButtonAll_Click);
            // 
            // veloDeleteButton5
            // 
            this.veloDeleteButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloDeleteButton5.Location = new System.Drawing.Point(403, 106);
            this.veloDeleteButton5.Name = "veloDeleteButton5";
            this.veloDeleteButton5.Size = new System.Drawing.Size(31, 47);
            this.veloDeleteButton5.TabIndex = 70;
            this.veloDeleteButton5.Text = "-";
            this.veloDeleteButton5.UseVisualStyleBackColor = true;
            this.veloDeleteButton5.Click += new System.EventHandler(this.veloDeleteButton5_Click);
            // 
            // buttonSwitchVeloLog
            // 
            this.buttonSwitchVeloLog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwitchVeloLog.Location = new System.Drawing.Point(145, 22);
            this.buttonSwitchVeloLog.Name = "buttonSwitchVeloLog";
            this.buttonSwitchVeloLog.Size = new System.Drawing.Size(104, 43);
            this.buttonSwitchVeloLog.TabIndex = 69;
            this.buttonSwitchVeloLog.Text = "Switch";
            this.buttonSwitchVeloLog.UseVisualStyleBackColor = true;
            this.buttonSwitchVeloLog.Click += new System.EventHandler(this.buttonSwitchVeloLog_Click);
            // 
            // labelVelocloudTitle
            // 
            this.labelVelocloudTitle.AutoSize = true;
            this.labelVelocloudTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocloudTitle.Location = new System.Drawing.Point(476, 25);
            this.labelVelocloudTitle.Name = "labelVelocloudTitle";
            this.labelVelocloudTitle.Size = new System.Drawing.Size(151, 32);
            this.labelVelocloudTitle.TabIndex = 68;
            this.labelVelocloudTitle.Text = "VELOCLOUD";
            // 
            // veloTextBox16
            // 
            this.veloTextBox16.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox16.Location = new System.Drawing.Point(667, 366);
            this.veloTextBox16.Multiline = true;
            this.veloTextBox16.Name = "veloTextBox16";
            this.veloTextBox16.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox16.TabIndex = 67;
            // 
            // labelVeloSubtitle16
            // 
            this.labelVeloSubtitle16.AutoSize = true;
            this.labelVeloSubtitle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle16.Location = new System.Drawing.Point(707, 346);
            this.labelVeloSubtitle16.Name = "labelVeloSubtitle16";
            this.labelVeloSubtitle16.Size = new System.Drawing.Size(97, 15);
            this.labelVeloSubtitle16.TabIndex = 66;
            this.labelVeloSubtitle16.Text = "Show BGP Table";
            // 
            // veloTextBoxFinal
            // 
            this.veloTextBoxFinal.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBoxFinal.Location = new System.Drawing.Point(889, 107);
            this.veloTextBoxFinal.Multiline = true;
            this.veloTextBoxFinal.Name = "veloTextBoxFinal";
            this.veloTextBoxFinal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.veloTextBoxFinal.Size = new System.Drawing.Size(208, 285);
            this.veloTextBoxFinal.TabIndex = 65;
            // 
            // veloTextBox15
            // 
            this.veloTextBox15.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox15.Location = new System.Drawing.Point(667, 282);
            this.veloTextBox15.Multiline = true;
            this.veloTextBox15.Name = "veloTextBox15";
            this.veloTextBox15.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox15.TabIndex = 64;
            // 
            // labelVeloSubtitle15
            // 
            this.labelVeloSubtitle15.AutoSize = true;
            this.labelVeloSubtitle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle15.Location = new System.Drawing.Point(662, 261);
            this.labelVeloSubtitle15.Name = "labelVeloSubtitle15";
            this.labelVeloSubtitle15.Size = new System.Drawing.Size(215, 15);
            this.labelVeloSubtitle15.TabIndex = 63;
            this.labelVeloSubtitle15.Text = "Show BGP Neighbors Learned Routes";
            // 
            // veloTextBox14
            // 
            this.veloTextBox14.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox14.Location = new System.Drawing.Point(667, 194);
            this.veloTextBox14.Multiline = true;
            this.veloTextBox14.Name = "veloTextBox14";
            this.veloTextBox14.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox14.TabIndex = 62;
            // 
            // labelVeloSubtitle14
            // 
            this.labelVeloSubtitle14.AutoSize = true;
            this.labelVeloSubtitle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle14.Location = new System.Drawing.Point(695, 173);
            this.labelVeloSubtitle14.Name = "labelVeloSubtitle14";
            this.labelVeloSubtitle14.Size = new System.Drawing.Size(121, 15);
            this.labelVeloSubtitle14.TabIndex = 61;
            this.labelVeloSubtitle14.Text = "Show BGP Summary";
            // 
            // veloTextBox13
            // 
            this.veloTextBox13.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox13.Location = new System.Drawing.Point(667, 107);
            this.veloTextBox13.Multiline = true;
            this.veloTextBox13.Name = "veloTextBox13";
            this.veloTextBox13.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox13.TabIndex = 60;
            // 
            // labelVeloSubtitle13
            // 
            this.labelVeloSubtitle13.AutoSize = true;
            this.labelVeloSubtitle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle13.Location = new System.Drawing.Point(735, 87);
            this.labelVeloSubtitle13.Name = "labelVeloSubtitle13";
            this.labelVeloSubtitle13.Size = new System.Drawing.Size(31, 15);
            this.labelVeloSubtitle13.TabIndex = 59;
            this.labelVeloSubtitle13.Text = "Ping";
            // 
            // veloTextBox12
            // 
            this.veloTextBox12.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox12.Location = new System.Drawing.Point(456, 366);
            this.veloTextBox12.Multiline = true;
            this.veloTextBox12.Name = "veloTextBox12";
            this.veloTextBox12.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox12.TabIndex = 58;
            // 
            // labelVeloSubtitle12
            // 
            this.labelVeloSubtitle12.AutoSize = true;
            this.labelVeloSubtitle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle12.Location = new System.Drawing.Point(518, 346);
            this.labelVeloSubtitle12.Name = "labelVeloSubtitle12";
            this.labelVeloSubtitle12.Size = new System.Drawing.Size(59, 15);
            this.labelVeloSubtitle12.TabIndex = 57;
            this.labelVeloSubtitle12.Text = "List Paths";
            // 
            // veloTextBox11
            // 
            this.veloTextBox11.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox11.Location = new System.Drawing.Point(456, 282);
            this.veloTextBox11.Multiline = true;
            this.veloTextBox11.Name = "veloTextBox11";
            this.veloTextBox11.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox11.TabIndex = 56;
            // 
            // labelVeloSubtitle11
            // 
            this.labelVeloSubtitle11.AutoSize = true;
            this.labelVeloSubtitle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle11.Location = new System.Drawing.Point(498, 263);
            this.labelVeloSubtitle11.Name = "labelVeloSubtitle11";
            this.labelVeloSubtitle11.Size = new System.Drawing.Size(97, 15);
            this.labelVeloSubtitle11.TabIndex = 55;
            this.labelVeloSubtitle11.Text = "Interface Status";
            // 
            // veloTextBox10
            // 
            this.veloTextBox10.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox10.Location = new System.Drawing.Point(456, 194);
            this.veloTextBox10.Multiline = true;
            this.veloTextBox10.Name = "veloTextBox10";
            this.veloTextBox10.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox10.TabIndex = 54;
            // 
            // labelVeloSubtitle10
            // 
            this.labelVeloSubtitle10.AutoSize = true;
            this.labelVeloSubtitle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle10.Location = new System.Drawing.Point(534, 175);
            this.labelVeloSubtitle10.Name = "labelVeloSubtitle10";
            this.labelVeloSubtitle10.Size = new System.Drawing.Size(24, 15);
            this.labelVeloSubtitle10.TabIndex = 53;
            this.labelVeloSubtitle10.Text = "HA";
            // 
            // veloTextBox9
            // 
            this.veloTextBox9.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox9.Location = new System.Drawing.Point(456, 107);
            this.veloTextBox9.Multiline = true;
            this.veloTextBox9.Name = "veloTextBox9";
            this.veloTextBox9.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox9.TabIndex = 52;
            // 
            // labelVeloSubtitle9
            // 
            this.labelVeloSubtitle9.AutoSize = true;
            this.labelVeloSubtitle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle9.Location = new System.Drawing.Point(515, 88);
            this.labelVeloSubtitle9.Name = "labelVeloSubtitle9";
            this.labelVeloSubtitle9.Size = new System.Drawing.Size(68, 15);
            this.labelVeloSubtitle9.TabIndex = 51;
            this.labelVeloSubtitle9.Text = "Tabela ARP";
            // 
            // veloTextBox8
            // 
            this.veloTextBox8.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox8.Location = new System.Drawing.Point(234, 366);
            this.veloTextBox8.Multiline = true;
            this.veloTextBox8.Name = "veloTextBox8";
            this.veloTextBox8.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox8.TabIndex = 50;
            // 
            // labelVeloSubtitle8
            // 
            this.labelVeloSubtitle8.AutoSize = true;
            this.labelVeloSubtitle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle8.Location = new System.Drawing.Point(308, 347);
            this.labelVeloSubtitle8.Name = "labelVeloSubtitle8";
            this.labelVeloSubtitle8.Size = new System.Drawing.Size(31, 15);
            this.labelVeloSubtitle8.TabIndex = 49;
            this.labelVeloSubtitle8.Text = "BGP";
            // 
            // veloTextBox7
            // 
            this.veloTextBox7.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox7.Location = new System.Drawing.Point(234, 282);
            this.veloTextBox7.Multiline = true;
            this.veloTextBox7.Name = "veloTextBox7";
            this.veloTextBox7.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox7.TabIndex = 48;
            // 
            // labelVeloSubtitle7
            // 
            this.labelVeloSubtitle7.AutoSize = true;
            this.labelVeloSubtitle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle7.Location = new System.Drawing.Point(283, 263);
            this.labelVeloSubtitle7.Name = "labelVeloSubtitle7";
            this.labelVeloSubtitle7.Size = new System.Drawing.Size(78, 15);
            this.labelVeloSubtitle7.TabIndex = 47;
            this.labelVeloSubtitle7.Text = "Rota Estática";
            // 
            // veloTextBox6
            // 
            this.veloTextBox6.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox6.Location = new System.Drawing.Point(234, 194);
            this.veloTextBox6.Multiline = true;
            this.veloTextBox6.Name = "veloTextBox6";
            this.veloTextBox6.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox6.TabIndex = 46;
            // 
            // labelVeloSubtitle6
            // 
            this.labelVeloSubtitle6.AutoSize = true;
            this.labelVeloSubtitle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle6.Location = new System.Drawing.Point(283, 175);
            this.labelVeloSubtitle6.Name = "labelVeloSubtitle6";
            this.labelVeloSubtitle6.Size = new System.Drawing.Size(87, 15);
            this.labelVeloSubtitle6.TabIndex = 45;
            this.labelVeloSubtitle6.Text = "Sobreposições";
            // 
            // veloTextBox5
            // 
            this.veloTextBox5.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox5.Location = new System.Drawing.Point(234, 107);
            this.veloTextBox5.Multiline = true;
            this.veloTextBox5.Name = "veloTextBox5";
            this.veloTextBox5.Size = new System.Drawing.Size(168, 46);
            this.veloTextBox5.TabIndex = 44;
            // 
            // labelVeloSubtitle5
            // 
            this.labelVeloSubtitle5.AutoSize = true;
            this.labelVeloSubtitle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle5.Location = new System.Drawing.Point(273, 88);
            this.labelVeloSubtitle5.Name = "labelVeloSubtitle5";
            this.labelVeloSubtitle5.Size = new System.Drawing.Size(101, 15);
            this.labelVeloSubtitle5.TabIndex = 43;
            this.labelVeloSubtitle5.Text = "Interfaces Físicas";
            // 
            // veloTextBox4
            // 
            this.veloTextBox4.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox4.Location = new System.Drawing.Point(18, 375);
            this.veloTextBox4.Multiline = true;
            this.veloTextBox4.Name = "veloTextBox4";
            this.veloTextBox4.Size = new System.Drawing.Size(160, 37);
            this.veloTextBox4.TabIndex = 42;
            // 
            // labelVeloSubtitle4
            // 
            this.labelVeloSubtitle4.AutoSize = true;
            this.labelVeloSubtitle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle4.Location = new System.Drawing.Point(75, 356);
            this.labelVeloSubtitle4.Name = "labelVeloSubtitle4";
            this.labelVeloSubtitle4.Size = new System.Drawing.Size(60, 15);
            this.labelVeloSubtitle4.TabIndex = 41;
            this.labelVeloSubtitle4.Text = "Loopback";
            // 
            // veloTextBox3
            // 
            this.veloTextBox3.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox3.Location = new System.Drawing.Point(18, 313);
            this.veloTextBox3.Multiline = true;
            this.veloTextBox3.Name = "veloTextBox3";
            this.veloTextBox3.Size = new System.Drawing.Size(160, 32);
            this.veloTextBox3.TabIndex = 40;
            // 
            // labelVeloSubtitle3
            // 
            this.labelVeloSubtitle3.AutoSize = true;
            this.labelVeloSubtitle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle3.Location = new System.Drawing.Point(36, 293);
            this.labelVeloSubtitle3.Name = "labelVeloSubtitle3";
            this.labelVeloSubtitle3.Size = new System.Drawing.Size(129, 15);
            this.labelVeloSubtitle3.TabIndex = 39;
            this.labelVeloSubtitle3.Text = "Configuração de Vlans";
            // 
            // veloTextBox2
            // 
            this.veloTextBox2.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox2.Location = new System.Drawing.Point(18, 236);
            this.veloTextBox2.Multiline = true;
            this.veloTextBox2.Name = "veloTextBox2";
            this.veloTextBox2.Size = new System.Drawing.Size(160, 32);
            this.veloTextBox2.TabIndex = 38;
            // 
            // labelVeloSubtitle2
            // 
            this.labelVeloSubtitle2.AutoSize = true;
            this.labelVeloSubtitle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle2.Location = new System.Drawing.Point(49, 216);
            this.labelVeloSubtitle2.Name = "labelVeloSubtitle2";
            this.labelVeloSubtitle2.Size = new System.Drawing.Size(104, 15);
            this.labelVeloSubtitle2.TabIndex = 37;
            this.labelVeloSubtitle2.Text = "Estado de Ligação";
            // 
            // veloTextBox1
            // 
            this.veloTextBox1.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox1.Location = new System.Drawing.Point(18, 166);
            this.veloTextBox1.Multiline = true;
            this.veloTextBox1.Name = "veloTextBox1";
            this.veloTextBox1.Size = new System.Drawing.Size(160, 32);
            this.veloTextBox1.TabIndex = 36;
            // 
            // labelVeloSubtitle1
            // 
            this.labelVeloSubtitle1.AutoSize = true;
            this.labelVeloSubtitle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle1.Location = new System.Drawing.Point(77, 147);
            this.labelVeloSubtitle1.Name = "labelVeloSubtitle1";
            this.labelVeloSubtitle1.Size = new System.Drawing.Size(50, 15);
            this.labelVeloSubtitle1.TabIndex = 35;
            this.labelVeloSubtitle1.Text = "NodeID";
            // 
            // veloTextBox0
            // 
            this.veloTextBox0.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veloTextBox0.Location = new System.Drawing.Point(18, 106);
            this.veloTextBox0.Multiline = true;
            this.veloTextBox0.Name = "veloTextBox0";
            this.veloTextBox0.Size = new System.Drawing.Size(160, 32);
            this.veloTextBox0.TabIndex = 34;
            // 
            // labelVeloSubtitle0
            // 
            this.labelVeloSubtitle0.AutoSize = true;
            this.labelVeloSubtitle0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeloSubtitle0.Location = new System.Drawing.Point(71, 87);
            this.labelVeloSubtitle0.Name = "labelVeloSubtitle0";
            this.labelVeloSubtitle0.Size = new System.Drawing.Size(64, 15);
            this.labelVeloSubtitle0.TabIndex = 33;
            this.labelVeloSubtitle0.Text = "Hostname";
            // 
            // HomeButton_Velo
            // 
            this.HomeButton_Velo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton_Velo.Location = new System.Drawing.Point(18, 22);
            this.HomeButton_Velo.Name = "HomeButton_Velo";
            this.HomeButton_Velo.Size = new System.Drawing.Size(104, 43);
            this.HomeButton_Velo.TabIndex = 32;
            this.HomeButton_Velo.Text = "Home";
            this.HomeButton_Velo.UseVisualStyleBackColor = true;
            this.HomeButton_Velo.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // BackButton_Velo
            // 
            this.BackButton_Velo.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackButton_Velo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_Velo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton_Velo.Location = new System.Drawing.Point(977, 22);
            this.BackButton_Velo.Name = "BackButton_Velo";
            this.BackButton_Velo.Size = new System.Drawing.Size(104, 43);
            this.BackButton_Velo.TabIndex = 31;
            this.BackButton_Velo.Text = "Voltar";
            this.BackButton_Velo.UseVisualStyleBackColor = false;
            this.BackButton_Velo.Click += new System.EventHandler(this.BackButton_Velo_Click);
            // 
            // buttonVeloClear
            // 
            this.buttonVeloClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVeloClear.Location = new System.Drawing.Point(889, 398);
            this.buttonVeloClear.Name = "buttonVeloClear";
            this.buttonVeloClear.Size = new System.Drawing.Size(101, 39);
            this.buttonVeloClear.TabIndex = 1;
            this.buttonVeloClear.Text = "Limpar";
            this.buttonVeloClear.UseVisualStyleBackColor = true;
            this.buttonVeloClear.Click += new System.EventHandler(this.buttonVeloClear_Click);
            // 
            // buttonVeloCopie
            // 
            this.buttonVeloCopie.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVeloCopie.Location = new System.Drawing.Point(996, 398);
            this.buttonVeloCopie.Name = "buttonVeloCopie";
            this.buttonVeloCopie.Size = new System.Drawing.Size(101, 39);
            this.buttonVeloCopie.TabIndex = 0;
            this.buttonVeloCopie.Text = "Formatar e Copiar";
            this.buttonVeloCopie.UseVisualStyleBackColor = true;
            this.buttonVeloCopie.Click += new System.EventHandler(this.buttonVeloCopie_Click);
            // 
            // tabLigacoes
            // 
            this.tabLigacoes.Controls.Add(this.Ligacoes_BHPE_Antigo);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BLogs);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BDigistar);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BCisco);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BHPE);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BDebug);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BAligera);
            this.tabLigacoes.Controls.Add(this.Ligacoes_BExemplos);
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
            this.tabLigacoes.Controls.Add(this.Ligacoes_TB5);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle5);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TB6);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle6);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TB4);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle4);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TB3);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle3);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TB2);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle2);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TB1);
            this.tabLigacoes.Controls.Add(this.Ligacoes_TBFinal);
            this.tabLigacoes.Controls.Add(this.Ligacoes_SubTitle1);
            this.tabLigacoes.Location = new System.Drawing.Point(4, 5);
            this.tabLigacoes.Name = "tabLigacoes";
            this.tabLigacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabLigacoes.Size = new System.Drawing.Size(1105, 443);
            this.tabLigacoes.TabIndex = 7;
            this.tabLigacoes.Text = "tabLigacoes";
            this.tabLigacoes.UseVisualStyleBackColor = true;
            // 
            // Ligacoes_BHPE_Antigo
            // 
            this.Ligacoes_BHPE_Antigo.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BHPE_Antigo.Location = new System.Drawing.Point(608, 221);
            this.Ligacoes_BHPE_Antigo.Name = "Ligacoes_BHPE_Antigo";
            this.Ligacoes_BHPE_Antigo.Size = new System.Drawing.Size(66, 44);
            this.Ligacoes_BHPE_Antigo.TabIndex = 34;
            this.Ligacoes_BHPE_Antigo.Text = "Coleta HPE (Antigo)";
            this.Ligacoes_BHPE_Antigo.UseVisualStyleBackColor = true;
            this.Ligacoes_BHPE_Antigo.Click += new System.EventHandler(this.Ligacoes_BHPE_Antigo_Click);
            // 
            // Ligacoes_BLogs
            // 
            this.Ligacoes_BLogs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BLogs.Location = new System.Drawing.Point(985, 8);
            this.Ligacoes_BLogs.Name = "Ligacoes_BLogs";
            this.Ligacoes_BLogs.Size = new System.Drawing.Size(104, 41);
            this.Ligacoes_BLogs.TabIndex = 33;
            this.Ligacoes_BLogs.Text = "Logs Finais";
            this.Ligacoes_BLogs.UseVisualStyleBackColor = true;
            this.Ligacoes_BLogs.Click += new System.EventHandler(this.Logs_Finais_Click);
            // 
            // Ligacoes_BDigistar
            // 
            this.Ligacoes_BDigistar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BDigistar.Location = new System.Drawing.Point(608, 323);
            this.Ligacoes_BDigistar.Name = "Ligacoes_BDigistar";
            this.Ligacoes_BDigistar.Size = new System.Drawing.Size(66, 44);
            this.Ligacoes_BDigistar.TabIndex = 32;
            this.Ligacoes_BDigistar.Text = "Coleta Digistar";
            this.Ligacoes_BDigistar.UseVisualStyleBackColor = true;
            this.Ligacoes_BDigistar.Click += new System.EventHandler(this.Ligacoes_BDigistar_Click);
            // 
            // Ligacoes_BCisco
            // 
            this.Ligacoes_BCisco.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BCisco.Location = new System.Drawing.Point(608, 272);
            this.Ligacoes_BCisco.Name = "Ligacoes_BCisco";
            this.Ligacoes_BCisco.Size = new System.Drawing.Size(66, 44);
            this.Ligacoes_BCisco.TabIndex = 31;
            this.Ligacoes_BCisco.Text = "Coleta Cisco";
            this.Ligacoes_BCisco.UseVisualStyleBackColor = true;
            this.Ligacoes_BCisco.Click += new System.EventHandler(this.Ligacoes_BCisco_Click);
            // 
            // Ligacoes_BHPE
            // 
            this.Ligacoes_BHPE.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BHPE.Location = new System.Drawing.Point(608, 171);
            this.Ligacoes_BHPE.Name = "Ligacoes_BHPE";
            this.Ligacoes_BHPE.Size = new System.Drawing.Size(66, 44);
            this.Ligacoes_BHPE.TabIndex = 30;
            this.Ligacoes_BHPE.Text = "Coleta HPE";
            this.Ligacoes_BHPE.UseVisualStyleBackColor = true;
            this.Ligacoes_BHPE.Click += new System.EventHandler(this.Ligacoes_BHPE_Click);
            // 
            // Ligacoes_BDebug
            // 
            this.Ligacoes_BDebug.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BDebug.Location = new System.Drawing.Point(608, 374);
            this.Ligacoes_BDebug.Name = "Ligacoes_BDebug";
            this.Ligacoes_BDebug.Size = new System.Drawing.Size(66, 52);
            this.Ligacoes_BDebug.TabIndex = 29;
            this.Ligacoes_BDebug.Text = "Debug";
            this.Ligacoes_BDebug.UseVisualStyleBackColor = true;
            this.Ligacoes_BDebug.Click += new System.EventHandler(this.Ligacoes_BDebug_Click);
            // 
            // Ligacoes_BAligera
            // 
            this.Ligacoes_BAligera.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BAligera.Location = new System.Drawing.Point(608, 121);
            this.Ligacoes_BAligera.Name = "Ligacoes_BAligera";
            this.Ligacoes_BAligera.Size = new System.Drawing.Size(66, 44);
            this.Ligacoes_BAligera.TabIndex = 26;
            this.Ligacoes_BAligera.Text = "Coleta Aligera";
            this.Ligacoes_BAligera.UseVisualStyleBackColor = true;
            this.Ligacoes_BAligera.Click += new System.EventHandler(this.Ligacoes_BAligera_Click);
            // 
            // Ligacoes_BExemplos
            // 
            this.Ligacoes_BExemplos.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BExemplos.Location = new System.Drawing.Point(608, 53);
            this.Ligacoes_BExemplos.Name = "Ligacoes_BExemplos";
            this.Ligacoes_BExemplos.Size = new System.Drawing.Size(66, 62);
            this.Ligacoes_BExemplos.TabIndex = 25;
            this.Ligacoes_BExemplos.Text = "Numeros de Exemplo";
            this.Ligacoes_BExemplos.UseVisualStyleBackColor = true;
            this.Ligacoes_BExemplos.Click += new System.EventHandler(this.Ligacoes_BExemplos_Click);
            // 
            // HomeButton_Ligacoes
            // 
            this.HomeButton_Ligacoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton_Ligacoes.Location = new System.Drawing.Point(6, 6);
            this.HomeButton_Ligacoes.Name = "HomeButton_Ligacoes";
            this.HomeButton_Ligacoes.Size = new System.Drawing.Size(104, 43);
            this.HomeButton_Ligacoes.TabIndex = 24;
            this.HomeButton_Ligacoes.Text = "Home";
            this.HomeButton_Ligacoes.UseVisualStyleBackColor = true;
            this.HomeButton_Ligacoes.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // Ligacoes_Title
            // 
            this.Ligacoes_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ligacoes_Title.AutoSize = true;
            this.Ligacoes_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ligacoes_Title.Location = new System.Drawing.Point(204, 19);
            this.Ligacoes_Title.Name = "Ligacoes_Title";
            this.Ligacoes_Title.Size = new System.Drawing.Size(268, 37);
            this.Ligacoes_Title.TabIndex = 23;
            this.Ligacoes_Title.Text = "Logs de Ligação";
            this.Ligacoes_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ligacoes_BRestore
            // 
            this.Ligacoes_BRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BRestore.Location = new System.Drawing.Point(689, 385);
            this.Ligacoes_BRestore.Name = "Ligacoes_BRestore";
            this.Ligacoes_BRestore.Size = new System.Drawing.Size(90, 40);
            this.Ligacoes_BRestore.TabIndex = 22;
            this.Ligacoes_BRestore.Text = "Restore";
            this.Ligacoes_BRestore.UseVisualStyleBackColor = true;
            this.Ligacoes_BRestore.Click += new System.EventHandler(this.Ligacoes_BRestore_Click);
            // 
            // Ligacoes_BCopy
            // 
            this.Ligacoes_BCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BCopy.Location = new System.Drawing.Point(999, 385);
            this.Ligacoes_BCopy.Name = "Ligacoes_BCopy";
            this.Ligacoes_BCopy.Size = new System.Drawing.Size(90, 40);
            this.Ligacoes_BCopy.TabIndex = 21;
            this.Ligacoes_BCopy.Text = "Formatar e Copiar";
            this.Ligacoes_BCopy.UseVisualStyleBackColor = true;
            this.Ligacoes_BCopy.Click += new System.EventHandler(this.Ligacoes_BCopy_Click);
            // 
            // Ligacoes_BFormat
            // 
            this.Ligacoes_BFormat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BFormat.Location = new System.Drawing.Point(897, 385);
            this.Ligacoes_BFormat.Name = "Ligacoes_BFormat";
            this.Ligacoes_BFormat.Size = new System.Drawing.Size(90, 40);
            this.Ligacoes_BFormat.TabIndex = 20;
            this.Ligacoes_BFormat.Text = "Formatar";
            this.Ligacoes_BFormat.UseVisualStyleBackColor = true;
            this.Ligacoes_BFormat.Click += new System.EventHandler(this.Ligacoes_BFormat_Click);
            // 
            // Ligacoes_BClear
            // 
            this.Ligacoes_BClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_BClear.Location = new System.Drawing.Point(794, 385);
            this.Ligacoes_BClear.Name = "Ligacoes_BClear";
            this.Ligacoes_BClear.Size = new System.Drawing.Size(90, 40);
            this.Ligacoes_BClear.TabIndex = 19;
            this.Ligacoes_BClear.Text = "Limpar";
            this.Ligacoes_BClear.UseVisualStyleBackColor = true;
            this.Ligacoes_BClear.Click += new System.EventHandler(this.Ligacoes_BClear_Click);
            // 
            // Ligacoes_Clear3
            // 
            this.Ligacoes_Clear3.Location = new System.Drawing.Point(234, 318);
            this.Ligacoes_Clear3.Name = "Ligacoes_Clear3";
            this.Ligacoes_Clear3.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear3.TabIndex = 18;
            this.Ligacoes_Clear3.Text = "Limpar";
            this.Ligacoes_Clear3.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear3.Click += new System.EventHandler(this.Ligacoes_Clear3_Click);
            // 
            // Ligacoes_Clear2
            // 
            this.Ligacoes_Clear2.Location = new System.Drawing.Point(234, 200);
            this.Ligacoes_Clear2.Name = "Ligacoes_Clear2";
            this.Ligacoes_Clear2.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear2.TabIndex = 17;
            this.Ligacoes_Clear2.Text = "Limpar";
            this.Ligacoes_Clear2.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear2.Click += new System.EventHandler(this.Ligacoes_Clear2_Click);
            // 
            // Ligacoes_Clear1
            // 
            this.Ligacoes_Clear1.Location = new System.Drawing.Point(234, 84);
            this.Ligacoes_Clear1.Name = "Ligacoes_Clear1";
            this.Ligacoes_Clear1.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear1.TabIndex = 16;
            this.Ligacoes_Clear1.Text = "Limpar";
            this.Ligacoes_Clear1.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear1.Click += new System.EventHandler(this.Ligacoes_Clear1_Click);
            // 
            // Ligacoes_Clear4
            // 
            this.Ligacoes_Clear4.Location = new System.Drawing.Point(524, 84);
            this.Ligacoes_Clear4.Name = "Ligacoes_Clear4";
            this.Ligacoes_Clear4.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear4.TabIndex = 15;
            this.Ligacoes_Clear4.Text = "Limpar";
            this.Ligacoes_Clear4.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear4.Click += new System.EventHandler(this.Ligacoes_Clear4_Click);
            // 
            // Ligacoes_Clear5
            // 
            this.Ligacoes_Clear5.Location = new System.Drawing.Point(524, 200);
            this.Ligacoes_Clear5.Name = "Ligacoes_Clear5";
            this.Ligacoes_Clear5.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear5.TabIndex = 14;
            this.Ligacoes_Clear5.Text = "Limpar";
            this.Ligacoes_Clear5.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear5.Click += new System.EventHandler(this.Ligacoes_Clear5_Click);
            // 
            // Ligacoes_Clear6
            // 
            this.Ligacoes_Clear6.Location = new System.Drawing.Point(524, 318);
            this.Ligacoes_Clear6.Name = "Ligacoes_Clear6";
            this.Ligacoes_Clear6.Size = new System.Drawing.Size(67, 24);
            this.Ligacoes_Clear6.TabIndex = 13;
            this.Ligacoes_Clear6.Text = "Limpar";
            this.Ligacoes_Clear6.UseVisualStyleBackColor = true;
            this.Ligacoes_Clear6.Click += new System.EventHandler(this.Ligacoes_Clear6_Click);
            // 
            // Ligacoes_TB5
            // 
            this.Ligacoes_TB5.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TB5.Location = new System.Drawing.Point(329, 224);
            this.Ligacoes_TB5.Multiline = true;
            this.Ligacoes_TB5.Name = "Ligacoes_TB5";
            this.Ligacoes_TB5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TB5.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TB5.TabIndex = 12;
            // 
            // Ligacoes_SubTitle5
            // 
            this.Ligacoes_SubTitle5.AutoSize = true;
            this.Ligacoes_SubTitle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle5.Location = new System.Drawing.Point(418, 200);
            this.Ligacoes_SubTitle5.Name = "Ligacoes_SubTitle5";
            this.Ligacoes_SubTitle5.Size = new System.Drawing.Size(78, 21);
            this.Ligacoes_SubTitle5.TabIndex = 11;
            this.Ligacoes_SubTitle5.Text = "3 Dígitos";
            // 
            // Ligacoes_TB6
            // 
            this.Ligacoes_TB6.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TB6.Location = new System.Drawing.Point(329, 342);
            this.Ligacoes_TB6.Multiline = true;
            this.Ligacoes_TB6.Name = "Ligacoes_TB6";
            this.Ligacoes_TB6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TB6.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TB6.TabIndex = 8;
            // 
            // Ligacoes_SubTitle6
            // 
            this.Ligacoes_SubTitle6.AutoSize = true;
            this.Ligacoes_SubTitle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle6.Location = new System.Drawing.Point(422, 318);
            this.Ligacoes_SubTitle6.Name = "Ligacoes_SubTitle6";
            this.Ligacoes_SubTitle6.Size = new System.Drawing.Size(69, 21);
            this.Ligacoes_SubTitle6.TabIndex = 7;
            this.Ligacoes_SubTitle6.Text = "Entrada";
            // 
            // Ligacoes_TB4
            // 
            this.Ligacoes_TB4.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TB4.Location = new System.Drawing.Point(329, 108);
            this.Ligacoes_TB4.Multiline = true;
            this.Ligacoes_TB4.Name = "Ligacoes_TB4";
            this.Ligacoes_TB4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TB4.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TB4.TabIndex = 10;
            // 
            // Ligacoes_SubTitle4
            // 
            this.Ligacoes_SubTitle4.AutoSize = true;
            this.Ligacoes_SubTitle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle4.Location = new System.Drawing.Point(431, 84);
            this.Ligacoes_SubTitle4.Name = "Ligacoes_SubTitle4";
            this.Ligacoes_SubTitle4.Size = new System.Drawing.Size(46, 21);
            this.Ligacoes_SubTitle4.TabIndex = 9;
            this.Ligacoes_SubTitle4.Text = "0800";
            // 
            // Ligacoes_TB3
            // 
            this.Ligacoes_TB3.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TB3.Location = new System.Drawing.Point(39, 342);
            this.Ligacoes_TB3.Multiline = true;
            this.Ligacoes_TB3.Name = "Ligacoes_TB3";
            this.Ligacoes_TB3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TB3.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TB3.TabIndex = 6;
            // 
            // Ligacoes_SubTitle3
            // 
            this.Ligacoes_SubTitle3.AutoSize = true;
            this.Ligacoes_SubTitle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle3.Location = new System.Drawing.Point(127, 318);
            this.Ligacoes_SubTitle3.Name = "Ligacoes_SubTitle3";
            this.Ligacoes_SubTitle3.Size = new System.Drawing.Size(64, 21);
            this.Ligacoes_SubTitle3.TabIndex = 5;
            this.Ligacoes_SubTitle3.Text = "Celular";
            // 
            // Ligacoes_TB2
            // 
            this.Ligacoes_TB2.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TB2.Location = new System.Drawing.Point(39, 224);
            this.Ligacoes_TB2.Multiline = true;
            this.Ligacoes_TB2.Name = "Ligacoes_TB2";
            this.Ligacoes_TB2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TB2.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TB2.TabIndex = 4;
            // 
            // Ligacoes_SubTitle2
            // 
            this.Ligacoes_SubTitle2.AutoSize = true;
            this.Ligacoes_SubTitle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle2.Location = new System.Drawing.Point(141, 200);
            this.Ligacoes_SubTitle2.Name = "Ligacoes_SubTitle2";
            this.Ligacoes_SubTitle2.Size = new System.Drawing.Size(46, 21);
            this.Ligacoes_SubTitle2.TabIndex = 3;
            this.Ligacoes_SubTitle2.Text = "DDD";
            // 
            // Ligacoes_TB1
            // 
            this.Ligacoes_TB1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TB1.Location = new System.Drawing.Point(39, 108);
            this.Ligacoes_TB1.Multiline = true;
            this.Ligacoes_TB1.Name = "Ligacoes_TB1";
            this.Ligacoes_TB1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TB1.Size = new System.Drawing.Size(262, 83);
            this.Ligacoes_TB1.TabIndex = 2;
            // 
            // Ligacoes_TBFinal
            // 
            this.Ligacoes_TBFinal.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_TBFinal.Location = new System.Drawing.Point(689, 53);
            this.Ligacoes_TBFinal.Multiline = true;
            this.Ligacoes_TBFinal.Name = "Ligacoes_TBFinal";
            this.Ligacoes_TBFinal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ligacoes_TBFinal.Size = new System.Drawing.Size(400, 325);
            this.Ligacoes_TBFinal.TabIndex = 1;
            // 
            // Ligacoes_SubTitle1
            // 
            this.Ligacoes_SubTitle1.AutoSize = true;
            this.Ligacoes_SubTitle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ligacoes_SubTitle1.Location = new System.Drawing.Point(121, 84);
            this.Ligacoes_SubTitle1.Name = "Ligacoes_SubTitle1";
            this.Ligacoes_SubTitle1.Size = new System.Drawing.Size(86, 21);
            this.Ligacoes_SubTitle1.TabIndex = 0;
            this.Ligacoes_SubTitle1.Text = "Fixo Local";
            // 
            // tabRouters
            // 
            this.tabRouters.Controls.Add(tabControl3);
            this.tabRouters.Location = new System.Drawing.Point(4, 22);
            this.tabRouters.Name = "tabRouters";
            this.tabRouters.Padding = new System.Windows.Forms.Padding(3);
            this.tabRouters.Size = new System.Drawing.Size(1119, 529);
            this.tabRouters.TabIndex = 1;
            this.tabRouters.Text = "Routers";
            this.tabRouters.UseVisualStyleBackColor = true;
            // 
            // tabLogTools
            // 
            this.tabLogTools.Controls.Add(this.LogToolsCalc);
            this.tabLogTools.Controls.Add(this.LogToolsSuporte);
            this.tabLogTools.Controls.Add(this.LogToolsFechamento);
            this.tabLogTools.Controls.Add(this.LogToolsPendencia);
            this.tabLogTools.Controls.Add(this.tabControlLogTools);
            this.tabLogTools.Location = new System.Drawing.Point(4, 22);
            this.tabLogTools.Name = "tabLogTools";
            this.tabLogTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogTools.Size = new System.Drawing.Size(1119, 529);
            this.tabLogTools.TabIndex = 2;
            this.tabLogTools.Text = "LogTools";
            this.tabLogTools.UseVisualStyleBackColor = true;
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
            this.LogToolsCalc.Click += new System.EventHandler(this.button4_Click);
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
            this.tabControlLogTools.Controls.Add(this.tabPendencia);
            this.tabControlLogTools.Controls.Add(this.tabSuporte);
            this.tabControlLogTools.Controls.Add(this.tabFechamento);
            this.tabControlLogTools.Controls.Add(this.tabCalculadoraDeIP);
            this.tabControlLogTools.Location = new System.Drawing.Point(157, 6);
            this.tabControlLogTools.Name = "tabControlLogTools";
            this.tabControlLogTools.SelectedIndex = 0;
            this.tabControlLogTools.Size = new System.Drawing.Size(962, 527);
            this.tabControlLogTools.TabIndex = 11;
            // 
            // tabPendencia
            // 
            this.tabPendencia.Controls.Add(this.Log_Copy);
            this.tabPendencia.Controls.Add(this.Log_Clear3);
            this.tabPendencia.Controls.Add(this.Log_Clear2);
            this.tabPendencia.Controls.Add(this.Log_Clear1);
            this.tabPendencia.Controls.Add(this.Log_FinalTextBox);
            this.tabPendencia.Controls.Add(this.Log_CopyF);
            this.tabPendencia.Controls.Add(this.Log_ClearAll);
            this.tabPendencia.Controls.Add(this.Log_Format);
            this.tabPendencia.Controls.Add(this.Log_TextBox3);
            this.tabPendencia.Controls.Add(this.Log_ProximosPassos);
            this.tabPendencia.Controls.Add(this.Log_TextBox2);
            this.tabPendencia.Controls.Add(this.Log_StatusAtual);
            this.tabPendencia.Controls.Add(this.Log_TextBox1);
            this.tabPendencia.Controls.Add(this.Log_StatusAnterior);
            this.tabPendencia.Location = new System.Drawing.Point(4, 22);
            this.tabPendencia.Name = "tabPendencia";
            this.tabPendencia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPendencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPendencia.Size = new System.Drawing.Size(954, 501);
            this.tabPendencia.TabIndex = 0;
            this.tabPendencia.Text = "Pendencia";
            this.tabPendencia.UseVisualStyleBackColor = true;
            // 
            // Log_Copy
            // 
            this.Log_Copy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Copy.Location = new System.Drawing.Point(809, 25);
            this.Log_Copy.Name = "Log_Copy";
            this.Log_Copy.Size = new System.Drawing.Size(120, 40);
            this.Log_Copy.TabIndex = 16;
            this.Log_Copy.Text = "Copiar";
            this.Log_Copy.UseVisualStyleBackColor = true;
            this.Log_Copy.Click += new System.EventHandler(this.Log_Copy_Click_2);
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
            // Log_FinalTextBox
            // 
            this.Log_FinalTextBox.AllowDrop = true;
            this.Log_FinalTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_FinalTextBox.Location = new System.Drawing.Point(460, 25);
            this.Log_FinalTextBox.Multiline = true;
            this.Log_FinalTextBox.Name = "Log_FinalTextBox";
            this.Log_FinalTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Log_FinalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log_FinalTextBox.Size = new System.Drawing.Size(469, 454);
            this.Log_FinalTextBox.TabIndex = 12;
            this.Log_FinalTextBox.WordWrap = false;
            // 
            // Log_CopyF
            // 
            this.Log_CopyF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_CopyF.Location = new System.Drawing.Point(305, 445);
            this.Log_CopyF.Name = "Log_CopyF";
            this.Log_CopyF.Size = new System.Drawing.Size(120, 40);
            this.Log_CopyF.TabIndex = 12;
            this.Log_CopyF.Text = "Formatar e Copiar";
            this.Log_CopyF.UseVisualStyleBackColor = true;
            this.Log_CopyF.Click += new System.EventHandler(this.Log_Copy_Click_1);
            // 
            // Log_ClearAll
            // 
            this.Log_ClearAll.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_ClearAll.Location = new System.Drawing.Point(33, 445);
            this.Log_ClearAll.Name = "Log_ClearAll";
            this.Log_ClearAll.Size = new System.Drawing.Size(120, 40);
            this.Log_ClearAll.TabIndex = 11;
            this.Log_ClearAll.Text = "Limpar";
            this.Log_ClearAll.UseVisualStyleBackColor = true;
            this.Log_ClearAll.Click += new System.EventHandler(this.Log_Clear_Click);
            // 
            // Log_Format
            // 
            this.Log_Format.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Format.Location = new System.Drawing.Point(170, 445);
            this.Log_Format.Name = "Log_Format";
            this.Log_Format.Size = new System.Drawing.Size(120, 40);
            this.Log_Format.TabIndex = 7;
            this.Log_Format.Text = "Formatar";
            this.Log_Format.UseVisualStyleBackColor = true;
            this.Log_Format.Click += new System.EventHandler(this.Log_Copy_Click);
            // 
            // Log_TextBox3
            // 
            this.Log_TextBox3.Location = new System.Drawing.Point(32, 327);
            this.Log_TextBox3.Multiline = true;
            this.Log_TextBox3.Name = "Log_TextBox3";
            this.Log_TextBox3.Size = new System.Drawing.Size(392, 100);
            this.Log_TextBox3.TabIndex = 6;
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
            // Log_TextBox2
            // 
            this.Log_TextBox2.Location = new System.Drawing.Point(33, 191);
            this.Log_TextBox2.Multiline = true;
            this.Log_TextBox2.Name = "Log_TextBox2";
            this.Log_TextBox2.Size = new System.Drawing.Size(392, 100);
            this.Log_TextBox2.TabIndex = 4;
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
            // Log_TextBox1
            // 
            this.Log_TextBox1.Location = new System.Drawing.Point(32, 55);
            this.Log_TextBox1.Multiline = true;
            this.Log_TextBox1.Name = "Log_TextBox1";
            this.Log_TextBox1.Size = new System.Drawing.Size(392, 100);
            this.Log_TextBox1.TabIndex = 2;
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
            // tabSuporte
            // 
            this.tabSuporte.Controls.Add(this.LTSup_buttonCopy);
            this.tabSuporte.Controls.Add(this.LTSup_buttonForm);
            this.tabSuporte.Controls.Add(this.LTSuporteFinalTextBox);
            this.tabSuporte.Controls.Add(this.ButtonLT_ClearCommand);
            this.tabSuporte.Controls.Add(this.ButtonLT_ResetCommand);
            this.tabSuporte.Controls.Add(this.LTSup_buttonClear);
            this.tabSuporte.Controls.Add(this.row4);
            this.tabSuporte.Controls.Add(this.ButtonLT_AdcCommand);
            this.tabSuporte.Controls.Add(this.LTSuporte_DescripTitle);
            this.tabSuporte.Controls.Add(this.LTSuporte_ComandoTitle);
            this.tabSuporte.Controls.Add(this.LogToolsSuporteTitle);
            this.tabSuporte.Controls.Add(this.LT_SuporteCom);
            this.tabSuporte.Controls.Add(this.LT_SuporteTitle);
            this.tabSuporte.Controls.Add(this.LTSup_buttonCopyF);
            this.tabSuporte.Location = new System.Drawing.Point(4, 22);
            this.tabSuporte.Name = "tabSuporte";
            this.tabSuporte.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuporte.Size = new System.Drawing.Size(954, 501);
            this.tabSuporte.TabIndex = 2;
            this.tabSuporte.Text = "Suporte";
            this.tabSuporte.UseVisualStyleBackColor = true;
            // 
            // LTSup_buttonCopy
            // 
            this.LTSup_buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTSup_buttonCopy.Location = new System.Drawing.Point(803, 64);
            this.LTSup_buttonCopy.Name = "LTSup_buttonCopy";
            this.LTSup_buttonCopy.Size = new System.Drawing.Size(127, 47);
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
            // LTSuporteFinalTextBox
            // 
            this.LTSuporteFinalTextBox.Location = new System.Drawing.Point(494, 114);
            this.LTSuporteFinalTextBox.Multiline = true;
            this.LTSuporteFinalTextBox.Name = "LTSuporteFinalTextBox";
            this.LTSuporteFinalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LTSuporteFinalTextBox.Size = new System.Drawing.Size(436, 370);
            this.LTSuporteFinalTextBox.TabIndex = 12;
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
            // row4
            // 
            this.row4.BackColor = System.Drawing.Color.Gray;
            this.row4.Location = new System.Drawing.Point(468, 113);
            this.row4.Name = "row4";
            this.row4.Size = new System.Drawing.Size(1, 370);
            this.row4.TabIndex = 8;
            this.row4.TabStop = false;
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
            // LT_SuporteCom
            // 
            this.LT_SuporteCom.Location = new System.Drawing.Point(48, 210);
            this.LT_SuporteCom.Multiline = true;
            this.LT_SuporteCom.Name = "LT_SuporteCom";
            this.LT_SuporteCom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LT_SuporteCom.Size = new System.Drawing.Size(396, 106);
            this.LT_SuporteCom.TabIndex = 2;
            // 
            // LT_SuporteTitle
            // 
            this.LT_SuporteTitle.Location = new System.Drawing.Point(48, 114);
            this.LT_SuporteTitle.Multiline = true;
            this.LT_SuporteTitle.Name = "LT_SuporteTitle";
            this.LT_SuporteTitle.Size = new System.Drawing.Size(396, 47);
            this.LT_SuporteTitle.TabIndex = 1;
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
            // tabFechamento
            // 
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox6);
            this.tabFechamento.Controls.Add(this.LTFechamento_ButtonCopy);
            this.tabFechamento.Controls.Add(this.LTFechamento_ButtonFormat);
            this.tabFechamento.Controls.Add(this.LTFechamento_ButtonClear2);
            this.tabFechamento.Controls.Add(this.LTFechamento_ButtonClear1);
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox5);
            this.tabFechamento.Controls.Add(this.row3);
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox3);
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox1);
            this.tabFechamento.Controls.Add(this.ObservacaoTitle);
            this.tabFechamento.Controls.Add(this.LTFechamento_TextBoxObs);
            this.tabFechamento.Controls.Add(this.LTFechamento_ButtonClear);
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox2);
            this.tabFechamento.Controls.Add(this.LTFechamento_BFormatCopy);
            this.tabFechamento.Controls.Add(this.LTFechamento_CheckBox0);
            this.tabFechamento.Controls.Add(this.LTFechamento_TextBox);
            this.tabFechamento.Controls.Add(this.LTFechamento_Title);
            this.tabFechamento.Controls.Add(this.LTFechamento_ContatoLabel);
            this.tabFechamento.Controls.Add(this.LTFechamento_ValidacaoText);
            this.tabFechamento.Location = new System.Drawing.Point(4, 22);
            this.tabFechamento.Name = "tabFechamento";
            this.tabFechamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabFechamento.Size = new System.Drawing.Size(954, 501);
            this.tabFechamento.TabIndex = 1;
            this.tabFechamento.Text = "Fechamento";
            this.tabFechamento.UseVisualStyleBackColor = true;
            // 
            // LTFechamento_CheckBox6
            // 
            this.LTFechamento_CheckBox6.AutoSize = true;
            this.LTFechamento_CheckBox6.Location = new System.Drawing.Point(266, 246);
            this.LTFechamento_CheckBox6.Name = "LTFechamento_CheckBox6";
            this.LTFechamento_CheckBox6.Size = new System.Drawing.Size(118, 17);
            this.LTFechamento_CheckBox6.TabIndex = 26;
            this.LTFechamento_CheckBox6.Text = "Técnico sem JDSU";
            this.LTFechamento_CheckBox6.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox6.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.LTFechamento_ButtonClear2.Location = new System.Drawing.Point(337, 291);
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
            this.LTFechamento_ButtonClear1.Location = new System.Drawing.Point(337, 107);
            this.LTFechamento_ButtonClear1.Name = "LTFechamento_ButtonClear1";
            this.LTFechamento_ButtonClear1.Size = new System.Drawing.Size(61, 21);
            this.LTFechamento_ButtonClear1.TabIndex = 22;
            this.LTFechamento_ButtonClear1.Text = "Limpar";
            this.LTFechamento_ButtonClear1.UseVisualStyleBackColor = true;
            this.LTFechamento_ButtonClear1.Click += new System.EventHandler(this.LTFechamento_ButtonClear1_Click);
            // 
            // LTFechamento_CheckBox5
            // 
            this.LTFechamento_CheckBox5.AutoSize = true;
            this.LTFechamento_CheckBox5.Location = new System.Drawing.Point(97, 246);
            this.LTFechamento_CheckBox5.Name = "LTFechamento_CheckBox5";
            this.LTFechamento_CheckBox5.Size = new System.Drawing.Size(156, 17);
            this.LTFechamento_CheckBox5.TabIndex = 20;
            this.LTFechamento_CheckBox5.Text = "Cliente não Autorizou Teste";
            this.LTFechamento_CheckBox5.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox5.CheckedChanged += new System.EventHandler(this.LTFechamento_CheckBox5_CheckedChanged);
            // 
            // row3
            // 
            this.row3.BackColor = System.Drawing.Color.Gray;
            this.row3.Location = new System.Drawing.Point(444, 125);
            this.row3.Name = "row3";
            this.row3.Size = new System.Drawing.Size(1, 320);
            this.row3.TabIndex = 19;
            this.row3.TabStop = false;
            // 
            // LTFechamento_CheckBox3
            // 
            this.LTFechamento_CheckBox3.AutoSize = true;
            this.LTFechamento_CheckBox3.Location = new System.Drawing.Point(266, 217);
            this.LTFechamento_CheckBox3.Name = "LTFechamento_CheckBox3";
            this.LTFechamento_CheckBox3.Size = new System.Drawing.Size(82, 17);
            this.LTFechamento_CheckBox3.TabIndex = 18;
            this.LTFechamento_CheckBox3.Text = "Visita Unica";
            this.LTFechamento_CheckBox3.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox3.CheckedChanged += new System.EventHandler(this.LTFechamento_CheckBox3_CheckedChanged);
            // 
            // LTFechamento_CheckBox1
            // 
            this.LTFechamento_CheckBox1.AutoSize = true;
            this.LTFechamento_CheckBox1.Location = new System.Drawing.Point(97, 217);
            this.LTFechamento_CheckBox1.Name = "LTFechamento_CheckBox1";
            this.LTFechamento_CheckBox1.Size = new System.Drawing.Size(141, 17);
            this.LTFechamento_CheckBox1.TabIndex = 17;
            this.LTFechamento_CheckBox1.Text = "Atividade IPVPN ou Voz";
            this.LTFechamento_CheckBox1.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox1.CheckedChanged += new System.EventHandler(this.LTFechamento_CheckBox1_CheckedChanged);
            // 
            // ObservacaoTitle
            // 
            this.ObservacaoTitle.AutoSize = true;
            this.ObservacaoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObservacaoTitle.Location = new System.Drawing.Point(177, 285);
            this.ObservacaoTitle.Name = "ObservacaoTitle";
            this.ObservacaoTitle.Size = new System.Drawing.Size(113, 25);
            this.ObservacaoTitle.TabIndex = 16;
            this.ObservacaoTitle.Text = "Observação";
            // 
            // LTFechamento_TextBoxObs
            // 
            this.LTFechamento_TextBoxObs.Location = new System.Drawing.Point(78, 318);
            this.LTFechamento_TextBoxObs.Multiline = true;
            this.LTFechamento_TextBoxObs.Name = "LTFechamento_TextBoxObs";
            this.LTFechamento_TextBoxObs.Size = new System.Drawing.Size(320, 109);
            this.LTFechamento_TextBoxObs.TabIndex = 15;
            this.LTFechamento_TextBoxObs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LTFechamento_TextBoxObs_KeyDown);
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
            // LTFechamento_CheckBox2
            // 
            this.LTFechamento_CheckBox2.AutoSize = true;
            this.LTFechamento_CheckBox2.Location = new System.Drawing.Point(266, 187);
            this.LTFechamento_CheckBox2.Name = "LTFechamento_CheckBox2";
            this.LTFechamento_CheckBox2.Size = new System.Drawing.Size(85, 17);
            this.LTFechamento_CheckBox2.TabIndex = 13;
            this.LTFechamento_CheckBox2.Text = "Degradação";
            this.LTFechamento_CheckBox2.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox2.CheckedChanged += new System.EventHandler(this.LTFechamento_CheckBox2_CheckedChanged);
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
            this.LTFechamento_CheckBox0.Location = new System.Drawing.Point(97, 187);
            this.LTFechamento_CheckBox0.Name = "LTFechamento_CheckBox0";
            this.LTFechamento_CheckBox0.Size = new System.Drawing.Size(110, 17);
            this.LTFechamento_CheckBox0.TabIndex = 11;
            this.LTFechamento_CheckBox0.Text = "Teste de Certidão";
            this.LTFechamento_CheckBox0.UseVisualStyleBackColor = true;
            this.LTFechamento_CheckBox0.CheckedChanged += new System.EventHandler(this.LTFechamento_CheckBox_CheckedChanged);
            // 
            // LTFechamento_TextBox
            // 
            this.LTFechamento_TextBox.Location = new System.Drawing.Point(486, 131);
            this.LTFechamento_TextBox.Multiline = true;
            this.LTFechamento_TextBox.Name = "LTFechamento_TextBox";
            this.LTFechamento_TextBox.Size = new System.Drawing.Size(417, 196);
            this.LTFechamento_TextBox.TabIndex = 10;
            this.LTFechamento_TextBox.Text = "- Atividade Realizada com Sucesso - \r\n \r\nResponsável do cliente pela Validação: \r" +
    "\n \r\n";
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
            this.LTFechamento_ContatoLabel.Location = new System.Drawing.Point(73, 107);
            this.LTFechamento_ContatoLabel.Name = "LTFechamento_ContatoLabel";
            this.LTFechamento_ContatoLabel.Size = new System.Drawing.Size(165, 21);
            this.LTFechamento_ContatoLabel.TabIndex = 8;
            this.LTFechamento_ContatoLabel.Text = "Contato de Validação";
            // 
            // LTFechamento_ValidacaoText
            // 
            this.LTFechamento_ValidacaoText.Location = new System.Drawing.Point(78, 131);
            this.LTFechamento_ValidacaoText.Multiline = true;
            this.LTFechamento_ValidacaoText.Name = "LTFechamento_ValidacaoText";
            this.LTFechamento_ValidacaoText.Size = new System.Drawing.Size(320, 40);
            this.LTFechamento_ValidacaoText.TabIndex = 7;
            this.LTFechamento_ValidacaoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LTFechamento_ValidacaoText_KeyDown);
            // 
            // tabCalculadoraDeIP
            // 
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_SubTitle);
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_buttonCalc);
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_Hint);
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_Title);
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_Result);
            this.tabCalculadoraDeIP.Controls.Add(this.LTCalc_IPTextBox);
            this.tabCalculadoraDeIP.Location = new System.Drawing.Point(4, 22);
            this.tabCalculadoraDeIP.Name = "tabCalculadoraDeIP";
            this.tabCalculadoraDeIP.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculadoraDeIP.Size = new System.Drawing.Size(954, 501);
            this.tabCalculadoraDeIP.TabIndex = 3;
            this.tabCalculadoraDeIP.Text = "Calculadora de IP";
            this.tabCalculadoraDeIP.UseVisualStyleBackColor = true;
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
            this.LTCalc_Hint.Location = new System.Drawing.Point(343, 121);
            this.LTCalc_Hint.Name = "LTCalc_Hint";
            this.LTCalc_Hint.Size = new System.Drawing.Size(99, 13);
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
            this.LTCalc_IPTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTCalc_IPTextBox.Location = new System.Drawing.Point(143, 137);
            this.LTCalc_IPTextBox.Name = "LTCalc_IPTextBox";
            this.LTCalc_IPTextBox.Size = new System.Drawing.Size(299, 33);
            this.LTCalc_IPTextBox.TabIndex = 0;
            this.LTCalc_IPTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LTCalc_IPTextBox_KeyDown);
            // 
            // tabTroubleShoot
            // 
            this.tabTroubleShoot.Controls.Add(this.label1);
            this.tabTroubleShoot.Controls.Add(this.label2);
            this.tabTroubleShoot.Controls.Add(this.Button_DarkMode);
            this.tabTroubleShoot.Controls.Add(this.Button_EnableEdit);
            this.tabTroubleShoot.Controls.Add(this.Teste_ClearDB);
            this.tabTroubleShoot.Controls.Add(this.Teste_ClearF);
            this.tabTroubleShoot.Controls.Add(this.label11);
            this.tabTroubleShoot.Controls.Add(this.Script_VarTest);
            this.tabTroubleShoot.Controls.Add(this.label10);
            this.tabTroubleShoot.Controls.Add(this.Teste_Enter);
            this.tabTroubleShoot.Controls.Add(this.Teste_In);
            this.tabTroubleShoot.Controls.Add(this.Teste_out);
            this.tabTroubleShoot.Controls.Add(this.label9);
            this.tabTroubleShoot.Controls.Add(this.label8);
            this.tabTroubleShoot.Controls.Add(this.label7);
            this.tabTroubleShoot.Controls.Add(this.Teste_ScriptBanco);
            this.tabTroubleShoot.Controls.Add(this.Teste_ScriptFinal);
            this.tabTroubleShoot.Controls.Add(this.groupBoxTest);
            this.tabTroubleShoot.Location = new System.Drawing.Point(4, 22);
            this.tabTroubleShoot.Name = "tabTroubleShoot";
            this.tabTroubleShoot.Size = new System.Drawing.Size(1119, 529);
            this.tabTroubleShoot.TabIndex = 0;
            this.tabTroubleShoot.Text = "Troubleshoot";
            this.tabTroubleShoot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Created by: Ricardo Thiago Firmino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "TESTES";
            // 
            // Button_DarkMode
            // 
            this.Button_DarkMode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DarkMode.Location = new System.Drawing.Point(19, 431);
            this.Button_DarkMode.Name = "Button_DarkMode";
            this.Button_DarkMode.Size = new System.Drawing.Size(97, 61);
            this.Button_DarkMode.TabIndex = 15;
            this.Button_DarkMode.Text = "Dark Mode";
            this.Button_DarkMode.UseVisualStyleBackColor = true;
            this.Button_DarkMode.Click += new System.EventHandler(this.Button_DarkMode_Click);
            // 
            // Button_EnableEdit
            // 
            this.Button_EnableEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_EnableEdit.Location = new System.Drawing.Point(19, 362);
            this.Button_EnableEdit.Name = "Button_EnableEdit";
            this.Button_EnableEdit.Size = new System.Drawing.Size(97, 61);
            this.Button_EnableEdit.TabIndex = 14;
            this.Button_EnableEdit.Text = "Enable Edit";
            this.Button_EnableEdit.UseVisualStyleBackColor = true;
            this.Button_EnableEdit.Click += new System.EventHandler(this.Button_EnableEdit_Click);
            // 
            // Teste_ClearDB
            // 
            this.Teste_ClearDB.Location = new System.Drawing.Point(489, 104);
            this.Teste_ClearDB.Name = "Teste_ClearDB";
            this.Teste_ClearDB.Size = new System.Drawing.Size(75, 23);
            this.Teste_ClearDB.TabIndex = 13;
            this.Teste_ClearDB.Text = "Limpar";
            this.Teste_ClearDB.UseVisualStyleBackColor = true;
            this.Teste_ClearDB.Click += new System.EventHandler(this.Teste_ClearDB_Click);
            // 
            // Teste_ClearF
            // 
            this.Teste_ClearF.Location = new System.Drawing.Point(1000, 104);
            this.Teste_ClearF.Name = "Teste_ClearF";
            this.Teste_ClearF.Size = new System.Drawing.Size(75, 23);
            this.Teste_ClearF.TabIndex = 12;
            this.Teste_ClearF.Text = "Limpar";
            this.Teste_ClearF.UseVisualStyleBackColor = true;
            this.Teste_ClearF.Click += new System.EventHandler(this.Teste_ClearF_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(638, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "utilize \"var\" para substituir";
            // 
            // Script_VarTest
            // 
            this.Script_VarTest.Location = new System.Drawing.Point(695, 451);
            this.Script_VarTest.Name = "Script_VarTest";
            this.Script_VarTest.Size = new System.Drawing.Size(100, 20);
            this.Script_VarTest.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(609, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Var Teste";
            // 
            // Teste_Enter
            // 
            this.Teste_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teste_Enter.Location = new System.Drawing.Point(877, 442);
            this.Teste_Enter.Name = "Teste_Enter";
            this.Teste_Enter.Size = new System.Drawing.Size(110, 45);
            this.Teste_Enter.TabIndex = 8;
            this.Teste_Enter.Text = "Enter";
            this.Teste_Enter.UseVisualStyleBackColor = true;
            this.Teste_Enter.Click += new System.EventHandler(this.Teste_Enter_Click);
            // 
            // Teste_In
            // 
            this.Teste_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teste_In.Location = new System.Drawing.Point(610, 287);
            this.Teste_In.Name = "Teste_In";
            this.Teste_In.Size = new System.Drawing.Size(110, 45);
            this.Teste_In.TabIndex = 7;
            this.Teste_In.Text = "<--";
            this.Teste_In.UseVisualStyleBackColor = true;
            this.Teste_In.Click += new System.EventHandler(this.Teste_In_Click);
            // 
            // Teste_out
            // 
            this.Teste_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teste_out.Location = new System.Drawing.Point(610, 210);
            this.Teste_out.Name = "Teste_out";
            this.Teste_out.Size = new System.Drawing.Size(110, 45);
            this.Teste_out.TabIndex = 6;
            this.Teste_out.Text = "-->";
            this.Teste_out.UseVisualStyleBackColor = true;
            this.Teste_out.Click += new System.EventHandler(this.Teste_out_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(762, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Script Final";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "O banco de dados recebe apenas uma String Unica**";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Banco de Dados";
            // 
            // Teste_ScriptBanco
            // 
            this.Teste_ScriptBanco.Location = new System.Drawing.Point(255, 133);
            this.Teste_ScriptBanco.Multiline = true;
            this.Teste_ScriptBanco.Name = "Teste_ScriptBanco";
            this.Teste_ScriptBanco.Size = new System.Drawing.Size(309, 290);
            this.Teste_ScriptBanco.TabIndex = 2;
            // 
            // Teste_ScriptFinal
            // 
            this.Teste_ScriptFinal.Location = new System.Drawing.Point(766, 133);
            this.Teste_ScriptFinal.Multiline = true;
            this.Teste_ScriptFinal.Name = "Teste_ScriptFinal";
            this.Teste_ScriptFinal.Size = new System.Drawing.Size(309, 290);
            this.Teste_ScriptFinal.TabIndex = 1;
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Location = new System.Drawing.Point(8, 18);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(203, 314);
            this.groupBoxTest.TabIndex = 0;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "groupBox1";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(995, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 577);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MasterSheet";
            tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRouters)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMaster.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabSelectProcedure.ResumeLayout(false);
            this.tabSelectProcedure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabScript.ResumeLayout(false);
            this.tabScript.PerformLayout();
            this.tabSelectRouter.ResumeLayout(false);
            this.tabSelectRouter.PerformLayout();
            this.tabWizGat.ResumeLayout(false);
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogsRow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogsRow0)).EndInit();
            this.tabVelocloud.ResumeLayout(false);
            this.tabVelocloud.PerformLayout();
            this.tabLigacoes.ResumeLayout(false);
            this.tabLigacoes.PerformLayout();
            this.tabRouters.ResumeLayout(false);
            this.tabLogTools.ResumeLayout(false);
            this.tabControlLogTools.ResumeLayout(false);
            this.tabPendencia.ResumeLayout(false);
            this.tabPendencia.PerformLayout();
            this.tabSuporte.ResumeLayout(false);
            this.tabSuporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row4)).EndInit();
            this.tabFechamento.ResumeLayout(false);
            this.tabFechamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row3)).EndInit();
            this.tabCalculadoraDeIP.ResumeLayout(false);
            this.tabCalculadoraDeIP.PerformLayout();
            this.tabTroubleShoot.ResumeLayout(false);
            this.tabTroubleShoot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label MainTitle;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabMaster;
        private TabPage tabRouters;
        private TabControl tabControl2;
        private TabPage tabSelectProcedure;
        private Button BLD_button;
        private Label Version;
        private Button VOZ_Button;
        private Button MPLS_button;
        private TabPage tabSelectRouter;
        private Button Config_Cisco;
        private Button Config_HPE;
        private Button BackButton_SelectRouter;
        private PictureBox pictureBox2;
        private Label TemplatesLabel;
        private Label ClientesSubTitle;
        private Label ScriptsSubTitle;
        private LinkLabel AllClients;
        private Button ClienteButton_Test4;
        private Button ClienteButton_Test3;
        private Button ClienteButton_Test2;
        private Button ClienteButton_Teste1;
        private TabPage ClientStepsPage;
        private Button WizGat_Open;
        private Label WizardGatLabel;
        private Label OutrasConfigs;
        private Button buttonOC_VLAN;
        private Button buttonOC_BlocPort;
        private DataGridView dataGridRouters;
        private TabPage tabWizGat;
        private Button WizNokiaBLDcBGP;
        private Button WizNokiaVoz;
        private Button WizNokiaMPLS;
        private Button WizNokiaBLD;
        private Button WizCiscoBGP;
        private Button WizCiscoVoz;
        private Button WizCiscoMPLS;
        private Button WizCiscoBLD;
        private Label WizCiscoTitle;
        private Label WizNokiaTitle;
        private Button BackButton_WizGat;
        private Label ConfiguracaoCPETitle;
        private Button Config_Fortigate;
        private Button Config_Huawei;
        private Button Config_HPE_old;
        private TabPage tabLogTools;
        private TabControl tabControlLogTools;
        private TabPage tabPendencia;
        private Button Log_CopyF;
        private Button Log_Format;
        private TextBox Log_TextBox3;
        private Label Log_ProximosPassos;
        private TextBox Log_TextBox2;
        private Label Log_StatusAtual;
        private TextBox Log_TextBox1;
        private Label Log_StatusAnterior;
        private TabPage tabFechamento;
        private Label label3;
        private Button Log_ClearAll;
        private TextBox Log_FinalTextBox;
        private Button LogToolsPendencia;
        private Button LogToolsFechamento;
        private Button LogToolsSuporte;
        private TabPage tabSuporte;
        private Button LTSup_buttonCopyF;
        private Label LogToolsSuporteTitle;
        private TextBox LT_SuporteCom;
        private TextBox LT_SuporteTitle;
        private Button ButtonLT_AdcCommand;
        private Label LTSuporte_DescripTitle;
        private Label LTSuporte_ComandoTitle;
        private Button LTSup_buttonClear;
        private PictureBox row4;
        private Label LTFechamento_ContatoLabel;
        private TextBox LTFechamento_ValidacaoText;
        private Label LTFechamento_Title;
        private TextBox LTFechamento_TextBox;
        private Button LTFechamento_BFormatCopy;
        private CheckBox LTFechamento_CheckBox0;
        private TabPage tabLogs;
        private Button Logs_Cisco_BLD;
        private Button Logs_VOZ_Aligera;
        private Button Logs_HPE_BLD;
        private Button Logs_BackButton;
        private Label Logs_Title;
        private PictureBox LogsRow1;
        private PictureBox LogsRow0;
        private Label Logs_SubTitle0;
        private Button Logs_HPE_MPLS;
        private Button Logs_Cisco_MPLS;
        private Label Logs_SubTitle1;
        private Button Logs_Finais;
        private Button Logs_Iniciais;
        private Label LogsSubTitle;
        private TabPage tabScript;
        private Button buttonSwitchScriptLog;
        private Button ButtonLimpeza;
        private Button ButtonParte2;
        private TextBox Script_Var9;
        private Label Script_VarName9;
        private TextBox Script_Var8;
        private Label Script_VarName8;
        private TextBox Script_Var7;
        private Label Script_VarName7;
        private ComboBox Script_LANMascara;
        private Button BackButton_Script3;
        private Button BackButton_Script2;
        private Label Script_TypeLabel;
        private Button Button_FormatarScript;
        private Button BackButton_Script;
        private ComboBox Script_ComboBox;
        private TextBox Script_Var6;
        private Label Script_VarName6;
        private Button ClearButton;
        private Label VarText;
        private TextBox Script_Var5;
        private TextBox Script_Var4;
        private TextBox Script_Var3;
        private TextBox Script_Var2;
        private TextBox Script_Var1;
        private Label Script_VarName5;
        private Label Script_VarName3;
        private Label Script_VarName4;
        private Label Script_VarName2;
        private Label Script_VarName1;
        private Label ProcedureName;
        private Button HomeButton_Script;
        private Label Script_LabelScript;
        private Label Script_VarName0;
        private TextBox Script_Var0;
        private TextBox Script_Var10;
        private Label Script_VarName10;
        private Button CopyButton;
        private Label hint1;
        private Button buttonOC_GLBP;
        private Button buttonOC_IPFlow;
        private Button buttonOC_NTP;
        private Button buttonOC_HSRP;
        private Button buttonOC_VRRP;
        private Button buttonOC_OSPF;
        private Button buttonOC_RIP;
        private Button buttonOC_User;
        private Button buttonOC_DHCP;
        private Button buttonOC_IPsecundario;
        private Button buttonOC_RotaEstatica;
        private Button buttonOC_Tacacs;
        private Button buttonOC_SNMP;
        private Button buttonOC_QoS;
        private Button buttonOC_IOSInstal;
        private Button buttonOC_Balanceamento;
        private Button buttonOC_EIGRP;
        private Label labelRouterInfo;
        private Button ButtonLT_ClearCommand;
        private Button ButtonLT_ResetCommand;
        private TextBox LTSuporteFinalTextBox;
        private CheckBox LTFechamento_CheckBox2;
        private Button LTFechamento_ButtonClear;
        private Label ObservacaoTitle;
        private TextBox LTFechamento_TextBoxObs;
        private TabPage tabTroubleShoot;
        private CheckBox LTFechamento_CheckBox1;
        private CheckBox LTFechamento_CheckBox3;
        private Button Logs_Velo;
        private Label Logs_SubTitle4;
        private TabPage tabVelocloud;
        private Button BackButton_Velo;
        private Button buttonVeloClear;
        private Button buttonVeloCopie;
        private Button HomeButton_Velo;
        private TextBox veloTextBoxFinal;
        private TextBox veloTextBox15;
        private Label labelVeloSubtitle15;
        private TextBox veloTextBox14;
        private Label labelVeloSubtitle14;
        private TextBox veloTextBox13;
        private Label labelVeloSubtitle13;
        private TextBox veloTextBox12;
        private Label labelVeloSubtitle12;
        private TextBox veloTextBox11;
        private Label labelVeloSubtitle11;
        private TextBox veloTextBox10;
        private Label labelVeloSubtitle10;
        private TextBox veloTextBox9;
        private Label labelVeloSubtitle9;
        private TextBox veloTextBox8;
        private Label labelVeloSubtitle8;
        private TextBox veloTextBox7;
        private Label labelVeloSubtitle7;
        private TextBox veloTextBox6;
        private Label labelVeloSubtitle6;
        private TextBox veloTextBox5;
        private Label labelVeloSubtitle5;
        private TextBox veloTextBox4;
        private Label labelVeloSubtitle4;
        private TextBox veloTextBox3;
        private Label labelVeloSubtitle3;
        private TextBox veloTextBox2;
        private Label labelVeloSubtitle2;
        private TextBox veloTextBox1;
        private Label labelVeloSubtitle1;
        private TextBox veloTextBox0;
        private Label labelVeloSubtitle0;
        private TextBox veloTextBox16;
        private Label labelVeloSubtitle16;
        private Label labelVelocloudTitle;
        private Button buttonSwitchVeloLog;
        private PictureBox row3;
        private TabPage tabPage1;
        private Button Button_IOS;
        private TabPage tabPage2;
        private Button Logs_MPLS_Fortigate;
        private PictureBox row6;
        private Label Logs_SubTitle2;
        private Button Logs_BLD_Fortigate;
        private Label Script_ModelLabel;
        private ComboBox Script_FortigateModel;
        private GroupBox groupBoxTest;
        private CheckBox LTFechamento_CheckBox5;
        private ComboBox Script_ISRBox;
        private Label Script_ISRLabel;
        private Button veloDeleteButton5;
        private Button veloDeleteButtonAll;
        private Button veloDeleteButton4;
        private Button veloDeleteButton3;
        private Button veloDeleteButton2;
        private Button veloDeleteButton1;
        private Button veloDeleteButton0;
        private Button veloDeleteButton16;
        private Button veloDeleteButton15;
        private Button veloDeleteButton14;
        private Button veloDeleteButton13;
        private Button veloDeleteButton12;
        private Button veloDeleteButton11;
        private Button veloDeleteButton10;
        private Button veloDeleteButton9;
        private Button veloDeleteButton8;
        private Button veloDeleteButton7;
        private Button veloDeleteButton6;
        private Button LTFechamento_ButtonClear2;
        private Button LTFechamento_ButtonClear1;
        private Button Script_DeleteVar5;
        private Button Script_DeleteVar4;
        private Button Script_DeleteVar3;
        private Button Script_DeleteVar2;
        private Button Script_DeleteVar1;
        private Button Script_DeleteVar0;
        private Button Script_DeleteVar10;
        private Button Script_DeleteVar9;
        private Button Script_DeleteVar8;
        private Button Script_DeleteVar7;
        private Button Script_DeleteVar6;
        private Button Button_FormatarECopiarScript;
        private Button Logs_BLD_Huawei;
        private Label Script_XRLabel;
        private ComboBox Script_XRBox;
        private Button Log_Clear3;
        private Button Log_Clear2;
        private Button Log_Clear1;
        private Button LTFechamento_ButtonCopy;
        private Button LTFechamento_ButtonFormat;
        private Button Script_DeleteRouteE1;
        private Label Script_VarRouteE1Label;
        private TextBox Script_VarRouteE1;
        private Button Script_DeleteRouteI2;
        private Label Script_VarRouteI2Label;
        private TextBox Script_VarRouteI2;
        private Button Script_DeleteRouteI1;
        private Label Script_VarRouteI1Label;
        private TextBox Script_VarRouteI1;
        private Label Script_RouteLabelHint;
        private Button Script_DeleteRouteE2;
        private Label Script_VarRouteE2Label;
        private TextBox Script_VarRouteE2;
        private Button Script_DeleteVar11;
        private TextBox Script_Var11;
        private Label Script_VarName11;
        private Button Script_DeleteVar13;
        private TextBox Script_Var13;
        private Label Script_VarName13;
        private Button Script_DeleteVar12;
        private TextBox Script_Var12;
        private Label Script_VarName12;
        private Button Script_DeleteVar15;
        private TextBox Script_Var15;
        private Label Script_VarName15;
        private Button Script_DeleteVar14;
        private TextBox Script_Var14;
        private Label Script_VarName14;
        private Button Teste_In;
        private Button Teste_out;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox Teste_ScriptBanco;
        private TextBox Teste_ScriptFinal;
        private TextBox Script_VarTest;
        private Label label10;
        private Button Teste_Enter;
        private Label label11;
        private Button Teste_ClearDB;
        private Button Teste_ClearF;
        private Button LogToolsCalc;
        private TabPage tabCalculadoraDeIP;
        private Label LTCalc_SubTitle;
        private Button LTCalc_buttonCalc;
        private Label LTCalc_Hint;
        private Label LTCalc_Title;
        private Label LTCalc_Result;
        private TextBox LTCalc_IPTextBox;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button LTSup_buttonForm;
        private Button Logs_Ligacao;
        private TabPage tabLigacoes;
        private TextBox Ligacoes_TBFinal;
        private Label Ligacoes_SubTitle1;
        private Button Ligacoes_Clear3;
        private Button Ligacoes_Clear2;
        private Button Ligacoes_Clear1;
        private Button Ligacoes_Clear4;
        private Button Ligacoes_Clear5;
        private Button Ligacoes_Clear6;
        private TextBox Ligacoes_TB5;
        private Label Ligacoes_SubTitle5;
        private TextBox Ligacoes_TB6;
        private Label Ligacoes_SubTitle6;
        private TextBox Ligacoes_TB4;
        private Label Ligacoes_SubTitle4;
        private TextBox Ligacoes_TB3;
        private Label Ligacoes_SubTitle3;
        private TextBox Ligacoes_TB2;
        private Label Ligacoes_SubTitle2;
        private TextBox Ligacoes_TB1;
        private Button Ligacoes_BRestore;
        private Button Ligacoes_BCopy;
        private Button Ligacoes_BFormat;
        private Button Ligacoes_BClear;
        private Label Ligacoes_Title;
        private Button HomeButton_Ligacoes;
        private Button Logs_MPLS_Huawei;
        private Button Logs_VOZ_Broadsoft;
        private Button Logs_VOZ_Digistar;
        private Button Logs_VOZ_HPE;
        private Button Logs_VOZ_Cisco;
        private Button Logs_WizGat;
        private Button LTSup_buttonCopy;
        private Button Log_Copy;
        private Button Ligacoes_BExemplos;
        private Button Button_EnableEdit;
        private Button Ligacoes_BDigistar;
        private Button Ligacoes_BCisco;
        private Button Ligacoes_BHPE;
        private Button Ligacoes_BDebug;
        private Button Ligacoes_BAligera;
        private Button Ligacoes_BLogs;
        private Button Ligacoes_BHPE_Antigo;
        private Label ConfiguracaoCPE_SubTitle;
        private Button Config_ChangeVOZ;
        private Button Config_ChangeMPLS;
        private Button Config_ChangeBLD;
        private Button Button_DarkMode;
        private Label label2;
        private Label Script_VarEx13;
        private Label Script_VarEx14;
        private Label Script_VarEx15;
        private Label Script_VarEx12;
        private Label Script_VarEx11;
        private Label Script_VarEx10;
        private Label Script_VarEx9;
        private Label Script_VarEx8;
        private Label Script_VarEx7;
        private Label Script_VarEx6;
        private Label Script_VarEx5;
        private Label Script_VarEx4;
        private Label Script_VarEx3;
        private Label Script_VarEx2;
        private Label Script_VarEx1;
        private Label Script_VarEx0;
        private Label Script_ExLabel;
        private CheckBox LTFechamento_CheckBox6;
        private Label CreatedLabel;
        private RichTextBox Script_TextBox;
        private Label label1;
        private Label label4;
    }
}

