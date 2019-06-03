namespace PMS
{
    partial class 行政管理
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.departmenttable = new System.Windows.Forms.DataGridView();
            this.dnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet4 = new PMS.PMSDataSet4();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rATEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSURANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mINpaytaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet10 = new PMS.PMSDataSet10();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dEPARTMENTTableAdapter = new PMS.PMSDataSet4TableAdapters.DEPARTMENTTableAdapter();
            this.rATETableAdapter = new PMS.PMSDataSet10TableAdapters.RATETableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.departmenttable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dEPARTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.rATEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet10)).BeginInit();
            this.SuspendLayout();
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 618);
            this.tabControl1.TabIndex = 0;
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.departmenttable);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1080, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "部门管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.button9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button9.Location = new System.Drawing.Point(667, 116);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 62);
            this.button9.TabIndex = 27;
            this.button9.Text = "删除";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            this.departmenttable.AutoGenerateColumns = false;
            this.departmenttable.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmenttable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.dnoDataGridViewTextBoxColumn, this.dnameDataGridViewTextBoxColumn,
                this.dpopDataGridViewTextBoxColumn
            });
            this.departmenttable.DataSource = this.dEPARTMENTBindingSource;
            this.departmenttable.Location = new System.Drawing.Point(80, 201);
            this.departmenttable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.departmenttable.Name = "departmenttable";
            this.departmenttable.RowTemplate.Height = 23;
            this.departmenttable.Size = new System.Drawing.Size(800, 371);
            this.departmenttable.TabIndex = 26;
            this.dnoDataGridViewTextBoxColumn.DataPropertyName = "Dno";
            this.dnoDataGridViewTextBoxColumn.HeaderText = "Dno";
            this.dnoDataGridViewTextBoxColumn.Name = "dnoDataGridViewTextBoxColumn";
            this.dnameDataGridViewTextBoxColumn.DataPropertyName = "Dname";
            this.dnameDataGridViewTextBoxColumn.HeaderText = "Dname";
            this.dnameDataGridViewTextBoxColumn.Name = "dnameDataGridViewTextBoxColumn";
            this.dpopDataGridViewTextBoxColumn.DataPropertyName = "Dpop";
            this.dpopDataGridViewTextBoxColumn.HeaderText = "Dpop";
            this.dpopDataGridViewTextBoxColumn.Name = "dpopDataGridViewTextBoxColumn";
            this.dEPARTMENTBindingSource.DataMember = "DEPARTMENT";
            this.dEPARTMENTBindingSource.DataSource = this.pMSDataSet4;
            this.pMSDataSet4.DataSetName = "PMSDataSet4";
            this.pMSDataSet4.Namespace = "http://tempuri.org/PMSDataSet4.xsd";
            this.pMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button3.Location = new System.Drawing.Point(506, 116);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 62);
            this.button3.TabIndex = 25;
            this.button3.Text = "增加";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            this.button2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button2.Location = new System.Drawing.Point(345, 116);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 62);
            this.button2.TabIndex = 24;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button1.Location = new System.Drawing.Point(184, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 62);
            this.button1.TabIndex = 23;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.textBox3.Location = new System.Drawing.Point(715, 38);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 23);
            this.textBox3.TabIndex = 22;
            this.textBox2.Location = new System.Drawing.Point(407, 38);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 23);
            this.textBox2.TabIndex = 20;
            this.textBox1.Location = new System.Drawing.Point(142, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 23);
            this.textBox1.TabIndex = 19;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label4.Location = new System.Drawing.Point(586, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "部门人数";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label2.Location = new System.Drawing.Point(340, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "名称";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(75, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "部号";
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1080, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "税收保险管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.button8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button8.Location = new System.Drawing.Point(726, 191);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 62);
            this.button8.TabIndex = 40;
            this.button8.Text = "查询";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            this.button7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button7.Location = new System.Drawing.Point(726, 109);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 62);
            this.button7.TabIndex = 39;
            this.button7.Text = "修改";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            this.textBox7.Location = new System.Drawing.Point(524, 113);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(123, 23);
            this.textBox7.TabIndex = 38;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label7.Location = new System.Drawing.Point(363, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 27);
            this.label7.TabIndex = 37;
            this.label7.Text = "最低纳税金额";
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.rATEIDDataGridViewTextBoxColumn, this.iNSURANCEDataGridViewTextBoxColumn,
                this.tAXDataGridViewTextBoxColumn, this.mINpaytaxDataGridViewTextBoxColumn
            });
            this.dataGridView1.DataSource = this.rATEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(80, 191);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(586, 353);
            this.dataGridView1.TabIndex = 36;
            this.rATEIDDataGridViewTextBoxColumn.DataPropertyName = "RATEID";
            this.rATEIDDataGridViewTextBoxColumn.HeaderText = "RATEID";
            this.rATEIDDataGridViewTextBoxColumn.Name = "rATEIDDataGridViewTextBoxColumn";
            this.iNSURANCEDataGridViewTextBoxColumn.DataPropertyName = "INSURANCE";
            this.iNSURANCEDataGridViewTextBoxColumn.HeaderText = "INSURANCE";
            this.iNSURANCEDataGridViewTextBoxColumn.Name = "iNSURANCEDataGridViewTextBoxColumn";
            this.tAXDataGridViewTextBoxColumn.DataPropertyName = "TAX";
            this.tAXDataGridViewTextBoxColumn.HeaderText = "TAX";
            this.tAXDataGridViewTextBoxColumn.Name = "tAXDataGridViewTextBoxColumn";
            this.mINpaytaxDataGridViewTextBoxColumn.DataPropertyName = "MINpaytax";
            this.mINpaytaxDataGridViewTextBoxColumn.HeaderText = "MINpaytax";
            this.mINpaytaxDataGridViewTextBoxColumn.Name = "mINpaytaxDataGridViewTextBoxColumn";
            this.rATEBindingSource.DataMember = "RATE";
            this.rATEBindingSource.DataSource = this.pMSDataSet10;
            this.pMSDataSet10.DataSetName = "PMSDataSet10";
            this.pMSDataSet10.Namespace = "http://tempuri.org/PMSDataSet10.xsd";
            this.pMSDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button4.Location = new System.Drawing.Point(726, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 62);
            this.button4.TabIndex = 35;
            this.button4.Text = "增加";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            this.button5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button5.Location = new System.Drawing.Point(497, 306);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 62);
            this.button5.TabIndex = 34;
            this.button5.Text = "修改";
            this.button5.UseVisualStyleBackColor = true;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button6.Location = new System.Drawing.Point(326, 306);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 62);
            this.button6.TabIndex = 33;
            this.button6.Text = "查询";
            this.button6.UseVisualStyleBackColor = true;
            this.textBox4.Location = new System.Drawing.Point(189, 113);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 23);
            this.textBox4.TabIndex = 32;
            this.textBox5.Location = new System.Drawing.Point(477, 42);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(123, 23);
            this.textBox5.TabIndex = 31;
            this.textBox6.Location = new System.Drawing.Point(138, 38);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(123, 23);
            this.textBox6.TabIndex = 30;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label3.Location = new System.Drawing.Point(75, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "五险一金";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label5.Location = new System.Drawing.Point(363, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "个税税率";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label6.Location = new System.Drawing.Point(75, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "编号";
            this.dEPARTMENTTableAdapter.ClearBeforeFill = true;
            this.rATETableAdapter.ClearBeforeFill = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 684);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "行政管理";
            this.Text = "行政管理";
            this.Load += new System.EventHandler(this.行政管理_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.departmenttable)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dEPARTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.rATEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet10)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView departmenttable;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private PMS.PMSDataSet4 pMSDataSet4;
        private System.Windows.Forms.BindingSource dEPARTMENTBindingSource;
        private PMS.PMSDataSet4TableAdapters.DEPARTMENTTableAdapter dEPARTMENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpopDataGridViewTextBoxColumn;
        private PMS.PMSDataSet10 pMSDataSet10;
        private System.Windows.Forms.BindingSource rATEBindingSource;
        private PMS.PMSDataSet10TableAdapters.RATETableAdapter rATETableAdapter;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn rATEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSURANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mINpaytaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button9;
    }
}