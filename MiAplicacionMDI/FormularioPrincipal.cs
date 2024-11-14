namespace MiAplicacionMDI
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void btnAbrirFormulario_Click(object sender, EventArgs e)
        {
            FormularioSecundario formularioSecundario = new FormularioSecundario();
            formularioSecundario.MdiParent = this; 
            formularioSecundario.Show(); 
        }

    }
}
