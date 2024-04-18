using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_escolha_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;

            switch (Convert.ToInt32(cmbEscolha.SelectedItem))
            {
                case 1:
                    lblMensagem.Text = "olá " + textBoxNome.Text + " você Nasceu em janeiro";
                    break;

                case 2:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você nasceu em fevereiro";
                    break;

                    case 3:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você nasceu em março";
                    break;

                    case 4:
                    lblMensagem.Text = "olá " + textBoxNome.Text + " você nasceu em Abril";
                    break;

                    case 5: 
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Você nasceu em maio";
                    break;

                    case 6:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Você nasceu em junho";
                    break;

                    case 7:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Você nasceu em julho";
                    break;

                    case 8:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Você nasceu em Agosto";
                    break;

                    case 9: 
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Você nasceu em setembro";
                    break;

                    case 10:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Você nasceu em outubro";
                    break;

                    case 11:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Você nasceu em novembro";
                    break;

                    case 12:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Você nasceu em dezembro";
                    break;

                default:
                    lblMensagem.Text = "Por favor escolha uma opção de numeros; Mês não encontrado";
                    break;
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
