using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entitys;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MasterSheetNew
{
    public partial class FormEdit : Form
    {

        Script scriptClass = new Script(99, "ScriptClass", "", "", DateTime.Parse("11/02/2026"));
        List<Script> allScripts = new List<Script>();
        Script selectedScript = new Script(99, "SelectedScript", "", "", DateTime.Parse("11/02/2026"));

        public FormEdit()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllScripts();
            selectedScript = allScripts[0];
        }

        public void GetAllScripts()
        {
            allScripts = scriptClass.AddScripts();

            Scripts_BoxList.DataSource = allScripts;
            Scripts_BoxList.DisplayMember = "name";
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            selectedScript.alterDate = DateTime.Now;
            scriptClass.AlterScript(selectedScript);

            GetAllScripts();

        }

        private void Scripts_BoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedScript = Scripts_BoxList.SelectedItem as Script;

            Script_TextBox.Text = selectedScript.scriptString;
            Script_SelectName.Text = selectedScript.name;
            Script_AlterDate.Text = selectedScript.alterDate.ToString("dd/MM/yyyy");
        }
    }
}
