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

namespace MasterSheetNew
{
    public partial class FormNewStep : Form
    {
        int number;
        int client_Id;
        FormNewClient newClientForm = new FormNewClient(new Form1(),0);

        public FormNewStep(FormNewClient NewClientForm, int Number, int Client_Id)
        {
            InitializeComponent();
            number = Number;
            client_Id = Client_Id;
            newClientForm = NewClientForm;
        }

        private void NewStep_ButtonSave_Click(object sender, EventArgs e)
        {
            Step newStep = new Step(number, NewStep_Texto.Text, NewStep_Script.Text, NewStep_Imagem, client_Id);
            newClientForm.steps.Add(newStep);

            this.Close();
        }
    }
}
