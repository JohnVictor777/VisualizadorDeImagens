using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorDeImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //BOTÃO MOSTRAR IMAGENS

        private void showButton_Click(object sender, EventArgs e)
        {
            //Mostra a caixa de diálogo Abrir arquivo. Se o usuário clicar em OK, carregue o
            //imagem que o usuário escolheu.

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        //BOTÃO LIMPAR

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Limpa a imagem.
            pictureBox1.Image = null;
        }

        //BOTÃO COR DE FUNDO 

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //Mostra a caixa de diálogo de cores. Se o usuário clicar em OK, altere o
            // Fundo do controle PictureBox na cor que o usuário escolheu
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        //BOTÃO FECHA

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Fecha o formulário.
            this.Close();

        }

        //ALTERA O PICTUREBOX
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Se o usuário marcar a caixa de seleção Esticar,
            // altera o PictureBox
            // Propriedade SizeMode para "Esticar". Se o usuário limpar
            // a caixa de seleção, altere-a para "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
