using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Arbol_AVL
{
    internal class DibujaAVL
    {
        public AVL Raiz;
        public AVL aux;

        // Constructor.
        public DibujaAVL()
        {
            aux = new AVL();
        }
        public DibujaAVL(AVL RaizNueva)
        {
            Raiz = RaizNueva;
        }

        // Agrega un nuevo valor al arbol.

        public void Insertar(int dato)
        {
            if (Raiz == null)
                Raiz = new AVL(dato, null, null, null);
            else
                Raiz = Raiz.Insertar(dato, Raiz);
        }

        //Eliminar un valor del arbol.
        public void Eliminar(int dato)

        {
            if (Raiz == null)
                Raiz = new AVL(dato, null, null, null);
            else
                Raiz.Eliminar(dato, ref Raiz);
        }

        private const int Radio = 30;
        private const int DistanciaH = 40;
        private const int DistanciaV = 10;

        private int CoordenadaX;
        private int CoordenadaY;

        public void PosicionNodoreocrrido(ref int xmin, ref int ymin)
        {
            CoordenadaY = (int)(ymin + Radio / 2);
            CoordenadaX = (int)(xmin + Radio / 2);
            xmin += Radio;
        }

        public void Colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, AVL Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;

            if (inor == true)
            {
                if (Raiz != null)
                {
                    Colorear(grafo, fuente, Brushes.Blue, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, post, inor, preor);
                    Raiz.Colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(500);
                    Raiz.Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor);
                }
            }
            else if (preor == true)
            {
                if (Raiz != null)
                {
                    Raiz.Colorear(grafo, fuente, Brushes.Yellow, Brushes.Blue, Pens.Black);
                    Thread.Sleep(500);
                    Raiz.Colorear(grafo, fuente, Brushes.White, Brushes.Black, Pens.Black);
                    Colorear(grafo, fuente, Brushes.Blue, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, post, inor, preor);
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor);
                }
            }
            else if (post == true)
            {
                if (Raiz != null)
                {
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, post, inor, preor);
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor);
                    Raiz.Colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(500);
                    Raiz.Colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                }
            }
        }

        public void ColorearB(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, AVL Raiz, int busqueda)
        {
            Brush entorno = Brushes.Red;
            if (Raiz != null)
            {

                Raiz.Colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);

                if (busqueda < Raiz.valor)
                {
                    Thread.Sleep(500);
                    Raiz.Colorear(grafo, fuente, entorno, Brushes.Blue, Lapiz);
                    ColorearB(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, busqueda);
                }
                else
                {
                    if (busqueda > Raiz.valor)
                    {
                        Thread.Sleep(500);
                        Raiz.Colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                        ColorearB(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, busqueda);
                    }
                    else
                    {
                        Raiz.Colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                        Thread.Sleep(500);
                    }
                }
            }
        }
        //Dibuja el arbol.
        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, int dato, Brush encuentro)
        {
            int x = 100;
            int y = 75;
            if (Raiz == null) return;

            //Posicion de todos los nodos.
            Raiz.PosicionNodo(ref x, y);

            //Dibuja los enlaces entre los nodos.
            Raiz.DibujarRamas(grafo, Lapiz);

            //Dibuja todos los nodos. 
            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, dato, encuentro);
        }

        public int x1 = 100;
        public int y2 = 75;
        public void Restablecer_valores()
        {
            x1 = 100;
            y2 = 75;
        }
        public void Buscar(int x)
        {
            if (Raiz == null)
                MessageBox.Show("Arbol AVL Vacio.", "Error", MessageBoxButtons.OK);
            else
                Raiz.Buscar(x, Raiz);
        }
    }
}
