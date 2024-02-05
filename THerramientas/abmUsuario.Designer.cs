namespace THerramientas
{
    partial class abmUsuario
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
            textNombre = new TextBox();
            textMail = new TextBox();
            textPassword = new TextBox();
            textNUsuario = new TextBox();
            textApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonOK = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.Location = new Point(209, 48);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(161, 27);
            textNombre.TabIndex = 0;
            textNombre.Text = "Ingrese Nombre";
            // 
            // textMail
            // 
            textMail.Location = new Point(209, 226);
            textMail.Name = "textMail";
            textMail.Size = new Size(161, 27);
            textMail.TabIndex = 2;
            textMail.Text = "Ingrese Mail";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(209, 180);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(161, 27);
            textPassword.TabIndex = 3;
            textPassword.Text = "Ingrese Password";
            // 
            // textNUsuario
            // 
            textNUsuario.Location = new Point(209, 135);
            textNUsuario.Name = "textNUsuario";
            textNUsuario.Size = new Size(161, 27);
            textNUsuario.TabIndex = 4;
            textNUsuario.Text = "Ingrese Nombre Usuario";
            // 
            // textApellido
            // 
            textApellido.Location = new Point(209, 90);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(161, 27);
            textApellido.TabIndex = 5;
            textApellido.Text = "Ingrese Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 229);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 7;
            label2.Text = "Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 185);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 138);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 9;
            label4.Text = "NombreUsuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 93);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 10;
            label5.Text = "Apellido";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(100, 324);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 11;
            buttonOK.Text = "Ok";
            buttonOK.TextAlign = ContentAlignment.TopLeft;
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(222, 324);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // abmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 391);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textApellido);
            Controls.Add(textNUsuario);
            Controls.Add(textPassword);
            Controls.Add(textMail);
            Controls.Add(textNombre);
            Name = "abmUsuario";
            Text = "abmUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNombre;
        private TextBox textMail;
        private TextBox textPassword;
        private TextBox textNUsuario;
        private TextBox textApellido;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonOK;
        private Button buttonCancel;
    }
}