
using ManageStock.DataBase;
using ManageStock.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStock.Operations
{
    class ShowMessages
    {
        private static int MessageCounter = 1;
        private static ListView MessageContainer;
        private static SqlConnection connection = new SqlConnection(DataBaseConnection.ConnectionLinke);
        private static string Query = "INSERT INTO [Status](Message,Date,Color)VALUES(@Message,@Date,@Color);";
        private static string SelectQuery = "SELECT * FROM [Status];";
        private static List<MessageSh> AllMessage = new List<MessageSh>();
        Thread thread1 = new Thread(new ThreadStart(FetchMessages));
        Thread thread2 = new Thread(new ThreadStart(ShowPreviouMessage));
        public ShowMessages(ListView MessageContainers) 
        {
            FetchMessages();
            MessageContainer = MessageContainers;
           thread1.Start();
           
            thread2.Start();
          //  ShowPreviouMessage();
          //  CheckForIllegalCrossThreadCalls = false;
            
        }

        public static void PutMessageInContainer(String Content, Color color)
        {
             
            try
            {
                
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@Message", Content);
                command.Parameters.AddWithValue("@Date", DateTime.Now);
                command.Parameters.AddWithValue("@Color", color.Name);

                connection.Open();
                command.ExecuteNonQuery();


                ListViewItem liv = new ListViewItem("" + MessageCounter++);
                liv.SubItems.Add(Content);
                liv.SubItems.Add(DateTime.Now.ToString());
                liv.BackColor = color;
                liv.ForeColor = Color.White;
               
                MessageContainer.Items.Add(liv);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.StackTrace, "DataBase Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            finally 
            {
                connection.Close();
              
            }

        }

        public static void FetchMessages()
        {
             SqlConnection connec = new SqlConnection(DataBaseConnection.ConnectionLinke);
            try
            {
               
                connec.Open();
                SqlCommand command = new SqlCommand(SelectQuery, connec);
                SqlDataReader Reader = command.ExecuteReader();
             
                while (Reader.Read())
                {
               
                    MessageSh Mes = new MessageSh();
                    Mes.IDs = int.Parse(Reader["Id"].ToString());
                    Mes.Messagess = Reader["Message"].ToString();
                    Mes.Dates = DateTime.Parse(Reader["Date"].ToString());
                    Mes.Colorss = Color.FromName(Reader["Color"].ToString());
                    AllMessage.Add(Mes);


                }
               
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.StackTrace, "Error  windows ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                connec.Close();
            }
            

        }

        private static void ShowPreviouMessage() 
        {
            foreach (MessageSh M in AllMessage) 
            {
                if (M.Dates.Date == DateTime.Now.Date)
                {
                    ListViewItem liv = new ListViewItem(""+M.IDs);
                    liv.SubItems.Add(M.Messagess);
                    liv.SubItems.Add(M.Dates.ToString());
                    liv.BackColor = M.Colorss;
                    liv.ForeColor = Color.White;
                    MessageContainer.Items.Add(liv);
                    MessageCounter = M.IDs;
                }
            }

            MessageCounter++;
        }


        public bool CheckForIllegalCrossThreadCalls { get; set; }
    }
}
