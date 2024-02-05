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
    public partial class FormProducto : Form
    {
        Producto productoSeleccionado;
        public FormProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Producto> productos = AdoProducto.ListarProducto();

            this.ActualizarDgv(productos);
        }
        private void ActualizarDgv(object objeto)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = objeto;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdoProducto.ObtenerProductoPorId(1);


            string idString = this.textId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);

                Producto productoBuscado = AdoProducto.ObtenerProductoPorId(id);
                List<Producto> lista = new List<Producto>();
                lista.Add(productoBuscado);


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
            AbmProducto frmAlta = new AbmProducto();
            frmAlta.ShowDialog();
            this.Hide();
            Producto producto = frmAlta.ProductoCreado;
            this.Show();
            if (AdoProducto.AgregarProducto(producto))
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
                bool resultado = AdoProducto.BorrarUnProductoPorid(id);

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

            AbmProducto frm = new AbmProducto(this.productoSeleccionado);
            frm.ShowDialog();

            Producto productoModificado = frm.ProductoCreado;

            if (AdoProducto.ActualizarUnProductoPorId(this.productoSeleccionado.Id, productoModificado))
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

                this.productoSeleccionado = dato as Producto;
            }
        }

        
    }
}
