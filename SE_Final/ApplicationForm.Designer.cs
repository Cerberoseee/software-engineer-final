namespace SE_Final
{
    partial class ApplicationForm
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
            this.tabGIR = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpGIRText = new System.Windows.Forms.GroupBox();
            this.grpGIRBtn = new System.Windows.Forms.GroupBox();
            this.btnDelRecord = new System.Windows.Forms.Button();
            this.btnCreateRecord = new System.Windows.Forms.Button();
            this.btnSaveRecord = new System.Windows.Forms.Button();
            this.btnDelGood = new System.Windows.Forms.Button();
            this.btnSaveGood = new System.Windows.Forms.Button();
            this.btnAddGood = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGIRGoodName = new System.Windows.Forms.TextBox();
            this.numGIRQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGIREmpID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGIRGoodPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGIRGoodID = new System.Windows.Forms.TextBox();
            this.dpGIRImport = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGIRReceiptID = new System.Windows.Forms.TextBox();
            this.grdGIRRecord = new System.Windows.Forms.DataGridView();
            this.grdGIRGood = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grdReseller = new System.Windows.Forms.DataGridView();
            this.btnResellerDelete = new System.Windows.Forms.Button();
            this.btnResellerAdd = new System.Windows.Forms.Button();
            this.txtResellerPass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtResellerUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtResellerAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtResellerName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtResellerID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabGIR.SuspendLayout();
            this.grpGIRText.SuspendLayout();
            this.grpGIRBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGIRQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGIRRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGIRGood)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReseller)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGIR
            // 
            this.tabGIR.Controls.Add(this.label9);
            this.tabGIR.Controls.Add(this.label8);
            this.tabGIR.Controls.Add(this.grpGIRText);
            this.tabGIR.Controls.Add(this.grdGIRRecord);
            this.tabGIR.Controls.Add(this.grdGIRGood);
            this.tabGIR.Location = new System.Drawing.Point(4, 29);
            this.tabGIR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGIR.Name = "tabGIR";
            this.tabGIR.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGIR.Size = new System.Drawing.Size(1150, 779);
            this.tabGIR.TabIndex = 1;
            this.tabGIR.Text = "Good Import Receipt";
            this.tabGIR.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Records Listing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Added Goods to Record";
            // 
            // grpGIRText
            // 
            this.grpGIRText.Controls.Add(this.grpGIRBtn);
            this.grpGIRText.Controls.Add(this.label7);
            this.grpGIRText.Controls.Add(this.txtGIRGoodName);
            this.grpGIRText.Controls.Add(this.numGIRQuantity);
            this.grpGIRText.Controls.Add(this.label6);
            this.grpGIRText.Controls.Add(this.txtGIREmpID);
            this.grpGIRText.Controls.Add(this.label5);
            this.grpGIRText.Controls.Add(this.label4);
            this.grpGIRText.Controls.Add(this.txtGIRGoodPrice);
            this.grpGIRText.Controls.Add(this.label3);
            this.grpGIRText.Controls.Add(this.txtGIRGoodID);
            this.grpGIRText.Controls.Add(this.dpGIRImport);
            this.grpGIRText.Controls.Add(this.label2);
            this.grpGIRText.Controls.Add(this.label1);
            this.grpGIRText.Controls.Add(this.txtGIRReceiptID);
            this.grpGIRText.Location = new System.Drawing.Point(9, 5);
            this.grpGIRText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGIRText.Name = "grpGIRText";
            this.grpGIRText.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGIRText.Size = new System.Drawing.Size(1133, 210);
            this.grpGIRText.TabIndex = 19;
            this.grpGIRText.TabStop = false;
            // 
            // grpGIRBtn
            // 
            this.grpGIRBtn.Controls.Add(this.btnDelRecord);
            this.grpGIRBtn.Controls.Add(this.btnCreateRecord);
            this.grpGIRBtn.Controls.Add(this.btnSaveRecord);
            this.grpGIRBtn.Controls.Add(this.btnDelGood);
            this.grpGIRBtn.Controls.Add(this.btnSaveGood);
            this.grpGIRBtn.Controls.Add(this.btnAddGood);
            this.grpGIRBtn.Location = new System.Drawing.Point(754, 43);
            this.grpGIRBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGIRBtn.Name = "grpGIRBtn";
            this.grpGIRBtn.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGIRBtn.Size = new System.Drawing.Size(371, 156);
            this.grpGIRBtn.TabIndex = 21;
            this.grpGIRBtn.TabStop = false;
            this.grpGIRBtn.Text = "Functions";
            // 
            // btnDelRecord
            // 
            this.btnDelRecord.Location = new System.Drawing.Point(246, 79);
            this.btnDelRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelRecord.Name = "btnDelRecord";
            this.btnDelRecord.Size = new System.Drawing.Size(110, 62);
            this.btnDelRecord.TabIndex = 19;
            this.btnDelRecord.Text = "Delete Record";
            this.btnDelRecord.UseVisualStyleBackColor = true;
            this.btnDelRecord.Click += new System.EventHandler(this.btnDelRecord_Click);
            // 
            // btnCreateRecord
            // 
            this.btnCreateRecord.Location = new System.Drawing.Point(6, 79);
            this.btnCreateRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateRecord.Name = "btnCreateRecord";
            this.btnCreateRecord.Size = new System.Drawing.Size(105, 62);
            this.btnCreateRecord.TabIndex = 20;
            this.btnCreateRecord.Text = "Create Record";
            this.btnCreateRecord.UseVisualStyleBackColor = true;
            this.btnCreateRecord.Click += new System.EventHandler(this.btnCreateRecord_Click);
            // 
            // btnSaveRecord
            // 
            this.btnSaveRecord.Location = new System.Drawing.Point(121, 79);
            this.btnSaveRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveRecord.Name = "btnSaveRecord";
            this.btnSaveRecord.Size = new System.Drawing.Size(117, 62);
            this.btnSaveRecord.TabIndex = 3;
            this.btnSaveRecord.Text = "Save Record";
            this.btnSaveRecord.UseVisualStyleBackColor = true;
            this.btnSaveRecord.Click += new System.EventHandler(this.btnSaveRecord_Click);
            // 
            // btnDelGood
            // 
            this.btnDelGood.Location = new System.Drawing.Point(244, 27);
            this.btnDelGood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelGood.Name = "btnDelGood";
            this.btnDelGood.Size = new System.Drawing.Size(112, 42);
            this.btnDelGood.TabIndex = 1;
            this.btnDelGood.Text = "Delete Good";
            this.btnDelGood.UseVisualStyleBackColor = true;
            this.btnDelGood.Click += new System.EventHandler(this.btnDelGood_Click);
            // 
            // btnSaveGood
            // 
            this.btnSaveGood.Location = new System.Drawing.Point(121, 27);
            this.btnSaveGood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveGood.Name = "btnSaveGood";
            this.btnSaveGood.Size = new System.Drawing.Size(117, 42);
            this.btnSaveGood.TabIndex = 2;
            this.btnSaveGood.Text = "Save Good";
            this.btnSaveGood.UseVisualStyleBackColor = true;
            this.btnSaveGood.Click += new System.EventHandler(this.btnSaveGood_Click);
            // 
            // btnAddGood
            // 
            this.btnAddGood.Location = new System.Drawing.Point(7, 27);
            this.btnAddGood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(105, 42);
            this.btnAddGood.TabIndex = 0;
            this.btnAddGood.Text = "Add Good";
            this.btnAddGood.UseVisualStyleBackColor = true;
            this.btnAddGood.Click += new System.EventHandler(this.btnAddGood_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Good Name";
            // 
            // txtGIRGoodName
            // 
            this.txtGIRGoodName.Location = new System.Drawing.Point(102, 140);
            this.txtGIRGoodName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGIRGoodName.Name = "txtGIRGoodName";
            this.txtGIRGoodName.Size = new System.Drawing.Size(246, 26);
            this.txtGIRGoodName.TabIndex = 18;
            // 
            // numGIRQuantity
            // 
            this.numGIRQuantity.Location = new System.Drawing.Point(495, 142);
            this.numGIRQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numGIRQuantity.Name = "numGIRQuantity";
            this.numGIRQuantity.Size = new System.Drawing.Size(248, 26);
            this.numGIRQuantity.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Employee ID";
            // 
            // txtGIREmpID
            // 
            this.txtGIREmpID.Location = new System.Drawing.Point(495, 14);
            this.txtGIREmpID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGIREmpID.Name = "txtGIREmpID";
            this.txtGIREmpID.Size = new System.Drawing.Size(246, 26);
            this.txtGIREmpID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Good Price";
            // 
            // txtGIRGoodPrice
            // 
            this.txtGIRGoodPrice.Location = new System.Drawing.Point(495, 77);
            this.txtGIRGoodPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGIRGoodPrice.Name = "txtGIRGoodPrice";
            this.txtGIRGoodPrice.Size = new System.Drawing.Size(246, 26);
            this.txtGIRGoodPrice.TabIndex = 10;
            this.txtGIRGoodPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGIRGoodPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Good ID";
            // 
            // txtGIRGoodID
            // 
            this.txtGIRGoodID.Location = new System.Drawing.Point(102, 77);
            this.txtGIRGoodID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGIRGoodID.Name = "txtGIRGoodID";
            this.txtGIRGoodID.Size = new System.Drawing.Size(246, 26);
            this.txtGIRGoodID.TabIndex = 8;
            // 
            // dpGIRImport
            // 
            this.dpGIRImport.Location = new System.Drawing.Point(867, 14);
            this.dpGIRImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpGIRImport.Name = "dpGIRImport";
            this.dpGIRImport.Size = new System.Drawing.Size(258, 26);
            this.dpGIRImport.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(758, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Import Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receipt ID";
            // 
            // txtGIRReceiptID
            // 
            this.txtGIRReceiptID.Location = new System.Drawing.Point(102, 14);
            this.txtGIRReceiptID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGIRReceiptID.Name = "txtGIRReceiptID";
            this.txtGIRReceiptID.Size = new System.Drawing.Size(246, 26);
            this.txtGIRReceiptID.TabIndex = 0;
            // 
            // grdGIRRecord
            // 
            this.grdGIRRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGIRRecord.Location = new System.Drawing.Point(19, 273);
            this.grdGIRRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdGIRRecord.Name = "grdGIRRecord";
            this.grdGIRRecord.RowHeadersWidth = 62;
            this.grdGIRRecord.Size = new System.Drawing.Size(564, 484);
            this.grdGIRRecord.TabIndex = 16;
            this.grdGIRRecord.Click += new System.EventHandler(this.grdGIRRecord_Click);
            // 
            // grdGIRGood
            // 
            this.grdGIRGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGIRGood.Location = new System.Drawing.Point(599, 273);
            this.grdGIRGood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdGIRGood.Name = "grdGIRGood";
            this.grdGIRGood.RowHeadersWidth = 62;
            this.grdGIRGood.Size = new System.Drawing.Size(543, 484);
            this.grdGIRGood.TabIndex = 7;
            this.grdGIRGood.Click += new System.EventHandler(this.grdGIRGood_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGIR);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 812);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdReseller);
            this.tabPage1.Controls.Add(this.btnResellerDelete);
            this.tabPage1.Controls.Add(this.btnResellerAdd);
            this.tabPage1.Controls.Add(this.txtResellerPass);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtResellerUser);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtResellerAddress);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtResellerName);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtResellerID);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1150, 779);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Reseller/Agent Address";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grdReseller
            // 
            this.grdReseller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReseller.Location = new System.Drawing.Point(11, 190);
            this.grdReseller.Name = "grdReseller";
            this.grdReseller.RowHeadersWidth = 62;
            this.grdReseller.RowTemplate.Height = 28;
            this.grdReseller.Size = new System.Drawing.Size(1132, 581);
            this.grdReseller.TabIndex = 12;
            this.grdReseller.Click += new System.EventHandler(this.grdReseller_Click);
            // 
            // btnResellerDelete
            // 
            this.btnResellerDelete.Location = new System.Drawing.Point(838, 115);
            this.btnResellerDelete.Name = "btnResellerDelete";
            this.btnResellerDelete.Size = new System.Drawing.Size(151, 55);
            this.btnResellerDelete.TabIndex = 11;
            this.btnResellerDelete.Text = "Delete";
            this.btnResellerDelete.UseVisualStyleBackColor = true;
            this.btnResellerDelete.Click += new System.EventHandler(this.btnResellerDelete_Click);
            // 
            // btnResellerAdd
            // 
            this.btnResellerAdd.Location = new System.Drawing.Point(643, 115);
            this.btnResellerAdd.Name = "btnResellerAdd";
            this.btnResellerAdd.Size = new System.Drawing.Size(151, 55);
            this.btnResellerAdd.TabIndex = 10;
            this.btnResellerAdd.Text = "Add";
            this.btnResellerAdd.UseVisualStyleBackColor = true;
            this.btnResellerAdd.Click += new System.EventHandler(this.btnResellerAdd_Click);
            // 
            // txtResellerPass
            // 
            this.txtResellerPass.Location = new System.Drawing.Point(812, 67);
            this.txtResellerPass.Name = "txtResellerPass";
            this.txtResellerPass.Size = new System.Drawing.Size(287, 26);
            this.txtResellerPass.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(613, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Password";
            // 
            // txtResellerUser
            // 
            this.txtResellerUser.Location = new System.Drawing.Point(812, 17);
            this.txtResellerUser.Name = "txtResellerUser";
            this.txtResellerUser.Size = new System.Drawing.Size(287, 26);
            this.txtResellerUser.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(613, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Username";
            // 
            // txtResellerAddress
            // 
            this.txtResellerAddress.Location = new System.Drawing.Point(206, 115);
            this.txtResellerAddress.Name = "txtResellerAddress";
            this.txtResellerAddress.Size = new System.Drawing.Size(287, 26);
            this.txtResellerAddress.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Reseller/Agent Address";
            // 
            // txtResellerName
            // 
            this.txtResellerName.Location = new System.Drawing.Point(206, 64);
            this.txtResellerName.Name = "txtResellerName";
            this.txtResellerName.Size = new System.Drawing.Size(287, 26);
            this.txtResellerName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Reseller/Agent Name";
            // 
            // txtResellerID
            // 
            this.txtResellerID.Location = new System.Drawing.Point(206, 14);
            this.txtResellerID.Name = "txtResellerID";
            this.txtResellerID.Size = new System.Drawing.Size(287, 26);
            this.txtResellerID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Reseller/Agent ID";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 841);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ApplicationForm";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ApplicationForm_KeyDown);
            this.tabGIR.ResumeLayout(false);
            this.tabGIR.PerformLayout();
            this.grpGIRText.ResumeLayout(false);
            this.grpGIRText.PerformLayout();
            this.grpGIRBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGIRQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGIRRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGIRGood)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReseller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabGIR;
        private System.Windows.Forms.DataGridView grdGIRRecord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGIREmpID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGIRGoodPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGIRGoodID;
        private System.Windows.Forms.DataGridView grdGIRGood;
        private System.Windows.Forms.DateTimePicker dpGIRImport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGIRReceiptID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numGIRQuantity;
        private System.Windows.Forms.Button btnCreateRecord;
        private System.Windows.Forms.Button btnDelRecord;
        private System.Windows.Forms.Button btnSaveRecord;
        private System.Windows.Forms.Button btnSaveGood;
        private System.Windows.Forms.Button btnDelGood;
        private System.Windows.Forms.Button btnAddGood;
        private System.Windows.Forms.GroupBox grpGIRText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGIRGoodName;
        private System.Windows.Forms.GroupBox grpGIRBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResellerPass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtResellerUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtResellerAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtResellerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtResellerID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grdReseller;
        private System.Windows.Forms.Button btnResellerDelete;
        private System.Windows.Forms.Button btnResellerAdd;
    }
}