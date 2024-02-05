using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THerramientas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario frmUsu = new FormUsuario();
            frmUsu.ShowDialog();

        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            FormProducto frmProducto = new FormProducto();
            frmProducto.ShowDialog();
        }

        private void BtnPVendido_Click(object sender, EventArgs e)
        {
            FormPVendido frmPVendido = new FormPVendido();
            frmPVendido.ShowDialog();

        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            FormVenta frmVenta = new FormVenta();
            frmVenta.ShowDialog();
        }
    }
}
