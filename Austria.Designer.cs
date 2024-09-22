namespace EuroExplorer
{
    partial class Austria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Austria));
            OpisAustrii = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Opis = new Label();
            InfoAustria = new TextBox();
            InfoAustria1 = new TextBox();
            Back = new Button();
            bookingAustria = new Button();
            Wieden_booking = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Salzburg_booking = new LinkLabel();
            Innsbruck_booking = new LinkLabel();
            Hallstatt_i_region_Salzkammergut_booking = new LinkLabel();
            Tyrol_booking = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OpisAustrii
            // 
            OpisAustrii.BackColor = Color.White;
            OpisAustrii.Enabled = false;
            OpisAustrii.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisAustrii.Location = new Point(12, 156);
            OpisAustrii.Multiline = true;
            OpisAustrii.Name = "OpisAustrii";
            OpisAustrii.Size = new Size(841, 450);
            OpisAustrii.TabIndex = 0;
            OpisAustrii.Text = resources.GetString("OpisAustrii.Text");
            OpisAustrii.TextChanged += OpisAustrii_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 89);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 2;
            label1.Text = "Opis :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 156);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 3;
            label2.Text = "Terytorium :";
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.BackColor = Color.Transparent;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.ForeColor = SystemColors.Menu;
            Opis.Location = new Point(1579, 159);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 4;
            Opis.Text = "Opis Live :";
            // 
            // InfoAustria
            // 
            InfoAustria.BackColor = Color.White;
            InfoAustria.Enabled = false;
            InfoAustria.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoAustria.Location = new Point(1429, 228);
            InfoAustria.Multiline = true;
            InfoAustria.Name = "InfoAustria";
            InfoAustria.Size = new Size(463, 67);
            InfoAustria.TabIndex = 5;
            InfoAustria.TextChanged += InfoAustria_TextChanged;
            // 
            // InfoAustria1
            // 
            InfoAustria1.BackColor = Color.White;
            InfoAustria1.Enabled = false;
            InfoAustria1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoAustria1.Location = new Point(1429, 301);
            InfoAustria1.Multiline = true;
            InfoAustria1.Name = "InfoAustria1";
            InfoAustria1.Size = new Size(463, 67);
            InfoAustria1.TabIndex = 6;
            InfoAustria1.TextChanged += InfoAustria1_TextChanged;
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.ForeColor = SystemColors.ActiveCaptionText;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 7;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // bookingAustria
            // 
            bookingAustria.Location = new Point(1080, 520);
            bookingAustria.Name = "bookingAustria";
            bookingAustria.Size = new Size(169, 62);
            bookingAustria.TabIndex = 8;
            bookingAustria.Text = "Noclegi cała Austria";
            bookingAustria.UseVisualStyleBackColor = true;
            bookingAustria.Click += bookingAustria_Click;
            // 
            // Wieden_booking
            // 
            Wieden_booking.AutoSize = true;
            Wieden_booking.BackColor = Color.White;
            Wieden_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Wieden_booking.Location = new Point(1490, 486);
            Wieden_booking.Name = "Wieden_booking";
            Wieden_booking.Size = new Size(88, 30);
            Wieden_booking.TabIndex = 9;
            Wieden_booking.TabStop = true;
            Wieden_booking.Text = "Wiedeń";
            Wieden_booking.LinkClicked += Wieden_booking_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.Menu;
            label3.Location = new Point(1429, 402);
            label3.Name = "label3";
            label3.Size = new Size(389, 64);
            label3.TabIndex = 10;
            label3.Text = "Lista Top 5 odwiedzanych miast, \r\nzobacz noclegi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.Menu;
            label4.Location = new Point(1429, 484);
            label4.Name = "label4";
            label4.Size = new Size(35, 32);
            label4.TabIndex = 11;
            label4.Text = "1.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.Menu;
            label5.Location = new Point(1429, 534);
            label5.Name = "label5";
            label5.Size = new Size(35, 32);
            label5.TabIndex = 12;
            label5.Text = "2.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.Menu;
            label6.Location = new Point(1429, 630);
            label6.Name = "label6";
            label6.Size = new Size(35, 32);
            label6.TabIndex = 14;
            label6.Text = "4.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = SystemColors.Menu;
            label7.Location = new Point(1429, 580);
            label7.Name = "label7";
            label7.Size = new Size(35, 32);
            label7.TabIndex = 13;
            label7.Text = "3.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.ForeColor = SystemColors.Menu;
            label8.Location = new Point(1429, 677);
            label8.Name = "label8";
            label8.Size = new Size(35, 32);
            label8.TabIndex = 15;
            label8.Text = "5.";
            // 
            // Salzburg_booking
            // 
            Salzburg_booking.AutoSize = true;
            Salzburg_booking.BackColor = Color.White;
            Salzburg_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Salzburg_booking.Location = new Point(1490, 536);
            Salzburg_booking.Name = "Salzburg_booking";
            Salzburg_booking.Size = new Size(99, 30);
            Salzburg_booking.TabIndex = 16;
            Salzburg_booking.TabStop = true;
            Salzburg_booking.Text = "Salzburg";
            Salzburg_booking.LinkClicked += Salzburg_booking_LinkClicked;
            // 
            // Innsbruck_booking
            // 
            Innsbruck_booking.AutoSize = true;
            Innsbruck_booking.BackColor = Color.White;
            Innsbruck_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Innsbruck_booking.Location = new Point(1490, 582);
            Innsbruck_booking.Name = "Innsbruck_booking";
            Innsbruck_booking.Size = new Size(111, 30);
            Innsbruck_booking.TabIndex = 17;
            Innsbruck_booking.TabStop = true;
            Innsbruck_booking.Text = "Innsbruck";
            Innsbruck_booking.LinkClicked += Innsbruck_booking_LinkClicked;
            // 
            // Hallstatt_i_region_Salzkammergut_booking
            // 
            Hallstatt_i_region_Salzkammergut_booking.AutoSize = true;
            Hallstatt_i_region_Salzkammergut_booking.BackColor = Color.White;
            Hallstatt_i_region_Salzkammergut_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Hallstatt_i_region_Salzkammergut_booking.Location = new Point(1489, 632);
            Hallstatt_i_region_Salzkammergut_booking.Name = "Hallstatt_i_region_Salzkammergut_booking";
            Hallstatt_i_region_Salzkammergut_booking.Size = new Size(337, 30);
            Hallstatt_i_region_Salzkammergut_booking.TabIndex = 18;
            Hallstatt_i_region_Salzkammergut_booking.TabStop = true;
            Hallstatt_i_region_Salzkammergut_booking.Text = "Hallstatt i region Salzkammergut";
            Hallstatt_i_region_Salzkammergut_booking.LinkClicked += Hallstatt_i_region_Salzkammergut_booking_LinkClicked;
            // 
            // Tyrol_booking
            // 
            Tyrol_booking.AutoSize = true;
            Tyrol_booking.BackColor = Color.White;
            Tyrol_booking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Tyrol_booking.Location = new Point(1490, 679);
            Tyrol_booking.Name = "Tyrol_booking";
            Tyrol_booking.Size = new Size(62, 30);
            Tyrol_booking.TabIndex = 19;
            Tyrol_booking.TabStop = true;
            Tyrol_booking.Text = "Tyrol";
            Tyrol_booking.LinkClicked += Tyrol_booking_LinkClicked;
            // 
            // Austria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Tyrol_booking);
            Controls.Add(Hallstatt_i_region_Salzkammergut_booking);
            Controls.Add(Innsbruck_booking);
            Controls.Add(Salzburg_booking);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Wieden_booking);
            Controls.Add(bookingAustria);
            Controls.Add(Back);
            Controls.Add(InfoAustria1);
            Controls.Add(InfoAustria);
            Controls.Add(Opis);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisAustrii);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Austria";
            Text = "Austria";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        protected TextBox OpisAustrii;
        private Label Opis;
        protected TextBox InfoAustria;
        protected TextBox InfoAustria1;
        private Button Back;
        private Button bookingAustria;
        private LinkLabel Wieden_booking;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private LinkLabel Salzburg_booking;
        private LinkLabel Innsbruck_booking;
        private LinkLabel Hallstatt_i_region_Salzkammergut_booking;
        private LinkLabel Tyrol_booking;
    }
}