namespace Sakktabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 1; sor < 9; sor++)
            {
                for (int oszlop = 1; oszlop < 9; oszlop++)
                {
                    if (sor % 2 == 0 && oszlop % 2 == 1)
                    {
                        Button b = new Button();
                        b.Top = sor * 60;
                        b.Left = oszlop * 60;
                        b.Width = 60;
                        b.Height = 60;

                        Controls.Add(b);
                    }
                    if(oszlop % 2 == 0 && sor % 2 == 1)
                    {
                        Button b = new Button();
                        b.Top = sor * 60;
                        b.Left = oszlop * 60;
                        b.Width = 60;
                        b.Height = 60;

                        Controls.Add(b);
                    }
                }
            }


           
        }
    }
}