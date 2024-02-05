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
    public partial class FormVenta : Form
    {
        Venta ventasSeleccionado;
        public FormVenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Venta> ventas = AdoVenta.ListarVentas();

            this.ActualizarDgv(ventas);
        }
        private void ActualizarDgv(object objeto)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = objeto;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdoVenta.ObtenerVentaPorId(1);


            string idString = this.textId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);

                Venta ventaBuscada = AdoVenta.ObtenerVentaPorId(id);
                List<Venta> lista = new List<Venta>();
                lista.Add(ventaBuscada);


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
            AbmVenta frmAlta = new AbmVenta();
            frmAlta.ShowDialog();
            this.Hide();
            Venta venta = frmAlta.VentaCreado;
            this.Show();
            if (AdoVenta.AgregarVenta(venta))
            {
                MessageBox.Show("Agregue un venta", "Alta");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string idString = this.textId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);
                bool resultado = AdoVenta.BorrarUnaVentaPorid(id);

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

            AbmVenta frm = new AbmVenta(this.ventasSeleccionado);
            frm.ShowDialog();

            Venta ventaModificado = frm.VentaCreado;

            if (AdoVenta.ActualizarUnaVentaPorId(this.ventasSeleccionado.Id, ventaModificado))
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

                this.ventasSeleccionado = dato as Venta;
            }
        }


    }
}
