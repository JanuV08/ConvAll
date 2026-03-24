namespace ConvAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlVaha.Visible = false;
            pnlVzdalenost.Visible = false;


            if (comboBox1.Text == "Vzdálenost")
            {
                pnlVzdalenost.Visible = true;


            }
            if (comboBox1.Text == "Váha")
            {
                pnlVaha.Visible = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
