namespace PaintCube
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.painel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newIco = new System.Windows.Forms.Label();
            this.carregarIco = new System.Windows.Forms.Label();
            this.gravarIco = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.red = new System.Windows.Forms.TrackBar();
            this.green = new System.Windows.Forms.TrackBar();
            this.blue = new System.Windows.Forms.TrackBar();
            this.paleta = new System.Windows.Forms.Label();
            this.borrachaIco = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contagotaIco = new System.Windows.Forms.Label();
            this.painel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.AutoScroll = true;
            this.painel.BackColor = System.Drawing.Color.White;
            this.painel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painel.Controls.Add(this.label1);
            this.painel.Controls.Add(this.label2);
            this.painel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.painel.Location = new System.Drawing.Point(215, 12);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(782, 498);
            this.painel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 0;
            this.label1.Visible = false;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(29, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 1;
            this.label2.Visible = false;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 498);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newIco);
            this.groupBox2.Controls.Add(this.carregarIco);
            this.groupBox2.Controls.Add(this.gravarIco);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arquivo";
            // 
            // newIco
            // 
            this.newIco.BackColor = System.Drawing.Color.Silver;
            this.newIco.Image = ((System.Drawing.Image)(resources.GetObject("newIco.Image")));
            this.newIco.Location = new System.Drawing.Point(6, 15);
            this.newIco.Margin = new System.Windows.Forms.Padding(3);
            this.newIco.Name = "newIco";
            this.newIco.Size = new System.Drawing.Size(65, 75);
            this.newIco.TabIndex = 3;
            this.newIco.Click += new System.EventHandler(this.label3_Click_1);
            this.newIco.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.newIco.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // carregarIco
            // 
            this.carregarIco.BackColor = System.Drawing.Color.Silver;
            this.carregarIco.Image = ((System.Drawing.Image)(resources.GetObject("carregarIco.Image")));
            this.carregarIco.Location = new System.Drawing.Point(143, 15);
            this.carregarIco.Margin = new System.Windows.Forms.Padding(3);
            this.carregarIco.Name = "carregarIco";
            this.carregarIco.Size = new System.Drawing.Size(46, 74);
            this.carregarIco.TabIndex = 5;
            this.carregarIco.Click += new System.EventHandler(this.label5_Click);
            this.carregarIco.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.carregarIco.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // gravarIco
            // 
            this.gravarIco.BackColor = System.Drawing.Color.Silver;
            this.gravarIco.Image = ((System.Drawing.Image)(resources.GetObject("gravarIco.Image")));
            this.gravarIco.Location = new System.Drawing.Point(74, 15);
            this.gravarIco.Margin = new System.Windows.Forms.Padding(3);
            this.gravarIco.Name = "gravarIco";
            this.gravarIco.Size = new System.Drawing.Size(65, 75);
            this.gravarIco.TabIndex = 4;
            this.gravarIco.Click += new System.EventHandler(this.gravarIco_Click);
            this.gravarIco.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.gravarIco.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.red);
            this.groupBox1.Controls.Add(this.green);
            this.groupBox1.Controls.Add(this.blue);
            this.groupBox1.Controls.Add(this.paleta);
            this.groupBox1.Location = new System.Drawing.Point(3, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cores";
            this.toolTip1.SetToolTip(this.groupBox1, "Modificar a cor do pincel");
            // 
            // red
            // 
            this.red.AutoSize = false;
            this.red.Location = new System.Drawing.Point(6, 19);
            this.red.Maximum = 255;
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(183, 25);
            this.red.TabIndex = 7;
            this.red.TickStyle = System.Windows.Forms.TickStyle.None;
            this.red.ValueChanged += new System.EventHandler(this.blue_ValueChanged);
            // 
            // green
            // 
            this.green.AutoSize = false;
            this.green.Location = new System.Drawing.Point(6, 50);
            this.green.Maximum = 255;
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(183, 25);
            this.green.TabIndex = 6;
            this.green.TickStyle = System.Windows.Forms.TickStyle.None;
            this.green.ValueChanged += new System.EventHandler(this.blue_ValueChanged);
            // 
            // blue
            // 
            this.blue.AutoSize = false;
            this.blue.Location = new System.Drawing.Point(6, 81);
            this.blue.Maximum = 255;
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(183, 25);
            this.blue.TabIndex = 4;
            this.blue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.blue.ValueChanged += new System.EventHandler(this.blue_ValueChanged);
            // 
            // paleta
            // 
            this.paleta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paleta.Image = ((System.Drawing.Image)(resources.GetObject("paleta.Image")));
            this.paleta.Location = new System.Drawing.Point(9, 109);
            this.paleta.Name = "paleta";
            this.paleta.Size = new System.Drawing.Size(180, 38);
            this.paleta.TabIndex = 5;
            // 
            // borrachaIco
            // 
            this.borrachaIco.BackColor = System.Drawing.Color.Silver;
            this.borrachaIco.Image = ((System.Drawing.Image)(resources.GetObject("borrachaIco.Image")));
            this.borrachaIco.Location = new System.Drawing.Point(6, 19);
            this.borrachaIco.Margin = new System.Windows.Forms.Padding(3);
            this.borrachaIco.Name = "borrachaIco";
            this.borrachaIco.Size = new System.Drawing.Size(41, 39);
            this.borrachaIco.TabIndex = 2;
            this.borrachaIco.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "imagem";
            this.openFileDialog1.Filter = "Imagem |*.PNC";
            this.openFileDialog1.InitialDirectory = "C:\\chrYstYan\\PaintCube\\";
            this.openFileDialog1.Title = "Selecionar Imagem";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "PNC";
            this.saveFileDialog1.Filter = "Imagem |*.PNC";
            this.saveFileDialog1.InitialDirectory = "C:\\chrYstYan\\PaintCube\\";
            this.saveFileDialog1.Title = "Salvar Imagem";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.contagotaIco);
            this.groupBox3.Controls.Add(this.borrachaIco);
            this.groupBox3.Location = new System.Drawing.Point(3, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 135);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ferramentas";
            // 
            // contagotaIco
            // 
            this.contagotaIco.BackColor = System.Drawing.Color.Silver;
            this.contagotaIco.Image = ((System.Drawing.Image)(resources.GetObject("contagotaIco.Image")));
            this.contagotaIco.Location = new System.Drawing.Point(53, 19);
            this.contagotaIco.Margin = new System.Windows.Forms.Padding(3);
            this.contagotaIco.Name = "contagotaIco";
            this.contagotaIco.Size = new System.Drawing.Size(41, 39);
            this.contagotaIco.TabIndex = 3;
            this.toolTip1.SetToolTip(this.contagotaIco, "Conta Gotas");
            this.contagotaIco.Click += new System.EventHandler(this.contagotaIco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1002, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.painel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Paint Cube";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.painel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel painel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label borrachaIco;
        private System.Windows.Forms.TrackBar blue;
        private System.Windows.Forms.TrackBar red;
        private System.Windows.Forms.TrackBar green;
        private System.Windows.Forms.Label paleta;
        private System.Windows.Forms.Label newIco;
        private System.Windows.Forms.Label carregarIco;
        private System.Windows.Forms.Label gravarIco;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label contagotaIco;
    }
}

