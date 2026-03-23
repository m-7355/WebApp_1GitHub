namespace KintaiApp
{
    partial class AdominForm
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
            EmployeeListBtn = new Button();
            EmployeeRegisterBtn = new Button();
            EmployeeEditBtn = new Button();
            button1 = new Button();
            QuitExcute = new Button();
            PasswordResetBtn = new Button();
            SuspendLayout();
            // 
            // EmployeeListBtn
            // 
            EmployeeListBtn.Location = new Point(40, 91);
            EmployeeListBtn.Name = "EmployeeListBtn";
            EmployeeListBtn.Size = new Size(488, 42);
            EmployeeListBtn.TabIndex = 0;
            EmployeeListBtn.Text = "社員一覧";
            EmployeeListBtn.UseMnemonic = false;
            EmployeeListBtn.UseVisualStyleBackColor = true;
            // 
            // EmployeeRegisterBtn
            // 
            EmployeeRegisterBtn.Location = new Point(40, 181);
            EmployeeRegisterBtn.Name = "EmployeeRegisterBtn";
            EmployeeRegisterBtn.Size = new Size(488, 42);
            EmployeeRegisterBtn.TabIndex = 1;
            EmployeeRegisterBtn.Text = "社員登録";
            EmployeeRegisterBtn.UseMnemonic = false;
            EmployeeRegisterBtn.UseVisualStyleBackColor = true;
            // 
            // EmployeeEditBtn
            // 
            EmployeeEditBtn.Location = new Point(40, 279);
            EmployeeEditBtn.Name = "EmployeeEditBtn";
            EmployeeEditBtn.Size = new Size(488, 42);
            EmployeeEditBtn.TabIndex = 2;
            EmployeeEditBtn.Text = "社員情報の登録";
            EmployeeEditBtn.UseMnemonic = false;
            EmployeeEditBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(40, 374);
            button1.Name = "button1";
            button1.Size = new Size(488, 42);
            button1.TabIndex = 3;
            button1.Text = "社員情報の登録";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            // 
            // QuitExcute
            // 
            QuitExcute.Location = new Point(40, 463);
            QuitExcute.Name = "QuitExcute";
            QuitExcute.Size = new Size(488, 42);
            QuitExcute.TabIndex = 4;
            QuitExcute.Text = "退職処理";
            QuitExcute.UseMnemonic = false;
            QuitExcute.UseVisualStyleBackColor = true;
            // 
            // PasswordResetBtn
            // 
            PasswordResetBtn.Location = new Point(40, 551);
            PasswordResetBtn.Name = "PasswordResetBtn";
            PasswordResetBtn.Size = new Size(488, 42);
            PasswordResetBtn.TabIndex = 5;
            PasswordResetBtn.Text = "パスワードリセット";
            PasswordResetBtn.UseMnemonic = false;
            PasswordResetBtn.UseVisualStyleBackColor = true;
            // 
            // AdominForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 653);
            Controls.Add(PasswordResetBtn);
            Controls.Add(QuitExcute);
            Controls.Add(button1);
            Controls.Add(EmployeeEditBtn);
            Controls.Add(EmployeeRegisterBtn);
            Controls.Add(EmployeeListBtn);
            Name = "AdominForm";
            Text = "AdominForm";
            ResumeLayout(false);
        }

        #endregion

        private Button EmployeeListBtn;
        private Button EmployeeRegisterBtn;
        private Button EmployeeEditBtn;
        private Button button1;
        private Button QuitExcute;
        private Button PasswordResetBtn;
    }
}