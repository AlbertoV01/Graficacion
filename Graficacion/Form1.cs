using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Graficacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Objetos 
        Graphics graphics;
        Graphics graphics2;
        Pen pluma = new Pen(Color.Black, 3);
        Pen pluma2 = new Pen(Color.Red, 3);
        Pen pluma3 = new Pen(Color.Black, 3);
        SolidBrush rojo = new SolidBrush(Color.Red);
        SolidBrush colornuevo = new SolidBrush(Color.LightYellow);
        SolidBrush blanco = new SolidBrush(Color.White);
        SolidBrush gris = new SolidBrush(Color.Gray);
        SolidBrush azul = new SolidBrush(Color.Blue);
        SolidBrush amarillo = new SolidBrush(Color.Yellow);
        SolidBrush negro = new SolidBrush(Color.Black);
        SolidBrush RojoOscuroDeadpool = new SolidBrush(Color.FromArgb(153, 0, 0));
        SolidBrush RojoClaroDeadpool = new SolidBrush(Color.FromArgb(255, 0, 0));
        SolidBrush GrisOscuroDeadpol = new SolidBrush(Color.FromArgb(64, 64, 64));
        SolidBrush GrisClaroDeadpool = new SolidBrush(Color.FromArgb(128, 128, 128));
        SolidBrush Blanco = new SolidBrush(Color.White);
        SolidBrush CafeDeadpool = new SolidBrush(Color.Brown);
        //SolidBrush rojorgb = new SolidBrush(Color.FromArgb());

        // --------------------------------------- CUADRADO CON LINEAS RECTA -----------------------------

        //---------------------------- Cuadrado Con lineas ---------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(pluma, 100, 50, 200, 50);
            graphics.DrawLine(pluma, 100, 50, 100, 150);

            graphics.DrawLine(pluma, 200, 50, 200, 150);
            graphics.DrawLine(pluma, 100, 150, 200, 150);
        }
        //--------------- METODO CreateGraphics dDE UNA FORMULARIO PARA OBTENER REFERENCIA A UN OBJETO Graphics -----------------
        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            graphics2 = this.CreateGraphics();
        }
        // ----------------------------------- CUADRADO con Polygon, Triangulo, Elipse -------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            Point punto1 = new Point(200, 150);
            Point punto2 = new Point(50, 200);
            Point punto3 = new Point(50, 350);
            Point[] arreglopuntos = { punto1, punto2, punto3 };

            graphics.DrawRectangle(pluma, 100, 200, 100, 200);
            graphics.DrawEllipse(pluma, 300, 200, 100, 100);
            graphics.DrawPolygon(pluma, arreglopuntos);
        }
        // ----------------------------------- COHETE -------------4----------------------------------------------------------
        private void btn_Cohete_Click(object sender, EventArgs e)
        {
            //Cuerpo del Cohete
            graphics.FillRectangle(azul, 700, 200, 100, 400);
            graphics.DrawRectangle(pluma, 700, 200, 100, 400);

            //Parte Superior del Cohete
            Point punto1 = new Point(700, 200);
            Point punto2 = new Point(750, 100);
            Point punto3 = new Point(800, 200);
            Point[] ArregloPuntos = { punto1, punto2, punto3 };
            graphics.FillPolygon(rojo, ArregloPuntos); //                         Color rojo
            graphics.DrawPolygon(pluma, ArregloPuntos);


            //Parte superior del cuerpo del cohete
            graphics.FillRectangle(azul, 700, 200, 100, 90);   //                 Color azul parte superior
            graphics.FillEllipse(colornuevo, 725, 220, 50, 50); //                Color de circulo
            graphics.DrawEllipse(pluma, 725, 220, 50, 50);
            graphics.DrawRectangle(pluma, 700, 200, 100, 90);

            //Parte Intermedia el cuerpo del cohete
            graphics.FillRectangle(rojo, 700, 290, 100, 120); //                         Color rojo
            graphics.FillEllipse(colornuevo, 725, 320, 50, 50);     //                   Color circulo
            graphics.DrawEllipse(pluma, 725, 320, 50, 50);
            graphics.DrawRectangle(pluma, 700, 290, 100, 120);

            //Parte Inferior del cuerpo del cohete
            graphics.FillRectangle(gris, 724, 450, 50, 100);//                  Color azul parte inferior del cohete
            graphics.FillEllipse(colornuevo, 710, 420, 20, 20); //              Color circulo
            graphics.FillEllipse(colornuevo, 770, 420, 20, 20);//               Color circulo
            graphics.FillEllipse(amarillo, 710, 565, 20, 20);//               Color circulo
            graphics.FillEllipse(amarillo, 770, 565, 20, 20);//               Color circulo


            graphics.DrawRectangle(pluma, 724, 450, 50, 100);
            graphics.DrawEllipse(pluma, 710, 420, 20, 20);//Circulo supperior izquierdo
            graphics.DrawEllipse(pluma, 770, 420, 20, 20);//Circulo superior derecho
            graphics.DrawEllipse(pluma, 710, 565, 20, 20);//Circulo Inferior derecho
            graphics.DrawEllipse(pluma, 770, 565, 20, 20);//Circulo inferior izquierdo

            //Circulos externos al cohete
            graphics.FillEllipse(colornuevo, 830, 70, 70, 70); //                Color nuevo
            graphics.FillEllipse(colornuevo, 790, 60, 20, 20);//                 Color nuevo
            graphics.FillEllipse(colornuevo, 830, 170, 100, 100);//              Color nuevo
            graphics.DrawEllipse(pluma, 790, 60, 20, 20);
            graphics.DrawEllipse(pluma, 830, 70, 70, 70);
            graphics.DrawEllipse(pluma, 830, 170, 100, 100);

            //Alas del cohete

            //Aala superior izquierda
            Point puntoala1 = new Point(700, 270);
            Point puntoala2 = new Point(590, 330);
            Point puntoala3 = new Point(590, 430);
            Point puntoala4 = new Point(700, 380);
            Point[] alasuperiorizq = { puntoala1, puntoala2, puntoala3, puntoala4 };
            graphics.FillPolygon(gris, alasuperiorizq);      //                                 Color Gris ala
            graphics.DrawPolygon(pluma, alasuperiorizq);

            //Ala superior derecha
            Point puntoala5 = new Point(800, 270);
            Point puntoala6 = new Point(920, 330);
            Point puntoala7 = new Point(920, 430);
            Point puntoala8 = new Point(800, 380);
            Point[] alasuperiorderech = { puntoala5, puntoala6, puntoala7, puntoala8 };
            graphics.FillPolygon(gris, alasuperiorderech);//                                   Color Gris ala
            graphics.DrawPolygon(pluma, alasuperiorderech);

            //Ala inferior izquierda
            Point puntoala9 = new Point(700, 500);
            Point puntoala10 = new Point(590, 560);
            Point puntoala11 = new Point(590, 660);
            Point puntoala12 = new Point(700, 620);
            Point[] alasinferiorizq = { puntoala9, puntoala10, puntoala11, puntoala12 };
            graphics.FillPolygon(gris, alasinferiorizq);//                                      Color Gris ala 
            graphics.DrawPolygon(pluma, alasinferiorizq);

            //Ala inferior derecha
            Point puntoala13 = new Point(800, 500);
            Point puntoala14 = new Point(920, 560);
            Point puntoala15 = new Point(920, 660);
            Point puntoala16 = new Point(800, 620);
            Point[] alasinferiorderech = { puntoala13, puntoala14, puntoala15, puntoala16 };
            graphics.FillPolygon(gris, alasinferiorderech); //                                   Color Gris  ala                       
            graphics.DrawPolygon(pluma, alasinferiorderech);

        }

        // ------------------------------------ DEADPOOL-------------------------------------------------------------------------
        private void btn_Deadpool_Click(object sender, EventArgs e)
        {
            int AumentoenX = 700;

            //Primera Linea
            for (int x = 0; x < 18; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 50, 4, 4);
                graphics.FillRectangle(negro, AumentoenX, 50, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 700;

            for (int x = 0; x < 18; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 54, 4, 4);
                graphics.FillRectangle(negro, AumentoenX, 54, 4, 4);
                AumentoenX += 4;
            }

            // Segunda Linea

            AumentoenX = 679;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 58, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 58, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 57, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;

            for (int x = 0; x < 12; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 57, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 775;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 58, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 58, 1, 1);
                AumentoenX += 4;
            }

            // Tercera Linea

            AumentoenX = 679;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 62, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 62, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 61, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;

            for (int x = 0; x < 12; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 61, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 775;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 62, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 62, 1, 1);
                AumentoenX += 4;
            }

            //  Cuarta Linea

            AumentoenX = 679;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 66, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 66, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 65, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;

            for (int x = 0; x < 12; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 65, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 775;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 66, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 66, 1, 1);
                AumentoenX += 4;
            }

            // Quinta Linea 

            AumentoenX = 667;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 70, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 70, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 69, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 714;

            for (int x = 0; x < 21; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 69, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 798;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 70, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 70, 1, 1);
                AumentoenX += 4;
            }


            //   Sexta Linea

            AumentoenX = 667;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 74, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 74, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 73, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 714;

            for (int x = 0; x < 21; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 73, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 798;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 74, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 74, 1, 1);
                AumentoenX += 4;
            }

            //     Septima Linea

            AumentoenX = 667;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 78, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 78, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 77, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 714;

            for (int x = 0; x < 21; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 77, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 798;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 78, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 78, 1, 1);
                AumentoenX += 4;
            }

            //   Octava Linea 

            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 82, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 82, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 81, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 27; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 81, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 82, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 82, 1, 1);
                AumentoenX += 4;
            }

            //    Novena Linea

            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 86, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 86, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 85, 4, 4);
                AumentoenX += 4;
            }


            AumentoenX = 701;

            for (int x = 0; x < 27; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 85, 4, 4);
                AumentoenX += 4;
            }


            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 86, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 86, 1, 1);
                AumentoenX += 4;
            }

            //   Decima Linea

            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 90, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 90, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 89, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 689;

            for (int x = 0; x < 30; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 89, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 90, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 90, 1, 1);
                AumentoenX += 4;
            }

            // Undecima

            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 94, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 94, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 93, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 689;

            for (int x = 0; x < 30; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 93, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 94, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 94, 1, 1);
                AumentoenX += 4;
            }

            //      Doceava Linea 

            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 98, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 98, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 97, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 689;

            for (int x = 0; x < 30; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 97, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 98, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 98, 1, 1);
                AumentoenX += 4;
            }

            //    Terceava Linea

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 102, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 102, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 101, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 36; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 101, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 102, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 102, 1, 1);
                AumentoenX += 4;

            }

            // Cuarteava Linea

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 106, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 106, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 105, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 36; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 105, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 106, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 106, 1, 1);
                AumentoenX += 4;

            }

            // Quinteava   Linea

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 110, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 110, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 109, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 36; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 109, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 110, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 110, 1, 1);
                AumentoenX += 4;
            }

            // Dieciseisava  Linea

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 114, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 114, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 113, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 36; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 113, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 114, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 114, 1, 1);
                AumentoenX += 4;
            }

            // Diecisietesava Linea

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 118, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 118, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 117, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 36; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 117, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 118, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 118, 1, 1);
                AumentoenX += 4;
            }

            // Dieciochoava Linea

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 122, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 122, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 121, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 36; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 121, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 122, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 122, 1, 1);
                AumentoenX += 4;
            }

            //  Diecinueveava Linea

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 126, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 126, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 125, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 36; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 125, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 126, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 126, 1, 1);
                AumentoenX += 4;
            }

            //  Veinteava Linea

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 126, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 126, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 125, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 36; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 125, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 126, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 126, 1, 1);
                AumentoenX += 4;
            }

            // Linea 21

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 130, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 130, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 129, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 36; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 129, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 130, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 130, 1, 1);
                AumentoenX += 4;
            }

            // Linea 22

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 134, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 134, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 133, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 133, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 133, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 133, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 749;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 133, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 133, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 134, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 134, 1, 1);
                AumentoenX += 4;
            }

            // Linea 23

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 138, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 138, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 137, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 137, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 137, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 137, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 749;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 137, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 137, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 138, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 138, 1, 1);
                AumentoenX += 4;
            }

            // Linea 24

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 142, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 142, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 141, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 141, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 141, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 141, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 749;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 141, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 141, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 142, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 142, 1, 1);
                AumentoenX += 4;
            }

            // Linea 25

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 146, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 146, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 145, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 145, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 145, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 737;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 145, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 145, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 145, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 146, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 146, 1, 1);
                AumentoenX += 4;
            }

            // Linea 26

            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 150, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 150, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 149, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 149, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 149, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 737;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 149, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 149, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 149, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 150, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 150, 1, 1);
                AumentoenX += 4;
            }

            // Linea 27


            AumentoenX = 643;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 154, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 154, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 153, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 153, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 153, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 737;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 153, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 153, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 153, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 154, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 154, 1, 1);
                AumentoenX += 4;
            }

            // Linea 28
            AumentoenX = 571;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 158, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 158, 1, 1);
                AumentoenX += 4;
            }



            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 158, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 158, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 157, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;


            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 157, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 157, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(Blanco, AumentoenX, 157, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 749;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 157, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 157, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 157, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 158, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 158, 1, 1);
                AumentoenX += 4;
            }

            // Linea 29

            AumentoenX = 571;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 162, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 162, 1, 1);
                AumentoenX += 4;
            }


            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 160, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 160, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 159, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;


            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 159, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 159, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(Blanco, AumentoenX, 159, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 749;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 159, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 159, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 159, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 160, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 160, 1, 1);
                AumentoenX += 4;
            }


            // Linea 30


            AumentoenX = 571;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 166, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 166, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 164, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 164, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 163, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;


            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 163, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 163, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(Blanco, AumentoenX, 163, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 749;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 163, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 163, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 163, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 164, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 164, 1, 1);
                AumentoenX += 4;
            }

            // Linea 31



            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 168, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 168, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 167, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 167, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 167, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(blanco, AumentoenX, 167, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 749;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(gris, AumentoenX, 167, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 167, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;


            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 167, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 168, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 168, 1, 1);
                AumentoenX += 4;
            }




            // Linea 32

            AumentoenX = 571;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 170, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 170, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 582;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(CafeDeadpool, AumentoenX, 169, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 170, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 170, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 171, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 171, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 170, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 170, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 170, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(blanco, AumentoenX, 170, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 761;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 170, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 170, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 170, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;


            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 171, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 171, 1, 1);
                AumentoenX += 4;
            }

            // Linea 33

            AumentoenX = 571;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 174, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 174, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 582;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(CafeDeadpool, AumentoenX, 173, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 174, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 174, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 175, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 175, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 174, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 174, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 174, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;


            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(blanco, AumentoenX, 174, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 761;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 174, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 174, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 174, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 175, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 175, 1, 1);
                AumentoenX += 4;
            }


            // Linea 34

            AumentoenX = 571;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 178, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 178, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 582;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(CafeDeadpool, AumentoenX, 177, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 178, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 178, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 178, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 178, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 177, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 177, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 177, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(blanco, AumentoenX, 177, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 761;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 177, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 177, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 177, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 178, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 178, 1, 1);
                AumentoenX += 4;
            }


            // Linea 35


            AumentoenX = 583;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 182, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 182, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(CafeDeadpool, AumentoenX, 181, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 182, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 182, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 655;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 182, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 182, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 181, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 181, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 181, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(blanco, AumentoenX, 181, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 761;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(gris, AumentoenX, 181, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 181, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 181, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 182, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 182, 1, 1);
                AumentoenX += 4;
            }

            // Linea 36


            AumentoenX = 583;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 184, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 184, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(CafeDeadpool, AumentoenX, 183, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 184, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 184, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 667;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 186, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 186, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 185, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 185, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 714;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 185, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 185, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 185, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 185, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 186, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 186, 1, 1);
                AumentoenX += 4;
            }

            // Linea 37

            AumentoenX = 583;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 188, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 188, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(CafeDeadpool, AumentoenX, 187, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 188, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 188, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 667;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 188, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 188, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 187, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 187, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 714;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 187, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 187, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 187, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 187, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 188, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 188, 1, 1);
                AumentoenX += 4;
            }

            // Linea 38

            AumentoenX = 583;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 192, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 192, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(CafeDeadpool, AumentoenX, 191, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 192, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 192, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 667;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 192, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 192, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 191, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 191, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 714;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 191, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 191, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 773;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 191, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 191, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 192, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 192, 1, 1);
                AumentoenX += 4;
            }

            // Linea 39

            AumentoenX = 595;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 196, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 196, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(CafeDeadpool, AumentoenX, 195, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 196, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 196, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 679;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 196, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 196, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 195, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;


            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 195, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 195, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 762;

            for (int x = 0; x < 12; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 195, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 196, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 196, 1, 1);
                AumentoenX += 4;
            }

            // Linea 40

            AumentoenX = 595;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 200, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 200, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(CafeDeadpool, AumentoenX, 199, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 200, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 200, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 679;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 200, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 200, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 199, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;


            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 199, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 199, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 762;

            for (int x = 0; x < 12; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 199, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 200, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 200, 1, 1);
                AumentoenX += 4;
            }

            // Linea 41

            AumentoenX = 595;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 204, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 204, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(CafeDeadpool, AumentoenX, 203, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 204, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 204, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 679;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 204, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 204, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 203, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;


            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 203, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 203, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 762;

            for (int x = 0; x < 12; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 203, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 204, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 204, 1, 1);
                AumentoenX += 4;
            }


            // Linea 42


            AumentoenX = 607;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 208, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 208, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(CafeDeadpool, AumentoenX, 207, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 208, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 208, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 667;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 208, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 208, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 207, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 208, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 208, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 9; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 207, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 737;

            for (int x = 0; x < 15; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 207, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 208, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 208, 1, 1);
                AumentoenX += 4;
            }

            // Linea 43

            AumentoenX = 607;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 212, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 212, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(CafeDeadpool, AumentoenX, 211, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 212, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 212, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 667;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 212, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 212, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 211, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 212, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 212, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 9; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 211, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 737;

            for (int x = 0; x < 15; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 211, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 212, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 212, 1, 1);
                AumentoenX += 4;
            }

            //  Linea 44


            AumentoenX = 607;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 216, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 216, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(CafeDeadpool, AumentoenX, 215, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 216, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 216, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 667;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 216, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 216, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 215, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 216, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 216, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 9; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 215, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 737;

            for (int x = 0; x < 15; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 215, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 216, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 216, 1, 1);
                AumentoenX += 4;
            }

            // Linea 45

            AumentoenX = 619;

            for (int x = 0; x < 12; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 220, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 220, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 219, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;


            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 219, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 220, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 220, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 219, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 749;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 219, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 785;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 220, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 220, 1, 1);
                AumentoenX += 4;
            }

            // Linea 46

            AumentoenX = 619;

            for (int x = 0; x < 12; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 224, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 224, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 223, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;


            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 223, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 224, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 224, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 223, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 749;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 223, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 785;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 224, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 224, 1, 1);
                AumentoenX += 4;
            }

            // Linea 47

            AumentoenX = 619;

            for (int x = 0; x < 12; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 228, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 228, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 227, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;


            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 227, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 228, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 228, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 227, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 749;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 227, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 785;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 228, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 228, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            // Linea 48

            AumentoenX = 631;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 232, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 232, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 12; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 231, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 231, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;

            for (int x = 0; x < 15; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 232, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 232, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 784;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 231, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 232, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 232, 1, 1);
                AumentoenX += 4;
            }

            // Linea 49

            AumentoenX = 631;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 236, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 236, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 12; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 235, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 235, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;

            for (int x = 0; x < 15; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 236, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 236, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 784;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 235, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 236, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 236, 1, 1);
                AumentoenX += 4;
            }

            // Linea 50

            AumentoenX = 631;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 240, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 240, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 12; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 239, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 239, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 726;

            for (int x = 0; x < 15; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 240, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 240, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 784;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 239, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 240, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 240, 1, 1);
                AumentoenX += 4;
            }

            // Linea 51

            AumentoenX = 631;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 244, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 244, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 243, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 243, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;


            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 244, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 244, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 243, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 18; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 243, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 243, 5, 5);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 244, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 244, 1, 1);
                AumentoenX += 4;
            }


            // Linea 52

            AumentoenX = 631;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 248, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 248, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 247, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 247, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;


            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 248, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 248, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 247, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 18; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 247, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 247, 5, 5);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 248, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 248, 1, 1);
                AumentoenX += 4;
            }

            // Linea 53

            AumentoenX = 631;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 252, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 252, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 251, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 251, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;


            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 252, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 252, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 251, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 18; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 251, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 251, 5, 5);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 252, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 252, 1, 1);
                AumentoenX += 4;
            }

            // Linea 54


            AumentoenX = 619;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 256, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 256, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 255, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 256, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 256, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 653;

            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 255, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 255, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;


            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 256, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 256, 1, 1);
                AumentoenX += 4;
            }


            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 255, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 18; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 255, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 255, 5, 5);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 256, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 256, 1, 1);
                AumentoenX += 4;
            }

            // Linea 55

            AumentoenX = 619;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 260, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 260, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 259, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 260, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 260, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 653;

            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 259, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 259, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;


            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 260, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 260, 1, 1);
                AumentoenX += 4;
            }


            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 259, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 18; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 259, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 259, 5, 5);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 260, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 260, 1, 1);
                AumentoenX += 4;
            }

            // Linea 56

            AumentoenX = 619;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 264, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 264, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 263, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 264, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 264, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 653;

            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 263, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 677;

            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 263, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 702;


            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 264, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 264, 1, 1);
                AumentoenX += 4;
            }


            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 263, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 18; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 263, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 263, 5, 5);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 264, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 264, 1, 1);
                AumentoenX += 4;
            }

            //  Linea 57

            AumentoenX = 619;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 268, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 268, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 267, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 9; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 267, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 267, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 268, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 268, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 267, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 713;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 268, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 268, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 736;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 267, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 267, 5, 5);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 268, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 268, 1, 1);
                AumentoenX += 4;
            }


            // Linea 58

            AumentoenX = 619;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 272, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 272, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 271, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 9; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 271, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 271, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 272, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 272, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 271, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 713;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 272, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 272, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 736;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 271, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 271, 5, 5);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 272, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 272, 1, 1);
                AumentoenX += 4;
            }

            // Linea 59

            AumentoenX = 619;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 276, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 276, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 275, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 9; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 275, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 275, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 276, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 276, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 275, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 713;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 276, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 276, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 736;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 275, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 275, 5, 5);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 276, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 276, 1, 1);
                AumentoenX += 4;
            }

            // Linea 60

            AumentoenX = 607;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 280, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 280, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 279, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 279, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 279, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 279, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 279, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 280, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 280, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 689;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 279, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 279, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 712;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 279, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 736;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 279, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 280, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 280, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 280, 1, 1);
                AumentoenX += 4;
            }

            // Linea 61


            AumentoenX = 607;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 284, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 284, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 283, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 283, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 283, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 283, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 283, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 284, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 284, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 689;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 283, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 283, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 712;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 283, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 736;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 283, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 284, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 284, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 284, 1, 1);
                AumentoenX += 4;
            }

            // Linea 62

            AumentoenX = 607;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 288, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 288, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 287, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 287, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 287, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 287, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 287, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 288, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 288, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 689;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 287, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 287, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 712;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 287, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 736;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 287, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 287, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 288, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 288, 1, 1);
                AumentoenX += 4;
            }

            // Linea 63

            AumentoenX = 607;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 292, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 292, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 291, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 291, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 291, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 292, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 292, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 689;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 291, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;


            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 291, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 737;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 291, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 291, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 292, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 292, 1, 1);
                AumentoenX += 4;
            }

            // Linea 64

            AumentoenX = 607;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 296, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 296, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 295, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 295, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 295, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 296, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 296, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 689;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 295, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;


            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 295, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 737;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 295, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 295, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 296, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 296, 1, 1);
                AumentoenX += 4;
            }


            // Linea 65

            AumentoenX = 607;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 300, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 300, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 300, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 300, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 689;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;


            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 737;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 300, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 300, 1, 1);
                AumentoenX += 4;
            }

            // Linea 66

            AumentoenX = 607;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 300, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 300, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 6; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 300, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 300, 1, 1);
                AumentoenX += 4;
            }

            AumentoenX = 689;

            for (int x = 0; x < 9; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 725;


            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 737;

            for (int x = 0; x < 15; x++)
            {
                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 299, 4, 4);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 300, 1, 1);
                graphics.FillRectangle(negro, AumentoenX, 300, 1, 1);
                AumentoenX += 4;
            }

            // Linea 67


            // Linea 67



            AumentoenX = 607;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 304, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 304, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 303, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 303, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {
                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 303, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 304, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 304, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 690;


            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 304, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 304, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 303, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 303, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 725;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 303, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 736;

            for (int x = 0; x < 15; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 303, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 303, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 304, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 304, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 304, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 304, 1, 9);
                AumentoenX += 4;
            }


            // Linea 68

            AumentoenX = 595;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 316, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 316, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 315, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 315, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 630;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 315, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 316, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 316, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 316, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 316, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 316, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 316, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 713;


            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 315, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 737;


            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 315, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 761;


            for (int x = 0; x < 9; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 315, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 796;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 315, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 809;

            for (int x = 0; x < 6; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 316, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 316, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 821;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 316, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 833;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 316, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 316, 1, 9);
                AumentoenX += 4;
            }


            // Linea 69

            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 618;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 327, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 327, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 327, 1, 10);
                graphics.FillRectangle(negro, AumentoenX, 327, 1, 10);
                AumentoenX += 4;
            }

            AumentoenX = 701;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 328, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 328, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 724;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 736;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 748;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 760;
            AumentoenX = 772;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 808;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 820;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 832;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 327, 4, 12);
                AumentoenX += 4;
            }

            // Linea 70


            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 606;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 630;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 339, 1, 10);
                graphics.FillRectangle(negro, AumentoenX, 339, 1, 10);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {
                graphics.DrawRectangle(pluma, AumentoenX, 340, 1, 9);
                graphics.FillRectangle(negro, AumentoenX, 340, 1, 9);
                AumentoenX += 4;
            }

            AumentoenX = 689;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 701;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 725;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 737;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 749;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 761;

            AumentoenX = 773;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 797;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 796;


            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 820;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 832;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 339, 4, 12);
                AumentoenX += 4;
            }


            // Linea 71

            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 666;



            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }
            AumentoenX = 713;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 725;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 737;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 748;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 760;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 772;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }
            AumentoenX = 784;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 807;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 819;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 831;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 351, 4, 12);
                AumentoenX += 4;
            }


            // Linea 72

            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 702;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 713;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 725;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 737;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 749;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 761;



            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 773;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 785;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 808;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 820;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 832;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 844;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 363, 4, 12);
                AumentoenX += 4;
            }


            // Linea 73

            AumentoenX = 594;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 714;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 726;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 738;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 762;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 774;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 786;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 798;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 822;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 834;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 846;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 375, 4, 12);
                AumentoenX += 4;
            }

            // Linea 75


            AumentoenX = 606;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 680;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 692;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 704;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 716;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 728;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 740;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 752;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 764;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 776;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 788;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 800;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 812;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 824;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 836;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 848;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 387, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 860;

            // Linea 75

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642; ;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 714;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 726;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 738;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 399, 6, 12);
                AumentoenX += 4;
            }

            AumentoenX = 752;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 764;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 776;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 788;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 800;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 812;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 824;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 836;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 848;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 399, 4, 12);
                AumentoenX += 4;
            }

            // Linea 76

            AumentoenX = 642; ;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 411, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 411, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 411, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 678;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 411, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 690;


            for (int x = 0; x < 12; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 411, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 738;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 411, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 411, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 762;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 411, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 774;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 411, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 786;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 411, 5, 12);
                AumentoenX += 4;
            }

            AumentoenX = 799;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 411, 5, 12);
                AumentoenX += 4;
            }

            AumentoenX = 812;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 411, 4, 12);
                AumentoenX += 4;
            }

            // Linea 77

            AumentoenX = 642; ;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 9; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 738;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 762;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 774;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 786;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 798;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 423, 6, 12);
                AumentoenX += 4;
            }

            AumentoenX = 812;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 423, 4, 12);
                AumentoenX += 4;
            }

            // Linea 78
            AumentoenX = 630;



            AumentoenX = 642; ;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 435, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 435, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 435, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 435, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 9; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 435, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 722;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 435, 8, 12);
                AumentoenX += 4;
            }

            AumentoenX = 734;

            AumentoenX = 747;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 435, 24, 12);
                AumentoenX += 4;
            }

            AumentoenX = 762;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 435, 4, 12);
                AumentoenX += 4;
            }


            AumentoenX = 770;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 435, 8, 12);
                AumentoenX += 4;
            }


            AumentoenX = 786;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 435, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 798;

            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 435, 6, 12);
                AumentoenX += 4;
            }

            // Linea 79

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 6; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 702;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 710;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 762;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 774;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 786;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 798;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 447, 4, 12);
                AumentoenX += 4;
            }


            // Linea 80

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 690;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 698;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 762;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 774;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 786;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 798;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 810;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 459, 4, 12);
                AumentoenX += 4;
            }

            // Linea 81

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 686;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 762;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 774;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 786;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 798;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 810;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 471, 4, 12);
                AumentoenX += 4;
            }

            // Linea 82
            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 678;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 686;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 750;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 762;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 774;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 786;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 798;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 800;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 810;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(rojo, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 822;


            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 483, 4, 12);
                AumentoenX += 4;
            }


            // Linea 83


            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 495, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 495, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 495, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 495, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 495, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 674;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 495, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 762;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 495, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 772;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisOscuroDeadpol, AumentoenX, 495, 6, 12);
                AumentoenX += 4;
            }

            AumentoenX = 786;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(GrisClaroDeadpool, AumentoenX, 495, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 796;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 495, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 802;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 495, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 814;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 495, 12, 12);
                AumentoenX += 4;
            }

            AumentoenX = 834;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 495, 4, 12);
                AumentoenX += 4;
            }

            // Linea 84

            AumentoenX = 618;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 507, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 630;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 507, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 642;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 507, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 654;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoOscuroDeadpool, AumentoenX, 507, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 666;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(RojoClaroDeadpool, AumentoenX, 507, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 674;

            for (int x = 0; x < 3; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 507, 4, 12);
                AumentoenX += 4;
            }

            AumentoenX = 772;

            for (int x = 0; x < 15; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 507, 5, 12);
                AumentoenX += 4;
            }

            // Ultima linea 85

            AumentoenX = 618;

            for (int x = 0; x < 14; x++)
            {

                graphics.FillRectangle(negro, AumentoenX, 519, 4, 12);
                AumentoenX += 4;
            }



        }
        // -------------------------------- TRIANGULO DE SIERSPINKI --------------------------------------------------------------
        private void btn_Sierspinki_Click(object sender, EventArgs e)
        {
            IniciarSierspinki();
        }
        // ---------------------------------- Se asignan las coordenadas a los puntos A,  B Y C ---------------------------------  
        void IniciarSierspinki()
        {
            Point A = new Point(600, 600);
            Point B = new Point(900, 600);
            Point C = new Point(750, 300);
            int Iteracion = 3;
            DibujarSierspinki(A, B, C, Iteracion);
        }
        // ----------------------------------- Se dibujan los triangulos (Recursividad) --------------------------------------------------------
        void DibujarSierspinki(Point A, Point B, Point C, int Iteracion)
        {
            if (Iteracion == 0)
            {
                DibujarRelleno(A, B, C);
            }
            else
            {
                Point AB = Mitad(A, B);
                Point BC = Mitad(B, C);
                Point AC = Mitad(A, C);

                DibujarSierspinki(A, AB, AC, Iteracion - 1);
                DibujarSierspinki(AB, B, BC, Iteracion - 1);
                DibujarSierspinki(AC, BC, C, Iteracion - 1);

            }
        }

        // --------------------------------- Se obtiene la mitad de los puntos ----------------------------------------------
        Point Mitad(Point A, Point B)
        {
            Point Resultado = new Point();
            Resultado.X = (A.X + B.X) / 2;
            Resultado.Y = (A.Y + B.Y) / 2;
            return Resultado;
        }

        //------------------------------ Dibujar TRIANGULO DE SIERSPINSKI-----------------------------------------------------------------------------------------------
        void DibujarRelleno(Point A, Point B, Point C)
        {
            Point[] Coordenadas = { A, B, C };
            graphics.DrawPolygon(pluma, Coordenadas);
        }
        // ----------------------------------------- ALFOMBRA DE SIERSPINKI  (PENDIENTE)  -------------------------------------------------------------
        private void btn_Alfombra_Click(object sender, EventArgs e)
        {
            IniciarAlfombra();
        }

        void IniciarAlfombra()
        {
            Point A = new Point(400, 100);
            Point B = new Point(1000, 100);
            Point C = new Point(1000, 500);
            Point D = new Point(400, 500);
            int Iteracion = 3;
            DibujarAlfombra(A, B, C, D, Iteracion);
        }

        void DibujarAlfombra(Point A, Point B, Point C, Point D, int Iteracion)
        {
            if (Iteracion == 0)
            {
                DibujarRellenoAlfombra(A, B, C, D);
            }
            else
            {
                Point AB = MitadAlfombra(A, B);
                Point BC = MitadAlfombra(B, C);
                Point CD = MitadAlfombra(C, D);
                Point DA = MitadAlfombra(D, A);

                DibujarAlfombra(A, AB, CD, DA, Iteracion - 1);
                DibujarAlfombra(AB, B, BC, CD, Iteracion - 1);
                DibujarAlfombra(DA, BC, CD, DA, Iteracion - 1);
            }

        }

        Point MitadAlfombra(Point A, Point B)
        {
            Point Resultado = new Point();
            Resultado.X = (A.X + B.X) / 3;
            Resultado.Y = (A.Y + B.Y) / 3;
            return Resultado;
        }

        void DibujarRellenoAlfombra(Point A, Point B, Point C, Point D)
        {
            Point[] Coordenadas = { A, B, C, D };
            graphics.DrawPolygon(pluma, Coordenadas);
        }

        //------------------------------------------- TRASLACION -------------------------------------------------------------------------------------------------

        // TRASLADA EL TRIANGULO
        private void btnTraslacion_Click(object sender, EventArgs e)
        {
            Point VectorTraslacion = new Point(Convert.ToInt32(tb_x.Text), Convert.ToInt32(tb_y.Text));


            Point A = new Point(600, 600);
            Point B = new Point(900, 600);
            Point C = new Point(750, 300);

            Point A_prima = new Point(A.X + VectorTraslacion.X, A.Y + VectorTraslacion.Y);

            Point B_prima = new Point(B.X + VectorTraslacion.X, B.Y + VectorTraslacion.Y);

            Point C_prima = new Point(C.X + VectorTraslacion.X, C.Y + VectorTraslacion.Y);
            Point[] Coordenadas = { A_prima, B_prima, C_prima };
            graphics.Clear(Color.White);
            tb_x.Clear();
            tb_y.Clear();
            graphics.DrawPolygon(pluma, Coordenadas);

        }
        // DIBUJA EL TRIANGULO INICIAL
        private void btn_DibjTraslacion_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            Point A = new Point(600, 600);

            Point B = new Point(900, 600);
            Point C = new Point(750, 300);

            Point[] Coordenadas = { A, B, C };

            graphics.DrawPolygon(pluma, Coordenadas);


        }
        // DIBUJJA EL TRIANGULO INICIAL Y LUEGO LO ESCALA CON LOS VALORES DE LOS TEXT BOX
        private void btn_DibEscalamiento_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            Point VectorEscalamiento = new Point(Convert.ToInt32(tb_DibEscalamientoX.Text), Convert.ToInt32(tb_DibEscalamientoY.Text));
            Point A = new Point(400, 400);
            Point B = new Point(700, 400);
            Point C = new Point(550, 100);

            Point A_prima = new Point(A.X * VectorEscalamiento.X, A.Y * VectorEscalamiento.Y);

            Point B_prima = new Point(B.X * VectorEscalamiento.X, B.Y * VectorEscalamiento.Y);

            Point C_prima = new Point(C.X * VectorEscalamiento.X, C.Y * VectorEscalamiento.Y);
            Point[] Coordenadas = { A_prima, B_prima, C_prima };
            graphics.Clear(Color.White);
            tb_DibEscalamientoX.Clear();
            tb_DibEscalamientoY.Clear();
            graphics.DrawPolygon(pluma, Coordenadas);


        }
        // TRASLACION DE ELPISE O CIRCULO
        private void btn_DibCirculo_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            Point VectorTraslacionCirculo = new Point(Convert.ToInt32(tb_DibCirculoX.Text), Convert.ToInt32(tb_DibCirculoY.Text));
            graphics.Clear(Color.White);
            tb_DibCirculoX.Clear();
            tb_DibCirculoY.Clear();

            graphics.DrawEllipse(pluma, 200 + VectorTraslacionCirculo.X, 200 + VectorTraslacionCirculo.Y, 20, 20);


        }

        // ----------------------------------- ROTACION -------------------------------------
        int contador = 0;
        private void btn_DibTrianguloRot_Click(object sender, EventArgs e)
        {         
            Point A = new Point(200, 200);
            Point B = new Point(250, 200);
            Point C = new Point(200, 250);


            Point[] Coordenadas = { A, B, C };
            graphics.Clear(Color.White);
            tb_x.Clear();
            tb_y.Clear();
            graphics.DrawPolygon(pluma, Coordenadas);






        }
        private void btn_Rotacion_Click(object sender, EventArgs e)
        {



            int AnguloGrado = Convert.ToInt32(tb_Angulo.Text);

            Point A = new Point(200, 200);
            Point B = new Point(250, 200);
            Point C = new Point(200, 250);

            // Objeto tipo point para obtener los valores de X Y despues de aplicar la formula
            Point Aprima = new Point();
            Point Bprima = new Point();
            Point Cprima = new Point();

            Aprima.X = (Convert.ToInt32(A.X * Math.Cos(AnguloGrado) - A.Y * Math.Sin(AnguloGrado)));
            Aprima.Y = (Convert.ToInt32(A.Y * Math.Cos(AnguloGrado) + A.X * Math.Sin(AnguloGrado)));

            Bprima.X = (Convert.ToInt32(B.X * Math.Cos(AnguloGrado) - B.Y * Math.Sin(AnguloGrado)));
            Bprima.Y = (Convert.ToInt32(B.Y * Math.Cos(AnguloGrado) + B.X * Math.Sin(AnguloGrado)));

            Cprima.X = (Convert.ToInt32(C.X * Math.Cos(AnguloGrado) - C.Y * Math.Sin(AnguloGrado)));
            Cprima.Y = (Convert.ToInt32(C.Y * Math.Cos(AnguloGrado) + C.X * Math.Sin(AnguloGrado)));


            Point[] CoordenadasPrima = { Aprima, Bprima, Cprima };
            Point[] Coordenadas = { A, B, C };



            tb_x.Clear();
            tb_y.Clear();

            graphics.DrawPolygon(pluma, CoordenadasPrima);





        }

        // ------------------------------------ ESCALAMIENTO EN UN PUNTO FIJO ------------------------------------------
        private void btn_EscalamientoPF_Click(object sender, EventArgs e)
        {
            Point VectorEscalamiento = new Point(Convert.ToInt32(tb_EscalamientoPFX.Text), Convert.ToInt32(tb_EscalamientoPFY.Text));

            Point A = new Point(700, 400);
            Point B = new Point(800, 400);
            Point C = new Point(750, 350);

            Point A_Prima = new Point();
            Point B_Prima = new Point();
            Point C_Prima = new Point();

            A_Prima.X = A.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * A.X;
            A_Prima.Y = A.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * A.Y;

            B_Prima.X = B.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * A.X;
            B_Prima.Y = B.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * A.Y;

            C_Prima.X = C.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * A.X;
            C_Prima.Y = C.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * A.Y;

            Point[] Coordenadas = { A_Prima, B_Prima, C_Prima };
            graphics.Clear(Color.White);
            tb_EscalamientoPFX.Clear();
            tb_EscalamientoPFY.Clear();
            graphics.DrawPolygon(pluma, Coordenadas);

        }

        // ----------------------------------- ROTACION EN UN PUNTO FIJO ------------------------------------------------------------------
        int contador2 = 0;
        private void btn_RotacionPF_Click(object sender, EventArgs e)
        {
          
            graphics.FillRectangle(azul, 1, 1, 1, 1);

            int AnguloGrado = Convert.ToInt32(tb_AnguloPA.Text);

            Point A = new Point(-50, -50);
            Point B = new Point(50, -50);
            Point C = new Point(50, 50);
            Point D = new Point(-50, 50);

            Point PA = new Point(1, 1);

            // Objeto tipo point para obtener los valores de X Y despues de aplicar la formula

            Point A_prima = new Point();
            Point B_prima = new Point();
            Point C_prima = new Point();
            Point D_prima = new Point();

            A_prima.X = (Convert.ToInt32(PA.X + (A.X - PA.X * Math.Cos(AnguloGrado) - (A.Y - PA.Y) * Math.Sin(AnguloGrado))));
            A_prima.Y = (Convert.ToInt32(PA.Y + (A.Y - PA.Y * Math.Cos(AnguloGrado) + (A.X - PA.X) * Math.Sin(AnguloGrado))));

            B_prima.X = Convert.ToInt32(PA.X + (B.X - PA.X * Math.Cos(AnguloGrado) - (B.Y - PA.Y) * Math.Sin(AnguloGrado)));
            B_prima.Y = Convert.ToInt32(PA.Y + (B.Y - PA.Y * Math.Cos(AnguloGrado) + (B.X - PA.X) * Math.Sin(AnguloGrado)));


            C_prima.X = Convert.ToInt32(PA.X + (C.X - PA.X * Math.Cos(AnguloGrado) - (C.Y - PA.Y) * Math.Sin(AnguloGrado)));
            C_prima.Y = Convert.ToInt32(PA.Y + (C.Y - PA.Y * Math.Cos(AnguloGrado) + (C.X - PA.X) * Math.Sin(AnguloGrado)));

            D_prima.X = Convert.ToInt32(PA.X + (D.X - PA.X * Math.Cos(AnguloGrado) - (D.Y - PA.Y) * Math.Sin(AnguloGrado)));
            D_prima.Y = Convert.ToInt32(PA.Y + (D.Y - PA.Y * Math.Cos(AnguloGrado) + (D.X - PA.X) * Math.Sin(AnguloGrado)));


            Point[] Coordenadas = { A, B, C, D };
            graphics.Clear(Color.White);
            Point[] CoordenadasPrima = { A_prima, B_prima, C_prima, D_prima };

            tb_x.Clear();
            tb_y.Clear();
            tb_AnguloPA.Clear();
            graphics.DrawPolygon(pluma, Coordenadas);
            graphics.DrawPolygon(pluma, CoordenadasPrima);


        }
        int Contador3 = 0;

        // -------------------------------------- PRACTICA 1 (TEMA 2) ROSA ESCALAMIENTO EN UN PUNTO FIJO --------------------------------------------------------
        private void btn_Practica1_Click(object sender, EventArgs e)
        {
            //Punto 0,0
            graphics.FillRectangle(rojo, 0, 0, 4, 4);
            //Cuadro de referencia
            /*
            Point A = new Point(-100, -100);
            Point B = new Point(100, -100);
            Point C = new Point(100, 100);
            Point D = new Point(-100, 100);
            */
            //Lineas Verticales
            Point CentroAlto = new Point(0, 150);
            Point CentroBajo = new Point(0, -150);
            //Lineas Horizontales
            Point CentroLadoIzq = new Point(-150, 0);
            Point CentroLadoDrch = new Point(150, 0);
            // Linea diagonal Izquierda 1 y 2
            Point LineaDiagonalIzq1 = new Point(-100, -110);
            Point LineaDiagonalIzq2 = new Point(100, 111);
            // Linea diagonal 2
            Point LineaDiagonal2P1 = new Point(100, -111);
            Point LineaDiagonal2P2 = new Point(-100, 111);

            //Linea diagonal 3
            Point LineaDiagonal3P1 = new Point(-140, 55);
            Point LineaDiagonal3P2 = new Point(140, -55);

            //Linea diagonal 4
            Point LineaDiagonal4P1 = new Point(-140, -55);
            Point LineaDiagonal4P2 = new Point(140, 55);

            // Circulo inferior izquierdo
            graphics.DrawEllipse(pluma, -130, -25, 150, 150);
            // Circulo inferior derecho
            graphics.DrawEllipse(pluma, -20, -25, 150, 150);
            // Circulo superior izquierdo
            graphics.DrawEllipse(pluma, -130, -125, 150, 150);
            // Circulo superior derecho 
            graphics.DrawEllipse(pluma, -20, -125, 150, 150);
            // Circulo Centro izquierdo
            graphics.DrawEllipse(pluma, -150, -75, 150, 150);
            // Circulo Centro derecho 
            graphics.DrawEllipse(pluma, 1, -75, 150, 150);
            // Ciirculo Grande 1
            graphics.DrawEllipse(pluma, -150, -150, 300, 300);
            // Circulo Mediano 1
            graphics.DrawEllipse(pluma, -110, -100, 221, 200);
            // Circulo Pequeno 1
            graphics.DrawEllipse(pluma, -50, -50, 100, 100);

            // Linea Diagonal 1
            graphics.DrawLine(pluma, LineaDiagonalIzq1, LineaDiagonalIzq2);
            // Linea Diagonal 2
            graphics.DrawLine(pluma, LineaDiagonal2P1, LineaDiagonal2P2);
            // Linea Diagonal 3
            graphics.DrawLine(pluma, LineaDiagonal3P1, LineaDiagonal3P2);
            // Linea Diagonal 4
            graphics.DrawLine(pluma, LineaDiagonal4P1, LineaDiagonal4P2);

            graphics.DrawLine(pluma, CentroAlto, CentroBajo);
            graphics.DrawLine(pluma, CentroLadoIzq, CentroLadoDrch);
        }

        private void btn_EscalamientoP1_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
          

           // Point VectorEscalamiento = new Point(Convert.ToInt32(tb_EscalamientoRosaX.Text),Convert.ToInt32(tb_EscalamientoRosaY.Text));
            Point VectorEscalamiento = new Point(Convert.ToInt32(tb_EscalamientoRosaX.Text), Convert.ToInt32(tb_EscalamientoRosaY.Text));
            tb_EscalamientoRosaX.Clear();
            tb_EscalamientoRosaY.Clear();

            //Lineas Verticales
            Point CentroAlto = new Point(0, 150);
            Point CentroBajo = new Point(0, -150);

            // Lineas Verticales Aplicando la formula de escalamiento en un punto fijo 

            Point PuntoOrigenLineasVerticales = new Point(0, 150);
            Point PuntoOrigen = new Point(0,0);

            Point CentroAltoE = new Point();
            Point CentroBajoE = new Point();

            CentroAltoE.X = CentroAlto.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            CentroAltoE.Y = CentroAlto.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * PuntoOrigen.Y;

            CentroBajoE.X = CentroBajo.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            CentroBajoE.Y = CentroBajo.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * PuntoOrigen.Y;

            //Lineas Horizontales

            Point PuntoOrigenLineasHorizontales = new Point(-150,0);

            Point CentroLadoIzq = new Point(-150, 0);
            Point CentroLadoDrch = new Point(150, 0);
            
            // Lineas Horizontales Aplicando la formula de escalamiento en un punto fijo

            Point CentroLadoIzqE = new Point();
            Point CentroLadoDrchE = new Point();

            CentroLadoIzqE.X = CentroLadoIzq.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            CentroLadoIzqE.Y = CentroLadoIzq.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * PuntoOrigen.Y;

            CentroLadoDrchE.X = CentroLadoDrch.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            CentroLadoDrchE.Y = CentroLadoDrch.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * PuntoOrigen.Y;       
            
            // Linea diagonal 1
            Point LineaDiagonal1P1 = new Point(-100, -110);
            Point LineaDiagonal12P2 = new Point(100, 111);

            // Lineas Diagonal 1 despues de haber aplicado la formula de el escalamiento en un punto fijo

            Point LineaDiagonal1P1E = new Point();
            Point LineaDiagonal1P2E = new Point();

            LineaDiagonal1P1E.X = LineaDiagonal1P1.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            LineaDiagonal1P1E.Y = LineaDiagonal1P1.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * PuntoOrigen.Y;

            LineaDiagonal1P2E.X = LineaDiagonal12P2.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            LineaDiagonal1P2E.Y = LineaDiagonal12P2.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * PuntoOrigen.Y;
            
            // Linea diagonal 2

            Point LineaDiagonal2P1 = new Point(100, -111);
            Point LineaDiagonal2P2 = new Point(-100, 111);

            // Linea Diagonal 2 Aplicando la formula de escalamiento en un punto fijo

            Point LineaDiagonal2P1E = new Point();
            Point LineaDiagonal2P2E = new Point();

            LineaDiagonal2P1E.X = LineaDiagonal2P1.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            LineaDiagonal2P1E.Y =LineaDiagonal2P1.Y * VectorEscalamiento.Y + (1-VectorEscalamiento.Y) * PuntoOrigen.Y;

            LineaDiagonal2P2E.X = LineaDiagonal2P2.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            LineaDiagonal2P2E.Y = LineaDiagonal2P2.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * PuntoOrigen.Y;
            
            //Linea diagonal 3
            Point LineaDiagonal3P1 = new Point(-140, 55);
            Point LineaDiagonal3P2 = new Point(140, -55);

            //Linea diagonal 3 aplicando la formula de escalamiento en un punto fijo

            Point LineaDiagonal3P1E = new Point();
            Point LineaDiagonal3P2E = new Point();

            LineaDiagonal3P1E.X = LineaDiagonal3P1.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            LineaDiagonal3P1E.Y = LineaDiagonal3P1.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * PuntoOrigen.Y;

            LineaDiagonal3P2E.X = LineaDiagonal3P2.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            LineaDiagonal3P2E.Y = LineaDiagonal3P2.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * PuntoOrigen.Y;
            
            //Linea diagonal 4
            Point LineaDiagonal4P1 = new Point(-140, -55);
            Point LineaDiagonal4P2 = new Point(140, 55);

            // Linea Diagonal 4 despues de haber aplicado la formula de escalamiento en un punto fijo

            Point LineaDiagonal4P1E = new Point();
            Point LineaDiagonal4P2E = new Point();

            LineaDiagonal4P1E.X =LineaDiagonal4P1.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            LineaDiagonal4P1E.Y = LineaDiagonal4P1.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * PuntoOrigen.Y;

            LineaDiagonal4P2E.X = LineaDiagonal4P2.X * VectorEscalamiento.X + (1 - VectorEscalamiento.X) * PuntoOrigen.X;
            LineaDiagonal4P2E.Y = LineaDiagonal4P2.Y * VectorEscalamiento.Y + (1 - VectorEscalamiento.Y) * PuntoOrigen.Y;
            // Circulo inferior izquierdo
            graphics.DrawEllipse(pluma, (-130 * VectorEscalamiento.X)+(1-VectorEscalamiento.X * PuntoOrigen.X), (-25 * VectorEscalamiento.Y) + (1-VectorEscalamiento.Y * PuntoOrigen.Y), (150 * VectorEscalamiento.X + (1-VectorEscalamiento.X * PuntoOrigen.X)), (150 * VectorEscalamiento.Y)+(1-VectorEscalamiento.Y * PuntoOrigen.Y));                       
            // Circulo inferior derecho    
            graphics.DrawEllipse(pluma, (-20 * VectorEscalamiento.X)+(1-VectorEscalamiento.X * PuntoOrigen.X), (-25 * VectorEscalamiento.Y) + (1-VectorEscalamiento.Y * PuntoOrigen.Y), 150*VectorEscalamiento.X, 150*VectorEscalamiento.Y);
            // Circulo superior izquierdo            
            graphics.DrawEllipse(pluma, (-130 * VectorEscalamiento.X)+(1-VectorEscalamiento.X * PuntoOrigen.X), (-125 * VectorEscalamiento.Y) + (1-VectorEscalamiento.Y * PuntoOrigen.Y), 150* VectorEscalamiento.X, 150*VectorEscalamiento.Y);
            // Circulo superior derecho            
            graphics.DrawEllipse(pluma, (-20 * VectorEscalamiento.X) + (1-VectorEscalamiento.X * PuntoOrigen.X), (-125 * VectorEscalamiento.Y) + (1-VectorEscalamiento.Y * PuntoOrigen.Y) , 150 * VectorEscalamiento.X, 150 * VectorEscalamiento.Y);            
            // Circulo Centro izquierdo           
            graphics.DrawEllipse(pluma, (-150 * VectorEscalamiento.X) + (1-VectorEscalamiento.X * PuntoOrigen.X),(-75 * VectorEscalamiento.Y) + (1-VectorEscalamiento.Y * PuntoOrigen.Y), 150 * VectorEscalamiento.X, 150 * VectorEscalamiento.Y);            
            // Circulo Centro derecho 
            graphics.DrawEllipse(pluma, (1 * VectorEscalamiento.X) + (1-VectorEscalamiento.X * PuntoOrigen.X), (-75 * VectorEscalamiento.Y) + (1-VectorEscalamiento.Y * PuntoOrigen.Y), 150 * VectorEscalamiento.X, 150 * VectorEscalamiento.Y);
            // Ciirculo Grande 1
            graphics.DrawEllipse(pluma, (-150 * VectorEscalamiento.X ) + (1-VectorEscalamiento.X * PuntoOrigen.X), (-150 * VectorEscalamiento.Y) + (1-VectorEscalamiento.Y * PuntoOrigen.Y), 300 * VectorEscalamiento.X, 300 * VectorEscalamiento.Y);
            // Circulo Mediano 1
            graphics.DrawEllipse(pluma, (-110 * VectorEscalamiento.X) + (1-VectorEscalamiento.X * PuntoOrigen.X), (-100 * VectorEscalamiento.Y) + (1-VectorEscalamiento.Y * PuntoOrigen.Y), 221* VectorEscalamiento.X, 200 * VectorEscalamiento.Y);
            // Circulo Pequeno 1
            graphics.DrawEllipse(pluma, (-50 * VectorEscalamiento.X) + (1 - VectorEscalamiento.X * PuntoOrigen.X), (-50 * VectorEscalamiento.Y) + (1 - VectorEscalamiento.Y * PuntoOrigen.Y), 100 * VectorEscalamiento.X, 100 * VectorEscalamiento.Y);
            // Linea Diagonal 1
            graphics.DrawLine(pluma, LineaDiagonal1P1E, LineaDiagonal1P2E);
            // Linea Diagonal 2
            graphics.DrawLine(pluma, LineaDiagonal2P1E, LineaDiagonal2P2E);
            // Linea Diagonal 3
            graphics.DrawLine(pluma, LineaDiagonal3P1E, LineaDiagonal3P2E);
            // Linea Diagonal 4
            graphics.DrawLine(pluma, LineaDiagonal4P1E, LineaDiagonal4P2E);
            // Llinea Vertical
            graphics.DrawLine(pluma, CentroAltoE, CentroBajoE);
            // Linea Horizontal
            graphics.DrawLine(pluma, CentroLadoIzqE, CentroLadoDrchE);
        }
       // --------------------------------------  PRACTICA 2 (TEMA 2) TRASLACION DE CUADRADOS --------------------------------
        private void btn_Practica2_Click(object sender, EventArgs e)
        {
            AumentarDisminuir();
        }

        public void AumentarDisminuir ()
        { 
            // Variables para los ciclos
            int i=0;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            //Variables para el cuadro 1
            int VarAux = 0;
            int VarAux2 = 0;
            int SumarAncho = 0;
            int SumarAlto = 0;
            // Variables para el cuadrado 2
            int SumarAncho2 = 0;
            int SumarAlto2 = 0;
            int Var2Aux = 0;
            int Var2Aux2 = 0;
            // Variables para el cuadro 3
            int Var3Aux = 0;
            int Var3Aux3 = 0;
            int SumarAncho3 = 0;
            int SumarAlto3 = 0;
            // Cuadrado 1
            do
            {
                graphics.Clear(Color.White);
                // Cuadrado 1
                graphics.DrawRectangle(pluma, -250 + VarAux, -50 + VarAux2, 50+SumarAncho  , 50+SumarAlto );
                // Cuadrado 2
                graphics.DrawRectangle(pluma, -100 + Var2Aux, -40+ Var2Aux2, 70 + SumarAncho2, 70+SumarAlto2 );
                // Cuadrado 3
                graphics.DrawRectangle(pluma, 50 + Var3Aux, -45 + Var3Aux3, 100 + SumarAncho3, 100 + SumarAlto3);
                // Aumento para el cuadrado 1
                VarAux += 10;
                VarAux2 += -10;
                SumarAlto += 5;
                SumarAncho += 5;
                // Aumento para el cuadrado 2
                Var2Aux += 10;
                Var2Aux2 += -10;
                SumarAncho2 += 5;
                SumarAlto2 += 5;
                // Aumento para el cuadrado 3
                Var3Aux += 10;
                Var3Aux3 += -10;
                SumarAncho3 += 5;
                SumarAlto3 += 5;

                Thread.Sleep(100);
                i++;
                if (i==5)
                {
                    // Restablecimiento de valores cuadro 1
                    VarAux = 0;
                    VarAux2 = 0;
                   
                    // Asignacion de restablecimiento de valores cuadrado 2
                    Var2Aux = 0;
                    Var2Aux2 = 0;
                  
                    // Restableciento los valores del cuadrado 3 a 0
                    Var3Aux = 0;
                    Var3Aux3 = 0;
                    
                    do
                    {
                        graphics.Clear(Color.White);
                        // Cuadrado 1
                        graphics.DrawRectangle(pluma, -200 + VarAux, -100 + VarAux2, 50 + SumarAlto , 50+SumarAncho);
                        // Cuadrado 2
                        graphics.DrawRectangle(pluma, -70 + Var2Aux, -105 + Var2Aux2, 70 + SumarAlto2, 70 + SumarAncho2);
                        // Cuadrado 3
                        graphics.DrawRectangle(pluma, 75 + Var3Aux, -95 + Var3Aux3, 70 + SumarAlto3, 70 + SumarAncho3);
                        // Aumentos para el cuadro 1
                        VarAux += -10;
                        VarAux2 += 10;
                        SumarAlto += -5;
                        SumarAncho += -5;
                        // Aumentos para el cuadro 2
                        Var2Aux += -10;
                        Var2Aux2 += 10;
                        SumarAncho2 += -10;
                        SumarAlto2 += -10;
                        // Aumentos para el cuadro 3
                        Var3Aux += -10;
                        Var3Aux3 += 10;
                        SumarAncho3 += -5;
                        SumarAlto3 += -5;
                        Thread.Sleep(100);
                        
                        a++;
                        
                        if(a==5)
                        {
                            // Restablecimiento de valores para las variables del cuadro 1
                            VarAux = 0;
                            VarAux2 = 0;
                            SumarAlto=0;
                            SumarAncho=0;
                            // Restablecimiento de valores para el cuadro 2
                            VarAux2 = 0;
                            VarAux2 = 0;
                            SumarAlto2 = 0;
                            SumarAncho2 = 0;
                            //  Restablecimiento de valores para el cuadro 3
                            Var3Aux = 0;
                            Var3Aux3 = 0;
                            SumarAncho3 = 0;
                            SumarAlto3 = 0;
                            do
                            {
                                graphics.Clear(Color.White);
                                // Cuadro 1
                                graphics.DrawRectangle(pluma, -250 + VarAux,-50  + VarAux2, 50 + SumarAncho, 50 + SumarAlto);
                                // Cuadro 2
                                graphics.DrawRectangle(pluma, -70 + Var2Aux, -55 + Var2Aux2, 50 + SumarAncho2, 50 + SumarAlto2);
                                // Cuadro 3
                                graphics.DrawRectangle(pluma, 50 + Var3Aux, -40 + Var3Aux3, 70 + SumarAncho3, 70 + SumarAlto3);
                                // Aumentos para el cuadro 1
                                VarAux += 10;
                                VarAux2 += 10;
                                SumarAlto += 5;
                                SumarAncho += 5;
                                // Aumentos para el cuadro 2
                                Var2Aux += 10;
                                Var2Aux2 += 10;
                                SumarAlto2 += 6;
                                SumarAncho2 += 6;
                                // Aumentos para el cuadro 3
                                Var3Aux += 10;
                                Var3Aux3 += 10;
                                SumarAncho3 += 20;
                                SumarAlto3 += 20;
                                Thread.Sleep(100);
                                b++;
                                
                                if (b==5)
                                {
                                    //Restablecimiento de valores para las variables del cuadro 1
                                    VarAux = 0;
                                    VarAux2 = 0;
                                   
                                    // Restablecimiento de valores para las variables del cuadro 2
                                    Var2Aux = 0;
                                    VarAux2 = 0;
                                  
                                    // Restablecimiento de valores para las variables del cuadro 3
                                    Var3Aux = 0;
                                    Var3Aux3 = 0;
                                
                                    do
                                    {
                                        graphics.Clear(Color.White);
                                        // Cuadro 1
                                        graphics.DrawRectangle(pluma, -200 + VarAux, 50 + VarAux2, 70 + SumarAncho, 70 + SumarAlto);
                                        // Cuadro 2
                                        graphics.DrawRectangle(pluma, -50 + Var2Aux, -55 + Var2Aux2, 70 + SumarAncho2, 70 + SumarAlto2);
                                        // Cuadro 3
                                        graphics.DrawRectangle(pluma, 75 + Var3Aux, 30 + Var3Aux3, 70 + SumarAncho3, 70 + SumarAlto3);
                                        // Aumento para el cuadrado 1
                                        VarAux += -10;
                                        VarAux2 += -10;
                                        SumarAlto += -5;
                                        SumarAncho += -5;
                                        // Aumento para el cuadrado 2
                                        Var2Aux += -10;
                                        Var2Aux2 += -10;
                                        SumarAlto2 += -6;
                                        SumarAncho2 += -6;
                                        // Aumento para el caudrado 3
                                        Var3Aux += -10;
                                        Var3Aux3 += -10;
                                        SumarAlto3 += -5;
                                        SumarAncho3 += -5;
                                        Thread.Sleep(100);
                                        c++;
                                    } while (c<5);
                                }
                            } while (b<5) ;                        
                        }
                    } while (a<5);               
                }                    
            }while (i< 5);
        }
       // -----------------------------------------LIMPIAR LA PANTALLA  -------------------------------------------------------------
        private void btn_LimpiarPantalla_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }
        // ------------------------------------------ PRACTICA 3 (TEMA 3) ROTACION DE CUADROS EN UUN PUNTO FIJO CON HILOS --------------------------

        // Declaro las variables tipo Thread (Hilos)
        Thread HiloCuadroNormal;
        Thread HiloCuadroRelleno;
        private void btn_Practica3_Click(object sender, EventArgs e)
        {
           HiloCuadroNormal = new Thread(CuadroNormal);
           HiloCuadroRelleno = new Thread(CuadroRelleno);
           HiloCuadroNormal.Start();
           HiloCuadroRelleno.Start();
          

        }
        public void CuadroNormal()
        {
            graphics.FillRectangle(azul, 1, 1, 1, 1);

            int AnguloGrado = Convert.ToInt32(tb_AnguloPractica.Text);

            Point A = new Point(-50, -50);
            Point B = new Point(50, -50);
            Point C = new Point(50, 50);
            Point D = new Point(-50, 50);

            Point PA = new Point(1, 1);

            // Objeto tipo point para obtener los valores de X Y despues de aplicar la formula

            Point A_prima = new Point();
            Point B_prima = new Point();
            Point C_prima = new Point();
            Point D_prima = new Point();

            for (int i = 0; i < 48; i++)
            {

                Point[] Coordenadas = { A, B, C, D };
               
                A_prima.X = (Convert.ToInt32(PA.X + (A.X - PA.X * Math.Cos(AnguloGrado) - (A.Y - PA.Y) * Math.Sin(AnguloGrado))));
                A_prima.Y = (Convert.ToInt32(PA.Y + (A.Y - PA.Y * Math.Cos(AnguloGrado) + (A.X - PA.X) * Math.Sin(AnguloGrado))));
            
                B_prima.X = Convert.ToInt32(PA.X + (B.X - PA.X * Math.Cos(AnguloGrado) - (B.Y - PA.Y) * Math.Sin(AnguloGrado)));
                B_prima.Y = Convert.ToInt32(PA.Y + (B.Y - PA.Y * Math.Cos(AnguloGrado) + (B.X - PA.X) * Math.Sin(AnguloGrado)));

                C_prima.X = Convert.ToInt32(PA.X + (C.X - PA.X * Math.Cos(AnguloGrado) - (C.Y - PA.Y) * Math.Sin(AnguloGrado)));
                C_prima.Y = Convert.ToInt32(PA.Y + (C.Y - PA.Y * Math.Cos(AnguloGrado) + (C.X - PA.X) * Math.Sin(AnguloGrado)));

                D_prima.X = Convert.ToInt32(PA.X + (D.X - PA.X * Math.Cos(AnguloGrado) - (D.Y - PA.Y) * Math.Sin(AnguloGrado)));
                D_prima.Y = Convert.ToInt32(PA.Y + (D.Y - PA.Y * Math.Cos(AnguloGrado) + (D.X - PA.X) * Math.Sin(AnguloGrado)));
                
                Point[] CoordenadasPrima = { A_prima, B_prima, C_prima, D_prima };
                AnguloGrado -= 1;
                Thread.Sleep(300);

                graphics.Clear(Color.White);


                graphics.DrawPolygon(pluma, CoordenadasPrima);

                if (i==47)
                {
                   graphics.Clear(Color.White);
                   graphics.DrawPolygon(pluma, Coordenadas);
                }
            }

        }
        public void CuadroRelleno()
        {
            graphics.FillRectangle(azul, 1, 1, 1, 1);

            int AnguloGrado2 = Convert.ToInt32(tb_AnguloPractica2.Text);

            Point A2 = new Point(-7, -92);
            Point B2 = new Point(93, -8);
            Point C2 = new Point(9, 92);
            Point D2 = new Point(-91, 8);

            Point PA2 = new Point(1, 1);

            // Objeto tipo point para obtener los valores de X Y despues de aplicar la formula

            Point A_prima2 = new Point();
            Point B_prima2 = new Point();
            Point C_prima2 = new Point();
            Point D_prima2 = new Point();

            for (int i2 = 0; i2 < 48; i2++)
            {

                Point[] Coordenadas2 = { A2, B2, C2, D2 };

                A_prima2.X = (Convert.ToInt32(PA2.X + (A2.X - PA2.X * Math.Cos(AnguloGrado2) - (A2.Y - PA2.Y) * Math.Sin(AnguloGrado2))));
                A_prima2.Y = (Convert.ToInt32(PA2.Y + (A2.Y - PA2.Y * Math.Cos(AnguloGrado2) + (A2.X - PA2.X) * Math.Sin(AnguloGrado2))));

                B_prima2.X = Convert.ToInt32(PA2.X + (B2.X - PA2.X * Math.Cos(AnguloGrado2) - (B2.Y - PA2.Y) * Math.Sin(AnguloGrado2)));
                B_prima2.Y = Convert.ToInt32(PA2.Y + (B2.Y - PA2.Y * Math.Cos(AnguloGrado2) + (B2.X - PA2.X) * Math.Sin(AnguloGrado2)));

                C_prima2.X = Convert.ToInt32(PA2.X + (C2.X - PA2.X * Math.Cos(AnguloGrado2) - (C2.Y - PA2.Y) * Math.Sin(AnguloGrado2)));
                C_prima2.Y = Convert.ToInt32(PA2.Y + (C2.Y - PA2.Y * Math.Cos(AnguloGrado2) + (C2.X - PA2.X) * Math.Sin(AnguloGrado2)));

                D_prima2.X = Convert.ToInt32(PA2.X + (D2.X - PA2.X * Math.Cos(AnguloGrado2) - (D2.Y - PA2.Y) * Math.Sin(AnguloGrado2)));
                D_prima2.Y = Convert.ToInt32(PA2.Y + (D2.Y - PA2.Y * Math.Cos(AnguloGrado2) + (D2.X - PA2.X) * Math.Sin(AnguloGrado2)));

                Point[] CoordenadasPrima2 = { A_prima2, B_prima2, C_prima2, D_prima2 };
                AnguloGrado2 += 1;
                Thread.Sleep(300);

                Point[] PuntoCuadroRelleno = { A_prima2, B_prima2,C_prima2,D_prima2 };
                graphics2.Clear(Color.White);


                graphics2.FillPolygon(azul,PuntoCuadroRelleno);       
                graphics2.DrawPolygon(pluma2, CoordenadasPrima2);


                if (i2 == 47)
                {
                    graphics2.Clear(Color.White);
                    graphics.FillPolygon(azul, Coordenadas2);
                    graphics2.DrawPolygon(pluma2, Coordenadas2);

                    A_prima2 = new Point(-50,-50);
                    B_prima2 = new Point(50,-50);
                    C_prima2 = new Point(50, 50);
                    D_prima2 = new Point(-50,50);

                    Point[] UltimoCuadro = { A_prima2, B_prima2, C_prima2, D_prima2 };
                    graphics2.DrawPolygon(pluma3, UltimoCuadro);


                }
            }

        }
        // -------------------------------------- ASIGNACION DEL PUNTO 0,0 ------------------------------------------
        private void btn_Punto00_Click(object sender, EventArgs e)
        {
            if (Contador3 == 0)
            {
                graphics.TranslateTransform(800, 400);
                graphics2.TranslateTransform(800,400);
                Contador3++;
            }
        }

        private void tb_DibCirculoX_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_AnguloPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_DibCirculoY_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_DibEscalamientoX_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_DibEscalamientoY_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Angulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_EscalamientoPFX_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_EscalamientoPFY_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_y_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Paint_Click(object sender, EventArgs e)
        {
            dlgPaint Form2 = new dlgPaint();
            Form2.Show();
           
        }
    }
    
      
      
}


