using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private int foundDifferences;
        private int totalDifferences;
        private string imageFileName;
        private List<Rectangle> differenceRectangles;
        private List<Rectangle> foundRectangles = new List<Rectangle>();

        public Form1()
        {
            InitializeComponent();
            LoadGameData("Kulonbsegek.txt");
            InitializeGame();
        }

        private void LoadGameData(string fileName)
        {
            try
            {
                var lines = File.ReadAllLines(fileName);
                imageFileName = lines[0];
                differenceRectangles = lines.Skip(1).Select(line =>
                {
                    var parts = line.Split(';');
                    if (parts.Length != 4) throw new FormatException("Invalid file format.");
                    return new Rectangle(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                }).ToList();
                totalDifferences = differenceRectangles.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading game data: {ex.Message}");
            }
        }

        private void InitializeGame()
        {
            try
            {
                pictureBox1.Image = Image.FromFile("Kep2.png");
                pictureBox2.Image = Image.FromFile("Kep2.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }

            startTime = DateTime.Now;
            foundDifferences = 0;
            foundRectangles.Clear();
            UpdateStatusLabels();
            gameTimer.Start();
        }

        private void UpdateStatusLabels()
        {
            var elapsed = DateTime.Now - startTime;
            labelElapsedTime.Text = $"Elapsed Time: {elapsed:mm\\:ss}";
            labelFoundDifferences.Text = $"Found Differences: {foundDifferences}/{totalDifferences}";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            UpdateStatusLabels();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var clickedPoint = e.Location;
            

            for (int i = 0; i < differenceRectangles.Count; i++)
            {
                var rect = differenceRectangles[i];
                if (rect.Contains(clickedPoint))
                {
                    foundDifferences++;
                    foundRectangles.Add(rect);
                    differenceRectangles.RemoveAt(i);
                    pictureBox1.Invalidate(); // Request a redraw
                    pictureBox2.Invalidate(); // Request a redraw
                    UpdateStatusLabels();
                    
                    if (foundDifferences == totalDifferences)
                    {
                        gameTimer.Stop();
                        MessageBox.Show("You found all differences!");
                    }
                    return; // Exit the loop and method
                }
            }

            
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightBlue, 3))
            {
                foreach (var rect in foundRectangles)
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            LoadGameData("Kulonbsegek.txt");
            InitializeGame();
        }
    }
}


