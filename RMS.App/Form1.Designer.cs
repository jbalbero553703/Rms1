namespace RMS.App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnDisplay = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtModels = new TextBox();
            btnSave = new Button();
            comboCondition = new ComboBox();
            comboLoanStatus = new ComboBox();
            comboCategory = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSerialNum = new TextBox();
            label1 = new Label();
            initialSetupBindingSource = new BindingSource(components);
            appDbContextBindingSource = new BindingSource(components);
            btnDelete = new Button();
            appDbContextBindingSource1 = new BindingSource(components);
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)initialSetupBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(436, 300);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(121, 30);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(332, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(440, 268);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txtModels);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(comboCondition);
            groupBox1.Controls.Add(comboLoanStatus);
            groupBox1.Controls.Add(comboCategory);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSerialNum);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 387);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Item";
            // 
            // txtModels
            // 
            txtModels.Location = new Point(150, 99);
            txtModels.Name = "txtModels";
            txtModels.Size = new Size(121, 23);
            txtModels.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 339);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 30);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // comboCondition
            // 
            comboCondition.FormattingEnabled = true;
            comboCondition.Items.AddRange(new object[] { "New", "Good", "Fair", "Poor", "UnderRepair", "Broken" });
            comboCondition.Location = new Point(150, 288);
            comboCondition.Name = "comboCondition";
            comboCondition.Size = new Size(121, 23);
            comboCondition.TabIndex = 11;
            // 
            // comboLoanStatus
            // 
            comboLoanStatus.FormattingEnabled = true;
            comboLoanStatus.Items.AddRange(new object[] { "Available", "Loaned", "Maintenance" });
            comboLoanStatus.Location = new Point(150, 225);
            comboLoanStatus.Name = "comboLoanStatus";
            comboLoanStatus.Size = new Size(121, 23);
            comboLoanStatus.TabIndex = 10;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Items.AddRange(new object[] { "Computer", "Printer", "Router", "Switch", "Other" });
            comboCategory.Location = new Point(150, 162);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(121, 23);
            comboCategory.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 291);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Condition:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 228);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 6;
            label4.Text = "Loan Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 165);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 102);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Model:";
            // 
            // txtSerialNum
            // 
            txtSerialNum.Location = new Point(150, 36);
            txtSerialNum.Name = "txtSerialNum";
            txtSerialNum.Size = new Size(121, 23);
            txtSerialNum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 39);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Serial Number:";
            // 
            // initialSetupBindingSource
            // 
            initialSetupBindingSource.DataSource = typeof(Infrastructure.Migrations.initialSetup);
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(Infrastructure.Data.AppDbContext);
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(563, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 30);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // appDbContextBindingSource1
            // 
            appDbContextBindingSource1.DataSource = typeof(Infrastructure.Data.AppDbContext);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(31, 343);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)initialSetupBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplay;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox txtSerialNum;
        private Label label1;
        private Button btnSave;
        private ComboBox comboCondition;
        private ComboBox comboLoanStatus;
        private ComboBox comboCategory;
        private Button btnDelete;
        private TextBox txtModels;
        private BindingSource appDbContextBindingSource;
        private BindingSource initialSetupBindingSource;
        private BindingSource appDbContextBindingSource1;
        private Button btnUpdate;
    }
}
