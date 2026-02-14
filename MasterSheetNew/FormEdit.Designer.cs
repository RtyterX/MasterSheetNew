namespace MasterSheetNew
{
    partial class FormEdit
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.Scripts_BoxList = new System.Windows.Forms.ComboBox();
            this.MainTitle = new System.Windows.Forms.Label();
            this.Script_TextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Script_AlterDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(525, 291);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 52);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Salvar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Scripts_BoxList
            // 
            this.Scripts_BoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scripts_BoxList.FormattingEnabled = true;
            this.Scripts_BoxList.Location = new System.Drawing.Point(479, 221);
            this.Scripts_BoxList.Name = "Scripts_BoxList";
            this.Scripts_BoxList.Size = new System.Drawing.Size(228, 26);
            this.Scripts_BoxList.TabIndex = 1;
            this.Scripts_BoxList.SelectedIndexChanged += new System.EventHandler(this.Scripts_BoxList_SelectedIndexChanged);
            // 
            // MainTitle
            // 
            this.MainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.Location = new System.Drawing.Point(272, 54);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(274, 45);
            this.MainTitle.TabIndex = 2;
            this.MainTitle.Text = "Edição de Scripts";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Script_TextBox
            // 
            this.Script_TextBox.Location = new System.Drawing.Point(40, 174);
            this.Script_TextBox.Name = "Script_TextBox";
            this.Script_TextBox.Size = new System.Drawing.Size(340, 424);
            this.Script_TextBox.TabIndex = 3;
            this.Script_TextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o Script";
            // 
            // Script_AlterDate
            // 
            this.Script_AlterDate.AutoSize = true;
            this.Script_AlterDate.Location = new System.Drawing.Point(307, 158);
            this.Script_AlterDate.Name = "Script_AlterDate";
            this.Script_AlterDate.Size = new System.Drawing.Size(30, 13);
            this.Script_AlterDate.TabIndex = 122;
            this.Script_AlterDate.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Ultima Alteração: ";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 619);
            this.Controls.Add(this.Script_AlterDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Script_TextBox);
            this.Controls.Add(this.MainTitle);
            this.Controls.Add(this.Scripts_BoxList);
            this.Controls.Add(this.SaveButton);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox Scripts_BoxList;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.RichTextBox Script_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Script_AlterDate;
        private System.Windows.Forms.Label label5;
    }
}