using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THerramientas.modelo;

namespace THerramientas
{
    public partial class AbmProducto : Form
    {
        public AbmProducto()
        {
            InitializeComponent();
        }

        public AbmProducto(Producto producto) : this()
        {
            this.textDescripcion.Text = producto.Descripcion;
            this.textCosto.Text = Convert.ToString(producto.Costo);
            this.textIdUsuario.Text = Convert.ToString(producto.IdUsuario);
            this.textPVenta.Text = Convert.ToString(producto.PrecioVenta);
            this.textStock.Text = Convert.ToString(producto.Stock);
        }
        public Producto ProductoCreado { get; private set; }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto() { Costo = Convert.ToDouble(this.textCosto.Text), Descripcion = this.textDescripcion.Text, Stock = Convert.ToInt32(this.textStock.Text), PrecioVenta = Convert.ToDouble(textPVenta.Text), IdUsuario = Convert.ToInt32(this.textIdUsuario.Text) };

            this.ProductoCreado = producto;

            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
    }
}
