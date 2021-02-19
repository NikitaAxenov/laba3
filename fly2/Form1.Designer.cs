namespace fly2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.forHeight = new System.Windows.Forms.NumericUpDown();
            this.forAngle = new System.Windows.Forms.NumericUpDown();
            this.forSpeed = new System.Windows.Forms.NumericUpDown();
            this.forSize = new System.Windows.Forms.NumericUpDown();
            this.forWeight = new System.Windows.Forms.NumericUpDown();
            this.btn = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.forDistance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.forHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(96, 511);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(81, 29);
            this.time.TabIndex = 5;
            this.time.Text = "00:00";
            // 
            // forHeight
            // 
            this.forHeight.Location = new System.Drawing.Point(120, 92);
            this.forHeight.Name = "forHeight";
            this.forHeight.Size = new System.Drawing.Size(120, 22);
            this.forHeight.TabIndex = 6;
            // 
            // forAngle
            // 
            this.forAngle.Location = new System.Drawing.Point(120, 158);
            this.forAngle.Name = "forAngle";
            this.forAngle.Size = new System.Drawing.Size(120, 22);
            this.forAngle.TabIndex = 7;
            // 
            // forSpeed
            // 
            this.forSpeed.Location = new System.Drawing.Point(120, 218);
            this.forSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.forSpeed.Name = "forSpeed";
            this.forSpeed.Size = new System.Drawing.Size(120, 22);
            this.forSpeed.TabIndex = 8;
            this.forSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // forSize
            // 
            this.forSize.DecimalPlaces = 2;
            this.forSize.Location = new System.Drawing.Point(120, 283);
            this.forSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.forSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.forSize.Name = "forSize";
            this.forSize.Size = new System.Drawing.Size(120, 22);
            this.forSize.TabIndex = 9;
            this.forSize.ThousandsSeparator = true;
            this.forSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // forWeight
            // 
            this.forWeight.Location = new System.Drawing.Point(120, 348);
            this.forWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.forWeight.Name = "forWeight";
            this.forWeight.Size = new System.Drawing.Size(120, 22);
            this.forWeight.TabIndex = 10;
            this.forWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(35, 403);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 11;
            this.btn.Text = "Launch";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(165, 403);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(165, 464);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // chart
            // 
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(282, 91);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(854, 449);
            this.chart.TabIndex = 14;
            this.chart.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Distance";
            // 
            // forDistance
            // 
            this.forDistance.AutoSize = true;
            this.forDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forDistance.Location = new System.Drawing.Point(120, 33);
            this.forDistance.Name = "forDistance";
            this.forDistance.Size = new System.Drawing.Size(18, 20);
            this.forDistance.TabIndex = 16;
            this.forDistance.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 581);
            this.Controls.Add(this.forDistance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.forWeight);
            this.Controls.Add(this.forSize);
            this.Controls.Add(this.forSpeed);
            this.Controls.Add(this.forAngle);
            this.Controls.Add(this.forHeight);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.forHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.NumericUpDown forHeight;
        private System.Windows.Forms.NumericUpDown forAngle;
        private System.Windows.Forms.NumericUpDown forSpeed;
        private System.Windows.Forms.NumericUpDown forSize;
        private System.Windows.Forms.NumericUpDown forWeight;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label forDistance;
    }
}

