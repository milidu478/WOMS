namespace shop
{
    partial class salary
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
            this.labalTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.repireItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kandyEDataSet = new shop.KandyEDataSet();
            this.repireItemTableAdapter = new shop.KandyEDataSetTableAdapters.repireItemTableAdapter();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.kandyEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repireItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repireItemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.repireItemBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.repireItemBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.repire_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobStatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repireItemBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.kandyEDataSet1 = new shop.KandyEDataSet1();
            this.repireItemTableAdapter1 = new shop.KandyEDataSet1TableAdapters.repireItemTableAdapter();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.repireItemBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // labalTotal
            // 
            this.labalTotal.AutoSize = true;
            this.labalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labalTotal.Location = new System.Drawing.Point(1095, 457);
            this.labalTotal.Name = "labalTotal";
            this.labalTotal.Size = new System.Drawing.Size(24, 25);
            this.labalTotal.TabIndex = 82;
            this.labalTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 36);
            this.label2.TabIndex = 67;
            this.label2.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(535, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "To";
            // 
            // repireItemBindingSource
            // 
            this.repireItemBindingSource.DataMember = "repireItem";
            this.repireItemBindingSource.DataSource = this.kandyEDataSet;
            // 
            // kandyEDataSet
            // 
            this.kandyEDataSet.DataSetName = "KandyEDataSet";
            this.kandyEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repireItemTableAdapter
            // 
            this.repireItemTableAdapter.ClearBeforeFill = true;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(758, 95);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(92, 36);
            this.iconButton2.TabIndex = 85;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 27);
            this.dateTimePicker1.TabIndex = 86;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 22, 21, 13, 37, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(592, 97);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(127, 27);
            this.dateTimePicker2.TabIndex = 87;
            this.dateTimePicker2.Value = new System.DateTime(2023, 10, 22, 0, 0, 0, 0);
            // 
            // kandyEDataSetBindingSource
            // 
            this.kandyEDataSetBindingSource.DataSource = this.kandyEDataSet;
            this.kandyEDataSetBindingSource.Position = 0;
            // 
            // repireItemBindingSource1
            // 
            this.repireItemBindingSource1.DataMember = "repireItem";
            this.repireItemBindingSource1.DataSource = this.kandyEDataSetBindingSource;
            // 
            // repireItemBindingSource2
            // 
            this.repireItemBindingSource2.DataMember = "repireItem";
            this.repireItemBindingSource2.DataSource = this.kandyEDataSet;
            // 
            // repireItemBindingSource3
            // 
            this.repireItemBindingSource3.DataMember = "repireItem";
            this.repireItemBindingSource3.DataSource = this.kandyEDataSet;
            // 
            // repireItemBindingSource4
            // 
            this.repireItemBindingSource4.DataMember = "repireItem";
            this.repireItemBindingSource4.DataSource = this.kandyEDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repire_id,
            this.Customer_Name,
            this.ItemName,
            this.Brand,
            this.EPF,
            this.ReceiveDate,
            this.DeliveryDate,
            this.Charges,
            this.jobStatsDataGridViewTextBoxColumn,
            this.Cost});
            this.dataGridView1.DataSource = this.repireItemBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1326, 278);
            this.dataGridView1.TabIndex = 88;
            // 
            // repire_id
            // 
            this.repire_id.DataPropertyName = "repire_id";
            this.repire_id.HeaderText = "Job ID";
            this.repire_id.MinimumWidth = 6;
            this.repire_id.Name = "repire_id";
            this.repire_id.ReadOnly = true;
            this.repire_id.Width = 125;
            // 
            // Customer_Name
            // 
            this.Customer_Name.DataPropertyName = "Customer_Name";
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.MinimumWidth = 6;
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            this.Customer_Name.Width = 300;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 125;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 60;
            // 
            // EPF
            // 
            this.EPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EPF.DataPropertyName = "EPF";
            this.EPF.HeaderText = "EPF";
            this.EPF.MinimumWidth = 6;
            this.EPF.Name = "EPF";
            this.EPF.ReadOnly = true;
            this.EPF.Width = 62;
            // 
            // ReceiveDate
            // 
            this.ReceiveDate.DataPropertyName = "ReceiveDate";
            this.ReceiveDate.HeaderText = "Receive Date";
            this.ReceiveDate.MinimumWidth = 6;
            this.ReceiveDate.Name = "ReceiveDate";
            this.ReceiveDate.ReadOnly = true;
            this.ReceiveDate.Width = 125;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            this.DeliveryDate.HeaderText = "Delivery Date";
            this.DeliveryDate.MinimumWidth = 6;
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            this.DeliveryDate.Width = 125;
            // 
            // Charges
            // 
            this.Charges.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Charges.DataPropertyName = "Charges";
            this.Charges.HeaderText = "Charges";
            this.Charges.MinimumWidth = 6;
            this.Charges.Name = "Charges";
            this.Charges.ReadOnly = true;
            this.Charges.Width = 87;
            // 
            // jobStatsDataGridViewTextBoxColumn
            // 
            this.jobStatsDataGridViewTextBoxColumn.DataPropertyName = "JobStats";
            this.jobStatsDataGridViewTextBoxColumn.HeaderText = "JobStats";
            this.jobStatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobStatsDataGridViewTextBoxColumn.Name = "jobStatsDataGridViewTextBoxColumn";
            this.jobStatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobStatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 125;
            // 
            // repireItemBindingSource5
            // 
            this.repireItemBindingSource5.DataMember = "repireItem";
            this.repireItemBindingSource5.DataSource = this.kandyEDataSet1;
            // 
            // kandyEDataSet1
            // 
            this.kandyEDataSet1.DataSetName = "KandyEDataSet1";
            this.kandyEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repireItemTableAdapter1
            // 
            this.repireItemTableAdapter1.ClearBeforeFill = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(785, 451);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(228, 37);
            this.iconButton1.TabIndex = 89;
            this.iconButton1.Text = "Total Sallary";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1033, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "Rs.";
            // 
            // repireItemBindingSource6
            // 
            this.repireItemBindingSource6.DataMember = "repireItem";
            this.repireItemBindingSource6.DataSource = this.kandyEDataSet1;
            // 
            // salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labalTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "store";
            this.Load += new System.EventHandler(this.store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labalTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private KandyEDataSet kandyEDataSet;
        private System.Windows.Forms.BindingSource repireItemBindingSource;
        private KandyEDataSetTableAdapters.repireItemTableAdapter repireItemTableAdapter;
        public FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource repireItemBindingSource1;
        private System.Windows.Forms.BindingSource kandyEDataSetBindingSource;
        private System.Windows.Forms.BindingSource repireItemBindingSource2;
        private System.Windows.Forms.BindingSource repireItemBindingSource3;
        private System.Windows.Forms.BindingSource repireItemBindingSource4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KandyEDataSet1 kandyEDataSet1;
        private System.Windows.Forms.BindingSource repireItemBindingSource5;
        private KandyEDataSet1TableAdapters.repireItemTableAdapter repireItemTableAdapter1;
        public FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn repire_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobStatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource repireItemBindingSource6;
    }
}