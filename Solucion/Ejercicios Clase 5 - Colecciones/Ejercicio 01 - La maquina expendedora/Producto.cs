namespace Ejercicio_01___La_maquina_expendedora
{
    public class Producto
    {
        string nombre;
        float precio;

        public Producto(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public float Precio { get { return precio; } }
    }
}