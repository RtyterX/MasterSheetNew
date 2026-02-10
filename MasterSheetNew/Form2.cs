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
    public partial class Form2 : Form
    {
        // Router List
        List<WindowsFormsApp1.Entitys.Version> versionList = new List<WindowsFormsApp1.Entitys.Version>();

        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.2.7", "", DateTime.Parse("28/01/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.3.1", "", DateTime.Parse("03/02/2026")));

            dataGridView1.DataSource = versionList;
        }
    }
}
