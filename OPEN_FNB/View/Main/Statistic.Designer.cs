namespace OPEN_FNB.View.Main
{
    partial class Statistic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_billdiscounts = new System.Windows.Forms.Panel();
            this.pn = new System.Windows.Forms.Panel();
            this.pn_billdetails = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bill_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bill_pay = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bill_checkin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bill_staff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bill_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.btn_find = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_all = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_all = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.Column1,
            this.dataGridViewTextBoxColumn5,
            this.condition,
            this.checkoout,
            this.Column2});
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.Orange;
            this.dgv.Location = new System.Drawing.Point(10, 145);
            this.dgv.Margin = new System.Windows.Forms.Padding(5);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Cornsilk;
            this.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowTemplate.Height = 40;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(683, 510);
            this.dgv.TabIndex = 21;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lb_all);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cb_type);
            this.panel2.Controls.Add(this.btn_all);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btn_find);
            this.panel2.Controls.Add(this.dtp_start);
            this.panel2.Controls.Add(this.dtp_end);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Location = new System.Drawing.Point(24, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 694);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bill_pay);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pb_billdiscounts);
            this.panel1.Controls.Add(this.pn);
            this.panel1.Location = new System.Drawing.Point(735, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 689);
            this.panel1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(10, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Khuyến mãi hóa đơn";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_billdiscounts
            // 
            this.pb_billdiscounts.AutoScroll = true;
            this.pb_billdiscounts.BackColor = System.Drawing.Color.Honeydew;
            this.pb_billdiscounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_billdiscounts.Location = new System.Drawing.Point(10, 556);
            this.pb_billdiscounts.Margin = new System.Windows.Forms.Padding(0);
            this.pb_billdiscounts.Name = "pb_billdiscounts";
            this.pb_billdiscounts.Size = new System.Drawing.Size(320, 74);
            this.pb_billdiscounts.TabIndex = 35;
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn.Controls.Add(this.pn_billdetails);
            this.pn.Controls.Add(this.label3);
            this.pn.Controls.Add(this.bill_total);
            this.pn.Controls.Add(this.label1);
            this.pn.Controls.Add(this.label2);
            this.pn.Controls.Add(this.label8);
            this.pn.Location = new System.Drawing.Point(10, 184);
            this.pn.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(320, 331);
            this.pn.TabIndex = 33;
            // 
            // pn_billdetails
            // 
            this.pn_billdetails.AutoScroll = true;
            this.pn_billdetails.BackColor = System.Drawing.Color.FloralWhite;
            this.pn_billdetails.Location = new System.Drawing.Point(-1, 39);
            this.pn_billdetails.Name = "pn_billdetails";
            this.pn_billdetails.Size = new System.Drawing.Size(320, 261);
            this.pn_billdetails.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(248, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "SL";
            // 
            // bill_total
            // 
            this.bill_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_total.ForeColor = System.Drawing.Color.OrangeRed;
            this.bill_total.Location = new System.Drawing.Point(173, 306);
            this.bill_total.Margin = new System.Windows.Forms.Padding(5);
            this.bill_total.Name = "bill_total";
            this.bill_total.Size = new System.Drawing.Size(113, 18);
            this.bill_total.TabIndex = 29;
            this.bill_total.Text = "0";
            this.bill_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "STT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(50, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(124, 306);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tổng:";
            // 
            // bill_pay
            // 
            this.bill_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_pay.ForeColor = System.Drawing.Color.OrangeRed;
            this.bill_pay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bill_pay.Location = new System.Drawing.Point(120, 645);
            this.bill_pay.Margin = new System.Windows.Forms.Padding(5);
            this.bill_pay.Name = "bill_pay";
            this.bill_pay.Size = new System.Drawing.Size(210, 25);
            this.bill_pay.TabIndex = 37;
            this.bill_pay.Text = "0";
            this.bill_pay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(5, 645);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "Thực trả:";
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(248, 89);
            this.time.Margin = new System.Windows.Forms.Padding(10);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(82, 82);
            this.time.TabIndex = 38;
            this.time.Text = "12 Giờ 33 Phút";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bill_checkin);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.bill_staff);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.bill_id);
            this.panel3.Location = new System.Drawing.Point(10, 89);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 82);
            this.panel3.TabIndex = 39;
            // 
            // bill_checkin
            // 
            this.bill_checkin.AutoSize = true;
            this.bill_checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_checkin.Location = new System.Drawing.Point(104, 31);
            this.bill_checkin.Name = "bill_checkin";
            this.bill_checkin.Size = new System.Drawing.Size(72, 18);
            this.bill_checkin.TabIndex = 27;
            this.bill_checkin.Text = "Không có";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(29, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã đơn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(26, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Giờ vào:";
            // 
            // bill_staff
            // 
            this.bill_staff.AutoSize = true;
            this.bill_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_staff.Location = new System.Drawing.Point(104, 52);
            this.bill_staff.Name = "bill_staff";
            this.bill_staff.Size = new System.Drawing.Size(64, 18);
            this.bill_staff.TabIndex = 28;
            this.bill_staff.Text = "Chưa có";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(14, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Người lập:";
            // 
            // bill_id
            // 
            this.bill_id.AutoSize = true;
            this.bill_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_id.Location = new System.Drawing.Point(104, 10);
            this.bill_id.Name = "bill_id";
            this.bill_id.Size = new System.Drawing.Size(64, 18);
            this.bill_id.TabIndex = 26;
            this.bill_id.Text = "Chưa có";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Danh sách hóa đơn";
            // 
            // index
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index.DefaultCellStyle = dataGridViewCellStyle6;
            this.index.Frozen = true;
            this.index.HeaderText = "ID";
            this.index.MinimumWidth = 30;
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.index.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Loại bàn";
            this.Column1.MinimumWidth = 90;
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn5.HeaderText = "Người lập";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 140;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // condition
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition.DefaultCellStyle = dataGridViewCellStyle8;
            this.condition.HeaderText = "Giờ vào";
            this.condition.MinimumWidth = 150;
            this.condition.Name = "condition";
            this.condition.ReadOnly = true;
            this.condition.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.condition.Width = 150;
            // 
            // checkoout
            // 
            this.checkoout.HeaderText = "Giờ ra";
            this.checkoout.MinimumWidth = 150;
            this.checkoout.Name = "checkoout";
            this.checkoout.ReadOnly = true;
            this.checkoout.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkoout.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tổng thu";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(306, 89);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 20);
            this.dtp_end.TabIndex = 23;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(63, 89);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_start.TabIndex = 24;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_find.Location = new System.Drawing.Point(512, 89);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 47);
            this.btn_find.TabIndex = 25;
            this.btn_find.Text = "Tìm";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Từ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Đến";
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_all.Location = new System.Drawing.Point(593, 89);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 47);
            this.btn_all.TabIndex = 28;
            this.btn_all.Text = "Tất cả";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(58, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 31);
            this.label13.TabIndex = 29;
            this.label13.Text = "Chi tiết hóa đơn";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Tất cả",
            "Mang về",
            "Tại bàn"});
            this.cb_type.Location = new System.Drawing.Point(306, 115);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(200, 21);
            this.cb_type.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(273, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Loại";
            // 
            // lb_all
            // 
            this.lb_all.BackColor = System.Drawing.Color.Transparent;
            this.lb_all.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_all.ForeColor = System.Drawing.Color.SeaGreen;
            this.lb_all.Location = new System.Drawing.Point(424, 660);
            this.lb_all.Name = "lb_all";
            this.lb_all.Size = new System.Drawing.Size(269, 29);
            this.lb_all.TabIndex = 35;
            this.lb_all.Text = "Tổng";
            this.lb_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Statistic";
            this.Size = new System.Drawing.Size(1100, 750);
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pb_billdiscounts;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Panel pn_billdetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bill_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label bill_pay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label bill_checkin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bill_staff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bill_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label lb_all;
    }
}
