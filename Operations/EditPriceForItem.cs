using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ManageStock.DataBase;
using System.Windows.Forms;
using ManageStock.Entity;
using System.Drawing;
namespace ManageStock.Operations
{
    class EditPriceForItem
    {
        public EditPriceForItem() { }
        SqlConnection connect;
        public EditPriceForItem(ComboBox comboBox1)
        {
             connect = DataBaseConnection.getInstance().getConnect();
            String SelectQuery = "SELECT Name FROM [Table]";

            SqlCommand cmd = new SqlCommand(SelectQuery, connect);
            cmd.CommandText = SelectQuery;
          
            try
            {
                connect.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                
                while (drd.Read())
                {
                    product p = new product();
                    p.Name = drd["Name"].ToString();
                    comboBox1.Items.Add(p);
                }
                drd.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.StackTrace.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            { 
                connect.Close();
            }
        }

        public void editPrice(TextBox textBox1,ComboBox comboBox1,NumericUpDown selectAmount)
        {
            try
            {
                connect = DataBaseConnection.getInstance().getConnect();
                SqlCommand cmd = new SqlCommand("update [Table] set [Price] = @Price , [Amount] = @Amount where [Name] = @Name", connect);
                //  cmd.CommandText = "update [Table] set [Price] = @Price where [Name] = @Name";
                cmd.Parameters.AddWithValue("@Price", float.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Name", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(selectAmount.Value));
                connect.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The product was Edited !! " + comboBox1.Text, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowMessages.PutMessageInContainer("The "+comboBox1+" information was updated", Color.Plum);

                connect.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.StackTrace.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowMessages.PutMessageInContainer("Error within Edit Operaiton ", Color.Red);

            }
            finally
            {
                connect.Close();
                UpdateGridView.UpdateGridViews();
            }
        }

        public void selectFromComboBox(TextBox textBox,ComboBox comboBox,NumericUpDown selectAmount)
        {
            connect = DataBaseConnection.getInstance().getConnect();
            String SelectQuery = "SELECT Amount,Price from [Table] where [Name] = @Name";
            SqlCommand cmd = new SqlCommand(SelectQuery, connect);
            cmd.CommandText = SelectQuery;
            cmd.Parameters.AddWithValue("@Name",comboBox.Text);
            connect.Open();
            try
            {
                SqlDataReader drd = cmd.ExecuteReader();
                
                product p = new product();
                while (drd.Read())
                {
                    p.Amount = int.Parse(drd[0].ToString());
                    p.Price = float.Parse(drd[1].ToString());
                    selectAmount.Value = p.Amount;
                    textBox.Text = p.Price.ToString();
                   
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
        }

    }
}
