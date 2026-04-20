using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MasterSheetNew
{
    public partial class FormDebug : Form
    {
        string debugText;

        public FormDebug(string debugText)
        {
            InitializeComponent();
            this.debugText = debugText;
            DebugText();
        }

        public void DebugText()
        {
            Debug_TextBox.Text = debugText;
        }

    }
}
