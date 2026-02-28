namespace MasterSheetNew.Entitys
{
    partial class FormNewClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewClient));
            this.NewClient_ButtonNewStep = new System.Windows.Forms.Button();
            this.NewClient_Title = new System.Windows.Forms.Label();
            this.NewClient__NameLabel = new System.Windows.Forms.Label();
            this.NewClient_Name = new System.Windows.Forms.TextBox();
            this.NewClient_ButtonSave = new System.Windows.Forms.Button();
            this.NewClient_CriticalBox = new System.Windows.Forms.CheckBox();
            this.NewClient_StepsBox = new System.Windows.Forms.ComboBox();
            this.NewClient_StepsLabel = new System.Windows.Forms.Label();
            this.NewClient_ShowOnScreenBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NewClient_ButtonNewStep
            // 
            this.NewClient_ButtonNewStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NewClient_ButtonNewStep.Location = new System.Drawing.Point(322, 175);
            this.NewClient_ButtonNewStep.Name = "NewClient_ButtonNewStep";
            this.NewClient_ButtonNewStep.Size = new System.Drawing.Size(98, 49);
            this.NewClient_ButtonNewStep.TabIndex = 23;
            this.NewClient_ButtonNewStep.Text = "Novo Passo";
            this.NewClient_ButtonNewStep.UseVisualStyleBackColor = true;
            this.NewClient_ButtonNewStep.Click += new System.EventHandler(this.NewClient_ButtonNewStep_Click);
            // 
            // NewClient_Title
            // 
            this.NewClient_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewClient_Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewClient_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewClient_Title.Location = new System.Drawing.Point(0, 0);
            this.NewClient_Title.Name = "NewClient_Title";
            this.NewClient_Title.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.NewClient_Title.Size = new System.Drawing.Size(501, 71);
            this.NewClient_Title.TabIndex = 22;
            this.NewClient_Title.Text = "Novo Cliente";
            this.NewClient_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewClient_Title.UseMnemonic = false;
            // 
            // NewClient__NameLabel
            // 
            this.NewClient__NameLabel.AutoSize = true;
            this.NewClient__NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewClient__NameLabel.Location = new System.Drawing.Point(137, 95);
            this.NewClient__NameLabel.Name = "NewClient__NameLabel";
            this.NewClient__NameLabel.Size = new System.Drawing.Size(55, 20);
            this.NewClient__NameLabel.TabIndex = 21;
            this.NewClient__NameLabel.Text = "Nome";
            // 
            // NewClient_Name
            // 
            this.NewClient_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NewClient_Name.Location = new System.Drawing.Point(64, 121);
            this.NewClient_Name.Name = "NewClient_Name";
            this.NewClient_Name.Size = new System.Drawing.Size(194, 29);
            this.NewClient_Name.TabIndex = 20;
            // 
            // NewClient_ButtonSave
            // 
            this.NewClient_ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NewClient_ButtonSave.Location = new System.Drawing.Point(363, 364);
            this.NewClient_ButtonSave.Name = "NewClient_ButtonSave";
            this.NewClient_ButtonSave.Size = new System.Drawing.Size(105, 44);
            this.NewClient_ButtonSave.TabIndex = 24;
            this.NewClient_ButtonSave.Text = "Salvar";
            this.NewClient_ButtonSave.UseVisualStyleBackColor = true;
            this.NewClient_ButtonSave.Click += new System.EventHandler(this.NewClient_ButtonSave_Click);
            // 
            // NewClient_CriticalBox
            // 
            this.NewClient_CriticalBox.AutoSize = true;
            this.NewClient_CriticalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NewClient_CriticalBox.Location = new System.Drawing.Point(84, 291);
            this.NewClient_CriticalBox.Name = "NewClient_CriticalBox";
            this.NewClient_CriticalBox.Size = new System.Drawing.Size(144, 28);
            this.NewClient_CriticalBox.TabIndex = 25;
            this.NewClient_CriticalBox.Text = "Cliente Crítico";
            this.NewClient_CriticalBox.UseVisualStyleBackColor = true;
            // 
            // NewClient_StepsBox
            // 
            this.NewClient_StepsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NewClient_StepsBox.FormattingEnabled = true;
            this.NewClient_StepsBox.Location = new System.Drawing.Point(304, 123);
            this.NewClient_StepsBox.Name = "NewClient_StepsBox";
            this.NewClient_StepsBox.Size = new System.Drawing.Size(144, 25);
            this.NewClient_StepsBox.TabIndex = 26;
            // 
            // NewClient_StepsLabel
            // 
            this.NewClient_StepsLabel.AutoSize = true;
            this.NewClient_StepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewClient_StepsLabel.Location = new System.Drawing.Point(340, 95);
            this.NewClient_StepsLabel.Name = "NewClient_StepsLabel";
            this.NewClient_StepsLabel.Size = new System.Drawing.Size(67, 20);
            this.NewClient_StepsLabel.TabIndex = 27;
            this.NewClient_StepsLabel.Text = "Passos";
            // 
            // NewClient_ShowOnScreenBox
            // 
            this.NewClient_ShowOnScreenBox.AutoSize = true;
            this.NewClient_ShowOnScreenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NewClient_ShowOnScreenBox.Location = new System.Drawing.Point(84, 196);
            this.NewClient_ShowOnScreenBox.Name = "NewClient_ShowOnScreenBox";
            this.NewClient_ShowOnScreenBox.Size = new System.Drawing.Size(139, 52);
            this.NewClient_ShowOnScreenBox.TabIndex = 28;
            this.NewClient_ShowOnScreenBox.Text = "Mostrar na \r\nPagina Inicial";
            this.NewClient_ShowOnScreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewClient_ShowOnScreenBox.UseVisualStyleBackColor = true;
            // 
            // FormNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 433);
            this.Controls.Add(this.NewClient_ShowOnScreenBox);
            this.Controls.Add(this.NewClient_StepsLabel);
            this.Controls.Add(this.NewClient_StepsBox);
            this.Controls.Add(this.NewClient_CriticalBox);
            this.Controls.Add(this.NewClient_ButtonSave);
            this.Controls.Add(this.NewClient_ButtonNewStep);
            this.Controls.Add(this.NewClient_Title);
            this.Controls.Add(this.NewClient__NameLabel);
            this.Controls.Add(this.NewClient_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewClient";
            this.Text = "Novo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewClient_ButtonNewStep;
        private System.Windows.Forms.Label NewClient_Title;
        private System.Windows.Forms.Label NewClient__NameLabel;
        private System.Windows.Forms.TextBox NewClient_Name;
        private System.Windows.Forms.Button NewClient_ButtonSave;
        private System.Windows.Forms.CheckBox NewClient_CriticalBox;
        private System.Windows.Forms.ComboBox NewClient_StepsBox;
        private System.Windows.Forms.Label NewClient_StepsLabel;
        private System.Windows.Forms.CheckBox NewClient_ShowOnScreenBox;
    }
}