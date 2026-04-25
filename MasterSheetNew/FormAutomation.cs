using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterSheetNew
{
    public partial class FormAutomation : Form
    {
        private readonly Automation automation = new Automation();

        private string pe;
        private string userPE;
        private string puttyPath;
        private bool isXR;
        private RouterType peType;
        private RouterType routerType;
        private ActivityType activityType;
        private string ipWAN;
        private string sourceWAN;
        private string vrf;

        private string scriptPE;
        private string scriptCPE;

        public FormAutomation(string pe, string userPE, string puttyPath, RouterType peType, bool isXR, RouterType routerType, ActivityType activityType,
            string ipWAN, string sourceWAN, string vrf, string scriptPE, string scriptCPE)
        {
            InitializeComponent();
            Debug.Write("\r\n--> Opening Automation Screen...");

            this.pe = pe;
            this.userPE = userPE;
            this.puttyPath = puttyPath;
            this.peType = peType;
            this.routerType = routerType;
            this.activityType = activityType;
            this.ipWAN = ipWAN;
            this.sourceWAN = sourceWAN;
            this.vrf = vrf;
            this.scriptPE = scriptPE;
            this.scriptCPE = scriptCPE;

            GetInfo();
     
            Debug.Write("...Opening Ok");
        }

        public void TestInfo()
        {
            if (Properties.Settings.Default.enableEdit)
            {
                MessageBox.Show("PE: " + pe + "\r\n" +
                    "User: " + userPE + "\r\n" +
                    "Putty: " + puttyPath + "\r\n" +
                    "PE Type: " + peType + "\r\n" +
                    "Router Type: " + routerType + "\r\n" +
                    "Activity Type: " + activityType + "\r\n" +
                    "PE - XR: " + isXR + "\r\n" +
                    "IP WAN: " + ipWAN + "\r\n" +
                    "Source WAN: " + sourceWAN + "\r\n" +
                    "VRF: " + vrf + "\r\n" +
                    "Script PE: " + scriptPE.Remove(25) + "\r\n" +
                    "Script CPE: " + scriptCPE.Remove(25) + "\r\n");
            }
        }

        /////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////
        private void FormAutomation_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            TestInfo();
        }

        private void ChangeInfo(object sender, EventArgs e)
        {
            SetInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestInfo();
            Debug.WriteLine("\r\n--> AUTOMATION: Opening PE with Telnet...");
            automation.OpenWithTelnet(pe, userPE, puttyPath, peType, routerType, activityType, isXR, ipWAN, sourceWAN, vrf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestInfo();
            Debug.WriteLine("\r\n--> AUTOMATION: Colecting PE Logs...");

            if (comboBox1.SelectedIndex == 0)
            {
                automation.LogsPE(false, pe, userPE, puttyPath, scriptPE);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                automation.LogsPE(true, pe, userPE, puttyPath, scriptPE);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestInfo();
            Debug.WriteLine("\r\n--> AUTOMATION: Colecting CPE Logs...");

            if (comboBox1.SelectedIndex == 0)
            {
                automation.LogsCPE(false, peType, routerType, activityType, isXR, ipWAN, sourceWAN, vrf, pe, userPE, puttyPath, scriptCPE);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                automation.LogsCPE(false, peType, routerType, activityType, isXR, ipWAN, sourceWAN, vrf, pe, userPE, puttyPath, scriptCPE);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TestInfo();
            Debug.WriteLine("\r\n--> AUTOMATION: Colecting both PE and CPE Logs...");

            if (comboBox1.SelectedIndex == 0)
            {
                automation.LogsComplete(false, peType, routerType, activityType, isXR, ipWAN, sourceWAN, vrf, pe, userPE, puttyPath, scriptPE, scriptCPE);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                automation.LogsComplete(false, peType, routerType, activityType, isXR, ipWAN, sourceWAN, vrf, pe, userPE, puttyPath, scriptPE, scriptCPE);
            }
        }


        /////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////

        public void GetInfo()
        {
            comboBox2.Text = peType.ToString();
            comboBox3.Text = activityType.ToString();
            comboBox4.Text = routerType.ToString();
        }

        public void SetInfo()
        {
            // Backbone Type
            if (comboBox2.SelectedIndex == 0)
            {
                peType = RouterType.Cisco;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                peType = RouterType.Nokia;
            }

            // Activity Type
            if (comboBox3.SelectedIndex == 0)
            {
                activityType = ActivityType.BLD;
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                activityType = ActivityType.MPLS;
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                activityType = ActivityType.VOZ;
            }

            // Router Type
            if (comboBox4.SelectedIndex == 0)
            {
                routerType = RouterType.Cisco;
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                routerType = RouterType.HPE;
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                routerType = RouterType.Huawei;
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                routerType = RouterType.Fortigate;
            }
        }
    }
}
