using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosApp
{
    class Producto
    {
        private string Nombre;
        private double Precio;
        private int Cantidad;

        public Producto()
        {
            Nombre = string.Empty;
            Precio = 0;
            Cantidad = 0;
        }

        public Producto(string n, double p, int c)
        {
            Nombre = n;
            Precio = p;
            Cantidad = c;
        }

        public string pNombre{
            get { return Nombre; }
            set { Nombre = value; }
        }

        public double pPrecio {
            get { return Precio; }
            set { Precio = value; }
        }

        public int pCantidad {
            get { return Cantidad; }
            set { Cantidad = value; }
        }

        public double calcularImporte()
        {
            return Precio * Cantidad;
        }
    }
}
