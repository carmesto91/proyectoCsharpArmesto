﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoHerramientas
{
    internal class ProductoVendido
    {


        private int id;
        private int idProducto;
        private int stock;
        private int idVenta;

        public int Id { get { return id; } set { id = value; } }
        public int IdProducto { get { return idProducto; } set { idProducto = value; } }
        public int Stock { get { return stock; } set { stock = value; } }
        public int IdVenta { get { return idVenta; } set { idVenta = value; } }

        public ProductoVendido()
        {
            this.id = 0;
            this.idProducto = 0;
            this.stock = 0;
            this.idVenta = 0;
        }

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;
        }
    }
}