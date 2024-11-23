namespace EuroExplorer
{
    partial class Malta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Malta));
            Back = new Button();
            Opis = new Label();
            InfoMalta1 = new TextBox();
            InfoMalta = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisMalta = new TextBox();
            Marsaxlokk_booking = new LinkLabel();
            Gozo_booking = new LinkLabel();
            Sliema_booking = new LinkLabel();
            Mdina_booking = new LinkLabel();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Valletta_booking = new LinkLabel();
            bookingMalta = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 14);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 127;
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
            Opis.TabIndex = 126;
            Opis.Text = "Opis Live :";
            // 
            // InfoMalta1
            // 
            InfoMalta1.BackColor = Color.White;
            InfoMalta1.Enabled = false;
            InfoMalta1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoMalta1.Location = new Point(1429, 423);
            InfoMalta1.Multiline = true;
            InfoMalta1.Name = "InfoMalta1";
            InfoMalta1.Size = new Size(463, 67);
            InfoMalta1.TabIndex = 125;
            InfoMalta1.TextChanged += InfoMalta1_TextChanged;
            // 
            // InfoMalta
            // 
            InfoMalta.BackColor = Color.White;
            InfoMalta.Enabled = false;
            InfoMalta.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoMalta.Location = new Point(1429, 350);
            InfoMalta.Multiline = true;
            InfoMalta.Name = "InfoMalta";
            InfoMalta.Size = new Size(463, 67);
            InfoMalta.TabIndex = 124;
            InfoMalta.TextChanged += InfoMalta_TextChanged;
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
            label2.TabIndex = 123;
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
            label1.TabIndex = 122;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 121;
            pictureBox1.TabStop = false;
            // 
            // OpisMalta
            // 
            OpisMalta.BackColor = Color.White;
            OpisMalta.Enabled = false;
            OpisMalta.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisMalta.Location = new Point(12, 278);
            OpisMalta.Multiline = true;
            OpisMalta.Name = "OpisMalta";
            OpisMalta.Size = new Size(841, 716);
            OpisMalta.TabIndex = 120;
            OpisMalta.Text = resources.GetString("OpisMalta.Text");
            // 
            // Marsaxlokk_booking
            // 
            Marsaxlokk_booking.AutoSize = true;
            Marsaxlokk_booking.BackColor = Color.White;
            Marsaxlokk_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Marsaxlokk_booking.Location = new Point(1492, 801);
            Marsaxlokk_booking.Name = "Marsaxlokk_booking";
            Marsaxlokk_booking.Size = new Size(127, 30);
            Marsaxlokk_booking.TabIndex = 180;
            Marsaxlokk_booking.TabStop = true;
            Marsaxlokk_booking.Text = "Marsaxlokk";
            Marsaxlokk_booking.LinkClicked += Marsaxlokk_booking_LinkClicked;
            // 
            // Gozo_booking
            // 
            Gozo_booking.AutoSize = true;
            Gozo_booking.BackColor = Color.White;
            Gozo_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Gozo_booking.Location = new Point(1491, 754);
            Gozo_booking.Name = "Gozo_booking";
            Gozo_booking.Size = new Size(64, 30);
            Gozo_booking.TabIndex = 179;
            Gozo_booking.TabStop = true;
            Gozo_booking.Text = "Gozo";
            Gozo_booking.LinkClicked += Gozo_booking_LinkClicked;
            // 
            // Sliema_booking
            // 
            Sliema_booking.AutoSize = true;
            Sliema_booking.BackColor = Color.White;
            Sliema_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Sliema_booking.Location = new Point(1491, 704);
            Sliema_booking.Name = "Sliema_booking";
            Sliema_booking.Size = new Size(78, 30);
            Sliema_booking.TabIndex = 178;
            Sliema_booking.TabStop = true;
            Sliema_booking.Text = "Sliema";
            Sliema_booking.LinkClicked += Sliema_booking_LinkClicked;
            // 
            // Mdina_booking
            // 
            Mdina_booking.AutoSize = true;
            Mdina_booking.BackColor = Color.White;
            Mdina_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Mdina_booking.Location = new Point(1492, 658);
            Mdina_booking.Name = "Mdina_booking";
            Mdina_booking.Size = new Size(76, 30);
            Mdina_booking.TabIndex = 177;
            Mdina_booking.TabStop = true;
            Mdina_booking.Text = "Mdina";
            Mdina_booking.LinkClicked += Mdina_booking_LinkClicked;
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
            label8.TabIndex = 176;
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
            label6.TabIndex = 175;
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
            label7.TabIndex = 174;
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
            label5.TabIndex = 173;
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
            label4.TabIndex = 172;
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
            label3.TabIndex = 171;
            label3.Text = "Lista Top 5 odwiedzanych miast, \r\nzobacz noclegi:";
            label3.Click += label3_Click;
            // 
            // Valletta_booking
            // 
            Valletta_booking.AutoSize = true;
            Valletta_booking.BackColor = Color.White;
            Valletta_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Valletta_booking.Location = new Point(1492, 608);
            Valletta_booking.Name = "Valletta_booking";
            Valletta_booking.Size = new Size(86, 30);
            Valletta_booking.TabIndex = 170;
            Valletta_booking.TabStop = true;
            Valletta_booking.Text = "Valletta";
            Valletta_booking.LinkClicked += Valletta_booking_LinkClicked;
            // 
            // bookingMalta
            // 
            bookingMalta.Location = new Point(1080, 646);
            bookingMalta.Name = "bookingMalta";
            bookingMalta.Size = new Size(169, 62);
            bookingMalta.TabIndex = 181;
            bookingMalta.Text = "Noclegi cała Malta";
            bookingMalta.UseVisualStyleBackColor = true;
            bookingMalta.Click += bookingMalta_Click;
            // 
            // Malta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(bookingMalta);
            Controls.Add(Marsaxlokk_booking);
            Controls.Add(Gozo_booking);
            Controls.Add(Sliema_booking);
            Controls.Add(Mdina_booking);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Valletta_booking);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoMalta1);
            Controls.Add(InfoMalta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisMalta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Malta";
            Text = "Malta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoMalta1;
        protected TextBox InfoMalta;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisMalta;
        private LinkLabel Marsaxlokk_booking;
        private LinkLabel Gozo_booking;
        private LinkLabel Sliema_booking;
        private LinkLabel Mdina_booking;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private LinkLabel Valletta_booking;
        private Button bookingMalta;
    }
}