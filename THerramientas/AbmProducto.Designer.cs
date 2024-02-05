namespace THerramientas
{
    partial class AbmProducto
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
            buttonCancel = new Button();
            buttonOK = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textCosto = new TextBox();
            textPVenta = new TextBox();
            textStock = new TextBox();
            textIdUsuario = new TextBox();
            textDescripcion = new TextBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(195, 321);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 24;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(73, 321);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 23;
            buttonOK.Text = "Ok";
            buttonOK.TextAlign = ContentAlignment.TopLeft;
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 90);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 22;
            label5.Text = "Costo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 135);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 21;
            label4.Text = "Precio Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 182);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 20;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 226);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 19;
            label2.Text = "IdUsuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 47);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 18;
            label1.Text = "Descripcion";
            // 
            // textCosto
            // 
            textCosto.Location = new Point(182, 87);
            textCosto.Name = "textCosto";
            textCosto.Size = new Size(161, 27);
            textCosto.TabIndex = 17;
            textCosto.Text = "Ingrese Costo";
            // 
            // textPVenta
            // 
            textPVenta.Location = new Point(182, 132);
            textPVenta.Name = "textPVenta";
            textPVenta.Size = new Size(161, 27);
            textPVenta.TabIndex = 16;
            textPVenta.Text = "Ingrese Precio Venta";
            // 
            // textStock
            // 
            textStock.Location = new Point(182, 177);
            textStock.Name = "textStock";
            textStock.Size = new Size(161, 27);
            textStock.TabIndex = 15;
            textStock.Text = "Ingrese Stock";
            // 
            // textIdUsuario
            // 
            textIdUsuario.Location = new Point(182, 223);
            textIdUsuario.Name = "textIdUsuario";
            textIdUsuario.Size = new Size(161, 27);
            textIdUsuario.TabIndex = 14;
            textIdUsuario.Text = "Ingrese IdUsuario";
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(182, 45);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(161, 27);
            textDescripcion.TabIndex = 13;
            textDescripcion.Text = "Ingrese Descripcion";
            // 
            // AbmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 411);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textCosto);
            Controls.Add(textPVenta);
            Controls.Add(textStock);
            Controls.Add(textIdUsuario);
            Controls.Add(textDescripcion);
            Name = "AbmProducto";
            Text = "AbmProducto";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonOK;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textCosto;
        private TextBox textPVenta;
        private TextBox textStock;
        private TextBox textIdUsuario;
        private TextBox textDescripcion;
    }
}