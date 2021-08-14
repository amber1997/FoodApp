using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

//業者介面
namespace FoodApp
{
    public partial class FoodBoss : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        private string myID;

        public FoodBoss(String s)
        {
            InitializeComponent();
            this.myID=s;
                        
            try
            {
                conn.Open();
                MessageBox.Show("資料庫連線成功!");

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("Select [FoodName] as '食品',[FoodPrice] as '價格',[FoodDetail] as '說明' From FoodMenu", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                dgvFoodMenu.DataSource = dataTable; //告訴GridView資料來源為誰
                //dgvFoodMenu.DataBindings();//綁定



            }
            catch(Exception ex)
            {
                MessageBox.Show("資料庫連線失敗!"+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //重新整理
        private void Reload()
        {
            DataTable dataTable = new DataTable();

            SqlCommand cmd = new SqlCommand("Select [FoodName] as '食品',[FoodPrice] as '價格',[FoodDetail] as '說明' From FoodMenu", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            dgvFoodMenu.DataSource = dataTable;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AddMenu add = new AddMenu();
            add.ShowDialog();

            
            Reload();
      
           
        }
        private string FoodName,FoodPrice,FoodMemo;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMenu edit = new EditMenu(FoodName, FoodPrice, FoodMemo);
            edit.ShowDialog();

            Reload();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = ("delete LogInStatus where ManagerID=@ID and AccStatus=@AccState");

                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.Add("@ID", myID);
                cmd.Parameters.Add("@AccState", '1');
      

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("已登出");
                this.Close();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            
            
        }
        private int deleEventCnt = 0;

        private void FoodBoss_Load(object sender, EventArgs e)
        {

        }

        private void btnTodayMenu_Click(object sender, EventArgs e)
        {
            RptBossPrint rpt = new RptBossPrint();
            rpt.ShowDialog();
        }

        private void dgvFoodMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleEventCnt = 1;
            dgvFoodMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FoodName = dgvFoodMenu.CurrentRow.Cells[0].Value.ToString();
            FoodPrice= dgvFoodMenu.CurrentRow.Cells[1].Value.ToString();
            FoodMemo= dgvFoodMenu.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(MessageBox.Show("確定要刪除嗎?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if(deleEventCnt!=0)
                    {
                        string strSQL = ("Delete FoodMenu where FoodName=@FoodName and FoodPrice=@FoodPrice and FoodDetail=@FoodDetail");

                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add("@FoodName", FoodName);
                        cmd.Parameters.Add("@FoodPrice", FoodPrice);
                        cmd.Parameters.Add("@FoodDetail", FoodMemo);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("刪除成功");
                        deleEventCnt = 0;

                        Reload();
                    }
                    else
                    {

                        MessageBox.Show("請再次點擊要刪除的資料試試看!");
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
            }
        }
    }
}
