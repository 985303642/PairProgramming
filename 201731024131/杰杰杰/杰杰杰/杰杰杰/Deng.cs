using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class Deng : Form
    {
        public Deng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from tblUser where userName='{0}' and userPwd='{1}'", textZH.Text, textMM.Text);
            DataSet ds = Xiugai.CX(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("登录成功！");
                 FrmStudent  frmS= new FrmStudent();
                this.Hide();
                frmS.ShowDialog();
            }
            else
            {
                MessageBox.Show("密码或账号错误！");
                textZH.Text = "";
                textMM.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
