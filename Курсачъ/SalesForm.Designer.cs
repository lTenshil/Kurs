namespace Курсачъ
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.electronic_GYMDataSet3 = new Курсачъ.Electronic_GYMDataSet3();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new Курсачъ.Electronic_GYMDataSet3TableAdapters.SalesTableAdapter();
            this.AddRows = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.electronic_GYMDataSet4 = new Курсачъ.Electronic_GYMDataSet4();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter1 = new Курсачъ.Electronic_GYMDataSet4TableAdapters.SalesTableAdapter();
            this.electronic_GYMDataSet5 = new Курсачъ.Electronic_GYMDataSet5();
            this.salesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter2 = new Курсачъ.Electronic_GYMDataSet5TableAdapters.SalesTableAdapter();
            this.saleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.electronic_GYMDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronic_GYMDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronic_GYMDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // electronic_GYMDataSet3
            // 
            this.electronic_GYMDataSet3.DataSetName = "Electronic_GYMDataSet3";
            this.electronic_GYMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.electronic_GYMDataSet3;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // AddRows
            // 
            this.AddRows.BackColor = System.Drawing.SystemColors.ControlText;
            this.AddRows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddRows.FlatAppearance.BorderSize = 0;
            this.AddRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRows.ForeColor = System.Drawing.Color.Red;
            this.AddRows.Location = new System.Drawing.Point(12, 319);
            this.AddRows.Name = "AddRows";
            this.AddRows.Size = new System.Drawing.Size(110, 31);
            this.AddRows.TabIndex = 3;
            this.AddRows.Text = "Добавить запись";
            this.AddRows.UseVisualStyleBackColor = true;
            this.AddRows.Click += new System.EventHandler(this.AddRows_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.BackColor = System.Drawing.SystemColors.ControlText;
            this.DeleteProduct.FlatAppearance.BorderSize = 0;
            this.DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProduct.ForeColor = System.Drawing.Color.Red;
            this.DeleteProduct.Location = new System.Drawing.Point(154, 319);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(110, 31);
            this.DeleteProduct.TabIndex = 7;
            this.DeleteProduct.Text = "Удалить запись";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.ForeColor = System.Drawing.Color.Red;
            this.RefreshButton.Location = new System.Drawing.Point(658, 319);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(41, 36);
            this.RefreshButton.TabIndex = 8;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIdDataGridViewTextBoxColumn,
            this.Product_Id1,
            this.employeeIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dateOfOrderDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(722, 300);
            this.dataGridView1.TabIndex = 9;
            // 
            // electronic_GYMDataSet4
            // 
            this.electronic_GYMDataSet4.DataSetName = "Electronic_GYMDataSet4";
            this.electronic_GYMDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "Sales";
            this.salesBindingSource1.DataSource = this.electronic_GYMDataSet4;
            // 
            // salesTableAdapter1
            // 
            this.salesTableAdapter1.ClearBeforeFill = true;
            // 
            // electronic_GYMDataSet5
            // 
            this.electronic_GYMDataSet5.DataSetName = "Electronic_GYMDataSet5";
            this.electronic_GYMDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource2
            // 
            this.salesBindingSource2.DataMember = "Sales";
            this.salesBindingSource2.DataSource = this.electronic_GYMDataSet5;
            // 
            // salesTableAdapter2
            // 
            this.salesTableAdapter2.ClearBeforeFill = true;
            // 
            // saleIdDataGridViewTextBoxColumn
            // 
            this.saleIdDataGridViewTextBoxColumn.DataPropertyName = "SaleId";
            this.saleIdDataGridViewTextBoxColumn.HeaderText = "SaleId";
            this.saleIdDataGridViewTextBoxColumn.Name = "saleIdDataGridViewTextBoxColumn";
            this.saleIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Product_Id1
            // 
            this.Product_Id1.DataPropertyName = "Product_Id1";
            this.Product_Id1.HeaderText = "ID товара";
            this.Product_Id1.Name = "Product_Id1";
            this.Product_Id1.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfOrderDataGridViewTextBoxColumn
            // 
            this.dateOfOrderDataGridViewTextBoxColumn.DataPropertyName = "DateOfOrder";
            this.dateOfOrderDataGridViewTextBoxColumn.HeaderText = "DateOfOrder";
            this.dateOfOrderDataGridViewTextBoxColumn.Name = "dateOfOrderDataGridViewTextBoxColumn";
            this.dateOfOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 359);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AddRows);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.electronic_GYMDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronic_GYMDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronic_GYMDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Electronic_GYMDataSet3 electronic_GYMDataSet3;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private Electronic_GYMDataSet3TableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.Button AddRows;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Electronic_GYMDataSet4 electronic_GYMDataSet4;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private Electronic_GYMDataSet4TableAdapters.SalesTableAdapter salesTableAdapter1;
        private Electronic_GYMDataSet5 electronic_GYMDataSet5;
        private System.Windows.Forms.BindingSource salesBindingSource2;
        private Electronic_GYMDataSet5TableAdapters.SalesTableAdapter salesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}