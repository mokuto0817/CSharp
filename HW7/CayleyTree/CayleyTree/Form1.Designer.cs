namespace CayleyTree
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
            this.components = new System.ComponentModel.Container();
            this.Draw = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DisplayCayleyTree = new System.Windows.Forms.Panel();
            this.penLabel = new System.Windows.Forms.Label();
            this.thLabel = new System.Windows.Forms.Label();
            this.leng_textBox = new System.Windows.Forms.TextBox();
            this.per2Label = new System.Windows.Forms.Label();
            this.per1Label = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.n_textBox = new System.Windows.Forms.TextBox();
            this.lengLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.per2_trackBar = new System.Windows.Forms.TrackBar();
            this.per1_trackBar = new System.Windows.Forms.TrackBar();
            this.th2_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.th1_trackBar = new System.Windows.Forms.TrackBar();
            this.th2_value = new System.Windows.Forms.Label();
            this.per1_value = new System.Windows.Forms.Label();
            this.per2_value = new System.Windows.Forms.Label();
            this.th1_value = new System.Windows.Forms.Label();
            this.penColor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.per2_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Draw.Font = new System.Drawing.Font("宋体", 12F);
            this.Draw.Location = new System.Drawing.Point(3, 3);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(279, 40);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // DisplayCayleyTree
            // 
            this.DisplayCayleyTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayCayleyTree.Location = new System.Drawing.Point(3, 70);
            this.DisplayCayleyTree.Name = "DisplayCayleyTree";
            this.DisplayCayleyTree.Size = new System.Drawing.Size(570, 521);
            this.DisplayCayleyTree.TabIndex = 1;
            // 
            // penLabel
            // 
            this.penLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.penLabel.AutoSize = true;
            this.penLabel.Font = new System.Drawing.Font("宋体", 9F);
            this.penLabel.Location = new System.Drawing.Point(14, 371);
            this.penLabel.Name = "penLabel";
            this.penLabel.Size = new System.Drawing.Size(80, 18);
            this.penLabel.TabIndex = 7;
            this.penLabel.Text = "PenColor";
            // 
            // thLabel
            // 
            this.thLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thLabel.AutoSize = true;
            this.thLabel.Font = new System.Drawing.Font("宋体", 9F);
            this.thLabel.Location = new System.Drawing.Point(19, 91);
            this.thLabel.Name = "thLabel";
            this.thLabel.Size = new System.Drawing.Size(71, 18);
            this.thLabel.TabIndex = 5;
            this.thLabel.Text = "th_left";
            // 
            // leng_textBox
            // 
            this.leng_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leng_textBox.Location = new System.Drawing.Point(141, 46);
            this.leng_textBox.Name = "leng_textBox";
            this.leng_textBox.Size = new System.Drawing.Size(100, 28);
            this.leng_textBox.TabIndex = 1;
            // 
            // per2Label
            // 
            this.per2Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.per2Label.AutoSize = true;
            this.per2Label.Font = new System.Drawing.Font("宋体", 9F);
            this.per2Label.Location = new System.Drawing.Point(10, 301);
            this.per2Label.Name = "per2Label";
            this.per2Label.Size = new System.Drawing.Size(89, 18);
            this.per2Label.TabIndex = 4;
            this.per2Label.Text = "per_right";
            // 
            // per1Label
            // 
            this.per1Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.per1Label.AutoSize = true;
            this.per1Label.Font = new System.Drawing.Font("宋体", 9F);
            this.per1Label.Location = new System.Drawing.Point(14, 231);
            this.per1Label.Name = "per1Label";
            this.per1Label.Size = new System.Drawing.Size(80, 18);
            this.per1Label.TabIndex = 3;
            this.per1Label.Text = "per_left";
            // 
            // nLabel
            // 
            this.nLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nLabel.AutoSize = true;
            this.nLabel.Font = new System.Drawing.Font("宋体", 9F);
            this.nLabel.Location = new System.Drawing.Point(46, 11);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(17, 18);
            this.nLabel.TabIndex = 1;
            this.nLabel.Text = "n";
            // 
            // n_textBox
            // 
            this.n_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.n_textBox.Location = new System.Drawing.Point(141, 6);
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.Size = new System.Drawing.Size(100, 28);
            this.n_textBox.TabIndex = 0;
            // 
            // lengLabel
            // 
            this.lengLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lengLabel.AutoSize = true;
            this.lengLabel.Font = new System.Drawing.Font("宋体", 9F);
            this.lengLabel.Location = new System.Drawing.Point(32, 51);
            this.lengLabel.Name = "lengLabel";
            this.lengLabel.Size = new System.Drawing.Size(44, 18);
            this.lengLabel.TabIndex = 2;
            this.lengLabel.Text = "leng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.91132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.08868F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 600);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisplayCayleyTree);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 594);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Draw, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.clear_btn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(570, 46);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // clear_btn
            // 
            this.clear_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear_btn.Location = new System.Drawing.Point(288, 3);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(279, 40);
            this.clear_btn.TabIndex = 1;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(585, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 594);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameter";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.15152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.84848F));
            this.tableLayoutPanel2.Controls.Add(this.per2_trackBar, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.per1_trackBar, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.th2_trackBar, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.penLabel, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.per2Label, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.per1Label, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.leng_textBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.n_textBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lengLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.th1_trackBar, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.th2_value, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.per1_value, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.per2_value, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.th1_value, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.thLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.penColor, 1, 10);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(273, 399);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // per2_trackBar
            // 
            this.per2_trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.per2_trackBar.Location = new System.Drawing.Point(112, 293);
            this.per2_trackBar.Name = "per2_trackBar";
            this.per2_trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.per2_trackBar.Size = new System.Drawing.Size(158, 34);
            this.per2_trackBar.TabIndex = 12;
            this.per2_trackBar.Scroll += new System.EventHandler(this.per2_trackBar_Scroll);
            // 
            // per1_trackBar
            // 
            this.per1_trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.per1_trackBar.Location = new System.Drawing.Point(112, 223);
            this.per1_trackBar.Name = "per1_trackBar";
            this.per1_trackBar.Size = new System.Drawing.Size(158, 34);
            this.per1_trackBar.TabIndex = 11;
            this.per1_trackBar.Scroll += new System.EventHandler(this.per1_trackBar_Scroll);
            // 
            // th2_trackBar
            // 
            this.th2_trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.th2_trackBar.Location = new System.Drawing.Point(112, 153);
            this.th2_trackBar.Maximum = 18;
            this.th2_trackBar.Name = "th2_trackBar";
            this.th2_trackBar.Size = new System.Drawing.Size(158, 34);
            this.th2_trackBar.TabIndex = 10;
            this.th2_trackBar.Scroll += new System.EventHandler(this.th2_trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "th_right";
            // 
            // th1_trackBar
            // 
            this.th1_trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.th1_trackBar.Location = new System.Drawing.Point(112, 83);
            this.th1_trackBar.Maximum = 18;
            this.th1_trackBar.Name = "th1_trackBar";
            this.th1_trackBar.Size = new System.Drawing.Size(158, 34);
            this.th1_trackBar.TabIndex = 9;
            this.th1_trackBar.Scroll += new System.EventHandler(this.th1_trackBar_Scroll);
            // 
            // th2_value
            // 
            this.th2_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.th2_value.AutoSize = true;
            this.th2_value.Location = new System.Drawing.Point(46, 196);
            this.th2_value.Name = "th2_value";
            this.th2_value.Size = new System.Drawing.Size(17, 18);
            this.th2_value.TabIndex = 14;
            this.th2_value.Text = "0";
            // 
            // per1_value
            // 
            this.per1_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.per1_value.AutoSize = true;
            this.per1_value.Location = new System.Drawing.Point(46, 266);
            this.per1_value.Name = "per1_value";
            this.per1_value.Size = new System.Drawing.Size(17, 18);
            this.per1_value.TabIndex = 15;
            this.per1_value.Text = "0";
            // 
            // per2_value
            // 
            this.per2_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.per2_value.AutoSize = true;
            this.per2_value.Location = new System.Drawing.Point(46, 336);
            this.per2_value.Name = "per2_value";
            this.per2_value.Size = new System.Drawing.Size(17, 18);
            this.per2_value.TabIndex = 16;
            this.per2_value.Text = "0";
            // 
            // th1_value
            // 
            this.th1_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.th1_value.AutoSize = true;
            this.th1_value.Location = new System.Drawing.Point(46, 126);
            this.th1_value.Name = "th1_value";
            this.th1_value.Size = new System.Drawing.Size(17, 18);
            this.th1_value.TabIndex = 13;
            this.th1_value.Text = "0";
            // 
            // penColor
            // 
            this.penColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.penColor.FormattingEnabled = true;
            this.penColor.Items.AddRange(new object[] {
            "Bule",
            "Black",
            "Red",
            "Yellow",
            "Gray",
            "Purple"});
            this.penColor.Location = new System.Drawing.Point(130, 367);
            this.penColor.Name = "penColor";
            this.penColor.Size = new System.Drawing.Size(121, 26);
            this.penColor.TabIndex = 17;
            this.penColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "DrawCayleyTree";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.per2_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel DisplayCayleyTree;
        private System.Windows.Forms.Label thLabel;
        private System.Windows.Forms.Label per2Label;
        private System.Windows.Forms.Label per1Label;
        private System.Windows.Forms.Label lengLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label penLabel;
        private System.Windows.Forms.TextBox leng_textBox;
        private System.Windows.Forms.TextBox n_textBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TrackBar per2_trackBar;
        private System.Windows.Forms.TrackBar per1_trackBar;
        private System.Windows.Forms.TrackBar th2_trackBar;
        private System.Windows.Forms.TrackBar th1_trackBar;
        private System.Windows.Forms.Label th2_value;
        private System.Windows.Forms.Label per2_value;
        private System.Windows.Forms.Label th1_value;
        private System.Windows.Forms.Label per1_value;
        private System.Windows.Forms.ComboBox penColor;
    }
}

