namespace PMS
{
    partial class 人事管理
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pMSDataSet = new PMS.PMSDataSet();
            this.stafftable = new System.Windows.Forms.DataGridView();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet1 = new PMS.PMSDataSet1();
            this.sTAFFTableAdapter = new PMS.PMSDataSet1TableAdapters.STAFFTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jointimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.stafftable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet1)).BeginInit();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label2.Location = new System.Drawing.Point(284, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label3.Location = new System.Drawing.Point(728, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "出生日期";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label4.Location = new System.Drawing.Point(509, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label5.Location = new System.Drawing.Point(509, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "时间";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label6.Location = new System.Drawing.Point(728, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "联系方式";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label7.Location = new System.Drawing.Point(284, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "级别";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label9.Location = new System.Drawing.Point(56, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "部门";
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button1.Location = new System.Drawing.Point(206, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button2.Location = new System.Drawing.Point(378, 198);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 62);
            this.button2.TabIndex = 10;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.button3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button3.Location = new System.Drawing.Point(541, 198);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 62);
            this.button3.TabIndex = 11;
            this.button3.Text = "增加";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            this.button4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.button4.Location = new System.Drawing.Point(721, 198);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 62);
            this.button4.TabIndex = 12;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            this.textBox1.Location = new System.Drawing.Point(124, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 23);
            this.textBox1.TabIndex = 13;
            this.textBox2.Location = new System.Drawing.Point(351, 38);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 23);
            this.textBox2.TabIndex = 14;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {"男", "女"});
            this.comboBox1.Location = new System.Drawing.Point(576, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 25);
            this.comboBox1.TabIndex = 15;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {"01", "02", "03", "04", "05", "06"});
            this.comboBox2.Location = new System.Drawing.Point(124, 108);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(123, 25);
            this.comboBox2.TabIndex = 17;
            this.textBox4.Location = new System.Drawing.Point(351, 108);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 23);
            this.textBox4.TabIndex = 18;
            this.textBox6.Location = new System.Drawing.Point(853, 109);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(123, 23);
            this.textBox6.TabIndex = 21;
            this.pMSDataSet.DataSetName = "PMSDataSet";
            this.pMSDataSet.Namespace = "http://tempuri.org/PMSDataSet.xsd";
            this.pMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.stafftable.AutoGenerateColumns = false;
            this.stafftable.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stafftable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.snoDataGridViewTextBoxColumn, this.snameDataGridViewTextBoxColumn,
                this.ssexDataGridViewTextBoxColumn, this.sbirthDataGridViewTextBoxColumn,
                this.deptnoDataGridViewTextBoxColumn, this.slevelDataGridViewTextBoxColumn,
                this.stelDataGridViewTextBoxColumn, this.jointimeDataGridViewTextBoxColumn
            });
            this.stafftable.DataSource = this.sTAFFBindingSource;
            this.stafftable.Location = new System.Drawing.Point(33, 306);
            this.stafftable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stafftable.Name = "stafftable";
            this.stafftable.RowTemplate.Height = 23;
            this.stafftable.Size = new System.Drawing.Size(986, 361);
            this.stafftable.TabIndex = 22;
            this.stafftable.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.Stafftable_CellContentClick);
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.pMSDataSet1;
            this.pMSDataSet1.DataSetName = "PMSDataSet1";
            this.pMSDataSet1.Namespace = "http://tempuri.org/PMSDataSet1.xsd";
            this.pMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            this.textBox3.Location = new System.Drawing.Point(853, 42);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 23);
            this.textBox3.TabIndex = 23;
            this.textBox5.Location = new System.Drawing.Point(576, 110);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(123, 23);
            this.textBox5.TabIndex = 24;
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.ssexDataGridViewTextBoxColumn.DataPropertyName = "Ssex";
            this.ssexDataGridViewTextBoxColumn.HeaderText = "Ssex";
            this.ssexDataGridViewTextBoxColumn.Name = "ssexDataGridViewTextBoxColumn";
            this.sbirthDataGridViewTextBoxColumn.DataPropertyName = "Sbirth";
            this.sbirthDataGridViewTextBoxColumn.HeaderText = "Sbirth";
            this.sbirthDataGridViewTextBoxColumn.Name = "sbirthDataGridViewTextBoxColumn";
            this.deptnoDataGridViewTextBoxColumn.DataPropertyName = "Deptno";
            this.deptnoDataGridViewTextBoxColumn.HeaderText = "Deptno";
            this.deptnoDataGridViewTextBoxColumn.Name = "deptnoDataGridViewTextBoxColumn";
            this.slevelDataGridViewTextBoxColumn.DataPropertyName = "Slevel";
            this.slevelDataGridViewTextBoxColumn.HeaderText = "Slevel";
            this.slevelDataGridViewTextBoxColumn.Name = "slevelDataGridViewTextBoxColumn";
            this.stelDataGridViewTextBoxColumn.DataPropertyName = "Stel";
            this.stelDataGridViewTextBoxColumn.HeaderText = "Stel";
            this.stelDataGridViewTextBoxColumn.Name = "stelDataGridViewTextBoxColumn";
            this.jointimeDataGridViewTextBoxColumn.DataPropertyName = "Jointime";
            this.jointimeDataGridViewTextBoxColumn.HeaderText = "Jointime";
            this.jointimeDataGridViewTextBoxColumn.Name = "jointimeDataGridViewTextBoxColumn";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 684);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.stafftable);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "人事管理";
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.人事管理_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.stafftable)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pMSDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jointimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private PMS.PMSDataSet pMSDataSet;
        private System.Windows.Forms.DataGridView stafftable;
        private PMS.PMSDataSet1 pMSDataSet1;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private PMS.PMSDataSet1TableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
    }
}