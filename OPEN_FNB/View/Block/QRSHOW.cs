using IronBarCode;
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
    public partial class QRSHOW : Form
    {
        public QRSHOW()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QRSHOW_Load(object sender, EventArgs e)
        {
            List<string> list = new Server().GetAllLocalIPAddress();
            if( list==null || list.Count == 0)
            {
                MessageBox.Show("Không tìm thấy mạng");
                this.Close();
            }
            else
            {
                comboBox1.Items.Clear();
                list.ForEach(s =>
                {
                    comboBox1.Items.Add(s);
                });
                comboBox1.SelectedIndex = 0;
                comboBox1_SelectedIndexChanged(null,null);
            }
            //
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = QRCodeWriter.CreateQrCode((string)comboBox1.SelectedItem, 300, QRCodeWriter.QrErrorCorrectionLevel.Medium).ToImage();
        }
    }
}
