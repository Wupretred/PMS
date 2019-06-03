using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMS
{
    public partial class 员工查询 : Form
    {
        public 员工查询()
        {
            InitializeComponent();
        }

        private void 员工查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pMSDataSet15.SALARY”中。您可以根据需要移动或删除它。
            this.sALARYTableAdapter1.Fill(this.pMSDataSet15.SALARY);
            // TODO: 这行代码将数据加载到表“pMSDataSet14.STAFF”中。您可以根据需要移动或删除它。
            this.sTAFFTableAdapter.Fill(this.pMSDataSet14.STAFF);
            // TODO: 这行代码将数据加载到表“pMSDataSet13.ATTENDENCE”中。您可以根据需要移动或删除它。
            this.aTTENDENCETableAdapter.Fill(this.pMSDataSet13.ATTENDENCE);
            // TODO: 这行代码将数据加载到表“pMSDataSet12.WITHHOLD”中。您可以根据需要移动或删除它。
            this.wITHHOLDTableAdapter.Fill(this.pMSDataSet12.WITHHOLD);
            // TODO: 这行代码将数据加载到表“pMSDataSet11.SALARY”中。您可以根据需要移动或删除它。
            this.sALARYTableAdapter.Fill(this.pMSDataSet11.SALARY);
        }

        private void Button6_Click(object sender, EventArgs e) //工资查询
        {
            String Sno = textBox10.Text.Trim();
            String Sname = textBox9.Text.Trim();
            String Dno = comboBox2.Text.Trim();
            String Paytime = textBox8.Text.Trim();


            String conn = "Data Source=.;Initial Catalog=PMS;User ID=sa;Password=1641117";

            SqlConnection sqlConnection = new SqlConnection(conn); //实例化连接对象
            sqlConnection.Open();

            if (Sno != "" && Sname == "" && Dno == "" && Paytime == "")
            {
                String select_by_Sno = "select * from SALARY where Sno='" + Sno + "'";
                SqlCommand sqlCommand = new SqlCommand(select_by_Sno, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                salarytable.DataSource = bindingSource;
            }
            else if (Sno == "" && Sname != "" && Dno == "" && Paytime == "")
            {
                String select_by_Sname = "select * from SALARY where Sname='" + Sname + "'";
                SqlCommand sqlCommand1 = new SqlCommand(select_by_Sname, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                salarytable.DataSource = bindingSource1;
            }
            else if (Sno == "" && Sname == "" && Dno != "" && Paytime == "")
            {
                String select_by_Dno = "select * from SALARY where Dno='" + Dno + "'";
                SqlCommand sqlCommand1 = new SqlCommand(select_by_Dno, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                salarytable.DataSource = bindingSource1;
            }
            else if (Sno == "" && Sname == "" && Dno == "" && Paytime != "")
            {
                String select_by_Paytime = "select * from SALARY where Paytime='" + Paytime + "'";
                SqlCommand sqlCommand1 = new SqlCommand(select_by_Paytime, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                salarytable.DataSource = bindingSource1;
            }
            else if (Sno == "" && Sname == "" && Dno == "" && Paytime == "")
            {
                String select = "select * from SALARY ";
                SqlCommand sqlCommand1 = new SqlCommand(select, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                salarytable.DataSource = bindingSource1;
            }
            else
            {
                MessageBox.Show("输入有误，请检查!", "警告");
            }

            sqlConnection.Close();
        }

        private void Button2_Click(object sender, EventArgs e) //代扣查询
        {
            String WITHHOLDID = textBox12.Text.Trim();
            String Sno = textBox5.Text.Trim();
            String RID = textBox7.Text.Trim();
            String WITHHOLDTIME = textBox11.Text.Trim();

            String conn = "Data Source=.;Initial Catalog=PMS;User ID=sa;Password=1641117";

            SqlConnection sqlConnection = new SqlConnection(conn); //实例化连接对象
            sqlConnection.Open();

            if (WITHHOLDID != "" && Sno == "" && RID == "" && WITHHOLDTIME == "")
            {
                String select_by_ID = "select * from WITHHOLD where WITHHOLDID='" + WITHHOLDID + "'";
                SqlCommand sqlCommand = new SqlCommand(select_by_ID, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                withholdtable.DataSource = bindingSource;
            }
            else if (WITHHOLDID == "" && Sno != "" && RID == "" && WITHHOLDTIME == "")
            {
                String select_by_Sno = "select * from WITHHOLD where Sno='" + Sno + "'";
                SqlCommand sqlCommand1 = new SqlCommand(select_by_Sno, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                withholdtable.DataSource = bindingSource1;
            }
            else if (WITHHOLDID == "" && Sno == "" && RID != "" && WITHHOLDTIME == "")
            {
                String select_by_RID = "select * from WITHHOLD where RID='" + RID + "'";
                SqlCommand sqlCommand1 = new SqlCommand(select_by_RID, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                withholdtable.DataSource = bindingSource1;
            }
            else if (WITHHOLDID == "" && Sno == "" && RID == "" && WITHHOLDTIME != "")
            {
                String select_by_time = "select * from WITHHOLD where WITHHOLDTIME='" + WITHHOLDTIME + "'";
                SqlCommand sqlCommand1 = new SqlCommand(select_by_time, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                withholdtable.DataSource = bindingSource1;
            }
            else if (WITHHOLDID != "" && Sno == "" && RID == "" && WITHHOLDTIME == "")
            {
                String select = "select * from WITHHOLD ";
                SqlCommand sqlCommand1 = new SqlCommand(select, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                withholdtable.DataSource = bindingSource1;
            }
            else
            {
                MessageBox.Show("输入有误，请检查!", "警告");
            }

            sqlConnection.Close();
        }

        private void Button3_Click(object sender, EventArgs e) //出勤查询
        {
            String Sno = textBox3.Text.Trim();
            String OVERTIME = textBox1.Text.Trim();
            String ABSENCE = textBox2.Text.Trim();
            String ATIME = textBox4.Text.Trim();


            String conn = "Data Source=.;Initial Catalog=PMS;User ID=sa;Password=1641117";

            SqlConnection sqlConnection = new SqlConnection(conn); //实例化连接对象
            sqlConnection.Open();

            if (Sno != "" && ATIME == "" && OVERTIME == "" && ABSENCE == "")
            {
                String select_by_Sno = "select * from ATTENDENCE where Sno='" + Sno + "'";
                SqlCommand sqlCommand = new SqlCommand(select_by_Sno, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                attendencetable.DataSource = bindingSource;
            }
            else if (Sno == "" && ATIME != "" && OVERTIME == "" && ABSENCE == "")
            {
                String select_by_ATIME = "select * from ATTENDENCE where ATIME='" + ATIME + "'";
                SqlCommand sqlCommand1 = new SqlCommand(select_by_ATIME, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                attendencetable.DataSource = bindingSource1;
            }
            else if (Sno == "" && ATIME == "" && OVERTIME == "" && ABSENCE == "")
            {
                String select = "select * from ATTENDENCE ";
                SqlCommand sqlCommand1 = new SqlCommand(select, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                attendencetable.DataSource = bindingSource1;
            }
            else if (Sno == "" && ATIME == "" && OVERTIME != "" && ABSENCE == "")
            {
                String select_by_over = "select * from ATTENDENCE where OVERTIME='" + OVERTIME + "'";
                SqlCommand sqlCommand1 = new SqlCommand(select_by_over, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                attendencetable.DataSource = bindingSource1;
            }
            else if (Sno == "" && ATIME == "" && OVERTIME == "" && ABSENCE != "")
            {
                String select_by_Abs = "select * from ATTENDENCE where ABSENCE='" + ABSENCE + "'";
                SqlCommand sqlCommand1 = new SqlCommand(select_by_Abs, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                attendencetable.DataSource = bindingSource1;
            }
            else
            {
                MessageBox.Show("输入有误，请检查!", "警告");
            }

            sqlConnection.Close();
        }

        private void Button7_Click(object sender, EventArgs e) //同事查询
        {
            String Sno = textBox17.Text.Trim();
            String Sname = textBox16.Text.Trim();
            String Ssex = comboBox3.Text.Trim();
            String Sbirth = textBox13.Text.Trim();
            String Deptno = comboBox1.Text.Trim();
            String Slevel = textBox15.Text.Trim();
            String Stel = textBox6.Text.Trim();
            String Jointime = textBox14.Text.Trim();


            String conn = "Data Source=.;Initial Catalog=PMS;User ID=sa;Password=1641117";

            SqlConnection sqlConnection = new SqlConnection(conn); //实例化连接对象
            sqlConnection.Open();

            if (Sno != "" && Sname == "")
            {
                String select_by_Sno = "select * from STAFF where Sno='" + Sno + "'";
                SqlCommand sqlCommand = new SqlCommand(select_by_Sno, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                stafftable.DataSource = bindingSource;
            }
            else if (Sname != "" && Sno == "")
            {
                String select_by_Sname = "select * from STAFF where Sname='" + Sname + "'";
                SqlCommand sqlCommand1 = new SqlCommand(select_by_Sname, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                stafftable.DataSource = bindingSource1;
            }
            else if (Sname == "" && Sno == "")
            {
                String select = "select * from STAFF ";
                SqlCommand sqlCommand1 = new SqlCommand(select, sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = sqlDataReader1;
                stafftable.DataSource = bindingSource1;
            }
            else
            {
                MessageBox.Show("输入有误，请检查!", "警告");
            }

            sqlConnection.Close();
        }

       
    }
}