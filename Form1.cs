using AplicativoListas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo.Lista.Circular
{
    public partial class Form1 : Form
    {
        private ListaCircular lista;
        public Form1()
        {
            InitializeComponent();
            lista = new ListaCircular();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = Convert.ToString(txtNombre.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);
            int minimo = Convert.ToInt32(txtMinimo.Text);
            Producto p = new Producto(codigo, nombre, cantidad, precio, minimo);

            lista.Insertar(p);
        }

        private void btnEliminarSegundo_Click(object sender, EventArgs e)
        {
            lista.EliminarSegundo();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            txtReporte.Text = "Nodos: " + lista.Contar();
        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            txtReporte.Text = lista.Reporte();
        }
    }
}
