namespace Weapon_shop
{
    partial class POS
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
            this.grouper1 = new CodeVendor.Controls.Grouper();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textTotalPrice = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textUnitPrice = new System.Windows.Forms.TextBox();
            this.text_P_Name = new System.Windows.Forms.TextBox();
            this.textPCode = new System.Windows.Forms.TextBox();
            this.textBarCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelInvoice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grouper2 = new CodeVendor.Controls.Grouper();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxInvoiceTotalCost = new System.Windows.Forms.TextBox();
            this.textinvoiceVAT = new System.Windows.Forms.TextBox();
            this.textBoxInvoiceTotalItems = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Admin = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.deletRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grouper1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grouper2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grouper1
            // 
            this.grouper1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.grouper1.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper1.BorderColor = System.Drawing.Color.Black;
            this.grouper1.BorderThickness = 1F;
            this.grouper1.Controls.Add(this.labelDate);
            this.grouper1.Controls.Add(this.labelClock);
            this.grouper1.Controls.Add(this.label2);
            this.grouper1.Controls.Add(this.button4);
            this.grouper1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper1.GroupImage = null;
            this.grouper1.GroupTitle = "";
            this.grouper1.Location = new System.Drawing.Point(8, 6);
            this.grouper1.Name = "grouper1";
            this.grouper1.Padding = new System.Windows.Forms.Padding(20);
            this.grouper1.PaintGroupBox = false;
            this.grouper1.RoundCorners = 10;
            this.grouper1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper1.ShadowControl = false;
            this.grouper1.ShadowThickness = 3;
            this.grouper1.Size = new System.Drawing.Size(906, 79);
            this.grouper1.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(741, 39);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(48, 20);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "Date";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.Location = new System.Drawing.Point(741, 20);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(53, 20);
            this.labelClock.TabIndex = 15;
            this.labelClock.Text = "Clock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weapon Centralized Sels Automation";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PowderBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(875, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.textTotalPrice);
            this.groupBox1.Controls.Add(this.textQuantity);
            this.groupBox1.Controls.Add(this.textUnitPrice);
            this.groupBox1.Controls.Add(this.text_P_Name);
            this.groupBox1.Controls.Add(this.textPCode);
            this.groupBox1.Controls.Add(this.textBarCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // textTotalPrice
            // 
            this.textTotalPrice.Location = new System.Drawing.Point(547, 19);
            this.textTotalPrice.Name = "textTotalPrice";
            this.textTotalPrice.Size = new System.Drawing.Size(69, 20);
            this.textTotalPrice.TabIndex = 11;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(480, 18);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(60, 20);
            this.textQuantity.TabIndex = 10;
            this.textQuantity.TextChanged += new System.EventHandler(this.textQuantity_TextChanged);
            this.textQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textQuantity_KeyDown);
            // 
            // textUnitPrice
            // 
            this.textUnitPrice.Location = new System.Drawing.Point(387, 18);
            this.textUnitPrice.Name = "textUnitPrice";
            this.textUnitPrice.Size = new System.Drawing.Size(81, 20);
            this.textUnitPrice.TabIndex = 9;
            // 
            // text_P_Name
            // 
            this.text_P_Name.Location = new System.Drawing.Point(187, 18);
            this.text_P_Name.Name = "text_P_Name";
            this.text_P_Name.Size = new System.Drawing.Size(193, 20);
            this.text_P_Name.TabIndex = 8;
            // 
            // textPCode
            // 
            this.textPCode.Location = new System.Drawing.Point(96, 19);
            this.textPCode.Name = "textPCode";
            this.textPCode.Size = new System.Drawing.Size(81, 20);
            this.textPCode.TabIndex = 7;
            this.textPCode.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBarCode
            // 
            this.textBarCode.Location = new System.Drawing.Point(6, 19);
            this.textBarCode.Name = "textBarCode";
            this.textBarCode.Size = new System.Drawing.Size(66, 20);
            this.textBarCode.TabIndex = 6;
            this.textBarCode.TextChanged += new System.EventHandler(this.textBarCode_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Product Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.LabelInvoice);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(673, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 49);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // LabelInvoice
            // 
            this.LabelInvoice.AutoSize = true;
            this.LabelInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInvoice.Location = new System.Drawing.Point(116, 11);
            this.LabelInvoice.Name = "LabelInvoice";
            this.LabelInvoice.Size = new System.Drawing.Size(32, 24);
            this.LabelInvoice.TabIndex = 1;
            this.LabelInvoice.Text = "00";
            this.LabelInvoice.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Invoice No :";
            // 
            // grouper2
            // 
            this.grouper2.BackgroundColor = System.Drawing.Color.Black;
            this.grouper2.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper2.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper2.BorderColor = System.Drawing.Color.Black;
            this.grouper2.BorderThickness = 1F;
            this.grouper2.Controls.Add(this.dataGridView1);
            this.grouper2.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper2.GroupImage = null;
            this.grouper2.GroupTitle = "";
            this.grouper2.Location = new System.Drawing.Point(15, 146);
            this.grouper2.Name = "grouper2";
            this.grouper2.Padding = new System.Windows.Forms.Padding(20);
            this.grouper2.PaintGroupBox = false;
            this.grouper2.RoundCorners = 10;
            this.grouper2.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper2.ShadowControl = false;
            this.grouper2.ShadowThickness = 3;
            this.grouper2.Size = new System.Drawing.Size(646, 398);
            this.grouper2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.TotalPrice,
            this.NumberOfItems});
            this.dataGridView1.Location = new System.Drawing.Point(5, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "Price";
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // NumberOfItems
            // 
            this.NumberOfItems.DataPropertyName = "Quantity";
            this.NumberOfItems.HeaderText = "NumberOfItems";
            this.NumberOfItems.Name = "NumberOfItems";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBoxInvoiceTotalCost);
            this.groupBox3.Controls.Add(this.textinvoiceVAT);
            this.groupBox3.Controls.Add(this.textBoxInvoiceTotalItems);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(671, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 174);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Balance";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Paid";
            // 
            // textBoxInvoiceTotalCost
            // 
            this.textBoxInvoiceTotalCost.Location = new System.Drawing.Point(91, 78);
            this.textBoxInvoiceTotalCost.Name = "textBoxInvoiceTotalCost";
            this.textBoxInvoiceTotalCost.Size = new System.Drawing.Size(119, 20);
            this.textBoxInvoiceTotalCost.TabIndex = 11;
            this.textBoxInvoiceTotalCost.TextChanged += new System.EventHandler(this.textBoxInvoiceTotalCost_TextChanged);
            // 
            // textinvoiceVAT
            // 
            this.textinvoiceVAT.Location = new System.Drawing.Point(108, 52);
            this.textinvoiceVAT.Name = "textinvoiceVAT";
            this.textinvoiceVAT.Size = new System.Drawing.Size(102, 20);
            this.textinvoiceVAT.TabIndex = 10;
            // 
            // textBoxInvoiceTotalItems
            // 
            this.textBoxInvoiceTotalItems.Location = new System.Drawing.Point(108, 25);
            this.textBoxInvoiceTotalItems.Name = "textBoxInvoiceTotalItems";
            this.textBoxInvoiceTotalItems.Size = new System.Drawing.Size(102, 20);
            this.textBoxInvoiceTotalItems.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total Cost";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "VAT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total Items";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(671, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 146);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PowderBlue;
            this.button6.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(164, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 61);
            this.button6.TabIndex = 5;
            this.button6.Text = "Close";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PowderBlue;
            this.button7.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(83, 81);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 61);
            this.button7.TabIndex = 4;
            this.button7.Text = "Print";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.AllowDrop = true;
            this.button8.BackColor = System.Drawing.Color.PowderBlue;
            this.button8.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(4, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 61);
            this.button8.TabIndex = 3;
            this.button8.Text = "Re-Print";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PowderBlue;
            this.button5.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(164, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 61);
            this.button5.TabIndex = 2;
            this.button5.Text = "Discount";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(83, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 61);
            this.button3.TabIndex = 1;
            this.button3.Text = "Customer info";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Font = new System.Drawing.Font("Kristen ITC", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 61);
            this.button2.TabIndex = 0;
            this.button2.Text = "New Tranjection";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox5.Controls.Add(this.Admin);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(671, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 53);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(105, 18);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(58, 13);
            this.Admin.TabIndex = 7;
            this.Admin.Text = "Total Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "Login As :";
            // 
            // deletRowToolStripMenuItem
            // 
            this.deletRowToolStripMenuItem.Name = "deletRowToolStripMenuItem";
            this.deletRowToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deletRowToolStripMenuItem.Text = "DeletRow";
            this.deletRowToolStripMenuItem.Click += new System.EventHandler(this.deletRowToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 556);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grouper2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grouper1);
            this.Name = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.grouper1.ResumeLayout(false);
            this.grouper1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grouper2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CodeVendor.Controls.Grouper grouper1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTotalPrice;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.TextBox textUnitPrice;
        private System.Windows.Forms.TextBox text_P_Name;
        private System.Windows.Forms.TextBox textPCode;
        private System.Windows.Forms.TextBox textBarCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabelInvoice;
        private System.Windows.Forms.Label label8;
        private CodeVendor.Controls.Grouper grouper2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxInvoiceTotalCost;
        private System.Windows.Forms.TextBox textinvoiceVAT;
        private System.Windows.Forms.TextBox textBoxInvoiceTotalItems;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletRowToolStripMenuItem;
    }
}