namespace Parcial_1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnCambiarTexto = new Button();
            this.lblTexto = new Label();
            SuspendLayout();
            // 
            // btnCambiarTexto
            // 
            this.btnCambiarTexto.Location = new Point(273, 56);
            this.btnCambiarTexto.Name = "btnCambiarTexto";
            this.btnCambiarTexto.Size = new Size(113, 29);
            this.btnCambiarTexto.TabIndex = 0;
            this.btnCambiarTexto.Text = "Cambiar Texto";
            this.btnCambiarTexto.TextAlign = ContentAlignment.BottomCenter;
            this.btnCambiarTexto.UseVisualStyleBackColor = true;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new Point(84, 56);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new Size(102, 20);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Texto Original";
            // 
            // Form1
            // 
            ClientSize = new Size(707, 396);
            Controls.Add(this.lblTexto);
            Controls.Add(this.btnCambiarTexto);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
