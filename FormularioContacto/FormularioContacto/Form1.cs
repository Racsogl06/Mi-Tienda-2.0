namespace FormularioContacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) ||
        string.IsNullOrWhiteSpace(TextBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(TextBoxMensaje.Text))
            {
                LabelEstado.Text = "Por favor, complete todos los campos.";
                LabelEstado.ForeColor = Color.Red;
            }
            else
            {
                LabelEstado.Text = "Formulario enviado correctamente.";
                LabelEstado.ForeColor = Color.Green;
            }
        
    }
    }
}
