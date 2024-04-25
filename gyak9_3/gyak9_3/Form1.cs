using gyak9_3.Models;

namespace gyak9_3
{
    public partial class Form1 : Form
    {
        Models.StudentContext studentContext = new Models.StudentContext();
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = studentContext.Students.ToList();

            studentBindingSource.DataSource = studentContext.Students.ToList();
            dataGridView1.DataSource = studentBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception kivétel)
            {
                MessageBox.Show(kivétel.InnerException.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string text = ((TextBox)sender).Text = textBox1.Text; 

            var eredmeny = from student in students
                           where student.Name.Contains(text)
                           select student;
            studentBindingSource.DataSource = eredmeny.ToList();    

        }
    }
}