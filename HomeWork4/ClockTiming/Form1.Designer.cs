namespace ClockTiming
{
    partial class Clock
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.setLabel = new System.Windows.Forms.Label();
            this.setHour = new System.Windows.Forms.NumericUpDown();
            this.setMinute = new System.Windows.Forms.NumericUpDown();
            this.leftTime = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.certain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // setLabel
            // 
            this.setLabel.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setLabel.Location = new System.Drawing.Point(83, 116);
            this.setLabel.Name = "setLabel";
            this.setLabel.Size = new System.Drawing.Size(205, 39);
            this.setLabel.TabIndex = 0;
            this.setLabel.Text = "Set your time";
            // 
            // setHour
            // 
            this.setHour.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setHour.Location = new System.Drawing.Point(324, 114);
            this.setHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.setHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setHour.Name = "setHour";
            this.setHour.Size = new System.Drawing.Size(120, 34);
            this.setHour.TabIndex = 1;
            this.setHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // setMinute
            // 
            this.setMinute.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setMinute.Location = new System.Drawing.Point(450, 114);
            this.setMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.setMinute.Name = "setMinute";
            this.setMinute.Size = new System.Drawing.Size(120, 34);
            this.setMinute.TabIndex = 2;
            // 
            // leftTime
            // 
            this.leftTime.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftTime.Location = new System.Drawing.Point(83, 254);
            this.leftTime.Name = "leftTime";
            this.leftTime.Size = new System.Drawing.Size(145, 57);
            this.leftTime.TabIndex = 3;
            this.leftTime.Text = "Time left";
            // 
            // hour
            // 
            this.hour.Font = new System.Drawing.Font("华文楷体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hour.Location = new System.Drawing.Point(266, 247);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(100, 75);
            this.hour.TabIndex = 4;
            // 
            // minute
            // 
            this.minute.Font = new System.Drawing.Font("华文楷体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minute.Location = new System.Drawing.Point(385, 247);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(100, 75);
            this.minute.TabIndex = 5;
            // 
            // second
            // 
            this.second.Font = new System.Drawing.Font("华文楷体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.second.Location = new System.Drawing.Point(504, 247);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(100, 75);
            this.second.TabIndex = 6;
            // 
            // certain
            // 
            this.certain.Location = new System.Drawing.Point(324, 360);
            this.certain.Name = "certain";
            this.certain.Size = new System.Drawing.Size(130, 39);
            this.certain.TabIndex = 7;
            this.certain.Text = "certain";
            this.certain.UseVisualStyleBackColor = true;
            this.certain.Click += new System.EventHandler(this.certain_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(468, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(349, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = ":";
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.certain);
            this.Controls.Add(this.second);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.leftTime);
            this.Controls.Add(this.setMinute);
            this.Controls.Add(this.setHour);
            this.Controls.Add(this.setLabel);
            this.Name = "Clock";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.setHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setMinute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label setLabel;
        private System.Windows.Forms.NumericUpDown setHour;
        private System.Windows.Forms.NumericUpDown setMinute;
        private System.Windows.Forms.Label leftTime;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label minute;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Button certain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

