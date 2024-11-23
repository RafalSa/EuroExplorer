namespace EuroExplorer
{
    partial class Polska
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polska));
            Back = new Button();
            Opis = new Label();
            InfoPolska1 = new TextBox();
            InfoPolska = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisPolska = new TextBox();
            Zakopane_booking = new LinkLabel();
            Gdansk_booking = new LinkLabel();
            Wroclaw_booking = new LinkLabel();
            Krakow_booking = new LinkLabel();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Warszawa_booking = new LinkLabel();
            bookingPolska = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 13);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 135;
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
            Opis.TabIndex = 134;
            Opis.Text = "Opis Live :";
            // 
            // InfoPolska1
            // 
            InfoPolska1.BackColor = Color.White;
            InfoPolska1.Enabled = false;
            InfoPolska1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoPolska1.Location = new Point(1429, 422);
            InfoPolska1.Multiline = true;
            InfoPolska1.Name = "InfoPolska1";
            InfoPolska1.Size = new Size(463, 67);
            InfoPolska1.TabIndex = 133;
            InfoPolska1.TextChanged += InfoPolska1_TextChanged;
            // 
            // InfoPolska
            // 
            InfoPolska.BackColor = Color.White;
            InfoPolska.Enabled = false;
            InfoPolska.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoPolska.Location = new Point(1429, 349);
            InfoPolska.Multiline = true;
            InfoPolska.Name = "InfoPolska";
            InfoPolska.Size = new Size(463, 67);
            InfoPolska.TabIndex = 132;
            InfoPolska.TextChanged += InfoPolska_TextChanged;
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
            label2.TabIndex = 131;
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
            label1.TabIndex = 130;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 129;
            pictureBox1.TabStop = false;
            // 
            // OpisPolska
            // 
            OpisPolska.BackColor = Color.White;
            OpisPolska.Enabled = false;
            OpisPolska.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisPolska.Location = new Point(12, 277);
            OpisPolska.Multiline = true;
            OpisPolska.Name = "OpisPolska";
            OpisPolska.Size = new Size(841, 615);
            OpisPolska.TabIndex = 128;
            OpisPolska.Text = resources.GetString("OpisPolska.Text");
            // 
            // Zakopane_booking
            // 
            Zakopane_booking.AutoSize = true;
            Zakopane_booking.BackColor = Color.White;
            Zakopane_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Zakopane_booking.Location = new Point(1492, 800);
            Zakopane_booking.Name = "Zakopane_booking";
            Zakopane_booking.Size = new Size(110, 30);
            Zakopane_booking.TabIndex = 191;
            Zakopane_booking.TabStop = true;
            Zakopane_booking.Text = "Zakopane";
            Zakopane_booking.LinkClicked += Zakopane_booking_LinkClicked;
            // 
            // Gdansk_booking
            // 
            Gdansk_booking.AutoSize = true;
            Gdansk_booking.BackColor = Color.White;
            Gdansk_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Gdansk_booking.Location = new Point(1491, 753);
            Gdansk_booking.Name = "Gdansk_booking";
            Gdansk_booking.Size = new Size(86, 30);
            Gdansk_booking.TabIndex = 190;
            Gdansk_booking.TabStop = true;
            Gdansk_booking.Text = "Gdańsk";
            Gdansk_booking.LinkClicked += Gdansk_booking_LinkClicked;
            // 
            // Wroclaw_booking
            // 
            Wroclaw_booking.AutoSize = true;
            Wroclaw_booking.BackColor = Color.White;
            Wroclaw_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Wroclaw_booking.Location = new Point(1491, 703);
            Wroclaw_booking.Name = "Wroclaw_booking";
            Wroclaw_booking.Size = new Size(100, 30);
            Wroclaw_booking.TabIndex = 189;
            Wroclaw_booking.TabStop = true;
            Wroclaw_booking.Text = "Wrocław";
            Wroclaw_booking.LinkClicked += Wroclaw_booking_LinkClicked;
            // 
            // Krakow_booking
            // 
            Krakow_booking.AutoSize = true;
            Krakow_booking.BackColor = Color.White;
            Krakow_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Krakow_booking.Location = new Point(1492, 657);
            Krakow_booking.Name = "Krakow_booking";
            Krakow_booking.Size = new Size(88, 30);
            Krakow_booking.TabIndex = 188;
            Krakow_booking.TabStop = true;
            Krakow_booking.Text = "Kraków";
            Krakow_booking.LinkClicked += Krakow_booking_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.ForeColor = SystemColors.Menu;
            label8.Location = new Point(1429, 798);
            label8.Name = "label8";
            label8.Size = new Size(35, 32);
            label8.TabIndex = 187;
            label8.Text = "5.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.Menu;
            label6.Location = new Point(1429, 751);
            label6.Name = "label6";
            label6.Size = new Size(35, 32);
            label6.TabIndex = 186;
            label6.Text = "4.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = SystemColors.Menu;
            label7.Location = new Point(1429, 701);
            label7.Name = "label7";
            label7.Size = new Size(35, 32);
            label7.TabIndex = 185;
            label7.Text = "3.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.Menu;
            label5.Location = new Point(1429, 655);
            label5.Name = "label5";
            label5.Size = new Size(35, 32);
            label5.TabIndex = 184;
            label5.Text = "2.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.Menu;
            label4.Location = new Point(1429, 605);
            label4.Name = "label4";
            label4.Size = new Size(35, 32);
            label4.TabIndex = 183;
            label4.Text = "1.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.Menu;
            label3.Location = new Point(1429, 523);
            label3.Name = "label3";
            label3.Size = new Size(389, 64);
            label3.TabIndex = 182;
            label3.Text = "Lista Top 5 odwiedzanych miast, \r\nzobacz noclegi:";
            // 
            // Warszawa_booking
            // 
            Warszawa_booking.AutoSize = true;
            Warszawa_booking.BackColor = Color.White;
            Warszawa_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Warszawa_booking.Location = new Point(1492, 607);
            Warszawa_booking.Name = "Warszawa_booking";
            Warszawa_booking.Size = new Size(110, 30);
            Warszawa_booking.TabIndex = 181;
            Warszawa_booking.TabStop = true;
            Warszawa_booking.Text = "Warszawa";
            Warszawa_booking.LinkClicked += Warszawa_booking_LinkClicked;
            // 
            // bookingPolska
            // 
            bookingPolska.Location = new Point(1080, 607);
            bookingPolska.Name = "bookingPolska";
            bookingPolska.Size = new Size(169, 62);
            bookingPolska.TabIndex = 192;
            bookingPolska.Text = "Noclegi cała Polska";
            bookingPolska.UseVisualStyleBackColor = true;
            bookingPolska.Click += bookingPolska_Click;
            // 
            // Polska
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(bookingPolska);
            Controls.Add(Zakopane_booking);
            Controls.Add(Gdansk_booking);
            Controls.Add(Wroclaw_booking);
            Controls.Add(Krakow_booking);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Warszawa_booking);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoPolska1);
            Controls.Add(InfoPolska);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisPolska);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Polska";
            Text = "Polska";
            Load += Polska_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoPolska1;
        protected TextBox InfoPolska;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisPolska;
        private LinkLabel Zakopane_booking;
        private LinkLabel Gdansk_booking;
        private LinkLabel Wroclaw_booking;
        private LinkLabel Krakow_booking;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private LinkLabel Warszawa_booking;
        private Button bookingPolska;
    }
}