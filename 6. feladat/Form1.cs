namespace _6._feladat
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
                    Button gomb = new Button();

                    gomb.Width = 20;
                    gomb.Height = 20;  

                    gomb.Left = ClientRectangle.Width/2 - i*10+j*20;
                    gomb.Top = i*25;

                    if (j <= i)
                    {
                        this.Controls.Add(gomb);
                    }
                }
            }
        }
    }
}