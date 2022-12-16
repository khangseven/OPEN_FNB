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
    public partial class K7Toast : Form
    {
        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

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

        private Point location;
        private int destinyHeight;
        private typeToast type;
        private status st;
        private Timer timer;
        private float timeCount;

        public bool Complete = false;

        public K7Toast(int t, string message, Point location)
        {
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;

            this.title = message;
            
            timeCount = 0;

            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.location = location;
            this.duration = 5;

            InitializeComponent();

            st = status.starting;
            this.Opacity = 0;


            #region Style
           // btn_close.FlatStyle = FlatStyle.Flat;
            //btn_close.FlatAppearance.BorderSize = 0;
            

            type = (typeToast)(t-1);
            Console.WriteLine(type);

            switch (type)
            {
                case typeToast.info:
                    this.BackColor = Color.DodgerBlue;
                    pictureBox.BackgroundImage = OPEN_FNB.Properties.Resources.info;
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

            

            #endregion
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            if (destinyHeight != this.Location.Y)
            {
                int step = 0;
                if (destinyHeight > Location.Y)
                {
                    step = Location.Y + (10 * 1);
                    if (step > destinyHeight) step = destinyHeight;
                }
                else
                {
                    step = Location.Y + (10 * -1);
                    if (step < destinyHeight) step = destinyHeight;
                }
                this.Location = new Point(this.Location.X, step);
            }

            if (st == status.starting)
            {
                start();
                timeCount += timer.Interval;
                if(Location.X < location.X)
                {
                    timeCount = 0;
                    st = status.showing;
                    this.Opacity = 1;
                }
            }else if(st == status.showing)
            {
                timeCount += timer.Interval;
                if (timeCount >= duration*1000)
                {
                    timeCount = 0;
                    st = status.closing;
                }
            }
            else if(st == status.closing)
            {
                close();
                if(this.Opacity == 0)
                {
                    this.Close();
                    Complete = true;
                }
            }

            

        }

        protected override CreateParams CreateParams
        {
            get
            {
                var Params = base.CreateParams;
                Params.ExStyle |= 0x00000080;
                return Params;
            }
        }

        void start()
        {
            this.Opacity += 0.09 ;
            Location = new Point(this.Location.X-20,this.Location.Y);
        }

        void close()
        {
            this.Opacity -= 0.1;
            Location = new Point(this.Location.X + 20, this.Location.Y);
        }

        private void K7Toast_Load(object sender, EventArgs e)
        {
            this.Location = new Point(location.X + 200,location.Y);
            destinyHeight = location.Y;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            st = status.closing;
        }

        public void forceToClose()
        {
            st = status.closing;
        }

        public void setDestinyHeight(int height)
        {
            destinyHeight = height;
        }

        private void ptn_close_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }


        private bool isClicked = false;
        private void text_Click(object sender, EventArgs e)
        {
            if (isClicked) return;
            K7Message mess = new K7Message(1 + ((int)type), title);
            mess.Show();
            isClicked = true;   
        }
    }
}
