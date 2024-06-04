using Pim_2024.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_2024
{
    public partial class Form_menuInicial : Form
    {
        public Form_menuInicial()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cadastro f = new Form_cadastro();
            f.ShowDialog();
        }

        private void label_Logo_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cadastroUsuario f = new Form_cadastroUsuario();
            f.ShowDialog();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
