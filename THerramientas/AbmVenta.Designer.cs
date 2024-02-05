namespace THerramientas
{
    partial class AbmVenta
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
            label1 = new Label();
            textidUsuario = new TextBox();
            textComentarios = new TextBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(201, 159);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 44;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(79, 159);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 43;
            buttonOK.Text = "Ok";
            buttonOK.TextAlign = ContentAlignment.TopLeft;
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 92);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 42;
            label5.Text = "IdUsuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 49);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 40;
            label1.Text = "Comentarios";
            // 
            // textidUsuario
            // 
            textidUsuario.Location = new Point(182, 89);
            textidUsuario.Name = "textidUsuario";
            textidUsuario.Size = new Size(161, 27);
            textidUsuario.TabIndex = 39;
            textidUsuario.Text = "Ingrese IdUsuario";
            // 
            // textComentarios
            // 
            textComentarios.Location = new Point(182, 47);
            textComentarios.Name = "textComentarios";
            textComentarios.Size = new Size(161, 27);
            textComentarios.TabIndex = 37;
            textComentarios.Text = "Ingrese Comentarios";
            // 
            // AbmVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 246);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textidUsuario);
            Controls.Add(textComentarios);
            Name = "AbmVenta";
            Text = "AbmVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonOK;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox textidUsuario;
        private TextBox textIdVenta;
        private TextBox textComentarios;
    }
}