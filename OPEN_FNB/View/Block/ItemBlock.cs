using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPEN_FNB.View.Block
{
    internal class ItemBlock:Panel
    {
        public Bitmap image { get; set; }
        public string name { get; set; }
        public string info { get; set; }
        public Color backColor { get; set; }
        public Color foreColor1  { get; set; }
        public Color foreColor2 { get; set; }

        public int id;

        private PictureBox pictureBox;
        private Label lb_name;
        private Label lb_info;

        public ItemBlock(Bitmap image, string name, string info, Color back,Color fore1, Color fore2)
        {
            this.image = image;
            this.name = name;
            this.info = info;

            this.backColor = back;
            this.foreColor1 = fore1; 
            this.foreColor2 = fore2;

            this.Width = 150;
            this.Height = 190;

            this.pictureBox = new PictureBox()
            {
                Size = new Size(120,120),
                Location = new Point(15,10),
                BackgroundImage = this.image,
                BackgroundImageLayout = ImageLayout.Stretch,
            };

            this.lb_name = new Label()
            {
                Size = new Size(130, 35),
                Text = this.name,
                Location = new Point(10, 130),
                ForeColor = this.foreColor1,
                Font = new Font("Times New Roman",11),
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.lb_info = new Label()
            {
                Size = new Size(130, 15),
                Text = this.info,
                Location = new Point(10, 167),
                ForeColor = this.foreColor2,
                Font = new Font("Times New Roman", 10,FontStyle.Bold),
                TextAlign = ContentAlignment.TopCenter
            };

            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_info);

            this.BackColor = backColor;
            this.pictureBox.Click += PictureBox_Click;
            this.lb_info.Click += Lb_info_Click;
            this.lb_name.Click += Lb_name_Click;
            this.Click += ItemBlock_Click;

        }

        private void Lb_name_Click(object sender, EventArgs e)
        {
            this.OnClick(new EventArgs());
        }

        private void Lb_info_Click(object sender, EventArgs e)
        {
            this.OnClick(new EventArgs());
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            this.OnClick(new EventArgs());
        }

        private void ItemBlock_Click(object sender, EventArgs e)
        {
            //Controller.ToastController.addToast(1,"asd");
        }

        #region Stylize
        public int borderRadius = 10;
        public int borderSize = 2;
        public Color borderColor = Color.DarkCyan;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            View.Style.BorderRadius(borderSize, borderRadius, borderColor, this, e);
        }
        #endregion
    }
}
