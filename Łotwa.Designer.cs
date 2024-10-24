namespace EuroExplorer
{
    partial class Łotwa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Łotwa));
            Back = new Button();
            Opis = new Label();
            InfoŁotwa1 = new TextBox();
            InfoŁotwa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            v = new TextBox();
            bookingŁotwa = new Button();
            Liepaja_booking = new LinkLabel();
            Kuldiga_booking = new LinkLabel();
            Sigulda_booking = new LinkLabel();
            Jurmala_booking = new LinkLabel();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Ryga_booking = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 14);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 119;
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
            Opis.Location = new Point(1593, 278);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 118;
            Opis.Text = "Opis Live :";
            // 
            // InfoŁotwa1
            // 
            InfoŁotwa1.BackColor = Color.White;
            InfoŁotwa1.Enabled = false;
            InfoŁotwa1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoŁotwa1.Location = new Point(1429, 423);
            InfoŁotwa1.Multiline = true;
            InfoŁotwa1.Name = "InfoŁotwa1";
            InfoŁotwa1.Size = new Size(463, 67);
            InfoŁotwa1.TabIndex = 117;
            InfoŁotwa1.TextChanged += InfoŁotwa1_TextChanged;
            // 
            // InfoŁotwa
            // 
            InfoŁotwa.BackColor = Color.White;
            InfoŁotwa.Enabled = false;
            InfoŁotwa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoŁotwa.Location = new Point(1429, 350);
            InfoŁotwa.Multiline = true;
            InfoŁotwa.Name = "InfoŁotwa";
            InfoŁotwa.Size = new Size(463, 67);
            InfoŁotwa.TabIndex = 116;
            InfoŁotwa.TextChanged += InfoŁotwa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1094, 278);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 115;
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
            label1.TabIndex = 114;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 113;
            pictureBox1.TabStop = false;
            // 
            // v
            // 
            v.BackColor = Color.White;
            v.Enabled = false;
            v.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            v.Location = new Point(12, 278);
            v.Multiline = true;
            v.Name = "v";
            v.Size = new Size(841, 556);
            v.TabIndex = 112;
            v.Text = resources.GetString("v.Text");
            // 
            // bookingŁotwa
            // 
            bookingŁotwa.Location = new Point(1080, 644);
            bookingŁotwa.Name = "bookingŁotwa";
            bookingŁotwa.Size = new Size(169, 62);
            bookingŁotwa.TabIndex = 138;
            bookingŁotwa.Text = "Noclegi cała Łotwa";
            bookingŁotwa.UseVisualStyleBackColor = true;
            bookingŁotwa.Click += bookingŁotwa_Click;
            // 
            // Liepaja_booking
            // 
            Liepaja_booking.AutoSize = true;
            Liepaja_booking.BackColor = Color.White;
            Liepaja_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Liepaja_booking.Location = new Point(1492, 801);
            Liepaja_booking.Name = "Liepaja_booking";
            Liepaja_booking.Size = new Size(82, 30);
            Liepaja_booking.TabIndex = 169;
            Liepaja_booking.TabStop = true;
            Liepaja_booking.Text = "Liepāja";
            Liepaja_booking.LinkClicked += Liepaja_booking_LinkClicked;
            // 
            // Kuldiga_booking
            // 
            Kuldiga_booking.AutoSize = true;
            Kuldiga_booking.BackColor = Color.White;
            Kuldiga_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Kuldiga_booking.Location = new Point(1491, 754);
            Kuldiga_booking.Name = "Kuldiga_booking";
            Kuldiga_booking.Size = new Size(89, 30);
            Kuldiga_booking.TabIndex = 168;
            Kuldiga_booking.TabStop = true;
            Kuldiga_booking.Text = "Kuldīga";
            Kuldiga_booking.LinkClicked += Kuldiga_booking_LinkClicked;
            // 
            // Sigulda_booking
            // 
            Sigulda_booking.AutoSize = true;
            Sigulda_booking.BackColor = Color.White;
            Sigulda_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Sigulda_booking.Location = new Point(1491, 704);
            Sigulda_booking.Name = "Sigulda_booking";
            Sigulda_booking.Size = new Size(87, 30);
            Sigulda_booking.TabIndex = 167;
            Sigulda_booking.TabStop = true;
            Sigulda_booking.Text = "Sigulda";
            Sigulda_booking.LinkClicked += Sigulda_booking_LinkClicked;
            // 
            // Jurmala_booking
            // 
            Jurmala_booking.AutoSize = true;
            Jurmala_booking.BackColor = Color.White;
            Jurmala_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Jurmala_booking.Location = new Point(1492, 658);
            Jurmala_booking.Name = "Jurmala_booking";
            Jurmala_booking.Size = new Size(90, 30);
            Jurmala_booking.TabIndex = 166;
            Jurmala_booking.TabStop = true;
            Jurmala_booking.Text = "Jūrmala";
            Jurmala_booking.LinkClicked += Jurmala_booking_LinkClicked;
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
            label8.TabIndex = 165;
            label8.Text = "5.";
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
            label6.TabIndex = 164;
            label6.Text = "4.";
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
            label7.TabIndex = 163;
            label7.Text = "3.";
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
            label5.TabIndex = 162;
            label5.Text = "2.";
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
            label4.TabIndex = 161;
            label4.Text = "1.";
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
            label3.TabIndex = 160;
            label3.Text = "Lista Top 5 odwiedzanych miast, \r\nzobacz noclegi:";
            // 
            // Ryga_booking
            // 
            Ryga_booking.AutoSize = true;
            Ryga_booking.BackColor = Color.White;
            Ryga_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Ryga_booking.Location = new Point(1492, 608);
            Ryga_booking.Name = "Ryga_booking";
            Ryga_booking.Size = new Size(62, 30);
            Ryga_booking.TabIndex = 159;
            Ryga_booking.TabStop = true;
            Ryga_booking.Text = "Ryga";
            Ryga_booking.LinkClicked += Ryga_booking_LinkClicked;
            // 
            // Łotwa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Liepaja_booking);
            Controls.Add(Kuldiga_booking);
            Controls.Add(Sigulda_booking);
            Controls.Add(Jurmala_booking);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Ryga_booking);
            Controls.Add(bookingŁotwa);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoŁotwa1);
            Controls.Add(InfoŁotwa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(v);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Łotwa";
            Text = "Łotwa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoŁotwa1;
        protected TextBox InfoŁotwa;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox v;
        private Button bookingŁotwa;
        private LinkLabel Liepaja_booking;
        private LinkLabel Kuldiga_booking;
        private LinkLabel Sigulda_booking;
        private LinkLabel Jurmala_booking;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private LinkLabel Ryga_booking;
    }
}