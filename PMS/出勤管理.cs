using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PMS
{
    public partial class 出勤管理 : Form
    {
        private SqlConnection sqlConnection = SetConnection.GetConnection();
        private List<People> list;

        public 出勤管理()
        {
            InitializeComponent();
            SqlCommand sqlCommand = new SqlCommand("select * from ATTENDENCE", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sqlDataReader;
            stafftable.DataSource = bindingSource;
            sqlDataReader.Close();
        }
        // private object pMSDataSet1;

        public object ATTENDENCETableAdapter { get; private set; }

        private void 出勤管理_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pMSDataSet6.ATTENDENCE”中。您可以根据需要移动或删除它。
//            this.aTTENDENCETableAdapter1.Fill(this.pMSDataSet6.ATTENDENCE);
        }

        private void Button1_Click(object sender, EventArgs e) //写入
        {
            String Sno = textBox3.Text.Trim();
            String Overtime = textBox1.Text.Trim();
            String Absence = textBox2.Text.Trim();
            String Atime = textBox4.Text.Trim();

            try
            {
                if (Sno == "" || Overtime == "" || Absence == "" || Atime == "")
                {
                    MessageBox.Show("请将信息填写完整!", "警告");
                }
                else
                {
                    string insertStr = "INSERT INTO  ATTENDENCE (Sno,OVERTIME,ABSENCE,ATIME) " +
                                       "VALUES ('" + Sno + "','" + Overtime + "','" + Absence + "','" + Atime + "')";
                    SqlCommand cmd = new SqlCommand(insertStr, sqlConnection);
                    cmd.ExecuteNonQuery();
                    SqlCommand sqlCommand = new SqlCommand("select * from ATTENDENCE", sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    stafftable.DataSource = bindingSource;
                    sqlDataReader.Close();
                }
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!", "警告");
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e) //删除
        {
            try
            {
                //问题 删除了所有工号相同的  怎么实现选中哪行删哪行
                string select_id = stafftable.SelectedRows[0].Cells[0].Value.ToString(); //选择的当前行第一列的值
                string select_overtime = stafftable.SelectedRows[0].Cells[1].Value.ToString(); //选择的当前行第一列的值
                string select_absence= stafftable.SelectedRows[0].Cells[2].Value.ToString(); //选择的当前行第一列的值
                string select_atime= stafftable.SelectedRows[0].Cells[3].Value.ToString(); //选择的当前行第一列的值

                string delete_by_id = "delete from ATTENDENCE where Sno=" + "'"+select_id+"'"
                    +" and OVERTIME="+select_overtime+" and ABSENCE="+select_absence+" and ATIME="+select_atime; //sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_id, sqlConnection);
                cmd.ExecuteNonQuery();

                SqlCommand sqlCommand = new SqlCommand("select * from ATTENDENCE", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                stafftable.DataSource = bindingSource;
                sqlDataReader.Close();
            }
            catch
            {
                MessageBox.Show("请正确选择行!");
                throw;
            }

        }

        private void Button3_Click(object sender, EventArgs e) //查询
        {
            GetData();
            SqlDataReader sqlDataReader = null;
            StringBuilder stringBuilder = new StringBuilder("select * from ATTENDENCE where ");
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].attr == "")
                {
                    list.Remove(list[i]);
                }
            }

            if (list.Count == 0)
            {
                MessageBox.Show("请输入信息！");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    stringBuilder.Append(list[i].name + " = '" + list[i].attr + "'");
                    if (i != list.Count - 1)
                    {
                        stringBuilder.Append(" and ");
                    }
                }

                SqlCommand sqlCommand = new SqlCommand(stringBuilder.ToString(), sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    stafftable.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show("未找到数据！");
                }

                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
            }
        }
        public void GetData()
        {
            list = null;
            list = new List<People>();
            list.Add(new People("Sno", textBox3.Text.Trim()));
            list.Add(new People("OVERTIME", textBox1.Text.Trim()));
            list.Add(new People("ABSENCE", textBox2.Text.Trim()));
            list.Add(new People("ATIME", textBox4.Text.Trim()));
        }
    }
}