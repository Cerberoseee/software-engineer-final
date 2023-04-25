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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtGIRReceiptID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dpGIRImport = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grdGIRGood = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGIRGoodID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGIRGoodPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGIREmpID = new System.Windows.Forms.TextBox();
            this.grdGIRRecord = new System.Windows.Forms.DataGridView();
            this.numGIRQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddGood = new System.Windows.Forms.Button();
            this.btnDelGood = new System.Windows.Forms.Button();
            this.btnSaveGood = new System.Windows.Forms.Button();
            this.btnSaveRecord = new System.Windows.Forms.Button();
            this.btnDelRecord = new System.Windows.Forms.Button();
            this.btnCreateRecord = new System.Windows.Forms.Button();
            this.grpGIRText = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGIRGoodName = new System.Windows.Forms.TextBox();
            this.grpGIRBtn = new System.Windows.Forms.GroupBox();
            this.tabGIR.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGIRGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGIRRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGIRQuantity)).BeginInit();
            this.grpGIRText.SuspendLayout();
            this.grpGIRBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGIR
            // 
            this.tabGIR.Controls.Add(this.grpGIRText);
            this.tabGIR.Controls.Add(this.grdGIRRecord);
            this.tabGIR.Controls.Add(this.grdGIRGood);
            this.tabGIR.Location = new System.Drawing.Point(4, 22);
            this.tabGIR.Name = "tabGIR";
            this.tabGIR.Padding = new System.Windows.Forms.Padding(3);
            this.tabGIR.Size = new System.Drawing.Size(764, 502);
            this.tabGIR.TabIndex = 1;
            this.tabGIR.Text = "Good Import Receipt";
            this.tabGIR.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGIR);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 411);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtGIRReceiptID
            // 
            this.txtGIRReceiptID.Location = new System.Drawing.Point(68, 9);
            this.txtGIRReceiptID.Name = "txtGIRReceiptID";
            this.txtGIRReceiptID.Size = new System.Drawing.Size(165, 20);
            this.txtGIRReceiptID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receipt ID";
            // 
            // dpGIRImport
            // 
            this.dpGIRImport.Location = new System.Drawing.Point(578, 9);
            this.dpGIRImport.Name = "dpGIRImport";
            this.dpGIRImport.Size = new System.Drawing.Size(165, 20);
            this.dpGIRImport.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Import Date";
            // 
            // grdGIRGood
            // 
            this.grdGIRGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGIRGood.Location = new System.Drawing.Point(11, 154);
            this.grdGIRGood.Name = "grdGIRGood";
            this.grdGIRGood.Size = new System.Drawing.Size(362, 330);
            this.grdGIRGood.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Good ID";
            // 
            // txtGIRGoodID
            // 
            this.txtGIRGoodID.Location = new System.Drawing.Point(68, 50);
            this.txtGIRGoodID.Name = "txtGIRGoodID";
            this.txtGIRGoodID.Size = new System.Drawing.Size(165, 20);
            this.txtGIRGoodID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Good Price";
            // 
            // txtGIRGoodPrice
            // 
            this.txtGIRGoodPrice.Location = new System.Drawing.Point(330, 50);
            this.txtGIRGoodPrice.Name = "txtGIRGoodPrice";
            this.txtGIRGoodPrice.Size = new System.Drawing.Size(165, 20);
            this.txtGIRGoodPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Employee ID";
            // 
            // txtGIREmpID
            // 
            this.txtGIREmpID.Location = new System.Drawing.Point(330, 9);
            this.txtGIREmpID.Name = "txtGIREmpID";
            this.txtGIREmpID.Size = new System.Drawing.Size(165, 20);
            this.txtGIREmpID.TabIndex = 14;
            // 
            // grdGIRRecord
            // 
            this.grdGIRRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGIRRecord.Location = new System.Drawing.Point(385, 154);
            this.grdGIRRecord.Name = "grdGIRRecord";
            this.grdGIRRecord.Size = new System.Drawing.Size(362, 330);
            this.grdGIRRecord.TabIndex = 16;
            // 
            // numGIRQuantity
            // 
            this.numGIRQuantity.Location = new System.Drawing.Point(330, 92);
            this.numGIRQuantity.Name = "numGIRQuantity";
            this.numGIRQuantity.Size = new System.Drawing.Size(165, 20);
            this.numGIRQuantity.TabIndex = 17;
            // 
            // btnAddGood
            // 
            this.btnAddGood.Location = new System.Drawing.Point(4, 11);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(70, 27);
            this.btnAddGood.TabIndex = 0;
            this.btnAddGood.Text = "Add Good";
            this.btnAddGood.UseVisualStyleBackColor = true;
            // 
            // btnDelGood
            // 
            this.btnDelGood.Location = new System.Drawing.Point(162, 11);
            this.btnDelGood.Name = "btnDelGood";
            this.btnDelGood.Size = new System.Drawing.Size(75, 27);
            this.btnDelGood.TabIndex = 1;
            this.btnDelGood.Text = "Delete Good";
            this.btnDelGood.UseVisualStyleBackColor = true;
            // 
            // btnSaveGood
            // 
            this.btnSaveGood.Location = new System.Drawing.Point(80, 11);
            this.btnSaveGood.Name = "btnSaveGood";
            this.btnSaveGood.Size = new System.Drawing.Size(78, 27);
            this.btnSaveGood.TabIndex = 2;
            this.btnSaveGood.Text = "Save Good";
            this.btnSaveGood.UseVisualStyleBackColor = true;
            // 
            // btnSaveRecord
            // 
            this.btnSaveRecord.Location = new System.Drawing.Point(80, 45);
            this.btnSaveRecord.Name = "btnSaveRecord";
            this.btnSaveRecord.Size = new System.Drawing.Size(78, 38);
            this.btnSaveRecord.TabIndex = 3;
            this.btnSaveRecord.Text = "Save Record";
            this.btnSaveRecord.UseVisualStyleBackColor = true;
            // 
            // btnDelRecord
            // 
            this.btnDelRecord.Location = new System.Drawing.Point(164, 45);
            this.btnDelRecord.Name = "btnDelRecord";
            this.btnDelRecord.Size = new System.Drawing.Size(73, 38);
            this.btnDelRecord.TabIndex = 19;
            this.btnDelRecord.Text = "Delete Record";
            this.btnDelRecord.UseVisualStyleBackColor = true;
            // 
            // btnCreateRecord
            // 
            this.btnCreateRecord.Location = new System.Drawing.Point(4, 43);
            this.btnCreateRecord.Name = "btnCreateRecord";
            this.btnCreateRecord.Size = new System.Drawing.Size(70, 40);
            this.btnCreateRecord.TabIndex = 20;
            this.btnCreateRecord.Text = "Create Record";
            this.btnCreateRecord.UseVisualStyleBackColor = true;
            this.btnCreateRecord.Click += new System.EventHandler(this.btnCreateRecord_Click);
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
            this.grpGIRText.Location = new System.Drawing.Point(6, 3);
            this.grpGIRText.Name = "grpGIRText";
            this.grpGIRText.Size = new System.Drawing.Size(741, 134);
            this.grpGIRText.TabIndex = 19;
            this.grpGIRText.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Good Name";
            // 
            // txtGIRGoodName
            // 
            this.txtGIRGoodName.Location = new System.Drawing.Point(68, 91);
            this.txtGIRGoodName.Name = "txtGIRGoodName";
            this.txtGIRGoodName.Size = new System.Drawing.Size(165, 20);
            this.txtGIRGoodName.TabIndex = 18;
            // 
            // grpGIRBtn
            // 
            this.grpGIRBtn.Controls.Add(this.btnDelRecord);
            this.grpGIRBtn.Controls.Add(this.btnCreateRecord);
            this.grpGIRBtn.Controls.Add(this.btnSaveRecord);
            this.grpGIRBtn.Controls.Add(this.btnDelGood);
            this.grpGIRBtn.Controls.Add(this.btnSaveGood);
            this.grpGIRBtn.Controls.Add(this.btnAddGood);
            this.grpGIRBtn.Location = new System.Drawing.Point(503, 35);
            this.grpGIRBtn.Name = "grpGIRBtn";
            this.grpGIRBtn.Size = new System.Drawing.Size(244, 94);
            this.grpGIRBtn.TabIndex = 21;
            this.grpGIRBtn.TabStop = false;
            this.grpGIRBtn.Text = "Functions";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 567);
            this.Controls.Add(this.tabControl1);
            this.Name = "ApplicationForm";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            this.tabGIR.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGIRGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGIRRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGIRQuantity)).EndInit();
            this.grpGIRText.ResumeLayout(false);
            this.grpGIRText.PerformLayout();
            this.grpGIRBtn.ResumeLayout(false);
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
    }
}