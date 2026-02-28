namespace MasterSheetNew
{
    partial class FormDebug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebug));
            this.Debug_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Debug_TextBox
            // 
            this.Debug_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Debug_TextBox.Location = new System.Drawing.Point(0, 0);
            this.Debug_TextBox.Name = "Debug_TextBox";
            this.Debug_TextBox.Size = new System.Drawing.Size(456, 491);
            this.Debug_TextBox.TabIndex = 0;
            this.Debug_TextBox.Text = "";
            // 
            // FormVoiceDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 491);
            this.Controls.Add(this.Debug_TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVoiceDebug";
            this.Text = "Voice SIP - Debug";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Debug_TextBox;
    }
}