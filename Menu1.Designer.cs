namespace EuroExplorer
{
    partial class Menu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1));
            panel1 = new Panel();
            BNB = new Button();
            button1 = new Button();
            Czat = new Button();
            Map = new Button();
            ListaPanstw = new Button();
            ListaPanel = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            Profil = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(Profil);
            panel1.Controls.Add(BNB);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Czat);
            panel1.Controls.Add(Map);
            panel1.Controls.Add(ListaPanstw);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 1048);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BNB
            // 
            BNB.Location = new Point(17, 331);
            BNB.Name = "BNB";
            BNB.Size = new Size(171, 38);
            BNB.TabIndex = 6;
            BNB.Text = "Tanie noclegi";
            BNB.UseVisualStyleBackColor = true;
            BNB.Click += BNB_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 272);
            button1.Name = "button1";
            button1.Size = new Size(171, 38);
            button1.TabIndex = 5;
            button1.Text = "Booking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Czat
            // 
            Czat.Location = new Point(17, 212);
            Czat.Name = "Czat";
            Czat.Size = new Size(171, 38);
            Czat.TabIndex = 4;
            Czat.Text = "Czat";
            Czat.UseVisualStyleBackColor = true;
            Czat.Click += Czat_Click;
            // 
            // Map
            // 
            Map.Location = new Point(17, 150);
            Map.Name = "Map";
            Map.Size = new Size(171, 38);
            Map.TabIndex = 3;
            Map.Text = "Mapa";
            Map.UseVisualStyleBackColor = true;
            Map.Click += Map_Click;
            // 
            // ListaPanstw
            // 
            ListaPanstw.Location = new Point(17, 88);
            ListaPanstw.Name = "ListaPanstw";
            ListaPanstw.Size = new Size(171, 38);
            ListaPanstw.TabIndex = 2;
            ListaPanstw.Text = "Lista Państw oraz mapa";
            ListaPanstw.UseVisualStyleBackColor = true;
            ListaPanstw.Click += ListaPanstw_Click;
            // 
            // ListaPanel
            // 
            ListaPanel.BackColor = Color.Transparent;
            ListaPanel.BackgroundImage = (Image)resources.GetObject("ListaPanel.BackgroundImage");
            ListaPanel.BackgroundImageLayout = ImageLayout.Stretch;
            ListaPanel.Location = new Point(12, 12);
            ListaPanel.Name = "ListaPanel";
            ListaPanel.Size = new Size(32, 31);
            ListaPanel.TabIndex = 1;
            ListaPanel.UseVisualStyleBackColor = false;
            ListaPanel.Click += ListaPanel_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(207, 12);
            webView21.Name = "webView21";
            webView21.Size = new Size(1685, 984);
            webView21.TabIndex = 2;
            webView21.ZoomFactor = 1D;
            // 
            // Profil
            // 
            Profil.BackgroundImage = (Image)resources.GetObject("Profil.BackgroundImage");
            Profil.BackgroundImageLayout = ImageLayout.Stretch;
            Profil.Location = new Point(149, 17);
            Profil.Name = "Profil";
            Profil.Size = new Size(39, 31);
            Profil.TabIndex = 7;
            Profil.UseVisualStyleBackColor = true;
            Profil.Click += Profil_Click;
            // 
            // Menu1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(ListaPanel);
            Controls.Add(panel1);
            Controls.Add(webView21);
            Name = "Menu1";
            Text = "Menu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ListaPanel;
        private Button Czat;
        private Button Map;
        private Button ListaPanstw;
        private Button button1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button BNB;
        private Button Profil;
    }
}
