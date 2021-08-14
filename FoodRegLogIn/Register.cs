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
    public partial class frmRegister : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public string EmailStr = "";
        public frmRegister()
        {
            InitializeComponent();
            try
            {
                conn.Open();
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

       
        private void btnRegSend_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                //驗證有無重複帳號
                SqlCommand myCommandID = new SqlCommand("select Count(*) from FoodStoreLogin where ManagerID=@ID", conn);
                myCommandID.Parameters.Add("@ID", txtID.Text);


                //驗證有無重複Email
                SqlCommand myCommandEmil = new SqlCommand("select Count(*) from FoodStoreLogin where Email=@Mail", conn);
                myCommandEmil.Parameters.Add("@Mail",txtEmail.Text);


                //驗證有無重複地址
                SqlCommand myCommandAddress = new SqlCommand("select Count(*) from FoodStoreLogin where [StoreAddress]=@Address", conn);
                myCommandAddress.Parameters.Add("@Address", txtAddress.Text);

                //驗證有無重複店家電話
                SqlCommand myCommandStoreTel = new SqlCommand("select Count(*) from FoodStoreLogin where [StorePhoneNum]=@StorePhoneNum", conn);
                myCommandStoreTel.Parameters.Add("@StorePhoneNum", txtPhoneNum.Text);
                

                //驗證有無重複店名
                SqlCommand myCommandStoreName = new SqlCommand("select Count(*) from FoodStoreLogin where [StoreName]=@StoreName", conn);
                myCommandStoreName.Parameters.Add("@StoreName", txtStoreName.Text);
               
                //驗證有無重複手機號碼
                SqlCommand myCommandCellPhoneNum = new SqlCommand("select Count(*) from FoodStoreLogin where [PhoneNum]=@PhoneNum", conn);
                myCommandCellPhoneNum.Parameters.Add("@PhoneNum", txtManagerCellphone.Text);




                int selectedCntID = 0, selectedCntStoreName=0,selectedCntStorePhone=0, selectedCellPhone=0,selectedEmail=0,selectedAddress=0;

                selectedCntID = (int)myCommandID.ExecuteScalar();
                selectedCntStoreName = (int)myCommandStoreName.ExecuteScalar();
                selectedCntStorePhone = (int)myCommandStoreTel.ExecuteScalar();
                selectedEmail = (int)myCommandEmil.ExecuteScalar();
                selectedAddress = (int)myCommandAddress.ExecuteScalar();
                selectedCellPhone = (int)myCommandCellPhoneNum.ExecuteScalar();

                string messageText="";

               
                if(selectedCntStoreName>0)
                {
                    messageText += "店名已存在!\n";
                }
                if (selectedAddress>0)
                {
                    messageText += "此地址已註冊使用過!\n";
                }
                if (selectedCntStorePhone > 0)
                {
                    messageText += "此電話號碼已註冊使用過!\n";
                }
                if (selectedCellPhone > 0)
                {
                    messageText += "此手機號碼已註冊使用過!\n";
                }
                if (selectedCntID > 0)
                {
                    messageText = messageText + ("此帳號ID已經被註冊過!\n");
                }
                if(selectedEmail>0)
                {
                    messageText = messageText + ("此Email已經註冊過!\n");
                }


                if (!txtConfirmPwd.Text.Equals(txtPwd.Text))
                {
                    messageText+="請確認密碼前後一致!\n";
                }


                string[] txtStoreElement = { txtStoreName.Text, txtManagerName.Text, txtAddress.Text, txtPhoneNum.Text, txtManagerCellphone.Text, txtID.Text, txtPwd.Text, txtEmail.Text };
                int txtSpaceCnt = 0;
                foreach (string s in txtStoreElement)
                {
                    if (s.Trim().Length <= 0)
                    {
                        txtSpaceCnt++;
                    }
                }

                if (txtSpaceCnt > 0)
                {
                    messageText+=("不可有欄位輸入空白!!");

                }

                if(messageText.Length>0)
                {
                    MessageBox.Show(messageText);
                }

                        
               else
               {
                    Random rnd = new Random();
                    int vertifyNum = rnd.Next(0, 9999);

                    string sqlString = "insert into [FoodStoreLogin] ([StoreName],[Manager],[StoreAddress],[StorePhoneNum] ,[PhoneNum],[ManagerID],[ManagerPwd],[ErrorTime],[isLocked],[Email],VertifyNum,isVertify) VALUES" +
                                  "(@StoreName,@Manager,@StoreAddress,@StorePhoneNum,@cellPhone,@ManagerID,@ManagerPwd,@ErrorTime,@isLodked,@Email,@VertifyNum,@isVertify)";

                    string[] parameterName = { "@StoreName", "@Manager", "@StoreAddress", "@StorePhoneNum", "@cellPhone", "@ManagerID", "ManagerPwd", "@ErrorTime", "@isLodked", "@Email", "@VertifyNum", "@isVertify" };
                    string[] parameterVal = { txtStoreName.Text, txtManagerName.Text, txtAddress.Text, txtPhoneNum.Text, txtManagerCellphone.Text, txtID.Text,PwdSecurity.Md5Encode(Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPwd.Text))), "0", "0", txtEmail.Text, vertifyNum.ToString(), "0" };
                    SqlCommand cmd = new SqlCommand(sqlString, conn);


                    for (int i = 0; i < parameterName.Length; i++)
                    {
                        cmd.Parameters.Add(parameterName[i], parameterVal[i]);
                    }


                    EmailStr = txtEmail.Text;
                    cmd.ExecuteNonQuery();

                    SendEmail.sendEmail(txtEmail.Text, vertifyNum);

                    MessageBox.Show("註冊完成，請去郵箱取得驗證碼，並於此輸入驗證碼驗證!");

                    frmVertifyAcc vertifyAcc = new frmVertifyAcc(txtEmail.Text);
                    vertifyAcc.ShowDialog();

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
    }
}
