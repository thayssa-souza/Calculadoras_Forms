namespace Calculadora_forms
{
    public partial class Frm_Calc_IMC : Form
    {
        public Frm_Calc_IMC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   label_title.Text = "Calculadora\n de IMC";
         //só para deixar o título desta forma /\
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = Convert.ToDouble(textBox_weight.Text);
            altura = Convert.ToDouble(textBox_height.Text);

            var alturaMetros = altura / 100;

           var (descricaoImc, resultadoIMC) = CalcularIMC(peso, alturaMetros);

            label_result.Text = $"{descricaoImc}\nSeu IMC: {resultadoIMC}";
        }

        private (string, double) CalcularIMC(double peso, double altura)
        {
            double imc = peso / (altura * altura);

            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre-peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
,            };

            return (resultado, imc);
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            textBox_weight.Text = "";
            textBox_height.Text = String.Empty;
            label_result.Text = String.Empty;
        }

    }
}