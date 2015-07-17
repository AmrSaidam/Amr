using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageStock.DataBase;
using System.Data.SqlClient;
using System.Data;
using ManageStock.Entity;
using System.Drawing;

namespace ManageStock.Operations
{
    class DeleteProduct
    {
        SqlConnection connect;

        public DeleteProduct(DataGridView dataGridView1)
        {
        
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Amount";
            dataGridView1.Columns[3].Name = "Price";
            dataGridView1.Columns[4].Name = "Date";

            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 193;

        }


        public void update(DataGridView dataGridView1)
        {
            List<product> list = new List<product>();
            connect = DataBaseConnection.getInstance().getConnect();
            String SelectQuery = "SELECT * FROM [Table]";
            SqlCommand cmd = new SqlCommand(SelectQuery,connect);
            cmd.CommandText = SelectQuery;
            try
            {
                connect.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    product p = new product();
                    p.Name = drd["Name"].ToString();
                    p.Amount = int.Parse(drd["Amount"].ToString());
                    p.Price = float.Parse(drd["Price"].ToString());
                    list.Add(p);
                }

                foreach (product pro in list)
                {
                    dataGridView1.Rows.Add(false,pro.Name,pro.Amount,pro.Price);
                    
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.StackTrace.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connect.Close();
            }
            //SqlDataAdapter sda;
            //DataSet ds = new DataSet();
            //sda = new SqlDataAdapter(cmd);
            //sda.Fill(ds);
            //DataTable dt = ds.Tables[0];
            //foreach(DataRow dataRow in dt.Rows)
            //{
              //  chekedListBox1.Items.Add(dataRow["Name"]);
            //}

        }

        public void Delete(DataGridView dataGridView1)
        {

            connect = DataBaseConnection.getInstance().getConnect();
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if ((bool)item.Cells[0].Value)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand("delete from [Table] where Name = '"+item.Cells[1].Value.ToString()+"'", connect);
                        cmd.ExecuteNonQuery();
                        connect.Close();
                       // dataGridView1.Rows.Remove(item);
                        ShowMessages.PutMessageInContainer("Delete Operation  was succeeded", Color.Tomato);
                    }
                }
                MessageBox.Show("SuccessFully Deleted ..!");
                dataGridView1.Rows.Clear();
                update(dataGridView1);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.StackTrace.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowMessages.PutMessageInContainer("Error within Delete Operation ", Color.Red);
            }
            finally
            {
                connect.Close();
            }

        }

    }
}
