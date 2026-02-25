using MySqlX.XDevAPI;
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

namespace MasterSheetNew.Entitys
{
    public partial class FormNewClient : Form
    {
        int client_Id;
        public List<Step> steps = new List<Step>();
        Form1 mainPage = new Form1();

        public FormNewClient(Form1 MainPage, int Client_Id)
        {
            InitializeComponent();
            client_Id = Client_Id;
            mainPage = MainPage;
        }

        private void NewClient_ButtonSave_Click(object sender, EventArgs e)
        {
            bool critical;
            bool showOnScreen;

            if (steps != null)
            {
                if (NewClient_ShowOnScreenBox.Checked)
                {
                    critical = true;
                }
                else
                {
                    critical = false;
                }
                if (NewClient_CriticalBox.Checked)
                {
                    showOnScreen = true;
                }
                else
                {
                    showOnScreen = false;
                }

                WindowsFormsApp1.Entitys.Client newClient = new WindowsFormsApp1.Entitys.Client(NewClient_Name.Text, critical, showOnScreen, steps);
                mainPage.clients.Add(newClient);
                mainPage.AllClientsButtonBuilder();
                mainPage.FillClientButtons();

                this.Close();
            }
            else
            {
                MessageBox.Show("Erro: Não foi configurado nenhum Passo");
            }
        }

        private void NewClient_ButtonNewStep_Click(object sender, EventArgs e)
        {
            int stepsNumber = steps.Count;

            MessageBox.Show("Numero de Steps = " + steps.Count);

            FormNewStep newClientForm = new FormNewStep(this, stepsNumber, client_Id);
            newClientForm.Show();
        }
    }
}
