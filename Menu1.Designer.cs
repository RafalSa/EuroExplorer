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
            Czat = new Button();
            Map = new Button();
            ListaPanstw = new Button();
            ListaPanel = new Button();
            Chat = new ListBox();
            Send = new Button();
            Message = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(Czat);
            panel1.Controls.Add(Map);
            panel1.Controls.Add(ListaPanstw);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 1048);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            ListaPanstw.Text = "Lista Państw";
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
            // Chat
            // 
            Chat.FormattingEnabled = true;
            Chat.ItemHeight = 15;
            Chat.Location = new Point(207, 1);
            Chat.Name = "Chat";
            Chat.Size = new Size(1685, 919);
            Chat.TabIndex = 2;
            Chat.SelectedIndexChanged += Chat_SelectedIndexChanged;
            // 
            // Send
            // 
            Send.Location = new Point(1778, 939);
            Send.Name = "Send";
            Send.Size = new Size(114, 28);
            Send.TabIndex = 3;
            Send.Text = "Wyślij";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // Message
            // 
            Message.Location = new Point(207, 939);
            Message.Name = "Message";
            Message.Size = new Size(1552, 23);
            Message.TabIndex = 4;
            Message.TextChanged += Message_TextChanged;
            // 
            // Menu1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Message);
            Controls.Add(Send);
            Controls.Add(Chat);
            Controls.Add(ListaPanel);
            Controls.Add(panel1);
            Name = "Menu1";
            Text = "Menu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button ListaPanel;
        private Button Czat;
        private Button Map;
        private Button ListaPanstw;
        private ListBox Chat;
        private Button Send;
        private TextBox Message;
    }
}
