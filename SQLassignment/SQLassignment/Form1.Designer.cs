namespace SQLassignment
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.传感器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.阅读器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.故障率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.传感器个数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.阅读器情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置了12个频点的全部阅读器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(283, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "传感器管理系统";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.录入ToolStripMenuItem,
            this.替换ToolStripMenuItem,
            this.配置工程ToolStripMenuItem,
            this.统计ToolStripMenuItem,
            this.阅读器情况ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 录入ToolStripMenuItem
            // 
            this.录入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.传感器ToolStripMenuItem,
            this.阅读器ToolStripMenuItem});
            this.录入ToolStripMenuItem.Name = "录入ToolStripMenuItem";
            this.录入ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.录入ToolStripMenuItem.Text = "录入";
            this.录入ToolStripMenuItem.Click += new System.EventHandler(this.录入ToolStripMenuItem_Click);
            // 
            // 传感器ToolStripMenuItem
            // 
            this.传感器ToolStripMenuItem.Name = "传感器ToolStripMenuItem";
            this.传感器ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.传感器ToolStripMenuItem.Text = "传感器";
            this.传感器ToolStripMenuItem.Click += new System.EventHandler(this.传感器ToolStripMenuItem_Click);
            // 
            // 阅读器ToolStripMenuItem
            // 
            this.阅读器ToolStripMenuItem.Name = "阅读器ToolStripMenuItem";
            this.阅读器ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.阅读器ToolStripMenuItem.Text = "阅读器";
            this.阅读器ToolStripMenuItem.Click += new System.EventHandler(this.阅读器ToolStripMenuItem_Click);
            // 
            // 替换ToolStripMenuItem
            // 
            this.替换ToolStripMenuItem.Name = "替换ToolStripMenuItem";
            this.替换ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.替换ToolStripMenuItem.Text = "替换";
            this.替换ToolStripMenuItem.Click += new System.EventHandler(this.替换ToolStripMenuItem_Click);
            // 
            // 配置工程ToolStripMenuItem
            // 
            this.配置工程ToolStripMenuItem.Name = "配置工程ToolStripMenuItem";
            this.配置工程ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.配置工程ToolStripMenuItem.Text = "配置工程";
            this.配置工程ToolStripMenuItem.Click += new System.EventHandler(this.配置工程ToolStripMenuItem_Click);
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.故障率ToolStripMenuItem,
            this.传感器个数ToolStripMenuItem});
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.统计ToolStripMenuItem.Text = "统计";
            // 
            // 故障率ToolStripMenuItem
            // 
            this.故障率ToolStripMenuItem.Name = "故障率ToolStripMenuItem";
            this.故障率ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.故障率ToolStripMenuItem.Text = "故障率";
            this.故障率ToolStripMenuItem.Click += new System.EventHandler(this.故障率ToolStripMenuItem_Click);
            // 
            // 传感器个数ToolStripMenuItem
            // 
            this.传感器个数ToolStripMenuItem.Name = "传感器个数ToolStripMenuItem";
            this.传感器个数ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.传感器个数ToolStripMenuItem.Text = "传感器个数";
            this.传感器个数ToolStripMenuItem.Click += new System.EventHandler(this.传感器个数ToolStripMenuItem_Click);
            // 
            // 阅读器情况ToolStripMenuItem
            // 
            this.阅读器情况ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置了12个频点的全部阅读器ToolStripMenuItem});
            this.阅读器情况ToolStripMenuItem.Name = "阅读器情况ToolStripMenuItem";
            this.阅读器情况ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.阅读器情况ToolStripMenuItem.Text = "阅读器情况";
            // 
            // 配置了12个频点的全部阅读器ToolStripMenuItem
            // 
            this.配置了12个频点的全部阅读器ToolStripMenuItem.Name = "配置了12个频点的全部阅读器ToolStripMenuItem";
            this.配置了12个频点的全部阅读器ToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.配置了12个频点的全部阅读器ToolStripMenuItem.Text = "配置了12个频点的全部阅读器";
            this.配置了12个频点的全部阅读器ToolStripMenuItem.Click += new System.EventHandler(this.配置了12个频点的全部阅读器ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(329, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据库名";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(546, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 25);
            this.textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "传感器管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 传感器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 阅读器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置工程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 故障率ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 传感器个数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 阅读器情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置了12个频点的全部阅读器ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
    }
}

