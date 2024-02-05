namespace THerramientas
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnUsuario = new Button();
            BtnVenta = new Button();
            BtnPVendido = new Button();
            BtnProducto = new Button();
            SuspendLayout();
            // 
            // BtnUsuario
            // 
            BtnUsuario.Location = new Point(54, 40);
            BtnUsuario.Name = "BtnUsuario";
            BtnUsuario.Size = new Size(121, 49);
            BtnUsuario.TabIndex = 0;
            BtnUsuario.Text = "Usuario";
            BtnUsuario.UseVisualStyleBackColor = true;
            BtnUsuario.Click += BtnUsuario_Click;
            // 
            // BtnVenta
            // 
            BtnVenta.Location = new Point(271, 144);
            BtnVenta.Name = "BtnVenta";
            BtnVenta.Size = new Size(133, 45);
            BtnVenta.TabIndex = 1;
            BtnVenta.Text = "Venta";
            BtnVenta.UseVisualStyleBackColor = true;
            BtnVenta.Click += BtnVenta_Click;
            // 
            // BtnPVendido
            // 
            BtnPVendido.Location = new Point(54, 144);
            BtnPVendido.Name = "BtnPVendido";
            BtnPVendido.Size = new Size(121, 62);
            BtnPVendido.TabIndex = 2;
            BtnPVendido.Text = "Producto Vendido";
            BtnPVendido.UseVisualStyleBackColor = true;
            BtnPVendido.Click += BtnPVendido_Click;
            // 
            // BtnProducto
            // 
            BtnProducto.Location = new Point(271, 40);
            BtnProducto.Name = "BtnProducto";
            BtnProducto.Size = new Size(133, 49);
            BtnProducto.TabIndex = 3;
            BtnProducto.Text = "Producto";
            BtnProducto.UseVisualStyleBackColor = true;
            BtnProducto.Click += BtnProducto_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 251);
            Controls.Add(BtnProducto);
            Controls.Add(BtnPVendido);
            Controls.Add(BtnVenta);
            Controls.Add(BtnUsuario);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnUsuario;
        private Button BtnVenta;
        private Button BtnPVendido;
        private Button BtnProducto;
    }
}