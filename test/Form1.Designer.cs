namespace test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.year1 = new System.Windows.Forms.Label();
            this.year2 = new System.Windows.Forms.Label();
            this.year3 = new System.Windows.Forms.Label();
            this.year4 = new System.Windows.Forms.Label();
            this.year5 = new System.Windows.Forms.Label();
            this.tyear1 = new System.Windows.Forms.TextBox();
            this.tyear2 = new System.Windows.Forms.TextBox();
            this.tyear3 = new System.Windows.Forms.TextBox();
            this.tyear4 = new System.Windows.Forms.TextBox();
            this.tyear5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.t_result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.touru = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "五年净现值计算";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "现贴率";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // year1
            // 
            this.year1.AutoSize = true;
            this.year1.Location = new System.Drawing.Point(96, 123);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(82, 15);
            this.year1.TabIndex = 3;
            this.year1.Text = "第一年收益";
            // 
            // year2
            // 
            this.year2.AutoSize = true;
            this.year2.Location = new System.Drawing.Point(96, 174);
            this.year2.Name = "year2";
            this.year2.Size = new System.Drawing.Size(82, 15);
            this.year2.TabIndex = 4;
            this.year2.Text = "第二年收益";
            // 
            // year3
            // 
            this.year3.AutoSize = true;
            this.year3.Location = new System.Drawing.Point(96, 221);
            this.year3.Name = "year3";
            this.year3.Size = new System.Drawing.Size(82, 15);
            this.year3.TabIndex = 5;
            this.year3.Text = "第三年收益";
            // 
            // year4
            // 
            this.year4.AutoSize = true;
            this.year4.Location = new System.Drawing.Point(96, 278);
            this.year4.Name = "year4";
            this.year4.Size = new System.Drawing.Size(82, 15);
            this.year4.TabIndex = 6;
            this.year4.Text = "第四年收益";
            // 
            // year5
            // 
            this.year5.AutoSize = true;
            this.year5.Location = new System.Drawing.Point(96, 341);
            this.year5.Name = "year5";
            this.year5.Size = new System.Drawing.Size(82, 15);
            this.year5.TabIndex = 7;
            this.year5.Text = "第五年收益";
            // 
            // tyear1
            // 
            this.tyear1.Location = new System.Drawing.Point(261, 113);
            this.tyear1.Name = "tyear1";
            this.tyear1.Size = new System.Drawing.Size(100, 25);
            this.tyear1.TabIndex = 3;
            this.tyear1.TextChanged += new System.EventHandler(this.tyear1_TextChanged);
            // 
            // tyear2
            // 
            this.tyear2.Location = new System.Drawing.Point(261, 164);
            this.tyear2.Name = "tyear2";
            this.tyear2.Size = new System.Drawing.Size(100, 25);
            this.tyear2.TabIndex = 4;
            // 
            // tyear3
            // 
            this.tyear3.Location = new System.Drawing.Point(261, 221);
            this.tyear3.Name = "tyear3";
            this.tyear3.Size = new System.Drawing.Size(100, 25);
            this.tyear3.TabIndex = 5;
            // 
            // tyear4
            // 
            this.tyear4.Location = new System.Drawing.Point(261, 278);
            this.tyear4.Name = "tyear4";
            this.tyear4.Size = new System.Drawing.Size(100, 25);
            this.tyear4.TabIndex = 6;
            // 
            // tyear5
            // 
            this.tyear5.Location = new System.Drawing.Point(261, 331);
            this.tyear5.Name = "tyear5";
            this.tyear5.Size = new System.Drawing.Size(100, 25);
            this.tyear5.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(445, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_result
            // 
            this.t_result.Location = new System.Drawing.Point(549, 235);
            this.t_result.Multiline = true;
            this.t_result.Name = "t_result";
            this.t_result.Size = new System.Drawing.Size(174, 36);
            this.t_result.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "投入";
            // 
            // touru
            // 
            this.touru.Location = new System.Drawing.Point(424, 62);
            this.touru.Name = "touru";
            this.touru.Size = new System.Drawing.Size(100, 25);
            this.touru.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 476);
            this.Controls.Add(this.touru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tyear5);
            this.Controls.Add(this.tyear4);
            this.Controls.Add(this.tyear3);
            this.Controls.Add(this.tyear2);
            this.Controls.Add(this.tyear1);
            this.Controls.Add(this.year5);
            this.Controls.Add(this.year4);
            this.Controls.Add(this.year3);
            this.Controls.Add(this.year2);
            this.Controls.Add(this.year1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "净现值计算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label year1;
        private System.Windows.Forms.Label year2;
        private System.Windows.Forms.Label year3;
        private System.Windows.Forms.Label year4;
        private System.Windows.Forms.Label year5;
        private System.Windows.Forms.TextBox tyear1;
        private System.Windows.Forms.TextBox tyear2;
        private System.Windows.Forms.TextBox tyear3;
        private System.Windows.Forms.TextBox tyear4;
        private System.Windows.Forms.TextBox tyear5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox touru;
    }
}

