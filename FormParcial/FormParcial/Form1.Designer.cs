namespace FormParcial
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
            btnCambiarTexto_Click = new Button();
            lblTexto = new Label();
            SuspendLayout();
            // 
            // btnCambiarTexto_Click
            // 
            btnCambiarTexto_Click.BackColor = SystemColors.ScrollBar;
            btnCambiarTexto_Click.Location = new Point(75, 119);
            btnCambiarTexto_Click.Name = "btnCambiarTexto_Click";
            btnCambiarTexto_Click.Size = new Size(128, 49);
            btnCambiarTexto_Click.TabIndex = 0;
            btnCambiarTexto_Click.Text = "Cambiar Texto";
            btnCambiarTexto_Click.UseVisualStyleBackColor = false;
            btnCambiarTexto_Click.Click += btnCambiarTexto_Click_Click;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(89, 78);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(102, 20);
            lblTexto.TabIndex = 1;
            lblTexto.Text = "Texto Original";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 253);
            Controls.Add(lblTexto);
            Controls.Add(btnCambiarTexto_Click);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambiarTexto_Click;
        private Label lblTexto;
    }
}
