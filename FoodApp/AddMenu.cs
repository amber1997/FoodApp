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

namespace FoodApp
{
    public partial class AddMenu : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        public AddMenu()
        {
            InitializeComponent();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                string strSQL = ("insert into FoodMenu(FoodName,FoodPrice,FoodDetail) Values(@FoodName,@FoodPrice,@FoodDetail)");

                int result;

                if(int.TryParse(txtPrice.Text,out result))
                {
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add("@FoodName", txtFoodName.Text);
                    cmd.Parameters.Add("@FoodPrice", txtPrice.Text);
                    cmd.Parameters.Add("@FoodDetail", txtMemo.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    this.Close();
                    MessageBox.Show("新增成功");
                }
                else
                {
                    MessageBox.Show("價位必須輸入數字!");
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("連線失敗!" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        
    }
}
