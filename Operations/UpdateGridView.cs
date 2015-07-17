using ManageStock.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStock.Operations
{
    class UpdateGridView
    {

        private static DataGridView dataGridView1;
        private static DataGridView dataGridView2;

        public UpdateGridView(DataGridView dataGridView1s  , DataGridView dataGridView2s) 
        {
           dataGridView1 = dataGridView1s;
           dataGridView2 = dataGridView2s;
        }

        public static void UpdateGridViews()
        {
            SqlConnection conn = new SqlConnection(DataBaseConnection.ConnectionLinke);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [Table]", conn);
                SqlDataAdapter DataAdapter = new SqlDataAdapter();
                DataAdapter.SelectCommand = command;
                DataTable DataTables = new DataTable();
                DataAdapter.Fill(DataTables);
                BindingSource BS = new BindingSource();
                BS.DataSource = DataTables;
                dataGridView1.DataSource = BS;
            ///    dataGridView2.DataSource = BS;
                
                DataAdapter.Update(DataTables);
                UpdateGridViews2();

            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
            finally
            {
                conn.Close();
            }

        }

        private static  void UpdateGridViews2()
        {
            SqlConnection conn = new SqlConnection(DataBaseConnection.ConnectionLinke);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [Table]", conn);
                SqlDataAdapter DataAdapter = new SqlDataAdapter();
                DataAdapter.SelectCommand = command;
                DataTable DataTables = new DataTable();
                DataAdapter.Fill(DataTables);
                BindingSource BS = new BindingSource();
                BS.DataSource = DataTables;
                dataGridView2.DataSource = BS;
                dataGridView2.Columns[1].Width = 220;
                dataGridView2.Columns[2].Width = 100;
                dataGridView2.Columns[3].Width = 100;
                dataGridView2.Columns[4].Width = dataGridView2.Width - (
                                                    dataGridView2.Columns[1].Width +
                                                    dataGridView2.Columns[2].Width +
                                                    dataGridView2.Columns[3].Width +
                                                    dataGridView2.Columns[4].Width);

               
                ///    dataGridView2.DataSource = BS;

                DataAdapter.Update(DataTables);
               // MessageBox.Show(dataGridView2.Columns[4].Width.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
            finally
            {
                conn.Close();
            }

        }

        private static void UpdateGridViews3()
        {
            SqlConnection conn = new SqlConnection(DataBaseConnection.ConnectionLinke);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [Table]", conn);
                SqlDataAdapter DataAdapter = new SqlDataAdapter();
                DataAdapter.SelectCommand = command;
                DataTable DataTables = new DataTable();
                DataAdapter.Fill(DataTables);
                BindingSource BS = new BindingSource();
                BS.DataSource = DataTables;
                dataGridView1.DataSource = BS;
                ///    dataGridView2.DataSource = BS;

                DataAdapter.Update(DataTables);

            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
            finally
            {
                conn.Close();
            }

        }
    }
}
