﻿namespace EuroExplorer
{
    partial class Słowenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Słowenia));
            Back = new Button();
            Opis = new Label();
            InfoSłowenia1 = new TextBox();
            InfoSłowenia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisSłowenia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 13);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 167;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.Location = new Point(1593, 277);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 166;
            Opis.Text = "Opis Live :";
            // 
            // InfoSłowenia1
            // 
            InfoSłowenia1.BackColor = Color.FromArgb(255, 224, 192);
            InfoSłowenia1.Enabled = false;
            InfoSłowenia1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoSłowenia1.Location = new Point(1429, 422);
            InfoSłowenia1.Multiline = true;
            InfoSłowenia1.Name = "InfoSłowenia1";
            InfoSłowenia1.Size = new Size(463, 67);
            InfoSłowenia1.TabIndex = 165;
            InfoSłowenia1.TextChanged += InfoSłowenia1_TextChanged;
            // 
            // InfoSłowenia
            // 
            InfoSłowenia.BackColor = Color.FromArgb(255, 224, 192);
            InfoSłowenia.Enabled = false;
            InfoSłowenia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoSłowenia.Location = new Point(1429, 349);
            InfoSłowenia.Multiline = true;
            InfoSłowenia.Name = "InfoSłowenia";
            InfoSłowenia.Size = new Size(463, 67);
            InfoSłowenia.TabIndex = 164;
            InfoSłowenia.TextChanged += InfoSłowenia_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 277);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 163;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 210);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 162;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 161;
            pictureBox1.TabStop = false;
            // 
            // OpisSłowenia
            // 
            OpisSłowenia.BackColor = Color.FromArgb(255, 224, 192);
            OpisSłowenia.Enabled = false;
            OpisSłowenia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisSłowenia.Location = new Point(12, 274);
            OpisSłowenia.Multiline = true;
            OpisSłowenia.Name = "OpisSłowenia";
            OpisSłowenia.Size = new Size(841, 715);
            OpisSłowenia.TabIndex = 160;
            OpisSłowenia.Text = resources.GetString("OpisSłowenia.Text");
            // 
            // Słowenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoSłowenia1);
            Controls.Add(InfoSłowenia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisSłowenia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Słowenia";
            Text = "Słowenia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoSłowenia1;
        protected TextBox InfoSłowenia;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisSłowenia;
    }
}