using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoHerramientas
{
    internal class Venta
    {
        private int id;
        private string comentarios; 
        private int idUsuario; 

        public int Id {  get { return id; } set { id = value; } }
        public string Comentarios { get { return comentarios; } set { comentarios = value; } }
        public int IdUsuario { get { return idUsuario; }set{ idUsuario = value; } }

        public Venta()
        {
            this.id = 0;
            this.comentarios = string.Empty;
            this.idUsuario = 0;
        }
        public Venta(int id, string comentarios, int idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }
    }
}
