namespace shop
{
    partial class Complite_job
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.repireItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kandyEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kandyEDataSet = new shop.KandyEDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ID_Search = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.repireItemTableAdapter = new shop.KandyEDataSetTableAdapters.repireItemTableAdapter();
            this.repireidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "Complete Job";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repireidDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.phonenumber1DataGridViewTextBoxColumn,
            this.phonenumber2DataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.SerialNumber,
            this.discriptionDataGridViewTextBoxColumn,
            this.ePFDataGridViewTextBoxColumn,
            this.receiveDateDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.chargesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.repireItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1296, 343);
            this.dataGridView1.TabIndex = 35;
            // 
            // repireItemBindingSource
            // 
            this.repireItemBindingSource.DataMember = "repireItem";
            this.repireItemBindingSource.DataSource = this.kandyEDataSetBindingSource;
            // 
            // kandyEDataSetBindingSource
            // 
            this.kandyEDataSetBindingSource.DataSource = this.kandyEDataSet;
            this.kandyEDataSetBindingSource.Position = 0;
            // 
            // kandyEDataSet
            // 
            this.kandyEDataSet.DataSetName = "KandyEDataSet";
            this.kandyEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1104, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 27);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ID_Search
            // 
            this.ID_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ID_Search.Location = new System.Drawing.Point(805, 93);
            this.ID_Search.MaxLength = 12;
            this.ID_Search.Name = "ID_Search";
            this.ID_Search.Size = new System.Drawing.Size(177, 27);
            this.ID_Search.TabIndex = 33;
            this.ID_Search.Enter += new System.EventHandler(this.ID_Search_Enter);
            this.ID_Search.Leave += new System.EventHandler(this.ID_Search_Leave);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(988, 86);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(54, 37);
            this.iconButton2.TabIndex = 36;
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
            this.iconButton1.Location = new System.Drawing.Point(1237, 86);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(56, 37);
            this.iconButton1.TabIndex = 37;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // repireItemTableAdapter
            // 
            this.repireItemTableAdapter.ClearBeforeFill = true;
            // 
            // repireidDataGridViewTextBoxColumn
            // 
            this.repireidDataGridViewTextBoxColumn.DataPropertyName = "repire_id";
            this.repireidDataGridViewTextBoxColumn.HeaderText = "Job ID";
            this.repireidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repireidDataGridViewTextBoxColumn.Name = "repireidDataGridViewTextBoxColumn";
            this.repireidDataGridViewTextBoxColumn.ReadOnly = true;
            this.repireidDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phonenumber1DataGridViewTextBoxColumn
            // 
            this.phonenumber1DataGridViewTextBoxColumn.DataPropertyName = "phone_number1";
            this.phonenumber1DataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phonenumber1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumber1DataGridViewTextBoxColumn.Name = "phonenumber1DataGridViewTextBoxColumn";
            this.phonenumber1DataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumber1DataGridViewTextBoxColumn.Width = 116;
            // 
            // phonenumber2DataGridViewTextBoxColumn
            // 
            this.phonenumber2DataGridViewTextBoxColumn.DataPropertyName = "phone_number2";
            this.phonenumber2DataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phonenumber2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumber2DataGridViewTextBoxColumn.Name = "phonenumber2DataGridViewTextBoxColumn";
            this.phonenumber2DataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumber2DataGridViewTextBoxColumn.Width = 116;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 60;
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "SerialNumber";
            this.SerialNumber.HeaderText = "Serial Number";
            this.SerialNumber.MinimumWidth = 6;
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Width = 125;
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            this.discriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.discriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // ePFDataGridViewTextBoxColumn
            // 
            this.ePFDataGridViewTextBoxColumn.DataPropertyName = "EPF";
            this.ePFDataGridViewTextBoxColumn.HeaderText = "EPF";
            this.ePFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ePFDataGridViewTextBoxColumn.Name = "ePFDataGridViewTextBoxColumn";
            this.ePFDataGridViewTextBoxColumn.ReadOnly = true;
            this.ePFDataGridViewTextBoxColumn.Width = 60;
            // 
            // receiveDateDataGridViewTextBoxColumn
            // 
            this.receiveDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiveDate";
            this.receiveDateDataGridViewTextBoxColumn.HeaderText = "Receive Date";
            this.receiveDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiveDateDataGridViewTextBoxColumn.Name = "receiveDateDataGridViewTextBoxColumn";
            this.receiveDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiveDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "Delivery Date";
            this.deliveryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // chargesDataGridViewTextBoxColumn
            // 
            this.chargesDataGridViewTextBoxColumn.DataPropertyName = "Charges";
            this.chargesDataGridViewTextBoxColumn.HeaderText = "Charges";
            this.chargesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chargesDataGridViewTextBoxColumn.Name = "chargesDataGridViewTextBoxColumn";
            this.chargesDataGridViewTextBoxColumn.ReadOnly = true;
            this.chargesDataGridViewTextBoxColumn.Width = 85;
            // 
            // Complite_job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 515);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ID_Search);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Complite_job";
            this.Text = "Complite_job";
            this.Load += new System.EventHandler(this.Complite_job_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox ID_Search;
        public FontAwesome.Sharp.IconButton iconButton2;
        public FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.BindingSource kandyEDataSetBindingSource;
        private KandyEDataSet kandyEDataSet;
        private System.Windows.Forms.BindingSource repireItemBindingSource;
        private KandyEDataSetTableAdapters.repireItemTableAdapter repireItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn repireidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargesDataGridViewTextBoxColumn;
    }
}