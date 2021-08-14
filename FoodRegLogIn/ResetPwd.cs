using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;


namespace FoodRegLogIn
{
    public partial class ResetPwd : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        string Email;
        public ResetPwd(string Email)
        {
            this.Email = Email;
            InitializeComponent();
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                //MessageBox.Show("資料庫連線成功!");


                if(!txtNewPwd.Text.Equals(txtConfirmNewPwd.Text))
                {
                    MessageBox.Show("密碼前後要一致!!");
                }
                else
                {
                    SqlDataReader myReader = null;

                    SqlCommand myCommand = new SqlCommand("update FoodStoreLogin set isVertify=@isVertify,ManagerPwd=@Pwd where Email=@Email", conn);

                    myCommand.Parameters.Add("@isVertify", '1');
                    myCommand.Parameters.Add("@Pwd", PwdSecurity.Md5Encode(Convert.ToBase64String(Encoding.UTF8.GetBytes(txtConfirmNewPwd.Text))));//先Encode再Md5加密
                    myCommand.Parameters.Add("@Email", Email);

                    myCommand.ExecuteNonQuery();

                    MessageBox.Show("密碼重設成功!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連線失敗!" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        
    }
}
