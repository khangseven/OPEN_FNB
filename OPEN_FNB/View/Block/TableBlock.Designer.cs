namespace OPEN_FNB.View.Block
{
    partial class TableBlock
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
            this.TableName = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TableName
            // 
            this.TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableName.Location = new System.Drawing.Point(3, 59);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(94, 21);
            this.TableName.TabIndex = 1;
            this.TableName.Text = "Bàn 10";
            this.TableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TableName.Click += new System.EventHandler(this.Name_Click);
            this.TableName.MouseEnter += new System.EventHandler(this.TableBlock_MouseEnter);
            this.TableName.MouseLeave += new System.EventHandler(this.TableBlock_MouseLeave);
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.ForeColor = System.Drawing.Color.Black;
            this.Type.Location = new System.Drawing.Point(3, 80);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(94, 14);
            this.Type.TabIndex = 2;
            this.Type.Text = "Bàn đôi";
            this.Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Type.Click += new System.EventHandler(this.Type_Click);
            this.Type.MouseEnter += new System.EventHandler(this.TableBlock_MouseEnter);
            this.Type.MouseLeave += new System.EventHandler(this.TableBlock_MouseLeave);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(94, 53);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            this.PictureBox.MouseEnter += new System.EventHandler(this.TableBlock_MouseEnter);
            this.PictureBox.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // TableBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Type);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.PictureBox);
            this.Name = "TableBlock";
            this.Size = new System.Drawing.Size(100, 100);
            this.Click += new System.EventHandler(this.TableBlock_Click);
            this.MouseEnter += new System.EventHandler(this.TableBlock_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TableBlock_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label TableName;
        private System.Windows.Forms.Label Type;
    }
}
