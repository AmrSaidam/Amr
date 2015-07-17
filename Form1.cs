using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using ManageStock.Operations;
using ManageStock.Entity;
using System.Text.RegularExpressions;
using ManageStock.DataBase;


namespace ManageStock
{
   

    public partial class Form1 : Form
    {
        private int MessageCounter = 1;
        List<string> Message = new List<string>();
        AddProduct AddProduct;
        UpdateGridView UpdateViews;
        ShowMessages ShowMessage;
        SqlConnection connect = DataBaseConnection.getInstance().getConnect();
        public Form1()
        {
            InitializeComponent();

            AddProduct = new AddProduct(MessageContainer, dataGridView1);
            UpdateViews = new UpdateGridView(dataGridView1, dataGridView2);
            ShowMessage = new ShowMessages(MessageContainer);
            UpdateGridView.UpdateGridViews();
            CheckForIllegalCrossThreadCalls = false;
          
             EditPriceForItem edit = new EditPriceForItem(comboBox1);
             //DeleteProduct delete = new DeleteProduct(dataGridView1);
            // delete.update(dataGridView1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'productsDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.productsDataSet.Table);
            // TODO: This line of code loads data into the 'stockDataSet1.Table' table. You can move, or remove it, as needed.
         //   this.tableTableAdapter1.Fill(this.stockDataSet1.Table);
            // TODO: This line of code loads data into the 'stockDataSet.Table' table. You can move, or remove it, as needed.
          //  this.tableTableAdapter.Fill(this.stockDataSet.Table);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            product Product = new product();

            Product.Name = "" + NameP.Text;
            Product.Amount = Convert.ToInt32(Amount.Value);
            Product.Price = float.Parse(Price.Text);


            Thread thread = new Thread(new ParameterizedThreadStart(AddProduct.AddProductToDataBase));
            thread.Start(Product);

           // DataRow table = tableDataGridView.NewRowNeeded();
        //    table["id"] = 1;
          //  table["Name"] = "Ahaa";
          ////  table["Amount"] = 1;
           // table["Price"] = 1.3;
           // table["Date"] = DateTime.Now;
           // tableDataGridView.Rows.Add(1,"ahaa",1,1.3,DateTime.Now.ToString());
            
          //  tableDataGridView.DataSource = table;
           // this.tableTableAdapter.Fill(this.productsDataSet.Table.AddTableRow());
           // this.tableAdapterManager.UpdateAll(this.stockDataSet);
         
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
//this.tableAdapterManager.UpdateAll(this.stockDataSet);
          //  this.tableTableAdapter.Fill(this.stockDataSet.Table);

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  this.tableTableAdapter1.Fill(this.stockDataSet1.Table);
            Edit.Visible = true;
            EditPrice.Visible = true;
            Add.Visible =true;
            delete.Visible = true;
       
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            Edit.Visible = false;
            EditPrice.Visible = false;
            delete.Visible = false;
         
        }

        private void PutMessageInContainer() 
        {

            ListViewItem liv = new ListViewItem("" + MessageCounter++);
            liv.SubItems.Add("Done !!!");
            liv.SubItems.Add("sdkjhfkjsdhf");
            MessageContainer.Items.Add(liv);
        }

        private void tableDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPrice.Visible = true;
            Add.Visible = true;
            Edit.Visible = false;
            delete.Visible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        public void editItem()
        {
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditPriceForItem edit = new EditPriceForItem();
            edit.editPrice(enterPrice, comboBox1,selectAmount);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditPriceForItem edit = new EditPriceForItem();
            edit.selectFromComboBox(enterPrice, comboBox1, selectAmount);
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPrice.Visible = true;
            Add.Visible = true;
            Edit.Visible = false;
            delete.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  DeleteProduct delete = new DeleteProduct(dataGridView1);
          //  delete.Delete(dataGridView1);
         
        }

       

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy(this.productsDataSet.Table);
                this.tableTableAdapter.Fill(this.productsDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tableDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
