namespace Forma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBox3.Text = (float.Parse(textBox1.Text) + float.Parse(textBox2.Text)).ToString();
                trackBar1.Value = (int)float.Parse(textBox3.Text);
                progressBar1.Value = (int)float.Parse(textBox1.Text);
            }
            else {
                MessageBox.Show("Turite pazymeti sutikimo varnele, kad gauti atsakyma");
            
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int scale = this.trackBar1.Value;

            this.progressBar1.Value = scale;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}