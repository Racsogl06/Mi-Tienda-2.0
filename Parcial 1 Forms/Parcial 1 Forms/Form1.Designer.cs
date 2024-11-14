using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    // Constructor del formulario
    public Form1()
    {
        InitializeComponent();

        // Conectar el manejador de eventos al botón
        btnCambiarTexto.Click += new EventHandler(BtnCambiarTexto_Click);
    }

    // Manejador de eventos para el botón
    private void BtnCambiarTexto_Click(object sender, EventArgs e)
    {
        if (lblTexto.Text == "Texto Original")
        {
            lblTexto.Text = "Texto Modificado";
        }
        else
        {
            lblTexto.Text = "Texto Original";
        }
    }

    private Button btnCambiarTexto;
    private Label lblTexto;
}
