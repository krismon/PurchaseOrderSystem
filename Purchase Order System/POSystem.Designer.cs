namespace Purchase_Order_System
{
    partial class POSystem
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
            this.PO = new System.Windows.Forms.TabControl();
            this.Tab_CreatePO = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Amount_text = new System.Windows.Forms.TextBox();
            this.Uprice_text = new System.Windows.Forms.TextBox();
            this.Desc_text = new System.Windows.Forms.TextBox();
            this.Unit_text = new System.Windows.Forms.TextBox();
            this.Qty_text = new System.Windows.Forms.TextBox();
            this.Cr_L_User = new System.Windows.Forms.Label();
            this.Cr_B_Cancel = new System.Windows.Forms.Button();
            this.Cr_B_Print = new System.Windows.Forms.Button();
            this.Cr_B_Save = new System.Windows.Forms.Button();
            this.Cr_DGV_Order = new System.Windows.Forms.DataGridView();
            this.C_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_UNITPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_AMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cr_TB_Delivery = new System.Windows.Forms.TextBox();
            this.Cr_TB_Terms = new System.Windows.Forms.TextBox();
            this.Cr_DD_DueDate = new System.Windows.Forms.DateTimePicker();
            this.Cr_TB_Address = new System.Windows.Forms.TextBox();
            this.Cr_TB_Company = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cr_L_PO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cr_DD_Store = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cr_DD_PODate = new System.Windows.Forms.DateTimePicker();
            this.ViewPO = new System.Windows.Forms.TabPage();
            this.V_DGV_Results = new System.Windows.Forms.DataGridView();
            this.V_B_Search = new System.Windows.Forms.Button();
            this.V_V_PO = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.V_DD_Company = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.V_DD_Store = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.V_DD_PODate = new System.Windows.Forms.DateTimePicker();
            this.Delete_row_btn = new System.Windows.Forms.Button();
            this.V_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V_PO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V_COMPANY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V_STORE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIEW = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE_COLUMN = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PO.SuspendLayout();
            this.Tab_CreatePO.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cr_DGV_Order)).BeginInit();
            this.ViewPO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V_DGV_Results)).BeginInit();
            this.SuspendLayout();
            // 
            // PO
            // 
            this.PO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PO.Controls.Add(this.Tab_CreatePO);
            this.PO.Controls.Add(this.ViewPO);
            this.PO.Location = new System.Drawing.Point(2, 0);
            this.PO.Name = "PO";
            this.PO.SelectedIndex = 0;
            this.PO.Size = new System.Drawing.Size(1042, 838);
            this.PO.TabIndex = 0;
            // 
            // Tab_CreatePO
            // 
            this.Tab_CreatePO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tab_CreatePO.Controls.Add(this.Delete_row_btn);
            this.Tab_CreatePO.Controls.Add(this.groupBox1);
            this.Tab_CreatePO.Controls.Add(this.Cr_L_User);
            this.Tab_CreatePO.Controls.Add(this.Cr_B_Cancel);
            this.Tab_CreatePO.Controls.Add(this.Cr_B_Print);
            this.Tab_CreatePO.Controls.Add(this.Cr_B_Save);
            this.Tab_CreatePO.Controls.Add(this.Cr_DGV_Order);
            this.Tab_CreatePO.Controls.Add(this.Cr_TB_Delivery);
            this.Tab_CreatePO.Controls.Add(this.Cr_TB_Terms);
            this.Tab_CreatePO.Controls.Add(this.Cr_DD_DueDate);
            this.Tab_CreatePO.Controls.Add(this.Cr_TB_Address);
            this.Tab_CreatePO.Controls.Add(this.Cr_TB_Company);
            this.Tab_CreatePO.Controls.Add(this.label8);
            this.Tab_CreatePO.Controls.Add(this.label7);
            this.Tab_CreatePO.Controls.Add(this.label6);
            this.Tab_CreatePO.Controls.Add(this.label5);
            this.Tab_CreatePO.Controls.Add(this.label4);
            this.Tab_CreatePO.Controls.Add(this.label3);
            this.Tab_CreatePO.Controls.Add(this.Cr_L_PO);
            this.Tab_CreatePO.Controls.Add(this.label2);
            this.Tab_CreatePO.Controls.Add(this.Cr_DD_Store);
            this.Tab_CreatePO.Controls.Add(this.label1);
            this.Tab_CreatePO.Controls.Add(this.Cr_DD_PODate);
            this.Tab_CreatePO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_CreatePO.Location = new System.Drawing.Point(4, 25);
            this.Tab_CreatePO.Name = "Tab_CreatePO";
            this.Tab_CreatePO.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_CreatePO.Size = new System.Drawing.Size(1034, 809);
            this.Tab_CreatePO.TabIndex = 0;
            this.Tab_CreatePO.Text = "Create PO";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Add_btn);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Amount_text);
            this.groupBox1.Controls.Add(this.Uprice_text);
            this.groupBox1.Controls.Add(this.Desc_text);
            this.groupBox1.Controls.Add(this.Unit_text);
            this.groupBox1.Controls.Add(this.Qty_text);
            this.groupBox1.Location = new System.Drawing.Point(6, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1019, 112);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD ITEM";
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_btn.Location = new System.Drawing.Point(866, 70);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(137, 24);
            this.Add_btn.TabIndex = 42;
            this.Add_btn.Text = "ADD";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(936, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "AMOUNT";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(776, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = "UNIT PRICE";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(173, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(271, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "STOCK NO. DESCRIPTION/PROD. CODE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(83, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "UNIT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "QTY";
            // 
            // Amount_text
            // 
            this.Amount_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount_text.Location = new System.Drawing.Point(866, 42);
            this.Amount_text.Name = "Amount_text";
            this.Amount_text.Size = new System.Drawing.Size(138, 22);
            this.Amount_text.TabIndex = 36;
            // 
            // Uprice_text
            // 
            this.Uprice_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Uprice_text.Location = new System.Drawing.Point(765, 42);
            this.Uprice_text.Name = "Uprice_text";
            this.Uprice_text.Size = new System.Drawing.Size(95, 22);
            this.Uprice_text.TabIndex = 35;
            // 
            // Desc_text
            // 
            this.Desc_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Desc_text.Location = new System.Drawing.Point(176, 42);
            this.Desc_text.Name = "Desc_text";
            this.Desc_text.Size = new System.Drawing.Size(574, 22);
            this.Desc_text.TabIndex = 34;
            // 
            // Unit_text
            // 
            this.Unit_text.Location = new System.Drawing.Point(96, 42);
            this.Unit_text.Name = "Unit_text";
            this.Unit_text.Size = new System.Drawing.Size(74, 22);
            this.Unit_text.TabIndex = 33;
            // 
            // Qty_text
            // 
            this.Qty_text.Location = new System.Drawing.Point(17, 42);
            this.Qty_text.Name = "Qty_text";
            this.Qty_text.Size = new System.Drawing.Size(73, 22);
            this.Qty_text.TabIndex = 32;
            // 
            // Cr_L_User
            // 
            this.Cr_L_User.AutoSize = true;
            this.Cr_L_User.Location = new System.Drawing.Point(927, 23);
            this.Cr_L_User.Name = "Cr_L_User";
            this.Cr_L_User.Size = new System.Drawing.Size(61, 17);
            this.Cr_L_User.TabIndex = 20;
            this.Cr_L_User.Text = "label13";
            // 
            // Cr_B_Cancel
            // 
            this.Cr_B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cr_B_Cancel.Location = new System.Drawing.Point(623, 763);
            this.Cr_B_Cancel.Name = "Cr_B_Cancel";
            this.Cr_B_Cancel.Size = new System.Drawing.Size(114, 32);
            this.Cr_B_Cancel.TabIndex = 19;
            this.Cr_B_Cancel.Text = "Cancel";
            this.Cr_B_Cancel.UseVisualStyleBackColor = true;
            this.Cr_B_Cancel.Click += new System.EventHandler(this.Cr_B_Cancel_Click);
            // 
            // Cr_B_Print
            // 
            this.Cr_B_Print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cr_B_Print.Location = new System.Drawing.Point(480, 763);
            this.Cr_B_Print.Name = "Cr_B_Print";
            this.Cr_B_Print.Size = new System.Drawing.Size(114, 32);
            this.Cr_B_Print.TabIndex = 18;
            this.Cr_B_Print.Text = "Print";
            this.Cr_B_Print.UseVisualStyleBackColor = true;
            // 
            // Cr_B_Save
            // 
            this.Cr_B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cr_B_Save.Location = new System.Drawing.Point(337, 763);
            this.Cr_B_Save.Name = "Cr_B_Save";
            this.Cr_B_Save.Size = new System.Drawing.Size(114, 32);
            this.Cr_B_Save.TabIndex = 17;
            this.Cr_B_Save.Text = "Save";
            this.Cr_B_Save.UseVisualStyleBackColor = true;
            this.Cr_B_Save.Click += new System.EventHandler(this.Cr_B_Save_Click);
            // 
            // Cr_DGV_Order
            // 
            this.Cr_DGV_Order.AllowUserToAddRows = false;
            this.Cr_DGV_Order.AllowUserToDeleteRows = false;
            this.Cr_DGV_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cr_DGV_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Cr_DGV_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cr_DGV_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_QTY,
            this.C_UNIT,
            this.C_ITEM,
            this.C_UNITPRICE,
            this.C_AMT});
            this.Cr_DGV_Order.Location = new System.Drawing.Point(6, 341);
            this.Cr_DGV_Order.Name = "Cr_DGV_Order";
            this.Cr_DGV_Order.ReadOnly = true;
            this.Cr_DGV_Order.RowHeadersVisible = false;
            this.Cr_DGV_Order.RowTemplate.Height = 24;
            this.Cr_DGV_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Cr_DGV_Order.Size = new System.Drawing.Size(1019, 393);
            this.Cr_DGV_Order.TabIndex = 16;
            // 
            // C_QTY
            // 
            this.C_QTY.FillWeight = 40.75047F;
            this.C_QTY.HeaderText = "QTY";
            this.C_QTY.Name = "C_QTY";
            this.C_QTY.ReadOnly = true;
            // 
            // C_UNIT
            // 
            this.C_UNIT.FillWeight = 35.16743F;
            this.C_UNIT.HeaderText = "UNIT";
            this.C_UNIT.Name = "C_UNIT";
            this.C_UNIT.ReadOnly = true;
            // 
            // C_ITEM
            // 
            this.C_ITEM.FillWeight = 301.3582F;
            this.C_ITEM.HeaderText = "STOCK NO. DESCRIPTION/PROD. CODE";
            this.C_ITEM.Name = "C_ITEM";
            this.C_ITEM.ReadOnly = true;
            // 
            // C_UNITPRICE
            // 
            this.C_UNITPRICE.FillWeight = 50.76142F;
            this.C_UNITPRICE.HeaderText = "UNIT PRICE";
            this.C_UNITPRICE.Name = "C_UNITPRICE";
            this.C_UNITPRICE.ReadOnly = true;
            // 
            // C_AMT
            // 
            this.C_AMT.FillWeight = 71.96244F;
            this.C_AMT.HeaderText = "AMOUNT";
            this.C_AMT.Name = "C_AMT";
            this.C_AMT.ReadOnly = true;
            // 
            // Cr_TB_Delivery
            // 
            this.Cr_TB_Delivery.Location = new System.Drawing.Point(786, 177);
            this.Cr_TB_Delivery.Name = "Cr_TB_Delivery";
            this.Cr_TB_Delivery.Size = new System.Drawing.Size(202, 22);
            this.Cr_TB_Delivery.TabIndex = 15;
            // 
            // Cr_TB_Terms
            // 
            this.Cr_TB_Terms.Location = new System.Drawing.Point(786, 136);
            this.Cr_TB_Terms.Name = "Cr_TB_Terms";
            this.Cr_TB_Terms.Size = new System.Drawing.Size(202, 22);
            this.Cr_TB_Terms.TabIndex = 14;
            // 
            // Cr_DD_DueDate
            // 
            this.Cr_DD_DueDate.CustomFormat = "MM/dd/yyyy";
            this.Cr_DD_DueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cr_DD_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Cr_DD_DueDate.Location = new System.Drawing.Point(237, 177);
            this.Cr_DD_DueDate.Name = "Cr_DD_DueDate";
            this.Cr_DD_DueDate.Size = new System.Drawing.Size(159, 27);
            this.Cr_DD_DueDate.TabIndex = 13;
            // 
            // Cr_TB_Address
            // 
            this.Cr_TB_Address.Location = new System.Drawing.Point(237, 134);
            this.Cr_TB_Address.Name = "Cr_TB_Address";
            this.Cr_TB_Address.Size = new System.Drawing.Size(331, 22);
            this.Cr_TB_Address.TabIndex = 12;
            // 
            // Cr_TB_Company
            // 
            this.Cr_TB_Company.Location = new System.Drawing.Point(237, 94);
            this.Cr_TB_Company.Name = "Cr_TB_Company";
            this.Cr_TB_Company.Size = new System.Drawing.Size(331, 22);
            this.Cr_TB_Company.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Due Date of Delivery";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(604, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Terms/Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(604, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Place of Delivery";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Store";
            // 
            // Cr_L_PO
            // 
            this.Cr_L_PO.AutoSize = true;
            this.Cr_L_PO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cr_L_PO.Location = new System.Drawing.Point(522, 20);
            this.Cr_L_PO.Name = "Cr_L_PO";
            this.Cr_L_PO.Size = new System.Drawing.Size(59, 20);
            this.Cr_L_PO.TabIndex = 4;
            this.Cr_L_PO.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "PO #";
            // 
            // Cr_DD_Store
            // 
            this.Cr_DD_Store.FormattingEnabled = true;
            this.Cr_DD_Store.Location = new System.Drawing.Point(404, 55);
            this.Cr_DD_Store.Name = "Cr_DD_Store";
            this.Cr_DD_Store.Size = new System.Drawing.Size(329, 24);
            this.Cr_DD_Store.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // Cr_DD_PODate
            // 
            this.Cr_DD_PODate.CustomFormat = "MM/dd/yyyy";
            this.Cr_DD_PODate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cr_DD_PODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Cr_DD_PODate.Location = new System.Drawing.Point(786, 94);
            this.Cr_DD_PODate.Name = "Cr_DD_PODate";
            this.Cr_DD_PODate.Size = new System.Drawing.Size(202, 27);
            this.Cr_DD_PODate.TabIndex = 0;
            // 
            // ViewPO
            // 
            this.ViewPO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewPO.Controls.Add(this.V_DGV_Results);
            this.ViewPO.Controls.Add(this.V_B_Search);
            this.ViewPO.Controls.Add(this.V_V_PO);
            this.ViewPO.Controls.Add(this.label12);
            this.ViewPO.Controls.Add(this.V_DD_Company);
            this.ViewPO.Controls.Add(this.label9);
            this.ViewPO.Controls.Add(this.label10);
            this.ViewPO.Controls.Add(this.V_DD_Store);
            this.ViewPO.Controls.Add(this.label11);
            this.ViewPO.Controls.Add(this.V_DD_PODate);
            this.ViewPO.Location = new System.Drawing.Point(4, 25);
            this.ViewPO.Name = "ViewPO";
            this.ViewPO.Padding = new System.Windows.Forms.Padding(3);
            this.ViewPO.Size = new System.Drawing.Size(1034, 809);
            this.ViewPO.TabIndex = 1;
            this.ViewPO.Text = "View PO";
            this.ViewPO.Click += new System.EventHandler(this.ViewPO_Click);
            // 
            // V_DGV_Results
            // 
            this.V_DGV_Results.AllowUserToAddRows = false;
            this.V_DGV_Results.AllowUserToDeleteRows = false;
            this.V_DGV_Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.V_DGV_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.V_DGV_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.V_DGV_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.V_DATE,
            this.V_PO,
            this.V_COMPANY,
            this.V_STORE,
            this.VIEW,
            this.DELETE_COLUMN});
            this.V_DGV_Results.Location = new System.Drawing.Point(6, 182);
            this.V_DGV_Results.Name = "V_DGV_Results";
            this.V_DGV_Results.ReadOnly = true;
            this.V_DGV_Results.RowHeadersVisible = false;
            this.V_DGV_Results.RowTemplate.Height = 24;
            this.V_DGV_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.V_DGV_Results.Size = new System.Drawing.Size(1022, 617);
            this.V_DGV_Results.TabIndex = 21;
            this.V_DGV_Results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.V_DGV_Results_CellContentClick);
            // 
            // V_B_Search
            // 
            this.V_B_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_B_Search.Location = new System.Drawing.Point(449, 144);
            this.V_B_Search.Name = "V_B_Search";
            this.V_B_Search.Size = new System.Drawing.Size(114, 32);
            this.V_B_Search.TabIndex = 20;
            this.V_B_Search.Text = "Search";
            this.V_B_Search.UseVisualStyleBackColor = true;
            this.V_B_Search.Click += new System.EventHandler(this.V_B_Search_Click);
            // 
            // V_V_PO
            // 
            this.V_V_PO.Location = new System.Drawing.Point(722, 38);
            this.V_V_PO.Name = "V_V_PO";
            this.V_V_PO.Size = new System.Drawing.Size(129, 22);
            this.V_V_PO.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(562, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "PO #";
            // 
            // V_DD_Company
            // 
            this.V_DD_Company.FormattingEnabled = true;
            this.V_DD_Company.Location = new System.Drawing.Point(722, 91);
            this.V_DD_Company.Name = "V_DD_Company";
            this.V_DD_Company.Size = new System.Drawing.Size(241, 24);
            this.V_DD_Company.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(558, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Company Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Store";
            // 
            // V_DD_Store
            // 
            this.V_DD_Store.FormattingEnabled = true;
            this.V_DD_Store.Location = new System.Drawing.Point(167, 87);
            this.V_DD_Store.Name = "V_DD_Store";
            this.V_DD_Store.Size = new System.Drawing.Size(302, 24);
            this.V_DD_Store.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(87, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Date";
            // 
            // V_DD_PODate
            // 
            this.V_DD_PODate.CustomFormat = "MM/dd/yyyy";
            this.V_DD_PODate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_DD_PODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.V_DD_PODate.Location = new System.Drawing.Point(167, 40);
            this.V_DD_PODate.Name = "V_DD_PODate";
            this.V_DD_PODate.Size = new System.Drawing.Size(175, 27);
            this.V_DD_PODate.TabIndex = 12;
            // 
            // Delete_row_btn
            // 
            this.Delete_row_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_row_btn.Location = new System.Drawing.Point(836, 740);
            this.Delete_row_btn.Name = "Delete_row_btn";
            this.Delete_row_btn.Size = new System.Drawing.Size(189, 24);
            this.Delete_row_btn.TabIndex = 43;
            this.Delete_row_btn.Text = "DELETE SELECTED";
            this.Delete_row_btn.UseVisualStyleBackColor = true;
            this.Delete_row_btn.Click += new System.EventHandler(this.Delete_row_btn_Click);
            // 
            // V_DATE
            // 
            this.V_DATE.HeaderText = "DATE";
            this.V_DATE.Name = "V_DATE";
            this.V_DATE.ReadOnly = true;
            // 
            // V_PO
            // 
            this.V_PO.HeaderText = "PO #";
            this.V_PO.Name = "V_PO";
            this.V_PO.ReadOnly = true;
            // 
            // V_COMPANY
            // 
            this.V_COMPANY.HeaderText = "COMPANY NAME";
            this.V_COMPANY.Name = "V_COMPANY";
            this.V_COMPANY.ReadOnly = true;
            // 
            // V_STORE
            // 
            this.V_STORE.HeaderText = "STORE";
            this.V_STORE.Name = "V_STORE";
            this.V_STORE.ReadOnly = true;
            // 
            // VIEW
            // 
            this.VIEW.HeaderText = "";
            this.VIEW.Name = "VIEW";
            this.VIEW.ReadOnly = true;
            this.VIEW.Text = "VIEW";
            this.VIEW.UseColumnTextForButtonValue = true;
            // 
            // DELETE_COLUMN
            // 
            this.DELETE_COLUMN.HeaderText = "";
            this.DELETE_COLUMN.Name = "DELETE_COLUMN";
            this.DELETE_COLUMN.ReadOnly = true;
            this.DELETE_COLUMN.Text = "DELETE";
            this.DELETE_COLUMN.UseColumnTextForButtonValue = true;
            // 
            // POSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 836);
            this.Controls.Add(this.PO);
            this.Name = "POSystem";
            this.Text = "Houseware and Appliance Purchase Order System";
            this.PO.ResumeLayout(false);
            this.Tab_CreatePO.ResumeLayout(false);
            this.Tab_CreatePO.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cr_DGV_Order)).EndInit();
            this.ViewPO.ResumeLayout(false);
            this.ViewPO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V_DGV_Results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PO;
        private System.Windows.Forms.TabPage Tab_CreatePO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Cr_L_PO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cr_DD_Store;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Cr_DD_PODate;
        private System.Windows.Forms.TabPage ViewPO;
        private System.Windows.Forms.DataGridView Cr_DGV_Order;
        private System.Windows.Forms.TextBox Cr_TB_Delivery;
        private System.Windows.Forms.TextBox Cr_TB_Terms;
        private System.Windows.Forms.DateTimePicker Cr_DD_DueDate;
        private System.Windows.Forms.TextBox Cr_TB_Address;
        private System.Windows.Forms.TextBox Cr_TB_Company;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cr_B_Cancel;
        private System.Windows.Forms.Button Cr_B_Print;
        private System.Windows.Forms.Button Cr_B_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_UNITPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_AMT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox V_DD_Store;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker V_DD_PODate;
        private System.Windows.Forms.TextBox V_V_PO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox V_DD_Company;
        private System.Windows.Forms.DataGridView V_DGV_Results;
        private System.Windows.Forms.Button V_B_Search;
        private System.Windows.Forms.Label Cr_L_User;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Amount_text;
        private System.Windows.Forms.TextBox Uprice_text;
        private System.Windows.Forms.TextBox Desc_text;
        private System.Windows.Forms.TextBox Unit_text;
        private System.Windows.Forms.TextBox Qty_text;
        private System.Windows.Forms.Button Delete_row_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn V_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn V_PO;
        private System.Windows.Forms.DataGridViewTextBoxColumn V_COMPANY;
        private System.Windows.Forms.DataGridViewTextBoxColumn V_STORE;
        private System.Windows.Forms.DataGridViewButtonColumn VIEW;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE_COLUMN;
    }
}