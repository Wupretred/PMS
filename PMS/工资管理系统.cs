using System;
using System.Windows.Forms;

namespace PMS
{
    public partial class 工资管理系统 : Form
    {
        private 行政管理 _formAdminManage;
        private 出勤管理 _formDutyManage;
        private 忘记密码 _formForgetPasswd;
        private 人事管理 _formPersonalManage;
        private Form[] _forms = new Form[4];
        private 工资管理 _formSalaryManage;

        public 工资管理系统()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            DrawForm();
            _formPersonalManage.MdiParent = this;
            _formPersonalManage.FormBorderStyle = FormBorderStyle.None;
            _formPersonalManage.TopLevel = false;
            _formPersonalManage.ControlBox = false;
            _formPersonalManage.Dock = DockStyle.Fill;
            _formPersonalManage.StartPosition = FormStartPosition.CenterParent;
            //设置子窗口的父布局为当前窗口，并将form的标题栏隐藏
            _formPersonalManage.Show();
        }


        private void 人事管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formPersonalManage);
            _formPersonalManage.MdiParent = this;
            _formPersonalManage.FormBorderStyle = FormBorderStyle.None;
            _formPersonalManage.TopLevel = false;
            _formPersonalManage.ControlBox = false;
            _formPersonalManage.Dock = DockStyle.Fill;
            _formPersonalManage.MdiParent = this;
            _formPersonalManage.StartPosition = FormStartPosition.CenterParent;
        }

        private void 工资管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formSalaryManage);
            _formSalaryManage.MdiParent = this;
            _formSalaryManage.FormBorderStyle = FormBorderStyle.None;
            _formSalaryManage.TopLevel = false;
            _formSalaryManage.ControlBox = false;
            _formSalaryManage.Dock = DockStyle.Fill;
            _formSalaryManage.MdiParent = this;
            _formSalaryManage.StartPosition = FormStartPosition.CenterScreen;
            _formSalaryManage.Show();
        }

        private void 工资管理系统_Load(object sender, EventArgs e)
        {
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            管理员登录界面 form = new 管理员登录界面();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            帮助 form = new 帮助();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.ControlBox = false;
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void 行政管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formAdminManage);
            _formAdminManage.MdiParent = this;
            _formAdminManage.FormBorderStyle = FormBorderStyle.None;
            _formAdminManage.TopLevel = false;
            _formAdminManage.ControlBox = false;
            _formAdminManage.Dock = DockStyle.Fill;
            _formAdminManage.MdiParent = this;
            _formAdminManage.StartPosition = FormStartPosition.CenterScreen;
            _formAdminManage.Show();
        }

        private void 出勤管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formDutyManage);
            _formDutyManage.MdiParent = this;
            _formDutyManage.FormBorderStyle = FormBorderStyle.None;
            _formDutyManage.TopLevel = false;
            _formDutyManage.ControlBox = false;
            _formDutyManage.Dock = DockStyle.Fill;
            _formDutyManage.MdiParent = this;
            _formDutyManage.StartPosition = FormStartPosition.CenterScreen;
            _formDutyManage.Show();
        }

        private void DrawForm()
        {
            _formPersonalManage = new 人事管理();
            _forms[0] = _formPersonalManage;
            _formSalaryManage = new 工资管理();
            _forms[1] = _formSalaryManage;
            _formAdminManage = new 行政管理();
            _forms[2] = _formAdminManage;
            _formDutyManage = new 出勤管理();
            _forms[3] = _formDutyManage;
        }

        private void ShowAndHide(Form form)
        {
            foreach (Form f in _forms)
            {
                if (f.Equals(form))
                {
                    f.Show();
                }
                else
                    f.Hide();
            }
        }
    }
}