namespace DrawTree
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
            this.draw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.offleft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.offright = new System.Windows.Forms.TextBox();
            this.colorbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.angle1 = new System.Windows.Forms.TrackBar();
            this.angle2 = new System.Windows.Forms.TrackBar();
            this.per2 = new System.Windows.Forms.TrackBar();
            this.per1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.perright = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.perleft = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lenpara = new System.Windows.Forms.TextBox();
            this.widthbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.angle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthbar)).BeginInit();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw.Location = new System.Drawing.Point(668, 514);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(109, 50);
            this.draw.TabIndex = 0;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "offsetAngle(left)";
            // 
            // offleft
            // 
            this.offleft.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.offleft.Location = new System.Drawing.Point(761, 22);
            this.offleft.Name = "offleft";
            this.offleft.Size = new System.Drawing.Size(100, 28);
            this.offleft.TabIndex = 3;
            this.offleft.Text = "30";
            this.offleft.Leave += new System.EventHandler(this.offleft_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "offsetAngle(right)";
            // 
            // offright
            // 
            this.offright.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.offright.Location = new System.Drawing.Point(761, 92);
            this.offright.Name = "offright";
            this.offright.Size = new System.Drawing.Size(100, 28);
            this.offright.TabIndex = 5;
            this.offright.Text = "40";
            this.offright.Leave += new System.EventHandler(this.offright_Leave);
            // 
            // colorbox
            // 
            this.colorbox.BackColor = System.Drawing.SystemColors.Window;
            this.colorbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorbox.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorbox.FormattingEnabled = true;
            this.colorbox.Items.AddRange(new object[] {
            "Pink",
            "Red",
            "Black",
            "Green",
            "Yellow",
            "Blue",
            "White"});
            this.colorbox.Location = new System.Drawing.Point(761, 412);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(100, 34);
            this.colorbox.TabIndex = 7;
            this.colorbox.Text = "Pink";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(663, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "color";
            // 
            // angle1
            // 
            this.angle1.AutoSize = false;
            this.angle1.Location = new System.Drawing.Point(761, 61);
            this.angle1.Maximum = 90;
            this.angle1.Name = "angle1";
            this.angle1.Size = new System.Drawing.Size(110, 25);
            this.angle1.TabIndex = 14;
            this.angle1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.angle1.Value = 30;
            this.angle1.Scroll += new System.EventHandler(this.angle1_Scroll);
            // 
            // angle2
            // 
            this.angle2.AutoSize = false;
            this.angle2.Location = new System.Drawing.Point(761, 123);
            this.angle2.Maximum = 90;
            this.angle2.Name = "angle2";
            this.angle2.Size = new System.Drawing.Size(110, 25);
            this.angle2.TabIndex = 15;
            this.angle2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.angle2.Value = 40;
            this.angle2.Scroll += new System.EventHandler(this.angle2_Scroll);
            // 
            // per2
            // 
            this.per2.AutoSize = false;
            this.per2.Location = new System.Drawing.Point(761, 262);
            this.per2.Maximum = 100;
            this.per2.Name = "per2";
            this.per2.Size = new System.Drawing.Size(110, 25);
            this.per2.TabIndex = 21;
            this.per2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.per2.Value = 80;
            this.per2.Scroll += new System.EventHandler(this.per2_Scroll);
            // 
            // per1
            // 
            this.per1.AutoSize = false;
            this.per1.Location = new System.Drawing.Point(761, 200);
            this.per1.Maximum = 100;
            this.per1.Name = "per1";
            this.per1.Size = new System.Drawing.Size(110, 25);
            this.per1.TabIndex = 20;
            this.per1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.per1.Value = 75;
            this.per1.Scroll += new System.EventHandler(this.per1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "lengthPercent(right)";
            // 
            // perright
            // 
            this.perright.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.perright.Location = new System.Drawing.Point(761, 231);
            this.perright.MaxLength = 1;
            this.perright.Name = "perright";
            this.perright.Size = new System.Drawing.Size(100, 28);
            this.perright.TabIndex = 18;
            this.perright.Text = "0.8";
            this.perright.Leave += new System.EventHandler(this.perright_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "lengthPercent(left)";
            // 
            // perleft
            // 
            this.perleft.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.perleft.Location = new System.Drawing.Point(761, 161);
            this.perleft.Name = "perleft";
            this.perleft.Size = new System.Drawing.Size(100, 28);
            this.perleft.TabIndex = 16;
            this.perleft.Text = "0.75";
            this.perleft.Leave += new System.EventHandler(this.perleft_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(588, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "lengthParameter";
            // 
            // lenpara
            // 
            this.lenpara.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lenpara.Location = new System.Drawing.Point(761, 293);
            this.lenpara.MaxLength = 10;
            this.lenpara.Name = "lenpara";
            this.lenpara.Size = new System.Drawing.Size(100, 28);
            this.lenpara.TabIndex = 24;
            this.lenpara.Text = "1.10";
            // 
            // widthbar
            // 
            this.widthbar.AutoSize = false;
            this.widthbar.Location = new System.Drawing.Point(761, 381);
            this.widthbar.Maximum = 500;
            this.widthbar.Name = "widthbar";
            this.widthbar.Size = new System.Drawing.Size(110, 25);
            this.widthbar.TabIndex = 27;
            this.widthbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.widthbar.Value = 5;
            this.widthbar.Scroll += new System.EventHandler(this.widthbar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "lineWidth";
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.width.Location = new System.Drawing.Point(761, 350);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 28);
            this.width.TabIndex = 25;
            this.width.Text = "5.0";
            this.width.Leave += new System.EventHandler(this.width_Leave);
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioYes.Location = new System.Drawing.Point(747, 459);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(56, 32);
            this.radioYes.TabIndex = 28;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "yes";
            this.radioYes.UseVisualStyleBackColor = true;
            this.radioYes.CheckedChanged += new System.EventHandler(this.radioYes_CheckedChanged);
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Checked = true;
            this.radioNo.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNo.Location = new System.Drawing.Point(809, 459);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(52, 32);
            this.radioNo.TabIndex = 29;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "no";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(585, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "whether random";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 576);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.radioYes);
            this.Controls.Add(this.widthbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.width);
            this.Controls.Add(this.lenpara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.per2);
            this.Controls.Add(this.per1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.perright);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.perleft);
            this.Controls.Add(this.angle2);
            this.Controls.Add(this.angle1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.offright);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.offleft);
            this.Controls.Add(this.draw);
            this.Name = "Form1";
            this.Text = "DrawTree";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.angle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox offleft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox offright;
        private System.Windows.Forms.ComboBox colorbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar angle1;
        private System.Windows.Forms.TrackBar angle2;
        private System.Windows.Forms.TrackBar per2;
        private System.Windows.Forms.TrackBar per1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox perright;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox perleft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lenpara;
        private System.Windows.Forms.TrackBar widthbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.Label label5;
    }
}

