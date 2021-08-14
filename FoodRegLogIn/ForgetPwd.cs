using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FoodRegLogIn
{
    public partial class ForgetPwd : Form 
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public ForgetPwd()
        {
            InitializeComponent();
           
        }

        private void UpdateIsVertifyZero()
        {
            try
            {
                //忘記密碼，設定為2:忘記密碼

                conn.Close();
               
                    string strSQL = ("update FoodStoreLogin set isVertify=@isVertify where Email=@Email and isVertify>= @Vertify ");

                    SqlCommand cmd = new SqlCommand(strSQL, conn);

                    cmd.Parameters.Add("@isVertify", "2");
                    cmd.Parameters.Add("@Email", txtEmail.Text);
                    cmd.Parameters.Add("@Vertify", "1");

                    conn.Open();
                    cmd.ExecuteNonQuery();
                

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

        private void UserInfoVertify(int VertifyNum)
        {
            try
            {
                conn.Close();
                
                    string strSQL = ("update FoodStoreLogin set isVertify=@isVertifyNum,VertifyNum=@VertifyNum where Email=@Email and isVertify>=@isVertify");

                    SqlCommand cmd = new SqlCommand(strSQL, conn);

                    cmd.Parameters.Add("@isVertifyNum", "2");
                    cmd.Parameters.Add("@VertifyNum", VertifyNum.ToString());

                    cmd.Parameters.Add("@Email", txtEmail.Text);
                    cmd.Parameters.Add("@isVertify", '1');

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    string strSQL1 = ("delete LogInStatus where ManagerID = (select ManagerID From FoodStoreLogin where Email =@Email) and AccStatus = @AccState");

                    SqlCommand cmd1 = new SqlCommand(strSQL1, conn);

                   

                    cmd1.Parameters.Add("@Email", txtEmail.Text);
                    cmd1.Parameters.Add("@AccState", '5');

                    cmd1.ExecuteNonQuery();

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
        private void UserInfoVertifyEmail(int VertifyNum)
        {
            try
            {
                conn.Close();
               
                    string strSQL = ("update FoodStoreLogin set VertifyNum=@VertifyNum where Email=@Email and isVertify>=@isVertify");

                    SqlCommand cmd = new SqlCommand(strSQL, conn);

                    
                    
                    cmd.Parameters.Add("@VertifyNum", VertifyNum.ToString());
                    cmd.Parameters.Add("@Email", txtEmail.Text);
                    cmd.Parameters.Add("@isVertify", "2");

                    conn.Open();
                    cmd.ExecuteNonQuery();
                

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
        private string Email = "";
        private void btnVertifyEmail_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateIsVertifyZero();
                Random rnd = new Random();
                int vertifyNum = rnd.Next(0, 9999);

                conn.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from FoodStoreLogin where Email=@Email and isVertify=@isVertify", conn);
                myCommand.Parameters.Add("@Email", txtEmail.Text);
                myCommand.Parameters.Add("@isVertify",'2');
                
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                     Email = myReader["Email"].ToString().Trim();
                    if (Email.Equals(txtEmail.Text.Trim()))//判斷Email是否有在資料庫
                    {


                        UserInfoVertifyEmail(vertifyNum);
                        SendEmail.sendEmail(txtEmail.Text, vertifyNum);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("此Email不存在，請再想想~");
                    }
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
                btnVertifyEmail.Enabled = false;
            }
        }
        private bool isVertify = false;
        private void btnVertify_Click(object sender, EventArgs e)
        {
           
            try
            {
                conn.Open();


                SqlDataReader myReader = null;
                //SqlCommand myCommand = new SqlCommand("select * from FoodStoreLogin where [Email]=@Email and isVertify=@isVertify", conn);
                SqlCommand myCommand = new SqlCommand("update FoodStoreLogin set isVertify=@isVertify where [Email]=@Email", conn);
                myCommand.Parameters.Add("@Email", Email);
                myCommand.Parameters.Add("@isVertify", '2');

                myCommand = new SqlCommand("select * from  FoodStoreLogin where isVertify=@isVertify and [Email]=@Email", conn);
                myCommand.Parameters.Add("@Email", Email);
                myCommand.Parameters.Add("@isVertify", '2');

                myReader = myCommand.ExecuteReader();
                bool vertifySuccess = false;
                while (myReader.Read())
                {

                     vertifySuccess = myReader["Email"].ToString().Trim().Equals(Email) && myReader["isVertify"].ToString().Equals("2") && txtVertifyNum.Text.Equals(myReader["VertifyNum"].ToString().Trim());
                    if (myReader["Email"].ToString().Trim().Equals(Email) && myReader["isVertify"].ToString().Equals("2") && txtVertifyNum.Text.Equals(myReader["VertifyNum"].ToString().Trim()))
                    {

                        isVertify = true;
                        UserInfoVertify(int.Parse(myReader["VertifyNum"].ToString().Trim()));
                        MessageBox.Show("驗證成功，請重新設定密碼");
                        this.Close();

                        
                       
                        break;
                    }

                }

                if(vertifySuccess==true)
                {
                    this.Close();
                    ResetPwd reset = new ResetPwd(Email);
                    reset.ShowDialog();
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
