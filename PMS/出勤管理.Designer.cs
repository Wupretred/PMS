namespace PMS
{
    partial class 出勤管理
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
            this.stafftable = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oVERTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBSENCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTTENDENCEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet6 = new PMS.PMSDataSet6();
            this.aTTENDENCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet3 = new PMS.PMSDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.aTTENDENCETableAdapter = new PMS.PMSDataSet3TableAdapters.ATTENDENCETableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.aTTENDENCETableAdapter1 = new PMS.PMSDataSet6TableAdapters.ATTENDENCETableAdapter();
            ((System.ComponentModel.ISupportInitialize) (this.stafftable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.aTTENDENCEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.aTTENDENCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet3)).BeginInit();
            this.SuspendLayout();
            this.stafftable.AutoGenerateColumns = false;
            this.stafftable.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stafftable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.snoDataGridViewTextBoxColumn, this.oVERTIMEDataGridViewTextBoxColumn,
                this.aBSENCEDataGridViewTextBoxColumn, this.aTIMEDataGridViewTextBoxColumn
            });
            this.stafftable.DataSource = this.aTTENDENCEBindingSource1;
            this.stafftable.Location = new System.Drawing.Point(169, 58);
            this.stafftable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stafftable.Name = "stafftable";
            this.stafftable.RowTemplate.Height = 23;
            this.stafftable.Size = new System.Drawing.Size(642, 425);
            this.stafftable.TabIndex = 23;
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.oVERTIMEDataGridViewTextBoxColumn.DataPropertyName = "OVERTIME";
            this.oVERTIMEDataGridViewTextBoxColumn.HeaderText = "OVERTIME";
            this.oVERTIMEDataGridViewTextBoxColumn.Name = "oVERTIMEDataGridViewTextBoxColumn";
            this.aBSENCEDataGridViewTextBoxColumn.DataPropertyName = "ABSENCE";
            this.aBSENCEDataGridViewTextBoxColumn.HeaderText = "ABSENCE";
            this.aBSENCEDataGridViewTextBoxColumn.Name = "aBSENCEDataGridViewTextBoxColumn";
            this.aTIMEDataGridViewTextBoxColumn.DataPropertyName = "ATIME";
            this.aTIMEDataGridViewTextBoxColumn.HeaderText = "ATIME";
            this.aTIMEDataGridViewTextBoxColumn.Name = "aTIMEDataGridViewTextBoxColumn";
            this.aTTENDENCEBindingSource1.DataMember = "ATTENDENCE";
            this.aTTENDENCEBindingSource1.DataSource = this.pMSDataSet6;
            this.pMSDataSet6.DataSetName = "PMSDataSet6";
            this.pMSDataSet6.Namespace = "http://tempuri.org/PMSDataSet6.xsd";
            this.pMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.aTTENDENCEBindingSource.DataMember = "ATTENDENCE";
            this.aTTENDENCEBindingSource.DataSource = this.pMSDataSet3;
            this.pMSDataSet3.DataSetName = "PMSDataSet3";
            this.pMSDataSet3.Namespace = "http://tempuri.org/PMSDataSet3.xsd";
            this.pMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "出勤数据";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label2.Location = new System.Drawing.Point(30, 507);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "添加出勤信息";
            this.textBox3.Location = new System.Drawing.Point(118, 599);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 23);
            this.textBox3.TabIndex = 39;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            this.textBox2.Location = new System.Drawing.Point(643, 602);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 23);
            this.textBox2.TabIndex = 35;
            this.textBox1.Location = new System.Drawing.Point(380, 599);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 23);
            this.textBox1.TabIndex = 34;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label9.Location = new System.Drawing.Point(46, 594);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 27);
            this.label9.TabIndex = 33;
            this.label9.Text = "工号";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label3.Location = new System.Drawing.Point(788, 594);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "日期";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label8.Location = new System.Drawing.Point(524, 594);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 27);
            this.label8.TabIndex = 27;
            this.label8.Text = "缺勤天数";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label10.Location = new System.Drawing.Point(261, 594);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 27);
            this.label10.TabIndex = 26;
            this.label10.Text = "加班天数";
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button1.Location = new System.Drawing.Point(728, 507);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 57);
            this.button1.TabIndex = 40;
            this.button1.Text = "写入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.textBox4.Location = new System.Drawing.Point(855, 599);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 23);
            this.textBox4.TabIndex = 41;
            this.aTTENDENCETableAdapter.ClearBeforeFill = true;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button2.Location = new System.Drawing.Point(855, 507);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 57);
            this.button2.TabIndex = 42;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.button3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button3.Location = new System.Drawing.Point(595, 507);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 57);
            this.button3.TabIndex = 43;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            this.aTTENDENCETableAdapter1.ClearBeforeFill = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 684);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stafftable);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "出勤管理";
            this.Text = "出勤管理";
            this.Load += new System.EventHandler(this.出勤管理_Load);
            ((System.ComponentModel.ISupportInitialize) (this.stafftable)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.aTTENDENCEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.aTTENDENCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView stafftable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private PMS.PMSDataSet3 pMSDataSet3;
        private System.Windows.Forms.BindingSource aTTENDENCEBindingSource;
        private PMS.PMSDataSet3TableAdapters.ATTENDENCETableAdapter aTTENDENCETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oVERTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aBSENCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private PMS.PMSDataSet6 pMSDataSet6;
        private System.Windows.Forms.BindingSource aTTENDENCEBindingSource1;
        private PMS.PMSDataSet6TableAdapters.ATTENDENCETableAdapter aTTENDENCETableAdapter1;
    }
}