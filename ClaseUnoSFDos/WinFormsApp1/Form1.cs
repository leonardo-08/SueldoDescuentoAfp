namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
        double AFP = 0.0287, SFS = 0.03004, ISR = 0.15;
            double sueldobruto;
            double sueldo;
            double sueldobrutoAFP;
            double sueldobrutoSFS;
            double sueldobrutoISR;
            sueldo = double.Parse(SueldoBruto.Text);
            sueldobrutoAFP = sueldo * AFP;
            sueldobrutoSFS = sueldo * SFS;
            if (sueldo > 35000)
            {
                sueldobrutoISR = sueldo * ISR;
                sueldobruto = sueldo - sueldobrutoAFP - sueldobrutoISR - sueldobrutoSFS;
            }
            else
            {
            sueldobruto = sueldo - sueldobrutoAFP - sueldobrutoSFS;
            }
         
            SueldoNeto.Text = "$"+(sueldobruto.ToString("N2"));


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SueldoNeto_Click(object sender, EventArgs e)
        {

        }

        private void calcularr_Click(object sender, EventArgs e)
        {

        }


    }
}