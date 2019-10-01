using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using DaoLayer;
using Entity;
using System.Threading;

namespace WindowsFormsApp
{
    public partial class FrmStudent : Form
    {
        List<Student> stuList;
        string Mingdan;
        public FrmStudent()
        {
            InitializeComponent();
        }

        void iniControl()
        {
            btnStart.Visible = false;
            btnStop.Visible = false;
            btnLoadStu.Enabled = true;
        }

        void setControlVisible()
        {
            btnStart.Visible = true;
            btnStop.Visible = true;
            btnLoadStu.Visible = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerCallName.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerCallName.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mingdan = @"D:/缺课名单.txt";
            File.WriteAllText(Mingdan, "");
            //获取学生数据源
            StudentDAO stuDao = new StudentDAO();
            stuList = stuDao.getAllStudents();

            //进度条设置
            int stuCounts = stuList.Count;//及时学生人数
            progressName.Maximum = stuCounts;


            //构造数据源
            DataTable dt = new DataTable();
            dt.Columns.Add("stuID", Type.GetType("System.String"));
            dt.Columns.Add("stuName", Type.GetType("System.String"));

            //数据加载以进度条方式展现
            foreach (Student stu in stuList)
            {
                dt.Rows.Add(stu.Id, stu.Name);
                progressName.Value += 1;//一个学生，进度条加1；
                Thread.Sleep(500);
            }

            dgvStuList.DataSource = dt;

            setControlVisible();
        }

        private void timerCallName_c(object sender, EventArgs e)
        {
            Random ra = new Random();
            int i = ra.Next(stuList.Count);
            label2.Text = stuList[i].Name;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult t = new DialogResult();
            t = MessageBox.Show(string.Format("同学{0}是否缺课", label2.Text), "缺课提醒", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                File.AppendAllText(Mingdan, string.Format("{0}\n", label2.Text.ToString()), Encoding.UTF8);
            }
        }
    }
}
