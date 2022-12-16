using OPEN_FNB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPEN_FNB.View.Block
{
    public partial class ItemBlock_Simple : UserControl
    {
        public ItemBlock_Simple()
        {
            InitializeComponent();
        }

        public event EventHandler ItemClick;
        public virtual void OnItemClick(EventArgs e)
        {
            ItemClick?.Invoke(this, e);
        }

        public Item item;

        public ItemBlock_Simple(Bitmap img, string title, string price, Item item)
        {
            InitializeComponent();
            this.PictureBox.Image = img;
            this.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Title.Text = title;
            Price.Text = price;
            this.item = item;
        }

        private void ItemBlock_Simple_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan;
        }

        private void ItemBlock_Simple_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            OnItemClick(e);
        }

        private void ItemBlock_Simple_Load(object sender, EventArgs e)
        {
            OnItemClick(e);
        }

        private void Title_Click(object sender, EventArgs e)
        {
            OnItemClick(e);
        }

        private void Price_Click(object sender, EventArgs e)
        {
            OnItemClick(e);
        }
    }
}
