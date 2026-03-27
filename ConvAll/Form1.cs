using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                comVzdaVstup.SelectedIndex = 0;
                comVzdaVystup.SelectedIndex = 1;

            }
            if (comboBox1.Text == "Váha")
            {
                pnlVaha.Visible = true;
                comVahVstup.SelectedIndex = 0;
                comVahVystup.SelectedIndex = 1;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

        }

        private void numVaha_ValueChanged(object sender, EventArgs e)
        {
            double vstup = Convert.ToDouble(numVaha.Value);
            double vystup = 0;
            double gram = 0;

            switch (comVahVstup.Text)
            {

                case "tuna (t)":
                    {
                        gram = vstup * Math.Pow(10, 6);
                        break;
                    }
                case "kilogram (kg)":
                    {
                        gram = vstup * Math.Pow(10, 3);
                        break;
                    }
                case "dekagram (dag)":
                    {
                        gram = vstup * Math.Pow(10, 1);
                        break;
                    }
                case "gram (g)":
                    {
                        gram = vstup;
                        break;
                    }
                case "miligram (mg)":
                    {
                        gram = vstup * Math.Pow(10, -3);
                        break;
                    }
                case "libra (lb)":
                    {
                        gram = vstup * 453.59237;
                        break;
                    }
                case "metrický cent (q)":
                    {
                        gram = vstup * Math.Pow(10, 5);
                        break;
                    }
                case "unce (oz)":
                    {
                        gram = vstup * 28.34952;
                        break;
                    }

            }

            /*     
             *     kilogram (kg)
             *     gram (g)
             *     libra (lb)
             *     tuna (t)
             *     dekagram  (dag)
             *     miligram (mg)
             *     metrický cent (q)
             *     unce (oz)
             */

            switch (comVahVystup.Text)
            {

                case "tuna (t)":
                    {
                        vystup = gram / Math.Pow(10, 6);
                        break;
                    }

                case "kilogram (kg)":
                    {
                        vystup = gram / Math.Pow(10, 3);
                        break;
                    }

                case "dekagram (dag)":
                    {
                        vystup = gram / Math.Pow(10, 1);
                        break;
                    }

                case "gram (g)":
                    {
                        vystup = gram;
                        break;
                    }

                case "miligram (mg)":
                    {
                        vystup = gram * Math.Pow(10, 3);
                        break;
                    }

                case "metrický cent (q)":
                    {
                        vystup = gram / Math.Pow(10, 5);
                        break;
                    }

                case "libra (lb)":
                    {
                        vystup = gram / 453.59237;
                        break;
                    }

                case "unce (oz)":
                    {
                        vystup = gram / 28.34952;
                        break;
                    }

            }

            textVystupVah.Text = vystup.ToString("G10");
        }

        private void numVzda_ValueChanged(object sender, EventArgs e)
        {
            /*
             *       metr (m)
             *       centimetr (cm)
             *       palec (in)
             *       milimetr (mm)
             *       stopa (ft)
             *       decimetr (dm)
             *       kilometr (km)
             *       míle (mi)
             *       yard (yd)
            */
            double vstup = Convert.ToDouble(numVzda.Value);
            double vystup = 0;
            double metr = 0;

            switch (comVzdaVstup.Text)
            {
                case "kilometr (km)":
                    {
                        metr = vstup * Math.Pow(10, 3);
                        break;
                    }

                case "metr (m)":
                    {
                        metr = vstup;
                        break;
                    }

                case "decimetr (dm)":
                    {
                        metr = vstup * Math.Pow(10, -1);
                        break;
                    }

                case "centimetr (cm)":
                    {
                        metr = vstup * Math.Pow(10, -2);
                        break;
                    }

                case "milimetr (mm)":
                    {
                        metr = vstup * Math.Pow(10, -3);
                        break;
                    }

                case "palec (in)":
                    {
                        metr = vstup * 0.0254;
                        break;
                    }

                case "stopa (ft)":
                    {
                        metr = vstup * 0.3048;
                        break;
                    }

                case "míle (mi)":
                    {
                        metr = vstup * 1609.344;
                        break;
                    }

                case "yard (yd)":
                    {
                        metr = vstup * 0.9144;
                        break;
                    }

            }

            switch (comVzdaVystup.Text)
            {
                case "kilometr (km)":
                    {
                        vystup = metr / Math.Pow(10, 3);
                        break;
                    }

                case "metr (m)":
                    {
                        vystup = metr;
                        break;
                    }

                case "decimetr (dm)":
                    {
                        vystup = metr / Math.Pow(10, -1);
                        break;
                    }

                case "centimetr (cm)":
                    {
                        vystup = metr / Math.Pow(10, -2);
                        break;
                    }

                case "milimetr (mm)":
                    {
                        vystup = metr / Math.Pow(10, -3);
                        break;
                    }

                case "palec (in)":
                    {
                        vystup = metr / 0.0254;
                        break;
                    }

                case "stopa (ft)":
                    {
                        vystup = metr / 0.3048;
                        break;
                    }

                case "míle (mi)":
                    {
                        vystup = metr / 1609.344;
                        break;
                    }

                case "yard (yd)":
                    {
                        vystup = metr / 0.9144;
                        break;
                    }

            }

            textVystupVzda.Text = vystup.ToString("G10");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pomocna = comVahVstup.SelectedIndex;
            comVahVstup.SelectedIndex = comVahVystup.SelectedIndex;
            comVahVystup.SelectedIndex = pomocna;

        }
    }
}
