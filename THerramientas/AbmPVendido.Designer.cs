namespace THerramientas
{
    partial class AbmPVendido
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
            label1 = new Label();
            textStock = new TextBox();
            textIdVenta = new TextBox();
            textIdProducto = new TextBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(228, 349);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 36;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(106, 349);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 35;
            buttonOK.Text = "Ok";
            buttonOK.TextAlign = ContentAlignment.TopLeft;
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 118);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 34;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 163);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 33;
            label4.Text = "IdVenta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 75);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 30;
            label1.Text = "IdProducto";
            // 
            // textStock
            // 
            textStock.Location = new Point(215, 115);
            textStock.Name = "textStock";
            textStock.Size = new Size(161, 27);
            textStock.TabIndex = 29;
            textStock.Text = "Ingrese Stock";
            // 
            // textIdVenta
            // 
            textIdVenta.Location = new Point(215, 160);
            textIdVenta.Name = "textIdVenta";
            textIdVenta.Size = new Size(161, 27);
            textIdVenta.TabIndex = 28;
            textIdVenta.Text = "Ingrese IdVenta";
            // 
            // textIdProducto
            // 
            textIdProducto.Location = new Point(215, 73);
            textIdProducto.Name = "textIdProducto";
            textIdProducto.Size = new Size(161, 27);
            textIdProducto.TabIndex = 25;
            textIdProducto.Text = "Ingrese IdProducto";
            // 
            // AbmPVendido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textStock);
            Controls.Add(textIdVenta);
            Controls.Add(textIdProducto);
            Name = "AbmPVendido";
            Text = "AbmPVendido";
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
       
        private TextBox textIdVenta;
        private TextBox textStock;
        private TextBox textIdUsuario;
        private TextBox textIdProducto;
    }
}