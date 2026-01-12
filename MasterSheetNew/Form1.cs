using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MasterSheetNew
{
    public partial class Form1 : Form
    {

        RouterType routerType;
        ActivityType activityType;
        bool backboneOrNot;
        bool logOrNot;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //-----------
            // SQL TEST
            //-----------

            try
            {
                var conectionStr = "server=localhost;uid=seila;database=test";
                var dbConection = new MySqlConnection(conectionStr);

                dbConection.Open();

                var sqlCommand = new MySqlCommand("SELECT * FROM clients", dbConection);
                var reader = sqlCommand.ExecuteReader();


                while (reader.Read())
                {
                    // Display Buttons for every Important Client

                    // Exemple
                    MessageBox.Show($"{reader["id"]} --- {reader["name"]}");
                }

                MessageBox.Show("Conexão com Banco de Dados Ok");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao Banco de Dados: " +
                    "\n" + ex.Message);
            }


        }


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {
            // Open Another Form that display all Versions and Changes
        }


        // ------------------------
        // Wizard Gat
        // ------------------------

        private void WizGat_CiscoBLD_Click_1(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabWizGat;
        }


        // ------------------------
        // Configuracoes Buttons
        // ------------------------

        private void BLD_button_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabSelectRouter;

            activityType = ActivityType.BLD;
        }

        // ------------------------
        // Back Buttons
        // ------------------------

        private void BackButton1_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabSelectRouter;
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

            ApplyVariebleToScript(routerType);
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



        // ------------------------------------------------------------------------------
        // SCRIPT TAB
        // ------------------------------------------------------------------------------

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

        private void BLD_Var1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyVariebleToScript(routerType);
            }
        }

        private void BLD_Var2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyVariebleToScript(routerType);
            }
        }

        private void BLD_Var3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyVariebleToScript(routerType);
            }
        }

        private void BLD_Var4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyVariebleToScript(routerType);
            }
        }

        private void BLD_Var5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyVariebleToScript(routerType);
            }
        }

        private void BLD_Var6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyVariebleToScript(routerType);
            }
        }


        // ---------------------------
        // Apply Varieble To Script
        // ---------------------------
        #region

        public void ApplyVariebleToScript(RouterType type)
        {

            WindowsFormsApp1.Entitys.Script bldScript = new WindowsFormsApp1.Entitys.Script("BLD", "test");
            ProcedureName.Text = bldScript.name;
            ProcedureDescrip.Text = "Teste de Script para BLD";

            Script_VarName0.Text = "Hostname:";
            Script_VarName1.Text = "Interface WAN:";
            Script_VarName2.Text = "Description:";
            Script_VarName3.Text = "Bandwidth";
            Script_VarName4.Text = "Interface LAN";
            Script_VarName5.Text = "IP de LAN";
            Script_VarName6.Text = "Máscara";

            if (type == RouterType.Cisco && activityType == ActivityType.BLD && logOrNot == false)
            {
                Script_ComboBox.Hide();

                ScriptProcedure.Text = "conf t \n" +
                "!\n!\n!\n" +
                "hostname " + Script_Var0.Text + "\n" +
                "!\n!\n!\n" +
                "interface " + Script_Var1.Text + "\n" +
                "description " + Script_Var2.Text + "\n" +
                "bandwidth " + Script_Var3.Text + "\n" +
                "!\n!\n!\n" +
                "interface " + Script_Var4.Text + "\n" +
                "description **LAN**" + "\n" +
                "ip address " + Script_Var5.Text + " " + Script_Var6.Text + "\n" +
                "!\n!\n!\n" +
                "!\n!\n!\n" +
                "!\n!\n!\n" +
                "!\n!\n!\n" +
                "!\n!\n!\n" +
                "!\n!\n!\n" +
                "end";
            }

            else if (type == RouterType.HPE && activityType == ActivityType.BLD && logOrNot == false)
            {
                Script_ComboBox.Hide();

                ScriptProcedure.Text = "sys \n" +
                "#\n#\n#\n" +
                "hostname " + Script_Var0.Text + "\n" +
                "#\n#\n#\n" +
                "interface " + Script_Var1.Text + "\n" +
                "description " + Script_Var2.Text + "\n" +
                "bandwidth " + Script_Var3.Text + "\n" +
                "#\n#\n#\n" +
                "interface " + Script_Var4.Text + "\n" +
                "description **LAN**" + "\n" +
                "ip address " + Script_Var5.Text + " " + Script_Var6.Text + "\n" +
                "#\n#\n#\n" +
                "#\n#\n#\n" +
                "#\n#\n#\n" +
                "#\n#\n#\n" +
                "#\n#\n#\n" +
                "#\n#\n#\n" +
                "end";
            }

            else if ((type == RouterType.Cisco) && (activityType == ActivityType.BLD) && backboneOrNot == true && logOrNot == true)
            {
                Script_VarName0.Text = "Interface PE:";
                Script_VarName1.Text = "IP CPE:";

                Script_VarName2.Hide();
                Script_VarName3.Hide();
                Script_VarName4.Hide();
                Script_VarName5.Hide();
                Script_VarName6.Hide();

                Script_Var2.Hide();
                Script_Var3.Hide();
                Script_Var4.Hide();
                Script_Var5.Hide();
                Script_Var6.Hide();

                Script_ComboBox.Text = "INICIAIS";


                ScriptProcedure.Text = "!######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show running-config interface " + Script_Var0.Text + "\n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show interface " + Script_Var0.Text + "\n" +
                "\n" +
                "\n" +
                "\n" +
                "################# Rota Estatica ################# \n" +
                "\n" +
                "show running-config | inc " + Script_Var1.Text + "\n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show running-config | inc  " + Script_Var0.Text + "\n" +
                "\n" +
                "\n" +
                "\n" +
                "##################### QoS ##################### \n" +
                "\n" +
                "show policy-map interface " + Script_Var1.Text + "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "!############### Ping ##################### \n" +
                "\n" +
                "ping \n" +
                "\n" +
                Script_Var1.Text + "\n" +
                "15 \n" +
                "1500 \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
            }

            else if ((type == RouterType.Cisco) && (activityType == ActivityType.MPLS) && backboneOrNot == true && logOrNot == true)
            {

                Script_VarName0.Text = "Interface PE:";
                Script_VarName1.Text = "IP CPE:";
                Script_VarName2.Text = "Nome da VRF:";

                Script_VarName3.Hide();
                Script_VarName4.Hide();
                Script_VarName5.Hide();
                Script_VarName6.Hide();

                Script_Var3.Hide();
                Script_Var4.Hide();
                Script_Var5.Hide();
                Script_Var6.Hide();

                Script_ComboBox.Text = "INICIAIS";


                ScriptProcedure.Text = "!######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show running-config interface " + Script_Var0.Text + "\n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show interface " + Script_Var0.Text + "\n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show running-config vrf " + Script_Var2.Text + "\n" +
                "\n" +
                "\n" +
                "\n" +
                "################# Rota Estatica ################# \n" +
                "\n" +
                "show running-config | inc " + Script_Var1.Text + "\n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show running-config | inc  " + Script_Var0.Text + "\n" +
                "\n" +
                "\n" +
                "\n" +
                "##################### QoS ##################### \n" +
                "\n" +
                "show policy-map interface " + Script_Var1.Text + "\n" +
                "\n" +
                "\n" +
                "\n" +
                "######################## BGP ######################## \n" +
                "\n" +
                "show running-config router bgp 4230 vrf " + Script_Var2.Text + " neighbor " + Script_Var1.Text + " \n" +
                "\n" +
                "\n" +
                "\n" +
                "########################################### \n" +
                "\n" +
                "show ip bgp vrf " + Script_Var2.Text + " summary \n" +
                "\n" +
                "\n" +
                "########################################### \n" +
                "\n" +
                "show ip bgp vrf " + Script_Var2.Text + " sum | inc " + Script_Var1.Text + " \n" +
                "\n" +
                "\n" +
                "########################################### \n" +
                "\n" +
                "show ip bgp vrf " + Script_Var2.Text + " nei " + Script_Var1.Text + " advertised-r | i xes \n" +
                "\n" +
                "\n" +
                "########################################### \n" +
                "\n" +
                "show ip bgp vrf " + Script_Var2.Text + " nei " + Script_Var1.Text + " ro \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "!############### Ping ##################### \n" +
                "\n" +
                "ping vrf " + Script_Var2.Text + " \n" +
                "\n" +
                Script_Var1.Text + "\n" +
                "15 \n" +
                "1500 \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
            }

            else if ((type == RouterType.Cisco) && (activityType == ActivityType.VOZ) && backboneOrNot == true && logOrNot == true)
            {

                Script_VarName0.Text = "Interface PE:";
                Script_VarName1.Text = "IP CPE:";

                Script_VarName2.Hide();
                Script_VarName3.Hide();
                Script_VarName4.Hide();
                Script_VarName5.Hide();
                Script_VarName6.Hide();

                Script_Var2.Hide();
                Script_Var3.Hide();
                Script_Var4.Hide();
                Script_Var5.Hide();
                Script_Var6.Hide();

                Script_ComboBox.Text = "INICIAIS";


                ScriptProcedure.Text = "!######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show running-config interface " + Script_Var0.Text + "\n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show interface " + Script_Var0.Text + "\n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show running-config vrf REALIP_CLIENTE:5581 \n" +
                "\n" +
                "\n" +
                "\n" +
                "################# Rota Estatica ################# \n" +
                "\n" +
                "show running-config | inc " + Script_Var1.Text + "\n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show running-config | inc  " + Script_Var0.Text + "\n" +
                "\n" +
                "\n" +
                "\n" +
                "!##################### QoS ###################### \n" +
                "\n" +
                "show policy-map interface " + Script_Var1.Text + "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "!############### Ping ##################### \n" +
                "\n" +
                "ping vrf REALIP_CLIENTE:5581 \n" +
                "\n" +
                Script_Var1.Text + "\n" +
                "15 \n" +
                "1500 \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n";
            }


            else if ((type == RouterType.Nokia) && (activityType == ActivityType.BLD) && backboneOrNot == true && logOrNot == true)
            {
                Script_VarName0.Text = "Interface PE:";
                Script_VarName1.Text = "IP PE:";
                Script_VarName2.Text = "IP CPE:";
                Script_VarName3.Text = "IPv6 CPE:";
                Script_VarName4.Text = "ID QoS:";

                Script_VarName5.Hide();
                Script_VarName6.Hide();

                Script_Var5.Hide();
                Script_Var6.Hide();

                Script_ComboBox.Text = "INICIAIS";


                ScriptProcedure.Text = "!######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "admin display-config | match " + Script_Var1.Text + " context all \n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "admin display-config | match expression " + Script_Var0.Text + "[^0-9] context all \n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show router interface " + Script_Var0.Text + " \n" +
                "\n" +
                "\n" +
                "\n" +
                "!##################### QoS ###################### \n" +
                "\n" +
                "show qos sap-ingress " + Script_Var4.Text + " \n" +
                "\n" +
                "\n" +
                "show qos sap-ingress " + Script_Var4.Text + " \n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "\n" +
                "\n" +
                "!################# ROTA ESTATICA #################### \n" +
                "\n" +
                "admin display-config | match " + Script_Var2.Text + " context all \n" +
                "\n" +
                "\n" +
                "show router static-route next-hop " + Script_Var2.Text +
                "\n" +
                "\n" +
                "admin display-config | match " + Script_Var2.Text + " pre-line 1 post-lines 5 \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "!################### PING #################### \n" +
                "\n" +
                "ping " + Script_Var2.Text + " size 1500 count 15 interface " + Script_Var0.Text + " rapid \n" +
                "\n" +
                "\n" +
                "\n";
            }


            else if ((type == RouterType.Nokia) && (activityType == ActivityType.MPLS) && backboneOrNot == true && logOrNot == true)
            {
                Script_VarName0.Text = "Interface PE:";
                Script_VarName1.Text = "IP PE:";
                Script_VarName2.Text = "IP CPE:";
                Script_VarName3.Text = "IPv6 CPE:";
                Script_VarName4.Text = "ID QoS:";
                Script_VarName5.Text = "Nome da VRF:";
                Script_VarName6.Text = "Service ID:";

                Script_ComboBox.Text = "INICIAIS";


                string vrfAS = " ";

                if (Script_Var5.Text.Contains(':'))
                {
                    string[] splitStr = Script_Var5.Text.Split(new char[] { ':' });
                    vrfAS = splitStr[1];
                }


                ScriptProcedure.Text = "!######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "admin display-config | match " + Script_Var1.Text + " context all \n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "admin display-config | match expression " + Script_Var0.Text + "[^0-9] context all \n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "admin display-config | match expression " + '"' + "route-distinguisher " + "4230:" + vrfAS + '"' + " pre-line 8 post-lines 10" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show router service-name " + Script_Var6.Text + " interface " + Script_Var0.Text + " \n" +
                "\n" +
                "\n" +
                "\n" +
                "!##################### QoS ###################### \n" +
                "\n" +
                "show qos sap-ingress " + Script_Var4.Text + " \n" +
                "\n" +
                "\n" +
                "show qos sap-ingress " + Script_Var4.Text + " \n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "\n" +
                "\n" +
                "!################# ROTA ESTATICA #################### \n" +
                "\n" +
                "show router service-name " + Script_Var6.Text + " static-route next-hop " + Script_Var2.Text +
                "\n" +
                "\n" +
                "admin display-config | match " + Script_Var2.Text + " pre-line 1 post-lines 6 \n" +
                "\n" +
                "\n" +
                "\n" +
                "!################### BGP ###################### \n" +
                "\n" +
                "admin display-config | match " + Script_Var2.Text + " context all \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show router service-name " + Script_Var6.Text + " bgp summary | match " + Script_Var2.Text + " post-lines 3 \n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show router service-name " + Script_Var6.Text + " bgp neighbor " + Script_Var2.Text + " received-routes \n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show router service-name " + Script_Var6.Text + " bgp neighbor " + Script_Var2.Text + " advertised-routes | match Routes \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "!################### PING #################### \n" +
                "\n" +
                "ping " + "service-name " + Script_Var6.Text + " " + Script_Var2.Text + " size 1500 count 15 interface " + Script_Var0.Text + " rapid \n" +
                "\n" +
                "\n" +
                "\n";
            }

            else if ((type == RouterType.Nokia) && (activityType == ActivityType.VOZ) && backboneOrNot == true && logOrNot == true)
            {
                Script_VarName0.Text = "Interface PE:";
                Script_VarName1.Text = "IP PE:";
                Script_VarName2.Text = "IP CPE:";
                Script_VarName3.Text = "IPv6 CPE:";

                Script_VarName4.Hide();
                Script_VarName5.Hide();
                Script_VarName6.Hide();

                Script_Var4.Hide();
                Script_Var5.Hide();
                Script_Var6.Hide();

                Script_ComboBox.Text = "INICIAIS";

                ScriptProcedure.Text = "!######## CONFIGURACOES " + Script_ComboBox.Text + " ######## \n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "admin display-config | match " + Script_Var1.Text + " context all \n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "admin display-config | match expression " + Script_Var0.Text + "[^0-9] context all \n" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "admin display-config | match expression " + '"' + "route-distinguisher " + "4230:5581" + '"' + " pre-line 6 post-lines 6" +
                "\n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "show router service-name 1000 interface " + Script_Var0.Text + " \n" +
                "\n" +
                "\n" +
                "\n" +
                "!##################### QoS ###################### \n" +
                "\n" +
                "show qos sap-ingress " + Script_Var4.Text + " \n" +
                "\n" +
                "\n" +
                "show qos sap-ingress " + Script_Var4.Text + " \n" +
                "\n" +
                "!########################################### \n" +
                "\n" +
                "\n" +
                "\n" +
                "!################# ROTA ESTATICA #################### \n" +
                "\n" +
                "admin display-config | match " + Script_Var2.Text + " context all \n" +
                "\n" +
                "\n" +
                "show router service-name 1000 static-route next-hop " + Script_Var2.Text +
                "\n" +
                "\n" +
                "admin display-config | match " + Script_Var2.Text + " pre-line 1 post-lines 5 \n" +
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "!################### PING #################### \n" +
                "\n" +
                "ping service-name 1000 " + Script_Var2.Text + " size 1500 count 15 interface " + Script_Var0.Text + " rapid \n" +
                "\n" +
                "\n" +
                "\n";
            }

            else
            {
                Script_VarName0.Hide();
                Script_VarName1.Hide();
                Script_VarName2.Hide();
                Script_VarName3.Hide();
                Script_VarName4.Hide();
                Script_VarName5.Hide();
                Script_VarName6.Hide();

                Script_Var0.Hide();
                Script_Var1.Hide();
                Script_Var2.Hide();
                Script_Var3.Hide();
                Script_Var4.Hide();
                Script_Var5.Hide();
                Script_Var6.Hide();

                Script_ComboBox.Hide();

                ScriptProcedure.Text = "";
            }
        }
        #endregion

        private void Button_FormatarScript_Click(object sender, EventArgs e)
        {
            ApplyVariebleToScript(routerType);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            ApplyVariebleToScript(routerType);
            Clipboard.SetText(ScriptProcedure.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Script_Var0.Text = "";
            Script_Var1.Text = "";
            Script_Var2.Text = "";
            Script_Var3.Text = "";
            Script_Var4.Text = "";
            Script_Var5.Text = "";
            Script_Var6.Text = "";

            ApplyVariebleToScript(routerType);
        }

        public string[] SplitString(String str)
        {
            string[] strList = str.Split(new char[] { ',' });

            return strList;
        }

        private void CreateButtons(int totalNumber, string[] nameList)
        {
            int height = 10;
            for (int i = 0; i < totalNumber; i++)
            {
                Button myButton = new Button();
                myButton.Name = nameList[i];
                myButton.Text = nameList[i];
                myButton.Location = new System.Drawing.Point(10, height);
                myButton.Size = new System.Drawing.Size(100, 30);
                height++;
            }

        }

        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // --------------------------- Wizard Gat ------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------


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

            // -------------------------------------------------
            // Teste Create Buttons
            // -------------------------------------------------

            //string bldCiscoStr = ("Interface PE: , IP CPE: ");
            //string[] teste = { bldCiscoStr };

            //CreateButtons(1, teste);


            // -------------------------------------------------

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
            MessageBox.Show("Still not Implemented");
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
            MessageBox.Show("Not Implemented");
        }




        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // --------------------------- Log Tools -------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------

        public void ApplyLogTools()
        {
            Log_FinalTextBox.Text = "#####################" + " \r\n" +
                "STATUS ANTERIOR: " + "\r\n" +
                Log_TextBox1.Text +
                "\r\n" +
                "\r\n" +
                "#####################" + " \r\n" +
                "STATUS ATUAL: " + "\r\n" +
                Log_TextBox2.Text +
                "\r\n" +
                "\r\n" +
                "#####################" + " \r\n" +
                "PRÓXIMOS PASSOS:\n" +
                Log_TextBox3.Text +
                "\r\n" +
                "\r\n";

            label9.Text = "#####################" + "\n" +
                "STATUS ANTERIOR:\n" +
                Log_TextBox1.Text +
                "\n" +
                "\n" +
                "\n#####################\n" +
                "O QUE FOI FEITO:\n" +
                Log_TextBox2.Text +
                "\n" +
                "\n" +
                "#####################\n" +
                "PRÓXIMOS PASSOS:\n" +
                Log_TextBox3.Text +
                "\n" +
                "\n";
        }

        private void Log_Copy_Click(object sender, EventArgs e)
        {
            ApplyLogTools();
        }

        private void Log_Copy_Click_1(object sender, EventArgs e)
        {
            ApplyLogTools();
            Clipboard.SetText(label9.Text);
        }

        private void Log_Clear_Click(object sender, EventArgs e)
        {
            Log_TextBox1.Text = "";
            Log_TextBox2.Text = "";
            Log_TextBox3.Text = "";
            Log_FinalTextBox.Text = "";
            label9.Text = "";
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

        private void ButtonLogTools_Suporte_Click(object sender, EventArgs e)
        {
            LogToolsSuporteFinalText.Text = "=================================================== \n" +
                "# " + TextBox_LogToolsSuporte.Text + " # \n" +
                "=================================================== \n" +
                "\n " +
                " ------------------------------------------------------------------------------------------------ \n" +
                "\n " +
                TextBox_LogToolsSuporte1.Text +
                "\n \n \n \n";        
        }


        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------- Still in Progress ----------------------------------
        // ---------------------------------------------------------------------------
        // ---------------------------------------------------------------------------

        private void MPLS_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void VOZ_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void Logs_Iniciais_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void Logs_Finais_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void ClienteButton_Teste1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }
        private void ClienteButton_Test2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void ClienteButton_Test3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }
        private void ClienteButton_Test4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void OutrosButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void OutrosButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void AllClients_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

    }
}
