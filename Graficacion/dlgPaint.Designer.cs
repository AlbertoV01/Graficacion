
namespace Graficacion
{
    partial class dlgPaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pb_Linea = new System.Windows.Forms.PictureBox();
            this.pb_Borrador = new System.Windows.Forms.PictureBox();
            this.pb_Triangulo = new System.Windows.Forms.PictureBox();
            this.pb_Cuadrado = new System.Windows.Forms.PictureBox();
            this.pb_LineaGrosor = new System.Windows.Forms.PictureBox();
            this.pb_Balde = new System.Windows.Forms.PictureBox();
            this.btn_Aumentar = new System.Windows.Forms.Button();
            this.pb_Circulo = new System.Windows.Forms.PictureBox();
            this.btn_Disminuir = new System.Windows.Forms.Button();
            this.btn_Amarillo = new System.Windows.Forms.Button();
            this.btn_Verde = new System.Windows.Forms.Button();
            this.btn_Azul = new System.Windows.Forms.Button();
            this.pb_Lapiz = new System.Windows.Forms.PictureBox();
            this.btn_Rojo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Linea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Triangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LineaGrosor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Balde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Circulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Lapiz)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel1.Controls.Add(this.pb_Linea);
            this.splitContainer1.Panel1.Controls.Add(this.pb_Borrador);
            this.splitContainer1.Panel1.Controls.Add(this.pb_Triangulo);
            this.splitContainer1.Panel1.Controls.Add(this.pb_Cuadrado);
            this.splitContainer1.Panel1.Controls.Add(this.pb_LineaGrosor);
            this.splitContainer1.Panel1.Controls.Add(this.pb_Balde);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Aumentar);
            this.splitContainer1.Panel1.Controls.Add(this.pb_Circulo);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Disminuir);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Amarillo);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Verde);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Azul);
            this.splitContainer1.Panel1.Controls.Add(this.pb_Lapiz);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Rojo);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.TabIndex = 0;
            // 
            // pb_Linea
            // 
            this.pb_Linea.Image = global::Graficacion.Properties.Resources.Linea;
            this.pb_Linea.Location = new System.Drawing.Point(333, 64);
            this.pb_Linea.Name = "pb_Linea";
            this.pb_Linea.Size = new System.Drawing.Size(43, 30);
            this.pb_Linea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Linea.TabIndex = 13;
            this.pb_Linea.TabStop = false;
            this.pb_Linea.Click += new System.EventHandler(this.pb_Linea_Click);
            // 
            // pb_Borrador
            // 
            this.pb_Borrador.Image = global::Graficacion.Properties.Resources.Borrador;
            this.pb_Borrador.Location = new System.Drawing.Point(333, 28);
            this.pb_Borrador.Name = "pb_Borrador";
            this.pb_Borrador.Size = new System.Drawing.Size(43, 30);
            this.pb_Borrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Borrador.TabIndex = 12;
            this.pb_Borrador.TabStop = false;
            this.pb_Borrador.Click += new System.EventHandler(this.pb_Borrador_Click);
            // 
            // pb_Triangulo
            // 
            this.pb_Triangulo.Image = global::Graficacion.Properties.Resources.Triangulo;
            this.pb_Triangulo.Location = new System.Drawing.Point(284, 64);
            this.pb_Triangulo.Name = "pb_Triangulo";
            this.pb_Triangulo.Size = new System.Drawing.Size(43, 30);
            this.pb_Triangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Triangulo.TabIndex = 11;
            this.pb_Triangulo.TabStop = false;
            this.pb_Triangulo.Click += new System.EventHandler(this.pb_Triangulo_Click);
            // 
            // pb_Cuadrado
            // 
            this.pb_Cuadrado.Image = global::Graficacion.Properties.Resources.Rectangulo;
            this.pb_Cuadrado.Location = new System.Drawing.Point(186, 64);
            this.pb_Cuadrado.Name = "pb_Cuadrado";
            this.pb_Cuadrado.Size = new System.Drawing.Size(43, 30);
            this.pb_Cuadrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Cuadrado.TabIndex = 8;
            this.pb_Cuadrado.TabStop = false;
            this.pb_Cuadrado.Click += new System.EventHandler(this.pb_Cuadrado_Click);
            // 
            // pb_LineaGrosor
            // 
            this.pb_LineaGrosor.Image = global::Graficacion.Properties.Resources.Linea_Horizontal;
            this.pb_LineaGrosor.Location = new System.Drawing.Point(186, 28);
            this.pb_LineaGrosor.Name = "pb_LineaGrosor";
            this.pb_LineaGrosor.Size = new System.Drawing.Size(43, 30);
            this.pb_LineaGrosor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_LineaGrosor.TabIndex = 4;
            this.pb_LineaGrosor.TabStop = false;
            this.pb_LineaGrosor.Click += new System.EventHandler(this.pb_LineaGrosor_Click);
            // 
            // pb_Balde
            // 
            this.pb_Balde.Image = global::Graficacion.Properties.Resources.Balde;
            this.pb_Balde.Location = new System.Drawing.Point(284, 28);
            this.pb_Balde.Name = "pb_Balde";
            this.pb_Balde.Size = new System.Drawing.Size(43, 30);
            this.pb_Balde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Balde.TabIndex = 0;
            this.pb_Balde.TabStop = false;
            this.pb_Balde.Click += new System.EventHandler(this.pb_Balde_Click);
            // 
            // btn_Aumentar
            // 
            this.btn_Aumentar.Location = new System.Drawing.Point(235, 99);
            this.btn_Aumentar.Name = "btn_Aumentar";
            this.btn_Aumentar.Size = new System.Drawing.Size(20, 23);
            this.btn_Aumentar.TabIndex = 0;
            this.btn_Aumentar.Text = "+";
            this.btn_Aumentar.UseVisualStyleBackColor = true;
            this.btn_Aumentar.Click += new System.EventHandler(this.btn_Aumentar_Click);
            // 
            // pb_Circulo
            // 
            this.pb_Circulo.Image = global::Graficacion.Properties.Resources.Circulo;
            this.pb_Circulo.Location = new System.Drawing.Point(235, 64);
            this.pb_Circulo.Name = "pb_Circulo";
            this.pb_Circulo.Size = new System.Drawing.Size(43, 30);
            this.pb_Circulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Circulo.TabIndex = 9;
            this.pb_Circulo.TabStop = false;
            this.pb_Circulo.Click += new System.EventHandler(this.pb_Circulo_Click);
            // 
            // btn_Disminuir
            // 
            this.btn_Disminuir.Location = new System.Drawing.Point(258, 99);
            this.btn_Disminuir.Name = "btn_Disminuir";
            this.btn_Disminuir.Size = new System.Drawing.Size(20, 23);
            this.btn_Disminuir.TabIndex = 10;
            this.btn_Disminuir.Text = "-";
            this.btn_Disminuir.UseVisualStyleBackColor = true;
            this.btn_Disminuir.Click += new System.EventHandler(this.btn_Disminuir_Click);
            // 
            // btn_Amarillo
            // 
            this.btn_Amarillo.BackColor = System.Drawing.Color.Yellow;
            this.btn_Amarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Amarillo.Location = new System.Drawing.Point(505, 27);
            this.btn_Amarillo.Name = "btn_Amarillo";
            this.btn_Amarillo.Size = new System.Drawing.Size(31, 27);
            this.btn_Amarillo.TabIndex = 7;
            this.btn_Amarillo.UseVisualStyleBackColor = false;
            this.btn_Amarillo.Click += new System.EventHandler(this.btn_Amarillo_Click);
            // 
            // btn_Verde
            // 
            this.btn_Verde.BackColor = System.Drawing.Color.Green;
            this.btn_Verde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Verde.Location = new System.Drawing.Point(468, 27);
            this.btn_Verde.Name = "btn_Verde";
            this.btn_Verde.Size = new System.Drawing.Size(31, 27);
            this.btn_Verde.TabIndex = 6;
            this.btn_Verde.UseVisualStyleBackColor = false;
            this.btn_Verde.Click += new System.EventHandler(this.btn_Verde_Click);
            // 
            // btn_Azul
            // 
            this.btn_Azul.BackColor = System.Drawing.Color.Blue;
            this.btn_Azul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Azul.Location = new System.Drawing.Point(431, 27);
            this.btn_Azul.Name = "btn_Azul";
            this.btn_Azul.Size = new System.Drawing.Size(31, 27);
            this.btn_Azul.TabIndex = 5;
            this.btn_Azul.UseVisualStyleBackColor = false;
            this.btn_Azul.Click += new System.EventHandler(this.btn_Azul_Click);
            // 
            // pb_Lapiz
            // 
            this.pb_Lapiz.Image = global::Graficacion.Properties.Resources.Lapiz;
            this.pb_Lapiz.Location = new System.Drawing.Point(235, 28);
            this.pb_Lapiz.Name = "pb_Lapiz";
            this.pb_Lapiz.Size = new System.Drawing.Size(43, 30);
            this.pb_Lapiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Lapiz.TabIndex = 3;
            this.pb_Lapiz.TabStop = false;
            this.pb_Lapiz.Click += new System.EventHandler(this.pb_Lapiz_Click);
            // 
            // btn_Rojo
            // 
            this.btn_Rojo.BackColor = System.Drawing.Color.Red;
            this.btn_Rojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rojo.Location = new System.Drawing.Point(394, 27);
            this.btn_Rojo.Name = "btn_Rojo";
            this.btn_Rojo.Size = new System.Drawing.Size(31, 27);
            this.btn_Rojo.TabIndex = 2;
            this.btn_Rojo.UseVisualStyleBackColor = false;
            this.btn_Rojo.Click += new System.EventHandler(this.btn_Rojo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 321);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // dlgPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dlgPaint";
            this.Text = "dlgPaint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dlgPaint_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Linea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Triangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LineaGrosor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Balde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Circulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Lapiz)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pb_Balde;
        private System.Windows.Forms.Button btn_Rojo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Lapiz;
        private System.Windows.Forms.Button btn_Amarillo;
        private System.Windows.Forms.Button btn_Verde;
        private System.Windows.Forms.Button btn_Azul;
        private System.Windows.Forms.PictureBox pb_LineaGrosor;
        private System.Windows.Forms.PictureBox pb_Cuadrado;
        private System.Windows.Forms.PictureBox pb_Circulo;
        private System.Windows.Forms.Button btn_Aumentar;
        private System.Windows.Forms.Button btn_Disminuir;
        private System.Windows.Forms.PictureBox pb_Triangulo;
        private System.Windows.Forms.PictureBox pb_Borrador;
        private System.Windows.Forms.PictureBox pb_Linea;
    }
}