namespace OPEN_FNB.View.Main
{
    partial class Chart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_total = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_all = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_type = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_time = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart_discount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_night = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_xh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_night)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_xh)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_total
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_total.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_total.Legends.Add(legend1);
            this.chart_total.Location = new System.Drawing.Point(25, 117);
            this.chart_total.Name = "chart_total";
            this.chart_total.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_total.Series.Add(series1);
            this.chart_total.Size = new System.Drawing.Size(343, 256);
            this.chart_total.TabIndex = 0;
            this.chart_total.Text = "chart1";
            this.chart_total.Click += new System.EventHandler(this.chart_total_Click);
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_all.Location = new System.Drawing.Point(996, 19);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 28);
            this.btn_all.TabIndex = 34;
            this.btn_all.Text = "Tất cả";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(679, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Đến";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Từ";
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_find.Location = new System.Drawing.Point(915, 19);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 28);
            this.btn_find.TabIndex = 31;
            this.btn_find.Text = "Tìm";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(469, 24);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_start.TabIndex = 30;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(712, 24);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 20);
            this.dtp_end.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 37);
            this.label1.TabIndex = 35;
            this.label1.Text = "Biểu đồ thống kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chart_type
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_type.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_type.Legends.Add(legend2);
            this.chart_type.Location = new System.Drawing.Point(376, 117);
            this.chart_type.Name = "chart_type";
            this.chart_type.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_type.Series.Add(series2);
            this.chart_type.Size = new System.Drawing.Size(343, 256);
            this.chart_type.TabIndex = 36;
            this.chart_type.Text = "chart1";
            // 
            // chart_time
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_time.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_time.Legends.Add(legend3);
            this.chart_time.Location = new System.Drawing.Point(728, 117);
            this.chart_time.Name = "chart_time";
            this.chart_time.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_time.Series.Add(series3);
            this.chart_time.Size = new System.Drawing.Size(343, 256);
            this.chart_time.TabIndex = 37;
            this.chart_time.Text = "chart1";
            this.chart_time.Click += new System.EventHandler(this.chart_time_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tổng doanh thu (VND)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Xu hướng mua hàng (lượt)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(841, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "So sánh thời gian";
            // 
            // chart_discount
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_discount.ChartAreas.Add(chartArea4);
            this.chart_discount.Location = new System.Drawing.Point(25, 423);
            this.chart_discount.Name = "chart_discount";
            this.chart_discount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Name = "Series1";
            this.chart_discount.Series.Add(series4);
            this.chart_discount.Size = new System.Drawing.Size(343, 256);
            this.chart_discount.TabIndex = 41;
            this.chart_discount.Text = "chart1";
            // 
            // chart_night
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_night.ChartAreas.Add(chartArea5);
            this.chart_night.Location = new System.Drawing.Point(376, 423);
            this.chart_night.Name = "chart_night";
            this.chart_night.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.Name = "Series1";
            this.chart_night.Series.Add(series5);
            this.chart_night.Size = new System.Drawing.Size(343, 256);
            this.chart_night.TabIndex = 42;
            this.chart_night.Text = "chart1";
            // 
            // chart_xh
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_xh.ChartAreas.Add(chartArea6);
            this.chart_xh.Location = new System.Drawing.Point(728, 423);
            this.chart_xh.Name = "chart_xh";
            this.chart_xh.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series1";
            series6.YValuesPerPoint = 2;
            this.chart_xh.Series.Add(series6);
            this.chart_xh.Size = new System.Drawing.Size(343, 256);
            this.chart_xh.TabIndex = 43;
            this.chart_xh.Text = "chart2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 694);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Số lượng khuyến mãi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 694);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Lượt khách sáng tối";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(812, 694);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Khách 30 ngày gần nhất";
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart_xh);
            this.Controls.Add(this.chart_night);
            this.Controls.Add(this.chart_discount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart_time);
            this.Controls.Add(this.chart_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.chart_total);
            this.Name = "Chart";
            this.Size = new System.Drawing.Size(1100, 750);
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_night)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_xh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_total;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_type;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_discount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_night;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_xh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
