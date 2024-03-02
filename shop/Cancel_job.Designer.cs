namespace shop
{
    partial class Cancel_job
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.repireItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kandyEDataSet = new shop.KandyEDataSet();
            this.ID_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.repireItemTableAdapter = new shop.KandyEDataSetTableAdapters.repireItemTableAdapter();
            this.repire_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobStatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repire_id,
            this.Customer_Name,
            this.phone_number1,
            this.phone_number2,
            this.ItemName,
            this.Brand,
            this.serialNumberDataGridViewTextBoxColumn,
            this.Discription,
            this.EPF,
            this.ReceiveDate,
            this.Charges,
            this.jobStatsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.repireItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 334);
            this.dataGridView1.TabIndex = 41;
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
            // ID_search
            // 
            this.ID_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_search.Location = new System.Drawing.Point(846, 94);
            this.ID_search.MaxLength = 12;
            this.ID_search.Name = "ID_search";
            this.ID_search.Size = new System.Drawing.Size(140, 27);
            this.ID_search.TabIndex = 39;
            this.ID_search.Enter += new System.EventHandler(this.ID_search_Enter);
            this.ID_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_search_KeyPress);
            this.ID_search.Leave += new System.EventHandler(this.ID_search_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(584, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cancel Job";
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(992, 89);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(48, 37);
            this.iconButton2.TabIndex = 42;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(1234, 89);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(48, 37);
            this.iconButton1.TabIndex = 43;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(1100, 94);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(128, 27);
            this.dateTimePicker2.TabIndex = 44;
            // 
            // repireItemTableAdapter
            // 
            this.repireItemTableAdapter.ClearBeforeFill = true;
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
            this.Customer_Name.Width = 150;
            // 
            // phone_number1
            // 
            this.phone_number1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phone_number1.DataPropertyName = "phone_number1";
            this.phone_number1.HeaderText = "Phone Number";
            this.phone_number1.MinimumWidth = 6;
            this.phone_number1.Name = "phone_number1";
            this.phone_number1.ReadOnly = true;
            this.phone_number1.Width = 116;
            // 
            // phone_number2
            // 
            this.phone_number2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.phone_number2.DataPropertyName = "phone_number2";
            this.phone_number2.HeaderText = "Phone Number";
            this.phone_number2.MinimumWidth = 6;
            this.phone_number2.Name = "phone_number2";
            this.phone_number2.ReadOnly = true;
            this.phone_number2.Width = 116;
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
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            this.serialNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // Discription
            // 
            this.Discription.DataPropertyName = "Discription";
            this.Discription.HeaderText = "Discription";
            this.Discription.MinimumWidth = 6;
            this.Discription.Name = "Discription";
            this.Discription.ReadOnly = true;
            this.Discription.Width = 200;
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
            // Cancel_job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 515);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ID_search);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cancel_job";
            this.Text = "Cancel_job";
            this.Load += new System.EventHandler(this.Cancel_job_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ID_search;
        private System.Windows.Forms.Label label2;
        public FontAwesome.Sharp.IconButton iconButton2;
        public FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private KandyEDataSet kandyEDataSet;
        private System.Windows.Forms.BindingSource repireItemBindingSource;
        private KandyEDataSetTableAdapters.repireItemTableAdapter repireItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn repire_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discription;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobStatsDataGridViewTextBoxColumn;
    }
}