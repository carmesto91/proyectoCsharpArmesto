using THerramientas.database;
using THerramientas.modelo;

namespace THerramientas
{
    public partial class FormUsuario : Form
    {
        Usuario usuarioSeleccionado;
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios =AdoUsuario.ListarUsuarios();

            this.ActualizarDgv(usuarios);
        }
        private void ActualizarDgv(object objeto)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = objeto;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdoUsuario.ObtenerUsuarioPorId(1);
        
        
            string idString = this.textId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);

                Usuario usuarioBuscado = AdoUsuario.ObtenerUsuarioPorId(id);
                List<Usuario> lista = new List<Usuario>();
                lista.Add(usuarioBuscado);


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
            abmUsuario frmAlta = new abmUsuario();
            frmAlta.ShowDialog();
            this.Hide();
            Usuario usuario = frmAlta.UsuarioCreado;
            this.Show();
            if (AdoUsuario.AgregarUsuario(usuario))
            {
                MessageBox.Show("Agregue un usuario", "Alta");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string idString = this.textId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);
                bool resultado = AdoUsuario.BorrarUnUsuarioPorid(id);

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

            abmUsuario frm = new abmUsuario(this.usuarioSeleccionado);
            frm.ShowDialog();

            Usuario usuarioModificado = frm.UsuarioCreado;

            if (AdoUsuario.ActualizarUnUsuarioPorId( this.usuarioSeleccionado.Id, usuarioModificado))
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

                this.usuarioSeleccionado = dato as Usuario;
            }
        }
    }
}
