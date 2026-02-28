using MasterSheetNew.Entitys;
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
using static System.Net.Mime.MediaTypeNames;

namespace MasterSheetNew
{
    public partial class FormNewStep : Form
    {
        int number;
        string scriptText;
        bool restore;
        int client_Id;
        FormNewClient newClientForm = new FormNewClient(new Form1(),0);
        List<TextBox> varText = new List<TextBox>();

        public FormNewStep(FormNewClient NewClientForm, int Number, int Client_Id)
        {
            InitializeComponent();
            number = Number;
            client_Id = Client_Id;
            newClientForm = NewClientForm;
            ListAllTextUI();
        }

        private void NewStep_ButtonSave_Click(object sender, EventArgs e)
        {
            if (NewStep_Restore.Checked)
            {
                restore = true;
            }
            else
            {
                restore = false;
            }

            string variables = string.Empty;
            string varNames = string.Empty;

            foreach (TextBox t in varText)
            {
                if (t.Text != string.Empty)
                {
                    if (variables == string.Empty)
                    {
                        variables = t.Name;
                        varNames = t.Text;
                    }
                    else
                    {
                        variables = variables + "," + t.Name;
                        varNames = varNames + "," + t.Text;
                    }
                }
            }

            if (NewStep_Script.Text == string.Empty)
            {
                scriptText = string.Empty;
            }
            else
            {
                scriptText = NewStep_Script.Text;
            }

            Script newScript = new Script(999, "script", true, scriptText, variables, varNames, DateTime.Now);
            Step newStep = new Step(number, NewStep_Texto.Text, newScript, NewStep_Imagem, restore, client_Id);
            newClientForm.steps.Add(newStep);

            this.Close();
        }

        public void ListAllTextUI()
        {
            varText.Add(Client_VarText00);
            varText.Add(Client_VarText01);
            varText.Add(Client_VarText02);
            varText.Add(Client_VarText03);
            varText.Add(Client_VarText04);
            varText.Add(Client_VarText05);
            varText.Add(Client_VarText06);
            varText.Add(Client_VarText07);
            varText.Add(Client_VarText08);
            varText.Add(Client_VarText09);
        }

        private void Client_VarDelete09_Click(object sender, EventArgs e)
        {
            Client_VarText09.Text = string.Empty;
        }

        private void Client_VarDelete08_Click(object sender, EventArgs e)
        {
            Client_VarText08.Text = string.Empty;
        }

        private void Client_VarDelete07_Click(object sender, EventArgs e)
        {
            Client_VarText07.Text = string.Empty;
        }

        private void Client_VarDelete06_Click(object sender, EventArgs e)
        {
            Client_VarText06.Text = string.Empty;
        }

        private void Client_VarDelete05_Click(object sender, EventArgs e)
        {
            Client_VarText05.Text = string.Empty;
        }

        private void Client_VarDelete04_Click(object sender, EventArgs e)
        {
            Client_VarText04.Text = string.Empty;
        }

        private void Client_VarDelete03_Click(object sender, EventArgs e)
        {
            Client_VarText03.Text = string.Empty;
        }

        private void Client_VarDelete02_Click(object sender, EventArgs e)
        {
            Client_VarText02.Text = string.Empty;
        }

        private void Client_VarDelete01_Click(object sender, EventArgs e)
        {
            Client_VarText01.Text = string.Empty;
        }

        private void Client_VarDelete00_Click(object sender, EventArgs e)
        {
            Client_VarText00.Text = string.Empty;
        }
    }
}
