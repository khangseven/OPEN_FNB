using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPEN_FNB.K7Controls
{
    public partial class K7Message : Form
    {
        enum typeToast
        {
            info,
            complete,
            warning,
            error
        }

        enum status
        {
            starting,
            showing,
            closing
        }

        public string title { get; set; }
        public int duration { get; set; }

        private typeToast type;
        private status st;

        public bool Complete = false;

        public K7Message(int t, string message)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;

            this.title = message;

            InitializeComponent();

            this.st = status.starting;


            #region Style
            // btn_close.FlatStyle = FlatStyle.Flat;
            //btn_close.FlatAppearance.BorderSize = 0;


            type = (typeToast)(t - 1);
            Console.WriteLine(type);

            switch (type)
            {
                case typeToast.info:
                    this.BackColor = Color.DodgerBlue;
                    pictureBox.BackgroundImage = Properties.Resources.info;
                    //btn_close.BackColor = Color.DodgerBlue;
                    break;
                case typeToast.complete:
                    this.BackColor = Color.ForestGreen;
                    pictureBox.BackgroundImage = Properties.Resources._checked;
                    //btn_close.BackColor = Color.ForestGreen;
                    break;
                case typeToast.warning:
                    this.BackColor = Color.Orange;
                    pictureBox.BackgroundImage = Properties.Resources.warning;
                    //btn_close.BackColor = Color.Orange;
                    break;
                case typeToast.error:
                    this.BackColor = Color.IndianRed;
                    pictureBox.BackgroundImage = Properties.Resources.cancle;
                    //btn_close.BackColor = Color.IndianRed;
                    break;
                default:
                    break;
            }

            text.Text = message;

            label1.Text = type.ToString();

            Close.Focus();

            #endregion

            text.GotFocus += Text_GotFocus;

        }

        private void Text_GotFocus(object sender, EventArgs e)
        {
            Close.Focus();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
