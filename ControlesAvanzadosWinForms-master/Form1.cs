namespace ControlesAvanzados
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioArchivo = new Archivo();
            formularioArchivo.MdiParent = this;
            formularioArchivo.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void nuevoProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioProyecto = new FormularioProyecto();
            formularioProyecto.Show();
        }
        panel1.Size = new Size(200, 100);
        panel1.BackColor = Color.LightGray;
    panel1.Font = new Font("Arial", 12);

        panel2.Size = new Size(200, 100);
        panel2.BackColor = Color.LightGray;
    panel2.Font = new Font("Arial", 12);

        decimal ventas = 10500.00m;
        labelVentas.Text = ventas.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("es-GT"));


int mes = 3;
        string nombreMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
        labelMes.Text = nombreMes; 

            public Contenedor()
        {
            InitializeComponent();

            comboBoxAño.Items.Insert(0, "Seleccionar todos");
            comboBoxMes.Items.Insert(0, "Seleccionar todos");
        }
        comboBoxAño.SelectedIndexChanged += (s, e) =>
{
    if (comboBoxAño.SelectedItem.ToString() == "Seleccionar todos")
    {
    }
};

    comboBoxMes.SelectedIndexChanged += (s, e) =>
{
    if (comboBoxMes.SelectedItem.ToString() == "Seleccionar todos")
    {
    }
};

    }
}
