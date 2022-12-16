namespace OPEN_FNB.View.Main
{
    partial class TableManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_tabletype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_idtype = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_updatet = new System.Windows.Forms.Button();
            this.btn_deletet = new System.Windows.Forms.Button();
            this.btn_addt = new System.Windows.Forms.Button();
            this.lb_nametype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_tabletype = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabletype)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.dgv_table);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.cb_tabletype);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(100, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 550);
            this.panel1.TabIndex = 0;
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToResizeColumns = false;
            this.dgv_table.AllowUserToResizeRows = false;
            this.dgv_table.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.type});
            this.dgv_table.Location = new System.Drawing.Point(3, 110);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_table.Size = new System.Drawing.Size(441, 290);
            this.dgv_table.TabIndex = 20;
            this.dgv_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên loại bàn";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 241;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 241;
            // 
            // type
            // 
            this.type.Frozen = true;
            this.type.HeaderText = "Loại";
            this.type.MinimumWidth = 100;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(107, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "(* Bàn sẽ được thêm với loại bàn được chọn ở trên)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(196, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(294, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(95, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Thêm mới";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_tabletype
            // 
            this.cb_tabletype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tabletype.FormattingEnabled = true;
            this.cb_tabletype.Location = new System.Drawing.Point(254, 412);
            this.cb_tabletype.Name = "cb_tabletype";
            this.cb_tabletype.Size = new System.Drawing.Size(141, 21);
            this.cb_tabletype.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(184, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Loại bàn:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(118, 414);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(55, 20);
            this.tb_id.TabIndex = 13;
            this.tb_id.Text = "_";
            this.tb_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(34, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "ID loại bàn";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(121, 451);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(274, 20);
            this.tb_name.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(34, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tên loại bàn";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Danh sách bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(152, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý bàn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.lb_idtype);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_updatet);
            this.panel2.Controls.Add(this.btn_deletet);
            this.panel2.Controls.Add(this.btn_addt);
            this.panel2.Controls.Add(this.lb_nametype);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgv_tabletype);
            this.panel2.Location = new System.Drawing.Point(650, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 550);
            this.panel2.TabIndex = 1;
            // 
            // lb_idtype
            // 
            this.lb_idtype.Location = new System.Drawing.Point(128, 414);
            this.lb_idtype.Name = "lb_idtype";
            this.lb_idtype.Size = new System.Drawing.Size(81, 20);
            this.lb_idtype.TabIndex = 9;
            this.lb_idtype.Text = "_";
            this.lb_idtype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(44, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID loại bàn";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách loại bàn";
            // 
            // btn_updatet
            // 
            this.btn_updatet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_updatet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatet.Location = new System.Drawing.Point(144, 489);
            this.btn_updatet.Name = "btn_updatet";
            this.btn_updatet.Size = new System.Drawing.Size(75, 23);
            this.btn_updatet.TabIndex = 7;
            this.btn_updatet.Text = "Cập nhật";
            this.btn_updatet.UseVisualStyleBackColor = false;
            this.btn_updatet.Click += new System.EventHandler(this.btn_updatet_Click);
            // 
            // btn_deletet
            // 
            this.btn_deletet.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_deletet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletet.Location = new System.Drawing.Point(242, 489);
            this.btn_deletet.Name = "btn_deletet";
            this.btn_deletet.Size = new System.Drawing.Size(75, 23);
            this.btn_deletet.TabIndex = 6;
            this.btn_deletet.Text = "Xóa";
            this.btn_deletet.UseVisualStyleBackColor = false;
            this.btn_deletet.Click += new System.EventHandler(this.btn_deletet_Click);
            // 
            // btn_addt
            // 
            this.btn_addt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_addt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addt.Location = new System.Drawing.Point(43, 489);
            this.btn_addt.Name = "btn_addt";
            this.btn_addt.Size = new System.Drawing.Size(75, 23);
            this.btn_addt.TabIndex = 5;
            this.btn_addt.Text = "Thêm mới";
            this.btn_addt.UseVisualStyleBackColor = false;
            this.btn_addt.Click += new System.EventHandler(this.btn_addt_Click);
            // 
            // lb_nametype
            // 
            this.lb_nametype.Location = new System.Drawing.Point(131, 451);
            this.lb_nametype.Name = "lb_nametype";
            this.lb_nametype.Size = new System.Drawing.Size(180, 20);
            this.lb_nametype.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(44, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên loại bàn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quản lý loại bàn";
            // 
            // dgv_tabletype
            // 
            this.dgv_tabletype.AllowUserToResizeColumns = false;
            this.dgv_tabletype.AllowUserToResizeRows = false;
            this.dgv_tabletype.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgv_tabletype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_tabletype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dgv_tabletype.Location = new System.Drawing.Point(3, 110);
            this.dgv_tabletype.Name = "dgv_tabletype";
            this.dgv_tabletype.RowHeadersVisible = false;
            this.dgv_tabletype.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabletype.Size = new System.Drawing.Size(344, 290);
            this.dgv_tabletype.TabIndex = 1;
            this.dgv_tabletype.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabletype_CellContentClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Tên loại bàn";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::OPEN_FNB.Properties.Resources.background2;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "TableManager";
            this.Size = new System.Drawing.Size(1100, 750);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabletype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_updatet;
        private System.Windows.Forms.Button btn_deletet;
        private System.Windows.Forms.Button btn_addt;
        private System.Windows.Forms.TextBox lb_nametype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_tabletype;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label lb_idtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cb_tabletype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tb_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}
