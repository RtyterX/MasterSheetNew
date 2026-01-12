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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMaster = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabSelectProcedure = new System.Windows.Forms.TabPage();
            this.OutrosButton2 = new System.Windows.Forms.Button();
            this.OutrosButton1 = new System.Windows.Forms.Button();
            this.WizGat_CiscoBLD = new System.Windows.Forms.Button();
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
            this.Script_TypeLabel = new System.Windows.Forms.Label();
            this.Button_FormatarScript = new System.Windows.Forms.Button();
            this.BackButton_Script = new System.Windows.Forms.Button();
            this.Script_ComboBox = new System.Windows.Forms.ComboBox();
            this.ScriptProcedure = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Script_Var6 = new System.Windows.Forms.TextBox();
            this.Script_VarName6 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
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
            this.ProcedureDescrip = new System.Windows.Forms.Label();
            this.ProcedureName = new System.Windows.Forms.Label();
            this.HomeButton_Script = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Script_VarName0 = new System.Windows.Forms.Label();
            this.Script_Var0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSelectRouter = new System.Windows.Forms.TabPage();
            this.Config_Fortigate = new System.Windows.Forms.Button();
            this.Config_Huawei = new System.Windows.Forms.Button();
            this.Config_HPE_old = new System.Windows.Forms.Button();
            this.ConfiguracaoCPETitle = new System.Windows.Forms.Label();
            this.BackButton_SelectRouter = new System.Windows.Forms.Button();
            this.Config_HPE = new System.Windows.Forms.Button();
            this.Config_Cisco = new System.Windows.Forms.Button();
            this.ClientStepsPage = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
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
            this.label5 = new System.Windows.Forms.Label();
            this.tabRouters = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxBandwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.tabLogTools = new System.Windows.Forms.TabPage();
            this.LogToolsSuporte = new System.Windows.Forms.Button();
            this.LogToolsFechamento = new System.Windows.Forms.Button();
            this.LogToolsPendencia = new System.Windows.Forms.Button();
            this.tabControlLogTools = new System.Windows.Forms.TabControl();
            this.tabPendencia = new System.Windows.Forms.TabPage();
            this.Log_FinalTextBox = new System.Windows.Forms.TextBox();
            this.Log_Copy = new System.Windows.Forms.Button();
            this.Log_Clear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Log_Format = new System.Windows.Forms.Button();
            this.Log_TextBox3 = new System.Windows.Forms.TextBox();
            this.Log_ProximosPassos = new System.Windows.Forms.Label();
            this.Log_TextBox2 = new System.Windows.Forms.TextBox();
            this.Log_StatusAtual = new System.Windows.Forms.Label();
            this.Log_TextBox1 = new System.Windows.Forms.TextBox();
            this.Log_StatusAnterior = new System.Windows.Forms.Label();
            this.tabFechamento = new System.Windows.Forms.TabPage();
            this.tabSuporte = new System.Windows.Forms.TabPage();
            this.ButtonLogTools_Suporte = new System.Windows.Forms.Button();
            this.TextBox_LogToolsSuporte = new System.Windows.Forms.TextBox();
            this.TextBox_LogToolsSuporte1 = new System.Windows.Forms.TextBox();
            this.LogToolsSuporteTitle = new System.Windows.Forms.Label();
            this.LogToolsSuporteFinalText = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMaster.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabSelectProcedure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabScript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabSelectRouter.SuspendLayout();
            this.ClientStepsPage.SuspendLayout();
            this.tabWizGat.SuspendLayout();
            this.tabRouters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabLogTools.SuspendLayout();
            this.tabControlLogTools.SuspendLayout();
            this.tabPendencia.SuspendLayout();
            this.tabSuporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1154, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "MasterSheet+";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1168, 22);
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
            this.pictureBox1.Location = new System.Drawing.Point(865, 453);
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1168, 653);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // tabMaster
            // 
            this.tabMaster.Controls.Add(this.tabControl2);
            this.tabMaster.Controls.Add(this.label1);
            this.tabMaster.Controls.Add(this.label5);
            this.tabMaster.Location = new System.Drawing.Point(4, 22);
            this.tabMaster.Name = "tabMaster";
            this.tabMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaster.Size = new System.Drawing.Size(1160, 627);
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
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl2.Location = new System.Drawing.Point(3, 74);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1154, 550);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 0;
            // 
            // tabSelectProcedure
            // 
            this.tabSelectProcedure.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabSelectProcedure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabSelectProcedure.Controls.Add(this.OutrosButton2);
            this.tabSelectProcedure.Controls.Add(this.OutrosButton1);
            this.tabSelectProcedure.Controls.Add(this.WizGat_CiscoBLD);
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
            this.tabSelectProcedure.Size = new System.Drawing.Size(1146, 541);
            this.tabSelectProcedure.TabIndex = 0;
            this.tabSelectProcedure.Text = "tabPage4";
            // 
            // OutrosButton2
            // 
            this.OutrosButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutrosButton2.Location = new System.Drawing.Point(185, 381);
            this.OutrosButton2.Name = "OutrosButton2";
            this.OutrosButton2.Size = new System.Drawing.Size(171, 60);
            this.OutrosButton2.TabIndex = 25;
            this.OutrosButton2.Text = "Bloqueio de Porta";
            this.OutrosButton2.UseVisualStyleBackColor = true;
            this.OutrosButton2.Click += new System.EventHandler(this.OutrosButton2_Click);
            // 
            // OutrosButton1
            // 
            this.OutrosButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutrosButton1.Location = new System.Drawing.Point(9, 381);
            this.OutrosButton1.Name = "OutrosButton1";
            this.OutrosButton1.Size = new System.Drawing.Size(171, 60);
            this.OutrosButton1.TabIndex = 24;
            this.OutrosButton1.Text = "Vlan";
            this.OutrosButton1.UseVisualStyleBackColor = true;
            this.OutrosButton1.Click += new System.EventHandler(this.OutrosButton1_Click);
            // 
            // WizGat_CiscoBLD
            // 
            this.WizGat_CiscoBLD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizGat_CiscoBLD.Location = new System.Drawing.Point(530, 301);
            this.WizGat_CiscoBLD.Name = "WizGat_CiscoBLD";
            this.WizGat_CiscoBLD.Size = new System.Drawing.Size(171, 60);
            this.WizGat_CiscoBLD.TabIndex = 23;
            this.WizGat_CiscoBLD.Text = "Abrir";
            this.WizGat_CiscoBLD.UseVisualStyleBackColor = true;
            this.WizGat_CiscoBLD.Click += new System.EventHandler(this.WizGat_CiscoBLD_Click_1);
            // 
            // WizardGatLabel
            // 
            this.WizardGatLabel.AutoSize = true;
            this.WizardGatLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.WizardGatLabel.Location = new System.Drawing.Point(563, 267);
            this.WizardGatLabel.Name = "WizardGatLabel";
            this.WizardGatLabel.Size = new System.Drawing.Size(106, 25);
            this.WizardGatLabel.TabIndex = 22;
            this.WizardGatLabel.Text = "WizardGat";
            // 
            // OutrasConfigs
            // 
            this.OutrasConfigs.AutoSize = true;
            this.OutrasConfigs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.OutrasConfigs.Location = new System.Drawing.Point(100, 339);
            this.OutrasConfigs.Name = "OutrasConfigs";
            this.OutrasConfigs.Size = new System.Drawing.Size(205, 25);
            this.OutrasConfigs.TabIndex = 21;
            this.OutrasConfigs.Text = "Outras Configurações";
            // 
            // AllClients
            // 
            this.AllClients.AutoSize = true;
            this.AllClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllClients.Location = new System.Drawing.Point(20, 294);
            this.AllClients.Name = "AllClients";
            this.AllClients.Size = new System.Drawing.Size(138, 21);
            this.AllClients.TabIndex = 20;
            this.AllClients.TabStop = true;
            this.AllClients.Text = "Outros Clientes...";
            this.AllClients.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AllClients_LinkClicked);
            // 
            // ClienteButton_Test4
            // 
            this.ClienteButton_Test4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteButton_Test4.Location = new System.Drawing.Point(185, 218);
            this.ClienteButton_Test4.Name = "ClienteButton_Test4";
            this.ClienteButton_Test4.Size = new System.Drawing.Size(171, 60);
            this.ClienteButton_Test4.TabIndex = 19;
            this.ClienteButton_Test4.Text = "Teste 4";
            this.ClienteButton_Test4.UseVisualStyleBackColor = true;
            this.ClienteButton_Test4.Click += new System.EventHandler(this.ClienteButton_Test4_Click);
            // 
            // ClienteButton_Test3
            // 
            this.ClienteButton_Test3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteButton_Test3.Location = new System.Drawing.Point(9, 218);
            this.ClienteButton_Test3.Name = "ClienteButton_Test3";
            this.ClienteButton_Test3.Size = new System.Drawing.Size(171, 60);
            this.ClienteButton_Test3.TabIndex = 18;
            this.ClienteButton_Test3.Text = "Teste 3";
            this.ClienteButton_Test3.UseVisualStyleBackColor = true;
            this.ClienteButton_Test3.Click += new System.EventHandler(this.ClienteButton_Test3_Click);
            // 
            // ClienteButton_Test2
            // 
            this.ClienteButton_Test2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteButton_Test2.Location = new System.Drawing.Point(185, 153);
            this.ClienteButton_Test2.Name = "ClienteButton_Test2";
            this.ClienteButton_Test2.Size = new System.Drawing.Size(171, 60);
            this.ClienteButton_Test2.TabIndex = 17;
            this.ClienteButton_Test2.Text = "Teste 2";
            this.ClienteButton_Test2.UseVisualStyleBackColor = true;
            this.ClienteButton_Test2.Click += new System.EventHandler(this.ClienteButton_Test2_Click);
            // 
            // ClienteButton_Teste1
            // 
            this.ClienteButton_Teste1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteButton_Teste1.Location = new System.Drawing.Point(9, 153);
            this.ClienteButton_Teste1.Name = "ClienteButton_Teste1";
            this.ClienteButton_Teste1.Size = new System.Drawing.Size(171, 60);
            this.ClienteButton_Teste1.TabIndex = 16;
            this.ClienteButton_Teste1.Text = "Teste 1";
            this.ClienteButton_Teste1.UseVisualStyleBackColor = true;
            this.ClienteButton_Teste1.Click += new System.EventHandler(this.ClienteButton_Teste1_Click);
            // 
            // Logs_Finais
            // 
            this.Logs_Finais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Finais.Location = new System.Drawing.Point(627, 153);
            this.Logs_Finais.Name = "Logs_Finais";
            this.Logs_Finais.Size = new System.Drawing.Size(171, 60);
            this.Logs_Finais.TabIndex = 15;
            this.Logs_Finais.Text = "FINAIS";
            this.Logs_Finais.UseVisualStyleBackColor = true;
            this.Logs_Finais.Click += new System.EventHandler(this.Logs_Finais_Click);
            // 
            // Logs_Iniciais
            // 
            this.Logs_Iniciais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs_Iniciais.Location = new System.Drawing.Point(434, 153);
            this.Logs_Iniciais.Name = "Logs_Iniciais";
            this.Logs_Iniciais.Size = new System.Drawing.Size(171, 60);
            this.Logs_Iniciais.TabIndex = 14;
            this.Logs_Iniciais.Text = "INICIAIS";
            this.Logs_Iniciais.UseVisualStyleBackColor = true;
            this.Logs_Iniciais.Click += new System.EventHandler(this.Logs_Iniciais_Click);
            // 
            // ScriptsSubTitle
            // 
            this.ScriptsSubTitle.AutoSize = true;
            this.ScriptsSubTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ScriptsSubTitle.Location = new System.Drawing.Point(891, 110);
            this.ScriptsSubTitle.Name = "ScriptsSubTitle";
            this.ScriptsSubTitle.Size = new System.Drawing.Size(141, 25);
            this.ScriptsSubTitle.TabIndex = 13;
            this.ScriptsSubTitle.Text = "Configurações";
            // 
            // LogsSubTitle
            // 
            this.LogsSubTitle.AutoSize = true;
            this.LogsSubTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.LogsSubTitle.Location = new System.Drawing.Point(592, 110);
            this.LogsSubTitle.Name = "LogsSubTitle";
            this.LogsSubTitle.Size = new System.Drawing.Size(54, 25);
            this.LogsSubTitle.TabIndex = 12;
            this.LogsSubTitle.Text = "Logs";
            // 
            // ClientesSubTitle
            // 
            this.ClientesSubTitle.AutoSize = true;
            this.ClientesSubTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ClientesSubTitle.Location = new System.Drawing.Point(157, 110);
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
            this.TemplatesLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplatesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TemplatesLabel.Location = new System.Drawing.Point(486, 22);
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
            this.pictureBox2.Size = new System.Drawing.Size(1140, 81);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Version
            // 
            this.Version.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Version.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(3, 523);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(1140, 15);
            this.Version.TabIndex = 7;
            this.Version.Text = "Versão: 1.0.0";
            // 
            // VOZ_Button
            // 
            this.VOZ_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VOZ_Button.Location = new System.Drawing.Point(865, 310);
            this.VOZ_Button.Name = "VOZ_Button";
            this.VOZ_Button.Size = new System.Drawing.Size(171, 60);
            this.VOZ_Button.TabIndex = 2;
            this.VOZ_Button.Text = "VOZ";
            this.VOZ_Button.UseVisualStyleBackColor = true;
            this.VOZ_Button.Click += new System.EventHandler(this.VOZ_Button_Click);
            // 
            // MPLS_button
            // 
            this.MPLS_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPLS_button.Location = new System.Drawing.Point(865, 232);
            this.MPLS_button.Name = "MPLS_button";
            this.MPLS_button.Size = new System.Drawing.Size(171, 60);
            this.MPLS_button.TabIndex = 1;
            this.MPLS_button.Text = "MPLS";
            this.MPLS_button.UseVisualStyleBackColor = true;
            this.MPLS_button.Click += new System.EventHandler(this.MPLS_button_Click);
            // 
            // BLD_button
            // 
            this.BLD_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLD_button.Location = new System.Drawing.Point(865, 153);
            this.BLD_button.Name = "BLD_button";
            this.BLD_button.Size = new System.Drawing.Size(171, 60);
            this.BLD_button.TabIndex = 3;
            this.BLD_button.Text = "BLD";
            this.BLD_button.UseVisualStyleBackColor = true;
            this.BLD_button.Click += new System.EventHandler(this.BLD_button_Click);
            // 
            // tabScript
            // 
            this.tabScript.AutoScroll = true;
            this.tabScript.AutoScrollMinSize = new System.Drawing.Size(0, 100);
            this.tabScript.Controls.Add(this.Script_TypeLabel);
            this.tabScript.Controls.Add(this.Button_FormatarScript);
            this.tabScript.Controls.Add(this.BackButton_Script);
            this.tabScript.Controls.Add(this.Script_ComboBox);
            this.tabScript.Controls.Add(this.ScriptProcedure);
            this.tabScript.Controls.Add(this.pictureBox3);
            this.tabScript.Controls.Add(this.Script_Var6);
            this.tabScript.Controls.Add(this.Script_VarName6);
            this.tabScript.Controls.Add(this.ClearButton);
            this.tabScript.Controls.Add(this.CopyButton);
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
            this.tabScript.Controls.Add(this.ProcedureDescrip);
            this.tabScript.Controls.Add(this.ProcedureName);
            this.tabScript.Controls.Add(this.HomeButton_Script);
            this.tabScript.Controls.Add(this.label4);
            this.tabScript.Controls.Add(this.Script_VarName0);
            this.tabScript.Controls.Add(this.Script_Var0);
            this.tabScript.Controls.Add(this.label2);
            this.tabScript.Location = new System.Drawing.Point(4, 5);
            this.tabScript.Margin = new System.Windows.Forms.Padding(86, 87, 86, 87);
            this.tabScript.Name = "tabScript";
            this.tabScript.Padding = new System.Windows.Forms.Padding(3);
            this.tabScript.Size = new System.Drawing.Size(1146, 541);
            this.tabScript.TabIndex = 1;
            this.tabScript.Text = "tabPage5";
            this.tabScript.UseVisualStyleBackColor = true;
            // 
            // Script_TypeLabel
            // 
            this.Script_TypeLabel.AutoSize = true;
            this.Script_TypeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_TypeLabel.Location = new System.Drawing.Point(50, 131);
            this.Script_TypeLabel.Name = "Script_TypeLabel";
            this.Script_TypeLabel.Size = new System.Drawing.Size(39, 17);
            this.Script_TypeLabel.TabIndex = 28;
            this.Script_TypeLabel.Text = "Logs:";
            // 
            // Button_FormatarScript
            // 
            this.Button_FormatarScript.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FormatarScript.Location = new System.Drawing.Point(62, 353);
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
            this.BackButton_Script.Location = new System.Drawing.Point(1023, 87);
            this.BackButton_Script.Name = "BackButton_Script";
            this.BackButton_Script.Size = new System.Drawing.Size(104, 43);
            this.BackButton_Script.TabIndex = 26;
            this.BackButton_Script.Text = "Voltar";
            this.BackButton_Script.UseVisualStyleBackColor = true;
            this.BackButton_Script.Click += new System.EventHandler(this.BackButton1_Click);
            // 
            // Script_ComboBox
            // 
            this.Script_ComboBox.FormattingEnabled = true;
            this.Script_ComboBox.Items.AddRange(new object[] {
            "INICIAIS",
            "APLICADAS",
            "FINAIS"});
            this.Script_ComboBox.Location = new System.Drawing.Point(111, 128);
            this.Script_ComboBox.Name = "Script_ComboBox";
            this.Script_ComboBox.Size = new System.Drawing.Size(107, 21);
            this.Script_ComboBox.TabIndex = 25;
            // 
            // ScriptProcedure
            // 
            this.ScriptProcedure.AutoSize = true;
            this.ScriptProcedure.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScriptProcedure.Location = new System.Drawing.Point(358, 136);
            this.ScriptProcedure.Name = "ScriptProcedure";
            this.ScriptProcedure.Size = new System.Drawing.Size(34, 13);
            this.ScriptProcedure.TabIndex = 24;
            this.ScriptProcedure.Text = "Script";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Location = new System.Drawing.Point(352, 131);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(361, 393);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // Script_Var6
            // 
            this.Script_Var6.Location = new System.Drawing.Point(132, 307);
            this.Script_Var6.Name = "Script_Var6";
            this.Script_Var6.Size = new System.Drawing.Size(86, 20);
            this.Script_Var6.TabIndex = 22;
            this.Script_Var6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var6_KeyDown);
            // 
            // Script_VarName6
            // 
            this.Script_VarName6.AutoSize = true;
            this.Script_VarName6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName6.Location = new System.Drawing.Point(50, 309);
            this.Script_VarName6.Name = "Script_VarName6";
            this.Script_VarName6.Size = new System.Drawing.Size(66, 17);
            this.Script_VarName6.TabIndex = 21;
            this.Script_VarName6.Text = "Var Name";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(62, 451);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(104, 43);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Limpar";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(62, 402);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(104, 43);
            this.CopyButton.TabIndex = 19;
            this.CopyButton.Text = "Copiar";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // VarText
            // 
            this.VarText.AutoSize = true;
            this.VarText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarText.Location = new System.Drawing.Point(93, 87);
            this.VarText.Name = "VarText";
            this.VarText.Size = new System.Drawing.Size(73, 21);
            this.VarText.TabIndex = 18;
            this.VarText.Text = "Variáveis";
            // 
            // Script_Var5
            // 
            this.Script_Var5.Location = new System.Drawing.Point(132, 282);
            this.Script_Var5.Name = "Script_Var5";
            this.Script_Var5.Size = new System.Drawing.Size(86, 20);
            this.Script_Var5.TabIndex = 17;
            this.Script_Var5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var5_KeyDown);
            // 
            // Script_Var4
            // 
            this.Script_Var4.Location = new System.Drawing.Point(132, 257);
            this.Script_Var4.Name = "Script_Var4";
            this.Script_Var4.Size = new System.Drawing.Size(86, 20);
            this.Script_Var4.TabIndex = 16;
            this.Script_Var4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var4_KeyDown);
            // 
            // Script_Var3
            // 
            this.Script_Var3.Location = new System.Drawing.Point(132, 231);
            this.Script_Var3.Name = "Script_Var3";
            this.Script_Var3.Size = new System.Drawing.Size(86, 20);
            this.Script_Var3.TabIndex = 15;
            this.Script_Var3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var3_KeyDown);
            // 
            // Script_Var2
            // 
            this.Script_Var2.Location = new System.Drawing.Point(132, 206);
            this.Script_Var2.Name = "Script_Var2";
            this.Script_Var2.Size = new System.Drawing.Size(86, 20);
            this.Script_Var2.TabIndex = 14;
            this.Script_Var2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var2_KeyDown);
            // 
            // Script_Var1
            // 
            this.Script_Var1.Location = new System.Drawing.Point(132, 181);
            this.Script_Var1.Name = "Script_Var1";
            this.Script_Var1.Size = new System.Drawing.Size(86, 20);
            this.Script_Var1.TabIndex = 13;
            this.Script_Var1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var1_KeyDown);
            // 
            // Script_VarName5
            // 
            this.Script_VarName5.AutoSize = true;
            this.Script_VarName5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName5.Location = new System.Drawing.Point(50, 284);
            this.Script_VarName5.Name = "Script_VarName5";
            this.Script_VarName5.Size = new System.Drawing.Size(66, 17);
            this.Script_VarName5.TabIndex = 12;
            this.Script_VarName5.Text = "Var Name";
            // 
            // Script_VarName3
            // 
            this.Script_VarName3.AutoSize = true;
            this.Script_VarName3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName3.Location = new System.Drawing.Point(50, 234);
            this.Script_VarName3.Name = "Script_VarName3";
            this.Script_VarName3.Size = new System.Drawing.Size(66, 17);
            this.Script_VarName3.TabIndex = 11;
            this.Script_VarName3.Text = "Var Name";
            // 
            // Script_VarName4
            // 
            this.Script_VarName4.AutoSize = true;
            this.Script_VarName4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName4.Location = new System.Drawing.Point(50, 259);
            this.Script_VarName4.Name = "Script_VarName4";
            this.Script_VarName4.Size = new System.Drawing.Size(66, 17);
            this.Script_VarName4.TabIndex = 10;
            this.Script_VarName4.Text = "Var Name";
            // 
            // Script_VarName2
            // 
            this.Script_VarName2.AutoSize = true;
            this.Script_VarName2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName2.Location = new System.Drawing.Point(50, 209);
            this.Script_VarName2.Name = "Script_VarName2";
            this.Script_VarName2.Size = new System.Drawing.Size(66, 17);
            this.Script_VarName2.TabIndex = 9;
            this.Script_VarName2.Text = "Var Name";
            // 
            // Script_VarName1
            // 
            this.Script_VarName1.AutoSize = true;
            this.Script_VarName1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Script_VarName1.Location = new System.Drawing.Point(50, 184);
            this.Script_VarName1.Name = "Script_VarName1";
            this.Script_VarName1.Size = new System.Drawing.Size(66, 17);
            this.Script_VarName1.TabIndex = 8;
            this.Script_VarName1.Text = "Var Name";
            // 
            // ProcedureDescrip
            // 
            this.ProcedureDescrip.AutoSize = true;
            this.ProcedureDescrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcedureDescrip.Location = new System.Drawing.Point(822, 136);
            this.ProcedureDescrip.Name = "ProcedureDescrip";
            this.ProcedureDescrip.Size = new System.Drawing.Size(116, 20);
            this.ProcedureDescrip.TabIndex = 7;
            this.ProcedureDescrip.Text = "Description Text";
            // 
            // ProcedureName
            // 
            this.ProcedureName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProcedureName.AutoSize = true;
            this.ProcedureName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcedureName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProcedureName.Location = new System.Drawing.Point(435, 0);
            this.ProcedureName.Margin = new System.Windows.Forms.Padding(0);
            this.ProcedureName.Name = "ProcedureName";
            this.ProcedureName.Padding = new System.Windows.Forms.Padding(0, 17, 0, 17);
            this.ProcedureName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProcedureName.Size = new System.Drawing.Size(271, 79);
            this.ProcedureName.TabIndex = 5;
            this.ProcedureName.Text = "Procedure Name";
            this.ProcedureName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeButton_Script
            // 
            this.HomeButton_Script.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton_Script.Location = new System.Drawing.Point(1023, 21);
            this.HomeButton_Script.Name = "HomeButton_Script";
            this.HomeButton_Script.Size = new System.Drawing.Size(104, 43);
            this.HomeButton_Script.TabIndex = 4;
            this.HomeButton_Script.Text = "Home";
            this.HomeButton_Script.UseVisualStyleBackColor = true;
            this.HomeButton_Script.Click += new System.EventHandler(this.HomeButton_Script_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Script";
            // 
            // Script_VarName0
            // 
            this.Script_VarName0.AutoSize = true;
            this.Script_VarName0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Script_VarName0.Location = new System.Drawing.Point(50, 159);
            this.Script_VarName0.Name = "Script_VarName0";
            this.Script_VarName0.Size = new System.Drawing.Size(66, 17);
            this.Script_VarName0.TabIndex = 2;
            this.Script_VarName0.Text = "Var Name";
            // 
            // Script_Var0
            // 
            this.Script_Var0.Location = new System.Drawing.Point(132, 157);
            this.Script_Var0.Name = "Script_Var0";
            this.Script_Var0.Size = new System.Drawing.Size(86, 20);
            this.Script_Var0.TabIndex = 1;
            this.Script_Var0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLD_Var0_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(822, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição";
            // 
            // tabSelectRouter
            // 
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
            this.tabSelectRouter.Size = new System.Drawing.Size(1146, 541);
            this.tabSelectRouter.TabIndex = 2;
            this.tabSelectRouter.Text = "tabPage4";
            this.tabSelectRouter.UseVisualStyleBackColor = true;
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
            this.Config_HPE_old.Click += new System.EventHandler(this.Config_HPE_old_Click);
            // 
            // ConfiguracaoCPETitle
            // 
            this.ConfiguracaoCPETitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfiguracaoCPETitle.AutoSize = true;
            this.ConfiguracaoCPETitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfiguracaoCPETitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConfiguracaoCPETitle.Location = new System.Drawing.Point(404, 56);
            this.ConfiguracaoCPETitle.Name = "ConfiguracaoCPETitle";
            this.ConfiguracaoCPETitle.Size = new System.Drawing.Size(299, 37);
            this.ConfiguracaoCPETitle.TabIndex = 6;
            this.ConfiguracaoCPETitle.Text = "Configuracão CPE";
            this.ConfiguracaoCPETitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BackButton_SelectRouter
            // 
            this.BackButton_SelectRouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton_SelectRouter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_SelectRouter.Location = new System.Drawing.Point(1015, 28);
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
            this.ClientStepsPage.Controls.Add(this.button10);
            this.ClientStepsPage.Controls.Add(this.button9);
            this.ClientStepsPage.Location = new System.Drawing.Point(4, 5);
            this.ClientStepsPage.Name = "ClientStepsPage";
            this.ClientStepsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientStepsPage.Size = new System.Drawing.Size(1146, 541);
            this.ClientStepsPage.TabIndex = 3;
            this.ClientStepsPage.Text = "ClientStepsPage";
            this.ClientStepsPage.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1008, 460);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(64, 20);
            this.button10.TabIndex = 1;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(40, 446);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 20);
            this.button9.TabIndex = 0;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
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
            this.tabWizGat.Size = new System.Drawing.Size(1146, 541);
            this.tabWizGat.TabIndex = 4;
            this.tabWizGat.Text = "WizGat";
            this.tabWizGat.UseVisualStyleBackColor = true;
            // 
            // BackButton_WizGat
            // 
            this.BackButton_WizGat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton_WizGat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton_WizGat.Location = new System.Drawing.Point(1010, 28);
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
            this.WizCiscoBGP.Location = new System.Drawing.Point(666, 292);
            this.WizCiscoBGP.Name = "WizCiscoBGP";
            this.WizCiscoBGP.Size = new System.Drawing.Size(114, 46);
            this.WizCiscoBGP.TabIndex = 9;
            this.WizCiscoBGP.Text = "BLD c/ BGP";
            this.WizCiscoBGP.UseVisualStyleBackColor = true;
            this.WizCiscoBGP.Click += new System.EventHandler(this.WizCiscoBGP_Click);
            // 
            // WizCiscoVoz
            // 
            this.WizCiscoVoz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizCiscoVoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizCiscoVoz.Location = new System.Drawing.Point(546, 292);
            this.WizCiscoVoz.Name = "WizCiscoVoz";
            this.WizCiscoVoz.Size = new System.Drawing.Size(114, 46);
            this.WizCiscoVoz.TabIndex = 8;
            this.WizCiscoVoz.Text = "VOZ";
            this.WizCiscoVoz.UseVisualStyleBackColor = true;
            this.WizCiscoVoz.Click += new System.EventHandler(this.WizCiscoVoz_Click);
            // 
            // WizCiscoMPLS
            // 
            this.WizCiscoMPLS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizCiscoMPLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizCiscoMPLS.Location = new System.Drawing.Point(426, 292);
            this.WizCiscoMPLS.Name = "WizCiscoMPLS";
            this.WizCiscoMPLS.Size = new System.Drawing.Size(114, 46);
            this.WizCiscoMPLS.TabIndex = 7;
            this.WizCiscoMPLS.Text = "MPLS";
            this.WizCiscoMPLS.UseVisualStyleBackColor = true;
            this.WizCiscoMPLS.Click += new System.EventHandler(this.WizCiscoMPLS_Click);
            // 
            // WizCiscoBLD
            // 
            this.WizCiscoBLD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizCiscoBLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizCiscoBLD.Location = new System.Drawing.Point(306, 292);
            this.WizCiscoBLD.Name = "WizCiscoBLD";
            this.WizCiscoBLD.Size = new System.Drawing.Size(114, 46);
            this.WizCiscoBLD.TabIndex = 6;
            this.WizCiscoBLD.Text = "BLD";
            this.WizCiscoBLD.UseVisualStyleBackColor = true;
            this.WizCiscoBLD.Click += new System.EventHandler(this.WizCiscoBLD_Click);
            // 
            // WizCiscoTitle
            // 
            this.WizCiscoTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizCiscoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizCiscoTitle.Location = new System.Drawing.Point(484, 226);
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
            this.WizNokiaTitle.Location = new System.Drawing.Point(484, 69);
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
            this.WizNokiaBLDcBGP.Location = new System.Drawing.Point(666, 127);
            this.WizNokiaBLDcBGP.Name = "WizNokiaBLDcBGP";
            this.WizNokiaBLDcBGP.Size = new System.Drawing.Size(114, 46);
            this.WizNokiaBLDcBGP.TabIndex = 3;
            this.WizNokiaBLDcBGP.Text = "BLD c/ BGP";
            this.WizNokiaBLDcBGP.UseVisualStyleBackColor = true;
            this.WizNokiaBLDcBGP.Click += new System.EventHandler(this.WizNokiaBLDcBGP_Click);
            // 
            // WizNokiaVoz
            // 
            this.WizNokiaVoz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizNokiaVoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizNokiaVoz.Location = new System.Drawing.Point(546, 127);
            this.WizNokiaVoz.Name = "WizNokiaVoz";
            this.WizNokiaVoz.Size = new System.Drawing.Size(114, 46);
            this.WizNokiaVoz.TabIndex = 2;
            this.WizNokiaVoz.Text = "VOZ";
            this.WizNokiaVoz.UseVisualStyleBackColor = true;
            this.WizNokiaVoz.Click += new System.EventHandler(this.WizNokiaVoz_Click);
            // 
            // WizNokiaMPLS
            // 
            this.WizNokiaMPLS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizNokiaMPLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizNokiaMPLS.Location = new System.Drawing.Point(426, 127);
            this.WizNokiaMPLS.Name = "WizNokiaMPLS";
            this.WizNokiaMPLS.Size = new System.Drawing.Size(114, 46);
            this.WizNokiaMPLS.TabIndex = 1;
            this.WizNokiaMPLS.Text = "MPLS";
            this.WizNokiaMPLS.UseVisualStyleBackColor = true;
            this.WizNokiaMPLS.Click += new System.EventHandler(this.WizNokiaMPLS_Click);
            // 
            // WizNokiaBLD
            // 
            this.WizNokiaBLD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WizNokiaBLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizNokiaBLD.Location = new System.Drawing.Point(306, 127);
            this.WizNokiaBLD.Name = "WizNokiaBLD";
            this.WizNokiaBLD.Size = new System.Drawing.Size(114, 46);
            this.WizNokiaBLD.TabIndex = 0;
            this.WizNokiaBLD.Text = "BLD";
            this.WizNokiaBLD.UseVisualStyleBackColor = true;
            this.WizNokiaBLD.Click += new System.EventHandler(this.WizNokiaBLD_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(994, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Created by: Ricardo Thiago Firmino";
            // 
            // tabRouters
            // 
            this.tabRouters.Controls.Add(this.dataGridView1);
            this.tabRouters.Controls.Add(this.button2);
            this.tabRouters.Location = new System.Drawing.Point(4, 22);
            this.tabRouters.Name = "tabRouters";
            this.tabRouters.Padding = new System.Windows.Forms.Padding(3);
            this.tabRouters.Size = new System.Drawing.Size(1160, 627);
            this.tabRouters.TabIndex = 1;
            this.tabRouters.Text = "Routers";
            this.tabRouters.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Modelo,
            this.IOS,
            this.MaxBandwidth});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1154, 621);
            this.dataGridView1.TabIndex = 4;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // IOS
            // 
            this.IOS.HeaderText = "IOS";
            this.IOS.Name = "IOS";
            // 
            // MaxBandwidth
            // 
            this.MaxBandwidth.HeaderText = "Max Bandwidth";
            this.MaxBandwidth.Name = "MaxBandwidth";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button2.Location = new System.Drawing.Point(22, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create New";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabLogTools
            // 
            this.tabLogTools.Controls.Add(this.LogToolsSuporte);
            this.tabLogTools.Controls.Add(this.LogToolsFechamento);
            this.tabLogTools.Controls.Add(this.LogToolsPendencia);
            this.tabLogTools.Controls.Add(this.tabControlLogTools);
            this.tabLogTools.Location = new System.Drawing.Point(4, 22);
            this.tabLogTools.Name = "tabLogTools";
            this.tabLogTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogTools.Size = new System.Drawing.Size(1160, 627);
            this.tabLogTools.TabIndex = 2;
            this.tabLogTools.Text = "LogTools";
            this.tabLogTools.UseVisualStyleBackColor = true;
            // 
            // LogToolsSuporte
            // 
            this.LogToolsSuporte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogToolsSuporte.Location = new System.Drawing.Point(42, 181);
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
            this.LogToolsFechamento.Location = new System.Drawing.Point(42, 108);
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
            this.LogToolsPendencia.Location = new System.Drawing.Point(42, 38);
            this.LogToolsPendencia.Name = "LogToolsPendencia";
            this.LogToolsPendencia.Size = new System.Drawing.Size(114, 54);
            this.LogToolsPendencia.TabIndex = 12;
            this.LogToolsPendencia.Text = "Pendencia";
            this.LogToolsPendencia.UseVisualStyleBackColor = true;
            this.LogToolsPendencia.Click += new System.EventHandler(this.LogToolsPendencia_Click);
            // 
            // tabControlLogTools
            // 
            this.tabControlLogTools.Controls.Add(this.tabPendencia);
            this.tabControlLogTools.Controls.Add(this.tabFechamento);
            this.tabControlLogTools.Controls.Add(this.tabSuporte);
            this.tabControlLogTools.Location = new System.Drawing.Point(217, 6);
            this.tabControlLogTools.Name = "tabControlLogTools";
            this.tabControlLogTools.SelectedIndex = 0;
            this.tabControlLogTools.Size = new System.Drawing.Size(947, 625);
            this.tabControlLogTools.TabIndex = 11;
            // 
            // tabPendencia
            // 
            this.tabPendencia.Controls.Add(this.Log_FinalTextBox);
            this.tabPendencia.Controls.Add(this.Log_Copy);
            this.tabPendencia.Controls.Add(this.Log_Clear);
            this.tabPendencia.Controls.Add(this.label9);
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
            this.tabPendencia.Size = new System.Drawing.Size(939, 599);
            this.tabPendencia.TabIndex = 0;
            this.tabPendencia.Text = "Pendencia";
            this.tabPendencia.UseVisualStyleBackColor = true;
            // 
            // Log_FinalTextBox
            // 
            this.Log_FinalTextBox.AllowDrop = true;
            this.Log_FinalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Log_FinalTextBox.Location = new System.Drawing.Point(421, 391);
            this.Log_FinalTextBox.Multiline = true;
            this.Log_FinalTextBox.Name = "Log_FinalTextBox";
            this.Log_FinalTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Log_FinalTextBox.Size = new System.Drawing.Size(483, 208);
            this.Log_FinalTextBox.TabIndex = 12;
            this.Log_FinalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Log_FinalTextBox.WordWrap = false;
            // 
            // Log_Copy
            // 
            this.Log_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Log_Copy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Copy.Location = new System.Drawing.Point(318, 309);
            this.Log_Copy.Name = "Log_Copy";
            this.Log_Copy.Size = new System.Drawing.Size(234, 40);
            this.Log_Copy.TabIndex = 12;
            this.Log_Copy.Text = "Formatar e Copiar";
            this.Log_Copy.UseVisualStyleBackColor = true;
            this.Log_Copy.Click += new System.EventHandler(this.Log_Copy_Click_1);
            // 
            // Log_Clear
            // 
            this.Log_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Log_Clear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Clear.Location = new System.Drawing.Point(659, 309);
            this.Log_Clear.Name = "Log_Clear";
            this.Log_Clear.Size = new System.Drawing.Size(256, 40);
            this.Log_Clear.TabIndex = 11;
            this.Log_Clear.Text = "Limpar";
            this.Log_Clear.UseVisualStyleBackColor = true;
            this.Log_Clear.Click += new System.EventHandler(this.Log_Clear_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Texto Aqui";
            // 
            // Log_Format
            // 
            this.Log_Format.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Log_Format.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Format.Location = new System.Drawing.Point(21, 309);
            this.Log_Format.Name = "Log_Format";
            this.Log_Format.Size = new System.Drawing.Size(190, 40);
            this.Log_Format.TabIndex = 7;
            this.Log_Format.Text = "Formatar";
            this.Log_Format.UseVisualStyleBackColor = true;
            this.Log_Format.Click += new System.EventHandler(this.Log_Copy_Click);
            // 
            // Log_TextBox3
            // 
            this.Log_TextBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Log_TextBox3.Location = new System.Drawing.Point(3, 208);
            this.Log_TextBox3.Multiline = true;
            this.Log_TextBox3.Name = "Log_TextBox3";
            this.Log_TextBox3.Size = new System.Drawing.Size(933, 63);
            this.Log_TextBox3.TabIndex = 6;
            // 
            // Log_ProximosPassos
            // 
            this.Log_ProximosPassos.AutoSize = true;
            this.Log_ProximosPassos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Log_ProximosPassos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_ProximosPassos.Location = new System.Drawing.Point(3, 178);
            this.Log_ProximosPassos.Name = "Log_ProximosPassos";
            this.Log_ProximosPassos.Size = new System.Drawing.Size(187, 30);
            this.Log_ProximosPassos.TabIndex = 5;
            this.Log_ProximosPassos.Text = " Próximos Passos:";
            // 
            // Log_TextBox2
            // 
            this.Log_TextBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Log_TextBox2.Location = new System.Drawing.Point(3, 119);
            this.Log_TextBox2.Multiline = true;
            this.Log_TextBox2.Name = "Log_TextBox2";
            this.Log_TextBox2.Size = new System.Drawing.Size(933, 59);
            this.Log_TextBox2.TabIndex = 4;
            // 
            // Log_StatusAtual
            // 
            this.Log_StatusAtual.AutoSize = true;
            this.Log_StatusAtual.Dock = System.Windows.Forms.DockStyle.Top;
            this.Log_StatusAtual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_StatusAtual.Location = new System.Drawing.Point(3, 89);
            this.Log_StatusAtual.Name = "Log_StatusAtual";
            this.Log_StatusAtual.Size = new System.Drawing.Size(169, 30);
            this.Log_StatusAtual.TabIndex = 3;
            this.Log_StatusAtual.Text = " O que foi feito:";
            // 
            // Log_TextBox1
            // 
            this.Log_TextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Log_TextBox1.Location = new System.Drawing.Point(3, 33);
            this.Log_TextBox1.Multiline = true;
            this.Log_TextBox1.Name = "Log_TextBox1";
            this.Log_TextBox1.Size = new System.Drawing.Size(933, 56);
            this.Log_TextBox1.TabIndex = 2;
            // 
            // Log_StatusAnterior
            // 
            this.Log_StatusAnterior.AutoSize = true;
            this.Log_StatusAnterior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Log_StatusAnterior.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_StatusAnterior.Location = new System.Drawing.Point(3, 3);
            this.Log_StatusAnterior.Name = "Log_StatusAnterior";
            this.Log_StatusAnterior.Size = new System.Drawing.Size(174, 30);
            this.Log_StatusAnterior.TabIndex = 1;
            this.Log_StatusAnterior.Text = " Status Anterior:";
            // 
            // tabFechamento
            // 
            this.tabFechamento.Location = new System.Drawing.Point(4, 22);
            this.tabFechamento.Name = "tabFechamento";
            this.tabFechamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabFechamento.Size = new System.Drawing.Size(939, 599);
            this.tabFechamento.TabIndex = 1;
            this.tabFechamento.Text = "Fechamento";
            this.tabFechamento.UseVisualStyleBackColor = true;
            // 
            // tabSuporte
            // 
            this.tabSuporte.Controls.Add(this.LogToolsSuporteFinalText);
            this.tabSuporte.Controls.Add(this.LogToolsSuporteTitle);
            this.tabSuporte.Controls.Add(this.TextBox_LogToolsSuporte1);
            this.tabSuporte.Controls.Add(this.TextBox_LogToolsSuporte);
            this.tabSuporte.Controls.Add(this.ButtonLogTools_Suporte);
            this.tabSuporte.Location = new System.Drawing.Point(4, 22);
            this.tabSuporte.Name = "tabSuporte";
            this.tabSuporte.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuporte.Size = new System.Drawing.Size(939, 599);
            this.tabSuporte.TabIndex = 2;
            this.tabSuporte.Text = "Suporte";
            this.tabSuporte.UseVisualStyleBackColor = true;
            // 
            // ButtonLogTools_Suporte
            // 
            this.ButtonLogTools_Suporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonLogTools_Suporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogTools_Suporte.Location = new System.Drawing.Point(414, 334);
            this.ButtonLogTools_Suporte.Name = "ButtonLogTools_Suporte";
            this.ButtonLogTools_Suporte.Size = new System.Drawing.Size(126, 43);
            this.ButtonLogTools_Suporte.TabIndex = 0;
            this.ButtonLogTools_Suporte.Text = "Formatar";
            this.ButtonLogTools_Suporte.UseVisualStyleBackColor = true;
            this.ButtonLogTools_Suporte.Click += new System.EventHandler(this.ButtonLogTools_Suporte_Click);
            // 
            // TextBox_LogToolsSuporte
            // 
            this.TextBox_LogToolsSuporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBox_LogToolsSuporte.Location = new System.Drawing.Point(258, 103);
            this.TextBox_LogToolsSuporte.Multiline = true;
            this.TextBox_LogToolsSuporte.Name = "TextBox_LogToolsSuporte";
            this.TextBox_LogToolsSuporte.Size = new System.Drawing.Size(420, 44);
            this.TextBox_LogToolsSuporte.TabIndex = 1;
            // 
            // TextBox_LogToolsSuporte1
            // 
            this.TextBox_LogToolsSuporte1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBox_LogToolsSuporte1.Location = new System.Drawing.Point(258, 189);
            this.TextBox_LogToolsSuporte1.Multiline = true;
            this.TextBox_LogToolsSuporte1.Name = "TextBox_LogToolsSuporte1";
            this.TextBox_LogToolsSuporte1.Size = new System.Drawing.Size(420, 106);
            this.TextBox_LogToolsSuporte1.TabIndex = 2;
            // 
            // LogToolsSuporteTitle
            // 
            this.LogToolsSuporteTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogToolsSuporteTitle.AutoSize = true;
            this.LogToolsSuporteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogToolsSuporteTitle.Location = new System.Drawing.Point(395, 44);
            this.LogToolsSuporteTitle.Name = "LogToolsSuporteTitle";
            this.LogToolsSuporteTitle.Size = new System.Drawing.Size(153, 31);
            this.LogToolsSuporteTitle.TabIndex = 3;
            this.LogToolsSuporteTitle.Text = "SUPORTE";
            this.LogToolsSuporteTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LogToolsSuporteFinalText
            // 
            this.LogToolsSuporteFinalText.AutoSize = true;
            this.LogToolsSuporteFinalText.Location = new System.Drawing.Point(437, 408);
            this.LogToolsSuporteFinalText.Name = "LogToolsSuporteFinalText";
            this.LogToolsSuporteFinalText.Size = new System.Drawing.Size(79, 13);
            this.LogToolsSuporteFinalText.TabIndex = 4;
            this.LogToolsSuporteFinalText.Text = "Final Text Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 675);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MasterSheet";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMaster.ResumeLayout(false);
            this.tabMaster.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabSelectProcedure.ResumeLayout(false);
            this.tabSelectProcedure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabScript.ResumeLayout(false);
            this.tabScript.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabSelectRouter.ResumeLayout(false);
            this.tabSelectRouter.PerformLayout();
            this.ClientStepsPage.ResumeLayout(false);
            this.tabWizGat.ResumeLayout(false);
            this.tabRouters.ResumeLayout(false);
            this.tabRouters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabLogTools.ResumeLayout(false);
            this.tabControlLogTools.ResumeLayout(false);
            this.tabPendencia.ResumeLayout(false);
            this.tabPendencia.PerformLayout();
            this.tabSuporte.ResumeLayout(false);
            this.tabSuporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabMaster;
        private TabPage tabRouters;
        private Button button2;
        private TabControl tabControl2;
        private TabPage tabSelectProcedure;
        private Button BLD_button;
        private TabPage tabScript;
        private TextBox Script_Var0;
        private Label label2;
        private Label label4;
        private Label Script_VarName0;
        private Button HomeButton_Script;
        private Label label5;
        private Label Version;
        private Label ProcedureName;
        private Label ProcedureDescrip;
        private Label Script_VarName4;
        private Label Script_VarName2;
        private Label Script_VarName1;
        private Label Script_VarName5;
        private Label Script_VarName3;
        private TextBox Script_Var5;
        private TextBox Script_Var4;
        private TextBox Script_Var3;
        private TextBox Script_Var2;
        private TextBox Script_Var1;
        private Label VarText;
        private Button VOZ_Button;
        private Button MPLS_button;
        private TabPage tabSelectRouter;
        private Button Config_Cisco;
        private Button Config_HPE;
        private Button BackButton_SelectRouter;
        private Button ClearButton;
        private Button CopyButton;
        private TextBox Script_Var6;
        private Label Script_VarName6;
        private PictureBox pictureBox2;
        private Label TemplatesLabel;
        private Label LogsSubTitle;
        private Label ClientesSubTitle;
        private Label ScriptsSubTitle;
        private LinkLabel AllClients;
        private Button ClienteButton_Test4;
        private Button ClienteButton_Test3;
        private Button ClienteButton_Test2;
        private Button ClienteButton_Teste1;
        private Button Logs_Finais;
        private Button Logs_Iniciais;
        private TabPage ClientStepsPage;
        private Button button10;
        private Button button9;
        private Button WizGat_CiscoBLD;
        private Label WizardGatLabel;
        private Label OutrasConfigs;
        private Button OutrosButton1;
        private Button OutrosButton2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn IOS;
        private DataGridViewTextBoxColumn MaxBandwidth;
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
        private Label ScriptProcedure;
        private PictureBox pictureBox3;
        private ComboBox Script_ComboBox;
        private Button BackButton_Script;
        private Button Button_FormatarScript;
        private Label ConfiguracaoCPETitle;
        private Button Config_Fortigate;
        private Button Config_Huawei;
        private Button Config_HPE_old;
        private Label Script_TypeLabel;
        private TabPage tabLogTools;
        private TabControl tabControlLogTools;
        private TabPage tabPendencia;
        private Button Log_Copy;
        private Label label9;
        private Button Log_Format;
        private TextBox Log_TextBox3;
        private Label Log_ProximosPassos;
        private TextBox Log_TextBox2;
        private Label Log_StatusAtual;
        private TextBox Log_TextBox1;
        private Label Log_StatusAnterior;
        private TabPage tabFechamento;
        private Label label3;
        private Button Log_Clear;
        private TextBox Log_FinalTextBox;
        private Button LogToolsPendencia;
        private Button LogToolsFechamento;
        private Button LogToolsSuporte;
        private TabPage tabSuporte;
        private Button ButtonLogTools_Suporte;
        private Label LogToolsSuporteFinalText;
        private Label LogToolsSuporteTitle;
        private TextBox TextBox_LogToolsSuporte1;
        private TextBox TextBox_LogToolsSuporte;
    }
}

