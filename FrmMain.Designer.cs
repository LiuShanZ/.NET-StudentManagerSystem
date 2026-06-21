namespace StudentManagerPro
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_PwdModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学员管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学员AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量导入学员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.学员信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStuManage = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.学员管理MToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1896, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_PwdModify,
            this.toolStripSeparator1,
            this.退出系统ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(82, 32);
            this.系统ToolStripMenuItem.Text = "系统(s&)";
            this.系统ToolStripMenuItem.Click += new System.EventHandler(this.系统ToolStripMenuItem_Click);
            // 
            // tsmi_PwdModify
            // 
            this.tsmi_PwdModify.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_PwdModify.Image")));
            this.tsmi_PwdModify.Name = "tsmi_PwdModify";
            this.tsmi_PwdModify.Size = new System.Drawing.Size(212, 34);
            this.tsmi_PwdModify.Text = "密码修改(M&)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出系统ToolStripMenuItem.Image")));
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            // 
            // 学员管理MToolStripMenuItem
            // 
            this.学员管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学员AToolStripMenuItem,
            this.批量导入学员ToolStripMenuItem,
            this.toolStripSeparator2,
            this.学员信息管理ToolStripMenuItem});
            this.学员管理MToolStripMenuItem.Name = "学员管理MToolStripMenuItem";
            this.学员管理MToolStripMenuItem.Size = new System.Drawing.Size(128, 32);
            this.学员管理MToolStripMenuItem.Text = "学员管理(M&)";
            // 
            // 添加学员AToolStripMenuItem
            // 
            this.添加学员AToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("添加学员AToolStripMenuItem.Image")));
            this.添加学员AToolStripMenuItem.Name = "添加学员AToolStripMenuItem";
            this.添加学员AToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.添加学员AToolStripMenuItem.Text = "添加学员(A&)";
            // 
            // 批量导入学员ToolStripMenuItem
            // 
            this.批量导入学员ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("批量导入学员ToolStripMenuItem.Image")));
            this.批量导入学员ToolStripMenuItem.Name = "批量导入学员ToolStripMenuItem";
            this.批量导入学员ToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.批量导入学员ToolStripMenuItem.Text = "批量导入学员(I&)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // 学员信息管理ToolStripMenuItem
            // 
            this.学员信息管理ToolStripMenuItem.Name = "学员信息管理ToolStripMenuItem";
            this.学员信息管理ToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.学员信息管理ToolStripMenuItem.Text = "学员信息管理";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 991);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1896, 31);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 24);
            this.toolStripStatusLabel1.Text = " ";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(64, 24);
            this.toolStripStatusLabel2.Text = "版本号";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(136, 24);
            this.toolStripStatusLabel3.Text = "[当前用户：***]";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // spContainer
            // 
            this.spContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainer.Location = new System.Drawing.Point(0, 36);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.button7);
            this.spContainer.Panel1.Controls.Add(this.button5);
            this.spContainer.Panel1.Controls.Add(this.button3);
            this.spContainer.Panel1.Controls.Add(this.button1);
            this.spContainer.Panel1.Controls.Add(this.button6);
            this.spContainer.Panel1.Controls.Add(this.button4);
            this.spContainer.Panel1.Controls.Add(this.btnStuManage);
            this.spContainer.Panel1.Controls.Add(this.btnAddStudent);
            this.spContainer.Panel1.Controls.Add(this.monthCalendar1);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spContainer.Panel2.BackgroundImage")));
            this.spContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spContainer.Panel2.Controls.Add(this.label1);
            this.spContainer.Size = new System.Drawing.Size(1896, 955);
            this.spContainer.SplitterDistance = 311;
            this.spContainer.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(200, 783);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 39);
            this.button7.TabIndex = 1;
            this.button7.Text = "退出系统";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(204, 504);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 39);
            this.button5.TabIndex = 1;
            this.button5.Text = "成绩浏览";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 5;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(204, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 39);
            this.button3.TabIndex = 1;
            this.button3.Text = "考勤打卡";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Turquoise;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "accept.png");
            this.imageList1.Images.SetKeyName(2, "zoom_selection.png");
            this.imageList1.Images.SetKeyName(3, "access_exports.png");
            this.imageList1.Images.SetKeyName(4, "border_color.png");
            this.imageList1.Images.SetKeyName(5, "allow_users_edit_ranges.png");
            this.imageList1.Images.SetKeyName(6, "user_go.png");
            this.imageList1.Images.SetKeyName(7, "basket.png");
            this.imageList1.Images.SetKeyName(8, "attach.png");
            this.imageList1.Images.SetKeyName(9, "star.png");
            this.imageList1.Images.SetKeyName(10, "cancel.png");
            this.imageList1.Images.SetKeyName(11, "cog.png");
            this.imageList1.Images.SetKeyName(12, "address_block.png");
            this.imageList1.Images.SetKeyName(13, "Work area.ico");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 12;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(204, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "批量导入";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(40, 783);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 39);
            this.button6.TabIndex = 1;
            this.button6.Text = "密码修改";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(40, 504);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 39);
            this.button4.TabIndex = 1;
            this.button4.Text = "成绩分析";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnStuManage
            // 
            this.btnStuManage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStuManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuManage.ImageIndex = 13;
            this.btnStuManage.ImageList = this.imageList1;
            this.btnStuManage.Location = new System.Drawing.Point(40, 406);
            this.btnStuManage.Name = "btnStuManage";
            this.btnStuManage.Size = new System.Drawing.Size(130, 39);
            this.btnStuManage.TabIndex = 1;
            this.btnStuManage.Text = "学员管理";
            this.btnStuManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStuManage.UseVisualStyleBackColor = true;
            this.btnStuManage.Click += new System.EventHandler(this.btnStuManage_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(40, 334);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(130, 39);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "添加学员";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(40, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用教学管理系统";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1022);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[学生管理系统]";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel2.ResumeLayout(false);
            this.spContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_PwdModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学员管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学员AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量导入学员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 学员信息管理ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStuManage;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}

