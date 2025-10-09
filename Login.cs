using DB_SYNC3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DB_SYNC3
{
    public partial class Login : Form
    {
        private MyDbContext _db;


        public Login()
        {
            InitializeComponent();
            _db = new MyDbContext();
        }
    
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 登入功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _db.memb.Where(x => x.meno == txb_AD.Text && x.p == txb_PW.Text).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("帳號或密碼錯誤！");
                    return;
                }

                // ✅ 登入成功後儲存登入資訊
                GlobalConfig.CurrentUser = user;

                MessageBox.Show($"歡迎 {user.name} 登入成功！");

                // ✅ 開啟主畫面
                MainForm main = new MainForm();
                this.Hide();
                main.ShowDialog();

                // 回主畫面結束後關閉登入表單
                this.Close();

            }
            catch (Exception ex)
            {
                txb_error.Text = ex.Message;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
