partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Button btnCambiarTexto;
    private Label lblTexto;

    // Método de limpieza de recursos
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.btnCambiarTexto = new System.Windows.Forms.Button();
        this.lblTexto = new System.Windows.Forms.Label();
        this.SuspendLayout();

        // 
        // btnCambiarTexto
        // 
        this.btnCambiarTexto.Location = new System.Drawing.Point(100, 50);
        this.btnCambiarTexto.Name = "btnCambiarTexto";
        this.btnCambiarTexto.Size = new System.Drawing.Size(120, 30);
        this.btnCambiarTexto.TabIndex = 0;
        this.btnCambiarTexto.Text = "Cambiar Texto";
        this.btnCambiarTexto.UseVisualStyleBackColor = true;

        // 
        // lblTexto
        // 
        this.lblTexto.AutoSize = true;
        this.lblTexto.Location = new System.Drawing.Point(100, 100);
        this.lblTexto.Name = "lblTexto";
        this.lblTexto.Size = new System.Drawing.Size(80, 20);
        this.lblTexto.TabIndex = 1;
        this.lblTexto.Text = "Texto Original";

        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(320, 200);
        this.Controls.Add(this.lblTexto);
        this.Controls.Add(this.btnCambiarTexto);
        this.Name = "Form1";
        this.Text = "Formulario";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
