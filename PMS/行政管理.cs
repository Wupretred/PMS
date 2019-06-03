using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PMS
{
    public partial class 行政管理 : Form
    {
        SqlConnection sqlConnection = SetConnection.GetConnection();
        private List<People> list;
        public 行政管理()
        {
            InitializeComponent();
        }

        private void 行政管理_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pMSDataSet10.RATE”中。您可以根据需要移动或删除它。
//            this.rATETableAdapter.Fill(this.pMSDataSet10.RATE);
//            // TODO: 这行代码将数据加载到表“pMSDataSet4.DEPARTMENT”中。您可以根据需要移动或删除它。
//            this.dEPARTMENTTableAdapter.Fill(this.pMSDataSet4.DEPARTMENT);
        }

        private void Button1_Click(object sender, EventArgs e) //查询
        {
            GetData();
            SqlDataReader sqlDataReader = null;
            StringBuilder stringBuilder = new StringBuilder("select * from DEPARTMENT where ");
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
                    departmenttable.DataSource = bindingSource;
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
        private void Button2_Click(object sender, EventArgs e) //修改
        {
            String Dno = textBox1.Text.Trim();
            String Dname = textBox2.Text.Trim();
            String Dpop = textBox3.Text.Trim();

            try
            {
                string insertStr = "UPDATE DEPARTMENT SET Dname = '" + Dname + "',Dpop='" + Dpop + "' WHERE Dno = '" +
                                   Dno + "'";
                SqlCommand cmd = new SqlCommand(insertStr, sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功。");
                SqlCommand sqlCommand = new SqlCommand("select * from DEPARTMENT", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                departmenttable.DataSource = bindingSource;
                sqlDataReader.Close();
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!", "警告");
            }
        }

        private void Button3_Click(object sender, EventArgs e) //增加
        {
            String Dno = textBox1.Text.Trim();
            String Dname = textBox2.Text.Trim();
            String Dpop = textBox3.Text.Trim();
            try
            {
                if (Dno == "" || Dname == "" || Dpop == "")
                {
                    MessageBox.Show("请将信息填写完整!", "警告");
                }
                else
                {
                    string insertStr = "INSERT INTO  DEPARTMENT (Dno,Dname,Dpop)    " +
                                       "VALUES ('" + Dno + "','" + Dname + "','" + Dpop + "')";
                    SqlCommand cmd = new SqlCommand(insertStr, sqlConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功。");
                    SqlCommand sqlCommand = new SqlCommand("select * from DEPARTMENT", sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    departmenttable.DataSource = bindingSource;
                    sqlDataReader.Close();
                }
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!", "警告");
            }

        }

        private void Button8_Click(object sender, EventArgs e) //查询
        {
            String RATEID = textBox6.Text.Trim();
            try
            {
                String select_by_RATEID = "select * from RATE where RATEID ='" + RATEID + "'";
                SqlCommand sqlCommand = new SqlCommand(select_by_RATEID, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
                sqlDataReader.Close();
            }
            catch
            {
                MessageBox.Show("查询有误，请检查!", "警告");
                throw;
            }
        }

        private void Button7_Click(object sender, EventArgs e) //修改
        {
            String RATEID = textBox6.Text.Trim();
            String INSURANCE = textBox5.Text.Trim();
            String TAX = textBox4.Text.Trim();
            String MINpaytax = textBox7.Text.Trim();
            try
            {
                string insertStr = "UPDATE RATE SET INSURANCE = '" + INSURANCE + "',TAX='" + TAX + "',MINpaytax='" +
                                   MINpaytax + "' WHERE RATEID = '" + RATEID + "'";
                SqlCommand cmd = new SqlCommand(insertStr, sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功。");
                SqlCommand sqlCommand = new SqlCommand("select * from RATE", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
                sqlDataReader.Close();
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!", "警告");
            }
           

        }

        private void Button4_Click(object sender, EventArgs e) //增加
        {
            String RATEID = textBox6.Text.Trim();
            String INSURANCE = textBox5.Text.Trim();
            String TAX = textBox4.Text.Trim();
            String MINpaytax = textBox7.Text.Trim();
            try
            {
                if (RATEID == "" || INSURANCE == "" || TAX == "" || MINpaytax == "")
                {
                    MessageBox.Show("请将信息填写完整!", "警告");
                }
                else
                {
                    string insertStr = "INSERT INTO  RATE (RATEID,INSURANCE,TAX,MINpaytax)    " +
                                       "VALUES ('" + RATEID + "','" + INSURANCE + "','" + TAX + "','" + MINpaytax +
                                       "')";
                    SqlCommand cmd = new SqlCommand(insertStr, sqlConnection);
                    cmd.ExecuteNonQuery();
                    SqlCommand sqlCommand = new SqlCommand("select * from RATE", sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    dataGridView1.DataSource = bindingSource;
                    sqlDataReader.Close();
                }
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!");
            }

        }

        private void Button9_Click(object sender, EventArgs e) //删除
        {
            try
            {
                string select_Dno = departmenttable.SelectedRows[0].Cells[0].Value.ToString(); //选择的当前行第一列的值，也就是ID
                string delete_by_Dno = "delete from DEPARTMENT where Dno=" + select_Dno; //sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_Dno, sqlConnection);
                cmd.ExecuteNonQuery();
                SqlCommand sqlCommand = new SqlCommand("select * from RATE", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
                sqlDataReader.Close();
            }
            catch
            {
                MessageBox.Show("请正确选择行!");
            }
        }
        public void GetData()
        {
            list = null;
            list = new List<People>();
            list.Add(new People("Dno", textBox1.Text.Trim()));
            list.Add(new People("Dname", textBox2.Text.Trim()));
            list.Add(new People("Dpop", textBox3.Text));
        }
    }

}