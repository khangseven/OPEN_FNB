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
using IronBarCode;

namespace OPEN_FNB.View.Main
{
    public partial class Main : Form
    {
        public User user;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var itemManager = new Selling()
            {
                TopLevel = false,
                user = this.user,
                refresh = refresh
            };
            panel1.Controls.Add(itemManager);
            itemManager.Show();

            lb_day.Text = DateTime.Now.ToString("dddd, dd/MM/yyy");
            lb_uname.Text = "Người dùng: " + user.name;
        }

        bool isOpen = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (user.id != 1)
            {
                MessageBox.Show("Chỉ có admin mới có thể truy cập vào chức năng này!");
                return;
            }
            if (isOpen)
            {
                MessageBox.Show("Đang mở!");
                return;
            }
            var ma = new Manager();
            ma.Show();
            isOpen = true;

            ma.FormClosed += (s, ex) =>
            {
                isOpen = false;
                Main_Load(null, null);
            };
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var itemManager = new Selling()
            {
                TopLevel = false,
                user = this.user,
                refresh = this.refresh
            };
            panel1.Controls.Add(itemManager);
            itemManager.Show();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var itemManager = new Statistic()
            {
                
            };
            panel1.Controls.Add(itemManager);
            itemManager.Show();
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var itemManager = new Chart()
            {

            };
            panel1.Controls.Add(itemManager);
            itemManager.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var rs = MessageBox.Show("Đóng ứng dụng?", "Chú ý", MessageBoxButtons.YesNo);
            if (rs != DialogResult.Yes)
                e.Cancel = true;
        }


        bool isShow = false;
        private void button2_Click(object sender, EventArgs e)
        {
            /*if (isShow)
            {
                isShow = false;
                pictureBox1.Image = Properties.Resources.logo;

            }
            else
            {
                isShow = true;
                string ip = new Server().GetLocalIPAddress().ToString();
                pictureBox1.Image = QRCodeWriter.CreateQrCode(ip,220, QRCodeWriter.QrErrorCorrectionLevel.Medium).ToImage();
                MessageBox.Show(ip);
            }*/

            new Block.QRSHOW().Show();
                
        }

        public void refresh()
        {
            btn_home_Click(null, null);
        }
    }
}
