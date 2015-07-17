using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ManageStock.DataBase
{
    public class DataBaseConnection
    {

        private static DataBaseConnection connection = null;
        private static SqlConnection connect = null;
        private static string startupPath = System.IO.Directory.GetCurrentDirectory();
        private static string startupPaths = Environment.CurrentDirectory;
        static FileInfo file = new FileInfo(startupPath);
        static string s = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
        static string path = Minpulate(s);
        public static string ConnectionLinke = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "Products.mdf;Integrated Security=True";

       
        private DataBaseConnection() {
        //    MessageBox.Show("" + path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           connect = new SqlConnection(ConnectionLinke); 
        }

        public static DataBaseConnection getInstance()
        {
    //    MessageBox.Show(""+path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (connection == null)
                connection = new DataBaseConnection();
            return connection;
        }

        public SqlConnection getConnect()
        {
            if (connect == null)
                connect = new SqlConnection(ConnectionLinke);
            return connect;



        }

        public static  string Minpulate(string s  )
        {
            
         
            string [] arr = s.Split('\\');
            List<string> temp = null;// new List<string>();
            temp = arr.ToList<string>();
            string g = null;
            try
            {
            for (int i = 0  ; i < temp.Count ; i++)
            {
               
                
                 if (temp[i].Equals("bin"))
                    {
                        temp.RemoveAt(i);


                    }
                 if (temp[i].Equals("Debug"))
                    {

                        temp.RemoveAt(i);
                    }
               
                   
                }
            
                MessageBox.Show("Amr", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
                 g = string.Join("\\", temp.ToArray());
               
            }
            catch (Exception ex) { MessageBox.Show("" + ex.StackTrace, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            return ""+g;
        }
    }
}
