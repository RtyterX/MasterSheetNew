namespace MasterSheetNew
{
    partial class FormNewStep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewStep));
            this.NewStep_Title = new System.Windows.Forms.Label();
            this.NewStep_Script = new System.Windows.Forms.RichTextBox();
            this.NewStep_Texto = new System.Windows.Forms.RichTextBox();
            this.NewStep_ButtonSave = new System.Windows.Forms.Button();
            this.NewStep_ButtonUpload = new System.Windows.Forms.Button();
            this.NewStep_TextoLabel = new System.Windows.Forms.Label();
            this.NewStep_ScriptLabel = new System.Windows.Forms.Label();
            this.NewStep_Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NewStep_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // NewStep_Title
            // 
            this.NewStep_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewStep_Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStep_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewStep_Title.Location = new System.Drawing.Point(0, 0);
            this.NewStep_Title.Name = "NewStep_Title";
            this.NewStep_Title.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.NewStep_Title.Size = new System.Drawing.Size(800, 71);
            this.NewStep_Title.TabIndex = 14;
            this.NewStep_Title.Text = "Novo Passo";
            this.NewStep_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewStep_Title.UseMnemonic = false;
            // 
            // NewStep_Script
            // 
            this.NewStep_Script.Location = new System.Drawing.Point(511, 126);
            this.NewStep_Script.Name = "NewStep_Script";
            this.NewStep_Script.Size = new System.Drawing.Size(222, 240);
            this.NewStep_Script.TabIndex = 16;
            this.NewStep_Script.Text = "";
            // 
            // NewStep_Texto
            // 
            this.NewStep_Texto.Location = new System.Drawing.Point(265, 126);
            this.NewStep_Texto.Name = "NewStep_Texto";
            this.NewStep_Texto.Size = new System.Drawing.Size(188, 240);
            this.NewStep_Texto.TabIndex = 17;
            this.NewStep_Texto.Text = "";
            // 
            // NewStep_ButtonSave
            // 
            this.NewStep_ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NewStep_ButtonSave.Location = new System.Drawing.Point(672, 386);
            this.NewStep_ButtonSave.Name = "NewStep_ButtonSave";
            this.NewStep_ButtonSave.Size = new System.Drawing.Size(105, 44);
            this.NewStep_ButtonSave.TabIndex = 18;
            this.NewStep_ButtonSave.Text = "Salvar";
            this.NewStep_ButtonSave.UseVisualStyleBackColor = true;
            this.NewStep_ButtonSave.Click += new System.EventHandler(this.NewStep_ButtonSave_Click);
            // 
            // NewStep_ButtonUpload
            // 
            this.NewStep_ButtonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NewStep_ButtonUpload.Location = new System.Drawing.Point(76, 110);
            this.NewStep_ButtonUpload.Name = "NewStep_ButtonUpload";
            this.NewStep_ButtonUpload.Size = new System.Drawing.Size(98, 49);
            this.NewStep_ButtonUpload.TabIndex = 19;
            this.NewStep_ButtonUpload.Text = "Upload Image";
            this.NewStep_ButtonUpload.UseVisualStyleBackColor = true;
            // 
            // NewStep_TextoLabel
            // 
            this.NewStep_TextoLabel.AutoSize = true;
            this.NewStep_TextoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStep_TextoLabel.Location = new System.Drawing.Point(334, 103);
            this.NewStep_TextoLabel.Name = "NewStep_TextoLabel";
            this.NewStep_TextoLabel.Size = new System.Drawing.Size(53, 20);
            this.NewStep_TextoLabel.TabIndex = 20;
            this.NewStep_TextoLabel.Text = "Texto";
            // 
            // NewStep_ScriptLabel
            // 
            this.NewStep_ScriptLabel.AutoSize = true;
            this.NewStep_ScriptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStep_ScriptLabel.Location = new System.Drawing.Point(577, 103);
            this.NewStep_ScriptLabel.Name = "NewStep_ScriptLabel";
            this.NewStep_ScriptLabel.Size = new System.Drawing.Size(56, 20);
            this.NewStep_ScriptLabel.TabIndex = 21;
            this.NewStep_ScriptLabel.Text = "Script";
            // 
            // NewStep_Imagem
            // 
            this.NewStep_Imagem.Location = new System.Drawing.Point(32, 187);
            this.NewStep_Imagem.Name = "NewStep_Imagem";
            this.NewStep_Imagem.Size = new System.Drawing.Size(180, 128);
            this.NewStep_Imagem.TabIndex = 22;
            this.NewStep_Imagem.TabStop = false;
            // 
            // FormNewStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewStep_Imagem);
            this.Controls.Add(this.NewStep_ScriptLabel);
            this.Controls.Add(this.NewStep_TextoLabel);
            this.Controls.Add(this.NewStep_ButtonUpload);
            this.Controls.Add(this.NewStep_ButtonSave);
            this.Controls.Add(this.NewStep_Texto);
            this.Controls.Add(this.NewStep_Script);
            this.Controls.Add(this.NewStep_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewStep";
            this.Text = "Novo Passo";
            ((System.ComponentModel.ISupportInitialize)(this.NewStep_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NewStep_Title;
        private System.Windows.Forms.RichTextBox NewStep_Script;
        private System.Windows.Forms.RichTextBox NewStep_Texto;
        private System.Windows.Forms.Button NewStep_ButtonSave;
        private System.Windows.Forms.Button NewStep_ButtonUpload;
        private System.Windows.Forms.Label NewStep_TextoLabel;
        private System.Windows.Forms.Label NewStep_ScriptLabel;
        private System.Windows.Forms.PictureBox NewStep_Imagem;
    }
}