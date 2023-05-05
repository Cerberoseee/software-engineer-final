using System;

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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sEFinalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rpvReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.dpReportNow = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.GoodImportedReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GoodReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGDNNoteID = new System.Windows.Forms.TextBox();
            this.txtGDNResellerID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGDNAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtGDNOrderID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dpGDNDate = new System.Windows.Forms.DateTimePicker();
            this.btnGDNAdd = new System.Windows.Forms.Button();
            this.btnGDNDel = new System.Windows.Forms.Button();
            this.btnGDNSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGDNOrderStatus = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnGDNSaveStatus = new System.Windows.Forms.Button();
            this.grdGDN = new System.Windows.Forms.DataGridView();
            this.grdGDNOrder = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sEFinalDataSetBindingSource)).BeginInit();
            this.tabGIR.SuspendLayout();
            this.grpGIRText.SuspendLayout();
            this.grpGIRBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGIRQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGIRRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGIRGood)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReseller)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodImportedReceiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodReceiptBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGDNOrder)).BeginInit();
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
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Receipts Listing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Added Goods to Receipt";
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
            this.btnDelRecord.Text = "Delete Receipt";
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
            this.btnCreateRecord.Text = "Create Receipt";
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
            this.btnSaveRecord.Text = "Save Receipt";
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(18, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 805);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rpvReport);
            this.tabPage2.Controls.Add(this.btnGetReport);
            this.tabPage2.Controls.Add(this.dpReportNow);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1150, 772);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rpvReport
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.sEFinalDataSetBindingSource;
            this.rpvReport.LocalReport.DataSources.Add(reportDataSource6);
            this.rpvReport.LocalReport.ReportEmbeddedResource = "SE_Final.Report.rdlc";
            this.rpvReport.Location = new System.Drawing.Point(23, 63);
            this.rpvReport.Name = "rpvReport";
            this.rpvReport.ServerReport.BearerToken = null;
            this.rpvReport.Size = new System.Drawing.Size(1111, 710);
            this.rpvReport.TabIndex = 6;
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(339, 10);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(157, 47);
            this.btnGetReport.TabIndex = 5;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // dpReportNow
            // 
            this.dpReportNow.Location = new System.Drawing.Point(68, 20);
            this.dpReportNow.Name = "dpReportNow";
            this.dpReportNow.Size = new System.Drawing.Size(226, 26);
            this.dpReportNow.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Time";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.grdGDNOrder);
            this.tabPage3.Controls.Add(this.grdGDN);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.btnGDNSave);
            this.tabPage3.Controls.Add(this.btnGDNDel);
            this.tabPage3.Controls.Add(this.btnGDNAdd);
            this.tabPage3.Controls.Add(this.dpGDNDate);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.txtGDNOrderID);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.txtGDNAddress);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txtGDNResellerID);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txtGDNNoteID);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1150, 772);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Good Delivery Note";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Note ID";
            // 
            // txtGDNNoteID
            // 
            this.txtGDNNoteID.Location = new System.Drawing.Point(177, 20);
            this.txtGDNNoteID.Name = "txtGDNNoteID";
            this.txtGDNNoteID.Size = new System.Drawing.Size(332, 26);
            this.txtGDNNoteID.TabIndex = 1;
            // 
            // txtGDNResellerID
            // 
            this.txtGDNResellerID.Location = new System.Drawing.Point(177, 67);
            this.txtGDNResellerID.Name = "txtGDNResellerID";
            this.txtGDNResellerID.Size = new System.Drawing.Size(332, 26);
            this.txtGDNResellerID.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Reseller ID";
            // 
            // txtGDNAddress
            // 
            this.txtGDNAddress.Location = new System.Drawing.Point(177, 117);
            this.txtGDNAddress.Name = "txtGDNAddress";
            this.txtGDNAddress.Size = new System.Drawing.Size(332, 26);
            this.txtGDNAddress.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 20);
            this.label18.TabIndex = 4;
            this.label18.Text = "Delivery Address";
            // 
            // txtGDNOrderID
            // 
            this.txtGDNOrderID.Location = new System.Drawing.Point(177, 169);
            this.txtGDNOrderID.Name = "txtGDNOrderID";
            this.txtGDNOrderID.Size = new System.Drawing.Size(332, 26);
            this.txtGDNOrderID.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 20);
            this.label19.TabIndex = 6;
            this.label19.Text = "Order ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 20);
            this.label20.TabIndex = 8;
            this.label20.Text = "Delivery Date";
            // 
            // dpGDNDate
            // 
            this.dpGDNDate.Location = new System.Drawing.Point(177, 221);
            this.dpGDNDate.Name = "dpGDNDate";
            this.dpGDNDate.Size = new System.Drawing.Size(332, 26);
            this.dpGDNDate.TabIndex = 9;
            // 
            // btnGDNAdd
            // 
            this.btnGDNAdd.Location = new System.Drawing.Point(614, 23);
            this.btnGDNAdd.Name = "btnGDNAdd";
            this.btnGDNAdd.Size = new System.Drawing.Size(132, 47);
            this.btnGDNAdd.TabIndex = 10;
            this.btnGDNAdd.Text = "Add Note";
            this.btnGDNAdd.UseVisualStyleBackColor = true;
            this.btnGDNAdd.Click += new System.EventHandler(this.btnGDNAdd_Click);
            // 
            // btnGDNDel
            // 
            this.btnGDNDel.Location = new System.Drawing.Point(787, 23);
            this.btnGDNDel.Name = "btnGDNDel";
            this.btnGDNDel.Size = new System.Drawing.Size(132, 47);
            this.btnGDNDel.TabIndex = 11;
            this.btnGDNDel.Text = "Delete Note";
            this.btnGDNDel.UseVisualStyleBackColor = true;
            this.btnGDNDel.Click += new System.EventHandler(this.btnGDNDel_Click);
            // 
            // btnGDNSave
            // 
            this.btnGDNSave.Location = new System.Drawing.Point(958, 23);
            this.btnGDNSave.Name = "btnGDNSave";
            this.btnGDNSave.Size = new System.Drawing.Size(132, 47);
            this.btnGDNSave.TabIndex = 12;
            this.btnGDNSave.Text = "Save Note";
            this.btnGDNSave.UseVisualStyleBackColor = true;
            this.btnGDNSave.Click += new System.EventHandler(this.btnGDNSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGDNSaveStatus);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtGDNOrderStatus);
            this.groupBox1.Location = new System.Drawing.Point(571, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 152);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Status Updating";
            // 
            // txtGDNOrderStatus
            // 
            this.txtGDNOrderStatus.Location = new System.Drawing.Point(136, 75);
            this.txtGDNOrderStatus.Name = "txtGDNOrderStatus";
            this.txtGDNOrderStatus.Size = new System.Drawing.Size(259, 26);
            this.txtGDNOrderStatus.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 20);
            this.label21.TabIndex = 1;
            this.label21.Text = "Order Status";
            // 
            // btnGDNSaveStatus
            // 
            this.btnGDNSaveStatus.Location = new System.Drawing.Point(415, 35);
            this.btnGDNSaveStatus.Name = "btnGDNSaveStatus";
            this.btnGDNSaveStatus.Size = new System.Drawing.Size(122, 107);
            this.btnGDNSaveStatus.TabIndex = 15;
            this.btnGDNSaveStatus.Text = "Save";
            this.btnGDNSaveStatus.UseVisualStyleBackColor = true;
            // 
            // grdGDN
            // 
            this.grdGDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGDN.Location = new System.Drawing.Point(32, 311);
            this.grdGDN.Name = "grdGDN";
            this.grdGDN.RowHeadersWidth = 62;
            this.grdGDN.RowTemplate.Height = 28;
            this.grdGDN.Size = new System.Drawing.Size(491, 439);
            this.grdGDN.TabIndex = 14;
            this.grdGDN.Click += new System.EventHandler(this.grdGDN_Click);
            // 
            // grdGDNOrder
            // 
            this.grdGDNOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGDNOrder.Location = new System.Drawing.Point(571, 311);
            this.grdGDNOrder.Name = "grdGDNOrder";
            this.grdGDNOrder.RowHeadersWidth = 62;
            this.grdGDNOrder.RowTemplate.Height = 28;
            this.grdGDNOrder.Size = new System.Drawing.Size(554, 439);
            this.grdGDNOrder.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 288);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 20);
            this.label22.TabIndex = 16;
            this.label22.Text = "Delivery Notes";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(567, 288);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 20);
            this.label23.TabIndex = 17;
            this.label23.Text = "Orders";
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
            ((System.ComponentModel.ISupportInitialize)(this.sEFinalDataSetBindingSource)).EndInit();
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodImportedReceiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodReceiptBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGDNOrder)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.DateTimePicker dpReportNow;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource sEFinalDataSetBindingSource;
        private System.Windows.Forms.BindingSource GoodImportedReceiptBindingSource;
        private System.Windows.Forms.BindingSource GoodReceiptBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReport;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtGDNOrderID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtGDNAddress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtGDNResellerID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGDNNoteID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView grdGDNOrder;
        private System.Windows.Forms.DataGridView grdGDN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGDNSaveStatus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtGDNOrderStatus;
        private System.Windows.Forms.Button btnGDNSave;
        private System.Windows.Forms.Button btnGDNDel;
        private System.Windows.Forms.Button btnGDNAdd;
        private System.Windows.Forms.DateTimePicker dpGDNDate;
        private System.Windows.Forms.Label label20;
    }
}