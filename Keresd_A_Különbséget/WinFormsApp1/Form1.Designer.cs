namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelElapsedTime = new Label();
            labelFoundDifferences = new Label();
            button1 = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(40, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(591, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(512, 512);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // labelElapsedTime
            // 
            labelElapsedTime.AutoSize = true;
            labelElapsedTime.Location = new Point(155, 594);
            labelElapsedTime.Name = "labelElapsedTime";
            labelElapsedTime.Size = new Size(38, 15);
            labelElapsedTime.TabIndex = 2;
            labelElapsedTime.Text = "label1";
            // 
            // labelFoundDifferences
            // 
            labelFoundDifferences.AutoSize = true;
            labelFoundDifferences.Location = new Point(293, 594);
            labelFoundDifferences.Name = "labelFoundDifferences";
            labelFoundDifferences.Size = new Size(38, 15);
            labelFoundDifferences.TabIndex = 3;
            labelFoundDifferences.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(40, 586);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Új játék";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonNewGame_Click;
            // 
            // gameTimer
            // 
            gameTimer.Tick += gameTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 824);
            Controls.Add(button1);
            Controls.Add(labelFoundDifferences);
            Controls.Add(labelElapsedTime);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelElapsedTime;
        private Label labelFoundDifferences;
        private Button button1;
        private System.Windows.Forms.Timer gameTimer;
    }
}