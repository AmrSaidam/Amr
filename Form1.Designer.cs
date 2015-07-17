namespace ManageStock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Save = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.PPrice = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.PAmount = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showproduct = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add = new System.Windows.Forms.Panel();
            this.EditPrice = new System.Windows.Forms.Panel();
            this.Cont4 = new System.Windows.Forms.GroupBox();
            this.Edit = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.selectAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.enterPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MessageContainer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataSet = new ManageStock.ProductsDataSet();
            this.tableTableAdapter = new ManageStock.ProductsDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new ManageStock.ProductsDataSetTableAdapters.TableAdapterManager();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Add.SuspendLayout();
            this.EditPrice.SuspendLayout();
            this.Cont4.SuspendLayout();
            this.Edit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectAmount)).BeginInit();
            this.delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Price
            // 
            resources.ApplyResources(this.Price, "Price");
            this.Price.Name = "Price";
            // 
            // PPrice
            // 
            resources.ApplyResources(this.PPrice, "PPrice");
            this.PPrice.Name = "PPrice";
            // 
            // Amount
            // 
            resources.ApplyResources(this.Amount, "Amount");
            this.Amount.Name = "Amount";
            // 
            // PAmount
            // 
            resources.ApplyResources(this.PAmount, "PAmount");
            this.PAmount.Name = "PAmount";
            // 
            // PName
            // 
            resources.ApplyResources(this.PName, "PName");
            this.PName.Name = "PName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameP);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.PAmount);
            this.groupBox1.Controls.Add(this.PPrice);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.PName);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // NameP
            // 
            resources.ApplyResources(this.NameP, "NameP");
            this.NameP.Name = "NameP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.showproduct,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // showproduct
            // 
            this.showproduct.Name = "showproduct";
            resources.ApplyResources(this.showproduct, "showproduct");
            this.showproduct.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPriceToolStripMenuItem,
            this.deleteProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // editPriceToolStripMenuItem
            // 
            this.editPriceToolStripMenuItem.Name = "editPriceToolStripMenuItem";
            resources.ApplyResources(this.editPriceToolStripMenuItem, "editPriceToolStripMenuItem");
            this.editPriceToolStripMenuItem.Click += new System.EventHandler(this.editPriceToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            resources.ApplyResources(this.deleteProductToolStripMenuItem, "deleteProductToolStripMenuItem");
            this.deleteProductToolStripMenuItem.Click += new System.EventHandler(this.deleteProductToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            resources.ApplyResources(this.windowToolStripMenuItem, "windowToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // Add
            // 
            this.Add.Controls.Add(this.EditPrice);
            this.Add.Controls.Add(this.groupBox1);
            this.Add.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.Add, "Add");
            this.Add.Name = "Add";
            this.Add.Paint += new System.Windows.Forms.PaintEventHandler(this.Add_Paint);
            // 
            // EditPrice
            // 
            this.EditPrice.AllowDrop = true;
            this.EditPrice.Controls.Add(this.Edit);
            this.EditPrice.Controls.Add(this.delete);
            this.EditPrice.Controls.Add(this.panel1);
            resources.ApplyResources(this.EditPrice, "EditPrice");
            this.EditPrice.Name = "EditPrice";
            // 
            // Cont4
            // 
            this.Cont4.Controls.Add(this.dataGridView2);
            resources.ApplyResources(this.Cont4, "Cont4");
            this.Cont4.Name = "Cont4";
            this.Cont4.TabStop = false;
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.Cont4);
            resources.ApplyResources(this.Edit, "Edit");
            this.Edit.Name = "Edit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.selectAmount);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.editBtn);
            this.groupBox4.Controls.Add(this.enterPrice);
            this.groupBox4.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // selectAmount
            // 
            resources.ApplyResources(this.selectAmount, "selectAmount");
            this.selectAmount.Name = "selectAmount";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // editBtn
            // 
            resources.ApplyResources(this.editBtn, "editBtn");
            this.editBtn.Name = "editBtn";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // enterPrice
            // 
            resources.ApplyResources(this.enterPrice, "enterPrice");
            this.enterPrice.Name = "enterPrice";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // delete
            // 
            this.delete.Controls.Add(this.button1);
            this.delete.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.delete, "delete");
            this.delete.Name = "delete";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MessageContainer);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // MessageContainer
            // 
            this.MessageContainer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.MessageContainer.GridLines = true;
            resources.ApplyResources(this.MessageContainer, "MessageContainer");
            this.MessageContainer.Name = "MessageContainer";
            this.MessageContainer.UseCompatibleStateImageBehavior = false;
            this.MessageContainer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // tableBindingSource2
            // 
            this.tableBindingSource2.DataMember = "Table";
            this.tableBindingSource2.DataSource = this.productsDataSet;
            // 
            // productsDataSet
            // 
            this.productsDataSet.DataSetName = "ProductsDataSet";
            this.productsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = ManageStock.ProductsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Add.ResumeLayout(false);
            this.EditPrice.ResumeLayout(false);
            this.Cont4.ResumeLayout(false);
            this.Edit.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectAmount)).EndInit();
            this.delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Label PAmount;
        private System.Windows.Forms.Label PName;
        private System.Windows.Forms.Label PPrice;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
       // private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
      //  private StockDataSetTableAdapters.TableTableAdapter tableTableAdapter;
     //   private StockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
   //   private StockDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showproduct;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Panel Add;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox NameP;
        private System.Windows.Forms.ListView MessageContainer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
      // private StockDataSet1 stockDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource1;
     //  private StockDataSet1TableAdapters.TableTableAdapter tableTableAdapter1;
     //  private StockDataSet1TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.ToolStripMenuItem editPriceToolStripMenuItem;
        private System.Windows.Forms.Panel EditPrice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox enterPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown selectAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel delete;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel Edit;
        private System.Windows.Forms.GroupBox Cont4;
        private ProductsDataSet productsDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource2;
        private ProductsDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private ProductsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;


    }
}

