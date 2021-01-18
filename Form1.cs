using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PaintCube
{
    public partial class Form1 : Form
    {
        Label[] celulas;
        Pintar pintar;
        public Form1()
        {
            InitializeComponent();
            pintar = new Pintar(paleta,borrachaIco);
            string diretorio = "C:\\chrYstYan\\PaintCube\\";
            if (!Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);

        }


        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int x=0; x<celulas.Length;x++)
            {
                if (celulas[x].ClientRectangle.Contains(celulas[x].PointToClient(Control.MousePosition)))
                    pintar.colorir(celulas[x]);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (!pintar.Borracha.borrachaAtv)
            {
                borrachaIco.BorderStyle = BorderStyle.FixedSingle;
                pintar.Borracha.borrachaAtv = true;
            }
            else
            {
                borrachaIco.BorderStyle = BorderStyle.None;
                pintar.Borracha.borrachaAtv = false;
            }
        }

        private void blue_ValueChanged(object sender, EventArgs e)
        {
            uint r = Convert.ToUInt32(red.Value);
            uint g = Convert.ToUInt32(green.Value);
            uint b = Convert.ToUInt32(blue.Value);

            if (r > 255)
                r = 255;

            if (g > 255)
                g = 255;

            if (b > 255)
                b = 255;

            pintar.setCor(r, g, b);
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Gerador gerador = new Gerador();
            celulas = gerador.gerar(570, 20);
            painel.Controls.Clear();

            for (int x = 0; x < 570; x++)
            {
                celulas[x].MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
                celulas[x].MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
                painel.Controls.Add(celulas[x]);
            }
        }

        private void gravarIco_Click(object sender, EventArgs e)
        {
            if (celulas != null)
                saveFileDialog1.ShowDialog();
            else
                MessageBox.Show("Nenhuma Imagem para ser Salva");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Gerador gerador = new Gerador();
            celulas = gerador.gerar(570, 20);
            painel.Controls.Clear();

            for (int x = 0; x < 570; x++)
            {
                celulas[x].MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
                celulas[x].MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
                painel.Controls.Add(celulas[x]);
            }

            openFileDialog1.ShowDialog();

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            Label icone = sender as Label;

            icone.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Label icone = sender as Label;

            icone.BorderStyle = BorderStyle.None;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pintar.carregar(celulas,openFileDialog1.FileName);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pintar.salvar(celulas, saveFileDialog1.FileName);
        }
    }
}
