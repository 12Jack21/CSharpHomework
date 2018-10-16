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
            ((System.ComponentModel.ISupportInitialize)(this.angle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(578, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "offsetAngle(left)";
            // 
            // offleft
            // 
            this.offleft.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.offleft.Location = new System.Drawing.Point(761, 69);
            this.offleft.Name = "offleft";
            this.offleft.Size = new System.Drawing.Size(100, 28);
            this.offleft.TabIndex = 3;
            this.offleft.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "offsetAngle(right)";
            // 
            // offright
            // 
            this.offright.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.offright.Location = new System.Drawing.Point(761, 139);
            this.offright.Name = "offright";
            this.offright.Size = new System.Drawing.Size(100, 28);
            this.offright.TabIndex = 5;
            this.offright.Text = "40";
            // 
            // colorbox
            // 
            this.colorbox.BackColor = System.Drawing.SystemColors.Window;
            this.colorbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorbox.FormattingEnabled = true;
            this.colorbox.Items.AddRange(new object[] {
            "Pink",
            "Red",
            "Black",
            "Green",
            "Yellow",
            "Blue",
            "White"});
            this.colorbox.Location = new System.Drawing.Point(761, 391);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(100, 23);
            this.colorbox.TabIndex = 7;
            this.colorbox.Text = "Pink";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(663, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "color";
            // 
            // angle1
            // 
            this.angle1.AutoSize = false;
            this.angle1.Location = new System.Drawing.Point(761, 108);
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
            this.angle2.Location = new System.Drawing.Point(761, 170);
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
            this.per2.Location = new System.Drawing.Point(761, 309);
            this.per2.Maximum = 100;
            this.per2.Name = "per2";
            this.per2.Size = new System.Drawing.Size(110, 25);
            this.per2.TabIndex = 21;
            this.per2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.per2.Value = 70;
            this.per2.Scroll += new System.EventHandler(this.per2_Scroll);
            // 
            // per1
            // 
            this.per1.AutoSize = false;
            this.per1.Location = new System.Drawing.Point(761, 247);
            this.per1.Maximum = 100;
            this.per1.Name = "per1";
            this.per1.Size = new System.Drawing.Size(110, 25);
            this.per1.TabIndex = 20;
            this.per1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.per1.Value = 60;
            this.per1.Scroll += new System.EventHandler(this.per1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "lengthPercent(right)";
            // 
            // perright
            // 
            this.perright.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.perright.Location = new System.Drawing.Point(761, 278);
            this.perright.Name = "perright";
            this.perright.Size = new System.Drawing.Size(100, 28);
            this.perright.TabIndex = 18;
            this.perright.Text = "0.7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(580, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "lengthPercent(left)";
            // 
            // perleft
            // 
            this.perleft.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.perleft.Location = new System.Drawing.Point(761, 208);
            this.perleft.Name = "perleft";
            this.perleft.Size = new System.Drawing.Size(100, 28);
            this.perleft.TabIndex = 16;
            this.perleft.Text = "0.6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(588, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "lengthParameter";
            // 
            // lenpara
            // 
            this.lenpara.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lenpara.Location = new System.Drawing.Point(761, 340);
            this.lenpara.Name = "lenpara";
            this.lenpara.Size = new System.Drawing.Size(100, 28);
            this.lenpara.TabIndex = 24;
            this.lenpara.Text = "1.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 576);
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
    }
}

