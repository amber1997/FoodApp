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
    public partial class EditMenu : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        string FoodName, FoodPrice, FoodMemo;

       

        public EditMenu(string FoodName,string FoodPrice,string FoodMemo)
        {
            InitializeComponent();
            this.FoodName = FoodName;
            this.FoodPrice = FoodPrice;
            this.FoodMemo = FoodMemo;
        }
        private void EditMenu_Load(object sender, EventArgs e)
        {
            txtFoodName.Text = FoodName;
            txtPrice.Text = FoodPrice;
            txtMemo.Text = FoodMemo;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = ("update FoodMenu set FoodName=@FoodName,FoodPrice=@FoodPrice,FoodDetail=@FoodDetail where FoodName=@Name and FoodPrice=@Price and FoodDetail=@Detail");

                SqlCommand cmd = new SqlCommand(strSQL, conn);

                cmd.Parameters.Add("@FoodName", txtFoodName.Text);
                cmd.Parameters.Add("@FoodPrice", txtPrice.Text);
                cmd.Parameters.Add("@FoodDetail", txtMemo.Text);

                cmd.Parameters.Add("@Name", FoodName);
                cmd.Parameters.Add("@Price", FoodPrice);
                cmd.Parameters.Add("@Detail", FoodMemo);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功");

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
