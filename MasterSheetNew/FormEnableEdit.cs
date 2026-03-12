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
                if (PasswordTextBox.Text == "KauanGostoso")
                {
                    //mainPage.EnableImportSAIP();
                    mainPage.CheckCanImportFromSAIP();
                    MessageBox.Show("Import SAIP Habilitado");
                    this.Close();
                }
                else if (PasswordTextBox.Text == "Nicholas67")
                {
                    mainPage.EnableEditing();
                    mainPage.CheckCanImportFromSAIP();
                    MessageBox.Show("Edição de Scripts Habilitada");
                    this.Close();
                }
                else if (PasswordTextBox.Text == "JohnMemesJohn")
                {
                   // mainPage.EnableTesting();
                    mainPage.EnableEditing();
                    mainPage.CheckCanImportFromSAIP();
                    //mainPage.CheckCanTestUI();
                    MessageBox.Show("Botões para Teste Habilitados");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha Incorreta");
                    PasswordTextBox.Text = string.Empty;
                }

            }
        }
    }
}
