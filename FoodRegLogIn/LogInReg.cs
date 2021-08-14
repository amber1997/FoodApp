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
using FoodApp;

namespace FoodRegLogIn
{
    public partial class FrmRegLogin : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        public FrmRegLogin()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                //MessageBox.Show("資料庫連線成功!");



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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {

                string strSQL = ("exec SP_FoodLogIn @ID,@Pwd");
                string[] parameterName = { "@ID", "@Pwd" };  
                string[] parameterVal = {txtID.Text, PwdSecurity.Md5Encode(Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPwd.Text))) };
                SqlCommand cmd = new SqlCommand(strSQL, conn);


                for(int i=0;i<parameterName.Length;i++)
                {
                    cmd.Parameters.Add(parameterName[i], parameterVal[i]);
                }

                
                conn.Open();
                cmd.ExecuteNonQuery();

                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from LogInStatus where [ManagerID]=@ID ",conn);
                myCommand.Parameters.Add("@ID", txtID.Text);
                
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string s = myReader["AccStatus"].ToString();
                    if (myReader["AccStatus"].ToString().Equals("4"))//密碼被鎖定
                    {


                        MessageBox.Show(myReader["StatusMemo"].ToString());
                        break;
                    }
                    else if(myReader["AccStatus"].ToString().Equals("3"))//查無帳號，需要註冊
                    {
                        MessageBox.Show(myReader["StatusMemo"].ToString());
                        break;
                    }
                    else if(myReader["AccStatus"].ToString().Equals("2"))//密碼錯誤
                    {

                        MessageBox.Show(myReader["StatusMemo"].ToString());
                        break;
                    }
                    else if(myReader["AccStatus"].ToString().Equals("1"))//登入成功
                    {
                        MessageBox.Show(myReader["StatusMemo"].ToString());
                        
                        FoodBoss foodApp = new FoodBoss(txtID.Text);
                        
                        foodApp.ShowDialog();
                        
                        break;
                    }

                    else if (myReader["AccStatus"].ToString().Equals("5"))//帳號未驗證
                    {
                        MessageBox.Show(myReader["StatusMemo"].ToString());
                        
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                conn.Close();
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                frmRegister register = new frmRegister();
                register.ShowDialog();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }

        private void linkLbForgetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPwd forgetPwd = new ForgetPwd();
            forgetPwd.ShowDialog();
        }

        private void FrmRegLogin_Load(object sender, EventArgs e)
        {

            
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {

            frmDeleteAcc frmDelete = new frmDeleteAcc();

            frmDelete.ShowDialog();
            
        }
    }
}
