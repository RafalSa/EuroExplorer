namespace EuroExplorer
{
    partial class Dania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dania));
            Opis = new Label();
            InfoDania1 = new TextBox();
            InfoDania = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisDania = new TextBox();
            Back = new Button();
            bookingDania = new Button();
            Bornholm_booking = new LinkLabel();
            Aalborg_booking = new LinkLabel();
            Odense_booking = new LinkLabel();
            Aarhus_booking = new LinkLabel();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Kopenhaga_booking = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.BackColor = Color.Transparent;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.ForeColor = SystemColors.Menu;
            Opis.Location = new Point(1593, 295);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 41;
            Opis.Text = "Opis Live :";
            // 
            // InfoDania1
            // 
            InfoDania1.BackColor = Color.White;
            InfoDania1.Enabled = false;
            InfoDania1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoDania1.Location = new Point(1429, 440);
            InfoDania1.Multiline = true;
            InfoDania1.Name = "InfoDania1";
            InfoDania1.Size = new Size(463, 67);
            InfoDania1.TabIndex = 40;
            InfoDania1.TextChanged += InfoDania1_TextChanged;
            // 
            // InfoDania
            // 
            InfoDania.BackColor = Color.White;
            InfoDania.Enabled = false;
            InfoDania.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoDania.Location = new Point(1429, 367);
            InfoDania.Multiline = true;
            InfoDania.Name = "InfoDania";
            InfoDania.Size = new Size(463, 67);
            InfoDania.TabIndex = 39;
            InfoDania.TextChanged += InfoDania_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 295);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 38;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 228);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 37;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 367);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // OpisDania
            // 
            OpisDania.BackColor = Color.White;
            OpisDania.Enabled = false;
            OpisDania.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisDania.Location = new Point(12, 295);
            OpisDania.Multiline = true;
            OpisDania.Name = "OpisDania";
            OpisDania.Size = new Size(841, 553);
            OpisDania.TabIndex = 35;
            OpisDania.Text = resources.GetString("OpisDania.Text");
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 42;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // bookingDania
            // 
            bookingDania.Location = new Point(1080, 634);
            bookingDania.Name = "bookingDania";
            bookingDania.Size = new Size(169, 62);
            bookingDania.TabIndex = 57;
            bookingDania.Text = "Noclegi cała Dania";
            bookingDania.UseVisualStyleBackColor = true;
            bookingDania.Click += bookingDania_Click;
            // 
            // Bornholm_booking
            // 
            Bornholm_booking.AutoSize = true;
            Bornholm_booking.BackColor = Color.White;
            Bornholm_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Bornholm_booking.Location = new Point(1490, 818);
            Bornholm_booking.Name = "Bornholm_booking";
            Bornholm_booking.Size = new Size(111, 30);
            Bornholm_booking.TabIndex = 68;
            Bornholm_booking.TabStop = true;
            Bornholm_booking.Text = "Bornholm";
            Bornholm_booking.LinkClicked += Bornholm_booking_LinkClicked;
            // 
            // Aalborg_booking
            // 
            Aalborg_booking.AutoSize = true;
            Aalborg_booking.BackColor = Color.White;
            Aalborg_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Aalborg_booking.Location = new Point(1489, 771);
            Aalborg_booking.Name = "Aalborg_booking";
            Aalborg_booking.Size = new Size(92, 30);
            Aalborg_booking.TabIndex = 67;
            Aalborg_booking.TabStop = true;
            Aalborg_booking.Text = "Aalborg";
            Aalborg_booking.LinkClicked += Aalborg_booking_LinkClicked;
            // 
            // Odense_booking
            // 
            Odense_booking.AutoSize = true;
            Odense_booking.BackColor = Color.White;
            Odense_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Odense_booking.Location = new Point(1490, 721);
            Odense_booking.Name = "Odense_booking";
            Odense_booking.Size = new Size(86, 30);
            Odense_booking.TabIndex = 66;
            Odense_booking.TabStop = true;
            Odense_booking.Text = "Odense";
            Odense_booking.LinkClicked += Odense_booking_LinkClicked;
            // 
            // Aarhus_booking
            // 
            Aarhus_booking.AutoSize = true;
            Aarhus_booking.BackColor = Color.White;
            Aarhus_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Aarhus_booking.Location = new Point(1490, 675);
            Aarhus_booking.Name = "Aarhus_booking";
            Aarhus_booking.Size = new Size(82, 30);
            Aarhus_booking.TabIndex = 65;
            Aarhus_booking.TabStop = true;
            Aarhus_booking.Text = "Aarhus";
            Aarhus_booking.LinkClicked += Aarhus_booking_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.ForeColor = SystemColors.Menu;
            label8.Location = new Point(1429, 816);
            label8.Name = "label8";
            label8.Size = new Size(35, 32);
            label8.TabIndex = 64;
            label8.Text = "5.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.Menu;
            label6.Location = new Point(1429, 769);
            label6.Name = "label6";
            label6.Size = new Size(35, 32);
            label6.TabIndex = 63;
            label6.Text = "4.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = SystemColors.Menu;
            label7.Location = new Point(1429, 719);
            label7.Name = "label7";
            label7.Size = new Size(35, 32);
            label7.TabIndex = 62;
            label7.Text = "3.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.Menu;
            label5.Location = new Point(1429, 673);
            label5.Name = "label5";
            label5.Size = new Size(35, 32);
            label5.TabIndex = 61;
            label5.Text = "2.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.Menu;
            label4.Location = new Point(1429, 623);
            label4.Name = "label4";
            label4.Size = new Size(35, 32);
            label4.TabIndex = 60;
            label4.Text = "1.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.Menu;
            label3.Location = new Point(1429, 541);
            label3.Name = "label3";
            label3.Size = new Size(389, 64);
            label3.TabIndex = 59;
            label3.Text = "Lista Top 5 odwiedzanych miast, \r\nzobacz noclegi:";
            // 
            // Kopenhaga_booking
            // 
            Kopenhaga_booking.AutoSize = true;
            Kopenhaga_booking.BackColor = Color.White;
            Kopenhaga_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Kopenhaga_booking.Location = new Point(1490, 625);
            Kopenhaga_booking.Name = "Kopenhaga_booking";
            Kopenhaga_booking.Size = new Size(125, 30);
            Kopenhaga_booking.TabIndex = 58;
            Kopenhaga_booking.TabStop = true;
            Kopenhaga_booking.Text = "Kopenhaga";
            Kopenhaga_booking.LinkClicked += Kopenhaga_booking_LinkClicked;
            // 
            // Dania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Bornholm_booking);
            Controls.Add(Aalborg_booking);
            Controls.Add(Odense_booking);
            Controls.Add(Aarhus_booking);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Kopenhaga_booking);
            Controls.Add(bookingDania);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoDania1);
            Controls.Add(InfoDania);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisDania);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dania";
            Text = "Dania";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Opis;
        protected TextBox InfoDania1;
        protected TextBox InfoDania;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisDania;
        private Button Back;
        private Button bookingDania;
        private LinkLabel Bornholm_booking;
        private LinkLabel Aalborg_booking;
        private LinkLabel Odense_booking;
        private LinkLabel Aarhus_booking;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private LinkLabel Kopenhaga_booking;
    }
}