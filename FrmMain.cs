using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagerPro
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //关闭前置窗体
        private void CloseForm()
        {
            foreach (Control item in this.spContainer.Panel2.Controls)
            {
                if (item is Form)
                {
                    Form objForm = (Form)item;
                    objForm.Close();
                }
            }
        }
        
        //打开新窗体
        private void OpenForm(Form objFrm)
        {
            objFrm.TopLevel = false; //将子窗体设置成非顶级控件
            objFrm.WindowState = FormWindowState.Maximized; //让子窗体最大化显示
            objFrm.FormBorderStyle = FormBorderStyle.None; //去掉窗体的边框
            objFrm.Parent = this.spContainer.Panel2; //指定子窗体显示的容器


            objFrm.Show();
        }

        /// <summary>
        /// 添加学员按钮单击后触发的响应方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //关闭前置窗体
            CloseForm();

            //创建（添加学员）窗体
            OpenForm(new FrmAddStudent());

        }

        /// <summary>
        /// 学员管理按钮单击后触发的响应方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStuManage_Click(object sender, EventArgs e)
        {
            CloseForm();

            OpenForm(new FrmStudentManage());


        }
    }
}
