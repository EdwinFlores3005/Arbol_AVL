using Arbol_AVL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Arbol_AVL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cont = 0;
        int dato = 0;
        int datb = 0;
        int cont2 = 0;

        DibujaAVL arbolAVL = new DibujaAVL();
        DibujaAVL arbolAVL_Letra = new DibujaAVL();
        Graphics g;

        //No olvidar generar el evento Paint que es importante para dibujar en el form.
        private void Form1_Paint(object sender, PaintEventArgs en)
        {
            en.Graphics.Clear(this.BackColor);
            en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = en.Graphics;

            arbolAVL.DibujarArbol(g, this.Font, Brushes.White, Brushes.Black, Pens.White, datb, Brushes.Black);
            datb = 0;

            if (pintaR == 1)
            {
                arbolAVL.Colorear(g, this.Font, Brushes.Black, Brushes.Yellow, Pens.Blue, arbolAVL.Raiz, post.Checked, ino.Checked, pre.Checked);
                pintaR = 0;
            }
            if (pintaR == 2)
            {
                arbolAVL.ColorearB(g, this.Font, Brushes.White, Brushes.Red, Pens.White, arbolAVL.Raiz, int.Parse(valor.Text));
                pintaR = 0;
            }
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            errores.Clear();
            if (valor.Text == "")
            {
                errores.SetError(valor, "Valor obligatorio.");
            }
            else
            {
                try
                {
                    dato = int.Parse(valor.Text);

                    arbolAVL.Insertar(dato);
                    valor.Clear();
                    valor.Focus();
                    lblaltura.Text = arbolAVL.Raiz.GetAltura(arbolAVL.Raiz).ToString();
                    cont++;
                    Refresh();
                    Refresh();
                }
                catch (Exception ex)
                {
                    errores.SetError(valor, "Debe ser numérico.");
                }
            }
        }

        int pintaR = 0;
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            errores.Clear();
            if (valor.Text == "")
            {
                errores.SetError(valor, "Valor obligatorio.");
            }
            else
            {
                try
                {
                    datb = int.Parse(valor.Text);
                    arbolAVL.Buscar(datb);
                    pintaR = 2;
                    Refresh();
                    valor.Clear();

                }
                catch (Exception ex)
                {
                    errores.SetError(valor, "Debe ser numérico.");
                }
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            errores.Clear();
            if (valor.Text == "")
            {
                errores.SetError(valor, "Valor obligatorio.");
            }
            else
            {
                try
                {
                    dato = int.Parse(valor.Text);
                    valor.Clear();
                    arbolAVL.Eliminar(dato);
                    lblaltura.Text = arbolAVL.Raiz.GetAltura(arbolAVL.Raiz).ToString();
                    Refresh();
                    Refresh();
                    cont2++;
                }
                catch (Exception ex)
                {
                    errores.SetError(valor, "Debe ser numérico.");
                }
            }
            Refresh(); Refresh(); Refresh();
        }

        //Al presionar enter se realizan las operaciones.
        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                errores.Clear();
                if (valor.Text == "")
                {
                    errores.SetError(valor, "Valor obligatorio.");
                }
                else
                {
                    try
                    {
                        dato = int.Parse(valor.Text);
                        if (dato > 0)
                        {
                            arbolAVL.Insertar(dato);
                            valor.Clear();
                            valor.Focus();
                            lblaltura.Text = arbolAVL.Raiz.GetAltura(arbolAVL.Raiz).ToString();
                            cont++;
                            Refresh();
                            Refresh();
                        }
                        else
                        {
                            errores.SetError(valor, "Debe ser un numero mayor que 0.");
                        }
                    }
                    catch (Exception ex)
                    {
                        errores.SetError(valor, "Debe ser numérico.");
                    }
                }
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
