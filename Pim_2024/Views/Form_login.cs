using Pim_2024.modelos;
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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string nomeUser = textBox1.Text;
           string passUser = maskedTextBox1.Text;

         //  UsuarioDB udb = new UsuarioDB();
         //   if (udb.ValidateLogin(nomeUser, passUser))
                MessageBox.Show($"{nomeUser}, você realizou login com sucesso!");

            
            Form_menuInicial f = new Form_menuInicial();
            f.ShowDialog();

            Application.Exit();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_login_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
