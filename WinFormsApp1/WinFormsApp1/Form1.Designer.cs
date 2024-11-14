using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    // Constructor del formulario
    public Form1()
    {
        InitializeComponent();

        // Conectar el manejador de eventos al botón
        this.btnCambiarTexto.Click += new EventHandler(BtnCambiarTexto_Click);
    }

    // Manejador de eventos para el botón
    private void BtnCambiarTexto_Click(object sender, EventArgs e)
    {
        if (this.lblTexto.Text == "Texto Original")
        {
            this.lblTexto.Text = "Texto Modificado";
        }
        else
        {
            this.lblTexto.Text = "Texto Original";
        }
    }

    private Button btnCambiarTexto;
    private Label lblTexto;
}
