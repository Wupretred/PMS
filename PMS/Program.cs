using System;
using System.Windows.Forms;

namespace PMS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 选择登陆());
            选择登陆 form1 = new 选择登陆();

            form1.ShowDialog(); //界面转换
            if (form1.DialogResult == DialogResult.OK)
            {
                form1.Dispose();
                Application.Run(new 工资管理系统());
            }
            else if (form1.DialogResult == DialogResult.Cancel)
            {
                form1.Dispose();
                return;
            }
        }
    }
}