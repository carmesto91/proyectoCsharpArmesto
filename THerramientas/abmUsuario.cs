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
    public partial class abmUsuario : Form
    {
        public abmUsuario()
        {
            InitializeComponent();
        }
        public abmUsuario(Usuario usuario) : this()
        {
            this.textNombre.Text = usuario.Nombre;
            this.textApellido.Text = usuario.Apellido;
            this.textMail.Text = usuario.Mail;
            this.textNUsuario.Text = usuario.NombreUsuario;
            this.textPassword.Text = usuario.Password;
        }
        public Usuario UsuarioCreado { get; private set; }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario() { Apellido = this.textApellido.Text, Nombre = this.textNombre.Text, Password = this.textPassword.Text, NombreUsuario = textNUsuario.Text, Mail = this.textMail.Text };

            this.UsuarioCreado = usuario;

            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

