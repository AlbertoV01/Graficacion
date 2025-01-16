using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficacion
{
    public partial class dlgPaint : Form
    {
        public dlgPaint()
        {
            InitializeComponent();
        }

        // DECLARACION DE TODAS LAS VARIABLE GLOBALES 
        int Aumentar=6;
        Point Linea;
        Point Linea2;
        Color ColorActivo = new Color();// sEGUN EL BOTON QUE SE PRESIONE CAMBIARA DE COLOR O VALOR 
        Graphics graphics;
        Point TrianguloP1 = new Point();
        Point TrianguloP2= new Point();
        Point TrianguloP3 = new Point();
        Point[] Triangulo;
        // VARIABLE PARA INDICAR QUE VAMOS A PINTAR AL DAR CLIC
        Boolean EscribirLapiz=false;
        Boolean Clic = false;
        int LineaGrosor=4;
        // VARIABLE QUE NOS DIRA QUE OPERACION SE DESEA REALIZAR
        string Acccion;

        // COORDEANADA CUADRADO 
        Point CoordenadaCuadrado;
        Point CoordenadaCuadrado2;
        Point DibujarCuadrado;

        //VARIABLE PARA SABER SI ESTA SELECCIONADO UN COLOR
        Boolean ColorSeleccion = false;


        // iNICIALIZAMOS LA VARIABLE GRAPHICS PARA INDICARLE QUE VAMOS A PINTAR EN EL PANEL 1
        private void dlgPaint_Load(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
        }

        private void btn_Rojo_Click(object sender, EventArgs e)
        {
            ColorActivo = Color.Red;
            ColorSeleccion = true;
        }

        private void pb_Balde_Click(object sender, EventArgs e)
        {  
            //if (ColorActivo == null)
            //{
            //    MessageBox.Show("Selecciona un color antes de pintar");
            //}
            graphics.Clear(ColorActivo);
        }
        // EVENTO DEL PANEL PARA MOVER EL MOUSE
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            switch (Acccion) 
            {
                case "Lapiz":

                        if (EscribirLapiz == true)
                        {
                        if (Clic)
                            {
                                graphics = panel1.CreateGraphics();
                                
                                graphics.FillEllipse(new SolidBrush(ColorActivo), e.X, e.Y, LineaGrosor, LineaGrosor);
                                graphics.Dispose();
                            }                       
                        }
                    break;
                case "Rectangulo":
                    if (CoordenadaCuadrado.X !=0  && CoordenadaCuadrado.Y != 0)
                    {
                        graphics = panel1.CreateGraphics();
                        graphics.TranslateTransform(0,0);
                        CoordenadaCuadrado2.X /= 10;
                        CoordenadaCuadrado2.Y /= 10;
                        graphics.DrawRectangle(new Pen(ColorActivo, LineaGrosor), CoordenadaCuadrado.X, CoordenadaCuadrado.Y, CoordenadaCuadrado.X + CoordenadaCuadrado2.Y , CoordenadaCuadrado.Y+CoordenadaCuadrado2.X);
                        // e.Y = 0;
                        CoordenadaCuadrado.X = 0;
                        CoordenadaCuadrado.Y = 0;
                    } 
                    else
                    {

                    }
                    break;
                case "Circulo":
                    if (CoordenadaCuadrado.X != 0 && CoordenadaCuadrado.Y !=0)
                    {
                        graphics = panel1.CreateGraphics();
                       
                        graphics.DrawEllipse(new Pen(ColorActivo, LineaGrosor), CoordenadaCuadrado.X, CoordenadaCuadrado.Y, Aumentar,Aumentar);
                        CoordenadaCuadrado.X = 0;
                        CoordenadaCuadrado.Y = 0;
                    } 
                    break;
                case "Borrador":
                    if (EscribirLapiz==true)
                    {
                            ColorActivo = Color.White;
                            graphics = panel1.CreateGraphics();
                            graphics.FillEllipse(new SolidBrush(ColorActivo), e.X, e.Y, LineaGrosor, LineaGrosor);
                            graphics.Dispose();                  
                    }    
                    break;
                case "Linea":
                    if (Linea.X != 0 && Linea.Y != 0)
                    {
                        if (Clic)
                        {
                      
                            if (Linea2.X != 0 && Linea2.Y != 0)
                            {
                                graphics.DrawLine(new Pen(ColorActivo, LineaGrosor), Linea, Linea2);
                            }
                            Linea.X = 0;
                            Linea.Y = 0;
                        }
                    }
                    break;
                case "Triangulo":

                    if (TrianguloP1.Y != 0 && TrianguloP1.X != 0)
                    {
                        if (Clic)
                        {
                            
                                
                            if (TrianguloP2.X != 0 && TrianguloP2.Y!=0)
                            {
                                if (TrianguloP3.X != 0)
                                {

                                    Point[] Triangulo = { TrianguloP1, TrianguloP2, TrianguloP3 };

                                    graphics.DrawPolygon(new Pen(ColorActivo, LineaGrosor), Triangulo);
                                    TrianguloP1.X = 0;
                                    TrianguloP1.Y = 0;
                                    TrianguloP2.X = 0;
                                    TrianguloP2.Y = 0;
                                    
                                }                                   
                                
                                
                            }
                                
                            
                        }  
                    }



                    break;
            }
        }
        // EEVENTO CLIC PARA CAMBIAR LA VARIABLE A VERDADERO
        private void pb_Lapiz_Click(object sender, EventArgs e)
        {
            Acccion = "Lapiz";
            EscribirLapiz = true;
        }
        // EVENTO PARA PRESIONAR EL CLI Y PINTAR HASTA QUE SE VUELVA A PRESIONAR EL CLIC
        private void panel1_Click(object sender, EventArgs e)
        {
            switch (Acccion)
            {
                case "Lapiz":

                    if (Clic == true)
                        Clic = false;
                    else
                        Clic = true;
                    break;
                case "Rectangulo":

                    if (Clic == true)
                        Clic = false;
                    else
                        Clic = true;

                    break;
                case "Circulo":

                    if (Clic == true)
                        Clic = false;
                    else
                        Clic = true;
                    break;
                case "Linea":
                    if (Clic == true)
                        Clic = false;
                    else
                        Clic = true;
                    break;
                case "Triangulo":
                    if (Clic == true)
                        Clic = false;
                    else
                        Clic = true;
                    break;
            }
        }

        private void btn_Azul_Click(object sender, EventArgs e)
        {
            ColorActivo = Color.Blue;
        }

        private void btn_Verde_Click(object sender, EventArgs e)
        {
            ColorActivo = Color.Green;
        }

        private void btn_Amarillo_Click(object sender, EventArgs e)
        {
            ColorActivo = Color.Yellow;
        }
        // CAMBIA EL GROSOR DE LA LINEA DEL LAPIZ CADA VEZ QUE OCURRA UN CLIC EN LA PICTURE BOX. ESTO CON 15 TAMA;OS DISTINTOS DE LINEA
        private void pb_LineaGrosor_Click(object sender, EventArgs e)
        {

            LineaGrosor += 1;
            if (LineaGrosor == 15)

                LineaGrosor = 4;

            
        }

        private void pb_Cuadrado_Click(object sender, EventArgs e)
        {
            CoordenadaCuadrado.X = 0;
            CoordenadaCuadrado.Y = 0;
            Acccion = "Rectangulo";
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ColorSeleccion == true)
            {
                if (CoordenadaCuadrado.X == 0)
                {
                    CoordenadaCuadrado.X = 0;
                    CoordenadaCuadrado.Y = 0;
                    CoordenadaCuadrado.X = e.X;
                    CoordenadaCuadrado.Y = e.Y;
                    //    Clic = false;
                    CoordenadaCuadrado2.Y = e.Y;
                    CoordenadaCuadrado2.X = e.X;

                }
                else
                {
                }
                if (Linea.X==0 && Linea.Y==0) 
                {
                    Linea.X = e.X;
                    Linea.Y = e.Y;
                }
                else
                {
                    Linea2.X = e.X;
                    Linea2.Y = e.Y;
                }
                // TRIANGULO
                if (TrianguloP1.X == 0)
                {
                    TrianguloP1.X = e.X;
                    TrianguloP1.Y = e.Y;
                }
               else  
                {
                    TrianguloP2.X = e.X;
                    TrianguloP2.Y = e.Y;
                }
                //if (TrianguloP3.X==0)
                //{
                //    TrianguloP3.X = 200;
                //    TrianguloP3.Y = 300;
                //}
           
              
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
        }

        private void pb_Circulo_Click(object sender, EventArgs e)
        {
            CoordenadaCuadrado.X = 0;
            CoordenadaCuadrado.Y = 0;
            Acccion = "Circulo";
           
        }
        // AUMENTAR EL TAMA;O DEL CIRCULO

        private void btn_Aumentar_Click(object sender, EventArgs e)
        {
            Aumentar += 10;
        }
        // DISMINUIR EL TAMA;O DEL CIRCULO
        private void btn_Disminuir_Click(object sender, EventArgs e)
        {
            Aumentar -= 10;
        }

        private void pb_Borrador_Click(object sender, EventArgs e)
        {
            Acccion = "Borrador";
            EscribirLapiz = true;
        }

        private void pb_Linea_Click(object sender, EventArgs e)
        {
            

            EscribirLapiz = true;
            Acccion = "Linea";

        }

        private void pb_Triangulo_Click(object sender, EventArgs e)
        {
            EscribirLapiz = true;
            Acccion = "Triangulo";
        }
    }
}
