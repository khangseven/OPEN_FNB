namespace OPEN_FNB.View.Block
{
    partial class AddDiscountBlock
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
            this._value = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this._info = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._start = new System.Windows.Forms.DateTimePicker();
            this._end = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._value)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _value
            // 
            this._value.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._value.Location = new System.Drawing.Point(100, 233);
            this._value.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._value.Name = "_value";
            this._value.Size = new System.Drawing.Size(58, 20);
            this._value.TabIndex = 31;
            this._value.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "% Giảm";
            // 
            // _info
            // 
            this._info.Location = new System.Drawing.Point(100, 112);
            this._info.Multiline = true;
            this._info.Name = "_info";
            this._info.Size = new System.Drawing.Size(200, 63);
            this._info.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Điều kiện";
            // 
            // _name
            // 
            this._name.Location = new System.Drawing.Point(100, 86);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(200, 20);
            this._name.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên";
            // 
            // _start
            // 
            this._start.Location = new System.Drawing.Point(100, 181);
            this._start.Name = "_start";
            this._start.Size = new System.Drawing.Size(200, 20);
            this._start.TabIndex = 24;
            this._start.ValueChanged += new System.EventHandler(this.start_ValueChanged);
            // 
            // _end
            // 
            this._end.Location = new System.Drawing.Point(100, 207);
            this._end.Name = "_end";
            this._end.Size = new System.Drawing.Size(200, 20);
            this._end.TabIndex = 25;
            this._end.ValueChanged += new System.EventHandler(this.end_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 66);
            this.panel1.TabIndex = 32;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(7, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(357, 52);
            this.title.TabIndex = 33;
            this.title.Text = "Thêm khuyến mãi hóa đơn";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(142, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Xong";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(223, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddDiscountBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 308);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._value);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._info);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._start);
            this.Controls.Add(this._end);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDiscountBlock";
            this.Text = "AddDiscountBlock";
            ((System.ComponentModel.ISupportInitialize)(this._value)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker _start;
        private System.Windows.Forms.DateTimePicker _end;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}