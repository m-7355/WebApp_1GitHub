using KintaiApp.Infrastructure;
using KintaiApp.Models;
using KintaiApp.Repository;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace KintaiApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // 接続後取得
            DbConnectManager.connect("MySqlConnection");
        }

        /// <summary>
        /// ログインボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Buttom_Click(object sender, EventArgs e)
        {
            //var condition = new LoginCondition
            //{
            //    CompanyId = Company_ID_Text.Text,
            //    Email = ID_Text.Text,
            //    UserName = ID_Text.Text,
            //    Password = Password_Text.Text
            //};

            //var repo = new LoginRepository();
            //var info = repo.LoadLoginInfo(condition);

            //if (info == null)
            //{
            //    MessageBox.Show("ログイン情報が間違っています");
            //    return;
            //}

            // ログイン成功
            this.Hide();
            var next = new EmployeeForm();
            next.ShowDialog();
            this.Close();
        }
    }



}
