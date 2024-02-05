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
    public partial class AbmPVendido : Form
    {
        public AbmPVendido()
        {
            InitializeComponent();
        }

        public AbmPVendido(ProductoVendido productoVendido) : this()
        {
            this.textIdProducto.Text = Convert.ToString(productoVendido.IdProducto);
            this.textStock.Text = Convert.ToString(productoVendido.Stock);
            this.textIdVenta.Text = Convert.ToString(productoVendido.IdVenta);
            
        }
        public ProductoVendido ProductoVendidoCreado { get; private set; }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            ProductoVendido productoVendido = new ProductoVendido() { Stock = Convert.ToInt32(this.textStock.Text), IdProducto = Convert.ToInt32(this.textIdProducto.Text), IdVenta = Convert.ToInt32(textIdVenta.Text) };

            this.ProductoVendidoCreado = productoVendido;

            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
