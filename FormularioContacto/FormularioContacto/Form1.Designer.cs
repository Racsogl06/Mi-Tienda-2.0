namespace FormularioContacto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EtiquetaNombre = new Label();
            EtiquetaEmail = new Label();
            EtiquetaMensaje = new Label();
            TextBoxNombre = new TextBox();
            TextBoxEmail = new TextBox();
            TextBoxMensaje = new TextBox();
            ButtonEnviar = new Button();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Location = new Point(62, 84);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(64, 20);
            EtiquetaNombre.TabIndex = 0;
            EtiquetaNombre.Text = "Nombre";
            EtiquetaNombre.Click += label1_Click;
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.Location = new Point(62, 209);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(132, 20);
            EtiquetaEmail.TabIndex = 1;
            EtiquetaEmail.Text = "Correo Electronico";
            // 
            // EtiquetaMensaje
            // 
            EtiquetaMensaje.AutoSize = true;
            EtiquetaMensaje.Location = new Point(62, 303);
            EtiquetaMensaje.Name = "EtiquetaMensaje";
            EtiquetaMensaje.Size = new Size(64, 20);
            EtiquetaMensaje.TabIndex = 2;
            EtiquetaMensaje.Text = "Mensaje";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(62, 121);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(125, 27);
            TextBoxNombre.TabIndex = 3;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(62, 246);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(125, 27);
            TextBoxEmail.TabIndex = 4;
            // 
            // TextBoxMensaje
            // 
            TextBoxMensaje.Location = new Point(62, 340);
            TextBoxMensaje.Multiline = true;
            TextBoxMensaje.Name = "TextBoxMensaje";
            TextBoxMensaje.Size = new Size(423, 82);
            TextBoxMensaje.TabIndex = 5;
            // 
            // ButtonEnviar
            // 
            ButtonEnviar.Location = new Point(645, 340);
            ButtonEnviar.Name = "ButtonEnviar";
            ButtonEnviar.Size = new Size(94, 29);
            ButtonEnviar.TabIndex = 6;
            ButtonEnviar.Text = "Enviar";
            ButtonEnviar.UseVisualStyleBackColor = true;
            ButtonEnviar.Click += ButtonEnviar_Click;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Location = new Point(645, 402);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(50, 20);
            LabelEstado.TabIndex = 7;
            LabelEstado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelEstado);
            Controls.Add(ButtonEnviar);
            Controls.Add(TextBoxMensaje);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxNombre);
            Controls.Add(EtiquetaMensaje);
            Controls.Add(EtiquetaEmail);
            Controls.Add(EtiquetaNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaNombre;
        private Label EtiquetaEmail;
        private Label EtiquetaMensaje;
        private TextBox TextBoxNombre;
        private TextBox TextBoxEmail;
        private TextBox TextBoxMensaje;
        private Button ButtonEnviar;
        private Label LabelEstado;
    }
}
