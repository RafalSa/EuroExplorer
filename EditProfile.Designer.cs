namespace EuroExplorer
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            SaveFile = new Button();
            ChooseFile = new Button();
            NewPassword = new TextBox();
            NewName = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            label1 = new Label();
            OldName = new TextBox();
            OldPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ProfilePicture = new PictureBox();
            label4 = new Label();
            ChangeLogin = new Button();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // SaveFile
            // 
            SaveFile.Location = new Point(461, 571);
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(119, 29);
            SaveFile.TabIndex = 17;
            SaveFile.Text = "Zapisz zdjęcie";
            SaveFile.UseVisualStyleBackColor = true;
            SaveFile.Click += SaveFile_Click;
            // 
            // ChooseFile
            // 
            ChooseFile.Location = new Point(300, 571);
            ChooseFile.Name = "ChooseFile";
            ChooseFile.Size = new Size(119, 29);
            ChooseFile.TabIndex = 16;
            ChooseFile.Text = "Wybierz zdjęcie";
            ChooseFile.UseVisualStyleBackColor = true;
            ChooseFile.Click += ChooseFile_Click;
            // 
            // NewPassword
            // 
            NewPassword.Location = new Point(457, 213);
            NewPassword.Name = "NewPassword";
            NewPassword.Size = new Size(123, 23);
            NewPassword.TabIndex = 15;
            NewPassword.TextChanged += NewPassword_TextChanged;
            // 
            // NewName
            // 
            NewName.Location = new Point(457, 161);
            NewName.Name = "NewName";
            NewName.Size = new Size(123, 23);
            NewName.TabIndex = 14;
            NewName.TextChanged += NewName_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.ForeColor = SystemColors.Menu;
            passwordLabel.Location = new Point(180, 221);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(43, 15);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Hasło :";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(180, 169);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(48, 15);
            usernameLabel.TabIndex = 12;
            usernameLabel.Text = "Nazwa :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(395, 43);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 18;
            label1.Text = "Zmiany profilu";
            // 
            // OldName
            // 
            OldName.BackColor = Color.White;
            OldName.Enabled = false;
            OldName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OldName.Location = new Point(300, 161);
            OldName.Multiline = true;
            OldName.Name = "OldName";
            OldName.Size = new Size(123, 23);
            OldName.TabIndex = 141;
            OldName.TextAlign = HorizontalAlignment.Center;
            OldName.TextChanged += OldName_TextChanged;
            // 
            // OldPassword
            // 
            OldPassword.BackColor = Color.White;
            OldPassword.Enabled = false;
            OldPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OldPassword.Location = new Point(300, 213);
            OldPassword.Multiline = true;
            OldPassword.Name = "OldPassword";
            OldPassword.Size = new Size(123, 23);
            OldPassword.TabIndex = 142;
            OldPassword.TextAlign = HorizontalAlignment.Center;
            OldPassword.TextChanged += OldPassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(331, 112);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 143;
            label2.Text = "Aktualne";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(500, 112);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 144;
            label3.Text = "Nowe";
            // 
            // ProfilePicture
            // 
            ProfilePicture.BackgroundImageLayout = ImageLayout.Stretch;
            ProfilePicture.Location = new Point(300, 339);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(280, 202);
            ProfilePicture.TabIndex = 145;
            ProfilePicture.TabStop = false;
            ProfilePicture.Click += ProfilePicture_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Menu;
            label4.Location = new Point(180, 339);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 146;
            label4.Text = "Zdjęcie profilowe :";
            // 
            // ChangeLogin
            // 
            ChangeLogin.Location = new Point(461, 264);
            ChangeLogin.Name = "ChangeLogin";
            ChangeLogin.Size = new Size(119, 29);
            ChangeLogin.TabIndex = 147;
            ChangeLogin.Text = "Zmień dane";
            ChangeLogin.UseVisualStyleBackColor = true;
            ChangeLogin.Click += ChangeLogin_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 148;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(ChangeLogin);
            Controls.Add(label4);
            Controls.Add(ProfilePicture);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OldPassword);
            Controls.Add(OldName);
            Controls.Add(label1);
            Controls.Add(SaveFile);
            Controls.Add(ChooseFile);
            Controls.Add(NewPassword);
            Controls.Add(NewName);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Name = "EditProfile";
            Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveFile;
        private Button ChooseFile;
        private TextBox NewPassword;
        private TextBox NewName;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label label1;
        protected TextBox OldName;
        protected TextBox OldPassword;
        private Label label2;
        private Label label3;
        private PictureBox ProfilePicture;
        private Label label4;
        private Button ChangeLogin;
        private Button Back;
    }
}