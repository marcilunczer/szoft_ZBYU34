using _10.gyak.Models;

namespace _10.gyak
{
    public partial class Form1 : Form
    {


     public Form1()
        {
            InitializeComponent();

            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from i in context.Instructors
                                where i.Name.Contains(textBox1.Text)
                                select i).ToList();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
                }

        
        private void button1_Click(object sender, EventArgs e)  
        {  
            
       

            panel1.Controls.Clear();  
            
            UserControl userControl1 = new UserControl1(); 
            panel1.Controls.Add(userControl1);  
            userControl1.Dock = DockStyle.Fill;  
        }
        Instructor instructor = (Instructor)listBox1.SelectedItem;
        if(listBox1.SelectedItem == null) return;
        Instructor selectedInstructor = listBox1.SelectedItem as Instructor;
        var lessons = from l in context.Lessons
              where l.InstructorFk == selectedInstructor.InstructorSk
              select new
              {
                  Kurzus = l.CourseFkNavigation.Name,
                  Nap = l.DayFkNavigation.Name,
                  Sáv = l.TimeFkNavigation.Name
              };
        var lessons2 = context.Lessons.Where(l => l.InstructorFk == selectedInstructor.InstructorSk)
                .Select(l => new
                {
                    Kurzus = l.CourseFkNavigation.Name,
                    Nap = l.DayFkNavigation.Name,
                    Sáv = l.TimeFkNavigation.Name
                });
                dataGridView1.DataSource = lessons.ToList();
        
    }

    public partial class UserControl2 : UserControl
        {
            StudiesContext context = new StudiesContext();
            public UserControl2()
            {
                InitializeComponent();

                FillDataSource();
                listBox1.DisplayMember = "Name";
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {
                FillDataSource();
            }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (listBox1.SelectedItem == null) return;
                Course course = listBox1.SelectedItem as Course;

                dataGridView1.DataSource = (from l in context.Lessons
                                            where l.CourseFk == course.CourseSk
                                            select new
                                            {
                                                Nap = l.DayFkNavigation.Name,
                                                Sáv = l.TimeFkNavigation.Name,
                                                Oktató = l.InstructorFkNavigation.Name
                                            }).ToList();
            }

            private void FillDataSource()
            {
                listBox1.DataSource = (from c in context.Courses
                                    where c.Name.Contains(textBox1.Text)
                                    select c).ToList();
            }
        }
}