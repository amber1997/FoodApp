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

namespace FoodRegLogIn
{
    public partial class frmConfirmEamil : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        
        public frmConfirmEamil()
        {
            InitializeComponent();
        }

        private void btnConfirmAccPwd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int deleEventCnt = 0,hasIdCnt=0;
                if (MessageBox.Show("確定要刪除帳號嗎?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    //驗證有無重複帳號
                    SqlCommand myCommandIDAndPwd = new SqlCommand("select Count(*) from FoodStoreLogin where ManagerID=@ID and [ManagerPwd]=@Pwd", conn);
                    myCommandIDAndPwd.Parameters.Add("@ID", txtAcc.Text);
                    myCommandIDAndPwd.Parameters.Add("@Pwd", PwdSecurity.Md5Encode(Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPwd.Text))));

                    SqlCommand myCommandIDCon = new SqlCommand("select Count(*) from FoodStoreLogin where ManagerID=@ID", conn);
                    myCommandIDCon.Parameters.Add("@ID", txtAcc.Text);
                   




                    deleEventCnt = (int)myCommandIDAndPwd.ExecuteScalar();
                    hasIdCnt = (int)myCommandIDCon.ExecuteScalar();

                    if (deleEventCnt != 0)
                    {
                        string strSQL = ("Delete FoodStoreLogin where ManagerID=@ID");

                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add("@ID", txtAcc.Text);
                       

                       
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("刪除成功");
                       
                        
                      
                    }
                    else
                    {
                        if(hasIdCnt!=0)
                        {
                            MessageBox.Show("密碼錯誤");
                        }
                        else
                        {
                            MessageBox.Show("查無帳號");
                        }

                        
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("連線失敗!" + ex.Message);
            }
            finally
            {
                conn.Close();
                this.Close();
            }
        }

        
    }
}
