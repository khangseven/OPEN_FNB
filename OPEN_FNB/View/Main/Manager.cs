using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPEN_FNB.View.Main
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            
             


        }

        private void Manager_Load(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            var item = new ItemManager()
            {
                TopLevel = false,
                Location = new Point(0, 0)
            };
            panel.Controls.Add(item);
            item.Show();
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            var item = new ItemManager()
            {
                TopLevel = false, Location = new Point(0, 0)
            };
            panel.Controls.Add(item);
            item.Show();
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            var item = new TableManager()
            {
                //TopLevel = false, Location = new Point(0, 0)
            };
            panel.Controls.Add(item);
            item.Show();
        }

        private void btn_id_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            var item = new ItemDiscountManager()
            {
                //TopLevel = false, Location = new Point(0, 0)
            };
            panel.Controls.Add(item);
            item.Show();
        }

        private void btn_bd_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            var item = new BillDiscountManager()
            {
                TopLevel = false, Location = new Point(0, 0)
            };
            panel.Controls.Add(item);
            item.Show();
        }

        private void btn_nv_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            var item = new UserManager()
            {
                //TopLevel = false, Location = new Point(0, 0)
            };
            panel.Controls.Add(item);
            item.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
