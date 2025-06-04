namespace AplicativoListas
{
    public class Producto
    {
        private int codigo;
        private string nombre;
        private int cantidad;
        private double precio;
        private double descuento;
        private int minimo;
        public Producto(int codigo, string nombre, int cantidad, double precio, int minimo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
            this.minimo = minimo;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public int Minimo
        {
            get { return minimo; }
            set { minimo = value; }
        }

    }
}
