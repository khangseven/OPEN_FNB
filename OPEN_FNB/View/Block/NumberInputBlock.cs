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
    public partial class NumberInputBlock : Form
    {
        public NumberInputBlock()
        {
            InitializeComponent();
        }
        public NumberInputBlock(int n,string t)
        {
            InitializeComponent();
            if(t!=null) title.Text = t;
            this.Number = n;
            numericUpDown1.Value = n;
        }
        public NumberInputBlock(int min, int max, string t)
        {
            InitializeComponent();
            if (t != null) title.Text = t;
            this.Number = min;
            numericUpDown1.Value = min;
            numericUpDown1.Minimum = min;
            numericUpDown1.Maximum = max;
        }

        public int Number { get; set; } 

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Number =(int) numericUpDown1.Value;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            Number = 0;
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Number = (int)numericUpDown1.Value;
        }
    }
}
