namespace OPEN_FNB.View.Block
{
    partial class ItemBlock_Simple
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(10, 10);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(130, 100);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            this.PictureBox.MouseEnter += new System.EventHandler(this.ItemBlock_Simple_MouseEnter);
            this.PictureBox.MouseLeave += new System.EventHandler(this.ItemBlock_Simple_MouseLeave);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(10, 114);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(130, 31);
            this.Title.TabIndex = 1;
            this.Title.Text = "Trà sữa chân châu đường đen không đường";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            this.Title.MouseEnter += new System.EventHandler(this.ItemBlock_Simple_MouseEnter);
            this.Title.MouseLeave += new System.EventHandler(this.ItemBlock_Simple_MouseLeave);
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.OrangeRed;
            this.Price.Location = new System.Drawing.Point(4, 147);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(143, 14);
            this.Price.TabIndex = 2;
            this.Price.Text = "30.000 VND";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Price.Click += new System.EventHandler(this.Price_Click);
            this.Price.MouseEnter += new System.EventHandler(this.ItemBlock_Simple_MouseEnter);
            this.Price.MouseLeave += new System.EventHandler(this.ItemBlock_Simple_MouseLeave);
            // 
            // ItemBlock_Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.PictureBox);
            this.Name = "ItemBlock_Simple";
            this.Size = new System.Drawing.Size(150, 170);
            this.Load += new System.EventHandler(this.ItemBlock_Simple_Load);
            this.MouseEnter += new System.EventHandler(this.ItemBlock_Simple_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ItemBlock_Simple_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Price;
    }
}
