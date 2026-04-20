using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterSheetNew
{
    public partial class FormPassword : Form
    {
        Form1 mainPage = new Form1();
        public FormPassword(Form1 MainPage)
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
                    mainPage.EnableImportSAIP();
                    MessageBox.Show("Import SAIP Habilitado");
                    this.Close();
                }
                else if (PasswordTextBox.Text == "Nicholas67")
                {
                    mainPage.EnableEditing();
                    MessageBox.Show("Edição de Scripts Habilitada");
                    this.Close();
                }
                else if (PasswordTextBox.Text == "Brunin")
                {
                    mainPage.EnableTesting();
                    MessageBox.Show("Botões para Teste Habilitados");
                    this.Close();
                }
                else if (PasswordTextBox.Text == "BuryTheLight")
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Bury_the_Light);
                    player.Play();
                    MessageBox.Show("shiiin... Check your balls");
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
