namespace EuroExplorer
{
    partial class Litwa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Litwa));
            Back = new Button();
            Opis = new Label();
            InfoLitwa1 = new TextBox();
            InfoLitwa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisLitwa = new TextBox();
            bookingLitwa = new Button();
            Troki_booking = new LinkLabel();
            Druskienniki_booking = new LinkLabel();
            Klajpeda_booking = new LinkLabel();
            Kowno_booking = new LinkLabel();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Wilno_booking = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 14);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 103;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.BackColor = Color.Transparent;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.ForeColor = Color.White;
            Opis.Location = new Point(1593, 278);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 102;
            Opis.Text = "Opis Live :";
            // 
            // InfoLitwa1
            // 
            InfoLitwa1.BackColor = Color.White;
            InfoLitwa1.Enabled = false;
            InfoLitwa1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoLitwa1.Location = new Point(1429, 423);
            InfoLitwa1.Multiline = true;
            InfoLitwa1.Name = "InfoLitwa1";
            InfoLitwa1.Size = new Size(463, 67);
            InfoLitwa1.TabIndex = 101;
            InfoLitwa1.TextChanged += InfoLitwa1_TextChanged;
            // 
            // InfoLitwa
            // 
            InfoLitwa.BackColor = Color.White;
            InfoLitwa.Enabled = false;
            InfoLitwa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoLitwa.Location = new Point(1429, 350);
            InfoLitwa.Multiline = true;
            InfoLitwa.Name = "InfoLitwa";
            InfoLitwa.Size = new Size(463, 67);
            InfoLitwa.TabIndex = 100;
            InfoLitwa.TextChanged += InfoLitwa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 278);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 99;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 211);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 98;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
            // 
            // OpisLitwa
            // 
            OpisLitwa.BackColor = Color.White;
            OpisLitwa.Enabled = false;
            OpisLitwa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisLitwa.Location = new Point(12, 278);
            OpisLitwa.Multiline = true;
            OpisLitwa.Name = "OpisLitwa";
            OpisLitwa.Size = new Size(841, 616);
            OpisLitwa.TabIndex = 96;
            OpisLitwa.Text = resources.GetString("OpisLitwa.Text");
            // 
            // bookingLitwa
            // 
            bookingLitwa.Location = new Point(1080, 658);
            bookingLitwa.Name = "bookingLitwa";
            bookingLitwa.Size = new Size(169, 62);
            bookingLitwa.TabIndex = 137;
            bookingLitwa.Text = "Noclegi cała Litwa";
            bookingLitwa.UseVisualStyleBackColor = true;
            bookingLitwa.Click += bookingLitwa_Click;
            // 
            // Troki_booking
            // 
            Troki_booking.AutoSize = true;
            Troki_booking.BackColor = Color.White;
            Troki_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Troki_booking.Location = new Point(1492, 801);
            Troki_booking.Name = "Troki_booking";
            Troki_booking.Size = new Size(62, 30);
            Troki_booking.TabIndex = 158;
            Troki_booking.TabStop = true;
            Troki_booking.Text = "Troki";
            Troki_booking.LinkClicked += Troki_booking_LinkClicked;
            // 
            // Druskienniki_booking
            // 
            Druskienniki_booking.AutoSize = true;
            Druskienniki_booking.BackColor = Color.White;
            Druskienniki_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Druskienniki_booking.Location = new Point(1491, 754);
            Druskienniki_booking.Name = "Druskienniki_booking";
            Druskienniki_booking.Size = new Size(137, 30);
            Druskienniki_booking.TabIndex = 157;
            Druskienniki_booking.TabStop = true;
            Druskienniki_booking.Text = "Druskienniki";
            Druskienniki_booking.LinkClicked += Druskienniki_booking_LinkClicked;
            // 
            // Klajpeda_booking
            // 
            Klajpeda_booking.AutoSize = true;
            Klajpeda_booking.BackColor = Color.White;
            Klajpeda_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Klajpeda_booking.Location = new Point(1491, 704);
            Klajpeda_booking.Name = "Klajpeda_booking";
            Klajpeda_booking.Size = new Size(99, 30);
            Klajpeda_booking.TabIndex = 156;
            Klajpeda_booking.TabStop = true;
            Klajpeda_booking.Text = "Kłajpeda";
            Klajpeda_booking.LinkClicked += Klajpeda_booking_LinkClicked;
            // 
            // Kowno_booking
            // 
            Kowno_booking.AutoSize = true;
            Kowno_booking.BackColor = Color.White;
            Kowno_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Kowno_booking.Location = new Point(1492, 658);
            Kowno_booking.Name = "Kowno_booking";
            Kowno_booking.Size = new Size(83, 30);
            Kowno_booking.TabIndex = 155;
            Kowno_booking.TabStop = true;
            Kowno_booking.Text = "Kowno";
            Kowno_booking.LinkClicked += Kowno_booking_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.ForeColor = SystemColors.Menu;
            label8.Location = new Point(1429, 799);
            label8.Name = "label8";
            label8.Size = new Size(35, 32);
            label8.TabIndex = 154;
            label8.Text = "5.";
            label8.Click += label8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.Menu;
            label6.Location = new Point(1429, 752);
            label6.Name = "label6";
            label6.Size = new Size(35, 32);
            label6.TabIndex = 153;
            label6.Text = "4.";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = SystemColors.Menu;
            label7.Location = new Point(1429, 702);
            label7.Name = "label7";
            label7.Size = new Size(35, 32);
            label7.TabIndex = 152;
            label7.Text = "3.";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.Menu;
            label5.Location = new Point(1429, 656);
            label5.Name = "label5";
            label5.Size = new Size(35, 32);
            label5.TabIndex = 151;
            label5.Text = "2.";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.Menu;
            label4.Location = new Point(1429, 606);
            label4.Name = "label4";
            label4.Size = new Size(35, 32);
            label4.TabIndex = 150;
            label4.Text = "1.";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.Menu;
            label3.Location = new Point(1429, 524);
            label3.Name = "label3";
            label3.Size = new Size(389, 64);
            label3.TabIndex = 149;
            label3.Text = "Lista Top 5 odwiedzanych miast, \r\nzobacz noclegi:";
            label3.Click += label3_Click;
            // 
            // Wilno_booking
            // 
            Wilno_booking.AutoSize = true;
            Wilno_booking.BackColor = Color.White;
            Wilno_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Wilno_booking.Location = new Point(1492, 608);
            Wilno_booking.Name = "Wilno_booking";
            Wilno_booking.Size = new Size(72, 30);
            Wilno_booking.TabIndex = 148;
            Wilno_booking.TabStop = true;
            Wilno_booking.Text = "Wilno";
            Wilno_booking.LinkClicked += Wilno_booking_LinkClicked;
            // 
            // Litwa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Troki_booking);
            Controls.Add(Druskienniki_booking);
            Controls.Add(Klajpeda_booking);
            Controls.Add(Kowno_booking);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Wilno_booking);
            Controls.Add(bookingLitwa);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoLitwa1);
            Controls.Add(InfoLitwa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisLitwa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Litwa";
            Text = "Litwa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoLitwa1;
        protected TextBox InfoLitwa;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisLitwa;
        private Button bookingLitwa;
        private LinkLabel Troki_booking;
        private LinkLabel Druskienniki_booking;
        private LinkLabel Klajpeda_booking;
        private LinkLabel Kowno_booking;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private LinkLabel Wilno_booking;
    }
}