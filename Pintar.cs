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
    class Pintar
    {
        Label paleta;

        public struct rgb
        {
            uint R;
            uint G;
            uint B;
        }
        public rgb RGB;
        public struct borracha 
        {
            public Label borrachaLbl;
            public bool borrachaAtv;
        }
        public borracha Borracha;

        public Pintar(Label plt, Label borr)
        {

            this.paleta = plt;
            this.Borracha.borrachaLbl = borr;
            this.Borracha.borrachaAtv = false;
        }

        public void setCor(uint r, uint g, uint b)
        {
            paleta.BackColor = Color.FromArgb((int)r, (int)g, (int)b);
        }

        public void colorir(Label lbl)
        {
            if (Borracha.borrachaAtv)
                lbl.BackColor = Color.White;
            else
                lbl.BackColor = paleta.BackColor;
        }

        public void salvar(Label[] cells,String nome)
        { 
            using(FileStream arquivo = new FileStream(nome,FileMode.Create))
            {
                using (BinaryWriter Imagem = new BinaryWriter(arquivo))
                {
                    for(int x=0; x<cells.Length; x++)
                    {
                        Imagem.Write(cells[x].BackColor.ToArgb());
                    }
                }
            }
        }

        public void carregar(Label[] cells, String nome)
        {
            using(FileStream arquivo = new FileStream(nome,FileMode.Open))
            {
                using(BinaryReader Imagem = new BinaryReader(arquivo))
                {
                    for(int x=0; x<cells.Length; x++)
                    {
                        cells[x].BackColor = Color.FromArgb(Imagem.ReadInt32());
                    }
                }
            }
        }
    }
}
