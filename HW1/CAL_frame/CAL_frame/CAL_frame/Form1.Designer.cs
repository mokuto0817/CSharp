namespace CAL_frame
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
            this.label_num1 = new System.Windows.Forms.Label();
            this.label_num2 = new System.Windows.Forms.Label();
            this.label_op = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.num1_TextBox = new System.Windows.Forms.TextBox();
            this.num2_TextBox = new System.Windows.Forms.TextBox();
            this.op_combox = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_num1
            // 
            this.label_num1.AutoSize = true;
            this.label_num1.Location = new System.Drawing.Point(78, 63);
            this.label_num1.Name = "label_num1";
            this.label_num1.Size = new System.Drawing.Size(71, 18);
            this.label_num1.TabIndex = 0;
            this.label_num1.Text = "Number1";
            // 
            // label_num2
            // 
            this.label_num2.AutoSize = true;
            this.label_num2.Location = new System.Drawing.Point(286, 63);
            this.label_num2.Name = "label_num2";
            this.label_num2.Size = new System.Drawing.Size(71, 18);
            this.label_num2.TabIndex = 1;
            this.label_num2.Text = "Number2";
            // 
            // label_op
            // 
            this.label_op.AutoSize = true;
            this.label_op.Location = new System.Drawing.Point(114, 120);
            this.label_op.Name = "label_op";
            this.label_op.Size = new System.Drawing.Size(71, 18);
            this.label_op.TabIndex = 2;
            this.label_op.Text = "Operate";
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Location = new System.Drawing.Point(197, 175);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(125, 18);
            this.ans.TabIndex = 3;
            this.ans.Text = "The answer is";
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(81, 166);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(104, 37);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // num1_TextBox
            // 
            this.num1_TextBox.Location = new System.Drawing.Point(155, 60);
            this.num1_TextBox.Name = "num1_TextBox";
            this.num1_TextBox.Size = new System.Drawing.Size(100, 28);
            this.num1_TextBox.TabIndex = 5;
            this.num1_TextBox.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // num2_TextBox
            // 
            this.num2_TextBox.Location = new System.Drawing.Point(363, 60);
            this.num2_TextBox.Name = "num2_TextBox";
            this.num2_TextBox.Size = new System.Drawing.Size(100, 28);
            this.num2_TextBox.TabIndex = 6;
            this.num2_TextBox.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // op_combox
            // 
            this.op_combox.FormattingEnabled = true;
            this.op_combox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.op_combox.Location = new System.Drawing.Point(226, 117);
            this.op_combox.Name = "op_combox";
            this.op_combox.Size = new System.Drawing.Size(121, 26);
            this.op_combox.TabIndex = 7;
            this.op_combox.SelectedIndexChanged += new System.EventHandler(this.op_combox_SelectedIndexChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(350, 175);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 18);
            this.result.TabIndex = 8;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 288);
            this.Controls.Add(this.result);
            this.Controls.Add(this.op_combox);
            this.Controls.Add(this.num2_TextBox);
            this.Controls.Add(this.num1_TextBox);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.label_op);
            this.Controls.Add(this.label_num2);
            this.Controls.Add(this.label_num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_num1;
        private System.Windows.Forms.Label label_num2;
        private System.Windows.Forms.Label label_op;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox num1_TextBox;
        private System.Windows.Forms.TextBox num2_TextBox;
        private System.Windows.Forms.ComboBox op_combox;
        private System.Windows.Forms.Label result;
    }
}

