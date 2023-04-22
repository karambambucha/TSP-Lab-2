namespace TSP_Lab_2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.MathExpectanceNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.StandardDevianceNumeric = new System.Windows.Forms.NumericUpDown();
            this.TimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MathExpectanceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StandardDevianceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Среднее время работы изделия на отказ";
            // 
            // MathExpectanceNumeric
            // 
            this.MathExpectanceNumeric.DecimalPlaces = 3;
            this.MathExpectanceNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MathExpectanceNumeric.Location = new System.Drawing.Point(15, 30);
            this.MathExpectanceNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MathExpectanceNumeric.Name = "MathExpectanceNumeric";
            this.MathExpectanceNumeric.Size = new System.Drawing.Size(120, 20);
            this.MathExpectanceNumeric.TabIndex = 1;
            this.MathExpectanceNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Среднеквадратическое отклонение";
            // 
            // StandardDevianceNumeric
            // 
            this.StandardDevianceNumeric.DecimalPlaces = 3;
            this.StandardDevianceNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.StandardDevianceNumeric.Location = new System.Drawing.Point(15, 69);
            this.StandardDevianceNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StandardDevianceNumeric.Name = "StandardDevianceNumeric";
            this.StandardDevianceNumeric.Size = new System.Drawing.Size(120, 20);
            this.StandardDevianceNumeric.TabIndex = 1;
            this.StandardDevianceNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // TimeNumeric
            // 
            this.TimeNumeric.Location = new System.Drawing.Point(15, 108);
            this.TimeNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeNumeric.Name = "TimeNumeric";
            this.TimeNumeric.Size = new System.Drawing.Size(120, 20);
            this.TimeNumeric.TabIndex = 2;
            this.TimeNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Время наблюдения в годах\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Начать моделирование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 227);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1365, 201);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Всего ламп: \r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeNumeric);
            this.Controls.Add(this.StandardDevianceNumeric);
            this.Controls.Add(this.MathExpectanceNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Потоки Эрланга";
            ((System.ComponentModel.ISupportInitialize)(this.MathExpectanceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StandardDevianceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MathExpectanceNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown StandardDevianceNumeric;
        private System.Windows.Forms.NumericUpDown TimeNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
    }
}

