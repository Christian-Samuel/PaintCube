using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintCube
{
    class Gerador
    {
        int Nome = 0;
        
        public Gerador()
        {

        }

        
        Label celula(int size)
        {
            Label cell = new Label();
            cell.Name = Nome.ToString();
            cell.Size = new Size(size, size);
            cell.BackColor = Color.White;
            cell.Margin = new Padding(3);
            cell.BorderStyle = BorderStyle.FixedSingle;

            Nome++;

            return cell;
        }

        public Label[] gerar(int quantidade,int size)
        {
            Label[] celulas = new Label[quantidade];

            for(int x=0; x<quantidade; x++)
            {
                celulas[x] = celula(size);
            }

            return celulas;
        }
    }
}
