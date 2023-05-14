using Projeto1.Classes;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Policy;
using System.Drawing.Text;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        private int sizeX, sizeY;
        public Form1()
        {
            InitializeComponent();
        }

        private void imgCadastro_MouseLeave(object sender, EventArgs e)
        {
            FazerBordaImagem(imgCadastro, false);
        }

        private void imgFinanceiro_MouseEnter(object sender, EventArgs e)
        {
            FazerBordaImagem(imgFinanceiro, true);
        }

        private void imgFinanceiro_MouseLeave(object sender, EventArgs e)
        {
            FazerBordaImagem(imgFinanceiro, false);
        }

        private void imgCadastro_MouseEnter(object sender, EventArgs e)
        {
            FazerBordaImagem(imgCadastro, true);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("INICIOU MENU");
            lblMenuPrincipal.TextAlign = ContentAlignment.MiddleLeft;
            lblMenuPrincipal.Dock = DockStyle.Fill;
            pnCabecalho.Controls.Add(lblMenuPrincipal);*/
        }

        private void iniciarCabecalho()
        {
            //ALINHAR TEXTO AO PANEL DO CABECALHO
            lblMenuPrincipal.TextAlign = ContentAlignment.MiddleLeft;
            lblMenuPrincipal.Dock = DockStyle.Fill;
            pnCabecalho.Controls.Add(lblMenuPrincipal);
        }

        private void FazerBordaImagem(PictureBox imgNome, bool mouseDentro)
        {
            //PASSAR PARA VARIÁVEL AS DIMENSÕES DA IMAGEM
            sizeX = imgFinanceiro.Width;
            sizeY = imgFinanceiro.Height;

            //FAZER RETANGULO
            RetanguloImg retangulo = new RetanguloImg(0, 0, sizeX, sizeY, imgNome, mouseDentro);
        }
    }
}
