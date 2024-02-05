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
    public partial class AbmVenta : Form
    {
        public AbmVenta()
        {
            InitializeComponent();
        }

        public AbmVenta(Venta venta) : this()
        {
            this.textComentarios.Text = venta.Comentarios;
            this.textidUsuario.Text = Convert.ToString(venta.IdUsuario);
            }
        public Venta VentaCreado { get; private set; }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta() {Comentarios = this.textComentarios.Text, IdUsuario = Convert.ToInt32(this.textidUsuario.Text) };

            this.VentaCreado = venta;

            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
