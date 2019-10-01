using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DaoLayer;
using Entity;
using System.Threading;

namespace WindowsFormsApp
{
    public partial class FrmStudent : Form
    {
        List<Student> stuList;
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
    }
}
