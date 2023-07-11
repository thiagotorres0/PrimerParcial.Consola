namespace _1stExam.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Base, Altura, Area, Volumen;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() && ValidarDatos2())
            {
                var Radio = double.Parse(txtArea.Text);
                var Altura = double.Parse(txtAltura.Text);
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, Radio, Altura);
                AgregarFila(r);
                Reiniciar();
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dataGridView1.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, double Area, double altura)
        {
            Area = CalcularArea(Base, Altura);
            Volumen = CalcularVolumen(Base, altura);
            r.Cells[colAltura.Index].Value = altura;
            r.Cells[colArea.Index].Value = Area;
            r.Cells[colVolumen.Index].Value = Volumen;
        }

        private double CalcularArea(double Base, double Altura)
        {
            return Math.Round(Base * (Base + Math.Sqrt(4 * Math.Pow(Altura, 2) + Math.Pow(Base, 2))));
        }

        private double CalcularVolumen(double Base, double altura)
        {
            return Math.Round(Math.Pow(Base, 2) * Altura) / 3;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dataGridView1);
            return r;
        }

        private bool ValidarDatos2()
        {
            bool EsValido = true;
            if (!double.TryParse(txtArea.Text, out double Area))
            {
                EsValido = false;
                errorProvider1.SetError(txtArea, "Area mal ingresada");
            }
            else if (!(Area > 0))
            {
                EsValido = false;
                errorProvider1.SetError(txtArea, "El Area debe ser mayor a 0 (Cero)");
            }
            return EsValido;
        }

        private bool ValidarDatos()
        {
            bool EsValido = true;
            if (!double.TryParse(txtAltura.Text, out double Altura))
            {
                EsValido = false;
                errorProvider1.SetError(txtAltura, "Altura mal ingresada");
            }
            else if (!(Altura > 0))
            {
                EsValido = false;
                errorProvider1.SetError(txtAltura, "La altura debe ser mayor a 0 (Cero)");
            }
            return EsValido;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir del formulario?", "Pregunta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Reiniciar()
        {
            txtAltura.Clear();
            txtArea.Clear();
            txtArea.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}