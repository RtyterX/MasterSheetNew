using MasterSheetNew.Entitys;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MasterSheetNew
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

            if (NewClient_Name.Text != string.Empty)
            {
                if (steps.Count != 0)
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

                    Client newClient = new Client(NewClient_Name.Text, critical, showOnScreen, steps);
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
            else
            {
                MessageBox.Show("Erro: Cliente precisa ter um Nome");
            }
        }

        private void NewClient_ButtonEditStep_Click(object sender, EventArgs e)
        {
            if (steps.Count > 0)
            {
                Step selectedStep = NewClient_StepsBox.SelectedItem as Step;

                FormNewStep newStepForm = new FormNewStep(this, selectedStep);
                newStepForm.Show();
            }
            else
            {
                MessageBox.Show("Cliente ainda não possui nenhum Passo");
            }

        }


        private void NewClient_ButtonNewStep_Click(object sender, EventArgs e)
        {
            Step newStep = new Step(steps.Count, null, null, null, false, client_Id);
            FormNewStep newStepForm = new FormNewStep(this, newStep);
            newStepForm.Show();
        }

        public void LoadStepsDatabox()
        {
            if (steps.Count > 0)
            {
                NewClient_StepsBox.DataSource = steps;
                NewClient_StepsBox.DisplayMember = "number";
            }
        }
    }
}
