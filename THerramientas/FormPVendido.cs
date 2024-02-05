using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THerramientas.database;
using THerramientas.modelo;

namespace THerramientas
{
    public partial class FormPVendido : Form
    {
        ProductoVendido productoVendidoSeleccionado;
        public FormPVendido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ProductoVendido> productosVendidos = AdoProductoVendido.ListarProductoVendido();

            this.ActualizarDgv(productosVendidos);
        }
        private void ActualizarDgv(object objeto)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = objeto;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdoProductoVendido.ObtenerProductoVendidoPorId(1);


            string idString = this.textId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);

                ProductoVendido productoVendidoBuscado = AdoProductoVendido.ObtenerProductoVendidoPorId(id);
                List<ProductoVendido> lista = new List<ProductoVendido>();
                lista.Add(productoVendidoBuscado);


                this.ActualizarDgv(lista);

            }
            else
            {
                MessageBox.Show("Complete Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textId.Focus();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmPVendido frmAlta = new AbmPVendido();
            frmAlta.ShowDialog();
            this.Hide();
            ProductoVendido productoVendido = frmAlta.ProductoVendidoCreado;
            this.Show();
            if (AdoProductoVendido.AgregarProductoVendido(productoVendido))
            {
                MessageBox.Show("Agregue un Producto", "Alta");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string idString = this.textId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);
                bool resultado = AdoProductoVendido.BorrarUnProductoVendidoPorid(id);

                if (resultado)
                {
                    MessageBox.Show("Borre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Complete Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textId.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            AbmPVendido frm = new AbmPVendido(this.productoVendidoSeleccionado);
            frm.ShowDialog();

            ProductoVendido productoVendidoModificado = frm.ProductoVendidoCreado;

            if (AdoProductoVendido.ActualizarUnProductoVendidoPorId(this.productoVendidoSeleccionado.Id, productoVendidoModificado))
            {
                MessageBox.Show("Actualice", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = this.dataGridView1.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;

                this.productoVendidoSeleccionado = dato as ProductoVendido;
            }
        }


    }
}
