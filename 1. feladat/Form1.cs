namespace _1._feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    SzinezoGomb uj = new SzinezoGomb();
                    uj.Height = 50;
                    uj.Width = 100;

                    uj.Left = i * 110;
                    uj.Top= j*55;

                    uj.Text = (i*j).ToString();

                    Controls.Add(uj);
                }

            }

            


        }
    }
}