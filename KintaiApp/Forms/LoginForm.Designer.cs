namespace KintaiApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Company_ID = new Label();
            Company_ID_Text = new TextBox();
            App_Name = new Label();
            Login_Buttom = new Button();
            Keep_CheckBox = new CheckBox();
            Passwoed_Change = new Label();
            ID_Text = new TextBox();
            ID = new Label();
            Password_Text = new TextBox();
            Password = new Label();
            SuspendLayout();
            // 
            // Company_ID
            // 
            Company_ID.AutoSize = true;
            Company_ID.Location = new Point(63, 87);
            Company_ID.Name = "Company_ID";
            Company_ID.Size = new Size(54, 20);
            Company_ID.TabIndex = 0;
            Company_ID.Text = "企業ID";
            // 
            // Company_ID_Text
            // 
            Company_ID_Text.Location = new Point(63, 124);
            Company_ID_Text.Name = "Company_ID_Text";
            Company_ID_Text.Size = new Size(464, 27);
            Company_ID_Text.TabIndex = 1;
            // 
            // App_Name
            // 
            App_Name.AutoSize = true;
            App_Name.Location = new Point(248, 32);
            App_Name.Name = "App_Name";
            App_Name.Size = new Size(39, 20);
            App_Name.TabIndex = 4;
            App_Name.Text = "仮名";
            // 
            // Login_Buttom
            // 
            Login_Buttom.Location = new Point(63, 403);
            Login_Buttom.Name = "Login_Buttom";
            Login_Buttom.Size = new Size(464, 29);
            Login_Buttom.TabIndex = 7;
            Login_Buttom.Text = "ログイン";
            Login_Buttom.UseVisualStyleBackColor = true;
            Login_Buttom.Click += Login_Buttom_Click;
            // 
            // Keep_CheckBox
            // 
            Keep_CheckBox.AutoSize = true;
            Keep_CheckBox.Location = new Point(63, 359);
            Keep_CheckBox.Name = "Keep_CheckBox";
            Keep_CheckBox.Size = new Size(374, 24);
            Keep_CheckBox.TabIndex = 8;
            Keep_CheckBox.Text = "企業IDと社員番号もしくはメールアドレス、パスワードを保存";
            Keep_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Passwoed_Change
            // 
            Passwoed_Change.AutoSize = true;
            Passwoed_Change.Cursor = Cursors.Hand;
            Passwoed_Change.Font = new Font("Yu Gothic UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 128);
            Passwoed_Change.Location = new Point(166, 454);
            Passwoed_Change.Name = "Passwoed_Change";
            Passwoed_Change.Size = new Size(260, 20);
            Passwoed_Change.TabIndex = 9;
            Passwoed_Change.Text = "パスワードを忘れた/変更したい場合はこちら";
            // 
            // ID_Text
            // 
            ID_Text.Location = new Point(63, 218);
            ID_Text.Name = "ID_Text";
            ID_Text.Size = new Size(464, 27);
            ID_Text.TabIndex = 11;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(63, 181);
            ID.Name = "ID";
            ID.Size = new Size(190, 20);
            ID.TabIndex = 10;
            ID.Text = "社員番号もしくはメールアドレス";
            // 
            // Password_Text
            // 
            Password_Text.Location = new Point(63, 309);
            Password_Text.Name = "Password_Text";
            Password_Text.Size = new Size(464, 27);
            Password_Text.TabIndex = 13;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(63, 272);
            Password.Name = "Password";
            Password.Size = new Size(64, 20);
            Password.TabIndex = 12;
            Password.Text = "パスワード";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 653);
            Controls.Add(Password_Text);
            Controls.Add(Password);
            Controls.Add(ID_Text);
            Controls.Add(ID);
            Controls.Add(Passwoed_Change);
            Controls.Add(Keep_CheckBox);
            Controls.Add(Login_Buttom);
            Controls.Add(App_Name);
            Controls.Add(Company_ID_Text);
            Controls.Add(Company_ID);
            Name = "LoginForm";
            ShowIcon = false;
            Text = "ログイン";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Company_ID;
        private TextBox Company_ID_Text;
        private Label App_Name;
        private Button Login_Buttom;
        private CheckBox Keep_CheckBox;
        private Label Passwoed_Change;
        private TextBox ID_Text;
        private Label ID;
        private TextBox Password_Text;
        private Label Password;
    }
}
