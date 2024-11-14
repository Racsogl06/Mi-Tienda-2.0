namespace FormParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiarTexto_Click_Click(object sender, EventArgs e)
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
    }
}
