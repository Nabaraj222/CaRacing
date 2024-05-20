namespace CarRacing
{
    partial class CarRacing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRacing));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            car = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            enemy3 = new PictureBox();
            over = new Label();
            coin3 = new PictureBox();
            coin2 = new PictureBox();
            coin4 = new PictureBox();
            coin1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(177, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 91);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(177, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 99);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(177, 254);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 98);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(177, 381);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 92);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Location = new Point(2, 1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(10, 453);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Location = new Point(371, 1);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(10, 453);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // car
            // 
            car.BackColor = Color.Gray;
            car.BackgroundImageLayout = ImageLayout.Stretch;
            car.Image = (Image)resources.GetObject("car.Image");
            car.Location = new Point(40, 313);
            car.Name = "car";
            car.Size = new Size(37, 62);
            car.SizeMode = PictureBoxSizeMode.StretchImage;
            car.TabIndex = 7;
            car.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.Gray;
            enemy1.BackgroundImageLayout = ImageLayout.Stretch;
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(40, 102);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(37, 49);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 8;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.BackColor = Color.Gray;
            enemy2.BackgroundImageLayout = ImageLayout.Stretch;
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(210, 67);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(37, 49);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 9;
            enemy2.TabStop = false;
            // 
            // enemy3
            // 
            enemy3.BackColor = Color.Gray;
            enemy3.BackgroundImageLayout = ImageLayout.Stretch;
            enemy3.Image = (Image)resources.GetObject("enemy3.Image");
            enemy3.Location = new Point(310, 174);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(37, 49);
            enemy3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy3.TabIndex = 10;
            enemy3.TabStop = false;
            // 
            // over
            // 
            over.AutoSize = true;
            over.BackColor = Color.LightSeaGreen;
            over.Font = new Font("Impact", 15F);
            over.ForeColor = Color.DarkSlateGray;
            over.Location = new Point(134, 1);
            over.Name = "over";
            over.Size = new Size(123, 32);
            over.TabIndex = 11;
            over.Text = "Game Over";
            // 
            // coin3
            // 
            coin3.BackColor = Color.Gray;
            coin3.BackgroundImageLayout = ImageLayout.Stretch;
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(72, 191);
            coin3.Name = "coin3";
            coin3.Size = new Size(32, 32);
            coin3.SizeMode = PictureBoxSizeMode.StretchImage;
            coin3.TabIndex = 12;
            coin3.TabStop = false;
            // 
            // coin2
            // 
            coin2.BackColor = Color.Gray;
            coin2.BackgroundImageLayout = ImageLayout.Stretch;
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(310, 42);
            coin2.Name = "coin2";
            coin2.Size = new Size(32, 32);
            coin2.SizeMode = PictureBoxSizeMode.StretchImage;
            coin2.TabIndex = 13;
            coin2.TabStop = false;
            // 
            // coin4
            // 
            coin4.BackColor = Color.Gray;
            coin4.BackgroundImageLayout = ImageLayout.Stretch;
            coin4.Image = (Image)resources.GetObject("coin4.Image");
            coin4.Location = new Point(282, 254);
            coin4.Name = "coin4";
            coin4.Size = new Size(32, 32);
            coin4.SizeMode = PictureBoxSizeMode.StretchImage;
            coin4.TabIndex = 14;
            coin4.TabStop = false;
            // 
            // coin1
            // 
            coin1.BackColor = Color.Gray;
            coin1.BackgroundImageLayout = ImageLayout.Stretch;
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(124, 42);
            coin1.Name = "coin1";
            coin1.Size = new Size(32, 32);
            coin1.SizeMode = PictureBoxSizeMode.StretchImage;
            coin1.TabIndex = 15;
            coin1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(18, 1);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 16;
            label1.Text = "Score: 0";
            // 
            // CarRacing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(382, 453);
            Controls.Add(label1);
            Controls.Add(coin1);
            Controls.Add(coin4);
            Controls.Add(coin2);
            Controls.Add(coin3);
            Controls.Add(over);
            Controls.Add(enemy3);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(car);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "CarRacing";
            Text = "CarRacing";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)car).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin4).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer1;
        private PictureBox car;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private PictureBox enemy3;
        private Label over;
        private PictureBox coin3;
        private PictureBox coin2;
        private PictureBox coin4;
        private PictureBox coin1;
        private Label label1;
    }
}
