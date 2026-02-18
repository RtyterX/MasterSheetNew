using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterSheetNew
{
    public partial class FormEnableEdit : Form
    {
        Form1 mainPage = new Form1();
        public FormEnableEdit(Form1 MainPage)
        {
            InitializeComponent();
            mainPage = MainPage;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(PasswordTextBox.Text == "Nicholas67")
                {
                    mainPage.enableEdit = true;
                    mainPage.canImportSAIP = true;
                    mainPage.CheckCanImportFromSAIP();
                    MessageBox.Show("Edição de Scripts Habilitada");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Senha Incorreta");
                }

            }
        }
    }
}
