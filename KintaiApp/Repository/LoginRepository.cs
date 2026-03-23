using KintaiApp.Infrastructure;
using KintaiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintaiApp.Repository
{
    public class LoginRepository
    {
        public LoginInfo LoadLoginInfo(LoginCondition condition)
        {
            using var cmd = DbConnectManager.GetConnection().CreateCommand();
            cmd.CommandText = DbConnectManager.SqlLoad("Login", "CheckUser");

            cmd.Parameters.AddWithValue("@CompanyId", condition.CompanyId);
            cmd.Parameters.AddWithValue("@Email", condition.Email);
            cmd.Parameters.AddWithValue("@UserName", condition.UserName);
            cmd.Parameters.AddWithValue("@Password", condition.Password);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new LoginInfo
            {
                CompanyId = reader["company_id"].ToString(),
                Email = reader["email"].ToString(),
                UserName = reader["name"].ToString(),
                Password = reader["password_hash"].ToString()
            };
        }
    }
}
