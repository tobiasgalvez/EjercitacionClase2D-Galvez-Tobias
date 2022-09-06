using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Producto
    {
        string nombre;
        float precio;
        private int codigoDeProducto;

        public Producto(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public Producto(string nombre, float precio, int codigoDeProducto)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.codigoDeProducto = codigoDeProducto;
            codigoDeProducto++;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public float Precio { get { return precio; } }

        public int CodigoDeProducto { get { return codigoDeProducto; } }

    }
}
