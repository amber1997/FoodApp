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
    public partial class frmVertifyAcc : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        string SendMail;
        
        public frmVertifyAcc(string Email)
        {
            InitializeComponent();
            
            try
            {
                conn.Open();
                this.SendMail = Email;
                labEmail.Text = Email;
                MessageBox.Show("資料庫連線成功!");



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
        public  void UserInfoVertify(bool isVertify)
        {
            try
            {
                conn.Close();
                if (isVertify == true)
                {
                    string strSQL = ("update FoodStoreLogin set isVertify=@isVertify where Email=@Email and VertifyNum=@VertifyNum");

                    SqlCommand cmd = new SqlCommand(strSQL, conn);

                    cmd.Parameters.Add("@isVertify", "1");
                    cmd.Parameters.Add("@Email", SendMail);
                    cmd.Parameters.Add("@VertifyNum", txtVertifyNum.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
               
            }catch(Exception ex)
            {
                MessageBox.Show("資料庫連線失敗!" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void UserInfoReSendEmail(int vertifyNum)
        {
            try
            {
                    conn.Close();
               
                    string strSQL = ("update FoodStoreLogin set VertifyNum=@VertifyNum where Email=@Email and isVertify=@isVertify");

                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add("@VertifyNum", vertifyNum.ToString());   
                    cmd.Parameters.Add("@Email", SendMail);
                    cmd.Parameters.Add("@isVertify", "0");


                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("已經寄送到您的Email，請確認後輸入驗證碼並按下驗證按鈕!");
                

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
        private bool isVertify = false;
        private void btnVertify_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from FoodStoreLogin where [Email]=@Email", conn);
                myCommand.Parameters.Add("@Email",SendMail);


                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                   

                    if (myReader["Email"].ToString().Trim().Equals(SendMail) && myReader["isVertify"].ToString().Equals("0") && txtVertifyNum.Text.Equals(myReader["VertifyNum"].ToString().Trim()))
                    {

                        isVertify = true;
                        UserInfoVertify(isVertify);
                        MessageBox.Show("驗證成功，可開始登入使用");
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("資料庫連線失敗!" + ex.Message);

            }
            finally
            {
                conn.Close();
            }
            
          }

        private void btnReSend_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int vertifyNum = rnd.Next(0, 9999);

                


                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from FoodStoreLogin where [Email]=@Email", conn);
                conn.Close();
                conn.Open();
                myCommand.Parameters.Add("@Email", SendMail);


                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    //conn.Open();
                    if (myReader["Email"].ToString().Trim().Equals(SendMail) && myReader["isVertify"].ToString().Equals("0"))
                    {
                        UserInfoReSendEmail(vertifyNum);

                        SendEmail.sendEmail(SendMail, vertifyNum);
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

        private void linkLbChangeEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
        }
    }
}
