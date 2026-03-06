using MasterSheetNew.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Bitmap image;
        FormNewClient newClientForm = new FormNewClient(new Form1(),0);
        List<TextBox> varText = new List<TextBox>();

        public FormNewStep(FormNewClient NewClientForm, Step step)
        {
            InitializeComponent();
            number = step.number;
            client_Id = step.client_Id;
            NewStep_Imagem.Image = step.image;
            if (step.script != null)
            {
                NewStep_Script.Text = step.script.scriptString;
                ApplyEditVarNames(step.script.variables, step.script.variableNames);
            }
            else
            {
                NewStep_Script.Text = string.Empty;
            }
            NewStep_Texto.Text = step.text;
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
            Step newStep = new Step(number, NewStep_Texto.Text, newScript, image, restore, client_Id);
            newClientForm.steps.Add(newStep);
            newClientForm.LoadStepsDatabox();
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

        private void NewStep_ButtonUpload_Click(object sender, EventArgs e)
        {
            // Set the filter to allow only image file types
            openFileDialog1.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg|All files (*.*)|*.*";
            // Set the filter index to default to image files
            openFileDialog1.FilterIndex = 1;
            // Do not allow the user to select multiple files
            openFileDialog1.Multiselect = false;

            // Show the dialog box
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the path of the selected file
                    string selectedFilePath = openFileDialog1.FileName;

                    // Load the image from the file path and display it in the PictureBox
                    // Using FileStream can prevent the file from being locked
                    using (FileStream fs = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                    {
                        NewStep_Imagem.Image = System.Drawing.Bitmap.FromStream(fs);
                        image = new Bitmap(NewStep_Imagem.Image);
                    }

                    // Optional: Adjust the PictureBox SizeMode (e.g., Zoom, StretchImage, AutoSize)
                    NewStep_Imagem.SizeMode = PictureBoxSizeMode.Zoom;

                    MessageBox.Show("Image successfully loaded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Handle any errors that might occur during file loading
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ApplyEditVarNames(string variables, string names)
        {
            string[] split = variables.Split(',');
            string[] namesSplit = names.Split(',');

            
            for (int i = 0; i < split.Length; i++)
            {
                foreach (TextBox t in varText)
                {
                    MessageBox.Show(split[i]);
                    if (t.Name.Contains(split[i]))
                    {
                        t.Text = namesSplit[i];
                    }
                }
            }
        }

        // ------------------------------------------------------------------------------------------------------

        private void NewStep_ButtonDeleteImage_Click(object sender, EventArgs e)
        {
            NewStep_Imagem.Image = null;
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
