
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dataGridViewParking = new System.Windows.Forms.DataGridView();
            this.licenseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeinCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeoutCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeTB_TimeIN = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.timeTB_TimeOUT = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonTimeIN = new System.Windows.Forms.Button();
            this.buttonDeleteData = new System.Windows.Forms.Button();
            this.buttonTimeOUT = new System.Windows.Forms.Button();
            this.buttonSaveDataDB = new System.Windows.Forms.Button();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.buttonVehiclePaid = new System.Windows.Forms.Button();
            this.buttonLoadDataDB = new System.Windows.Forms.Button();
            this.buttonClearDataDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParking)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParking
            // 
            this.dataGridViewParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licenseCol,
            this.brandCol,
            this.colorCol,
            this.timeinCol,
            this.timeoutCol,
            this.durationCol,
            this.amountCol,
            this.paidCol});
            this.dataGridViewParking.Location = new System.Drawing.Point(12, 194);
            this.dataGridViewParking.Name = "dataGridViewParking";
            this.dataGridViewParking.Size = new System.Drawing.Size(776, 244);
            this.dataGridViewParking.TabIndex = 0;
            this.dataGridViewParking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParking_CellContentClick);
            // 
            // licenseCol
            // 
            this.licenseCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.licenseCol.HeaderText = "LICENSE PLATE";
            this.licenseCol.Name = "licenseCol";
            this.licenseCol.Width = 105;
            // 
            // brandCol
            // 
            this.brandCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brandCol.HeaderText = "BRAND";
            this.brandCol.Name = "brandCol";
            this.brandCol.Width = 70;
            // 
            // colorCol
            // 
            this.colorCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colorCol.HeaderText = "COLOR";
            this.colorCol.Name = "colorCol";
            this.colorCol.Width = 69;
            // 
            // timeinCol
            // 
            this.timeinCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeinCol.HeaderText = "TIME IN";
            this.timeinCol.Name = "timeinCol";
            this.timeinCol.Width = 67;
            // 
            // timeoutCol
            // 
            this.timeoutCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeoutCol.HeaderText = "TIME OUT";
            this.timeoutCol.Name = "timeoutCol";
            this.timeoutCol.Width = 78;
            // 
            // durationCol
            // 
            this.durationCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.durationCol.HeaderText = "DURATION";
            this.durationCol.Name = "durationCol";
            this.durationCol.Width = 89;
            // 
            // amountCol
            // 
            this.amountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountCol.HeaderText = "AMOUNT";
            this.amountCol.Name = "amountCol";
            // 
            // paidCol
            // 
            this.paidCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paidCol.HeaderText = "PAID";
            this.paidCol.Name = "paidCol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "License Plate";
            // 
            // textBoxLP
            // 
            this.textBoxLP.Location = new System.Drawing.Point(41, 39);
            this.textBoxLP.Name = "textBoxLP";
            this.textBoxLP.Size = new System.Drawing.Size(100, 20);
            this.textBoxLP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(41, 78);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(41, 117);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TIme In";
            // 
            // timeTB_TimeIN
            // 
            this.timeTB_TimeIN.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeTB_TimeIN.Location = new System.Drawing.Point(181, 39);
            this.timeTB_TimeIN.Name = "timeTB_TimeIN";
            this.timeTB_TimeIN.Size = new System.Drawing.Size(103, 20);
            this.timeTB_TimeIN.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TIme Out";
            // 
            // timeTB_TimeOUT
            // 
            this.timeTB_TimeOUT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeTB_TimeOUT.Location = new System.Drawing.Point(181, 78);
            this.timeTB_TimeOUT.Name = "timeTB_TimeOUT";
            this.timeTB_TimeOUT.Size = new System.Drawing.Size(103, 20);
            this.timeTB_TimeOUT.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Duration";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(181, 117);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuration.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(374, 39);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 14;
            // 
            // buttonTimeIN
            // 
            this.buttonTimeIN.Location = new System.Drawing.Point(41, 165);
            this.buttonTimeIN.Name = "buttonTimeIN";
            this.buttonTimeIN.Size = new System.Drawing.Size(75, 23);
            this.buttonTimeIN.TabIndex = 17;
            this.buttonTimeIN.Text = "TIME IN";
            this.buttonTimeIN.UseVisualStyleBackColor = true;
            this.buttonTimeIN.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // buttonDeleteData
            // 
            this.buttonDeleteData.Location = new System.Drawing.Point(365, 165);
            this.buttonDeleteData.Name = "buttonDeleteData";
            this.buttonDeleteData.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteData.TabIndex = 18;
            this.buttonDeleteData.Text = "Delete Row";
            this.buttonDeleteData.UseVisualStyleBackColor = true;
            this.buttonDeleteData.Click += new System.EventHandler(this.buttonDeleteData_Click);
            // 
            // buttonTimeOUT
            // 
            this.buttonTimeOUT.Location = new System.Drawing.Point(122, 165);
            this.buttonTimeOUT.Name = "buttonTimeOUT";
            this.buttonTimeOUT.Size = new System.Drawing.Size(75, 23);
            this.buttonTimeOUT.TabIndex = 19;
            this.buttonTimeOUT.Text = "TIME OUT";
            this.buttonTimeOUT.UseVisualStyleBackColor = true;
            this.buttonTimeOUT.Click += new System.EventHandler(this.buttonTimeOUT_Click);
            // 
            // buttonSaveDataDB
            // 
            this.buttonSaveDataDB.Location = new System.Drawing.Point(511, 165);
            this.buttonSaveDataDB.Name = "buttonSaveDataDB";
            this.buttonSaveDataDB.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveDataDB.TabIndex = 20;
            this.buttonSaveDataDB.Text = "SAVE";
            this.buttonSaveDataDB.UseVisualStyleBackColor = true;
            this.buttonSaveDataDB.Click += new System.EventHandler(this.buttonSaveDataDB_Click);
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.Location = new System.Drawing.Point(284, 165);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateData.TabIndex = 21;
            this.buttonUpdateData.Text = "Update Row";
            this.buttonUpdateData.UseVisualStyleBackColor = true;
            this.buttonUpdateData.Click += new System.EventHandler(this.buttonUpdateData_Click);
            // 
            // buttonVehiclePaid
            // 
            this.buttonVehiclePaid.Location = new System.Drawing.Point(203, 165);
            this.buttonVehiclePaid.Name = "buttonVehiclePaid";
            this.buttonVehiclePaid.Size = new System.Drawing.Size(75, 23);
            this.buttonVehiclePaid.TabIndex = 22;
            this.buttonVehiclePaid.Text = "PAY";
            this.buttonVehiclePaid.UseVisualStyleBackColor = true;
            this.buttonVehiclePaid.Click += new System.EventHandler(this.buttonVehiclePaid_Click);
            // 
            // buttonLoadDataDB
            // 
            this.buttonLoadDataDB.Location = new System.Drawing.Point(592, 165);
            this.buttonLoadDataDB.Name = "buttonLoadDataDB";
            this.buttonLoadDataDB.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadDataDB.TabIndex = 23;
            this.buttonLoadDataDB.Text = "LOAD";
            this.buttonLoadDataDB.UseVisualStyleBackColor = true;
            // 
            // buttonClearDataDB
            // 
            this.buttonClearDataDB.Location = new System.Drawing.Point(673, 165);
            this.buttonClearDataDB.Name = "buttonClearDataDB";
            this.buttonClearDataDB.Size = new System.Drawing.Size(75, 23);
            this.buttonClearDataDB.TabIndex = 24;
            this.buttonClearDataDB.Text = "CLEAR DB";
            this.buttonClearDataDB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClearDataDB);
            this.Controls.Add(this.buttonLoadDataDB);
            this.Controls.Add(this.buttonVehiclePaid);
            this.Controls.Add(this.buttonUpdateData);
            this.Controls.Add(this.buttonSaveDataDB);
            this.Controls.Add(this.buttonTimeOUT);
            this.Controls.Add(this.buttonDeleteData);
            this.Controls.Add(this.buttonTimeIN);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeTB_TimeOUT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeTB_TimeIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewParking);
            this.Name = "Form1";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewParking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timeTB_TimeIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker timeTB_TimeOUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonTimeIN;
        private System.Windows.Forms.Button buttonDeleteData;
        private System.Windows.Forms.Button buttonTimeOUT;
        private System.Windows.Forms.Button buttonSaveDataDB;
        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.Button buttonVehiclePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeinCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeoutCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidCol;
        private System.Windows.Forms.Button buttonLoadDataDB;
        private System.Windows.Forms.Button buttonClearDataDB;
    }
}

