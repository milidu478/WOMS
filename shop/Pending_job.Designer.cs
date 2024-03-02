namespace shop
{
    partial class Pending_job
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
            this.repiarId_s_b = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.repireID_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.repireidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobStatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repireItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kandyEDataSet = new shop.KandyEDataSet();
            this.label13 = new System.Windows.Forms.Label();
            this.search_2 = new System.Windows.Forms.TextBox();
            this.statas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.Customer_Name = new System.Windows.Forms.Label();
            this.repireItemTableAdapter = new shop.KandyEDataSetTableAdapters.repireItemTableAdapter();
            this.phone_number1 = new System.Windows.Forms.Label();
            this.phone_number2 = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.Charges = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // repiarId_s_b
            // 
            this.repiarId_s_b.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.repiarId_s_b.IconColor = System.Drawing.Color.Black;
            this.repiarId_s_b.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.repiarId_s_b.IconSize = 25;
            this.repiarId_s_b.Location = new System.Drawing.Point(1199, 69);
            this.repiarId_s_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repiarId_s_b.Name = "repiarId_s_b";
            this.repiarId_s_b.Size = new System.Drawing.Size(63, 37);
            this.repiarId_s_b.TabIndex = 2;
            this.repiarId_s_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.repiarId_s_b.UseVisualStyleBackColor = true;
            this.repiarId_s_b.Click += new System.EventHandler(this.repiarId_s_b_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 36);
            this.label2.TabIndex = 25;
            this.label2.Text = "Pending Job";
            // 
            // repireID_search
            // 
            this.repireID_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repireID_search.Location = new System.Drawing.Point(1043, 76);
            this.repireID_search.MaxLength = 12;
            this.repireID_search.Name = "repireID_search";
            this.repireID_search.Size = new System.Drawing.Size(150, 27);
            this.repireID_search.TabIndex = 1;
            this.repireID_search.Enter += new System.EventHandler(this.repireID_search_Enter);
            this.repireID_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repireID_search_KeyPress);
            this.repireID_search.Leave += new System.EventHandler(this.repireID_search_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repireidDataGridViewTextBoxColumn,
            this.EPF,
            this.customerNameDataGridViewTextBoxColumn,
            this.phonenumber1DataGridViewTextBoxColumn,
            this.phonenumber2DataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.discriptionDataGridViewTextBoxColumn,
            this.receiveDateDataGridViewTextBoxColumn,
            this.chargesDataGridViewTextBoxColumn,
            this.jobStatsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.repireItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1333, 177);
            this.dataGridView1.TabIndex = 30;
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
            // EPF
            // 
            this.EPF.DataPropertyName = "EPF";
            this.EPF.HeaderText = "EPF";
            this.EPF.MinimumWidth = 6;
            this.EPF.Name = "EPF";
            this.EPF.ReadOnly = true;
            this.EPF.Width = 40;
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
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "Serial Number";
            this.serialNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            this.serialNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialNumberDataGridViewTextBoxColumn.Width = 125;
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
            // receiveDateDataGridViewTextBoxColumn
            // 
            this.receiveDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiveDate";
            this.receiveDateDataGridViewTextBoxColumn.HeaderText = "Receive Date";
            this.receiveDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiveDateDataGridViewTextBoxColumn.Name = "receiveDateDataGridViewTextBoxColumn";
            this.receiveDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiveDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // chargesDataGridViewTextBoxColumn
            // 
            this.chargesDataGridViewTextBoxColumn.DataPropertyName = "Charges";
            this.chargesDataGridViewTextBoxColumn.HeaderText = "Charges";
            this.chargesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chargesDataGridViewTextBoxColumn.Name = "chargesDataGridViewTextBoxColumn";
            this.chargesDataGridViewTextBoxColumn.ReadOnly = true;
            this.chargesDataGridViewTextBoxColumn.Width = 80;
            // 
            // jobStatsDataGridViewTextBoxColumn
            // 
            this.jobStatsDataGridViewTextBoxColumn.DataPropertyName = "JobStats";
            this.jobStatsDataGridViewTextBoxColumn.HeaderText = "JobStats";
            this.jobStatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobStatsDataGridViewTextBoxColumn.Name = "jobStatsDataGridViewTextBoxColumn";
            this.jobStatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobStatsDataGridViewTextBoxColumn.Width = 110;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(169, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1024, 18);
            this.label13.TabIndex = 55;
            this.label13.Text = "_________________________________________________________________________________" +
    "______________________________________________";
            // 
            // search_2
            // 
            this.search_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_2.Location = new System.Drawing.Point(161, 329);
            this.search_2.MaxLength = 12;
            this.search_2.Name = "search_2";
            this.search_2.Size = new System.Drawing.Size(150, 27);
            this.search_2.TabIndex = 4;
            this.search_2.Enter += new System.EventHandler(this.search_2_Enter);
            this.search_2.Leave += new System.EventHandler(this.search_2_Leave);
            // 
            // statas
            // 
            this.statas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statas.FormattingEnabled = true;
            this.statas.Items.AddRange(new object[] {
            "Complite job",
            "Cancel job"});
            this.statas.Location = new System.Drawing.Point(969, 395);
            this.statas.Name = "statas";
            this.statas.Size = new System.Drawing.Size(158, 30);
            this.statas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(883, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Statas :";
            // 
            // iconButton4
            // 
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 40;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.Location = new System.Drawing.Point(1155, 382);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(190, 56);
            this.iconButton4.TabIndex = 8;
            this.iconButton4.Text = "Submit";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 40;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton5.Location = new System.Drawing.Point(1155, 445);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(190, 59);
            this.iconButton5.TabIndex = 9;
            this.iconButton5.Text = "Clear";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(326, 325);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(58, 37);
            this.iconButton3.TabIndex = 5;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // Customer_Name
            // 
            this.Customer_Name.AutoSize = true;
            this.Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Name.Location = new System.Drawing.Point(192, 384);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(157, 22);
            this.Customer_Name.TabIndex = 66;
            this.Customer_Name.Text = "Customer_Name";
            // 
            // repireItemTableAdapter
            // 
            this.repireItemTableAdapter.ClearBeforeFill = true;
            // 
            // phone_number1
            // 
            this.phone_number1.AutoSize = true;
            this.phone_number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_number1.Location = new System.Drawing.Point(635, 386);
            this.phone_number1.Name = "phone_number1";
            this.phone_number1.Size = new System.Drawing.Size(153, 22);
            this.phone_number1.TabIndex = 67;
            this.phone_number1.Text = "phone_number1";
            // 
            // phone_number2
            // 
            this.phone_number2.AutoSize = true;
            this.phone_number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_number2.Location = new System.Drawing.Point(639, 418);
            this.phone_number2.Name = "phone_number2";
            this.phone_number2.Size = new System.Drawing.Size(153, 22);
            this.phone_number2.TabIndex = 68;
            this.phone_number2.Text = "phone_number2";
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(192, 421);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(98, 22);
            this.ItemName.TabIndex = 69;
            this.ItemName.Text = "ItemName";
            // 
            // Charges
            // 
            this.Charges.AutoSize = true;
            this.Charges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Charges.Location = new System.Drawing.Point(685, 454);
            this.Charges.Name = "Charges";
            this.Charges.Size = new System.Drawing.Size(85, 22);
            this.Charges.TabIndex = 70;
            this.Charges.Text = "Charges";
            // 
            // cost
            // 
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.Location = new System.Drawing.Point(1011, 445);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(116, 28);
            this.cost.TabIndex = 7;
            this.cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cost_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(896, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Cost :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(965, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 22);
            this.label5.TabIndex = 73;
            this.label5.Text = "Rs.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(639, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 22);
            this.label6.TabIndex = 74;
            this.label6.Text = "Rs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Customer Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "Item Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "Phone Number :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(469, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 78;
            this.label9.Text = "Phone Number :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(517, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 79;
            this.label10.Text = "Charges :";
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(1268, 69);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(62, 37);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Pending_job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 515);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.Charges);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.phone_number2);
            this.Controls.Add(this.phone_number1);
            this.Controls.Add(this.Customer_Name);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statas);
            this.Controls.Add(this.search_2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.repireID_search);
            this.Controls.Add(this.repiarId_s_b);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pending_job";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pending_job";
            this.Load += new System.EventHandler(this.Pending_job_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repireItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandyEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public FontAwesome.Sharp.IconButton repiarId_s_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox repireID_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox search_2;
        private System.Windows.Forms.ComboBox statas;
        private System.Windows.Forms.Label label1;
        public FontAwesome.Sharp.IconButton iconButton4;
        public FontAwesome.Sharp.IconButton iconButton5;
        public FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label Customer_Name;
        private KandyEDataSet kandyEDataSet;
        private System.Windows.Forms.BindingSource repireItemBindingSource;
        private KandyEDataSetTableAdapters.repireItemTableAdapter repireItemTableAdapter;
        private System.Windows.Forms.Label phone_number1;
        private System.Windows.Forms.Label phone_number2;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label Charges;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn repireidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobStatsDataGridViewTextBoxColumn;
    }
}