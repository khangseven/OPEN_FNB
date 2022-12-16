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
    public partial class K7ToggleButton : UserControl
    {
        public bool Status;
        public string CustomOn;
        public string CustomOff;

        public event EventHandler StatusChanged;    

        public virtual void OnStatusChanged(EventArgs e)
        {
            //Console.WriteLine("click");
            StatusChanged?.Invoke(this, e);
        }

        public void setText(string on, string off)
        {
            this.CustomOff = off;
            this.CustomOn=on;
            using (Graphics g = this.CreateGraphics())
            {
                SizeF size1 = g.MeasureString(this.CustomOn,button.Font);
                SizeF size2 = g.MeasureString(this.CustomOff, button.Font);
                Console.WriteLine(size1.ToString());
                float size = size1.Width > size2.Width ? size1.Width : size2.Width;

                button.ForeColor = this.ForeColor;

                button.Width = (int)size + 18;
                this.Width = button.Width*2 + 6;

                button.Height = this.Height - 6;
                
            }

        }

        public K7ToggleButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            draw();
        }

        public void toggle()
        {
            this.Status = !this.Status;
            draw();
        }

        private void draw()
        {
            if (Status)
            {
                button.Text = CustomOn!=null ? CustomOn :"ON";
                button.Location = new Point(this.Size.Width - 3 - button.Size.Width, 3);
                this.BackColor = Color.DarkGreen;
                button.BackColor = Color.LightGreen;
            }
            else
            {
                button.Text = CustomOff != null ? CustomOff : "OFF";
                button.Location = new Point(3, 3);
                if (CustomOff != null)
                {
                    this.BackColor = Color.DarkGreen;
                    button.BackColor = Color.LightGreen;
                }
                else
                {
                    this.BackColor = Color.DarkGray;
                    button.BackColor = Color.DarkRed;
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            K7ToggleButton_Click(this,EventArgs.Empty);
        }

        private void K7ToggleButton_Click(object sender, EventArgs e)
        {
            toggle();
            this.Refresh();

            this.OnStatusChanged(EventArgs.Empty);
        }

        private void K7ToggleButton_Load(object sender, EventArgs e)
        {
            button.Font = this.Font;
        }
    }
}
