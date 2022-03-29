using System.Windows.Forms;

namespace Курсачъ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.CatalogButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SaleButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guaranteeperiodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electronic_GYMDataSet1 = new Курсачъ.Electronic_GYMDataSet1();
            this.electronicGYMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electronic_GYMDataSet = new Курсачъ.Electronic_GYMDataSet();
            this.productsTableAdapter = new Курсачъ.Electronic_GYMDataSet1TableAdapters.ProductsTableAdapter();
            this.BackButton = new System.Windows.Forms.Button();
            this.Search_Id = new System.Windows.Forms.Button();
            this.Search_Name = new System.Windows.Forms.Button();
            this.Search_price = new System.Windows.Forms.Button();
            this.Search_Manufacturer = new System.Windows.Forms.Button();
            this.Search_Category = new System.Windows.Forms.Button();
            this.Search_Subcategory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search_find = new System.Windows.Forms.Button();
            this.Low_ThenPrice = new System.Windows.Forms.Button();
            this.More_ThenPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronic_GYMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicGYMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronic_GYMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CatalogButton
            // 
            this.CatalogButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.CatalogButton.FlatAppearance.BorderSize = 0;
            this.CatalogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatalogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatalogButton.ForeColor = System.Drawing.Color.Red;
            this.CatalogButton.Location = new System.Drawing.Point(63, 12);
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(156, 53);
            this.CatalogButton.TabIndex = 0;
            this.CatalogButton.Text = "Каталог";
            this.CatalogButton.UseVisualStyleBackColor = false;
            this.CatalogButton.Click += new System.EventHandler(this.CatalogButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.Red;
            this.SearchButton.Location = new System.Drawing.Point(561, 13);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(145, 53);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SaleButton
            // 
            this.SaleButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.SaleButton.FlatAppearance.BorderSize = 0;
            this.SaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaleButton.ForeColor = System.Drawing.Color.Red;
            this.SaleButton.Location = new System.Drawing.Point(394, 12);
            this.SaleButton.Name = "SaleButton";
            this.SaleButton.Size = new System.Drawing.Size(150, 53);
            this.SaleButton.TabIndex = 4;
            this.SaleButton.Text = "Заказы";
            this.SaleButton.UseVisualStyleBackColor = false;
            this.SaleButton.Click += new System.EventHandler(this.SaleButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeButton.FlatAppearance.BorderSize = 0;
            this.EmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeButton.ForeColor = System.Drawing.Color.Red;
            this.EmployeeButton.Location = new System.Drawing.Point(239, 12);
            this.EmployeeButton.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(140, 53);
            this.EmployeeButton.TabIndex = 5;
            this.EmployeeButton.Text = "Сотрудники";
            this.EmployeeButton.UseVisualStyleBackColor = false;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.subCategoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.parameterDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.dateOfManufacturerDataGridViewTextBoxColumn,
            this.guaranteeperiodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(815, 315);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subCategoryDataGridViewTextBoxColumn
            // 
            this.subCategoryDataGridViewTextBoxColumn.DataPropertyName = "SubCategory";
            this.subCategoryDataGridViewTextBoxColumn.HeaderText = "SubCategory";
            this.subCategoryDataGridViewTextBoxColumn.Name = "subCategoryDataGridViewTextBoxColumn";
            this.subCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parameterDataGridViewTextBoxColumn
            // 
            this.parameterDataGridViewTextBoxColumn.DataPropertyName = "Parameter";
            this.parameterDataGridViewTextBoxColumn.HeaderText = "Parameter";
            this.parameterDataGridViewTextBoxColumn.Name = "parameterDataGridViewTextBoxColumn";
            this.parameterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfManufacturerDataGridViewTextBoxColumn
            // 
            this.dateOfManufacturerDataGridViewTextBoxColumn.DataPropertyName = "DateOfManufacturer";
            this.dateOfManufacturerDataGridViewTextBoxColumn.HeaderText = "DateOfManufacturer";
            this.dateOfManufacturerDataGridViewTextBoxColumn.Name = "dateOfManufacturerDataGridViewTextBoxColumn";
            this.dateOfManufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guaranteeperiodDataGridViewTextBoxColumn
            // 
            this.guaranteeperiodDataGridViewTextBoxColumn.DataPropertyName = "Guarantee_period";
            this.guaranteeperiodDataGridViewTextBoxColumn.HeaderText = "Guarantee_period";
            this.guaranteeperiodDataGridViewTextBoxColumn.Name = "guaranteeperiodDataGridViewTextBoxColumn";
            this.guaranteeperiodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.electronic_GYMDataSet1;
            // 
            // electronic_GYMDataSet1
            // 
            this.electronic_GYMDataSet1.DataSetName = "Electronic_GYMDataSet1";
            this.electronic_GYMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // electronicGYMDataSetBindingSource
            // 
            this.electronicGYMDataSetBindingSource.DataSource = this.electronic_GYMDataSet;
            this.electronicGYMDataSetBindingSource.Position = 0;
            // 
            // electronic_GYMDataSet
            // 
            this.electronic_GYMDataSet.DataSetName = "Electronic_GYMDataSet";
            this.electronic_GYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Control;
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(-1, 1);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(58, 42);
            this.BackButton.TabIndex = 7;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Search_Id
            // 
            this.Search_Id.BackColor = System.Drawing.SystemColors.ControlText;
            this.Search_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Search_Id.FlatAppearance.BorderSize = 0;
            this.Search_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Id.ForeColor = System.Drawing.Color.Red;
            this.Search_Id.Location = new System.Drawing.Point(74, 17);
            this.Search_Id.Name = "Search_Id";
            this.Search_Id.Size = new System.Drawing.Size(79, 43);
            this.Search_Id.TabIndex = 8;
            this.Search_Id.Text = "По ID";
            this.Search_Id.UseVisualStyleBackColor = false;
            this.Search_Id.Visible = false;
            this.Search_Id.Click += new System.EventHandler(this.Search_Id_Click);
            // 
            // Search_Name
            // 
            this.Search_Name.BackColor = System.Drawing.SystemColors.ControlText;
            this.Search_Name.FlatAppearance.BorderSize = 0;
            this.Search_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Name.ForeColor = System.Drawing.Color.Red;
            this.Search_Name.Location = new System.Drawing.Point(159, 17);
            this.Search_Name.Name = "Search_Name";
            this.Search_Name.Size = new System.Drawing.Size(85, 43);
            this.Search_Name.TabIndex = 9;
            this.Search_Name.Text = "По имени";
            this.Search_Name.UseVisualStyleBackColor = false;
            this.Search_Name.Visible = false;
            this.Search_Name.Click += new System.EventHandler(this.Search_Name_Click);
            // 
            // Search_price
            // 
            this.Search_price.BackColor = System.Drawing.SystemColors.ControlText;
            this.Search_price.FlatAppearance.BorderSize = 0;
            this.Search_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_price.ForeColor = System.Drawing.Color.Red;
            this.Search_price.Location = new System.Drawing.Point(250, 17);
            this.Search_price.Name = "Search_price";
            this.Search_price.Size = new System.Drawing.Size(89, 43);
            this.Search_price.TabIndex = 10;
            this.Search_price.Text = "По цене";
            this.Search_price.UseVisualStyleBackColor = true;
            this.Search_price.Visible = false;
            this.Search_price.Click += new System.EventHandler(this.Search_price_Click);
            // 
            // Search_Manufacturer
            // 
            this.Search_Manufacturer.BackColor = System.Drawing.SystemColors.ControlText;
            this.Search_Manufacturer.FlatAppearance.BorderSize = 0;
            this.Search_Manufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Manufacturer.ForeColor = System.Drawing.Color.Red;
            this.Search_Manufacturer.Location = new System.Drawing.Point(345, 18);
            this.Search_Manufacturer.Name = "Search_Manufacturer";
            this.Search_Manufacturer.Size = new System.Drawing.Size(137, 43);
            this.Search_Manufacturer.TabIndex = 11;
            this.Search_Manufacturer.Text = "По производителю";
            this.Search_Manufacturer.UseVisualStyleBackColor = true;
            this.Search_Manufacturer.Visible = false;
            this.Search_Manufacturer.Click += new System.EventHandler(this.Search_Manufacturer_Click);
            // 
            // Search_Category
            // 
            this.Search_Category.BackColor = System.Drawing.SystemColors.ControlText;
            this.Search_Category.FlatAppearance.BorderSize = 0;
            this.Search_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Category.ForeColor = System.Drawing.Color.Red;
            this.Search_Category.Location = new System.Drawing.Point(488, 17);
            this.Search_Category.Name = "Search_Category";
            this.Search_Category.Size = new System.Drawing.Size(115, 43);
            this.Search_Category.TabIndex = 12;
            this.Search_Category.Text = "По категории";
            this.Search_Category.UseVisualStyleBackColor = true;
            this.Search_Category.Visible = false;
            this.Search_Category.Click += new System.EventHandler(this.Search_Category_Click);
            // 
            // Search_Subcategory
            // 
            this.Search_Subcategory.BackColor = System.Drawing.SystemColors.ControlText;
            this.Search_Subcategory.FlatAppearance.BorderSize = 0;
            this.Search_Subcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Subcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Subcategory.ForeColor = System.Drawing.Color.Red;
            this.Search_Subcategory.Location = new System.Drawing.Point(609, 17);
            this.Search_Subcategory.Name = "Search_Subcategory";
            this.Search_Subcategory.Size = new System.Drawing.Size(115, 43);
            this.Search_Subcategory.TabIndex = 13;
            this.Search_Subcategory.Text = "По подкатегории";
            this.Search_Subcategory.UseVisualStyleBackColor = true;
            this.Search_Subcategory.Visible = false;
            this.Search_Subcategory.Click += new System.EventHandler(this.Search_Subcategory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // Search_find
            // 
            this.Search_find.BackColor = System.Drawing.SystemColors.ControlText;
            this.Search_find.FlatAppearance.BorderSize = 0;
            this.Search_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_find.ForeColor = System.Drawing.Color.Red;
            this.Search_find.Location = new System.Drawing.Point(475, 66);
            this.Search_find.Name = "Search_find";
            this.Search_find.Size = new System.Drawing.Size(97, 30);
            this.Search_find.TabIndex = 15;
            this.Search_find.Text = "Поиск";
            this.Search_find.UseVisualStyleBackColor = true;
            this.Search_find.Visible = false;
            this.Search_find.Click += new System.EventHandler(this.Search_find_Click);
            // 
            // Low_ThenPrice
            // 
            this.Low_ThenPrice.BackColor = System.Drawing.SystemColors.ControlText;
            this.Low_ThenPrice.FlatAppearance.BorderSize = 0;
            this.Low_ThenPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Low_ThenPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Low_ThenPrice.ForeColor = System.Drawing.Color.Red;
            this.Low_ThenPrice.Location = new System.Drawing.Point(86, 98);
            this.Low_ThenPrice.Name = "Low_ThenPrice";
            this.Low_ThenPrice.Size = new System.Drawing.Size(132, 23);
            this.Low_ThenPrice.TabIndex = 16;
            this.Low_ThenPrice.Text = "Меньше введенной";
            this.Low_ThenPrice.UseVisualStyleBackColor = true;
            this.Low_ThenPrice.Visible = false;
            this.Low_ThenPrice.Click += new System.EventHandler(this.Low_ThenPrice_Click);
            // 
            // More_ThenPrice
            // 
            this.More_ThenPrice.BackColor = System.Drawing.SystemColors.ControlText;
            this.More_ThenPrice.FlatAppearance.BorderSize = 0;
            this.More_ThenPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.More_ThenPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.More_ThenPrice.ForeColor = System.Drawing.Color.Red;
            this.More_ThenPrice.Location = new System.Drawing.Point(239, 98);
            this.More_ThenPrice.Name = "More_ThenPrice";
            this.More_ThenPrice.Size = new System.Drawing.Size(132, 23);
            this.More_ThenPrice.TabIndex = 17;
            this.More_ThenPrice.Text = "Больше введенной";
            this.More_ThenPrice.UseVisualStyleBackColor = true;
            this.More_ThenPrice.Visible = false;
            this.More_ThenPrice.Click += new System.EventHandler(this.More_ThenPrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 403);
            this.Controls.Add(this.More_ThenPrice);
            this.Controls.Add(this.Low_ThenPrice);
            this.Controls.Add(this.Search_find);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search_Subcategory);
            this.Controls.Add(this.Search_Category);
            this.Controls.Add(this.Search_Manufacturer);
            this.Controls.Add(this.Search_price);
            this.Controls.Add(this.Search_Name);
            this.Controls.Add(this.Search_Id);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.SaleButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CatalogButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronic_GYMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicGYMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronic_GYMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CatalogButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button SaleButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource electronicGYMDataSetBindingSource;
        private Electronic_GYMDataSet electronic_GYMDataSet;
        private Electronic_GYMDataSet1 electronic_GYMDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Electronic_GYMDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guaranteeperiodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Search_Id;
        private System.Windows.Forms.Button Search_Name;
        private System.Windows.Forms.Button Search_price;
        private System.Windows.Forms.Button Search_Manufacturer;
        private System.Windows.Forms.Button Search_Category;
        private System.Windows.Forms.Button Search_Subcategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search_find;
        private System.Windows.Forms.Button Low_ThenPrice;
        private System.Windows.Forms.Button More_ThenPrice;
    }
}