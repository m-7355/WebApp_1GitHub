using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace KintaiApp.Infrastructure
{
    public class DbConnectManager
    {
        private static MySqlConnection connection;
        private static IConfiguration config;

        static DbConnectManager()
        {
            config = new ConfigurationBuilder()
                        .SetBasePath(AppContext.BaseDirectory)
                        .AddJsonFile("appsettings.json", optional: false)
                        .Build();
        }

        /// <summary>
        /// DB接続用メソッド
        /// 引数にキー名を代入し各テーブル接続
        /// </summary>
        /// <param name="constr"></param>
        public static void connect(string keyName)
        {
            if (connection != null) return;

            string conStr = config.GetConnectionString(keyName);

            try
            {
                connection = new MySqlConnection(conStr);
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("接続失敗" + e.Message);
                connection = null;
            }
        }

        public static string SqlLoad(string category, string key)
        {
            string relative = config[$"SqlPaths:{category}:{key}"];
            string fullPath = Path.Combine(AppContext.BaseDirectory, relative);
            return File.ReadAllText(fullPath);
        }

        /// <summary>
        /// DB接続チェック
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static MySqlConnection GetConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                return connection;

            throw new Exception("DBが接続されていません。");
        }

        public static void Close()
        {
            if(connection != null)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }

    }
}
