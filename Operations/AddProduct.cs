using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ManageStock.DataBase;
using ManageStock.Entity;
using System.Drawing;
using System.Data;

namespace ManageStock.Operations
{
    class AddProduct
    {
        private int MessageCounter = 1;
        public static Boolean MessageFlage = true;
        private List<product> AllProduct = new List<product>();
        private SqlConnection Connection = DataBaseConnection.getInstance().getConnect(); // create connection by singilton class
        private String InsertQuery = "INSERT INTO [Table](Name,Amount,Price,Date)VALUES(@Name,@Amount,@Price,@Date);";
        private String FetchQuery = "SELECT * FROM [Table] ";
        private Exception AddedItBeforeException = new Exception("You added it before ");
        private ListView MessageContainer;
        DataGridView dataGridView1;



        public AddProduct(ListView MessageContainer, DataGridView dataGridView1)
        {
            CkeckPoduct();
            this.MessageContainer = MessageContainer;
            this.dataGridView1 = dataGridView1;
           


        }




        public void AddProductToDataBase(object Product)
        {
            MessageFlage = true;
            Boolean flage = true;

            product pro = (product)Product;


            try
            {
               

                foreach (product p in AllProduct)
                {
                    /// MessageBox.Show("The product was saved !! " + p.Name + " " + AllProduct.Count, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (p.Name.Equals(pro.Name))
                    {
                        ///    MessageBox.Show("The product was saved !! " + pro.Name + " " + AllProduct.Count, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        flage = false;
                        MessageFlage = false;


                    }
                }


                if (flage == true)
                {
                    SqlCommand putValue = new SqlCommand(InsertQuery, Connection);
                    putValue.Parameters.AddWithValue("@Name", pro.Name.ToString());
                    putValue.Parameters.AddWithValue("@Amount", pro.Amount);
                    putValue.Parameters.AddWithValue("@Price", pro.Price);
                    putValue.Parameters.AddWithValue("@Date", DateTime.Now);
                    Connection.Open();
                    putValue.ExecuteNonQuery();



                    AllProduct.Add(pro);
                   
                    MessageBox.Show("The product was saved !! " + pro.Name + "" + AllProduct.Count, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowMessages.PutMessageInContainer("The Product " + pro.Name + " was saved successfully ", Color.Aqua);

                }
                else
                {
                    MessageBox.Show("You added " + pro.Name + " before ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ShowMessages.PutMessageInContainer("You added " + pro.Name + " before ", Color.OrangeRed);

                }


            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.StackTrace.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowMessages.PutMessageInContainer("Error within Add Product Operation", Color.Red);

            }
            finally
            {

                Connection.Close();
                UpdateGridView.UpdateGridViews();
                MessageBox.Show("Here ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }


        //This method featches the content of database and fill them in AllProduct List

        private void CkeckPoduct()
        {

            try
            {
                SqlCommand Command = new SqlCommand(FetchQuery, Connection);
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    product temp = new product();
                    temp.Name = reader["Name"].ToString();

                    temp.Amount = int.Parse(reader["Amount"].ToString());
                    temp.Price = float.Parse(reader["Price"].ToString());
                    //     MessageBox.Show(reader["Name"].ToString(), "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AllProduct.Add(temp);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();

            }





        }

       

    }
}
