namespace FIGURAS_GEOMETRICAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(textBox1.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3);
            textBox2.Text = area1.ToString();
            textBox3.Text = volumen1.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(textBox4.Text);
            float valor2 = float.Parse(textBox5.Text);
            float valor3 = valor1 * valor2 / 2;
            textBox6.Text = valor3.ToString();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double lado2, area2, volumen2;
            lado2 = double.Parse(textBox7.Text);
            area2 = 6 * lado2 * lado2;
            volumen2 = lado2 * lado2 * lado2;
            textBox8.Text = area2.ToString();
            textBox9.Text = volumen2.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio3, altura3, area3, volumen3;
            radio3 = double.Parse(textBox10.Text);
            altura3 = double.Parse(textBox11.Text);
            area3 = 2 * pi * radio3 * altura3 + 2 * pi * radio3 * radio3;
            volumen3 = pi * radio3 * radio3 * altura3;
            textBox12.Text = area3.ToString();
            textBox13.Text = volumen3.ToString();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(textBox14.Text);
            float valor2 = float.Parse(textBox15.Text);
            float valor3 = valor1 * valor2 / 2;
            textBox16.Text = valor3.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double lado4, area4, volumen4;
            lado4 = double.Parse(textBox17.Text);
            area4 = 2 * Math.Sqrt(3) * lado4 * lado4;
            volumen4 = Math.Sqrt(2) / 3 * lado4 * lado4 * lado4;
            textBox18.Text = area4.ToString();
            textBox19.Text = volumen4.ToString();
        }
    }
}