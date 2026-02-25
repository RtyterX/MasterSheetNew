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
    public partial class FormVersionControl : Form
    {
        // Router List
        List<WindowsFormsApp1.Entitys.Version> versionList = new List<WindowsFormsApp1.Entitys.Version>();

        public FormVersionControl()
        {
            InitializeComponent();
            GetAllVersionsList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetAllVersionsList();
        }

        public void GetAllVersionsList()
        {
            // Versions
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.8.1", "Adicionado Criação de Novos Clientes", DateTime.Parse("24/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.8.0", "Adicionado Procedimento para Clientes Específicos", DateTime.Parse("22/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.7.5", "Adicionado Config Voz PABX - Cisco e HPE", DateTime.Parse("21/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.7.4", "Minor Script Fixes", DateTime.Parse("20/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.7.3", "Adicionado Scripts de MPLS e Coleta de Logs", DateTime.Parse("19/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.7.2", "Adicionado Importar do SAIP na tela de Scripts", DateTime.Parse("16/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.7.1", "Script Dispatcher Bug Fix", DateTime.Parse("15/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.7.0", "Habilitar Edição + Reorganização Total do Código Principal", DateTime.Parse("14/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.6.3", "Minor Fixes", DateTime.Parse("13/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.6.2", "Correção: tabScript mostrando todas as Variaveis", DateTime.Parse("12/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.6.1", "Automação ao abrir o tabScript", DateTime.Parse("12/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.5.2", "Melhorado Night Mode + Minor Fixes", DateTime.Parse("11/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.5.1", "Adicionado Night Mode", DateTime.Parse("11/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.4.3", "Correção de Bugs", DateTime.Parse("10/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.4.2", "Minor Fixes + Melhor na UI tabScripts", DateTime.Parse("09/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.4.0", "Adicionada Calculadora de IP", DateTime.Parse("09/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.3.9", "Minor Fixes", DateTime.Parse("07/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.3.8", "Correção de Bugs + Melhorias na UI", DateTime.Parse("06/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.3.7", "Correção nos Scripts", DateTime.Parse("05/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.3.6", "Melhora UI na TabScript", DateTime.Parse("04/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.3.5", "Adicionado Coleta de Logs de Ligação", DateTime.Parse("03/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.3.1", "Adicionado Coleta de Logs Velocloud", DateTime.Parse("02/02/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.2.7", "Correção de Bugs", DateTime.Parse("30/01/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.2.6", "Correção nos Scripts", DateTime.Parse("28/01/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.2.5", "Melhora na UI", DateTime.Parse("25/01/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.2.1", "Adicionado BLD + Projeto Alterado para .NET 4.8.1", DateTime.Parse("13/01/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.1.0", "Criaçao do .exe + Correção de Scripts", DateTime.Parse("7/01/2026")));
            versionList.Add(new WindowsFormsApp1.Entitys.Version("1.0.0", "Inico do Projeto + WizardGat", DateTime.Parse("5/01/2026")));

            // -------------------------------------------------------
            dataGridView1.DataSource = versionList;
        }
    }
}
