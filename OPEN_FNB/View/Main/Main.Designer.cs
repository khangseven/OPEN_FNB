namespace OPEN_FNB.View.Main
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_chart = new System.Windows.Forms.Button();
            this.btn_manager = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.lb_uname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_day = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(275, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 750);
            this.panel1.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(12, 368);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(249, 75);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Bán Hàng";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_chart
            // 
            this.btn_chart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chart.ForeColor = System.Drawing.Color.White;
            this.btn_chart.Location = new System.Drawing.Point(12, 611);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Size = new System.Drawing.Size(249, 75);
            this.btn_chart.TabIndex = 2;
            this.btn_chart.Text = "Biểu đồ";
            this.btn_chart.UseVisualStyleBackColor = false;
            this.btn_chart.Click += new System.EventHandler(this.btn_chart_Click);
            // 
            // btn_manager
            // 
            this.btn_manager.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manager.ForeColor = System.Drawing.Color.White;
            this.btn_manager.Location = new System.Drawing.Point(11, 449);
            this.btn_manager.Name = "btn_manager";
            this.btn_manager.Size = new System.Drawing.Size(249, 75);
            this.btn_manager.TabIndex = 3;
            this.btn_manager.Text = "Quản lý";
            this.btn_manager.UseVisualStyleBackColor = false;
            this.btn_manager.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OPEN_FNB.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_thongke
            // 
            this.btn_thongke.BackColor = System.Drawing.Color.Gold;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.Color.White;
            this.btn_thongke.Location = new System.Drawing.Point(12, 530);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(249, 75);
            this.btn_thongke.TabIndex = 5;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = false;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // lb_uname
            // 
            this.lb_uname.AutoSize = true;
            this.lb_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_uname.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lb_uname.Location = new System.Drawing.Point(54, 314);
            this.lb_uname.Name = "lb_uname";
            this.lb_uname.Size = new System.Drawing.Size(160, 20);
            this.lb_uname.TabIndex = 6;
            this.lb_uname.Text = "Người dùng: Admin";
            this.lb_uname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 738);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_day
            // 
            this.lb_day.AutoSize = true;
            this.lb_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_day.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_day.Location = new System.Drawing.Point(44, 281);
            this.lb_day.Name = "lb_day";
            this.lb_day.Size = new System.Drawing.Size(179, 20);
            this.lb_day.TabIndex = 8;
            this.lb_day.Text = "Hôm nay, 11/11/2022";
            this.lb_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 695);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "QR CODE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_day);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_uname);
            this.Controls.Add(this.btn_thongke);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_manager);
            this.Controls.Add(this.btn_chart);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_chart;
        private System.Windows.Forms.Button btn_manager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Label lb_uname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_day;
        private System.Windows.Forms.Button button2;
    }
}