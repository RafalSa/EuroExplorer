namespace EuroExplorer
{
    partial class Grecja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grecja));
            Back = new Button();
            Opis = new Label();
            InfoGrecja1 = new TextBox();
            InfoGrecja = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisGrecja = new TextBox();
            Rodos_booking = new LinkLabel();
            Mykonos_booking = new LinkLabel();
            Kreta_booking = new LinkLabel();
            Santorini_booking = new LinkLabel();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Ateny_booking = new LinkLabel();
            bookingGrecja = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 13);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 71;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.BackColor = Color.Transparent;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.ForeColor = SystemColors.Menu;
            Opis.Location = new Point(1593, 277);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 70;
            Opis.Text = "Opis Live :";
            // 
            // InfoGrecja1
            // 
            InfoGrecja1.BackColor = Color.White;
            InfoGrecja1.Enabled = false;
            InfoGrecja1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoGrecja1.Location = new Point(1429, 422);
            InfoGrecja1.Multiline = true;
            InfoGrecja1.Name = "InfoGrecja1";
            InfoGrecja1.Size = new Size(463, 67);
            InfoGrecja1.TabIndex = 69;
            InfoGrecja1.TextChanged += InfoGrecja1_TextChanged;
            // 
            // InfoGrecja
            // 
            InfoGrecja.BackColor = Color.White;
            InfoGrecja.Enabled = false;
            InfoGrecja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoGrecja.Location = new Point(1429, 349);
            InfoGrecja.Multiline = true;
            InfoGrecja.Name = "InfoGrecja";
            InfoGrecja.Size = new Size(463, 67);
            InfoGrecja.TabIndex = 68;
            InfoGrecja.TextChanged += InfoGrecja_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 277);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 67;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 210);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 66;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(920, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // OpisGrecja
            // 
            OpisGrecja.BackColor = Color.White;
            OpisGrecja.Enabled = false;
            OpisGrecja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisGrecja.Location = new Point(12, 277);
            OpisGrecja.Multiline = true;
            OpisGrecja.Name = "OpisGrecja";
            OpisGrecja.Size = new Size(841, 585);
            OpisGrecja.TabIndex = 64;
            OpisGrecja.Text = resources.GetString("OpisGrecja.Text");
            // 
            // Rodos_booking
            // 
            Rodos_booking.AutoSize = true;
            Rodos_booking.BackColor = Color.White;
            Rodos_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Rodos_booking.Location = new Point(1492, 797);
            Rodos_booking.Name = "Rodos_booking";
            Rodos_booking.Size = new Size(74, 30);
            Rodos_booking.TabIndex = 101;
            Rodos_booking.TabStop = true;
            Rodos_booking.Text = "Rodos";
            Rodos_booking.LinkClicked += Rodos_booking_LinkClicked;
            // 
            // Mykonos_booking
            // 
            Mykonos_booking.AutoSize = true;
            Mykonos_booking.BackColor = Color.White;
            Mykonos_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Mykonos_booking.Location = new Point(1491, 750);
            Mykonos_booking.Name = "Mykonos_booking";
            Mykonos_booking.Size = new Size(104, 30);
            Mykonos_booking.TabIndex = 100;
            Mykonos_booking.TabStop = true;
            Mykonos_booking.Text = "Mykonos";
            Mykonos_booking.LinkClicked += Mykonos_booking_LinkClicked;
            // 
            // Kreta_booking
            // 
            Kreta_booking.AutoSize = true;
            Kreta_booking.BackColor = Color.White;
            Kreta_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Kreta_booking.Location = new Point(1491, 700);
            Kreta_booking.Name = "Kreta_booking";
            Kreta_booking.Size = new Size(65, 30);
            Kreta_booking.TabIndex = 99;
            Kreta_booking.TabStop = true;
            Kreta_booking.Text = "Kreta";
            Kreta_booking.LinkClicked += Kreta_booking_LinkClicked;
            // 
            // Santorini_booking
            // 
            Santorini_booking.AutoSize = true;
            Santorini_booking.BackColor = Color.White;
            Santorini_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Santorini_booking.Location = new Point(1492, 654);
            Santorini_booking.Name = "Santorini_booking";
            Santorini_booking.Size = new Size(103, 30);
            Santorini_booking.TabIndex = 98;
            Santorini_booking.TabStop = true;
            Santorini_booking.Text = "Santorini";
            Santorini_booking.LinkClicked += Santorini_booking_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.ForeColor = SystemColors.Menu;
            label8.Location = new Point(1429, 795);
            label8.Name = "label8";
            label8.Size = new Size(35, 32);
            label8.TabIndex = 97;
            label8.Text = "5.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.Menu;
            label6.Location = new Point(1429, 748);
            label6.Name = "label6";
            label6.Size = new Size(35, 32);
            label6.TabIndex = 96;
            label6.Text = "4.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = SystemColors.Menu;
            label7.Location = new Point(1429, 698);
            label7.Name = "label7";
            label7.Size = new Size(35, 32);
            label7.TabIndex = 95;
            label7.Text = "3.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.Menu;
            label5.Location = new Point(1429, 652);
            label5.Name = "label5";
            label5.Size = new Size(35, 32);
            label5.TabIndex = 94;
            label5.Text = "2.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.Menu;
            label4.Location = new Point(1429, 602);
            label4.Name = "label4";
            label4.Size = new Size(35, 32);
            label4.TabIndex = 93;
            label4.Text = "1.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.Menu;
            label3.Location = new Point(1429, 520);
            label3.Name = "label3";
            label3.Size = new Size(389, 64);
            label3.TabIndex = 92;
            label3.Text = "Lista Top 5 odwiedzanych miast, \r\nzobacz noclegi:";
            // 
            // Ateny_booking
            // 
            Ateny_booking.AutoSize = true;
            Ateny_booking.BackColor = Color.White;
            Ateny_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Ateny_booking.Location = new Point(1492, 604);
            Ateny_booking.Name = "Ateny_booking";
            Ateny_booking.Size = new Size(71, 30);
            Ateny_booking.TabIndex = 91;
            Ateny_booking.TabStop = true;
            Ateny_booking.Text = "Ateny";
            Ateny_booking.LinkClicked += Ateny_booking_LinkClicked;
            // 
            // bookingGrecja
            // 
            bookingGrecja.Location = new Point(1080, 688);
            bookingGrecja.Name = "bookingGrecja";
            bookingGrecja.Size = new Size(169, 62);
            bookingGrecja.TabIndex = 102;
            bookingGrecja.Text = "Noclegi cała Grecja";
            bookingGrecja.UseVisualStyleBackColor = true;
            bookingGrecja.Click += bookingGrecja_Click;
            // 
            // Grecja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(bookingGrecja);
            Controls.Add(Rodos_booking);
            Controls.Add(Mykonos_booking);
            Controls.Add(Kreta_booking);
            Controls.Add(Santorini_booking);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Ateny_booking);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoGrecja1);
            Controls.Add(InfoGrecja);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisGrecja);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Grecja";
            Text = "Grecja";
            Load += Grecja_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoGrecja1;
        protected TextBox InfoGrecja;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisGrecja;
        private LinkLabel Rodos_booking;
        private LinkLabel Mykonos_booking;
        private LinkLabel Kreta_booking;
        private LinkLabel Santorini_booking;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private LinkLabel Ateny_booking;
        private Button bookingGrecja;
    }
}