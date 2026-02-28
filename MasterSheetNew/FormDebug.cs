using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            MessageBox.Show(debugText);
            Debug_TextBox.Text = debugText;
        }
    }


}
